
compiletoram
forgetram

\ Controlling MCP23S17 over SPI3
\ USES mcp.fs

: _dr ;     \ A
: _cr 1+ ;  \ B

$00 constant IODIR \ I/O Direction reg. r/w 1 - input, 0 - output
$02 constant IPOL  \ Input polarity reg. rw 1 - invert input, 0 - no inversion
$04 constant GPINTEN \ Interrupt on change control reg, rw, 1 is set.
$06 constant DEFVAL \ Default compare value for GPINTEN. Opposite val cause int.
$08 constant INTCON \ Interrupt control reg. 1 - compare against defval, 0 - against prev val
$0A constant IOCON \ Configure device
$0C constant GPPU  \ Pull up register 1 - pulls 100K for inputs
$0E constant INTF  \ Interrupt flag reg. 1 - Int enabled on pin.
$10 constant INTCAP \ Interrupt capture reg. ro.
$12 constant GPIO  \ Port register.
$14 constant OLAT  \ Output latch. Read from OLAT (not port). Writing is for output.


\ ti = TFT Interface

true variable TI.DR  \ Mode for Data Register. false - write, true - read

: ti-data-write
  TI.DR @ if       \ Is the prev state read?
    \ ." init DR" cr
    0 IODIR _dr mcp! \ Data register set as output
    false TI.DR !
  then
;

: ti-data-read
  TI.DR @ not if   \ Is the prev state not read (write)?
    $ff IODIR _dr mcp!    \ Data register set as output
    true TI.DR !
  then
;

: ti-ctrl-write
  0 IODIR _cr mcp!
;

: ti-ctrl-read        \ UNUSED
  $ff IODIR _cr mcp!
;

: ti-data-iocon! ( byte -- )
  IOCON _dr mcp!
;

: ti-ctrl-iocon! ( byte -- )
  IOCON _cr mcp!
;

: ti-poll-mode ( -- )
  %00100000
  dup ti-data-iocon!
      ti-ctrl-iocon!
;

: ti-switch-mode ( -- )
  %00000000
  dup ti-data-iocon!
      ti-ctrl-iocon!
;

: ti-init        \ init TFT interface
  mcp-init
  ti-poll-mode
  true TI.DR !
  ti-data-write
  ti-ctrl-write
;

: ti-dr! ( byte -- )  \ Write to _dr
  ti-data-write
  GPIO _dr mcp!
;

: ti-dr@ ( -- byte )  \ Read from _dr
  ti-data-read
  GPIO _dr mcp@
;

: ti-cr! ( byte -- )  \ Write to _cr
  GPIO _cr mcp!
;

: ti-pre! ( -- ) \ write GPIO PREAMBLE and do not raise MCP-CS
  mcp-start
  0 mcp-read-bit
  >spi3> drop   \ Dev addr + write bit
  GPIO _cr >spi3> drop \ MCP.GPIOB (TFT CMD) register address
;

: ti-pre@ ( -- ) \ write cmd read bytes
  mcp-start
  1 mcp-read-bit
  >spi3> drop
  GPIO _cr >spi3> drop
;

: ti-blink ( -- )  \ Test blinking
  ti-init
  100 0 do
    $00 dup ti-dr! ti-cr!
    $ff dup ti-dr! ti-cr!
  loop
  $00 ti-dr!
;


\ TFT actually starts here

\ 0 variable TFT.DR
                  \  4   3   2   1   0
0 variable TFT.CR \ rst csx, rs, wr, rd

: tft-cr!  \ Write TFT.CR to ti_cr
  TFT.CR @ ti-cr!
;

: tft-reset
  $ff TFT.CR !
  1 5 lshift TFT.CR bic!
  tft-cr!
  500 0 do loop
  $ff TFT.CR !
  tft-cr!
;

: tft-csx
  \ ti-pre!
  1 3 lshift TFT.CR bic!
  \ tft-cr!
  TFT.CR @
  >spi3> drop
  0 >spi3> drop \ skip data
;

: -tft-csx
  1 3 lshift TFT.CR bis!
  \ tft-cr!
  TFT.CR @
  >spi3> drop
  \ mcp-stop
;

