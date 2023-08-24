\ Uses display, mcp-2515.fs, printing.fs, display.fs, spi.fs

forgetram
compiletoram


\ ---------- Forgotten routines of mcp-2515 -----

\ 212 page
$40013C00 \ EXTI base address

dup $00 + constant EXTI-IMR
dup $04 + constant EXTI-EMR
dup $08 + constant EXTI-RTSR
dup $0c + constant EXTI-FTSR
dup $10 + constant EXTI-SWIER
dup $14 + constant EXTI-PR
drop

0 constant CAN0
1 constant CAN1

: int-vector-init ( flag-rising-edge n -- ) \ n-th vector and rising edge (flag)
  1 swap lshift >r \ mask
  r@ EXTI-IMR bis! \ clear mask (0=masked, 1=not masked)
  r@ EXTI-EMR bis! \ clear event mask
  if \ Rising triggering
    r@ EXTI-RTSR bis!
    r@ EXTI-FTSR bic!
  else
    r@ EXTI-RTSR bic!
    r@ EXTI-FTSR bis!
  then
  \ EXTI-SWIER \ Ignoring the software interrupt engine
  \ EXTI-PR \ ... and it as well
  rdrop
;

: EXTI.
  ." EXTI-IMR (int enable 1=enable, 0=masked)"
  EXTI-IMR 1b.
  ." EXTI-EMR (event enable 1=enable, 0=masked)"
  EXTI-EMR 1b.
  ." EXTI-RTSR (raising edge)"
  EXTI-RTSR 1b.
  ." EXTI-FTSR (falling edge)"
  EXTI-FTSR 1b.
  ." EXTI-SWIER (soft int)"
  EXTI-SWIER 1b.
  ." EXTI-PR (pending)"
  EXTI-PR 1b.
;

: int-vector-done ( n -- ) \ n-th vector disable events & ints
  1 swap lshift >r
  r@ EXTI-IMR bic!
  r@ EXTI-EMR bic!
  rdrop
;


: int-vector-clear! ( n -- ) \ Writing 1 in n-th bit clears its int event
  1 swap lshift EXTI-PR bis!
;

: int-vector? ( n -- flag ) \ Check n-th vector int pending
  1 swap lshift EXTI-PR bit@
;

\ 8 mhz clock
\ 00 80 80  (1mbps)
\ 00 90 82  (500 kbps)
\ 00 b1 85  (250 kbps)
\ 01 b1 b5  (125 kbps)
\ . . . .
\ 1f d0 82  (5 kbps)

\ ---------- Adapter application subroutines for mcp-2515 can -------
\ https://github.com/autowp/arduino-mcp2515 - Helping sources

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
    \ ." ."
    MCP-CANSTAT r@ mcp-read
    MCP-CANSTAT-OPMOD and
    over
    \ 2dup ch. space ch. cr
    =
  until
  drop rdrop
;

0 variable MCAN-INT-HANDLER \ Addr of word of ( n -- ) signature

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

false variable (mcan-check)

: (mcan-exti-8-handler)
  true (mcan-check) !
  1
  MCAN-INT-HANDLER @
  dup
  0<> if
    execute
  else 2drop then
  MCP-INT-1 nip int-vector-clear!
;

$40013800
dup $10 + constant SYSCFG-EXTICR3
drop

$E000E100 constant NVIC-ISER0

\ https://stm32f4-discovery.net/2014/08/stm32f4-external-interrupts-tutorial/

