\ TEMPLATE FILE for STM32F411
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence

 compiletoflash

\ available forth template words as selected by config.xml

$40012300 constant ADC_Common ( ADC common registers )
ADC_Common $0 + constant ADC_Common-CSR ( ADC Common status register )
ADC_Common $4 + constant ADC_Common-CCR ( ADC common control register )
: ADC_Common-CSR. ." ADC_Common-CSR (read-only) $" ADC_Common-CSR @ hex. ADC_Common-CSR 1b. ;
: ADC_Common-CCR. ." ADC_Common-CCR (read-write) $" ADC_Common-CCR @ hex. ADC_Common-CCR 1b. ;
: ADC_Common.
ADC_Common-CSR.
ADC_Common-CCR.
;

$40012000 constant ADC1 ( Analog-to-digital converter )
ADC1 $0 + constant ADC1-SR ( status register )
ADC1 $4 + constant ADC1-CR1 ( control register 1 )
ADC1 $8 + constant ADC1-CR2 ( control register 2 )
ADC1 $C + constant ADC1-SMPR1 ( sample time register 1 )
ADC1 $10 + constant ADC1-SMPR2 ( sample time register 2 )
ADC1 $14 + constant ADC1-JOFR1 ( injected channel data offset register
  x )
ADC1 $18 + constant ADC1-JOFR2 ( injected channel data offset register
  x )
ADC1 $1C + constant ADC1-JOFR3 ( injected channel data offset register
  x )
ADC1 $20 + constant ADC1-JOFR4 ( injected channel data offset register
  x )
ADC1 $24 + constant ADC1-HTR ( watchdog higher threshold
  register )
ADC1 $28 + constant ADC1-LTR ( watchdog lower threshold
  register )
ADC1 $2C + constant ADC1-SQR1 ( regular sequence register 1 )
ADC1 $30 + constant ADC1-SQR2 ( regular sequence register 2 )
ADC1 $34 + constant ADC1-SQR3 ( regular sequence register 3 )
ADC1 $38 + constant ADC1-JSQR ( injected sequence register )
ADC1 $3C + constant ADC1-JDR1 ( injected data register x )
ADC1 $40 + constant ADC1-JDR2 ( injected data register x )
ADC1 $44 + constant ADC1-JDR3 ( injected data register x )
ADC1 $48 + constant ADC1-JDR4 ( injected data register x )
ADC1 $4C + constant ADC1-DR ( regular data register )
: ADC1-SR. ." ADC1-SR (read-write) $" ADC1-SR @ hex. ADC1-SR 1b. ;
: ADC1-CR1. ." ADC1-CR1 (read-write) $" ADC1-CR1 @ hex. ADC1-CR1 1b. ;
: ADC1-CR2. ." ADC1-CR2 (read-write) $" ADC1-CR2 @ hex. ADC1-CR2 1b. ;
: ADC1-SMPR1. ." ADC1-SMPR1 (read-write) $" ADC1-SMPR1 @ hex. ADC1-SMPR1 1b. ;
: ADC1-SMPR2. ." ADC1-SMPR2 (read-write) $" ADC1-SMPR2 @ hex. ADC1-SMPR2 1b. ;
: ADC1-JOFR1. ." ADC1-JOFR1 (read-write) $" ADC1-JOFR1 @ hex. ADC1-JOFR1 1b. ;
: ADC1-JOFR2. ." ADC1-JOFR2 (read-write) $" ADC1-JOFR2 @ hex. ADC1-JOFR2 1b. ;
: ADC1-JOFR3. ." ADC1-JOFR3 (read-write) $" ADC1-JOFR3 @ hex. ADC1-JOFR3 1b. ;
: ADC1-JOFR4. ." ADC1-JOFR4 (read-write) $" ADC1-JOFR4 @ hex. ADC1-JOFR4 1b. ;
: ADC1-HTR. ." ADC1-HTR (read-write) $" ADC1-HTR @ hex. ADC1-HTR 1b. ;
: ADC1-LTR. ." ADC1-LTR (read-write) $" ADC1-LTR @ hex. ADC1-LTR 1b. ;
: ADC1-SQR1. ." ADC1-SQR1 (read-write) $" ADC1-SQR1 @ hex. ADC1-SQR1 1b. ;
: ADC1-SQR2. ." ADC1-SQR2 (read-write) $" ADC1-SQR2 @ hex. ADC1-SQR2 1b. ;
: ADC1-SQR3. ." ADC1-SQR3 (read-write) $" ADC1-SQR3 @ hex. ADC1-SQR3 1b. ;
: ADC1-JSQR. ." ADC1-JSQR (read-write) $" ADC1-JSQR @ hex. ADC1-JSQR 1b. ;
: ADC1-JDR1. ." ADC1-JDR1 (read-only) $" ADC1-JDR1 @ hex. ADC1-JDR1 1b. ;
: ADC1-JDR2. ." ADC1-JDR2 (read-only) $" ADC1-JDR2 @ hex. ADC1-JDR2 1b. ;
: ADC1-JDR3. ." ADC1-JDR3 (read-only) $" ADC1-JDR3 @ hex. ADC1-JDR3 1b. ;
: ADC1-JDR4. ." ADC1-JDR4 (read-only) $" ADC1-JDR4 @ hex. ADC1-JDR4 1b. ;
: ADC1-DR. ." ADC1-DR (read-only) $" ADC1-DR @ hex. ADC1-DR 1b. ;
: ADC1.
ADC1-SR.
ADC1-CR1.
ADC1-CR2.
ADC1-SMPR1.
ADC1-SMPR2.
ADC1-JOFR1.
ADC1-JOFR2.
ADC1-JOFR3.
ADC1-JOFR4.
ADC1-HTR.
ADC1-LTR.
ADC1-SQR1.
ADC1-SQR2.
ADC1-SQR3.
ADC1-JSQR.
ADC1-JDR1.
ADC1-JDR2.
ADC1-JDR3.
ADC1-JDR4.
ADC1-DR.
;

$40023000 constant CRC ( Cryptographic processor )
CRC $0 + constant CRC-DR ( Data register )
CRC $4 + constant CRC-IDR ( Independent Data register )
CRC $8 + constant CRC-CR ( Control register )
: CRC-DR. ." CRC-DR (read-write) $" CRC-DR @ hex. CRC-DR 1b. ;
: CRC-IDR. ." CRC-IDR (read-write) $" CRC-IDR @ hex. CRC-IDR 1b. ;
: CRC-CR. ." CRC-CR (write-only) $" CRC-CR @ hex. CRC-CR 1b. ;
: CRC.
CRC-DR.
CRC-IDR.
CRC-CR.
;

$E0042000 constant DBG ( Debug support )
DBG $0 + constant DBG-DBGMCU_IDCODE ( IDCODE )
DBG $4 + constant DBG-DBGMCU_CR ( Control Register )
DBG $8 + constant DBG-DBGMCU_APB1_FZ ( Debug MCU APB1 Freeze registe )
DBG $C + constant DBG-DBGMCU_APB2_FZ ( Debug MCU APB2 Freeze registe )
: DBG-DBGMCU_IDCODE. ." DBG-DBGMCU_IDCODE (read-only) $" DBG-DBGMCU_IDCODE @ hex. DBG-DBGMCU_IDCODE 1b. ;
: DBG-DBGMCU_CR. ." DBG-DBGMCU_CR (read-write) $" DBG-DBGMCU_CR @ hex. DBG-DBGMCU_CR 1b. ;
: DBG-DBGMCU_APB1_FZ. ." DBG-DBGMCU_APB1_FZ (read-write) $" DBG-DBGMCU_APB1_FZ @ hex. DBG-DBGMCU_APB1_FZ 1b. ;
: DBG-DBGMCU_APB2_FZ. ." DBG-DBGMCU_APB2_FZ (read-write) $" DBG-DBGMCU_APB2_FZ @ hex. DBG-DBGMCU_APB2_FZ 1b. ;
: DBG.
DBG-DBGMCU_IDCODE.
DBG-DBGMCU_CR.
DBG-DBGMCU_APB1_FZ.
DBG-DBGMCU_APB2_FZ.
;

$40013C00 constant EXTI ( External interrupt/event
  controller )
EXTI $0 + constant EXTI-IMR ( Interrupt mask register
  EXTI_IMR )
EXTI $4 + constant EXTI-EMR ( Event mask register EXTI_EMR )
EXTI $8 + constant EXTI-RTSR ( Rising Trigger selection register
  EXTI_RTSR )
EXTI $C + constant EXTI-FTSR ( Falling Trigger selection register
  EXTI_FTSR )
EXTI $10 + constant EXTI-SWIER ( Software interrupt event register
  EXTI_SWIER )
EXTI $14 + constant EXTI-PR ( Pending register EXTI_PR )
: EXTI-IMR. ." EXTI-IMR (read-write) $" EXTI-IMR @ hex. EXTI-IMR 1b. ;
: EXTI-EMR. ." EXTI-EMR (read-write) $" EXTI-EMR @ hex. EXTI-EMR 1b. ;
: EXTI-RTSR. ." EXTI-RTSR (read-write) $" EXTI-RTSR @ hex. EXTI-RTSR 1b. ;
: EXTI-FTSR. ." EXTI-FTSR (read-write) $" EXTI-FTSR @ hex. EXTI-FTSR 1b. ;
: EXTI-SWIER. ." EXTI-SWIER (read-write) $" EXTI-SWIER @ hex. EXTI-SWIER 1b. ;
: EXTI-PR. ." EXTI-PR (read-write) $" EXTI-PR @ hex. EXTI-PR 1b. ;
: EXTI.
EXTI-IMR.
EXTI-EMR.
EXTI-RTSR.
EXTI-FTSR.
EXTI-SWIER.
EXTI-PR.
;

$40023C00 constant FLASH ( FLASH )
FLASH $0 + constant FLASH-ACR ( Flash access control register )
FLASH $4 + constant FLASH-KEYR ( Flash key register )
FLASH $8 + constant FLASH-OPTKEYR ( Flash option key register )
FLASH $C + constant FLASH-SR ( Status register )
FLASH $10 + constant FLASH-CR ( Control register )
FLASH $14 + constant FLASH-OPTCR ( Flash option control register )
: FLASH-ACR. ." FLASH-ACR () $" FLASH-ACR @ hex. FLASH-ACR 1b. ;
: FLASH-KEYR. ." FLASH-KEYR (write-only) $" FLASH-KEYR @ hex. FLASH-KEYR 1b. ;
: FLASH-OPTKEYR. ." FLASH-OPTKEYR (write-only) $" FLASH-OPTKEYR @ hex. FLASH-OPTKEYR 1b. ;
: FLASH-SR. ." FLASH-SR () $" FLASH-SR @ hex. FLASH-SR 1b. ;
: FLASH-CR. ." FLASH-CR (read-write) $" FLASH-CR @ hex. FLASH-CR 1b. ;
: FLASH-OPTCR. ." FLASH-OPTCR (read-write) $" FLASH-OPTCR @ hex. FLASH-OPTCR 1b. ;
: FLASH.
FLASH-ACR.
FLASH-KEYR.
FLASH-OPTKEYR.
FLASH-SR.
FLASH-CR.
FLASH-OPTCR.
;

$40003000 constant IWDG ( Independent watchdog )
IWDG $0 + constant IWDG-KR ( Key register )
IWDG $4 + constant IWDG-PR ( Prescaler register )
IWDG $8 + constant IWDG-RLR ( Reload register )
IWDG $C + constant IWDG-SR ( Status register )
: IWDG-KR. ." IWDG-KR (write-only) $" IWDG-KR @ hex. IWDG-KR 1b. ;
: IWDG-PR. ." IWDG-PR (read-write) $" IWDG-PR @ hex. IWDG-PR 1b. ;
: IWDG-RLR. ." IWDG-RLR (read-write) $" IWDG-RLR @ hex. IWDG-RLR 1b. ;
: IWDG-SR. ." IWDG-SR (read-only) $" IWDG-SR @ hex. IWDG-SR 1b. ;
: IWDG.
IWDG-KR.
IWDG-PR.
IWDG-RLR.
IWDG-SR.
;

$50000800 constant OTG_FS_DEVICE ( USB on the go full speed )
OTG_FS_DEVICE $0 + constant OTG_FS_DEVICE-FS_DCFG ( OTG_FS device configuration register
  OTG_FS_DCFG )
OTG_FS_DEVICE $4 + constant OTG_FS_DEVICE-FS_DCTL ( OTG_FS device control register
  OTG_FS_DCTL )
OTG_FS_DEVICE $8 + constant OTG_FS_DEVICE-FS_DSTS ( OTG_FS device status register
  OTG_FS_DSTS )
OTG_FS_DEVICE $10 + constant OTG_FS_DEVICE-FS_DIEPMSK ( OTG_FS device IN endpoint common interrupt
  mask register OTG_FS_DIEPMSK )
OTG_FS_DEVICE $14 + constant OTG_FS_DEVICE-FS_DOEPMSK ( OTG_FS device OUT endpoint common interrupt
  mask register OTG_FS_DOEPMSK )
OTG_FS_DEVICE $18 + constant OTG_FS_DEVICE-FS_DAINT ( OTG_FS device all endpoints interrupt
  register OTG_FS_DAINT )
OTG_FS_DEVICE $1C + constant OTG_FS_DEVICE-FS_DAINTMSK ( OTG_FS all endpoints interrupt mask register
  OTG_FS_DAINTMSK )
OTG_FS_DEVICE $28 + constant OTG_FS_DEVICE-DVBUSDIS ( OTG_FS device VBUS discharge time
  register )
OTG_FS_DEVICE $2C + constant OTG_FS_DEVICE-DVBUSPULSE ( OTG_FS device VBUS pulsing time
  register )
OTG_FS_DEVICE $34 + constant OTG_FS_DEVICE-DIEPEMPMSK ( OTG_FS device IN endpoint FIFO empty
  interrupt mask register )
OTG_FS_DEVICE $100 + constant OTG_FS_DEVICE-FS_DIEPCTL0 ( OTG_FS device control IN endpoint 0 control
  register OTG_FS_DIEPCTL0 )
OTG_FS_DEVICE $120 + constant OTG_FS_DEVICE-DIEPCTL1 ( OTG device endpoint-1 control
  register )
OTG_FS_DEVICE $140 + constant OTG_FS_DEVICE-DIEPCTL2 ( OTG device endpoint-2 control
  register )
OTG_FS_DEVICE $160 + constant OTG_FS_DEVICE-DIEPCTL3 ( OTG device endpoint-3 control
  register )
OTG_FS_DEVICE $300 + constant OTG_FS_DEVICE-DOEPCTL0 ( device endpoint-0 control
  register )
OTG_FS_DEVICE $320 + constant OTG_FS_DEVICE-DOEPCTL1 ( device endpoint-1 control
  register )
OTG_FS_DEVICE $340 + constant OTG_FS_DEVICE-DOEPCTL2 ( device endpoint-2 control
  register )
OTG_FS_DEVICE $360 + constant OTG_FS_DEVICE-DOEPCTL3 ( device endpoint-3 control
  register )
OTG_FS_DEVICE $108 + constant OTG_FS_DEVICE-DIEPINT0 ( device endpoint-x interrupt
  register )
OTG_FS_DEVICE $128 + constant OTG_FS_DEVICE-DIEPINT1 ( device endpoint-1 interrupt
  register )
OTG_FS_DEVICE $148 + constant OTG_FS_DEVICE-DIEPINT2 ( device endpoint-2 interrupt
  register )
OTG_FS_DEVICE $168 + constant OTG_FS_DEVICE-DIEPINT3 ( device endpoint-3 interrupt
  register )
OTG_FS_DEVICE $308 + constant OTG_FS_DEVICE-DOEPINT0 ( device endpoint-0 interrupt
  register )
OTG_FS_DEVICE $328 + constant OTG_FS_DEVICE-DOEPINT1 ( device endpoint-1 interrupt
  register )
OTG_FS_DEVICE $348 + constant OTG_FS_DEVICE-DOEPINT2 ( device endpoint-2 interrupt
  register )
OTG_FS_DEVICE $368 + constant OTG_FS_DEVICE-DOEPINT3 ( device endpoint-3 interrupt
  register )
OTG_FS_DEVICE $110 + constant OTG_FS_DEVICE-DIEPTSIZ0 ( device endpoint-0 transfer size
  register )
OTG_FS_DEVICE $310 + constant OTG_FS_DEVICE-DOEPTSIZ0 ( device OUT endpoint-0 transfer size
  register )
OTG_FS_DEVICE $130 + constant OTG_FS_DEVICE-DIEPTSIZ1 ( device endpoint-1 transfer size
  register )
OTG_FS_DEVICE $150 + constant OTG_FS_DEVICE-DIEPTSIZ2 ( device endpoint-2 transfer size
  register )
OTG_FS_DEVICE $170 + constant OTG_FS_DEVICE-DIEPTSIZ3 ( device endpoint-3 transfer size
  register )
OTG_FS_DEVICE $118 + constant OTG_FS_DEVICE-DTXFSTS0 ( OTG_FS device IN endpoint transmit FIFO
  status register )
OTG_FS_DEVICE $138 + constant OTG_FS_DEVICE-DTXFSTS1 ( OTG_FS device IN endpoint transmit FIFO
  status register )
OTG_FS_DEVICE $158 + constant OTG_FS_DEVICE-DTXFSTS2 ( OTG_FS device IN endpoint transmit FIFO
  status register )
OTG_FS_DEVICE $178 + constant OTG_FS_DEVICE-DTXFSTS3 ( OTG_FS device IN endpoint transmit FIFO
  status register )
OTG_FS_DEVICE $330 + constant OTG_FS_DEVICE-DOEPTSIZ1 ( device OUT endpoint-1 transfer size
  register )
OTG_FS_DEVICE $350 + constant OTG_FS_DEVICE-DOEPTSIZ2 ( device OUT endpoint-2 transfer size
  register )
OTG_FS_DEVICE $370 + constant OTG_FS_DEVICE-DOEPTSIZ3 ( device OUT endpoint-3 transfer size
  register )
: OTG_FS_DEVICE-FS_DCFG. ." OTG_FS_DEVICE-FS_DCFG (read-write) $" OTG_FS_DEVICE-FS_DCFG @ hex. OTG_FS_DEVICE-FS_DCFG 1b. ;
: OTG_FS_DEVICE-FS_DCTL. ." OTG_FS_DEVICE-FS_DCTL () $" OTG_FS_DEVICE-FS_DCTL @ hex. OTG_FS_DEVICE-FS_DCTL 1b. ;
: OTG_FS_DEVICE-FS_DSTS. ." OTG_FS_DEVICE-FS_DSTS (read-only) $" OTG_FS_DEVICE-FS_DSTS @ hex. OTG_FS_DEVICE-FS_DSTS 1b. ;
: OTG_FS_DEVICE-FS_DIEPMSK. ." OTG_FS_DEVICE-FS_DIEPMSK (read-write) $" OTG_FS_DEVICE-FS_DIEPMSK @ hex. OTG_FS_DEVICE-FS_DIEPMSK 1b. ;
: OTG_FS_DEVICE-FS_DOEPMSK. ." OTG_FS_DEVICE-FS_DOEPMSK (read-write) $" OTG_FS_DEVICE-FS_DOEPMSK @ hex. OTG_FS_DEVICE-FS_DOEPMSK 1b. ;
: OTG_FS_DEVICE-FS_DAINT. ." OTG_FS_DEVICE-FS_DAINT (read-only) $" OTG_FS_DEVICE-FS_DAINT @ hex. OTG_FS_DEVICE-FS_DAINT 1b. ;
: OTG_FS_DEVICE-FS_DAINTMSK. ." OTG_FS_DEVICE-FS_DAINTMSK (read-write) $" OTG_FS_DEVICE-FS_DAINTMSK @ hex. OTG_FS_DEVICE-FS_DAINTMSK 1b. ;
: OTG_FS_DEVICE-DVBUSDIS. ." OTG_FS_DEVICE-DVBUSDIS (read-write) $" OTG_FS_DEVICE-DVBUSDIS @ hex. OTG_FS_DEVICE-DVBUSDIS 1b. ;
: OTG_FS_DEVICE-DVBUSPULSE. ." OTG_FS_DEVICE-DVBUSPULSE (read-write) $" OTG_FS_DEVICE-DVBUSPULSE @ hex. OTG_FS_DEVICE-DVBUSPULSE 1b. ;
: OTG_FS_DEVICE-DIEPEMPMSK. ." OTG_FS_DEVICE-DIEPEMPMSK (read-write) $" OTG_FS_DEVICE-DIEPEMPMSK @ hex. OTG_FS_DEVICE-DIEPEMPMSK 1b. ;
: OTG_FS_DEVICE-FS_DIEPCTL0. ." OTG_FS_DEVICE-FS_DIEPCTL0 () $" OTG_FS_DEVICE-FS_DIEPCTL0 @ hex. OTG_FS_DEVICE-FS_DIEPCTL0 1b. ;
: OTG_FS_DEVICE-DIEPCTL1. ." OTG_FS_DEVICE-DIEPCTL1 () $" OTG_FS_DEVICE-DIEPCTL1 @ hex. OTG_FS_DEVICE-DIEPCTL1 1b. ;
: OTG_FS_DEVICE-DIEPCTL2. ." OTG_FS_DEVICE-DIEPCTL2 () $" OTG_FS_DEVICE-DIEPCTL2 @ hex. OTG_FS_DEVICE-DIEPCTL2 1b. ;
: OTG_FS_DEVICE-DIEPCTL3. ." OTG_FS_DEVICE-DIEPCTL3 () $" OTG_FS_DEVICE-DIEPCTL3 @ hex. OTG_FS_DEVICE-DIEPCTL3 1b. ;
: OTG_FS_DEVICE-DOEPCTL0. ." OTG_FS_DEVICE-DOEPCTL0 () $" OTG_FS_DEVICE-DOEPCTL0 @ hex. OTG_FS_DEVICE-DOEPCTL0 1b. ;
: OTG_FS_DEVICE-DOEPCTL1. ." OTG_FS_DEVICE-DOEPCTL1 () $" OTG_FS_DEVICE-DOEPCTL1 @ hex. OTG_FS_DEVICE-DOEPCTL1 1b. ;
: OTG_FS_DEVICE-DOEPCTL2. ." OTG_FS_DEVICE-DOEPCTL2 () $" OTG_FS_DEVICE-DOEPCTL2 @ hex. OTG_FS_DEVICE-DOEPCTL2 1b. ;
: OTG_FS_DEVICE-DOEPCTL3. ." OTG_FS_DEVICE-DOEPCTL3 () $" OTG_FS_DEVICE-DOEPCTL3 @ hex. OTG_FS_DEVICE-DOEPCTL3 1b. ;
: OTG_FS_DEVICE-DIEPINT0. ." OTG_FS_DEVICE-DIEPINT0 () $" OTG_FS_DEVICE-DIEPINT0 @ hex. OTG_FS_DEVICE-DIEPINT0 1b. ;
: OTG_FS_DEVICE-DIEPINT1. ." OTG_FS_DEVICE-DIEPINT1 () $" OTG_FS_DEVICE-DIEPINT1 @ hex. OTG_FS_DEVICE-DIEPINT1 1b. ;
: OTG_FS_DEVICE-DIEPINT2. ." OTG_FS_DEVICE-DIEPINT2 () $" OTG_FS_DEVICE-DIEPINT2 @ hex. OTG_FS_DEVICE-DIEPINT2 1b. ;
: OTG_FS_DEVICE-DIEPINT3. ." OTG_FS_DEVICE-DIEPINT3 () $" OTG_FS_DEVICE-DIEPINT3 @ hex. OTG_FS_DEVICE-DIEPINT3 1b. ;
: OTG_FS_DEVICE-DOEPINT0. ." OTG_FS_DEVICE-DOEPINT0 (read-write) $" OTG_FS_DEVICE-DOEPINT0 @ hex. OTG_FS_DEVICE-DOEPINT0 1b. ;
: OTG_FS_DEVICE-DOEPINT1. ." OTG_FS_DEVICE-DOEPINT1 (read-write) $" OTG_FS_DEVICE-DOEPINT1 @ hex. OTG_FS_DEVICE-DOEPINT1 1b. ;
: OTG_FS_DEVICE-DOEPINT2. ." OTG_FS_DEVICE-DOEPINT2 (read-write) $" OTG_FS_DEVICE-DOEPINT2 @ hex. OTG_FS_DEVICE-DOEPINT2 1b. ;
: OTG_FS_DEVICE-DOEPINT3. ." OTG_FS_DEVICE-DOEPINT3 (read-write) $" OTG_FS_DEVICE-DOEPINT3 @ hex. OTG_FS_DEVICE-DOEPINT3 1b. ;
: OTG_FS_DEVICE-DIEPTSIZ0. ." OTG_FS_DEVICE-DIEPTSIZ0 (read-write) $" OTG_FS_DEVICE-DIEPTSIZ0 @ hex. OTG_FS_DEVICE-DIEPTSIZ0 1b. ;
: OTG_FS_DEVICE-DOEPTSIZ0. ." OTG_FS_DEVICE-DOEPTSIZ0 (read-write) $" OTG_FS_DEVICE-DOEPTSIZ0 @ hex. OTG_FS_DEVICE-DOEPTSIZ0 1b. ;
: OTG_FS_DEVICE-DIEPTSIZ1. ." OTG_FS_DEVICE-DIEPTSIZ1 (read-write) $" OTG_FS_DEVICE-DIEPTSIZ1 @ hex. OTG_FS_DEVICE-DIEPTSIZ1 1b. ;
: OTG_FS_DEVICE-DIEPTSIZ2. ." OTG_FS_DEVICE-DIEPTSIZ2 (read-write) $" OTG_FS_DEVICE-DIEPTSIZ2 @ hex. OTG_FS_DEVICE-DIEPTSIZ2 1b. ;
: OTG_FS_DEVICE-DIEPTSIZ3. ." OTG_FS_DEVICE-DIEPTSIZ3 (read-write) $" OTG_FS_DEVICE-DIEPTSIZ3 @ hex. OTG_FS_DEVICE-DIEPTSIZ3 1b. ;
: OTG_FS_DEVICE-DTXFSTS0. ." OTG_FS_DEVICE-DTXFSTS0 (read-only) $" OTG_FS_DEVICE-DTXFSTS0 @ hex. OTG_FS_DEVICE-DTXFSTS0 1b. ;
: OTG_FS_DEVICE-DTXFSTS1. ." OTG_FS_DEVICE-DTXFSTS1 (read-only) $" OTG_FS_DEVICE-DTXFSTS1 @ hex. OTG_FS_DEVICE-DTXFSTS1 1b. ;
: OTG_FS_DEVICE-DTXFSTS2. ." OTG_FS_DEVICE-DTXFSTS2 (read-only) $" OTG_FS_DEVICE-DTXFSTS2 @ hex. OTG_FS_DEVICE-DTXFSTS2 1b. ;
: OTG_FS_DEVICE-DTXFSTS3. ." OTG_FS_DEVICE-DTXFSTS3 (read-only) $" OTG_FS_DEVICE-DTXFSTS3 @ hex. OTG_FS_DEVICE-DTXFSTS3 1b. ;
: OTG_FS_DEVICE-DOEPTSIZ1. ." OTG_FS_DEVICE-DOEPTSIZ1 (read-write) $" OTG_FS_DEVICE-DOEPTSIZ1 @ hex. OTG_FS_DEVICE-DOEPTSIZ1 1b. ;
: OTG_FS_DEVICE-DOEPTSIZ2. ." OTG_FS_DEVICE-DOEPTSIZ2 (read-write) $" OTG_FS_DEVICE-DOEPTSIZ2 @ hex. OTG_FS_DEVICE-DOEPTSIZ2 1b. ;
: OTG_FS_DEVICE-DOEPTSIZ3. ." OTG_FS_DEVICE-DOEPTSIZ3 (read-write) $" OTG_FS_DEVICE-DOEPTSIZ3 @ hex. OTG_FS_DEVICE-DOEPTSIZ3 1b. ;
: OTG_FS_DEVICE.
OTG_FS_DEVICE-FS_DCFG.
OTG_FS_DEVICE-FS_DCTL.
OTG_FS_DEVICE-FS_DSTS.
OTG_FS_DEVICE-FS_DIEPMSK.
OTG_FS_DEVICE-FS_DOEPMSK.
OTG_FS_DEVICE-FS_DAINT.
OTG_FS_DEVICE-FS_DAINTMSK.
OTG_FS_DEVICE-DVBUSDIS.
OTG_FS_DEVICE-DVBUSPULSE.
OTG_FS_DEVICE-DIEPEMPMSK.
OTG_FS_DEVICE-FS_DIEPCTL0.
OTG_FS_DEVICE-DIEPCTL1.
OTG_FS_DEVICE-DIEPCTL2.
OTG_FS_DEVICE-DIEPCTL3.
OTG_FS_DEVICE-DOEPCTL0.
OTG_FS_DEVICE-DOEPCTL1.
OTG_FS_DEVICE-DOEPCTL2.
OTG_FS_DEVICE-DOEPCTL3.
OTG_FS_DEVICE-DIEPINT0.
OTG_FS_DEVICE-DIEPINT1.
OTG_FS_DEVICE-DIEPINT2.
OTG_FS_DEVICE-DIEPINT3.
OTG_FS_DEVICE-DOEPINT0.
OTG_FS_DEVICE-DOEPINT1.
OTG_FS_DEVICE-DOEPINT2.
OTG_FS_DEVICE-DOEPINT3.
OTG_FS_DEVICE-DIEPTSIZ0.
OTG_FS_DEVICE-DOEPTSIZ0.
OTG_FS_DEVICE-DIEPTSIZ1.
OTG_FS_DEVICE-DIEPTSIZ2.
OTG_FS_DEVICE-DIEPTSIZ3.
OTG_FS_DEVICE-DTXFSTS0.
OTG_FS_DEVICE-DTXFSTS1.
OTG_FS_DEVICE-DTXFSTS2.
OTG_FS_DEVICE-DTXFSTS3.
OTG_FS_DEVICE-DOEPTSIZ1.
OTG_FS_DEVICE-DOEPTSIZ2.
OTG_FS_DEVICE-DOEPTSIZ3.
;

