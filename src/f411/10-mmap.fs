\ compiletoram
compiletoflash

\ forgetram

\ USES 01-display.fs

$40020000 constant GPIOA ( General-purpose I/Os )
$40020400 constant GPIOB ( General-purpose I/Os )
$40020800 constant GPIOC ( General-purpose I/Os )
$40020C00 constant GPIOD ( General-purpose I/Os )
$40021000 constant GPIOE ( General-purpose I/Os )
$40021C00 constant GPIOH ( General-purpose I/Os )

\ $40010800 constant GPIO.BASE

\ GPIOC constant GPIO.BASE
\ GPIOA constant GPIO.BASE

\ The left hand side a is GPIOx base address in the following words

\ Four configurtion registers, 32 bit each
: GPIO.MODER ( a -- a ) ( 0 + ) ;  ( GPIO port mode register )
: GPIO.OTYPER  ( a -- a ) $4 + ; ( GPIO port output type register )
: GPIO.OSPEEDR ( a -- a ) $8 + ; ( GPIO port output speed register )
: GPIO.PUPDR ( a -- a ) $C + ; ( GPIO port pull-up/pull-down register )

\ Two data registers, 32 bit each
: GPIO.IDR ( a -- a ) $10 + ; ( GPIO port Input Data Register )
: GPIO.ODR ( a -- a ) $14 + ; ( GPIO port Output Data Register )

\ Set/Reset register, 32 bit
: GPIO.BSRR ( a -- a ) $18 + ; ( GPIO port Bit Set/Reset Register )

\ Locking register, 32 bit
: GPIO.LCKR ( a -- a ) $1C + ; ( GPIO port configuration LoCK Register )

\ Two alternate function selection registers, 32 bit each
: GPIO.AFRL ( a -- a ) $20 + ; ( GPIO Alternate Function Low Register )
: GPIO.AFRH ( a -- a ) $24 + ; ( GPIO Alternate Function High Register )


\ Print register state, taken from SVD generator results.
\ a is GPIOx base address in the following words
: GPIO.MODER. ( a -- ) ." GPIO.MODER (read-write) $" GPIO.MODER @CRb. ;
: GPIO.OTYPER. ( a -- )  ." GPIO.OTYPER (read-write) $" GPIO.OTYPER @1b. ;
: GPIO.OSPEEDR. ( a -- )  ." GPIO.OSPEEDR (read-write) $" GPIO.OSPEEDR @CRb. ;
: GPIO.PUPDR. ( a -- )  ." GPIO.PUPDR (read-write) $" GPIO.PUPDR @CRb. ;
: GPIO.IDR. ( a -- )  ." GPIO.IDR (read-only) $" GPIO.IDR @1b. ;
: GPIO.ODR. ( a -- )  ." GPIO.ODR (read-write) $" GPIO.ODR @1b. ;
: GPIO.BSRR. ( a -- )  ." GPIO.BSRR (write-only) $" GPIO.BSRR @1b. ;
: GPIO.LCKR. ( a -- )  ." GPIO.LCKR (read-write) $" GPIO.LCKR @1b. ;
: GPIO.AFRL. ( a -- )  ." GPIO.AFRL (read-write) $" GPIO.AFRL @AFb. ;
: GPIO.AFRH. ( a -- )  ." GPIO.AFRH (read-write) $" GPIO.AFRH @AFb. ;

: GPIO. ( a -- ) \ n is GPIOx base address
  cr
  dup ." GPIOx base address is " hex. cr
  dup GPIO.MODER.
  dup GPIO.OTYPER.
  dup GPIO.OSPEEDR.
  dup GPIO.PUPDR.
  dup GPIO.IDR.
  dup GPIO.ODR.
\  dup GPIO.BSRR.
  dup GPIO.LCKR.
  dup GPIO.AFRL.
  dup GPIO.AFRH.
  drop
;

: pin ( pin -- mask )
  %1 swap lshift
;

: pin+ ( mask pin -- mask )
  pin or
;

: pin- ( mask pin -- mask )
  pin not and
