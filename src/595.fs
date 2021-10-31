
forgetram

\ Controlling 74LS535 over SPI3
\ USES spi.fs

: spi-enable! ( SPIa %1/0 -- )
  swap SPI.CR1 swap
  \ DMA?
  if
    \ %111 5 lshift r@ SPI.CR2 bis! \ enable interrupts
    1 6 lshift swap bis! \ enable
    \ enable peripheral clock
  else
    \ spi-wait
    1 6 lshift swap bic! \ disable
    \ %111 5 lshift r@ SPI.CR2 bic! \ disable interrupts
    \ disable peripheral clock
  then
;

GPIOA constant REG.PORT
0 constant REG.OE.PIN \ PA0

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

  %0 %1 rcc-en!        \ Enable CLK Enable on port 0 = A
  GPIOA
      15 6 spi3-pin-conf#

;

: spi3-speed! ( n -- )  \ !000 -- %111 divider value
  %111 3 lshift SPI3 SPI.CR1 bic!
    3 lshift
      SPI3 SPI.CR1 bis!
;

: spi3-low-speed!
  %111 spi3-speed!
;

: spi3-high-speed!
  %1000 spi3-speed!
;


\ Tested OK
: rcc-spi3-enable! ( %1/0 -- ) \ TODO: Move to spi.fs
  RCC RCC.APB1ENR swap \ a 1
  1 15 lshift swap \ a mask 1/0
  if
    swap bis!
  else
    swap bic!
  then
;



  \ hspi3.Instance = SPI3;
  \ hspi3.Init.Mode = SPI_MODE_MASTER;
  \ hspi3.Init.Direction = SPI_DIRECTION_2LINES;
  \ hspi3.Init.DataSize = SPI_DATASIZE_8BIT;
  \ hspi3.Init.CLKPolarity = SPI_POLARITY_LOW;
  \ hspi3.Init.CLKPhase = SPI_PHASE_1EDGE;
  \ hspi3.Init.NSS = SPI_NSS_SOFT;
  \ hspi3.Init.BaudRatePrescaler = SPI_BAUDRATEPRESCALER_8;
  \ hspi3.Init.FirstBit = SPI_FIRSTBIT_MSB;
  \ hspi3.Init.TIMode = SPI_TIMODE_DISABLE;
  \ hspi3.Init.CRCCalculation = SPI_CRCCALCULATION_DISABLE;
  \ hspi3.Init.CRCPolynomial = 10;

\ 74LS595 supports approx 7 Mhz at 3.3 V CLK

: reg-init-spi ( -- )
  reg-init-spi3-gpio
  1 rcc-spi3-enable! \ ENABLE CLK in order to allow configuration
  SPI3
    \ CPOL=1 CPCHA=1 nio TI
    \ dup 0 spi-enable! \ HANGS
    dup SPI.CR2
       dup 1 4 lshift swap bic!  \ NO TI Mode
       dup %111 5 lshift swap bic! \ Disable interrupts
       dup 1 2 lshift swap bis!  \ ENABLE SSOE, output NSS when hardware mngmt.
       drop
    dup SPI.CR1
       dup 1 11 lshift swap bic! \ 8 bit
       dup 1 9 lshift swap bic!  \ Disable SSM (Enable hardware mngmt of NSS)
       dup 1 1 lshift swap bis!  \ CPOL=1
       dup 1 swap bis!           \ CPOL=1
       dup 1 2 lshift swap bis!  \ MASTER Mode !
       dup %010 3 lshift swap bis! \ Baud rate = 16Mhz/8 = 2Mhz < 7 MHz at 3.3V
       drop
    drop
;

: reg-start ( -- ) \ Start communications
  SPI3 1 spi-enable! \ NSS goes low if configuration is OK
;

: reg-stop ( -- ) \ Finish communications, rising NSS
  SPI3 0 spi-enable!
;

: reg-init ( -- )
  reg-init-gpio
  reg-init-spi
  spi3-low-speed!  \ Debuggung
;

: reg-wait-comm ( -- )
  begin
    SPI3 spi-busy? 128 = not key? or until
;

: reg! ( n -- ) \ Send 8 but to register
  SPI3 spi!
;

: reg@ ( -- n ) \ get value
  SPI3 spi@
;

: reg? ( -- n ) \ Is there dat received
  SPI3 spi-rxne?
;

: >reg> ( n -- n ) \ transmits byte and receives byte.
  reg-start
  reg-wait-comm
  begin
    SPI3 spi-txe? until
  reg!
  reg-wait-comm
  \ SPI3 spi-busy? ." busy: " . cr
  \ reg? ." REG: " . cr reg@  \ if reg@ else ." >reg> NO DATA" reg@ then
  reg@
  reg-stop
;


: rt-init
  reg-init
;

: spi.
  SPI3 SPI.
;

: ddd
  50000 0 do nop loop
;

: tc
  ." Start comm test" cr
  $88 >reg> ." GOT: " hex. cr
  ddd
  $77 >reg> ." GOT: " hex. cr
  ddd
  $F0 >reg> ." GOT: " hex. cr
  ddd
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
  tc
  reg-disconn
;