$50000000 constant OTG_FS_GLOBAL ( USB on the go full speed )
OTG_FS_GLOBAL $0 + constant OTG_FS_GLOBAL-FS_GOTGCTL ( OTG_FS control and status register
  OTG_FS_GOTGCTL )
OTG_FS_GLOBAL $4 + constant OTG_FS_GLOBAL-FS_GOTGINT ( OTG_FS interrupt register
  OTG_FS_GOTGINT )
OTG_FS_GLOBAL $8 + constant OTG_FS_GLOBAL-FS_GAHBCFG ( OTG_FS AHB configuration register
  OTG_FS_GAHBCFG )
OTG_FS_GLOBAL $C + constant OTG_FS_GLOBAL-FS_GUSBCFG ( OTG_FS USB configuration register
  OTG_FS_GUSBCFG )
OTG_FS_GLOBAL $10 + constant OTG_FS_GLOBAL-FS_GRSTCTL ( OTG_FS reset register
  OTG_FS_GRSTCTL )
OTG_FS_GLOBAL $14 + constant OTG_FS_GLOBAL-FS_GINTSTS ( OTG_FS core interrupt register
  OTG_FS_GINTSTS )
OTG_FS_GLOBAL $18 + constant OTG_FS_GLOBAL-FS_GINTMSK ( OTG_FS interrupt mask register
  OTG_FS_GINTMSK )
OTG_FS_GLOBAL $1C + constant OTG_FS_GLOBAL-FS_GRXSTSR_Device ( OTG_FS Receive status debug readDevice
  mode )
OTG_FS_GLOBAL $1C + constant OTG_FS_GLOBAL-FS_GRXSTSR_Host ( OTG_FS Receive status debug readHost
  mode )
OTG_FS_GLOBAL $24 + constant OTG_FS_GLOBAL-FS_GRXFSIZ ( OTG_FS Receive FIFO size register
  OTG_FS_GRXFSIZ )
OTG_FS_GLOBAL $28 + constant OTG_FS_GLOBAL-FS_GNPTXFSIZ_Device ( OTG_FS non-periodic transmit FIFO size
  register Device mode )
OTG_FS_GLOBAL $28 + constant OTG_FS_GLOBAL-FS_GNPTXFSIZ_Host ( OTG_FS non-periodic transmit FIFO size
  register Host mode )
OTG_FS_GLOBAL $2C + constant OTG_FS_GLOBAL-FS_GNPTXSTS ( OTG_FS non-periodic transmit FIFO/queue
  status register OTG_FS_GNPTXSTS )
OTG_FS_GLOBAL $38 + constant OTG_FS_GLOBAL-FS_GCCFG ( OTG_FS general core configuration register
  OTG_FS_GCCFG )
OTG_FS_GLOBAL $3C + constant OTG_FS_GLOBAL-FS_CID ( core ID register )
OTG_FS_GLOBAL $100 + constant OTG_FS_GLOBAL-FS_HPTXFSIZ ( OTG_FS Host periodic transmit FIFO size
  register OTG_FS_HPTXFSIZ )
OTG_FS_GLOBAL $104 + constant OTG_FS_GLOBAL-FS_DIEPTXF1 ( OTG_FS device IN endpoint transmit FIFO size
  register OTG_FS_DIEPTXF2 )
OTG_FS_GLOBAL $108 + constant OTG_FS_GLOBAL-FS_DIEPTXF2 ( OTG_FS device IN endpoint transmit FIFO size
  register OTG_FS_DIEPTXF3 )
OTG_FS_GLOBAL $10C + constant OTG_FS_GLOBAL-FS_DIEPTXF3 ( OTG_FS device IN endpoint transmit FIFO size
  register OTG_FS_DIEPTXF4 )
: OTG_FS_GLOBAL-FS_GOTGCTL. ." OTG_FS_GLOBAL-FS_GOTGCTL () $" OTG_FS_GLOBAL-FS_GOTGCTL @ hex. OTG_FS_GLOBAL-FS_GOTGCTL 1b. ;
: OTG_FS_GLOBAL-FS_GOTGINT. ." OTG_FS_GLOBAL-FS_GOTGINT (read-write) $" OTG_FS_GLOBAL-FS_GOTGINT @ hex. OTG_FS_GLOBAL-FS_GOTGINT 1b. ;
: OTG_FS_GLOBAL-FS_GAHBCFG. ." OTG_FS_GLOBAL-FS_GAHBCFG (read-write) $" OTG_FS_GLOBAL-FS_GAHBCFG @ hex. OTG_FS_GLOBAL-FS_GAHBCFG 1b. ;
: OTG_FS_GLOBAL-FS_GUSBCFG. ." OTG_FS_GLOBAL-FS_GUSBCFG () $" OTG_FS_GLOBAL-FS_GUSBCFG @ hex. OTG_FS_GLOBAL-FS_GUSBCFG 1b. ;
: OTG_FS_GLOBAL-FS_GRSTCTL. ." OTG_FS_GLOBAL-FS_GRSTCTL () $" OTG_FS_GLOBAL-FS_GRSTCTL @ hex. OTG_FS_GLOBAL-FS_GRSTCTL 1b. ;
: OTG_FS_GLOBAL-FS_GINTSTS. ." OTG_FS_GLOBAL-FS_GINTSTS () $" OTG_FS_GLOBAL-FS_GINTSTS @ hex. OTG_FS_GLOBAL-FS_GINTSTS 1b. ;
: OTG_FS_GLOBAL-FS_GINTMSK. ." OTG_FS_GLOBAL-FS_GINTMSK () $" OTG_FS_GLOBAL-FS_GINTMSK @ hex. OTG_FS_GLOBAL-FS_GINTMSK 1b. ;
: OTG_FS_GLOBAL-FS_GRXSTSR_Device. ." OTG_FS_GLOBAL-FS_GRXSTSR_Device (read-only) $" OTG_FS_GLOBAL-FS_GRXSTSR_Device @ hex. OTG_FS_GLOBAL-FS_GRXSTSR_Device 1b. ;
: OTG_FS_GLOBAL-FS_GRXSTSR_Host. ." OTG_FS_GLOBAL-FS_GRXSTSR_Host (read-only) $" OTG_FS_GLOBAL-FS_GRXSTSR_Host @ hex. OTG_FS_GLOBAL-FS_GRXSTSR_Host 1b. ;
: OTG_FS_GLOBAL-FS_GRXFSIZ. ." OTG_FS_GLOBAL-FS_GRXFSIZ (read-write) $" OTG_FS_GLOBAL-FS_GRXFSIZ @ hex. OTG_FS_GLOBAL-FS_GRXFSIZ 1b. ;
: OTG_FS_GLOBAL-FS_GNPTXFSIZ_Device. ." OTG_FS_GLOBAL-FS_GNPTXFSIZ_Device (read-write) $" OTG_FS_GLOBAL-FS_GNPTXFSIZ_Device @ hex. OTG_FS_GLOBAL-FS_GNPTXFSIZ_Device 1b. ;
: OTG_FS_GLOBAL-FS_GNPTXFSIZ_Host. ." OTG_FS_GLOBAL-FS_GNPTXFSIZ_Host (read-write) $" OTG_FS_GLOBAL-FS_GNPTXFSIZ_Host @ hex. OTG_FS_GLOBAL-FS_GNPTXFSIZ_Host 1b. ;
: OTG_FS_GLOBAL-FS_GNPTXSTS. ." OTG_FS_GLOBAL-FS_GNPTXSTS (read-only) $" OTG_FS_GLOBAL-FS_GNPTXSTS @ hex. OTG_FS_GLOBAL-FS_GNPTXSTS 1b. ;
: OTG_FS_GLOBAL-FS_GCCFG. ." OTG_FS_GLOBAL-FS_GCCFG (read-write) $" OTG_FS_GLOBAL-FS_GCCFG @ hex. OTG_FS_GLOBAL-FS_GCCFG 1b. ;
: OTG_FS_GLOBAL-FS_CID. ." OTG_FS_GLOBAL-FS_CID (read-write) $" OTG_FS_GLOBAL-FS_CID @ hex. OTG_FS_GLOBAL-FS_CID 1b. ;
: OTG_FS_GLOBAL-FS_HPTXFSIZ. ." OTG_FS_GLOBAL-FS_HPTXFSIZ (read-write) $" OTG_FS_GLOBAL-FS_HPTXFSIZ @ hex. OTG_FS_GLOBAL-FS_HPTXFSIZ 1b. ;
: OTG_FS_GLOBAL-FS_DIEPTXF1. ." OTG_FS_GLOBAL-FS_DIEPTXF1 (read-write) $" OTG_FS_GLOBAL-FS_DIEPTXF1 @ hex. OTG_FS_GLOBAL-FS_DIEPTXF1 1b. ;
: OTG_FS_GLOBAL-FS_DIEPTXF2. ." OTG_FS_GLOBAL-FS_DIEPTXF2 (read-write) $" OTG_FS_GLOBAL-FS_DIEPTXF2 @ hex. OTG_FS_GLOBAL-FS_DIEPTXF2 1b. ;
: OTG_FS_GLOBAL-FS_DIEPTXF3. ." OTG_FS_GLOBAL-FS_DIEPTXF3 (read-write) $" OTG_FS_GLOBAL-FS_DIEPTXF3 @ hex. OTG_FS_GLOBAL-FS_DIEPTXF3 1b. ;
: OTG_FS_GLOBAL.
OTG_FS_GLOBAL-FS_GOTGCTL.
OTG_FS_GLOBAL-FS_GOTGINT.
OTG_FS_GLOBAL-FS_GAHBCFG.
OTG_FS_GLOBAL-FS_GUSBCFG.
OTG_FS_GLOBAL-FS_GRSTCTL.
OTG_FS_GLOBAL-FS_GINTSTS.
OTG_FS_GLOBAL-FS_GINTMSK.
OTG_FS_GLOBAL-FS_GRXSTSR_Device.
OTG_FS_GLOBAL-FS_GRXSTSR_Host.
OTG_FS_GLOBAL-FS_GRXFSIZ.
OTG_FS_GLOBAL-FS_GNPTXFSIZ_Device.
OTG_FS_GLOBAL-FS_GNPTXFSIZ_Host.
OTG_FS_GLOBAL-FS_GNPTXSTS.
OTG_FS_GLOBAL-FS_GCCFG.
OTG_FS_GLOBAL-FS_CID.
OTG_FS_GLOBAL-FS_HPTXFSIZ.
OTG_FS_GLOBAL-FS_DIEPTXF1.
OTG_FS_GLOBAL-FS_DIEPTXF2.
OTG_FS_GLOBAL-FS_DIEPTXF3.
;

$50000400 constant OTG_FS_HOST ( USB on the go full speed )
OTG_FS_HOST $0 + constant OTG_FS_HOST-FS_HCFG ( OTG_FS host configuration register
  OTG_FS_HCFG )
OTG_FS_HOST $4 + constant OTG_FS_HOST-HFIR ( OTG_FS Host frame interval
  register )
OTG_FS_HOST $8 + constant OTG_FS_HOST-FS_HFNUM ( OTG_FS host frame number/frame time
  remaining register OTG_FS_HFNUM )
OTG_FS_HOST $10 + constant OTG_FS_HOST-FS_HPTXSTS ( OTG_FS_Host periodic transmit FIFO/queue
  status register OTG_FS_HPTXSTS )
OTG_FS_HOST $14 + constant OTG_FS_HOST-HAINT ( OTG_FS Host all channels interrupt
  register )
OTG_FS_HOST $18 + constant OTG_FS_HOST-HAINTMSK ( OTG_FS host all channels interrupt mask
  register )
OTG_FS_HOST $40 + constant OTG_FS_HOST-FS_HPRT ( OTG_FS host port control and status register
  OTG_FS_HPRT )
OTG_FS_HOST $100 + constant OTG_FS_HOST-FS_HCCHAR0 ( OTG_FS host channel-0 characteristics
  register OTG_FS_HCCHAR0 )
OTG_FS_HOST $120 + constant OTG_FS_HOST-FS_HCCHAR1 ( OTG_FS host channel-1 characteristics
  register OTG_FS_HCCHAR1 )
OTG_FS_HOST $140 + constant OTG_FS_HOST-FS_HCCHAR2 ( OTG_FS host channel-2 characteristics
  register OTG_FS_HCCHAR2 )
OTG_FS_HOST $160 + constant OTG_FS_HOST-FS_HCCHAR3 ( OTG_FS host channel-3 characteristics
  register OTG_FS_HCCHAR3 )
OTG_FS_HOST $180 + constant OTG_FS_HOST-FS_HCCHAR4 ( OTG_FS host channel-4 characteristics
  register OTG_FS_HCCHAR4 )
OTG_FS_HOST $1A0 + constant OTG_FS_HOST-FS_HCCHAR5 ( OTG_FS host channel-5 characteristics
  register OTG_FS_HCCHAR5 )
OTG_FS_HOST $1C0 + constant OTG_FS_HOST-FS_HCCHAR6 ( OTG_FS host channel-6 characteristics
  register OTG_FS_HCCHAR6 )
OTG_FS_HOST $1E0 + constant OTG_FS_HOST-FS_HCCHAR7 ( OTG_FS host channel-7 characteristics
  register OTG_FS_HCCHAR7 )
OTG_FS_HOST $108 + constant OTG_FS_HOST-FS_HCINT0 ( OTG_FS host channel-0 interrupt register
  OTG_FS_HCINT0 )
OTG_FS_HOST $128 + constant OTG_FS_HOST-FS_HCINT1 ( OTG_FS host channel-1 interrupt register
  OTG_FS_HCINT1 )
OTG_FS_HOST $148 + constant OTG_FS_HOST-FS_HCINT2 ( OTG_FS host channel-2 interrupt register
  OTG_FS_HCINT2 )
OTG_FS_HOST $168 + constant OTG_FS_HOST-FS_HCINT3 ( OTG_FS host channel-3 interrupt register
  OTG_FS_HCINT3 )
OTG_FS_HOST $188 + constant OTG_FS_HOST-FS_HCINT4 ( OTG_FS host channel-4 interrupt register
  OTG_FS_HCINT4 )
OTG_FS_HOST $1A8 + constant OTG_FS_HOST-FS_HCINT5 ( OTG_FS host channel-5 interrupt register
  OTG_FS_HCINT5 )
OTG_FS_HOST $1C8 + constant OTG_FS_HOST-FS_HCINT6 ( OTG_FS host channel-6 interrupt register
  OTG_FS_HCINT6 )
OTG_FS_HOST $1E8 + constant OTG_FS_HOST-FS_HCINT7 ( OTG_FS host channel-7 interrupt register
  OTG_FS_HCINT7 )
OTG_FS_HOST $10C + constant OTG_FS_HOST-FS_HCINTMSK0 ( OTG_FS host channel-0 mask register
  OTG_FS_HCINTMSK0 )
OTG_FS_HOST $12C + constant OTG_FS_HOST-FS_HCINTMSK1 ( OTG_FS host channel-1 mask register
  OTG_FS_HCINTMSK1 )
OTG_FS_HOST $14C + constant OTG_FS_HOST-FS_HCINTMSK2 ( OTG_FS host channel-2 mask register
  OTG_FS_HCINTMSK2 )
OTG_FS_HOST $16C + constant OTG_FS_HOST-FS_HCINTMSK3 ( OTG_FS host channel-3 mask register
  OTG_FS_HCINTMSK3 )
OTG_FS_HOST $18C + constant OTG_FS_HOST-FS_HCINTMSK4 ( OTG_FS host channel-4 mask register
  OTG_FS_HCINTMSK4 )
OTG_FS_HOST $1AC + constant OTG_FS_HOST-FS_HCINTMSK5 ( OTG_FS host channel-5 mask register
  OTG_FS_HCINTMSK5 )
OTG_FS_HOST $1CC + constant OTG_FS_HOST-FS_HCINTMSK6 ( OTG_FS host channel-6 mask register
  OTG_FS_HCINTMSK6 )
OTG_FS_HOST $1EC + constant OTG_FS_HOST-FS_HCINTMSK7 ( OTG_FS host channel-7 mask register
  OTG_FS_HCINTMSK7 )
OTG_FS_HOST $110 + constant OTG_FS_HOST-FS_HCTSIZ0 ( OTG_FS host channel-0 transfer size
  register )
OTG_FS_HOST $130 + constant OTG_FS_HOST-FS_HCTSIZ1 ( OTG_FS host channel-1 transfer size
  register )
OTG_FS_HOST $150 + constant OTG_FS_HOST-FS_HCTSIZ2 ( OTG_FS host channel-2 transfer size
  register )
OTG_FS_HOST $170 + constant OTG_FS_HOST-FS_HCTSIZ3 ( OTG_FS host channel-3 transfer size
  register )
OTG_FS_HOST $190 + constant OTG_FS_HOST-FS_HCTSIZ4 ( OTG_FS host channel-x transfer size
  register )
OTG_FS_HOST $1B0 + constant OTG_FS_HOST-FS_HCTSIZ5 ( OTG_FS host channel-5 transfer size
  register )
OTG_FS_HOST $1D0 + constant OTG_FS_HOST-FS_HCTSIZ6 ( OTG_FS host channel-6 transfer size
  register )
OTG_FS_HOST $1F0 + constant OTG_FS_HOST-FS_HCTSIZ7 ( OTG_FS host channel-7 transfer size
  register )
: OTG_FS_HOST-FS_HCFG. ." OTG_FS_HOST-FS_HCFG () $" OTG_FS_HOST-FS_HCFG @ hex. OTG_FS_HOST-FS_HCFG 1b. ;
: OTG_FS_HOST-HFIR. ." OTG_FS_HOST-HFIR (read-write) $" OTG_FS_HOST-HFIR @ hex. OTG_FS_HOST-HFIR 1b. ;
: OTG_FS_HOST-FS_HFNUM. ." OTG_FS_HOST-FS_HFNUM (read-only) $" OTG_FS_HOST-FS_HFNUM @ hex. OTG_FS_HOST-FS_HFNUM 1b. ;
: OTG_FS_HOST-FS_HPTXSTS. ." OTG_FS_HOST-FS_HPTXSTS () $" OTG_FS_HOST-FS_HPTXSTS @ hex. OTG_FS_HOST-FS_HPTXSTS 1b. ;
: OTG_FS_HOST-HAINT. ." OTG_FS_HOST-HAINT (read-only) $" OTG_FS_HOST-HAINT @ hex. OTG_FS_HOST-HAINT 1b. ;
: OTG_FS_HOST-HAINTMSK. ." OTG_FS_HOST-HAINTMSK (read-write) $" OTG_FS_HOST-HAINTMSK @ hex. OTG_FS_HOST-HAINTMSK 1b. ;
: OTG_FS_HOST-FS_HPRT. ." OTG_FS_HOST-FS_HPRT () $" OTG_FS_HOST-FS_HPRT @ hex. OTG_FS_HOST-FS_HPRT 1b. ;
: OTG_FS_HOST-FS_HCCHAR0. ." OTG_FS_HOST-FS_HCCHAR0 (read-write) $" OTG_FS_HOST-FS_HCCHAR0 @ hex. OTG_FS_HOST-FS_HCCHAR0 1b. ;
: OTG_FS_HOST-FS_HCCHAR1. ." OTG_FS_HOST-FS_HCCHAR1 (read-write) $" OTG_FS_HOST-FS_HCCHAR1 @ hex. OTG_FS_HOST-FS_HCCHAR1 1b. ;
: OTG_FS_HOST-FS_HCCHAR2. ." OTG_FS_HOST-FS_HCCHAR2 (read-write) $" OTG_FS_HOST-FS_HCCHAR2 @ hex. OTG_FS_HOST-FS_HCCHAR2 1b. ;
: OTG_FS_HOST-FS_HCCHAR3. ." OTG_FS_HOST-FS_HCCHAR3 (read-write) $" OTG_FS_HOST-FS_HCCHAR3 @ hex. OTG_FS_HOST-FS_HCCHAR3 1b. ;
: OTG_FS_HOST-FS_HCCHAR4. ." OTG_FS_HOST-FS_HCCHAR4 (read-write) $" OTG_FS_HOST-FS_HCCHAR4 @ hex. OTG_FS_HOST-FS_HCCHAR4 1b. ;
: OTG_FS_HOST-FS_HCCHAR5. ." OTG_FS_HOST-FS_HCCHAR5 (read-write) $" OTG_FS_HOST-FS_HCCHAR5 @ hex. OTG_FS_HOST-FS_HCCHAR5 1b. ;
: OTG_FS_HOST-FS_HCCHAR6. ." OTG_FS_HOST-FS_HCCHAR6 (read-write) $" OTG_FS_HOST-FS_HCCHAR6 @ hex. OTG_FS_HOST-FS_HCCHAR6 1b. ;
: OTG_FS_HOST-FS_HCCHAR7. ." OTG_FS_HOST-FS_HCCHAR7 (read-write) $" OTG_FS_HOST-FS_HCCHAR7 @ hex. OTG_FS_HOST-FS_HCCHAR7 1b. ;
: OTG_FS_HOST-FS_HCINT0. ." OTG_FS_HOST-FS_HCINT0 (read-write) $" OTG_FS_HOST-FS_HCINT0 @ hex. OTG_FS_HOST-FS_HCINT0 1b. ;
: OTG_FS_HOST-FS_HCINT1. ." OTG_FS_HOST-FS_HCINT1 (read-write) $" OTG_FS_HOST-FS_HCINT1 @ hex. OTG_FS_HOST-FS_HCINT1 1b. ;
: OTG_FS_HOST-FS_HCINT2. ." OTG_FS_HOST-FS_HCINT2 (read-write) $" OTG_FS_HOST-FS_HCINT2 @ hex. OTG_FS_HOST-FS_HCINT2 1b. ;
: OTG_FS_HOST-FS_HCINT3. ." OTG_FS_HOST-FS_HCINT3 (read-write) $" OTG_FS_HOST-FS_HCINT3 @ hex. OTG_FS_HOST-FS_HCINT3 1b. ;
: OTG_FS_HOST-FS_HCINT4. ." OTG_FS_HOST-FS_HCINT4 (read-write) $" OTG_FS_HOST-FS_HCINT4 @ hex. OTG_FS_HOST-FS_HCINT4 1b. ;
: OTG_FS_HOST-FS_HCINT5. ." OTG_FS_HOST-FS_HCINT5 (read-write) $" OTG_FS_HOST-FS_HCINT5 @ hex. OTG_FS_HOST-FS_HCINT5 1b. ;
: OTG_FS_HOST-FS_HCINT6. ." OTG_FS_HOST-FS_HCINT6 (read-write) $" OTG_FS_HOST-FS_HCINT6 @ hex. OTG_FS_HOST-FS_HCINT6 1b. ;
: OTG_FS_HOST-FS_HCINT7. ." OTG_FS_HOST-FS_HCINT7 (read-write) $" OTG_FS_HOST-FS_HCINT7 @ hex. OTG_FS_HOST-FS_HCINT7 1b. ;
: OTG_FS_HOST-FS_HCINTMSK0. ." OTG_FS_HOST-FS_HCINTMSK0 (read-write) $" OTG_FS_HOST-FS_HCINTMSK0 @ hex. OTG_FS_HOST-FS_HCINTMSK0 1b. ;
: OTG_FS_HOST-FS_HCINTMSK1. ." OTG_FS_HOST-FS_HCINTMSK1 (read-write) $" OTG_FS_HOST-FS_HCINTMSK1 @ hex. OTG_FS_HOST-FS_HCINTMSK1 1b. ;
: OTG_FS_HOST-FS_HCINTMSK2. ." OTG_FS_HOST-FS_HCINTMSK2 (read-write) $" OTG_FS_HOST-FS_HCINTMSK2 @ hex. OTG_FS_HOST-FS_HCINTMSK2 1b. ;
: OTG_FS_HOST-FS_HCINTMSK3. ." OTG_FS_HOST-FS_HCINTMSK3 (read-write) $" OTG_FS_HOST-FS_HCINTMSK3 @ hex. OTG_FS_HOST-FS_HCINTMSK3 1b. ;
: OTG_FS_HOST-FS_HCINTMSK4. ." OTG_FS_HOST-FS_HCINTMSK4 (read-write) $" OTG_FS_HOST-FS_HCINTMSK4 @ hex. OTG_FS_HOST-FS_HCINTMSK4 1b. ;
: OTG_FS_HOST-FS_HCINTMSK5. ." OTG_FS_HOST-FS_HCINTMSK5 (read-write) $" OTG_FS_HOST-FS_HCINTMSK5 @ hex. OTG_FS_HOST-FS_HCINTMSK5 1b. ;
: OTG_FS_HOST-FS_HCINTMSK6. ." OTG_FS_HOST-FS_HCINTMSK6 (read-write) $" OTG_FS_HOST-FS_HCINTMSK6 @ hex. OTG_FS_HOST-FS_HCINTMSK6 1b. ;
: OTG_FS_HOST-FS_HCINTMSK7. ." OTG_FS_HOST-FS_HCINTMSK7 (read-write) $" OTG_FS_HOST-FS_HCINTMSK7 @ hex. OTG_FS_HOST-FS_HCINTMSK7 1b. ;
: OTG_FS_HOST-FS_HCTSIZ0. ." OTG_FS_HOST-FS_HCTSIZ0 (read-write) $" OTG_FS_HOST-FS_HCTSIZ0 @ hex. OTG_FS_HOST-FS_HCTSIZ0 1b. ;
: OTG_FS_HOST-FS_HCTSIZ1. ." OTG_FS_HOST-FS_HCTSIZ1 (read-write) $" OTG_FS_HOST-FS_HCTSIZ1 @ hex. OTG_FS_HOST-FS_HCTSIZ1 1b. ;
: OTG_FS_HOST-FS_HCTSIZ2. ." OTG_FS_HOST-FS_HCTSIZ2 (read-write) $" OTG_FS_HOST-FS_HCTSIZ2 @ hex. OTG_FS_HOST-FS_HCTSIZ2 1b. ;
: OTG_FS_HOST-FS_HCTSIZ3. ." OTG_FS_HOST-FS_HCTSIZ3 (read-write) $" OTG_FS_HOST-FS_HCTSIZ3 @ hex. OTG_FS_HOST-FS_HCTSIZ3 1b. ;
: OTG_FS_HOST-FS_HCTSIZ4. ." OTG_FS_HOST-FS_HCTSIZ4 (read-write) $" OTG_FS_HOST-FS_HCTSIZ4 @ hex. OTG_FS_HOST-FS_HCTSIZ4 1b. ;
: OTG_FS_HOST-FS_HCTSIZ5. ." OTG_FS_HOST-FS_HCTSIZ5 (read-write) $" OTG_FS_HOST-FS_HCTSIZ5 @ hex. OTG_FS_HOST-FS_HCTSIZ5 1b. ;
: OTG_FS_HOST-FS_HCTSIZ6. ." OTG_FS_HOST-FS_HCTSIZ6 (read-write) $" OTG_FS_HOST-FS_HCTSIZ6 @ hex. OTG_FS_HOST-FS_HCTSIZ6 1b. ;
: OTG_FS_HOST-FS_HCTSIZ7. ." OTG_FS_HOST-FS_HCTSIZ7 (read-write) $" OTG_FS_HOST-FS_HCTSIZ7 @ hex. OTG_FS_HOST-FS_HCTSIZ7 1b. ;
: OTG_FS_HOST.
OTG_FS_HOST-FS_HCFG.
OTG_FS_HOST-HFIR.
OTG_FS_HOST-FS_HFNUM.
OTG_FS_HOST-FS_HPTXSTS.
OTG_FS_HOST-HAINT.
OTG_FS_HOST-HAINTMSK.
OTG_FS_HOST-FS_HPRT.
OTG_FS_HOST-FS_HCCHAR0.
OTG_FS_HOST-FS_HCCHAR1.
OTG_FS_HOST-FS_HCCHAR2.
OTG_FS_HOST-FS_HCCHAR3.
OTG_FS_HOST-FS_HCCHAR4.
OTG_FS_HOST-FS_HCCHAR5.
OTG_FS_HOST-FS_HCCHAR6.
OTG_FS_HOST-FS_HCCHAR7.
OTG_FS_HOST-FS_HCINT0.
OTG_FS_HOST-FS_HCINT1.
OTG_FS_HOST-FS_HCINT2.
OTG_FS_HOST-FS_HCINT3.
OTG_FS_HOST-FS_HCINT4.
OTG_FS_HOST-FS_HCINT5.
OTG_FS_HOST-FS_HCINT6.
OTG_FS_HOST-FS_HCINT7.
OTG_FS_HOST-FS_HCINTMSK0.
OTG_FS_HOST-FS_HCINTMSK1.
OTG_FS_HOST-FS_HCINTMSK2.
OTG_FS_HOST-FS_HCINTMSK3.
OTG_FS_HOST-FS_HCINTMSK4.
OTG_FS_HOST-FS_HCINTMSK5.
OTG_FS_HOST-FS_HCINTMSK6.
OTG_FS_HOST-FS_HCINTMSK7.
OTG_FS_HOST-FS_HCTSIZ0.
OTG_FS_HOST-FS_HCTSIZ1.
OTG_FS_HOST-FS_HCTSIZ2.
OTG_FS_HOST-FS_HCTSIZ3.
OTG_FS_HOST-FS_HCTSIZ4.
OTG_FS_HOST-FS_HCTSIZ5.
OTG_FS_HOST-FS_HCTSIZ6.
OTG_FS_HOST-FS_HCTSIZ7.
;

