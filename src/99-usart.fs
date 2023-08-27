\ USART Speed routines

compiletoram

$40004400
dup constant USART2
dup $08 + constant USART2-BRR
drop

: usart2-576000-baud \ Does not work
  $11 USART2-BRR ! \ 588235
;

: usart2-460800-baud \ works well
  $23 USART2-BRR ! \ 454545
;

compiletoram
