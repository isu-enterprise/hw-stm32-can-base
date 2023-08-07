\ Uses SPI.fs, gpio.fs
compiletoram
\ forgetram

: MCP-NSS GPIOA 12 inline ; \ GPIOA12, PA12
: MCP-SPI GPIOB inline ;
: MCP-MOSI MCP-SPI 5 inline ;
: MCP-MISO MCP-SPI 4 inline ;
: MCP-SCK MCP-SPI 3 inline ;

$40010000 constant AFIO

: AFIO.MAPR $04 + inline ; \ AF remap and debug I/O configuration register (AFIO_MAPR)

: AFIO.
  \ ." AFIO.MAPR, bit 0"
  AFIO AFIO.MAPR 1b.
;

: MCP.
  ." enable RCC.APB2ENR. (12-spi1, 0-afio)"
  RCC.APB2ENR.
  ." remap AFIO.MAPR (0 bit)"
  AFIO.
  ." nss  GPIOA GPIO.CRH. (PA12, 4)"
  GPIOA GPIO.CRH.
  ." spi1 GPIOB GPIO.CRL. (PB3-PB5)"
  GPIOB GPIO.CRL.
  ." SPI1 registers"
  SPI1 SPI.
;

: spi-init
  true spi1-rcc-enable
  %1 \ 0 lshift ;-)
  \ TODO: AFIO ENABLE
  AFIO AFIO.MAPR bis! \ Remap SPI1 to PB3-5...
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
  \       mode conf
  MCP-NSS %01 %00 gpio-setup \ 10 Mhz, Output
  MCP-SCK %01 %10 gpio-setup \ Output, AF
  MCP-MISO %00 %10 gpio-setup \ Input, AF
  MCP-MOSI %01 %10 gpio-setup \ Output, AF
  \ SPI1 init
  spi-init
  \ TODO: Interrupt is on PB7
  SPI1 dup spi-low-speed
       dup SPI.CR1
           \ CPOL=0
           \ CPHA=0 ___/---
           dup %11 swap bic!
           \ LSBFirst first = 0
           dup %1 7 lshift swap bic!
           \ SSM=0
           dup %1 9 lshift swap bic!
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
          drop
      dup SPI.CR1
          \ MSTR set
          dup %1 2 lshift swap bis!
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
  2 shift or
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