$50000E00 constant OTG_FS_PWRCLK ( USB on the go full speed )
OTG_FS_PWRCLK $0 + constant OTG_FS_PWRCLK-FS_PCGCCTL ( OTG_FS power and clock gating control
  register )
: OTG_FS_PWRCLK-FS_PCGCCTL. ." OTG_FS_PWRCLK-FS_PCGCCTL (read-write) $" OTG_FS_PWRCLK-FS_PCGCCTL @ hex. OTG_FS_PWRCLK-FS_PCGCCTL 1b. ;
: OTG_FS_PWRCLK.
OTG_FS_PWRCLK-FS_PCGCCTL.
;

$40007000 constant PWR ( Power control )
PWR $0 + constant PWR-CR ( power control register )
PWR $4 + constant PWR-CSR ( power control/status register )
: PWR-CR. ." PWR-CR (read-write) $" PWR-CR @ hex. PWR-CR 1b. ;
: PWR-CSR. ." PWR-CSR () $" PWR-CSR @ hex. PWR-CSR 1b. ;
: PWR.
PWR-CR.
PWR-CSR.
;

$40023800 constant RCC ( Reset and clock control )
RCC $0 + constant RCC-CR ( clock control register )
RCC $4 + constant RCC-PLLCFGR ( PLL configuration register )
RCC $8 + constant RCC-CFGR ( clock configuration register )
RCC $C + constant RCC-CIR ( clock interrupt register )
RCC $10 + constant RCC-AHB1RSTR ( AHB1 peripheral reset register )
RCC $14 + constant RCC-AHB2RSTR ( AHB2 peripheral reset register )
RCC $20 + constant RCC-APB1RSTR ( APB1 peripheral reset register )
RCC $24 + constant RCC-APB2RSTR ( APB2 peripheral reset register )
RCC $30 + constant RCC-AHB1ENR ( AHB1 peripheral clock register )
RCC $34 + constant RCC-AHB2ENR ( AHB2 peripheral clock enable
  register )
RCC $40 + constant RCC-APB1ENR ( APB1 peripheral clock enable
  register )
RCC $44 + constant RCC-APB2ENR ( APB2 peripheral clock enable
  register )
RCC $50 + constant RCC-AHB1LPENR ( AHB1 peripheral clock enable in low power
  mode register )
RCC $54 + constant RCC-AHB2LPENR ( AHB2 peripheral clock enable in low power
  mode register )
RCC $60 + constant RCC-APB1LPENR ( APB1 peripheral clock enable in low power
  mode register )
RCC $64 + constant RCC-APB2LPENR ( APB2 peripheral clock enabled in low power
  mode register )
RCC $70 + constant RCC-BDCR ( Backup domain control register )
RCC $74 + constant RCC-CSR ( clock control & status
  register )
RCC $80 + constant RCC-SSCGR ( spread spectrum clock generation
  register )
RCC $84 + constant RCC-PLLI2SCFGR ( PLLI2S configuration register )
: RCC-CR. ." RCC-CR () $" RCC-CR @ hex. RCC-CR 1b. ;
: RCC-PLLCFGR. ." RCC-PLLCFGR (read-write) $" RCC-PLLCFGR @ hex. RCC-PLLCFGR 1b. ;
: RCC-CFGR. ." RCC-CFGR () $" RCC-CFGR @ hex. RCC-CFGR 1b. ;
: RCC-CIR. ." RCC-CIR () $" RCC-CIR @ hex. RCC-CIR 1b. ;
: RCC-AHB1RSTR. ." RCC-AHB1RSTR (read-write) $" RCC-AHB1RSTR @ hex. RCC-AHB1RSTR 1b. ;
: RCC-AHB2RSTR. ." RCC-AHB2RSTR (read-write) $" RCC-AHB2RSTR @ hex. RCC-AHB2RSTR 1b. ;
: RCC-APB1RSTR. ." RCC-APB1RSTR (read-write) $" RCC-APB1RSTR @ hex. RCC-APB1RSTR 1b. ;
: RCC-APB2RSTR. ." RCC-APB2RSTR (read-write) $" RCC-APB2RSTR @ hex. RCC-APB2RSTR 1b. ;
: RCC-AHB1ENR. ." RCC-AHB1ENR (read-write) $" RCC-AHB1ENR @ hex. RCC-AHB1ENR 1b. ;
: RCC-AHB2ENR. ." RCC-AHB2ENR (read-write) $" RCC-AHB2ENR @ hex. RCC-AHB2ENR 1b. ;
: RCC-APB1ENR. ." RCC-APB1ENR (read-write) $" RCC-APB1ENR @ hex. RCC-APB1ENR 1b. ;
: RCC-APB2ENR. ." RCC-APB2ENR (read-write) $" RCC-APB2ENR @ hex. RCC-APB2ENR 1b. ;
: RCC-AHB1LPENR. ." RCC-AHB1LPENR (read-write) $" RCC-AHB1LPENR @ hex. RCC-AHB1LPENR 1b. ;
: RCC-AHB2LPENR. ." RCC-AHB2LPENR (read-write) $" RCC-AHB2LPENR @ hex. RCC-AHB2LPENR 1b. ;
: RCC-APB1LPENR. ." RCC-APB1LPENR (read-write) $" RCC-APB1LPENR @ hex. RCC-APB1LPENR 1b. ;
: RCC-APB2LPENR. ." RCC-APB2LPENR (read-write) $" RCC-APB2LPENR @ hex. RCC-APB2LPENR 1b. ;
: RCC-BDCR. ." RCC-BDCR () $" RCC-BDCR @ hex. RCC-BDCR 1b. ;
: RCC-CSR. ." RCC-CSR () $" RCC-CSR @ hex. RCC-CSR 1b. ;
: RCC-SSCGR. ." RCC-SSCGR (read-write) $" RCC-SSCGR @ hex. RCC-SSCGR 1b. ;
: RCC-PLLI2SCFGR. ." RCC-PLLI2SCFGR (read-write) $" RCC-PLLI2SCFGR @ hex. RCC-PLLI2SCFGR 1b. ;
: RCC.
RCC-CR.
RCC-PLLCFGR.
RCC-CFGR.
RCC-CIR.
RCC-AHB1RSTR.
RCC-AHB2RSTR.
RCC-APB1RSTR.
RCC-APB2RSTR.
RCC-AHB1ENR.
RCC-AHB2ENR.
RCC-APB1ENR.
RCC-APB2ENR.
RCC-AHB1LPENR.
RCC-AHB2LPENR.
RCC-APB1LPENR.
RCC-APB2LPENR.
RCC-BDCR.
RCC-CSR.
RCC-SSCGR.
RCC-PLLI2SCFGR.
;

$40002800 constant RTC ( Real-time clock )
RTC $0 + constant RTC-TR ( time register )
RTC $4 + constant RTC-DR ( date register )
RTC $8 + constant RTC-CR ( control register )
RTC $C + constant RTC-ISR ( initialization and status
  register )
RTC $10 + constant RTC-PRER ( prescaler register )
RTC $14 + constant RTC-WUTR ( wakeup timer register )
RTC $18 + constant RTC-CALIBR ( calibration register )
RTC $1C + constant RTC-ALRMAR ( alarm A register )
RTC $20 + constant RTC-ALRMBR ( alarm B register )
RTC $24 + constant RTC-WPR ( write protection register )
RTC $28 + constant RTC-SSR ( sub second register )
RTC $2C + constant RTC-SHIFTR ( shift control register )
RTC $30 + constant RTC-TSTR ( time stamp time register )
RTC $34 + constant RTC-TSDR ( time stamp date register )
RTC $38 + constant RTC-TSSSR ( timestamp sub second register )
RTC $3C + constant RTC-CALR ( calibration register )
RTC $40 + constant RTC-TAFCR ( tamper and alternate function configuration
  register )
RTC $44 + constant RTC-ALRMASSR ( alarm A sub second register )
RTC $48 + constant RTC-ALRMBSSR ( alarm B sub second register )
RTC $50 + constant RTC-BKP0R ( backup register )
RTC $54 + constant RTC-BKP1R ( backup register )
RTC $58 + constant RTC-BKP2R ( backup register )
RTC $5C + constant RTC-BKP3R ( backup register )
RTC $60 + constant RTC-BKP4R ( backup register )
RTC $64 + constant RTC-BKP5R ( backup register )
RTC $68 + constant RTC-BKP6R ( backup register )
RTC $6C + constant RTC-BKP7R ( backup register )
RTC $70 + constant RTC-BKP8R ( backup register )
RTC $74 + constant RTC-BKP9R ( backup register )
RTC $78 + constant RTC-BKP10R ( backup register )
RTC $7C + constant RTC-BKP11R ( backup register )
RTC $80 + constant RTC-BKP12R ( backup register )
RTC $84 + constant RTC-BKP13R ( backup register )
RTC $88 + constant RTC-BKP14R ( backup register )
RTC $8C + constant RTC-BKP15R ( backup register )
RTC $90 + constant RTC-BKP16R ( backup register )
RTC $94 + constant RTC-BKP17R ( backup register )
RTC $98 + constant RTC-BKP18R ( backup register )
RTC $9C + constant RTC-BKP19R ( backup register )
: RTC-TR. ." RTC-TR (read-write) $" RTC-TR @ hex. RTC-TR 1b. ;
: RTC-DR. ." RTC-DR (read-write) $" RTC-DR @ hex. RTC-DR 1b. ;
: RTC-CR. ." RTC-CR (read-write) $" RTC-CR @ hex. RTC-CR 1b. ;
: RTC-ISR. ." RTC-ISR () $" RTC-ISR @ hex. RTC-ISR 1b. ;
: RTC-PRER. ." RTC-PRER (read-write) $" RTC-PRER @ hex. RTC-PRER 1b. ;
: RTC-WUTR. ." RTC-WUTR (read-write) $" RTC-WUTR @ hex. RTC-WUTR 1b. ;
: RTC-CALIBR. ." RTC-CALIBR (read-write) $" RTC-CALIBR @ hex. RTC-CALIBR 1b. ;
: RTC-ALRMAR. ." RTC-ALRMAR (read-write) $" RTC-ALRMAR @ hex. RTC-ALRMAR 1b. ;
: RTC-ALRMBR. ." RTC-ALRMBR (read-write) $" RTC-ALRMBR @ hex. RTC-ALRMBR 1b. ;
: RTC-WPR. ." RTC-WPR (write-only) $" RTC-WPR @ hex. RTC-WPR 1b. ;
: RTC-SSR. ." RTC-SSR (read-only) $" RTC-SSR @ hex. RTC-SSR 1b. ;
: RTC-SHIFTR. ." RTC-SHIFTR (write-only) $" RTC-SHIFTR @ hex. RTC-SHIFTR 1b. ;
: RTC-TSTR. ." RTC-TSTR (read-only) $" RTC-TSTR @ hex. RTC-TSTR 1b. ;
: RTC-TSDR. ." RTC-TSDR (read-only) $" RTC-TSDR @ hex. RTC-TSDR 1b. ;
: RTC-TSSSR. ." RTC-TSSSR (read-only) $" RTC-TSSSR @ hex. RTC-TSSSR 1b. ;
: RTC-CALR. ." RTC-CALR (read-write) $" RTC-CALR @ hex. RTC-CALR 1b. ;
: RTC-TAFCR. ." RTC-TAFCR (read-write) $" RTC-TAFCR @ hex. RTC-TAFCR 1b. ;
: RTC-ALRMASSR. ." RTC-ALRMASSR (read-write) $" RTC-ALRMASSR @ hex. RTC-ALRMASSR 1b. ;
: RTC-ALRMBSSR. ." RTC-ALRMBSSR (read-write) $" RTC-ALRMBSSR @ hex. RTC-ALRMBSSR 1b. ;
: RTC-BKP0R. ." RTC-BKP0R (read-write) $" RTC-BKP0R @ hex. RTC-BKP0R 1b. ;
: RTC-BKP1R. ." RTC-BKP1R (read-write) $" RTC-BKP1R @ hex. RTC-BKP1R 1b. ;
: RTC-BKP2R. ." RTC-BKP2R (read-write) $" RTC-BKP2R @ hex. RTC-BKP2R 1b. ;
: RTC-BKP3R. ." RTC-BKP3R (read-write) $" RTC-BKP3R @ hex. RTC-BKP3R 1b. ;
: RTC-BKP4R. ." RTC-BKP4R (read-write) $" RTC-BKP4R @ hex. RTC-BKP4R 1b. ;
: RTC-BKP5R. ." RTC-BKP5R (read-write) $" RTC-BKP5R @ hex. RTC-BKP5R 1b. ;
: RTC-BKP6R. ." RTC-BKP6R (read-write) $" RTC-BKP6R @ hex. RTC-BKP6R 1b. ;
: RTC-BKP7R. ." RTC-BKP7R (read-write) $" RTC-BKP7R @ hex. RTC-BKP7R 1b. ;
: RTC-BKP8R. ." RTC-BKP8R (read-write) $" RTC-BKP8R @ hex. RTC-BKP8R 1b. ;
: RTC-BKP9R. ." RTC-BKP9R (read-write) $" RTC-BKP9R @ hex. RTC-BKP9R 1b. ;
: RTC-BKP10R. ." RTC-BKP10R (read-write) $" RTC-BKP10R @ hex. RTC-BKP10R 1b. ;
: RTC-BKP11R. ." RTC-BKP11R (read-write) $" RTC-BKP11R @ hex. RTC-BKP11R 1b. ;
: RTC-BKP12R. ." RTC-BKP12R (read-write) $" RTC-BKP12R @ hex. RTC-BKP12R 1b. ;
: RTC-BKP13R. ." RTC-BKP13R (read-write) $" RTC-BKP13R @ hex. RTC-BKP13R 1b. ;
: RTC-BKP14R. ." RTC-BKP14R (read-write) $" RTC-BKP14R @ hex. RTC-BKP14R 1b. ;
: RTC-BKP15R. ." RTC-BKP15R (read-write) $" RTC-BKP15R @ hex. RTC-BKP15R 1b. ;
: RTC-BKP16R. ." RTC-BKP16R (read-write) $" RTC-BKP16R @ hex. RTC-BKP16R 1b. ;
: RTC-BKP17R. ." RTC-BKP17R (read-write) $" RTC-BKP17R @ hex. RTC-BKP17R 1b. ;
: RTC-BKP18R. ." RTC-BKP18R (read-write) $" RTC-BKP18R @ hex. RTC-BKP18R 1b. ;
: RTC-BKP19R. ." RTC-BKP19R (read-write) $" RTC-BKP19R @ hex. RTC-BKP19R 1b. ;
: RTC.
RTC-TR.
RTC-DR.
RTC-CR.
RTC-ISR.
RTC-PRER.
RTC-WUTR.
RTC-CALIBR.
RTC-ALRMAR.
RTC-ALRMBR.
RTC-WPR.
RTC-SSR.
RTC-SHIFTR.
RTC-TSTR.
RTC-TSDR.
RTC-TSSSR.
RTC-CALR.
RTC-TAFCR.
RTC-ALRMASSR.
RTC-ALRMBSSR.
RTC-BKP0R.
RTC-BKP1R.
RTC-BKP2R.
RTC-BKP3R.
RTC-BKP4R.
RTC-BKP5R.
RTC-BKP6R.
RTC-BKP7R.
RTC-BKP8R.
RTC-BKP9R.
RTC-BKP10R.
RTC-BKP11R.
RTC-BKP12R.
RTC-BKP13R.
RTC-BKP14R.
RTC-BKP15R.
RTC-BKP16R.
RTC-BKP17R.
RTC-BKP18R.
RTC-BKP19R.
;

$40012C00 constant SDIO ( Secure digital input/output
  interface )
SDIO $0 + constant SDIO-POWER ( power control register )
SDIO $4 + constant SDIO-CLKCR ( SDI clock control register )
SDIO $8 + constant SDIO-ARG ( argument register )
SDIO $C + constant SDIO-CMD ( command register )
SDIO $10 + constant SDIO-RESPCMD ( command response register )
SDIO $14 + constant SDIO-RESP1 ( response 1..4 register )
SDIO $18 + constant SDIO-RESP2 ( response 1..4 register )
SDIO $1C + constant SDIO-RESP3 ( response 1..4 register )
SDIO $20 + constant SDIO-RESP4 ( response 1..4 register )
SDIO $24 + constant SDIO-DTIMER ( data timer register )
SDIO $28 + constant SDIO-DLEN ( data length register )
SDIO $2C + constant SDIO-DCTRL ( data control register )
SDIO $30 + constant SDIO-DCOUNT ( data counter register )
SDIO $34 + constant SDIO-STA ( status register )
SDIO $38 + constant SDIO-ICR ( interrupt clear register )
SDIO $3C + constant SDIO-MASK ( mask register )
SDIO $48 + constant SDIO-FIFOCNT ( FIFO counter register )
SDIO $80 + constant SDIO-FIFO ( data FIFO register )
: SDIO-POWER. ." SDIO-POWER (read-write) $" SDIO-POWER @ hex. SDIO-POWER 1b. ;
: SDIO-CLKCR. ." SDIO-CLKCR (read-write) $" SDIO-CLKCR @ hex. SDIO-CLKCR 1b. ;
: SDIO-ARG. ." SDIO-ARG (read-write) $" SDIO-ARG @ hex. SDIO-ARG 1b. ;
: SDIO-CMD. ." SDIO-CMD (read-write) $" SDIO-CMD @ hex. SDIO-CMD 1b. ;
: SDIO-RESPCMD. ." SDIO-RESPCMD (read-only) $" SDIO-RESPCMD @ hex. SDIO-RESPCMD 1b. ;
: SDIO-RESP1. ." SDIO-RESP1 (read-only) $" SDIO-RESP1 @ hex. SDIO-RESP1 1b. ;
: SDIO-RESP2. ." SDIO-RESP2 (read-only) $" SDIO-RESP2 @ hex. SDIO-RESP2 1b. ;
: SDIO-RESP3. ." SDIO-RESP3 (read-only) $" SDIO-RESP3 @ hex. SDIO-RESP3 1b. ;
: SDIO-RESP4. ." SDIO-RESP4 (read-only) $" SDIO-RESP4 @ hex. SDIO-RESP4 1b. ;
: SDIO-DTIMER. ." SDIO-DTIMER (read-write) $" SDIO-DTIMER @ hex. SDIO-DTIMER 1b. ;
: SDIO-DLEN. ." SDIO-DLEN (read-write) $" SDIO-DLEN @ hex. SDIO-DLEN 1b. ;
: SDIO-DCTRL. ." SDIO-DCTRL (read-write) $" SDIO-DCTRL @ hex. SDIO-DCTRL 1b. ;
: SDIO-DCOUNT. ." SDIO-DCOUNT (read-only) $" SDIO-DCOUNT @ hex. SDIO-DCOUNT 1b. ;
: SDIO-STA. ." SDIO-STA (read-only) $" SDIO-STA @ hex. SDIO-STA 1b. ;
: SDIO-ICR. ." SDIO-ICR (read-write) $" SDIO-ICR @ hex. SDIO-ICR 1b. ;
: SDIO-MASK. ." SDIO-MASK (read-write) $" SDIO-MASK @ hex. SDIO-MASK 1b. ;
: SDIO-FIFOCNT. ." SDIO-FIFOCNT (read-only) $" SDIO-FIFOCNT @ hex. SDIO-FIFOCNT 1b. ;
: SDIO-FIFO. ." SDIO-FIFO (read-write) $" SDIO-FIFO @ hex. SDIO-FIFO 1b. ;
: SDIO.
SDIO-POWER.
SDIO-CLKCR.
SDIO-ARG.
SDIO-CMD.
SDIO-RESPCMD.
SDIO-RESP1.
SDIO-RESP2.
SDIO-RESP3.
SDIO-RESP4.
SDIO-DTIMER.
SDIO-DLEN.
SDIO-DCTRL.
SDIO-DCOUNT.
SDIO-STA.
SDIO-ICR.
SDIO-MASK.
SDIO-FIFOCNT.
SDIO-FIFO.
;

$40013800 constant SYSCFG ( System configuration controller )
SYSCFG $0 + constant SYSCFG-MEMRM ( memory remap register )
SYSCFG $4 + constant SYSCFG-PMC ( peripheral mode configuration
  register )
SYSCFG $8 + constant SYSCFG-EXTICR1 ( external interrupt configuration register
  1 )
SYSCFG $C + constant SYSCFG-EXTICR2 ( external interrupt configuration register
  2 )
SYSCFG $10 + constant SYSCFG-EXTICR3 ( external interrupt configuration register
  3 )
SYSCFG $14 + constant SYSCFG-EXTICR4 ( external interrupt configuration register
  4 )
SYSCFG $20 + constant SYSCFG-CMPCR ( Compensation cell control
  register )
