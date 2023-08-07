\ SPI
\ Uses display.fs, system.fs

forgetram

compiletoram

$40013000 constant SPI1
$40003800 constant SPI2
$40003C00 constant SPI3

: SPI.CR1 $00 + inline ; \ SPI control register 1 (\ SPI_CR1)
: SPI.CR2 $04 + inline ; \ SPI control register 2 (\ SPI_CR2)
: SPI.SR  $08 + inline ; \ SPI status register (\ SPI_SR)
: SPI.DR  $0c + inline ; \ SPI data register (\ SPI_DR)
: SPI.RXCRCR $14 + inline ; \ SPI RX CRC register (\ SPI_RXCRCR)
: SPI.TXCRCR $18 + inline ; \ SPI TX CRC register (\ SPI_TXCRCR)
: SPI.I2SCFGR $1c + inline ; \ SPI_I2S configuration register (\ SPI_I2SCFGR)
: SPI.I2SPR $20 + inline ; \ SPI_I2S prescaler register (\ SPI_I2SPR)

: SPI.CR1.
  SPI.CR1 1b.
;

: SPI.CR2.
  SPI.CR2 1b.
;

: SPI.SR.
  SPI.SR 1b.
;

: SPI.DR.
  SPI.DR 1b.
;

: SPI.
  cr
  ." CR1"
  dup SPI.CR1.
  ." CR2"
  dup SPI.CR2.
  ." SR"
  dup SPI.SR.
  ." DR"
  dup SPI.DR.
  drop
;

: bis?! ( flag mask addr -- ) \ Set (if flag=true) or clear with mask
  rot
  if
    bis!
  else
    bic!
  then
;

: spi1-rcc-enable ( flag -- ) \ Enable clocking of SPI1 subsystem
  1 12 lshift
  RCC RCC.APB2ENR
  \ flag mask addr.APB2ENR
  bis?!
;

: spi3-rcc-enable ( flag -- )
  1 15 lshift
  RCC RCC.APB1ENR
  bis?!
;

: spi2-rcc-enable ( flag -- )
  1 14 lshift
  RCC RCC.APB1ENR
  bis?!
;


: spi-sr-tb$@ ( bitn SPIa -- flag ) \
  SPI.SR %1 \ bit SPIa.SR %1
  rot lshift \ SPIa.SR mask
  swap bit@
;

: spi-txe? ( SPIa -- flag ) \ Is transmit buffer empty ?
  1 spi-sr-tb$@
;

: spi-rx? ( SPIa -- flag ) \ Is receive buffer NOT empty ?
  0 spi-sr-tb$@
;

: spi-busy? ( SPIa -- busy ) \ Get busy flag
  7 spi-sr-tb$@
;

\ ----------------

: spi@ ( SPIa -- n ) \ Get [received] data from data register (RX buffer)
  SPI.DR @
;

: spi! ( data SPIa -- ) \ Set [transmit] data register (TX buffer)
  SPI.DR !
;

: spi-wait ( SPIa -- )
  \ until RXNE == 1 &
  \ until TXE == 1 &
  \ until BSY == 0 &
  begin
    dup spi-busy? not
  until
  SPI.SR
  begin
    dup @ %11 and \ SPI_SRa TXE|RXNE
    %11 =
  until
;

: spi-enable ( flag SPIa -- )
  SPI.CR1
  1 6 lshift swap
  bis?!
;

: spi-speed ( SPIa n -- )  \ !000 -- %111 divider value
  3 lshift \ SPIa mask
  swap
  SPI.CR1 \ mask SPIa.CR1
  %111 3 lshift \ mask SPIa.CR1 mask2
  over bic! \ mask SPIa.CR1
  bis!
;

: spi-low-speed ( SPIa -- ) \ !111 - big divider
  %111 spi-speed
;

: spi-high-speed ( SPIa -- ) \ !000 - small divider
  %000 spi-speed
;

: spi-mid-speed ( SPIa -- ) \ !000 - average divider
  %010 spi-speed
;

: spi-wait-comm ( SPIa -- )
  begin
    dup spi-busy? not
  until
  drop
;

: >spi> ( n SPIa -- n ) \ transmits byte/word and receives byte/word.
  dup spi-wait-comm
  swap \ SPIa n
  over spi! \ SPIa
  dup spi-wait-comm
  dup spi@
;