;


\ 0 variable GPIOBUF#

\ Internal word
\ Performs setting bits defined by pin number in an address
: setup#! ( a %XY.. K*bitno %11.. -- ) \ works!
  over
  lshift \ a mode pin 000110000....
  -rot lshift \ a 000110000... mode<<2*pin
  -rot over \ mode a 00011000 a
  bic!
  bis!
;

\ Internal
: setupbit! ( a %X bitno -- ) \ works!
  %1
  setup#!
;

\ Internal
: setup2bit! ( a %XX bitno -- ) \ works!
  1 lshift     \ mode has 2 bits per pin
  %11
  setup#!
;

\ Internal
: setup4bit! ( a %XX bitno -- ) \ works!
  2 lshift     \ mode has 4 bits per pin
  %1111
  setup#!
;


: gpio-mode! ( GPIOa pin mode -- ) \ works!
  \ mode: %01 - output
  \       %10 - alternate function
  \       %00 - input
  \       %11 - reserved (do not use)
  \ pin: 0 .. 15
  swap
  rot GPIO.MODER -rot
  setup2bit!
;

: gpio-otype! ( GPIOa pin type )
  \ type: 0 - output push-pull ( default )
  \       1 - output open-drain
  swap
  rot GPIO.OTYPER -rot
  setupbit!
;

: gpio-ospeed! ( GPIOa pin speed )
  \ speed: %00 - low speed
  \        %01 - medium speed
  \        %10 - fast speed
  \        %11 - high speed
  swap
  rot GPIO.OSPEEDR -rot
  setup2bit!
;

: gpio-pupd! ( GPIOa pin mode )
  \ mode: %00 - no pull-up, no pull-dowb
  \       %01 - pull-up
  \       %10 - pull-down
  \       %11 - reserved (do not use )
  swap
  rot GPIO.PUPDR -rot
  setup2bit!
;

: gpio-af! ( GPIOa pin fun )
  \ fun (4bit):  #7 USART
  \              #5 SPI

  swap \ a f p
  rot  \ f p a
  over \ f p a p
  7 <= if
    GPIO.AFRL \ f p aL
  else
    GPIO.AFRH
    swap 8 -
    swap \ f p-8 aH
  then
  -rot
  setup4bit!
;

\ TODO: does not work
: gpio-out! ( GPIOa pin val -- )
  \ pin: 0..15
  \ val: %0, %1
  swap
  rot GPIO.ODR -rot
  setupbit!
;

: gpio-bsr! ( GPIOa pin val -- )
  \ pin: 0, 15
  \ val: %0, %1
  if
    nop
  else
    16 +
  then
  1 swap lshift
  swap GPIO.BSRR !
;

$40004400 constant USART2
: USART.BRR $8 + ;

$40023C00 constant FLASH.ACR \ Flash Access Control Register
$40023800 constant RCC ( Reset and clock control )

: RCC.CR ;
: RCC.PLLCFGR $4 + ;
: RCC.CFGR $8 + ;
: RCC.AHB1LPENR ( RCCa -- RCC_AHB1LPENRa) $50 + ; ( AHB1 peripheral clock enable in low power mode register )
: RCC.AHB1ENR ( RCCa -- RCC_AHB1ENRa) $30 + ; ( AHB1 peripheral clock enable register )
: RCC.APB1ENR ( RCCa -- RCC_AHB1ENRa) $40 + ; ( APB1 peripheral clock enable register )
: RCC.APB2ENR ( RCCa -- RCC_AHB2ENRa) $44 + ; ( APB2 peripheral clock enable register )

