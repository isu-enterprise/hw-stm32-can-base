\ USES 01-display.fs
\ USES 00-mmap.fs

forgetram

\ ### Управление Экраном ILI9488

\  - SPI3 PB5,4,3,PA16
\  - I2C1 SDA1=PB7, SCL1=PB6

\  - CS=PB10, RS=PB2, WR=PB1, RD=PB0:    RST->RESET

\ PB
GPIOB constant TFT.PORT
10 constant TFT.CS
2  constant TFT.RS
1  constant TFT.WR
0  constant TFT.RD

: tft-pin-setup# ( pin -- )
  >r
  TFT.PORT r@ %01 gpio-mode!   \ OUTPUT
  TFT.PORT r@ %0 gpio-otype!   \ OUTPUT Push-pull
  TFT.PORT r@ %00 gpio-pupd!   \ OUTPUT Push-pull
  TFT.PORT r@ %00 gpio-ospeed! \ OUTPUT Low Speed
  rdrop
;

: tft-init-gpio ( -- )
  \ All pins are IO, PP, low speed
  1 1 rcc-en! \ CLK on GPIOB == GPIO1

  TFT.CS tft-pin-setup#
  TFT.RS tft-pin-setup#
  TFT.WR tft-pin-setup#
  TFT.RD tft-pin-setup#

;


: i2c-pin-config# ( GPIOa pin af -- )
  swap >r \ GPIOa af
  over r@ %10 gpio-mode!     \ Alternate function
  over swap r@ swap gpio-af! \ Function no
  over r@ %11 gpio-ospeed!   \ Fast
  dup  r@ 0 gpio-otype!      \ Analog?
  dup  r@ 0 gpio-pupd!       \ No push-pull
  drop  \ GPIOa
  rdrop \ pin no
;


$40005400 constant I2C1
$40005800 constant I2C2
$40005C00 constant I2C3

: I2C.CR1 ( I2Ca -- I2Ca.CR1 ) ; \ Control REg 1
: I2C.CR2 4 + ; \ Control reg 2
: I2C.OAR1 8 + ; \ Own address register
: I2C.OAR2 $0c + ;
: I2C.DR $10 + ; \ Data register
: I2C.SR1 $14 + ; \ Status register 1
: I2C.SR2 $18 + ; \ Status register 2
: I2C.CCR $1C + ; \ CLock control register
: I2C.TRISE $20 + ; \ Raise time
: I2C.FLTR $24 + ;  \ Set analog and digital filters

: I2C.CR1. ( I2Ca -- ) ." I2C1-CR1 (read-write) $" I2C.CR1 @1b. ;
: I2C.CR2. ." I2C1-CR2 (read-write) $" I2C.CR2 @1b. ;
: I2C.OAR1. ." I2C1-OAR1 (read-write) $" I2C.OAR1 @1b. ;
: I2C.OAR2. ." I2C1-OAR2 (read-write) $" I2C.OAR2 @1b. ;
: I2C.DR. ." I2C1-DR (read-write) $" I2C.DR @1b. ;
: I2C.SR1. ." I2C1-SR1 () $" I2C.SR1 @1b. ;
: I2C.SR2. ." I2C1-SR2 (read-only) $" I2C.SR2 @1b. ;
: I2C.CCR. ." I2C1-CCR (read-write) $" I2C.CCR @1b. ;
: I2C.TRISE. ." I2C1-TRISE (read-write) $" I2C.TRISE @1b. ;

: I2C. ( I2Ca -- )
dup I2C.CR1.
dup I2C.CR2.
dup I2C.OAR1.
dup I2C.OAR2.
dup I2C.DR.
dup I2C.SR1.
dup I2C.SR2.
dup I2C.CCR.
dup I2C.TRISE.
;



\ 1. I2C1.CR2 pp input clock 2, 4 mhz
\ 2. Conf Clock control registerS
\ 3. Configure rise time register
\ 4. Enable peripheral in I2C.CR1
\ 5. SET Start bit in I2C_CR1 .... to generate start cond.
\ 6.


: i2c1-gpio-init ( -- )
  \ CLK on I2C1 peripheral
  \ By default it is in slave mode
  RCC RCC.APB1ENR 1 21 lshift swap bis! \ OK!
  GPIOB \ PB7-SDA1, PB6-SCL1
  dup 6 4 i2c-pin-config# \ AF = 4 for PB6,7 = I2C
  dup 7 4 i2c-pin-config#
  drop \ GPIOB
;

: i2c-enable! ( I2Ca 1/0 -- )
  swap I2C.CR1 swap if
    1 swap bis!
  else
    1 swap bic!
  then
;

: i2c-fast! ( I2Ca 1/0 -- )
  swap I2C.CCR swap
  if
    1 15 lshift swap bis!
  else
    1 15 lshift swap bic!
  then
