
forgetram

\ Controlling MCP23S17 over SPI3
\ USES spi.fs

GPIOA constant MCP.PORT
0  constant MCP.RESET.PIN \ PA0
$f constant MCP.NSS.PIN   \ PA15

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

: mcp-nss ( -- ) \ Command Start condition
  GPIOA MCP.NSS.PIN 0 gpio-bsr!
;

: -mcp-nss ( -- ) \ Command Stop condition
  GPIOA MCP.NSS.PIN 1 gpio-bsr!
;

: mcp-init-gpio        \ Reset pin of MCP
  %0 %1 rcc-en!        \ Enable CLK Enable on port 0 = A
  GPIOA MCP.RESET.PIN mcp-pin-conf#
  GPIOA MCP.NSS.PIN mcp-pin-conf#
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

  \ %0 %1 rcc-en!        \ Enable CLK Enable on port 0 = A
  \ GPIOA
  \     15 6 spi3-pin-conf#

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
  %000 spi3-speed!
;

: spi3-mid-speed!
  %010 spi3-speed!
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


: mcp-init-spi ( -- )
  mcp-init-spi3-gpio
  1 rcc-spi3-enable! \ ENABLE CLK in order to allow configuration
  SPI3
    \ CPOL=1 CPCHA=1 no TI
    \ dup 0 spi-enable! \ HANGS
    dup SPI.CR2
       dup 1 4 lshift swap bic!  \ NO TI Mode
       dup %111 5 lshift swap bic! \ Disable interrupts
       dup 1 2 lshift swap bic!  \ DISABLE SSOE, we will control ourselves
       dup %11 swap bic!         \ DISABLE DMA ints
       drop
    dup SPI.CR1
       dup 1 11 lshift swap bic! \ 8 bit
       dup 1 9 lshift swap bis!  \ ENABLE SSM
       dup 1 8 lshift swap bis!  \ ENABLE SSI
       dup 1 1 lshift swap bis!  \ CPOL=1
       dup 1 swap bis!           \ CPOL=1
       dup 1 2 lshift swap bis!  \ MASTER Mode !
       dup %010 3 lshift swap bis! \ Baud rate = 16Mhz/8 = 2Mhz < 7 MHz at 3.3V
       \ MSB
       \
       drop
    drop
;

: _w
  10 0 do loop
;

: mcp-start ( -- ) \ Start communications
  SPI3 1 spi-enable! \ NSS goes low if configuration is OK
  _w
  mcp-nss
  _w
;

: mcp-stop ( -- ) \ Finish communications, rising NSS
  _w
  -mcp-nss
  _w
  \ SPI3 0 spi-enable!
;

: mcp-init ( -- )
  mcp-init-gpio
  -mcp-nss
  mcp-init-spi
  mcp-reset
  _w _w _w
  -mcp-reset
  \ spi3-low-speed!  \ Debuggung
  spi3-high-speed!  \ Release 10 Mhz possible / 8? by default
;

\ : mcp-wait-comm ( -- )
\   begin
\     SPI3 spi-busy? 128 = not key? or until
\ ;

: mcp-wait-comm ( -- )
  begin
    SPI3 spi-busy? not
  until
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
  \ begin
  \   SPI3 spi-txe? until \ Redundant as BUSY cover this
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

0 variable MCP.ADDR

: mcp-read-bit ( %1/0 -- %0100 ABC R ) \ R as input
  \ %01001110 or
  %01000000 or
  MCP.ADDR @ %111 and 1 lshift or
;

: mcp-cmd ( DATA/8 CMD/8 ADDR/8 -- Word )
  mcp-start
  \ ." At mcp-cmd" cr
  \ h.s cr cr
  >spi3> drop \ Addr
  >spi3> drop \ . cr
  >spi3>
  mcp-stop
;


: mcp! ( byte reg -- )
  0 mcp-read-bit  \ Command = <0100AAAW> <REG> <BYTE>
  mcp-cmd
  drop
  \ bin.  \ debug
;

: mcp@ ( reg -- byte )
  0 swap   \ Blank data first
  1 mcp-read-bit \ Command = <0100AAAW> <REG> <dummy BYTE>
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

: tt
  mt
  mcp-delay
  $0f 0 mcp!
  mcp-delay
  0 mcp@
;

: mcp. cr $1b 0 do i hex. i mcp@ hex. cr loop ;

: mcp-scan
  8 0 do
    i MCP.ADDR   !
    cr ." scanning " MCP.ADDR @ hex. cr
    mcp.
  loop
;
