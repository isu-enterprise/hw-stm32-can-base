
compiletoram
forgetram

\ Controlling TFT ini over SPI3 with two 595 registers
\ USES 595.fs

\ ti = TFT Interface

\ WR  RD  RS CS RST
\ 15  14  13 12 11 | 10 9 8 || 7..0
\  7   6   5  4  3 | 210/8  || data/8
1 15 lshift CONSTANT TFT.WR
1 14 lshift CONSTANT TFT.RD
1 13 lshift CONSTANT TFT.RS
1 12 lshift CONSTANT TFT.CS
1 11 lshift CONSTANT TFT.RST

$FFFF VARIABLE TFT.REG

: tft-d@ ( -- c/data )
  TFT.REG @ $FF and
;

: tft-c@ ( -- c/control )
  TFT.REG @ 8 rshift $FF and
;

: tft-d! ( c/data -- )
  $ff TFT.REG bic!
  TFT.REG bis!
;

: tft-c! ( c/control -- )
  $FF00 TFT.REG bic!
  $FF and 8 lshift
  TFT.REG bis!
;

: tw
   5000 0 do loop
;

: >tft ( -- )  \ send TFT.REG to spi3
  TFT.REG @
  ." > "
  dup hex. space
  >reg> drop
  tw
;

\ TFT actually starts here

: tft.
  ." TFT.REG"
  TFT.REG @ bin.
;

: tft-reset
  0 TFT.REG !
  reg-conn
  $ff tft-c! >tft
  TFT.RST TFT.REG bic!
  >tft
  500 0 do loop
  $ff tft-c! >tft
;

: tft-csx
  TFT.CS TFT.REG bic!
  >tft
;

: -tft-csx
  TFT.CS TFT.REG bis!
  >tft
;

: tft-cmd! ( cmd -- )
  tft-d!
  TFT.WR TFT.RS or
  TFT.REG bic!
  >tft
  TFT.WR TFT.REG bis! \ WR /
  >tft
  TFT.RS TFT.REG bis! \ RS /
  >tft
;

: tft-dw! ( D -- )  \ Lower
  tft-d!
  TFT.RD TFT.RS or TFT.REG bis!
  TFT.WR TFT.REG bic!
  >tft
  TFT.WR TFT.REG bis!
  >tft
;

: tft! ( Dn-1 ... D0 n cmd - )
  cr ." |"
  tft-csx
  \ ." CMD:" dup hex. cr
  tft-cmd!
  \ .s cr
  0 ?do
    \ dup hex. bl emit
    tft-dw!
  loop
  \ cr
  -tft-csx
  cr cr
;


: tft-win-max
;


: tft-init
  reg-init
  reg-conn
  spi3-high-speed!
  \ spi3-low-speed!
  tft-reset
  50000 0 do loop
  0 1 tft!   \ !sw reset
  50000 0 do loop
  0 $28 tft! \ !Display off
  \ Start init sequence
  $0f $1a $16 $08
  $0a $09 $4c $78
  $3f $0a $16 $08
  $09 $03 $00
  15 $E0 \ !Positive gamma corr
  tft!
  $0f $37 $35 $0d
  $0e $04 $46 $45
  $32 $05 $0f $03
  $19 $16 $00
  15 $E1 \ !Negative ...
  tft!

  $15 $17 2 $C0 tft! \ Power CTRL 1
  $41 1 $C1 tft! \ Pwr CTRL 2
  $80 $12 $00 3 $C5 tft! \ !VCOM CTRL
  $48 1 $36 tft! \ Mem access control
  \ $55 1 $3A tft! \ 16bit/Pixel interface format ||
  $66 1 $3A tft! \ 18bit/Pixel interface format ||
  $00 1 $B0 tft! \ Interface mode control
  $a0 1 $B1 tft! \ Frame rate
  $02 1 $B4 tft! \ Display inversion control
  $3b $02 $02 3 $B6 tft! \ Display function control
  $c6 1 $B7 tft! \ Entry mode
  $82 $2c $51 $a9 4 $F7 tft! \ Adjust control 3

  tft-win-max

  0 $11 tft! \ Sleep out
  50000 0 do loop
  0 $29 tft! \ Display on
  50000 0 do loop
;


: int2bytes ( int/16 -- byteL/8 byteH/8 ) \ ? MSB!
  dup
  8 rshift $FF and
  swap
  $FF and
  swap
;

: tft-pixel ( B G R y x -- )
  dup 1+ swap >r \ x+1 R:x
  int2bytes r> \ bh+ bl+ x
  int2bytes \ bh+ bl+ bh bl
  4 $2A tft!
  dup 1+ swap >r
  int2bytes r>
  int2bytes
  4 $2B tft!
  3 $2C tft!
;

: tft-vline ( B G R y x1 x0 -- )
  2dup < if swap then
  swap 1+ swap
  do
    \ i . cr
    2over 2over i tft-pixel
  loop
  2drop 2drop
;


\ Testing assets

: it
  tft-init
;
: t
  ." Pixel test"
  $00 $FF $00 100 100 tft-pixel
  ." Done" cr
  ." Vline test"
  $00 $00 $00 10 100 0 tft-vline
  ." Done" cr
;


: tft-diag ( n -- )
  0 do
    $00 $FF $00 i i tft-pixel
  loop
;


: tft-clear
  320 0 do
    480 0 do
      0 0 0 j i tft-pixel
    loop
  loop
;


: reg-cnt
  256 0 do
    i 8 lshift i or dup hex. space
     >reg> hex. cr
    tw
  loop
;


: blcsx
  100 0 do
    tft-csx
    tw
    -tft-csx
    tw
  loop

;

compiletoram
