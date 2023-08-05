\ Uses

compiletoram
\ forgetram

: tft-init
  ti-init
  spi3-high-speed!
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
  $36 1 $36 tft! \ Mem access control \ default
  \ $48 1 $36 tft! \ Mem access control
  \ $55 1 $3A tft! \ 16bit/Pixel interface format ||
  $66 1 $3A tft! \ 18bit/Pixel interface format ||
  $00 1 $B0 tft! \ Interface mode control
  $a0 1 $B1 tft! \ Frame rate
  $02 1 $B4 tft! \ Display inversion control
  $3b $02 $02 3 $B6 tft! \ Display function control
  $c6 1 $B7 tft! \ Entry mode
  $82 $2c $51 $a9 4 $F7 tft! \ Adjust control 3

  \ tft-win-max

  \ 0 $21 tft! \ Display Inversion ON
  0 $20 tft! \ Display Inversion OFF

  0 $11 tft! \ Sleep out
  50000 0 do loop
  0 $29 tft! \ Display on
  50000 0 do loop
;

480 constant TFT.SCR.W
320 constant TFT.SCR.H

: tft-full-rect ( -- )
  TFT.SCR.H 1- 0 TFT.SCR.W 1- 0 tft-rect \ 153600 pixels
;

: tft-bkg ( B G R -- ) \ Fill background wit a color
  tft-full-rect
  TFT.SCR.H TFT.SCR.W *
  tft-fill
;

\ MY MX MV ML BGR MH X X
\ 0  1  0  0   1  1  0 0
: tft-ma-portrait ( -- )
   $48 1 $36 tft! \ Mem access control
;

\ MY MX MV ML BGR MH X X
\ 0  0  1  1   1  1  1 0
: tft-ma-landscape ( -- )
  $3e 1 $36 tft! \ Mem access control
;

: fcnt ( n -- ) \ List font array
  0 ?do
    font16x30
    i 2 lshift \ 4 *
    + \ Addr of a word
    @
    i . ." : $" hex. cr
  loop
;

30 constant FONT.HEIGHT
\ 15 constant FONT.LC  \ Line count
16 constant FONT.WIDTH

\ : b16sloop. ( u -- ) \ print 16 lower bits in 1 bit groups
\ 0  <#
\ 15 0 DO
\ # LOOP
\ # #>
\ TYPE ;

: b16sloop. ( u -- )
  16 0 do
    dup 1 i lshift and 0 >
    if
      space
    else
      35 emit \ #
    then
  loop
  drop
;

255 variable TFT.F.R
255 variable TFT.F.G
255 variable TFT.F.B

0 variable TFT.B.R
0 variable TFT.B.G
0 variable TFT.B.B

: tft-f! ( B G R -- )
  TFT.F.R !
  TFT.F.G !
  TFT.F.B !
;

: tft-b! ( B G R -- )
  TFT.B.R !
  TFT.B.G !
  TFT.B.B !
;

: tft-f@ ( -- B G R )
  TFT.F.B @
  TFT.F.G @
  TFT.F.R @
;

: tft-b@ ( -- B G R )
  TFT.B.B @
  TFT.B.G @
  TFT.B.R @
;

: tft-pixel#! ( bool -- ) \ true - fore color pixel, false elsewhere.
  if
    tft-f@
    \ space
  else
    tft-b@
    \ 35 emit
  then
  3 tft-data!
;

: tft-gl# ( u -- ) \ emits scan line to TFT
  16 0 do
    dup %1000000000000000 i rshift and 0 >
    tft-pixel#!
  loop
  drop
  \ ." |"
;

: tft-draw-start# \ Send command to accept pixel data
  0 $2C tft-pre! \ Start write glyph
;

: tft-glyph ( u y x -- ) \ draws glyph form table
  \ .s cr
  dup FONT.WIDTH + 1- swap
  tft-def-x
  dup FONT.HEIGHT + 1- swap
  tft-def-y
  tft-fini!
  \ .s cr
  FONT.HEIGHT *
  1 lshift
  font16x30 + \ addr
  \ h.s cr
  tft-draw-start#
  \ h.s cr
  FONT.HEIGHT 0 do
    \ dup h@
    \ dup bin.
    dup i 2* + h@
    \ dub b16sloop. cr
    tft-gl#
    \ 2+
  loop
  drop
  tft-fini!
;

