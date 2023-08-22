\ Uses display, mcp-2515.fs, printing.fs, display.fs, spi.fs

forgetram
compiletoram


\ ---------- Forgotten routines of mcp-2515 -----

8000000 constant MCP-CLOCK

: mcp-nwrite ( vn-1 ... v0 nlen mcp-addr n -- ) \ Writes in registers
  >r
  r@ mcp-start
  %00000010 >mcp> drop
  >mcp> drop \ write mcp-addr
  0 ?do >mcp> drop loop
  r> mcp-stop
;


: mcp-nread ( nlen mcp-addr n -- dm...d0 nlen )
  rot
  dup 0= if
    drop 2drop 0
    exit
  then
  \ mcp-addr n nlen
  >r \ Save the length
  >r \ Save n
  \ mcp-addr
  r@ mcp-start
  %00000011 >mcp> drop \ Read cmd
  >mcp> drop \ Set addr
  2r@ drop \ nlen
  0 do 0 >mcp> loop
  r@ mcp-stop
  2r> drop \ Set length in the stack
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
$0e constant MCP-CANSTAT
$e0 constant MCP-CANSTAT-OPMOD

\ 8 mhz clock
\ 00 80 80  (1mbps)
\ 00 90 82  (500 kbps)
\ 00 b1 85  (250 kbps)
\ 01 b1 b5  (125 kbps)
\ . . . .
\ 1f d0 82  (5 kbps)

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
  dup \ save nmode
  $E0 \ mask
  $0F \ MCP-CANCTRL register
  r@
  mcp-mod
  \ nmode
  begin
    mcan-delay
    MCP-CANSTAT r@ mcp-read
    MCP-CANSTAT-OPMOD and
    over =
  until
  drop rdrop
;

: mcan-nbt! ( ncf1 ncf2 ncf3 n -- ) \ Set Nominal Bit Time
  3 swap
  $28 swap
  mcp-nwrite
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

: mcan-id! ( ndh-dl-e8-e0 fm-addr n -- ) \ Set filter/mask-addr 4 bytes
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

: mcan-txb-addr ( n -- addr )
  %0011 + 4 lshift
  inline
;

: mcan-rxb-addr ( n -- addr )
  %0110 + 4 lshift
  inline
;

: mcan-xb-id ( addr -- addr )
  1+ inline
;

: mcan-xb-buf ( addr -- addr )
  %0101 + inline
;

: (mcan-nwrite) ( mcp.*XB-addr nval count n -- )
  >r
  rot >r \ R: n addr
  copies$ r> r>
  mcp-nwrite
;

: mcan-500KBps ( n -- ) \ Set 500 KBps bitrate for 8 MHz osc
  >r
  $00 $90 $82
  r>
  mcan-nbt!
;

: mcan-save-message ( nm...n0 nlen ncanid flag ntxb n -- )
  \ Send message via ntxb-th buffer of n-th mcan infs
  2>r
  mcan-prep-id$
  2r@ swap
  mcan-txb-addr mcan-xb-id \ ntxb-th CAN id buffer addr
  swap mcan-id!
  \ CAN id now stored in ntxb-th buffer
  dup 1+
  2r> swap
  mcan-txb-addr mcan-xb-buf \ ntxb-th CAN buff addr
  swap
  mcp-nwrite
;


: mcan-send-txb ( ntxb n -- ) \ Send message in ntxb-th buffer
  swap mcan-txb-addr swap 2>r
  $08 $08 2r> mcp-mod
;

: mcan-txb-status@ ( ntxb n -- n ) \ Reads status
  swap mcan-txb-addr swap
  mcp-read
;


: mcan-tx-failed? ( ntxb n -- flag ) \ Check if sending failed
  mcan-txb-status@
  %01110000 and 0<> \ true if a bit set
;


: mcan-tx-message ( nm...n0 nlen ncanid flag ntxb n -- flag )
  \ Send message via ntxb-th buffer
  2>r
  2r@
  mcan-save-message \ Save message in buffer
  2r@ mcan-send-txb \ Try Send it from the buffer
  2r> mcan-tx-failed? not \ Load flag if it is OK
;

: mcan-txb-free? ( ntxb n -- flag ) \ Is ntxb-th buffer free for sending?
  mcan-txb-status@
  $08 and 0=
;


: mcan-find-ntxb ( n -- ntxb flag ) \ Find a free tx buffer
  \ If found flag is true and ntxb is the number.
  \ In the other case ntxb must be ignored
  \ h.s
  0 false
  \ ." CYCLE: " cr
  \ h.s
  3 0 do i 2 pick
         mcan-txb-free? if
           i true leave
         then
      loop
  \ h.s
  if \ found
    >r \ ntxb
    2drop
    drop \ n
    r> true
  else
    \ n 0
    swap \ 0 n
    drop
    false \ 0 false
  then
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
    mcan-id!
  loop
  2 0 do
    dup
    0 true mcan-prep-id$
    i mcan-rxm-addr
    rot
    mcan-id!
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