: tft-cmd! ( cmd -- )
  %11 1 lshift \ RS, WR _
  TFT.CR bic!
  TFT.CR @ >spi3> drop
  dup >spi3> drop \ Drop answer to cmd
  \ tft-cr!
  \ ti-dr!
  1 1 lshift TFT.CR bis! \ WR /
  \ tft-cr!
  TFT.CR @ >spi3> drop
  dup >spi3> drop \ a copy of data
  1 2 lshift TFT.CR bis! \ CMD _-
  TFT.CR @ >spi3> drop
  >spi3> drop \ a copy of data
;

: tft-dw! ( D -- )  \ Lower
  %101 TFT.CR bis!
  %010 TFT.CR bic!
  TFT.CR @ >spi3> drop
  \ tft-cr!
  \ ti-dr!
  dup >spi3> drop
  %010 TFT.CR bis!
  TFT.CR @ >spi3> drop
  >spi3> drop
  \ tft-cr!
;


: tft-dr@ ( -- D ) \ Data Read
  %110 TFT.CR bis!
  %001 TFT.CR bic!
  tft-cr!
  %001 TFT.CR bis!
  tft-cr!
  ti-dr@
;

: tft-data! ( Dn-1 .... D0 n -- )
  0 ?do
    tft-dw!
  loop
;

: tft-pre! ( Dn-1 ... D0 n cmd -- ) \ Start write and do not close TFT.CSX
  ti-pre!
  tft-csx
  tft-cmd!
  tft-data!
;

: tft-fini!
  -tft-csx
  mcp-stop
;

: tft! ( Dn-1 ... D0 n cmd -- ) \ Write and close CSX
  tft-pre!
  tft-fini!
;

: tft@ ( n cmd -- Dn-1 ... Dn1 D0 n )
  swap
  >r
  tft-csx
  tft-cmd!
  r@
  0 ?do
    tft-dr@
  loop
  r>
  -tft-csx
;

: tft-win-max
;


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

  0 $21 tft! \ Display Inversion ON
  \ 0 $20 tft! \ Display Inversion OFF

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

: tft-def-x ( x1 x0 -- )
  0 $2A tft-pre!
  int2bytes tft-dw! tft-dw! \ x0
  int2bytes tft-dw! tft-dw!  \ x1
;

: tft-def-y ( y1 y0 -- )
  $2B tft-cmd!
  int2bytes tft-dw! tft-dw!  \ y0
  int2bytes tft-dw! tft-dw!  \ y1
;

: tft-rect ( y1 y0 x1 x0 -- )
  tft-def-x
  tft-def-y
  tft-fini!
;

: tft-fill ( B G R n -- ) \ Fill rect wit n pixels
  0 $2C tft-pre!
  0 ?do
    dup tft-dw!  \ R
    over tft-dw! \ G
    2 pick tft-dw! \ B
  loop
  drop 2drop
  tft-fini!
;

: tft-full-rect ( -- )
  479 0 319 0 tft-rect \ 153600 pixels
;

: tft-bkg ( B G R -- ) \ Fill background wit a color
  tft-full-rect
  320 480 *
  tft-fill
;

: tft-pixel ( B G R y x -- )
  dup >r \ x+1 R:x
  int2bytes r> \ bh+ bl+ x
  int2bytes \ bh+ bl+ bh bl
  4 $2A tft-pre!
  dup >r
  int2bytes r>
  int2bytes
  4 $2B tft-cmd! tft-data!
  3 $2C tft-cmd! tft-data!
  tft-fini!
;

: tft-hline ( B G R y x1 x0 -- )
  2dup - 1+ >r \ no of pixels
  rot dup 2swap
  tft-rect
  r> \ No of pixels
  tft-fill \ TODO: Deinits TFT
;

: tft-vline ( B G R x y1 y0 -- )
  2dup - 1+ >r \ no of pixels
  rot dup
  tft-rect
  r> \ No of pixels
  tft-fill \ TODO: Deinits TFT
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
      0 0 0 i j tft-pixel
    loop
  loop
;

: tft-bar
  100 0 do
    100 0 do
      \ 0 0 0 - white
      \ 0 FF 0 - magenta
      \ 0 0 FF - cyan
      \ FF 0 0 - yellow
      $ff $FF $FF i j tft-pixel
    loop
  loop
;







compiletoram