0 variable TFT.CUR.X
0 variable TFT.CUR.Y

: tft-emit ( u -- )
  dup 13 = if \ cr
    TFT.CUR.Y @ FONT.HEIGHT +
    TFT.CUR.Y !
    0 TFT.CUR.X !
    drop
    exit
  then
  32 -  \ Latin char
  TFT.CUR.Y @
  TFT.CUR.X @
  tft-glyph
  TFT.CUR.X @ FONT.WIDTH +
  TFT.CUR.X !
  TFT.CUR.X @ 463 > if
    TFT.CUR.Y @ FONT.HEIGHT +
    TFT.CUR.Y !
    0 TFT.CUR.X !
  then
  TFT.CUR.Y @ 289 > if
    0 TFT.CUR.Y !
    0 TFT.CUR.X !
  then
;

: tft-clear ( -- )
  tft-b@ tft-bkg
  0 TFT.CUR.X !
  0 TFT.CUR.Y !
;

: t-i
  tft-init
  64 0 0 tft-b!
;

: t-t
  255 255 255 tft-b!
  0   0   255 tft-f!
  ." Type, ESC - exit:" cr
  begin
    key dup 27 = if drop exit then
    tft-emit
  again
;

: t
  t-i
  tft-clear
  t-t
;

: tft-char-con ( n -- ) \ writes 30 lines of n-th char
  \ representation
  cr
  FONT.HEIGHT * \ Line no of the first line
  1 lshift \ 2*, address offset
  font16x30 + \ address
  h.s cr
  binary
  FONT.HEIGHT 0 do
    \ dup i + @ binary . decimal cr
    dup i 2* + h@
    b16sloop.
    cr
  loop
  drop \ address of the first line
  decimal
;

: tft-chars-con
  224 0 do
    cr
    ." Char: " i . space i hex. cr
    i tft-char-con
    key 113 = if leave then
  loop
;

: tft-type ( c-addr length -- ) \ Typeout string to tft
  0 ?do
    dup c@ tft-emit
    1+
  loop
  drop
;

: tft-locate ( y x -- ) \ Locate cursor on TFT
  FONT.WIDTH * TFT.CUR.X !
  FONT.HEIGHT * TFT.CUR.Y !
;

\ 4 bytes per 30 pixels of mono
4 TFT.SCR.W * constant CBUF.M
0 variable CBUF.L
create CBUF CBUF.M allot

: tft-accept ( -- )
  CBUF CBUF.M accept
  CBUF.L !
;

1 29 lshift constant TFT.HI.BIT

: tft-bar-draw# ( n -- )
  \ Draw n highest bit - highest position
  30 0 do
    dup TFT.HI.BIT i rshift and 0 >
    tft-pixel#!
  loop
  drop
;

: tft-bar-draw ( abuf y x -- )
  \ Draw 4-byte, 30 pixel vertical bar at x,y
  dup tft-def-x
  dup 29 + swap tft-def-y
  tft-fini!
  tft-draw-start#
  @
  tft-bar-draw#
  tft-fini!
;

: tft-buf-draw ( abuf n -- )
  \ number of 30 bit pixel bars in abuf
  \ at the cursor. Cursor does not move
  \ highest bit highest position on the screen
  dup -rot  \ n abuf n
  0 ?do  \ n abuf
    dup TFT.CUR.Y @ TFT.CUR.X @ i + tft-bar-draw
    4 + \ shift to 4 bytes the abuf
  loop \ s: n abuf
  drop \ s: n
  TFT.CUR.X @ + \ b+cur.x
  dup TFT.SCR.W 1- > if
    drop
    0 TFT.CUR.X !
    TFT.CUR.Y @ 1+ TFT.CUR.Y !
    \ TODO: Check TFT.CUR.Y out of screen
  else
    TFT.CUR.X !
  then
;

: cbuf-fill ( -- )
  1 CBUF
  TFT.SCR.W 0 do
    2dup \ 1 CBUF 1 CBUF
    !
    4 + swap \ CBUF 1
    rol swap \ %10 CBUF
  loop
  2drop
;

\ DEBUGGING FOR FONT OUTPUT

: tft-type-con
  begin
    key dup 27 =
    if
      drop
      exit
    then
    32 -
    tft-char-con
  again
;

: tcon ( -- ) \ test console
  tft-type-con
;


compiletoram
