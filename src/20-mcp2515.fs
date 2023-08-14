\ Uses SPI.fs, gpio.fs
compiletoram
\ forgetram

: MCP-NSS GPIOA 15 inline ;
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
  %01 MCP-NSS gpio-pin-moder!   \ Output
  %0  MCP-NSS gpio-pin-otyper!  \ push pull output
  %10 MCP-NSS gpio-pin-ospeedr! \ High speed
  %00 MCP-NSS gpio-pin-pupdr!   \ No PULL-Ups
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

: nss\ \ Synthesize \___ ... signal (Start transiver)
  MCP-NSS gpio-pin-c!
;

: nss/ \ Synthesize .... ___/ signal (Stop transiver)
  MCP-NSS gpio-pin-s!
;

: mcp-stop
  nss/
  spi-stop
;

: mcp-done
  mcp-stop
  spi-done
;

: >mcp> ( c -- c ) \ Send/recive a byte
  SPI1 >spi>
;


: mcp-start
  1 2 lshift SPI1 SPI.CR1 bis! \ MSTR setting
  true SPI1 spi-enable
  nss\
;


\ : mcp-send-seq ( n_m n_m-1 ... n_1 m -- n_m n_m-1 ... n_1 m )
\  dup >r \ save resulting length


: mcp-read ( mcp-addr -- n ) \ Reads addr-register, byte
  mcp-start
  %00000011 >mcp> drop
  >mcp> drop
  0 >mcp>
  mcp-stop
;

: mcp-write ( n mcp-addr -- ) \ Writes addr-register, byte
  mcp-start
  %00000010 >mcp> drop
  >mcp> drop
  >mcp> drop
  mcp-stop
;


: mcp-read-status ( -- n ) \ Read status
  mcp-start
  %10100000 >mcp> drop
  0 >mcp>
  mcp-stop
;

: mcp-rx-status  ( -- n ) \ Read RX status
  mcp-start
  %10110000 >mcp> drop
  0 >mcp>
  mcp-stop
;

: mcp-rts ( flag2 flag1 flag0 -- ) \ Request-to-send TC buffers 0,1,2
  mcp-start
  %10000000
  if %1 or then
  if %10 or then
  if %100 or then
  >mcp> drop
  mcp-stop
;

: mcp-read-rx ( n flag -- ... ) \ Read RX buffer
  mcp-start
  %10010000
  if %10 or then
  2 lshift or
  >mcp> drop
  >mcp>
  mcp-stop
;

: mcp-write-tx ( data n flag -- ) \ Write into TX buffer
  mcp-start
  %01000000
  if %1 or then
  1 lshift or
  >mcp> drop
  >mcp> drop
  mcp-stop
;

: mcp-mod ( data mask mcp-add -- ) \ Modify according to mask and data
  mcp-start
  %00000101 >mcp> drop
  >mcp> drop
  >mcp> drop
  >mcp> drop
  mcp-stop
;


: mcp-test
  mcp-init
  cr ." -----------------------" cr
  MCP.
  mcp-read-status bin.
  mcp-done
;


: mcp-reg-dump ( -- ) \ Read all CAN controller registers
  mcp-init
  7 0 do
    $F 0 do
      j 8 lshift i or \ an Address
      mcp-read hex. space
    loop
    cr
  loop
  mcp-done
;
