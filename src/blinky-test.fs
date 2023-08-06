\ Uses 02-gpio.fs

compiletoram
: led-addr GPIOC inline ;
: led led-addr 13 inline ;


: led-setup
  led %01 %00 gpio-setup \ %01=Output 10Mhz, %00-Push-pull
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
;