;

: i2c-init ( I2Ca  -- )
  \ Before configuring the interface must be disabled
  dup 0 i2c-enable! \ In case of RE-initialization
  \ Set to 2 Mhz peripheral clock
  16 over I2C.CR2 bis! \ 16 Mhz ARB channel
  \ Set to 2 Mhz input clock
  1 10 lshift over I2C.CR1 bis! \ Enable acknowledgement
  dup 0 i2c-fast!  \ Slow Mode

  \ http://fastbitlab.com/stm32-i2c-lecture-12-i2c-serial-clock-settings-with-explanations/
  \ $50 over I2C.CCR bis! \ 100Khz on 16Mhz 10uS period = #80
  $50 4 * over I2C.CCR bis! \ 25Khz on 16Mhz 10uS period = #80
  \ TRISE register
  16 over I2C.TRISE bis! \ 1000 ns/63 ns (1/16Mhz CLOCK)

  \ enable interface
  \ Last instruction, must be
  1 i2c-enable!
;

: i2c-txe? ( I2Ca -- n )
  I2C.SR1 1 7 lshift and
;

: i2c-rne? ( I2Ca -- n )
  I2C.SR1 1 6 lshift and
;

: i2c-stopf? ( I2Ca -- n ) \ Stop detected
  I2C.SR1 1 4 lshift and
;

: i2c-btf? ( I2Ca -- n ) \ Bye transfer finished
  I2C.SR1 1 2 lshift and
;

: i2c-addr? ( I2Ca -- n ) \ Address sent/correct
  I2C.SR1 1 1 lshift and
;

: i2c-sb? ( I2Ca -- n ) \ Start bit detected in master
  I2C.SR1 1 or
;

: i2c-af? ( I2Ca -- n ) \ Acknowledge failure
  I2C.SR1 1 10 lshift and
;

: i2c-busy? ( I2Ca -- n) \ Busy flag
  I2C.SR2 1 1 lshift and
;

: i2c-start ( I2Ca -- ) \ Generate start condition
  dup I2C.CR1 1 8 lshift swap bis!
;

: i2c-stop ( I2Ca -- ) \ Generate stop condition
  \ begin
  \   ." stopping: txe "
  \   dup i2c-txe? until
  \ begin
  \   ." stopping: btf "
  \   dup i2c-btf? until
  I2C.CR1 1 9 lshift swap bis!
;

: i2c-wait-comm ( I2Ca -- )
  begin
    \ dup i2c-busy? if ." b" then
    dup i2c-busy? not key? or until
  drop
;

\ Data register manipulation
: i2c! ( c I2Ca -- )
  I2C.DR !
;

: i2c@ ( I2Ca -- )
  I2C.DR @
;

: i2c-addr! ( I2Ca addr mode -- cond? )
  rot \ i2c-appl-addr mode I2Ca
  begin
    ." EV5 "
    dup i2c-sb? until \ EV5, wait for SB==1 flag
  -rot
  swap 1 lshift or \ The first byte (Address+mode0)
  swap i2c!        \ EV5 cleared
;


%0100011 constant EXT.ADDR \ Must be 1-lshifted
%0000001 constant EXT.RD   \ LSB of the first byte
%0000000 constant EXT.WR

: ext-read ( I2Ca -- pins ok? )
  dup i2c-start
  dup EXT.ADDR EXT.RD i2c-addr!
  begin
    ." EV6 "
    dup i2c-addr? key? or until \ EV6 wait for ADDR flag==1
  dup i2c-wait-comm     \ EV6 cleared now
  dup i2c-af?
     dup if ." FAILURE!" else ." ACK!" then cr
     if
       i2c-stop
       0 0
     else
       \ Wait ... until ...
       dup i2c@
       swap i2c-stop
       1
     then
;

: ext-write ( I2Ca -- pins )
  >r \ Save data
  dup i2c-start
  dup EXT.ADDR EXT.WR i2c-addr!
  begin
    ." EV6 "
    dup i2c-addr? key? or until \ EV6 wait for ADDR flag==1
  dup i2c-wait-comm     \ EV6 cleared now
  dup i2c-af?
     dup if ." FAILURE!" else ." ACK!" then cr
     if
       i2c-stop
       rdrop
       0
     else
       \ Wait ... until ...
       dup r> swap i2c!
       i2c-stop
       1
     then
;

: tft-init ( -- )
  tft-init-gpio
  i2c1-gpio-init
  I2C1 i2c-init
;

: tt ( -- )
  tft-init
  I2C1 h.s
  dup $FF ext-write hex. h.s cr \ Print condition
  dup $FF ext-write hex. h.s cr
  dup $FF ext-write hex. h.s cr
  dup $FF ext-write hex. h.s cr
  drop
;