: mcan-int-init ( addr n -- )
  \ GPIO setup
  >r
  dup 0= if
    ." No handler ( n -- ) defined!" cr
    drop
  else
    MCAN-INT-HANDLER !
  then

  ['] (mcan-exti-8-handler) irq-exti9_5 !

  %00 MCP-INT-1 gpio-pin-moder!   \ Input
  %01 MCP-INT-1 gpio-pin-pupdr!   \ Pull Up ----\____

  \ Add clocking to configuration
  1 14 lshift RCC RCC.APB2ENR bis!
  \ Connect B8 to EXTI8
  SYSCFG-EXTICR3
      %1111 over bic!
      %0001 swap bis!

  MCP-INT-1 nip
  dup int-vector-clear!
  false swap int-vector-init \ Setup 12-th EXTI as PA12 ---\___

  \ Now init mcp2515
  r@ mcan-mode-config
  %11 dup $2b r@ mcp-mod \ Set interrupt when received msg
  r> mcan-mode-normal
  1 23 lshift NVIC-ISER0 bis!
;

: mcan-int-done ( -- )
  1 23 lshift NVIC-ISER0 bic!
  MCP-INT-1 nip int-vector-done
  0 MCAN-INT-HANDLER !
;

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

: mcan-id! ( ndh-dl-e8-e0 fm-addr n -- ) \ Set filter/mask-addr 4 bytes
  >r >r
  3 0 do
    dup $ff and swap 8 rshift
  loop
  4
  r> r>
  mcp-nwrite
;

: mcan-prep-id$ ( nid flag -- nidh-nidl-neid8-neid0 )
  swap $ffff and swap \ Trim leading 1s in id.
  if \ ext
    >r
    r@ $ff and
    r@ 8 rshift $ff and
    r> 16 rshift >r
    r@ $03 and
    r@ $1c and 3 lshift + TXB-EXIDE-MASK or
    r> 5 rshift
  else
    >r
    0 0
    r@ $07 and 5 lshift
    r> 3 rshift
  then
  \ neid0 neid8 nidl nidh
  \ h.s
  3 0 do 8 lshift or loop
  \ ." prep-id:" dup hex. cr
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

  0 false
  \ ." CYCLE: " cr

  3 0 do i 2 pick
         mcan-txb-free? if
           i true leave
         then
      loop

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

false constant MCAN-RTR
false constant MCAN-EFF
false constant MCAN-ERR


: mcan-get-id$ ( nidh nidl neid8 neid0 -- nid flag ) \ Unpack id
  \ 0
  \ 4 0 do i 1+ pick i 8 * lshift or loop
  \ ." get-id:" hex. cr
  2>r
  swap \ nidl nidh
  3 lshift over 5 rshift + \ nidl id.part
  over TXB-EXIDE-MASK and
  0<> if \ Extended
    2 lshift over $03 and +
    nip \ id.part
    2r> swap \ id.part neid0 nedi8
    rot
    8 lshift +
    8 lshift +
    true
  else
    nip \ remove nidl
    2rdrop \ remove neid8 and neid0
    false
  then
  dup MCAN-EFF !
;

: mcan-load-message ( nrxb n -- d0...d7 ndlen canid flag )
  \ Load a message from buffer nrxb (0..1) and n-th can mcp
  \ ." -----" cr

  swap mcan-rxb-addr swap \ rxb.base.addr n
  2>r
  \ ." reading len" cr
  2r@ swap mcan-xb-buf swap mcp-read \ Length of the message
  \ ." MSG LEN:" dup . cr
  \ ." reading data" cr

  dup 0<> if
    2r@ swap mcan-xb-buf 1+ swap \ nlen mcp-addr n
    \ ." =====" cr

    mcp-nread
    \ d0...d7 nlen
  then

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
  mcp-mod
;

: mcan-message. ( d0...d7 ndlen canid flag -- )
  if
    ." EXT "
  then
  ." Message ID:" ." $" hex. space
  dup 0= if drop ." (no data)"
         else
           dup 0 do dup i - pick ch. space loop
           0 do drop loop \ Clean msg
           \ ." (in the reverse order?)"
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

: a-receive-message ( n -- ) \ Receive and print

  dup mcan-nrxb

  dup 0= if
    \ ." No message yet." cr
    drop \ len
    drop \ bufs
    drop \ n
    exit
  then
  ." A Message! " cr

  \ ." No of full buffers:" dup . cr
  0 do \ canid rxbufs
    \ ." Iteration: " i . cr
    \ ." bfsno: " dup ch. cr
    dup i 4 * rshift $0F and \ n rxbufs nrxb

    \ ." Consider buffer: " dup . cr
    2 pick

    2dup mcan-load-message
    mcan-message.

    mcan-clear-rxb

  loop
  drop \ rxbufs
  drop \ n
;

: a-send-test-message ( canid flag -- ) \ Send a test message as CAN ID canid
  >r \ canid R: flag
  CAN0 mcan-find-ntxb \ canid ntxb flag
  if
    >r \ canid  R: ntxb
    \ ." Found buffer:" r@ . cr
    8 0 do
      dup 4 lshift 7 i - or $ff and
      \ dup ch. space
      swap \ shift canid
    loop
    \ 8 0 do i $f0 or
    \        dup ch. space
    \        swap \ Shift canid
    \     loop

    8 \ The message length
    \ dup ch. space cr
    swap \ ... 8 canid

    r> \ ntxb
    r> \ Extended ID flag
    swap

    ." Sending message!" cr
    dint
    CAN0 mcan-tx-message
    if
      ." MCAN TX SUCCESS!"
    else
      ." MCAN TX FAILED!"
    then
    cr
    eint
    cr
  else
    \ We have not found a free buffer
    drop  \ dummy zero
    drop \ canid
    rdrop \ flag
    ." MCAN TX Failed: No free buffer " cr
  then
;

compiletoram


: mcan-sr-test
  3 0 do
    i 5 + 2 lshift
    dup
    ." Try send " dup ch. space ." CANID message" cr
    false a-send-test-message
    ." Try send " dup ch. space ." CANID message" cr
    true a-send-test-message
    10 0 do
      \ ." RECEIVING it:" i . cr
      CAN1 a-receive-message
      mcan-delay
    loop
  loop
;

: ttt

  a-init
  mcan-delay

  ." Receiving previous messages " cr

  CAN1 a-receive-message

  ." SENDING messages " cr
  mcan-sr-test
;

: mega-ttt ( number-of-tests -- ) \ Run number... repetitions of test
  dup 2 < if
    drop
    ." At least 2 tests needed!" cr
  then
  1-
  ttt
  0 do
    mcan-sr-test
  loop
;

: mcan-int-handler-impl ( n -- )
  dint
  ." INT:" cr
  a-receive-message
  eint
;


: iii-init
  a-init
  mcan-delay
  CAN1 a-receive-message
  false (mcan-check) ! \ Wether an event triggered or not
  ['] mcan-int-handler-impl CAN1 mcan-int-init
;

: iii \ Interrupt driven demo
  iii-init
  $20 false a-send-test-message
  mcan-delay
  $FF00 true a-send-test-message
  \ mcan-int-done
;

: si
  (mcan-exti-8-handler)
;
