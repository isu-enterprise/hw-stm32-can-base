\ Printing various structures, e.g. two-digit hexadecimals

\ compiletoram
forgetram
compiletoflash

: ? @ . inline ;
: u? @ u. inline ;

: ch. ( n -- )
  dup $ff >
  if ." not a 8 bit char $" hex.
  else
    0
    base @
    -rot
    hex
    <# # # #>
    type
    base !
  then
;

: ?ch. ( addr -- ) \ Fetches char and hex-prints it
  c@ ch. space
;

: cdump ( addr n -- ) \ Dump n bytes as 8bit chars as hex at addr
  cr
  ." Dump @ " over ." $" hex. cr
  15
  -rot
  0 do
    dup i + ?ch. \ cnt addr
    swap
    dup 8 = if
      space space
    then
    dup 0= if
      drop
      16
      cr
    then
    1-
    swap
  loop
  2drop \ cnt addr -> empty
  cr
;

: wdump ( addr n -- ) \ Dump n cells as 32bit hex at addr
  cr
  ." Dump @ " over ." $" hex. cr
  3
  -rot
  0 do
    dup i cells +
    @ hex.
    swap
    dup 2 = if
      space space
    then
    dup 0= if
      drop
      4
      cr
    then
    1-
    swap
  loop
  2drop
  cr
;


compiletoram
