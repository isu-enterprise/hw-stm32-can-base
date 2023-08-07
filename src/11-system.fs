\ System setup, clock, subsys clocking, etc.
\ Uses 01-display.fs

forgetram
\ compiletoram

compiletoflash

$40023800 constant RCC

: RCC.CR inline ;         \ Clock control register (RCC_CR)
: RCC.PLLCFGR $04 + inline ;
: RCC.CFGR $08 + inline ;
: RCC.CIR $0C + inline ;
: RCC.AHB1RSTR $10 + inline ;
: RCC.AHB2RSTR $14 + inline ;
: RCC.APB1RSTR $20 + inline ;
: RCC.APB2RSTR $24 + inline ;
: RCC.AHB1ENR $30 + inline ;
: RCC.AHB2ENR $34 + inline ;
: RCC.APB1ENR $40 + inline ;
: RCC.APB2ENR $44 + inline ;
: RCC.AHB1LPENR $50 + inline ;
: RCC.AHB2LPENR $54 + inline ;
: RCC.APB1LPENR $60 + inline ;
: RCC.APB2LPENR $64 + inline ;
: RCC.BDCR $70 + inline ;
: RCC.CSR $74 + inline ;
: RCC.SSCGR $80 + inline ;
: RCC.PLLI2SCFGR $84 + inline ;
: RCC.DCKCFGR $8C + inline ;

\ : RCC.APB2RSTR.
\   RCC RCC.APB2RSTR 1b.
\ ;

\ : RCC.APB1RSTR.
\   RCC RCC.APB1RSTR 1b.
\ ;

\ : RCC.APB2ENR.
\   RCC RCC.APB2ENR 1b.
\ ;

\ : RCC.APB1ENR.
\   RCC RCC.APB1ENR 1b.
\ ;

\ : RCC.AHBENR.
\   RCC RCC.AHBENR 1b.
\ ;

compiletoram
