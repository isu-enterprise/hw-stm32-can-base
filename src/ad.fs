
\ TRY to control AD76330 via SPI1 and PIN14,PIN15 of GPIOC

\ USES 00-mmap.fs, spi.fs

\ forgetram

compiletoflash

: spi1-pin-conf# ( pin -- )
  >r
  GPIOA r@ %10 gpio-mode!   \ Alternate Function
  GPIOA r@ %11 gpio-ospeed! \ HUIGH SPEED
  GPIOA r@ %00 gpio-pupd!   \ NO-PULL
  GPIOA r@ 5   gpio-af!     \ 5 = SPI Altern.funct. on port A
  rdrop
;

: gpioc-pin-conf# ( pin -- )
  $2 $1 rcc-en!             \ ENABLE CLK on port C
  >r
  GPIOC r@ %01 gpio-mode!   \ OUTPUT
  GPIOC r@ %00 gpio-ospeed! \ LOW SPEED
  GPIOC r@ %0  gpio-otype!  \ PUSH/PULL
  GPIOC r@ %00 gpio-pupd!   \ NO PULL-UP/DN
  rdrop
;

13 constant LED.PIN
14 constant RESET.PIN
15 constant SE.PIN
GPIOC constant ADIO

: gpioc-setup-ad
  LED.PIN   gpioc-pin-conf#        \ the LED for debugging
  ADIO LED.PIN 1 gpio-bsr!      \ Turn off LED
  RESET.PIN gpioc-pin-conf#        \ the ~RESET (FL0) of AD
  ADIO RESET.PIN 0 gpio-bsr!    \ ~RESET==0, i.e. SET TO RESET
  SE.PIN    gpioc-pin-conf#        \ the SE (FL1) of AD
  ADIO SE.PIN 0 gpio-bsr!       \ Set SE to 0, i.e. Chip is not SELECTED
;

: a. GPIOA GPIO. ;
: b. GPIOB GPIO. ;
: c. GPIOC GPIO. ;

: spi1-gpio-setup
  $0 $1 rcc-en!        \ Enable CLK Enable on port 0 = A
  4 spi1-pin-conf#
  5 spi1-pin-conf#
  6 spi1-pin-conf#
  7 spi1-pin-conf#
;

: spi1-setup-ad ( -- )
  gpioc-setup-ad     \ Setup GPIOC pins to control AD
  spi1-gpio-setup    \ Setup functions on GPIOA pins, enable CLK on GPIOA
  1 spi1-en!         \ Enable CLK on SPI1 peripheral
  SPI1
  dup SPI.CR1
    dup 1 6 lshift swap bic!   \ ~SPE, SPI Enable
    dup 1 11 lshift swap bis!  \ 16 bit data frame

    \ dup 1 lshift 9 bic! \ Software management disabled (if ~TI)
    \ dup 1 lshift 7 bic! \ 0 - MSBFIRST, 1 - LSBFIRST (if ~TI)
    \ dup 1 lshift 1 bic! \ CPOL (if ~TI)
    \ dup 1 lshift 0 bis! \ CPHA = 0, L=1  ---\_/-\_/-.....---- SCK \  (if ~TI)
                          \ CPHA = 1, L=0  _/-\_/-\_/-.....---- SCK \

    dup 1 2 lshift swap bic!   \ MSTR, SLAVE mode SPI
    drop
  dup SPI.CR2
    dup 1 4 lshift swap bis!   \ FRF (Frame format) TI mode (seems OK for AD)
    drop
  drop
;

0 variable ad.init

: init-ad
  ad.init @ if exit then \ Already initialized
  spi1-setup-ad
  1 ad.init !
  \ SPI1 SPI.
;

: deinit-ad
  0 spi1-en!  \ Disable CLK on SPI1
  0 ad.init !
;


: led-on  GPIOC LED.PIN 0 gpio-bsr! ;
: led-off GPIOC LED.PIN 1 gpio-bsr! ;

: ad-reset
  ADIO RESET.PIN 0 gpio-bsr!
  ADIO SE.PIN 0 gpio-bsr!
;

: ad-se-on
  ADIO SE.PIN 1 gpio-bsr!
;

: ad-on
  ADIO RESET.PIN 1 gpio-bsr!
  ad-se-on
;

: ad-off
  ADIO SE.PIN 0 gpio-bsr!
;

: ad-start-comm \ Starts communication with AD
  init-ad
  led-off
  SPI1 1 spi-enable!
;

: ad-stop-comm \ Terminates communications
  SPI1 0 spi-enable!
;

: ad.
  SPI1 SPI.SR.
;


: ad@
  SPI1 spi@
;

: ad! ( n -- )
  SPI1 spi!
;