: SYSCFG-MEMRM. ." SYSCFG-MEMRM (read-write) $" SYSCFG-MEMRM @ hex. SYSCFG-MEMRM 1b. ;
: SYSCFG-PMC. ." SYSCFG-PMC (read-write) $" SYSCFG-PMC @ hex. SYSCFG-PMC 1b. ;
: SYSCFG-EXTICR1. ." SYSCFG-EXTICR1 (read-write) $" SYSCFG-EXTICR1 @ hex. SYSCFG-EXTICR1 1b. ;
: SYSCFG-EXTICR2. ." SYSCFG-EXTICR2 (read-write) $" SYSCFG-EXTICR2 @ hex. SYSCFG-EXTICR2 1b. ;
: SYSCFG-EXTICR3. ." SYSCFG-EXTICR3 (read-write) $" SYSCFG-EXTICR3 @ hex. SYSCFG-EXTICR3 1b. ;
: SYSCFG-EXTICR4. ." SYSCFG-EXTICR4 (read-write) $" SYSCFG-EXTICR4 @ hex. SYSCFG-EXTICR4 1b. ;
: SYSCFG-CMPCR. ." SYSCFG-CMPCR (read-only) $" SYSCFG-CMPCR @ hex. SYSCFG-CMPCR 1b. ;
: SYSCFG.
SYSCFG-MEMRM.
SYSCFG-PMC.
SYSCFG-EXTICR1.
SYSCFG-EXTICR2.
SYSCFG-EXTICR3.
SYSCFG-EXTICR4.
SYSCFG-CMPCR.
;

$40010000 constant TIM1 ( Advanced-timers )
TIM1 $0 + constant TIM1-CR1 ( control register 1 )
TIM1 $4 + constant TIM1-CR2 ( control register 2 )
TIM1 $8 + constant TIM1-SMCR ( slave mode control register )
TIM1 $C + constant TIM1-DIER ( DMA/Interrupt enable register )
TIM1 $10 + constant TIM1-SR ( status register )
TIM1 $14 + constant TIM1-EGR ( event generation register )
TIM1 $18 + constant TIM1-CCMR1_Output ( capture/compare mode register 1 output
  mode )
TIM1 $18 + constant TIM1-CCMR1_Input ( capture/compare mode register 1 input
  mode )
TIM1 $1C + constant TIM1-CCMR2_Output ( capture/compare mode register 2 output
  mode )
TIM1 $1C + constant TIM1-CCMR2_Input ( capture/compare mode register 2 input
  mode )
TIM1 $20 + constant TIM1-CCER ( capture/compare enable
  register )
TIM1 $24 + constant TIM1-CNT ( counter )
TIM1 $28 + constant TIM1-PSC ( prescaler )
TIM1 $2C + constant TIM1-ARR ( auto-reload register )
TIM1 $34 + constant TIM1-CCR1 ( capture/compare register 1 )
TIM1 $38 + constant TIM1-CCR2 ( capture/compare register 2 )
TIM1 $3C + constant TIM1-CCR3 ( capture/compare register 3 )
TIM1 $40 + constant TIM1-CCR4 ( capture/compare register 4 )
TIM1 $48 + constant TIM1-DCR ( DMA control register )
TIM1 $4C + constant TIM1-DMAR ( DMA address for full transfer )
TIM1 $30 + constant TIM1-RCR ( repetition counter register )
TIM1 $44 + constant TIM1-BDTR ( break and dead-time register )
: TIM1-CR1. ." TIM1-CR1 (read-write) $" TIM1-CR1 @ hex. TIM1-CR1 1b. ;
: TIM1-CR2. ." TIM1-CR2 (read-write) $" TIM1-CR2 @ hex. TIM1-CR2 1b. ;
: TIM1-SMCR. ." TIM1-SMCR (read-write) $" TIM1-SMCR @ hex. TIM1-SMCR 1b. ;
: TIM1-DIER. ." TIM1-DIER (read-write) $" TIM1-DIER @ hex. TIM1-DIER 1b. ;
: TIM1-SR. ." TIM1-SR (read-write) $" TIM1-SR @ hex. TIM1-SR 1b. ;
: TIM1-EGR. ." TIM1-EGR (write-only) $" TIM1-EGR @ hex. TIM1-EGR 1b. ;
: TIM1-CCMR1_Output. ." TIM1-CCMR1_Output (read-write) $" TIM1-CCMR1_Output @ hex. TIM1-CCMR1_Output 1b. ;
: TIM1-CCMR1_Input. ." TIM1-CCMR1_Input (read-write) $" TIM1-CCMR1_Input @ hex. TIM1-CCMR1_Input 1b. ;
: TIM1-CCMR2_Output. ." TIM1-CCMR2_Output (read-write) $" TIM1-CCMR2_Output @ hex. TIM1-CCMR2_Output 1b. ;
: TIM1-CCMR2_Input. ." TIM1-CCMR2_Input (read-write) $" TIM1-CCMR2_Input @ hex. TIM1-CCMR2_Input 1b. ;
: TIM1-CCER. ." TIM1-CCER (read-write) $" TIM1-CCER @ hex. TIM1-CCER 1b. ;
: TIM1-CNT. ." TIM1-CNT (read-write) $" TIM1-CNT @ hex. TIM1-CNT 1b. ;
: TIM1-PSC. ." TIM1-PSC (read-write) $" TIM1-PSC @ hex. TIM1-PSC 1b. ;
: TIM1-ARR. ." TIM1-ARR (read-write) $" TIM1-ARR @ hex. TIM1-ARR 1b. ;
: TIM1-CCR1. ." TIM1-CCR1 (read-write) $" TIM1-CCR1 @ hex. TIM1-CCR1 1b. ;
: TIM1-CCR2. ." TIM1-CCR2 (read-write) $" TIM1-CCR2 @ hex. TIM1-CCR2 1b. ;
: TIM1-CCR3. ." TIM1-CCR3 (read-write) $" TIM1-CCR3 @ hex. TIM1-CCR3 1b. ;
: TIM1-CCR4. ." TIM1-CCR4 (read-write) $" TIM1-CCR4 @ hex. TIM1-CCR4 1b. ;
: TIM1-DCR. ." TIM1-DCR (read-write) $" TIM1-DCR @ hex. TIM1-DCR 1b. ;
: TIM1-DMAR. ." TIM1-DMAR (read-write) $" TIM1-DMAR @ hex. TIM1-DMAR 1b. ;
: TIM1-RCR. ." TIM1-RCR (read-write) $" TIM1-RCR @ hex. TIM1-RCR 1b. ;
: TIM1-BDTR. ." TIM1-BDTR (read-write) $" TIM1-BDTR @ hex. TIM1-BDTR 1b. ;
: TIM1.
TIM1-CR1.
TIM1-CR2.
TIM1-SMCR.
TIM1-DIER.
TIM1-SR.
TIM1-EGR.
TIM1-CCMR1_Output.
TIM1-CCMR1_Input.
TIM1-CCMR2_Output.
TIM1-CCMR2_Input.
TIM1-CCER.
TIM1-CNT.
TIM1-PSC.
TIM1-ARR.
TIM1-CCR1.
TIM1-CCR2.
TIM1-CCR3.
TIM1-CCR4.
TIM1-DCR.
TIM1-DMAR.
TIM1-RCR.
TIM1-BDTR.
;

$40010400 constant TIM8 ( Advanced-timers )
TIM8 $0 + constant TIM8-CR1 ( control register 1 )
TIM8 $4 + constant TIM8-CR2 ( control register 2 )
TIM8 $8 + constant TIM8-SMCR ( slave mode control register )
TIM8 $C + constant TIM8-DIER ( DMA/Interrupt enable register )
TIM8 $10 + constant TIM8-SR ( status register )
TIM8 $14 + constant TIM8-EGR ( event generation register )
TIM8 $18 + constant TIM8-CCMR1_Output ( capture/compare mode register 1 output
  mode )
TIM8 $18 + constant TIM8-CCMR1_Input ( capture/compare mode register 1 input
  mode )
TIM8 $1C + constant TIM8-CCMR2_Output ( capture/compare mode register 2 output
  mode )
TIM8 $1C + constant TIM8-CCMR2_Input ( capture/compare mode register 2 input
  mode )
TIM8 $20 + constant TIM8-CCER ( capture/compare enable
  register )
TIM8 $24 + constant TIM8-CNT ( counter )
TIM8 $28 + constant TIM8-PSC ( prescaler )
TIM8 $2C + constant TIM8-ARR ( auto-reload register )
TIM8 $34 + constant TIM8-CCR1 ( capture/compare register 1 )
TIM8 $38 + constant TIM8-CCR2 ( capture/compare register 2 )
TIM8 $3C + constant TIM8-CCR3 ( capture/compare register 3 )
TIM8 $40 + constant TIM8-CCR4 ( capture/compare register 4 )
TIM8 $48 + constant TIM8-DCR ( DMA control register )
TIM8 $4C + constant TIM8-DMAR ( DMA address for full transfer )
TIM8 $30 + constant TIM8-RCR ( repetition counter register )
TIM8 $44 + constant TIM8-BDTR ( break and dead-time register )
: TIM8-CR1. ." TIM8-CR1 (read-write) $" TIM8-CR1 @ hex. TIM8-CR1 1b. ;
: TIM8-CR2. ." TIM8-CR2 (read-write) $" TIM8-CR2 @ hex. TIM8-CR2 1b. ;
: TIM8-SMCR. ." TIM8-SMCR (read-write) $" TIM8-SMCR @ hex. TIM8-SMCR 1b. ;
: TIM8-DIER. ." TIM8-DIER (read-write) $" TIM8-DIER @ hex. TIM8-DIER 1b. ;
: TIM8-SR. ." TIM8-SR (read-write) $" TIM8-SR @ hex. TIM8-SR 1b. ;
: TIM8-EGR. ." TIM8-EGR (write-only) $" TIM8-EGR @ hex. TIM8-EGR 1b. ;
: TIM8-CCMR1_Output. ." TIM8-CCMR1_Output (read-write) $" TIM8-CCMR1_Output @ hex. TIM8-CCMR1_Output 1b. ;
: TIM8-CCMR1_Input. ." TIM8-CCMR1_Input (read-write) $" TIM8-CCMR1_Input @ hex. TIM8-CCMR1_Input 1b. ;
: TIM8-CCMR2_Output. ." TIM8-CCMR2_Output (read-write) $" TIM8-CCMR2_Output @ hex. TIM8-CCMR2_Output 1b. ;
: TIM8-CCMR2_Input. ." TIM8-CCMR2_Input (read-write) $" TIM8-CCMR2_Input @ hex. TIM8-CCMR2_Input 1b. ;
: TIM8-CCER. ." TIM8-CCER (read-write) $" TIM8-CCER @ hex. TIM8-CCER 1b. ;
: TIM8-CNT. ." TIM8-CNT (read-write) $" TIM8-CNT @ hex. TIM8-CNT 1b. ;
: TIM8-PSC. ." TIM8-PSC (read-write) $" TIM8-PSC @ hex. TIM8-PSC 1b. ;
: TIM8-ARR. ." TIM8-ARR (read-write) $" TIM8-ARR @ hex. TIM8-ARR 1b. ;
: TIM8-CCR1. ." TIM8-CCR1 (read-write) $" TIM8-CCR1 @ hex. TIM8-CCR1 1b. ;
: TIM8-CCR2. ." TIM8-CCR2 (read-write) $" TIM8-CCR2 @ hex. TIM8-CCR2 1b. ;
: TIM8-CCR3. ." TIM8-CCR3 (read-write) $" TIM8-CCR3 @ hex. TIM8-CCR3 1b. ;
: TIM8-CCR4. ." TIM8-CCR4 (read-write) $" TIM8-CCR4 @ hex. TIM8-CCR4 1b. ;
: TIM8-DCR. ." TIM8-DCR (read-write) $" TIM8-DCR @ hex. TIM8-DCR 1b. ;
: TIM8-DMAR. ." TIM8-DMAR (read-write) $" TIM8-DMAR @ hex. TIM8-DMAR 1b. ;
: TIM8-RCR. ." TIM8-RCR (read-write) $" TIM8-RCR @ hex. TIM8-RCR 1b. ;
: TIM8-BDTR. ." TIM8-BDTR (read-write) $" TIM8-BDTR @ hex. TIM8-BDTR 1b. ;
: TIM8.
TIM8-CR1.
TIM8-CR2.
TIM8-SMCR.
TIM8-DIER.
TIM8-SR.
TIM8-EGR.
TIM8-CCMR1_Output.
TIM8-CCMR1_Input.
TIM8-CCMR2_Output.
TIM8-CCMR2_Input.
TIM8-CCER.
TIM8-CNT.
TIM8-PSC.
TIM8-ARR.
TIM8-CCR1.
TIM8-CCR2.
TIM8-CCR3.
TIM8-CCR4.
TIM8-DCR.
TIM8-DMAR.
TIM8-RCR.
TIM8-BDTR.
;

$40014400 constant TIM10 ( General-purpose-timers )
TIM10 $0 + constant TIM10-CR1 ( control register 1 )
TIM10 $C + constant TIM10-DIER ( DMA/Interrupt enable register )
TIM10 $10 + constant TIM10-SR ( status register )
TIM10 $14 + constant TIM10-EGR ( event generation register )
TIM10 $18 + constant TIM10-CCMR1_Output ( capture/compare mode register 1 output
  mode )
TIM10 $18 + constant TIM10-CCMR1_Input ( capture/compare mode register 1 input
  mode )
TIM10 $20 + constant TIM10-CCER ( capture/compare enable
  register )
TIM10 $24 + constant TIM10-CNT ( counter )
TIM10 $28 + constant TIM10-PSC ( prescaler )
TIM10 $2C + constant TIM10-ARR ( auto-reload register )
TIM10 $34 + constant TIM10-CCR1 ( capture/compare register 1 )
: TIM10-CR1. ." TIM10-CR1 (read-write) $" TIM10-CR1 @ hex. TIM10-CR1 1b. ;
: TIM10-DIER. ." TIM10-DIER (read-write) $" TIM10-DIER @ hex. TIM10-DIER 1b. ;
: TIM10-SR. ." TIM10-SR (read-write) $" TIM10-SR @ hex. TIM10-SR 1b. ;
: TIM10-EGR. ." TIM10-EGR (write-only) $" TIM10-EGR @ hex. TIM10-EGR 1b. ;
: TIM10-CCMR1_Output. ." TIM10-CCMR1_Output (read-write) $" TIM10-CCMR1_Output @ hex. TIM10-CCMR1_Output 1b. ;
: TIM10-CCMR1_Input. ." TIM10-CCMR1_Input (read-write) $" TIM10-CCMR1_Input @ hex. TIM10-CCMR1_Input 1b. ;
: TIM10-CCER. ." TIM10-CCER (read-write) $" TIM10-CCER @ hex. TIM10-CCER 1b. ;
: TIM10-CNT. ." TIM10-CNT (read-write) $" TIM10-CNT @ hex. TIM10-CNT 1b. ;
: TIM10-PSC. ." TIM10-PSC (read-write) $" TIM10-PSC @ hex. TIM10-PSC 1b. ;
: TIM10-ARR. ." TIM10-ARR (read-write) $" TIM10-ARR @ hex. TIM10-ARR 1b. ;
: TIM10-CCR1. ." TIM10-CCR1 (read-write) $" TIM10-CCR1 @ hex. TIM10-CCR1 1b. ;
: TIM10.
TIM10-CR1.
TIM10-DIER.
TIM10-SR.
TIM10-EGR.
TIM10-CCMR1_Output.
TIM10-CCMR1_Input.
TIM10-CCER.
TIM10-CNT.
TIM10-PSC.
TIM10-ARR.
TIM10-CCR1.
;

$40014800 constant TIM11 ( General-purpose-timers )
TIM11 $0 + constant TIM11-CR1 ( control register 1 )
TIM11 $C + constant TIM11-DIER ( DMA/Interrupt enable register )
TIM11 $10 + constant TIM11-SR ( status register )
TIM11 $14 + constant TIM11-EGR ( event generation register )
TIM11 $18 + constant TIM11-CCMR1_Output ( capture/compare mode register 1 output
  mode )
TIM11 $18 + constant TIM11-CCMR1_Input ( capture/compare mode register 1 input
  mode )
TIM11 $20 + constant TIM11-CCER ( capture/compare enable
  register )
TIM11 $24 + constant TIM11-CNT ( counter )
TIM11 $28 + constant TIM11-PSC ( prescaler )
TIM11 $2C + constant TIM11-ARR ( auto-reload register )
TIM11 $34 + constant TIM11-CCR1 ( capture/compare register 1 )
TIM11 $50 + constant TIM11-OR ( option register )
: TIM11-CR1. ." TIM11-CR1 (read-write) $" TIM11-CR1 @ hex. TIM11-CR1 1b. ;
: TIM11-DIER. ." TIM11-DIER (read-write) $" TIM11-DIER @ hex. TIM11-DIER 1b. ;
: TIM11-SR. ." TIM11-SR (read-write) $" TIM11-SR @ hex. TIM11-SR 1b. ;
: TIM11-EGR. ." TIM11-EGR (write-only) $" TIM11-EGR @ hex. TIM11-EGR 1b. ;
: TIM11-CCMR1_Output. ." TIM11-CCMR1_Output (read-write) $" TIM11-CCMR1_Output @ hex. TIM11-CCMR1_Output 1b. ;
: TIM11-CCMR1_Input. ." TIM11-CCMR1_Input (read-write) $" TIM11-CCMR1_Input @ hex. TIM11-CCMR1_Input 1b. ;
: TIM11-CCER. ." TIM11-CCER (read-write) $" TIM11-CCER @ hex. TIM11-CCER 1b. ;
: TIM11-CNT. ." TIM11-CNT (read-write) $" TIM11-CNT @ hex. TIM11-CNT 1b. ;
: TIM11-PSC. ." TIM11-PSC (read-write) $" TIM11-PSC @ hex. TIM11-PSC 1b. ;
: TIM11-ARR. ." TIM11-ARR (read-write) $" TIM11-ARR @ hex. TIM11-ARR 1b. ;
: TIM11-CCR1. ." TIM11-CCR1 (read-write) $" TIM11-CCR1 @ hex. TIM11-CCR1 1b. ;
: TIM11-OR. ." TIM11-OR (read-write) $" TIM11-OR @ hex. TIM11-OR 1b. ;
: TIM11.
TIM11-CR1.
TIM11-DIER.
TIM11-SR.
TIM11-EGR.
TIM11-CCMR1_Output.
TIM11-CCMR1_Input.
TIM11-CCER.
TIM11-CNT.
TIM11-PSC.
TIM11-ARR.
TIM11-CCR1.
TIM11-OR.
;

$40000000 constant TIM2 ( General purpose timers )
TIM2 $0 + constant TIM2-CR1 ( control register 1 )
TIM2 $4 + constant TIM2-CR2 ( control register 2 )
TIM2 $8 + constant TIM2-SMCR ( slave mode control register )
TIM2 $C + constant TIM2-DIER ( DMA/Interrupt enable register )
TIM2 $10 + constant TIM2-SR ( status register )
TIM2 $14 + constant TIM2-EGR ( event generation register )
TIM2 $18 + constant TIM2-CCMR1_Output ( capture/compare mode register 1 output
  mode )
TIM2 $18 + constant TIM2-CCMR1_Input ( capture/compare mode register 1 input
  mode )
TIM2 $1C + constant TIM2-CCMR2_Output ( capture/compare mode register 2 output
  mode )
TIM2 $1C + constant TIM2-CCMR2_Input ( capture/compare mode register 2 input
  mode )
TIM2 $20 + constant TIM2-CCER ( capture/compare enable
  register )
TIM2 $24 + constant TIM2-CNT ( counter )
TIM2 $28 + constant TIM2-PSC ( prescaler )
TIM2 $2C + constant TIM2-ARR ( auto-reload register )
TIM2 $34 + constant TIM2-CCR1 ( capture/compare register 1 )
TIM2 $38 + constant TIM2-CCR2 ( capture/compare register 2 )
TIM2 $3C + constant TIM2-CCR3 ( capture/compare register 3 )
TIM2 $40 + constant TIM2-CCR4 ( capture/compare register 4 )
TIM2 $48 + constant TIM2-DCR ( DMA control register )
TIM2 $4C + constant TIM2-DMAR ( DMA address for full transfer )
TIM2 $50 + constant TIM2-OR ( TIM5 option register )
: TIM2-CR1. ." TIM2-CR1 (read-write) $" TIM2-CR1 @ hex. TIM2-CR1 1b. ;
: TIM2-CR2. ." TIM2-CR2 (read-write) $" TIM2-CR2 @ hex. TIM2-CR2 1b. ;
: TIM2-SMCR. ." TIM2-SMCR (read-write) $" TIM2-SMCR @ hex. TIM2-SMCR 1b. ;
: TIM2-DIER. ." TIM2-DIER (read-write) $" TIM2-DIER @ hex. TIM2-DIER 1b. ;
: TIM2-SR. ." TIM2-SR (read-write) $" TIM2-SR @ hex. TIM2-SR 1b. ;
: TIM2-EGR. ." TIM2-EGR (write-only) $" TIM2-EGR @ hex. TIM2-EGR 1b. ;
: TIM2-CCMR1_Output. ." TIM2-CCMR1_Output (read-write) $" TIM2-CCMR1_Output @ hex. TIM2-CCMR1_Output 1b. ;
: TIM2-CCMR1_Input. ." TIM2-CCMR1_Input (read-write) $" TIM2-CCMR1_Input @ hex. TIM2-CCMR1_Input 1b. ;
: TIM2-CCMR2_Output. ." TIM2-CCMR2_Output (read-write) $" TIM2-CCMR2_Output @ hex. TIM2-CCMR2_Output 1b. ;
: TIM2-CCMR2_Input. ." TIM2-CCMR2_Input (read-write) $" TIM2-CCMR2_Input @ hex. TIM2-CCMR2_Input 1b. ;
: TIM2-CCER. ." TIM2-CCER (read-write) $" TIM2-CCER @ hex. TIM2-CCER 1b. ;
: TIM2-CNT. ." TIM2-CNT (read-write) $" TIM2-CNT @ hex. TIM2-CNT 1b. ;
: TIM2-PSC. ." TIM2-PSC (read-write) $" TIM2-PSC @ hex. TIM2-PSC 1b. ;
: TIM2-ARR. ." TIM2-ARR (read-write) $" TIM2-ARR @ hex. TIM2-ARR 1b. ;
: TIM2-CCR1. ." TIM2-CCR1 (read-write) $" TIM2-CCR1 @ hex. TIM2-CCR1 1b. ;
: TIM2-CCR2. ." TIM2-CCR2 (read-write) $" TIM2-CCR2 @ hex. TIM2-CCR2 1b. ;
: TIM2-CCR3. ." TIM2-CCR3 (read-write) $" TIM2-CCR3 @ hex. TIM2-CCR3 1b. ;
: TIM2-CCR4. ." TIM2-CCR4 (read-write) $" TIM2-CCR4 @ hex. TIM2-CCR4 1b. ;
: TIM2-DCR. ." TIM2-DCR (read-write) $" TIM2-DCR @ hex. TIM2-DCR 1b. ;
: TIM2-DMAR. ." TIM2-DMAR (read-write) $" TIM2-DMAR @ hex. TIM2-DMAR 1b. ;
: TIM2-OR. ." TIM2-OR (read-write) $" TIM2-OR @ hex. TIM2-OR 1b. ;
: TIM2.
TIM2-CR1.
TIM2-CR2.
TIM2-SMCR.
TIM2-DIER.
TIM2-SR.
TIM2-EGR.
TIM2-CCMR1_Output.
TIM2-CCMR1_Input.
TIM2-CCMR2_Output.
TIM2-CCMR2_Input.
TIM2-CCER.
TIM2-CNT.
TIM2-PSC.
TIM2-ARR.
TIM2-CCR1.
TIM2-CCR2.
TIM2-CCR3.
TIM2-CCR4.
TIM2-DCR.
TIM2-DMAR.
TIM2-OR.
;

$40000400 constant TIM3 ( General purpose timers )
TIM3 $0 + constant TIM3-CR1 ( control register 1 )
TIM3 $4 + constant TIM3-CR2 ( control register 2 )
TIM3 $8 + constant TIM3-SMCR ( slave mode control register )
TIM3 $C + constant TIM3-DIER ( DMA/Interrupt enable register )
TIM3 $10 + constant TIM3-SR ( status register )
TIM3 $14 + constant TIM3-EGR ( event generation register )
TIM3 $18 + constant TIM3-CCMR1_Output ( capture/compare mode register 1 output
  mode )
TIM3 $18 + constant TIM3-CCMR1_Input ( capture/compare mode register 1 input
  mode )
TIM3 $1C + constant TIM3-CCMR2_Output ( capture/compare mode register 2 output
  mode )
TIM3 $1C + constant TIM3-CCMR2_Input ( capture/compare mode register 2 input
  mode )
TIM3 $20 + constant TIM3-CCER ( capture/compare enable
  register )
TIM3 $24 + constant TIM3-CNT ( counter )
TIM3 $28 + constant TIM3-PSC ( prescaler )
TIM3 $2C + constant TIM3-ARR ( auto-reload register )
TIM3 $34 + constant TIM3-CCR1 ( capture/compare register 1 )
TIM3 $38 + constant TIM3-CCR2 ( capture/compare register 2 )
TIM3 $3C + constant TIM3-CCR3 ( capture/compare register 3 )
TIM3 $40 + constant TIM3-CCR4 ( capture/compare register 4 )
TIM3 $48 + constant TIM3-DCR ( DMA control register )
TIM3 $4C + constant TIM3-DMAR ( DMA address for full transfer )
: TIM3-CR1. ." TIM3-CR1 (read-write) $" TIM3-CR1 @ hex. TIM3-CR1 1b. ;
: TIM3-CR2. ." TIM3-CR2 (read-write) $" TIM3-CR2 @ hex. TIM3-CR2 1b. ;
: TIM3-SMCR. ." TIM3-SMCR (read-write) $" TIM3-SMCR @ hex. TIM3-SMCR 1b. ;
: TIM3-DIER. ." TIM3-DIER (read-write) $" TIM3-DIER @ hex. TIM3-DIER 1b. ;
: TIM3-SR. ." TIM3-SR (read-write) $" TIM3-SR @ hex. TIM3-SR 1b. ;
: TIM3-EGR. ." TIM3-EGR (write-only) $" TIM3-EGR @ hex. TIM3-EGR 1b. ;
: TIM3-CCMR1_Output. ." TIM3-CCMR1_Output (read-write) $" TIM3-CCMR1_Output @ hex. TIM3-CCMR1_Output 1b. ;
: TIM3-CCMR1_Input. ." TIM3-CCMR1_Input (read-write) $" TIM3-CCMR1_Input @ hex. TIM3-CCMR1_Input 1b. ;
: TIM3-CCMR2_Output. ." TIM3-CCMR2_Output (read-write) $" TIM3-CCMR2_Output @ hex. TIM3-CCMR2_Output 1b. ;
: TIM3-CCMR2_Input. ." TIM3-CCMR2_Input (read-write) $" TIM3-CCMR2_Input @ hex. TIM3-CCMR2_Input 1b. ;
: TIM3-CCER. ." TIM3-CCER (read-write) $" TIM3-CCER @ hex. TIM3-CCER 1b. ;
: TIM3-CNT. ." TIM3-CNT (read-write) $" TIM3-CNT @ hex. TIM3-CNT 1b. ;
: TIM3-PSC. ." TIM3-PSC (read-write) $" TIM3-PSC @ hex. TIM3-PSC 1b. ;
: TIM3-ARR. ." TIM3-ARR (read-write) $" TIM3-ARR @ hex. TIM3-ARR 1b. ;
: TIM3-CCR1. ." TIM3-CCR1 (read-write) $" TIM3-CCR1 @ hex. TIM3-CCR1 1b. ;
: TIM3-CCR2. ." TIM3-CCR2 (read-write) $" TIM3-CCR2 @ hex. TIM3-CCR2 1b. ;
: TIM3-CCR3. ." TIM3-CCR3 (read-write) $" TIM3-CCR3 @ hex. TIM3-CCR3 1b. ;
: TIM3-CCR4. ." TIM3-CCR4 (read-write) $" TIM3-CCR4 @ hex. TIM3-CCR4 1b. ;
: TIM3-DCR. ." TIM3-DCR (read-write) $" TIM3-DCR @ hex. TIM3-DCR 1b. ;
: TIM3-DMAR. ." TIM3-DMAR (read-write) $" TIM3-DMAR @ hex. TIM3-DMAR 1b. ;
: TIM3.
TIM3-CR1.
TIM3-CR2.
TIM3-SMCR.
TIM3-DIER.
TIM3-SR.
TIM3-EGR.
TIM3-CCMR1_Output.
TIM3-CCMR1_Input.
TIM3-CCMR2_Output.
TIM3-CCMR2_Input.
TIM3-CCER.
TIM3-CNT.
TIM3-PSC.
TIM3-ARR.
TIM3-CCR1.
TIM3-CCR2.
TIM3-CCR3.
TIM3-CCR4.
TIM3-DCR.
TIM3-DMAR.
;

