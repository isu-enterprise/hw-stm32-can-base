
\ LED example

$40020800 constant GPIOC ( General-purpose I/Os )

GPIOC constant GPIO-BASE ( A,B,C,D,E, H0,H1 also )

\ $40010800 constant GPIO-BASE

\ GPIOC constant GPIO-BASE
\ GPIOA constant GPIO-BASE

\ The left hand side a is GPIOx base address in the following words

\ Four configurtion registers, 32 bit each
: MODER ( a -- a ) ( 0 + ) ;  ( GPIO port mode register )
: OTYPER  ( a -- a ) $4 + ; ( GPIO port output type register )
: OSPEEDR ( a -- a ) $8 + ; ( GPIO port output speed register )
: PUPDR ( a -- a ) $C + ; ( GPIO port pull-up/pull-down register )

\ Two data registers, 32 bit each
: IDR ( a -- a ) $10 + ; ( GPIO port Input Data Register )
: ODR ( a -- a ) $14 + ; ( GPIO port Output Data Register )

\ Set/Reset register, 32 bit
: BSRR ( a -- a ) $18 + ; ( GPIO port Bit Set/Reset Register )

\ Locking register, 32 bit
: LCKR ( a -- a ) $1C + ; ( GPIO port configuration LoCK Register )

\ Two alternate function selection registers, 32 bit each
: AFRL ( a -- a ) $20 + ; ( GPIO Alternate Function Low Register )
: AFRH ( a -- a ) $24 + ; ( GPIO Alternate Function High Register )


\ Print register state, taken from SVD generator results.
\ a is GPIOx base address in the following words
: GPIO-MODER. ( a -- ) ." GPIO-MODER (read-write) $" dup MODER @ hex. MODER 1b. ;
: GPIO-OTYPER. ( a -- )  ." GPIO-OTYPER (read-write) $" dup OTYPER @ hex. OTYPER 1b. ;
: GPIO-OSPEEDR. ( a -- )  ." GPIO-OSPEEDR (read-write) $" dup OSPEEDR @ hex. OSPEEDR 1b. ;
: GPIO-PUPDR. ( a -- )  ." GPIO-PUPDR (read-write) $" dup PUPDR @ hex. PUPDR 1b. ;
: GPIO-IDR. ( a -- )  ." GPIO-IDR (read-only) $" dup IDR @ hex. IDR 1b. ;
: GPIO-ODR. ( a -- )  ." GPIO-ODR (read-write) $" dup ODR @ hex. ODR 1b. ;
: GPIO-BSRR. ( a -- )  ." GPIO-BSRR (write-only) $" dup BSRR @ hex. BSRR 1b. ;
: GPIO-LCKR. ( a -- )  ." GPIO-LCKR (read-write) $" dup LCKR @ hex. LCKR 1b. ;
: GPIO-AFRL. ( a -- )  ." GPIO-AFRL (read-write) $" dup AFRL @ hex. AFRL 1b. ;
: GPIO-AFRH. ( a -- )  ." GPIO-AFRH (read-write) $" dup AFRH @ hex. AFRH 1b. ;

: GPIO. ( a -- ) \ n is GPIOx base address
  dup ." GPIOx base address is " hex. cr
  dup GPIO-MODER.
  dup GPIO-OTYPER.
  dup GPIO-OSPEEDR.
  dup GPIO-PUPDR.
  dup GPIO-IDR.
  dup GPIO-ODR.
  dup GPIO-BSRR.
  dup GPIO-LCKR.
  dup GPIO-AFRL.
  dup GPIO-AFRH.
  drop
;

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
  2*     \ mode has 2 bits per pin
  %11
  setup#!
;


: gpio-mode! ( GPIOa pin mode -- ) \ works!
  \ mode: %01 - output
  \       %10 - alternate function
  \       %00 - input
  \       %11 - reserved (do not use)
  \ pin: 0 .. 15
  swap
  rot MODER -rot
  setup2bit!
;

: gpio-otyper! ( GPIOa pin type )
  \ type: 0 - output push-pull ( default )
  \       1 - output open-drain
  swap
  rot OTYPER -rot
  setupbit!
;

: gpio-ospeedr! ( GPIOa pin speed )
  \ speed: %00 - low speed
  \        %01 - medium speed
  \        %10 - fast speed
  \        %11 - high speed
  swap
  rot OSPEEDR -rot
  setupbit!
;

: gpio-pupdr ( GPIOa pin mode )
  \ mode: %00 - no pull-up, no pull-dowb
  \       %01 - pull-up
  \       %10 - pull-down
  \       %11 - reserved (do not use )
  swap
  rot PUPDR -rot
  setupbit!
;

\ TODO: does not work
: gpio-out! ( GPIOa pin val -- )
  \ pin: 0..15
  \ val: %0, %1
  swap
  rot ODR -rot
  setupbit!
;

: gpio-bsrr! ( GPIOa pin val -- )
  \ pin: 0, 15
  \ val: %0, %1
  if
    nop
  else
    16 +
  then
  1 swap lshift
  swap BSRR !
;


$40023800 constant RCC ( Reset and clock control )

: AHB1LPENR ( RCCa -- RCC_AHB1LPENRa) $50 + ; ( AHB1 peripheral clock enable in low power mode register )
: AHB1ENR ( RCCa -- RCC_AHB1ENRa) $30 + ; ( AHB1 peripheral clock register )

: AHB1LPENR. ." RCC-AHB1LPENR (read-write) $" RCC AHB1LPENR @ hex. RCC AHB1LPENR 1b. ;
: AHB1ENR. ." RCC-AHB1ENR (read-write) $" RCC AHB1ENR @ hex. RCC AHB1ENR 1b. ;

\ Internal
: rcc-en#! ( GPIOn %X RCCa -- )
  >r \ n %X
  over 1 swap lshift \ n %x 1<<n
  r@ bic!
  swap lshift
  r> bis!
;

: rcc-enr! ( GPIOn %X -- )
  \ GPIOn $0 - GPIOA
  \       $1 - GPIOB
  \       $2 - GPIOC
  \       $3 - GPIOD
  \       $4 - GPIOD
  \       $7 - GPIOH
  \ %X - 1 (enable clock), 0 (disable clock)
  RCC AHB1ENR
  rcc-en#!
;

: rcc-lpen! ( GPIOn %X -- )
  \ GPIOn $0 - GPIOA
  \       $1 - GPIOB
  \       $2 - GPIOC
  \       $3 - GPIOD
  \       $4 - GPIOD
  \       $7 - GPIOH
  RCC AHB1LPENR
  rcc-en#!
;

: gpio-test
  \ TODO: SET gpio-clk via RCC_BASE and RCC_AHB1ENR
  $2 1 rcc-enr!
  GPIOC 13
  2dup %01 gpio-mode!
  2dup %0 gpio-otyper!
  2dup %1 gpio-out!
  2dup %1 gpio-bsrr!
  drop
  GPIO.
  AHB1ENR.
;


\ User LD2: the green LED is a user LED connected to Arduino signal D13 corresponding to
\ MCU I/O PA5 (pin 21) or PB13 (pin 34) depending on the STM32 target.
\ On the Nucleo F103RB, this is PA5.

\ : blinky ( -- )

\   %01 6 io-mode! \ Set LED Pin mode to output

\   begin
\     1 6 lshift GPIO.ODR xor!
\     500000 0 do loop
\   key? until
\ ;