: ad? ( -- 0 ) \ Are there data?
  SPI1 spi-rxne?
;

: delay1
  500000 0 do loop
;

: ad-wait-comm
  begin
    SPI1 spi-busy? key? or
  until
;

: >ad> ( cmd -- resp )
  ad-wait-comm
  begin
    SPI1 spi-txe? until
  ad!
  ad-wait-comm
  ad? if ad@ else ." >ad> NO DATA" ad@ then
;

\ Sample one
: ad>? ( -- s1 key? )
  ad-wait-comm
  begin
    ad? key? or until
  ad? if ad@ 1
      else
        0 0
      then
;


0 variable dtick
10 variable ad.tries

%000 constant AD.CRA
%001 constant AD.CRB
%010 constant AD.CRC
%011 constant AD.CRD
%100 constant AD.CRE
%101 constant AD.CRF
%110 constant AD.CRG
%111 constant AD.CRH


: ad-cmd ( c/~d r/~w dev/3 reg/3 data/8 -- cmd/16 )
  swap 8 lshift or
  swap 11 lshift or
  swap 14 lshift or
  swap 15 lshift or
;

: ad-reg#. ( index -- )  \ Prints AD.REG
  ." AD.CR" 65 + emit
;

: ad-reg. ( cmd -- ) \
  dup 1 15 lshift and if ." C" else ." D" then
  dup 1 14 lshift and if ." R" else ." W" then
  space
  dup 7 11 lshift and 11 rshift ." DEV:" .
  dup 7 8 lshift and 8 rshift   ." REG:" ad-reg#. space
  $000000FF and dup hex. binary . decimal
  \ cr
;

: ad-power-on-cmd ( -- cmd/16 )
  1 0 000 AD.CRC %10000110
  ad-cmd
;

: ad-clock-set-cmd ( CEE/1 MCD/3 SCD/2 DR/2 -- cmd )
  \ Data 8 bit
  \ DR
  swap 2 lshift or \ SCD
  swap 4 lshift or \ MCD
  swap 7 lshift or \ CEE
  >r
  1 0 000 AD.CRB
  r>
  .s
  ad-cmd
;

: ad-init-seq1 ( -- SEQ n )
  \ Returns n - number of commands
  \ commands in direct order (not reverse)

  %1000000010000000 \ Reset AD -> Program MODE
  %1000000000000000 \ ~Reset
  %1000000101000000 \ MCD = %100 = 4 DIVIDER
  %1000001001100001 \ GPU = 1 REFPOWER=1 REFOUT=1
  %1000001100000000 \ GAINS=0 POWER=0 inputs 1-2
  %1000010000000000 \ .... 3-4
  %1000010100000000 \ .... 5-6
  %1000011010111111 \ RMOD = 0 CH1..6 = 1 (SELECT)
  %1000011100000000 \ .... CH1..6 = 0 ?
  %1000000000000001 \ Data MODE
  10 \ No of commands
;

\ Print non-destructively the SEQ in right order
0 variable seq-max
: ad-seq. ( SEQ n -- )
  cr
  seq-max ! \ Save n
  seq-max @ 0 do seq-max @ 1- i - pick dup binary . decimal ad-reg. cr loop
  seq-max @ \ Restore n
;

: ad-seq! ( SEQ n -- )
  ad-reset \ Go Program mode
  delay1
  ad-on

  seq-max ! \ Save n
  seq-max @ 0 do seq-max @ 1- i - pick >ad> ." R:" ad-reg. cr loop
  seq-max @ 0 do drop loop \ clean stack out of commans
  seq-max @ \ Restore n
;

\ Initialize interfaces and fill in registers, start samling
: ad-init
  ad-start-comm
  delay1
  ad-on
  ad-init-seq1
  ad-seq!
  0 >ad> drop
;

: ad-deinit
  ad-reset
;

: ad-sample-6 ( -- n1 n2 ... n6 6 )
  6 0 do ad>? drop loop
  6
;

: ad-sample. ( n1 .. n6 6 -- n1 .. n6 6 )
  0 do hex. loop
;

: ad-loop
  begin
    ad-sample-6 ad-sample. cr
    key? until
;


: ad-test
  cr
  ad-init
  led-on
  100 ad.tries !
  0 dtick !
  \ ad-wait-data
  begin
    ad.tries @
    \ dup 0= if
    \   drop
    \   leave
    \ then
    1- ad.tries !

    ad-wait-comm
    ad? if
      ad@ .
    else
      dtick @ dup .
      1+ dtick !
      ." NO DATA"
    then
    cr
    ad.tries @ 0= key? or until
  led-off
  ad-deinit
  \ ad-stop-comm \ FIXME: hangs USART2
;

: t ad-test ;
: l ad-init ad-loop ;

compiletoram
