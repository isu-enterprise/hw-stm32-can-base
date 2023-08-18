\ Uses display, mcp-2515.fs, printing.fs, display.fs, spi.fs

forgetram
compiletoram


\ ---------- Forgotten routines of mcp-2515 -----
: mcp-nwrite ( vn-1 ... v0 nlen mcp-addr n -- ) \ Writes in registers
  >r
  r@ mcp-start
  %00000010 >mcp> drop
  >mcp> drop \ write mcp-addr
  0 ?do >mcp> drop loop
  r> mcp-stop
;

: mcp-reset ( n -- )
  dup mcp-start
  %11000000 >mcp> drop
  mcp-stop
;

: MCP.TXB ( n -- mcp-addr ) \ Converts TXn to TXBn_CTRL mcp-addr
  %0011 + 4 lshift inline
;

: MCP.RXB ( n -- mcp-addr ) \ Converts TXn to TXBn_CTRL mcp-addr
  %0110 + 4 lshift inline
;

: MCP.BSIDH ( mcp-addr -- mcp-addr )
  1 + inline
;

: MCP.BSIDL ( mcp-addr -- mcp-addr )
  2 + inline
;

: MCP.BEID8 ( mcp-addr -- mcp-addr )
  3 + inline
;

: MCP.BEID0 ( mcp-addr -- mcp-addr )
  4 + inline
;

: MCP.DLC ( mcp-addr -- mcp-addr )
  5 + inline
;

: MCP.D ( n mcp-addr -- mcp-addr ) \ n-th byte of data
  6 + +
  inline
;

$08 constant TXB-EXIDE-MASK

$2b constant MCP-CANINTE
$2c constant MCP-CANINTF

\ ---------- Adapter application subroutines for mcp-2515 can -------
\ https://github.com/autowp/arduino-mcp2515 - Helping sources

: copies$ ( nval n -- nval ... nval n ) \ Fill stack with n values and its length
  >r
  r@
  dup 0 >
  if
    1-
    0 do dup loop
    r>
  else
    drop \ n
    drop \ val
    0 rdrop
  then
;

: mcan-delay
  1000 0 do loop
;

: mcan-mode ( nmode n -- ) \ Set mode of mcp-2515
  >r
  $E0 \ mask
  $0F \ MCP-CANCTRL register
  r>
  mcp-mod
;

: mcan-mode-config ( n -- ) \ Ensure mcan in the config mode
  $80 swap
  mcan-mode
;

: mcan-mode-listenonly ( n -- ) \ Ensure mcan in the listen only mode
  $60 swap mcan-mode
;

: mcan-mode-powerup ( n -- ) \ ... powerup only mode
  $E0 swap mcan-mode
;

: mcan-mode-loopback ( n -- ) \ Ensure mcan in the loopback mode
  $40 swap mcan-mode
;

: mcan-mode-sleep ( n -- ) \ Ensure mcan in the sleep mode
  $20 swap mcan-mode
;

: mcan-mode-normal ( n -- ) \ Ensure mcan in the normal mode
  $00 swap mcan-mode
;

: mcan-fm! ( ndh-dl-e8-e0 fm-addr n -- ) \ Set filter/mask-addr 4 bytes
  >r >r
  3 0 do
    dup $ff and swap 8 rshift
  loop
  4
  r> r>
  mcp-nwrite
;

: mcan-prep-id$ ( nid flag -- ndh-dl-e8-e0 )
  swap $ffff and swap \ Trim leading 1s in id.
  if \ ext
    >r
    r@ $ff and
    r@ 8 rshift
    r> 16 rshift >r

    r@ $03 and
    r@ $1c and 3 lshift + TXB-EXIDE-MASK or
    r> 5 rshift
  else
    >r
    0 0
    r@ $07 and 5 lshift
    r> 5 rshift
  then
  3 0 do 8 lshift or loop
;

: mcan-rxf-addr ( n -- addr )
  dup 2 > if
    3 -
    2 lshift %00010000 or
  else
    2 lshift
  then
;

: mcan-rxm-addr ( n -- addr )
  2 lshift %00100000 or
  inline
;

: (mcan-nwrite) ( mcp.*XB-addr nval count n -- )
  >r
  rot >r \ R: n addr
  copies$ r> r>
  mcp-nwrite
;

: mcan-init ( n -- ) \ The subroutine inits the n-th can mcp-2515 interface
  dup nss/
  mcan-delay
  dup mcp-reset
  mcan-delay
  dup mcan-mode-config
  >r

  r@
  2 0 do
    dup i MCP.TXB swap \ caddr-*xb n
    0 14 rot \ caddr 0 14 n
    (mcan-nwrite)
  loop
  2 0 do
    dup 0 i MCP.RXB rot mcp-write
  loop
  drop

  %10100011 MCP-CANINTE r@ mcp-write
  \ RXBnCTRL_RXM_MASK | RXBwrite
  \ 0CTRL_BUKT | RXB0CTRL_FILHIT_MASK,
  \ $60 | $04 | $03
  \ RXBnCTRL_RXM_STDEXT | RXB0CTRL_BUKT | RXB0CTRL_FILHIT
  \ $00 | $04 | $00
  $04 $67 0 MCP.RXB r@ mcp-mod
  $00 $67 1 MCP.RXB r@ mcp-mod

  r@
  6 0 do
    dup
    0 i 1 = mcan-prep-id$ \ n can-id
    i mcan-rxf-addr \ n can-id caddr
    rot
    mcan-fm!
  loop
  2 0 do
    dup
    0 true mcan-prep-id$
    i mcan-rxm-addr
    rot
    mcan-fm!
  loop
  drop

  rdrop
;

: mcan-done ( n -- ) \ Deinits the n-th can interface
  dup nss/
  mcan-delay
  dup mcp-reset
  mcan-delay
  drop
;

\ ----------- application words, subject to move to a new 40-...fs file



: a-init ( -- ) \ Inits the adapter of two can interfaces
  2 0 do
    i mcp-init drop \ mcp-init does not accept parameters
  loop
  2 0 do
    i mcan-init
  loop
;

: a-done ( -- ) \ Deinits the adapter
  2 0 do
    i mcan-done
  loop
  2 0 do
    i mcp-done
  loop
;

compiletoram
: ttt a-init ;
