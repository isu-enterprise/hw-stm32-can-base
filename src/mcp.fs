
forgetram

\ Controlling MCP23S17 over SPI3
\ USES spi.fs

GPIOA constant MCP.PORT
0 constant MCP.RESET.PIN \ PA0

: mcp-pin-conf# ( GPIOa pin -- )
  >r
  dup r@ %01 gpio-mode!   \ OUTPUT
  dup r@ %0 gpio-otype!   \ OUTPUT Push-pull
  dup r@ %00 gpio-pupd!   \ OUTPUT Push-pull
      r> %00 gpio-ospeed! \ OUTPUT Low Speed
;


: mcp-reset ( -- ) \ Connect Qx to output
  GPIOA MCP.RESET.PIN 0 gpio-bsr!
;

: -mcp-reset ( -- ) \ DisConnect Qx from output, go Z
  GPIOA MCP.RESET.PIN 1 gpio-bsr!
;

: mcp-init-gpio        \ Reset pin of MCP
  %0 %1 rcc-en!        \ Enable CLK Enable on port 0 = A
  GPIOA MCP.RESET.PIN mcp-pin-conf#
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



: mcp-init-spi3-gpio ( -- )
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

: mcp-init-spi ( -- )
  mcp-init-spi3-gpio
  1 rcc-spi3-enable! \ ENABLE CLK in order to allow configuration
  SPI3
    \ CPOL=1 CPCHA=1 no TI
    \ dup 0 spi-enable! \ HANGS
    dup SPI.CR2
       dup 1 4 lshift swap bic!  \ NO TI Mode
       dup %111 5 lshift swap bic! \ Disable interrupts
       dup 1 2 lshift swap bis!  \ ENABLE SSOE, output NSS when hardware mngmt.
       drop
    dup SPI.CR1
       dup 1 11 lshift swap bis! \ 16 bit
       dup 1 9 lshift swap bic!  \ Disable SSM (Enable hardware mngmt of NSS)
       dup 1 1 lshift swap bis!  \ CPOL=1
       dup 1 swap bis!           \ CPOL=1
       dup 1 2 lshift swap bis!  \ MASTER Mode !
       dup %010 3 lshift swap bis! \ Baud rate = 16Mhz/8 = 2Mhz < 7 MHz at 3.3V
       drop
    drop
;

: mcp-start ( -- ) \ Start communications
  SPI3 1 spi-enable! \ NSS goes low if configuration is OK
;

: mcp-stop ( -- ) \ Finish communications, rising NSS
  SPI3 0 spi-enable!
;

: mcp-init ( -- )
  mcp-init-gpio
  mcp-init-spi
  mcp-reset
  1000 0 do loop
  -mcp-reset
  spi3-low-speed!  \ Debuggung
;

: mcp-wait-comm ( -- )
  begin
    SPI3 spi-busy? 128 = not key? or until
;

: spi3! ( n -- ) \ Send 8 but to MCP
  SPI3 spi!
;

: spi3@ ( -- n ) \ get value
  SPI3 spi@
;

: spi3? ( -- n ) \ Is there dat received
  SPI3 spi-rxne?
;

: >spi3> ( n -- n ) \ transmits byte and receives byte.
  mcp-wait-comm
  begin
    SPI3 spi-txe? until
  spi3!
  mcp-wait-comm
  spi3@
;


: mt-init
  mcp-init
;

: spi.
  SPI3 SPI.
;

: mcp-delay
  50000 0 do nop loop
;


: mcp-read-bit ( %1/0 -- %0100 ABC R ) \ R as input
  %01001110 or 8 lshift
;

: mcp-cmd ( DATA CMD -- Word )
  mcp-start
  \ h.s cr cr
  >spi3> drop \ . cr
  >spi3>
  mcp-stop
;


: mcp! ( reg byte1 byte2 -- ? ?)
  swap 8 lshift or
  swap
  0 mcp-read-bit or  \ Command = <0100AAAW REG> <BYTE1 BYTE2>
  h.s
  mcp-cmd
  bin.  \ debug
;

: mcp@ ( reg -- Word)
  1 mcp-read-bit or  \ Command = <0100AAAW REG> <BYTE1 BYTE2>
  0 swap
  mcp-cmd
;


\ : mc
\   ." Start comm test" cr
\   $88 >mcp> ." GOT: " hex. cr
\   mcp-delay
\   $77 >mcp> ." GOT: " hex. cr
\   mcp-delay
\   $F0 >mcp> ." GOT: " hex. cr
\   mcp-delay
\ ;

: mt ( -- ) \ MCP test
  mt-init
;

mt

: mcp. $1b 0 do i hex. i mcp@ hex. cr loop ;
