
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
    ." init DR" cr
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

: ti-init        \ init TFT interface
  mcp-init
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
  1 3 lshift TFT.CR bic!
  tft-cr!
;

: -tft-csx
  1 3 lshift TFT.CR bis!
  tft-cr!
;

: tft-cmd! ( cmd -- )
  %11 1 lshift \ RS, WR _
    TFT.CR bic!
  tft-cr!
  ti-dr!
  1 1 lshift TFT.CR bis! \ WR /
  tft-cr!
  1 2 lshift TFT.CR bis! \ CMD _-
;

: tft-dw! ( D -- )  \ Lower
  %101 TFT.CR bis!
  %010 TFT.CR bic!
  tft-cr!
  ti-dr!
  %010 TFT.CR bis!
  tft-cr!
;


: tft-dr@ ( -- D ) \ Data Read
  %110 TFT.CR bis!
  %001 TFT.CR bic!
  tft-cr!
  %001 TFT.CR bis!
  tft-cr!
  ti-dr@
;

: tft! ( Dn-1 ... D0 n cmd - )
  tft-csx
  tft-cmd!
  \ .s cr
  0 ?do
    tft-dw!
  loop
  -tft-csx
;


: tft@ ( n cmd -- Dn-1 ... Dn1 D0 n )
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
  0 1 tft!   \ sw reset
  50000 0 do loop
  0 $28 tft! \ Display off
  \ Start init sequence
  $30 $83 $00 3 $CF \ Power control B
  tft!
  $81 $12 $03 $64 4 $ED \ Power on sequence control
  tft!
  $79 $01 $85 3 $E8 \ Driver timing control A
  tft!
  $02 $34 $00 $2c $39 5 $CB \ Power control A
  tft!
  $20 1 $F7 tft! \ Pump ratio control
  0 0 2 $EA tft! \ Driver timing control B
  $26 1 $C0 tft! \ Power CTRL 1
  $11 1 $C1 tft! \ Pwr CTRL 2
  $3e $35 2 $C5 tft! \ VCOM CTRL 1
  $be 1 $C7 tft! \ VCOM ctrl 2
  $48 1 $36 tft! \ Mem access control
  $55 1 $3a tft! \ Colmod pixel format set
  $1b $00 2 $b1 tft! \ Frame rate
  $08 1 $f2 tft! \ Gamma fun disable
  $01 1 $26 tft! \ Gamma set for curve 01/2/04/08
  $00 $05 $07 $02 $07 $0a $32
  $87 $45 $06 $0f $0a $18 $1a
  $1f 15 $E0 \ Positive gamma corr
  tft!
  $1f $3a $38 $0d $18 $05 $4d
  $78 $3a $09 $10 $05 $27 $25
  $00 15 $E1 \ Negative ...
  tft!
  tft-win-max
  $07 1 $b7 tft! \ Entry mode
  $00 $27 $82 $0a 4 $B6 tft! \ Display function control
  0 $11 tft! \ Sleep out
  50000 0 do loop
  0 $29 tft! \ Display on
  50000 0 do loop
;


: tftt
  tft-init
  \ 0 1 2 3 4 5
  \ 6
  \ $0f
  \ tft!
;


compiletoram