$40000800 constant TIM4 ( General purpose timers )
TIM4 $0 + constant TIM4-CR1 ( control register 1 )
TIM4 $4 + constant TIM4-CR2 ( control register 2 )
TIM4 $8 + constant TIM4-SMCR ( slave mode control register )
TIM4 $C + constant TIM4-DIER ( DMA/Interrupt enable register )
TIM4 $10 + constant TIM4-SR ( status register )
TIM4 $14 + constant TIM4-EGR ( event generation register )
TIM4 $18 + constant TIM4-CCMR1_Output ( capture/compare mode register 1 output
  mode )
TIM4 $18 + constant TIM4-CCMR1_Input ( capture/compare mode register 1 input
  mode )
TIM4 $1C + constant TIM4-CCMR2_Output ( capture/compare mode register 2 output
  mode )
TIM4 $1C + constant TIM4-CCMR2_Input ( capture/compare mode register 2 input
  mode )
TIM4 $20 + constant TIM4-CCER ( capture/compare enable
  register )
TIM4 $24 + constant TIM4-CNT ( counter )
TIM4 $28 + constant TIM4-PSC ( prescaler )
TIM4 $2C + constant TIM4-ARR ( auto-reload register )
TIM4 $34 + constant TIM4-CCR1 ( capture/compare register 1 )
TIM4 $38 + constant TIM4-CCR2 ( capture/compare register 2 )
TIM4 $3C + constant TIM4-CCR3 ( capture/compare register 3 )
TIM4 $40 + constant TIM4-CCR4 ( capture/compare register 4 )
TIM4 $48 + constant TIM4-DCR ( DMA control register )
TIM4 $4C + constant TIM4-DMAR ( DMA address for full transfer )
: TIM4-CR1. ." TIM4-CR1 (read-write) $" TIM4-CR1 @ hex. TIM4-CR1 1b. ;
: TIM4-CR2. ." TIM4-CR2 (read-write) $" TIM4-CR2 @ hex. TIM4-CR2 1b. ;
: TIM4-SMCR. ." TIM4-SMCR (read-write) $" TIM4-SMCR @ hex. TIM4-SMCR 1b. ;
: TIM4-DIER. ." TIM4-DIER (read-write) $" TIM4-DIER @ hex. TIM4-DIER 1b. ;
: TIM4-SR. ." TIM4-SR (read-write) $" TIM4-SR @ hex. TIM4-SR 1b. ;
: TIM4-EGR. ." TIM4-EGR (write-only) $" TIM4-EGR @ hex. TIM4-EGR 1b. ;
: TIM4-CCMR1_Output. ." TIM4-CCMR1_Output (read-write) $" TIM4-CCMR1_Output @ hex. TIM4-CCMR1_Output 1b. ;
: TIM4-CCMR1_Input. ." TIM4-CCMR1_Input (read-write) $" TIM4-CCMR1_Input @ hex. TIM4-CCMR1_Input 1b. ;
: TIM4-CCMR2_Output. ." TIM4-CCMR2_Output (read-write) $" TIM4-CCMR2_Output @ hex. TIM4-CCMR2_Output 1b. ;
: TIM4-CCMR2_Input. ." TIM4-CCMR2_Input (read-write) $" TIM4-CCMR2_Input @ hex. TIM4-CCMR2_Input 1b. ;
: TIM4-CCER. ." TIM4-CCER (read-write) $" TIM4-CCER @ hex. TIM4-CCER 1b. ;
: TIM4-CNT. ." TIM4-CNT (read-write) $" TIM4-CNT @ hex. TIM4-CNT 1b. ;
: TIM4-PSC. ." TIM4-PSC (read-write) $" TIM4-PSC @ hex. TIM4-PSC 1b. ;
: TIM4-ARR. ." TIM4-ARR (read-write) $" TIM4-ARR @ hex. TIM4-ARR 1b. ;
: TIM4-CCR1. ." TIM4-CCR1 (read-write) $" TIM4-CCR1 @ hex. TIM4-CCR1 1b. ;
: TIM4-CCR2. ." TIM4-CCR2 (read-write) $" TIM4-CCR2 @ hex. TIM4-CCR2 1b. ;
: TIM4-CCR3. ." TIM4-CCR3 (read-write) $" TIM4-CCR3 @ hex. TIM4-CCR3 1b. ;
: TIM4-CCR4. ." TIM4-CCR4 (read-write) $" TIM4-CCR4 @ hex. TIM4-CCR4 1b. ;
: TIM4-DCR. ." TIM4-DCR (read-write) $" TIM4-DCR @ hex. TIM4-DCR 1b. ;
: TIM4-DMAR. ." TIM4-DMAR (read-write) $" TIM4-DMAR @ hex. TIM4-DMAR 1b. ;
: TIM4.
TIM4-CR1.
TIM4-CR2.
TIM4-SMCR.
TIM4-DIER.
TIM4-SR.
TIM4-EGR.
TIM4-CCMR1_Output.
TIM4-CCMR1_Input.
TIM4-CCMR2_Output.
TIM4-CCMR2_Input.
TIM4-CCER.
TIM4-CNT.
TIM4-PSC.
TIM4-ARR.
TIM4-CCR1.
TIM4-CCR2.
TIM4-CCR3.
TIM4-CCR4.
TIM4-DCR.
TIM4-DMAR.
;

$40000C00 constant TIM5 ( General-purpose-timers )
TIM5 $0 + constant TIM5-CR1 ( control register 1 )
TIM5 $4 + constant TIM5-CR2 ( control register 2 )
TIM5 $8 + constant TIM5-SMCR ( slave mode control register )
TIM5 $C + constant TIM5-DIER ( DMA/Interrupt enable register )
TIM5 $10 + constant TIM5-SR ( status register )
TIM5 $14 + constant TIM5-EGR ( event generation register )
TIM5 $18 + constant TIM5-CCMR1_Output ( capture/compare mode register 1 output
  mode )
TIM5 $18 + constant TIM5-CCMR1_Input ( capture/compare mode register 1 input
  mode )
TIM5 $1C + constant TIM5-CCMR2_Output ( capture/compare mode register 2 output
  mode )
TIM5 $1C + constant TIM5-CCMR2_Input ( capture/compare mode register 2 input
  mode )
TIM5 $20 + constant TIM5-CCER ( capture/compare enable
  register )
TIM5 $24 + constant TIM5-CNT ( counter )
TIM5 $28 + constant TIM5-PSC ( prescaler )
TIM5 $2C + constant TIM5-ARR ( auto-reload register )
TIM5 $34 + constant TIM5-CCR1 ( capture/compare register 1 )
TIM5 $38 + constant TIM5-CCR2 ( capture/compare register 2 )
TIM5 $3C + constant TIM5-CCR3 ( capture/compare register 3 )
TIM5 $40 + constant TIM5-CCR4 ( capture/compare register 4 )
TIM5 $48 + constant TIM5-DCR ( DMA control register )
TIM5 $4C + constant TIM5-DMAR ( DMA address for full transfer )
TIM5 $50 + constant TIM5-OR ( TIM5 option register )
: TIM5-CR1. ." TIM5-CR1 (read-write) $" TIM5-CR1 @ hex. TIM5-CR1 1b. ;
: TIM5-CR2. ." TIM5-CR2 (read-write) $" TIM5-CR2 @ hex. TIM5-CR2 1b. ;
: TIM5-SMCR. ." TIM5-SMCR (read-write) $" TIM5-SMCR @ hex. TIM5-SMCR 1b. ;
: TIM5-DIER. ." TIM5-DIER (read-write) $" TIM5-DIER @ hex. TIM5-DIER 1b. ;
: TIM5-SR. ." TIM5-SR (read-write) $" TIM5-SR @ hex. TIM5-SR 1b. ;
: TIM5-EGR. ." TIM5-EGR (write-only) $" TIM5-EGR @ hex. TIM5-EGR 1b. ;
: TIM5-CCMR1_Output. ." TIM5-CCMR1_Output (read-write) $" TIM5-CCMR1_Output @ hex. TIM5-CCMR1_Output 1b. ;
: TIM5-CCMR1_Input. ." TIM5-CCMR1_Input (read-write) $" TIM5-CCMR1_Input @ hex. TIM5-CCMR1_Input 1b. ;
: TIM5-CCMR2_Output. ." TIM5-CCMR2_Output (read-write) $" TIM5-CCMR2_Output @ hex. TIM5-CCMR2_Output 1b. ;
: TIM5-CCMR2_Input. ." TIM5-CCMR2_Input (read-write) $" TIM5-CCMR2_Input @ hex. TIM5-CCMR2_Input 1b. ;
: TIM5-CCER. ." TIM5-CCER (read-write) $" TIM5-CCER @ hex. TIM5-CCER 1b. ;
: TIM5-CNT. ." TIM5-CNT (read-write) $" TIM5-CNT @ hex. TIM5-CNT 1b. ;
: TIM5-PSC. ." TIM5-PSC (read-write) $" TIM5-PSC @ hex. TIM5-PSC 1b. ;
: TIM5-ARR. ." TIM5-ARR (read-write) $" TIM5-ARR @ hex. TIM5-ARR 1b. ;
: TIM5-CCR1. ." TIM5-CCR1 (read-write) $" TIM5-CCR1 @ hex. TIM5-CCR1 1b. ;
: TIM5-CCR2. ." TIM5-CCR2 (read-write) $" TIM5-CCR2 @ hex. TIM5-CCR2 1b. ;
: TIM5-CCR3. ." TIM5-CCR3 (read-write) $" TIM5-CCR3 @ hex. TIM5-CCR3 1b. ;
: TIM5-CCR4. ." TIM5-CCR4 (read-write) $" TIM5-CCR4 @ hex. TIM5-CCR4 1b. ;
: TIM5-DCR. ." TIM5-DCR (read-write) $" TIM5-DCR @ hex. TIM5-DCR 1b. ;
: TIM5-DMAR. ." TIM5-DMAR (read-write) $" TIM5-DMAR @ hex. TIM5-DMAR 1b. ;
: TIM5-OR. ." TIM5-OR (read-write) $" TIM5-OR @ hex. TIM5-OR 1b. ;
: TIM5.
TIM5-CR1.
TIM5-CR2.
TIM5-SMCR.
TIM5-DIER.
TIM5-SR.
TIM5-EGR.
TIM5-CCMR1_Output.
TIM5-CCMR1_Input.
TIM5-CCMR2_Output.
TIM5-CCMR2_Input.
TIM5-CCER.
TIM5-CNT.
TIM5-PSC.
TIM5-ARR.
TIM5-CCR1.
TIM5-CCR2.
TIM5-CCR3.
TIM5-CCR4.
TIM5-DCR.
TIM5-DMAR.
TIM5-OR.
;

$40014000 constant TIM9 ( General purpose timers )
TIM9 $0 + constant TIM9-CR1 ( control register 1 )
TIM9 $4 + constant TIM9-CR2 ( control register 2 )
TIM9 $8 + constant TIM9-SMCR ( slave mode control register )
TIM9 $C + constant TIM9-DIER ( DMA/Interrupt enable register )
TIM9 $10 + constant TIM9-SR ( status register )
TIM9 $14 + constant TIM9-EGR ( event generation register )
TIM9 $18 + constant TIM9-CCMR1_Output ( capture/compare mode register 1 output
  mode )
TIM9 $18 + constant TIM9-CCMR1_Input ( capture/compare mode register 1 input
  mode )
TIM9 $20 + constant TIM9-CCER ( capture/compare enable
  register )
TIM9 $24 + constant TIM9-CNT ( counter )
TIM9 $28 + constant TIM9-PSC ( prescaler )
TIM9 $2C + constant TIM9-ARR ( auto-reload register )
TIM9 $34 + constant TIM9-CCR1 ( capture/compare register 1 )
TIM9 $38 + constant TIM9-CCR2 ( capture/compare register 2 )
: TIM9-CR1. ." TIM9-CR1 (read-write) $" TIM9-CR1 @ hex. TIM9-CR1 1b. ;
: TIM9-CR2. ." TIM9-CR2 (read-write) $" TIM9-CR2 @ hex. TIM9-CR2 1b. ;
: TIM9-SMCR. ." TIM9-SMCR (read-write) $" TIM9-SMCR @ hex. TIM9-SMCR 1b. ;
: TIM9-DIER. ." TIM9-DIER (read-write) $" TIM9-DIER @ hex. TIM9-DIER 1b. ;
: TIM9-SR. ." TIM9-SR (read-write) $" TIM9-SR @ hex. TIM9-SR 1b. ;
: TIM9-EGR. ." TIM9-EGR (write-only) $" TIM9-EGR @ hex. TIM9-EGR 1b. ;
: TIM9-CCMR1_Output. ." TIM9-CCMR1_Output (read-write) $" TIM9-CCMR1_Output @ hex. TIM9-CCMR1_Output 1b. ;
: TIM9-CCMR1_Input. ." TIM9-CCMR1_Input (read-write) $" TIM9-CCMR1_Input @ hex. TIM9-CCMR1_Input 1b. ;
: TIM9-CCER. ." TIM9-CCER (read-write) $" TIM9-CCER @ hex. TIM9-CCER 1b. ;
: TIM9-CNT. ." TIM9-CNT (read-write) $" TIM9-CNT @ hex. TIM9-CNT 1b. ;
: TIM9-PSC. ." TIM9-PSC (read-write) $" TIM9-PSC @ hex. TIM9-PSC 1b. ;
: TIM9-ARR. ." TIM9-ARR (read-write) $" TIM9-ARR @ hex. TIM9-ARR 1b. ;
: TIM9-CCR1. ." TIM9-CCR1 (read-write) $" TIM9-CCR1 @ hex. TIM9-CCR1 1b. ;
: TIM9-CCR2. ." TIM9-CCR2 (read-write) $" TIM9-CCR2 @ hex. TIM9-CCR2 1b. ;
: TIM9.
TIM9-CR1.
TIM9-CR2.
TIM9-SMCR.
TIM9-DIER.
TIM9-SR.
TIM9-EGR.
TIM9-CCMR1_Output.
TIM9-CCMR1_Input.
TIM9-CCER.
TIM9-CNT.
TIM9-PSC.
TIM9-ARR.
TIM9-CCR1.
TIM9-CCR2.
;

$40011000 constant USART1 ( Universal synchronous asynchronous receiver
  transmitter )
USART1 $0 + constant USART1-SR ( Status register )
USART1 $4 + constant USART1-DR ( Data register )
USART1 $8 + constant USART1-BRR ( Baud rate register )
USART1 $C + constant USART1-CR1 ( Control register 1 )
USART1 $10 + constant USART1-CR2 ( Control register 2 )
USART1 $14 + constant USART1-CR3 ( Control register 3 )
USART1 $18 + constant USART1-GTPR ( Guard time and prescaler
  register )
: USART1-SR. ." USART1-SR () $" USART1-SR @ hex. USART1-SR 1b. ;
: USART1-DR. ." USART1-DR (read-write) $" USART1-DR @ hex. USART1-DR 1b. ;
: USART1-BRR. ." USART1-BRR (read-write) $" USART1-BRR @ hex. USART1-BRR 1b. ;
: USART1-CR1. ." USART1-CR1 (read-write) $" USART1-CR1 @ hex. USART1-CR1 1b. ;
: USART1-CR2. ." USART1-CR2 (read-write) $" USART1-CR2 @ hex. USART1-CR2 1b. ;
: USART1-CR3. ." USART1-CR3 (read-write) $" USART1-CR3 @ hex. USART1-CR3 1b. ;
: USART1-GTPR. ." USART1-GTPR (read-write) $" USART1-GTPR @ hex. USART1-GTPR 1b. ;
: USART1.
USART1-SR.
USART1-DR.
USART1-BRR.
USART1-CR1.
USART1-CR2.
USART1-CR3.
USART1-GTPR.
;

$40004400 constant USART2 ( Universal synchronous asynchronous receiver
  transmitter )
USART2 $0 + constant USART2-SR ( Status register )
USART2 $4 + constant USART2-DR ( Data register )
USART2 $8 + constant USART2-BRR ( Baud rate register )
USART2 $C + constant USART2-CR1 ( Control register 1 )
USART2 $10 + constant USART2-CR2 ( Control register 2 )
USART2 $14 + constant USART2-CR3 ( Control register 3 )
USART2 $18 + constant USART2-GTPR ( Guard time and prescaler
  register )
: USART2-SR. ." USART2-SR () $" USART2-SR @ hex. USART2-SR 1b. ;
: USART2-DR. ." USART2-DR (read-write) $" USART2-DR @ hex. USART2-DR 1b. ;
: USART2-BRR. ." USART2-BRR (read-write) $" USART2-BRR @ hex. USART2-BRR 1b. ;
: USART2-CR1. ." USART2-CR1 (read-write) $" USART2-CR1 @ hex. USART2-CR1 1b. ;
: USART2-CR2. ." USART2-CR2 (read-write) $" USART2-CR2 @ hex. USART2-CR2 1b. ;
: USART2-CR3. ." USART2-CR3 (read-write) $" USART2-CR3 @ hex. USART2-CR3 1b. ;
: USART2-GTPR. ." USART2-GTPR (read-write) $" USART2-GTPR @ hex. USART2-GTPR 1b. ;
: USART2.
USART2-SR.
USART2-DR.
USART2-BRR.
USART2-CR1.
USART2-CR2.
USART2-CR3.
USART2-GTPR.
;

$40011400 constant USART6 ( Universal synchronous asynchronous receiver
  transmitter )
USART6 $0 + constant USART6-SR ( Status register )
USART6 $4 + constant USART6-DR ( Data register )
USART6 $8 + constant USART6-BRR ( Baud rate register )
USART6 $C + constant USART6-CR1 ( Control register 1 )
USART6 $10 + constant USART6-CR2 ( Control register 2 )
USART6 $14 + constant USART6-CR3 ( Control register 3 )
USART6 $18 + constant USART6-GTPR ( Guard time and prescaler
  register )
: USART6-SR. ." USART6-SR () $" USART6-SR @ hex. USART6-SR 1b. ;
: USART6-DR. ." USART6-DR (read-write) $" USART6-DR @ hex. USART6-DR 1b. ;
: USART6-BRR. ." USART6-BRR (read-write) $" USART6-BRR @ hex. USART6-BRR 1b. ;
: USART6-CR1. ." USART6-CR1 (read-write) $" USART6-CR1 @ hex. USART6-CR1 1b. ;
: USART6-CR2. ." USART6-CR2 (read-write) $" USART6-CR2 @ hex. USART6-CR2 1b. ;
: USART6-CR3. ." USART6-CR3 (read-write) $" USART6-CR3 @ hex. USART6-CR3 1b. ;
: USART6-GTPR. ." USART6-GTPR (read-write) $" USART6-GTPR @ hex. USART6-GTPR 1b. ;
: USART6.
USART6-SR.
USART6-DR.
USART6-BRR.
USART6-CR1.
USART6-CR2.
USART6-CR3.
USART6-GTPR.
;

$40002C00 constant WWDG ( Window watchdog )
WWDG $0 + constant WWDG-CR ( Control register )
WWDG $4 + constant WWDG-CFR ( Configuration register )
WWDG $8 + constant WWDG-SR ( Status register )
: WWDG-CR. ." WWDG-CR (read-write) $" WWDG-CR @ hex. WWDG-CR 1b. ;
: WWDG-CFR. ." WWDG-CFR (read-write) $" WWDG-CFR @ hex. WWDG-CFR 1b. ;
: WWDG-SR. ." WWDG-SR (read-write) $" WWDG-SR @ hex. WWDG-SR 1b. ;
: WWDG.
WWDG-CR.
WWDG-CFR.
WWDG-SR.
;

$40026400 constant DMA2 ( DMA controller )
DMA2 $0 + constant DMA2-LISR ( low interrupt status register )
DMA2 $4 + constant DMA2-HISR ( high interrupt status register )
DMA2 $8 + constant DMA2-LIFCR ( low interrupt flag clear
  register )
DMA2 $C + constant DMA2-HIFCR ( high interrupt flag clear
  register )
DMA2 $10 + constant DMA2-S0CR ( stream x configuration
  register )
DMA2 $14 + constant DMA2-S0NDTR ( stream x number of data
  register )
DMA2 $18 + constant DMA2-S0PAR ( stream x peripheral address
  register )
DMA2 $1C + constant DMA2-S0M0AR ( stream x memory 0 address
  register )
DMA2 $20 + constant DMA2-S0M1AR ( stream x memory 1 address
  register )
DMA2 $24 + constant DMA2-S0FCR ( stream x FIFO control register )
DMA2 $28 + constant DMA2-S1CR ( stream x configuration
  register )
DMA2 $2C + constant DMA2-S1NDTR ( stream x number of data
  register )
DMA2 $30 + constant DMA2-S1PAR ( stream x peripheral address
  register )
DMA2 $34 + constant DMA2-S1M0AR ( stream x memory 0 address
  register )
DMA2 $38 + constant DMA2-S1M1AR ( stream x memory 1 address
  register )
DMA2 $3C + constant DMA2-S1FCR ( stream x FIFO control register )
DMA2 $40 + constant DMA2-S2CR ( stream x configuration
  register )
DMA2 $44 + constant DMA2-S2NDTR ( stream x number of data
  register )
DMA2 $48 + constant DMA2-S2PAR ( stream x peripheral address
  register )
DMA2 $4C + constant DMA2-S2M0AR ( stream x memory 0 address
  register )
DMA2 $50 + constant DMA2-S2M1AR ( stream x memory 1 address
  register )
DMA2 $54 + constant DMA2-S2FCR ( stream x FIFO control register )
DMA2 $58 + constant DMA2-S3CR ( stream x configuration
  register )
DMA2 $5C + constant DMA2-S3NDTR ( stream x number of data
  register )
DMA2 $60 + constant DMA2-S3PAR ( stream x peripheral address
  register )
DMA2 $64 + constant DMA2-S3M0AR ( stream x memory 0 address
  register )
DMA2 $68 + constant DMA2-S3M1AR ( stream x memory 1 address
  register )
DMA2 $6C + constant DMA2-S3FCR ( stream x FIFO control register )
DMA2 $70 + constant DMA2-S4CR ( stream x configuration
  register )
DMA2 $74 + constant DMA2-S4NDTR ( stream x number of data
  register )
DMA2 $78 + constant DMA2-S4PAR ( stream x peripheral address
  register )
DMA2 $7C + constant DMA2-S4M0AR ( stream x memory 0 address
  register )
DMA2 $80 + constant DMA2-S4M1AR ( stream x memory 1 address
  register )
DMA2 $84 + constant DMA2-S4FCR ( stream x FIFO control register )
DMA2 $88 + constant DMA2-S5CR ( stream x configuration
  register )
DMA2 $8C + constant DMA2-S5NDTR ( stream x number of data
  register )
DMA2 $90 + constant DMA2-S5PAR ( stream x peripheral address
  register )
DMA2 $94 + constant DMA2-S5M0AR ( stream x memory 0 address
  register )
DMA2 $98 + constant DMA2-S5M1AR ( stream x memory 1 address
  register )
DMA2 $9C + constant DMA2-S5FCR ( stream x FIFO control register )
DMA2 $A0 + constant DMA2-S6CR ( stream x configuration
  register )
DMA2 $A4 + constant DMA2-S6NDTR ( stream x number of data
  register )
DMA2 $A8 + constant DMA2-S6PAR ( stream x peripheral address
  register )
DMA2 $AC + constant DMA2-S6M0AR ( stream x memory 0 address
  register )
DMA2 $B0 + constant DMA2-S6M1AR ( stream x memory 1 address
  register )
DMA2 $B4 + constant DMA2-S6FCR ( stream x FIFO control register )
DMA2 $B8 + constant DMA2-S7CR ( stream x configuration
  register )
DMA2 $BC + constant DMA2-S7NDTR ( stream x number of data
  register )
DMA2 $C0 + constant DMA2-S7PAR ( stream x peripheral address
  register )
DMA2 $C4 + constant DMA2-S7M0AR ( stream x memory 0 address
  register )
DMA2 $C8 + constant DMA2-S7M1AR ( stream x memory 1 address
  register )
