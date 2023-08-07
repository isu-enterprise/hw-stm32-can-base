\ Uses 02-gpio.fs

compiletoram
: LED-ADDR GPIOC inline ;
: led LED-ADDR 13 inline ;


: led-setup
  %01 led gpio-pin-moder!
  %0  led gpio-pin-otyper!
  %00 led gpio-pin-ospeedr!
  %00 led gpio-pin-pupdr!
;

: led-on?
  led gpio-out-pin@
;

: led-toggle
  led-on? not
  led gpio-pin!
;

: led-delay
  1000000 0 do loop
  inline
;

: led-off
  led gpio-pin-s!
;

: led-test
  led-setup
  cr
  ." Led on blue pill board will blink until a key pressed..."
  cr
  begin
    led-toggle
    led-delay
    key?
  until
  led-off
;
