
\ forgetram
compiletoflash

\ Controlling 74LS535 over SPI3
\ USES spi.fs

GPIOA constant REG.PORT
0 constant REG.OE.PIN \ PA0
$f constant REG.NSS.PIN   \ PA15

: reg-pin-conf# ( GPIOa pin -- )
  >r
  dup r@ %01 gpio-mode!   \ OUTPUT
  dup r@ %0 gpio-otype!   \ OUTPUT Push-pull
  dup r@ %00 gpio-pupd!   \ OUTPUT Push-pull
      r> %00 gpio-ospeed! \ OUTPUT Low Speed
;


: reg-conn ( -- ) \ Connect Qx to output
  GPIOA REG.OE.PIN 0 gpio-bsr!
;

: reg-disconn ( -- ) \ DisConnect Qx from output, go Z
  GPIOA REG.OE.PIN 1 gpio-bsr!
;

: reg-init-gpio
  %0 %1 rcc-en!        \ Enable CLK Enable on port 0 = A
  GPIOA REG.OE.PIN reg-pin-conf#
  GPIOA REG.NSS.PIN reg-pin-conf#
  reg-disconn \ Raise to shift to Zstate
;


: spi3-pin-conf# ( GPIOa pin af -- )
  swap
  >r   \ GPIOa af
  over r@ %10 gpio-mode!   \ Alternate Function
  over r@ %11 gpio-ospeed! \ HUIGH SPEED
  over r@ %00 gpio-pupd!   \ NO-PULL
  r>   \ GPIOa af pin
  swap   gpio-af!     \ 8 on PB = SPI Altern.funct. on port A
;

: reg-init-spi3-gpio ( -- )
  %1 %1 rcc-en!        \ Enable CLK Enable on port 1 = B
  GPIOB
  dup 5 6 spi3-pin-conf#
  dup 4 6 spi3-pin-conf#
      3 6 spi3-pin-conf#
;

: reg-nss ( -- ) \ Command Start condition
  GPIOA REG.NSS.PIN 0 gpio-bsr!
;

: -reg-nss ( -- ) \ Command Stop condition
  GPIOA REG.NSS.PIN 1 gpio-bsr!
;


: rcc-spi3-enable! ( bool -- )
  RCC RCC.APB1ENR swap \ addr bool
  1 15 lshift \ addr bool mask
  -rot \ mask addr bool
  if
    bis!
  else
    bic!
  then
;

: reg-init-spi ( -- )
  reg-init-spi3-gpio
  true rcc-spi3-enable! \ ENABLE CLK in order to allow configuration
  SPI3
    \ CPOL=1 CPCHA=1 nio TI
    \ dup 0 spi-enable! \ HANGS
    dup SPI.CR2
       dup 1 4 lshift swap bic!  \ NO TI Mode
       dup %111 5 lshift swap bic! \ Disable interrupts
       dup 1 2 lshift swap bic!  \ DISABLE SSOE, we will control NSS ourselves
       dup %11 swap bic!         \ DISABLE DMA ints
       drop
    dup SPI.CR1
       dup 1 11 lshift swap bis! \ 16 bit
       dup 1 9 lshift swap bis!  \ ENABLE SSM
       dup 1 8 lshift swap bis!  \ ENABLE SSI
       dup 1 1 lshift swap bis!  \ CPOL=1
       dup 1 swap bis!           \ CPOL=1
       dup 1 2 lshift swap bis!  \ MASTER Mode !
       dup %000 3 lshift swap bis! \ Baud rate = 8/2 = 4Mhz << 100 MHz at 3.3V
       drop
    drop
;


: spi-wait-comm ( SPIa -- )
  begin
    dup spi-busy? not
  until
  drop
;

: >spi3> ( n -- n ) \ transmits byte/word and receives byte/word.
  SPI3 spi-wait-comm
  spi3!
  SPI3 spi-wait-comm
  spi3@
;


: >reg> ( word -- word )
  reg-nss
  >spi3>
  -reg-nss \ Latch
;

: reg-start ( -- ) \ Start communications
  SPI3 1 spi-enable! \ Enable SPI, NSS is controlled elsewhere
  \ reg-nss
;

: reg-stop ( -- ) \ Finish SPI, NSS is controlled elsewhere
  \ -reg-nss
  SPI3 0 spi-enable!
;

: reg-init ( -- )
  reg-init-gpio
  reg-init-spi
  spi3-low-speed!  \ Debuggung
  reg-start
;

: rt-init
  reg-init
  reg-disconn
  $ffff >reg> drop
;

: spi.
  SPI3 SPI.
;

: ddd
\  50000 0 do nop loop
;

: tc
  ." Start comm test" cr
  reg-conn
  $0000 >reg> drop \ ." GOT: " hex. cr
  ddd
  $FFFF >reg> drop \ ." GOT: " hex. cr
  ddd
  $0000 >reg> drop \ ." GOT: " hex. cr
  ddd
  $FFFF >reg> drop \ ." GOT: " hex. cr
  ddd
  reg-disconn
;

: tc1
  ." Start comm test" cr
  $ff >reg> ." GOT: " hex. cr
  ddd
  $f0 >reg> ." GOT: " hex. cr
  ddd
  $00 >reg> ." GOT: " hex. cr
  ddd
;

: rt ( -- ) \ Register test
  rt-init
  reg-conn
  \ reg-start
  tc
;

: _ww
  25000 0 do loop
;


: reg-blink
  100 0 do
    reg-conn
    reg-nss
    25000 0 do loop
    -reg-nss
    reg-disconn
    25000 0 do loop
  loop
;

: reg-cnt
  256 0 do
    i 8 lshift i or dup hex. space
     >reg> hex. cr
    _ww
  loop
;

: regb
  reg-blink
;

compiletoram