DMA2 $CC + constant DMA2-S7FCR ( stream x FIFO control register )
: DMA2-LISR. ." DMA2-LISR (read-only) $" DMA2-LISR @ hex. DMA2-LISR 1b. ;
: DMA2-HISR. ." DMA2-HISR (read-only) $" DMA2-HISR @ hex. DMA2-HISR 1b. ;
: DMA2-LIFCR. ." DMA2-LIFCR (write-only) $" DMA2-LIFCR @ hex. DMA2-LIFCR 1b. ;
: DMA2-HIFCR. ." DMA2-HIFCR (write-only) $" DMA2-HIFCR @ hex. DMA2-HIFCR 1b. ;
: DMA2-S0CR. ." DMA2-S0CR (read-write) $" DMA2-S0CR @ hex. DMA2-S0CR 1b. ;
: DMA2-S0NDTR. ." DMA2-S0NDTR (read-write) $" DMA2-S0NDTR @ hex. DMA2-S0NDTR 1b. ;
: DMA2-S0PAR. ." DMA2-S0PAR (read-write) $" DMA2-S0PAR @ hex. DMA2-S0PAR 1b. ;
: DMA2-S0M0AR. ." DMA2-S0M0AR (read-write) $" DMA2-S0M0AR @ hex. DMA2-S0M0AR 1b. ;
: DMA2-S0M1AR. ." DMA2-S0M1AR (read-write) $" DMA2-S0M1AR @ hex. DMA2-S0M1AR 1b. ;
: DMA2-S0FCR. ." DMA2-S0FCR () $" DMA2-S0FCR @ hex. DMA2-S0FCR 1b. ;
: DMA2-S1CR. ." DMA2-S1CR (read-write) $" DMA2-S1CR @ hex. DMA2-S1CR 1b. ;
: DMA2-S1NDTR. ." DMA2-S1NDTR (read-write) $" DMA2-S1NDTR @ hex. DMA2-S1NDTR 1b. ;
: DMA2-S1PAR. ." DMA2-S1PAR (read-write) $" DMA2-S1PAR @ hex. DMA2-S1PAR 1b. ;
: DMA2-S1M0AR. ." DMA2-S1M0AR (read-write) $" DMA2-S1M0AR @ hex. DMA2-S1M0AR 1b. ;
: DMA2-S1M1AR. ." DMA2-S1M1AR (read-write) $" DMA2-S1M1AR @ hex. DMA2-S1M1AR 1b. ;
: DMA2-S1FCR. ." DMA2-S1FCR () $" DMA2-S1FCR @ hex. DMA2-S1FCR 1b. ;
: DMA2-S2CR. ." DMA2-S2CR (read-write) $" DMA2-S2CR @ hex. DMA2-S2CR 1b. ;
: DMA2-S2NDTR. ." DMA2-S2NDTR (read-write) $" DMA2-S2NDTR @ hex. DMA2-S2NDTR 1b. ;
: DMA2-S2PAR. ." DMA2-S2PAR (read-write) $" DMA2-S2PAR @ hex. DMA2-S2PAR 1b. ;
: DMA2-S2M0AR. ." DMA2-S2M0AR (read-write) $" DMA2-S2M0AR @ hex. DMA2-S2M0AR 1b. ;
: DMA2-S2M1AR. ." DMA2-S2M1AR (read-write) $" DMA2-S2M1AR @ hex. DMA2-S2M1AR 1b. ;
: DMA2-S2FCR. ." DMA2-S2FCR () $" DMA2-S2FCR @ hex. DMA2-S2FCR 1b. ;
: DMA2-S3CR. ." DMA2-S3CR (read-write) $" DMA2-S3CR @ hex. DMA2-S3CR 1b. ;
: DMA2-S3NDTR. ." DMA2-S3NDTR (read-write) $" DMA2-S3NDTR @ hex. DMA2-S3NDTR 1b. ;
: DMA2-S3PAR. ." DMA2-S3PAR (read-write) $" DMA2-S3PAR @ hex. DMA2-S3PAR 1b. ;
: DMA2-S3M0AR. ." DMA2-S3M0AR (read-write) $" DMA2-S3M0AR @ hex. DMA2-S3M0AR 1b. ;
: DMA2-S3M1AR. ." DMA2-S3M1AR (read-write) $" DMA2-S3M1AR @ hex. DMA2-S3M1AR 1b. ;
: DMA2-S3FCR. ." DMA2-S3FCR () $" DMA2-S3FCR @ hex. DMA2-S3FCR 1b. ;
: DMA2-S4CR. ." DMA2-S4CR (read-write) $" DMA2-S4CR @ hex. DMA2-S4CR 1b. ;
: DMA2-S4NDTR. ." DMA2-S4NDTR (read-write) $" DMA2-S4NDTR @ hex. DMA2-S4NDTR 1b. ;
: DMA2-S4PAR. ." DMA2-S4PAR (read-write) $" DMA2-S4PAR @ hex. DMA2-S4PAR 1b. ;
: DMA2-S4M0AR. ." DMA2-S4M0AR (read-write) $" DMA2-S4M0AR @ hex. DMA2-S4M0AR 1b. ;
: DMA2-S4M1AR. ." DMA2-S4M1AR (read-write) $" DMA2-S4M1AR @ hex. DMA2-S4M1AR 1b. ;
: DMA2-S4FCR. ." DMA2-S4FCR () $" DMA2-S4FCR @ hex. DMA2-S4FCR 1b. ;
: DMA2-S5CR. ." DMA2-S5CR (read-write) $" DMA2-S5CR @ hex. DMA2-S5CR 1b. ;
: DMA2-S5NDTR. ." DMA2-S5NDTR (read-write) $" DMA2-S5NDTR @ hex. DMA2-S5NDTR 1b. ;
: DMA2-S5PAR. ." DMA2-S5PAR (read-write) $" DMA2-S5PAR @ hex. DMA2-S5PAR 1b. ;
: DMA2-S5M0AR. ." DMA2-S5M0AR (read-write) $" DMA2-S5M0AR @ hex. DMA2-S5M0AR 1b. ;
: DMA2-S5M1AR. ." DMA2-S5M1AR (read-write) $" DMA2-S5M1AR @ hex. DMA2-S5M1AR 1b. ;
: DMA2-S5FCR. ." DMA2-S5FCR () $" DMA2-S5FCR @ hex. DMA2-S5FCR 1b. ;
: DMA2-S6CR. ." DMA2-S6CR (read-write) $" DMA2-S6CR @ hex. DMA2-S6CR 1b. ;
: DMA2-S6NDTR. ." DMA2-S6NDTR (read-write) $" DMA2-S6NDTR @ hex. DMA2-S6NDTR 1b. ;
: DMA2-S6PAR. ." DMA2-S6PAR (read-write) $" DMA2-S6PAR @ hex. DMA2-S6PAR 1b. ;
: DMA2-S6M0AR. ." DMA2-S6M0AR (read-write) $" DMA2-S6M0AR @ hex. DMA2-S6M0AR 1b. ;
: DMA2-S6M1AR. ." DMA2-S6M1AR (read-write) $" DMA2-S6M1AR @ hex. DMA2-S6M1AR 1b. ;
: DMA2-S6FCR. ." DMA2-S6FCR () $" DMA2-S6FCR @ hex. DMA2-S6FCR 1b. ;
: DMA2-S7CR. ." DMA2-S7CR (read-write) $" DMA2-S7CR @ hex. DMA2-S7CR 1b. ;
: DMA2-S7NDTR. ." DMA2-S7NDTR (read-write) $" DMA2-S7NDTR @ hex. DMA2-S7NDTR 1b. ;
: DMA2-S7PAR. ." DMA2-S7PAR (read-write) $" DMA2-S7PAR @ hex. DMA2-S7PAR 1b. ;
: DMA2-S7M0AR. ." DMA2-S7M0AR (read-write) $" DMA2-S7M0AR @ hex. DMA2-S7M0AR 1b. ;
: DMA2-S7M1AR. ." DMA2-S7M1AR (read-write) $" DMA2-S7M1AR @ hex. DMA2-S7M1AR 1b. ;
: DMA2-S7FCR. ." DMA2-S7FCR () $" DMA2-S7FCR @ hex. DMA2-S7FCR 1b. ;
: DMA2.
DMA2-LISR.
DMA2-HISR.
DMA2-LIFCR.
DMA2-HIFCR.
DMA2-S0CR.
DMA2-S0NDTR.
DMA2-S0PAR.
DMA2-S0M0AR.
DMA2-S0M1AR.
DMA2-S0FCR.
DMA2-S1CR.
DMA2-S1NDTR.
DMA2-S1PAR.
DMA2-S1M0AR.
DMA2-S1M1AR.
DMA2-S1FCR.
DMA2-S2CR.
DMA2-S2NDTR.
DMA2-S2PAR.
DMA2-S2M0AR.
DMA2-S2M1AR.
DMA2-S2FCR.
DMA2-S3CR.
DMA2-S3NDTR.
DMA2-S3PAR.
DMA2-S3M0AR.
DMA2-S3M1AR.
DMA2-S3FCR.
DMA2-S4CR.
DMA2-S4NDTR.
DMA2-S4PAR.
DMA2-S4M0AR.
DMA2-S4M1AR.
DMA2-S4FCR.
DMA2-S5CR.
DMA2-S5NDTR.
DMA2-S5PAR.
DMA2-S5M0AR.
DMA2-S5M1AR.
DMA2-S5FCR.
DMA2-S6CR.
DMA2-S6NDTR.
DMA2-S6PAR.
DMA2-S6M0AR.
DMA2-S6M1AR.
DMA2-S6FCR.
DMA2-S7CR.
DMA2-S7NDTR.
DMA2-S7PAR.
DMA2-S7M0AR.
DMA2-S7M1AR.
DMA2-S7FCR.
;

$40026000 constant DMA1 ( DMA controller )
DMA1 $0 + constant DMA1-LISR ( low interrupt status register )
DMA1 $4 + constant DMA1-HISR ( high interrupt status register )
DMA1 $8 + constant DMA1-LIFCR ( low interrupt flag clear
  register )
DMA1 $C + constant DMA1-HIFCR ( high interrupt flag clear
  register )
DMA1 $10 + constant DMA1-S0CR ( stream x configuration
  register )
DMA1 $14 + constant DMA1-S0NDTR ( stream x number of data
  register )
DMA1 $18 + constant DMA1-S0PAR ( stream x peripheral address
  register )
DMA1 $1C + constant DMA1-S0M0AR ( stream x memory 0 address
  register )
DMA1 $20 + constant DMA1-S0M1AR ( stream x memory 1 address
  register )
DMA1 $24 + constant DMA1-S0FCR ( stream x FIFO control register )
DMA1 $28 + constant DMA1-S1CR ( stream x configuration
  register )
DMA1 $2C + constant DMA1-S1NDTR ( stream x number of data
  register )
DMA1 $30 + constant DMA1-S1PAR ( stream x peripheral address
  register )
DMA1 $34 + constant DMA1-S1M0AR ( stream x memory 0 address
  register )
DMA1 $38 + constant DMA1-S1M1AR ( stream x memory 1 address
  register )
DMA1 $3C + constant DMA1-S1FCR ( stream x FIFO control register )
DMA1 $40 + constant DMA1-S2CR ( stream x configuration
  register )
DMA1 $44 + constant DMA1-S2NDTR ( stream x number of data
  register )
DMA1 $48 + constant DMA1-S2PAR ( stream x peripheral address
  register )
DMA1 $4C + constant DMA1-S2M0AR ( stream x memory 0 address
  register )
DMA1 $50 + constant DMA1-S2M1AR ( stream x memory 1 address
  register )
DMA1 $54 + constant DMA1-S2FCR ( stream x FIFO control register )
DMA1 $58 + constant DMA1-S3CR ( stream x configuration
  register )
DMA1 $5C + constant DMA1-S3NDTR ( stream x number of data
  register )
DMA1 $60 + constant DMA1-S3PAR ( stream x peripheral address
  register )
DMA1 $64 + constant DMA1-S3M0AR ( stream x memory 0 address
  register )
DMA1 $68 + constant DMA1-S3M1AR ( stream x memory 1 address
  register )
DMA1 $6C + constant DMA1-S3FCR ( stream x FIFO control register )
DMA1 $70 + constant DMA1-S4CR ( stream x configuration
  register )
DMA1 $74 + constant DMA1-S4NDTR ( stream x number of data
  register )
DMA1 $78 + constant DMA1-S4PAR ( stream x peripheral address
  register )
DMA1 $7C + constant DMA1-S4M0AR ( stream x memory 0 address
  register )
DMA1 $80 + constant DMA1-S4M1AR ( stream x memory 1 address
  register )
DMA1 $84 + constant DMA1-S4FCR ( stream x FIFO control register )
DMA1 $88 + constant DMA1-S5CR ( stream x configuration
  register )
DMA1 $8C + constant DMA1-S5NDTR ( stream x number of data
  register )
DMA1 $90 + constant DMA1-S5PAR ( stream x peripheral address
  register )
DMA1 $94 + constant DMA1-S5M0AR ( stream x memory 0 address
  register )
DMA1 $98 + constant DMA1-S5M1AR ( stream x memory 1 address
  register )
DMA1 $9C + constant DMA1-S5FCR ( stream x FIFO control register )
DMA1 $A0 + constant DMA1-S6CR ( stream x configuration
  register )
DMA1 $A4 + constant DMA1-S6NDTR ( stream x number of data
  register )
DMA1 $A8 + constant DMA1-S6PAR ( stream x peripheral address
  register )
DMA1 $AC + constant DMA1-S6M0AR ( stream x memory 0 address
  register )
DMA1 $B0 + constant DMA1-S6M1AR ( stream x memory 1 address
  register )
DMA1 $B4 + constant DMA1-S6FCR ( stream x FIFO control register )
DMA1 $B8 + constant DMA1-S7CR ( stream x configuration
  register )
DMA1 $BC + constant DMA1-S7NDTR ( stream x number of data
  register )
DMA1 $C0 + constant DMA1-S7PAR ( stream x peripheral address
  register )
DMA1 $C4 + constant DMA1-S7M0AR ( stream x memory 0 address
  register )
DMA1 $C8 + constant DMA1-S7M1AR ( stream x memory 1 address
  register )
DMA1 $CC + constant DMA1-S7FCR ( stream x FIFO control register )
: DMA1-LISR. ." DMA1-LISR (read-only) $" DMA1-LISR @ hex. DMA1-LISR 1b. ;
: DMA1-HISR. ." DMA1-HISR (read-only) $" DMA1-HISR @ hex. DMA1-HISR 1b. ;
: DMA1-LIFCR. ." DMA1-LIFCR (write-only) $" DMA1-LIFCR @ hex. DMA1-LIFCR 1b. ;
: DMA1-HIFCR. ." DMA1-HIFCR (write-only) $" DMA1-HIFCR @ hex. DMA1-HIFCR 1b. ;
: DMA1-S0CR. ." DMA1-S0CR (read-write) $" DMA1-S0CR @ hex. DMA1-S0CR 1b. ;
: DMA1-S0NDTR. ." DMA1-S0NDTR (read-write) $" DMA1-S0NDTR @ hex. DMA1-S0NDTR 1b. ;
: DMA1-S0PAR. ." DMA1-S0PAR (read-write) $" DMA1-S0PAR @ hex. DMA1-S0PAR 1b. ;
: DMA1-S0M0AR. ." DMA1-S0M0AR (read-write) $" DMA1-S0M0AR @ hex. DMA1-S0M0AR 1b. ;
: DMA1-S0M1AR. ." DMA1-S0M1AR (read-write) $" DMA1-S0M1AR @ hex. DMA1-S0M1AR 1b. ;
: DMA1-S0FCR. ." DMA1-S0FCR () $" DMA1-S0FCR @ hex. DMA1-S0FCR 1b. ;
: DMA1-S1CR. ." DMA1-S1CR (read-write) $" DMA1-S1CR @ hex. DMA1-S1CR 1b. ;
: DMA1-S1NDTR. ." DMA1-S1NDTR (read-write) $" DMA1-S1NDTR @ hex. DMA1-S1NDTR 1b. ;
: DMA1-S1PAR. ." DMA1-S1PAR (read-write) $" DMA1-S1PAR @ hex. DMA1-S1PAR 1b. ;
: DMA1-S1M0AR. ." DMA1-S1M0AR (read-write) $" DMA1-S1M0AR @ hex. DMA1-S1M0AR 1b. ;
: DMA1-S1M1AR. ." DMA1-S1M1AR (read-write) $" DMA1-S1M1AR @ hex. DMA1-S1M1AR 1b. ;
: DMA1-S1FCR. ." DMA1-S1FCR () $" DMA1-S1FCR @ hex. DMA1-S1FCR 1b. ;
: DMA1-S2CR. ." DMA1-S2CR (read-write) $" DMA1-S2CR @ hex. DMA1-S2CR 1b. ;
: DMA1-S2NDTR. ." DMA1-S2NDTR (read-write) $" DMA1-S2NDTR @ hex. DMA1-S2NDTR 1b. ;
: DMA1-S2PAR. ." DMA1-S2PAR (read-write) $" DMA1-S2PAR @ hex. DMA1-S2PAR 1b. ;
: DMA1-S2M0AR. ." DMA1-S2M0AR (read-write) $" DMA1-S2M0AR @ hex. DMA1-S2M0AR 1b. ;
: DMA1-S2M1AR. ." DMA1-S2M1AR (read-write) $" DMA1-S2M1AR @ hex. DMA1-S2M1AR 1b. ;
: DMA1-S2FCR. ." DMA1-S2FCR () $" DMA1-S2FCR @ hex. DMA1-S2FCR 1b. ;
: DMA1-S3CR. ." DMA1-S3CR (read-write) $" DMA1-S3CR @ hex. DMA1-S3CR 1b. ;
: DMA1-S3NDTR. ." DMA1-S3NDTR (read-write) $" DMA1-S3NDTR @ hex. DMA1-S3NDTR 1b. ;
: DMA1-S3PAR. ." DMA1-S3PAR (read-write) $" DMA1-S3PAR @ hex. DMA1-S3PAR 1b. ;
: DMA1-S3M0AR. ." DMA1-S3M0AR (read-write) $" DMA1-S3M0AR @ hex. DMA1-S3M0AR 1b. ;
: DMA1-S3M1AR. ." DMA1-S3M1AR (read-write) $" DMA1-S3M1AR @ hex. DMA1-S3M1AR 1b. ;
: DMA1-S3FCR. ." DMA1-S3FCR () $" DMA1-S3FCR @ hex. DMA1-S3FCR 1b. ;
: DMA1-S4CR. ." DMA1-S4CR (read-write) $" DMA1-S4CR @ hex. DMA1-S4CR 1b. ;
: DMA1-S4NDTR. ." DMA1-S4NDTR (read-write) $" DMA1-S4NDTR @ hex. DMA1-S4NDTR 1b. ;
: DMA1-S4PAR. ." DMA1-S4PAR (read-write) $" DMA1-S4PAR @ hex. DMA1-S4PAR 1b. ;
: DMA1-S4M0AR. ." DMA1-S4M0AR (read-write) $" DMA1-S4M0AR @ hex. DMA1-S4M0AR 1b. ;
: DMA1-S4M1AR. ." DMA1-S4M1AR (read-write) $" DMA1-S4M1AR @ hex. DMA1-S4M1AR 1b. ;
: DMA1-S4FCR. ." DMA1-S4FCR () $" DMA1-S4FCR @ hex. DMA1-S4FCR 1b. ;
: DMA1-S5CR. ." DMA1-S5CR (read-write) $" DMA1-S5CR @ hex. DMA1-S5CR 1b. ;
: DMA1-S5NDTR. ." DMA1-S5NDTR (read-write) $" DMA1-S5NDTR @ hex. DMA1-S5NDTR 1b. ;
: DMA1-S5PAR. ." DMA1-S5PAR (read-write) $" DMA1-S5PAR @ hex. DMA1-S5PAR 1b. ;
: DMA1-S5M0AR. ." DMA1-S5M0AR (read-write) $" DMA1-S5M0AR @ hex. DMA1-S5M0AR 1b. ;
: DMA1-S5M1AR. ." DMA1-S5M1AR (read-write) $" DMA1-S5M1AR @ hex. DMA1-S5M1AR 1b. ;
: DMA1-S5FCR. ." DMA1-S5FCR () $" DMA1-S5FCR @ hex. DMA1-S5FCR 1b. ;
: DMA1-S6CR. ." DMA1-S6CR (read-write) $" DMA1-S6CR @ hex. DMA1-S6CR 1b. ;
: DMA1-S6NDTR. ." DMA1-S6NDTR (read-write) $" DMA1-S6NDTR @ hex. DMA1-S6NDTR 1b. ;
: DMA1-S6PAR. ." DMA1-S6PAR (read-write) $" DMA1-S6PAR @ hex. DMA1-S6PAR 1b. ;
: DMA1-S6M0AR. ." DMA1-S6M0AR (read-write) $" DMA1-S6M0AR @ hex. DMA1-S6M0AR 1b. ;
: DMA1-S6M1AR. ." DMA1-S6M1AR (read-write) $" DMA1-S6M1AR @ hex. DMA1-S6M1AR 1b. ;
: DMA1-S6FCR. ." DMA1-S6FCR () $" DMA1-S6FCR @ hex. DMA1-S6FCR 1b. ;
: DMA1-S7CR. ." DMA1-S7CR (read-write) $" DMA1-S7CR @ hex. DMA1-S7CR 1b. ;
: DMA1-S7NDTR. ." DMA1-S7NDTR (read-write) $" DMA1-S7NDTR @ hex. DMA1-S7NDTR 1b. ;
: DMA1-S7PAR. ." DMA1-S7PAR (read-write) $" DMA1-S7PAR @ hex. DMA1-S7PAR 1b. ;
: DMA1-S7M0AR. ." DMA1-S7M0AR (read-write) $" DMA1-S7M0AR @ hex. DMA1-S7M0AR 1b. ;
: DMA1-S7M1AR. ." DMA1-S7M1AR (read-write) $" DMA1-S7M1AR @ hex. DMA1-S7M1AR 1b. ;
: DMA1-S7FCR. ." DMA1-S7FCR () $" DMA1-S7FCR @ hex. DMA1-S7FCR 1b. ;
: DMA1.
DMA1-LISR.
DMA1-HISR.
DMA1-LIFCR.
DMA1-HIFCR.
DMA1-S0CR.
DMA1-S0NDTR.
DMA1-S0PAR.
DMA1-S0M0AR.
DMA1-S0M1AR.
DMA1-S0FCR.
DMA1-S1CR.
DMA1-S1NDTR.
DMA1-S1PAR.
DMA1-S1M0AR.
DMA1-S1M1AR.
DMA1-S1FCR.
DMA1-S2CR.
DMA1-S2NDTR.
DMA1-S2PAR.
DMA1-S2M0AR.
DMA1-S2M1AR.
DMA1-S2FCR.
DMA1-S3CR.
DMA1-S3NDTR.
DMA1-S3PAR.
DMA1-S3M0AR.
DMA1-S3M1AR.
DMA1-S3FCR.
DMA1-S4CR.
DMA1-S4NDTR.
DMA1-S4PAR.
DMA1-S4M0AR.
DMA1-S4M1AR.
DMA1-S4FCR.
DMA1-S5CR.
DMA1-S5NDTR.
DMA1-S5PAR.
DMA1-S5M0AR.
DMA1-S5M1AR.
DMA1-S5FCR.
DMA1-S6CR.
DMA1-S6NDTR.
DMA1-S6PAR.
DMA1-S6M0AR.
DMA1-S6M1AR.
DMA1-S6FCR.
DMA1-S7CR.
DMA1-S7NDTR.
DMA1-S7PAR.
DMA1-S7M0AR.
DMA1-S7M1AR.
DMA1-S7FCR.
;

$40021C00 constant GPIOH ( General-purpose I/Os )
GPIOH $0 + constant GPIOH-MODER ( GPIO port mode register )
GPIOH $4 + constant GPIOH-OTYPER ( GPIO port output type register )
GPIOH $8 + constant GPIOH-OSPEEDR ( GPIO port output speed
  register )
GPIOH $C + constant GPIOH-PUPDR ( GPIO port pull-up/pull-down
  register )
GPIOH $10 + constant GPIOH-IDR ( GPIO port input data register )
GPIOH $14 + constant GPIOH-ODR ( GPIO port output data register )
GPIOH $18 + constant GPIOH-BSRR ( GPIO port bit set/reset
  register )
GPIOH $1C + constant GPIOH-LCKR ( GPIO port configuration lock
  register )
GPIOH $20 + constant GPIOH-AFRL ( GPIO alternate function low
  register )
GPIOH $24 + constant GPIOH-AFRH ( GPIO alternate function high
  register )
: GPIOH-MODER. ." GPIOH-MODER (read-write) $" GPIOH-MODER @ hex. GPIOH-MODER 1b. ;
: GPIOH-OTYPER. ." GPIOH-OTYPER (read-write) $" GPIOH-OTYPER @ hex. GPIOH-OTYPER 1b. ;
: GPIOH-OSPEEDR. ." GPIOH-OSPEEDR (read-write) $" GPIOH-OSPEEDR @ hex. GPIOH-OSPEEDR 1b. ;
: GPIOH-PUPDR. ." GPIOH-PUPDR (read-write) $" GPIOH-PUPDR @ hex. GPIOH-PUPDR 1b. ;
: GPIOH-IDR. ." GPIOH-IDR (read-only) $" GPIOH-IDR @ hex. GPIOH-IDR 1b. ;
: GPIOH-ODR. ." GPIOH-ODR (read-write) $" GPIOH-ODR @ hex. GPIOH-ODR 1b. ;
: GPIOH-BSRR. ." GPIOH-BSRR (write-only) $" GPIOH-BSRR @ hex. GPIOH-BSRR 1b. ;
: GPIOH-LCKR. ." GPIOH-LCKR (read-write) $" GPIOH-LCKR @ hex. GPIOH-LCKR 1b. ;
: GPIOH-AFRL. ." GPIOH-AFRL (read-write) $" GPIOH-AFRL @ hex. GPIOH-AFRL 1b. ;
: GPIOH-AFRH. ." GPIOH-AFRH (read-write) $" GPIOH-AFRH @ hex. GPIOH-AFRH 1b. ;
: GPIOH.
GPIOH-MODER.
GPIOH-OTYPER.
GPIOH-OSPEEDR.
GPIOH-PUPDR.
GPIOH-IDR.
GPIOH-ODR.
GPIOH-BSRR.
GPIOH-LCKR.
GPIOH-AFRL.
GPIOH-AFRH.
;

$40021000 constant GPIOE ( General-purpose I/Os )
GPIOE $0 + constant GPIOE-MODER ( GPIO port mode register )
GPIOE $4 + constant GPIOE-OTYPER ( GPIO port output type register )
GPIOE $8 + constant GPIOE-OSPEEDR ( GPIO port output speed
  register )
GPIOE $C + constant GPIOE-PUPDR ( GPIO port pull-up/pull-down
  register )
GPIOE $10 + constant GPIOE-IDR ( GPIO port input data register )
GPIOE $14 + constant GPIOE-ODR ( GPIO port output data register )
GPIOE $18 + constant GPIOE-BSRR ( GPIO port bit set/reset
  register )
GPIOE $1C + constant GPIOE-LCKR ( GPIO port configuration lock
  register )
GPIOE $20 + constant GPIOE-AFRL ( GPIO alternate function low
  register )
GPIOE $24 + constant GPIOE-AFRH ( GPIO alternate function high
  register )
