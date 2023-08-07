\ Uses SPI.fs, gpio.fs
compiletoram
\ forgetram

: MCP-NSS GPIOA 15 inline ; \ GPIOA15, PA15
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
  ." nss  GPIOA GPIO.CRH. (PA15)"
  GPIOA GPIO.CRH.
  ." spi1 GPIOB GPIO.CRL. (PB3-PB5)"
  GPIOB GPIO.CRL.
  ." SPI1 registers"
  SPI1 SPI.
;

: spi-init
  true spi1-rcc-enable
  %1 \ 0 lshift ;-)
  AFIO AFIO.MAPR bis! \ Remap SPI1 to PB3-5...
  SPI1 spi-low-speed
  cr ." -----------------------" cr
  mcp.
;

: spi-done
  false spi1-rcc-enable
;

: mcp-init
  spi-init
  \ Software control on NSS
  \       mode conf
  MCP-NSS %01 %00 gpio-setup \ 10 Mhz, Output
  MCP-SCK %01 %10 gpio-setup \ Output, AF
  MCP-MISO %00 %10 gpio-setup \ Input, AF
  MCP-MOSI %01 %10 gpio-setup \ Output, AF
;

: mcp-done
  spi-done
;

: nss\ \ Synthesize \___ ... signal (Start transiver)
  MCP-NSS gpio-pin-c!
;

: nss/ \ Synthesize .... ___/ signal (Stop transiver)
  MCP-NSS gpio-pin-s!
;

: >mcp> ( c -- c ) \ Send/recive a byte
  SPI1 >spi>
;
