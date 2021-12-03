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

\ USES 10-mmap.fs

\ RCC_APB2PeriphClockCmd(RCC_APB2Periph_AFIO, ENABLE) ?


: rcc-spi1-enable! ( bool -- ) \ Enable communications
  RCC RCC.APB2ENR swap
  1 12 lshift -rot
  if
    bis!
  else
    bic!
  then
;

: rcc-spi3-enable! ( bool -- )
  RCC RCC.APB1ENR swap \ addr bool
  1 15 lshift \ addr bool mask
  -rot \ mask addr bool
  if
    bis!
  else
    bic!
  then
;

: rcc-spi2-enable! ( bool -- )
  RCC RCC.APB1ENR swap \ addr bool
  1 14 lshift \ addr bool mask
  -rot \ mask addr bool
  if
    bis!
  else
    bic!
  then
;


: spi-txe? ( SPIa -- T/F ) \ Is transmit buffer empty ?
  SPI.SR %1 1 lshift swap bit@
;

: spi-rxne? ( SPIa -- T/F ) \ Is receive buffer NOT empty ?
  SPI.SR %1 swap bit@
;

: spi-busy? ( SPIa -- busy ) \ Get busy flag
  SPI.SR %1 7 lshift swap bit@
;

: spi@ ( SPIa -- SPI-DR ) \ Get [received] data from data register (RX buffer)
  SPI.DR @
;

: spi! ( data SPIa -- ) \ Set [transmit] data register (TX buffer)
  SPI.DR !
;

: spi1-en! ( %1/0 -- )
  RCC RCC.APB2ENR
  %1 12 lshift \ 1/0 a mask
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
  swap SPI.CR1 swap
  \ DMA?
  if
    \ %111 5 lshift r@ SPI.CR2 bis! \ enable interrupts
    1 6 lshift swap bis! \ enable
    \ enable peripheral clock
  else
    \ spi-wait
    1 6 lshift swap bic! \ disable
    \ %111 5 lshift r@ SPI.CR2 bic! \ disable interrupts
    \ disable peripheral clock
  then
;



: spi-speed! ( SPIa n -- )  \ !000 -- %111 divider value
  swap SPI.CR1 >r \ n
  %111 3 lshift r@ bic!
  3 lshift
    r> bis!
;

: spi3-speed! ( n -- )  \ !000 -- %111 divider value
  SPI3 swap spi-speed!
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

: spi3! ( n -- ) \ Send 8/16 but to MCP
  SPI3 spi!
;

: spi3@ ( -- n ) \ get value
  SPI3 spi@
;

: spi3? ( -- n ) \ Is there dat received
  SPI3 spi-rxne?
;

: spi-wait-comm ( SPIa -- )
  begin
    dup spi-busy? not
  until
  drop
;

: >spi3> ( n -- n ) \ transmits byte/word and receives byte/word.
  SPI3 spi-wait-comm
  spi3!
  SPI3 spi-wait-comm
  spi3@
;


compiletoram
