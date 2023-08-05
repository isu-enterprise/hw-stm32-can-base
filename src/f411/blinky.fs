

\ https://git.drak.xyz/flabbergast/forth-mecrisp

\ LED example

\ forgetram

\ USES 00-mmap.fs constants and routines

GPIOC constant LED.GPIO ( A,B,C,D,E, H0,H1 also )
$2 constant LED.EN
13 constant LED.PIN

: gpio-test
  \ TODO: SET gpio-clk via RCC_BASE and RCC_AHB1ENR
  LED.EN %1 rcc-en!
  LED.GPIO LED.PIN
  2dup %01 gpio-mode!
  2dup %0 gpio-otype!
  2dup %0 gpio-out!
  \ 2dup %1 gpio-bsrr!
  drop
  cr cr
  GPIO.
  RCC.
;

: blinky-init ( -- )
  LED.PIN %1 rcc-en! \ enable clock on GPIOC
  LED.GPIO LED.PIN      \ LED PIN address
  2dup %01 gpio-mode!  \ OUTPUT mode
  2dup %0 gpio-otype! \ PUSH-PULL mode
  2drop
;


\ User LD2: the green LED is a user LED connected to Arduino signal D13 corresponding to
\ MCU I/O PA5 (pin 21) or PB13 (pin 34) depending on the STM32 target.
\ On the Nucleo F103RB, this is PA5.

: blinky ( -- )

  blinky-init

  begin
    LED.GPIO GPIO.ODR 1 LED.PIN lshift swap xor!
    GPIOC GPIO.ODR.
    5000000 0 do loop
  key? until
;
