\ Uses SPI.fs, gpio.fs, printing.fs
\ compiletoram
forgetram
compiletoflash

: MCP-NSS-0 GPIOA 15 inline ;
: MCP-NSS-1 GPIOA 11 inline ;
: MCP-INT-0 GPIOA 12 inline ;
: MCP-INT-1 GPIOB 8 inline ;
: MCP-SPI GPIOB inline ;
: MCP-MOSI MCP-SPI 5 inline ;
: MCP-MISO MCP-SPI 4 inline ;
: MCP-SCK MCP-SPI 3 inline ;

: RCC.APB2ENR.
  RCC RCC.APB2ENR 1b.
;

: MCP.
  ." enable RCC.APB2ENR. (12-spi1)"
  RCC.APB2ENR.
  ." nss  GPIOA GPIO.CRH. (PA12, 4, PA15, 7)"
  GPIOA GPIO.
  ." spi1 GPIOB GPIO.CRL. (PB3-PB5)"
  GPIOB GPIO.
  ." SPI1 registers"
  SPI1 SPI.
;

: spi-init
  true spi1-rcc-enable
;

: spi-stop
  SPI1
  dup spi-busy?
  if
    dup spi-wait-rx
    dup spi-wait-tx
    dup spi-wait-comm
  then
  dup false swap spi-enable
  drop
;

: spi-done
  spi-stop
  false spi1-rcc-enable
;

: mcp-init
  \ HArdare control on NSS via GPIO
  %01 MCP-NSS-0 gpio-pin-moder!   \ Output
  %0  MCP-NSS-0 gpio-pin-otyper!  \ push pull output
  %10 MCP-NSS-0 gpio-pin-ospeedr! \ High speed
  %00 MCP-NSS-0 gpio-pin-pupdr!   \ No PULL-Ups

  %01 MCP-NSS-1 gpio-pin-moder!   \ Output
  %0  MCP-NSS-1 gpio-pin-otyper!  \ push pull output
  %10 MCP-NSS-1 gpio-pin-ospeedr! \ High speed
  %00 MCP-NSS-1 gpio-pin-pupdr!   \ No PULL-Ups
  \ SPI SCK pin PB3
  %10 MCP-SCK gpio-pin-moder!   \ Alterative function
  5   MCP-SCK gpio-pin-af!
  %0  MCP-SCK gpio-pin-otyper!
  %10 MCP-SCK gpio-pin-ospeedr!
  %00 MCP-SCK gpio-pin-pupdr!
  \ SPI MISO pin PB4
  %10 MCP-MISO gpio-pin-moder!   \ Alterative function
  5   MCP-MISO gpio-pin-af!
  %0  MCP-MISO gpio-pin-otyper!
  %10 MCP-MISO gpio-pin-ospeedr!
  %00 MCP-MISO gpio-pin-pupdr!
  \ SPI MOSI pin PB5
  %10 MCP-MOSI gpio-pin-moder!   \ Alterative function
  5   MCP-MOSI gpio-pin-af!
  %0  MCP-MOSI gpio-pin-otyper!
  %10 MCP-MOSI gpio-pin-ospeedr!
  %00 MCP-MOSI gpio-pin-pupdr!
  \ SPI1 init
  spi-init
  \ TODO: Interrupt is on PA12
  \ SPI1 dup spi-low-speed
  SPI1 dup spi-high-speed
       dup SPI.CR1
           \ CPOL=0
           \ CPHA=0 ___/---
       dup %11 swap bic!
           \ LSBFirst first = 0
           dup %1 7 lshift swap bic!
           \ SSM=1
           dup %1 9 lshift swap bis!
           \ SSI=1
           dup %1 8 lshift swap bis!
           \ DFF - 8bit = 0
           dup %1 11 lshift swap bic!
           \ BIDIMODE = 0, BIDIOE=0
           dup %11 14 lshift swap bic!
           \ No CRC
           dup %1 13 lshift swap bic!
           \ RXONLY = 0
           dup %1 10 lshift swap bic!
           drop
      dup SPI.CR2
           \ SSOE=0 (1?)
          dup %1 2 lshift swap bic!
          dup %1 2 lshift swap bic! \ NO TI mode
          drop
      \ TODO: FRF \ TI protocol
      dup SPI.CR1
          \ MSTR set
          dup %1 2 lshift swap bis!
          drop
      drop
  \ SPIE set
;


: nss-which ( n -- addr pin ) \ convert n, mcp number,
                              \ in addr-pin combo
  dup 0= if drop MCP-NSS-0 exit then
  1 = if MCP-NSS-1 exit then
  ." ERROR: wrong SPI No" cr
;

: nss\ ( n -- )  \ Synthesize \___ ... signal (Start transiver)
                 \ n = mcp number
  nss-which gpio-pin-c!
;

: nss/ ( n -- ) \ Synthesize .... ___/ signal (Stop transiver)
  nss-which gpio-pin-s!
;

: mcp-stop ( n -- )
  nss/
  spi-stop
;

: mcp-done ( n -- )
  mcp-stop
  spi-done
;

: >mcp> ( c -- c ) \ Send/recive a byte
  SPI1 >spi>
;


