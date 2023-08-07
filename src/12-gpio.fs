\ compiletoflash
\ Uses 01-display.fs

forgetram

\ compiletoram

compiletoflash


$40020000 constant GPIOA
$40020400 constant GPIOB
$40020800 constant GPIOC


: GPIO.MODER ( addr -- addr ) inline ;
: GPIO.OTYPER ( n -- n ) $04 + inline ;
: GPIO.OSPEEDR ( n -- n ) $08 + inline ;
: GPIO.PUPDR ( n -- n ) $0C + inline ;
: GPIO.IDR ( n -- n ) $10 + inline ;
: GPIO.ODR ( n -- n ) $14 + inline ;
: GPIO.BSRR ( n -- n ) $18 + inline ;

: GPIO.LCKR ( n -- n ) $1C + inline ;
: GPIO.AFRL ( n -- n ) $20 + inline ;
: GPIO.AFRH ( n -- n ) $24 + inline ;

: GPIO.MODER. ( addr -- )
  ." GPIO.MODER."
  GPIO.MODER 2b.
;

: GPIO.OTYPER. ( addr -- )
  ." GPIO.OTYPER."
  GPIO.OTYPER 1b.
;

: GPIO.OSPEEDR. ( addr -- )
  ." GPIO.OPEEDR."
  GPIO.OSPEEDR 2b.
;

: GPIO.PUPDR. ( addr -- )
  ." GPIO.PUPDR."
  GPIO.PUPDR 2b.
;

: GPIO. ( addr -- )
  dup GPIO.MODER.
  dup GPIO.OTYPER.
  dup GPIO.OSPEEDR.
  dup GPIO.PUPDR.
  drop
;

: gpio-pin-moder! ( mode addr pin -- )
  \ mode %00 - input
  \      %01 - GP output
  \      %10 - Alternate Function mode
  \      %11 - Analog
  1 lshift \ mode addr position \ 1st bit position
  >r \ mode addr
  GPIO.MODER
  %11 r@ lshift over bic!
  swap \ addr.MODER mode
  r> lshift swap bis!
;

: gpio-flag$ ( flag addr mask -- )
  swap
  rot
  if
    bis!
  else
    bic!
  then
;

: gpio-pin-otyper! ( flag addr pin -- )
  swap GPIO.OTYPER swap
  %1 swap lshift \ flag addr mask
  gpio-flag$
;

: gpio-pin-ospeedr! ( n addr pin -- )
  \ n = %00 - low,
  \     %01 - medium,
  \     %10 - high,
  \     %01 - very high,
  1 lshift
  >r
  GPIO.OSPEEDR
  %11 r@ lshift over bic!
  swap r> lshift
  swap
  bis!
;

: gpio-pin-pupdr! ( mode addr pin -- )
  \ mode = %00 - no pull up, no pull Down
  \        %01 - pull up
  \        %10 - pull down
  \        %11 - reserved
  1 lshift >r
  GPIO.PUPDR
  %11 r@ lshift over bic!
  swap r> lshift
  swap
  bis!
;

: gpio-pin-af! ( af addr pin -- )
  dup
  15 > if
    16 -
    swap
    GPIO.AFRH
  else
    swap
    GPIO.AFRL
  then
  \ af pin-localized addr.AH*
  >r
  2 lshift \ af position
  r@
  swap \ af addr.* pos
  %1111 over lshift \ af addr pos clearmask
  rot bic! \ af pos
  lshift r> bis!
;


: gpio-in@ ( addr -- n ) \ reads 32 bit state of all pins
  GPIO.IDR @
  inline
;

: gpio-out@ ( addr -- n ) \ reads 32 bit state of all pins
  GPIO.ODR @
  inline
;

: pin-lshift$ ( pin n -- mask ) \ Shifts n into pin's position
  swap lshift
  inline
;

: and? ( n mask - flag ) \ make and and check any 1-s
  and 0<>
  inline
;

: gpio-in-pin@ ( addr pin -- flag ) \ Reads input pin
  1 pin-lshift$
  swap
  gpio-in@ \ mask GPIO.IDR-val
  and?
  inline
;

: gpio-out-pin@ ( addr pin -- flag ) \ Reads input pin
  1 pin-lshift$
  swap
  gpio-out@ \ mask GPIO.IDR-val
  and?
  inline
;

: gpio! ( n addr -- ) \ Stores 32 bit state to all pins
  GPIO.ODR !
  inline
;

: gpio-pin-s! ( addr pin -- ) \ Sets a pin in output mode
  1 pin-lshift$
  swap GPIO.BSRR bis!
;

: gpio-pin-c! ( addr pin -- ) \ Clears a pin in output mode
  1 pin-lshift$ 16 lshift
  swap GPIO.BSRR bis!
;


: gpio-pin! ( flag addr pin -- ) \ If flag==true sets pin high, otherwise low
  rot
  if
    gpio-pin-s!
  else
    gpio-pin-c!
  then
;


\ Note, led on pin PC13 lights if its bit cleared

compiletoram