: mcan-status@ ( n -- n ) \ Get status
  mcp-read-status
  inline
;

: mcan-rx? ( n -- flag ) \ Are there a message received
  mcan-status@
  \ manual page 70, 54 CANINTF[0..1] RX0IF, RX1IF
  $00000011 and 0<>
;


: mcan-nrxb ( n -- n1-n0 nlen ) \ Which mailbox the message received in
  \ Returns
  \ n0-n1 - mailbox numbers (4bit fields)
  \ n - the number of non-empty mailboxes
  mcan-status@
  3 and \ satus
  dup 0= if drop 0 0 exit then
  dup %10 = if drop $01 1 exit then
  %01 = if $00 1 exit then
  \ %11
  $10 2
;


: mcan-get-id$ ( nidh nidl neid8 neid0 -- nid flag ) \ Unpack id
  2drop 2drop \ Strut
  $FF true
;

: mcan-load-message ( nrxb n -- d0...d7 ndlen canid flag )
  \ Load a message from buffer nrxb (0..1) and n-th can mcp
  \ ." -----" cr
  \ h.s
  swap mcan-rxb-addr swap \ rxb.base.addr n
  2>r
  \ ." reading len" cr
  2r@ swap mcan-xb-buf swap mcp-read \ Length of the message
  \ ." MSG LEN:" dup . cr
  \ ." reading data" cr
  \ h.s
  dup 0<> if
    2r@ swap mcan-xb-buf 1+ swap \ nlen mcp-addr n
    \ ." =====" cr
    \ h.s
    mcp-nread
    \ d0...d7 nlen
  then
  \ h.s
  \ ." Reading canid" cr
  4 2r> swap mcan-xb-id swap mcp-nread
  drop \ length of 4
  \ ." Unpacking canid" cr
  mcan-get-id$
  \ ." Reading done" cr
  \ .s
;

: mcan-clear-rxb ( nrxb n -- ) \ Make nrxb-th buf free for receiving
  >r
  1+ \ mask = nrxb+1
  0 swap %00101100 r>
  \ ." clearing" cr
  \ h.s
  mcp-mod
;

: mcan-message. ( d0...d7 ndlen canid flag -- )
  if
    ." EXT "
  then
  ." Message ID:" ch. space
  dup 0= if drop ." (no data)"
         else
           0 do ch. space loop
           ." (in the reverse order)"
         then
  cr
;

\ ----------- application words, subject to move to a new 40-...fs file

: a-init ( -- ) \ Inits the adapter of two can interfaces
  2 0 do
    i mcp-init drop \ mcp-init does not accept parameters
  loop
  2 0 do
    i mcan-init
    i mcan-500KBps
    i mcan-mode-normal
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

0 constant CAN0
1 constant CAN1

: a-receive-message ( n -- ) \ Receive and print
  \ h.s
  dup mcan-nrxb
  \ h.s
  dup 0= if
    ." No message yet." cr
    drop \ len
    drop \ bufs
    drop \ n
    exit
  then
  ." A Message! " cr
  \ h.s
  \ ." No of full buffers:" dup . cr
  0 do \ canid rxbufs
    \ ." Iteration: " i . cr
    \ ." bfsno: " dup ch. cr
    dup i 4 * rshift $0F and \ n rxbufs nrxb
    \ h.s
    \ ." Consider buffer: " dup . cr
    2 pick
    \ h.s
    2dup mcan-load-message
    ." received msg" cr
    h.s
    mcan-message.
    \ h.s
    mcan-clear-rxb
    \ h.s
  loop
  drop \ rxbufs
  drop \ n
;

: a-send-test-message ( canid -- ) \ Send a test message as CAN ID canid
  \ h.s
  CAN0 mcan-find-ntxb \ canid ntxb flag
  \ h.s
  if
    >r \ canid  R: ntxb

    ." Found buffer:" r@ . cr

    8 0 do
      dup 4 lshift i or $ff and
      dup ch. space
      swap \ shift canid
    loop
    \ 8 0 do i $f0 or
    \        dup ch. space
    \        swap \ Shift canid
    \     loop

    8 \ The message length
    dup ch. space cr
    swap \ ... 8 canid

    true \ Extended ID
    r> \ ntxb
    ." Sending message!" cr
    h.s
    CAN0 mcan-tx-message
    if
      ." MCAN TX SUCCESS!"
    else
      ." MCAN TX FAILED!"
    then
    cr
  else
    rdrop \ We have not found a free buffer
    drop  \ dummy zero
    ." MCAN TX Failed: No free buffer " cr
  then
;

compiletoram

: ttt
  \ h.s
  a-init
  mcan-delay
  \ h.s
  CAN1 a-receive-message
  \ h.s
  ." SENDING " cr
  3 0 do
    i 10 +
    ." Try send " dup hex. ." CANID message" cr
    \ h.s
    a-send-test-message
    \ ." LOOK at stack " cr
    \ h.s
    10 0 do
      \ ." RECEIVING it:" i . cr
      CAN1 a-receive-message
      mcan-delay
    loop
  loop
;
