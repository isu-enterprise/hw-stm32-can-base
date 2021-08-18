\ Long fundamental instruction with a video.
\ https://www.digikey.com/en/maker/projects/getting-started-with-stm32-how-to-use-spi/09eab3dfe74c4d0391aaaa99b0a8ee17

\ It is recommended to disable JTAG and SWD bwfore using SPI/I2C
\ Slave mode
\  1.Set the DFF bit to define 8- or 16-bit data frame format
\  2.Select the CPOL and CPHA bits to define one of the four relationships between the
\    data transfer and the serial clock (see Figure 194). For correct data transfer, the CPOL
\    and CPHA bits must be configured in the same way in the slave device and the master
\    device. This step is not required when the TI mode is selected through the FRF bit in
\    the SPI_CR2 register.
\  3.The frame format (MSB-first or LSB-first depending on the value of the LSBFIRST bit in
\    the SPI_CR1 register) must be the same as the master device. This step is not
\    required when TI mode is selected.
\  4.In Hardware mode (refer to Slave select (NSS) pin management), the NSS pin must be
\    connected to a low level signal during the complete byte transmit sequence. In NSS
\    software mode, set the SSM bit and clear the SSI bit in the SPI_CR1 register. This step
\    is not required when TI mode is selected.
\  5.Set the FRF bit in the SPI_CR2 register to select the TI mode protocol for serial
\    communications.
\  6.Clear the MSTR bit and set the SPE bit (both in the SPI_CR1 register) to assign the
\    pins to alternate functions.
\  MOSI = Input, MISO = Output in slave mode.

\ forgetram

compiletoflash

\ USES 00-mmap.fs

\ RCC_APB2PeriphClockCmd(RCC_APB2Periph_AFIO, ENABLE) ?


: rcc-spi1-enable! ( 1/0 -- ) \ Enable communications
  RCC RCC.APB2ENR swap
  1 12 lshift swap
  if
    bis!
  else
    bic!
  then
;

: spi-s? ( SPIa -- register ) \ Get status register
  SPI.SR @
;

: spi-txe? ( SPIa -- T/F ) \ Is transmit buffer empty ?
  spi-s? 1 1 lshift and
;

: spi-rxne? ( SPIa -- T/F ) \ Is receive buffer NOT empty ?
  spi-s? %1 and
;

: spi-busy? ( SPIa -- busy ) \ Get busy flag
  spi-s? 1 7 lshift and
;

: spi@ ( SPIa -- SPI-DR ) \ Get [received] data from data register (RX buffer)
  SPI.DR @
;

: spi! ( data SPIa -- ) \ Set [transmit] data register (TX buffer)
  SPI.DR !
;

: spi1-en! ( %1/0 -- )
  RCC RCC.APB2ENR
  1 12 lshift \ 1/0 a mask
  rot
  if
    swap bis!
  else
    swap bic!
  then
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

: spi-enable! ( SPIa %1/0 -- )
  swap >r \ 1/0
  \ DMA?
  if
    \ %111 5 lshift r@ SPI.CR2 bis! \ enable interrupts
    1 6 lshift    r@ SPI.CR1 bis! \ enable
    \ enable peripheral clock
  else
    \ spi-wait
    1 6 lshift    r@ SPI.CR1 bic! \ disable
    \ %111 5 lshift r@ SPI.CR2 bic! \ disable interrupts
    \ disable peripheral clock
  then
  rdrop
;

compiletoram
