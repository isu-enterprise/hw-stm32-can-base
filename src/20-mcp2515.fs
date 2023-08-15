\ Uses SPI.fs, gpio.fs
compiletoram
\ forgetram

: MCP-NSS-0 GPIOA 15 inline ;
: MCP-NSS-1 GPIOA 11 inline ;
: MCP-SPI GPIOB inline ;
: MCP-MOSI MCP-SPI 5 inline ;
: MCP-MISO MCP-SPI 4 inline ;
: MCP-SCK MCP-SPI 3 inline ;
: MCP-INT GPIOA 12 inline ;

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
  SPI1 dup spi-low-speed
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
  ." ERROR: wrong SPI No"
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

: mcp-mod ( data mask mcp-add n -- ) \ Modify according to mask and data
  >r
  r@ mcp-start
  %00000101 >mcp> drop
  >mcp> drop
  >mcp> drop
  >mcp> drop
  r> mcp-stop
;


: mcp-test ( n -- ) \ n - mcp No = 0,1
  dup mcp-init
  cr ." -----------------------" cr
  MCP.
  dup mcp-read-status bin.
  mcp-done
;


: mcp-reg-dump ( n -- ) \ Read all CAN controller registers
  dup mcp-init
  cr
  7 0 do
    $F 0 do
      j 8 lshift i or \ an Address
      dup hex. ." ="
      over mcp-read hex. space
    loop
    cr
  loop
  mcp-done
;
