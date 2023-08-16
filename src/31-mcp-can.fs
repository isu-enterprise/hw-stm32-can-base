\ Uses display, mcp-2515.fs, printing.fs, display.fs, spi.fs

forgetram
compiletoram


\ ---------- Forgotten routines of mcp-2515 -----

: mcp-reset ( n -- )
  dup mcp-start
  %11000000 >mcp> drop
  mcp-stop
;


\ ---------- Adapter application subroutines -------

: mcan-delay
  1000 0 do loop
;

: mcan-init ( n -- ) \ The subroutine inits the n-th can mcp-2415 interface
  dup nss/
  mcan-delay
  dup mcp-reset
  drop
;

: mcan-done ( n -- ) \ Deinits the n-th can interface
  dup nss/
  mcan-delay
  dup mcp-reset
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
