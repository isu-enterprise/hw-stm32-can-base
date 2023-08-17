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

$2b constant MCP-CANINTE
$2c constant MCP-CANINTF

\ ---------- Adapter application subroutines for mcp-2515 can -------
\ https://github.com/autowp/arduino-mcp2515 - Helping sources

: zeros$ ( n -- 0 ... 0 n ) \ Fill stackwith n zeroes and its length
  >r
  r@ 0 ?do 0 loop
  r>
;

: mcan-delay
  1000 0 do loop
;

: mcan-init ( n -- ) \ The subroutine inits the n-th can mcp-2515 interface
  dup nss/
  mcan-delay
  dup mcp-reset
  mcan-delay
  >r
  3 0 do
    14 zeros$ i MCP.TXB r@ mcp-nwrite
  loop
  2 0 do
    0 i MCP.RXB r@ mcp-write
  loop
  %10100011 MCP-CANINTE r@ mcp-write
  \ RXBnCTRL_RXM_MASK | RXB0CTRL_BUKT | RXB0CTRL_FILHIT_MASK,
  \ $60 | $04 | $03
  \ RXBnCTRL_RXM_STDEXT | RXB0CTRL_BUKT | RXB0CTRL_FILHIT
  \ $00 | $04 | $00
  $04 $67 0 MCP.RXB r@ mcp-mod
  $00 $67 1 MCP.RXB r@ mcp-mod
  \ TODO: Set Filter mask, two stages
  rdrop
  drop
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
    i mcp-init
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