: RCC.CR. ." RCC.CR (read-write) $" RCC RCC.CR @1b. ;
: RCC.PLLCFGR. ." RCC.PLLCFGR (read-write) $" RCC RCC.PLLCFGR @1b. ;
: RCC.CFGR. ." RCC.CFGR (read-write) $" RCC RCC.CFGR @1b. ;
: RCC.AHB1LPENR. ." RCC.AHB1LPENR (read-write) $" RCC RCC.AHB1LPENR @1b. ;
: RCC.AHB1ENR. ." RCC.AHB1ENR (read-write) $" RCC RCC.AHB1ENR @1b. ;
: RCC.APB1ENR. ." RCC.APB1ENR (read-write) $" RCC RCC.APB1ENR @1b. ;
: RCC.APB2ENR. ." RCC.APB2ENR (read-write) $" RCC RCC.APB2ENR @1b. ;

: RCC.
  \ RCC.AHB1LPENR.
  RCC.CR.
  RCC.PLLCFGR.
  RCC.CFGR.
  RCC.AHB1ENR.
  RCC.APB1ENR.
  RCC.APB2ENR.
;


\ Internal
: rcc-en#! ( GPIOn %X RCCa -- )
  >r \ n %X
  over 1 swap lshift \ n %x 1<<n
  r@ bic!
  swap lshift
  r> bis!
;

: rcc-en! ( GPIOn %X -- )
  \ GPIOn $0 - GPIOA
  \       $1 - GPIOB
  \       $2 - GPIOC
  \       $3 - GPIOD
  \       $4 - GPIOD
  \       $7 - GPIOH
  \ %X - 1 (enable clock), 0 (disable clock)
  RCC RCC.AHB1ENR
  rcc-en#!
;

: rcc-lpen! ( GPIOn %X -- )
  \ GPIOn $0 - GPIOA
  \       $1 - GPIOB
  \       $2 - GPIOC
  \       $3 - GPIOD
  \       $4 - GPIOD
  \       $7 - GPIOH
  RCC RCC.AHB1LPENR
  rcc-en#!
;

$40013000 constant SPI1 ( Serial peripheral interface )
$40003800 constant SPI2 ( Serial peripheral interface )
$40003C00 constant SPI3 ( Serial peripheral interface )
$40013400 constant SPI4 ( Serial peripheral interface )
$40015000 constant SPI5 ( Serial peripheral interface )

: SPI.CR1 ( SPIa -- SPI_CR1s ) $0 + ; ( control register 1 )
: SPI.CR2 $4 + ; ( control register 2 )
: SPI.SR $8 + ; ( status register )
: SPI.DR  $C + ; ( data register )
: SPI.CRCPR $10 + ; ( CRC polynomial register )
: SPI.RXCRCR $14 + ; ( RX CRC register )
: SPI.TXCRCR $18 + ; ( TX CRC register )
: SPI.I2SCFGR $1C + ; ( I2S configuration register )
: SPI.I2SPR $20 + ; ( I2S prescaler register )

: SPI.CR1. ( SPIa -- ) ." SPI.CR1 (read-write) $" SPI.CR1 @1b. ;
: SPI.CR2. ." SPI.CR2 (read-write) $" SPI.CR2 @1b. ;
: SPI.SR. ." SPI.SR (read) $" SPI.SR @1b. ;
: SPI.DR. ." SPI.DR (read-write) $" SPI.DR @1b. ;
: SPI.CRCPR. ." SPI.CRCPR (read-write) $" SPI.CRCPR @1b. ;
: SPI.RXCRCR. ." SPI.RXCRCR (read-only) $" SPI.RXCRCR @1b. ;
: SPI.TXCRCR. ." SPI.TXCRCR (read-only) $" SPI.TXCRCR @1b. ;
: SPI.I2SCFGR. ." SPI.I2SCFGR (read-write) $" SPI.I2SCFGR @1b. ;
: SPI.I2SPR. ." SPI.I2SPR (read-write) $" SPI.I2SPR @1b. ;
: SPI. ( SPIa -- )
  cr
  dup ." SPI Base addres is " hex. cr
  dup SPI.CR1.
  dup SPI.CR2.
  dup SPI.SR.
  dup SPI.DR.
  dup SPI.CRCPR.
  dup SPI.RXCRCR.
  dup SPI.TXCRCR.
  dup SPI.I2SCFGR.
  dup SPI.I2SPR.
  drop
;

compiletoram
