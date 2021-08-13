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

forgetram

\ USES 00-mmap.fs

: spi1-pin-conf# ( pin -- )
  >r
  GPIOA r@ %10 gpio-mode!   \ Alternate Function
  GPIOA r@ %11 gpio-ospeed! \ HUIGH SPEED
  GPIOA r@ %00 gpio-pupd!  \ NO-PULL
  GPIOA r@ 5   gpio-af!     \ 5 = SPI Altern.funct.
  r> drop
;

: g. GPIOA GPIO. ;

: spi1-gpio-setup
  4 spi1-pin-conf#
  5 spi1-pin-conf#
  6 spi1-pin-conf#
  7 spi1-pin-conf#
  $0 $1 rcc-en!        \ Enable CLK Enable on port 0 = A
;

\ RCC_APB2PeriphClockCmd(RCC_APB2Periph_AFIO, ENABLE) ?

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


: spi1-setup-ad ( -- )
  spi1-gpio-setup    \ Setup functions on pins first, enable CLK
  1 spi1-en!
  SPI1
  dup SPI.CR1
    dup 1 6 lshift swap bic!   \ ~SPE, SPI Enable
    dup 1 11 lshift swap bis!  \ 16 bit data frame

    \ dup 1 lshift 9 bic! \ Software management disabled (if ~TI)
    \ dup 1 lshift 7 bic! \ 0 - MSBFIRST, 1 - LSBFIRST (if ~TI)
    \ dup 1 lshift 1 bic! \ CPOL (if ~TI)
    \ dup 1 lshift 0 bis! \ CPHA = 0, L=1  ---\_/-\_/-.....---- SCK \  (if ~TI)
                          \ CPHA = 1, L=0  _/-\_/-\_/-.....---- SCK \

    dup 1 2 lshift swap bic!   \ MSTR, SLAVE mode SPI
    drop
  dup SPI.CR2
    dup 1 4 lshift swap bis!   \ FRF (Frame format) TI mode (seems OK for AD)
    drop
  drop
;

: spi-wait ( SPIa -- )
  \ until RXNE == 1 &
  \ until TXE == 1 &
  \ until BSY == 0 &
  begin
    dup spi-bsy? not
  until
  SPI.SR
  begin
    dup @ %11 and \ SPI_SRa TXE|RXNE
    %11 =
  until
;

: spi-enable! ( SPIa %1/0 -- )
  \ DMA?
  if
    dup SPI.CR2 %111 5 lshift bis! \ enable interrupts
    SPI.CR1 1 6 lshift bis!        \ enable
    \ enable peripheral clock
  else
    spi-wait
    dup SPI.CR2 %111 5 lshift bic! \ disable interrupts
    SPI.CR1 1 6 lshift bic!        \ disable
    \ disable peripheral clock
  then
;


: init-ad
  spi1-setup-ad
  SPI1 SPI.
;
