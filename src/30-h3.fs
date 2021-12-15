\ Connect to Orange Pi PC h3 via SPI2
\ SPI2 salve mode for STM

\ USES 00-mmap.fs, spi.fs

\ 2020-07-13

forgetram

\ compiletoflash
compiletoram

GPIOB constant GPIO.SPI2

: spi2-pin-conf# ( pin -- )
  >r
  GPIO.SPI2 r@ %10 gpio-mode!   \ Alternate Function
  GPIO.SPI2 r@ %11 gpio-ospeed! \ HUIGH SPEED
  GPIO.SPI2 r@ %00 gpio-pupd!   \ NO-PULL
  GPIO.SPI2 r@ 5   gpio-af!     \ 5 = SPI Altern.funct. on port A
  rdrop
;

: a. GPIOA GPIO. ;
: b. GPIOB GPIO. ;
: c. GPIOC GPIO. ;

: spi2-gpio-setup
  $1 $1 rcc-en!        \ Enable CLK Enable on port $1 = B
  12 spi2-pin-conf#
  13 spi2-pin-conf#
  14 spi2-pin-conf#
  15 spi2-pin-conf#
;

: rcc-spi2-enable! ( bool -- )  \ TODO: Check in 25-spi.fs
  RCC RCC.APB1ENR swap \ addr bool
  true 14 lshift \ addr bool mask
  -rot \ mask addr bool
  if
    bis!
  else
    bic!
  then
;

: spi2-setup-h3 ( -- )
  \ gpioc-setup-ad     \ Setup GPIOC pins to control AD
  spi2-gpio-setup    \ Setup functions on GPIO.SPI2 pins, enable CLK on GPIO.SPI2
  true rcc-spi2-enable! \ Enable CLK on SPI2 peripheral
  SPI2
  dup SPI.CR1
    dup 1 6 lshift swap bic!   \ ~SPE, SPI Enable
    dup 1 11 lshift swap bic!  \ 8 bit data frame

    dup 1 9 lshift swap bic! \ Software management disabled (if ~TI)
    dup 1 7 lshift swap bic! \ 0 - MSBFIRST, 1 - LSBFIRST (if ~TI)
    dup 1 1 lshift swap bic! \ CPOL (if ~TI)
    dup 1 0 lshift swap bic! \ CPHA = 0, L=0  ---\_/-\_/-.....---- SCK \  (if ~TI)
                          \ CPHA = 0, L=0  _/-\_/-\_/-.....---- SCK \

    dup 1 2 lshift swap bic!   \ MSTR, SLAVE mode SPI
    drop
  dup SPI.CR2
    dup 1 4 lshift swap bic!   \ FRF (Frame format) NO TI mode
    drop
  drop
;

: spi-enable! ( SPIa bool -- )
  swap SPI.CR1 swap
  \ DMA?
  if
    \ %111 5 lshift r@ SPI.CR2 bis! \ enable interrupts
    1 6 lshift swap bis! \ enable
  else
    \ spi-wait
    1 6 lshift swap bic! \ disable
    \ %111 5 lshift r@ SPI.CR2 bic! \ disable interrupts
  then
;

: h3-enable! ( bool -- )
  SPI2 swap spi-enable!
;

: h3.
  SPI2 SPI.SR.
;

: h3@
  SPI2 spi@
;

: h3! ( n -- )
  SPI2 spi!
;

: h3? ( -- 0 ) \ Are there data?
  SPI2 spi-rxne?
;

: h3-wait-comm
  begin
    SPI2 spi-busy? key? or
  until
;

: >h3> ( cmd -- resp )
  h3-wait-comm
  begin
    SPI3 spi-txe? until
  h3!
  h3-wait-comm
  h3? if h3@ else ." >h3> NO DATA" h3@ then
;

: SPI2. ( -- )
  SPI2
  cr
  dup ." SPI Base addres is " hex. cr
  dup SPI.CR1.
  dup SPI.CR2.
  dup SPI.SR.
  dup SPI.DR.
  dup SPI.CRCPR.
  dup SPI.RXCRCR.
  dup SPI.TXCRCR.
  dup SPI.I2SCFGR.
  dup SPI.I2SPR.
  drop
;


: init-h3
  spi2-setup-h3
  true h3-enable!
;


: t
  init-h3

  begin
    h3?
    if
       h3@ hex. space
    else
       \ 42 emit
    then
  key? until
;

\ Temporal buffer
create CBUF 1024 allot

: h3-buf-receive ( abuf n -- )
  \ Receive n bytes via SPI2 into abuf
  0 ?do
    begin
    h3? until
    h3@ \ abuf val
    over \ abuf val abuf
    !
    1+
  loop
  drop \ abuf
;

: h3-buf. ( abuf n -- )
  0 ?do
    dup c@ hex.
    1+
  loop
  drop
;

: tttt
  CBUF 20 h3-buf.
;