: mcp-start ( n -- )
  1 2 lshift SPI1 SPI.CR1 bis! \ MSTR setting
  true SPI1 spi-enable
  nss\
;


\ : mcp-send-seq ( n_m n_m-1 ... n_1 m -- n_m n_m-1 ... n_1 m )
\  dup >r \ save resulting length


: mcp-read ( mcp-addr n -- n ) \ Reads addr-register, byte
  >r
  r@ mcp-start
  %00000011 >mcp> drop
  >mcp> drop
  0 >mcp>
  r> mcp-stop
;

: mcp-write ( n mcp-addr n -- ) \ Writes addr-register, byte
  >r
  r@ mcp-start
  %00000010 >mcp> drop
  >mcp> drop
  >mcp> drop
  r> mcp-stop
;


: mcp-read-status ( n -- n ) \ Read status
  >r
  r@ mcp-start
  %10100000 >mcp> drop
  0 >mcp>
  r> mcp-stop
;

: mcp-rx-status  ( n -- n ) \ Read RX status
  >r
  r@ mcp-start
  %10110000 >mcp> drop
  0 >mcp>
  r> mcp-stop
;

: mcp-rts ( flag2 flag1 flag0 n -- ) \ Request-to-send TC buffers 0,1,2
  >r
  r@ mcp-start
  %10000000
  if %1 or then
  if %10 or then
  if %100 or then
  >mcp> drop
  r> mcp-stop
;

: mcp-read-rx ( n flag n -- ... ) \ Read RX buffer
  >r
  r@ mcp-start
  %10010000
  if %10 or then
  2 lshift or
  >mcp> drop
  >mcp>
  r> mcp-stop
;

: mcp-write-tx ( data n flag n -- ) \ Write into TX buffer
  >r
  r@ mcp-start
  %01000000
  if %1 or then
  1 lshift or
  >mcp> drop
  >mcp> drop
  r> mcp-stop
;

: mcp-mod ( data mask mcp-addr n -- ) \ Modify according to mask and data
  >r
  r@ mcp-start
  %00000101 >mcp> drop
  >mcp> drop
  >mcp> drop
  >mcp> drop
  r> mcp-stop
;


8000000 constant MCP-CLOCK

: mcp-nwrite ( vn-1 ... v0 nlen mcp-addr n -- ) \ Writes in registers
  >r
  r@ mcp-start
  %00000010 >mcp> drop
  >mcp> drop \ write mcp-addr
  0 ?do >mcp> drop loop
  r> mcp-stop
;


: mcp-nread ( nlen mcp-addr n -- dm...d0 nlen )
  rot
  dup 0= if
    drop 2drop 0
    exit
  then
  \ mcp-addr n nlen
  >r \ Save the length
  >r \ Save n
  \ mcp-addr
  r@ mcp-start
  %00000011 >mcp> drop \ Read cmd
  >mcp> drop \ Set addr
  2r@ drop \ nlen
  0 do 0 >mcp> loop
  r@ mcp-stop
  2r> drop \ Set length in the stack
;

: mcp-reset ( n -- )
  dup mcp-start
  %11000000 >mcp> drop
  mcp-stop
;

: MCP.TXB ( n -- mcp-addr ) \ Converts TXn to TXBn_CTRL mcp-addr
  %0011 + 4 lshift inline
;

: MCP.RXB ( n -- mcp-addr ) \ Converts TXn to TXBn_CTRL mcp-addr
  %0110 + 4 lshift inline
;

: MCP.BSIDH ( mcp-addr -- mcp-addr )
  1 + inline
;

: MCP.BSIDL ( mcp-addr -- mcp-addr )
  2 + inline
;

: MCP.BEID8 ( mcp-addr -- mcp-addr )
  3 + inline
;

: MCP.BEID0 ( mcp-addr -- mcp-addr )
  4 + inline
;

: MCP.DLC ( mcp-addr -- mcp-addr )
  5 + inline
;

: MCP.D ( n mcp-addr -- mcp-addr ) \ n-th byte of data
  6 + +
  inline
;

$08 constant TXB-EXIDE-MASK
$2b constant MCP-CANINTE
$2c constant MCP-CANINTF
$0e constant MCP-CANSTAT
$e0 constant MCP-CANSTAT-OPMOD


: mcp-test ( n -- ) \ n - mcp No = 0,1
  dup mcp-init
  cr ." -----------------------" cr
  MCP.
  dup mcp-read-status bin.
  mcp-done
;


: mcp-reg-dump ( n -- ) \ Read all CAN controller registers
  \ TODO: Check if spi is ready, else it hangs
  cr
  ." MCP-Dump interface: " dup . cr
  ."   | "
  $10 0 do
    i ch. space
    i 7 = if space space then
  loop
  cr
  ." ---+-"
  8 0 do ." ---" loop
  ." --"
  8 0 do ." ---" loop
  cr
  8 0 do
    i 4 lshift ch. ." | "
    $10 0 do
      j 4 lshift i or \ n mcp-reg-addrs
      over mcp-read ch. space
      i 7 = if space space then
    loop
    cr
  loop
;

: mcp-reg-test ( n -- ) \ initialize and dump
  dup mcp-init
  dup mcp-reg-dump
  mcp-done
;

compiletoram
