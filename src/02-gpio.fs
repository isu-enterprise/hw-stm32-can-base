\ compiletoflash

compiletoram
forgetram

$40010800 constant GPIOA
$40010C00 constant GPIOB
$40011000 constant GPIOC
\ $40011400 constant GPIOD
\ $40011800 constant GPIOE
\ $40011C00 constant GPIOF
\ $40012000 constant GPIOG

: GPIO.CRL ( addr -- addr ) ;
: GPIO.CRH ( n -- n ) $04 + ;
: GPIO.IDR ( n -- n ) $08 + ;
: GPIO.ODR ( n -- n ) $0C + ;
: GPIO.BSRR ( n -- n ) $10 + ;
: GPIO.BRR ( n -- n ) $14 + ;
: GPIO.LCKR ( n -- n ) $18 + ;

: GPIO.CRL. ( addr -- )
  GPIO.CRL CRb.
;

: GPIO.CRH. ( addr -- )
  GPIO.CRH CRb.
;

: gpio-setup ( addr pin mode conf -- )
  2 lshift or \ addr pin code
  -rot
  dup 7 > if
    8 -
    swap
    GPIO.CRH
  else
    swap
    GPIO.CRL
  then
  -rot
  \ addr.CR* code pin
  2 lshift \ addr.CR* code shift
  >r
  over %1111 r@ lshift swap bic! \ clear setup bits
  r>
  lshift \ addr.CR* mask
  swap bis!
;

: gpio@ ( addr -- n ) \ reads 32 bit state of all pins
  GPIO.IDR @
;

: pin-lshift$ ( pin n -- mask ) \ Shifts n into pin's position
  swap lshift
;

: gpio-pin@ ( addr pin -- Flag ) \ Reads pin
  1 pin-lshift$
  swap
  gpio@ \ mask GPIO.IDR-val
  or 0<>
;

: gpio! ( n addr -- ) \ Stores 32 bit state to all pins
  GPIO.ODR !
;

: gpio-pin! ( Flag addr pin -- ) \ If flag==true sets pin high, otherwise low
  1 pin-lshift$
  swap GPIO.BSRR
  \ Flag mask addr.BSRR
  -rot
  swap
  \ addr.BSRR mask Flag
  not
  if
    16 lshift
  then
  swap bis!
;

: gpio-pin-s! ( addr pin -- ) \ Sets a pin in output mode
  true -rot
  gpio-pin!
;

: gpio-pin-c! ( addr pin -- ) \ Clears a pin in output mode
  false -rot
  gpio-pin!
;

\ Note, led on pin PC13 lights if its bit cleared