: GPIOE-MODER. ." GPIOE-MODER (read-write) $" GPIOE-MODER @ hex. GPIOE-MODER 1b. ;
: GPIOE-OTYPER. ." GPIOE-OTYPER (read-write) $" GPIOE-OTYPER @ hex. GPIOE-OTYPER 1b. ;
: GPIOE-OSPEEDR. ." GPIOE-OSPEEDR (read-write) $" GPIOE-OSPEEDR @ hex. GPIOE-OSPEEDR 1b. ;
: GPIOE-PUPDR. ." GPIOE-PUPDR (read-write) $" GPIOE-PUPDR @ hex. GPIOE-PUPDR 1b. ;
: GPIOE-IDR. ." GPIOE-IDR (read-only) $" GPIOE-IDR @ hex. GPIOE-IDR 1b. ;
: GPIOE-ODR. ." GPIOE-ODR (read-write) $" GPIOE-ODR @ hex. GPIOE-ODR 1b. ;
: GPIOE-BSRR. ." GPIOE-BSRR (write-only) $" GPIOE-BSRR @ hex. GPIOE-BSRR 1b. ;
: GPIOE-LCKR. ." GPIOE-LCKR (read-write) $" GPIOE-LCKR @ hex. GPIOE-LCKR 1b. ;
: GPIOE-AFRL. ." GPIOE-AFRL (read-write) $" GPIOE-AFRL @ hex. GPIOE-AFRL 1b. ;
: GPIOE-AFRH. ." GPIOE-AFRH (read-write) $" GPIOE-AFRH @ hex. GPIOE-AFRH 1b. ;
: GPIOE.
GPIOE-MODER.
GPIOE-OTYPER.
GPIOE-OSPEEDR.
GPIOE-PUPDR.
GPIOE-IDR.
GPIOE-ODR.
GPIOE-BSRR.
GPIOE-LCKR.
GPIOE-AFRL.
GPIOE-AFRH.
;

$40020C00 constant GPIOD ( General-purpose I/Os )
GPIOD $0 + constant GPIOD-MODER ( GPIO port mode register )
GPIOD $4 + constant GPIOD-OTYPER ( GPIO port output type register )
GPIOD $8 + constant GPIOD-OSPEEDR ( GPIO port output speed
  register )
GPIOD $C + constant GPIOD-PUPDR ( GPIO port pull-up/pull-down
  register )
GPIOD $10 + constant GPIOD-IDR ( GPIO port input data register )
GPIOD $14 + constant GPIOD-ODR ( GPIO port output data register )
GPIOD $18 + constant GPIOD-BSRR ( GPIO port bit set/reset
  register )
GPIOD $1C + constant GPIOD-LCKR ( GPIO port configuration lock
  register )
GPIOD $20 + constant GPIOD-AFRL ( GPIO alternate function low
  register )
GPIOD $24 + constant GPIOD-AFRH ( GPIO alternate function high
  register )
: GPIOD-MODER. ." GPIOD-MODER (read-write) $" GPIOD-MODER @ hex. GPIOD-MODER 1b. ;
: GPIOD-OTYPER. ." GPIOD-OTYPER (read-write) $" GPIOD-OTYPER @ hex. GPIOD-OTYPER 1b. ;
: GPIOD-OSPEEDR. ." GPIOD-OSPEEDR (read-write) $" GPIOD-OSPEEDR @ hex. GPIOD-OSPEEDR 1b. ;
: GPIOD-PUPDR. ." GPIOD-PUPDR (read-write) $" GPIOD-PUPDR @ hex. GPIOD-PUPDR 1b. ;
: GPIOD-IDR. ." GPIOD-IDR (read-only) $" GPIOD-IDR @ hex. GPIOD-IDR 1b. ;
: GPIOD-ODR. ." GPIOD-ODR (read-write) $" GPIOD-ODR @ hex. GPIOD-ODR 1b. ;
: GPIOD-BSRR. ." GPIOD-BSRR (write-only) $" GPIOD-BSRR @ hex. GPIOD-BSRR 1b. ;
: GPIOD-LCKR. ." GPIOD-LCKR (read-write) $" GPIOD-LCKR @ hex. GPIOD-LCKR 1b. ;
: GPIOD-AFRL. ." GPIOD-AFRL (read-write) $" GPIOD-AFRL @ hex. GPIOD-AFRL 1b. ;
: GPIOD-AFRH. ." GPIOD-AFRH (read-write) $" GPIOD-AFRH @ hex. GPIOD-AFRH 1b. ;
: GPIOD.
GPIOD-MODER.
GPIOD-OTYPER.
GPIOD-OSPEEDR.
GPIOD-PUPDR.
GPIOD-IDR.
GPIOD-ODR.
GPIOD-BSRR.
GPIOD-LCKR.
GPIOD-AFRL.
GPIOD-AFRH.
;

$40020800 constant GPIOC ( General-purpose I/Os )
GPIOC $0 + constant GPIOC-MODER ( GPIO port mode register )
GPIOC $4 + constant GPIOC-OTYPER ( GPIO port output type register )
GPIOC $8 + constant GPIOC-OSPEEDR ( GPIO port output speed
  register )
GPIOC $C + constant GPIOC-PUPDR ( GPIO port pull-up/pull-down
  register )
GPIOC $10 + constant GPIOC-IDR ( GPIO port input data register )
GPIOC $14 + constant GPIOC-ODR ( GPIO port output data register )
GPIOC $18 + constant GPIOC-BSRR ( GPIO port bit set/reset
  register )
GPIOC $1C + constant GPIOC-LCKR ( GPIO port configuration lock
  register )
GPIOC $20 + constant GPIOC-AFRL ( GPIO alternate function low
  register )
GPIOC $24 + constant GPIOC-AFRH ( GPIO alternate function high
  register )
: GPIOC-MODER. ." GPIOC-MODER (read-write) $" GPIOC-MODER @ hex. GPIOC-MODER 1b. ;
: GPIOC-OTYPER. ." GPIOC-OTYPER (read-write) $" GPIOC-OTYPER @ hex. GPIOC-OTYPER 1b. ;
: GPIOC-OSPEEDR. ." GPIOC-OSPEEDR (read-write) $" GPIOC-OSPEEDR @ hex. GPIOC-OSPEEDR 1b. ;
: GPIOC-PUPDR. ." GPIOC-PUPDR (read-write) $" GPIOC-PUPDR @ hex. GPIOC-PUPDR 1b. ;
: GPIOC-IDR. ." GPIOC-IDR (read-only) $" GPIOC-IDR @ hex. GPIOC-IDR 1b. ;
: GPIOC-ODR. ." GPIOC-ODR (read-write) $" GPIOC-ODR @ hex. GPIOC-ODR 1b. ;
: GPIOC-BSRR. ." GPIOC-BSRR (write-only) $" GPIOC-BSRR @ hex. GPIOC-BSRR 1b. ;
: GPIOC-LCKR. ." GPIOC-LCKR (read-write) $" GPIOC-LCKR @ hex. GPIOC-LCKR 1b. ;
: GPIOC-AFRL. ." GPIOC-AFRL (read-write) $" GPIOC-AFRL @ hex. GPIOC-AFRL 1b. ;
: GPIOC-AFRH. ." GPIOC-AFRH (read-write) $" GPIOC-AFRH @ hex. GPIOC-AFRH 1b. ;
: GPIOC.
GPIOC-MODER.
GPIOC-OTYPER.
GPIOC-OSPEEDR.
GPIOC-PUPDR.
GPIOC-IDR.
GPIOC-ODR.
GPIOC-BSRR.
GPIOC-LCKR.
GPIOC-AFRL.
GPIOC-AFRH.
;

$40020400 constant GPIOB ( General-purpose I/Os )
GPIOB $0 + constant GPIOB-MODER ( GPIO port mode register )
GPIOB $4 + constant GPIOB-OTYPER ( GPIO port output type register )
GPIOB $8 + constant GPIOB-OSPEEDR ( GPIO port output speed
  register )
GPIOB $C + constant GPIOB-PUPDR ( GPIO port pull-up/pull-down
  register )
GPIOB $10 + constant GPIOB-IDR ( GPIO port input data register )
GPIOB $14 + constant GPIOB-ODR ( GPIO port output data register )
GPIOB $18 + constant GPIOB-BSRR ( GPIO port bit set/reset
  register )
GPIOB $1C + constant GPIOB-LCKR ( GPIO port configuration lock
  register )
GPIOB $20 + constant GPIOB-AFRL ( GPIO alternate function low
  register )
GPIOB $24 + constant GPIOB-AFRH ( GPIO alternate function high
  register )
: GPIOB-MODER. ." GPIOB-MODER (read-write) $" GPIOB-MODER @ hex. GPIOB-MODER 1b. ;
: GPIOB-OTYPER. ." GPIOB-OTYPER (read-write) $" GPIOB-OTYPER @ hex. GPIOB-OTYPER 1b. ;
: GPIOB-OSPEEDR. ." GPIOB-OSPEEDR (read-write) $" GPIOB-OSPEEDR @ hex. GPIOB-OSPEEDR 1b. ;
: GPIOB-PUPDR. ." GPIOB-PUPDR (read-write) $" GPIOB-PUPDR @ hex. GPIOB-PUPDR 1b. ;
: GPIOB-IDR. ." GPIOB-IDR (read-only) $" GPIOB-IDR @ hex. GPIOB-IDR 1b. ;
: GPIOB-ODR. ." GPIOB-ODR (read-write) $" GPIOB-ODR @ hex. GPIOB-ODR 1b. ;
: GPIOB-BSRR. ." GPIOB-BSRR (write-only) $" GPIOB-BSRR @ hex. GPIOB-BSRR 1b. ;
: GPIOB-LCKR. ." GPIOB-LCKR (read-write) $" GPIOB-LCKR @ hex. GPIOB-LCKR 1b. ;
: GPIOB-AFRL. ." GPIOB-AFRL (read-write) $" GPIOB-AFRL @ hex. GPIOB-AFRL 1b. ;
: GPIOB-AFRH. ." GPIOB-AFRH (read-write) $" GPIOB-AFRH @ hex. GPIOB-AFRH 1b. ;
: GPIOB.
GPIOB-MODER.
GPIOB-OTYPER.
GPIOB-OSPEEDR.
GPIOB-PUPDR.
GPIOB-IDR.
GPIOB-ODR.
GPIOB-BSRR.
GPIOB-LCKR.
GPIOB-AFRL.
GPIOB-AFRH.
;

$40020000 constant GPIOA ( General-purpose I/Os )
GPIOA $0 + constant GPIOA-MODER ( GPIO port mode register )
GPIOA $4 + constant GPIOA-OTYPER ( GPIO port output type register )
GPIOA $8 + constant GPIOA-OSPEEDR ( GPIO port output speed
  register )
GPIOA $C + constant GPIOA-PUPDR ( GPIO port pull-up/pull-down
  register )
GPIOA $10 + constant GPIOA-IDR ( GPIO port input data register )
GPIOA $14 + constant GPIOA-ODR ( GPIO port output data register )
GPIOA $18 + constant GPIOA-BSRR ( GPIO port bit set/reset
  register )
GPIOA $1C + constant GPIOA-LCKR ( GPIO port configuration lock
  register )
GPIOA $20 + constant GPIOA-AFRL ( GPIO alternate function low
  register )
GPIOA $24 + constant GPIOA-AFRH ( GPIO alternate function high
  register )
: GPIOA-MODER. ." GPIOA-MODER (read-write) $" GPIOA-MODER @ hex. GPIOA-MODER 1b. ;
: GPIOA-OTYPER. ." GPIOA-OTYPER (read-write) $" GPIOA-OTYPER @ hex. GPIOA-OTYPER 1b. ;
: GPIOA-OSPEEDR. ." GPIOA-OSPEEDR (read-write) $" GPIOA-OSPEEDR @ hex. GPIOA-OSPEEDR 1b. ;
: GPIOA-PUPDR. ." GPIOA-PUPDR (read-write) $" GPIOA-PUPDR @ hex. GPIOA-PUPDR 1b. ;
: GPIOA-IDR. ." GPIOA-IDR (read-only) $" GPIOA-IDR @ hex. GPIOA-IDR 1b. ;
: GPIOA-ODR. ." GPIOA-ODR (read-write) $" GPIOA-ODR @ hex. GPIOA-ODR 1b. ;
: GPIOA-BSRR. ." GPIOA-BSRR (write-only) $" GPIOA-BSRR @ hex. GPIOA-BSRR 1b. ;
: GPIOA-LCKR. ." GPIOA-LCKR (read-write) $" GPIOA-LCKR @ hex. GPIOA-LCKR 1b. ;
: GPIOA-AFRL. ." GPIOA-AFRL (read-write) $" GPIOA-AFRL @ hex. GPIOA-AFRL 1b. ;
: GPIOA-AFRH. ." GPIOA-AFRH (read-write) $" GPIOA-AFRH @ hex. GPIOA-AFRH 1b. ;
: GPIOA.
GPIOA-MODER.
GPIOA-OTYPER.
GPIOA-OSPEEDR.
GPIOA-PUPDR.
GPIOA-IDR.
GPIOA-ODR.
GPIOA-BSRR.
GPIOA-LCKR.
GPIOA-AFRL.
GPIOA-AFRH.
;

$40005C00 constant I2C3 ( Inter-integrated circuit )
I2C3 $0 + constant I2C3-CR1 ( Control register 1 )
I2C3 $4 + constant I2C3-CR2 ( Control register 2 )
I2C3 $8 + constant I2C3-OAR1 ( Own address register 1 )
I2C3 $C + constant I2C3-OAR2 ( Own address register 2 )
I2C3 $10 + constant I2C3-DR ( Data register )
I2C3 $14 + constant I2C3-SR1 ( Status register 1 )
I2C3 $18 + constant I2C3-SR2 ( Status register 2 )
I2C3 $1C + constant I2C3-CCR ( Clock control register )
I2C3 $20 + constant I2C3-TRISE ( TRISE register )
: I2C3-CR1. ." I2C3-CR1 (read-write) $" I2C3-CR1 @ hex. I2C3-CR1 1b. ;
: I2C3-CR2. ." I2C3-CR2 (read-write) $" I2C3-CR2 @ hex. I2C3-CR2 1b. ;
: I2C3-OAR1. ." I2C3-OAR1 (read-write) $" I2C3-OAR1 @ hex. I2C3-OAR1 1b. ;
: I2C3-OAR2. ." I2C3-OAR2 (read-write) $" I2C3-OAR2 @ hex. I2C3-OAR2 1b. ;
: I2C3-DR. ." I2C3-DR (read-write) $" I2C3-DR @ hex. I2C3-DR 1b. ;
: I2C3-SR1. ." I2C3-SR1 () $" I2C3-SR1 @ hex. I2C3-SR1 1b. ;
: I2C3-SR2. ." I2C3-SR2 (read-only) $" I2C3-SR2 @ hex. I2C3-SR2 1b. ;
: I2C3-CCR. ." I2C3-CCR (read-write) $" I2C3-CCR @ hex. I2C3-CCR 1b. ;
: I2C3-TRISE. ." I2C3-TRISE (read-write) $" I2C3-TRISE @ hex. I2C3-TRISE 1b. ;
: I2C3.
I2C3-CR1.
I2C3-CR2.
I2C3-OAR1.
I2C3-OAR2.
I2C3-DR.
I2C3-SR1.
I2C3-SR2.
I2C3-CCR.
I2C3-TRISE.
;

$40005800 constant I2C2 ( Inter-integrated circuit )
I2C2 $0 + constant I2C2-CR1 ( Control register 1 )
I2C2 $4 + constant I2C2-CR2 ( Control register 2 )
I2C2 $8 + constant I2C2-OAR1 ( Own address register 1 )
I2C2 $C + constant I2C2-OAR2 ( Own address register 2 )
I2C2 $10 + constant I2C2-DR ( Data register )
I2C2 $14 + constant I2C2-SR1 ( Status register 1 )
I2C2 $18 + constant I2C2-SR2 ( Status register 2 )
I2C2 $1C + constant I2C2-CCR ( Clock control register )
I2C2 $20 + constant I2C2-TRISE ( TRISE register )
: I2C2-CR1. ." I2C2-CR1 (read-write) $" I2C2-CR1 @ hex. I2C2-CR1 1b. ;
: I2C2-CR2. ." I2C2-CR2 (read-write) $" I2C2-CR2 @ hex. I2C2-CR2 1b. ;
: I2C2-OAR1. ." I2C2-OAR1 (read-write) $" I2C2-OAR1 @ hex. I2C2-OAR1 1b. ;
: I2C2-OAR2. ." I2C2-OAR2 (read-write) $" I2C2-OAR2 @ hex. I2C2-OAR2 1b. ;
: I2C2-DR. ." I2C2-DR (read-write) $" I2C2-DR @ hex. I2C2-DR 1b. ;
: I2C2-SR1. ." I2C2-SR1 () $" I2C2-SR1 @ hex. I2C2-SR1 1b. ;
: I2C2-SR2. ." I2C2-SR2 (read-only) $" I2C2-SR2 @ hex. I2C2-SR2 1b. ;
: I2C2-CCR. ." I2C2-CCR (read-write) $" I2C2-CCR @ hex. I2C2-CCR 1b. ;
: I2C2-TRISE. ." I2C2-TRISE (read-write) $" I2C2-TRISE @ hex. I2C2-TRISE 1b. ;
: I2C2.
I2C2-CR1.
I2C2-CR2.
I2C2-OAR1.
I2C2-OAR2.
I2C2-DR.
I2C2-SR1.
I2C2-SR2.
I2C2-CCR.
I2C2-TRISE.
;

$40005400 constant I2C1 ( Inter-integrated circuit )
I2C1 $0 + constant I2C1-CR1 ( Control register 1 )
I2C1 $4 + constant I2C1-CR2 ( Control register 2 )
I2C1 $8 + constant I2C1-OAR1 ( Own address register 1 )
I2C1 $C + constant I2C1-OAR2 ( Own address register 2 )
I2C1 $10 + constant I2C1-DR ( Data register )
I2C1 $14 + constant I2C1-SR1 ( Status register 1 )
I2C1 $18 + constant I2C1-SR2 ( Status register 2 )
I2C1 $1C + constant I2C1-CCR ( Clock control register )
I2C1 $20 + constant I2C1-TRISE ( TRISE register )
: I2C1-CR1. ." I2C1-CR1 (read-write) $" I2C1-CR1 @ hex. I2C1-CR1 1b. ;
: I2C1-CR2. ." I2C1-CR2 (read-write) $" I2C1-CR2 @ hex. I2C1-CR2 1b. ;
: I2C1-OAR1. ." I2C1-OAR1 (read-write) $" I2C1-OAR1 @ hex. I2C1-OAR1 1b. ;
: I2C1-OAR2. ." I2C1-OAR2 (read-write) $" I2C1-OAR2 @ hex. I2C1-OAR2 1b. ;
: I2C1-DR. ." I2C1-DR (read-write) $" I2C1-DR @ hex. I2C1-DR 1b. ;
: I2C1-SR1. ." I2C1-SR1 () $" I2C1-SR1 @ hex. I2C1-SR1 1b. ;
: I2C1-SR2. ." I2C1-SR2 (read-only) $" I2C1-SR2 @ hex. I2C1-SR2 1b. ;
: I2C1-CCR. ." I2C1-CCR (read-write) $" I2C1-CCR @ hex. I2C1-CCR 1b. ;
: I2C1-TRISE. ." I2C1-TRISE (read-write) $" I2C1-TRISE @ hex. I2C1-TRISE 1b. ;
: I2C1.
I2C1-CR1.
I2C1-CR2.
I2C1-OAR1.
I2C1-OAR2.
I2C1-DR.
I2C1-SR1.
I2C1-SR2.
I2C1-CCR.
I2C1-TRISE.
;

$40003400 constant I2S2ext ( Serial peripheral interface )
I2S2ext $0 + constant I2S2ext-CR1 ( control register 1 )
I2S2ext $4 + constant I2S2ext-CR2 ( control register 2 )
I2S2ext $8 + constant I2S2ext-SR ( status register )
I2S2ext $C + constant I2S2ext-DR ( data register )
I2S2ext $10 + constant I2S2ext-CRCPR ( CRC polynomial register )
I2S2ext $14 + constant I2S2ext-RXCRCR ( RX CRC register )
I2S2ext $18 + constant I2S2ext-TXCRCR ( TX CRC register )
I2S2ext $1C + constant I2S2ext-I2SCFGR ( I2S configuration register )
I2S2ext $20 + constant I2S2ext-I2SPR ( I2S prescaler register )
: I2S2ext-CR1. ." I2S2ext-CR1 (read-write) $" I2S2ext-CR1 @ hex. I2S2ext-CR1 1b. ;
: I2S2ext-CR2. ." I2S2ext-CR2 (read-write) $" I2S2ext-CR2 @ hex. I2S2ext-CR2 1b. ;
: I2S2ext-SR. ." I2S2ext-SR () $" I2S2ext-SR @ hex. I2S2ext-SR 1b. ;
: I2S2ext-DR. ." I2S2ext-DR (read-write) $" I2S2ext-DR @ hex. I2S2ext-DR 1b. ;
: I2S2ext-CRCPR. ." I2S2ext-CRCPR (read-write) $" I2S2ext-CRCPR @ hex. I2S2ext-CRCPR 1b. ;
: I2S2ext-RXCRCR. ." I2S2ext-RXCRCR (read-only) $" I2S2ext-RXCRCR @ hex. I2S2ext-RXCRCR 1b. ;
: I2S2ext-TXCRCR. ." I2S2ext-TXCRCR (read-only) $" I2S2ext-TXCRCR @ hex. I2S2ext-TXCRCR 1b. ;
: I2S2ext-I2SCFGR. ." I2S2ext-I2SCFGR (read-write) $" I2S2ext-I2SCFGR @ hex. I2S2ext-I2SCFGR 1b. ;
: I2S2ext-I2SPR. ." I2S2ext-I2SPR (read-write) $" I2S2ext-I2SPR @ hex. I2S2ext-I2SPR 1b. ;
: I2S2ext.
I2S2ext-CR1.
I2S2ext-CR2.
I2S2ext-SR.
I2S2ext-DR.
I2S2ext-CRCPR.
I2S2ext-RXCRCR.
I2S2ext-TXCRCR.
I2S2ext-I2SCFGR.
I2S2ext-I2SPR.
;

$40004000 constant I2S3ext ( Serial peripheral interface )
I2S3ext $0 + constant I2S3ext-CR1 ( control register 1 )
I2S3ext $4 + constant I2S3ext-CR2 ( control register 2 )
I2S3ext $8 + constant I2S3ext-SR ( status register )
I2S3ext $C + constant I2S3ext-DR ( data register )
I2S3ext $10 + constant I2S3ext-CRCPR ( CRC polynomial register )
I2S3ext $14 + constant I2S3ext-RXCRCR ( RX CRC register )
I2S3ext $18 + constant I2S3ext-TXCRCR ( TX CRC register )
I2S3ext $1C + constant I2S3ext-I2SCFGR ( I2S configuration register )
I2S3ext $20 + constant I2S3ext-I2SPR ( I2S prescaler register )
: I2S3ext-CR1. ." I2S3ext-CR1 (read-write) $" I2S3ext-CR1 @ hex. I2S3ext-CR1 1b. ;
: I2S3ext-CR2. ." I2S3ext-CR2 (read-write) $" I2S3ext-CR2 @ hex. I2S3ext-CR2 1b. ;
: I2S3ext-SR. ." I2S3ext-SR () $" I2S3ext-SR @ hex. I2S3ext-SR 1b. ;
: I2S3ext-DR. ." I2S3ext-DR (read-write) $" I2S3ext-DR @ hex. I2S3ext-DR 1b. ;
: I2S3ext-CRCPR. ." I2S3ext-CRCPR (read-write) $" I2S3ext-CRCPR @ hex. I2S3ext-CRCPR 1b. ;
: I2S3ext-RXCRCR. ." I2S3ext-RXCRCR (read-only) $" I2S3ext-RXCRCR @ hex. I2S3ext-RXCRCR 1b. ;
: I2S3ext-TXCRCR. ." I2S3ext-TXCRCR (read-only) $" I2S3ext-TXCRCR @ hex. I2S3ext-TXCRCR 1b. ;
: I2S3ext-I2SCFGR. ." I2S3ext-I2SCFGR (read-write) $" I2S3ext-I2SCFGR @ hex. I2S3ext-I2SCFGR 1b. ;
: I2S3ext-I2SPR. ." I2S3ext-I2SPR (read-write) $" I2S3ext-I2SPR @ hex. I2S3ext-I2SPR 1b. ;
: I2S3ext.
I2S3ext-CR1.
I2S3ext-CR2.
I2S3ext-SR.
I2S3ext-DR.
I2S3ext-CRCPR.
I2S3ext-RXCRCR.
I2S3ext-TXCRCR.
I2S3ext-I2SCFGR.
I2S3ext-I2SPR.
;

$40013000 constant SPI1 ( Serial peripheral interface )
SPI1 $0 + constant SPI1-CR1 ( control register 1 )
SPI1 $4 + constant SPI1-CR2 ( control register 2 )
SPI1 $8 + constant SPI1-SR ( status register )
SPI1 $C + constant SPI1-DR ( data register )
SPI1 $10 + constant SPI1-CRCPR ( CRC polynomial register )
SPI1 $14 + constant SPI1-RXCRCR ( RX CRC register )
SPI1 $18 + constant SPI1-TXCRCR ( TX CRC register )
SPI1 $1C + constant SPI1-I2SCFGR ( I2S configuration register )
SPI1 $20 + constant SPI1-I2SPR ( I2S prescaler register )
: SPI1-CR1. ." SPI1-CR1 (read-write) $" SPI1-CR1 @ hex. SPI1-CR1 1b. ;
: SPI1-CR2. ." SPI1-CR2 (read-write) $" SPI1-CR2 @ hex. SPI1-CR2 1b. ;
: SPI1-SR. ." SPI1-SR () $" SPI1-SR @ hex. SPI1-SR 1b. ;
: SPI1-DR. ." SPI1-DR (read-write) $" SPI1-DR @ hex. SPI1-DR 1b. ;
: SPI1-CRCPR. ." SPI1-CRCPR (read-write) $" SPI1-CRCPR @ hex. SPI1-CRCPR 1b. ;
: SPI1-RXCRCR. ." SPI1-RXCRCR (read-only) $" SPI1-RXCRCR @ hex. SPI1-RXCRCR 1b. ;
: SPI1-TXCRCR. ." SPI1-TXCRCR (read-only) $" SPI1-TXCRCR @ hex. SPI1-TXCRCR 1b. ;
: SPI1-I2SCFGR. ." SPI1-I2SCFGR (read-write) $" SPI1-I2SCFGR @ hex. SPI1-I2SCFGR 1b. ;
: SPI1-I2SPR. ." SPI1-I2SPR (read-write) $" SPI1-I2SPR @ hex. SPI1-I2SPR 1b. ;
: SPI1.
SPI1-CR1.
SPI1-CR2.
SPI1-SR.
SPI1-DR.
SPI1-CRCPR.
SPI1-RXCRCR.
SPI1-TXCRCR.
SPI1-I2SCFGR.
SPI1-I2SPR.
;

