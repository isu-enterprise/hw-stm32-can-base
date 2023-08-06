\ SPI
\ Uses display.fs, system.fs

compiletoram
forgetram

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
  SPI.CR1 bin.
;

: SPI.CR2.
  SPI.CR2 bin.
;

: SPI.SR.
  SPI.SR bin.
;

: SPI.DR.
  SPI.DR bin.
;

: SPI.
  cr
  ." CR1" cr
  dup SPI.CR1.
  ." CR2" cr
  dup SPI.CR2.
  ." SR" cr
  dup SPI.SR.
  ." DR" cr
  dup SPI.DR.
  drop
;
