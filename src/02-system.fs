\ System setup, clock, subsys clocking, etc.
\ Uses 01-display.fs

compiletoram
forgetram

$40021000 constant RCC

: RCC.CR inline ;         \ Clock control register (RCC_CR)
: RCC.CFGR $04 + inline ; \ Clock configuration register (RCC_CFGR)
: RCC.CIR $08 + inline ;  \ Clock interrupt register (RCC_CIR)
: RCC.APB2RSTR $0C + inline ;  \ APB2 peripheral reset register (RCC_APB2RSTR)
: RCC.APB1RSTR $10 + inline ;  \ APB1 peripheral reset register (RCC_APB1RSTR)
: RCC.AHBENR $14 + inline ;  \ AHB Peripheral Clock enable register (RCC_AHBENR)
: RCC.APB2ENR $18 + inline ;  \ APB2 Peripheral Clock enable register (RCC_APB2ENR)
: RCC.APB1ENR $1C + inline ;  \ APB1 Peripheral Clock enable register (RCC_APB1ENR)
: RCC.BDCR $20 + inline ;  \ Backup domain control register (RCC_BDCR)
: RCC.CSR $24 + inline ;  \ Control/status register (RCC_CSR)
: RCC.AHBRSTR $28 + inline ;  \ AHB peripheral clock reset register (RCC_AHBRSTR)
: RCC.CFGR2 $2C + inline ;  \ Clock configuration register2 (RCC_CFGR2)


: RCC.APB2RSTR.
  RCC RCC.APB2RSTR bin.
;

: RCC.APB1RSTR.
  RCC RCC.APB1RSTR bin.
;

: RCC.APB2ENR.
  RCC RCC.APB2ENR bin.
;

: RCC.APB1ENR.
  RCC RCC.APB1ENR bin.
;

: RCC.AHBENR.
  RCC RCC.AHBENR bin.
;