$40003800 constant SPI2 ( Serial peripheral interface )
SPI2 $0 + constant SPI2-CR1 ( control register 1 )
SPI2 $4 + constant SPI2-CR2 ( control register 2 )
SPI2 $8 + constant SPI2-SR ( status register )
SPI2 $C + constant SPI2-DR ( data register )
SPI2 $10 + constant SPI2-CRCPR ( CRC polynomial register )
SPI2 $14 + constant SPI2-RXCRCR ( RX CRC register )
SPI2 $18 + constant SPI2-TXCRCR ( TX CRC register )
SPI2 $1C + constant SPI2-I2SCFGR ( I2S configuration register )
SPI2 $20 + constant SPI2-I2SPR ( I2S prescaler register )
: SPI2-CR1. ." SPI2-CR1 (read-write) $" SPI2-CR1 @ hex. SPI2-CR1 1b. ;
: SPI2-CR2. ." SPI2-CR2 (read-write) $" SPI2-CR2 @ hex. SPI2-CR2 1b. ;
: SPI2-SR. ." SPI2-SR () $" SPI2-SR @ hex. SPI2-SR 1b. ;
: SPI2-DR. ." SPI2-DR (read-write) $" SPI2-DR @ hex. SPI2-DR 1b. ;
: SPI2-CRCPR. ." SPI2-CRCPR (read-write) $" SPI2-CRCPR @ hex. SPI2-CRCPR 1b. ;
: SPI2-RXCRCR. ." SPI2-RXCRCR (read-only) $" SPI2-RXCRCR @ hex. SPI2-RXCRCR 1b. ;
: SPI2-TXCRCR. ." SPI2-TXCRCR (read-only) $" SPI2-TXCRCR @ hex. SPI2-TXCRCR 1b. ;
: SPI2-I2SCFGR. ." SPI2-I2SCFGR (read-write) $" SPI2-I2SCFGR @ hex. SPI2-I2SCFGR 1b. ;
: SPI2-I2SPR. ." SPI2-I2SPR (read-write) $" SPI2-I2SPR @ hex. SPI2-I2SPR 1b. ;
: SPI2.
SPI2-CR1.
SPI2-CR2.
SPI2-SR.
SPI2-DR.
SPI2-CRCPR.
SPI2-RXCRCR.
SPI2-TXCRCR.
SPI2-I2SCFGR.
SPI2-I2SPR.
;

$40003C00 constant SPI3 ( Serial peripheral interface )
SPI3 $0 + constant SPI3-CR1 ( control register 1 )
SPI3 $4 + constant SPI3-CR2 ( control register 2 )
SPI3 $8 + constant SPI3-SR ( status register )
SPI3 $C + constant SPI3-DR ( data register )
SPI3 $10 + constant SPI3-CRCPR ( CRC polynomial register )
SPI3 $14 + constant SPI3-RXCRCR ( RX CRC register )
SPI3 $18 + constant SPI3-TXCRCR ( TX CRC register )
SPI3 $1C + constant SPI3-I2SCFGR ( I2S configuration register )
SPI3 $20 + constant SPI3-I2SPR ( I2S prescaler register )
: SPI3-CR1. ." SPI3-CR1 (read-write) $" SPI3-CR1 @ hex. SPI3-CR1 1b. ;
: SPI3-CR2. ." SPI3-CR2 (read-write) $" SPI3-CR2 @ hex. SPI3-CR2 1b. ;
: SPI3-SR. ." SPI3-SR () $" SPI3-SR @ hex. SPI3-SR 1b. ;
: SPI3-DR. ." SPI3-DR (read-write) $" SPI3-DR @ hex. SPI3-DR 1b. ;
: SPI3-CRCPR. ." SPI3-CRCPR (read-write) $" SPI3-CRCPR @ hex. SPI3-CRCPR 1b. ;
: SPI3-RXCRCR. ." SPI3-RXCRCR (read-only) $" SPI3-RXCRCR @ hex. SPI3-RXCRCR 1b. ;
: SPI3-TXCRCR. ." SPI3-TXCRCR (read-only) $" SPI3-TXCRCR @ hex. SPI3-TXCRCR 1b. ;
: SPI3-I2SCFGR. ." SPI3-I2SCFGR (read-write) $" SPI3-I2SCFGR @ hex. SPI3-I2SCFGR 1b. ;
: SPI3-I2SPR. ." SPI3-I2SPR (read-write) $" SPI3-I2SPR @ hex. SPI3-I2SPR 1b. ;
: SPI3.
SPI3-CR1.
SPI3-CR2.
SPI3-SR.
SPI3-DR.
SPI3-CRCPR.
SPI3-RXCRCR.
SPI3-TXCRCR.
SPI3-I2SCFGR.
SPI3-I2SPR.
;

$40013400 constant SPI4 ( Serial peripheral interface )
SPI4 $0 + constant SPI4-CR1 ( control register 1 )
SPI4 $4 + constant SPI4-CR2 ( control register 2 )
SPI4 $8 + constant SPI4-SR ( status register )
SPI4 $C + constant SPI4-DR ( data register )
SPI4 $10 + constant SPI4-CRCPR ( CRC polynomial register )
SPI4 $14 + constant SPI4-RXCRCR ( RX CRC register )
SPI4 $18 + constant SPI4-TXCRCR ( TX CRC register )
SPI4 $1C + constant SPI4-I2SCFGR ( I2S configuration register )
SPI4 $20 + constant SPI4-I2SPR ( I2S prescaler register )
: SPI4-CR1. ." SPI4-CR1 (read-write) $" SPI4-CR1 @ hex. SPI4-CR1 1b. ;
: SPI4-CR2. ." SPI4-CR2 (read-write) $" SPI4-CR2 @ hex. SPI4-CR2 1b. ;
: SPI4-SR. ." SPI4-SR () $" SPI4-SR @ hex. SPI4-SR 1b. ;
: SPI4-DR. ." SPI4-DR (read-write) $" SPI4-DR @ hex. SPI4-DR 1b. ;
: SPI4-CRCPR. ." SPI4-CRCPR (read-write) $" SPI4-CRCPR @ hex. SPI4-CRCPR 1b. ;
: SPI4-RXCRCR. ." SPI4-RXCRCR (read-only) $" SPI4-RXCRCR @ hex. SPI4-RXCRCR 1b. ;
: SPI4-TXCRCR. ." SPI4-TXCRCR (read-only) $" SPI4-TXCRCR @ hex. SPI4-TXCRCR 1b. ;
: SPI4-I2SCFGR. ." SPI4-I2SCFGR (read-write) $" SPI4-I2SCFGR @ hex. SPI4-I2SCFGR 1b. ;
: SPI4-I2SPR. ." SPI4-I2SPR (read-write) $" SPI4-I2SPR @ hex. SPI4-I2SPR 1b. ;
: SPI4.
SPI4-CR1.
SPI4-CR2.
SPI4-SR.
SPI4-DR.
SPI4-CRCPR.
SPI4-RXCRCR.
SPI4-TXCRCR.
SPI4-I2SCFGR.
SPI4-I2SPR.
;

$40015000 constant SPI5 ( Serial peripheral interface )
SPI5 $0 + constant SPI5-CR1 ( control register 1 )
SPI5 $4 + constant SPI5-CR2 ( control register 2 )
SPI5 $8 + constant SPI5-SR ( status register )
SPI5 $C + constant SPI5-DR ( data register )
SPI5 $10 + constant SPI5-CRCPR ( CRC polynomial register )
SPI5 $14 + constant SPI5-RXCRCR ( RX CRC register )
SPI5 $18 + constant SPI5-TXCRCR ( TX CRC register )
SPI5 $1C + constant SPI5-I2SCFGR ( I2S configuration register )
SPI5 $20 + constant SPI5-I2SPR ( I2S prescaler register )
: SPI5-CR1. ." SPI5-CR1 (read-write) $" SPI5-CR1 @ hex. SPI5-CR1 1b. ;
: SPI5-CR2. ." SPI5-CR2 (read-write) $" SPI5-CR2 @ hex. SPI5-CR2 1b. ;
: SPI5-SR. ." SPI5-SR () $" SPI5-SR @ hex. SPI5-SR 1b. ;
: SPI5-DR. ." SPI5-DR (read-write) $" SPI5-DR @ hex. SPI5-DR 1b. ;
: SPI5-CRCPR. ." SPI5-CRCPR (read-write) $" SPI5-CRCPR @ hex. SPI5-CRCPR 1b. ;
: SPI5-RXCRCR. ." SPI5-RXCRCR (read-only) $" SPI5-RXCRCR @ hex. SPI5-RXCRCR 1b. ;
: SPI5-TXCRCR. ." SPI5-TXCRCR (read-only) $" SPI5-TXCRCR @ hex. SPI5-TXCRCR 1b. ;
: SPI5-I2SCFGR. ." SPI5-I2SCFGR (read-write) $" SPI5-I2SCFGR @ hex. SPI5-I2SCFGR 1b. ;
: SPI5-I2SPR. ." SPI5-I2SPR (read-write) $" SPI5-I2SPR @ hex. SPI5-I2SPR 1b. ;
: SPI5.
SPI5-CR1.
SPI5-CR2.
SPI5-SR.
SPI5-DR.
SPI5-CRCPR.
SPI5-RXCRCR.
SPI5-TXCRCR.
SPI5-I2SCFGR.
SPI5-I2SPR.
;

$E000E100 constant NVIC ( Nested Vectored Interrupt
  Controller )
NVIC $0 + constant NVIC-ISER0 ( Interrupt Set-Enable Register )
NVIC $4 + constant NVIC-ISER1 ( Interrupt Set-Enable Register )
NVIC $8 + constant NVIC-ISER2 ( Interrupt Set-Enable Register )
NVIC $80 + constant NVIC-ICER0 ( Interrupt Clear-Enable
  Register )
NVIC $84 + constant NVIC-ICER1 ( Interrupt Clear-Enable
  Register )
NVIC $88 + constant NVIC-ICER2 ( Interrupt Clear-Enable
  Register )
NVIC $100 + constant NVIC-ISPR0 ( Interrupt Set-Pending Register )
NVIC $104 + constant NVIC-ISPR1 ( Interrupt Set-Pending Register )
NVIC $108 + constant NVIC-ISPR2 ( Interrupt Set-Pending Register )
NVIC $180 + constant NVIC-ICPR0 ( Interrupt Clear-Pending
  Register )
NVIC $184 + constant NVIC-ICPR1 ( Interrupt Clear-Pending
  Register )
NVIC $188 + constant NVIC-ICPR2 ( Interrupt Clear-Pending
  Register )
NVIC $200 + constant NVIC-IABR0 ( Interrupt Active Bit Register )
NVIC $204 + constant NVIC-IABR1 ( Interrupt Active Bit Register )
NVIC $208 + constant NVIC-IABR2 ( Interrupt Active Bit Register )
NVIC $300 + constant NVIC-IPR0 ( Interrupt Priority Register )
NVIC $304 + constant NVIC-IPR1 ( Interrupt Priority Register )
NVIC $308 + constant NVIC-IPR2 ( Interrupt Priority Register )
NVIC $30C + constant NVIC-IPR3 ( Interrupt Priority Register )
NVIC $310 + constant NVIC-IPR4 ( Interrupt Priority Register )
NVIC $314 + constant NVIC-IPR5 ( Interrupt Priority Register )
NVIC $318 + constant NVIC-IPR6 ( Interrupt Priority Register )
NVIC $31C + constant NVIC-IPR7 ( Interrupt Priority Register )
NVIC $320 + constant NVIC-IPR8 ( Interrupt Priority Register )
NVIC $324 + constant NVIC-IPR9 ( Interrupt Priority Register )
NVIC $328 + constant NVIC-IPR10 ( Interrupt Priority Register )
NVIC $32C + constant NVIC-IPR11 ( Interrupt Priority Register )
NVIC $330 + constant NVIC-IPR12 ( Interrupt Priority Register )
NVIC $334 + constant NVIC-IPR13 ( Interrupt Priority Register )
NVIC $338 + constant NVIC-IPR14 ( Interrupt Priority Register )
NVIC $33C + constant NVIC-IPR15 ( Interrupt Priority Register )
NVIC $340 + constant NVIC-IPR16 ( Interrupt Priority Register )
NVIC $344 + constant NVIC-IPR17 ( Interrupt Priority Register )
NVIC $348 + constant NVIC-IPR18 ( Interrupt Priority Register )
NVIC $34C + constant NVIC-IPR19 ( Interrupt Priority Register )
: NVIC-ISER0. ." NVIC-ISER0 (read-write) $" NVIC-ISER0 @ hex. NVIC-ISER0 1b. ;
: NVIC-ISER1. ." NVIC-ISER1 (read-write) $" NVIC-ISER1 @ hex. NVIC-ISER1 1b. ;
: NVIC-ISER2. ." NVIC-ISER2 (read-write) $" NVIC-ISER2 @ hex. NVIC-ISER2 1b. ;
: NVIC-ICER0. ." NVIC-ICER0 (read-write) $" NVIC-ICER0 @ hex. NVIC-ICER0 1b. ;
: NVIC-ICER1. ." NVIC-ICER1 (read-write) $" NVIC-ICER1 @ hex. NVIC-ICER1 1b. ;
: NVIC-ICER2. ." NVIC-ICER2 (read-write) $" NVIC-ICER2 @ hex. NVIC-ICER2 1b. ;
: NVIC-ISPR0. ." NVIC-ISPR0 (read-write) $" NVIC-ISPR0 @ hex. NVIC-ISPR0 1b. ;
: NVIC-ISPR1. ." NVIC-ISPR1 (read-write) $" NVIC-ISPR1 @ hex. NVIC-ISPR1 1b. ;
: NVIC-ISPR2. ." NVIC-ISPR2 (read-write) $" NVIC-ISPR2 @ hex. NVIC-ISPR2 1b. ;
: NVIC-ICPR0. ." NVIC-ICPR0 (read-write) $" NVIC-ICPR0 @ hex. NVIC-ICPR0 1b. ;
: NVIC-ICPR1. ." NVIC-ICPR1 (read-write) $" NVIC-ICPR1 @ hex. NVIC-ICPR1 1b. ;
: NVIC-ICPR2. ." NVIC-ICPR2 (read-write) $" NVIC-ICPR2 @ hex. NVIC-ICPR2 1b. ;
: NVIC-IABR0. ." NVIC-IABR0 (read-only) $" NVIC-IABR0 @ hex. NVIC-IABR0 1b. ;
: NVIC-IABR1. ." NVIC-IABR1 (read-only) $" NVIC-IABR1 @ hex. NVIC-IABR1 1b. ;
: NVIC-IABR2. ." NVIC-IABR2 (read-only) $" NVIC-IABR2 @ hex. NVIC-IABR2 1b. ;
: NVIC-IPR0. ." NVIC-IPR0 (read-write) $" NVIC-IPR0 @ hex. NVIC-IPR0 1b. ;
: NVIC-IPR1. ." NVIC-IPR1 (read-write) $" NVIC-IPR1 @ hex. NVIC-IPR1 1b. ;
: NVIC-IPR2. ." NVIC-IPR2 (read-write) $" NVIC-IPR2 @ hex. NVIC-IPR2 1b. ;
: NVIC-IPR3. ." NVIC-IPR3 (read-write) $" NVIC-IPR3 @ hex. NVIC-IPR3 1b. ;
: NVIC-IPR4. ." NVIC-IPR4 (read-write) $" NVIC-IPR4 @ hex. NVIC-IPR4 1b. ;
: NVIC-IPR5. ." NVIC-IPR5 (read-write) $" NVIC-IPR5 @ hex. NVIC-IPR5 1b. ;
: NVIC-IPR6. ." NVIC-IPR6 (read-write) $" NVIC-IPR6 @ hex. NVIC-IPR6 1b. ;
: NVIC-IPR7. ." NVIC-IPR7 (read-write) $" NVIC-IPR7 @ hex. NVIC-IPR7 1b. ;
: NVIC-IPR8. ." NVIC-IPR8 (read-write) $" NVIC-IPR8 @ hex. NVIC-IPR8 1b. ;
: NVIC-IPR9. ." NVIC-IPR9 (read-write) $" NVIC-IPR9 @ hex. NVIC-IPR9 1b. ;
: NVIC-IPR10. ." NVIC-IPR10 (read-write) $" NVIC-IPR10 @ hex. NVIC-IPR10 1b. ;
: NVIC-IPR11. ." NVIC-IPR11 (read-write) $" NVIC-IPR11 @ hex. NVIC-IPR11 1b. ;
: NVIC-IPR12. ." NVIC-IPR12 (read-write) $" NVIC-IPR12 @ hex. NVIC-IPR12 1b. ;
: NVIC-IPR13. ." NVIC-IPR13 (read-write) $" NVIC-IPR13 @ hex. NVIC-IPR13 1b. ;
: NVIC-IPR14. ." NVIC-IPR14 (read-write) $" NVIC-IPR14 @ hex. NVIC-IPR14 1b. ;
: NVIC-IPR15. ." NVIC-IPR15 (read-write) $" NVIC-IPR15 @ hex. NVIC-IPR15 1b. ;
: NVIC-IPR16. ." NVIC-IPR16 (read-write) $" NVIC-IPR16 @ hex. NVIC-IPR16 1b. ;
: NVIC-IPR17. ." NVIC-IPR17 (read-write) $" NVIC-IPR17 @ hex. NVIC-IPR17 1b. ;
: NVIC-IPR18. ." NVIC-IPR18 (read-write) $" NVIC-IPR18 @ hex. NVIC-IPR18 1b. ;
: NVIC-IPR19. ." NVIC-IPR19 (read-write) $" NVIC-IPR19 @ hex. NVIC-IPR19 1b. ;
: NVIC.
NVIC-ISER0.
NVIC-ISER1.
NVIC-ISER2.
NVIC-ICER0.
NVIC-ICER1.
NVIC-ICER2.
NVIC-ISPR0.
NVIC-ISPR1.
NVIC-ISPR2.
NVIC-ICPR0.
NVIC-ICPR1.
NVIC-ICPR2.
NVIC-IABR0.
NVIC-IABR1.
NVIC-IABR2.
NVIC-IPR0.
NVIC-IPR1.
NVIC-IPR2.
NVIC-IPR3.
NVIC-IPR4.
NVIC-IPR5.
NVIC-IPR6.
NVIC-IPR7.
NVIC-IPR8.
NVIC-IPR9.
NVIC-IPR10.
NVIC-IPR11.
NVIC-IPR12.
NVIC-IPR13.
NVIC-IPR14.
NVIC-IPR15.
NVIC-IPR16.
NVIC-IPR17.
NVIC-IPR18.
NVIC-IPR19.
;

$E000EF34 constant FPU ( Floting point unit )
FPU $0 + constant FPU-FPCCR ( Floating-point context control
  register )
FPU $4 + constant FPU-FPCAR ( Floating-point context address
  register )
FPU $8 + constant FPU-FPSCR ( Floating-point status control
  register )
: FPU-FPCCR. ." FPU-FPCCR (read-write) $" FPU-FPCCR @ hex. FPU-FPCCR 1b. ;
: FPU-FPCAR. ." FPU-FPCAR (read-write) $" FPU-FPCAR @ hex. FPU-FPCAR 1b. ;
: FPU-FPSCR. ." FPU-FPSCR (read-write) $" FPU-FPSCR @ hex. FPU-FPSCR 1b. ;
: FPU.
FPU-FPCCR.
FPU-FPCAR.
FPU-FPSCR.
;

$E000ED90 constant MPU ( Memory protection unit )
MPU $0 + constant MPU-MPU_TYPER ( MPU type register )
MPU $4 + constant MPU-MPU_CTRL ( MPU control register )
MPU $8 + constant MPU-MPU_RNR ( MPU region number register )
MPU $C + constant MPU-MPU_RBAR ( MPU region base address
  register )
MPU $10 + constant MPU-MPU_RASR ( MPU region attribute and size
  register )
: MPU-MPU_TYPER. ." MPU-MPU_TYPER (read-only) $" MPU-MPU_TYPER @ hex. MPU-MPU_TYPER 1b. ;
: MPU-MPU_CTRL. ." MPU-MPU_CTRL (read-only) $" MPU-MPU_CTRL @ hex. MPU-MPU_CTRL 1b. ;
: MPU-MPU_RNR. ." MPU-MPU_RNR (read-write) $" MPU-MPU_RNR @ hex. MPU-MPU_RNR 1b. ;
: MPU-MPU_RBAR. ." MPU-MPU_RBAR (read-write) $" MPU-MPU_RBAR @ hex. MPU-MPU_RBAR 1b. ;
: MPU-MPU_RASR. ." MPU-MPU_RASR (read-write) $" MPU-MPU_RASR @ hex. MPU-MPU_RASR 1b. ;
: MPU.
MPU-MPU_TYPER.
MPU-MPU_CTRL.
MPU-MPU_RNR.
MPU-MPU_RBAR.
MPU-MPU_RASR.
;

$E000E010 constant STK ( SysTick timer )
STK $0 + constant STK-CTRL ( SysTick control and status
  register )
STK $4 + constant STK-LOAD ( SysTick reload value register )
STK $8 + constant STK-VAL ( SysTick current value register )
STK $C + constant STK-CALIB ( SysTick calibration value
  register )
: STK-CTRL. ." STK-CTRL (read-write) $" STK-CTRL @ hex. STK-CTRL 1b. ;
: STK-LOAD. ." STK-LOAD (read-write) $" STK-LOAD @ hex. STK-LOAD 1b. ;
: STK-VAL. ." STK-VAL (read-write) $" STK-VAL @ hex. STK-VAL 1b. ;
: STK-CALIB. ." STK-CALIB (read-write) $" STK-CALIB @ hex. STK-CALIB 1b. ;
: STK.
STK-CTRL.
STK-LOAD.
STK-VAL.
STK-CALIB.
;

$E000ED00 constant SCB ( System control block )
SCB $0 + constant SCB-CPUID ( CPUID base register )
SCB $4 + constant SCB-ICSR ( Interrupt control and state
  register )
SCB $8 + constant SCB-VTOR ( Vector table offset register )
SCB $C + constant SCB-AIRCR ( Application interrupt and reset control
  register )
SCB $10 + constant SCB-SCR ( System control register )
SCB $14 + constant SCB-CCR ( Configuration and control
  register )
SCB $18 + constant SCB-SHPR1 ( System handler priority
  registers )
SCB $1C + constant SCB-SHPR2 ( System handler priority
  registers )
SCB $20 + constant SCB-SHPR3 ( System handler priority
  registers )
SCB $24 + constant SCB-SHCRS ( System handler control and state
  register )
SCB $28 + constant SCB-CFSR_UFSR_BFSR_MMFSR ( Configurable fault status
  register )
SCB $2C + constant SCB-HFSR ( Hard fault status register )
SCB $34 + constant SCB-MMFAR ( Memory management fault address
  register )
SCB $38 + constant SCB-BFAR ( Bus fault address register )
SCB $3C + constant SCB-AFSR ( Auxiliary fault status
  register )
: SCB-CPUID. ." SCB-CPUID (read-only) $" SCB-CPUID @ hex. SCB-CPUID 1b. ;
: SCB-ICSR. ." SCB-ICSR (read-write) $" SCB-ICSR @ hex. SCB-ICSR 1b. ;
: SCB-VTOR. ." SCB-VTOR (read-write) $" SCB-VTOR @ hex. SCB-VTOR 1b. ;
: SCB-AIRCR. ." SCB-AIRCR (read-write) $" SCB-AIRCR @ hex. SCB-AIRCR 1b. ;
: SCB-SCR. ." SCB-SCR (read-write) $" SCB-SCR @ hex. SCB-SCR 1b. ;
: SCB-CCR. ." SCB-CCR (read-write) $" SCB-CCR @ hex. SCB-CCR 1b. ;
: SCB-SHPR1. ." SCB-SHPR1 (read-write) $" SCB-SHPR1 @ hex. SCB-SHPR1 1b. ;
: SCB-SHPR2. ." SCB-SHPR2 (read-write) $" SCB-SHPR2 @ hex. SCB-SHPR2 1b. ;
: SCB-SHPR3. ." SCB-SHPR3 (read-write) $" SCB-SHPR3 @ hex. SCB-SHPR3 1b. ;
: SCB-SHCRS. ." SCB-SHCRS (read-write) $" SCB-SHCRS @ hex. SCB-SHCRS 1b. ;
: SCB-CFSR_UFSR_BFSR_MMFSR. ." SCB-CFSR_UFSR_BFSR_MMFSR (read-write) $" SCB-CFSR_UFSR_BFSR_MMFSR @ hex. SCB-CFSR_UFSR_BFSR_MMFSR 1b. ;
: SCB-HFSR. ." SCB-HFSR (read-write) $" SCB-HFSR @ hex. SCB-HFSR 1b. ;
: SCB-MMFAR. ." SCB-MMFAR (read-write) $" SCB-MMFAR @ hex. SCB-MMFAR 1b. ;
: SCB-BFAR. ." SCB-BFAR (read-write) $" SCB-BFAR @ hex. SCB-BFAR 1b. ;
: SCB-AFSR. ." SCB-AFSR (read-write) $" SCB-AFSR @ hex. SCB-AFSR 1b. ;
: SCB.
SCB-CPUID.
SCB-ICSR.
SCB-VTOR.
SCB-AIRCR.
SCB-SCR.
SCB-CCR.
SCB-SHPR1.
SCB-SHPR2.
SCB-SHPR3.
SCB-SHCRS.
SCB-CFSR_UFSR_BFSR_MMFSR.
SCB-HFSR.
SCB-MMFAR.
SCB-BFAR.
SCB-AFSR.
;

$E000EF00 constant NVIC_STIR ( Nested vectored interrupt
  controller )
NVIC_STIR $0 + constant NVIC_STIR-STIR ( Software trigger interrupt
  register )
: NVIC_STIR-STIR. ." NVIC_STIR-STIR (read-write) $" NVIC_STIR-STIR @ hex. NVIC_STIR-STIR 1b. ;
: NVIC_STIR.
NVIC_STIR-STIR.
;

$E000ED88 constant FPU_CPACR ( Floating point unit CPACR )
FPU_CPACR $0 + constant FPU_CPACR-CPACR ( Coprocessor access control
  register )
: FPU_CPACR-CPACR. ." FPU_CPACR-CPACR (read-write) $" FPU_CPACR-CPACR @ hex. FPU_CPACR-CPACR 1b. ;
: FPU_CPACR.
FPU_CPACR-CPACR.
;

$E000E008 constant SCB_ACTRL ( System control block ACTLR )
SCB_ACTRL $0 + constant SCB_ACTRL-ACTRL ( Auxiliary control register )
: SCB_ACTRL-ACTRL. ." SCB_ACTRL-ACTRL (read-write) $" SCB_ACTRL-ACTRL @ hex. SCB_ACTRL-ACTRL 1b. ;
: SCB_ACTRL.
SCB_ACTRL-ACTRL.
;


compiletoram
