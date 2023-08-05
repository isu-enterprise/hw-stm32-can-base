\ STM32F411 Register Bitfield Definitions for Mecrisp-Stellaris Forth by Matthias Koch. 
\ bitfield.xsl takes STM32Fxx.svd, config.xml and produces bitfield.fs
\ Written by Terry Porter "terry@tjporter.com.au" 2016 - 2018 and released under the GPL V2.
\ Replace 'bis!' (set bit) with 'bic!' to CLEAR bit, 'bit@' to test bit etc.


\ ADC_Common-CSR (read-only)
: ADC_Common-CSR_OVR3   %1 21 lshift ADC_Common-CSR bis! ;  \ ADC_Common-CSR_OVR3    Overrun flag of ADC3
: ADC_Common-CSR_STRT3   %1 20 lshift ADC_Common-CSR bis! ;  \ ADC_Common-CSR_STRT3    Regular channel Start flag of ADC
  3
: ADC_Common-CSR_JSTRT3   %1 19 lshift ADC_Common-CSR bis! ;  \ ADC_Common-CSR_JSTRT3    Injected channel Start flag of ADC
  3
: ADC_Common-CSR_JEOC3   %1 18 lshift ADC_Common-CSR bis! ;  \ ADC_Common-CSR_JEOC3    Injected channel end of conversion of
  ADC 3
: ADC_Common-CSR_EOC3   %1 17 lshift ADC_Common-CSR bis! ;  \ ADC_Common-CSR_EOC3    End of conversion of ADC 3
: ADC_Common-CSR_AWD3   %1 16 lshift ADC_Common-CSR bis! ;  \ ADC_Common-CSR_AWD3    Analog watchdog flag of ADC
  3
: ADC_Common-CSR_OVR2   %1 13 lshift ADC_Common-CSR bis! ;  \ ADC_Common-CSR_OVR2    Overrun flag of ADC 2
: ADC_Common-CSR_STRT2   %1 12 lshift ADC_Common-CSR bis! ;  \ ADC_Common-CSR_STRT2    Regular channel Start flag of ADC
  2
: ADC_Common-CSR_JSTRT2   %1 11 lshift ADC_Common-CSR bis! ;  \ ADC_Common-CSR_JSTRT2    Injected channel Start flag of ADC
  2
: ADC_Common-CSR_JEOC2   %1 10 lshift ADC_Common-CSR bis! ;  \ ADC_Common-CSR_JEOC2    Injected channel end of conversion of
  ADC 2
: ADC_Common-CSR_EOC2   %1 9 lshift ADC_Common-CSR bis! ;  \ ADC_Common-CSR_EOC2    End of conversion of ADC 2
: ADC_Common-CSR_AWD2   %1 8 lshift ADC_Common-CSR bis! ;  \ ADC_Common-CSR_AWD2    Analog watchdog flag of ADC
  2
: ADC_Common-CSR_OVR1   %1 5 lshift ADC_Common-CSR bis! ;  \ ADC_Common-CSR_OVR1    Overrun flag of ADC 1
: ADC_Common-CSR_STRT1   %1 4 lshift ADC_Common-CSR bis! ;  \ ADC_Common-CSR_STRT1    Regular channel Start flag of ADC
  1
: ADC_Common-CSR_JSTRT1   %1 3 lshift ADC_Common-CSR bis! ;  \ ADC_Common-CSR_JSTRT1    Injected channel Start flag of ADC
  1
: ADC_Common-CSR_JEOC1   %1 2 lshift ADC_Common-CSR bis! ;  \ ADC_Common-CSR_JEOC1    Injected channel end of conversion of
  ADC 1
: ADC_Common-CSR_EOC1   %1 1 lshift ADC_Common-CSR bis! ;  \ ADC_Common-CSR_EOC1    End of conversion of ADC 1
: ADC_Common-CSR_AWD1   %1 0 lshift ADC_Common-CSR bis! ;  \ ADC_Common-CSR_AWD1    Analog watchdog flag of ADC
  1

\ ADC_Common-CCR (read-write)
: ADC_Common-CCR_TSVREFE   %1 23 lshift ADC_Common-CCR bis! ;  \ ADC_Common-CCR_TSVREFE    Temperature sensor and VREFINT
  enable
: ADC_Common-CCR_VBATE   %1 22 lshift ADC_Common-CCR bis! ;  \ ADC_Common-CCR_VBATE    VBAT enable
: ADC_Common-CCR_ADCPRE   ( %XX -- ) 16 lshift ADC_Common-CCR bis! ;  \ ADC_Common-CCR_ADCPRE    ADC prescaler
: ADC_Common-CCR_DMA   ( %XX -- ) 14 lshift ADC_Common-CCR bis! ;  \ ADC_Common-CCR_DMA    Direct memory access mode for multi ADC
  mode
: ADC_Common-CCR_DDS   %1 13 lshift ADC_Common-CCR bis! ;  \ ADC_Common-CCR_DDS    DMA disable selection for multi-ADC
  mode
: ADC_Common-CCR_DELAY   ( %XXXX -- ) 8 lshift ADC_Common-CCR bis! ;  \ ADC_Common-CCR_DELAY    Delay between 2 sampling
  phases

\ ADC1-SR (read-write)
: ADC1-SR_OVR   %1 5 lshift ADC1-SR bis! ;  \ ADC1-SR_OVR    Overrun
: ADC1-SR_STRT   %1 4 lshift ADC1-SR bis! ;  \ ADC1-SR_STRT    Regular channel start flag
: ADC1-SR_JSTRT   %1 3 lshift ADC1-SR bis! ;  \ ADC1-SR_JSTRT    Injected channel start
  flag
: ADC1-SR_JEOC   %1 2 lshift ADC1-SR bis! ;  \ ADC1-SR_JEOC    Injected channel end of
  conversion
: ADC1-SR_EOC   %1 1 lshift ADC1-SR bis! ;  \ ADC1-SR_EOC    Regular channel end of
  conversion
: ADC1-SR_AWD   %1 0 lshift ADC1-SR bis! ;  \ ADC1-SR_AWD    Analog watchdog flag

\ ADC1-CR1 (read-write)
: ADC1-CR1_OVRIE   %1 26 lshift ADC1-CR1 bis! ;  \ ADC1-CR1_OVRIE    Overrun interrupt enable
: ADC1-CR1_RES   ( %XX -- ) 24 lshift ADC1-CR1 bis! ;  \ ADC1-CR1_RES    Resolution
: ADC1-CR1_AWDEN   %1 23 lshift ADC1-CR1 bis! ;  \ ADC1-CR1_AWDEN    Analog watchdog enable on regular
  channels
: ADC1-CR1_JAWDEN   %1 22 lshift ADC1-CR1 bis! ;  \ ADC1-CR1_JAWDEN    Analog watchdog enable on injected
  channels
: ADC1-CR1_DISCNUM   ( %XXX -- ) 13 lshift ADC1-CR1 bis! ;  \ ADC1-CR1_DISCNUM    Discontinuous mode channel
  count
: ADC1-CR1_JDISCEN   %1 12 lshift ADC1-CR1 bis! ;  \ ADC1-CR1_JDISCEN    Discontinuous mode on injected
  channels
: ADC1-CR1_DISCEN   %1 11 lshift ADC1-CR1 bis! ;  \ ADC1-CR1_DISCEN    Discontinuous mode on regular
  channels
: ADC1-CR1_JAUTO   %1 10 lshift ADC1-CR1 bis! ;  \ ADC1-CR1_JAUTO    Automatic injected group
  conversion
: ADC1-CR1_AWDSGL   %1 9 lshift ADC1-CR1 bis! ;  \ ADC1-CR1_AWDSGL    Enable the watchdog on a single channel
  in scan mode
: ADC1-CR1_SCAN   %1 8 lshift ADC1-CR1 bis! ;  \ ADC1-CR1_SCAN    Scan mode
: ADC1-CR1_JEOCIE   %1 7 lshift ADC1-CR1 bis! ;  \ ADC1-CR1_JEOCIE    Interrupt enable for injected
  channels
: ADC1-CR1_AWDIE   %1 6 lshift ADC1-CR1 bis! ;  \ ADC1-CR1_AWDIE    Analog watchdog interrupt
  enable
: ADC1-CR1_EOCIE   %1 5 lshift ADC1-CR1 bis! ;  \ ADC1-CR1_EOCIE    Interrupt enable for EOC
: ADC1-CR1_AWDCH   ( %XXXXX -- ) 0 lshift ADC1-CR1 bis! ;  \ ADC1-CR1_AWDCH    Analog watchdog channel select
  bits

\ ADC1-CR2 (read-write)
: ADC1-CR2_SWSTART   %1 30 lshift ADC1-CR2 bis! ;  \ ADC1-CR2_SWSTART    Start conversion of regular
  channels
: ADC1-CR2_EXTEN   ( %XX -- ) 28 lshift ADC1-CR2 bis! ;  \ ADC1-CR2_EXTEN    External trigger enable for regular
  channels
: ADC1-CR2_EXTSEL   ( %XXXX -- ) 24 lshift ADC1-CR2 bis! ;  \ ADC1-CR2_EXTSEL    External event select for regular
  group
: ADC1-CR2_JSWSTART   %1 22 lshift ADC1-CR2 bis! ;  \ ADC1-CR2_JSWSTART    Start conversion of injected
  channels
: ADC1-CR2_JEXTEN   ( %XX -- ) 20 lshift ADC1-CR2 bis! ;  \ ADC1-CR2_JEXTEN    External trigger enable for injected
  channels
: ADC1-CR2_JEXTSEL   ( %XXXX -- ) 16 lshift ADC1-CR2 bis! ;  \ ADC1-CR2_JEXTSEL    External event select for injected
  group
: ADC1-CR2_ALIGN   %1 11 lshift ADC1-CR2 bis! ;  \ ADC1-CR2_ALIGN    Data alignment
: ADC1-CR2_EOCS   %1 10 lshift ADC1-CR2 bis! ;  \ ADC1-CR2_EOCS    End of conversion
  selection
: ADC1-CR2_DDS   %1 9 lshift ADC1-CR2 bis! ;  \ ADC1-CR2_DDS    DMA disable selection for single ADC
  mode
: ADC1-CR2_DMA   %1 8 lshift ADC1-CR2 bis! ;  \ ADC1-CR2_DMA    Direct memory access mode for single
  ADC mode
: ADC1-CR2_CONT   %1 1 lshift ADC1-CR2 bis! ;  \ ADC1-CR2_CONT    Continuous conversion
: ADC1-CR2_ADON   %1 0 lshift ADC1-CR2 bis! ;  \ ADC1-CR2_ADON    A/D Converter ON / OFF

\ ADC1-SMPR1 (read-write)
: ADC1-SMPR1_SMPx_x   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift ADC1-SMPR1 bis! ;  \ ADC1-SMPR1_SMPx_x    Sample time bits

\ ADC1-SMPR2 (read-write)
: ADC1-SMPR2_SMPx_x   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift ADC1-SMPR2 bis! ;  \ ADC1-SMPR2_SMPx_x    Sample time bits

\ ADC1-JOFR1 (read-write)
: ADC1-JOFR1_JOFFSET1   ( %XXXXXXXXXXX -- ) 0 lshift ADC1-JOFR1 bis! ;  \ ADC1-JOFR1_JOFFSET1    Data offset for injected channel
  x

\ ADC1-JOFR2 (read-write)
: ADC1-JOFR2_JOFFSET2   ( %XXXXXXXXXXX -- ) 0 lshift ADC1-JOFR2 bis! ;  \ ADC1-JOFR2_JOFFSET2    Data offset for injected channel
  x

\ ADC1-JOFR3 (read-write)
: ADC1-JOFR3_JOFFSET3   ( %XXXXXXXXXXX -- ) 0 lshift ADC1-JOFR3 bis! ;  \ ADC1-JOFR3_JOFFSET3    Data offset for injected channel
  x

\ ADC1-JOFR4 (read-write)
: ADC1-JOFR4_JOFFSET4   ( %XXXXXXXXXXX -- ) 0 lshift ADC1-JOFR4 bis! ;  \ ADC1-JOFR4_JOFFSET4    Data offset for injected channel
  x

\ ADC1-HTR (read-write)
: ADC1-HTR_HT   ( %XXXXXXXXXXX -- ) 0 lshift ADC1-HTR bis! ;  \ ADC1-HTR_HT    Analog watchdog higher
  threshold

\ ADC1-LTR (read-write)
: ADC1-LTR_LT   ( %XXXXXXXXXXX -- ) 0 lshift ADC1-LTR bis! ;  \ ADC1-LTR_LT    Analog watchdog lower
  threshold

\ ADC1-SQR1 (read-write)
: ADC1-SQR1_L   ( %XXXX -- ) 20 lshift ADC1-SQR1 bis! ;  \ ADC1-SQR1_L    Regular channel sequence
  length
: ADC1-SQR1_SQ16   ( %XXXXX -- ) 15 lshift ADC1-SQR1 bis! ;  \ ADC1-SQR1_SQ16    16th conversion in regular
  sequence
: ADC1-SQR1_SQ15   ( %XXXXX -- ) 10 lshift ADC1-SQR1 bis! ;  \ ADC1-SQR1_SQ15    15th conversion in regular
  sequence
: ADC1-SQR1_SQ14   ( %XXXXX -- ) 5 lshift ADC1-SQR1 bis! ;  \ ADC1-SQR1_SQ14    14th conversion in regular
  sequence
: ADC1-SQR1_SQ13   ( %XXXXX -- ) 0 lshift ADC1-SQR1 bis! ;  \ ADC1-SQR1_SQ13    13th conversion in regular
  sequence

\ ADC1-SQR2 (read-write)
: ADC1-SQR2_SQ12   ( %XXXXX -- ) 25 lshift ADC1-SQR2 bis! ;  \ ADC1-SQR2_SQ12    12th conversion in regular
  sequence
: ADC1-SQR2_SQ11   ( %XXXXX -- ) 20 lshift ADC1-SQR2 bis! ;  \ ADC1-SQR2_SQ11    11th conversion in regular
  sequence
: ADC1-SQR2_SQ10   ( %XXXXX -- ) 15 lshift ADC1-SQR2 bis! ;  \ ADC1-SQR2_SQ10    10th conversion in regular
  sequence
: ADC1-SQR2_SQ9   ( %XXXXX -- ) 10 lshift ADC1-SQR2 bis! ;  \ ADC1-SQR2_SQ9    9th conversion in regular
  sequence
: ADC1-SQR2_SQ8   ( %XXXXX -- ) 5 lshift ADC1-SQR2 bis! ;  \ ADC1-SQR2_SQ8    8th conversion in regular
  sequence
: ADC1-SQR2_SQ7   ( %XXXXX -- ) 0 lshift ADC1-SQR2 bis! ;  \ ADC1-SQR2_SQ7    7th conversion in regular
  sequence

\ ADC1-SQR3 (read-write)
: ADC1-SQR3_SQ6   ( %XXXXX -- ) 25 lshift ADC1-SQR3 bis! ;  \ ADC1-SQR3_SQ6    6th conversion in regular
  sequence
: ADC1-SQR3_SQ5   ( %XXXXX -- ) 20 lshift ADC1-SQR3 bis! ;  \ ADC1-SQR3_SQ5    5th conversion in regular
  sequence
: ADC1-SQR3_SQ4   ( %XXXXX -- ) 15 lshift ADC1-SQR3 bis! ;  \ ADC1-SQR3_SQ4    4th conversion in regular
  sequence
: ADC1-SQR3_SQ3   ( %XXXXX -- ) 10 lshift ADC1-SQR3 bis! ;  \ ADC1-SQR3_SQ3    3rd conversion in regular
  sequence
: ADC1-SQR3_SQ2   ( %XXXXX -- ) 5 lshift ADC1-SQR3 bis! ;  \ ADC1-SQR3_SQ2    2nd conversion in regular
  sequence
: ADC1-SQR3_SQ1   ( %XXXXX -- ) 0 lshift ADC1-SQR3 bis! ;  \ ADC1-SQR3_SQ1    1st conversion in regular
  sequence

\ ADC1-JSQR (read-write)
: ADC1-JSQR_JL   ( %XX -- ) 20 lshift ADC1-JSQR bis! ;  \ ADC1-JSQR_JL    Injected sequence length
: ADC1-JSQR_JSQ4   ( %XXXXX -- ) 15 lshift ADC1-JSQR bis! ;  \ ADC1-JSQR_JSQ4    4th conversion in injected
  sequence
: ADC1-JSQR_JSQ3   ( %XXXXX -- ) 10 lshift ADC1-JSQR bis! ;  \ ADC1-JSQR_JSQ3    3rd conversion in injected
  sequence
: ADC1-JSQR_JSQ2   ( %XXXXX -- ) 5 lshift ADC1-JSQR bis! ;  \ ADC1-JSQR_JSQ2    2nd conversion in injected
  sequence
: ADC1-JSQR_JSQ1   ( %XXXXX -- ) 0 lshift ADC1-JSQR bis! ;  \ ADC1-JSQR_JSQ1    1st conversion in injected
  sequence

\ ADC1-JDR1 (read-only)
: ADC1-JDR1_JDATA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift ADC1-JDR1 bis! ;  \ ADC1-JDR1_JDATA    Injected data

\ ADC1-JDR2 (read-only)
: ADC1-JDR2_JDATA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift ADC1-JDR2 bis! ;  \ ADC1-JDR2_JDATA    Injected data

\ ADC1-JDR3 (read-only)
: ADC1-JDR3_JDATA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift ADC1-JDR3 bis! ;  \ ADC1-JDR3_JDATA    Injected data

\ ADC1-JDR4 (read-only)
: ADC1-JDR4_JDATA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift ADC1-JDR4 bis! ;  \ ADC1-JDR4_JDATA    Injected data

\ ADC1-DR (read-only)
: ADC1-DR_DATA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift ADC1-DR bis! ;  \ ADC1-DR_DATA    Regular data

\ CRC-DR (read-write)
: CRC-DR_DR   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift CRC-DR bis! ;  \ CRC-DR_DR    Data Register

\ CRC-IDR (read-write)
: CRC-IDR_IDR   ( %XXXXXXXX -- ) 0 lshift CRC-IDR bis! ;  \ CRC-IDR_IDR    Independent Data register

\ CRC-CR (write-only)
: CRC-CR_CR   %1 0 lshift CRC-CR bis! ;  \ CRC-CR_CR    Control regidter

\ DBG-DBGMCU_IDCODE (read-only)
: DBG-DBGMCU_IDCODE_DEV_ID   ( %XXXXXXXXXXX -- ) 0 lshift DBG-DBGMCU_IDCODE bis! ;  \ DBG-DBGMCU_IDCODE_DEV_ID    DEV_ID
: DBG-DBGMCU_IDCODE_REV_ID   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift DBG-DBGMCU_IDCODE bis! ;  \ DBG-DBGMCU_IDCODE_REV_ID    REV_ID

\ DBG-DBGMCU_CR (read-write)
: DBG-DBGMCU_CR_DBG_SLEEP   %1 0 lshift DBG-DBGMCU_CR bis! ;  \ DBG-DBGMCU_CR_DBG_SLEEP    DBG_SLEEP
: DBG-DBGMCU_CR_DBG_STOP   %1 1 lshift DBG-DBGMCU_CR bis! ;  \ DBG-DBGMCU_CR_DBG_STOP    DBG_STOP
: DBG-DBGMCU_CR_DBG_STANDBY   %1 2 lshift DBG-DBGMCU_CR bis! ;  \ DBG-DBGMCU_CR_DBG_STANDBY    DBG_STANDBY
: DBG-DBGMCU_CR_TRACE_IOEN   %1 5 lshift DBG-DBGMCU_CR bis! ;  \ DBG-DBGMCU_CR_TRACE_IOEN    TRACE_IOEN
: DBG-DBGMCU_CR_TRACE_MODE   ( %XX -- ) 6 lshift DBG-DBGMCU_CR bis! ;  \ DBG-DBGMCU_CR_TRACE_MODE    TRACE_MODE

\ DBG-DBGMCU_APB1_FZ (read-write)
: DBG-DBGMCU_APB1_FZ_DBG_TIM2_STOP   %1 0 lshift DBG-DBGMCU_APB1_FZ bis! ;  \ DBG-DBGMCU_APB1_FZ_DBG_TIM2_STOP    DBG_TIM2_STOP
: DBG-DBGMCU_APB1_FZ_DBG_TIM3_STOP   %1 1 lshift DBG-DBGMCU_APB1_FZ bis! ;  \ DBG-DBGMCU_APB1_FZ_DBG_TIM3_STOP    DBG_TIM3 _STOP
: DBG-DBGMCU_APB1_FZ_DBG_TIM4_STOP   %1 2 lshift DBG-DBGMCU_APB1_FZ bis! ;  \ DBG-DBGMCU_APB1_FZ_DBG_TIM4_STOP    DBG_TIM4_STOP
: DBG-DBGMCU_APB1_FZ_DBG_TIM5_STOP   %1 3 lshift DBG-DBGMCU_APB1_FZ bis! ;  \ DBG-DBGMCU_APB1_FZ_DBG_TIM5_STOP    DBG_TIM5_STOP
: DBG-DBGMCU_APB1_FZ_DBG_RTC_Stop   %1 10 lshift DBG-DBGMCU_APB1_FZ bis! ;  \ DBG-DBGMCU_APB1_FZ_DBG_RTC_Stop    RTC stopped when Core is
  halted
: DBG-DBGMCU_APB1_FZ_DBG_WWDG_STOP   %1 11 lshift DBG-DBGMCU_APB1_FZ bis! ;  \ DBG-DBGMCU_APB1_FZ_DBG_WWDG_STOP    DBG_WWDG_STOP
: DBG-DBGMCU_APB1_FZ_DBG_IWDEG_STOP   %1 12 lshift DBG-DBGMCU_APB1_FZ bis! ;  \ DBG-DBGMCU_APB1_FZ_DBG_IWDEG_STOP    DBG_IWDEG_STOP
: DBG-DBGMCU_APB1_FZ_DBG_I2C1_SMBUS_TIMEOUT   %1 21 lshift DBG-DBGMCU_APB1_FZ bis! ;  \ DBG-DBGMCU_APB1_FZ_DBG_I2C1_SMBUS_TIMEOUT    DBG_J2C1_SMBUS_TIMEOUT
: DBG-DBGMCU_APB1_FZ_DBG_I2C2_SMBUS_TIMEOUT   %1 22 lshift DBG-DBGMCU_APB1_FZ bis! ;  \ DBG-DBGMCU_APB1_FZ_DBG_I2C2_SMBUS_TIMEOUT    DBG_J2C2_SMBUS_TIMEOUT
: DBG-DBGMCU_APB1_FZ_DBG_I2C3SMBUS_TIMEOUT   %1 23 lshift DBG-DBGMCU_APB1_FZ bis! ;  \ DBG-DBGMCU_APB1_FZ_DBG_I2C3SMBUS_TIMEOUT    DBG_J2C3SMBUS_TIMEOUT

\ DBG-DBGMCU_APB2_FZ (read-write)
: DBG-DBGMCU_APB2_FZ_DBG_TIM1_STOP   %1 0 lshift DBG-DBGMCU_APB2_FZ bis! ;  \ DBG-DBGMCU_APB2_FZ_DBG_TIM1_STOP    TIM1 counter stopped when core is
  halted
: DBG-DBGMCU_APB2_FZ_DBG_TIM9_STOP   %1 16 lshift DBG-DBGMCU_APB2_FZ bis! ;  \ DBG-DBGMCU_APB2_FZ_DBG_TIM9_STOP    TIM9 counter stopped when core is
  halted
: DBG-DBGMCU_APB2_FZ_DBG_TIM10_STOP   %1 17 lshift DBG-DBGMCU_APB2_FZ bis! ;  \ DBG-DBGMCU_APB2_FZ_DBG_TIM10_STOP    TIM10 counter stopped when core is
  halted
: DBG-DBGMCU_APB2_FZ_DBG_TIM11_STOP   %1 18 lshift DBG-DBGMCU_APB2_FZ bis! ;  \ DBG-DBGMCU_APB2_FZ_DBG_TIM11_STOP    TIM11 counter stopped when core is
  halted

\ EXTI-IMR (read-write)
: EXTI-IMR_MR0   %1 0 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR0    Interrupt Mask on line 0
: EXTI-IMR_MR1   %1 1 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR1    Interrupt Mask on line 1
: EXTI-IMR_MR2   %1 2 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR2    Interrupt Mask on line 2
: EXTI-IMR_MR3   %1 3 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR3    Interrupt Mask on line 3
: EXTI-IMR_MR4   %1 4 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR4    Interrupt Mask on line 4
: EXTI-IMR_MR5   %1 5 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR5    Interrupt Mask on line 5
: EXTI-IMR_MR6   %1 6 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR6    Interrupt Mask on line 6
: EXTI-IMR_MR7   %1 7 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR7    Interrupt Mask on line 7
: EXTI-IMR_MR8   %1 8 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR8    Interrupt Mask on line 8
: EXTI-IMR_MR9   %1 9 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR9    Interrupt Mask on line 9
: EXTI-IMR_MR10   %1 10 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR10    Interrupt Mask on line 10
: EXTI-IMR_MR11   %1 11 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR11    Interrupt Mask on line 11
: EXTI-IMR_MR12   %1 12 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR12    Interrupt Mask on line 12
: EXTI-IMR_MR13   %1 13 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR13    Interrupt Mask on line 13
: EXTI-IMR_MR14   %1 14 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR14    Interrupt Mask on line 14
: EXTI-IMR_MR15   %1 15 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR15    Interrupt Mask on line 15
: EXTI-IMR_MR16   %1 16 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR16    Interrupt Mask on line 16
: EXTI-IMR_MR17   %1 17 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR17    Interrupt Mask on line 17
: EXTI-IMR_MR18   %1 18 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR18    Interrupt Mask on line 18
: EXTI-IMR_MR19   %1 19 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR19    Interrupt Mask on line 19
: EXTI-IMR_MR20   %1 20 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR20    Interrupt Mask on line 20
: EXTI-IMR_MR21   %1 21 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR21    Interrupt Mask on line 21
: EXTI-IMR_MR22   %1 22 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR22    Interrupt Mask on line 22

\ EXTI-EMR (read-write)
: EXTI-EMR_MR0   %1 0 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR0    Event Mask on line 0
: EXTI-EMR_MR1   %1 1 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR1    Event Mask on line 1
: EXTI-EMR_MR2   %1 2 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR2    Event Mask on line 2
: EXTI-EMR_MR3   %1 3 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR3    Event Mask on line 3
: EXTI-EMR_MR4   %1 4 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR4    Event Mask on line 4
: EXTI-EMR_MR5   %1 5 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR5    Event Mask on line 5
: EXTI-EMR_MR6   %1 6 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR6    Event Mask on line 6
: EXTI-EMR_MR7   %1 7 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR7    Event Mask on line 7
: EXTI-EMR_MR8   %1 8 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR8    Event Mask on line 8
: EXTI-EMR_MR9   %1 9 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR9    Event Mask on line 9
: EXTI-EMR_MR10   %1 10 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR10    Event Mask on line 10
: EXTI-EMR_MR11   %1 11 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR11    Event Mask on line 11
: EXTI-EMR_MR12   %1 12 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR12    Event Mask on line 12
: EXTI-EMR_MR13   %1 13 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR13    Event Mask on line 13
: EXTI-EMR_MR14   %1 14 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR14    Event Mask on line 14
: EXTI-EMR_MR15   %1 15 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR15    Event Mask on line 15
: EXTI-EMR_MR16   %1 16 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR16    Event Mask on line 16
: EXTI-EMR_MR17   %1 17 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR17    Event Mask on line 17
: EXTI-EMR_MR18   %1 18 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR18    Event Mask on line 18
: EXTI-EMR_MR19   %1 19 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR19    Event Mask on line 19
: EXTI-EMR_MR20   %1 20 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR20    Event Mask on line 20
: EXTI-EMR_MR21   %1 21 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR21    Event Mask on line 21
: EXTI-EMR_MR22   %1 22 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR22    Event Mask on line 22

\ EXTI-RTSR (read-write)
: EXTI-RTSR_TR0   %1 0 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR0    Rising trigger event configuration of
  line 0
: EXTI-RTSR_TR1   %1 1 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR1    Rising trigger event configuration of
  line 1
: EXTI-RTSR_TR2   %1 2 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR2    Rising trigger event configuration of
  line 2
: EXTI-RTSR_TR3   %1 3 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR3    Rising trigger event configuration of
  line 3
: EXTI-RTSR_TR4   %1 4 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR4    Rising trigger event configuration of
  line 4
: EXTI-RTSR_TR5   %1 5 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR5    Rising trigger event configuration of
  line 5
: EXTI-RTSR_TR6   %1 6 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR6    Rising trigger event configuration of
  line 6
: EXTI-RTSR_TR7   %1 7 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR7    Rising trigger event configuration of
  line 7
: EXTI-RTSR_TR8   %1 8 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR8    Rising trigger event configuration of
  line 8
: EXTI-RTSR_TR9   %1 9 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR9    Rising trigger event configuration of
  line 9
: EXTI-RTSR_TR10   %1 10 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR10    Rising trigger event configuration of
  line 10
: EXTI-RTSR_TR11   %1 11 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR11    Rising trigger event configuration of
  line 11
: EXTI-RTSR_TR12   %1 12 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR12    Rising trigger event configuration of
  line 12
: EXTI-RTSR_TR13   %1 13 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR13    Rising trigger event configuration of
  line 13
: EXTI-RTSR_TR14   %1 14 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR14    Rising trigger event configuration of
  line 14
: EXTI-RTSR_TR15   %1 15 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR15    Rising trigger event configuration of
  line 15
: EXTI-RTSR_TR16   %1 16 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR16    Rising trigger event configuration of
  line 16
: EXTI-RTSR_TR17   %1 17 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR17    Rising trigger event configuration of
  line 17
: EXTI-RTSR_TR18   %1 18 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR18    Rising trigger event configuration of
  line 18
: EXTI-RTSR_TR19   %1 19 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR19    Rising trigger event configuration of
  line 19
: EXTI-RTSR_TR20   %1 20 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR20    Rising trigger event configuration of
  line 20
: EXTI-RTSR_TR21   %1 21 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR21    Rising trigger event configuration of
  line 21
: EXTI-RTSR_TR22   %1 22 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR22    Rising trigger event configuration of
  line 22

\ EXTI-FTSR (read-write)
: EXTI-FTSR_TR0   %1 0 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR0    Falling trigger event configuration of
  line 0
: EXTI-FTSR_TR1   %1 1 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR1    Falling trigger event configuration of
  line 1
: EXTI-FTSR_TR2   %1 2 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR2    Falling trigger event configuration of
  line 2
: EXTI-FTSR_TR3   %1 3 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR3    Falling trigger event configuration of
  line 3
: EXTI-FTSR_TR4   %1 4 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR4    Falling trigger event configuration of
  line 4
: EXTI-FTSR_TR5   %1 5 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR5    Falling trigger event configuration of
  line 5
: EXTI-FTSR_TR6   %1 6 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR6    Falling trigger event configuration of
  line 6
: EXTI-FTSR_TR7   %1 7 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR7    Falling trigger event configuration of
  line 7
: EXTI-FTSR_TR8   %1 8 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR8    Falling trigger event configuration of
  line 8
: EXTI-FTSR_TR9   %1 9 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR9    Falling trigger event configuration of
  line 9
: EXTI-FTSR_TR10   %1 10 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR10    Falling trigger event configuration of
  line 10
: EXTI-FTSR_TR11   %1 11 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR11    Falling trigger event configuration of
  line 11
: EXTI-FTSR_TR12   %1 12 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR12    Falling trigger event configuration of
  line 12
: EXTI-FTSR_TR13   %1 13 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR13    Falling trigger event configuration of
  line 13
: EXTI-FTSR_TR14   %1 14 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR14    Falling trigger event configuration of
  line 14
: EXTI-FTSR_TR15   %1 15 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR15    Falling trigger event configuration of
  line 15
: EXTI-FTSR_TR16   %1 16 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR16    Falling trigger event configuration of
  line 16
: EXTI-FTSR_TR17   %1 17 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR17    Falling trigger event configuration of
  line 17
: EXTI-FTSR_TR18   %1 18 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR18    Falling trigger event configuration of
  line 18
: EXTI-FTSR_TR19   %1 19 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR19    Falling trigger event configuration of
  line 19
: EXTI-FTSR_TR20   %1 20 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR20    Falling trigger event configuration of
  line 20
: EXTI-FTSR_TR21   %1 21 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR21    Falling trigger event configuration of
  line 21
: EXTI-FTSR_TR22   %1 22 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR22    Falling trigger event configuration of
  line 22

\ EXTI-SWIER (read-write)
: EXTI-SWIER_SWIER0   %1 0 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER0    Software Interrupt on line
  0
: EXTI-SWIER_SWIER1   %1 1 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER1    Software Interrupt on line
  1
: EXTI-SWIER_SWIER2   %1 2 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER2    Software Interrupt on line
  2
: EXTI-SWIER_SWIER3   %1 3 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER3    Software Interrupt on line
  3
: EXTI-SWIER_SWIER4   %1 4 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER4    Software Interrupt on line
  4
: EXTI-SWIER_SWIER5   %1 5 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER5    Software Interrupt on line
  5
: EXTI-SWIER_SWIER6   %1 6 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER6    Software Interrupt on line
  6
: EXTI-SWIER_SWIER7   %1 7 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER7    Software Interrupt on line
  7
: EXTI-SWIER_SWIER8   %1 8 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER8    Software Interrupt on line
  8
: EXTI-SWIER_SWIER9   %1 9 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER9    Software Interrupt on line
  9
: EXTI-SWIER_SWIER10   %1 10 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER10    Software Interrupt on line
  10
: EXTI-SWIER_SWIER11   %1 11 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER11    Software Interrupt on line
  11
: EXTI-SWIER_SWIER12   %1 12 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER12    Software Interrupt on line
  12
: EXTI-SWIER_SWIER13   %1 13 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER13    Software Interrupt on line
  13
: EXTI-SWIER_SWIER14   %1 14 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER14    Software Interrupt on line
  14
: EXTI-SWIER_SWIER15   %1 15 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER15    Software Interrupt on line
  15
: EXTI-SWIER_SWIER16   %1 16 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER16    Software Interrupt on line
  16
: EXTI-SWIER_SWIER17   %1 17 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER17    Software Interrupt on line
  17
: EXTI-SWIER_SWIER18   %1 18 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER18    Software Interrupt on line
  18
: EXTI-SWIER_SWIER19   %1 19 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER19    Software Interrupt on line
  19
: EXTI-SWIER_SWIER20   %1 20 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER20    Software Interrupt on line
  20
: EXTI-SWIER_SWIER21   %1 21 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER21    Software Interrupt on line
  21
: EXTI-SWIER_SWIER22   %1 22 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER22    Software Interrupt on line
  22

\ EXTI-PR (read-write)
: EXTI-PR_PR0   %1 0 lshift EXTI-PR bis! ;  \ EXTI-PR_PR0    Pending bit 0
: EXTI-PR_PR1   %1 1 lshift EXTI-PR bis! ;  \ EXTI-PR_PR1    Pending bit 1
: EXTI-PR_PR2   %1 2 lshift EXTI-PR bis! ;  \ EXTI-PR_PR2    Pending bit 2
: EXTI-PR_PR3   %1 3 lshift EXTI-PR bis! ;  \ EXTI-PR_PR3    Pending bit 3
: EXTI-PR_PR4   %1 4 lshift EXTI-PR bis! ;  \ EXTI-PR_PR4    Pending bit 4
: EXTI-PR_PR5   %1 5 lshift EXTI-PR bis! ;  \ EXTI-PR_PR5    Pending bit 5
: EXTI-PR_PR6   %1 6 lshift EXTI-PR bis! ;  \ EXTI-PR_PR6    Pending bit 6
: EXTI-PR_PR7   %1 7 lshift EXTI-PR bis! ;  \ EXTI-PR_PR7    Pending bit 7
: EXTI-PR_PR8   %1 8 lshift EXTI-PR bis! ;  \ EXTI-PR_PR8    Pending bit 8
: EXTI-PR_PR9   %1 9 lshift EXTI-PR bis! ;  \ EXTI-PR_PR9    Pending bit 9
: EXTI-PR_PR10   %1 10 lshift EXTI-PR bis! ;  \ EXTI-PR_PR10    Pending bit 10
: EXTI-PR_PR11   %1 11 lshift EXTI-PR bis! ;  \ EXTI-PR_PR11    Pending bit 11
: EXTI-PR_PR12   %1 12 lshift EXTI-PR bis! ;  \ EXTI-PR_PR12    Pending bit 12
: EXTI-PR_PR13   %1 13 lshift EXTI-PR bis! ;  \ EXTI-PR_PR13    Pending bit 13
: EXTI-PR_PR14   %1 14 lshift EXTI-PR bis! ;  \ EXTI-PR_PR14    Pending bit 14
: EXTI-PR_PR15   %1 15 lshift EXTI-PR bis! ;  \ EXTI-PR_PR15    Pending bit 15
: EXTI-PR_PR16   %1 16 lshift EXTI-PR bis! ;  \ EXTI-PR_PR16    Pending bit 16
: EXTI-PR_PR17   %1 17 lshift EXTI-PR bis! ;  \ EXTI-PR_PR17    Pending bit 17
: EXTI-PR_PR18   %1 18 lshift EXTI-PR bis! ;  \ EXTI-PR_PR18    Pending bit 18
: EXTI-PR_PR19   %1 19 lshift EXTI-PR bis! ;  \ EXTI-PR_PR19    Pending bit 19
: EXTI-PR_PR20   %1 20 lshift EXTI-PR bis! ;  \ EXTI-PR_PR20    Pending bit 20
: EXTI-PR_PR21   %1 21 lshift EXTI-PR bis! ;  \ EXTI-PR_PR21    Pending bit 21
: EXTI-PR_PR22   %1 22 lshift EXTI-PR bis! ;  \ EXTI-PR_PR22    Pending bit 22

\ FLASH-ACR ()
: FLASH-ACR_LATENCY   ( %XXX -- ) 0 lshift FLASH-ACR bis! ;  \ FLASH-ACR_LATENCY    Latency
: FLASH-ACR_PRFTEN   %1 8 lshift FLASH-ACR bis! ;  \ FLASH-ACR_PRFTEN    Prefetch enable
: FLASH-ACR_ICEN   %1 9 lshift FLASH-ACR bis! ;  \ FLASH-ACR_ICEN    Instruction cache enable
: FLASH-ACR_DCEN   %1 10 lshift FLASH-ACR bis! ;  \ FLASH-ACR_DCEN    Data cache enable
: FLASH-ACR_ICRST   %1 11 lshift FLASH-ACR bis! ;  \ FLASH-ACR_ICRST    Instruction cache reset
: FLASH-ACR_DCRST   %1 12 lshift FLASH-ACR bis! ;  \ FLASH-ACR_DCRST    Data cache reset

\ FLASH-KEYR (write-only)
: FLASH-KEYR_KEY   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift FLASH-KEYR bis! ;  \ FLASH-KEYR_KEY    FPEC key

\ FLASH-OPTKEYR (write-only)
: FLASH-OPTKEYR_OPTKEY   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift FLASH-OPTKEYR bis! ;  \ FLASH-OPTKEYR_OPTKEY    Option byte key

\ FLASH-SR ()
: FLASH-SR_EOP   %1 0 lshift FLASH-SR bis! ;  \ FLASH-SR_EOP    End of operation
: FLASH-SR_OPERR   %1 1 lshift FLASH-SR bis! ;  \ FLASH-SR_OPERR    Operation error
: FLASH-SR_WRPERR   %1 4 lshift FLASH-SR bis! ;  \ FLASH-SR_WRPERR    Write protection error
: FLASH-SR_PGAERR   %1 5 lshift FLASH-SR bis! ;  \ FLASH-SR_PGAERR    Programming alignment
  error
: FLASH-SR_PGPERR   %1 6 lshift FLASH-SR bis! ;  \ FLASH-SR_PGPERR    Programming parallelism
  error
: FLASH-SR_PGSERR   %1 7 lshift FLASH-SR bis! ;  \ FLASH-SR_PGSERR    Programming sequence error
: FLASH-SR_BSY   %1 16 lshift FLASH-SR bis! ;  \ FLASH-SR_BSY    Busy

\ FLASH-CR (read-write)
: FLASH-CR_PG   %1 0 lshift FLASH-CR bis! ;  \ FLASH-CR_PG    Programming
: FLASH-CR_SER   %1 1 lshift FLASH-CR bis! ;  \ FLASH-CR_SER    Sector Erase
: FLASH-CR_MER   %1 2 lshift FLASH-CR bis! ;  \ FLASH-CR_MER    Mass Erase
: FLASH-CR_SNB   ( %XXXX -- ) 3 lshift FLASH-CR bis! ;  \ FLASH-CR_SNB    Sector number
: FLASH-CR_PSIZE   ( %XX -- ) 8 lshift FLASH-CR bis! ;  \ FLASH-CR_PSIZE    Program size
: FLASH-CR_STRT   %1 16 lshift FLASH-CR bis! ;  \ FLASH-CR_STRT    Start
: FLASH-CR_EOPIE   %1 24 lshift FLASH-CR bis! ;  \ FLASH-CR_EOPIE    End of operation interrupt
  enable
: FLASH-CR_ERRIE   %1 25 lshift FLASH-CR bis! ;  \ FLASH-CR_ERRIE    Error interrupt enable
: FLASH-CR_LOCK   %1 31 lshift FLASH-CR bis! ;  \ FLASH-CR_LOCK    Lock

\ FLASH-OPTCR (read-write)
: FLASH-OPTCR_OPTLOCK   %1 0 lshift FLASH-OPTCR bis! ;  \ FLASH-OPTCR_OPTLOCK    Option lock
: FLASH-OPTCR_OPTSTRT   %1 1 lshift FLASH-OPTCR bis! ;  \ FLASH-OPTCR_OPTSTRT    Option start
: FLASH-OPTCR_BOR_LEV   ( %XX -- ) 2 lshift FLASH-OPTCR bis! ;  \ FLASH-OPTCR_BOR_LEV    BOR reset Level
: FLASH-OPTCR_WDG_SW   %1 5 lshift FLASH-OPTCR bis! ;  \ FLASH-OPTCR_WDG_SW    WDG_SW User option bytes
: FLASH-OPTCR_nRST_STOP   %1 6 lshift FLASH-OPTCR bis! ;  \ FLASH-OPTCR_nRST_STOP    nRST_STOP User option
  bytes
: FLASH-OPTCR_nRST_STDBY   %1 7 lshift FLASH-OPTCR bis! ;  \ FLASH-OPTCR_nRST_STDBY    nRST_STDBY User option
  bytes
: FLASH-OPTCR_RDP   ( %XXXXXXXX -- ) 8 lshift FLASH-OPTCR bis! ;  \ FLASH-OPTCR_RDP    Read protect
: FLASH-OPTCR_nWRP   ( %XXXXXXXXXXX -- ) 16 lshift FLASH-OPTCR bis! ;  \ FLASH-OPTCR_nWRP    Not write protect

\ IWDG-KR (write-only)
: IWDG-KR_KEY   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift IWDG-KR bis! ;  \ IWDG-KR_KEY    Key value

\ IWDG-PR (read-write)
: IWDG-PR_PR   ( %XXX -- ) 0 lshift IWDG-PR bis! ;  \ IWDG-PR_PR    Prescaler divider

\ IWDG-RLR (read-write)
: IWDG-RLR_RL   ( %XXXXXXXXXXX -- ) 0 lshift IWDG-RLR bis! ;  \ IWDG-RLR_RL    Watchdog counter reload
  value

\ IWDG-SR (read-only)
: IWDG-SR_RVU   %1 1 lshift IWDG-SR bis! ;  \ IWDG-SR_RVU    Watchdog counter reload value
  update
: IWDG-SR_PVU   %1 0 lshift IWDG-SR bis! ;  \ IWDG-SR_PVU    Watchdog prescaler value
  update

\ OTG_FS_DEVICE-FS_DCFG (read-write)
: OTG_FS_DEVICE-FS_DCFG_DSPD   ( %XX -- ) 0 lshift OTG_FS_DEVICE-FS_DCFG bis! ;  \ OTG_FS_DEVICE-FS_DCFG_DSPD    Device speed
: OTG_FS_DEVICE-FS_DCFG_NZLSOHSK   %1 2 lshift OTG_FS_DEVICE-FS_DCFG bis! ;  \ OTG_FS_DEVICE-FS_DCFG_NZLSOHSK    Non-zero-length status OUT
  handshake
: OTG_FS_DEVICE-FS_DCFG_DAD   ( %XXXXXXX -- ) 4 lshift OTG_FS_DEVICE-FS_DCFG bis! ;  \ OTG_FS_DEVICE-FS_DCFG_DAD    Device address
: OTG_FS_DEVICE-FS_DCFG_PFIVL   ( %XX -- ) 11 lshift OTG_FS_DEVICE-FS_DCFG bis! ;  \ OTG_FS_DEVICE-FS_DCFG_PFIVL    Periodic frame interval

\ OTG_FS_DEVICE-FS_DCTL ()
: OTG_FS_DEVICE-FS_DCTL_RWUSIG   %1 0 lshift OTG_FS_DEVICE-FS_DCTL bis! ;  \ OTG_FS_DEVICE-FS_DCTL_RWUSIG    Remote wakeup signaling
: OTG_FS_DEVICE-FS_DCTL_SDIS   %1 1 lshift OTG_FS_DEVICE-FS_DCTL bis! ;  \ OTG_FS_DEVICE-FS_DCTL_SDIS    Soft disconnect
: OTG_FS_DEVICE-FS_DCTL_GINSTS   %1 2 lshift OTG_FS_DEVICE-FS_DCTL bis! ;  \ OTG_FS_DEVICE-FS_DCTL_GINSTS    Global IN NAK status
: OTG_FS_DEVICE-FS_DCTL_GONSTS   %1 3 lshift OTG_FS_DEVICE-FS_DCTL bis! ;  \ OTG_FS_DEVICE-FS_DCTL_GONSTS    Global OUT NAK status
: OTG_FS_DEVICE-FS_DCTL_TCTL   ( %XXX -- ) 4 lshift OTG_FS_DEVICE-FS_DCTL bis! ;  \ OTG_FS_DEVICE-FS_DCTL_TCTL    Test control
: OTG_FS_DEVICE-FS_DCTL_SGINAK   %1 7 lshift OTG_FS_DEVICE-FS_DCTL bis! ;  \ OTG_FS_DEVICE-FS_DCTL_SGINAK    Set global IN NAK
: OTG_FS_DEVICE-FS_DCTL_CGINAK   %1 8 lshift OTG_FS_DEVICE-FS_DCTL bis! ;  \ OTG_FS_DEVICE-FS_DCTL_CGINAK    Clear global IN NAK
: OTG_FS_DEVICE-FS_DCTL_SGONAK   %1 9 lshift OTG_FS_DEVICE-FS_DCTL bis! ;  \ OTG_FS_DEVICE-FS_DCTL_SGONAK    Set global OUT NAK
: OTG_FS_DEVICE-FS_DCTL_CGONAK   %1 10 lshift OTG_FS_DEVICE-FS_DCTL bis! ;  \ OTG_FS_DEVICE-FS_DCTL_CGONAK    Clear global OUT NAK
: OTG_FS_DEVICE-FS_DCTL_POPRGDNE   %1 11 lshift OTG_FS_DEVICE-FS_DCTL bis! ;  \ OTG_FS_DEVICE-FS_DCTL_POPRGDNE    Power-on programming done

\ OTG_FS_DEVICE-FS_DSTS (read-only)
: OTG_FS_DEVICE-FS_DSTS_SUSPSTS   %1 0 lshift OTG_FS_DEVICE-FS_DSTS bis! ;  \ OTG_FS_DEVICE-FS_DSTS_SUSPSTS    Suspend status
: OTG_FS_DEVICE-FS_DSTS_ENUMSPD   ( %XX -- ) 1 lshift OTG_FS_DEVICE-FS_DSTS bis! ;  \ OTG_FS_DEVICE-FS_DSTS_ENUMSPD    Enumerated speed
: OTG_FS_DEVICE-FS_DSTS_EERR   %1 3 lshift OTG_FS_DEVICE-FS_DSTS bis! ;  \ OTG_FS_DEVICE-FS_DSTS_EERR    Erratic error
: OTG_FS_DEVICE-FS_DSTS_FNSOF   ( %XXXXXXXXXXXXXX -- ) 8 lshift OTG_FS_DEVICE-FS_DSTS bis! ;  \ OTG_FS_DEVICE-FS_DSTS_FNSOF    Frame number of the received
  SOF

\ OTG_FS_DEVICE-FS_DIEPMSK (read-write)
: OTG_FS_DEVICE-FS_DIEPMSK_XFRCM   %1 0 lshift OTG_FS_DEVICE-FS_DIEPMSK bis! ;  \ OTG_FS_DEVICE-FS_DIEPMSK_XFRCM    Transfer completed interrupt
  mask
: OTG_FS_DEVICE-FS_DIEPMSK_EPDM   %1 1 lshift OTG_FS_DEVICE-FS_DIEPMSK bis! ;  \ OTG_FS_DEVICE-FS_DIEPMSK_EPDM    Endpoint disabled interrupt
  mask
: OTG_FS_DEVICE-FS_DIEPMSK_TOM   %1 3 lshift OTG_FS_DEVICE-FS_DIEPMSK bis! ;  \ OTG_FS_DEVICE-FS_DIEPMSK_TOM    Timeout condition mask Non-isochronous
  endpoints
: OTG_FS_DEVICE-FS_DIEPMSK_ITTXFEMSK   %1 4 lshift OTG_FS_DEVICE-FS_DIEPMSK bis! ;  \ OTG_FS_DEVICE-FS_DIEPMSK_ITTXFEMSK    IN token received when TxFIFO empty
  mask
: OTG_FS_DEVICE-FS_DIEPMSK_INEPNMM   %1 5 lshift OTG_FS_DEVICE-FS_DIEPMSK bis! ;  \ OTG_FS_DEVICE-FS_DIEPMSK_INEPNMM    IN token received with EP mismatch
  mask
: OTG_FS_DEVICE-FS_DIEPMSK_INEPNEM   %1 6 lshift OTG_FS_DEVICE-FS_DIEPMSK bis! ;  \ OTG_FS_DEVICE-FS_DIEPMSK_INEPNEM    IN endpoint NAK effective
  mask

\ OTG_FS_DEVICE-FS_DOEPMSK (read-write)
: OTG_FS_DEVICE-FS_DOEPMSK_XFRCM   %1 0 lshift OTG_FS_DEVICE-FS_DOEPMSK bis! ;  \ OTG_FS_DEVICE-FS_DOEPMSK_XFRCM    Transfer completed interrupt
  mask
: OTG_FS_DEVICE-FS_DOEPMSK_EPDM   %1 1 lshift OTG_FS_DEVICE-FS_DOEPMSK bis! ;  \ OTG_FS_DEVICE-FS_DOEPMSK_EPDM    Endpoint disabled interrupt
  mask
: OTG_FS_DEVICE-FS_DOEPMSK_STUPM   %1 3 lshift OTG_FS_DEVICE-FS_DOEPMSK bis! ;  \ OTG_FS_DEVICE-FS_DOEPMSK_STUPM    SETUP phase done mask
: OTG_FS_DEVICE-FS_DOEPMSK_OTEPDM   %1 4 lshift OTG_FS_DEVICE-FS_DOEPMSK bis! ;  \ OTG_FS_DEVICE-FS_DOEPMSK_OTEPDM    OUT token received when endpoint
  disabled mask

\ OTG_FS_DEVICE-FS_DAINT (read-only)
: OTG_FS_DEVICE-FS_DAINT_IEPINT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift OTG_FS_DEVICE-FS_DAINT bis! ;  \ OTG_FS_DEVICE-FS_DAINT_IEPINT    IN endpoint interrupt bits
: OTG_FS_DEVICE-FS_DAINT_OEPINT   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift OTG_FS_DEVICE-FS_DAINT bis! ;  \ OTG_FS_DEVICE-FS_DAINT_OEPINT    OUT endpoint interrupt
  bits

\ OTG_FS_DEVICE-FS_DAINTMSK (read-write)
: OTG_FS_DEVICE-FS_DAINTMSK_IEPM   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift OTG_FS_DEVICE-FS_DAINTMSK bis! ;  \ OTG_FS_DEVICE-FS_DAINTMSK_IEPM    IN EP interrupt mask bits
: OTG_FS_DEVICE-FS_DAINTMSK_OEPINT   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift OTG_FS_DEVICE-FS_DAINTMSK bis! ;  \ OTG_FS_DEVICE-FS_DAINTMSK_OEPINT    OUT endpoint interrupt
  bits

\ OTG_FS_DEVICE-DVBUSDIS (read-write)
: OTG_FS_DEVICE-DVBUSDIS_VBUSDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift OTG_FS_DEVICE-DVBUSDIS bis! ;  \ OTG_FS_DEVICE-DVBUSDIS_VBUSDT    Device VBUS discharge time

\ OTG_FS_DEVICE-DVBUSPULSE (read-write)
: OTG_FS_DEVICE-DVBUSPULSE_DVBUSP   ( %XXXXXXXXXXX -- ) 0 lshift OTG_FS_DEVICE-DVBUSPULSE bis! ;  \ OTG_FS_DEVICE-DVBUSPULSE_DVBUSP    Device VBUS pulsing time

\ OTG_FS_DEVICE-DIEPEMPMSK (read-write)
: OTG_FS_DEVICE-DIEPEMPMSK_INEPTXFEM   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift OTG_FS_DEVICE-DIEPEMPMSK bis! ;  \ OTG_FS_DEVICE-DIEPEMPMSK_INEPTXFEM    IN EP Tx FIFO empty interrupt mask
  bits

\ OTG_FS_DEVICE-FS_DIEPCTL0 ()
: OTG_FS_DEVICE-FS_DIEPCTL0_MPSIZ   ( %XX -- ) 0 lshift OTG_FS_DEVICE-FS_DIEPCTL0 bis! ;  \ OTG_FS_DEVICE-FS_DIEPCTL0_MPSIZ    Maximum packet size
: OTG_FS_DEVICE-FS_DIEPCTL0_USBAEP   %1 15 lshift OTG_FS_DEVICE-FS_DIEPCTL0 bis! ;  \ OTG_FS_DEVICE-FS_DIEPCTL0_USBAEP    USB active endpoint
: OTG_FS_DEVICE-FS_DIEPCTL0_NAKSTS   %1 17 lshift OTG_FS_DEVICE-FS_DIEPCTL0 bis! ;  \ OTG_FS_DEVICE-FS_DIEPCTL0_NAKSTS    NAK status
: OTG_FS_DEVICE-FS_DIEPCTL0_EPTYP   ( %XX -- ) 18 lshift OTG_FS_DEVICE-FS_DIEPCTL0 bis! ;  \ OTG_FS_DEVICE-FS_DIEPCTL0_EPTYP    Endpoint type
: OTG_FS_DEVICE-FS_DIEPCTL0_STALL   %1 21 lshift OTG_FS_DEVICE-FS_DIEPCTL0 bis! ;  \ OTG_FS_DEVICE-FS_DIEPCTL0_STALL    STALL handshake
: OTG_FS_DEVICE-FS_DIEPCTL0_TXFNUM   ( %XXXX -- ) 22 lshift OTG_FS_DEVICE-FS_DIEPCTL0 bis! ;  \ OTG_FS_DEVICE-FS_DIEPCTL0_TXFNUM    TxFIFO number
: OTG_FS_DEVICE-FS_DIEPCTL0_CNAK   %1 26 lshift OTG_FS_DEVICE-FS_DIEPCTL0 bis! ;  \ OTG_FS_DEVICE-FS_DIEPCTL0_CNAK    Clear NAK
: OTG_FS_DEVICE-FS_DIEPCTL0_SNAK   %1 27 lshift OTG_FS_DEVICE-FS_DIEPCTL0 bis! ;  \ OTG_FS_DEVICE-FS_DIEPCTL0_SNAK    Set NAK
: OTG_FS_DEVICE-FS_DIEPCTL0_EPDIS   %1 30 lshift OTG_FS_DEVICE-FS_DIEPCTL0 bis! ;  \ OTG_FS_DEVICE-FS_DIEPCTL0_EPDIS    Endpoint disable
: OTG_FS_DEVICE-FS_DIEPCTL0_EPENA   %1 31 lshift OTG_FS_DEVICE-FS_DIEPCTL0 bis! ;  \ OTG_FS_DEVICE-FS_DIEPCTL0_EPENA    Endpoint enable

\ OTG_FS_DEVICE-DIEPCTL1 ()
: OTG_FS_DEVICE-DIEPCTL1_EPENA   %1 31 lshift OTG_FS_DEVICE-DIEPCTL1 bis! ;  \ OTG_FS_DEVICE-DIEPCTL1_EPENA    EPENA
: OTG_FS_DEVICE-DIEPCTL1_EPDIS   %1 30 lshift OTG_FS_DEVICE-DIEPCTL1 bis! ;  \ OTG_FS_DEVICE-DIEPCTL1_EPDIS    EPDIS
: OTG_FS_DEVICE-DIEPCTL1_SODDFRM_SD1PID   %1 29 lshift OTG_FS_DEVICE-DIEPCTL1 bis! ;  \ OTG_FS_DEVICE-DIEPCTL1_SODDFRM_SD1PID    SODDFRM/SD1PID
: OTG_FS_DEVICE-DIEPCTL1_SD0PID_SEVNFRM   %1 28 lshift OTG_FS_DEVICE-DIEPCTL1 bis! ;  \ OTG_FS_DEVICE-DIEPCTL1_SD0PID_SEVNFRM    SD0PID/SEVNFRM
: OTG_FS_DEVICE-DIEPCTL1_SNAK   %1 27 lshift OTG_FS_DEVICE-DIEPCTL1 bis! ;  \ OTG_FS_DEVICE-DIEPCTL1_SNAK    SNAK
: OTG_FS_DEVICE-DIEPCTL1_CNAK   %1 26 lshift OTG_FS_DEVICE-DIEPCTL1 bis! ;  \ OTG_FS_DEVICE-DIEPCTL1_CNAK    CNAK
: OTG_FS_DEVICE-DIEPCTL1_TXFNUM   ( %XXXX -- ) 22 lshift OTG_FS_DEVICE-DIEPCTL1 bis! ;  \ OTG_FS_DEVICE-DIEPCTL1_TXFNUM    TXFNUM
: OTG_FS_DEVICE-DIEPCTL1_Stall   %1 21 lshift OTG_FS_DEVICE-DIEPCTL1 bis! ;  \ OTG_FS_DEVICE-DIEPCTL1_Stall    Stall
: OTG_FS_DEVICE-DIEPCTL1_EPTYP   ( %XX -- ) 18 lshift OTG_FS_DEVICE-DIEPCTL1 bis! ;  \ OTG_FS_DEVICE-DIEPCTL1_EPTYP    EPTYP
: OTG_FS_DEVICE-DIEPCTL1_NAKSTS   %1 17 lshift OTG_FS_DEVICE-DIEPCTL1 bis! ;  \ OTG_FS_DEVICE-DIEPCTL1_NAKSTS    NAKSTS
: OTG_FS_DEVICE-DIEPCTL1_EONUM_DPID   %1 16 lshift OTG_FS_DEVICE-DIEPCTL1 bis! ;  \ OTG_FS_DEVICE-DIEPCTL1_EONUM_DPID    EONUM/DPID
: OTG_FS_DEVICE-DIEPCTL1_USBAEP   %1 15 lshift OTG_FS_DEVICE-DIEPCTL1 bis! ;  \ OTG_FS_DEVICE-DIEPCTL1_USBAEP    USBAEP
: OTG_FS_DEVICE-DIEPCTL1_MPSIZ  0 lshift OTG_FS_DEVICE-DIEPCTL1 bis! ;  \ OTG_FS_DEVICE-DIEPCTL1_MPSIZ    MPSIZ

\ OTG_FS_DEVICE-DIEPCTL2 ()
: OTG_FS_DEVICE-DIEPCTL2_EPENA   %1 31 lshift OTG_FS_DEVICE-DIEPCTL2 bis! ;  \ OTG_FS_DEVICE-DIEPCTL2_EPENA    EPENA
: OTG_FS_DEVICE-DIEPCTL2_EPDIS   %1 30 lshift OTG_FS_DEVICE-DIEPCTL2 bis! ;  \ OTG_FS_DEVICE-DIEPCTL2_EPDIS    EPDIS
: OTG_FS_DEVICE-DIEPCTL2_SODDFRM   %1 29 lshift OTG_FS_DEVICE-DIEPCTL2 bis! ;  \ OTG_FS_DEVICE-DIEPCTL2_SODDFRM    SODDFRM
: OTG_FS_DEVICE-DIEPCTL2_SD0PID_SEVNFRM   %1 28 lshift OTG_FS_DEVICE-DIEPCTL2 bis! ;  \ OTG_FS_DEVICE-DIEPCTL2_SD0PID_SEVNFRM    SD0PID/SEVNFRM
: OTG_FS_DEVICE-DIEPCTL2_SNAK   %1 27 lshift OTG_FS_DEVICE-DIEPCTL2 bis! ;  \ OTG_FS_DEVICE-DIEPCTL2_SNAK    SNAK
: OTG_FS_DEVICE-DIEPCTL2_CNAK   %1 26 lshift OTG_FS_DEVICE-DIEPCTL2 bis! ;  \ OTG_FS_DEVICE-DIEPCTL2_CNAK    CNAK
: OTG_FS_DEVICE-DIEPCTL2_TXFNUM   ( %XXXX -- ) 22 lshift OTG_FS_DEVICE-DIEPCTL2 bis! ;  \ OTG_FS_DEVICE-DIEPCTL2_TXFNUM    TXFNUM
: OTG_FS_DEVICE-DIEPCTL2_Stall   %1 21 lshift OTG_FS_DEVICE-DIEPCTL2 bis! ;  \ OTG_FS_DEVICE-DIEPCTL2_Stall    Stall
: OTG_FS_DEVICE-DIEPCTL2_EPTYP   ( %XX -- ) 18 lshift OTG_FS_DEVICE-DIEPCTL2 bis! ;  \ OTG_FS_DEVICE-DIEPCTL2_EPTYP    EPTYP
: OTG_FS_DEVICE-DIEPCTL2_NAKSTS   %1 17 lshift OTG_FS_DEVICE-DIEPCTL2 bis! ;  \ OTG_FS_DEVICE-DIEPCTL2_NAKSTS    NAKSTS
: OTG_FS_DEVICE-DIEPCTL2_EONUM_DPID   %1 16 lshift OTG_FS_DEVICE-DIEPCTL2 bis! ;  \ OTG_FS_DEVICE-DIEPCTL2_EONUM_DPID    EONUM/DPID
: OTG_FS_DEVICE-DIEPCTL2_USBAEP   %1 15 lshift OTG_FS_DEVICE-DIEPCTL2 bis! ;  \ OTG_FS_DEVICE-DIEPCTL2_USBAEP    USBAEP
: OTG_FS_DEVICE-DIEPCTL2_MPSIZ  0 lshift OTG_FS_DEVICE-DIEPCTL2 bis! ;  \ OTG_FS_DEVICE-DIEPCTL2_MPSIZ    MPSIZ

\ OTG_FS_DEVICE-DIEPCTL3 ()
: OTG_FS_DEVICE-DIEPCTL3_EPENA   %1 31 lshift OTG_FS_DEVICE-DIEPCTL3 bis! ;  \ OTG_FS_DEVICE-DIEPCTL3_EPENA    EPENA
: OTG_FS_DEVICE-DIEPCTL3_EPDIS   %1 30 lshift OTG_FS_DEVICE-DIEPCTL3 bis! ;  \ OTG_FS_DEVICE-DIEPCTL3_EPDIS    EPDIS
: OTG_FS_DEVICE-DIEPCTL3_SODDFRM   %1 29 lshift OTG_FS_DEVICE-DIEPCTL3 bis! ;  \ OTG_FS_DEVICE-DIEPCTL3_SODDFRM    SODDFRM
: OTG_FS_DEVICE-DIEPCTL3_SD0PID_SEVNFRM   %1 28 lshift OTG_FS_DEVICE-DIEPCTL3 bis! ;  \ OTG_FS_DEVICE-DIEPCTL3_SD0PID_SEVNFRM    SD0PID/SEVNFRM
: OTG_FS_DEVICE-DIEPCTL3_SNAK   %1 27 lshift OTG_FS_DEVICE-DIEPCTL3 bis! ;  \ OTG_FS_DEVICE-DIEPCTL3_SNAK    SNAK
: OTG_FS_DEVICE-DIEPCTL3_CNAK   %1 26 lshift OTG_FS_DEVICE-DIEPCTL3 bis! ;  \ OTG_FS_DEVICE-DIEPCTL3_CNAK    CNAK
: OTG_FS_DEVICE-DIEPCTL3_TXFNUM   ( %XXXX -- ) 22 lshift OTG_FS_DEVICE-DIEPCTL3 bis! ;  \ OTG_FS_DEVICE-DIEPCTL3_TXFNUM    TXFNUM
: OTG_FS_DEVICE-DIEPCTL3_Stall   %1 21 lshift OTG_FS_DEVICE-DIEPCTL3 bis! ;  \ OTG_FS_DEVICE-DIEPCTL3_Stall    Stall
: OTG_FS_DEVICE-DIEPCTL3_EPTYP   ( %XX -- ) 18 lshift OTG_FS_DEVICE-DIEPCTL3 bis! ;  \ OTG_FS_DEVICE-DIEPCTL3_EPTYP    EPTYP
: OTG_FS_DEVICE-DIEPCTL3_NAKSTS   %1 17 lshift OTG_FS_DEVICE-DIEPCTL3 bis! ;  \ OTG_FS_DEVICE-DIEPCTL3_NAKSTS    NAKSTS
: OTG_FS_DEVICE-DIEPCTL3_EONUM_DPID   %1 16 lshift OTG_FS_DEVICE-DIEPCTL3 bis! ;  \ OTG_FS_DEVICE-DIEPCTL3_EONUM_DPID    EONUM/DPID
: OTG_FS_DEVICE-DIEPCTL3_USBAEP   %1 15 lshift OTG_FS_DEVICE-DIEPCTL3 bis! ;  \ OTG_FS_DEVICE-DIEPCTL3_USBAEP    USBAEP
: OTG_FS_DEVICE-DIEPCTL3_MPSIZ  0 lshift OTG_FS_DEVICE-DIEPCTL3 bis! ;  \ OTG_FS_DEVICE-DIEPCTL3_MPSIZ    MPSIZ

\ OTG_FS_DEVICE-DOEPCTL0 ()
: OTG_FS_DEVICE-DOEPCTL0_EPENA   %1 31 lshift OTG_FS_DEVICE-DOEPCTL0 bis! ;  \ OTG_FS_DEVICE-DOEPCTL0_EPENA    EPENA
: OTG_FS_DEVICE-DOEPCTL0_EPDIS   %1 30 lshift OTG_FS_DEVICE-DOEPCTL0 bis! ;  \ OTG_FS_DEVICE-DOEPCTL0_EPDIS    EPDIS
: OTG_FS_DEVICE-DOEPCTL0_SNAK   %1 27 lshift OTG_FS_DEVICE-DOEPCTL0 bis! ;  \ OTG_FS_DEVICE-DOEPCTL0_SNAK    SNAK
: OTG_FS_DEVICE-DOEPCTL0_CNAK   %1 26 lshift OTG_FS_DEVICE-DOEPCTL0 bis! ;  \ OTG_FS_DEVICE-DOEPCTL0_CNAK    CNAK
: OTG_FS_DEVICE-DOEPCTL0_Stall   %1 21 lshift OTG_FS_DEVICE-DOEPCTL0 bis! ;  \ OTG_FS_DEVICE-DOEPCTL0_Stall    Stall
: OTG_FS_DEVICE-DOEPCTL0_SNPM   %1 20 lshift OTG_FS_DEVICE-DOEPCTL0 bis! ;  \ OTG_FS_DEVICE-DOEPCTL0_SNPM    SNPM
: OTG_FS_DEVICE-DOEPCTL0_EPTYP   ( %XX -- ) 18 lshift OTG_FS_DEVICE-DOEPCTL0 bis! ;  \ OTG_FS_DEVICE-DOEPCTL0_EPTYP    EPTYP
: OTG_FS_DEVICE-DOEPCTL0_NAKSTS   %1 17 lshift OTG_FS_DEVICE-DOEPCTL0 bis! ;  \ OTG_FS_DEVICE-DOEPCTL0_NAKSTS    NAKSTS
: OTG_FS_DEVICE-DOEPCTL0_USBAEP   %1 15 lshift OTG_FS_DEVICE-DOEPCTL0 bis! ;  \ OTG_FS_DEVICE-DOEPCTL0_USBAEP    USBAEP
: OTG_FS_DEVICE-DOEPCTL0_MPSIZ   ( %XX -- ) 0 lshift OTG_FS_DEVICE-DOEPCTL0 bis! ;  \ OTG_FS_DEVICE-DOEPCTL0_MPSIZ    MPSIZ

\ OTG_FS_DEVICE-DOEPCTL1 ()
: OTG_FS_DEVICE-DOEPCTL1_EPENA   %1 31 lshift OTG_FS_DEVICE-DOEPCTL1 bis! ;  \ OTG_FS_DEVICE-DOEPCTL1_EPENA    EPENA
: OTG_FS_DEVICE-DOEPCTL1_EPDIS   %1 30 lshift OTG_FS_DEVICE-DOEPCTL1 bis! ;  \ OTG_FS_DEVICE-DOEPCTL1_EPDIS    EPDIS
: OTG_FS_DEVICE-DOEPCTL1_SODDFRM   %1 29 lshift OTG_FS_DEVICE-DOEPCTL1 bis! ;  \ OTG_FS_DEVICE-DOEPCTL1_SODDFRM    SODDFRM
: OTG_FS_DEVICE-DOEPCTL1_SD0PID_SEVNFRM   %1 28 lshift OTG_FS_DEVICE-DOEPCTL1 bis! ;  \ OTG_FS_DEVICE-DOEPCTL1_SD0PID_SEVNFRM    SD0PID/SEVNFRM
: OTG_FS_DEVICE-DOEPCTL1_SNAK   %1 27 lshift OTG_FS_DEVICE-DOEPCTL1 bis! ;  \ OTG_FS_DEVICE-DOEPCTL1_SNAK    SNAK
: OTG_FS_DEVICE-DOEPCTL1_CNAK   %1 26 lshift OTG_FS_DEVICE-DOEPCTL1 bis! ;  \ OTG_FS_DEVICE-DOEPCTL1_CNAK    CNAK
: OTG_FS_DEVICE-DOEPCTL1_Stall   %1 21 lshift OTG_FS_DEVICE-DOEPCTL1 bis! ;  \ OTG_FS_DEVICE-DOEPCTL1_Stall    Stall
: OTG_FS_DEVICE-DOEPCTL1_SNPM   %1 20 lshift OTG_FS_DEVICE-DOEPCTL1 bis! ;  \ OTG_FS_DEVICE-DOEPCTL1_SNPM    SNPM
: OTG_FS_DEVICE-DOEPCTL1_EPTYP   ( %XX -- ) 18 lshift OTG_FS_DEVICE-DOEPCTL1 bis! ;  \ OTG_FS_DEVICE-DOEPCTL1_EPTYP    EPTYP
: OTG_FS_DEVICE-DOEPCTL1_NAKSTS   %1 17 lshift OTG_FS_DEVICE-DOEPCTL1 bis! ;  \ OTG_FS_DEVICE-DOEPCTL1_NAKSTS    NAKSTS
: OTG_FS_DEVICE-DOEPCTL1_EONUM_DPID   %1 16 lshift OTG_FS_DEVICE-DOEPCTL1 bis! ;  \ OTG_FS_DEVICE-DOEPCTL1_EONUM_DPID    EONUM/DPID
: OTG_FS_DEVICE-DOEPCTL1_USBAEP   %1 15 lshift OTG_FS_DEVICE-DOEPCTL1 bis! ;  \ OTG_FS_DEVICE-DOEPCTL1_USBAEP    USBAEP
: OTG_FS_DEVICE-DOEPCTL1_MPSIZ  0 lshift OTG_FS_DEVICE-DOEPCTL1 bis! ;  \ OTG_FS_DEVICE-DOEPCTL1_MPSIZ    MPSIZ

\ OTG_FS_DEVICE-DOEPCTL2 ()
: OTG_FS_DEVICE-DOEPCTL2_EPENA   %1 31 lshift OTG_FS_DEVICE-DOEPCTL2 bis! ;  \ OTG_FS_DEVICE-DOEPCTL2_EPENA    EPENA
: OTG_FS_DEVICE-DOEPCTL2_EPDIS   %1 30 lshift OTG_FS_DEVICE-DOEPCTL2 bis! ;  \ OTG_FS_DEVICE-DOEPCTL2_EPDIS    EPDIS
: OTG_FS_DEVICE-DOEPCTL2_SODDFRM   %1 29 lshift OTG_FS_DEVICE-DOEPCTL2 bis! ;  \ OTG_FS_DEVICE-DOEPCTL2_SODDFRM    SODDFRM
: OTG_FS_DEVICE-DOEPCTL2_SD0PID_SEVNFRM   %1 28 lshift OTG_FS_DEVICE-DOEPCTL2 bis! ;  \ OTG_FS_DEVICE-DOEPCTL2_SD0PID_SEVNFRM    SD0PID/SEVNFRM
: OTG_FS_DEVICE-DOEPCTL2_SNAK   %1 27 lshift OTG_FS_DEVICE-DOEPCTL2 bis! ;  \ OTG_FS_DEVICE-DOEPCTL2_SNAK    SNAK
: OTG_FS_DEVICE-DOEPCTL2_CNAK   %1 26 lshift OTG_FS_DEVICE-DOEPCTL2 bis! ;  \ OTG_FS_DEVICE-DOEPCTL2_CNAK    CNAK
: OTG_FS_DEVICE-DOEPCTL2_Stall   %1 21 lshift OTG_FS_DEVICE-DOEPCTL2 bis! ;  \ OTG_FS_DEVICE-DOEPCTL2_Stall    Stall
: OTG_FS_DEVICE-DOEPCTL2_SNPM   %1 20 lshift OTG_FS_DEVICE-DOEPCTL2 bis! ;  \ OTG_FS_DEVICE-DOEPCTL2_SNPM    SNPM
: OTG_FS_DEVICE-DOEPCTL2_EPTYP   ( %XX -- ) 18 lshift OTG_FS_DEVICE-DOEPCTL2 bis! ;  \ OTG_FS_DEVICE-DOEPCTL2_EPTYP    EPTYP
: OTG_FS_DEVICE-DOEPCTL2_NAKSTS   %1 17 lshift OTG_FS_DEVICE-DOEPCTL2 bis! ;  \ OTG_FS_DEVICE-DOEPCTL2_NAKSTS    NAKSTS
: OTG_FS_DEVICE-DOEPCTL2_EONUM_DPID   %1 16 lshift OTG_FS_DEVICE-DOEPCTL2 bis! ;  \ OTG_FS_DEVICE-DOEPCTL2_EONUM_DPID    EONUM/DPID
: OTG_FS_DEVICE-DOEPCTL2_USBAEP   %1 15 lshift OTG_FS_DEVICE-DOEPCTL2 bis! ;  \ OTG_FS_DEVICE-DOEPCTL2_USBAEP    USBAEP
: OTG_FS_DEVICE-DOEPCTL2_MPSIZ  0 lshift OTG_FS_DEVICE-DOEPCTL2 bis! ;  \ OTG_FS_DEVICE-DOEPCTL2_MPSIZ    MPSIZ

\ OTG_FS_DEVICE-DOEPCTL3 ()
: OTG_FS_DEVICE-DOEPCTL3_EPENA   %1 31 lshift OTG_FS_DEVICE-DOEPCTL3 bis! ;  \ OTG_FS_DEVICE-DOEPCTL3_EPENA    EPENA
: OTG_FS_DEVICE-DOEPCTL3_EPDIS   %1 30 lshift OTG_FS_DEVICE-DOEPCTL3 bis! ;  \ OTG_FS_DEVICE-DOEPCTL3_EPDIS    EPDIS
: OTG_FS_DEVICE-DOEPCTL3_SODDFRM   %1 29 lshift OTG_FS_DEVICE-DOEPCTL3 bis! ;  \ OTG_FS_DEVICE-DOEPCTL3_SODDFRM    SODDFRM
: OTG_FS_DEVICE-DOEPCTL3_SD0PID_SEVNFRM   %1 28 lshift OTG_FS_DEVICE-DOEPCTL3 bis! ;  \ OTG_FS_DEVICE-DOEPCTL3_SD0PID_SEVNFRM    SD0PID/SEVNFRM
: OTG_FS_DEVICE-DOEPCTL3_SNAK   %1 27 lshift OTG_FS_DEVICE-DOEPCTL3 bis! ;  \ OTG_FS_DEVICE-DOEPCTL3_SNAK    SNAK
: OTG_FS_DEVICE-DOEPCTL3_CNAK   %1 26 lshift OTG_FS_DEVICE-DOEPCTL3 bis! ;  \ OTG_FS_DEVICE-DOEPCTL3_CNAK    CNAK
: OTG_FS_DEVICE-DOEPCTL3_Stall   %1 21 lshift OTG_FS_DEVICE-DOEPCTL3 bis! ;  \ OTG_FS_DEVICE-DOEPCTL3_Stall    Stall
: OTG_FS_DEVICE-DOEPCTL3_SNPM   %1 20 lshift OTG_FS_DEVICE-DOEPCTL3 bis! ;  \ OTG_FS_DEVICE-DOEPCTL3_SNPM    SNPM
: OTG_FS_DEVICE-DOEPCTL3_EPTYP   ( %XX -- ) 18 lshift OTG_FS_DEVICE-DOEPCTL3 bis! ;  \ OTG_FS_DEVICE-DOEPCTL3_EPTYP    EPTYP
: OTG_FS_DEVICE-DOEPCTL3_NAKSTS   %1 17 lshift OTG_FS_DEVICE-DOEPCTL3 bis! ;  \ OTG_FS_DEVICE-DOEPCTL3_NAKSTS    NAKSTS
: OTG_FS_DEVICE-DOEPCTL3_EONUM_DPID   %1 16 lshift OTG_FS_DEVICE-DOEPCTL3 bis! ;  \ OTG_FS_DEVICE-DOEPCTL3_EONUM_DPID    EONUM/DPID
: OTG_FS_DEVICE-DOEPCTL3_USBAEP   %1 15 lshift OTG_FS_DEVICE-DOEPCTL3 bis! ;  \ OTG_FS_DEVICE-DOEPCTL3_USBAEP    USBAEP
: OTG_FS_DEVICE-DOEPCTL3_MPSIZ  0 lshift OTG_FS_DEVICE-DOEPCTL3 bis! ;  \ OTG_FS_DEVICE-DOEPCTL3_MPSIZ    MPSIZ

\ OTG_FS_DEVICE-DIEPINT0 ()
: OTG_FS_DEVICE-DIEPINT0_TXFE   %1 7 lshift OTG_FS_DEVICE-DIEPINT0 bis! ;  \ OTG_FS_DEVICE-DIEPINT0_TXFE    TXFE
: OTG_FS_DEVICE-DIEPINT0_INEPNE   %1 6 lshift OTG_FS_DEVICE-DIEPINT0 bis! ;  \ OTG_FS_DEVICE-DIEPINT0_INEPNE    INEPNE
: OTG_FS_DEVICE-DIEPINT0_ITTXFE   %1 4 lshift OTG_FS_DEVICE-DIEPINT0 bis! ;  \ OTG_FS_DEVICE-DIEPINT0_ITTXFE    ITTXFE
: OTG_FS_DEVICE-DIEPINT0_TOC   %1 3 lshift OTG_FS_DEVICE-DIEPINT0 bis! ;  \ OTG_FS_DEVICE-DIEPINT0_TOC    TOC
: OTG_FS_DEVICE-DIEPINT0_EPDISD   %1 1 lshift OTG_FS_DEVICE-DIEPINT0 bis! ;  \ OTG_FS_DEVICE-DIEPINT0_EPDISD    EPDISD
: OTG_FS_DEVICE-DIEPINT0_XFRC   %1 0 lshift OTG_FS_DEVICE-DIEPINT0 bis! ;  \ OTG_FS_DEVICE-DIEPINT0_XFRC    XFRC

\ OTG_FS_DEVICE-DIEPINT1 ()
: OTG_FS_DEVICE-DIEPINT1_TXFE   %1 7 lshift OTG_FS_DEVICE-DIEPINT1 bis! ;  \ OTG_FS_DEVICE-DIEPINT1_TXFE    TXFE
: OTG_FS_DEVICE-DIEPINT1_INEPNE   %1 6 lshift OTG_FS_DEVICE-DIEPINT1 bis! ;  \ OTG_FS_DEVICE-DIEPINT1_INEPNE    INEPNE
: OTG_FS_DEVICE-DIEPINT1_ITTXFE   %1 4 lshift OTG_FS_DEVICE-DIEPINT1 bis! ;  \ OTG_FS_DEVICE-DIEPINT1_ITTXFE    ITTXFE
: OTG_FS_DEVICE-DIEPINT1_TOC   %1 3 lshift OTG_FS_DEVICE-DIEPINT1 bis! ;  \ OTG_FS_DEVICE-DIEPINT1_TOC    TOC
: OTG_FS_DEVICE-DIEPINT1_EPDISD   %1 1 lshift OTG_FS_DEVICE-DIEPINT1 bis! ;  \ OTG_FS_DEVICE-DIEPINT1_EPDISD    EPDISD
: OTG_FS_DEVICE-DIEPINT1_XFRC   %1 0 lshift OTG_FS_DEVICE-DIEPINT1 bis! ;  \ OTG_FS_DEVICE-DIEPINT1_XFRC    XFRC

\ OTG_FS_DEVICE-DIEPINT2 ()
: OTG_FS_DEVICE-DIEPINT2_TXFE   %1 7 lshift OTG_FS_DEVICE-DIEPINT2 bis! ;  \ OTG_FS_DEVICE-DIEPINT2_TXFE    TXFE
: OTG_FS_DEVICE-DIEPINT2_INEPNE   %1 6 lshift OTG_FS_DEVICE-DIEPINT2 bis! ;  \ OTG_FS_DEVICE-DIEPINT2_INEPNE    INEPNE
: OTG_FS_DEVICE-DIEPINT2_ITTXFE   %1 4 lshift OTG_FS_DEVICE-DIEPINT2 bis! ;  \ OTG_FS_DEVICE-DIEPINT2_ITTXFE    ITTXFE
: OTG_FS_DEVICE-DIEPINT2_TOC   %1 3 lshift OTG_FS_DEVICE-DIEPINT2 bis! ;  \ OTG_FS_DEVICE-DIEPINT2_TOC    TOC
: OTG_FS_DEVICE-DIEPINT2_EPDISD   %1 1 lshift OTG_FS_DEVICE-DIEPINT2 bis! ;  \ OTG_FS_DEVICE-DIEPINT2_EPDISD    EPDISD
: OTG_FS_DEVICE-DIEPINT2_XFRC   %1 0 lshift OTG_FS_DEVICE-DIEPINT2 bis! ;  \ OTG_FS_DEVICE-DIEPINT2_XFRC    XFRC

\ OTG_FS_DEVICE-DIEPINT3 ()
: OTG_FS_DEVICE-DIEPINT3_TXFE   %1 7 lshift OTG_FS_DEVICE-DIEPINT3 bis! ;  \ OTG_FS_DEVICE-DIEPINT3_TXFE    TXFE
: OTG_FS_DEVICE-DIEPINT3_INEPNE   %1 6 lshift OTG_FS_DEVICE-DIEPINT3 bis! ;  \ OTG_FS_DEVICE-DIEPINT3_INEPNE    INEPNE
: OTG_FS_DEVICE-DIEPINT3_ITTXFE   %1 4 lshift OTG_FS_DEVICE-DIEPINT3 bis! ;  \ OTG_FS_DEVICE-DIEPINT3_ITTXFE    ITTXFE
: OTG_FS_DEVICE-DIEPINT3_TOC   %1 3 lshift OTG_FS_DEVICE-DIEPINT3 bis! ;  \ OTG_FS_DEVICE-DIEPINT3_TOC    TOC
: OTG_FS_DEVICE-DIEPINT3_EPDISD   %1 1 lshift OTG_FS_DEVICE-DIEPINT3 bis! ;  \ OTG_FS_DEVICE-DIEPINT3_EPDISD    EPDISD
: OTG_FS_DEVICE-DIEPINT3_XFRC   %1 0 lshift OTG_FS_DEVICE-DIEPINT3 bis! ;  \ OTG_FS_DEVICE-DIEPINT3_XFRC    XFRC

\ OTG_FS_DEVICE-DOEPINT0 (read-write)
: OTG_FS_DEVICE-DOEPINT0_B2BSTUP   %1 6 lshift OTG_FS_DEVICE-DOEPINT0 bis! ;  \ OTG_FS_DEVICE-DOEPINT0_B2BSTUP    B2BSTUP
: OTG_FS_DEVICE-DOEPINT0_OTEPDIS   %1 4 lshift OTG_FS_DEVICE-DOEPINT0 bis! ;  \ OTG_FS_DEVICE-DOEPINT0_OTEPDIS    OTEPDIS
: OTG_FS_DEVICE-DOEPINT0_STUP   %1 3 lshift OTG_FS_DEVICE-DOEPINT0 bis! ;  \ OTG_FS_DEVICE-DOEPINT0_STUP    STUP
: OTG_FS_DEVICE-DOEPINT0_EPDISD   %1 1 lshift OTG_FS_DEVICE-DOEPINT0 bis! ;  \ OTG_FS_DEVICE-DOEPINT0_EPDISD    EPDISD
: OTG_FS_DEVICE-DOEPINT0_XFRC   %1 0 lshift OTG_FS_DEVICE-DOEPINT0 bis! ;  \ OTG_FS_DEVICE-DOEPINT0_XFRC    XFRC

\ OTG_FS_DEVICE-DOEPINT1 (read-write)
: OTG_FS_DEVICE-DOEPINT1_B2BSTUP   %1 6 lshift OTG_FS_DEVICE-DOEPINT1 bis! ;  \ OTG_FS_DEVICE-DOEPINT1_B2BSTUP    B2BSTUP
: OTG_FS_DEVICE-DOEPINT1_OTEPDIS   %1 4 lshift OTG_FS_DEVICE-DOEPINT1 bis! ;  \ OTG_FS_DEVICE-DOEPINT1_OTEPDIS    OTEPDIS
: OTG_FS_DEVICE-DOEPINT1_STUP   %1 3 lshift OTG_FS_DEVICE-DOEPINT1 bis! ;  \ OTG_FS_DEVICE-DOEPINT1_STUP    STUP
: OTG_FS_DEVICE-DOEPINT1_EPDISD   %1 1 lshift OTG_FS_DEVICE-DOEPINT1 bis! ;  \ OTG_FS_DEVICE-DOEPINT1_EPDISD    EPDISD
: OTG_FS_DEVICE-DOEPINT1_XFRC   %1 0 lshift OTG_FS_DEVICE-DOEPINT1 bis! ;  \ OTG_FS_DEVICE-DOEPINT1_XFRC    XFRC

\ OTG_FS_DEVICE-DOEPINT2 (read-write)
: OTG_FS_DEVICE-DOEPINT2_B2BSTUP   %1 6 lshift OTG_FS_DEVICE-DOEPINT2 bis! ;  \ OTG_FS_DEVICE-DOEPINT2_B2BSTUP    B2BSTUP
: OTG_FS_DEVICE-DOEPINT2_OTEPDIS   %1 4 lshift OTG_FS_DEVICE-DOEPINT2 bis! ;  \ OTG_FS_DEVICE-DOEPINT2_OTEPDIS    OTEPDIS
: OTG_FS_DEVICE-DOEPINT2_STUP   %1 3 lshift OTG_FS_DEVICE-DOEPINT2 bis! ;  \ OTG_FS_DEVICE-DOEPINT2_STUP    STUP
: OTG_FS_DEVICE-DOEPINT2_EPDISD   %1 1 lshift OTG_FS_DEVICE-DOEPINT2 bis! ;  \ OTG_FS_DEVICE-DOEPINT2_EPDISD    EPDISD
: OTG_FS_DEVICE-DOEPINT2_XFRC   %1 0 lshift OTG_FS_DEVICE-DOEPINT2 bis! ;  \ OTG_FS_DEVICE-DOEPINT2_XFRC    XFRC

\ OTG_FS_DEVICE-DOEPINT3 (read-write)
: OTG_FS_DEVICE-DOEPINT3_B2BSTUP   %1 6 lshift OTG_FS_DEVICE-DOEPINT3 bis! ;  \ OTG_FS_DEVICE-DOEPINT3_B2BSTUP    B2BSTUP
: OTG_FS_DEVICE-DOEPINT3_OTEPDIS   %1 4 lshift OTG_FS_DEVICE-DOEPINT3 bis! ;  \ OTG_FS_DEVICE-DOEPINT3_OTEPDIS    OTEPDIS
: OTG_FS_DEVICE-DOEPINT3_STUP   %1 3 lshift OTG_FS_DEVICE-DOEPINT3 bis! ;  \ OTG_FS_DEVICE-DOEPINT3_STUP    STUP
: OTG_FS_DEVICE-DOEPINT3_EPDISD   %1 1 lshift OTG_FS_DEVICE-DOEPINT3 bis! ;  \ OTG_FS_DEVICE-DOEPINT3_EPDISD    EPDISD
: OTG_FS_DEVICE-DOEPINT3_XFRC   %1 0 lshift OTG_FS_DEVICE-DOEPINT3 bis! ;  \ OTG_FS_DEVICE-DOEPINT3_XFRC    XFRC

\ OTG_FS_DEVICE-DIEPTSIZ0 (read-write)
: OTG_FS_DEVICE-DIEPTSIZ0_PKTCNT   ( %XX -- ) 19 lshift OTG_FS_DEVICE-DIEPTSIZ0 bis! ;  \ OTG_FS_DEVICE-DIEPTSIZ0_PKTCNT    Packet count
: OTG_FS_DEVICE-DIEPTSIZ0_XFRSIZ   ( %XXXXXXX -- ) 0 lshift OTG_FS_DEVICE-DIEPTSIZ0 bis! ;  \ OTG_FS_DEVICE-DIEPTSIZ0_XFRSIZ    Transfer size

\ OTG_FS_DEVICE-DOEPTSIZ0 (read-write)
: OTG_FS_DEVICE-DOEPTSIZ0_STUPCNT   ( %XX -- ) 29 lshift OTG_FS_DEVICE-DOEPTSIZ0 bis! ;  \ OTG_FS_DEVICE-DOEPTSIZ0_STUPCNT    SETUP packet count
: OTG_FS_DEVICE-DOEPTSIZ0_PKTCNT   %1 19 lshift OTG_FS_DEVICE-DOEPTSIZ0 bis! ;  \ OTG_FS_DEVICE-DOEPTSIZ0_PKTCNT    Packet count
: OTG_FS_DEVICE-DOEPTSIZ0_XFRSIZ   ( %XXXXXXX -- ) 0 lshift OTG_FS_DEVICE-DOEPTSIZ0 bis! ;  \ OTG_FS_DEVICE-DOEPTSIZ0_XFRSIZ    Transfer size

\ OTG_FS_DEVICE-DIEPTSIZ1 (read-write)
: OTG_FS_DEVICE-DIEPTSIZ1_MCNT   ( %XX -- ) 29 lshift OTG_FS_DEVICE-DIEPTSIZ1 bis! ;  \ OTG_FS_DEVICE-DIEPTSIZ1_MCNT    Multi count
: OTG_FS_DEVICE-DIEPTSIZ1_PKTCNT  19 lshift OTG_FS_DEVICE-DIEPTSIZ1 bis! ;  \ OTG_FS_DEVICE-DIEPTSIZ1_PKTCNT    Packet count
: OTG_FS_DEVICE-DIEPTSIZ1_XFRSIZ  0 lshift OTG_FS_DEVICE-DIEPTSIZ1 bis! ;  \ OTG_FS_DEVICE-DIEPTSIZ1_XFRSIZ    Transfer size

\ OTG_FS_DEVICE-DIEPTSIZ2 (read-write)
: OTG_FS_DEVICE-DIEPTSIZ2_MCNT   ( %XX -- ) 29 lshift OTG_FS_DEVICE-DIEPTSIZ2 bis! ;  \ OTG_FS_DEVICE-DIEPTSIZ2_MCNT    Multi count
: OTG_FS_DEVICE-DIEPTSIZ2_PKTCNT  19 lshift OTG_FS_DEVICE-DIEPTSIZ2 bis! ;  \ OTG_FS_DEVICE-DIEPTSIZ2_PKTCNT    Packet count
: OTG_FS_DEVICE-DIEPTSIZ2_XFRSIZ  0 lshift OTG_FS_DEVICE-DIEPTSIZ2 bis! ;  \ OTG_FS_DEVICE-DIEPTSIZ2_XFRSIZ    Transfer size

\ OTG_FS_DEVICE-DIEPTSIZ3 (read-write)
: OTG_FS_DEVICE-DIEPTSIZ3_MCNT   ( %XX -- ) 29 lshift OTG_FS_DEVICE-DIEPTSIZ3 bis! ;  \ OTG_FS_DEVICE-DIEPTSIZ3_MCNT    Multi count
: OTG_FS_DEVICE-DIEPTSIZ3_PKTCNT  19 lshift OTG_FS_DEVICE-DIEPTSIZ3 bis! ;  \ OTG_FS_DEVICE-DIEPTSIZ3_PKTCNT    Packet count
: OTG_FS_DEVICE-DIEPTSIZ3_XFRSIZ  0 lshift OTG_FS_DEVICE-DIEPTSIZ3 bis! ;  \ OTG_FS_DEVICE-DIEPTSIZ3_XFRSIZ    Transfer size

\ OTG_FS_DEVICE-DTXFSTS0 (read-only)
: OTG_FS_DEVICE-DTXFSTS0_INEPTFSAV   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift OTG_FS_DEVICE-DTXFSTS0 bis! ;  \ OTG_FS_DEVICE-DTXFSTS0_INEPTFSAV    IN endpoint TxFIFO space
  available

\ OTG_FS_DEVICE-DTXFSTS1 (read-only)
: OTG_FS_DEVICE-DTXFSTS1_INEPTFSAV   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift OTG_FS_DEVICE-DTXFSTS1 bis! ;  \ OTG_FS_DEVICE-DTXFSTS1_INEPTFSAV    IN endpoint TxFIFO space
  available

\ OTG_FS_DEVICE-DTXFSTS2 (read-only)
: OTG_FS_DEVICE-DTXFSTS2_INEPTFSAV   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift OTG_FS_DEVICE-DTXFSTS2 bis! ;  \ OTG_FS_DEVICE-DTXFSTS2_INEPTFSAV    IN endpoint TxFIFO space
  available

\ OTG_FS_DEVICE-DTXFSTS3 (read-only)
: OTG_FS_DEVICE-DTXFSTS3_INEPTFSAV   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift OTG_FS_DEVICE-DTXFSTS3 bis! ;  \ OTG_FS_DEVICE-DTXFSTS3_INEPTFSAV    IN endpoint TxFIFO space
  available

\ OTG_FS_DEVICE-DOEPTSIZ1 (read-write)
: OTG_FS_DEVICE-DOEPTSIZ1_RXDPID_STUPCNT   ( %XX -- ) 29 lshift OTG_FS_DEVICE-DOEPTSIZ1 bis! ;  \ OTG_FS_DEVICE-DOEPTSIZ1_RXDPID_STUPCNT    Received data PID/SETUP packet
  count
: OTG_FS_DEVICE-DOEPTSIZ1_PKTCNT  19 lshift OTG_FS_DEVICE-DOEPTSIZ1 bis! ;  \ OTG_FS_DEVICE-DOEPTSIZ1_PKTCNT    Packet count
: OTG_FS_DEVICE-DOEPTSIZ1_XFRSIZ  0 lshift OTG_FS_DEVICE-DOEPTSIZ1 bis! ;  \ OTG_FS_DEVICE-DOEPTSIZ1_XFRSIZ    Transfer size

\ OTG_FS_DEVICE-DOEPTSIZ2 (read-write)
: OTG_FS_DEVICE-DOEPTSIZ2_RXDPID_STUPCNT   ( %XX -- ) 29 lshift OTG_FS_DEVICE-DOEPTSIZ2 bis! ;  \ OTG_FS_DEVICE-DOEPTSIZ2_RXDPID_STUPCNT    Received data PID/SETUP packet
  count
: OTG_FS_DEVICE-DOEPTSIZ2_PKTCNT  19 lshift OTG_FS_DEVICE-DOEPTSIZ2 bis! ;  \ OTG_FS_DEVICE-DOEPTSIZ2_PKTCNT    Packet count
: OTG_FS_DEVICE-DOEPTSIZ2_XFRSIZ  0 lshift OTG_FS_DEVICE-DOEPTSIZ2 bis! ;  \ OTG_FS_DEVICE-DOEPTSIZ2_XFRSIZ    Transfer size

\ OTG_FS_DEVICE-DOEPTSIZ3 (read-write)
: OTG_FS_DEVICE-DOEPTSIZ3_RXDPID_STUPCNT   ( %XX -- ) 29 lshift OTG_FS_DEVICE-DOEPTSIZ3 bis! ;  \ OTG_FS_DEVICE-DOEPTSIZ3_RXDPID_STUPCNT    Received data PID/SETUP packet
  count
: OTG_FS_DEVICE-DOEPTSIZ3_PKTCNT  19 lshift OTG_FS_DEVICE-DOEPTSIZ3 bis! ;  \ OTG_FS_DEVICE-DOEPTSIZ3_PKTCNT    Packet count
: OTG_FS_DEVICE-DOEPTSIZ3_XFRSIZ  0 lshift OTG_FS_DEVICE-DOEPTSIZ3 bis! ;  \ OTG_FS_DEVICE-DOEPTSIZ3_XFRSIZ    Transfer size

\ OTG_FS_GLOBAL-FS_GOTGCTL ()
: OTG_FS_GLOBAL-FS_GOTGCTL_SRQSCS   %1 0 lshift OTG_FS_GLOBAL-FS_GOTGCTL bis! ;  \ OTG_FS_GLOBAL-FS_GOTGCTL_SRQSCS    Session request success
: OTG_FS_GLOBAL-FS_GOTGCTL_SRQ   %1 1 lshift OTG_FS_GLOBAL-FS_GOTGCTL bis! ;  \ OTG_FS_GLOBAL-FS_GOTGCTL_SRQ    Session request
: OTG_FS_GLOBAL-FS_GOTGCTL_HNGSCS   %1 8 lshift OTG_FS_GLOBAL-FS_GOTGCTL bis! ;  \ OTG_FS_GLOBAL-FS_GOTGCTL_HNGSCS    Host negotiation success
: OTG_FS_GLOBAL-FS_GOTGCTL_HNPRQ   %1 9 lshift OTG_FS_GLOBAL-FS_GOTGCTL bis! ;  \ OTG_FS_GLOBAL-FS_GOTGCTL_HNPRQ    HNP request
: OTG_FS_GLOBAL-FS_GOTGCTL_HSHNPEN   %1 10 lshift OTG_FS_GLOBAL-FS_GOTGCTL bis! ;  \ OTG_FS_GLOBAL-FS_GOTGCTL_HSHNPEN    Host set HNP enable
: OTG_FS_GLOBAL-FS_GOTGCTL_DHNPEN   %1 11 lshift OTG_FS_GLOBAL-FS_GOTGCTL bis! ;  \ OTG_FS_GLOBAL-FS_GOTGCTL_DHNPEN    Device HNP enabled
: OTG_FS_GLOBAL-FS_GOTGCTL_CIDSTS   %1 16 lshift OTG_FS_GLOBAL-FS_GOTGCTL bis! ;  \ OTG_FS_GLOBAL-FS_GOTGCTL_CIDSTS    Connector ID status
: OTG_FS_GLOBAL-FS_GOTGCTL_DBCT   %1 17 lshift OTG_FS_GLOBAL-FS_GOTGCTL bis! ;  \ OTG_FS_GLOBAL-FS_GOTGCTL_DBCT    Long/short debounce time
: OTG_FS_GLOBAL-FS_GOTGCTL_ASVLD   %1 18 lshift OTG_FS_GLOBAL-FS_GOTGCTL bis! ;  \ OTG_FS_GLOBAL-FS_GOTGCTL_ASVLD    A-session valid
: OTG_FS_GLOBAL-FS_GOTGCTL_BSVLD   %1 19 lshift OTG_FS_GLOBAL-FS_GOTGCTL bis! ;  \ OTG_FS_GLOBAL-FS_GOTGCTL_BSVLD    B-session valid

\ OTG_FS_GLOBAL-FS_GOTGINT (read-write)
: OTG_FS_GLOBAL-FS_GOTGINT_SEDET   %1 2 lshift OTG_FS_GLOBAL-FS_GOTGINT bis! ;  \ OTG_FS_GLOBAL-FS_GOTGINT_SEDET    Session end detected
: OTG_FS_GLOBAL-FS_GOTGINT_SRSSCHG   %1 8 lshift OTG_FS_GLOBAL-FS_GOTGINT bis! ;  \ OTG_FS_GLOBAL-FS_GOTGINT_SRSSCHG    Session request success status
  change
: OTG_FS_GLOBAL-FS_GOTGINT_HNSSCHG   %1 9 lshift OTG_FS_GLOBAL-FS_GOTGINT bis! ;  \ OTG_FS_GLOBAL-FS_GOTGINT_HNSSCHG    Host negotiation success status
  change
: OTG_FS_GLOBAL-FS_GOTGINT_HNGDET   %1 17 lshift OTG_FS_GLOBAL-FS_GOTGINT bis! ;  \ OTG_FS_GLOBAL-FS_GOTGINT_HNGDET    Host negotiation detected
: OTG_FS_GLOBAL-FS_GOTGINT_ADTOCHG   %1 18 lshift OTG_FS_GLOBAL-FS_GOTGINT bis! ;  \ OTG_FS_GLOBAL-FS_GOTGINT_ADTOCHG    A-device timeout change
: OTG_FS_GLOBAL-FS_GOTGINT_DBCDNE   %1 19 lshift OTG_FS_GLOBAL-FS_GOTGINT bis! ;  \ OTG_FS_GLOBAL-FS_GOTGINT_DBCDNE    Debounce done

\ OTG_FS_GLOBAL-FS_GAHBCFG (read-write)
: OTG_FS_GLOBAL-FS_GAHBCFG_GINT   %1 0 lshift OTG_FS_GLOBAL-FS_GAHBCFG bis! ;  \ OTG_FS_GLOBAL-FS_GAHBCFG_GINT    Global interrupt mask
: OTG_FS_GLOBAL-FS_GAHBCFG_TXFELVL   %1 7 lshift OTG_FS_GLOBAL-FS_GAHBCFG bis! ;  \ OTG_FS_GLOBAL-FS_GAHBCFG_TXFELVL    TxFIFO empty level
: OTG_FS_GLOBAL-FS_GAHBCFG_PTXFELVL   %1 8 lshift OTG_FS_GLOBAL-FS_GAHBCFG bis! ;  \ OTG_FS_GLOBAL-FS_GAHBCFG_PTXFELVL    Periodic TxFIFO empty
  level

\ OTG_FS_GLOBAL-FS_GUSBCFG ()
: OTG_FS_GLOBAL-FS_GUSBCFG_TOCAL   ( %XXX -- ) 0 lshift OTG_FS_GLOBAL-FS_GUSBCFG bis! ;  \ OTG_FS_GLOBAL-FS_GUSBCFG_TOCAL    FS timeout calibration
: OTG_FS_GLOBAL-FS_GUSBCFG_PHYSEL   %1 6 lshift OTG_FS_GLOBAL-FS_GUSBCFG bis! ;  \ OTG_FS_GLOBAL-FS_GUSBCFG_PHYSEL    Full Speed serial transceiver
  select
: OTG_FS_GLOBAL-FS_GUSBCFG_SRPCAP   %1 8 lshift OTG_FS_GLOBAL-FS_GUSBCFG bis! ;  \ OTG_FS_GLOBAL-FS_GUSBCFG_SRPCAP    SRP-capable
: OTG_FS_GLOBAL-FS_GUSBCFG_HNPCAP   %1 9 lshift OTG_FS_GLOBAL-FS_GUSBCFG bis! ;  \ OTG_FS_GLOBAL-FS_GUSBCFG_HNPCAP    HNP-capable
: OTG_FS_GLOBAL-FS_GUSBCFG_TRDT   ( %XXXX -- ) 10 lshift OTG_FS_GLOBAL-FS_GUSBCFG bis! ;  \ OTG_FS_GLOBAL-FS_GUSBCFG_TRDT    USB turnaround time
: OTG_FS_GLOBAL-FS_GUSBCFG_FHMOD   %1 29 lshift OTG_FS_GLOBAL-FS_GUSBCFG bis! ;  \ OTG_FS_GLOBAL-FS_GUSBCFG_FHMOD    Force host mode
: OTG_FS_GLOBAL-FS_GUSBCFG_FDMOD   %1 30 lshift OTG_FS_GLOBAL-FS_GUSBCFG bis! ;  \ OTG_FS_GLOBAL-FS_GUSBCFG_FDMOD    Force device mode
: OTG_FS_GLOBAL-FS_GUSBCFG_CTXPKT   %1 31 lshift OTG_FS_GLOBAL-FS_GUSBCFG bis! ;  \ OTG_FS_GLOBAL-FS_GUSBCFG_CTXPKT    Corrupt Tx packet

\ OTG_FS_GLOBAL-FS_GRSTCTL ()
: OTG_FS_GLOBAL-FS_GRSTCTL_CSRST   %1 0 lshift OTG_FS_GLOBAL-FS_GRSTCTL bis! ;  \ OTG_FS_GLOBAL-FS_GRSTCTL_CSRST    Core soft reset
: OTG_FS_GLOBAL-FS_GRSTCTL_HSRST   %1 1 lshift OTG_FS_GLOBAL-FS_GRSTCTL bis! ;  \ OTG_FS_GLOBAL-FS_GRSTCTL_HSRST    HCLK soft reset
: OTG_FS_GLOBAL-FS_GRSTCTL_FCRST   %1 2 lshift OTG_FS_GLOBAL-FS_GRSTCTL bis! ;  \ OTG_FS_GLOBAL-FS_GRSTCTL_FCRST    Host frame counter reset
: OTG_FS_GLOBAL-FS_GRSTCTL_RXFFLSH   %1 4 lshift OTG_FS_GLOBAL-FS_GRSTCTL bis! ;  \ OTG_FS_GLOBAL-FS_GRSTCTL_RXFFLSH    RxFIFO flush
: OTG_FS_GLOBAL-FS_GRSTCTL_TXFFLSH   %1 5 lshift OTG_FS_GLOBAL-FS_GRSTCTL bis! ;  \ OTG_FS_GLOBAL-FS_GRSTCTL_TXFFLSH    TxFIFO flush
: OTG_FS_GLOBAL-FS_GRSTCTL_TXFNUM   ( %XXXXX -- ) 6 lshift OTG_FS_GLOBAL-FS_GRSTCTL bis! ;  \ OTG_FS_GLOBAL-FS_GRSTCTL_TXFNUM    TxFIFO number
: OTG_FS_GLOBAL-FS_GRSTCTL_AHBIDL   %1 31 lshift OTG_FS_GLOBAL-FS_GRSTCTL bis! ;  \ OTG_FS_GLOBAL-FS_GRSTCTL_AHBIDL    AHB master idle

\ OTG_FS_GLOBAL-FS_GINTSTS ()
: OTG_FS_GLOBAL-FS_GINTSTS_CMOD   %1 0 lshift OTG_FS_GLOBAL-FS_GINTSTS bis! ;  \ OTG_FS_GLOBAL-FS_GINTSTS_CMOD    Current mode of operation
: OTG_FS_GLOBAL-FS_GINTSTS_MMIS   %1 1 lshift OTG_FS_GLOBAL-FS_GINTSTS bis! ;  \ OTG_FS_GLOBAL-FS_GINTSTS_MMIS    Mode mismatch interrupt
: OTG_FS_GLOBAL-FS_GINTSTS_OTGINT   %1 2 lshift OTG_FS_GLOBAL-FS_GINTSTS bis! ;  \ OTG_FS_GLOBAL-FS_GINTSTS_OTGINT    OTG interrupt
: OTG_FS_GLOBAL-FS_GINTSTS_SOF   %1 3 lshift OTG_FS_GLOBAL-FS_GINTSTS bis! ;  \ OTG_FS_GLOBAL-FS_GINTSTS_SOF    Start of frame
: OTG_FS_GLOBAL-FS_GINTSTS_RXFLVL   %1 4 lshift OTG_FS_GLOBAL-FS_GINTSTS bis! ;  \ OTG_FS_GLOBAL-FS_GINTSTS_RXFLVL    RxFIFO non-empty
: OTG_FS_GLOBAL-FS_GINTSTS_NPTXFE   %1 5 lshift OTG_FS_GLOBAL-FS_GINTSTS bis! ;  \ OTG_FS_GLOBAL-FS_GINTSTS_NPTXFE    Non-periodic TxFIFO empty
: OTG_FS_GLOBAL-FS_GINTSTS_GINAKEFF   %1 6 lshift OTG_FS_GLOBAL-FS_GINTSTS bis! ;  \ OTG_FS_GLOBAL-FS_GINTSTS_GINAKEFF    Global IN non-periodic NAK
  effective
: OTG_FS_GLOBAL-FS_GINTSTS_GOUTNAKEFF   %1 7 lshift OTG_FS_GLOBAL-FS_GINTSTS bis! ;  \ OTG_FS_GLOBAL-FS_GINTSTS_GOUTNAKEFF    Global OUT NAK effective
: OTG_FS_GLOBAL-FS_GINTSTS_ESUSP   %1 10 lshift OTG_FS_GLOBAL-FS_GINTSTS bis! ;  \ OTG_FS_GLOBAL-FS_GINTSTS_ESUSP    Early suspend
: OTG_FS_GLOBAL-FS_GINTSTS_USBSUSP   %1 11 lshift OTG_FS_GLOBAL-FS_GINTSTS bis! ;  \ OTG_FS_GLOBAL-FS_GINTSTS_USBSUSP    USB suspend
: OTG_FS_GLOBAL-FS_GINTSTS_USBRST   %1 12 lshift OTG_FS_GLOBAL-FS_GINTSTS bis! ;  \ OTG_FS_GLOBAL-FS_GINTSTS_USBRST    USB reset
: OTG_FS_GLOBAL-FS_GINTSTS_ENUMDNE   %1 13 lshift OTG_FS_GLOBAL-FS_GINTSTS bis! ;  \ OTG_FS_GLOBAL-FS_GINTSTS_ENUMDNE    Enumeration done
: OTG_FS_GLOBAL-FS_GINTSTS_ISOODRP   %1 14 lshift OTG_FS_GLOBAL-FS_GINTSTS bis! ;  \ OTG_FS_GLOBAL-FS_GINTSTS_ISOODRP    Isochronous OUT packet dropped
  interrupt
: OTG_FS_GLOBAL-FS_GINTSTS_EOPF   %1 15 lshift OTG_FS_GLOBAL-FS_GINTSTS bis! ;  \ OTG_FS_GLOBAL-FS_GINTSTS_EOPF    End of periodic frame
  interrupt
: OTG_FS_GLOBAL-FS_GINTSTS_IEPINT   %1 18 lshift OTG_FS_GLOBAL-FS_GINTSTS bis! ;  \ OTG_FS_GLOBAL-FS_GINTSTS_IEPINT    IN endpoint interrupt
: OTG_FS_GLOBAL-FS_GINTSTS_OEPINT   %1 19 lshift OTG_FS_GLOBAL-FS_GINTSTS bis! ;  \ OTG_FS_GLOBAL-FS_GINTSTS_OEPINT    OUT endpoint interrupt
: OTG_FS_GLOBAL-FS_GINTSTS_IISOIXFR   %1 20 lshift OTG_FS_GLOBAL-FS_GINTSTS bis! ;  \ OTG_FS_GLOBAL-FS_GINTSTS_IISOIXFR    Incomplete isochronous IN
  transfer
: OTG_FS_GLOBAL-FS_GINTSTS_IPXFR_INCOMPISOOUT   %1 21 lshift OTG_FS_GLOBAL-FS_GINTSTS bis! ;  \ OTG_FS_GLOBAL-FS_GINTSTS_IPXFR_INCOMPISOOUT    Incomplete periodic transferHost
  mode/Incomplete isochronous OUT transferDevice
  mode
: OTG_FS_GLOBAL-FS_GINTSTS_HPRTINT   %1 24 lshift OTG_FS_GLOBAL-FS_GINTSTS bis! ;  \ OTG_FS_GLOBAL-FS_GINTSTS_HPRTINT    Host port interrupt
: OTG_FS_GLOBAL-FS_GINTSTS_HCINT   %1 25 lshift OTG_FS_GLOBAL-FS_GINTSTS bis! ;  \ OTG_FS_GLOBAL-FS_GINTSTS_HCINT    Host channels interrupt
: OTG_FS_GLOBAL-FS_GINTSTS_PTXFE   %1 26 lshift OTG_FS_GLOBAL-FS_GINTSTS bis! ;  \ OTG_FS_GLOBAL-FS_GINTSTS_PTXFE    Periodic TxFIFO empty
: OTG_FS_GLOBAL-FS_GINTSTS_CIDSCHG   %1 28 lshift OTG_FS_GLOBAL-FS_GINTSTS bis! ;  \ OTG_FS_GLOBAL-FS_GINTSTS_CIDSCHG    Connector ID status change
: OTG_FS_GLOBAL-FS_GINTSTS_DISCINT   %1 29 lshift OTG_FS_GLOBAL-FS_GINTSTS bis! ;  \ OTG_FS_GLOBAL-FS_GINTSTS_DISCINT    Disconnect detected
  interrupt
: OTG_FS_GLOBAL-FS_GINTSTS_SRQINT   %1 30 lshift OTG_FS_GLOBAL-FS_GINTSTS bis! ;  \ OTG_FS_GLOBAL-FS_GINTSTS_SRQINT    Session request/new session detected
  interrupt
: OTG_FS_GLOBAL-FS_GINTSTS_WKUPINT   %1 31 lshift OTG_FS_GLOBAL-FS_GINTSTS bis! ;  \ OTG_FS_GLOBAL-FS_GINTSTS_WKUPINT    Resume/remote wakeup detected
  interrupt

\ OTG_FS_GLOBAL-FS_GINTMSK ()
: OTG_FS_GLOBAL-FS_GINTMSK_MMISM   %1 1 lshift OTG_FS_GLOBAL-FS_GINTMSK bis! ;  \ OTG_FS_GLOBAL-FS_GINTMSK_MMISM    Mode mismatch interrupt
  mask
: OTG_FS_GLOBAL-FS_GINTMSK_OTGINT   %1 2 lshift OTG_FS_GLOBAL-FS_GINTMSK bis! ;  \ OTG_FS_GLOBAL-FS_GINTMSK_OTGINT    OTG interrupt mask
: OTG_FS_GLOBAL-FS_GINTMSK_SOFM   %1 3 lshift OTG_FS_GLOBAL-FS_GINTMSK bis! ;  \ OTG_FS_GLOBAL-FS_GINTMSK_SOFM    Start of frame mask
: OTG_FS_GLOBAL-FS_GINTMSK_RXFLVLM   %1 4 lshift OTG_FS_GLOBAL-FS_GINTMSK bis! ;  \ OTG_FS_GLOBAL-FS_GINTMSK_RXFLVLM    Receive FIFO non-empty
  mask
: OTG_FS_GLOBAL-FS_GINTMSK_NPTXFEM   %1 5 lshift OTG_FS_GLOBAL-FS_GINTMSK bis! ;  \ OTG_FS_GLOBAL-FS_GINTMSK_NPTXFEM    Non-periodic TxFIFO empty
  mask
: OTG_FS_GLOBAL-FS_GINTMSK_GINAKEFFM   %1 6 lshift OTG_FS_GLOBAL-FS_GINTMSK bis! ;  \ OTG_FS_GLOBAL-FS_GINTMSK_GINAKEFFM    Global non-periodic IN NAK effective
  mask
: OTG_FS_GLOBAL-FS_GINTMSK_GONAKEFFM   %1 7 lshift OTG_FS_GLOBAL-FS_GINTMSK bis! ;  \ OTG_FS_GLOBAL-FS_GINTMSK_GONAKEFFM    Global OUT NAK effective
  mask
: OTG_FS_GLOBAL-FS_GINTMSK_ESUSPM   %1 10 lshift OTG_FS_GLOBAL-FS_GINTMSK bis! ;  \ OTG_FS_GLOBAL-FS_GINTMSK_ESUSPM    Early suspend mask
: OTG_FS_GLOBAL-FS_GINTMSK_USBSUSPM   %1 11 lshift OTG_FS_GLOBAL-FS_GINTMSK bis! ;  \ OTG_FS_GLOBAL-FS_GINTMSK_USBSUSPM    USB suspend mask
: OTG_FS_GLOBAL-FS_GINTMSK_USBRST   %1 12 lshift OTG_FS_GLOBAL-FS_GINTMSK bis! ;  \ OTG_FS_GLOBAL-FS_GINTMSK_USBRST    USB reset mask
: OTG_FS_GLOBAL-FS_GINTMSK_ENUMDNEM   %1 13 lshift OTG_FS_GLOBAL-FS_GINTMSK bis! ;  \ OTG_FS_GLOBAL-FS_GINTMSK_ENUMDNEM    Enumeration done mask
: OTG_FS_GLOBAL-FS_GINTMSK_ISOODRPM   %1 14 lshift OTG_FS_GLOBAL-FS_GINTMSK bis! ;  \ OTG_FS_GLOBAL-FS_GINTMSK_ISOODRPM    Isochronous OUT packet dropped interrupt
  mask
: OTG_FS_GLOBAL-FS_GINTMSK_EOPFM   %1 15 lshift OTG_FS_GLOBAL-FS_GINTMSK bis! ;  \ OTG_FS_GLOBAL-FS_GINTMSK_EOPFM    End of periodic frame interrupt
  mask
: OTG_FS_GLOBAL-FS_GINTMSK_EPMISM   %1 17 lshift OTG_FS_GLOBAL-FS_GINTMSK bis! ;  \ OTG_FS_GLOBAL-FS_GINTMSK_EPMISM    Endpoint mismatch interrupt
  mask
: OTG_FS_GLOBAL-FS_GINTMSK_IEPINT   %1 18 lshift OTG_FS_GLOBAL-FS_GINTMSK bis! ;  \ OTG_FS_GLOBAL-FS_GINTMSK_IEPINT    IN endpoints interrupt
  mask
: OTG_FS_GLOBAL-FS_GINTMSK_OEPINT   %1 19 lshift OTG_FS_GLOBAL-FS_GINTMSK bis! ;  \ OTG_FS_GLOBAL-FS_GINTMSK_OEPINT    OUT endpoints interrupt
  mask
: OTG_FS_GLOBAL-FS_GINTMSK_IISOIXFRM   %1 20 lshift OTG_FS_GLOBAL-FS_GINTMSK bis! ;  \ OTG_FS_GLOBAL-FS_GINTMSK_IISOIXFRM    Incomplete isochronous IN transfer
  mask
: OTG_FS_GLOBAL-FS_GINTMSK_IPXFRM_IISOOXFRM   %1 21 lshift OTG_FS_GLOBAL-FS_GINTMSK bis! ;  \ OTG_FS_GLOBAL-FS_GINTMSK_IPXFRM_IISOOXFRM    Incomplete periodic transfer maskHost
  mode/Incomplete isochronous OUT transfer maskDevice
  mode
: OTG_FS_GLOBAL-FS_GINTMSK_PRTIM   %1 24 lshift OTG_FS_GLOBAL-FS_GINTMSK bis! ;  \ OTG_FS_GLOBAL-FS_GINTMSK_PRTIM    Host port interrupt mask
: OTG_FS_GLOBAL-FS_GINTMSK_HCIM   %1 25 lshift OTG_FS_GLOBAL-FS_GINTMSK bis! ;  \ OTG_FS_GLOBAL-FS_GINTMSK_HCIM    Host channels interrupt
  mask
: OTG_FS_GLOBAL-FS_GINTMSK_PTXFEM   %1 26 lshift OTG_FS_GLOBAL-FS_GINTMSK bis! ;  \ OTG_FS_GLOBAL-FS_GINTMSK_PTXFEM    Periodic TxFIFO empty mask
: OTG_FS_GLOBAL-FS_GINTMSK_CIDSCHGM   %1 28 lshift OTG_FS_GLOBAL-FS_GINTMSK bis! ;  \ OTG_FS_GLOBAL-FS_GINTMSK_CIDSCHGM    Connector ID status change
  mask
: OTG_FS_GLOBAL-FS_GINTMSK_DISCINT   %1 29 lshift OTG_FS_GLOBAL-FS_GINTMSK bis! ;  \ OTG_FS_GLOBAL-FS_GINTMSK_DISCINT    Disconnect detected interrupt
  mask
: OTG_FS_GLOBAL-FS_GINTMSK_SRQIM   %1 30 lshift OTG_FS_GLOBAL-FS_GINTMSK bis! ;  \ OTG_FS_GLOBAL-FS_GINTMSK_SRQIM    Session request/new session detected
  interrupt mask
: OTG_FS_GLOBAL-FS_GINTMSK_WUIM   %1 31 lshift OTG_FS_GLOBAL-FS_GINTMSK bis! ;  \ OTG_FS_GLOBAL-FS_GINTMSK_WUIM    Resume/remote wakeup detected interrupt
  mask

\ OTG_FS_GLOBAL-FS_GRXSTSR_Device (read-only)
: OTG_FS_GLOBAL-FS_GRXSTSR_Device_EPNUM   ( %XXXX -- ) 0 lshift OTG_FS_GLOBAL-FS_GRXSTSR_Device bis! ;  \ OTG_FS_GLOBAL-FS_GRXSTSR_Device_EPNUM    Endpoint number
: OTG_FS_GLOBAL-FS_GRXSTSR_Device_BCNT  4 lshift OTG_FS_GLOBAL-FS_GRXSTSR_Device bis! ;  \ OTG_FS_GLOBAL-FS_GRXSTSR_Device_BCNT    Byte count
: OTG_FS_GLOBAL-FS_GRXSTSR_Device_DPID   ( %XX -- ) 15 lshift OTG_FS_GLOBAL-FS_GRXSTSR_Device bis! ;  \ OTG_FS_GLOBAL-FS_GRXSTSR_Device_DPID    Data PID
: OTG_FS_GLOBAL-FS_GRXSTSR_Device_PKTSTS   ( %XXXX -- ) 17 lshift OTG_FS_GLOBAL-FS_GRXSTSR_Device bis! ;  \ OTG_FS_GLOBAL-FS_GRXSTSR_Device_PKTSTS    Packet status
: OTG_FS_GLOBAL-FS_GRXSTSR_Device_FRMNUM   ( %XXXX -- ) 21 lshift OTG_FS_GLOBAL-FS_GRXSTSR_Device bis! ;  \ OTG_FS_GLOBAL-FS_GRXSTSR_Device_FRMNUM    Frame number

\ OTG_FS_GLOBAL-FS_GRXSTSR_Host (read-only)
: OTG_FS_GLOBAL-FS_GRXSTSR_Host_EPNUM   ( %XXXX -- ) 0 lshift OTG_FS_GLOBAL-FS_GRXSTSR_Host bis! ;  \ OTG_FS_GLOBAL-FS_GRXSTSR_Host_EPNUM    Endpoint number
: OTG_FS_GLOBAL-FS_GRXSTSR_Host_BCNT  4 lshift OTG_FS_GLOBAL-FS_GRXSTSR_Host bis! ;  \ OTG_FS_GLOBAL-FS_GRXSTSR_Host_BCNT    Byte count
: OTG_FS_GLOBAL-FS_GRXSTSR_Host_DPID   ( %XX -- ) 15 lshift OTG_FS_GLOBAL-FS_GRXSTSR_Host bis! ;  \ OTG_FS_GLOBAL-FS_GRXSTSR_Host_DPID    Data PID
: OTG_FS_GLOBAL-FS_GRXSTSR_Host_PKTSTS   ( %XXXX -- ) 17 lshift OTG_FS_GLOBAL-FS_GRXSTSR_Host bis! ;  \ OTG_FS_GLOBAL-FS_GRXSTSR_Host_PKTSTS    Packet status
: OTG_FS_GLOBAL-FS_GRXSTSR_Host_FRMNUM   ( %XXXX -- ) 21 lshift OTG_FS_GLOBAL-FS_GRXSTSR_Host bis! ;  \ OTG_FS_GLOBAL-FS_GRXSTSR_Host_FRMNUM    Frame number

\ OTG_FS_GLOBAL-FS_GRXFSIZ (read-write)
: OTG_FS_GLOBAL-FS_GRXFSIZ_RXFD   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift OTG_FS_GLOBAL-FS_GRXFSIZ bis! ;  \ OTG_FS_GLOBAL-FS_GRXFSIZ_RXFD    RxFIFO depth

\ OTG_FS_GLOBAL-FS_GNPTXFSIZ_Device (read-write)
: OTG_FS_GLOBAL-FS_GNPTXFSIZ_Device_TX0FSA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift OTG_FS_GLOBAL-FS_GNPTXFSIZ_Device bis! ;  \ OTG_FS_GLOBAL-FS_GNPTXFSIZ_Device_TX0FSA    Endpoint 0 transmit RAM start
  address
: OTG_FS_GLOBAL-FS_GNPTXFSIZ_Device_TX0FD   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift OTG_FS_GLOBAL-FS_GNPTXFSIZ_Device bis! ;  \ OTG_FS_GLOBAL-FS_GNPTXFSIZ_Device_TX0FD    Endpoint 0 TxFIFO depth

\ OTG_FS_GLOBAL-FS_GNPTXFSIZ_Host (read-write)
: OTG_FS_GLOBAL-FS_GNPTXFSIZ_Host_NPTXFSA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift OTG_FS_GLOBAL-FS_GNPTXFSIZ_Host bis! ;  \ OTG_FS_GLOBAL-FS_GNPTXFSIZ_Host_NPTXFSA    Non-periodic transmit RAM start
  address
: OTG_FS_GLOBAL-FS_GNPTXFSIZ_Host_NPTXFD   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift OTG_FS_GLOBAL-FS_GNPTXFSIZ_Host bis! ;  \ OTG_FS_GLOBAL-FS_GNPTXFSIZ_Host_NPTXFD    Non-periodic TxFIFO depth

\ OTG_FS_GLOBAL-FS_GNPTXSTS (read-only)
: OTG_FS_GLOBAL-FS_GNPTXSTS_NPTXFSAV   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift OTG_FS_GLOBAL-FS_GNPTXSTS bis! ;  \ OTG_FS_GLOBAL-FS_GNPTXSTS_NPTXFSAV    Non-periodic TxFIFO space
  available
: OTG_FS_GLOBAL-FS_GNPTXSTS_NPTQXSAV   ( %XXXXXXXX -- ) 16 lshift OTG_FS_GLOBAL-FS_GNPTXSTS bis! ;  \ OTG_FS_GLOBAL-FS_GNPTXSTS_NPTQXSAV    Non-periodic transmit request queue
  space available
: OTG_FS_GLOBAL-FS_GNPTXSTS_NPTXQTOP   ( %XXXXXXX -- ) 24 lshift OTG_FS_GLOBAL-FS_GNPTXSTS bis! ;  \ OTG_FS_GLOBAL-FS_GNPTXSTS_NPTXQTOP    Top of the non-periodic transmit request
  queue

\ OTG_FS_GLOBAL-FS_GCCFG (read-write)
: OTG_FS_GLOBAL-FS_GCCFG_PWRDWN   %1 16 lshift OTG_FS_GLOBAL-FS_GCCFG bis! ;  \ OTG_FS_GLOBAL-FS_GCCFG_PWRDWN    Power down
: OTG_FS_GLOBAL-FS_GCCFG_VBUSASEN   %1 18 lshift OTG_FS_GLOBAL-FS_GCCFG bis! ;  \ OTG_FS_GLOBAL-FS_GCCFG_VBUSASEN    Enable the VBUS sensing
  device
: OTG_FS_GLOBAL-FS_GCCFG_VBUSBSEN   %1 19 lshift OTG_FS_GLOBAL-FS_GCCFG bis! ;  \ OTG_FS_GLOBAL-FS_GCCFG_VBUSBSEN    Enable the VBUS sensing
  device
: OTG_FS_GLOBAL-FS_GCCFG_SOFOUTEN   %1 20 lshift OTG_FS_GLOBAL-FS_GCCFG bis! ;  \ OTG_FS_GLOBAL-FS_GCCFG_SOFOUTEN    SOF output enable

\ OTG_FS_GLOBAL-FS_CID (read-write)
: OTG_FS_GLOBAL-FS_CID_PRODUCT_ID   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift OTG_FS_GLOBAL-FS_CID bis! ;  \ OTG_FS_GLOBAL-FS_CID_PRODUCT_ID    Product ID field

\ OTG_FS_GLOBAL-FS_HPTXFSIZ (read-write)
: OTG_FS_GLOBAL-FS_HPTXFSIZ_PTXSA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift OTG_FS_GLOBAL-FS_HPTXFSIZ bis! ;  \ OTG_FS_GLOBAL-FS_HPTXFSIZ_PTXSA    Host periodic TxFIFO start
  address
: OTG_FS_GLOBAL-FS_HPTXFSIZ_PTXFSIZ   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift OTG_FS_GLOBAL-FS_HPTXFSIZ bis! ;  \ OTG_FS_GLOBAL-FS_HPTXFSIZ_PTXFSIZ    Host periodic TxFIFO depth

\ OTG_FS_GLOBAL-FS_DIEPTXF1 (read-write)
: OTG_FS_GLOBAL-FS_DIEPTXF1_INEPTXSA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift OTG_FS_GLOBAL-FS_DIEPTXF1 bis! ;  \ OTG_FS_GLOBAL-FS_DIEPTXF1_INEPTXSA    IN endpoint FIFO2 transmit RAM start
  address
: OTG_FS_GLOBAL-FS_DIEPTXF1_INEPTXFD   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift OTG_FS_GLOBAL-FS_DIEPTXF1 bis! ;  \ OTG_FS_GLOBAL-FS_DIEPTXF1_INEPTXFD    IN endpoint TxFIFO depth

\ OTG_FS_GLOBAL-FS_DIEPTXF2 (read-write)
: OTG_FS_GLOBAL-FS_DIEPTXF2_INEPTXSA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift OTG_FS_GLOBAL-FS_DIEPTXF2 bis! ;  \ OTG_FS_GLOBAL-FS_DIEPTXF2_INEPTXSA    IN endpoint FIFO3 transmit RAM start
  address
: OTG_FS_GLOBAL-FS_DIEPTXF2_INEPTXFD   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift OTG_FS_GLOBAL-FS_DIEPTXF2 bis! ;  \ OTG_FS_GLOBAL-FS_DIEPTXF2_INEPTXFD    IN endpoint TxFIFO depth

\ OTG_FS_GLOBAL-FS_DIEPTXF3 (read-write)
: OTG_FS_GLOBAL-FS_DIEPTXF3_INEPTXSA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift OTG_FS_GLOBAL-FS_DIEPTXF3 bis! ;  \ OTG_FS_GLOBAL-FS_DIEPTXF3_INEPTXSA    IN endpoint FIFO4 transmit RAM start
  address
: OTG_FS_GLOBAL-FS_DIEPTXF3_INEPTXFD   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift OTG_FS_GLOBAL-FS_DIEPTXF3 bis! ;  \ OTG_FS_GLOBAL-FS_DIEPTXF3_INEPTXFD    IN endpoint TxFIFO depth

\ OTG_FS_HOST-FS_HCFG ()
: OTG_FS_HOST-FS_HCFG_FSLSPCS   ( %XX -- ) 0 lshift OTG_FS_HOST-FS_HCFG bis! ;  \ OTG_FS_HOST-FS_HCFG_FSLSPCS    FS/LS PHY clock select
: OTG_FS_HOST-FS_HCFG_FSLSS   %1 2 lshift OTG_FS_HOST-FS_HCFG bis! ;  \ OTG_FS_HOST-FS_HCFG_FSLSS    FS- and LS-only support

\ OTG_FS_HOST-HFIR (read-write)
: OTG_FS_HOST-HFIR_FRIVL   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift OTG_FS_HOST-HFIR bis! ;  \ OTG_FS_HOST-HFIR_FRIVL    Frame interval

\ OTG_FS_HOST-FS_HFNUM (read-only)
: OTG_FS_HOST-FS_HFNUM_FRNUM   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift OTG_FS_HOST-FS_HFNUM bis! ;  \ OTG_FS_HOST-FS_HFNUM_FRNUM    Frame number
: OTG_FS_HOST-FS_HFNUM_FTREM   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift OTG_FS_HOST-FS_HFNUM bis! ;  \ OTG_FS_HOST-FS_HFNUM_FTREM    Frame time remaining

\ OTG_FS_HOST-FS_HPTXSTS ()
: OTG_FS_HOST-FS_HPTXSTS_PTXFSAVL   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift OTG_FS_HOST-FS_HPTXSTS bis! ;  \ OTG_FS_HOST-FS_HPTXSTS_PTXFSAVL    Periodic transmit data FIFO space
  available
: OTG_FS_HOST-FS_HPTXSTS_PTXQSAV   ( %XXXXXXXX -- ) 16 lshift OTG_FS_HOST-FS_HPTXSTS bis! ;  \ OTG_FS_HOST-FS_HPTXSTS_PTXQSAV    Periodic transmit request queue space
  available
: OTG_FS_HOST-FS_HPTXSTS_PTXQTOP   ( %XXXXXXXX -- ) 24 lshift OTG_FS_HOST-FS_HPTXSTS bis! ;  \ OTG_FS_HOST-FS_HPTXSTS_PTXQTOP    Top of the periodic transmit request
  queue

\ OTG_FS_HOST-HAINT (read-only)
: OTG_FS_HOST-HAINT_HAINT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift OTG_FS_HOST-HAINT bis! ;  \ OTG_FS_HOST-HAINT_HAINT    Channel interrupts

\ OTG_FS_HOST-HAINTMSK (read-write)
: OTG_FS_HOST-HAINTMSK_HAINTM   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift OTG_FS_HOST-HAINTMSK bis! ;  \ OTG_FS_HOST-HAINTMSK_HAINTM    Channel interrupt mask

\ OTG_FS_HOST-FS_HPRT ()
: OTG_FS_HOST-FS_HPRT_PCSTS   %1 0 lshift OTG_FS_HOST-FS_HPRT bis! ;  \ OTG_FS_HOST-FS_HPRT_PCSTS    Port connect status
: OTG_FS_HOST-FS_HPRT_PCDET   %1 1 lshift OTG_FS_HOST-FS_HPRT bis! ;  \ OTG_FS_HOST-FS_HPRT_PCDET    Port connect detected
: OTG_FS_HOST-FS_HPRT_PENA   %1 2 lshift OTG_FS_HOST-FS_HPRT bis! ;  \ OTG_FS_HOST-FS_HPRT_PENA    Port enable
: OTG_FS_HOST-FS_HPRT_PENCHNG   %1 3 lshift OTG_FS_HOST-FS_HPRT bis! ;  \ OTG_FS_HOST-FS_HPRT_PENCHNG    Port enable/disable change
: OTG_FS_HOST-FS_HPRT_POCA   %1 4 lshift OTG_FS_HOST-FS_HPRT bis! ;  \ OTG_FS_HOST-FS_HPRT_POCA    Port overcurrent active
: OTG_FS_HOST-FS_HPRT_POCCHNG   %1 5 lshift OTG_FS_HOST-FS_HPRT bis! ;  \ OTG_FS_HOST-FS_HPRT_POCCHNG    Port overcurrent change
: OTG_FS_HOST-FS_HPRT_PRES   %1 6 lshift OTG_FS_HOST-FS_HPRT bis! ;  \ OTG_FS_HOST-FS_HPRT_PRES    Port resume
: OTG_FS_HOST-FS_HPRT_PSUSP   %1 7 lshift OTG_FS_HOST-FS_HPRT bis! ;  \ OTG_FS_HOST-FS_HPRT_PSUSP    Port suspend
: OTG_FS_HOST-FS_HPRT_PRST   %1 8 lshift OTG_FS_HOST-FS_HPRT bis! ;  \ OTG_FS_HOST-FS_HPRT_PRST    Port reset
: OTG_FS_HOST-FS_HPRT_PLSTS   ( %XX -- ) 10 lshift OTG_FS_HOST-FS_HPRT bis! ;  \ OTG_FS_HOST-FS_HPRT_PLSTS    Port line status
: OTG_FS_HOST-FS_HPRT_PPWR   %1 12 lshift OTG_FS_HOST-FS_HPRT bis! ;  \ OTG_FS_HOST-FS_HPRT_PPWR    Port power
: OTG_FS_HOST-FS_HPRT_PTCTL   ( %XXXX -- ) 13 lshift OTG_FS_HOST-FS_HPRT bis! ;  \ OTG_FS_HOST-FS_HPRT_PTCTL    Port test control
: OTG_FS_HOST-FS_HPRT_PSPD   ( %XX -- ) 17 lshift OTG_FS_HOST-FS_HPRT bis! ;  \ OTG_FS_HOST-FS_HPRT_PSPD    Port speed

\ OTG_FS_HOST-FS_HCCHAR0 (read-write)
: OTG_FS_HOST-FS_HCCHAR0_MPSIZ  0 lshift OTG_FS_HOST-FS_HCCHAR0 bis! ;  \ OTG_FS_HOST-FS_HCCHAR0_MPSIZ    Maximum packet size
: OTG_FS_HOST-FS_HCCHAR0_EPNUM   ( %XXXX -- ) 11 lshift OTG_FS_HOST-FS_HCCHAR0 bis! ;  \ OTG_FS_HOST-FS_HCCHAR0_EPNUM    Endpoint number
: OTG_FS_HOST-FS_HCCHAR0_EPDIR   %1 15 lshift OTG_FS_HOST-FS_HCCHAR0 bis! ;  \ OTG_FS_HOST-FS_HCCHAR0_EPDIR    Endpoint direction
: OTG_FS_HOST-FS_HCCHAR0_LSDEV   %1 17 lshift OTG_FS_HOST-FS_HCCHAR0 bis! ;  \ OTG_FS_HOST-FS_HCCHAR0_LSDEV    Low-speed device
: OTG_FS_HOST-FS_HCCHAR0_EPTYP   ( %XX -- ) 18 lshift OTG_FS_HOST-FS_HCCHAR0 bis! ;  \ OTG_FS_HOST-FS_HCCHAR0_EPTYP    Endpoint type
: OTG_FS_HOST-FS_HCCHAR0_MCNT   ( %XX -- ) 20 lshift OTG_FS_HOST-FS_HCCHAR0 bis! ;  \ OTG_FS_HOST-FS_HCCHAR0_MCNT    Multicount
: OTG_FS_HOST-FS_HCCHAR0_DAD   ( %XXXXXXX -- ) 22 lshift OTG_FS_HOST-FS_HCCHAR0 bis! ;  \ OTG_FS_HOST-FS_HCCHAR0_DAD    Device address
: OTG_FS_HOST-FS_HCCHAR0_ODDFRM   %1 29 lshift OTG_FS_HOST-FS_HCCHAR0 bis! ;  \ OTG_FS_HOST-FS_HCCHAR0_ODDFRM    Odd frame
: OTG_FS_HOST-FS_HCCHAR0_CHDIS   %1 30 lshift OTG_FS_HOST-FS_HCCHAR0 bis! ;  \ OTG_FS_HOST-FS_HCCHAR0_CHDIS    Channel disable
: OTG_FS_HOST-FS_HCCHAR0_CHENA   %1 31 lshift OTG_FS_HOST-FS_HCCHAR0 bis! ;  \ OTG_FS_HOST-FS_HCCHAR0_CHENA    Channel enable

\ OTG_FS_HOST-FS_HCCHAR1 (read-write)
: OTG_FS_HOST-FS_HCCHAR1_MPSIZ  0 lshift OTG_FS_HOST-FS_HCCHAR1 bis! ;  \ OTG_FS_HOST-FS_HCCHAR1_MPSIZ    Maximum packet size
: OTG_FS_HOST-FS_HCCHAR1_EPNUM   ( %XXXX -- ) 11 lshift OTG_FS_HOST-FS_HCCHAR1 bis! ;  \ OTG_FS_HOST-FS_HCCHAR1_EPNUM    Endpoint number
: OTG_FS_HOST-FS_HCCHAR1_EPDIR   %1 15 lshift OTG_FS_HOST-FS_HCCHAR1 bis! ;  \ OTG_FS_HOST-FS_HCCHAR1_EPDIR    Endpoint direction
: OTG_FS_HOST-FS_HCCHAR1_LSDEV   %1 17 lshift OTG_FS_HOST-FS_HCCHAR1 bis! ;  \ OTG_FS_HOST-FS_HCCHAR1_LSDEV    Low-speed device
: OTG_FS_HOST-FS_HCCHAR1_EPTYP   ( %XX -- ) 18 lshift OTG_FS_HOST-FS_HCCHAR1 bis! ;  \ OTG_FS_HOST-FS_HCCHAR1_EPTYP    Endpoint type
: OTG_FS_HOST-FS_HCCHAR1_MCNT   ( %XX -- ) 20 lshift OTG_FS_HOST-FS_HCCHAR1 bis! ;  \ OTG_FS_HOST-FS_HCCHAR1_MCNT    Multicount
: OTG_FS_HOST-FS_HCCHAR1_DAD   ( %XXXXXXX -- ) 22 lshift OTG_FS_HOST-FS_HCCHAR1 bis! ;  \ OTG_FS_HOST-FS_HCCHAR1_DAD    Device address
: OTG_FS_HOST-FS_HCCHAR1_ODDFRM   %1 29 lshift OTG_FS_HOST-FS_HCCHAR1 bis! ;  \ OTG_FS_HOST-FS_HCCHAR1_ODDFRM    Odd frame
: OTG_FS_HOST-FS_HCCHAR1_CHDIS   %1 30 lshift OTG_FS_HOST-FS_HCCHAR1 bis! ;  \ OTG_FS_HOST-FS_HCCHAR1_CHDIS    Channel disable
: OTG_FS_HOST-FS_HCCHAR1_CHENA   %1 31 lshift OTG_FS_HOST-FS_HCCHAR1 bis! ;  \ OTG_FS_HOST-FS_HCCHAR1_CHENA    Channel enable

\ OTG_FS_HOST-FS_HCCHAR2 (read-write)
: OTG_FS_HOST-FS_HCCHAR2_MPSIZ  0 lshift OTG_FS_HOST-FS_HCCHAR2 bis! ;  \ OTG_FS_HOST-FS_HCCHAR2_MPSIZ    Maximum packet size
: OTG_FS_HOST-FS_HCCHAR2_EPNUM   ( %XXXX -- ) 11 lshift OTG_FS_HOST-FS_HCCHAR2 bis! ;  \ OTG_FS_HOST-FS_HCCHAR2_EPNUM    Endpoint number
: OTG_FS_HOST-FS_HCCHAR2_EPDIR   %1 15 lshift OTG_FS_HOST-FS_HCCHAR2 bis! ;  \ OTG_FS_HOST-FS_HCCHAR2_EPDIR    Endpoint direction
: OTG_FS_HOST-FS_HCCHAR2_LSDEV   %1 17 lshift OTG_FS_HOST-FS_HCCHAR2 bis! ;  \ OTG_FS_HOST-FS_HCCHAR2_LSDEV    Low-speed device
: OTG_FS_HOST-FS_HCCHAR2_EPTYP   ( %XX -- ) 18 lshift OTG_FS_HOST-FS_HCCHAR2 bis! ;  \ OTG_FS_HOST-FS_HCCHAR2_EPTYP    Endpoint type
: OTG_FS_HOST-FS_HCCHAR2_MCNT   ( %XX -- ) 20 lshift OTG_FS_HOST-FS_HCCHAR2 bis! ;  \ OTG_FS_HOST-FS_HCCHAR2_MCNT    Multicount
: OTG_FS_HOST-FS_HCCHAR2_DAD   ( %XXXXXXX -- ) 22 lshift OTG_FS_HOST-FS_HCCHAR2 bis! ;  \ OTG_FS_HOST-FS_HCCHAR2_DAD    Device address
: OTG_FS_HOST-FS_HCCHAR2_ODDFRM   %1 29 lshift OTG_FS_HOST-FS_HCCHAR2 bis! ;  \ OTG_FS_HOST-FS_HCCHAR2_ODDFRM    Odd frame
: OTG_FS_HOST-FS_HCCHAR2_CHDIS   %1 30 lshift OTG_FS_HOST-FS_HCCHAR2 bis! ;  \ OTG_FS_HOST-FS_HCCHAR2_CHDIS    Channel disable
: OTG_FS_HOST-FS_HCCHAR2_CHENA   %1 31 lshift OTG_FS_HOST-FS_HCCHAR2 bis! ;  \ OTG_FS_HOST-FS_HCCHAR2_CHENA    Channel enable

\ OTG_FS_HOST-FS_HCCHAR3 (read-write)
: OTG_FS_HOST-FS_HCCHAR3_MPSIZ  0 lshift OTG_FS_HOST-FS_HCCHAR3 bis! ;  \ OTG_FS_HOST-FS_HCCHAR3_MPSIZ    Maximum packet size
: OTG_FS_HOST-FS_HCCHAR3_EPNUM   ( %XXXX -- ) 11 lshift OTG_FS_HOST-FS_HCCHAR3 bis! ;  \ OTG_FS_HOST-FS_HCCHAR3_EPNUM    Endpoint number
: OTG_FS_HOST-FS_HCCHAR3_EPDIR   %1 15 lshift OTG_FS_HOST-FS_HCCHAR3 bis! ;  \ OTG_FS_HOST-FS_HCCHAR3_EPDIR    Endpoint direction
: OTG_FS_HOST-FS_HCCHAR3_LSDEV   %1 17 lshift OTG_FS_HOST-FS_HCCHAR3 bis! ;  \ OTG_FS_HOST-FS_HCCHAR3_LSDEV    Low-speed device
: OTG_FS_HOST-FS_HCCHAR3_EPTYP   ( %XX -- ) 18 lshift OTG_FS_HOST-FS_HCCHAR3 bis! ;  \ OTG_FS_HOST-FS_HCCHAR3_EPTYP    Endpoint type
: OTG_FS_HOST-FS_HCCHAR3_MCNT   ( %XX -- ) 20 lshift OTG_FS_HOST-FS_HCCHAR3 bis! ;  \ OTG_FS_HOST-FS_HCCHAR3_MCNT    Multicount
: OTG_FS_HOST-FS_HCCHAR3_DAD   ( %XXXXXXX -- ) 22 lshift OTG_FS_HOST-FS_HCCHAR3 bis! ;  \ OTG_FS_HOST-FS_HCCHAR3_DAD    Device address
: OTG_FS_HOST-FS_HCCHAR3_ODDFRM   %1 29 lshift OTG_FS_HOST-FS_HCCHAR3 bis! ;  \ OTG_FS_HOST-FS_HCCHAR3_ODDFRM    Odd frame
: OTG_FS_HOST-FS_HCCHAR3_CHDIS   %1 30 lshift OTG_FS_HOST-FS_HCCHAR3 bis! ;  \ OTG_FS_HOST-FS_HCCHAR3_CHDIS    Channel disable
: OTG_FS_HOST-FS_HCCHAR3_CHENA   %1 31 lshift OTG_FS_HOST-FS_HCCHAR3 bis! ;  \ OTG_FS_HOST-FS_HCCHAR3_CHENA    Channel enable

\ OTG_FS_HOST-FS_HCCHAR4 (read-write)
: OTG_FS_HOST-FS_HCCHAR4_MPSIZ  0 lshift OTG_FS_HOST-FS_HCCHAR4 bis! ;  \ OTG_FS_HOST-FS_HCCHAR4_MPSIZ    Maximum packet size
: OTG_FS_HOST-FS_HCCHAR4_EPNUM   ( %XXXX -- ) 11 lshift OTG_FS_HOST-FS_HCCHAR4 bis! ;  \ OTG_FS_HOST-FS_HCCHAR4_EPNUM    Endpoint number
: OTG_FS_HOST-FS_HCCHAR4_EPDIR   %1 15 lshift OTG_FS_HOST-FS_HCCHAR4 bis! ;  \ OTG_FS_HOST-FS_HCCHAR4_EPDIR    Endpoint direction
: OTG_FS_HOST-FS_HCCHAR4_LSDEV   %1 17 lshift OTG_FS_HOST-FS_HCCHAR4 bis! ;  \ OTG_FS_HOST-FS_HCCHAR4_LSDEV    Low-speed device
: OTG_FS_HOST-FS_HCCHAR4_EPTYP   ( %XX -- ) 18 lshift OTG_FS_HOST-FS_HCCHAR4 bis! ;  \ OTG_FS_HOST-FS_HCCHAR4_EPTYP    Endpoint type
: OTG_FS_HOST-FS_HCCHAR4_MCNT   ( %XX -- ) 20 lshift OTG_FS_HOST-FS_HCCHAR4 bis! ;  \ OTG_FS_HOST-FS_HCCHAR4_MCNT    Multicount
: OTG_FS_HOST-FS_HCCHAR4_DAD   ( %XXXXXXX -- ) 22 lshift OTG_FS_HOST-FS_HCCHAR4 bis! ;  \ OTG_FS_HOST-FS_HCCHAR4_DAD    Device address
: OTG_FS_HOST-FS_HCCHAR4_ODDFRM   %1 29 lshift OTG_FS_HOST-FS_HCCHAR4 bis! ;  \ OTG_FS_HOST-FS_HCCHAR4_ODDFRM    Odd frame
: OTG_FS_HOST-FS_HCCHAR4_CHDIS   %1 30 lshift OTG_FS_HOST-FS_HCCHAR4 bis! ;  \ OTG_FS_HOST-FS_HCCHAR4_CHDIS    Channel disable
: OTG_FS_HOST-FS_HCCHAR4_CHENA   %1 31 lshift OTG_FS_HOST-FS_HCCHAR4 bis! ;  \ OTG_FS_HOST-FS_HCCHAR4_CHENA    Channel enable

\ OTG_FS_HOST-FS_HCCHAR5 (read-write)
: OTG_FS_HOST-FS_HCCHAR5_MPSIZ  0 lshift OTG_FS_HOST-FS_HCCHAR5 bis! ;  \ OTG_FS_HOST-FS_HCCHAR5_MPSIZ    Maximum packet size
: OTG_FS_HOST-FS_HCCHAR5_EPNUM   ( %XXXX -- ) 11 lshift OTG_FS_HOST-FS_HCCHAR5 bis! ;  \ OTG_FS_HOST-FS_HCCHAR5_EPNUM    Endpoint number
: OTG_FS_HOST-FS_HCCHAR5_EPDIR   %1 15 lshift OTG_FS_HOST-FS_HCCHAR5 bis! ;  \ OTG_FS_HOST-FS_HCCHAR5_EPDIR    Endpoint direction
: OTG_FS_HOST-FS_HCCHAR5_LSDEV   %1 17 lshift OTG_FS_HOST-FS_HCCHAR5 bis! ;  \ OTG_FS_HOST-FS_HCCHAR5_LSDEV    Low-speed device
: OTG_FS_HOST-FS_HCCHAR5_EPTYP   ( %XX -- ) 18 lshift OTG_FS_HOST-FS_HCCHAR5 bis! ;  \ OTG_FS_HOST-FS_HCCHAR5_EPTYP    Endpoint type
: OTG_FS_HOST-FS_HCCHAR5_MCNT   ( %XX -- ) 20 lshift OTG_FS_HOST-FS_HCCHAR5 bis! ;  \ OTG_FS_HOST-FS_HCCHAR5_MCNT    Multicount
: OTG_FS_HOST-FS_HCCHAR5_DAD   ( %XXXXXXX -- ) 22 lshift OTG_FS_HOST-FS_HCCHAR5 bis! ;  \ OTG_FS_HOST-FS_HCCHAR5_DAD    Device address
: OTG_FS_HOST-FS_HCCHAR5_ODDFRM   %1 29 lshift OTG_FS_HOST-FS_HCCHAR5 bis! ;  \ OTG_FS_HOST-FS_HCCHAR5_ODDFRM    Odd frame
: OTG_FS_HOST-FS_HCCHAR5_CHDIS   %1 30 lshift OTG_FS_HOST-FS_HCCHAR5 bis! ;  \ OTG_FS_HOST-FS_HCCHAR5_CHDIS    Channel disable
: OTG_FS_HOST-FS_HCCHAR5_CHENA   %1 31 lshift OTG_FS_HOST-FS_HCCHAR5 bis! ;  \ OTG_FS_HOST-FS_HCCHAR5_CHENA    Channel enable

\ OTG_FS_HOST-FS_HCCHAR6 (read-write)
: OTG_FS_HOST-FS_HCCHAR6_MPSIZ  0 lshift OTG_FS_HOST-FS_HCCHAR6 bis! ;  \ OTG_FS_HOST-FS_HCCHAR6_MPSIZ    Maximum packet size
: OTG_FS_HOST-FS_HCCHAR6_EPNUM   ( %XXXX -- ) 11 lshift OTG_FS_HOST-FS_HCCHAR6 bis! ;  \ OTG_FS_HOST-FS_HCCHAR6_EPNUM    Endpoint number
: OTG_FS_HOST-FS_HCCHAR6_EPDIR   %1 15 lshift OTG_FS_HOST-FS_HCCHAR6 bis! ;  \ OTG_FS_HOST-FS_HCCHAR6_EPDIR    Endpoint direction
: OTG_FS_HOST-FS_HCCHAR6_LSDEV   %1 17 lshift OTG_FS_HOST-FS_HCCHAR6 bis! ;  \ OTG_FS_HOST-FS_HCCHAR6_LSDEV    Low-speed device
: OTG_FS_HOST-FS_HCCHAR6_EPTYP   ( %XX -- ) 18 lshift OTG_FS_HOST-FS_HCCHAR6 bis! ;  \ OTG_FS_HOST-FS_HCCHAR6_EPTYP    Endpoint type
: OTG_FS_HOST-FS_HCCHAR6_MCNT   ( %XX -- ) 20 lshift OTG_FS_HOST-FS_HCCHAR6 bis! ;  \ OTG_FS_HOST-FS_HCCHAR6_MCNT    Multicount
: OTG_FS_HOST-FS_HCCHAR6_DAD   ( %XXXXXXX -- ) 22 lshift OTG_FS_HOST-FS_HCCHAR6 bis! ;  \ OTG_FS_HOST-FS_HCCHAR6_DAD    Device address
: OTG_FS_HOST-FS_HCCHAR6_ODDFRM   %1 29 lshift OTG_FS_HOST-FS_HCCHAR6 bis! ;  \ OTG_FS_HOST-FS_HCCHAR6_ODDFRM    Odd frame
: OTG_FS_HOST-FS_HCCHAR6_CHDIS   %1 30 lshift OTG_FS_HOST-FS_HCCHAR6 bis! ;  \ OTG_FS_HOST-FS_HCCHAR6_CHDIS    Channel disable
: OTG_FS_HOST-FS_HCCHAR6_CHENA   %1 31 lshift OTG_FS_HOST-FS_HCCHAR6 bis! ;  \ OTG_FS_HOST-FS_HCCHAR6_CHENA    Channel enable

\ OTG_FS_HOST-FS_HCCHAR7 (read-write)
: OTG_FS_HOST-FS_HCCHAR7_MPSIZ  0 lshift OTG_FS_HOST-FS_HCCHAR7 bis! ;  \ OTG_FS_HOST-FS_HCCHAR7_MPSIZ    Maximum packet size
: OTG_FS_HOST-FS_HCCHAR7_EPNUM   ( %XXXX -- ) 11 lshift OTG_FS_HOST-FS_HCCHAR7 bis! ;  \ OTG_FS_HOST-FS_HCCHAR7_EPNUM    Endpoint number
: OTG_FS_HOST-FS_HCCHAR7_EPDIR   %1 15 lshift OTG_FS_HOST-FS_HCCHAR7 bis! ;  \ OTG_FS_HOST-FS_HCCHAR7_EPDIR    Endpoint direction
: OTG_FS_HOST-FS_HCCHAR7_LSDEV   %1 17 lshift OTG_FS_HOST-FS_HCCHAR7 bis! ;  \ OTG_FS_HOST-FS_HCCHAR7_LSDEV    Low-speed device
: OTG_FS_HOST-FS_HCCHAR7_EPTYP   ( %XX -- ) 18 lshift OTG_FS_HOST-FS_HCCHAR7 bis! ;  \ OTG_FS_HOST-FS_HCCHAR7_EPTYP    Endpoint type
: OTG_FS_HOST-FS_HCCHAR7_MCNT   ( %XX -- ) 20 lshift OTG_FS_HOST-FS_HCCHAR7 bis! ;  \ OTG_FS_HOST-FS_HCCHAR7_MCNT    Multicount
: OTG_FS_HOST-FS_HCCHAR7_DAD   ( %XXXXXXX -- ) 22 lshift OTG_FS_HOST-FS_HCCHAR7 bis! ;  \ OTG_FS_HOST-FS_HCCHAR7_DAD    Device address
: OTG_FS_HOST-FS_HCCHAR7_ODDFRM   %1 29 lshift OTG_FS_HOST-FS_HCCHAR7 bis! ;  \ OTG_FS_HOST-FS_HCCHAR7_ODDFRM    Odd frame
: OTG_FS_HOST-FS_HCCHAR7_CHDIS   %1 30 lshift OTG_FS_HOST-FS_HCCHAR7 bis! ;  \ OTG_FS_HOST-FS_HCCHAR7_CHDIS    Channel disable
: OTG_FS_HOST-FS_HCCHAR7_CHENA   %1 31 lshift OTG_FS_HOST-FS_HCCHAR7 bis! ;  \ OTG_FS_HOST-FS_HCCHAR7_CHENA    Channel enable

\ OTG_FS_HOST-FS_HCINT0 (read-write)
: OTG_FS_HOST-FS_HCINT0_XFRC   %1 0 lshift OTG_FS_HOST-FS_HCINT0 bis! ;  \ OTG_FS_HOST-FS_HCINT0_XFRC    Transfer completed
: OTG_FS_HOST-FS_HCINT0_CHH   %1 1 lshift OTG_FS_HOST-FS_HCINT0 bis! ;  \ OTG_FS_HOST-FS_HCINT0_CHH    Channel halted
: OTG_FS_HOST-FS_HCINT0_STALL   %1 3 lshift OTG_FS_HOST-FS_HCINT0 bis! ;  \ OTG_FS_HOST-FS_HCINT0_STALL    STALL response received
  interrupt
: OTG_FS_HOST-FS_HCINT0_NAK   %1 4 lshift OTG_FS_HOST-FS_HCINT0 bis! ;  \ OTG_FS_HOST-FS_HCINT0_NAK    NAK response received
  interrupt
: OTG_FS_HOST-FS_HCINT0_ACK   %1 5 lshift OTG_FS_HOST-FS_HCINT0 bis! ;  \ OTG_FS_HOST-FS_HCINT0_ACK    ACK response received/transmitted
  interrupt
: OTG_FS_HOST-FS_HCINT0_TXERR   %1 7 lshift OTG_FS_HOST-FS_HCINT0 bis! ;  \ OTG_FS_HOST-FS_HCINT0_TXERR    Transaction error
: OTG_FS_HOST-FS_HCINT0_BBERR   %1 8 lshift OTG_FS_HOST-FS_HCINT0 bis! ;  \ OTG_FS_HOST-FS_HCINT0_BBERR    Babble error
: OTG_FS_HOST-FS_HCINT0_FRMOR   %1 9 lshift OTG_FS_HOST-FS_HCINT0 bis! ;  \ OTG_FS_HOST-FS_HCINT0_FRMOR    Frame overrun
: OTG_FS_HOST-FS_HCINT0_DTERR   %1 10 lshift OTG_FS_HOST-FS_HCINT0 bis! ;  \ OTG_FS_HOST-FS_HCINT0_DTERR    Data toggle error

\ OTG_FS_HOST-FS_HCINT1 (read-write)
: OTG_FS_HOST-FS_HCINT1_XFRC   %1 0 lshift OTG_FS_HOST-FS_HCINT1 bis! ;  \ OTG_FS_HOST-FS_HCINT1_XFRC    Transfer completed
: OTG_FS_HOST-FS_HCINT1_CHH   %1 1 lshift OTG_FS_HOST-FS_HCINT1 bis! ;  \ OTG_FS_HOST-FS_HCINT1_CHH    Channel halted
: OTG_FS_HOST-FS_HCINT1_STALL   %1 3 lshift OTG_FS_HOST-FS_HCINT1 bis! ;  \ OTG_FS_HOST-FS_HCINT1_STALL    STALL response received
  interrupt
: OTG_FS_HOST-FS_HCINT1_NAK   %1 4 lshift OTG_FS_HOST-FS_HCINT1 bis! ;  \ OTG_FS_HOST-FS_HCINT1_NAK    NAK response received
  interrupt
: OTG_FS_HOST-FS_HCINT1_ACK   %1 5 lshift OTG_FS_HOST-FS_HCINT1 bis! ;  \ OTG_FS_HOST-FS_HCINT1_ACK    ACK response received/transmitted
  interrupt
: OTG_FS_HOST-FS_HCINT1_TXERR   %1 7 lshift OTG_FS_HOST-FS_HCINT1 bis! ;  \ OTG_FS_HOST-FS_HCINT1_TXERR    Transaction error
: OTG_FS_HOST-FS_HCINT1_BBERR   %1 8 lshift OTG_FS_HOST-FS_HCINT1 bis! ;  \ OTG_FS_HOST-FS_HCINT1_BBERR    Babble error
: OTG_FS_HOST-FS_HCINT1_FRMOR   %1 9 lshift OTG_FS_HOST-FS_HCINT1 bis! ;  \ OTG_FS_HOST-FS_HCINT1_FRMOR    Frame overrun
: OTG_FS_HOST-FS_HCINT1_DTERR   %1 10 lshift OTG_FS_HOST-FS_HCINT1 bis! ;  \ OTG_FS_HOST-FS_HCINT1_DTERR    Data toggle error

\ OTG_FS_HOST-FS_HCINT2 (read-write)
: OTG_FS_HOST-FS_HCINT2_XFRC   %1 0 lshift OTG_FS_HOST-FS_HCINT2 bis! ;  \ OTG_FS_HOST-FS_HCINT2_XFRC    Transfer completed
: OTG_FS_HOST-FS_HCINT2_CHH   %1 1 lshift OTG_FS_HOST-FS_HCINT2 bis! ;  \ OTG_FS_HOST-FS_HCINT2_CHH    Channel halted
: OTG_FS_HOST-FS_HCINT2_STALL   %1 3 lshift OTG_FS_HOST-FS_HCINT2 bis! ;  \ OTG_FS_HOST-FS_HCINT2_STALL    STALL response received
  interrupt
: OTG_FS_HOST-FS_HCINT2_NAK   %1 4 lshift OTG_FS_HOST-FS_HCINT2 bis! ;  \ OTG_FS_HOST-FS_HCINT2_NAK    NAK response received
  interrupt
: OTG_FS_HOST-FS_HCINT2_ACK   %1 5 lshift OTG_FS_HOST-FS_HCINT2 bis! ;  \ OTG_FS_HOST-FS_HCINT2_ACK    ACK response received/transmitted
  interrupt
: OTG_FS_HOST-FS_HCINT2_TXERR   %1 7 lshift OTG_FS_HOST-FS_HCINT2 bis! ;  \ OTG_FS_HOST-FS_HCINT2_TXERR    Transaction error
: OTG_FS_HOST-FS_HCINT2_BBERR   %1 8 lshift OTG_FS_HOST-FS_HCINT2 bis! ;  \ OTG_FS_HOST-FS_HCINT2_BBERR    Babble error
: OTG_FS_HOST-FS_HCINT2_FRMOR   %1 9 lshift OTG_FS_HOST-FS_HCINT2 bis! ;  \ OTG_FS_HOST-FS_HCINT2_FRMOR    Frame overrun
: OTG_FS_HOST-FS_HCINT2_DTERR   %1 10 lshift OTG_FS_HOST-FS_HCINT2 bis! ;  \ OTG_FS_HOST-FS_HCINT2_DTERR    Data toggle error

\ OTG_FS_HOST-FS_HCINT3 (read-write)
: OTG_FS_HOST-FS_HCINT3_XFRC   %1 0 lshift OTG_FS_HOST-FS_HCINT3 bis! ;  \ OTG_FS_HOST-FS_HCINT3_XFRC    Transfer completed
: OTG_FS_HOST-FS_HCINT3_CHH   %1 1 lshift OTG_FS_HOST-FS_HCINT3 bis! ;  \ OTG_FS_HOST-FS_HCINT3_CHH    Channel halted
: OTG_FS_HOST-FS_HCINT3_STALL   %1 3 lshift OTG_FS_HOST-FS_HCINT3 bis! ;  \ OTG_FS_HOST-FS_HCINT3_STALL    STALL response received
  interrupt
: OTG_FS_HOST-FS_HCINT3_NAK   %1 4 lshift OTG_FS_HOST-FS_HCINT3 bis! ;  \ OTG_FS_HOST-FS_HCINT3_NAK    NAK response received
  interrupt
: OTG_FS_HOST-FS_HCINT3_ACK   %1 5 lshift OTG_FS_HOST-FS_HCINT3 bis! ;  \ OTG_FS_HOST-FS_HCINT3_ACK    ACK response received/transmitted
  interrupt
: OTG_FS_HOST-FS_HCINT3_TXERR   %1 7 lshift OTG_FS_HOST-FS_HCINT3 bis! ;  \ OTG_FS_HOST-FS_HCINT3_TXERR    Transaction error
: OTG_FS_HOST-FS_HCINT3_BBERR   %1 8 lshift OTG_FS_HOST-FS_HCINT3 bis! ;  \ OTG_FS_HOST-FS_HCINT3_BBERR    Babble error
: OTG_FS_HOST-FS_HCINT3_FRMOR   %1 9 lshift OTG_FS_HOST-FS_HCINT3 bis! ;  \ OTG_FS_HOST-FS_HCINT3_FRMOR    Frame overrun
: OTG_FS_HOST-FS_HCINT3_DTERR   %1 10 lshift OTG_FS_HOST-FS_HCINT3 bis! ;  \ OTG_FS_HOST-FS_HCINT3_DTERR    Data toggle error

\ OTG_FS_HOST-FS_HCINT4 (read-write)
: OTG_FS_HOST-FS_HCINT4_XFRC   %1 0 lshift OTG_FS_HOST-FS_HCINT4 bis! ;  \ OTG_FS_HOST-FS_HCINT4_XFRC    Transfer completed
: OTG_FS_HOST-FS_HCINT4_CHH   %1 1 lshift OTG_FS_HOST-FS_HCINT4 bis! ;  \ OTG_FS_HOST-FS_HCINT4_CHH    Channel halted
: OTG_FS_HOST-FS_HCINT4_STALL   %1 3 lshift OTG_FS_HOST-FS_HCINT4 bis! ;  \ OTG_FS_HOST-FS_HCINT4_STALL    STALL response received
  interrupt
: OTG_FS_HOST-FS_HCINT4_NAK   %1 4 lshift OTG_FS_HOST-FS_HCINT4 bis! ;  \ OTG_FS_HOST-FS_HCINT4_NAK    NAK response received
  interrupt
: OTG_FS_HOST-FS_HCINT4_ACK   %1 5 lshift OTG_FS_HOST-FS_HCINT4 bis! ;  \ OTG_FS_HOST-FS_HCINT4_ACK    ACK response received/transmitted
  interrupt
: OTG_FS_HOST-FS_HCINT4_TXERR   %1 7 lshift OTG_FS_HOST-FS_HCINT4 bis! ;  \ OTG_FS_HOST-FS_HCINT4_TXERR    Transaction error
: OTG_FS_HOST-FS_HCINT4_BBERR   %1 8 lshift OTG_FS_HOST-FS_HCINT4 bis! ;  \ OTG_FS_HOST-FS_HCINT4_BBERR    Babble error
: OTG_FS_HOST-FS_HCINT4_FRMOR   %1 9 lshift OTG_FS_HOST-FS_HCINT4 bis! ;  \ OTG_FS_HOST-FS_HCINT4_FRMOR    Frame overrun
: OTG_FS_HOST-FS_HCINT4_DTERR   %1 10 lshift OTG_FS_HOST-FS_HCINT4 bis! ;  \ OTG_FS_HOST-FS_HCINT4_DTERR    Data toggle error

\ OTG_FS_HOST-FS_HCINT5 (read-write)
: OTG_FS_HOST-FS_HCINT5_XFRC   %1 0 lshift OTG_FS_HOST-FS_HCINT5 bis! ;  \ OTG_FS_HOST-FS_HCINT5_XFRC    Transfer completed
: OTG_FS_HOST-FS_HCINT5_CHH   %1 1 lshift OTG_FS_HOST-FS_HCINT5 bis! ;  \ OTG_FS_HOST-FS_HCINT5_CHH    Channel halted
: OTG_FS_HOST-FS_HCINT5_STALL   %1 3 lshift OTG_FS_HOST-FS_HCINT5 bis! ;  \ OTG_FS_HOST-FS_HCINT5_STALL    STALL response received
  interrupt
: OTG_FS_HOST-FS_HCINT5_NAK   %1 4 lshift OTG_FS_HOST-FS_HCINT5 bis! ;  \ OTG_FS_HOST-FS_HCINT5_NAK    NAK response received
  interrupt
: OTG_FS_HOST-FS_HCINT5_ACK   %1 5 lshift OTG_FS_HOST-FS_HCINT5 bis! ;  \ OTG_FS_HOST-FS_HCINT5_ACK    ACK response received/transmitted
  interrupt
: OTG_FS_HOST-FS_HCINT5_TXERR   %1 7 lshift OTG_FS_HOST-FS_HCINT5 bis! ;  \ OTG_FS_HOST-FS_HCINT5_TXERR    Transaction error
: OTG_FS_HOST-FS_HCINT5_BBERR   %1 8 lshift OTG_FS_HOST-FS_HCINT5 bis! ;  \ OTG_FS_HOST-FS_HCINT5_BBERR    Babble error
: OTG_FS_HOST-FS_HCINT5_FRMOR   %1 9 lshift OTG_FS_HOST-FS_HCINT5 bis! ;  \ OTG_FS_HOST-FS_HCINT5_FRMOR    Frame overrun
: OTG_FS_HOST-FS_HCINT5_DTERR   %1 10 lshift OTG_FS_HOST-FS_HCINT5 bis! ;  \ OTG_FS_HOST-FS_HCINT5_DTERR    Data toggle error

\ OTG_FS_HOST-FS_HCINT6 (read-write)
: OTG_FS_HOST-FS_HCINT6_XFRC   %1 0 lshift OTG_FS_HOST-FS_HCINT6 bis! ;  \ OTG_FS_HOST-FS_HCINT6_XFRC    Transfer completed
: OTG_FS_HOST-FS_HCINT6_CHH   %1 1 lshift OTG_FS_HOST-FS_HCINT6 bis! ;  \ OTG_FS_HOST-FS_HCINT6_CHH    Channel halted
: OTG_FS_HOST-FS_HCINT6_STALL   %1 3 lshift OTG_FS_HOST-FS_HCINT6 bis! ;  \ OTG_FS_HOST-FS_HCINT6_STALL    STALL response received
  interrupt
: OTG_FS_HOST-FS_HCINT6_NAK   %1 4 lshift OTG_FS_HOST-FS_HCINT6 bis! ;  \ OTG_FS_HOST-FS_HCINT6_NAK    NAK response received
  interrupt
: OTG_FS_HOST-FS_HCINT6_ACK   %1 5 lshift OTG_FS_HOST-FS_HCINT6 bis! ;  \ OTG_FS_HOST-FS_HCINT6_ACK    ACK response received/transmitted
  interrupt
: OTG_FS_HOST-FS_HCINT6_TXERR   %1 7 lshift OTG_FS_HOST-FS_HCINT6 bis! ;  \ OTG_FS_HOST-FS_HCINT6_TXERR    Transaction error
: OTG_FS_HOST-FS_HCINT6_BBERR   %1 8 lshift OTG_FS_HOST-FS_HCINT6 bis! ;  \ OTG_FS_HOST-FS_HCINT6_BBERR    Babble error
: OTG_FS_HOST-FS_HCINT6_FRMOR   %1 9 lshift OTG_FS_HOST-FS_HCINT6 bis! ;  \ OTG_FS_HOST-FS_HCINT6_FRMOR    Frame overrun
: OTG_FS_HOST-FS_HCINT6_DTERR   %1 10 lshift OTG_FS_HOST-FS_HCINT6 bis! ;  \ OTG_FS_HOST-FS_HCINT6_DTERR    Data toggle error

\ OTG_FS_HOST-FS_HCINT7 (read-write)
: OTG_FS_HOST-FS_HCINT7_XFRC   %1 0 lshift OTG_FS_HOST-FS_HCINT7 bis! ;  \ OTG_FS_HOST-FS_HCINT7_XFRC    Transfer completed
: OTG_FS_HOST-FS_HCINT7_CHH   %1 1 lshift OTG_FS_HOST-FS_HCINT7 bis! ;  \ OTG_FS_HOST-FS_HCINT7_CHH    Channel halted
: OTG_FS_HOST-FS_HCINT7_STALL   %1 3 lshift OTG_FS_HOST-FS_HCINT7 bis! ;  \ OTG_FS_HOST-FS_HCINT7_STALL    STALL response received
  interrupt
: OTG_FS_HOST-FS_HCINT7_NAK   %1 4 lshift OTG_FS_HOST-FS_HCINT7 bis! ;  \ OTG_FS_HOST-FS_HCINT7_NAK    NAK response received
  interrupt
: OTG_FS_HOST-FS_HCINT7_ACK   %1 5 lshift OTG_FS_HOST-FS_HCINT7 bis! ;  \ OTG_FS_HOST-FS_HCINT7_ACK    ACK response received/transmitted
  interrupt
: OTG_FS_HOST-FS_HCINT7_TXERR   %1 7 lshift OTG_FS_HOST-FS_HCINT7 bis! ;  \ OTG_FS_HOST-FS_HCINT7_TXERR    Transaction error
: OTG_FS_HOST-FS_HCINT7_BBERR   %1 8 lshift OTG_FS_HOST-FS_HCINT7 bis! ;  \ OTG_FS_HOST-FS_HCINT7_BBERR    Babble error
: OTG_FS_HOST-FS_HCINT7_FRMOR   %1 9 lshift OTG_FS_HOST-FS_HCINT7 bis! ;  \ OTG_FS_HOST-FS_HCINT7_FRMOR    Frame overrun
: OTG_FS_HOST-FS_HCINT7_DTERR   %1 10 lshift OTG_FS_HOST-FS_HCINT7 bis! ;  \ OTG_FS_HOST-FS_HCINT7_DTERR    Data toggle error

\ OTG_FS_HOST-FS_HCINTMSK0 (read-write)
: OTG_FS_HOST-FS_HCINTMSK0_XFRCM   %1 0 lshift OTG_FS_HOST-FS_HCINTMSK0 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK0_XFRCM    Transfer completed mask
: OTG_FS_HOST-FS_HCINTMSK0_CHHM   %1 1 lshift OTG_FS_HOST-FS_HCINTMSK0 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK0_CHHM    Channel halted mask
: OTG_FS_HOST-FS_HCINTMSK0_STALLM   %1 3 lshift OTG_FS_HOST-FS_HCINTMSK0 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK0_STALLM    STALL response received interrupt
  mask
: OTG_FS_HOST-FS_HCINTMSK0_NAKM   %1 4 lshift OTG_FS_HOST-FS_HCINTMSK0 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK0_NAKM    NAK response received interrupt
  mask
: OTG_FS_HOST-FS_HCINTMSK0_ACKM   %1 5 lshift OTG_FS_HOST-FS_HCINTMSK0 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK0_ACKM    ACK response received/transmitted
  interrupt mask
: OTG_FS_HOST-FS_HCINTMSK0_NYET   %1 6 lshift OTG_FS_HOST-FS_HCINTMSK0 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK0_NYET    response received interrupt
  mask
: OTG_FS_HOST-FS_HCINTMSK0_TXERRM   %1 7 lshift OTG_FS_HOST-FS_HCINTMSK0 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK0_TXERRM    Transaction error mask
: OTG_FS_HOST-FS_HCINTMSK0_BBERRM   %1 8 lshift OTG_FS_HOST-FS_HCINTMSK0 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK0_BBERRM    Babble error mask
: OTG_FS_HOST-FS_HCINTMSK0_FRMORM   %1 9 lshift OTG_FS_HOST-FS_HCINTMSK0 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK0_FRMORM    Frame overrun mask
: OTG_FS_HOST-FS_HCINTMSK0_DTERRM   %1 10 lshift OTG_FS_HOST-FS_HCINTMSK0 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK0_DTERRM    Data toggle error mask

\ OTG_FS_HOST-FS_HCINTMSK1 (read-write)
: OTG_FS_HOST-FS_HCINTMSK1_XFRCM   %1 0 lshift OTG_FS_HOST-FS_HCINTMSK1 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK1_XFRCM    Transfer completed mask
: OTG_FS_HOST-FS_HCINTMSK1_CHHM   %1 1 lshift OTG_FS_HOST-FS_HCINTMSK1 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK1_CHHM    Channel halted mask
: OTG_FS_HOST-FS_HCINTMSK1_STALLM   %1 3 lshift OTG_FS_HOST-FS_HCINTMSK1 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK1_STALLM    STALL response received interrupt
  mask
: OTG_FS_HOST-FS_HCINTMSK1_NAKM   %1 4 lshift OTG_FS_HOST-FS_HCINTMSK1 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK1_NAKM    NAK response received interrupt
  mask
: OTG_FS_HOST-FS_HCINTMSK1_ACKM   %1 5 lshift OTG_FS_HOST-FS_HCINTMSK1 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK1_ACKM    ACK response received/transmitted
  interrupt mask
: OTG_FS_HOST-FS_HCINTMSK1_NYET   %1 6 lshift OTG_FS_HOST-FS_HCINTMSK1 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK1_NYET    response received interrupt
  mask
: OTG_FS_HOST-FS_HCINTMSK1_TXERRM   %1 7 lshift OTG_FS_HOST-FS_HCINTMSK1 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK1_TXERRM    Transaction error mask
: OTG_FS_HOST-FS_HCINTMSK1_BBERRM   %1 8 lshift OTG_FS_HOST-FS_HCINTMSK1 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK1_BBERRM    Babble error mask
: OTG_FS_HOST-FS_HCINTMSK1_FRMORM   %1 9 lshift OTG_FS_HOST-FS_HCINTMSK1 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK1_FRMORM    Frame overrun mask
: OTG_FS_HOST-FS_HCINTMSK1_DTERRM   %1 10 lshift OTG_FS_HOST-FS_HCINTMSK1 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK1_DTERRM    Data toggle error mask

\ OTG_FS_HOST-FS_HCINTMSK2 (read-write)
: OTG_FS_HOST-FS_HCINTMSK2_XFRCM   %1 0 lshift OTG_FS_HOST-FS_HCINTMSK2 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK2_XFRCM    Transfer completed mask
: OTG_FS_HOST-FS_HCINTMSK2_CHHM   %1 1 lshift OTG_FS_HOST-FS_HCINTMSK2 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK2_CHHM    Channel halted mask
: OTG_FS_HOST-FS_HCINTMSK2_STALLM   %1 3 lshift OTG_FS_HOST-FS_HCINTMSK2 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK2_STALLM    STALL response received interrupt
  mask
: OTG_FS_HOST-FS_HCINTMSK2_NAKM   %1 4 lshift OTG_FS_HOST-FS_HCINTMSK2 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK2_NAKM    NAK response received interrupt
  mask
: OTG_FS_HOST-FS_HCINTMSK2_ACKM   %1 5 lshift OTG_FS_HOST-FS_HCINTMSK2 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK2_ACKM    ACK response received/transmitted
  interrupt mask
: OTG_FS_HOST-FS_HCINTMSK2_NYET   %1 6 lshift OTG_FS_HOST-FS_HCINTMSK2 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK2_NYET    response received interrupt
  mask
: OTG_FS_HOST-FS_HCINTMSK2_TXERRM   %1 7 lshift OTG_FS_HOST-FS_HCINTMSK2 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK2_TXERRM    Transaction error mask
: OTG_FS_HOST-FS_HCINTMSK2_BBERRM   %1 8 lshift OTG_FS_HOST-FS_HCINTMSK2 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK2_BBERRM    Babble error mask
: OTG_FS_HOST-FS_HCINTMSK2_FRMORM   %1 9 lshift OTG_FS_HOST-FS_HCINTMSK2 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK2_FRMORM    Frame overrun mask
: OTG_FS_HOST-FS_HCINTMSK2_DTERRM   %1 10 lshift OTG_FS_HOST-FS_HCINTMSK2 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK2_DTERRM    Data toggle error mask

\ OTG_FS_HOST-FS_HCINTMSK3 (read-write)
: OTG_FS_HOST-FS_HCINTMSK3_XFRCM   %1 0 lshift OTG_FS_HOST-FS_HCINTMSK3 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK3_XFRCM    Transfer completed mask
: OTG_FS_HOST-FS_HCINTMSK3_CHHM   %1 1 lshift OTG_FS_HOST-FS_HCINTMSK3 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK3_CHHM    Channel halted mask
: OTG_FS_HOST-FS_HCINTMSK3_STALLM   %1 3 lshift OTG_FS_HOST-FS_HCINTMSK3 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK3_STALLM    STALL response received interrupt
  mask
: OTG_FS_HOST-FS_HCINTMSK3_NAKM   %1 4 lshift OTG_FS_HOST-FS_HCINTMSK3 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK3_NAKM    NAK response received interrupt
  mask
: OTG_FS_HOST-FS_HCINTMSK3_ACKM   %1 5 lshift OTG_FS_HOST-FS_HCINTMSK3 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK3_ACKM    ACK response received/transmitted
  interrupt mask
: OTG_FS_HOST-FS_HCINTMSK3_NYET   %1 6 lshift OTG_FS_HOST-FS_HCINTMSK3 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK3_NYET    response received interrupt
  mask
: OTG_FS_HOST-FS_HCINTMSK3_TXERRM   %1 7 lshift OTG_FS_HOST-FS_HCINTMSK3 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK3_TXERRM    Transaction error mask
: OTG_FS_HOST-FS_HCINTMSK3_BBERRM   %1 8 lshift OTG_FS_HOST-FS_HCINTMSK3 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK3_BBERRM    Babble error mask
: OTG_FS_HOST-FS_HCINTMSK3_FRMORM   %1 9 lshift OTG_FS_HOST-FS_HCINTMSK3 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK3_FRMORM    Frame overrun mask
: OTG_FS_HOST-FS_HCINTMSK3_DTERRM   %1 10 lshift OTG_FS_HOST-FS_HCINTMSK3 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK3_DTERRM    Data toggle error mask

\ OTG_FS_HOST-FS_HCINTMSK4 (read-write)
: OTG_FS_HOST-FS_HCINTMSK4_XFRCM   %1 0 lshift OTG_FS_HOST-FS_HCINTMSK4 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK4_XFRCM    Transfer completed mask
: OTG_FS_HOST-FS_HCINTMSK4_CHHM   %1 1 lshift OTG_FS_HOST-FS_HCINTMSK4 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK4_CHHM    Channel halted mask
: OTG_FS_HOST-FS_HCINTMSK4_STALLM   %1 3 lshift OTG_FS_HOST-FS_HCINTMSK4 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK4_STALLM    STALL response received interrupt
  mask
: OTG_FS_HOST-FS_HCINTMSK4_NAKM   %1 4 lshift OTG_FS_HOST-FS_HCINTMSK4 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK4_NAKM    NAK response received interrupt
  mask
: OTG_FS_HOST-FS_HCINTMSK4_ACKM   %1 5 lshift OTG_FS_HOST-FS_HCINTMSK4 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK4_ACKM    ACK response received/transmitted
  interrupt mask
: OTG_FS_HOST-FS_HCINTMSK4_NYET   %1 6 lshift OTG_FS_HOST-FS_HCINTMSK4 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK4_NYET    response received interrupt
  mask
: OTG_FS_HOST-FS_HCINTMSK4_TXERRM   %1 7 lshift OTG_FS_HOST-FS_HCINTMSK4 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK4_TXERRM    Transaction error mask
: OTG_FS_HOST-FS_HCINTMSK4_BBERRM   %1 8 lshift OTG_FS_HOST-FS_HCINTMSK4 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK4_BBERRM    Babble error mask
: OTG_FS_HOST-FS_HCINTMSK4_FRMORM   %1 9 lshift OTG_FS_HOST-FS_HCINTMSK4 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK4_FRMORM    Frame overrun mask
: OTG_FS_HOST-FS_HCINTMSK4_DTERRM   %1 10 lshift OTG_FS_HOST-FS_HCINTMSK4 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK4_DTERRM    Data toggle error mask

\ OTG_FS_HOST-FS_HCINTMSK5 (read-write)
: OTG_FS_HOST-FS_HCINTMSK5_XFRCM   %1 0 lshift OTG_FS_HOST-FS_HCINTMSK5 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK5_XFRCM    Transfer completed mask
: OTG_FS_HOST-FS_HCINTMSK5_CHHM   %1 1 lshift OTG_FS_HOST-FS_HCINTMSK5 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK5_CHHM    Channel halted mask
: OTG_FS_HOST-FS_HCINTMSK5_STALLM   %1 3 lshift OTG_FS_HOST-FS_HCINTMSK5 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK5_STALLM    STALL response received interrupt
  mask
: OTG_FS_HOST-FS_HCINTMSK5_NAKM   %1 4 lshift OTG_FS_HOST-FS_HCINTMSK5 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK5_NAKM    NAK response received interrupt
  mask
: OTG_FS_HOST-FS_HCINTMSK5_ACKM   %1 5 lshift OTG_FS_HOST-FS_HCINTMSK5 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK5_ACKM    ACK response received/transmitted
  interrupt mask
: OTG_FS_HOST-FS_HCINTMSK5_NYET   %1 6 lshift OTG_FS_HOST-FS_HCINTMSK5 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK5_NYET    response received interrupt
  mask
: OTG_FS_HOST-FS_HCINTMSK5_TXERRM   %1 7 lshift OTG_FS_HOST-FS_HCINTMSK5 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK5_TXERRM    Transaction error mask
: OTG_FS_HOST-FS_HCINTMSK5_BBERRM   %1 8 lshift OTG_FS_HOST-FS_HCINTMSK5 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK5_BBERRM    Babble error mask
: OTG_FS_HOST-FS_HCINTMSK5_FRMORM   %1 9 lshift OTG_FS_HOST-FS_HCINTMSK5 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK5_FRMORM    Frame overrun mask
: OTG_FS_HOST-FS_HCINTMSK5_DTERRM   %1 10 lshift OTG_FS_HOST-FS_HCINTMSK5 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK5_DTERRM    Data toggle error mask

\ OTG_FS_HOST-FS_HCINTMSK6 (read-write)
: OTG_FS_HOST-FS_HCINTMSK6_XFRCM   %1 0 lshift OTG_FS_HOST-FS_HCINTMSK6 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK6_XFRCM    Transfer completed mask
: OTG_FS_HOST-FS_HCINTMSK6_CHHM   %1 1 lshift OTG_FS_HOST-FS_HCINTMSK6 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK6_CHHM    Channel halted mask
: OTG_FS_HOST-FS_HCINTMSK6_STALLM   %1 3 lshift OTG_FS_HOST-FS_HCINTMSK6 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK6_STALLM    STALL response received interrupt
  mask
: OTG_FS_HOST-FS_HCINTMSK6_NAKM   %1 4 lshift OTG_FS_HOST-FS_HCINTMSK6 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK6_NAKM    NAK response received interrupt
  mask
: OTG_FS_HOST-FS_HCINTMSK6_ACKM   %1 5 lshift OTG_FS_HOST-FS_HCINTMSK6 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK6_ACKM    ACK response received/transmitted
  interrupt mask
: OTG_FS_HOST-FS_HCINTMSK6_NYET   %1 6 lshift OTG_FS_HOST-FS_HCINTMSK6 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK6_NYET    response received interrupt
  mask
: OTG_FS_HOST-FS_HCINTMSK6_TXERRM   %1 7 lshift OTG_FS_HOST-FS_HCINTMSK6 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK6_TXERRM    Transaction error mask
: OTG_FS_HOST-FS_HCINTMSK6_BBERRM   %1 8 lshift OTG_FS_HOST-FS_HCINTMSK6 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK6_BBERRM    Babble error mask
: OTG_FS_HOST-FS_HCINTMSK6_FRMORM   %1 9 lshift OTG_FS_HOST-FS_HCINTMSK6 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK6_FRMORM    Frame overrun mask
: OTG_FS_HOST-FS_HCINTMSK6_DTERRM   %1 10 lshift OTG_FS_HOST-FS_HCINTMSK6 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK6_DTERRM    Data toggle error mask

\ OTG_FS_HOST-FS_HCINTMSK7 (read-write)
: OTG_FS_HOST-FS_HCINTMSK7_XFRCM   %1 0 lshift OTG_FS_HOST-FS_HCINTMSK7 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK7_XFRCM    Transfer completed mask
: OTG_FS_HOST-FS_HCINTMSK7_CHHM   %1 1 lshift OTG_FS_HOST-FS_HCINTMSK7 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK7_CHHM    Channel halted mask
: OTG_FS_HOST-FS_HCINTMSK7_STALLM   %1 3 lshift OTG_FS_HOST-FS_HCINTMSK7 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK7_STALLM    STALL response received interrupt
  mask
: OTG_FS_HOST-FS_HCINTMSK7_NAKM   %1 4 lshift OTG_FS_HOST-FS_HCINTMSK7 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK7_NAKM    NAK response received interrupt
  mask
: OTG_FS_HOST-FS_HCINTMSK7_ACKM   %1 5 lshift OTG_FS_HOST-FS_HCINTMSK7 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK7_ACKM    ACK response received/transmitted
  interrupt mask
: OTG_FS_HOST-FS_HCINTMSK7_NYET   %1 6 lshift OTG_FS_HOST-FS_HCINTMSK7 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK7_NYET    response received interrupt
  mask
: OTG_FS_HOST-FS_HCINTMSK7_TXERRM   %1 7 lshift OTG_FS_HOST-FS_HCINTMSK7 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK7_TXERRM    Transaction error mask
: OTG_FS_HOST-FS_HCINTMSK7_BBERRM   %1 8 lshift OTG_FS_HOST-FS_HCINTMSK7 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK7_BBERRM    Babble error mask
: OTG_FS_HOST-FS_HCINTMSK7_FRMORM   %1 9 lshift OTG_FS_HOST-FS_HCINTMSK7 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK7_FRMORM    Frame overrun mask
: OTG_FS_HOST-FS_HCINTMSK7_DTERRM   %1 10 lshift OTG_FS_HOST-FS_HCINTMSK7 bis! ;  \ OTG_FS_HOST-FS_HCINTMSK7_DTERRM    Data toggle error mask

\ OTG_FS_HOST-FS_HCTSIZ0 (read-write)
: OTG_FS_HOST-FS_HCTSIZ0_XFRSIZ  0 lshift OTG_FS_HOST-FS_HCTSIZ0 bis! ;  \ OTG_FS_HOST-FS_HCTSIZ0_XFRSIZ    Transfer size
: OTG_FS_HOST-FS_HCTSIZ0_PKTCNT  19 lshift OTG_FS_HOST-FS_HCTSIZ0 bis! ;  \ OTG_FS_HOST-FS_HCTSIZ0_PKTCNT    Packet count
: OTG_FS_HOST-FS_HCTSIZ0_DPID   ( %XX -- ) 29 lshift OTG_FS_HOST-FS_HCTSIZ0 bis! ;  \ OTG_FS_HOST-FS_HCTSIZ0_DPID    Data PID

\ OTG_FS_HOST-FS_HCTSIZ1 (read-write)
: OTG_FS_HOST-FS_HCTSIZ1_XFRSIZ  0 lshift OTG_FS_HOST-FS_HCTSIZ1 bis! ;  \ OTG_FS_HOST-FS_HCTSIZ1_XFRSIZ    Transfer size
: OTG_FS_HOST-FS_HCTSIZ1_PKTCNT  19 lshift OTG_FS_HOST-FS_HCTSIZ1 bis! ;  \ OTG_FS_HOST-FS_HCTSIZ1_PKTCNT    Packet count
: OTG_FS_HOST-FS_HCTSIZ1_DPID   ( %XX -- ) 29 lshift OTG_FS_HOST-FS_HCTSIZ1 bis! ;  \ OTG_FS_HOST-FS_HCTSIZ1_DPID    Data PID

\ OTG_FS_HOST-FS_HCTSIZ2 (read-write)
: OTG_FS_HOST-FS_HCTSIZ2_XFRSIZ  0 lshift OTG_FS_HOST-FS_HCTSIZ2 bis! ;  \ OTG_FS_HOST-FS_HCTSIZ2_XFRSIZ    Transfer size
: OTG_FS_HOST-FS_HCTSIZ2_PKTCNT  19 lshift OTG_FS_HOST-FS_HCTSIZ2 bis! ;  \ OTG_FS_HOST-FS_HCTSIZ2_PKTCNT    Packet count
: OTG_FS_HOST-FS_HCTSIZ2_DPID   ( %XX -- ) 29 lshift OTG_FS_HOST-FS_HCTSIZ2 bis! ;  \ OTG_FS_HOST-FS_HCTSIZ2_DPID    Data PID

\ OTG_FS_HOST-FS_HCTSIZ3 (read-write)
: OTG_FS_HOST-FS_HCTSIZ3_XFRSIZ  0 lshift OTG_FS_HOST-FS_HCTSIZ3 bis! ;  \ OTG_FS_HOST-FS_HCTSIZ3_XFRSIZ    Transfer size
: OTG_FS_HOST-FS_HCTSIZ3_PKTCNT  19 lshift OTG_FS_HOST-FS_HCTSIZ3 bis! ;  \ OTG_FS_HOST-FS_HCTSIZ3_PKTCNT    Packet count
: OTG_FS_HOST-FS_HCTSIZ3_DPID   ( %XX -- ) 29 lshift OTG_FS_HOST-FS_HCTSIZ3 bis! ;  \ OTG_FS_HOST-FS_HCTSIZ3_DPID    Data PID

\ OTG_FS_HOST-FS_HCTSIZ4 (read-write)
: OTG_FS_HOST-FS_HCTSIZ4_XFRSIZ  0 lshift OTG_FS_HOST-FS_HCTSIZ4 bis! ;  \ OTG_FS_HOST-FS_HCTSIZ4_XFRSIZ    Transfer size
: OTG_FS_HOST-FS_HCTSIZ4_PKTCNT  19 lshift OTG_FS_HOST-FS_HCTSIZ4 bis! ;  \ OTG_FS_HOST-FS_HCTSIZ4_PKTCNT    Packet count
: OTG_FS_HOST-FS_HCTSIZ4_DPID   ( %XX -- ) 29 lshift OTG_FS_HOST-FS_HCTSIZ4 bis! ;  \ OTG_FS_HOST-FS_HCTSIZ4_DPID    Data PID

\ OTG_FS_HOST-FS_HCTSIZ5 (read-write)
: OTG_FS_HOST-FS_HCTSIZ5_XFRSIZ  0 lshift OTG_FS_HOST-FS_HCTSIZ5 bis! ;  \ OTG_FS_HOST-FS_HCTSIZ5_XFRSIZ    Transfer size
: OTG_FS_HOST-FS_HCTSIZ5_PKTCNT  19 lshift OTG_FS_HOST-FS_HCTSIZ5 bis! ;  \ OTG_FS_HOST-FS_HCTSIZ5_PKTCNT    Packet count
: OTG_FS_HOST-FS_HCTSIZ5_DPID   ( %XX -- ) 29 lshift OTG_FS_HOST-FS_HCTSIZ5 bis! ;  \ OTG_FS_HOST-FS_HCTSIZ5_DPID    Data PID

\ OTG_FS_HOST-FS_HCTSIZ6 (read-write)
: OTG_FS_HOST-FS_HCTSIZ6_XFRSIZ  0 lshift OTG_FS_HOST-FS_HCTSIZ6 bis! ;  \ OTG_FS_HOST-FS_HCTSIZ6_XFRSIZ    Transfer size
: OTG_FS_HOST-FS_HCTSIZ6_PKTCNT  19 lshift OTG_FS_HOST-FS_HCTSIZ6 bis! ;  \ OTG_FS_HOST-FS_HCTSIZ6_PKTCNT    Packet count
: OTG_FS_HOST-FS_HCTSIZ6_DPID   ( %XX -- ) 29 lshift OTG_FS_HOST-FS_HCTSIZ6 bis! ;  \ OTG_FS_HOST-FS_HCTSIZ6_DPID    Data PID

\ OTG_FS_HOST-FS_HCTSIZ7 (read-write)
: OTG_FS_HOST-FS_HCTSIZ7_XFRSIZ  0 lshift OTG_FS_HOST-FS_HCTSIZ7 bis! ;  \ OTG_FS_HOST-FS_HCTSIZ7_XFRSIZ    Transfer size
: OTG_FS_HOST-FS_HCTSIZ7_PKTCNT  19 lshift OTG_FS_HOST-FS_HCTSIZ7 bis! ;  \ OTG_FS_HOST-FS_HCTSIZ7_PKTCNT    Packet count
: OTG_FS_HOST-FS_HCTSIZ7_DPID   ( %XX -- ) 29 lshift OTG_FS_HOST-FS_HCTSIZ7 bis! ;  \ OTG_FS_HOST-FS_HCTSIZ7_DPID    Data PID

\ OTG_FS_PWRCLK-FS_PCGCCTL (read-write)
: OTG_FS_PWRCLK-FS_PCGCCTL_STPPCLK   %1 0 lshift OTG_FS_PWRCLK-FS_PCGCCTL bis! ;  \ OTG_FS_PWRCLK-FS_PCGCCTL_STPPCLK    Stop PHY clock
: OTG_FS_PWRCLK-FS_PCGCCTL_GATEHCLK   %1 1 lshift OTG_FS_PWRCLK-FS_PCGCCTL bis! ;  \ OTG_FS_PWRCLK-FS_PCGCCTL_GATEHCLK    Gate HCLK
: OTG_FS_PWRCLK-FS_PCGCCTL_PHYSUSP   %1 4 lshift OTG_FS_PWRCLK-FS_PCGCCTL bis! ;  \ OTG_FS_PWRCLK-FS_PCGCCTL_PHYSUSP    PHY Suspended

\ PWR-CR (read-write)
: PWR-CR_VOS   ( %XX -- ) 14 lshift PWR-CR bis! ;  \ PWR-CR_VOS    Regulator voltage scaling output
  selection
: PWR-CR_ADCDC1   %1 13 lshift PWR-CR bis! ;  \ PWR-CR_ADCDC1    ADCDC1
: PWR-CR_FPDS   %1 9 lshift PWR-CR bis! ;  \ PWR-CR_FPDS    Flash power down in Stop
  mode
: PWR-CR_DBP   %1 8 lshift PWR-CR bis! ;  \ PWR-CR_DBP    Disable backup domain write
  protection
: PWR-CR_PLS   ( %XXX -- ) 5 lshift PWR-CR bis! ;  \ PWR-CR_PLS    PVD level selection
: PWR-CR_PVDE   %1 4 lshift PWR-CR bis! ;  \ PWR-CR_PVDE    Power voltage detector
  enable
: PWR-CR_CSBF   %1 3 lshift PWR-CR bis! ;  \ PWR-CR_CSBF    Clear standby flag
: PWR-CR_CWUF   %1 2 lshift PWR-CR bis! ;  \ PWR-CR_CWUF    Clear wakeup flag
: PWR-CR_PDDS   %1 1 lshift PWR-CR bis! ;  \ PWR-CR_PDDS    Power down deepsleep
: PWR-CR_LPDS   %1 0 lshift PWR-CR bis! ;  \ PWR-CR_LPDS    Low-power deep sleep

\ PWR-CSR ()
: PWR-CSR_WUF   %1 0 lshift PWR-CSR bis! ;  \ PWR-CSR_WUF    Wakeup flag
: PWR-CSR_SBF   %1 1 lshift PWR-CSR bis! ;  \ PWR-CSR_SBF    Standby flag
: PWR-CSR_PVDO   %1 2 lshift PWR-CSR bis! ;  \ PWR-CSR_PVDO    PVD output
: PWR-CSR_BRR   %1 3 lshift PWR-CSR bis! ;  \ PWR-CSR_BRR    Backup regulator ready
: PWR-CSR_EWUP   %1 8 lshift PWR-CSR bis! ;  \ PWR-CSR_EWUP    Enable WKUP pin
: PWR-CSR_BRE   %1 9 lshift PWR-CSR bis! ;  \ PWR-CSR_BRE    Backup regulator enable
: PWR-CSR_VOSRDY   %1 14 lshift PWR-CSR bis! ;  \ PWR-CSR_VOSRDY    Regulator voltage scaling output
  selection ready bit

\ RCC-CR ()
: RCC-CR_PLLI2SRDY   %1 27 lshift RCC-CR bis! ;  \ RCC-CR_PLLI2SRDY    PLLI2S clock ready flag
: RCC-CR_PLLI2SON   %1 26 lshift RCC-CR bis! ;  \ RCC-CR_PLLI2SON    PLLI2S enable
: RCC-CR_PLLRDY   %1 25 lshift RCC-CR bis! ;  \ RCC-CR_PLLRDY    Main PLL PLL clock ready
  flag
: RCC-CR_PLLON   %1 24 lshift RCC-CR bis! ;  \ RCC-CR_PLLON    Main PLL PLL enable
: RCC-CR_CSSON   %1 19 lshift RCC-CR bis! ;  \ RCC-CR_CSSON    Clock security system
  enable
: RCC-CR_HSEBYP   %1 18 lshift RCC-CR bis! ;  \ RCC-CR_HSEBYP    HSE clock bypass
: RCC-CR_HSERDY   %1 17 lshift RCC-CR bis! ;  \ RCC-CR_HSERDY    HSE clock ready flag
: RCC-CR_HSEON   %1 16 lshift RCC-CR bis! ;  \ RCC-CR_HSEON    HSE clock enable
: RCC-CR_HSICAL   ( %XXXXXXXX -- ) 8 lshift RCC-CR bis! ;  \ RCC-CR_HSICAL    Internal high-speed clock
  calibration
: RCC-CR_HSITRIM   ( %XXXXX -- ) 3 lshift RCC-CR bis! ;  \ RCC-CR_HSITRIM    Internal high-speed clock
  trimming
: RCC-CR_HSIRDY   %1 1 lshift RCC-CR bis! ;  \ RCC-CR_HSIRDY    Internal high-speed clock ready
  flag
: RCC-CR_HSION   %1 0 lshift RCC-CR bis! ;  \ RCC-CR_HSION    Internal high-speed clock
  enable

\ RCC-PLLCFGR (read-write)
: RCC-PLLCFGR_PLLQ3   %1 27 lshift RCC-PLLCFGR bis! ;  \ RCC-PLLCFGR_PLLQ3    Main PLL PLL division factor for USB
  OTG FS, SDIO and random number generator
  clocks
: RCC-PLLCFGR_PLLQ2   %1 26 lshift RCC-PLLCFGR bis! ;  \ RCC-PLLCFGR_PLLQ2    Main PLL PLL division factor for USB
  OTG FS, SDIO and random number generator
  clocks
: RCC-PLLCFGR_PLLQ1   %1 25 lshift RCC-PLLCFGR bis! ;  \ RCC-PLLCFGR_PLLQ1    Main PLL PLL division factor for USB
  OTG FS, SDIO and random number generator
  clocks
: RCC-PLLCFGR_PLLQ0   %1 24 lshift RCC-PLLCFGR bis! ;  \ RCC-PLLCFGR_PLLQ0    Main PLL PLL division factor for USB
  OTG FS, SDIO and random number generator
  clocks
: RCC-PLLCFGR_PLLSRC   %1 22 lshift RCC-PLLCFGR bis! ;  \ RCC-PLLCFGR_PLLSRC    Main PLLPLL and audio PLL PLLI2S
  entry clock source
: RCC-PLLCFGR_PLLP1   %1 17 lshift RCC-PLLCFGR bis! ;  \ RCC-PLLCFGR_PLLP1    Main PLL PLL division factor for main
  system clock
: RCC-PLLCFGR_PLLP0   %1 16 lshift RCC-PLLCFGR bis! ;  \ RCC-PLLCFGR_PLLP0    Main PLL PLL division factor for main
  system clock
: RCC-PLLCFGR_PLLN8   %1 14 lshift RCC-PLLCFGR bis! ;  \ RCC-PLLCFGR_PLLN8    Main PLL PLL multiplication factor for
  VCO
: RCC-PLLCFGR_PLLN7   %1 13 lshift RCC-PLLCFGR bis! ;  \ RCC-PLLCFGR_PLLN7    Main PLL PLL multiplication factor for
  VCO
: RCC-PLLCFGR_PLLN6   %1 12 lshift RCC-PLLCFGR bis! ;  \ RCC-PLLCFGR_PLLN6    Main PLL PLL multiplication factor for
  VCO
: RCC-PLLCFGR_PLLN5   %1 11 lshift RCC-PLLCFGR bis! ;  \ RCC-PLLCFGR_PLLN5    Main PLL PLL multiplication factor for
  VCO
: RCC-PLLCFGR_PLLN4   %1 10 lshift RCC-PLLCFGR bis! ;  \ RCC-PLLCFGR_PLLN4    Main PLL PLL multiplication factor for
  VCO
: RCC-PLLCFGR_PLLN3   %1 9 lshift RCC-PLLCFGR bis! ;  \ RCC-PLLCFGR_PLLN3    Main PLL PLL multiplication factor for
  VCO
: RCC-PLLCFGR_PLLN2   %1 8 lshift RCC-PLLCFGR bis! ;  \ RCC-PLLCFGR_PLLN2    Main PLL PLL multiplication factor for
  VCO
: RCC-PLLCFGR_PLLN1   %1 7 lshift RCC-PLLCFGR bis! ;  \ RCC-PLLCFGR_PLLN1    Main PLL PLL multiplication factor for
  VCO
: RCC-PLLCFGR_PLLN0   %1 6 lshift RCC-PLLCFGR bis! ;  \ RCC-PLLCFGR_PLLN0    Main PLL PLL multiplication factor for
  VCO
: RCC-PLLCFGR_PLLM5   %1 5 lshift RCC-PLLCFGR bis! ;  \ RCC-PLLCFGR_PLLM5    Division factor for the main PLL PLL
  and audio PLL PLLI2S input clock
: RCC-PLLCFGR_PLLM4   %1 4 lshift RCC-PLLCFGR bis! ;  \ RCC-PLLCFGR_PLLM4    Division factor for the main PLL PLL
  and audio PLL PLLI2S input clock
: RCC-PLLCFGR_PLLM3   %1 3 lshift RCC-PLLCFGR bis! ;  \ RCC-PLLCFGR_PLLM3    Division factor for the main PLL PLL
  and audio PLL PLLI2S input clock
: RCC-PLLCFGR_PLLM2   %1 2 lshift RCC-PLLCFGR bis! ;  \ RCC-PLLCFGR_PLLM2    Division factor for the main PLL PLL
  and audio PLL PLLI2S input clock
: RCC-PLLCFGR_PLLM1   %1 1 lshift RCC-PLLCFGR bis! ;  \ RCC-PLLCFGR_PLLM1    Division factor for the main PLL PLL
  and audio PLL PLLI2S input clock
: RCC-PLLCFGR_PLLM0   %1 0 lshift RCC-PLLCFGR bis! ;  \ RCC-PLLCFGR_PLLM0    Division factor for the main PLL PLL
  and audio PLL PLLI2S input clock

\ RCC-CFGR ()
: RCC-CFGR_MCO2   ( %XX -- ) 30 lshift RCC-CFGR bis! ;  \ RCC-CFGR_MCO2    Microcontroller clock output
  2
: RCC-CFGR_MCO2PRE   ( %XXX -- ) 27 lshift RCC-CFGR bis! ;  \ RCC-CFGR_MCO2PRE    MCO2 prescaler
: RCC-CFGR_MCO1PRE   ( %XXX -- ) 24 lshift RCC-CFGR bis! ;  \ RCC-CFGR_MCO1PRE    MCO1 prescaler
: RCC-CFGR_I2SSRC   %1 23 lshift RCC-CFGR bis! ;  \ RCC-CFGR_I2SSRC    I2S clock selection
: RCC-CFGR_MCO1   ( %XX -- ) 21 lshift RCC-CFGR bis! ;  \ RCC-CFGR_MCO1    Microcontroller clock output
  1
: RCC-CFGR_RTCPRE   ( %XXXXX -- ) 16 lshift RCC-CFGR bis! ;  \ RCC-CFGR_RTCPRE    HSE division factor for RTC
  clock
: RCC-CFGR_PPRE2   ( %XXX -- ) 13 lshift RCC-CFGR bis! ;  \ RCC-CFGR_PPRE2    APB high-speed prescaler
  APB2
: RCC-CFGR_PPRE1   ( %XXX -- ) 10 lshift RCC-CFGR bis! ;  \ RCC-CFGR_PPRE1    APB Low speed prescaler
  APB1
: RCC-CFGR_HPRE   ( %XXXX -- ) 4 lshift RCC-CFGR bis! ;  \ RCC-CFGR_HPRE    AHB prescaler
: RCC-CFGR_SWS1   %1 3 lshift RCC-CFGR bis! ;  \ RCC-CFGR_SWS1    System clock switch status
: RCC-CFGR_SWS0   %1 2 lshift RCC-CFGR bis! ;  \ RCC-CFGR_SWS0    System clock switch status
: RCC-CFGR_SW1   %1 1 lshift RCC-CFGR bis! ;  \ RCC-CFGR_SW1    System clock switch
: RCC-CFGR_SW0   %1 0 lshift RCC-CFGR bis! ;  \ RCC-CFGR_SW0    System clock switch

\ RCC-CIR ()
: RCC-CIR_CSSC   %1 23 lshift RCC-CIR bis! ;  \ RCC-CIR_CSSC    Clock security system interrupt
  clear
: RCC-CIR_PLLI2SRDYC   %1 21 lshift RCC-CIR bis! ;  \ RCC-CIR_PLLI2SRDYC    PLLI2S ready interrupt
  clear
: RCC-CIR_PLLRDYC   %1 20 lshift RCC-CIR bis! ;  \ RCC-CIR_PLLRDYC    Main PLLPLL ready interrupt
  clear
: RCC-CIR_HSERDYC   %1 19 lshift RCC-CIR bis! ;  \ RCC-CIR_HSERDYC    HSE ready interrupt clear
: RCC-CIR_HSIRDYC   %1 18 lshift RCC-CIR bis! ;  \ RCC-CIR_HSIRDYC    HSI ready interrupt clear
: RCC-CIR_LSERDYC   %1 17 lshift RCC-CIR bis! ;  \ RCC-CIR_LSERDYC    LSE ready interrupt clear
: RCC-CIR_LSIRDYC   %1 16 lshift RCC-CIR bis! ;  \ RCC-CIR_LSIRDYC    LSI ready interrupt clear
: RCC-CIR_PLLI2SRDYIE   %1 13 lshift RCC-CIR bis! ;  \ RCC-CIR_PLLI2SRDYIE    PLLI2S ready interrupt
  enable
: RCC-CIR_PLLRDYIE   %1 12 lshift RCC-CIR bis! ;  \ RCC-CIR_PLLRDYIE    Main PLL PLL ready interrupt
  enable
: RCC-CIR_HSERDYIE   %1 11 lshift RCC-CIR bis! ;  \ RCC-CIR_HSERDYIE    HSE ready interrupt enable
: RCC-CIR_HSIRDYIE   %1 10 lshift RCC-CIR bis! ;  \ RCC-CIR_HSIRDYIE    HSI ready interrupt enable
: RCC-CIR_LSERDYIE   %1 9 lshift RCC-CIR bis! ;  \ RCC-CIR_LSERDYIE    LSE ready interrupt enable
: RCC-CIR_LSIRDYIE   %1 8 lshift RCC-CIR bis! ;  \ RCC-CIR_LSIRDYIE    LSI ready interrupt enable
: RCC-CIR_CSSF   %1 7 lshift RCC-CIR bis! ;  \ RCC-CIR_CSSF    Clock security system interrupt
  flag
: RCC-CIR_PLLI2SRDYF   %1 5 lshift RCC-CIR bis! ;  \ RCC-CIR_PLLI2SRDYF    PLLI2S ready interrupt
  flag
: RCC-CIR_PLLRDYF   %1 4 lshift RCC-CIR bis! ;  \ RCC-CIR_PLLRDYF    Main PLL PLL ready interrupt
  flag
: RCC-CIR_HSERDYF   %1 3 lshift RCC-CIR bis! ;  \ RCC-CIR_HSERDYF    HSE ready interrupt flag
: RCC-CIR_HSIRDYF   %1 2 lshift RCC-CIR bis! ;  \ RCC-CIR_HSIRDYF    HSI ready interrupt flag
: RCC-CIR_LSERDYF   %1 1 lshift RCC-CIR bis! ;  \ RCC-CIR_LSERDYF    LSE ready interrupt flag
: RCC-CIR_LSIRDYF   %1 0 lshift RCC-CIR bis! ;  \ RCC-CIR_LSIRDYF    LSI ready interrupt flag

\ RCC-AHB1RSTR (read-write)
: RCC-AHB1RSTR_DMA2RST   %1 22 lshift RCC-AHB1RSTR bis! ;  \ RCC-AHB1RSTR_DMA2RST    DMA2 reset
: RCC-AHB1RSTR_DMA1RST   %1 21 lshift RCC-AHB1RSTR bis! ;  \ RCC-AHB1RSTR_DMA1RST    DMA2 reset
: RCC-AHB1RSTR_CRCRST   %1 12 lshift RCC-AHB1RSTR bis! ;  \ RCC-AHB1RSTR_CRCRST    CRC reset
: RCC-AHB1RSTR_GPIOHRST   %1 7 lshift RCC-AHB1RSTR bis! ;  \ RCC-AHB1RSTR_GPIOHRST    IO port H reset
: RCC-AHB1RSTR_GPIOERST   %1 4 lshift RCC-AHB1RSTR bis! ;  \ RCC-AHB1RSTR_GPIOERST    IO port E reset
: RCC-AHB1RSTR_GPIODRST   %1 3 lshift RCC-AHB1RSTR bis! ;  \ RCC-AHB1RSTR_GPIODRST    IO port D reset
: RCC-AHB1RSTR_GPIOCRST   %1 2 lshift RCC-AHB1RSTR bis! ;  \ RCC-AHB1RSTR_GPIOCRST    IO port C reset
: RCC-AHB1RSTR_GPIOBRST   %1 1 lshift RCC-AHB1RSTR bis! ;  \ RCC-AHB1RSTR_GPIOBRST    IO port B reset
: RCC-AHB1RSTR_GPIOARST   %1 0 lshift RCC-AHB1RSTR bis! ;  \ RCC-AHB1RSTR_GPIOARST    IO port A reset

\ RCC-AHB2RSTR (read-write)
: RCC-AHB2RSTR_OTGFSRST   %1 7 lshift RCC-AHB2RSTR bis! ;  \ RCC-AHB2RSTR_OTGFSRST    USB OTG FS module reset

\ RCC-APB1RSTR (read-write)
: RCC-APB1RSTR_PWRRST   %1 28 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_PWRRST    Power interface reset
: RCC-APB1RSTR_I2C3RST   %1 23 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_I2C3RST    I2C3 reset
: RCC-APB1RSTR_I2C2RST   %1 22 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_I2C2RST    I2C 2 reset
: RCC-APB1RSTR_I2C1RST   %1 21 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_I2C1RST    I2C 1 reset
: RCC-APB1RSTR_UART2RST   %1 17 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_UART2RST    USART 2 reset
: RCC-APB1RSTR_SPI3RST   %1 15 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_SPI3RST    SPI 3 reset
: RCC-APB1RSTR_SPI2RST   %1 14 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_SPI2RST    SPI 2 reset
: RCC-APB1RSTR_WWDGRST   %1 11 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_WWDGRST    Window watchdog reset
: RCC-APB1RSTR_TIM5RST   %1 3 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_TIM5RST    TIM5 reset
: RCC-APB1RSTR_TIM4RST   %1 2 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_TIM4RST    TIM4 reset
: RCC-APB1RSTR_TIM3RST   %1 1 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_TIM3RST    TIM3 reset
: RCC-APB1RSTR_TIM2RST   %1 0 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_TIM2RST    TIM2 reset

\ RCC-APB2RSTR (read-write)
: RCC-APB2RSTR_TIM11RST   %1 18 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_TIM11RST    TIM11 reset
: RCC-APB2RSTR_TIM10RST   %1 17 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_TIM10RST    TIM10 reset
: RCC-APB2RSTR_TIM9RST   %1 16 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_TIM9RST    TIM9 reset
: RCC-APB2RSTR_SYSCFGRST   %1 14 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_SYSCFGRST    System configuration controller
  reset
: RCC-APB2RSTR_SPI1RST   %1 12 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_SPI1RST    SPI 1 reset
: RCC-APB2RSTR_SDIORST   %1 11 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_SDIORST    SDIO reset
: RCC-APB2RSTR_ADCRST   %1 8 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_ADCRST    ADC interface reset common to all
  ADCs
: RCC-APB2RSTR_USART6RST   %1 5 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_USART6RST    USART6 reset
: RCC-APB2RSTR_USART1RST   %1 4 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_USART1RST    USART1 reset
: RCC-APB2RSTR_TIM1RST   %1 0 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_TIM1RST    TIM1 reset

\ RCC-AHB1ENR (read-write)
: RCC-AHB1ENR_DMA2EN   %1 22 lshift RCC-AHB1ENR bis! ;  \ RCC-AHB1ENR_DMA2EN    DMA2 clock enable
: RCC-AHB1ENR_DMA1EN   %1 21 lshift RCC-AHB1ENR bis! ;  \ RCC-AHB1ENR_DMA1EN    DMA1 clock enable
: RCC-AHB1ENR_CRCEN   %1 12 lshift RCC-AHB1ENR bis! ;  \ RCC-AHB1ENR_CRCEN    CRC clock enable
: RCC-AHB1ENR_GPIOHEN   %1 7 lshift RCC-AHB1ENR bis! ;  \ RCC-AHB1ENR_GPIOHEN    IO port H clock enable
: RCC-AHB1ENR_GPIOEEN   %1 4 lshift RCC-AHB1ENR bis! ;  \ RCC-AHB1ENR_GPIOEEN    IO port E clock enable
: RCC-AHB1ENR_GPIODEN   %1 3 lshift RCC-AHB1ENR bis! ;  \ RCC-AHB1ENR_GPIODEN    IO port D clock enable
: RCC-AHB1ENR_GPIOCEN   %1 2 lshift RCC-AHB1ENR bis! ;  \ RCC-AHB1ENR_GPIOCEN    IO port C clock enable
: RCC-AHB1ENR_GPIOBEN   %1 1 lshift RCC-AHB1ENR bis! ;  \ RCC-AHB1ENR_GPIOBEN    IO port B clock enable
: RCC-AHB1ENR_GPIOAEN   %1 0 lshift RCC-AHB1ENR bis! ;  \ RCC-AHB1ENR_GPIOAEN    IO port A clock enable

\ RCC-AHB2ENR (read-write)
: RCC-AHB2ENR_OTGFSEN   %1 7 lshift RCC-AHB2ENR bis! ;  \ RCC-AHB2ENR_OTGFSEN    USB OTG FS clock enable

\ RCC-APB1ENR (read-write)
: RCC-APB1ENR_PWREN   %1 28 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_PWREN    Power interface clock
  enable
: RCC-APB1ENR_I2C3EN   %1 23 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_I2C3EN    I2C3 clock enable
: RCC-APB1ENR_I2C2EN   %1 22 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_I2C2EN    I2C2 clock enable
: RCC-APB1ENR_I2C1EN   %1 21 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_I2C1EN    I2C1 clock enable
: RCC-APB1ENR_USART2EN   %1 17 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_USART2EN    USART 2 clock enable
: RCC-APB1ENR_SPI3EN   %1 15 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_SPI3EN    SPI3 clock enable
: RCC-APB1ENR_SPI2EN   %1 14 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_SPI2EN    SPI2 clock enable
: RCC-APB1ENR_WWDGEN   %1 11 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_WWDGEN    Window watchdog clock
  enable
: RCC-APB1ENR_TIM5EN   %1 3 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_TIM5EN    TIM5 clock enable
: RCC-APB1ENR_TIM4EN   %1 2 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_TIM4EN    TIM4 clock enable
: RCC-APB1ENR_TIM3EN   %1 1 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_TIM3EN    TIM3 clock enable
: RCC-APB1ENR_TIM2EN   %1 0 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_TIM2EN    TIM2 clock enable

\ RCC-APB2ENR (read-write)
: RCC-APB2ENR_TIM1EN   %1 0 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_TIM1EN    TIM1 clock enable
: RCC-APB2ENR_USART1EN   %1 4 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_USART1EN    USART1 clock enable
: RCC-APB2ENR_USART6EN   %1 5 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_USART6EN    USART6 clock enable
: RCC-APB2ENR_ADC1EN   %1 8 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_ADC1EN    ADC1 clock enable
: RCC-APB2ENR_SDIOEN   %1 11 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_SDIOEN    SDIO clock enable
: RCC-APB2ENR_SPI1EN   %1 12 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_SPI1EN    SPI1 clock enable
: RCC-APB2ENR_SPI4EN   %1 13 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_SPI4EN    SPI4 clock enable
: RCC-APB2ENR_SYSCFGEN   %1 14 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_SYSCFGEN    System configuration controller clock
  enable
: RCC-APB2ENR_TIM9EN   %1 16 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_TIM9EN    TIM9 clock enable
: RCC-APB2ENR_TIM10EN   %1 17 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_TIM10EN    TIM10 clock enable
: RCC-APB2ENR_TIM11EN   %1 18 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_TIM11EN    TIM11 clock enable

\ RCC-AHB1LPENR (read-write)
: RCC-AHB1LPENR_DMA2LPEN   %1 22 lshift RCC-AHB1LPENR bis! ;  \ RCC-AHB1LPENR_DMA2LPEN    DMA2 clock enable during Sleep
  mode
: RCC-AHB1LPENR_DMA1LPEN   %1 21 lshift RCC-AHB1LPENR bis! ;  \ RCC-AHB1LPENR_DMA1LPEN    DMA1 clock enable during Sleep
  mode
: RCC-AHB1LPENR_SRAM1LPEN   %1 16 lshift RCC-AHB1LPENR bis! ;  \ RCC-AHB1LPENR_SRAM1LPEN    SRAM 1interface clock enable during
  Sleep mode
: RCC-AHB1LPENR_FLITFLPEN   %1 15 lshift RCC-AHB1LPENR bis! ;  \ RCC-AHB1LPENR_FLITFLPEN    Flash interface clock enable during
  Sleep mode
: RCC-AHB1LPENR_CRCLPEN   %1 12 lshift RCC-AHB1LPENR bis! ;  \ RCC-AHB1LPENR_CRCLPEN    CRC clock enable during Sleep
  mode
: RCC-AHB1LPENR_GPIOHLPEN   %1 7 lshift RCC-AHB1LPENR bis! ;  \ RCC-AHB1LPENR_GPIOHLPEN    IO port H clock enable during Sleep
  mode
: RCC-AHB1LPENR_GPIOELPEN   %1 4 lshift RCC-AHB1LPENR bis! ;  \ RCC-AHB1LPENR_GPIOELPEN    IO port E clock enable during Sleep
  mode
: RCC-AHB1LPENR_GPIODLPEN   %1 3 lshift RCC-AHB1LPENR bis! ;  \ RCC-AHB1LPENR_GPIODLPEN    IO port D clock enable during Sleep
  mode
: RCC-AHB1LPENR_GPIOCLPEN   %1 2 lshift RCC-AHB1LPENR bis! ;  \ RCC-AHB1LPENR_GPIOCLPEN    IO port C clock enable during Sleep
  mode
: RCC-AHB1LPENR_GPIOBLPEN   %1 1 lshift RCC-AHB1LPENR bis! ;  \ RCC-AHB1LPENR_GPIOBLPEN    IO port B clock enable during Sleep
  mode
: RCC-AHB1LPENR_GPIOALPEN   %1 0 lshift RCC-AHB1LPENR bis! ;  \ RCC-AHB1LPENR_GPIOALPEN    IO port A clock enable during sleep
  mode

\ RCC-AHB2LPENR (read-write)
: RCC-AHB2LPENR_OTGFSLPEN   %1 7 lshift RCC-AHB2LPENR bis! ;  \ RCC-AHB2LPENR_OTGFSLPEN    USB OTG FS clock enable during Sleep
  mode

\ RCC-APB1LPENR (read-write)
: RCC-APB1LPENR_PWRLPEN   %1 28 lshift RCC-APB1LPENR bis! ;  \ RCC-APB1LPENR_PWRLPEN    Power interface clock enable during
  Sleep mode
: RCC-APB1LPENR_I2C3LPEN   %1 23 lshift RCC-APB1LPENR bis! ;  \ RCC-APB1LPENR_I2C3LPEN    I2C3 clock enable during Sleep
  mode
: RCC-APB1LPENR_I2C2LPEN   %1 22 lshift RCC-APB1LPENR bis! ;  \ RCC-APB1LPENR_I2C2LPEN    I2C2 clock enable during Sleep
  mode
: RCC-APB1LPENR_I2C1LPEN   %1 21 lshift RCC-APB1LPENR bis! ;  \ RCC-APB1LPENR_I2C1LPEN    I2C1 clock enable during Sleep
  mode
: RCC-APB1LPENR_USART2LPEN   %1 17 lshift RCC-APB1LPENR bis! ;  \ RCC-APB1LPENR_USART2LPEN    USART2 clock enable during Sleep
  mode
: RCC-APB1LPENR_SPI3LPEN   %1 15 lshift RCC-APB1LPENR bis! ;  \ RCC-APB1LPENR_SPI3LPEN    SPI3 clock enable during Sleep
  mode
: RCC-APB1LPENR_SPI2LPEN   %1 14 lshift RCC-APB1LPENR bis! ;  \ RCC-APB1LPENR_SPI2LPEN    SPI2 clock enable during Sleep
  mode
: RCC-APB1LPENR_WWDGLPEN   %1 11 lshift RCC-APB1LPENR bis! ;  \ RCC-APB1LPENR_WWDGLPEN    Window watchdog clock enable during
  Sleep mode
: RCC-APB1LPENR_TIM5LPEN   %1 3 lshift RCC-APB1LPENR bis! ;  \ RCC-APB1LPENR_TIM5LPEN    TIM5 clock enable during Sleep
  mode
: RCC-APB1LPENR_TIM4LPEN   %1 2 lshift RCC-APB1LPENR bis! ;  \ RCC-APB1LPENR_TIM4LPEN    TIM4 clock enable during Sleep
  mode
: RCC-APB1LPENR_TIM3LPEN   %1 1 lshift RCC-APB1LPENR bis! ;  \ RCC-APB1LPENR_TIM3LPEN    TIM3 clock enable during Sleep
  mode
: RCC-APB1LPENR_TIM2LPEN   %1 0 lshift RCC-APB1LPENR bis! ;  \ RCC-APB1LPENR_TIM2LPEN    TIM2 clock enable during Sleep
  mode

\ RCC-APB2LPENR (read-write)
: RCC-APB2LPENR_TIM1LPEN   %1 0 lshift RCC-APB2LPENR bis! ;  \ RCC-APB2LPENR_TIM1LPEN    TIM1 clock enable during Sleep
  mode
: RCC-APB2LPENR_USART1LPEN   %1 4 lshift RCC-APB2LPENR bis! ;  \ RCC-APB2LPENR_USART1LPEN    USART1 clock enable during Sleep
  mode
: RCC-APB2LPENR_USART6LPEN   %1 5 lshift RCC-APB2LPENR bis! ;  \ RCC-APB2LPENR_USART6LPEN    USART6 clock enable during Sleep
  mode
: RCC-APB2LPENR_ADC1LPEN   %1 8 lshift RCC-APB2LPENR bis! ;  \ RCC-APB2LPENR_ADC1LPEN    ADC1 clock enable during Sleep
  mode
: RCC-APB2LPENR_SDIOLPEN   %1 11 lshift RCC-APB2LPENR bis! ;  \ RCC-APB2LPENR_SDIOLPEN    SDIO clock enable during Sleep
  mode
: RCC-APB2LPENR_SPI1LPEN   %1 12 lshift RCC-APB2LPENR bis! ;  \ RCC-APB2LPENR_SPI1LPEN    SPI 1 clock enable during Sleep
  mode
: RCC-APB2LPENR_SPI4LPEN   %1 13 lshift RCC-APB2LPENR bis! ;  \ RCC-APB2LPENR_SPI4LPEN    SPI4 clock enable during Sleep
  mode
: RCC-APB2LPENR_SYSCFGLPEN   %1 14 lshift RCC-APB2LPENR bis! ;  \ RCC-APB2LPENR_SYSCFGLPEN    System configuration controller clock
  enable during Sleep mode
: RCC-APB2LPENR_TIM9LPEN   %1 16 lshift RCC-APB2LPENR bis! ;  \ RCC-APB2LPENR_TIM9LPEN    TIM9 clock enable during sleep
  mode
: RCC-APB2LPENR_TIM10LPEN   %1 17 lshift RCC-APB2LPENR bis! ;  \ RCC-APB2LPENR_TIM10LPEN    TIM10 clock enable during Sleep
  mode
: RCC-APB2LPENR_TIM11LPEN   %1 18 lshift RCC-APB2LPENR bis! ;  \ RCC-APB2LPENR_TIM11LPEN    TIM11 clock enable during Sleep
  mode

\ RCC-BDCR ()
: RCC-BDCR_BDRST   %1 16 lshift RCC-BDCR bis! ;  \ RCC-BDCR_BDRST    Backup domain software
  reset
: RCC-BDCR_RTCEN   %1 15 lshift RCC-BDCR bis! ;  \ RCC-BDCR_RTCEN    RTC clock enable
: RCC-BDCR_RTCSEL1   %1 9 lshift RCC-BDCR bis! ;  \ RCC-BDCR_RTCSEL1    RTC clock source selection
: RCC-BDCR_RTCSEL0   %1 8 lshift RCC-BDCR bis! ;  \ RCC-BDCR_RTCSEL0    RTC clock source selection
: RCC-BDCR_LSEBYP   %1 2 lshift RCC-BDCR bis! ;  \ RCC-BDCR_LSEBYP    External low-speed oscillator
  bypass
: RCC-BDCR_LSERDY   %1 1 lshift RCC-BDCR bis! ;  \ RCC-BDCR_LSERDY    External low-speed oscillator
  ready
: RCC-BDCR_LSEON   %1 0 lshift RCC-BDCR bis! ;  \ RCC-BDCR_LSEON    External low-speed oscillator
  enable

\ RCC-CSR ()
: RCC-CSR_LPWRRSTF   %1 31 lshift RCC-CSR bis! ;  \ RCC-CSR_LPWRRSTF    Low-power reset flag
: RCC-CSR_WWDGRSTF   %1 30 lshift RCC-CSR bis! ;  \ RCC-CSR_WWDGRSTF    Window watchdog reset flag
: RCC-CSR_WDGRSTF   %1 29 lshift RCC-CSR bis! ;  \ RCC-CSR_WDGRSTF    Independent watchdog reset
  flag
: RCC-CSR_SFTRSTF   %1 28 lshift RCC-CSR bis! ;  \ RCC-CSR_SFTRSTF    Software reset flag
: RCC-CSR_PORRSTF   %1 27 lshift RCC-CSR bis! ;  \ RCC-CSR_PORRSTF    POR/PDR reset flag
: RCC-CSR_PADRSTF   %1 26 lshift RCC-CSR bis! ;  \ RCC-CSR_PADRSTF    PIN reset flag
: RCC-CSR_BORRSTF   %1 25 lshift RCC-CSR bis! ;  \ RCC-CSR_BORRSTF    BOR reset flag
: RCC-CSR_RMVF   %1 24 lshift RCC-CSR bis! ;  \ RCC-CSR_RMVF    Remove reset flag
: RCC-CSR_LSIRDY   %1 1 lshift RCC-CSR bis! ;  \ RCC-CSR_LSIRDY    Internal low-speed oscillator
  ready
: RCC-CSR_LSION   %1 0 lshift RCC-CSR bis! ;  \ RCC-CSR_LSION    Internal low-speed oscillator
  enable

\ RCC-SSCGR (read-write)
: RCC-SSCGR_SSCGEN   %1 31 lshift RCC-SSCGR bis! ;  \ RCC-SSCGR_SSCGEN    Spread spectrum modulation
  enable
: RCC-SSCGR_SPREADSEL   %1 30 lshift RCC-SSCGR bis! ;  \ RCC-SSCGR_SPREADSEL    Spread Select
: RCC-SSCGR_INCSTEP   ( %XXXXXXXXXXXXXXX -- ) 13 lshift RCC-SSCGR bis! ;  \ RCC-SSCGR_INCSTEP    Incrementation step
: RCC-SSCGR_MODPER  0 lshift RCC-SSCGR bis! ;  \ RCC-SSCGR_MODPER    Modulation period

\ RCC-PLLI2SCFGR (read-write)
: RCC-PLLI2SCFGR_PLLI2SRx   ( %XXX -- ) 28 lshift RCC-PLLI2SCFGR bis! ;  \ RCC-PLLI2SCFGR_PLLI2SRx    PLLI2S division factor for I2S
  clocks
: RCC-PLLI2SCFGR_PLLI2SNx   ( %XXXXXXXXX -- ) 6 lshift RCC-PLLI2SCFGR bis! ;  \ RCC-PLLI2SCFGR_PLLI2SNx    PLLI2S multiplication factor for
  VCO

\ RTC-TR (read-write)
: RTC-TR_PM   %1 22 lshift RTC-TR bis! ;  \ RTC-TR_PM    AM/PM notation
: RTC-TR_HT   ( %XX -- ) 20 lshift RTC-TR bis! ;  \ RTC-TR_HT    Hour tens in BCD format
: RTC-TR_HU   ( %XXXX -- ) 16 lshift RTC-TR bis! ;  \ RTC-TR_HU    Hour units in BCD format
: RTC-TR_MNT   ( %XXX -- ) 12 lshift RTC-TR bis! ;  \ RTC-TR_MNT    Minute tens in BCD format
: RTC-TR_MNU   ( %XXXX -- ) 8 lshift RTC-TR bis! ;  \ RTC-TR_MNU    Minute units in BCD format
: RTC-TR_ST   ( %XXX -- ) 4 lshift RTC-TR bis! ;  \ RTC-TR_ST    Second tens in BCD format
: RTC-TR_SU   ( %XXXX -- ) 0 lshift RTC-TR bis! ;  \ RTC-TR_SU    Second units in BCD format

\ RTC-DR (read-write)
: RTC-DR_YT   ( %XXXX -- ) 20 lshift RTC-DR bis! ;  \ RTC-DR_YT    Year tens in BCD format
: RTC-DR_YU   ( %XXXX -- ) 16 lshift RTC-DR bis! ;  \ RTC-DR_YU    Year units in BCD format
: RTC-DR_WDU   ( %XXX -- ) 13 lshift RTC-DR bis! ;  \ RTC-DR_WDU    Week day units
: RTC-DR_MT   %1 12 lshift RTC-DR bis! ;  \ RTC-DR_MT    Month tens in BCD format
: RTC-DR_MU   ( %XXXX -- ) 8 lshift RTC-DR bis! ;  \ RTC-DR_MU    Month units in BCD format
: RTC-DR_DT   ( %XX -- ) 4 lshift RTC-DR bis! ;  \ RTC-DR_DT    Date tens in BCD format
: RTC-DR_DU   ( %XXXX -- ) 0 lshift RTC-DR bis! ;  \ RTC-DR_DU    Date units in BCD format

\ RTC-CR (read-write)
: RTC-CR_COE   %1 23 lshift RTC-CR bis! ;  \ RTC-CR_COE    Calibration output enable
: RTC-CR_OSEL   ( %XX -- ) 21 lshift RTC-CR bis! ;  \ RTC-CR_OSEL    Output selection
: RTC-CR_POL   %1 20 lshift RTC-CR bis! ;  \ RTC-CR_POL    Output polarity
: RTC-CR_COSEL   %1 19 lshift RTC-CR bis! ;  \ RTC-CR_COSEL    Calibration Output
  selection
: RTC-CR_BKP   %1 18 lshift RTC-CR bis! ;  \ RTC-CR_BKP    Backup
: RTC-CR_SUB1H   %1 17 lshift RTC-CR bis! ;  \ RTC-CR_SUB1H    Subtract 1 hour winter time
  change
: RTC-CR_ADD1H   %1 16 lshift RTC-CR bis! ;  \ RTC-CR_ADD1H    Add 1 hour summer time
  change
: RTC-CR_TSIE   %1 15 lshift RTC-CR bis! ;  \ RTC-CR_TSIE    Time-stamp interrupt
  enable
: RTC-CR_WUTIE   %1 14 lshift RTC-CR bis! ;  \ RTC-CR_WUTIE    Wakeup timer interrupt
  enable
: RTC-CR_ALRBIE   %1 13 lshift RTC-CR bis! ;  \ RTC-CR_ALRBIE    Alarm B interrupt enable
: RTC-CR_ALRAIE   %1 12 lshift RTC-CR bis! ;  \ RTC-CR_ALRAIE    Alarm A interrupt enable
: RTC-CR_TSE   %1 11 lshift RTC-CR bis! ;  \ RTC-CR_TSE    Time stamp enable
: RTC-CR_WUTE   %1 10 lshift RTC-CR bis! ;  \ RTC-CR_WUTE    Wakeup timer enable
: RTC-CR_ALRBE   %1 9 lshift RTC-CR bis! ;  \ RTC-CR_ALRBE    Alarm B enable
: RTC-CR_ALRAE   %1 8 lshift RTC-CR bis! ;  \ RTC-CR_ALRAE    Alarm A enable
: RTC-CR_DCE   %1 7 lshift RTC-CR bis! ;  \ RTC-CR_DCE    Coarse digital calibration
  enable
: RTC-CR_FMT   %1 6 lshift RTC-CR bis! ;  \ RTC-CR_FMT    Hour format
: RTC-CR_BYPSHAD   %1 5 lshift RTC-CR bis! ;  \ RTC-CR_BYPSHAD    Bypass the shadow
  registers
: RTC-CR_REFCKON   %1 4 lshift RTC-CR bis! ;  \ RTC-CR_REFCKON    Reference clock detection enable 50 or
  60 Hz
: RTC-CR_TSEDGE   %1 3 lshift RTC-CR bis! ;  \ RTC-CR_TSEDGE    Time-stamp event active
  edge
: RTC-CR_WCKSEL   ( %XXX -- ) 0 lshift RTC-CR bis! ;  \ RTC-CR_WCKSEL    Wakeup clock selection

\ RTC-ISR ()
: RTC-ISR_ALRAWF   %1 0 lshift RTC-ISR bis! ;  \ RTC-ISR_ALRAWF    Alarm A write flag
: RTC-ISR_ALRBWF   %1 1 lshift RTC-ISR bis! ;  \ RTC-ISR_ALRBWF    Alarm B write flag
: RTC-ISR_WUTWF   %1 2 lshift RTC-ISR bis! ;  \ RTC-ISR_WUTWF    Wakeup timer write flag
: RTC-ISR_SHPF   %1 3 lshift RTC-ISR bis! ;  \ RTC-ISR_SHPF    Shift operation pending
: RTC-ISR_INITS   %1 4 lshift RTC-ISR bis! ;  \ RTC-ISR_INITS    Initialization status flag
: RTC-ISR_RSF   %1 5 lshift RTC-ISR bis! ;  \ RTC-ISR_RSF    Registers synchronization
  flag
: RTC-ISR_INITF   %1 6 lshift RTC-ISR bis! ;  \ RTC-ISR_INITF    Initialization flag
: RTC-ISR_INIT   %1 7 lshift RTC-ISR bis! ;  \ RTC-ISR_INIT    Initialization mode
: RTC-ISR_ALRAF   %1 8 lshift RTC-ISR bis! ;  \ RTC-ISR_ALRAF    Alarm A flag
: RTC-ISR_ALRBF   %1 9 lshift RTC-ISR bis! ;  \ RTC-ISR_ALRBF    Alarm B flag
: RTC-ISR_WUTF   %1 10 lshift RTC-ISR bis! ;  \ RTC-ISR_WUTF    Wakeup timer flag
: RTC-ISR_TSF   %1 11 lshift RTC-ISR bis! ;  \ RTC-ISR_TSF    Time-stamp flag
: RTC-ISR_TSOVF   %1 12 lshift RTC-ISR bis! ;  \ RTC-ISR_TSOVF    Time-stamp overflow flag
: RTC-ISR_TAMP1F   %1 13 lshift RTC-ISR bis! ;  \ RTC-ISR_TAMP1F    Tamper detection flag
: RTC-ISR_TAMP2F   %1 14 lshift RTC-ISR bis! ;  \ RTC-ISR_TAMP2F    TAMPER2 detection flag
: RTC-ISR_RECALPF   %1 16 lshift RTC-ISR bis! ;  \ RTC-ISR_RECALPF    Recalibration pending Flag

\ RTC-PRER (read-write)
: RTC-PRER_PREDIV_A   ( %XXXXXXX -- ) 16 lshift RTC-PRER bis! ;  \ RTC-PRER_PREDIV_A    Asynchronous prescaler
  factor
: RTC-PRER_PREDIV_S   ( %XXXXXXXXXXXXXXX -- ) 0 lshift RTC-PRER bis! ;  \ RTC-PRER_PREDIV_S    Synchronous prescaler
  factor

\ RTC-WUTR (read-write)
: RTC-WUTR_WUT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift RTC-WUTR bis! ;  \ RTC-WUTR_WUT    Wakeup auto-reload value
  bits

\ RTC-CALIBR (read-write)
: RTC-CALIBR_DCS   %1 7 lshift RTC-CALIBR bis! ;  \ RTC-CALIBR_DCS    Digital calibration sign
: RTC-CALIBR_DC   ( %XXXXX -- ) 0 lshift RTC-CALIBR bis! ;  \ RTC-CALIBR_DC    Digital calibration

\ RTC-ALRMAR (read-write)
: RTC-ALRMAR_MSK4   %1 31 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_MSK4    Alarm A date mask
: RTC-ALRMAR_WDSEL   %1 30 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_WDSEL    Week day selection
: RTC-ALRMAR_DT   ( %XX -- ) 28 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_DT    Date tens in BCD format
: RTC-ALRMAR_DU   ( %XXXX -- ) 24 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_DU    Date units or day in BCD
  format
: RTC-ALRMAR_MSK3   %1 23 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_MSK3    Alarm A hours mask
: RTC-ALRMAR_PM   %1 22 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_PM    AM/PM notation
: RTC-ALRMAR_HT   ( %XX -- ) 20 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_HT    Hour tens in BCD format
: RTC-ALRMAR_HU   ( %XXXX -- ) 16 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_HU    Hour units in BCD format
: RTC-ALRMAR_MSK2   %1 15 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_MSK2    Alarm A minutes mask
: RTC-ALRMAR_MNT   ( %XXX -- ) 12 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_MNT    Minute tens in BCD format
: RTC-ALRMAR_MNU   ( %XXXX -- ) 8 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_MNU    Minute units in BCD format
: RTC-ALRMAR_MSK1   %1 7 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_MSK1    Alarm A seconds mask
: RTC-ALRMAR_ST   ( %XXX -- ) 4 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_ST    Second tens in BCD format
: RTC-ALRMAR_SU   ( %XXXX -- ) 0 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_SU    Second units in BCD format

\ RTC-ALRMBR (read-write)
: RTC-ALRMBR_MSK4   %1 31 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_MSK4    Alarm B date mask
: RTC-ALRMBR_WDSEL   %1 30 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_WDSEL    Week day selection
: RTC-ALRMBR_DT   ( %XX -- ) 28 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_DT    Date tens in BCD format
: RTC-ALRMBR_DU   ( %XXXX -- ) 24 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_DU    Date units or day in BCD
  format
: RTC-ALRMBR_MSK3   %1 23 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_MSK3    Alarm B hours mask
: RTC-ALRMBR_PM   %1 22 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_PM    AM/PM notation
: RTC-ALRMBR_HT   ( %XX -- ) 20 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_HT    Hour tens in BCD format
: RTC-ALRMBR_HU   ( %XXXX -- ) 16 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_HU    Hour units in BCD format
: RTC-ALRMBR_MSK2   %1 15 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_MSK2    Alarm B minutes mask
: RTC-ALRMBR_MNT   ( %XXX -- ) 12 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_MNT    Minute tens in BCD format
: RTC-ALRMBR_MNU   ( %XXXX -- ) 8 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_MNU    Minute units in BCD format
: RTC-ALRMBR_MSK1   %1 7 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_MSK1    Alarm B seconds mask
: RTC-ALRMBR_ST   ( %XXX -- ) 4 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_ST    Second tens in BCD format
: RTC-ALRMBR_SU   ( %XXXX -- ) 0 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_SU    Second units in BCD format

\ RTC-WPR (write-only)
: RTC-WPR_KEY   ( %XXXXXXXX -- ) 0 lshift RTC-WPR bis! ;  \ RTC-WPR_KEY    Write protection key

\ RTC-SSR (read-only)
: RTC-SSR_SS   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift RTC-SSR bis! ;  \ RTC-SSR_SS    Sub second value

\ RTC-SHIFTR (write-only)
: RTC-SHIFTR_ADD1S   %1 31 lshift RTC-SHIFTR bis! ;  \ RTC-SHIFTR_ADD1S    Add one second
: RTC-SHIFTR_SUBFS   ( %XXXXXXXXXXXXXXX -- ) 0 lshift RTC-SHIFTR bis! ;  \ RTC-SHIFTR_SUBFS    Subtract a fraction of a
  second

\ RTC-TSTR (read-only)
: RTC-TSTR_PM   %1 22 lshift RTC-TSTR bis! ;  \ RTC-TSTR_PM    AM/PM notation
: RTC-TSTR_HT   ( %XX -- ) 20 lshift RTC-TSTR bis! ;  \ RTC-TSTR_HT    Hour tens in BCD format
: RTC-TSTR_HU   ( %XXXX -- ) 16 lshift RTC-TSTR bis! ;  \ RTC-TSTR_HU    Hour units in BCD format
: RTC-TSTR_MNT   ( %XXX -- ) 12 lshift RTC-TSTR bis! ;  \ RTC-TSTR_MNT    Minute tens in BCD format
: RTC-TSTR_MNU   ( %XXXX -- ) 8 lshift RTC-TSTR bis! ;  \ RTC-TSTR_MNU    Minute units in BCD format
: RTC-TSTR_ST   ( %XXX -- ) 4 lshift RTC-TSTR bis! ;  \ RTC-TSTR_ST    Second tens in BCD format
: RTC-TSTR_SU   ( %XXXX -- ) 0 lshift RTC-TSTR bis! ;  \ RTC-TSTR_SU    Second units in BCD format

\ RTC-TSDR (read-only)
: RTC-TSDR_WDU   ( %XXX -- ) 13 lshift RTC-TSDR bis! ;  \ RTC-TSDR_WDU    Week day units
: RTC-TSDR_MT   %1 12 lshift RTC-TSDR bis! ;  \ RTC-TSDR_MT    Month tens in BCD format
: RTC-TSDR_MU   ( %XXXX -- ) 8 lshift RTC-TSDR bis! ;  \ RTC-TSDR_MU    Month units in BCD format
: RTC-TSDR_DT   ( %XX -- ) 4 lshift RTC-TSDR bis! ;  \ RTC-TSDR_DT    Date tens in BCD format
: RTC-TSDR_DU   ( %XXXX -- ) 0 lshift RTC-TSDR bis! ;  \ RTC-TSDR_DU    Date units in BCD format

\ RTC-TSSSR (read-only)
: RTC-TSSSR_SS   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift RTC-TSSSR bis! ;  \ RTC-TSSSR_SS    Sub second value

\ RTC-CALR (read-write)
: RTC-CALR_CALP   %1 15 lshift RTC-CALR bis! ;  \ RTC-CALR_CALP    Increase frequency of RTC by 488.5
  ppm
: RTC-CALR_CALW8   %1 14 lshift RTC-CALR bis! ;  \ RTC-CALR_CALW8    Use an 8-second calibration cycle
  period
: RTC-CALR_CALW16   %1 13 lshift RTC-CALR bis! ;  \ RTC-CALR_CALW16    Use a 16-second calibration cycle
  period
: RTC-CALR_CALM   ( %XXXXXXXXX -- ) 0 lshift RTC-CALR bis! ;  \ RTC-CALR_CALM    Calibration minus

\ RTC-TAFCR (read-write)
: RTC-TAFCR_ALARMOUTTYPE   %1 18 lshift RTC-TAFCR bis! ;  \ RTC-TAFCR_ALARMOUTTYPE    AFO_ALARM output type
: RTC-TAFCR_TSINSEL   %1 17 lshift RTC-TAFCR bis! ;  \ RTC-TAFCR_TSINSEL    TIMESTAMP mapping
: RTC-TAFCR_TAMP1INSEL   %1 16 lshift RTC-TAFCR bis! ;  \ RTC-TAFCR_TAMP1INSEL    TAMPER1 mapping
: RTC-TAFCR_TAMPPUDIS   %1 15 lshift RTC-TAFCR bis! ;  \ RTC-TAFCR_TAMPPUDIS    TAMPER pull-up disable
: RTC-TAFCR_TAMPPRCH   ( %XX -- ) 13 lshift RTC-TAFCR bis! ;  \ RTC-TAFCR_TAMPPRCH    Tamper precharge duration
: RTC-TAFCR_TAMPFLT   ( %XX -- ) 11 lshift RTC-TAFCR bis! ;  \ RTC-TAFCR_TAMPFLT    Tamper filter count
: RTC-TAFCR_TAMPFREQ   ( %XXX -- ) 8 lshift RTC-TAFCR bis! ;  \ RTC-TAFCR_TAMPFREQ    Tamper sampling frequency
: RTC-TAFCR_TAMPTS   %1 7 lshift RTC-TAFCR bis! ;  \ RTC-TAFCR_TAMPTS    Activate timestamp on tamper detection
  event
: RTC-TAFCR_TAMP2TRG   %1 4 lshift RTC-TAFCR bis! ;  \ RTC-TAFCR_TAMP2TRG    Active level for tamper 2
: RTC-TAFCR_TAMP2E   %1 3 lshift RTC-TAFCR bis! ;  \ RTC-TAFCR_TAMP2E    Tamper 2 detection enable
: RTC-TAFCR_TAMPIE   %1 2 lshift RTC-TAFCR bis! ;  \ RTC-TAFCR_TAMPIE    Tamper interrupt enable
: RTC-TAFCR_TAMP1TRG   %1 1 lshift RTC-TAFCR bis! ;  \ RTC-TAFCR_TAMP1TRG    Active level for tamper 1
: RTC-TAFCR_TAMP1E   %1 0 lshift RTC-TAFCR bis! ;  \ RTC-TAFCR_TAMP1E    Tamper 1 detection enable

\ RTC-ALRMASSR (read-write)
: RTC-ALRMASSR_MASKSS   ( %XXXX -- ) 24 lshift RTC-ALRMASSR bis! ;  \ RTC-ALRMASSR_MASKSS    Mask the most-significant bits starting
  at this bit
: RTC-ALRMASSR_SS   ( %XXXXXXXXXXXXXXX -- ) 0 lshift RTC-ALRMASSR bis! ;  \ RTC-ALRMASSR_SS    Sub seconds value

\ RTC-ALRMBSSR (read-write)
: RTC-ALRMBSSR_MASKSS   ( %XXXX -- ) 24 lshift RTC-ALRMBSSR bis! ;  \ RTC-ALRMBSSR_MASKSS    Mask the most-significant bits starting
  at this bit
: RTC-ALRMBSSR_SS   ( %XXXXXXXXXXXXXXX -- ) 0 lshift RTC-ALRMBSSR bis! ;  \ RTC-ALRMBSSR_SS    Sub seconds value

\ RTC-BKP0R (read-write)
: RTC-BKP0R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP0R bis! ;  \ RTC-BKP0R_BKP    BKP

\ RTC-BKP1R (read-write)
: RTC-BKP1R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP1R bis! ;  \ RTC-BKP1R_BKP    BKP

\ RTC-BKP2R (read-write)
: RTC-BKP2R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP2R bis! ;  \ RTC-BKP2R_BKP    BKP

\ RTC-BKP3R (read-write)
: RTC-BKP3R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP3R bis! ;  \ RTC-BKP3R_BKP    BKP

\ RTC-BKP4R (read-write)
: RTC-BKP4R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP4R bis! ;  \ RTC-BKP4R_BKP    BKP

\ RTC-BKP5R (read-write)
: RTC-BKP5R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP5R bis! ;  \ RTC-BKP5R_BKP    BKP

\ RTC-BKP6R (read-write)
: RTC-BKP6R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP6R bis! ;  \ RTC-BKP6R_BKP    BKP

\ RTC-BKP7R (read-write)
: RTC-BKP7R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP7R bis! ;  \ RTC-BKP7R_BKP    BKP

\ RTC-BKP8R (read-write)
: RTC-BKP8R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP8R bis! ;  \ RTC-BKP8R_BKP    BKP

\ RTC-BKP9R (read-write)
: RTC-BKP9R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP9R bis! ;  \ RTC-BKP9R_BKP    BKP

\ RTC-BKP10R (read-write)
: RTC-BKP10R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP10R bis! ;  \ RTC-BKP10R_BKP    BKP

\ RTC-BKP11R (read-write)
: RTC-BKP11R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP11R bis! ;  \ RTC-BKP11R_BKP    BKP

\ RTC-BKP12R (read-write)
: RTC-BKP12R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP12R bis! ;  \ RTC-BKP12R_BKP    BKP

\ RTC-BKP13R (read-write)
: RTC-BKP13R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP13R bis! ;  \ RTC-BKP13R_BKP    BKP

\ RTC-BKP14R (read-write)
: RTC-BKP14R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP14R bis! ;  \ RTC-BKP14R_BKP    BKP

\ RTC-BKP15R (read-write)
: RTC-BKP15R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP15R bis! ;  \ RTC-BKP15R_BKP    BKP

\ RTC-BKP16R (read-write)
: RTC-BKP16R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP16R bis! ;  \ RTC-BKP16R_BKP    BKP

\ RTC-BKP17R (read-write)
: RTC-BKP17R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP17R bis! ;  \ RTC-BKP17R_BKP    BKP

\ RTC-BKP18R (read-write)
: RTC-BKP18R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP18R bis! ;  \ RTC-BKP18R_BKP    BKP

\ RTC-BKP19R (read-write)
: RTC-BKP19R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP19R bis! ;  \ RTC-BKP19R_BKP    BKP

\ SDIO-POWER (read-write)
: SDIO-POWER_PWRCTRL   ( %XX -- ) 0 lshift SDIO-POWER bis! ;  \ SDIO-POWER_PWRCTRL    PWRCTRL

\ SDIO-CLKCR (read-write)
: SDIO-CLKCR_HWFC_EN   %1 14 lshift SDIO-CLKCR bis! ;  \ SDIO-CLKCR_HWFC_EN    HW Flow Control enable
: SDIO-CLKCR_NEGEDGE   %1 13 lshift SDIO-CLKCR bis! ;  \ SDIO-CLKCR_NEGEDGE    SDIO_CK dephasing selection
  bit
: SDIO-CLKCR_WIDBUS   ( %XX -- ) 11 lshift SDIO-CLKCR bis! ;  \ SDIO-CLKCR_WIDBUS    Wide bus mode enable bit
: SDIO-CLKCR_BYPASS   %1 10 lshift SDIO-CLKCR bis! ;  \ SDIO-CLKCR_BYPASS    Clock divider bypass enable
  bit
: SDIO-CLKCR_PWRSAV   %1 9 lshift SDIO-CLKCR bis! ;  \ SDIO-CLKCR_PWRSAV    Power saving configuration
  bit
: SDIO-CLKCR_CLKEN   %1 8 lshift SDIO-CLKCR bis! ;  \ SDIO-CLKCR_CLKEN    Clock enable bit
: SDIO-CLKCR_CLKDIV   ( %XXXXXXXX -- ) 0 lshift SDIO-CLKCR bis! ;  \ SDIO-CLKCR_CLKDIV    Clock divide factor

\ SDIO-ARG (read-write)
: SDIO-ARG_CMDARG   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift SDIO-ARG bis! ;  \ SDIO-ARG_CMDARG    Command argument

\ SDIO-CMD (read-write)
: SDIO-CMD_CE_ATACMD   %1 14 lshift SDIO-CMD bis! ;  \ SDIO-CMD_CE_ATACMD    CE-ATA command
: SDIO-CMD_nIEN   %1 13 lshift SDIO-CMD bis! ;  \ SDIO-CMD_nIEN    not Interrupt Enable
: SDIO-CMD_ENCMDcompl   %1 12 lshift SDIO-CMD bis! ;  \ SDIO-CMD_ENCMDcompl    Enable CMD completion
: SDIO-CMD_SDIOSuspend   %1 11 lshift SDIO-CMD bis! ;  \ SDIO-CMD_SDIOSuspend    SD I/O suspend command
: SDIO-CMD_CPSMEN   %1 10 lshift SDIO-CMD bis! ;  \ SDIO-CMD_CPSMEN    Command path state machine CPSM Enable
  bit
: SDIO-CMD_WAITPEND   %1 9 lshift SDIO-CMD bis! ;  \ SDIO-CMD_WAITPEND    CPSM Waits for ends of data transfer
  CmdPend internal signal.
: SDIO-CMD_WAITINT   %1 8 lshift SDIO-CMD bis! ;  \ SDIO-CMD_WAITINT    CPSM waits for interrupt
  request
: SDIO-CMD_WAITRESP   ( %XX -- ) 6 lshift SDIO-CMD bis! ;  \ SDIO-CMD_WAITRESP    Wait for response bits
: SDIO-CMD_CMDINDEX   ( %XXXXXX -- ) 0 lshift SDIO-CMD bis! ;  \ SDIO-CMD_CMDINDEX    Command index

\ SDIO-RESPCMD (read-only)
: SDIO-RESPCMD_RESPCMD   ( %XXXXXX -- ) 0 lshift SDIO-RESPCMD bis! ;  \ SDIO-RESPCMD_RESPCMD    Response command index

\ SDIO-RESP1 (read-only)
: SDIO-RESP1_CARDSTATUS1   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift SDIO-RESP1 bis! ;  \ SDIO-RESP1_CARDSTATUS1    Card Status

\ SDIO-RESP2 (read-only)
: SDIO-RESP2_CARDSTATUS2   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift SDIO-RESP2 bis! ;  \ SDIO-RESP2_CARDSTATUS2    Card Status

\ SDIO-RESP3 (read-only)
: SDIO-RESP3_CARDSTATUS3   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift SDIO-RESP3 bis! ;  \ SDIO-RESP3_CARDSTATUS3    Card Status

\ SDIO-RESP4 (read-only)
: SDIO-RESP4_CARDSTATUS4   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift SDIO-RESP4 bis! ;  \ SDIO-RESP4_CARDSTATUS4    Card Status

\ SDIO-DTIMER (read-write)
: SDIO-DTIMER_DATATIME   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift SDIO-DTIMER bis! ;  \ SDIO-DTIMER_DATATIME    Data timeout period

\ SDIO-DLEN (read-write)
: SDIO-DLEN_DATALENGTH  0 lshift SDIO-DLEN bis! ;  \ SDIO-DLEN_DATALENGTH    Data length value

\ SDIO-DCTRL (read-write)
: SDIO-DCTRL_SDIOEN   %1 11 lshift SDIO-DCTRL bis! ;  \ SDIO-DCTRL_SDIOEN    SD I/O enable functions
: SDIO-DCTRL_RWMOD   %1 10 lshift SDIO-DCTRL bis! ;  \ SDIO-DCTRL_RWMOD    Read wait mode
: SDIO-DCTRL_RWSTOP   %1 9 lshift SDIO-DCTRL bis! ;  \ SDIO-DCTRL_RWSTOP    Read wait stop
: SDIO-DCTRL_RWSTART   %1 8 lshift SDIO-DCTRL bis! ;  \ SDIO-DCTRL_RWSTART    Read wait start
: SDIO-DCTRL_DBLOCKSIZE   ( %XXXX -- ) 4 lshift SDIO-DCTRL bis! ;  \ SDIO-DCTRL_DBLOCKSIZE    Data block size
: SDIO-DCTRL_DMAEN   %1 3 lshift SDIO-DCTRL bis! ;  \ SDIO-DCTRL_DMAEN    DMA enable bit
: SDIO-DCTRL_DTMODE   %1 2 lshift SDIO-DCTRL bis! ;  \ SDIO-DCTRL_DTMODE    Data transfer mode selection 1: Stream
  or SDIO multibyte data transfer.
: SDIO-DCTRL_DTDIR   %1 1 lshift SDIO-DCTRL bis! ;  \ SDIO-DCTRL_DTDIR    Data transfer direction
  selection
: SDIO-DCTRL_DTEN   %1 0 lshift SDIO-DCTRL bis! ;  \ SDIO-DCTRL_DTEN    DTEN

\ SDIO-DCOUNT (read-only)
: SDIO-DCOUNT_DATACOUNT  0 lshift SDIO-DCOUNT bis! ;  \ SDIO-DCOUNT_DATACOUNT    Data count value

\ SDIO-STA (read-only)
: SDIO-STA_CEATAEND   %1 23 lshift SDIO-STA bis! ;  \ SDIO-STA_CEATAEND    CE-ATA command completion signal
  received for CMD61
: SDIO-STA_SDIOIT   %1 22 lshift SDIO-STA bis! ;  \ SDIO-STA_SDIOIT    SDIO interrupt received
: SDIO-STA_RXDAVL   %1 21 lshift SDIO-STA bis! ;  \ SDIO-STA_RXDAVL    Data available in receive
  FIFO
: SDIO-STA_TXDAVL   %1 20 lshift SDIO-STA bis! ;  \ SDIO-STA_TXDAVL    Data available in transmit
  FIFO
: SDIO-STA_RXFIFOE   %1 19 lshift SDIO-STA bis! ;  \ SDIO-STA_RXFIFOE    Receive FIFO empty
: SDIO-STA_TXFIFOE   %1 18 lshift SDIO-STA bis! ;  \ SDIO-STA_TXFIFOE    Transmit FIFO empty
: SDIO-STA_RXFIFOF   %1 17 lshift SDIO-STA bis! ;  \ SDIO-STA_RXFIFOF    Receive FIFO full
: SDIO-STA_TXFIFOF   %1 16 lshift SDIO-STA bis! ;  \ SDIO-STA_TXFIFOF    Transmit FIFO full
: SDIO-STA_RXFIFOHF   %1 15 lshift SDIO-STA bis! ;  \ SDIO-STA_RXFIFOHF    Receive FIFO half full: there are at
  least 8 words in the FIFO
: SDIO-STA_TXFIFOHE   %1 14 lshift SDIO-STA bis! ;  \ SDIO-STA_TXFIFOHE    Transmit FIFO half empty: at least 8
  words can be written into the FIFO
: SDIO-STA_RXACT   %1 13 lshift SDIO-STA bis! ;  \ SDIO-STA_RXACT    Data receive in progress
: SDIO-STA_TXACT   %1 12 lshift SDIO-STA bis! ;  \ SDIO-STA_TXACT    Data transmit in progress
: SDIO-STA_CMDACT   %1 11 lshift SDIO-STA bis! ;  \ SDIO-STA_CMDACT    Command transfer in
  progress
: SDIO-STA_DBCKEND   %1 10 lshift SDIO-STA bis! ;  \ SDIO-STA_DBCKEND    Data block sent/received CRC check
  passed
: SDIO-STA_STBITERR   %1 9 lshift SDIO-STA bis! ;  \ SDIO-STA_STBITERR    Start bit not detected on all data
  signals in wide bus mode
: SDIO-STA_DATAEND   %1 8 lshift SDIO-STA bis! ;  \ SDIO-STA_DATAEND    Data end data counter, SDIDCOUNT, is
  zero
: SDIO-STA_CMDSENT   %1 7 lshift SDIO-STA bis! ;  \ SDIO-STA_CMDSENT    Command sent no response
  required
: SDIO-STA_CMDREND   %1 6 lshift SDIO-STA bis! ;  \ SDIO-STA_CMDREND    Command response received CRC check
  passed
: SDIO-STA_RXOVERR   %1 5 lshift SDIO-STA bis! ;  \ SDIO-STA_RXOVERR    Received FIFO overrun
  error
: SDIO-STA_TXUNDERR   %1 4 lshift SDIO-STA bis! ;  \ SDIO-STA_TXUNDERR    Transmit FIFO underrun
  error
: SDIO-STA_DTIMEOUT   %1 3 lshift SDIO-STA bis! ;  \ SDIO-STA_DTIMEOUT    Data timeout
: SDIO-STA_CTIMEOUT   %1 2 lshift SDIO-STA bis! ;  \ SDIO-STA_CTIMEOUT    Command response timeout
: SDIO-STA_DCRCFAIL   %1 1 lshift SDIO-STA bis! ;  \ SDIO-STA_DCRCFAIL    Data block sent/received CRC check
  failed
: SDIO-STA_CCRCFAIL   %1 0 lshift SDIO-STA bis! ;  \ SDIO-STA_CCRCFAIL    Command response received CRC check
  failed

\ SDIO-ICR (read-write)
: SDIO-ICR_CEATAENDC   %1 23 lshift SDIO-ICR bis! ;  \ SDIO-ICR_CEATAENDC    CEATAEND flag clear bit
: SDIO-ICR_SDIOITC   %1 22 lshift SDIO-ICR bis! ;  \ SDIO-ICR_SDIOITC    SDIOIT flag clear bit
: SDIO-ICR_DBCKENDC   %1 10 lshift SDIO-ICR bis! ;  \ SDIO-ICR_DBCKENDC    DBCKEND flag clear bit
: SDIO-ICR_STBITERRC   %1 9 lshift SDIO-ICR bis! ;  \ SDIO-ICR_STBITERRC    STBITERR flag clear bit
: SDIO-ICR_DATAENDC   %1 8 lshift SDIO-ICR bis! ;  \ SDIO-ICR_DATAENDC    DATAEND flag clear bit
: SDIO-ICR_CMDSENTC   %1 7 lshift SDIO-ICR bis! ;  \ SDIO-ICR_CMDSENTC    CMDSENT flag clear bit
: SDIO-ICR_CMDRENDC   %1 6 lshift SDIO-ICR bis! ;  \ SDIO-ICR_CMDRENDC    CMDREND flag clear bit
: SDIO-ICR_RXOVERRC   %1 5 lshift SDIO-ICR bis! ;  \ SDIO-ICR_RXOVERRC    RXOVERR flag clear bit
: SDIO-ICR_TXUNDERRC   %1 4 lshift SDIO-ICR bis! ;  \ SDIO-ICR_TXUNDERRC    TXUNDERR flag clear bit
: SDIO-ICR_DTIMEOUTC   %1 3 lshift SDIO-ICR bis! ;  \ SDIO-ICR_DTIMEOUTC    DTIMEOUT flag clear bit
: SDIO-ICR_CTIMEOUTC   %1 2 lshift SDIO-ICR bis! ;  \ SDIO-ICR_CTIMEOUTC    CTIMEOUT flag clear bit
: SDIO-ICR_DCRCFAILC   %1 1 lshift SDIO-ICR bis! ;  \ SDIO-ICR_DCRCFAILC    DCRCFAIL flag clear bit
: SDIO-ICR_CCRCFAILC   %1 0 lshift SDIO-ICR bis! ;  \ SDIO-ICR_CCRCFAILC    CCRCFAIL flag clear bit

\ SDIO-MASK (read-write)
: SDIO-MASK_CEATAENDIE   %1 23 lshift SDIO-MASK bis! ;  \ SDIO-MASK_CEATAENDIE    CE-ATA command completion signal
  received interrupt enable
: SDIO-MASK_SDIOITIE   %1 22 lshift SDIO-MASK bis! ;  \ SDIO-MASK_SDIOITIE    SDIO mode interrupt received interrupt
  enable
: SDIO-MASK_RXDAVLIE   %1 21 lshift SDIO-MASK bis! ;  \ SDIO-MASK_RXDAVLIE    Data available in Rx FIFO interrupt
  enable
: SDIO-MASK_TXDAVLIE   %1 20 lshift SDIO-MASK bis! ;  \ SDIO-MASK_TXDAVLIE    Data available in Tx FIFO interrupt
  enable
: SDIO-MASK_RXFIFOEIE   %1 19 lshift SDIO-MASK bis! ;  \ SDIO-MASK_RXFIFOEIE    Rx FIFO empty interrupt
  enable
: SDIO-MASK_TXFIFOEIE   %1 18 lshift SDIO-MASK bis! ;  \ SDIO-MASK_TXFIFOEIE    Tx FIFO empty interrupt
  enable
: SDIO-MASK_RXFIFOFIE   %1 17 lshift SDIO-MASK bis! ;  \ SDIO-MASK_RXFIFOFIE    Rx FIFO full interrupt
  enable
: SDIO-MASK_TXFIFOFIE   %1 16 lshift SDIO-MASK bis! ;  \ SDIO-MASK_TXFIFOFIE    Tx FIFO full interrupt
  enable
: SDIO-MASK_RXFIFOHFIE   %1 15 lshift SDIO-MASK bis! ;  \ SDIO-MASK_RXFIFOHFIE    Rx FIFO half full interrupt
  enable
: SDIO-MASK_TXFIFOHEIE   %1 14 lshift SDIO-MASK bis! ;  \ SDIO-MASK_TXFIFOHEIE    Tx FIFO half empty interrupt
  enable
: SDIO-MASK_RXACTIE   %1 13 lshift SDIO-MASK bis! ;  \ SDIO-MASK_RXACTIE    Data receive acting interrupt
  enable
: SDIO-MASK_TXACTIE   %1 12 lshift SDIO-MASK bis! ;  \ SDIO-MASK_TXACTIE    Data transmit acting interrupt
  enable
: SDIO-MASK_CMDACTIE   %1 11 lshift SDIO-MASK bis! ;  \ SDIO-MASK_CMDACTIE    Command acting interrupt
  enable
: SDIO-MASK_DBCKENDIE   %1 10 lshift SDIO-MASK bis! ;  \ SDIO-MASK_DBCKENDIE    Data block end interrupt
  enable
: SDIO-MASK_STBITERRIE   %1 9 lshift SDIO-MASK bis! ;  \ SDIO-MASK_STBITERRIE    Start bit error interrupt
  enable
: SDIO-MASK_DATAENDIE   %1 8 lshift SDIO-MASK bis! ;  \ SDIO-MASK_DATAENDIE    Data end interrupt enable
: SDIO-MASK_CMDSENTIE   %1 7 lshift SDIO-MASK bis! ;  \ SDIO-MASK_CMDSENTIE    Command sent interrupt
  enable
: SDIO-MASK_CMDRENDIE   %1 6 lshift SDIO-MASK bis! ;  \ SDIO-MASK_CMDRENDIE    Command response received interrupt
  enable
: SDIO-MASK_RXOVERRIE   %1 5 lshift SDIO-MASK bis! ;  \ SDIO-MASK_RXOVERRIE    Rx FIFO overrun error interrupt
  enable
: SDIO-MASK_TXUNDERRIE   %1 4 lshift SDIO-MASK bis! ;  \ SDIO-MASK_TXUNDERRIE    Tx FIFO underrun error interrupt
  enable
: SDIO-MASK_DTIMEOUTIE   %1 3 lshift SDIO-MASK bis! ;  \ SDIO-MASK_DTIMEOUTIE    Data timeout interrupt
  enable
: SDIO-MASK_CTIMEOUTIE   %1 2 lshift SDIO-MASK bis! ;  \ SDIO-MASK_CTIMEOUTIE    Command timeout interrupt
  enable
: SDIO-MASK_DCRCFAILIE   %1 1 lshift SDIO-MASK bis! ;  \ SDIO-MASK_DCRCFAILIE    Data CRC fail interrupt
  enable
: SDIO-MASK_CCRCFAILIE   %1 0 lshift SDIO-MASK bis! ;  \ SDIO-MASK_CCRCFAILIE    Command CRC fail interrupt
  enable

\ SDIO-FIFOCNT (read-only)
: SDIO-FIFOCNT_FIFOCOUNT   ( %XXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift SDIO-FIFOCNT bis! ;  \ SDIO-FIFOCNT_FIFOCOUNT    Remaining number of words to be written
  to or read from the FIFO.

\ SDIO-FIFO (read-write)
: SDIO-FIFO_FIFOData   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift SDIO-FIFO bis! ;  \ SDIO-FIFO_FIFOData    Receive and transmit FIFO
  data

\ SYSCFG-MEMRM (read-write)
: SYSCFG-MEMRM_MEM_MODE   ( %XX -- ) 0 lshift SYSCFG-MEMRM bis! ;  \ SYSCFG-MEMRM_MEM_MODE    MEM_MODE

\ SYSCFG-PMC (read-write)
: SYSCFG-PMC_ADC1DC2   %1 16 lshift SYSCFG-PMC bis! ;  \ SYSCFG-PMC_ADC1DC2    ADC1DC2

\ SYSCFG-EXTICR1 (read-write)
: SYSCFG-EXTICR1_EXTI3   ( %XXXX -- ) 12 lshift SYSCFG-EXTICR1 bis! ;  \ SYSCFG-EXTICR1_EXTI3    EXTI x configuration x = 0 to
  3
: SYSCFG-EXTICR1_EXTI2   ( %XXXX -- ) 8 lshift SYSCFG-EXTICR1 bis! ;  \ SYSCFG-EXTICR1_EXTI2    EXTI x configuration x = 0 to
  3
: SYSCFG-EXTICR1_EXTI1   ( %XXXX -- ) 4 lshift SYSCFG-EXTICR1 bis! ;  \ SYSCFG-EXTICR1_EXTI1    EXTI x configuration x = 0 to
  3
: SYSCFG-EXTICR1_EXTI0   ( %XXXX -- ) 0 lshift SYSCFG-EXTICR1 bis! ;  \ SYSCFG-EXTICR1_EXTI0    EXTI x configuration x = 0 to
  3

\ SYSCFG-EXTICR2 (read-write)
: SYSCFG-EXTICR2_EXTI7   ( %XXXX -- ) 12 lshift SYSCFG-EXTICR2 bis! ;  \ SYSCFG-EXTICR2_EXTI7    EXTI x configuration x = 4 to
  7
: SYSCFG-EXTICR2_EXTI6   ( %XXXX -- ) 8 lshift SYSCFG-EXTICR2 bis! ;  \ SYSCFG-EXTICR2_EXTI6    EXTI x configuration x = 4 to
  7
: SYSCFG-EXTICR2_EXTI5   ( %XXXX -- ) 4 lshift SYSCFG-EXTICR2 bis! ;  \ SYSCFG-EXTICR2_EXTI5    EXTI x configuration x = 4 to
  7
: SYSCFG-EXTICR2_EXTI4   ( %XXXX -- ) 0 lshift SYSCFG-EXTICR2 bis! ;  \ SYSCFG-EXTICR2_EXTI4    EXTI x configuration x = 4 to
  7

\ SYSCFG-EXTICR3 (read-write)
: SYSCFG-EXTICR3_EXTI11   ( %XXXX -- ) 12 lshift SYSCFG-EXTICR3 bis! ;  \ SYSCFG-EXTICR3_EXTI11    EXTI x configuration x = 8 to
  11
: SYSCFG-EXTICR3_EXTI10   ( %XXXX -- ) 8 lshift SYSCFG-EXTICR3 bis! ;  \ SYSCFG-EXTICR3_EXTI10    EXTI10
: SYSCFG-EXTICR3_EXTI9   ( %XXXX -- ) 4 lshift SYSCFG-EXTICR3 bis! ;  \ SYSCFG-EXTICR3_EXTI9    EXTI x configuration x = 8 to
  11
: SYSCFG-EXTICR3_EXTI8   ( %XXXX -- ) 0 lshift SYSCFG-EXTICR3 bis! ;  \ SYSCFG-EXTICR3_EXTI8    EXTI x configuration x = 8 to
  11

\ SYSCFG-EXTICR4 (read-write)
: SYSCFG-EXTICR4_EXTI15   ( %XXXX -- ) 12 lshift SYSCFG-EXTICR4 bis! ;  \ SYSCFG-EXTICR4_EXTI15    EXTI x configuration x = 12 to
  15
: SYSCFG-EXTICR4_EXTI14   ( %XXXX -- ) 8 lshift SYSCFG-EXTICR4 bis! ;  \ SYSCFG-EXTICR4_EXTI14    EXTI x configuration x = 12 to
  15
: SYSCFG-EXTICR4_EXTI13   ( %XXXX -- ) 4 lshift SYSCFG-EXTICR4 bis! ;  \ SYSCFG-EXTICR4_EXTI13    EXTI x configuration x = 12 to
  15
: SYSCFG-EXTICR4_EXTI12   ( %XXXX -- ) 0 lshift SYSCFG-EXTICR4 bis! ;  \ SYSCFG-EXTICR4_EXTI12    EXTI x configuration x = 12 to
  15

\ SYSCFG-CMPCR (read-only)
: SYSCFG-CMPCR_READY   %1 8 lshift SYSCFG-CMPCR bis! ;  \ SYSCFG-CMPCR_READY    READY
: SYSCFG-CMPCR_CMP_PD   %1 0 lshift SYSCFG-CMPCR bis! ;  \ SYSCFG-CMPCR_CMP_PD    Compensation cell
  power-down

\ TIM1-CR1 (read-write)
: TIM1-CR1_CKD   ( %XX -- ) 8 lshift TIM1-CR1 bis! ;  \ TIM1-CR1_CKD    Clock division
: TIM1-CR1_ARPE   %1 7 lshift TIM1-CR1 bis! ;  \ TIM1-CR1_ARPE    Auto-reload preload enable
: TIM1-CR1_CMS   ( %XX -- ) 5 lshift TIM1-CR1 bis! ;  \ TIM1-CR1_CMS    Center-aligned mode
  selection
: TIM1-CR1_DIR   %1 4 lshift TIM1-CR1 bis! ;  \ TIM1-CR1_DIR    Direction
: TIM1-CR1_OPM   %1 3 lshift TIM1-CR1 bis! ;  \ TIM1-CR1_OPM    One-pulse mode
: TIM1-CR1_URS   %1 2 lshift TIM1-CR1 bis! ;  \ TIM1-CR1_URS    Update request source
: TIM1-CR1_UDIS   %1 1 lshift TIM1-CR1 bis! ;  \ TIM1-CR1_UDIS    Update disable
: TIM1-CR1_CEN   %1 0 lshift TIM1-CR1 bis! ;  \ TIM1-CR1_CEN    Counter enable

\ TIM1-CR2 (read-write)
: TIM1-CR2_OIS4   %1 14 lshift TIM1-CR2 bis! ;  \ TIM1-CR2_OIS4    Output Idle state 4
: TIM1-CR2_OIS3N   %1 13 lshift TIM1-CR2 bis! ;  \ TIM1-CR2_OIS3N    Output Idle state 3
: TIM1-CR2_OIS3   %1 12 lshift TIM1-CR2 bis! ;  \ TIM1-CR2_OIS3    Output Idle state 3
: TIM1-CR2_OIS2N   %1 11 lshift TIM1-CR2 bis! ;  \ TIM1-CR2_OIS2N    Output Idle state 2
: TIM1-CR2_OIS2   %1 10 lshift TIM1-CR2 bis! ;  \ TIM1-CR2_OIS2    Output Idle state 2
: TIM1-CR2_OIS1N   %1 9 lshift TIM1-CR2 bis! ;  \ TIM1-CR2_OIS1N    Output Idle state 1
: TIM1-CR2_OIS1   %1 8 lshift TIM1-CR2 bis! ;  \ TIM1-CR2_OIS1    Output Idle state 1
: TIM1-CR2_TI1S   %1 7 lshift TIM1-CR2 bis! ;  \ TIM1-CR2_TI1S    TI1 selection
: TIM1-CR2_MMS   ( %XXX -- ) 4 lshift TIM1-CR2 bis! ;  \ TIM1-CR2_MMS    Master mode selection
: TIM1-CR2_CCDS   %1 3 lshift TIM1-CR2 bis! ;  \ TIM1-CR2_CCDS    Capture/compare DMA
  selection
: TIM1-CR2_CCUS   %1 2 lshift TIM1-CR2 bis! ;  \ TIM1-CR2_CCUS    Capture/compare control update
  selection
: TIM1-CR2_CCPC   %1 0 lshift TIM1-CR2 bis! ;  \ TIM1-CR2_CCPC    Capture/compare preloaded
  control

\ TIM1-SMCR (read-write)
: TIM1-SMCR_ETP   %1 15 lshift TIM1-SMCR bis! ;  \ TIM1-SMCR_ETP    External trigger polarity
: TIM1-SMCR_ECE   %1 14 lshift TIM1-SMCR bis! ;  \ TIM1-SMCR_ECE    External clock enable
: TIM1-SMCR_ETPS   ( %XX -- ) 12 lshift TIM1-SMCR bis! ;  \ TIM1-SMCR_ETPS    External trigger prescaler
: TIM1-SMCR_ETF   ( %XXXX -- ) 8 lshift TIM1-SMCR bis! ;  \ TIM1-SMCR_ETF    External trigger filter
: TIM1-SMCR_MSM   %1 7 lshift TIM1-SMCR bis! ;  \ TIM1-SMCR_MSM    Master/Slave mode
: TIM1-SMCR_TS   ( %XXX -- ) 4 lshift TIM1-SMCR bis! ;  \ TIM1-SMCR_TS    Trigger selection
: TIM1-SMCR_SMS   ( %XXX -- ) 0 lshift TIM1-SMCR bis! ;  \ TIM1-SMCR_SMS    Slave mode selection

\ TIM1-DIER (read-write)
: TIM1-DIER_TDE   %1 14 lshift TIM1-DIER bis! ;  \ TIM1-DIER_TDE    Trigger DMA request enable
: TIM1-DIER_COMDE   %1 13 lshift TIM1-DIER bis! ;  \ TIM1-DIER_COMDE    COM DMA request enable
: TIM1-DIER_CC4DE   %1 12 lshift TIM1-DIER bis! ;  \ TIM1-DIER_CC4DE    Capture/Compare 4 DMA request
  enable
: TIM1-DIER_CC3DE   %1 11 lshift TIM1-DIER bis! ;  \ TIM1-DIER_CC3DE    Capture/Compare 3 DMA request
  enable
: TIM1-DIER_CC2DE   %1 10 lshift TIM1-DIER bis! ;  \ TIM1-DIER_CC2DE    Capture/Compare 2 DMA request
  enable
: TIM1-DIER_CC1DE   %1 9 lshift TIM1-DIER bis! ;  \ TIM1-DIER_CC1DE    Capture/Compare 1 DMA request
  enable
: TIM1-DIER_UDE   %1 8 lshift TIM1-DIER bis! ;  \ TIM1-DIER_UDE    Update DMA request enable
: TIM1-DIER_BIE   %1 7 lshift TIM1-DIER bis! ;  \ TIM1-DIER_BIE    Break interrupt enable
: TIM1-DIER_TIE   %1 6 lshift TIM1-DIER bis! ;  \ TIM1-DIER_TIE    Trigger interrupt enable
: TIM1-DIER_COMIE   %1 5 lshift TIM1-DIER bis! ;  \ TIM1-DIER_COMIE    COM interrupt enable
: TIM1-DIER_CC4IE   %1 4 lshift TIM1-DIER bis! ;  \ TIM1-DIER_CC4IE    Capture/Compare 4 interrupt
  enable
: TIM1-DIER_CC3IE   %1 3 lshift TIM1-DIER bis! ;  \ TIM1-DIER_CC3IE    Capture/Compare 3 interrupt
  enable
: TIM1-DIER_CC2IE   %1 2 lshift TIM1-DIER bis! ;  \ TIM1-DIER_CC2IE    Capture/Compare 2 interrupt
  enable
: TIM1-DIER_CC1IE   %1 1 lshift TIM1-DIER bis! ;  \ TIM1-DIER_CC1IE    Capture/Compare 1 interrupt
  enable
: TIM1-DIER_UIE   %1 0 lshift TIM1-DIER bis! ;  \ TIM1-DIER_UIE    Update interrupt enable

\ TIM1-SR (read-write)
: TIM1-SR_CC4OF   %1 12 lshift TIM1-SR bis! ;  \ TIM1-SR_CC4OF    Capture/Compare 4 overcapture
  flag
: TIM1-SR_CC3OF   %1 11 lshift TIM1-SR bis! ;  \ TIM1-SR_CC3OF    Capture/Compare 3 overcapture
  flag
: TIM1-SR_CC2OF   %1 10 lshift TIM1-SR bis! ;  \ TIM1-SR_CC2OF    Capture/compare 2 overcapture
  flag
: TIM1-SR_CC1OF   %1 9 lshift TIM1-SR bis! ;  \ TIM1-SR_CC1OF    Capture/Compare 1 overcapture
  flag
: TIM1-SR_BIF   %1 7 lshift TIM1-SR bis! ;  \ TIM1-SR_BIF    Break interrupt flag
: TIM1-SR_TIF   %1 6 lshift TIM1-SR bis! ;  \ TIM1-SR_TIF    Trigger interrupt flag
: TIM1-SR_COMIF   %1 5 lshift TIM1-SR bis! ;  \ TIM1-SR_COMIF    COM interrupt flag
: TIM1-SR_CC4IF   %1 4 lshift TIM1-SR bis! ;  \ TIM1-SR_CC4IF    Capture/Compare 4 interrupt
  flag
: TIM1-SR_CC3IF   %1 3 lshift TIM1-SR bis! ;  \ TIM1-SR_CC3IF    Capture/Compare 3 interrupt
  flag
: TIM1-SR_CC2IF   %1 2 lshift TIM1-SR bis! ;  \ TIM1-SR_CC2IF    Capture/Compare 2 interrupt
  flag
: TIM1-SR_CC1IF   %1 1 lshift TIM1-SR bis! ;  \ TIM1-SR_CC1IF    Capture/compare 1 interrupt
  flag
: TIM1-SR_UIF   %1 0 lshift TIM1-SR bis! ;  \ TIM1-SR_UIF    Update interrupt flag

\ TIM1-EGR (write-only)
: TIM1-EGR_BG   %1 7 lshift TIM1-EGR bis! ;  \ TIM1-EGR_BG    Break generation
: TIM1-EGR_TG   %1 6 lshift TIM1-EGR bis! ;  \ TIM1-EGR_TG    Trigger generation
: TIM1-EGR_COMG   %1 5 lshift TIM1-EGR bis! ;  \ TIM1-EGR_COMG    Capture/Compare control update
  generation
: TIM1-EGR_CC4G   %1 4 lshift TIM1-EGR bis! ;  \ TIM1-EGR_CC4G    Capture/compare 4
  generation
: TIM1-EGR_CC3G   %1 3 lshift TIM1-EGR bis! ;  \ TIM1-EGR_CC3G    Capture/compare 3
  generation
: TIM1-EGR_CC2G   %1 2 lshift TIM1-EGR bis! ;  \ TIM1-EGR_CC2G    Capture/compare 2
  generation
: TIM1-EGR_CC1G   %1 1 lshift TIM1-EGR bis! ;  \ TIM1-EGR_CC1G    Capture/compare 1
  generation
: TIM1-EGR_UG   %1 0 lshift TIM1-EGR bis! ;  \ TIM1-EGR_UG    Update generation

\ TIM1-CCMR1_Output (read-write)
: TIM1-CCMR1_Output_OC2CE   %1 15 lshift TIM1-CCMR1_Output bis! ;  \ TIM1-CCMR1_Output_OC2CE    Output Compare 2 clear
  enable
: TIM1-CCMR1_Output_OC2M   ( %XXX -- ) 12 lshift TIM1-CCMR1_Output bis! ;  \ TIM1-CCMR1_Output_OC2M    Output Compare 2 mode
: TIM1-CCMR1_Output_OC2PE   %1 11 lshift TIM1-CCMR1_Output bis! ;  \ TIM1-CCMR1_Output_OC2PE    Output Compare 2 preload
  enable
: TIM1-CCMR1_Output_OC2FE   %1 10 lshift TIM1-CCMR1_Output bis! ;  \ TIM1-CCMR1_Output_OC2FE    Output Compare 2 fast
  enable
: TIM1-CCMR1_Output_CC2S   ( %XX -- ) 8 lshift TIM1-CCMR1_Output bis! ;  \ TIM1-CCMR1_Output_CC2S    Capture/Compare 2
  selection
: TIM1-CCMR1_Output_OC1CE   %1 7 lshift TIM1-CCMR1_Output bis! ;  \ TIM1-CCMR1_Output_OC1CE    Output Compare 1 clear
  enable
: TIM1-CCMR1_Output_OC1M   ( %XXX -- ) 4 lshift TIM1-CCMR1_Output bis! ;  \ TIM1-CCMR1_Output_OC1M    Output Compare 1 mode
: TIM1-CCMR1_Output_OC1PE   %1 3 lshift TIM1-CCMR1_Output bis! ;  \ TIM1-CCMR1_Output_OC1PE    Output Compare 1 preload
  enable
: TIM1-CCMR1_Output_OC1FE   %1 2 lshift TIM1-CCMR1_Output bis! ;  \ TIM1-CCMR1_Output_OC1FE    Output Compare 1 fast
  enable
: TIM1-CCMR1_Output_CC1S   ( %XX -- ) 0 lshift TIM1-CCMR1_Output bis! ;  \ TIM1-CCMR1_Output_CC1S    Capture/Compare 1
  selection

\ TIM1-CCMR1_Input (read-write)
: TIM1-CCMR1_Input_IC2F   ( %XXXX -- ) 12 lshift TIM1-CCMR1_Input bis! ;  \ TIM1-CCMR1_Input_IC2F    Input capture 2 filter
: TIM1-CCMR1_Input_IC2PCS   ( %XX -- ) 10 lshift TIM1-CCMR1_Input bis! ;  \ TIM1-CCMR1_Input_IC2PCS    Input capture 2 prescaler
: TIM1-CCMR1_Input_CC2S   ( %XX -- ) 8 lshift TIM1-CCMR1_Input bis! ;  \ TIM1-CCMR1_Input_CC2S    Capture/Compare 2
  selection
: TIM1-CCMR1_Input_IC1F   ( %XXXX -- ) 4 lshift TIM1-CCMR1_Input bis! ;  \ TIM1-CCMR1_Input_IC1F    Input capture 1 filter
: TIM1-CCMR1_Input_ICPCS   ( %XX -- ) 2 lshift TIM1-CCMR1_Input bis! ;  \ TIM1-CCMR1_Input_ICPCS    Input capture 1 prescaler
: TIM1-CCMR1_Input_CC1S   ( %XX -- ) 0 lshift TIM1-CCMR1_Input bis! ;  \ TIM1-CCMR1_Input_CC1S    Capture/Compare 1
  selection

\ TIM1-CCMR2_Output (read-write)
: TIM1-CCMR2_Output_OC4CE   %1 15 lshift TIM1-CCMR2_Output bis! ;  \ TIM1-CCMR2_Output_OC4CE    Output compare 4 clear
  enable
: TIM1-CCMR2_Output_OC4M   ( %XXX -- ) 12 lshift TIM1-CCMR2_Output bis! ;  \ TIM1-CCMR2_Output_OC4M    Output compare 4 mode
: TIM1-CCMR2_Output_OC4PE   %1 11 lshift TIM1-CCMR2_Output bis! ;  \ TIM1-CCMR2_Output_OC4PE    Output compare 4 preload
  enable
: TIM1-CCMR2_Output_OC4FE   %1 10 lshift TIM1-CCMR2_Output bis! ;  \ TIM1-CCMR2_Output_OC4FE    Output compare 4 fast
  enable
: TIM1-CCMR2_Output_CC4S   ( %XX -- ) 8 lshift TIM1-CCMR2_Output bis! ;  \ TIM1-CCMR2_Output_CC4S    Capture/Compare 4
  selection
: TIM1-CCMR2_Output_OC3CE   %1 7 lshift TIM1-CCMR2_Output bis! ;  \ TIM1-CCMR2_Output_OC3CE    Output compare 3 clear
  enable
: TIM1-CCMR2_Output_OC3M   ( %XXX -- ) 4 lshift TIM1-CCMR2_Output bis! ;  \ TIM1-CCMR2_Output_OC3M    Output compare 3 mode
: TIM1-CCMR2_Output_OC3PE   %1 3 lshift TIM1-CCMR2_Output bis! ;  \ TIM1-CCMR2_Output_OC3PE    Output compare 3 preload
  enable
: TIM1-CCMR2_Output_OC3FE   %1 2 lshift TIM1-CCMR2_Output bis! ;  \ TIM1-CCMR2_Output_OC3FE    Output compare 3 fast
  enable
: TIM1-CCMR2_Output_CC3S   ( %XX -- ) 0 lshift TIM1-CCMR2_Output bis! ;  \ TIM1-CCMR2_Output_CC3S    Capture/Compare 3
  selection

\ TIM1-CCMR2_Input (read-write)
: TIM1-CCMR2_Input_IC4F   ( %XXXX -- ) 12 lshift TIM1-CCMR2_Input bis! ;  \ TIM1-CCMR2_Input_IC4F    Input capture 4 filter
: TIM1-CCMR2_Input_IC4PSC   ( %XX -- ) 10 lshift TIM1-CCMR2_Input bis! ;  \ TIM1-CCMR2_Input_IC4PSC    Input capture 4 prescaler
: TIM1-CCMR2_Input_CC4S   ( %XX -- ) 8 lshift TIM1-CCMR2_Input bis! ;  \ TIM1-CCMR2_Input_CC4S    Capture/Compare 4
  selection
: TIM1-CCMR2_Input_IC3F   ( %XXXX -- ) 4 lshift TIM1-CCMR2_Input bis! ;  \ TIM1-CCMR2_Input_IC3F    Input capture 3 filter
: TIM1-CCMR2_Input_IC3PSC   ( %XX -- ) 2 lshift TIM1-CCMR2_Input bis! ;  \ TIM1-CCMR2_Input_IC3PSC    Input capture 3 prescaler
: TIM1-CCMR2_Input_CC3S   ( %XX -- ) 0 lshift TIM1-CCMR2_Input bis! ;  \ TIM1-CCMR2_Input_CC3S    Capture/compare 3
  selection

\ TIM1-CCER (read-write)
: TIM1-CCER_CC4P   %1 13 lshift TIM1-CCER bis! ;  \ TIM1-CCER_CC4P    Capture/Compare 3 output
  Polarity
: TIM1-CCER_CC4E   %1 12 lshift TIM1-CCER bis! ;  \ TIM1-CCER_CC4E    Capture/Compare 4 output
  enable
: TIM1-CCER_CC3NP   %1 11 lshift TIM1-CCER bis! ;  \ TIM1-CCER_CC3NP    Capture/Compare 3 output
  Polarity
: TIM1-CCER_CC3NE   %1 10 lshift TIM1-CCER bis! ;  \ TIM1-CCER_CC3NE    Capture/Compare 3 complementary output
  enable
: TIM1-CCER_CC3P   %1 9 lshift TIM1-CCER bis! ;  \ TIM1-CCER_CC3P    Capture/Compare 3 output
  Polarity
: TIM1-CCER_CC3E   %1 8 lshift TIM1-CCER bis! ;  \ TIM1-CCER_CC3E    Capture/Compare 3 output
  enable
: TIM1-CCER_CC2NP   %1 7 lshift TIM1-CCER bis! ;  \ TIM1-CCER_CC2NP    Capture/Compare 2 output
  Polarity
: TIM1-CCER_CC2NE   %1 6 lshift TIM1-CCER bis! ;  \ TIM1-CCER_CC2NE    Capture/Compare 2 complementary output
  enable
: TIM1-CCER_CC2P   %1 5 lshift TIM1-CCER bis! ;  \ TIM1-CCER_CC2P    Capture/Compare 2 output
  Polarity
: TIM1-CCER_CC2E   %1 4 lshift TIM1-CCER bis! ;  \ TIM1-CCER_CC2E    Capture/Compare 2 output
  enable
: TIM1-CCER_CC1NP   %1 3 lshift TIM1-CCER bis! ;  \ TIM1-CCER_CC1NP    Capture/Compare 1 output
  Polarity
: TIM1-CCER_CC1NE   %1 2 lshift TIM1-CCER bis! ;  \ TIM1-CCER_CC1NE    Capture/Compare 1 complementary output
  enable
: TIM1-CCER_CC1P   %1 1 lshift TIM1-CCER bis! ;  \ TIM1-CCER_CC1P    Capture/Compare 1 output
  Polarity
: TIM1-CCER_CC1E   %1 0 lshift TIM1-CCER bis! ;  \ TIM1-CCER_CC1E    Capture/Compare 1 output
  enable

\ TIM1-CNT (read-write)
: TIM1-CNT_CNT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM1-CNT bis! ;  \ TIM1-CNT_CNT    counter value

\ TIM1-PSC (read-write)
: TIM1-PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM1-PSC bis! ;  \ TIM1-PSC_PSC    Prescaler value

\ TIM1-ARR (read-write)
: TIM1-ARR_ARR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM1-ARR bis! ;  \ TIM1-ARR_ARR    Auto-reload value

\ TIM1-CCR1 (read-write)
: TIM1-CCR1_CCR1   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM1-CCR1 bis! ;  \ TIM1-CCR1_CCR1    Capture/Compare 1 value

\ TIM1-CCR2 (read-write)
: TIM1-CCR2_CCR2   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM1-CCR2 bis! ;  \ TIM1-CCR2_CCR2    Capture/Compare 2 value

\ TIM1-CCR3 (read-write)
: TIM1-CCR3_CCR3   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM1-CCR3 bis! ;  \ TIM1-CCR3_CCR3    Capture/Compare value

\ TIM1-CCR4 (read-write)
: TIM1-CCR4_CCR4   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM1-CCR4 bis! ;  \ TIM1-CCR4_CCR4    Capture/Compare value

\ TIM1-DCR (read-write)
: TIM1-DCR_DBL   ( %XXXXX -- ) 8 lshift TIM1-DCR bis! ;  \ TIM1-DCR_DBL    DMA burst length
: TIM1-DCR_DBA   ( %XXXXX -- ) 0 lshift TIM1-DCR bis! ;  \ TIM1-DCR_DBA    DMA base address

\ TIM1-DMAR (read-write)
: TIM1-DMAR_DMAB   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM1-DMAR bis! ;  \ TIM1-DMAR_DMAB    DMA register for burst
  accesses

\ TIM1-RCR (read-write)
: TIM1-RCR_REP   ( %XXXXXXXX -- ) 0 lshift TIM1-RCR bis! ;  \ TIM1-RCR_REP    Repetition counter value

\ TIM1-BDTR (read-write)
: TIM1-BDTR_MOE   %1 15 lshift TIM1-BDTR bis! ;  \ TIM1-BDTR_MOE    Main output enable
: TIM1-BDTR_AOE   %1 14 lshift TIM1-BDTR bis! ;  \ TIM1-BDTR_AOE    Automatic output enable
: TIM1-BDTR_BKP   %1 13 lshift TIM1-BDTR bis! ;  \ TIM1-BDTR_BKP    Break polarity
: TIM1-BDTR_BKE   %1 12 lshift TIM1-BDTR bis! ;  \ TIM1-BDTR_BKE    Break enable
: TIM1-BDTR_OSSR   %1 11 lshift TIM1-BDTR bis! ;  \ TIM1-BDTR_OSSR    Off-state selection for Run
  mode
: TIM1-BDTR_OSSI   %1 10 lshift TIM1-BDTR bis! ;  \ TIM1-BDTR_OSSI    Off-state selection for Idle
  mode
: TIM1-BDTR_LOCK   ( %XX -- ) 8 lshift TIM1-BDTR bis! ;  \ TIM1-BDTR_LOCK    Lock configuration
: TIM1-BDTR_DTG   ( %XXXXXXXX -- ) 0 lshift TIM1-BDTR bis! ;  \ TIM1-BDTR_DTG    Dead-time generator setup

\ TIM8-CR1 (read-write)
: TIM8-CR1_CKD   ( %XX -- ) 8 lshift TIM8-CR1 bis! ;  \ TIM8-CR1_CKD    Clock division
: TIM8-CR1_ARPE   %1 7 lshift TIM8-CR1 bis! ;  \ TIM8-CR1_ARPE    Auto-reload preload enable
: TIM8-CR1_CMS   ( %XX -- ) 5 lshift TIM8-CR1 bis! ;  \ TIM8-CR1_CMS    Center-aligned mode
  selection
: TIM8-CR1_DIR   %1 4 lshift TIM8-CR1 bis! ;  \ TIM8-CR1_DIR    Direction
: TIM8-CR1_OPM   %1 3 lshift TIM8-CR1 bis! ;  \ TIM8-CR1_OPM    One-pulse mode
: TIM8-CR1_URS   %1 2 lshift TIM8-CR1 bis! ;  \ TIM8-CR1_URS    Update request source
: TIM8-CR1_UDIS   %1 1 lshift TIM8-CR1 bis! ;  \ TIM8-CR1_UDIS    Update disable
: TIM8-CR1_CEN   %1 0 lshift TIM8-CR1 bis! ;  \ TIM8-CR1_CEN    Counter enable

\ TIM8-CR2 (read-write)
: TIM8-CR2_OIS4   %1 14 lshift TIM8-CR2 bis! ;  \ TIM8-CR2_OIS4    Output Idle state 4
: TIM8-CR2_OIS3N   %1 13 lshift TIM8-CR2 bis! ;  \ TIM8-CR2_OIS3N    Output Idle state 3
: TIM8-CR2_OIS3   %1 12 lshift TIM8-CR2 bis! ;  \ TIM8-CR2_OIS3    Output Idle state 3
: TIM8-CR2_OIS2N   %1 11 lshift TIM8-CR2 bis! ;  \ TIM8-CR2_OIS2N    Output Idle state 2
: TIM8-CR2_OIS2   %1 10 lshift TIM8-CR2 bis! ;  \ TIM8-CR2_OIS2    Output Idle state 2
: TIM8-CR2_OIS1N   %1 9 lshift TIM8-CR2 bis! ;  \ TIM8-CR2_OIS1N    Output Idle state 1
: TIM8-CR2_OIS1   %1 8 lshift TIM8-CR2 bis! ;  \ TIM8-CR2_OIS1    Output Idle state 1
: TIM8-CR2_TI1S   %1 7 lshift TIM8-CR2 bis! ;  \ TIM8-CR2_TI1S    TI1 selection
: TIM8-CR2_MMS   ( %XXX -- ) 4 lshift TIM8-CR2 bis! ;  \ TIM8-CR2_MMS    Master mode selection
: TIM8-CR2_CCDS   %1 3 lshift TIM8-CR2 bis! ;  \ TIM8-CR2_CCDS    Capture/compare DMA
  selection
: TIM8-CR2_CCUS   %1 2 lshift TIM8-CR2 bis! ;  \ TIM8-CR2_CCUS    Capture/compare control update
  selection
: TIM8-CR2_CCPC   %1 0 lshift TIM8-CR2 bis! ;  \ TIM8-CR2_CCPC    Capture/compare preloaded
  control

\ TIM8-SMCR (read-write)
: TIM8-SMCR_ETP   %1 15 lshift TIM8-SMCR bis! ;  \ TIM8-SMCR_ETP    External trigger polarity
: TIM8-SMCR_ECE   %1 14 lshift TIM8-SMCR bis! ;  \ TIM8-SMCR_ECE    External clock enable
: TIM8-SMCR_ETPS   ( %XX -- ) 12 lshift TIM8-SMCR bis! ;  \ TIM8-SMCR_ETPS    External trigger prescaler
: TIM8-SMCR_ETF   ( %XXXX -- ) 8 lshift TIM8-SMCR bis! ;  \ TIM8-SMCR_ETF    External trigger filter
: TIM8-SMCR_MSM   %1 7 lshift TIM8-SMCR bis! ;  \ TIM8-SMCR_MSM    Master/Slave mode
: TIM8-SMCR_TS   ( %XXX -- ) 4 lshift TIM8-SMCR bis! ;  \ TIM8-SMCR_TS    Trigger selection
: TIM8-SMCR_SMS   ( %XXX -- ) 0 lshift TIM8-SMCR bis! ;  \ TIM8-SMCR_SMS    Slave mode selection

\ TIM8-DIER (read-write)
: TIM8-DIER_TDE   %1 14 lshift TIM8-DIER bis! ;  \ TIM8-DIER_TDE    Trigger DMA request enable
: TIM8-DIER_COMDE   %1 13 lshift TIM8-DIER bis! ;  \ TIM8-DIER_COMDE    COM DMA request enable
: TIM8-DIER_CC4DE   %1 12 lshift TIM8-DIER bis! ;  \ TIM8-DIER_CC4DE    Capture/Compare 4 DMA request
  enable
: TIM8-DIER_CC3DE   %1 11 lshift TIM8-DIER bis! ;  \ TIM8-DIER_CC3DE    Capture/Compare 3 DMA request
  enable
: TIM8-DIER_CC2DE   %1 10 lshift TIM8-DIER bis! ;  \ TIM8-DIER_CC2DE    Capture/Compare 2 DMA request
  enable
: TIM8-DIER_CC1DE   %1 9 lshift TIM8-DIER bis! ;  \ TIM8-DIER_CC1DE    Capture/Compare 1 DMA request
  enable
: TIM8-DIER_UDE   %1 8 lshift TIM8-DIER bis! ;  \ TIM8-DIER_UDE    Update DMA request enable
: TIM8-DIER_BIE   %1 7 lshift TIM8-DIER bis! ;  \ TIM8-DIER_BIE    Break interrupt enable
: TIM8-DIER_TIE   %1 6 lshift TIM8-DIER bis! ;  \ TIM8-DIER_TIE    Trigger interrupt enable
: TIM8-DIER_COMIE   %1 5 lshift TIM8-DIER bis! ;  \ TIM8-DIER_COMIE    COM interrupt enable
: TIM8-DIER_CC4IE   %1 4 lshift TIM8-DIER bis! ;  \ TIM8-DIER_CC4IE    Capture/Compare 4 interrupt
  enable
: TIM8-DIER_CC3IE   %1 3 lshift TIM8-DIER bis! ;  \ TIM8-DIER_CC3IE    Capture/Compare 3 interrupt
  enable
: TIM8-DIER_CC2IE   %1 2 lshift TIM8-DIER bis! ;  \ TIM8-DIER_CC2IE    Capture/Compare 2 interrupt
  enable
: TIM8-DIER_CC1IE   %1 1 lshift TIM8-DIER bis! ;  \ TIM8-DIER_CC1IE    Capture/Compare 1 interrupt
  enable
: TIM8-DIER_UIE   %1 0 lshift TIM8-DIER bis! ;  \ TIM8-DIER_UIE    Update interrupt enable

\ TIM8-SR (read-write)
: TIM8-SR_CC4OF   %1 12 lshift TIM8-SR bis! ;  \ TIM8-SR_CC4OF    Capture/Compare 4 overcapture
  flag
: TIM8-SR_CC3OF   %1 11 lshift TIM8-SR bis! ;  \ TIM8-SR_CC3OF    Capture/Compare 3 overcapture
  flag
: TIM8-SR_CC2OF   %1 10 lshift TIM8-SR bis! ;  \ TIM8-SR_CC2OF    Capture/compare 2 overcapture
  flag
: TIM8-SR_CC1OF   %1 9 lshift TIM8-SR bis! ;  \ TIM8-SR_CC1OF    Capture/Compare 1 overcapture
  flag
: TIM8-SR_BIF   %1 7 lshift TIM8-SR bis! ;  \ TIM8-SR_BIF    Break interrupt flag
: TIM8-SR_TIF   %1 6 lshift TIM8-SR bis! ;  \ TIM8-SR_TIF    Trigger interrupt flag
: TIM8-SR_COMIF   %1 5 lshift TIM8-SR bis! ;  \ TIM8-SR_COMIF    COM interrupt flag
: TIM8-SR_CC4IF   %1 4 lshift TIM8-SR bis! ;  \ TIM8-SR_CC4IF    Capture/Compare 4 interrupt
  flag
: TIM8-SR_CC3IF   %1 3 lshift TIM8-SR bis! ;  \ TIM8-SR_CC3IF    Capture/Compare 3 interrupt
  flag
: TIM8-SR_CC2IF   %1 2 lshift TIM8-SR bis! ;  \ TIM8-SR_CC2IF    Capture/Compare 2 interrupt
  flag
: TIM8-SR_CC1IF   %1 1 lshift TIM8-SR bis! ;  \ TIM8-SR_CC1IF    Capture/compare 1 interrupt
  flag
: TIM8-SR_UIF   %1 0 lshift TIM8-SR bis! ;  \ TIM8-SR_UIF    Update interrupt flag

\ TIM8-EGR (write-only)
: TIM8-EGR_BG   %1 7 lshift TIM8-EGR bis! ;  \ TIM8-EGR_BG    Break generation
: TIM8-EGR_TG   %1 6 lshift TIM8-EGR bis! ;  \ TIM8-EGR_TG    Trigger generation
: TIM8-EGR_COMG   %1 5 lshift TIM8-EGR bis! ;  \ TIM8-EGR_COMG    Capture/Compare control update
  generation
: TIM8-EGR_CC4G   %1 4 lshift TIM8-EGR bis! ;  \ TIM8-EGR_CC4G    Capture/compare 4
  generation
: TIM8-EGR_CC3G   %1 3 lshift TIM8-EGR bis! ;  \ TIM8-EGR_CC3G    Capture/compare 3
  generation
: TIM8-EGR_CC2G   %1 2 lshift TIM8-EGR bis! ;  \ TIM8-EGR_CC2G    Capture/compare 2
  generation
: TIM8-EGR_CC1G   %1 1 lshift TIM8-EGR bis! ;  \ TIM8-EGR_CC1G    Capture/compare 1
  generation
: TIM8-EGR_UG   %1 0 lshift TIM8-EGR bis! ;  \ TIM8-EGR_UG    Update generation

\ TIM8-CCMR1_Output (read-write)
: TIM8-CCMR1_Output_OC2CE   %1 15 lshift TIM8-CCMR1_Output bis! ;  \ TIM8-CCMR1_Output_OC2CE    Output Compare 2 clear
  enable
: TIM8-CCMR1_Output_OC2M   ( %XXX -- ) 12 lshift TIM8-CCMR1_Output bis! ;  \ TIM8-CCMR1_Output_OC2M    Output Compare 2 mode
: TIM8-CCMR1_Output_OC2PE   %1 11 lshift TIM8-CCMR1_Output bis! ;  \ TIM8-CCMR1_Output_OC2PE    Output Compare 2 preload
  enable
: TIM8-CCMR1_Output_OC2FE   %1 10 lshift TIM8-CCMR1_Output bis! ;  \ TIM8-CCMR1_Output_OC2FE    Output Compare 2 fast
  enable
: TIM8-CCMR1_Output_CC2S   ( %XX -- ) 8 lshift TIM8-CCMR1_Output bis! ;  \ TIM8-CCMR1_Output_CC2S    Capture/Compare 2
  selection
: TIM8-CCMR1_Output_OC1CE   %1 7 lshift TIM8-CCMR1_Output bis! ;  \ TIM8-CCMR1_Output_OC1CE    Output Compare 1 clear
  enable
: TIM8-CCMR1_Output_OC1M   ( %XXX -- ) 4 lshift TIM8-CCMR1_Output bis! ;  \ TIM8-CCMR1_Output_OC1M    Output Compare 1 mode
: TIM8-CCMR1_Output_OC1PE   %1 3 lshift TIM8-CCMR1_Output bis! ;  \ TIM8-CCMR1_Output_OC1PE    Output Compare 1 preload
  enable
: TIM8-CCMR1_Output_OC1FE   %1 2 lshift TIM8-CCMR1_Output bis! ;  \ TIM8-CCMR1_Output_OC1FE    Output Compare 1 fast
  enable
: TIM8-CCMR1_Output_CC1S   ( %XX -- ) 0 lshift TIM8-CCMR1_Output bis! ;  \ TIM8-CCMR1_Output_CC1S    Capture/Compare 1
  selection

\ TIM8-CCMR1_Input (read-write)
: TIM8-CCMR1_Input_IC2F   ( %XXXX -- ) 12 lshift TIM8-CCMR1_Input bis! ;  \ TIM8-CCMR1_Input_IC2F    Input capture 2 filter
: TIM8-CCMR1_Input_IC2PCS   ( %XX -- ) 10 lshift TIM8-CCMR1_Input bis! ;  \ TIM8-CCMR1_Input_IC2PCS    Input capture 2 prescaler
: TIM8-CCMR1_Input_CC2S   ( %XX -- ) 8 lshift TIM8-CCMR1_Input bis! ;  \ TIM8-CCMR1_Input_CC2S    Capture/Compare 2
  selection
: TIM8-CCMR1_Input_IC1F   ( %XXXX -- ) 4 lshift TIM8-CCMR1_Input bis! ;  \ TIM8-CCMR1_Input_IC1F    Input capture 1 filter
: TIM8-CCMR1_Input_ICPCS   ( %XX -- ) 2 lshift TIM8-CCMR1_Input bis! ;  \ TIM8-CCMR1_Input_ICPCS    Input capture 1 prescaler
: TIM8-CCMR1_Input_CC1S   ( %XX -- ) 0 lshift TIM8-CCMR1_Input bis! ;  \ TIM8-CCMR1_Input_CC1S    Capture/Compare 1
  selection

\ TIM8-CCMR2_Output (read-write)
: TIM8-CCMR2_Output_OC4CE   %1 15 lshift TIM8-CCMR2_Output bis! ;  \ TIM8-CCMR2_Output_OC4CE    Output compare 4 clear
  enable
: TIM8-CCMR2_Output_OC4M   ( %XXX -- ) 12 lshift TIM8-CCMR2_Output bis! ;  \ TIM8-CCMR2_Output_OC4M    Output compare 4 mode
: TIM8-CCMR2_Output_OC4PE   %1 11 lshift TIM8-CCMR2_Output bis! ;  \ TIM8-CCMR2_Output_OC4PE    Output compare 4 preload
  enable
: TIM8-CCMR2_Output_OC4FE   %1 10 lshift TIM8-CCMR2_Output bis! ;  \ TIM8-CCMR2_Output_OC4FE    Output compare 4 fast
  enable
: TIM8-CCMR2_Output_CC4S   ( %XX -- ) 8 lshift TIM8-CCMR2_Output bis! ;  \ TIM8-CCMR2_Output_CC4S    Capture/Compare 4
  selection
: TIM8-CCMR2_Output_OC3CE   %1 7 lshift TIM8-CCMR2_Output bis! ;  \ TIM8-CCMR2_Output_OC3CE    Output compare 3 clear
  enable
: TIM8-CCMR2_Output_OC3M   ( %XXX -- ) 4 lshift TIM8-CCMR2_Output bis! ;  \ TIM8-CCMR2_Output_OC3M    Output compare 3 mode
: TIM8-CCMR2_Output_OC3PE   %1 3 lshift TIM8-CCMR2_Output bis! ;  \ TIM8-CCMR2_Output_OC3PE    Output compare 3 preload
  enable
: TIM8-CCMR2_Output_OC3FE   %1 2 lshift TIM8-CCMR2_Output bis! ;  \ TIM8-CCMR2_Output_OC3FE    Output compare 3 fast
  enable
: TIM8-CCMR2_Output_CC3S   ( %XX -- ) 0 lshift TIM8-CCMR2_Output bis! ;  \ TIM8-CCMR2_Output_CC3S    Capture/Compare 3
  selection

\ TIM8-CCMR2_Input (read-write)
: TIM8-CCMR2_Input_IC4F   ( %XXXX -- ) 12 lshift TIM8-CCMR2_Input bis! ;  \ TIM8-CCMR2_Input_IC4F    Input capture 4 filter
: TIM8-CCMR2_Input_IC4PSC   ( %XX -- ) 10 lshift TIM8-CCMR2_Input bis! ;  \ TIM8-CCMR2_Input_IC4PSC    Input capture 4 prescaler
: TIM8-CCMR2_Input_CC4S   ( %XX -- ) 8 lshift TIM8-CCMR2_Input bis! ;  \ TIM8-CCMR2_Input_CC4S    Capture/Compare 4
  selection
: TIM8-CCMR2_Input_IC3F   ( %XXXX -- ) 4 lshift TIM8-CCMR2_Input bis! ;  \ TIM8-CCMR2_Input_IC3F    Input capture 3 filter
: TIM8-CCMR2_Input_IC3PSC   ( %XX -- ) 2 lshift TIM8-CCMR2_Input bis! ;  \ TIM8-CCMR2_Input_IC3PSC    Input capture 3 prescaler
: TIM8-CCMR2_Input_CC3S   ( %XX -- ) 0 lshift TIM8-CCMR2_Input bis! ;  \ TIM8-CCMR2_Input_CC3S    Capture/compare 3
  selection

\ TIM8-CCER (read-write)
: TIM8-CCER_CC4P   %1 13 lshift TIM8-CCER bis! ;  \ TIM8-CCER_CC4P    Capture/Compare 3 output
  Polarity
: TIM8-CCER_CC4E   %1 12 lshift TIM8-CCER bis! ;  \ TIM8-CCER_CC4E    Capture/Compare 4 output
  enable
: TIM8-CCER_CC3NP   %1 11 lshift TIM8-CCER bis! ;  \ TIM8-CCER_CC3NP    Capture/Compare 3 output
  Polarity
: TIM8-CCER_CC3NE   %1 10 lshift TIM8-CCER bis! ;  \ TIM8-CCER_CC3NE    Capture/Compare 3 complementary output
  enable
: TIM8-CCER_CC3P   %1 9 lshift TIM8-CCER bis! ;  \ TIM8-CCER_CC3P    Capture/Compare 3 output
  Polarity
: TIM8-CCER_CC3E   %1 8 lshift TIM8-CCER bis! ;  \ TIM8-CCER_CC3E    Capture/Compare 3 output
  enable
: TIM8-CCER_CC2NP   %1 7 lshift TIM8-CCER bis! ;  \ TIM8-CCER_CC2NP    Capture/Compare 2 output
  Polarity
: TIM8-CCER_CC2NE   %1 6 lshift TIM8-CCER bis! ;  \ TIM8-CCER_CC2NE    Capture/Compare 2 complementary output
  enable
: TIM8-CCER_CC2P   %1 5 lshift TIM8-CCER bis! ;  \ TIM8-CCER_CC2P    Capture/Compare 2 output
  Polarity
: TIM8-CCER_CC2E   %1 4 lshift TIM8-CCER bis! ;  \ TIM8-CCER_CC2E    Capture/Compare 2 output
  enable
: TIM8-CCER_CC1NP   %1 3 lshift TIM8-CCER bis! ;  \ TIM8-CCER_CC1NP    Capture/Compare 1 output
  Polarity
: TIM8-CCER_CC1NE   %1 2 lshift TIM8-CCER bis! ;  \ TIM8-CCER_CC1NE    Capture/Compare 1 complementary output
  enable
: TIM8-CCER_CC1P   %1 1 lshift TIM8-CCER bis! ;  \ TIM8-CCER_CC1P    Capture/Compare 1 output
  Polarity
: TIM8-CCER_CC1E   %1 0 lshift TIM8-CCER bis! ;  \ TIM8-CCER_CC1E    Capture/Compare 1 output
  enable

\ TIM8-CNT (read-write)
: TIM8-CNT_CNT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM8-CNT bis! ;  \ TIM8-CNT_CNT    counter value

\ TIM8-PSC (read-write)
: TIM8-PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM8-PSC bis! ;  \ TIM8-PSC_PSC    Prescaler value

\ TIM8-ARR (read-write)
: TIM8-ARR_ARR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM8-ARR bis! ;  \ TIM8-ARR_ARR    Auto-reload value

\ TIM8-CCR1 (read-write)
: TIM8-CCR1_CCR1   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM8-CCR1 bis! ;  \ TIM8-CCR1_CCR1    Capture/Compare 1 value

\ TIM8-CCR2 (read-write)
: TIM8-CCR2_CCR2   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM8-CCR2 bis! ;  \ TIM8-CCR2_CCR2    Capture/Compare 2 value

\ TIM8-CCR3 (read-write)
: TIM8-CCR3_CCR3   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM8-CCR3 bis! ;  \ TIM8-CCR3_CCR3    Capture/Compare value

\ TIM8-CCR4 (read-write)
: TIM8-CCR4_CCR4   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM8-CCR4 bis! ;  \ TIM8-CCR4_CCR4    Capture/Compare value

\ TIM8-DCR (read-write)
: TIM8-DCR_DBL   ( %XXXXX -- ) 8 lshift TIM8-DCR bis! ;  \ TIM8-DCR_DBL    DMA burst length
: TIM8-DCR_DBA   ( %XXXXX -- ) 0 lshift TIM8-DCR bis! ;  \ TIM8-DCR_DBA    DMA base address

\ TIM8-DMAR (read-write)
: TIM8-DMAR_DMAB   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM8-DMAR bis! ;  \ TIM8-DMAR_DMAB    DMA register for burst
  accesses

\ TIM8-RCR (read-write)
: TIM8-RCR_REP   ( %XXXXXXXX -- ) 0 lshift TIM8-RCR bis! ;  \ TIM8-RCR_REP    Repetition counter value

\ TIM8-BDTR (read-write)
: TIM8-BDTR_MOE   %1 15 lshift TIM8-BDTR bis! ;  \ TIM8-BDTR_MOE    Main output enable
: TIM8-BDTR_AOE   %1 14 lshift TIM8-BDTR bis! ;  \ TIM8-BDTR_AOE    Automatic output enable
: TIM8-BDTR_BKP   %1 13 lshift TIM8-BDTR bis! ;  \ TIM8-BDTR_BKP    Break polarity
: TIM8-BDTR_BKE   %1 12 lshift TIM8-BDTR bis! ;  \ TIM8-BDTR_BKE    Break enable
: TIM8-BDTR_OSSR   %1 11 lshift TIM8-BDTR bis! ;  \ TIM8-BDTR_OSSR    Off-state selection for Run
  mode
: TIM8-BDTR_OSSI   %1 10 lshift TIM8-BDTR bis! ;  \ TIM8-BDTR_OSSI    Off-state selection for Idle
  mode
: TIM8-BDTR_LOCK   ( %XX -- ) 8 lshift TIM8-BDTR bis! ;  \ TIM8-BDTR_LOCK    Lock configuration
: TIM8-BDTR_DTG   ( %XXXXXXXX -- ) 0 lshift TIM8-BDTR bis! ;  \ TIM8-BDTR_DTG    Dead-time generator setup

\ TIM10-CR1 (read-write)
: TIM10-CR1_CKD   ( %XX -- ) 8 lshift TIM10-CR1 bis! ;  \ TIM10-CR1_CKD    Clock division
: TIM10-CR1_ARPE   %1 7 lshift TIM10-CR1 bis! ;  \ TIM10-CR1_ARPE    Auto-reload preload enable
: TIM10-CR1_URS   %1 2 lshift TIM10-CR1 bis! ;  \ TIM10-CR1_URS    Update request source
: TIM10-CR1_UDIS   %1 1 lshift TIM10-CR1 bis! ;  \ TIM10-CR1_UDIS    Update disable
: TIM10-CR1_CEN   %1 0 lshift TIM10-CR1 bis! ;  \ TIM10-CR1_CEN    Counter enable

\ TIM10-DIER (read-write)
: TIM10-DIER_CC1IE   %1 1 lshift TIM10-DIER bis! ;  \ TIM10-DIER_CC1IE    Capture/Compare 1 interrupt
  enable
: TIM10-DIER_UIE   %1 0 lshift TIM10-DIER bis! ;  \ TIM10-DIER_UIE    Update interrupt enable

\ TIM10-SR (read-write)
: TIM10-SR_CC1OF   %1 9 lshift TIM10-SR bis! ;  \ TIM10-SR_CC1OF    Capture/Compare 1 overcapture
  flag
: TIM10-SR_CC1IF   %1 1 lshift TIM10-SR bis! ;  \ TIM10-SR_CC1IF    Capture/compare 1 interrupt
  flag
: TIM10-SR_UIF   %1 0 lshift TIM10-SR bis! ;  \ TIM10-SR_UIF    Update interrupt flag

\ TIM10-EGR (write-only)
: TIM10-EGR_CC1G   %1 1 lshift TIM10-EGR bis! ;  \ TIM10-EGR_CC1G    Capture/compare 1
  generation
: TIM10-EGR_UG   %1 0 lshift TIM10-EGR bis! ;  \ TIM10-EGR_UG    Update generation

\ TIM10-CCMR1_Output (read-write)
: TIM10-CCMR1_Output_OC1M   ( %XXX -- ) 4 lshift TIM10-CCMR1_Output bis! ;  \ TIM10-CCMR1_Output_OC1M    Output Compare 1 mode
: TIM10-CCMR1_Output_OC1PE   %1 3 lshift TIM10-CCMR1_Output bis! ;  \ TIM10-CCMR1_Output_OC1PE    Output Compare 1 preload
  enable
: TIM10-CCMR1_Output_OC1FE   %1 2 lshift TIM10-CCMR1_Output bis! ;  \ TIM10-CCMR1_Output_OC1FE    Output Compare 1 fast
  enable
: TIM10-CCMR1_Output_CC1S   ( %XX -- ) 0 lshift TIM10-CCMR1_Output bis! ;  \ TIM10-CCMR1_Output_CC1S    Capture/Compare 1
  selection

\ TIM10-CCMR1_Input (read-write)
: TIM10-CCMR1_Input_IC1F   ( %XXXX -- ) 4 lshift TIM10-CCMR1_Input bis! ;  \ TIM10-CCMR1_Input_IC1F    Input capture 1 filter
: TIM10-CCMR1_Input_ICPCS   ( %XX -- ) 2 lshift TIM10-CCMR1_Input bis! ;  \ TIM10-CCMR1_Input_ICPCS    Input capture 1 prescaler
: TIM10-CCMR1_Input_CC1S   ( %XX -- ) 0 lshift TIM10-CCMR1_Input bis! ;  \ TIM10-CCMR1_Input_CC1S    Capture/Compare 1
  selection

\ TIM10-CCER (read-write)
: TIM10-CCER_CC1NP   %1 3 lshift TIM10-CCER bis! ;  \ TIM10-CCER_CC1NP    Capture/Compare 1 output
  Polarity
: TIM10-CCER_CC1P   %1 1 lshift TIM10-CCER bis! ;  \ TIM10-CCER_CC1P    Capture/Compare 1 output
  Polarity
: TIM10-CCER_CC1E   %1 0 lshift TIM10-CCER bis! ;  \ TIM10-CCER_CC1E    Capture/Compare 1 output
  enable

\ TIM10-CNT (read-write)
: TIM10-CNT_CNT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM10-CNT bis! ;  \ TIM10-CNT_CNT    counter value

\ TIM10-PSC (read-write)
: TIM10-PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM10-PSC bis! ;  \ TIM10-PSC_PSC    Prescaler value

\ TIM10-ARR (read-write)
: TIM10-ARR_ARR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM10-ARR bis! ;  \ TIM10-ARR_ARR    Auto-reload value

\ TIM10-CCR1 (read-write)
: TIM10-CCR1_CCR1   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM10-CCR1 bis! ;  \ TIM10-CCR1_CCR1    Capture/Compare 1 value

\ TIM11-CR1 (read-write)
: TIM11-CR1_CKD   ( %XX -- ) 8 lshift TIM11-CR1 bis! ;  \ TIM11-CR1_CKD    Clock division
: TIM11-CR1_ARPE   %1 7 lshift TIM11-CR1 bis! ;  \ TIM11-CR1_ARPE    Auto-reload preload enable
: TIM11-CR1_URS   %1 2 lshift TIM11-CR1 bis! ;  \ TIM11-CR1_URS    Update request source
: TIM11-CR1_UDIS   %1 1 lshift TIM11-CR1 bis! ;  \ TIM11-CR1_UDIS    Update disable
: TIM11-CR1_CEN   %1 0 lshift TIM11-CR1 bis! ;  \ TIM11-CR1_CEN    Counter enable

\ TIM11-DIER (read-write)
: TIM11-DIER_CC1IE   %1 1 lshift TIM11-DIER bis! ;  \ TIM11-DIER_CC1IE    Capture/Compare 1 interrupt
  enable
: TIM11-DIER_UIE   %1 0 lshift TIM11-DIER bis! ;  \ TIM11-DIER_UIE    Update interrupt enable

\ TIM11-SR (read-write)
: TIM11-SR_CC1OF   %1 9 lshift TIM11-SR bis! ;  \ TIM11-SR_CC1OF    Capture/Compare 1 overcapture
  flag
: TIM11-SR_CC1IF   %1 1 lshift TIM11-SR bis! ;  \ TIM11-SR_CC1IF    Capture/compare 1 interrupt
  flag
: TIM11-SR_UIF   %1 0 lshift TIM11-SR bis! ;  \ TIM11-SR_UIF    Update interrupt flag

\ TIM11-EGR (write-only)
: TIM11-EGR_CC1G   %1 1 lshift TIM11-EGR bis! ;  \ TIM11-EGR_CC1G    Capture/compare 1
  generation
: TIM11-EGR_UG   %1 0 lshift TIM11-EGR bis! ;  \ TIM11-EGR_UG    Update generation

\ TIM11-CCMR1_Output (read-write)
: TIM11-CCMR1_Output_OC1M   ( %XXX -- ) 4 lshift TIM11-CCMR1_Output bis! ;  \ TIM11-CCMR1_Output_OC1M    Output Compare 1 mode
: TIM11-CCMR1_Output_OC1PE   %1 3 lshift TIM11-CCMR1_Output bis! ;  \ TIM11-CCMR1_Output_OC1PE    Output Compare 1 preload
  enable
: TIM11-CCMR1_Output_OC1FE   %1 2 lshift TIM11-CCMR1_Output bis! ;  \ TIM11-CCMR1_Output_OC1FE    Output Compare 1 fast
  enable
: TIM11-CCMR1_Output_CC1S   ( %XX -- ) 0 lshift TIM11-CCMR1_Output bis! ;  \ TIM11-CCMR1_Output_CC1S    Capture/Compare 1
  selection

\ TIM11-CCMR1_Input (read-write)
: TIM11-CCMR1_Input_IC1F   ( %XXXX -- ) 4 lshift TIM11-CCMR1_Input bis! ;  \ TIM11-CCMR1_Input_IC1F    Input capture 1 filter
: TIM11-CCMR1_Input_ICPCS   ( %XX -- ) 2 lshift TIM11-CCMR1_Input bis! ;  \ TIM11-CCMR1_Input_ICPCS    Input capture 1 prescaler
: TIM11-CCMR1_Input_CC1S   ( %XX -- ) 0 lshift TIM11-CCMR1_Input bis! ;  \ TIM11-CCMR1_Input_CC1S    Capture/Compare 1
  selection

\ TIM11-CCER (read-write)
: TIM11-CCER_CC1NP   %1 3 lshift TIM11-CCER bis! ;  \ TIM11-CCER_CC1NP    Capture/Compare 1 output
  Polarity
: TIM11-CCER_CC1P   %1 1 lshift TIM11-CCER bis! ;  \ TIM11-CCER_CC1P    Capture/Compare 1 output
  Polarity
: TIM11-CCER_CC1E   %1 0 lshift TIM11-CCER bis! ;  \ TIM11-CCER_CC1E    Capture/Compare 1 output
  enable

\ TIM11-CNT (read-write)
: TIM11-CNT_CNT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM11-CNT bis! ;  \ TIM11-CNT_CNT    counter value

\ TIM11-PSC (read-write)
: TIM11-PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM11-PSC bis! ;  \ TIM11-PSC_PSC    Prescaler value

\ TIM11-ARR (read-write)
: TIM11-ARR_ARR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM11-ARR bis! ;  \ TIM11-ARR_ARR    Auto-reload value

\ TIM11-CCR1 (read-write)
: TIM11-CCR1_CCR1   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM11-CCR1 bis! ;  \ TIM11-CCR1_CCR1    Capture/Compare 1 value

\ TIM11-OR (read-write)
: TIM11-OR_RMP   ( %XX -- ) 0 lshift TIM11-OR bis! ;  \ TIM11-OR_RMP    Input 1 remapping
  capability

\ TIM2-CR1 (read-write)
: TIM2-CR1_CKD   ( %XX -- ) 8 lshift TIM2-CR1 bis! ;  \ TIM2-CR1_CKD    Clock division
: TIM2-CR1_ARPE   %1 7 lshift TIM2-CR1 bis! ;  \ TIM2-CR1_ARPE    Auto-reload preload enable
: TIM2-CR1_CMS   ( %XX -- ) 5 lshift TIM2-CR1 bis! ;  \ TIM2-CR1_CMS    Center-aligned mode
  selection
: TIM2-CR1_DIR   %1 4 lshift TIM2-CR1 bis! ;  \ TIM2-CR1_DIR    Direction
: TIM2-CR1_OPM   %1 3 lshift TIM2-CR1 bis! ;  \ TIM2-CR1_OPM    One-pulse mode
: TIM2-CR1_URS   %1 2 lshift TIM2-CR1 bis! ;  \ TIM2-CR1_URS    Update request source
: TIM2-CR1_UDIS   %1 1 lshift TIM2-CR1 bis! ;  \ TIM2-CR1_UDIS    Update disable
: TIM2-CR1_CEN   %1 0 lshift TIM2-CR1 bis! ;  \ TIM2-CR1_CEN    Counter enable

\ TIM2-CR2 (read-write)
: TIM2-CR2_TI1S   %1 7 lshift TIM2-CR2 bis! ;  \ TIM2-CR2_TI1S    TI1 selection
: TIM2-CR2_MMS   ( %XXX -- ) 4 lshift TIM2-CR2 bis! ;  \ TIM2-CR2_MMS    Master mode selection
: TIM2-CR2_CCDS   %1 3 lshift TIM2-CR2 bis! ;  \ TIM2-CR2_CCDS    Capture/compare DMA
  selection

\ TIM2-SMCR (read-write)
: TIM2-SMCR_ETP   %1 15 lshift TIM2-SMCR bis! ;  \ TIM2-SMCR_ETP    External trigger polarity
: TIM2-SMCR_ECE   %1 14 lshift TIM2-SMCR bis! ;  \ TIM2-SMCR_ECE    External clock enable
: TIM2-SMCR_ETPS   ( %XX -- ) 12 lshift TIM2-SMCR bis! ;  \ TIM2-SMCR_ETPS    External trigger prescaler
: TIM2-SMCR_ETF   ( %XXXX -- ) 8 lshift TIM2-SMCR bis! ;  \ TIM2-SMCR_ETF    External trigger filter
: TIM2-SMCR_MSM   %1 7 lshift TIM2-SMCR bis! ;  \ TIM2-SMCR_MSM    Master/Slave mode
: TIM2-SMCR_TS   ( %XXX -- ) 4 lshift TIM2-SMCR bis! ;  \ TIM2-SMCR_TS    Trigger selection
: TIM2-SMCR_SMS   ( %XXX -- ) 0 lshift TIM2-SMCR bis! ;  \ TIM2-SMCR_SMS    Slave mode selection

\ TIM2-DIER (read-write)
: TIM2-DIER_TDE   %1 14 lshift TIM2-DIER bis! ;  \ TIM2-DIER_TDE    Trigger DMA request enable
: TIM2-DIER_CC4DE   %1 12 lshift TIM2-DIER bis! ;  \ TIM2-DIER_CC4DE    Capture/Compare 4 DMA request
  enable
: TIM2-DIER_CC3DE   %1 11 lshift TIM2-DIER bis! ;  \ TIM2-DIER_CC3DE    Capture/Compare 3 DMA request
  enable
: TIM2-DIER_CC2DE   %1 10 lshift TIM2-DIER bis! ;  \ TIM2-DIER_CC2DE    Capture/Compare 2 DMA request
  enable
: TIM2-DIER_CC1DE   %1 9 lshift TIM2-DIER bis! ;  \ TIM2-DIER_CC1DE    Capture/Compare 1 DMA request
  enable
: TIM2-DIER_UDE   %1 8 lshift TIM2-DIER bis! ;  \ TIM2-DIER_UDE    Update DMA request enable
: TIM2-DIER_TIE   %1 6 lshift TIM2-DIER bis! ;  \ TIM2-DIER_TIE    Trigger interrupt enable
: TIM2-DIER_CC4IE   %1 4 lshift TIM2-DIER bis! ;  \ TIM2-DIER_CC4IE    Capture/Compare 4 interrupt
  enable
: TIM2-DIER_CC3IE   %1 3 lshift TIM2-DIER bis! ;  \ TIM2-DIER_CC3IE    Capture/Compare 3 interrupt
  enable
: TIM2-DIER_CC2IE   %1 2 lshift TIM2-DIER bis! ;  \ TIM2-DIER_CC2IE    Capture/Compare 2 interrupt
  enable
: TIM2-DIER_CC1IE   %1 1 lshift TIM2-DIER bis! ;  \ TIM2-DIER_CC1IE    Capture/Compare 1 interrupt
  enable
: TIM2-DIER_UIE   %1 0 lshift TIM2-DIER bis! ;  \ TIM2-DIER_UIE    Update interrupt enable

\ TIM2-SR (read-write)
: TIM2-SR_CC4OF   %1 12 lshift TIM2-SR bis! ;  \ TIM2-SR_CC4OF    Capture/Compare 4 overcapture
  flag
: TIM2-SR_CC3OF   %1 11 lshift TIM2-SR bis! ;  \ TIM2-SR_CC3OF    Capture/Compare 3 overcapture
  flag
: TIM2-SR_CC2OF   %1 10 lshift TIM2-SR bis! ;  \ TIM2-SR_CC2OF    Capture/compare 2 overcapture
  flag
: TIM2-SR_CC1OF   %1 9 lshift TIM2-SR bis! ;  \ TIM2-SR_CC1OF    Capture/Compare 1 overcapture
  flag
: TIM2-SR_TIF   %1 6 lshift TIM2-SR bis! ;  \ TIM2-SR_TIF    Trigger interrupt flag
: TIM2-SR_CC4IF   %1 4 lshift TIM2-SR bis! ;  \ TIM2-SR_CC4IF    Capture/Compare 4 interrupt
  flag
: TIM2-SR_CC3IF   %1 3 lshift TIM2-SR bis! ;  \ TIM2-SR_CC3IF    Capture/Compare 3 interrupt
  flag
: TIM2-SR_CC2IF   %1 2 lshift TIM2-SR bis! ;  \ TIM2-SR_CC2IF    Capture/Compare 2 interrupt
  flag
: TIM2-SR_CC1IF   %1 1 lshift TIM2-SR bis! ;  \ TIM2-SR_CC1IF    Capture/compare 1 interrupt
  flag
: TIM2-SR_UIF   %1 0 lshift TIM2-SR bis! ;  \ TIM2-SR_UIF    Update interrupt flag

\ TIM2-EGR (write-only)
: TIM2-EGR_TG   %1 6 lshift TIM2-EGR bis! ;  \ TIM2-EGR_TG    Trigger generation
: TIM2-EGR_CC4G   %1 4 lshift TIM2-EGR bis! ;  \ TIM2-EGR_CC4G    Capture/compare 4
  generation
: TIM2-EGR_CC3G   %1 3 lshift TIM2-EGR bis! ;  \ TIM2-EGR_CC3G    Capture/compare 3
  generation
: TIM2-EGR_CC2G   %1 2 lshift TIM2-EGR bis! ;  \ TIM2-EGR_CC2G    Capture/compare 2
  generation
: TIM2-EGR_CC1G   %1 1 lshift TIM2-EGR bis! ;  \ TIM2-EGR_CC1G    Capture/compare 1
  generation
: TIM2-EGR_UG   %1 0 lshift TIM2-EGR bis! ;  \ TIM2-EGR_UG    Update generation

\ TIM2-CCMR1_Output (read-write)
: TIM2-CCMR1_Output_OC2CE   %1 15 lshift TIM2-CCMR1_Output bis! ;  \ TIM2-CCMR1_Output_OC2CE    OC2CE
: TIM2-CCMR1_Output_OC2M   ( %XXX -- ) 12 lshift TIM2-CCMR1_Output bis! ;  \ TIM2-CCMR1_Output_OC2M    OC2M
: TIM2-CCMR1_Output_OC2PE   %1 11 lshift TIM2-CCMR1_Output bis! ;  \ TIM2-CCMR1_Output_OC2PE    OC2PE
: TIM2-CCMR1_Output_OC2FE   %1 10 lshift TIM2-CCMR1_Output bis! ;  \ TIM2-CCMR1_Output_OC2FE    OC2FE
: TIM2-CCMR1_Output_CC2S   ( %XX -- ) 8 lshift TIM2-CCMR1_Output bis! ;  \ TIM2-CCMR1_Output_CC2S    CC2S
: TIM2-CCMR1_Output_OC1CE   %1 7 lshift TIM2-CCMR1_Output bis! ;  \ TIM2-CCMR1_Output_OC1CE    OC1CE
: TIM2-CCMR1_Output_OC1M   ( %XXX -- ) 4 lshift TIM2-CCMR1_Output bis! ;  \ TIM2-CCMR1_Output_OC1M    OC1M
: TIM2-CCMR1_Output_OC1PE   %1 3 lshift TIM2-CCMR1_Output bis! ;  \ TIM2-CCMR1_Output_OC1PE    OC1PE
: TIM2-CCMR1_Output_OC1FE   %1 2 lshift TIM2-CCMR1_Output bis! ;  \ TIM2-CCMR1_Output_OC1FE    OC1FE
: TIM2-CCMR1_Output_CC1S   ( %XX -- ) 0 lshift TIM2-CCMR1_Output bis! ;  \ TIM2-CCMR1_Output_CC1S    CC1S

\ TIM2-CCMR1_Input (read-write)
: TIM2-CCMR1_Input_IC2F   ( %XXXX -- ) 12 lshift TIM2-CCMR1_Input bis! ;  \ TIM2-CCMR1_Input_IC2F    Input capture 2 filter
: TIM2-CCMR1_Input_IC2PCS   ( %XX -- ) 10 lshift TIM2-CCMR1_Input bis! ;  \ TIM2-CCMR1_Input_IC2PCS    Input capture 2 prescaler
: TIM2-CCMR1_Input_CC2S   ( %XX -- ) 8 lshift TIM2-CCMR1_Input bis! ;  \ TIM2-CCMR1_Input_CC2S    Capture/Compare 2
  selection
: TIM2-CCMR1_Input_IC1F   ( %XXXX -- ) 4 lshift TIM2-CCMR1_Input bis! ;  \ TIM2-CCMR1_Input_IC1F    Input capture 1 filter
: TIM2-CCMR1_Input_ICPCS   ( %XX -- ) 2 lshift TIM2-CCMR1_Input bis! ;  \ TIM2-CCMR1_Input_ICPCS    Input capture 1 prescaler
: TIM2-CCMR1_Input_CC1S   ( %XX -- ) 0 lshift TIM2-CCMR1_Input bis! ;  \ TIM2-CCMR1_Input_CC1S    Capture/Compare 1
  selection

\ TIM2-CCMR2_Output (read-write)
: TIM2-CCMR2_Output_O24CE   %1 15 lshift TIM2-CCMR2_Output bis! ;  \ TIM2-CCMR2_Output_O24CE    O24CE
: TIM2-CCMR2_Output_OC4M   ( %XXX -- ) 12 lshift TIM2-CCMR2_Output bis! ;  \ TIM2-CCMR2_Output_OC4M    OC4M
: TIM2-CCMR2_Output_OC4PE   %1 11 lshift TIM2-CCMR2_Output bis! ;  \ TIM2-CCMR2_Output_OC4PE    OC4PE
: TIM2-CCMR2_Output_OC4FE   %1 10 lshift TIM2-CCMR2_Output bis! ;  \ TIM2-CCMR2_Output_OC4FE    OC4FE
: TIM2-CCMR2_Output_CC4S   ( %XX -- ) 8 lshift TIM2-CCMR2_Output bis! ;  \ TIM2-CCMR2_Output_CC4S    CC4S
: TIM2-CCMR2_Output_OC3CE   %1 7 lshift TIM2-CCMR2_Output bis! ;  \ TIM2-CCMR2_Output_OC3CE    OC3CE
: TIM2-CCMR2_Output_OC3M   ( %XXX -- ) 4 lshift TIM2-CCMR2_Output bis! ;  \ TIM2-CCMR2_Output_OC3M    OC3M
: TIM2-CCMR2_Output_OC3PE   %1 3 lshift TIM2-CCMR2_Output bis! ;  \ TIM2-CCMR2_Output_OC3PE    OC3PE
: TIM2-CCMR2_Output_OC3FE   %1 2 lshift TIM2-CCMR2_Output bis! ;  \ TIM2-CCMR2_Output_OC3FE    OC3FE
: TIM2-CCMR2_Output_CC3S   ( %XX -- ) 0 lshift TIM2-CCMR2_Output bis! ;  \ TIM2-CCMR2_Output_CC3S    CC3S

\ TIM2-CCMR2_Input (read-write)
: TIM2-CCMR2_Input_IC4F   ( %XXXX -- ) 12 lshift TIM2-CCMR2_Input bis! ;  \ TIM2-CCMR2_Input_IC4F    Input capture 4 filter
: TIM2-CCMR2_Input_IC4PSC   ( %XX -- ) 10 lshift TIM2-CCMR2_Input bis! ;  \ TIM2-CCMR2_Input_IC4PSC    Input capture 4 prescaler
: TIM2-CCMR2_Input_CC4S   ( %XX -- ) 8 lshift TIM2-CCMR2_Input bis! ;  \ TIM2-CCMR2_Input_CC4S    Capture/Compare 4
  selection
: TIM2-CCMR2_Input_IC3F   ( %XXXX -- ) 4 lshift TIM2-CCMR2_Input bis! ;  \ TIM2-CCMR2_Input_IC3F    Input capture 3 filter
: TIM2-CCMR2_Input_IC3PSC   ( %XX -- ) 2 lshift TIM2-CCMR2_Input bis! ;  \ TIM2-CCMR2_Input_IC3PSC    Input capture 3 prescaler
: TIM2-CCMR2_Input_CC3S   ( %XX -- ) 0 lshift TIM2-CCMR2_Input bis! ;  \ TIM2-CCMR2_Input_CC3S    Capture/compare 3
  selection

\ TIM2-CCER (read-write)
: TIM2-CCER_CC4NP   %1 15 lshift TIM2-CCER bis! ;  \ TIM2-CCER_CC4NP    Capture/Compare 4 output
  Polarity
: TIM2-CCER_CC4P   %1 13 lshift TIM2-CCER bis! ;  \ TIM2-CCER_CC4P    Capture/Compare 3 output
  Polarity
: TIM2-CCER_CC4E   %1 12 lshift TIM2-CCER bis! ;  \ TIM2-CCER_CC4E    Capture/Compare 4 output
  enable
: TIM2-CCER_CC3NP   %1 11 lshift TIM2-CCER bis! ;  \ TIM2-CCER_CC3NP    Capture/Compare 3 output
  Polarity
: TIM2-CCER_CC3P   %1 9 lshift TIM2-CCER bis! ;  \ TIM2-CCER_CC3P    Capture/Compare 3 output
  Polarity
: TIM2-CCER_CC3E   %1 8 lshift TIM2-CCER bis! ;  \ TIM2-CCER_CC3E    Capture/Compare 3 output
  enable
: TIM2-CCER_CC2NP   %1 7 lshift TIM2-CCER bis! ;  \ TIM2-CCER_CC2NP    Capture/Compare 2 output
  Polarity
: TIM2-CCER_CC2P   %1 5 lshift TIM2-CCER bis! ;  \ TIM2-CCER_CC2P    Capture/Compare 2 output
  Polarity
: TIM2-CCER_CC2E   %1 4 lshift TIM2-CCER bis! ;  \ TIM2-CCER_CC2E    Capture/Compare 2 output
  enable
: TIM2-CCER_CC1NP   %1 3 lshift TIM2-CCER bis! ;  \ TIM2-CCER_CC1NP    Capture/Compare 1 output
  Polarity
: TIM2-CCER_CC1P   %1 1 lshift TIM2-CCER bis! ;  \ TIM2-CCER_CC1P    Capture/Compare 1 output
  Polarity
: TIM2-CCER_CC1E   %1 0 lshift TIM2-CCER bis! ;  \ TIM2-CCER_CC1E    Capture/Compare 1 output
  enable

\ TIM2-CNT (read-write)
: TIM2-CNT_CNT_H   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift TIM2-CNT bis! ;  \ TIM2-CNT_CNT_H    High counter value
: TIM2-CNT_CNT_L   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM2-CNT bis! ;  \ TIM2-CNT_CNT_L    Low counter value

\ TIM2-PSC (read-write)
: TIM2-PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM2-PSC bis! ;  \ TIM2-PSC_PSC    Prescaler value

\ TIM2-ARR (read-write)
: TIM2-ARR_ARR_H   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift TIM2-ARR bis! ;  \ TIM2-ARR_ARR_H    High Auto-reload value
: TIM2-ARR_ARR_L   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM2-ARR bis! ;  \ TIM2-ARR_ARR_L    Low Auto-reload value

\ TIM2-CCR1 (read-write)
: TIM2-CCR1_CCR1_H   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift TIM2-CCR1 bis! ;  \ TIM2-CCR1_CCR1_H    High Capture/Compare 1
  value
: TIM2-CCR1_CCR1_L   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM2-CCR1 bis! ;  \ TIM2-CCR1_CCR1_L    Low Capture/Compare 1
  value

\ TIM2-CCR2 (read-write)
: TIM2-CCR2_CCR2_H   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift TIM2-CCR2 bis! ;  \ TIM2-CCR2_CCR2_H    High Capture/Compare 2
  value
: TIM2-CCR2_CCR2_L   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM2-CCR2 bis! ;  \ TIM2-CCR2_CCR2_L    Low Capture/Compare 2
  value

\ TIM2-CCR3 (read-write)
: TIM2-CCR3_CCR3_H   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift TIM2-CCR3 bis! ;  \ TIM2-CCR3_CCR3_H    High Capture/Compare value
: TIM2-CCR3_CCR3_L   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM2-CCR3 bis! ;  \ TIM2-CCR3_CCR3_L    Low Capture/Compare value

\ TIM2-CCR4 (read-write)
: TIM2-CCR4_CCR4_H   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift TIM2-CCR4 bis! ;  \ TIM2-CCR4_CCR4_H    High Capture/Compare value
: TIM2-CCR4_CCR4_L   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM2-CCR4 bis! ;  \ TIM2-CCR4_CCR4_L    Low Capture/Compare value

\ TIM2-DCR (read-write)
: TIM2-DCR_DBL   ( %XXXXX -- ) 8 lshift TIM2-DCR bis! ;  \ TIM2-DCR_DBL    DMA burst length
: TIM2-DCR_DBA   ( %XXXXX -- ) 0 lshift TIM2-DCR bis! ;  \ TIM2-DCR_DBA    DMA base address

\ TIM2-DMAR (read-write)
: TIM2-DMAR_DMAB   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM2-DMAR bis! ;  \ TIM2-DMAR_DMAB    DMA register for burst
  accesses

\ TIM2-OR (read-write)
: TIM2-OR_ITR1_RMP   ( %XX -- ) 10 lshift TIM2-OR bis! ;  \ TIM2-OR_ITR1_RMP    Timer Input 4 remap

\ TIM3-CR1 (read-write)
: TIM3-CR1_CKD   ( %XX -- ) 8 lshift TIM3-CR1 bis! ;  \ TIM3-CR1_CKD    Clock division
: TIM3-CR1_ARPE   %1 7 lshift TIM3-CR1 bis! ;  \ TIM3-CR1_ARPE    Auto-reload preload enable
: TIM3-CR1_CMS   ( %XX -- ) 5 lshift TIM3-CR1 bis! ;  \ TIM3-CR1_CMS    Center-aligned mode
  selection
: TIM3-CR1_DIR   %1 4 lshift TIM3-CR1 bis! ;  \ TIM3-CR1_DIR    Direction
: TIM3-CR1_OPM   %1 3 lshift TIM3-CR1 bis! ;  \ TIM3-CR1_OPM    One-pulse mode
: TIM3-CR1_URS   %1 2 lshift TIM3-CR1 bis! ;  \ TIM3-CR1_URS    Update request source
: TIM3-CR1_UDIS   %1 1 lshift TIM3-CR1 bis! ;  \ TIM3-CR1_UDIS    Update disable
: TIM3-CR1_CEN   %1 0 lshift TIM3-CR1 bis! ;  \ TIM3-CR1_CEN    Counter enable

\ TIM3-CR2 (read-write)
: TIM3-CR2_TI1S   %1 7 lshift TIM3-CR2 bis! ;  \ TIM3-CR2_TI1S    TI1 selection
: TIM3-CR2_MMS   ( %XXX -- ) 4 lshift TIM3-CR2 bis! ;  \ TIM3-CR2_MMS    Master mode selection
: TIM3-CR2_CCDS   %1 3 lshift TIM3-CR2 bis! ;  \ TIM3-CR2_CCDS    Capture/compare DMA
  selection

\ TIM3-SMCR (read-write)
: TIM3-SMCR_ETP   %1 15 lshift TIM3-SMCR bis! ;  \ TIM3-SMCR_ETP    External trigger polarity
: TIM3-SMCR_ECE   %1 14 lshift TIM3-SMCR bis! ;  \ TIM3-SMCR_ECE    External clock enable
: TIM3-SMCR_ETPS   ( %XX -- ) 12 lshift TIM3-SMCR bis! ;  \ TIM3-SMCR_ETPS    External trigger prescaler
: TIM3-SMCR_ETF   ( %XXXX -- ) 8 lshift TIM3-SMCR bis! ;  \ TIM3-SMCR_ETF    External trigger filter
: TIM3-SMCR_MSM   %1 7 lshift TIM3-SMCR bis! ;  \ TIM3-SMCR_MSM    Master/Slave mode
: TIM3-SMCR_TS   ( %XXX -- ) 4 lshift TIM3-SMCR bis! ;  \ TIM3-SMCR_TS    Trigger selection
: TIM3-SMCR_SMS   ( %XXX -- ) 0 lshift TIM3-SMCR bis! ;  \ TIM3-SMCR_SMS    Slave mode selection

\ TIM3-DIER (read-write)
: TIM3-DIER_TDE   %1 14 lshift TIM3-DIER bis! ;  \ TIM3-DIER_TDE    Trigger DMA request enable
: TIM3-DIER_CC4DE   %1 12 lshift TIM3-DIER bis! ;  \ TIM3-DIER_CC4DE    Capture/Compare 4 DMA request
  enable
: TIM3-DIER_CC3DE   %1 11 lshift TIM3-DIER bis! ;  \ TIM3-DIER_CC3DE    Capture/Compare 3 DMA request
  enable
: TIM3-DIER_CC2DE   %1 10 lshift TIM3-DIER bis! ;  \ TIM3-DIER_CC2DE    Capture/Compare 2 DMA request
  enable
: TIM3-DIER_CC1DE   %1 9 lshift TIM3-DIER bis! ;  \ TIM3-DIER_CC1DE    Capture/Compare 1 DMA request
  enable
: TIM3-DIER_UDE   %1 8 lshift TIM3-DIER bis! ;  \ TIM3-DIER_UDE    Update DMA request enable
: TIM3-DIER_TIE   %1 6 lshift TIM3-DIER bis! ;  \ TIM3-DIER_TIE    Trigger interrupt enable
: TIM3-DIER_CC4IE   %1 4 lshift TIM3-DIER bis! ;  \ TIM3-DIER_CC4IE    Capture/Compare 4 interrupt
  enable
: TIM3-DIER_CC3IE   %1 3 lshift TIM3-DIER bis! ;  \ TIM3-DIER_CC3IE    Capture/Compare 3 interrupt
  enable
: TIM3-DIER_CC2IE   %1 2 lshift TIM3-DIER bis! ;  \ TIM3-DIER_CC2IE    Capture/Compare 2 interrupt
  enable
: TIM3-DIER_CC1IE   %1 1 lshift TIM3-DIER bis! ;  \ TIM3-DIER_CC1IE    Capture/Compare 1 interrupt
  enable
: TIM3-DIER_UIE   %1 0 lshift TIM3-DIER bis! ;  \ TIM3-DIER_UIE    Update interrupt enable

\ TIM3-SR (read-write)
: TIM3-SR_CC4OF   %1 12 lshift TIM3-SR bis! ;  \ TIM3-SR_CC4OF    Capture/Compare 4 overcapture
  flag
: TIM3-SR_CC3OF   %1 11 lshift TIM3-SR bis! ;  \ TIM3-SR_CC3OF    Capture/Compare 3 overcapture
  flag
: TIM3-SR_CC2OF   %1 10 lshift TIM3-SR bis! ;  \ TIM3-SR_CC2OF    Capture/compare 2 overcapture
  flag
: TIM3-SR_CC1OF   %1 9 lshift TIM3-SR bis! ;  \ TIM3-SR_CC1OF    Capture/Compare 1 overcapture
  flag
: TIM3-SR_TIF   %1 6 lshift TIM3-SR bis! ;  \ TIM3-SR_TIF    Trigger interrupt flag
: TIM3-SR_CC4IF   %1 4 lshift TIM3-SR bis! ;  \ TIM3-SR_CC4IF    Capture/Compare 4 interrupt
  flag
: TIM3-SR_CC3IF   %1 3 lshift TIM3-SR bis! ;  \ TIM3-SR_CC3IF    Capture/Compare 3 interrupt
  flag
: TIM3-SR_CC2IF   %1 2 lshift TIM3-SR bis! ;  \ TIM3-SR_CC2IF    Capture/Compare 2 interrupt
  flag
: TIM3-SR_CC1IF   %1 1 lshift TIM3-SR bis! ;  \ TIM3-SR_CC1IF    Capture/compare 1 interrupt
  flag
: TIM3-SR_UIF   %1 0 lshift TIM3-SR bis! ;  \ TIM3-SR_UIF    Update interrupt flag

\ TIM3-EGR (write-only)
: TIM3-EGR_TG   %1 6 lshift TIM3-EGR bis! ;  \ TIM3-EGR_TG    Trigger generation
: TIM3-EGR_CC4G   %1 4 lshift TIM3-EGR bis! ;  \ TIM3-EGR_CC4G    Capture/compare 4
  generation
: TIM3-EGR_CC3G   %1 3 lshift TIM3-EGR bis! ;  \ TIM3-EGR_CC3G    Capture/compare 3
  generation
: TIM3-EGR_CC2G   %1 2 lshift TIM3-EGR bis! ;  \ TIM3-EGR_CC2G    Capture/compare 2
  generation
: TIM3-EGR_CC1G   %1 1 lshift TIM3-EGR bis! ;  \ TIM3-EGR_CC1G    Capture/compare 1
  generation
: TIM3-EGR_UG   %1 0 lshift TIM3-EGR bis! ;  \ TIM3-EGR_UG    Update generation

\ TIM3-CCMR1_Output (read-write)
: TIM3-CCMR1_Output_OC2CE   %1 15 lshift TIM3-CCMR1_Output bis! ;  \ TIM3-CCMR1_Output_OC2CE    OC2CE
: TIM3-CCMR1_Output_OC2M   ( %XXX -- ) 12 lshift TIM3-CCMR1_Output bis! ;  \ TIM3-CCMR1_Output_OC2M    OC2M
: TIM3-CCMR1_Output_OC2PE   %1 11 lshift TIM3-CCMR1_Output bis! ;  \ TIM3-CCMR1_Output_OC2PE    OC2PE
: TIM3-CCMR1_Output_OC2FE   %1 10 lshift TIM3-CCMR1_Output bis! ;  \ TIM3-CCMR1_Output_OC2FE    OC2FE
: TIM3-CCMR1_Output_CC2S   ( %XX -- ) 8 lshift TIM3-CCMR1_Output bis! ;  \ TIM3-CCMR1_Output_CC2S    CC2S
: TIM3-CCMR1_Output_OC1CE   %1 7 lshift TIM3-CCMR1_Output bis! ;  \ TIM3-CCMR1_Output_OC1CE    OC1CE
: TIM3-CCMR1_Output_OC1M   ( %XXX -- ) 4 lshift TIM3-CCMR1_Output bis! ;  \ TIM3-CCMR1_Output_OC1M    OC1M
: TIM3-CCMR1_Output_OC1PE   %1 3 lshift TIM3-CCMR1_Output bis! ;  \ TIM3-CCMR1_Output_OC1PE    OC1PE
: TIM3-CCMR1_Output_OC1FE   %1 2 lshift TIM3-CCMR1_Output bis! ;  \ TIM3-CCMR1_Output_OC1FE    OC1FE
: TIM3-CCMR1_Output_CC1S   ( %XX -- ) 0 lshift TIM3-CCMR1_Output bis! ;  \ TIM3-CCMR1_Output_CC1S    CC1S

\ TIM3-CCMR1_Input (read-write)
: TIM3-CCMR1_Input_IC2F   ( %XXXX -- ) 12 lshift TIM3-CCMR1_Input bis! ;  \ TIM3-CCMR1_Input_IC2F    Input capture 2 filter
: TIM3-CCMR1_Input_IC2PCS   ( %XX -- ) 10 lshift TIM3-CCMR1_Input bis! ;  \ TIM3-CCMR1_Input_IC2PCS    Input capture 2 prescaler
: TIM3-CCMR1_Input_CC2S   ( %XX -- ) 8 lshift TIM3-CCMR1_Input bis! ;  \ TIM3-CCMR1_Input_CC2S    Capture/Compare 2
  selection
: TIM3-CCMR1_Input_IC1F   ( %XXXX -- ) 4 lshift TIM3-CCMR1_Input bis! ;  \ TIM3-CCMR1_Input_IC1F    Input capture 1 filter
: TIM3-CCMR1_Input_ICPCS   ( %XX -- ) 2 lshift TIM3-CCMR1_Input bis! ;  \ TIM3-CCMR1_Input_ICPCS    Input capture 1 prescaler
: TIM3-CCMR1_Input_CC1S   ( %XX -- ) 0 lshift TIM3-CCMR1_Input bis! ;  \ TIM3-CCMR1_Input_CC1S    Capture/Compare 1
  selection

\ TIM3-CCMR2_Output (read-write)
: TIM3-CCMR2_Output_O24CE   %1 15 lshift TIM3-CCMR2_Output bis! ;  \ TIM3-CCMR2_Output_O24CE    O24CE
: TIM3-CCMR2_Output_OC4M   ( %XXX -- ) 12 lshift TIM3-CCMR2_Output bis! ;  \ TIM3-CCMR2_Output_OC4M    OC4M
: TIM3-CCMR2_Output_OC4PE   %1 11 lshift TIM3-CCMR2_Output bis! ;  \ TIM3-CCMR2_Output_OC4PE    OC4PE
: TIM3-CCMR2_Output_OC4FE   %1 10 lshift TIM3-CCMR2_Output bis! ;  \ TIM3-CCMR2_Output_OC4FE    OC4FE
: TIM3-CCMR2_Output_CC4S   ( %XX -- ) 8 lshift TIM3-CCMR2_Output bis! ;  \ TIM3-CCMR2_Output_CC4S    CC4S
: TIM3-CCMR2_Output_OC3CE   %1 7 lshift TIM3-CCMR2_Output bis! ;  \ TIM3-CCMR2_Output_OC3CE    OC3CE
: TIM3-CCMR2_Output_OC3M   ( %XXX -- ) 4 lshift TIM3-CCMR2_Output bis! ;  \ TIM3-CCMR2_Output_OC3M    OC3M
: TIM3-CCMR2_Output_OC3PE   %1 3 lshift TIM3-CCMR2_Output bis! ;  \ TIM3-CCMR2_Output_OC3PE    OC3PE
: TIM3-CCMR2_Output_OC3FE   %1 2 lshift TIM3-CCMR2_Output bis! ;  \ TIM3-CCMR2_Output_OC3FE    OC3FE
: TIM3-CCMR2_Output_CC3S   ( %XX -- ) 0 lshift TIM3-CCMR2_Output bis! ;  \ TIM3-CCMR2_Output_CC3S    CC3S

\ TIM3-CCMR2_Input (read-write)
: TIM3-CCMR2_Input_IC4F   ( %XXXX -- ) 12 lshift TIM3-CCMR2_Input bis! ;  \ TIM3-CCMR2_Input_IC4F    Input capture 4 filter
: TIM3-CCMR2_Input_IC4PSC   ( %XX -- ) 10 lshift TIM3-CCMR2_Input bis! ;  \ TIM3-CCMR2_Input_IC4PSC    Input capture 4 prescaler
: TIM3-CCMR2_Input_CC4S   ( %XX -- ) 8 lshift TIM3-CCMR2_Input bis! ;  \ TIM3-CCMR2_Input_CC4S    Capture/Compare 4
  selection
: TIM3-CCMR2_Input_IC3F   ( %XXXX -- ) 4 lshift TIM3-CCMR2_Input bis! ;  \ TIM3-CCMR2_Input_IC3F    Input capture 3 filter
: TIM3-CCMR2_Input_IC3PSC   ( %XX -- ) 2 lshift TIM3-CCMR2_Input bis! ;  \ TIM3-CCMR2_Input_IC3PSC    Input capture 3 prescaler
: TIM3-CCMR2_Input_CC3S   ( %XX -- ) 0 lshift TIM3-CCMR2_Input bis! ;  \ TIM3-CCMR2_Input_CC3S    Capture/compare 3
  selection

\ TIM3-CCER (read-write)
: TIM3-CCER_CC4NP   %1 15 lshift TIM3-CCER bis! ;  \ TIM3-CCER_CC4NP    Capture/Compare 4 output
  Polarity
: TIM3-CCER_CC4P   %1 13 lshift TIM3-CCER bis! ;  \ TIM3-CCER_CC4P    Capture/Compare 3 output
  Polarity
: TIM3-CCER_CC4E   %1 12 lshift TIM3-CCER bis! ;  \ TIM3-CCER_CC4E    Capture/Compare 4 output
  enable
: TIM3-CCER_CC3NP   %1 11 lshift TIM3-CCER bis! ;  \ TIM3-CCER_CC3NP    Capture/Compare 3 output
  Polarity
: TIM3-CCER_CC3P   %1 9 lshift TIM3-CCER bis! ;  \ TIM3-CCER_CC3P    Capture/Compare 3 output
  Polarity
: TIM3-CCER_CC3E   %1 8 lshift TIM3-CCER bis! ;  \ TIM3-CCER_CC3E    Capture/Compare 3 output
  enable
: TIM3-CCER_CC2NP   %1 7 lshift TIM3-CCER bis! ;  \ TIM3-CCER_CC2NP    Capture/Compare 2 output
  Polarity
: TIM3-CCER_CC2P   %1 5 lshift TIM3-CCER bis! ;  \ TIM3-CCER_CC2P    Capture/Compare 2 output
  Polarity
: TIM3-CCER_CC2E   %1 4 lshift TIM3-CCER bis! ;  \ TIM3-CCER_CC2E    Capture/Compare 2 output
  enable
: TIM3-CCER_CC1NP   %1 3 lshift TIM3-CCER bis! ;  \ TIM3-CCER_CC1NP    Capture/Compare 1 output
  Polarity
: TIM3-CCER_CC1P   %1 1 lshift TIM3-CCER bis! ;  \ TIM3-CCER_CC1P    Capture/Compare 1 output
  Polarity
: TIM3-CCER_CC1E   %1 0 lshift TIM3-CCER bis! ;  \ TIM3-CCER_CC1E    Capture/Compare 1 output
  enable

\ TIM3-CNT (read-write)
: TIM3-CNT_CNT_H   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift TIM3-CNT bis! ;  \ TIM3-CNT_CNT_H    High counter value
: TIM3-CNT_CNT_L   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM3-CNT bis! ;  \ TIM3-CNT_CNT_L    Low counter value

\ TIM3-PSC (read-write)
: TIM3-PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM3-PSC bis! ;  \ TIM3-PSC_PSC    Prescaler value

\ TIM3-ARR (read-write)
: TIM3-ARR_ARR_H   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift TIM3-ARR bis! ;  \ TIM3-ARR_ARR_H    High Auto-reload value
: TIM3-ARR_ARR_L   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM3-ARR bis! ;  \ TIM3-ARR_ARR_L    Low Auto-reload value

\ TIM3-CCR1 (read-write)
: TIM3-CCR1_CCR1_H   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift TIM3-CCR1 bis! ;  \ TIM3-CCR1_CCR1_H    High Capture/Compare 1
  value
: TIM3-CCR1_CCR1_L   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM3-CCR1 bis! ;  \ TIM3-CCR1_CCR1_L    Low Capture/Compare 1
  value

\ TIM3-CCR2 (read-write)
: TIM3-CCR2_CCR2_H   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift TIM3-CCR2 bis! ;  \ TIM3-CCR2_CCR2_H    High Capture/Compare 2
  value
: TIM3-CCR2_CCR2_L   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM3-CCR2 bis! ;  \ TIM3-CCR2_CCR2_L    Low Capture/Compare 2
  value

\ TIM3-CCR3 (read-write)
: TIM3-CCR3_CCR3_H   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift TIM3-CCR3 bis! ;  \ TIM3-CCR3_CCR3_H    High Capture/Compare value
: TIM3-CCR3_CCR3_L   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM3-CCR3 bis! ;  \ TIM3-CCR3_CCR3_L    Low Capture/Compare value

\ TIM3-CCR4 (read-write)
: TIM3-CCR4_CCR4_H   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift TIM3-CCR4 bis! ;  \ TIM3-CCR4_CCR4_H    High Capture/Compare value
: TIM3-CCR4_CCR4_L   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM3-CCR4 bis! ;  \ TIM3-CCR4_CCR4_L    Low Capture/Compare value

\ TIM3-DCR (read-write)
: TIM3-DCR_DBL   ( %XXXXX -- ) 8 lshift TIM3-DCR bis! ;  \ TIM3-DCR_DBL    DMA burst length
: TIM3-DCR_DBA   ( %XXXXX -- ) 0 lshift TIM3-DCR bis! ;  \ TIM3-DCR_DBA    DMA base address

\ TIM3-DMAR (read-write)
: TIM3-DMAR_DMAB   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM3-DMAR bis! ;  \ TIM3-DMAR_DMAB    DMA register for burst
  accesses

\ TIM4-CR1 (read-write)
: TIM4-CR1_CKD   ( %XX -- ) 8 lshift TIM4-CR1 bis! ;  \ TIM4-CR1_CKD    Clock division
: TIM4-CR1_ARPE   %1 7 lshift TIM4-CR1 bis! ;  \ TIM4-CR1_ARPE    Auto-reload preload enable
: TIM4-CR1_CMS   ( %XX -- ) 5 lshift TIM4-CR1 bis! ;  \ TIM4-CR1_CMS    Center-aligned mode
  selection
: TIM4-CR1_DIR   %1 4 lshift TIM4-CR1 bis! ;  \ TIM4-CR1_DIR    Direction
: TIM4-CR1_OPM   %1 3 lshift TIM4-CR1 bis! ;  \ TIM4-CR1_OPM    One-pulse mode
: TIM4-CR1_URS   %1 2 lshift TIM4-CR1 bis! ;  \ TIM4-CR1_URS    Update request source
: TIM4-CR1_UDIS   %1 1 lshift TIM4-CR1 bis! ;  \ TIM4-CR1_UDIS    Update disable
: TIM4-CR1_CEN   %1 0 lshift TIM4-CR1 bis! ;  \ TIM4-CR1_CEN    Counter enable

\ TIM4-CR2 (read-write)
: TIM4-CR2_TI1S   %1 7 lshift TIM4-CR2 bis! ;  \ TIM4-CR2_TI1S    TI1 selection
: TIM4-CR2_MMS   ( %XXX -- ) 4 lshift TIM4-CR2 bis! ;  \ TIM4-CR2_MMS    Master mode selection
: TIM4-CR2_CCDS   %1 3 lshift TIM4-CR2 bis! ;  \ TIM4-CR2_CCDS    Capture/compare DMA
  selection

\ TIM4-SMCR (read-write)
: TIM4-SMCR_ETP   %1 15 lshift TIM4-SMCR bis! ;  \ TIM4-SMCR_ETP    External trigger polarity
: TIM4-SMCR_ECE   %1 14 lshift TIM4-SMCR bis! ;  \ TIM4-SMCR_ECE    External clock enable
: TIM4-SMCR_ETPS   ( %XX -- ) 12 lshift TIM4-SMCR bis! ;  \ TIM4-SMCR_ETPS    External trigger prescaler
: TIM4-SMCR_ETF   ( %XXXX -- ) 8 lshift TIM4-SMCR bis! ;  \ TIM4-SMCR_ETF    External trigger filter
: TIM4-SMCR_MSM   %1 7 lshift TIM4-SMCR bis! ;  \ TIM4-SMCR_MSM    Master/Slave mode
: TIM4-SMCR_TS   ( %XXX -- ) 4 lshift TIM4-SMCR bis! ;  \ TIM4-SMCR_TS    Trigger selection
: TIM4-SMCR_SMS   ( %XXX -- ) 0 lshift TIM4-SMCR bis! ;  \ TIM4-SMCR_SMS    Slave mode selection

\ TIM4-DIER (read-write)
: TIM4-DIER_TDE   %1 14 lshift TIM4-DIER bis! ;  \ TIM4-DIER_TDE    Trigger DMA request enable
: TIM4-DIER_CC4DE   %1 12 lshift TIM4-DIER bis! ;  \ TIM4-DIER_CC4DE    Capture/Compare 4 DMA request
  enable
: TIM4-DIER_CC3DE   %1 11 lshift TIM4-DIER bis! ;  \ TIM4-DIER_CC3DE    Capture/Compare 3 DMA request
  enable
: TIM4-DIER_CC2DE   %1 10 lshift TIM4-DIER bis! ;  \ TIM4-DIER_CC2DE    Capture/Compare 2 DMA request
  enable
: TIM4-DIER_CC1DE   %1 9 lshift TIM4-DIER bis! ;  \ TIM4-DIER_CC1DE    Capture/Compare 1 DMA request
  enable
: TIM4-DIER_UDE   %1 8 lshift TIM4-DIER bis! ;  \ TIM4-DIER_UDE    Update DMA request enable
: TIM4-DIER_TIE   %1 6 lshift TIM4-DIER bis! ;  \ TIM4-DIER_TIE    Trigger interrupt enable
: TIM4-DIER_CC4IE   %1 4 lshift TIM4-DIER bis! ;  \ TIM4-DIER_CC4IE    Capture/Compare 4 interrupt
  enable
: TIM4-DIER_CC3IE   %1 3 lshift TIM4-DIER bis! ;  \ TIM4-DIER_CC3IE    Capture/Compare 3 interrupt
  enable
: TIM4-DIER_CC2IE   %1 2 lshift TIM4-DIER bis! ;  \ TIM4-DIER_CC2IE    Capture/Compare 2 interrupt
  enable
: TIM4-DIER_CC1IE   %1 1 lshift TIM4-DIER bis! ;  \ TIM4-DIER_CC1IE    Capture/Compare 1 interrupt
  enable
: TIM4-DIER_UIE   %1 0 lshift TIM4-DIER bis! ;  \ TIM4-DIER_UIE    Update interrupt enable

\ TIM4-SR (read-write)
: TIM4-SR_CC4OF   %1 12 lshift TIM4-SR bis! ;  \ TIM4-SR_CC4OF    Capture/Compare 4 overcapture
  flag
: TIM4-SR_CC3OF   %1 11 lshift TIM4-SR bis! ;  \ TIM4-SR_CC3OF    Capture/Compare 3 overcapture
  flag
: TIM4-SR_CC2OF   %1 10 lshift TIM4-SR bis! ;  \ TIM4-SR_CC2OF    Capture/compare 2 overcapture
  flag
: TIM4-SR_CC1OF   %1 9 lshift TIM4-SR bis! ;  \ TIM4-SR_CC1OF    Capture/Compare 1 overcapture
  flag
: TIM4-SR_TIF   %1 6 lshift TIM4-SR bis! ;  \ TIM4-SR_TIF    Trigger interrupt flag
: TIM4-SR_CC4IF   %1 4 lshift TIM4-SR bis! ;  \ TIM4-SR_CC4IF    Capture/Compare 4 interrupt
  flag
: TIM4-SR_CC3IF   %1 3 lshift TIM4-SR bis! ;  \ TIM4-SR_CC3IF    Capture/Compare 3 interrupt
  flag
: TIM4-SR_CC2IF   %1 2 lshift TIM4-SR bis! ;  \ TIM4-SR_CC2IF    Capture/Compare 2 interrupt
  flag
: TIM4-SR_CC1IF   %1 1 lshift TIM4-SR bis! ;  \ TIM4-SR_CC1IF    Capture/compare 1 interrupt
  flag
: TIM4-SR_UIF   %1 0 lshift TIM4-SR bis! ;  \ TIM4-SR_UIF    Update interrupt flag

\ TIM4-EGR (write-only)
: TIM4-EGR_TG   %1 6 lshift TIM4-EGR bis! ;  \ TIM4-EGR_TG    Trigger generation
: TIM4-EGR_CC4G   %1 4 lshift TIM4-EGR bis! ;  \ TIM4-EGR_CC4G    Capture/compare 4
  generation
: TIM4-EGR_CC3G   %1 3 lshift TIM4-EGR bis! ;  \ TIM4-EGR_CC3G    Capture/compare 3
  generation
: TIM4-EGR_CC2G   %1 2 lshift TIM4-EGR bis! ;  \ TIM4-EGR_CC2G    Capture/compare 2
  generation
: TIM4-EGR_CC1G   %1 1 lshift TIM4-EGR bis! ;  \ TIM4-EGR_CC1G    Capture/compare 1
  generation
: TIM4-EGR_UG   %1 0 lshift TIM4-EGR bis! ;  \ TIM4-EGR_UG    Update generation

\ TIM4-CCMR1_Output (read-write)
: TIM4-CCMR1_Output_OC2CE   %1 15 lshift TIM4-CCMR1_Output bis! ;  \ TIM4-CCMR1_Output_OC2CE    OC2CE
: TIM4-CCMR1_Output_OC2M   ( %XXX -- ) 12 lshift TIM4-CCMR1_Output bis! ;  \ TIM4-CCMR1_Output_OC2M    OC2M
: TIM4-CCMR1_Output_OC2PE   %1 11 lshift TIM4-CCMR1_Output bis! ;  \ TIM4-CCMR1_Output_OC2PE    OC2PE
: TIM4-CCMR1_Output_OC2FE   %1 10 lshift TIM4-CCMR1_Output bis! ;  \ TIM4-CCMR1_Output_OC2FE    OC2FE
: TIM4-CCMR1_Output_CC2S   ( %XX -- ) 8 lshift TIM4-CCMR1_Output bis! ;  \ TIM4-CCMR1_Output_CC2S    CC2S
: TIM4-CCMR1_Output_OC1CE   %1 7 lshift TIM4-CCMR1_Output bis! ;  \ TIM4-CCMR1_Output_OC1CE    OC1CE
: TIM4-CCMR1_Output_OC1M   ( %XXX -- ) 4 lshift TIM4-CCMR1_Output bis! ;  \ TIM4-CCMR1_Output_OC1M    OC1M
: TIM4-CCMR1_Output_OC1PE   %1 3 lshift TIM4-CCMR1_Output bis! ;  \ TIM4-CCMR1_Output_OC1PE    OC1PE
: TIM4-CCMR1_Output_OC1FE   %1 2 lshift TIM4-CCMR1_Output bis! ;  \ TIM4-CCMR1_Output_OC1FE    OC1FE
: TIM4-CCMR1_Output_CC1S   ( %XX -- ) 0 lshift TIM4-CCMR1_Output bis! ;  \ TIM4-CCMR1_Output_CC1S    CC1S

\ TIM4-CCMR1_Input (read-write)
: TIM4-CCMR1_Input_IC2F   ( %XXXX -- ) 12 lshift TIM4-CCMR1_Input bis! ;  \ TIM4-CCMR1_Input_IC2F    Input capture 2 filter
: TIM4-CCMR1_Input_IC2PCS   ( %XX -- ) 10 lshift TIM4-CCMR1_Input bis! ;  \ TIM4-CCMR1_Input_IC2PCS    Input capture 2 prescaler
: TIM4-CCMR1_Input_CC2S   ( %XX -- ) 8 lshift TIM4-CCMR1_Input bis! ;  \ TIM4-CCMR1_Input_CC2S    Capture/Compare 2
  selection
: TIM4-CCMR1_Input_IC1F   ( %XXXX -- ) 4 lshift TIM4-CCMR1_Input bis! ;  \ TIM4-CCMR1_Input_IC1F    Input capture 1 filter
: TIM4-CCMR1_Input_ICPCS   ( %XX -- ) 2 lshift TIM4-CCMR1_Input bis! ;  \ TIM4-CCMR1_Input_ICPCS    Input capture 1 prescaler
: TIM4-CCMR1_Input_CC1S   ( %XX -- ) 0 lshift TIM4-CCMR1_Input bis! ;  \ TIM4-CCMR1_Input_CC1S    Capture/Compare 1
  selection

\ TIM4-CCMR2_Output (read-write)
: TIM4-CCMR2_Output_O24CE   %1 15 lshift TIM4-CCMR2_Output bis! ;  \ TIM4-CCMR2_Output_O24CE    O24CE
: TIM4-CCMR2_Output_OC4M   ( %XXX -- ) 12 lshift TIM4-CCMR2_Output bis! ;  \ TIM4-CCMR2_Output_OC4M    OC4M
: TIM4-CCMR2_Output_OC4PE   %1 11 lshift TIM4-CCMR2_Output bis! ;  \ TIM4-CCMR2_Output_OC4PE    OC4PE
: TIM4-CCMR2_Output_OC4FE   %1 10 lshift TIM4-CCMR2_Output bis! ;  \ TIM4-CCMR2_Output_OC4FE    OC4FE
: TIM4-CCMR2_Output_CC4S   ( %XX -- ) 8 lshift TIM4-CCMR2_Output bis! ;  \ TIM4-CCMR2_Output_CC4S    CC4S
: TIM4-CCMR2_Output_OC3CE   %1 7 lshift TIM4-CCMR2_Output bis! ;  \ TIM4-CCMR2_Output_OC3CE    OC3CE
: TIM4-CCMR2_Output_OC3M   ( %XXX -- ) 4 lshift TIM4-CCMR2_Output bis! ;  \ TIM4-CCMR2_Output_OC3M    OC3M
: TIM4-CCMR2_Output_OC3PE   %1 3 lshift TIM4-CCMR2_Output bis! ;  \ TIM4-CCMR2_Output_OC3PE    OC3PE
: TIM4-CCMR2_Output_OC3FE   %1 2 lshift TIM4-CCMR2_Output bis! ;  \ TIM4-CCMR2_Output_OC3FE    OC3FE
: TIM4-CCMR2_Output_CC3S   ( %XX -- ) 0 lshift TIM4-CCMR2_Output bis! ;  \ TIM4-CCMR2_Output_CC3S    CC3S

\ TIM4-CCMR2_Input (read-write)
: TIM4-CCMR2_Input_IC4F   ( %XXXX -- ) 12 lshift TIM4-CCMR2_Input bis! ;  \ TIM4-CCMR2_Input_IC4F    Input capture 4 filter
: TIM4-CCMR2_Input_IC4PSC   ( %XX -- ) 10 lshift TIM4-CCMR2_Input bis! ;  \ TIM4-CCMR2_Input_IC4PSC    Input capture 4 prescaler
: TIM4-CCMR2_Input_CC4S   ( %XX -- ) 8 lshift TIM4-CCMR2_Input bis! ;  \ TIM4-CCMR2_Input_CC4S    Capture/Compare 4
  selection
: TIM4-CCMR2_Input_IC3F   ( %XXXX -- ) 4 lshift TIM4-CCMR2_Input bis! ;  \ TIM4-CCMR2_Input_IC3F    Input capture 3 filter
: TIM4-CCMR2_Input_IC3PSC   ( %XX -- ) 2 lshift TIM4-CCMR2_Input bis! ;  \ TIM4-CCMR2_Input_IC3PSC    Input capture 3 prescaler
: TIM4-CCMR2_Input_CC3S   ( %XX -- ) 0 lshift TIM4-CCMR2_Input bis! ;  \ TIM4-CCMR2_Input_CC3S    Capture/compare 3
  selection

\ TIM4-CCER (read-write)
: TIM4-CCER_CC4NP   %1 15 lshift TIM4-CCER bis! ;  \ TIM4-CCER_CC4NP    Capture/Compare 4 output
  Polarity
: TIM4-CCER_CC4P   %1 13 lshift TIM4-CCER bis! ;  \ TIM4-CCER_CC4P    Capture/Compare 3 output
  Polarity
: TIM4-CCER_CC4E   %1 12 lshift TIM4-CCER bis! ;  \ TIM4-CCER_CC4E    Capture/Compare 4 output
  enable
: TIM4-CCER_CC3NP   %1 11 lshift TIM4-CCER bis! ;  \ TIM4-CCER_CC3NP    Capture/Compare 3 output
  Polarity
: TIM4-CCER_CC3P   %1 9 lshift TIM4-CCER bis! ;  \ TIM4-CCER_CC3P    Capture/Compare 3 output
  Polarity
: TIM4-CCER_CC3E   %1 8 lshift TIM4-CCER bis! ;  \ TIM4-CCER_CC3E    Capture/Compare 3 output
  enable
: TIM4-CCER_CC2NP   %1 7 lshift TIM4-CCER bis! ;  \ TIM4-CCER_CC2NP    Capture/Compare 2 output
  Polarity
: TIM4-CCER_CC2P   %1 5 lshift TIM4-CCER bis! ;  \ TIM4-CCER_CC2P    Capture/Compare 2 output
  Polarity
: TIM4-CCER_CC2E   %1 4 lshift TIM4-CCER bis! ;  \ TIM4-CCER_CC2E    Capture/Compare 2 output
  enable
: TIM4-CCER_CC1NP   %1 3 lshift TIM4-CCER bis! ;  \ TIM4-CCER_CC1NP    Capture/Compare 1 output
  Polarity
: TIM4-CCER_CC1P   %1 1 lshift TIM4-CCER bis! ;  \ TIM4-CCER_CC1P    Capture/Compare 1 output
  Polarity
: TIM4-CCER_CC1E   %1 0 lshift TIM4-CCER bis! ;  \ TIM4-CCER_CC1E    Capture/Compare 1 output
  enable

\ TIM4-CNT (read-write)
: TIM4-CNT_CNT_H   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift TIM4-CNT bis! ;  \ TIM4-CNT_CNT_H    High counter value
: TIM4-CNT_CNT_L   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM4-CNT bis! ;  \ TIM4-CNT_CNT_L    Low counter value

\ TIM4-PSC (read-write)
: TIM4-PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM4-PSC bis! ;  \ TIM4-PSC_PSC    Prescaler value

\ TIM4-ARR (read-write)
: TIM4-ARR_ARR_H   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift TIM4-ARR bis! ;  \ TIM4-ARR_ARR_H    High Auto-reload value
: TIM4-ARR_ARR_L   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM4-ARR bis! ;  \ TIM4-ARR_ARR_L    Low Auto-reload value

\ TIM4-CCR1 (read-write)
: TIM4-CCR1_CCR1_H   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift TIM4-CCR1 bis! ;  \ TIM4-CCR1_CCR1_H    High Capture/Compare 1
  value
: TIM4-CCR1_CCR1_L   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM4-CCR1 bis! ;  \ TIM4-CCR1_CCR1_L    Low Capture/Compare 1
  value

\ TIM4-CCR2 (read-write)
: TIM4-CCR2_CCR2_H   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift TIM4-CCR2 bis! ;  \ TIM4-CCR2_CCR2_H    High Capture/Compare 2
  value
: TIM4-CCR2_CCR2_L   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM4-CCR2 bis! ;  \ TIM4-CCR2_CCR2_L    Low Capture/Compare 2
  value

\ TIM4-CCR3 (read-write)
: TIM4-CCR3_CCR3_H   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift TIM4-CCR3 bis! ;  \ TIM4-CCR3_CCR3_H    High Capture/Compare value
: TIM4-CCR3_CCR3_L   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM4-CCR3 bis! ;  \ TIM4-CCR3_CCR3_L    Low Capture/Compare value

\ TIM4-CCR4 (read-write)
: TIM4-CCR4_CCR4_H   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift TIM4-CCR4 bis! ;  \ TIM4-CCR4_CCR4_H    High Capture/Compare value
: TIM4-CCR4_CCR4_L   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM4-CCR4 bis! ;  \ TIM4-CCR4_CCR4_L    Low Capture/Compare value

\ TIM4-DCR (read-write)
: TIM4-DCR_DBL   ( %XXXXX -- ) 8 lshift TIM4-DCR bis! ;  \ TIM4-DCR_DBL    DMA burst length
: TIM4-DCR_DBA   ( %XXXXX -- ) 0 lshift TIM4-DCR bis! ;  \ TIM4-DCR_DBA    DMA base address

\ TIM4-DMAR (read-write)
: TIM4-DMAR_DMAB   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM4-DMAR bis! ;  \ TIM4-DMAR_DMAB    DMA register for burst
  accesses

\ TIM5-CR1 (read-write)
: TIM5-CR1_CKD   ( %XX -- ) 8 lshift TIM5-CR1 bis! ;  \ TIM5-CR1_CKD    Clock division
: TIM5-CR1_ARPE   %1 7 lshift TIM5-CR1 bis! ;  \ TIM5-CR1_ARPE    Auto-reload preload enable
: TIM5-CR1_CMS   ( %XX -- ) 5 lshift TIM5-CR1 bis! ;  \ TIM5-CR1_CMS    Center-aligned mode
  selection
: TIM5-CR1_DIR   %1 4 lshift TIM5-CR1 bis! ;  \ TIM5-CR1_DIR    Direction
: TIM5-CR1_OPM   %1 3 lshift TIM5-CR1 bis! ;  \ TIM5-CR1_OPM    One-pulse mode
: TIM5-CR1_URS   %1 2 lshift TIM5-CR1 bis! ;  \ TIM5-CR1_URS    Update request source
: TIM5-CR1_UDIS   %1 1 lshift TIM5-CR1 bis! ;  \ TIM5-CR1_UDIS    Update disable
: TIM5-CR1_CEN   %1 0 lshift TIM5-CR1 bis! ;  \ TIM5-CR1_CEN    Counter enable

\ TIM5-CR2 (read-write)
: TIM5-CR2_TI1S   %1 7 lshift TIM5-CR2 bis! ;  \ TIM5-CR2_TI1S    TI1 selection
: TIM5-CR2_MMS   ( %XXX -- ) 4 lshift TIM5-CR2 bis! ;  \ TIM5-CR2_MMS    Master mode selection
: TIM5-CR2_CCDS   %1 3 lshift TIM5-CR2 bis! ;  \ TIM5-CR2_CCDS    Capture/compare DMA
  selection

\ TIM5-SMCR (read-write)
: TIM5-SMCR_ETP   %1 15 lshift TIM5-SMCR bis! ;  \ TIM5-SMCR_ETP    External trigger polarity
: TIM5-SMCR_ECE   %1 14 lshift TIM5-SMCR bis! ;  \ TIM5-SMCR_ECE    External clock enable
: TIM5-SMCR_ETPS   ( %XX -- ) 12 lshift TIM5-SMCR bis! ;  \ TIM5-SMCR_ETPS    External trigger prescaler
: TIM5-SMCR_ETF   ( %XXXX -- ) 8 lshift TIM5-SMCR bis! ;  \ TIM5-SMCR_ETF    External trigger filter
: TIM5-SMCR_MSM   %1 7 lshift TIM5-SMCR bis! ;  \ TIM5-SMCR_MSM    Master/Slave mode
: TIM5-SMCR_TS   ( %XXX -- ) 4 lshift TIM5-SMCR bis! ;  \ TIM5-SMCR_TS    Trigger selection
: TIM5-SMCR_SMS   ( %XXX -- ) 0 lshift TIM5-SMCR bis! ;  \ TIM5-SMCR_SMS    Slave mode selection

\ TIM5-DIER (read-write)
: TIM5-DIER_TDE   %1 14 lshift TIM5-DIER bis! ;  \ TIM5-DIER_TDE    Trigger DMA request enable
: TIM5-DIER_CC4DE   %1 12 lshift TIM5-DIER bis! ;  \ TIM5-DIER_CC4DE    Capture/Compare 4 DMA request
  enable
: TIM5-DIER_CC3DE   %1 11 lshift TIM5-DIER bis! ;  \ TIM5-DIER_CC3DE    Capture/Compare 3 DMA request
  enable
: TIM5-DIER_CC2DE   %1 10 lshift TIM5-DIER bis! ;  \ TIM5-DIER_CC2DE    Capture/Compare 2 DMA request
  enable
: TIM5-DIER_CC1DE   %1 9 lshift TIM5-DIER bis! ;  \ TIM5-DIER_CC1DE    Capture/Compare 1 DMA request
  enable
: TIM5-DIER_UDE   %1 8 lshift TIM5-DIER bis! ;  \ TIM5-DIER_UDE    Update DMA request enable
: TIM5-DIER_TIE   %1 6 lshift TIM5-DIER bis! ;  \ TIM5-DIER_TIE    Trigger interrupt enable
: TIM5-DIER_CC4IE   %1 4 lshift TIM5-DIER bis! ;  \ TIM5-DIER_CC4IE    Capture/Compare 4 interrupt
  enable
: TIM5-DIER_CC3IE   %1 3 lshift TIM5-DIER bis! ;  \ TIM5-DIER_CC3IE    Capture/Compare 3 interrupt
  enable
: TIM5-DIER_CC2IE   %1 2 lshift TIM5-DIER bis! ;  \ TIM5-DIER_CC2IE    Capture/Compare 2 interrupt
  enable
: TIM5-DIER_CC1IE   %1 1 lshift TIM5-DIER bis! ;  \ TIM5-DIER_CC1IE    Capture/Compare 1 interrupt
  enable
: TIM5-DIER_UIE   %1 0 lshift TIM5-DIER bis! ;  \ TIM5-DIER_UIE    Update interrupt enable

\ TIM5-SR (read-write)
: TIM5-SR_CC4OF   %1 12 lshift TIM5-SR bis! ;  \ TIM5-SR_CC4OF    Capture/Compare 4 overcapture
  flag
: TIM5-SR_CC3OF   %1 11 lshift TIM5-SR bis! ;  \ TIM5-SR_CC3OF    Capture/Compare 3 overcapture
  flag
: TIM5-SR_CC2OF   %1 10 lshift TIM5-SR bis! ;  \ TIM5-SR_CC2OF    Capture/compare 2 overcapture
  flag
: TIM5-SR_CC1OF   %1 9 lshift TIM5-SR bis! ;  \ TIM5-SR_CC1OF    Capture/Compare 1 overcapture
  flag
: TIM5-SR_TIF   %1 6 lshift TIM5-SR bis! ;  \ TIM5-SR_TIF    Trigger interrupt flag
: TIM5-SR_CC4IF   %1 4 lshift TIM5-SR bis! ;  \ TIM5-SR_CC4IF    Capture/Compare 4 interrupt
  flag
: TIM5-SR_CC3IF   %1 3 lshift TIM5-SR bis! ;  \ TIM5-SR_CC3IF    Capture/Compare 3 interrupt
  flag
: TIM5-SR_CC2IF   %1 2 lshift TIM5-SR bis! ;  \ TIM5-SR_CC2IF    Capture/Compare 2 interrupt
  flag
: TIM5-SR_CC1IF   %1 1 lshift TIM5-SR bis! ;  \ TIM5-SR_CC1IF    Capture/compare 1 interrupt
  flag
: TIM5-SR_UIF   %1 0 lshift TIM5-SR bis! ;  \ TIM5-SR_UIF    Update interrupt flag

\ TIM5-EGR (write-only)
: TIM5-EGR_TG   %1 6 lshift TIM5-EGR bis! ;  \ TIM5-EGR_TG    Trigger generation
: TIM5-EGR_CC4G   %1 4 lshift TIM5-EGR bis! ;  \ TIM5-EGR_CC4G    Capture/compare 4
  generation
: TIM5-EGR_CC3G   %1 3 lshift TIM5-EGR bis! ;  \ TIM5-EGR_CC3G    Capture/compare 3
  generation
: TIM5-EGR_CC2G   %1 2 lshift TIM5-EGR bis! ;  \ TIM5-EGR_CC2G    Capture/compare 2
  generation
: TIM5-EGR_CC1G   %1 1 lshift TIM5-EGR bis! ;  \ TIM5-EGR_CC1G    Capture/compare 1
  generation
: TIM5-EGR_UG   %1 0 lshift TIM5-EGR bis! ;  \ TIM5-EGR_UG    Update generation

\ TIM5-CCMR1_Output (read-write)
: TIM5-CCMR1_Output_OC2CE   %1 15 lshift TIM5-CCMR1_Output bis! ;  \ TIM5-CCMR1_Output_OC2CE    OC2CE
: TIM5-CCMR1_Output_OC2M   ( %XXX -- ) 12 lshift TIM5-CCMR1_Output bis! ;  \ TIM5-CCMR1_Output_OC2M    OC2M
: TIM5-CCMR1_Output_OC2PE   %1 11 lshift TIM5-CCMR1_Output bis! ;  \ TIM5-CCMR1_Output_OC2PE    OC2PE
: TIM5-CCMR1_Output_OC2FE   %1 10 lshift TIM5-CCMR1_Output bis! ;  \ TIM5-CCMR1_Output_OC2FE    OC2FE
: TIM5-CCMR1_Output_CC2S   ( %XX -- ) 8 lshift TIM5-CCMR1_Output bis! ;  \ TIM5-CCMR1_Output_CC2S    CC2S
: TIM5-CCMR1_Output_OC1CE   %1 7 lshift TIM5-CCMR1_Output bis! ;  \ TIM5-CCMR1_Output_OC1CE    OC1CE
: TIM5-CCMR1_Output_OC1M   ( %XXX -- ) 4 lshift TIM5-CCMR1_Output bis! ;  \ TIM5-CCMR1_Output_OC1M    OC1M
: TIM5-CCMR1_Output_OC1PE   %1 3 lshift TIM5-CCMR1_Output bis! ;  \ TIM5-CCMR1_Output_OC1PE    OC1PE
: TIM5-CCMR1_Output_OC1FE   %1 2 lshift TIM5-CCMR1_Output bis! ;  \ TIM5-CCMR1_Output_OC1FE    OC1FE
: TIM5-CCMR1_Output_CC1S   ( %XX -- ) 0 lshift TIM5-CCMR1_Output bis! ;  \ TIM5-CCMR1_Output_CC1S    CC1S

\ TIM5-CCMR1_Input (read-write)
: TIM5-CCMR1_Input_IC2F   ( %XXXX -- ) 12 lshift TIM5-CCMR1_Input bis! ;  \ TIM5-CCMR1_Input_IC2F    Input capture 2 filter
: TIM5-CCMR1_Input_IC2PCS   ( %XX -- ) 10 lshift TIM5-CCMR1_Input bis! ;  \ TIM5-CCMR1_Input_IC2PCS    Input capture 2 prescaler
: TIM5-CCMR1_Input_CC2S   ( %XX -- ) 8 lshift TIM5-CCMR1_Input bis! ;  \ TIM5-CCMR1_Input_CC2S    Capture/Compare 2
  selection
: TIM5-CCMR1_Input_IC1F   ( %XXXX -- ) 4 lshift TIM5-CCMR1_Input bis! ;  \ TIM5-CCMR1_Input_IC1F    Input capture 1 filter
: TIM5-CCMR1_Input_ICPCS   ( %XX -- ) 2 lshift TIM5-CCMR1_Input bis! ;  \ TIM5-CCMR1_Input_ICPCS    Input capture 1 prescaler
: TIM5-CCMR1_Input_CC1S   ( %XX -- ) 0 lshift TIM5-CCMR1_Input bis! ;  \ TIM5-CCMR1_Input_CC1S    Capture/Compare 1
  selection

\ TIM5-CCMR2_Output (read-write)
: TIM5-CCMR2_Output_O24CE   %1 15 lshift TIM5-CCMR2_Output bis! ;  \ TIM5-CCMR2_Output_O24CE    O24CE
: TIM5-CCMR2_Output_OC4M   ( %XXX -- ) 12 lshift TIM5-CCMR2_Output bis! ;  \ TIM5-CCMR2_Output_OC4M    OC4M
: TIM5-CCMR2_Output_OC4PE   %1 11 lshift TIM5-CCMR2_Output bis! ;  \ TIM5-CCMR2_Output_OC4PE    OC4PE
: TIM5-CCMR2_Output_OC4FE   %1 10 lshift TIM5-CCMR2_Output bis! ;  \ TIM5-CCMR2_Output_OC4FE    OC4FE
: TIM5-CCMR2_Output_CC4S   ( %XX -- ) 8 lshift TIM5-CCMR2_Output bis! ;  \ TIM5-CCMR2_Output_CC4S    CC4S
: TIM5-CCMR2_Output_OC3CE   %1 7 lshift TIM5-CCMR2_Output bis! ;  \ TIM5-CCMR2_Output_OC3CE    OC3CE
: TIM5-CCMR2_Output_OC3M   ( %XXX -- ) 4 lshift TIM5-CCMR2_Output bis! ;  \ TIM5-CCMR2_Output_OC3M    OC3M
: TIM5-CCMR2_Output_OC3PE   %1 3 lshift TIM5-CCMR2_Output bis! ;  \ TIM5-CCMR2_Output_OC3PE    OC3PE
: TIM5-CCMR2_Output_OC3FE   %1 2 lshift TIM5-CCMR2_Output bis! ;  \ TIM5-CCMR2_Output_OC3FE    OC3FE
: TIM5-CCMR2_Output_CC3S   ( %XX -- ) 0 lshift TIM5-CCMR2_Output bis! ;  \ TIM5-CCMR2_Output_CC3S    CC3S

\ TIM5-CCMR2_Input (read-write)
: TIM5-CCMR2_Input_IC4F   ( %XXXX -- ) 12 lshift TIM5-CCMR2_Input bis! ;  \ TIM5-CCMR2_Input_IC4F    Input capture 4 filter
: TIM5-CCMR2_Input_IC4PSC   ( %XX -- ) 10 lshift TIM5-CCMR2_Input bis! ;  \ TIM5-CCMR2_Input_IC4PSC    Input capture 4 prescaler
: TIM5-CCMR2_Input_CC4S   ( %XX -- ) 8 lshift TIM5-CCMR2_Input bis! ;  \ TIM5-CCMR2_Input_CC4S    Capture/Compare 4
  selection
: TIM5-CCMR2_Input_IC3F   ( %XXXX -- ) 4 lshift TIM5-CCMR2_Input bis! ;  \ TIM5-CCMR2_Input_IC3F    Input capture 3 filter
: TIM5-CCMR2_Input_IC3PSC   ( %XX -- ) 2 lshift TIM5-CCMR2_Input bis! ;  \ TIM5-CCMR2_Input_IC3PSC    Input capture 3 prescaler
: TIM5-CCMR2_Input_CC3S   ( %XX -- ) 0 lshift TIM5-CCMR2_Input bis! ;  \ TIM5-CCMR2_Input_CC3S    Capture/compare 3
  selection

\ TIM5-CCER (read-write)
: TIM5-CCER_CC4NP   %1 15 lshift TIM5-CCER bis! ;  \ TIM5-CCER_CC4NP    Capture/Compare 4 output
  Polarity
: TIM5-CCER_CC4P   %1 13 lshift TIM5-CCER bis! ;  \ TIM5-CCER_CC4P    Capture/Compare 3 output
  Polarity
: TIM5-CCER_CC4E   %1 12 lshift TIM5-CCER bis! ;  \ TIM5-CCER_CC4E    Capture/Compare 4 output
  enable
: TIM5-CCER_CC3NP   %1 11 lshift TIM5-CCER bis! ;  \ TIM5-CCER_CC3NP    Capture/Compare 3 output
  Polarity
: TIM5-CCER_CC3P   %1 9 lshift TIM5-CCER bis! ;  \ TIM5-CCER_CC3P    Capture/Compare 3 output
  Polarity
: TIM5-CCER_CC3E   %1 8 lshift TIM5-CCER bis! ;  \ TIM5-CCER_CC3E    Capture/Compare 3 output
  enable
: TIM5-CCER_CC2NP   %1 7 lshift TIM5-CCER bis! ;  \ TIM5-CCER_CC2NP    Capture/Compare 2 output
  Polarity
: TIM5-CCER_CC2P   %1 5 lshift TIM5-CCER bis! ;  \ TIM5-CCER_CC2P    Capture/Compare 2 output
  Polarity
: TIM5-CCER_CC2E   %1 4 lshift TIM5-CCER bis! ;  \ TIM5-CCER_CC2E    Capture/Compare 2 output
  enable
: TIM5-CCER_CC1NP   %1 3 lshift TIM5-CCER bis! ;  \ TIM5-CCER_CC1NP    Capture/Compare 1 output
  Polarity
: TIM5-CCER_CC1P   %1 1 lshift TIM5-CCER bis! ;  \ TIM5-CCER_CC1P    Capture/Compare 1 output
  Polarity
: TIM5-CCER_CC1E   %1 0 lshift TIM5-CCER bis! ;  \ TIM5-CCER_CC1E    Capture/Compare 1 output
  enable

\ TIM5-CNT (read-write)
: TIM5-CNT_CNT_H   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift TIM5-CNT bis! ;  \ TIM5-CNT_CNT_H    High counter value
: TIM5-CNT_CNT_L   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM5-CNT bis! ;  \ TIM5-CNT_CNT_L    Low counter value

\ TIM5-PSC (read-write)
: TIM5-PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM5-PSC bis! ;  \ TIM5-PSC_PSC    Prescaler value

\ TIM5-ARR (read-write)
: TIM5-ARR_ARR_H   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift TIM5-ARR bis! ;  \ TIM5-ARR_ARR_H    High Auto-reload value
: TIM5-ARR_ARR_L   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM5-ARR bis! ;  \ TIM5-ARR_ARR_L    Low Auto-reload value

\ TIM5-CCR1 (read-write)
: TIM5-CCR1_CCR1_H   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift TIM5-CCR1 bis! ;  \ TIM5-CCR1_CCR1_H    High Capture/Compare 1
  value
: TIM5-CCR1_CCR1_L   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM5-CCR1 bis! ;  \ TIM5-CCR1_CCR1_L    Low Capture/Compare 1
  value

\ TIM5-CCR2 (read-write)
: TIM5-CCR2_CCR2_H   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift TIM5-CCR2 bis! ;  \ TIM5-CCR2_CCR2_H    High Capture/Compare 2
  value
: TIM5-CCR2_CCR2_L   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM5-CCR2 bis! ;  \ TIM5-CCR2_CCR2_L    Low Capture/Compare 2
  value

\ TIM5-CCR3 (read-write)
: TIM5-CCR3_CCR3_H   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift TIM5-CCR3 bis! ;  \ TIM5-CCR3_CCR3_H    High Capture/Compare value
: TIM5-CCR3_CCR3_L   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM5-CCR3 bis! ;  \ TIM5-CCR3_CCR3_L    Low Capture/Compare value

\ TIM5-CCR4 (read-write)
: TIM5-CCR4_CCR4_H   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift TIM5-CCR4 bis! ;  \ TIM5-CCR4_CCR4_H    High Capture/Compare value
: TIM5-CCR4_CCR4_L   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM5-CCR4 bis! ;  \ TIM5-CCR4_CCR4_L    Low Capture/Compare value

\ TIM5-DCR (read-write)
: TIM5-DCR_DBL   ( %XXXXX -- ) 8 lshift TIM5-DCR bis! ;  \ TIM5-DCR_DBL    DMA burst length
: TIM5-DCR_DBA   ( %XXXXX -- ) 0 lshift TIM5-DCR bis! ;  \ TIM5-DCR_DBA    DMA base address

\ TIM5-DMAR (read-write)
: TIM5-DMAR_DMAB   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM5-DMAR bis! ;  \ TIM5-DMAR_DMAB    DMA register for burst
  accesses

\ TIM5-OR (read-write)
: TIM5-OR_IT4_RMP   ( %XX -- ) 6 lshift TIM5-OR bis! ;  \ TIM5-OR_IT4_RMP    Timer Input 4 remap

\ TIM9-CR1 (read-write)
: TIM9-CR1_CKD   ( %XX -- ) 8 lshift TIM9-CR1 bis! ;  \ TIM9-CR1_CKD    Clock division
: TIM9-CR1_ARPE   %1 7 lshift TIM9-CR1 bis! ;  \ TIM9-CR1_ARPE    Auto-reload preload enable
: TIM9-CR1_OPM   %1 3 lshift TIM9-CR1 bis! ;  \ TIM9-CR1_OPM    One-pulse mode
: TIM9-CR1_URS   %1 2 lshift TIM9-CR1 bis! ;  \ TIM9-CR1_URS    Update request source
: TIM9-CR1_UDIS   %1 1 lshift TIM9-CR1 bis! ;  \ TIM9-CR1_UDIS    Update disable
: TIM9-CR1_CEN   %1 0 lshift TIM9-CR1 bis! ;  \ TIM9-CR1_CEN    Counter enable

\ TIM9-CR2 (read-write)
: TIM9-CR2_MMS   ( %XXX -- ) 4 lshift TIM9-CR2 bis! ;  \ TIM9-CR2_MMS    Master mode selection

\ TIM9-SMCR (read-write)
: TIM9-SMCR_MSM   %1 7 lshift TIM9-SMCR bis! ;  \ TIM9-SMCR_MSM    Master/Slave mode
: TIM9-SMCR_TS   ( %XXX -- ) 4 lshift TIM9-SMCR bis! ;  \ TIM9-SMCR_TS    Trigger selection
: TIM9-SMCR_SMS   ( %XXX -- ) 0 lshift TIM9-SMCR bis! ;  \ TIM9-SMCR_SMS    Slave mode selection

\ TIM9-DIER (read-write)
: TIM9-DIER_TIE   %1 6 lshift TIM9-DIER bis! ;  \ TIM9-DIER_TIE    Trigger interrupt enable
: TIM9-DIER_CC2IE   %1 2 lshift TIM9-DIER bis! ;  \ TIM9-DIER_CC2IE    Capture/Compare 2 interrupt
  enable
: TIM9-DIER_CC1IE   %1 1 lshift TIM9-DIER bis! ;  \ TIM9-DIER_CC1IE    Capture/Compare 1 interrupt
  enable
: TIM9-DIER_UIE   %1 0 lshift TIM9-DIER bis! ;  \ TIM9-DIER_UIE    Update interrupt enable

\ TIM9-SR (read-write)
: TIM9-SR_CC2OF   %1 10 lshift TIM9-SR bis! ;  \ TIM9-SR_CC2OF    Capture/compare 2 overcapture
  flag
: TIM9-SR_CC1OF   %1 9 lshift TIM9-SR bis! ;  \ TIM9-SR_CC1OF    Capture/Compare 1 overcapture
  flag
: TIM9-SR_TIF   %1 6 lshift TIM9-SR bis! ;  \ TIM9-SR_TIF    Trigger interrupt flag
: TIM9-SR_CC2IF   %1 2 lshift TIM9-SR bis! ;  \ TIM9-SR_CC2IF    Capture/Compare 2 interrupt
  flag
: TIM9-SR_CC1IF   %1 1 lshift TIM9-SR bis! ;  \ TIM9-SR_CC1IF    Capture/compare 1 interrupt
  flag
: TIM9-SR_UIF   %1 0 lshift TIM9-SR bis! ;  \ TIM9-SR_UIF    Update interrupt flag

\ TIM9-EGR (write-only)
: TIM9-EGR_TG   %1 6 lshift TIM9-EGR bis! ;  \ TIM9-EGR_TG    Trigger generation
: TIM9-EGR_CC2G   %1 2 lshift TIM9-EGR bis! ;  \ TIM9-EGR_CC2G    Capture/compare 2
  generation
: TIM9-EGR_CC1G   %1 1 lshift TIM9-EGR bis! ;  \ TIM9-EGR_CC1G    Capture/compare 1
  generation
: TIM9-EGR_UG   %1 0 lshift TIM9-EGR bis! ;  \ TIM9-EGR_UG    Update generation

\ TIM9-CCMR1_Output (read-write)
: TIM9-CCMR1_Output_OC2M   ( %XXX -- ) 12 lshift TIM9-CCMR1_Output bis! ;  \ TIM9-CCMR1_Output_OC2M    Output Compare 2 mode
: TIM9-CCMR1_Output_OC2PE   %1 11 lshift TIM9-CCMR1_Output bis! ;  \ TIM9-CCMR1_Output_OC2PE    Output Compare 2 preload
  enable
: TIM9-CCMR1_Output_OC2FE   %1 10 lshift TIM9-CCMR1_Output bis! ;  \ TIM9-CCMR1_Output_OC2FE    Output Compare 2 fast
  enable
: TIM9-CCMR1_Output_CC2S   ( %XX -- ) 8 lshift TIM9-CCMR1_Output bis! ;  \ TIM9-CCMR1_Output_CC2S    Capture/Compare 2
  selection
: TIM9-CCMR1_Output_OC1M   ( %XXX -- ) 4 lshift TIM9-CCMR1_Output bis! ;  \ TIM9-CCMR1_Output_OC1M    Output Compare 1 mode
: TIM9-CCMR1_Output_OC1PE   %1 3 lshift TIM9-CCMR1_Output bis! ;  \ TIM9-CCMR1_Output_OC1PE    Output Compare 1 preload
  enable
: TIM9-CCMR1_Output_OC1FE   %1 2 lshift TIM9-CCMR1_Output bis! ;  \ TIM9-CCMR1_Output_OC1FE    Output Compare 1 fast
  enable
: TIM9-CCMR1_Output_CC1S   ( %XX -- ) 0 lshift TIM9-CCMR1_Output bis! ;  \ TIM9-CCMR1_Output_CC1S    Capture/Compare 1
  selection

\ TIM9-CCMR1_Input (read-write)
: TIM9-CCMR1_Input_IC2F   ( %XXX -- ) 12 lshift TIM9-CCMR1_Input bis! ;  \ TIM9-CCMR1_Input_IC2F    Input capture 2 filter
: TIM9-CCMR1_Input_IC2PCS   ( %XX -- ) 10 lshift TIM9-CCMR1_Input bis! ;  \ TIM9-CCMR1_Input_IC2PCS    Input capture 2 prescaler
: TIM9-CCMR1_Input_CC2S   ( %XX -- ) 8 lshift TIM9-CCMR1_Input bis! ;  \ TIM9-CCMR1_Input_CC2S    Capture/Compare 2
  selection
: TIM9-CCMR1_Input_IC1F   ( %XXX -- ) 4 lshift TIM9-CCMR1_Input bis! ;  \ TIM9-CCMR1_Input_IC1F    Input capture 1 filter
: TIM9-CCMR1_Input_ICPCS   ( %XX -- ) 2 lshift TIM9-CCMR1_Input bis! ;  \ TIM9-CCMR1_Input_ICPCS    Input capture 1 prescaler
: TIM9-CCMR1_Input_CC1S   ( %XX -- ) 0 lshift TIM9-CCMR1_Input bis! ;  \ TIM9-CCMR1_Input_CC1S    Capture/Compare 1
  selection

\ TIM9-CCER (read-write)
: TIM9-CCER_CC2NP   %1 7 lshift TIM9-CCER bis! ;  \ TIM9-CCER_CC2NP    Capture/Compare 2 output
  Polarity
: TIM9-CCER_CC2P   %1 5 lshift TIM9-CCER bis! ;  \ TIM9-CCER_CC2P    Capture/Compare 2 output
  Polarity
: TIM9-CCER_CC2E   %1 4 lshift TIM9-CCER bis! ;  \ TIM9-CCER_CC2E    Capture/Compare 2 output
  enable
: TIM9-CCER_CC1NP   %1 3 lshift TIM9-CCER bis! ;  \ TIM9-CCER_CC1NP    Capture/Compare 1 output
  Polarity
: TIM9-CCER_CC1P   %1 1 lshift TIM9-CCER bis! ;  \ TIM9-CCER_CC1P    Capture/Compare 1 output
  Polarity
: TIM9-CCER_CC1E   %1 0 lshift TIM9-CCER bis! ;  \ TIM9-CCER_CC1E    Capture/Compare 1 output
  enable

\ TIM9-CNT (read-write)
: TIM9-CNT_CNT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM9-CNT bis! ;  \ TIM9-CNT_CNT    counter value

\ TIM9-PSC (read-write)
: TIM9-PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM9-PSC bis! ;  \ TIM9-PSC_PSC    Prescaler value

\ TIM9-ARR (read-write)
: TIM9-ARR_ARR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM9-ARR bis! ;  \ TIM9-ARR_ARR    Auto-reload value

\ TIM9-CCR1 (read-write)
: TIM9-CCR1_CCR1   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM9-CCR1 bis! ;  \ TIM9-CCR1_CCR1    Capture/Compare 1 value

\ TIM9-CCR2 (read-write)
: TIM9-CCR2_CCR2   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM9-CCR2 bis! ;  \ TIM9-CCR2_CCR2    Capture/Compare 2 value

\ USART1-SR ()
: USART1-SR_CTS   %1 9 lshift USART1-SR bis! ;  \ USART1-SR_CTS    CTS flag
: USART1-SR_LBD   %1 8 lshift USART1-SR bis! ;  \ USART1-SR_LBD    LIN break detection flag
: USART1-SR_TXE   %1 7 lshift USART1-SR bis! ;  \ USART1-SR_TXE    Transmit data register
  empty
: USART1-SR_TC   %1 6 lshift USART1-SR bis! ;  \ USART1-SR_TC    Transmission complete
: USART1-SR_RXNE   %1 5 lshift USART1-SR bis! ;  \ USART1-SR_RXNE    Read data register not
  empty
: USART1-SR_IDLE   %1 4 lshift USART1-SR bis! ;  \ USART1-SR_IDLE    IDLE line detected
: USART1-SR_ORE   %1 3 lshift USART1-SR bis! ;  \ USART1-SR_ORE    Overrun error
: USART1-SR_NF   %1 2 lshift USART1-SR bis! ;  \ USART1-SR_NF    Noise detected flag
: USART1-SR_FE   %1 1 lshift USART1-SR bis! ;  \ USART1-SR_FE    Framing error
: USART1-SR_PE   %1 0 lshift USART1-SR bis! ;  \ USART1-SR_PE    Parity error

\ USART1-DR (read-write)
: USART1-DR_DR   ( %XXXXXXXXX -- ) 0 lshift USART1-DR bis! ;  \ USART1-DR_DR    Data value

\ USART1-BRR (read-write)
: USART1-BRR_DIV_Mantissa   ( %XXXXXXXXXXX -- ) 4 lshift USART1-BRR bis! ;  \ USART1-BRR_DIV_Mantissa    mantissa of USARTDIV
: USART1-BRR_DIV_Fraction   ( %XXXX -- ) 0 lshift USART1-BRR bis! ;  \ USART1-BRR_DIV_Fraction    fraction of USARTDIV

\ USART1-CR1 (read-write)
: USART1-CR1_OVER8   %1 15 lshift USART1-CR1 bis! ;  \ USART1-CR1_OVER8    Oversampling mode
: USART1-CR1_UE   %1 13 lshift USART1-CR1 bis! ;  \ USART1-CR1_UE    USART enable
: USART1-CR1_M   %1 12 lshift USART1-CR1 bis! ;  \ USART1-CR1_M    Word length
: USART1-CR1_WAKE   %1 11 lshift USART1-CR1 bis! ;  \ USART1-CR1_WAKE    Wakeup method
: USART1-CR1_PCE   %1 10 lshift USART1-CR1 bis! ;  \ USART1-CR1_PCE    Parity control enable
: USART1-CR1_PS   %1 9 lshift USART1-CR1 bis! ;  \ USART1-CR1_PS    Parity selection
: USART1-CR1_PEIE   %1 8 lshift USART1-CR1 bis! ;  \ USART1-CR1_PEIE    PE interrupt enable
: USART1-CR1_TXEIE   %1 7 lshift USART1-CR1 bis! ;  \ USART1-CR1_TXEIE    TXE interrupt enable
: USART1-CR1_TCIE   %1 6 lshift USART1-CR1 bis! ;  \ USART1-CR1_TCIE    Transmission complete interrupt
  enable
: USART1-CR1_RXNEIE   %1 5 lshift USART1-CR1 bis! ;  \ USART1-CR1_RXNEIE    RXNE interrupt enable
: USART1-CR1_IDLEIE   %1 4 lshift USART1-CR1 bis! ;  \ USART1-CR1_IDLEIE    IDLE interrupt enable
: USART1-CR1_TE   %1 3 lshift USART1-CR1 bis! ;  \ USART1-CR1_TE    Transmitter enable
: USART1-CR1_RE   %1 2 lshift USART1-CR1 bis! ;  \ USART1-CR1_RE    Receiver enable
: USART1-CR1_RWU   %1 1 lshift USART1-CR1 bis! ;  \ USART1-CR1_RWU    Receiver wakeup
: USART1-CR1_SBK   %1 0 lshift USART1-CR1 bis! ;  \ USART1-CR1_SBK    Send break

\ USART1-CR2 (read-write)
: USART1-CR2_LINEN   %1 14 lshift USART1-CR2 bis! ;  \ USART1-CR2_LINEN    LIN mode enable
: USART1-CR2_STOP   ( %XX -- ) 12 lshift USART1-CR2 bis! ;  \ USART1-CR2_STOP    STOP bits
: USART1-CR2_CLKEN   %1 11 lshift USART1-CR2 bis! ;  \ USART1-CR2_CLKEN    Clock enable
: USART1-CR2_CPOL   %1 10 lshift USART1-CR2 bis! ;  \ USART1-CR2_CPOL    Clock polarity
: USART1-CR2_CPHA   %1 9 lshift USART1-CR2 bis! ;  \ USART1-CR2_CPHA    Clock phase
: USART1-CR2_LBCL   %1 8 lshift USART1-CR2 bis! ;  \ USART1-CR2_LBCL    Last bit clock pulse
: USART1-CR2_LBDIE   %1 6 lshift USART1-CR2 bis! ;  \ USART1-CR2_LBDIE    LIN break detection interrupt
  enable
: USART1-CR2_LBDL   %1 5 lshift USART1-CR2 bis! ;  \ USART1-CR2_LBDL    lin break detection length
: USART1-CR2_ADD   ( %XXXX -- ) 0 lshift USART1-CR2 bis! ;  \ USART1-CR2_ADD    Address of the USART node

\ USART1-CR3 (read-write)
: USART1-CR3_ONEBIT   %1 11 lshift USART1-CR3 bis! ;  \ USART1-CR3_ONEBIT    One sample bit method
  enable
: USART1-CR3_CTSIE   %1 10 lshift USART1-CR3 bis! ;  \ USART1-CR3_CTSIE    CTS interrupt enable
: USART1-CR3_CTSE   %1 9 lshift USART1-CR3 bis! ;  \ USART1-CR3_CTSE    CTS enable
: USART1-CR3_RTSE   %1 8 lshift USART1-CR3 bis! ;  \ USART1-CR3_RTSE    RTS enable
: USART1-CR3_DMAT   %1 7 lshift USART1-CR3 bis! ;  \ USART1-CR3_DMAT    DMA enable transmitter
: USART1-CR3_DMAR   %1 6 lshift USART1-CR3 bis! ;  \ USART1-CR3_DMAR    DMA enable receiver
: USART1-CR3_SCEN   %1 5 lshift USART1-CR3 bis! ;  \ USART1-CR3_SCEN    Smartcard mode enable
: USART1-CR3_NACK   %1 4 lshift USART1-CR3 bis! ;  \ USART1-CR3_NACK    Smartcard NACK enable
: USART1-CR3_HDSEL   %1 3 lshift USART1-CR3 bis! ;  \ USART1-CR3_HDSEL    Half-duplex selection
: USART1-CR3_IRLP   %1 2 lshift USART1-CR3 bis! ;  \ USART1-CR3_IRLP    IrDA low-power
: USART1-CR3_IREN   %1 1 lshift USART1-CR3 bis! ;  \ USART1-CR3_IREN    IrDA mode enable
: USART1-CR3_EIE   %1 0 lshift USART1-CR3 bis! ;  \ USART1-CR3_EIE    Error interrupt enable

\ USART1-GTPR (read-write)
: USART1-GTPR_GT   ( %XXXXXXXX -- ) 8 lshift USART1-GTPR bis! ;  \ USART1-GTPR_GT    Guard time value
: USART1-GTPR_PSC   ( %XXXXXXXX -- ) 0 lshift USART1-GTPR bis! ;  \ USART1-GTPR_PSC    Prescaler value

\ USART2-SR ()
: USART2-SR_CTS   %1 9 lshift USART2-SR bis! ;  \ USART2-SR_CTS    CTS flag
: USART2-SR_LBD   %1 8 lshift USART2-SR bis! ;  \ USART2-SR_LBD    LIN break detection flag
: USART2-SR_TXE   %1 7 lshift USART2-SR bis! ;  \ USART2-SR_TXE    Transmit data register
  empty
: USART2-SR_TC   %1 6 lshift USART2-SR bis! ;  \ USART2-SR_TC    Transmission complete
: USART2-SR_RXNE   %1 5 lshift USART2-SR bis! ;  \ USART2-SR_RXNE    Read data register not
  empty
: USART2-SR_IDLE   %1 4 lshift USART2-SR bis! ;  \ USART2-SR_IDLE    IDLE line detected
: USART2-SR_ORE   %1 3 lshift USART2-SR bis! ;  \ USART2-SR_ORE    Overrun error
: USART2-SR_NF   %1 2 lshift USART2-SR bis! ;  \ USART2-SR_NF    Noise detected flag
: USART2-SR_FE   %1 1 lshift USART2-SR bis! ;  \ USART2-SR_FE    Framing error
: USART2-SR_PE   %1 0 lshift USART2-SR bis! ;  \ USART2-SR_PE    Parity error

\ USART2-DR (read-write)
: USART2-DR_DR   ( %XXXXXXXXX -- ) 0 lshift USART2-DR bis! ;  \ USART2-DR_DR    Data value

\ USART2-BRR (read-write)
: USART2-BRR_DIV_Mantissa   ( %XXXXXXXXXXX -- ) 4 lshift USART2-BRR bis! ;  \ USART2-BRR_DIV_Mantissa    mantissa of USARTDIV
: USART2-BRR_DIV_Fraction   ( %XXXX -- ) 0 lshift USART2-BRR bis! ;  \ USART2-BRR_DIV_Fraction    fraction of USARTDIV

\ USART2-CR1 (read-write)
: USART2-CR1_OVER8   %1 15 lshift USART2-CR1 bis! ;  \ USART2-CR1_OVER8    Oversampling mode
: USART2-CR1_UE   %1 13 lshift USART2-CR1 bis! ;  \ USART2-CR1_UE    USART enable
: USART2-CR1_M   %1 12 lshift USART2-CR1 bis! ;  \ USART2-CR1_M    Word length
: USART2-CR1_WAKE   %1 11 lshift USART2-CR1 bis! ;  \ USART2-CR1_WAKE    Wakeup method
: USART2-CR1_PCE   %1 10 lshift USART2-CR1 bis! ;  \ USART2-CR1_PCE    Parity control enable
: USART2-CR1_PS   %1 9 lshift USART2-CR1 bis! ;  \ USART2-CR1_PS    Parity selection
: USART2-CR1_PEIE   %1 8 lshift USART2-CR1 bis! ;  \ USART2-CR1_PEIE    PE interrupt enable
: USART2-CR1_TXEIE   %1 7 lshift USART2-CR1 bis! ;  \ USART2-CR1_TXEIE    TXE interrupt enable
: USART2-CR1_TCIE   %1 6 lshift USART2-CR1 bis! ;  \ USART2-CR1_TCIE    Transmission complete interrupt
  enable
: USART2-CR1_RXNEIE   %1 5 lshift USART2-CR1 bis! ;  \ USART2-CR1_RXNEIE    RXNE interrupt enable
: USART2-CR1_IDLEIE   %1 4 lshift USART2-CR1 bis! ;  \ USART2-CR1_IDLEIE    IDLE interrupt enable
: USART2-CR1_TE   %1 3 lshift USART2-CR1 bis! ;  \ USART2-CR1_TE    Transmitter enable
: USART2-CR1_RE   %1 2 lshift USART2-CR1 bis! ;  \ USART2-CR1_RE    Receiver enable
: USART2-CR1_RWU   %1 1 lshift USART2-CR1 bis! ;  \ USART2-CR1_RWU    Receiver wakeup
: USART2-CR1_SBK   %1 0 lshift USART2-CR1 bis! ;  \ USART2-CR1_SBK    Send break

\ USART2-CR2 (read-write)
: USART2-CR2_LINEN   %1 14 lshift USART2-CR2 bis! ;  \ USART2-CR2_LINEN    LIN mode enable
: USART2-CR2_STOP   ( %XX -- ) 12 lshift USART2-CR2 bis! ;  \ USART2-CR2_STOP    STOP bits
: USART2-CR2_CLKEN   %1 11 lshift USART2-CR2 bis! ;  \ USART2-CR2_CLKEN    Clock enable
: USART2-CR2_CPOL   %1 10 lshift USART2-CR2 bis! ;  \ USART2-CR2_CPOL    Clock polarity
: USART2-CR2_CPHA   %1 9 lshift USART2-CR2 bis! ;  \ USART2-CR2_CPHA    Clock phase
: USART2-CR2_LBCL   %1 8 lshift USART2-CR2 bis! ;  \ USART2-CR2_LBCL    Last bit clock pulse
: USART2-CR2_LBDIE   %1 6 lshift USART2-CR2 bis! ;  \ USART2-CR2_LBDIE    LIN break detection interrupt
  enable
: USART2-CR2_LBDL   %1 5 lshift USART2-CR2 bis! ;  \ USART2-CR2_LBDL    lin break detection length
: USART2-CR2_ADD   ( %XXXX -- ) 0 lshift USART2-CR2 bis! ;  \ USART2-CR2_ADD    Address of the USART node

\ USART2-CR3 (read-write)
: USART2-CR3_ONEBIT   %1 11 lshift USART2-CR3 bis! ;  \ USART2-CR3_ONEBIT    One sample bit method
  enable
: USART2-CR3_CTSIE   %1 10 lshift USART2-CR3 bis! ;  \ USART2-CR3_CTSIE    CTS interrupt enable
: USART2-CR3_CTSE   %1 9 lshift USART2-CR3 bis! ;  \ USART2-CR3_CTSE    CTS enable
: USART2-CR3_RTSE   %1 8 lshift USART2-CR3 bis! ;  \ USART2-CR3_RTSE    RTS enable
: USART2-CR3_DMAT   %1 7 lshift USART2-CR3 bis! ;  \ USART2-CR3_DMAT    DMA enable transmitter
: USART2-CR3_DMAR   %1 6 lshift USART2-CR3 bis! ;  \ USART2-CR3_DMAR    DMA enable receiver
: USART2-CR3_SCEN   %1 5 lshift USART2-CR3 bis! ;  \ USART2-CR3_SCEN    Smartcard mode enable
: USART2-CR3_NACK   %1 4 lshift USART2-CR3 bis! ;  \ USART2-CR3_NACK    Smartcard NACK enable
: USART2-CR3_HDSEL   %1 3 lshift USART2-CR3 bis! ;  \ USART2-CR3_HDSEL    Half-duplex selection
: USART2-CR3_IRLP   %1 2 lshift USART2-CR3 bis! ;  \ USART2-CR3_IRLP    IrDA low-power
: USART2-CR3_IREN   %1 1 lshift USART2-CR3 bis! ;  \ USART2-CR3_IREN    IrDA mode enable
: USART2-CR3_EIE   %1 0 lshift USART2-CR3 bis! ;  \ USART2-CR3_EIE    Error interrupt enable

\ USART2-GTPR (read-write)
: USART2-GTPR_GT   ( %XXXXXXXX -- ) 8 lshift USART2-GTPR bis! ;  \ USART2-GTPR_GT    Guard time value
: USART2-GTPR_PSC   ( %XXXXXXXX -- ) 0 lshift USART2-GTPR bis! ;  \ USART2-GTPR_PSC    Prescaler value

\ USART6-SR ()
: USART6-SR_CTS   %1 9 lshift USART6-SR bis! ;  \ USART6-SR_CTS    CTS flag
: USART6-SR_LBD   %1 8 lshift USART6-SR bis! ;  \ USART6-SR_LBD    LIN break detection flag
: USART6-SR_TXE   %1 7 lshift USART6-SR bis! ;  \ USART6-SR_TXE    Transmit data register
  empty
: USART6-SR_TC   %1 6 lshift USART6-SR bis! ;  \ USART6-SR_TC    Transmission complete
: USART6-SR_RXNE   %1 5 lshift USART6-SR bis! ;  \ USART6-SR_RXNE    Read data register not
  empty
: USART6-SR_IDLE   %1 4 lshift USART6-SR bis! ;  \ USART6-SR_IDLE    IDLE line detected
: USART6-SR_ORE   %1 3 lshift USART6-SR bis! ;  \ USART6-SR_ORE    Overrun error
: USART6-SR_NF   %1 2 lshift USART6-SR bis! ;  \ USART6-SR_NF    Noise detected flag
: USART6-SR_FE   %1 1 lshift USART6-SR bis! ;  \ USART6-SR_FE    Framing error
: USART6-SR_PE   %1 0 lshift USART6-SR bis! ;  \ USART6-SR_PE    Parity error

\ USART6-DR (read-write)
: USART6-DR_DR   ( %XXXXXXXXX -- ) 0 lshift USART6-DR bis! ;  \ USART6-DR_DR    Data value

\ USART6-BRR (read-write)
: USART6-BRR_DIV_Mantissa   ( %XXXXXXXXXXX -- ) 4 lshift USART6-BRR bis! ;  \ USART6-BRR_DIV_Mantissa    mantissa of USARTDIV
: USART6-BRR_DIV_Fraction   ( %XXXX -- ) 0 lshift USART6-BRR bis! ;  \ USART6-BRR_DIV_Fraction    fraction of USARTDIV

\ USART6-CR1 (read-write)
: USART6-CR1_OVER8   %1 15 lshift USART6-CR1 bis! ;  \ USART6-CR1_OVER8    Oversampling mode
: USART6-CR1_UE   %1 13 lshift USART6-CR1 bis! ;  \ USART6-CR1_UE    USART enable
: USART6-CR1_M   %1 12 lshift USART6-CR1 bis! ;  \ USART6-CR1_M    Word length
: USART6-CR1_WAKE   %1 11 lshift USART6-CR1 bis! ;  \ USART6-CR1_WAKE    Wakeup method
: USART6-CR1_PCE   %1 10 lshift USART6-CR1 bis! ;  \ USART6-CR1_PCE    Parity control enable
: USART6-CR1_PS   %1 9 lshift USART6-CR1 bis! ;  \ USART6-CR1_PS    Parity selection
: USART6-CR1_PEIE   %1 8 lshift USART6-CR1 bis! ;  \ USART6-CR1_PEIE    PE interrupt enable
: USART6-CR1_TXEIE   %1 7 lshift USART6-CR1 bis! ;  \ USART6-CR1_TXEIE    TXE interrupt enable
: USART6-CR1_TCIE   %1 6 lshift USART6-CR1 bis! ;  \ USART6-CR1_TCIE    Transmission complete interrupt
  enable
: USART6-CR1_RXNEIE   %1 5 lshift USART6-CR1 bis! ;  \ USART6-CR1_RXNEIE    RXNE interrupt enable
: USART6-CR1_IDLEIE   %1 4 lshift USART6-CR1 bis! ;  \ USART6-CR1_IDLEIE    IDLE interrupt enable
: USART6-CR1_TE   %1 3 lshift USART6-CR1 bis! ;  \ USART6-CR1_TE    Transmitter enable
: USART6-CR1_RE   %1 2 lshift USART6-CR1 bis! ;  \ USART6-CR1_RE    Receiver enable
: USART6-CR1_RWU   %1 1 lshift USART6-CR1 bis! ;  \ USART6-CR1_RWU    Receiver wakeup
: USART6-CR1_SBK   %1 0 lshift USART6-CR1 bis! ;  \ USART6-CR1_SBK    Send break

\ USART6-CR2 (read-write)
: USART6-CR2_LINEN   %1 14 lshift USART6-CR2 bis! ;  \ USART6-CR2_LINEN    LIN mode enable
: USART6-CR2_STOP   ( %XX -- ) 12 lshift USART6-CR2 bis! ;  \ USART6-CR2_STOP    STOP bits
: USART6-CR2_CLKEN   %1 11 lshift USART6-CR2 bis! ;  \ USART6-CR2_CLKEN    Clock enable
: USART6-CR2_CPOL   %1 10 lshift USART6-CR2 bis! ;  \ USART6-CR2_CPOL    Clock polarity
: USART6-CR2_CPHA   %1 9 lshift USART6-CR2 bis! ;  \ USART6-CR2_CPHA    Clock phase
: USART6-CR2_LBCL   %1 8 lshift USART6-CR2 bis! ;  \ USART6-CR2_LBCL    Last bit clock pulse
: USART6-CR2_LBDIE   %1 6 lshift USART6-CR2 bis! ;  \ USART6-CR2_LBDIE    LIN break detection interrupt
  enable
: USART6-CR2_LBDL   %1 5 lshift USART6-CR2 bis! ;  \ USART6-CR2_LBDL    lin break detection length
: USART6-CR2_ADD   ( %XXXX -- ) 0 lshift USART6-CR2 bis! ;  \ USART6-CR2_ADD    Address of the USART node

\ USART6-CR3 (read-write)
: USART6-CR3_ONEBIT   %1 11 lshift USART6-CR3 bis! ;  \ USART6-CR3_ONEBIT    One sample bit method
  enable
: USART6-CR3_CTSIE   %1 10 lshift USART6-CR3 bis! ;  \ USART6-CR3_CTSIE    CTS interrupt enable
: USART6-CR3_CTSE   %1 9 lshift USART6-CR3 bis! ;  \ USART6-CR3_CTSE    CTS enable
: USART6-CR3_RTSE   %1 8 lshift USART6-CR3 bis! ;  \ USART6-CR3_RTSE    RTS enable
: USART6-CR3_DMAT   %1 7 lshift USART6-CR3 bis! ;  \ USART6-CR3_DMAT    DMA enable transmitter
: USART6-CR3_DMAR   %1 6 lshift USART6-CR3 bis! ;  \ USART6-CR3_DMAR    DMA enable receiver
: USART6-CR3_SCEN   %1 5 lshift USART6-CR3 bis! ;  \ USART6-CR3_SCEN    Smartcard mode enable
: USART6-CR3_NACK   %1 4 lshift USART6-CR3 bis! ;  \ USART6-CR3_NACK    Smartcard NACK enable
: USART6-CR3_HDSEL   %1 3 lshift USART6-CR3 bis! ;  \ USART6-CR3_HDSEL    Half-duplex selection
: USART6-CR3_IRLP   %1 2 lshift USART6-CR3 bis! ;  \ USART6-CR3_IRLP    IrDA low-power
: USART6-CR3_IREN   %1 1 lshift USART6-CR3 bis! ;  \ USART6-CR3_IREN    IrDA mode enable
: USART6-CR3_EIE   %1 0 lshift USART6-CR3 bis! ;  \ USART6-CR3_EIE    Error interrupt enable

\ USART6-GTPR (read-write)
: USART6-GTPR_GT   ( %XXXXXXXX -- ) 8 lshift USART6-GTPR bis! ;  \ USART6-GTPR_GT    Guard time value
: USART6-GTPR_PSC   ( %XXXXXXXX -- ) 0 lshift USART6-GTPR bis! ;  \ USART6-GTPR_PSC    Prescaler value

\ WWDG-CR (read-write)
: WWDG-CR_WDGA   %1 7 lshift WWDG-CR bis! ;  \ WWDG-CR_WDGA    Activation bit
: WWDG-CR_T   ( %XXXXXXX -- ) 0 lshift WWDG-CR bis! ;  \ WWDG-CR_T    7-bit counter MSB to LSB

\ WWDG-CFR (read-write)
: WWDG-CFR_EWI   %1 9 lshift WWDG-CFR bis! ;  \ WWDG-CFR_EWI    Early wakeup interrupt
: WWDG-CFR_WDGTB1   %1 8 lshift WWDG-CFR bis! ;  \ WWDG-CFR_WDGTB1    Timer base
: WWDG-CFR_WDGTB0   %1 7 lshift WWDG-CFR bis! ;  \ WWDG-CFR_WDGTB0    Timer base
: WWDG-CFR_W   ( %XXXXXXX -- ) 0 lshift WWDG-CFR bis! ;  \ WWDG-CFR_W    7-bit window value

\ WWDG-SR (read-write)
: WWDG-SR_EWIF   %1 0 lshift WWDG-SR bis! ;  \ WWDG-SR_EWIF    Early wakeup interrupt
  flag

\ DMA2-LISR (read-only)
: DMA2-LISR_TCIF3   %1 27 lshift DMA2-LISR bis! ;  \ DMA2-LISR_TCIF3    Stream x transfer complete interrupt
  flag x = 3..0
: DMA2-LISR_HTIF3   %1 26 lshift DMA2-LISR bis! ;  \ DMA2-LISR_HTIF3    Stream x half transfer interrupt flag
  x=3..0
: DMA2-LISR_TEIF3   %1 25 lshift DMA2-LISR bis! ;  \ DMA2-LISR_TEIF3    Stream x transfer error interrupt flag
  x=3..0
: DMA2-LISR_DMEIF3   %1 24 lshift DMA2-LISR bis! ;  \ DMA2-LISR_DMEIF3    Stream x direct mode error interrupt
  flag x=3..0
: DMA2-LISR_FEIF3   %1 22 lshift DMA2-LISR bis! ;  \ DMA2-LISR_FEIF3    Stream x FIFO error interrupt flag
  x=3..0
: DMA2-LISR_TCIF2   %1 21 lshift DMA2-LISR bis! ;  \ DMA2-LISR_TCIF2    Stream x transfer complete interrupt
  flag x = 3..0
: DMA2-LISR_HTIF2   %1 20 lshift DMA2-LISR bis! ;  \ DMA2-LISR_HTIF2    Stream x half transfer interrupt flag
  x=3..0
: DMA2-LISR_TEIF2   %1 19 lshift DMA2-LISR bis! ;  \ DMA2-LISR_TEIF2    Stream x transfer error interrupt flag
  x=3..0
: DMA2-LISR_DMEIF2   %1 18 lshift DMA2-LISR bis! ;  \ DMA2-LISR_DMEIF2    Stream x direct mode error interrupt
  flag x=3..0
: DMA2-LISR_FEIF2   %1 16 lshift DMA2-LISR bis! ;  \ DMA2-LISR_FEIF2    Stream x FIFO error interrupt flag
  x=3..0
: DMA2-LISR_TCIF1   %1 11 lshift DMA2-LISR bis! ;  \ DMA2-LISR_TCIF1    Stream x transfer complete interrupt
  flag x = 3..0
: DMA2-LISR_HTIF1   %1 10 lshift DMA2-LISR bis! ;  \ DMA2-LISR_HTIF1    Stream x half transfer interrupt flag
  x=3..0
: DMA2-LISR_TEIF1   %1 9 lshift DMA2-LISR bis! ;  \ DMA2-LISR_TEIF1    Stream x transfer error interrupt flag
  x=3..0
: DMA2-LISR_DMEIF1   %1 8 lshift DMA2-LISR bis! ;  \ DMA2-LISR_DMEIF1    Stream x direct mode error interrupt
  flag x=3..0
: DMA2-LISR_FEIF1   %1 6 lshift DMA2-LISR bis! ;  \ DMA2-LISR_FEIF1    Stream x FIFO error interrupt flag
  x=3..0
: DMA2-LISR_TCIF0   %1 5 lshift DMA2-LISR bis! ;  \ DMA2-LISR_TCIF0    Stream x transfer complete interrupt
  flag x = 3..0
: DMA2-LISR_HTIF0   %1 4 lshift DMA2-LISR bis! ;  \ DMA2-LISR_HTIF0    Stream x half transfer interrupt flag
  x=3..0
: DMA2-LISR_TEIF0   %1 3 lshift DMA2-LISR bis! ;  \ DMA2-LISR_TEIF0    Stream x transfer error interrupt flag
  x=3..0
: DMA2-LISR_DMEIF0   %1 2 lshift DMA2-LISR bis! ;  \ DMA2-LISR_DMEIF0    Stream x direct mode error interrupt
  flag x=3..0
: DMA2-LISR_FEIF0   %1 0 lshift DMA2-LISR bis! ;  \ DMA2-LISR_FEIF0    Stream x FIFO error interrupt flag
  x=3..0

\ DMA2-HISR (read-only)
: DMA2-HISR_TCIF7   %1 27 lshift DMA2-HISR bis! ;  \ DMA2-HISR_TCIF7    Stream x transfer complete interrupt
  flag x=7..4
: DMA2-HISR_HTIF7   %1 26 lshift DMA2-HISR bis! ;  \ DMA2-HISR_HTIF7    Stream x half transfer interrupt flag
  x=7..4
: DMA2-HISR_TEIF7   %1 25 lshift DMA2-HISR bis! ;  \ DMA2-HISR_TEIF7    Stream x transfer error interrupt flag
  x=7..4
: DMA2-HISR_DMEIF7   %1 24 lshift DMA2-HISR bis! ;  \ DMA2-HISR_DMEIF7    Stream x direct mode error interrupt
  flag x=7..4
: DMA2-HISR_FEIF7   %1 22 lshift DMA2-HISR bis! ;  \ DMA2-HISR_FEIF7    Stream x FIFO error interrupt flag
  x=7..4
: DMA2-HISR_TCIF6   %1 21 lshift DMA2-HISR bis! ;  \ DMA2-HISR_TCIF6    Stream x transfer complete interrupt
  flag x=7..4
: DMA2-HISR_HTIF6   %1 20 lshift DMA2-HISR bis! ;  \ DMA2-HISR_HTIF6    Stream x half transfer interrupt flag
  x=7..4
: DMA2-HISR_TEIF6   %1 19 lshift DMA2-HISR bis! ;  \ DMA2-HISR_TEIF6    Stream x transfer error interrupt flag
  x=7..4
: DMA2-HISR_DMEIF6   %1 18 lshift DMA2-HISR bis! ;  \ DMA2-HISR_DMEIF6    Stream x direct mode error interrupt
  flag x=7..4
: DMA2-HISR_FEIF6   %1 16 lshift DMA2-HISR bis! ;  \ DMA2-HISR_FEIF6    Stream x FIFO error interrupt flag
  x=7..4
: DMA2-HISR_TCIF5   %1 11 lshift DMA2-HISR bis! ;  \ DMA2-HISR_TCIF5    Stream x transfer complete interrupt
  flag x=7..4
: DMA2-HISR_HTIF5   %1 10 lshift DMA2-HISR bis! ;  \ DMA2-HISR_HTIF5    Stream x half transfer interrupt flag
  x=7..4
: DMA2-HISR_TEIF5   %1 9 lshift DMA2-HISR bis! ;  \ DMA2-HISR_TEIF5    Stream x transfer error interrupt flag
  x=7..4
: DMA2-HISR_DMEIF5   %1 8 lshift DMA2-HISR bis! ;  \ DMA2-HISR_DMEIF5    Stream x direct mode error interrupt
  flag x=7..4
: DMA2-HISR_FEIF5   %1 6 lshift DMA2-HISR bis! ;  \ DMA2-HISR_FEIF5    Stream x FIFO error interrupt flag
  x=7..4
: DMA2-HISR_TCIF4   %1 5 lshift DMA2-HISR bis! ;  \ DMA2-HISR_TCIF4    Stream x transfer complete interrupt
  flag x=7..4
: DMA2-HISR_HTIF4   %1 4 lshift DMA2-HISR bis! ;  \ DMA2-HISR_HTIF4    Stream x half transfer interrupt flag
  x=7..4
: DMA2-HISR_TEIF4   %1 3 lshift DMA2-HISR bis! ;  \ DMA2-HISR_TEIF4    Stream x transfer error interrupt flag
  x=7..4
: DMA2-HISR_DMEIF4   %1 2 lshift DMA2-HISR bis! ;  \ DMA2-HISR_DMEIF4    Stream x direct mode error interrupt
  flag x=7..4
: DMA2-HISR_FEIF4   %1 0 lshift DMA2-HISR bis! ;  \ DMA2-HISR_FEIF4    Stream x FIFO error interrupt flag
  x=7..4

\ DMA2-LIFCR (write-only)
: DMA2-LIFCR_CTCIF3   %1 27 lshift DMA2-LIFCR bis! ;  \ DMA2-LIFCR_CTCIF3    Stream x clear transfer complete
  interrupt flag x = 3..0
: DMA2-LIFCR_CHTIF3   %1 26 lshift DMA2-LIFCR bis! ;  \ DMA2-LIFCR_CHTIF3    Stream x clear half transfer interrupt
  flag x = 3..0
: DMA2-LIFCR_CTEIF3   %1 25 lshift DMA2-LIFCR bis! ;  \ DMA2-LIFCR_CTEIF3    Stream x clear transfer error interrupt
  flag x = 3..0
: DMA2-LIFCR_CDMEIF3   %1 24 lshift DMA2-LIFCR bis! ;  \ DMA2-LIFCR_CDMEIF3    Stream x clear direct mode error
  interrupt flag x = 3..0
: DMA2-LIFCR_CFEIF3   %1 22 lshift DMA2-LIFCR bis! ;  \ DMA2-LIFCR_CFEIF3    Stream x clear FIFO error interrupt flag
  x = 3..0
: DMA2-LIFCR_CTCIF2   %1 21 lshift DMA2-LIFCR bis! ;  \ DMA2-LIFCR_CTCIF2    Stream x clear transfer complete
  interrupt flag x = 3..0
: DMA2-LIFCR_CHTIF2   %1 20 lshift DMA2-LIFCR bis! ;  \ DMA2-LIFCR_CHTIF2    Stream x clear half transfer interrupt
  flag x = 3..0
: DMA2-LIFCR_CTEIF2   %1 19 lshift DMA2-LIFCR bis! ;  \ DMA2-LIFCR_CTEIF2    Stream x clear transfer error interrupt
  flag x = 3..0
: DMA2-LIFCR_CDMEIF2   %1 18 lshift DMA2-LIFCR bis! ;  \ DMA2-LIFCR_CDMEIF2    Stream x clear direct mode error
  interrupt flag x = 3..0
: DMA2-LIFCR_CFEIF2   %1 16 lshift DMA2-LIFCR bis! ;  \ DMA2-LIFCR_CFEIF2    Stream x clear FIFO error interrupt flag
  x = 3..0
: DMA2-LIFCR_CTCIF1   %1 11 lshift DMA2-LIFCR bis! ;  \ DMA2-LIFCR_CTCIF1    Stream x clear transfer complete
  interrupt flag x = 3..0
: DMA2-LIFCR_CHTIF1   %1 10 lshift DMA2-LIFCR bis! ;  \ DMA2-LIFCR_CHTIF1    Stream x clear half transfer interrupt
  flag x = 3..0
: DMA2-LIFCR_CTEIF1   %1 9 lshift DMA2-LIFCR bis! ;  \ DMA2-LIFCR_CTEIF1    Stream x clear transfer error interrupt
  flag x = 3..0
: DMA2-LIFCR_CDMEIF1   %1 8 lshift DMA2-LIFCR bis! ;  \ DMA2-LIFCR_CDMEIF1    Stream x clear direct mode error
  interrupt flag x = 3..0
: DMA2-LIFCR_CFEIF1   %1 6 lshift DMA2-LIFCR bis! ;  \ DMA2-LIFCR_CFEIF1    Stream x clear FIFO error interrupt flag
  x = 3..0
: DMA2-LIFCR_CTCIF0   %1 5 lshift DMA2-LIFCR bis! ;  \ DMA2-LIFCR_CTCIF0    Stream x clear transfer complete
  interrupt flag x = 3..0
: DMA2-LIFCR_CHTIF0   %1 4 lshift DMA2-LIFCR bis! ;  \ DMA2-LIFCR_CHTIF0    Stream x clear half transfer interrupt
  flag x = 3..0
: DMA2-LIFCR_CTEIF0   %1 3 lshift DMA2-LIFCR bis! ;  \ DMA2-LIFCR_CTEIF0    Stream x clear transfer error interrupt
  flag x = 3..0
: DMA2-LIFCR_CDMEIF0   %1 2 lshift DMA2-LIFCR bis! ;  \ DMA2-LIFCR_CDMEIF0    Stream x clear direct mode error
  interrupt flag x = 3..0
: DMA2-LIFCR_CFEIF0   %1 0 lshift DMA2-LIFCR bis! ;  \ DMA2-LIFCR_CFEIF0    Stream x clear FIFO error interrupt flag
  x = 3..0

\ DMA2-HIFCR (write-only)
: DMA2-HIFCR_CTCIF7   %1 27 lshift DMA2-HIFCR bis! ;  \ DMA2-HIFCR_CTCIF7    Stream x clear transfer complete
  interrupt flag x = 7..4
: DMA2-HIFCR_CHTIF7   %1 26 lshift DMA2-HIFCR bis! ;  \ DMA2-HIFCR_CHTIF7    Stream x clear half transfer interrupt
  flag x = 7..4
: DMA2-HIFCR_CTEIF7   %1 25 lshift DMA2-HIFCR bis! ;  \ DMA2-HIFCR_CTEIF7    Stream x clear transfer error interrupt
  flag x = 7..4
: DMA2-HIFCR_CDMEIF7   %1 24 lshift DMA2-HIFCR bis! ;  \ DMA2-HIFCR_CDMEIF7    Stream x clear direct mode error
  interrupt flag x = 7..4
: DMA2-HIFCR_CFEIF7   %1 22 lshift DMA2-HIFCR bis! ;  \ DMA2-HIFCR_CFEIF7    Stream x clear FIFO error interrupt flag
  x = 7..4
: DMA2-HIFCR_CTCIF6   %1 21 lshift DMA2-HIFCR bis! ;  \ DMA2-HIFCR_CTCIF6    Stream x clear transfer complete
  interrupt flag x = 7..4
: DMA2-HIFCR_CHTIF6   %1 20 lshift DMA2-HIFCR bis! ;  \ DMA2-HIFCR_CHTIF6    Stream x clear half transfer interrupt
  flag x = 7..4
: DMA2-HIFCR_CTEIF6   %1 19 lshift DMA2-HIFCR bis! ;  \ DMA2-HIFCR_CTEIF6    Stream x clear transfer error interrupt
  flag x = 7..4
: DMA2-HIFCR_CDMEIF6   %1 18 lshift DMA2-HIFCR bis! ;  \ DMA2-HIFCR_CDMEIF6    Stream x clear direct mode error
  interrupt flag x = 7..4
: DMA2-HIFCR_CFEIF6   %1 16 lshift DMA2-HIFCR bis! ;  \ DMA2-HIFCR_CFEIF6    Stream x clear FIFO error interrupt flag
  x = 7..4
: DMA2-HIFCR_CTCIF5   %1 11 lshift DMA2-HIFCR bis! ;  \ DMA2-HIFCR_CTCIF5    Stream x clear transfer complete
  interrupt flag x = 7..4
: DMA2-HIFCR_CHTIF5   %1 10 lshift DMA2-HIFCR bis! ;  \ DMA2-HIFCR_CHTIF5    Stream x clear half transfer interrupt
  flag x = 7..4
: DMA2-HIFCR_CTEIF5   %1 9 lshift DMA2-HIFCR bis! ;  \ DMA2-HIFCR_CTEIF5    Stream x clear transfer error interrupt
  flag x = 7..4
: DMA2-HIFCR_CDMEIF5   %1 8 lshift DMA2-HIFCR bis! ;  \ DMA2-HIFCR_CDMEIF5    Stream x clear direct mode error
  interrupt flag x = 7..4
: DMA2-HIFCR_CFEIF5   %1 6 lshift DMA2-HIFCR bis! ;  \ DMA2-HIFCR_CFEIF5    Stream x clear FIFO error interrupt flag
  x = 7..4
: DMA2-HIFCR_CTCIF4   %1 5 lshift DMA2-HIFCR bis! ;  \ DMA2-HIFCR_CTCIF4    Stream x clear transfer complete
  interrupt flag x = 7..4
: DMA2-HIFCR_CHTIF4   %1 4 lshift DMA2-HIFCR bis! ;  \ DMA2-HIFCR_CHTIF4    Stream x clear half transfer interrupt
  flag x = 7..4
: DMA2-HIFCR_CTEIF4   %1 3 lshift DMA2-HIFCR bis! ;  \ DMA2-HIFCR_CTEIF4    Stream x clear transfer error interrupt
  flag x = 7..4
: DMA2-HIFCR_CDMEIF4   %1 2 lshift DMA2-HIFCR bis! ;  \ DMA2-HIFCR_CDMEIF4    Stream x clear direct mode error
  interrupt flag x = 7..4
: DMA2-HIFCR_CFEIF4   %1 0 lshift DMA2-HIFCR bis! ;  \ DMA2-HIFCR_CFEIF4    Stream x clear FIFO error interrupt flag
  x = 7..4

\ DMA2-S0CR (read-write)
: DMA2-S0CR_CHSEL   ( %XXX -- ) 25 lshift DMA2-S0CR bis! ;  \ DMA2-S0CR_CHSEL    Channel selection
: DMA2-S0CR_MBURST   ( %XX -- ) 23 lshift DMA2-S0CR bis! ;  \ DMA2-S0CR_MBURST    Memory burst transfer
  configuration
: DMA2-S0CR_PBURST   ( %XX -- ) 21 lshift DMA2-S0CR bis! ;  \ DMA2-S0CR_PBURST    Peripheral burst transfer
  configuration
: DMA2-S0CR_CT   %1 19 lshift DMA2-S0CR bis! ;  \ DMA2-S0CR_CT    Current target only in double buffer
  mode
: DMA2-S0CR_DBM   %1 18 lshift DMA2-S0CR bis! ;  \ DMA2-S0CR_DBM    Double buffer mode
: DMA2-S0CR_PL   ( %XX -- ) 16 lshift DMA2-S0CR bis! ;  \ DMA2-S0CR_PL    Priority level
: DMA2-S0CR_PINCOS   %1 15 lshift DMA2-S0CR bis! ;  \ DMA2-S0CR_PINCOS    Peripheral increment offset
  size
: DMA2-S0CR_MSIZE   ( %XX -- ) 13 lshift DMA2-S0CR bis! ;  \ DMA2-S0CR_MSIZE    Memory data size
: DMA2-S0CR_PSIZE   ( %XX -- ) 11 lshift DMA2-S0CR bis! ;  \ DMA2-S0CR_PSIZE    Peripheral data size
: DMA2-S0CR_MINC   %1 10 lshift DMA2-S0CR bis! ;  \ DMA2-S0CR_MINC    Memory increment mode
: DMA2-S0CR_PINC   %1 9 lshift DMA2-S0CR bis! ;  \ DMA2-S0CR_PINC    Peripheral increment mode
: DMA2-S0CR_CIRC   %1 8 lshift DMA2-S0CR bis! ;  \ DMA2-S0CR_CIRC    Circular mode
: DMA2-S0CR_DIR   ( %XX -- ) 6 lshift DMA2-S0CR bis! ;  \ DMA2-S0CR_DIR    Data transfer direction
: DMA2-S0CR_PFCTRL   %1 5 lshift DMA2-S0CR bis! ;  \ DMA2-S0CR_PFCTRL    Peripheral flow controller
: DMA2-S0CR_TCIE   %1 4 lshift DMA2-S0CR bis! ;  \ DMA2-S0CR_TCIE    Transfer complete interrupt
  enable
: DMA2-S0CR_HTIE   %1 3 lshift DMA2-S0CR bis! ;  \ DMA2-S0CR_HTIE    Half transfer interrupt
  enable
: DMA2-S0CR_TEIE   %1 2 lshift DMA2-S0CR bis! ;  \ DMA2-S0CR_TEIE    Transfer error interrupt
  enable
: DMA2-S0CR_DMEIE   %1 1 lshift DMA2-S0CR bis! ;  \ DMA2-S0CR_DMEIE    Direct mode error interrupt
  enable
: DMA2-S0CR_EN   %1 0 lshift DMA2-S0CR bis! ;  \ DMA2-S0CR_EN    Stream enable / flag stream ready when
  read low

\ DMA2-S0NDTR (read-write)
: DMA2-S0NDTR_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-S0NDTR bis! ;  \ DMA2-S0NDTR_NDT    Number of data items to
  transfer

\ DMA2-S0PAR (read-write)
: DMA2-S0PAR_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-S0PAR bis! ;  \ DMA2-S0PAR_PA    Peripheral address

\ DMA2-S0M0AR (read-write)
: DMA2-S0M0AR_M0A   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-S0M0AR bis! ;  \ DMA2-S0M0AR_M0A    Memory 0 address

\ DMA2-S0M1AR (read-write)
: DMA2-S0M1AR_M1A   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-S0M1AR bis! ;  \ DMA2-S0M1AR_M1A    Memory 1 address used in case of Double
  buffer mode

\ DMA2-S0FCR ()
: DMA2-S0FCR_FEIE   %1 7 lshift DMA2-S0FCR bis! ;  \ DMA2-S0FCR_FEIE    FIFO error interrupt
  enable
: DMA2-S0FCR_FS   ( %XXX -- ) 3 lshift DMA2-S0FCR bis! ;  \ DMA2-S0FCR_FS    FIFO status
: DMA2-S0FCR_DMDIS   %1 2 lshift DMA2-S0FCR bis! ;  \ DMA2-S0FCR_DMDIS    Direct mode disable
: DMA2-S0FCR_FTH   ( %XX -- ) 0 lshift DMA2-S0FCR bis! ;  \ DMA2-S0FCR_FTH    FIFO threshold selection

\ DMA2-S1CR (read-write)
: DMA2-S1CR_CHSEL   ( %XXX -- ) 25 lshift DMA2-S1CR bis! ;  \ DMA2-S1CR_CHSEL    Channel selection
: DMA2-S1CR_MBURST   ( %XX -- ) 23 lshift DMA2-S1CR bis! ;  \ DMA2-S1CR_MBURST    Memory burst transfer
  configuration
: DMA2-S1CR_PBURST   ( %XX -- ) 21 lshift DMA2-S1CR bis! ;  \ DMA2-S1CR_PBURST    Peripheral burst transfer
  configuration
: DMA2-S1CR_ACK   %1 20 lshift DMA2-S1CR bis! ;  \ DMA2-S1CR_ACK    ACK
: DMA2-S1CR_CT   %1 19 lshift DMA2-S1CR bis! ;  \ DMA2-S1CR_CT    Current target only in double buffer
  mode
: DMA2-S1CR_DBM   %1 18 lshift DMA2-S1CR bis! ;  \ DMA2-S1CR_DBM    Double buffer mode
: DMA2-S1CR_PL   ( %XX -- ) 16 lshift DMA2-S1CR bis! ;  \ DMA2-S1CR_PL    Priority level
: DMA2-S1CR_PINCOS   %1 15 lshift DMA2-S1CR bis! ;  \ DMA2-S1CR_PINCOS    Peripheral increment offset
  size
: DMA2-S1CR_MSIZE   ( %XX -- ) 13 lshift DMA2-S1CR bis! ;  \ DMA2-S1CR_MSIZE    Memory data size
: DMA2-S1CR_PSIZE   ( %XX -- ) 11 lshift DMA2-S1CR bis! ;  \ DMA2-S1CR_PSIZE    Peripheral data size
: DMA2-S1CR_MINC   %1 10 lshift DMA2-S1CR bis! ;  \ DMA2-S1CR_MINC    Memory increment mode
: DMA2-S1CR_PINC   %1 9 lshift DMA2-S1CR bis! ;  \ DMA2-S1CR_PINC    Peripheral increment mode
: DMA2-S1CR_CIRC   %1 8 lshift DMA2-S1CR bis! ;  \ DMA2-S1CR_CIRC    Circular mode
: DMA2-S1CR_DIR   ( %XX -- ) 6 lshift DMA2-S1CR bis! ;  \ DMA2-S1CR_DIR    Data transfer direction
: DMA2-S1CR_PFCTRL   %1 5 lshift DMA2-S1CR bis! ;  \ DMA2-S1CR_PFCTRL    Peripheral flow controller
: DMA2-S1CR_TCIE   %1 4 lshift DMA2-S1CR bis! ;  \ DMA2-S1CR_TCIE    Transfer complete interrupt
  enable
: DMA2-S1CR_HTIE   %1 3 lshift DMA2-S1CR bis! ;  \ DMA2-S1CR_HTIE    Half transfer interrupt
  enable
: DMA2-S1CR_TEIE   %1 2 lshift DMA2-S1CR bis! ;  \ DMA2-S1CR_TEIE    Transfer error interrupt
  enable
: DMA2-S1CR_DMEIE   %1 1 lshift DMA2-S1CR bis! ;  \ DMA2-S1CR_DMEIE    Direct mode error interrupt
  enable
: DMA2-S1CR_EN   %1 0 lshift DMA2-S1CR bis! ;  \ DMA2-S1CR_EN    Stream enable / flag stream ready when
  read low

\ DMA2-S1NDTR (read-write)
: DMA2-S1NDTR_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-S1NDTR bis! ;  \ DMA2-S1NDTR_NDT    Number of data items to
  transfer

\ DMA2-S1PAR (read-write)
: DMA2-S1PAR_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-S1PAR bis! ;  \ DMA2-S1PAR_PA    Peripheral address

\ DMA2-S1M0AR (read-write)
: DMA2-S1M0AR_M0A   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-S1M0AR bis! ;  \ DMA2-S1M0AR_M0A    Memory 0 address

\ DMA2-S1M1AR (read-write)
: DMA2-S1M1AR_M1A   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-S1M1AR bis! ;  \ DMA2-S1M1AR_M1A    Memory 1 address used in case of Double
  buffer mode

\ DMA2-S1FCR ()
: DMA2-S1FCR_FEIE   %1 7 lshift DMA2-S1FCR bis! ;  \ DMA2-S1FCR_FEIE    FIFO error interrupt
  enable
: DMA2-S1FCR_FS   ( %XXX -- ) 3 lshift DMA2-S1FCR bis! ;  \ DMA2-S1FCR_FS    FIFO status
: DMA2-S1FCR_DMDIS   %1 2 lshift DMA2-S1FCR bis! ;  \ DMA2-S1FCR_DMDIS    Direct mode disable
: DMA2-S1FCR_FTH   ( %XX -- ) 0 lshift DMA2-S1FCR bis! ;  \ DMA2-S1FCR_FTH    FIFO threshold selection

\ DMA2-S2CR (read-write)
: DMA2-S2CR_CHSEL   ( %XXX -- ) 25 lshift DMA2-S2CR bis! ;  \ DMA2-S2CR_CHSEL    Channel selection
: DMA2-S2CR_MBURST   ( %XX -- ) 23 lshift DMA2-S2CR bis! ;  \ DMA2-S2CR_MBURST    Memory burst transfer
  configuration
: DMA2-S2CR_PBURST   ( %XX -- ) 21 lshift DMA2-S2CR bis! ;  \ DMA2-S2CR_PBURST    Peripheral burst transfer
  configuration
: DMA2-S2CR_ACK   %1 20 lshift DMA2-S2CR bis! ;  \ DMA2-S2CR_ACK    ACK
: DMA2-S2CR_CT   %1 19 lshift DMA2-S2CR bis! ;  \ DMA2-S2CR_CT    Current target only in double buffer
  mode
: DMA2-S2CR_DBM   %1 18 lshift DMA2-S2CR bis! ;  \ DMA2-S2CR_DBM    Double buffer mode
: DMA2-S2CR_PL   ( %XX -- ) 16 lshift DMA2-S2CR bis! ;  \ DMA2-S2CR_PL    Priority level
: DMA2-S2CR_PINCOS   %1 15 lshift DMA2-S2CR bis! ;  \ DMA2-S2CR_PINCOS    Peripheral increment offset
  size
: DMA2-S2CR_MSIZE   ( %XX -- ) 13 lshift DMA2-S2CR bis! ;  \ DMA2-S2CR_MSIZE    Memory data size
: DMA2-S2CR_PSIZE   ( %XX -- ) 11 lshift DMA2-S2CR bis! ;  \ DMA2-S2CR_PSIZE    Peripheral data size
: DMA2-S2CR_MINC   %1 10 lshift DMA2-S2CR bis! ;  \ DMA2-S2CR_MINC    Memory increment mode
: DMA2-S2CR_PINC   %1 9 lshift DMA2-S2CR bis! ;  \ DMA2-S2CR_PINC    Peripheral increment mode
: DMA2-S2CR_CIRC   %1 8 lshift DMA2-S2CR bis! ;  \ DMA2-S2CR_CIRC    Circular mode
: DMA2-S2CR_DIR   ( %XX -- ) 6 lshift DMA2-S2CR bis! ;  \ DMA2-S2CR_DIR    Data transfer direction
: DMA2-S2CR_PFCTRL   %1 5 lshift DMA2-S2CR bis! ;  \ DMA2-S2CR_PFCTRL    Peripheral flow controller
: DMA2-S2CR_TCIE   %1 4 lshift DMA2-S2CR bis! ;  \ DMA2-S2CR_TCIE    Transfer complete interrupt
  enable
: DMA2-S2CR_HTIE   %1 3 lshift DMA2-S2CR bis! ;  \ DMA2-S2CR_HTIE    Half transfer interrupt
  enable
: DMA2-S2CR_TEIE   %1 2 lshift DMA2-S2CR bis! ;  \ DMA2-S2CR_TEIE    Transfer error interrupt
  enable
: DMA2-S2CR_DMEIE   %1 1 lshift DMA2-S2CR bis! ;  \ DMA2-S2CR_DMEIE    Direct mode error interrupt
  enable
: DMA2-S2CR_EN   %1 0 lshift DMA2-S2CR bis! ;  \ DMA2-S2CR_EN    Stream enable / flag stream ready when
  read low

\ DMA2-S2NDTR (read-write)
: DMA2-S2NDTR_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-S2NDTR bis! ;  \ DMA2-S2NDTR_NDT    Number of data items to
  transfer

\ DMA2-S2PAR (read-write)
: DMA2-S2PAR_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-S2PAR bis! ;  \ DMA2-S2PAR_PA    Peripheral address

\ DMA2-S2M0AR (read-write)
: DMA2-S2M0AR_M0A   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-S2M0AR bis! ;  \ DMA2-S2M0AR_M0A    Memory 0 address

\ DMA2-S2M1AR (read-write)
: DMA2-S2M1AR_M1A   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-S2M1AR bis! ;  \ DMA2-S2M1AR_M1A    Memory 1 address used in case of Double
  buffer mode

\ DMA2-S2FCR ()
: DMA2-S2FCR_FEIE   %1 7 lshift DMA2-S2FCR bis! ;  \ DMA2-S2FCR_FEIE    FIFO error interrupt
  enable
: DMA2-S2FCR_FS   ( %XXX -- ) 3 lshift DMA2-S2FCR bis! ;  \ DMA2-S2FCR_FS    FIFO status
: DMA2-S2FCR_DMDIS   %1 2 lshift DMA2-S2FCR bis! ;  \ DMA2-S2FCR_DMDIS    Direct mode disable
: DMA2-S2FCR_FTH   ( %XX -- ) 0 lshift DMA2-S2FCR bis! ;  \ DMA2-S2FCR_FTH    FIFO threshold selection

\ DMA2-S3CR (read-write)
: DMA2-S3CR_CHSEL   ( %XXX -- ) 25 lshift DMA2-S3CR bis! ;  \ DMA2-S3CR_CHSEL    Channel selection
: DMA2-S3CR_MBURST   ( %XX -- ) 23 lshift DMA2-S3CR bis! ;  \ DMA2-S3CR_MBURST    Memory burst transfer
  configuration
: DMA2-S3CR_PBURST   ( %XX -- ) 21 lshift DMA2-S3CR bis! ;  \ DMA2-S3CR_PBURST    Peripheral burst transfer
  configuration
: DMA2-S3CR_ACK   %1 20 lshift DMA2-S3CR bis! ;  \ DMA2-S3CR_ACK    ACK
: DMA2-S3CR_CT   %1 19 lshift DMA2-S3CR bis! ;  \ DMA2-S3CR_CT    Current target only in double buffer
  mode
: DMA2-S3CR_DBM   %1 18 lshift DMA2-S3CR bis! ;  \ DMA2-S3CR_DBM    Double buffer mode
: DMA2-S3CR_PL   ( %XX -- ) 16 lshift DMA2-S3CR bis! ;  \ DMA2-S3CR_PL    Priority level
: DMA2-S3CR_PINCOS   %1 15 lshift DMA2-S3CR bis! ;  \ DMA2-S3CR_PINCOS    Peripheral increment offset
  size
: DMA2-S3CR_MSIZE   ( %XX -- ) 13 lshift DMA2-S3CR bis! ;  \ DMA2-S3CR_MSIZE    Memory data size
: DMA2-S3CR_PSIZE   ( %XX -- ) 11 lshift DMA2-S3CR bis! ;  \ DMA2-S3CR_PSIZE    Peripheral data size
: DMA2-S3CR_MINC   %1 10 lshift DMA2-S3CR bis! ;  \ DMA2-S3CR_MINC    Memory increment mode
: DMA2-S3CR_PINC   %1 9 lshift DMA2-S3CR bis! ;  \ DMA2-S3CR_PINC    Peripheral increment mode
: DMA2-S3CR_CIRC   %1 8 lshift DMA2-S3CR bis! ;  \ DMA2-S3CR_CIRC    Circular mode
: DMA2-S3CR_DIR   ( %XX -- ) 6 lshift DMA2-S3CR bis! ;  \ DMA2-S3CR_DIR    Data transfer direction
: DMA2-S3CR_PFCTRL   %1 5 lshift DMA2-S3CR bis! ;  \ DMA2-S3CR_PFCTRL    Peripheral flow controller
: DMA2-S3CR_TCIE   %1 4 lshift DMA2-S3CR bis! ;  \ DMA2-S3CR_TCIE    Transfer complete interrupt
  enable
: DMA2-S3CR_HTIE   %1 3 lshift DMA2-S3CR bis! ;  \ DMA2-S3CR_HTIE    Half transfer interrupt
  enable
: DMA2-S3CR_TEIE   %1 2 lshift DMA2-S3CR bis! ;  \ DMA2-S3CR_TEIE    Transfer error interrupt
  enable
: DMA2-S3CR_DMEIE   %1 1 lshift DMA2-S3CR bis! ;  \ DMA2-S3CR_DMEIE    Direct mode error interrupt
  enable
: DMA2-S3CR_EN   %1 0 lshift DMA2-S3CR bis! ;  \ DMA2-S3CR_EN    Stream enable / flag stream ready when
  read low

\ DMA2-S3NDTR (read-write)
: DMA2-S3NDTR_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-S3NDTR bis! ;  \ DMA2-S3NDTR_NDT    Number of data items to
  transfer

\ DMA2-S3PAR (read-write)
: DMA2-S3PAR_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-S3PAR bis! ;  \ DMA2-S3PAR_PA    Peripheral address

\ DMA2-S3M0AR (read-write)
: DMA2-S3M0AR_M0A   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-S3M0AR bis! ;  \ DMA2-S3M0AR_M0A    Memory 0 address

\ DMA2-S3M1AR (read-write)
: DMA2-S3M1AR_M1A   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-S3M1AR bis! ;  \ DMA2-S3M1AR_M1A    Memory 1 address used in case of Double
  buffer mode

\ DMA2-S3FCR ()
: DMA2-S3FCR_FEIE   %1 7 lshift DMA2-S3FCR bis! ;  \ DMA2-S3FCR_FEIE    FIFO error interrupt
  enable
: DMA2-S3FCR_FS   ( %XXX -- ) 3 lshift DMA2-S3FCR bis! ;  \ DMA2-S3FCR_FS    FIFO status
: DMA2-S3FCR_DMDIS   %1 2 lshift DMA2-S3FCR bis! ;  \ DMA2-S3FCR_DMDIS    Direct mode disable
: DMA2-S3FCR_FTH   ( %XX -- ) 0 lshift DMA2-S3FCR bis! ;  \ DMA2-S3FCR_FTH    FIFO threshold selection

\ DMA2-S4CR (read-write)
: DMA2-S4CR_CHSEL   ( %XXX -- ) 25 lshift DMA2-S4CR bis! ;  \ DMA2-S4CR_CHSEL    Channel selection
: DMA2-S4CR_MBURST   ( %XX -- ) 23 lshift DMA2-S4CR bis! ;  \ DMA2-S4CR_MBURST    Memory burst transfer
  configuration
: DMA2-S4CR_PBURST   ( %XX -- ) 21 lshift DMA2-S4CR bis! ;  \ DMA2-S4CR_PBURST    Peripheral burst transfer
  configuration
: DMA2-S4CR_ACK   %1 20 lshift DMA2-S4CR bis! ;  \ DMA2-S4CR_ACK    ACK
: DMA2-S4CR_CT   %1 19 lshift DMA2-S4CR bis! ;  \ DMA2-S4CR_CT    Current target only in double buffer
  mode
: DMA2-S4CR_DBM   %1 18 lshift DMA2-S4CR bis! ;  \ DMA2-S4CR_DBM    Double buffer mode
: DMA2-S4CR_PL   ( %XX -- ) 16 lshift DMA2-S4CR bis! ;  \ DMA2-S4CR_PL    Priority level
: DMA2-S4CR_PINCOS   %1 15 lshift DMA2-S4CR bis! ;  \ DMA2-S4CR_PINCOS    Peripheral increment offset
  size
: DMA2-S4CR_MSIZE   ( %XX -- ) 13 lshift DMA2-S4CR bis! ;  \ DMA2-S4CR_MSIZE    Memory data size
: DMA2-S4CR_PSIZE   ( %XX -- ) 11 lshift DMA2-S4CR bis! ;  \ DMA2-S4CR_PSIZE    Peripheral data size
: DMA2-S4CR_MINC   %1 10 lshift DMA2-S4CR bis! ;  \ DMA2-S4CR_MINC    Memory increment mode
: DMA2-S4CR_PINC   %1 9 lshift DMA2-S4CR bis! ;  \ DMA2-S4CR_PINC    Peripheral increment mode
: DMA2-S4CR_CIRC   %1 8 lshift DMA2-S4CR bis! ;  \ DMA2-S4CR_CIRC    Circular mode
: DMA2-S4CR_DIR   ( %XX -- ) 6 lshift DMA2-S4CR bis! ;  \ DMA2-S4CR_DIR    Data transfer direction
: DMA2-S4CR_PFCTRL   %1 5 lshift DMA2-S4CR bis! ;  \ DMA2-S4CR_PFCTRL    Peripheral flow controller
: DMA2-S4CR_TCIE   %1 4 lshift DMA2-S4CR bis! ;  \ DMA2-S4CR_TCIE    Transfer complete interrupt
  enable
: DMA2-S4CR_HTIE   %1 3 lshift DMA2-S4CR bis! ;  \ DMA2-S4CR_HTIE    Half transfer interrupt
  enable
: DMA2-S4CR_TEIE   %1 2 lshift DMA2-S4CR bis! ;  \ DMA2-S4CR_TEIE    Transfer error interrupt
  enable
: DMA2-S4CR_DMEIE   %1 1 lshift DMA2-S4CR bis! ;  \ DMA2-S4CR_DMEIE    Direct mode error interrupt
  enable
: DMA2-S4CR_EN   %1 0 lshift DMA2-S4CR bis! ;  \ DMA2-S4CR_EN    Stream enable / flag stream ready when
  read low

\ DMA2-S4NDTR (read-write)
: DMA2-S4NDTR_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-S4NDTR bis! ;  \ DMA2-S4NDTR_NDT    Number of data items to
  transfer

\ DMA2-S4PAR (read-write)
: DMA2-S4PAR_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-S4PAR bis! ;  \ DMA2-S4PAR_PA    Peripheral address

\ DMA2-S4M0AR (read-write)
: DMA2-S4M0AR_M0A   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-S4M0AR bis! ;  \ DMA2-S4M0AR_M0A    Memory 0 address

\ DMA2-S4M1AR (read-write)
: DMA2-S4M1AR_M1A   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-S4M1AR bis! ;  \ DMA2-S4M1AR_M1A    Memory 1 address used in case of Double
  buffer mode

\ DMA2-S4FCR ()
: DMA2-S4FCR_FEIE   %1 7 lshift DMA2-S4FCR bis! ;  \ DMA2-S4FCR_FEIE    FIFO error interrupt
  enable
: DMA2-S4FCR_FS   ( %XXX -- ) 3 lshift DMA2-S4FCR bis! ;  \ DMA2-S4FCR_FS    FIFO status
: DMA2-S4FCR_DMDIS   %1 2 lshift DMA2-S4FCR bis! ;  \ DMA2-S4FCR_DMDIS    Direct mode disable
: DMA2-S4FCR_FTH   ( %XX -- ) 0 lshift DMA2-S4FCR bis! ;  \ DMA2-S4FCR_FTH    FIFO threshold selection

\ DMA2-S5CR (read-write)
: DMA2-S5CR_CHSEL   ( %XXX -- ) 25 lshift DMA2-S5CR bis! ;  \ DMA2-S5CR_CHSEL    Channel selection
: DMA2-S5CR_MBURST   ( %XX -- ) 23 lshift DMA2-S5CR bis! ;  \ DMA2-S5CR_MBURST    Memory burst transfer
  configuration
: DMA2-S5CR_PBURST   ( %XX -- ) 21 lshift DMA2-S5CR bis! ;  \ DMA2-S5CR_PBURST    Peripheral burst transfer
  configuration
: DMA2-S5CR_ACK   %1 20 lshift DMA2-S5CR bis! ;  \ DMA2-S5CR_ACK    ACK
: DMA2-S5CR_CT   %1 19 lshift DMA2-S5CR bis! ;  \ DMA2-S5CR_CT    Current target only in double buffer
  mode
: DMA2-S5CR_DBM   %1 18 lshift DMA2-S5CR bis! ;  \ DMA2-S5CR_DBM    Double buffer mode
: DMA2-S5CR_PL   ( %XX -- ) 16 lshift DMA2-S5CR bis! ;  \ DMA2-S5CR_PL    Priority level
: DMA2-S5CR_PINCOS   %1 15 lshift DMA2-S5CR bis! ;  \ DMA2-S5CR_PINCOS    Peripheral increment offset
  size
: DMA2-S5CR_MSIZE   ( %XX -- ) 13 lshift DMA2-S5CR bis! ;  \ DMA2-S5CR_MSIZE    Memory data size
: DMA2-S5CR_PSIZE   ( %XX -- ) 11 lshift DMA2-S5CR bis! ;  \ DMA2-S5CR_PSIZE    Peripheral data size
: DMA2-S5CR_MINC   %1 10 lshift DMA2-S5CR bis! ;  \ DMA2-S5CR_MINC    Memory increment mode
: DMA2-S5CR_PINC   %1 9 lshift DMA2-S5CR bis! ;  \ DMA2-S5CR_PINC    Peripheral increment mode
: DMA2-S5CR_CIRC   %1 8 lshift DMA2-S5CR bis! ;  \ DMA2-S5CR_CIRC    Circular mode
: DMA2-S5CR_DIR   ( %XX -- ) 6 lshift DMA2-S5CR bis! ;  \ DMA2-S5CR_DIR    Data transfer direction
: DMA2-S5CR_PFCTRL   %1 5 lshift DMA2-S5CR bis! ;  \ DMA2-S5CR_PFCTRL    Peripheral flow controller
: DMA2-S5CR_TCIE   %1 4 lshift DMA2-S5CR bis! ;  \ DMA2-S5CR_TCIE    Transfer complete interrupt
  enable
: DMA2-S5CR_HTIE   %1 3 lshift DMA2-S5CR bis! ;  \ DMA2-S5CR_HTIE    Half transfer interrupt
  enable
: DMA2-S5CR_TEIE   %1 2 lshift DMA2-S5CR bis! ;  \ DMA2-S5CR_TEIE    Transfer error interrupt
  enable
: DMA2-S5CR_DMEIE   %1 1 lshift DMA2-S5CR bis! ;  \ DMA2-S5CR_DMEIE    Direct mode error interrupt
  enable
: DMA2-S5CR_EN   %1 0 lshift DMA2-S5CR bis! ;  \ DMA2-S5CR_EN    Stream enable / flag stream ready when
  read low

\ DMA2-S5NDTR (read-write)
: DMA2-S5NDTR_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-S5NDTR bis! ;  \ DMA2-S5NDTR_NDT    Number of data items to
  transfer

\ DMA2-S5PAR (read-write)
: DMA2-S5PAR_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-S5PAR bis! ;  \ DMA2-S5PAR_PA    Peripheral address

\ DMA2-S5M0AR (read-write)
: DMA2-S5M0AR_M0A   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-S5M0AR bis! ;  \ DMA2-S5M0AR_M0A    Memory 0 address

\ DMA2-S5M1AR (read-write)
: DMA2-S5M1AR_M1A   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-S5M1AR bis! ;  \ DMA2-S5M1AR_M1A    Memory 1 address used in case of Double
  buffer mode

\ DMA2-S5FCR ()
: DMA2-S5FCR_FEIE   %1 7 lshift DMA2-S5FCR bis! ;  \ DMA2-S5FCR_FEIE    FIFO error interrupt
  enable
: DMA2-S5FCR_FS   ( %XXX -- ) 3 lshift DMA2-S5FCR bis! ;  \ DMA2-S5FCR_FS    FIFO status
: DMA2-S5FCR_DMDIS   %1 2 lshift DMA2-S5FCR bis! ;  \ DMA2-S5FCR_DMDIS    Direct mode disable
: DMA2-S5FCR_FTH   ( %XX -- ) 0 lshift DMA2-S5FCR bis! ;  \ DMA2-S5FCR_FTH    FIFO threshold selection

\ DMA2-S6CR (read-write)
: DMA2-S6CR_CHSEL   ( %XXX -- ) 25 lshift DMA2-S6CR bis! ;  \ DMA2-S6CR_CHSEL    Channel selection
: DMA2-S6CR_MBURST   ( %XX -- ) 23 lshift DMA2-S6CR bis! ;  \ DMA2-S6CR_MBURST    Memory burst transfer
  configuration
: DMA2-S6CR_PBURST   ( %XX -- ) 21 lshift DMA2-S6CR bis! ;  \ DMA2-S6CR_PBURST    Peripheral burst transfer
  configuration
: DMA2-S6CR_ACK   %1 20 lshift DMA2-S6CR bis! ;  \ DMA2-S6CR_ACK    ACK
: DMA2-S6CR_CT   %1 19 lshift DMA2-S6CR bis! ;  \ DMA2-S6CR_CT    Current target only in double buffer
  mode
: DMA2-S6CR_DBM   %1 18 lshift DMA2-S6CR bis! ;  \ DMA2-S6CR_DBM    Double buffer mode
: DMA2-S6CR_PL   ( %XX -- ) 16 lshift DMA2-S6CR bis! ;  \ DMA2-S6CR_PL    Priority level
: DMA2-S6CR_PINCOS   %1 15 lshift DMA2-S6CR bis! ;  \ DMA2-S6CR_PINCOS    Peripheral increment offset
  size
: DMA2-S6CR_MSIZE   ( %XX -- ) 13 lshift DMA2-S6CR bis! ;  \ DMA2-S6CR_MSIZE    Memory data size
: DMA2-S6CR_PSIZE   ( %XX -- ) 11 lshift DMA2-S6CR bis! ;  \ DMA2-S6CR_PSIZE    Peripheral data size
: DMA2-S6CR_MINC   %1 10 lshift DMA2-S6CR bis! ;  \ DMA2-S6CR_MINC    Memory increment mode
: DMA2-S6CR_PINC   %1 9 lshift DMA2-S6CR bis! ;  \ DMA2-S6CR_PINC    Peripheral increment mode
: DMA2-S6CR_CIRC   %1 8 lshift DMA2-S6CR bis! ;  \ DMA2-S6CR_CIRC    Circular mode
: DMA2-S6CR_DIR   ( %XX -- ) 6 lshift DMA2-S6CR bis! ;  \ DMA2-S6CR_DIR    Data transfer direction
: DMA2-S6CR_PFCTRL   %1 5 lshift DMA2-S6CR bis! ;  \ DMA2-S6CR_PFCTRL    Peripheral flow controller
: DMA2-S6CR_TCIE   %1 4 lshift DMA2-S6CR bis! ;  \ DMA2-S6CR_TCIE    Transfer complete interrupt
  enable
: DMA2-S6CR_HTIE   %1 3 lshift DMA2-S6CR bis! ;  \ DMA2-S6CR_HTIE    Half transfer interrupt
  enable
: DMA2-S6CR_TEIE   %1 2 lshift DMA2-S6CR bis! ;  \ DMA2-S6CR_TEIE    Transfer error interrupt
  enable
: DMA2-S6CR_DMEIE   %1 1 lshift DMA2-S6CR bis! ;  \ DMA2-S6CR_DMEIE    Direct mode error interrupt
  enable
: DMA2-S6CR_EN   %1 0 lshift DMA2-S6CR bis! ;  \ DMA2-S6CR_EN    Stream enable / flag stream ready when
  read low

\ DMA2-S6NDTR (read-write)
: DMA2-S6NDTR_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-S6NDTR bis! ;  \ DMA2-S6NDTR_NDT    Number of data items to
  transfer

\ DMA2-S6PAR (read-write)
: DMA2-S6PAR_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-S6PAR bis! ;  \ DMA2-S6PAR_PA    Peripheral address

\ DMA2-S6M0AR (read-write)
: DMA2-S6M0AR_M0A   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-S6M0AR bis! ;  \ DMA2-S6M0AR_M0A    Memory 0 address

\ DMA2-S6M1AR (read-write)
: DMA2-S6M1AR_M1A   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-S6M1AR bis! ;  \ DMA2-S6M1AR_M1A    Memory 1 address used in case of Double
  buffer mode

\ DMA2-S6FCR ()
: DMA2-S6FCR_FEIE   %1 7 lshift DMA2-S6FCR bis! ;  \ DMA2-S6FCR_FEIE    FIFO error interrupt
  enable
: DMA2-S6FCR_FS   ( %XXX -- ) 3 lshift DMA2-S6FCR bis! ;  \ DMA2-S6FCR_FS    FIFO status
: DMA2-S6FCR_DMDIS   %1 2 lshift DMA2-S6FCR bis! ;  \ DMA2-S6FCR_DMDIS    Direct mode disable
: DMA2-S6FCR_FTH   ( %XX -- ) 0 lshift DMA2-S6FCR bis! ;  \ DMA2-S6FCR_FTH    FIFO threshold selection

\ DMA2-S7CR (read-write)
: DMA2-S7CR_CHSEL   ( %XXX -- ) 25 lshift DMA2-S7CR bis! ;  \ DMA2-S7CR_CHSEL    Channel selection
: DMA2-S7CR_MBURST   ( %XX -- ) 23 lshift DMA2-S7CR bis! ;  \ DMA2-S7CR_MBURST    Memory burst transfer
  configuration
: DMA2-S7CR_PBURST   ( %XX -- ) 21 lshift DMA2-S7CR bis! ;  \ DMA2-S7CR_PBURST    Peripheral burst transfer
  configuration
: DMA2-S7CR_ACK   %1 20 lshift DMA2-S7CR bis! ;  \ DMA2-S7CR_ACK    ACK
: DMA2-S7CR_CT   %1 19 lshift DMA2-S7CR bis! ;  \ DMA2-S7CR_CT    Current target only in double buffer
  mode
: DMA2-S7CR_DBM   %1 18 lshift DMA2-S7CR bis! ;  \ DMA2-S7CR_DBM    Double buffer mode
: DMA2-S7CR_PL   ( %XX -- ) 16 lshift DMA2-S7CR bis! ;  \ DMA2-S7CR_PL    Priority level
: DMA2-S7CR_PINCOS   %1 15 lshift DMA2-S7CR bis! ;  \ DMA2-S7CR_PINCOS    Peripheral increment offset
  size
: DMA2-S7CR_MSIZE   ( %XX -- ) 13 lshift DMA2-S7CR bis! ;  \ DMA2-S7CR_MSIZE    Memory data size
: DMA2-S7CR_PSIZE   ( %XX -- ) 11 lshift DMA2-S7CR bis! ;  \ DMA2-S7CR_PSIZE    Peripheral data size
: DMA2-S7CR_MINC   %1 10 lshift DMA2-S7CR bis! ;  \ DMA2-S7CR_MINC    Memory increment mode
: DMA2-S7CR_PINC   %1 9 lshift DMA2-S7CR bis! ;  \ DMA2-S7CR_PINC    Peripheral increment mode
: DMA2-S7CR_CIRC   %1 8 lshift DMA2-S7CR bis! ;  \ DMA2-S7CR_CIRC    Circular mode
: DMA2-S7CR_DIR   ( %XX -- ) 6 lshift DMA2-S7CR bis! ;  \ DMA2-S7CR_DIR    Data transfer direction
: DMA2-S7CR_PFCTRL   %1 5 lshift DMA2-S7CR bis! ;  \ DMA2-S7CR_PFCTRL    Peripheral flow controller
: DMA2-S7CR_TCIE   %1 4 lshift DMA2-S7CR bis! ;  \ DMA2-S7CR_TCIE    Transfer complete interrupt
  enable
: DMA2-S7CR_HTIE   %1 3 lshift DMA2-S7CR bis! ;  \ DMA2-S7CR_HTIE    Half transfer interrupt
  enable
: DMA2-S7CR_TEIE   %1 2 lshift DMA2-S7CR bis! ;  \ DMA2-S7CR_TEIE    Transfer error interrupt
  enable
: DMA2-S7CR_DMEIE   %1 1 lshift DMA2-S7CR bis! ;  \ DMA2-S7CR_DMEIE    Direct mode error interrupt
  enable
: DMA2-S7CR_EN   %1 0 lshift DMA2-S7CR bis! ;  \ DMA2-S7CR_EN    Stream enable / flag stream ready when
  read low

\ DMA2-S7NDTR (read-write)
: DMA2-S7NDTR_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-S7NDTR bis! ;  \ DMA2-S7NDTR_NDT    Number of data items to
  transfer

\ DMA2-S7PAR (read-write)
: DMA2-S7PAR_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-S7PAR bis! ;  \ DMA2-S7PAR_PA    Peripheral address

\ DMA2-S7M0AR (read-write)
: DMA2-S7M0AR_M0A   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-S7M0AR bis! ;  \ DMA2-S7M0AR_M0A    Memory 0 address

\ DMA2-S7M1AR (read-write)
: DMA2-S7M1AR_M1A   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-S7M1AR bis! ;  \ DMA2-S7M1AR_M1A    Memory 1 address used in case of Double
  buffer mode

\ DMA2-S7FCR ()
: DMA2-S7FCR_FEIE   %1 7 lshift DMA2-S7FCR bis! ;  \ DMA2-S7FCR_FEIE    FIFO error interrupt
  enable
: DMA2-S7FCR_FS   ( %XXX -- ) 3 lshift DMA2-S7FCR bis! ;  \ DMA2-S7FCR_FS    FIFO status
: DMA2-S7FCR_DMDIS   %1 2 lshift DMA2-S7FCR bis! ;  \ DMA2-S7FCR_DMDIS    Direct mode disable
: DMA2-S7FCR_FTH   ( %XX -- ) 0 lshift DMA2-S7FCR bis! ;  \ DMA2-S7FCR_FTH    FIFO threshold selection

\ DMA1-LISR (read-only)
: DMA1-LISR_TCIF3   %1 27 lshift DMA1-LISR bis! ;  \ DMA1-LISR_TCIF3    Stream x transfer complete interrupt
  flag x = 3..0
: DMA1-LISR_HTIF3   %1 26 lshift DMA1-LISR bis! ;  \ DMA1-LISR_HTIF3    Stream x half transfer interrupt flag
  x=3..0
: DMA1-LISR_TEIF3   %1 25 lshift DMA1-LISR bis! ;  \ DMA1-LISR_TEIF3    Stream x transfer error interrupt flag
  x=3..0
: DMA1-LISR_DMEIF3   %1 24 lshift DMA1-LISR bis! ;  \ DMA1-LISR_DMEIF3    Stream x direct mode error interrupt
  flag x=3..0
: DMA1-LISR_FEIF3   %1 22 lshift DMA1-LISR bis! ;  \ DMA1-LISR_FEIF3    Stream x FIFO error interrupt flag
  x=3..0
: DMA1-LISR_TCIF2   %1 21 lshift DMA1-LISR bis! ;  \ DMA1-LISR_TCIF2    Stream x transfer complete interrupt
  flag x = 3..0
: DMA1-LISR_HTIF2   %1 20 lshift DMA1-LISR bis! ;  \ DMA1-LISR_HTIF2    Stream x half transfer interrupt flag
  x=3..0
: DMA1-LISR_TEIF2   %1 19 lshift DMA1-LISR bis! ;  \ DMA1-LISR_TEIF2    Stream x transfer error interrupt flag
  x=3..0
: DMA1-LISR_DMEIF2   %1 18 lshift DMA1-LISR bis! ;  \ DMA1-LISR_DMEIF2    Stream x direct mode error interrupt
  flag x=3..0
: DMA1-LISR_FEIF2   %1 16 lshift DMA1-LISR bis! ;  \ DMA1-LISR_FEIF2    Stream x FIFO error interrupt flag
  x=3..0
: DMA1-LISR_TCIF1   %1 11 lshift DMA1-LISR bis! ;  \ DMA1-LISR_TCIF1    Stream x transfer complete interrupt
  flag x = 3..0
: DMA1-LISR_HTIF1   %1 10 lshift DMA1-LISR bis! ;  \ DMA1-LISR_HTIF1    Stream x half transfer interrupt flag
  x=3..0
: DMA1-LISR_TEIF1   %1 9 lshift DMA1-LISR bis! ;  \ DMA1-LISR_TEIF1    Stream x transfer error interrupt flag
  x=3..0
: DMA1-LISR_DMEIF1   %1 8 lshift DMA1-LISR bis! ;  \ DMA1-LISR_DMEIF1    Stream x direct mode error interrupt
  flag x=3..0
: DMA1-LISR_FEIF1   %1 6 lshift DMA1-LISR bis! ;  \ DMA1-LISR_FEIF1    Stream x FIFO error interrupt flag
  x=3..0
: DMA1-LISR_TCIF0   %1 5 lshift DMA1-LISR bis! ;  \ DMA1-LISR_TCIF0    Stream x transfer complete interrupt
  flag x = 3..0
: DMA1-LISR_HTIF0   %1 4 lshift DMA1-LISR bis! ;  \ DMA1-LISR_HTIF0    Stream x half transfer interrupt flag
  x=3..0
: DMA1-LISR_TEIF0   %1 3 lshift DMA1-LISR bis! ;  \ DMA1-LISR_TEIF0    Stream x transfer error interrupt flag
  x=3..0
: DMA1-LISR_DMEIF0   %1 2 lshift DMA1-LISR bis! ;  \ DMA1-LISR_DMEIF0    Stream x direct mode error interrupt
  flag x=3..0
: DMA1-LISR_FEIF0   %1 0 lshift DMA1-LISR bis! ;  \ DMA1-LISR_FEIF0    Stream x FIFO error interrupt flag
  x=3..0

\ DMA1-HISR (read-only)
: DMA1-HISR_TCIF7   %1 27 lshift DMA1-HISR bis! ;  \ DMA1-HISR_TCIF7    Stream x transfer complete interrupt
  flag x=7..4
: DMA1-HISR_HTIF7   %1 26 lshift DMA1-HISR bis! ;  \ DMA1-HISR_HTIF7    Stream x half transfer interrupt flag
  x=7..4
: DMA1-HISR_TEIF7   %1 25 lshift DMA1-HISR bis! ;  \ DMA1-HISR_TEIF7    Stream x transfer error interrupt flag
  x=7..4
: DMA1-HISR_DMEIF7   %1 24 lshift DMA1-HISR bis! ;  \ DMA1-HISR_DMEIF7    Stream x direct mode error interrupt
  flag x=7..4
: DMA1-HISR_FEIF7   %1 22 lshift DMA1-HISR bis! ;  \ DMA1-HISR_FEIF7    Stream x FIFO error interrupt flag
  x=7..4
: DMA1-HISR_TCIF6   %1 21 lshift DMA1-HISR bis! ;  \ DMA1-HISR_TCIF6    Stream x transfer complete interrupt
  flag x=7..4
: DMA1-HISR_HTIF6   %1 20 lshift DMA1-HISR bis! ;  \ DMA1-HISR_HTIF6    Stream x half transfer interrupt flag
  x=7..4
: DMA1-HISR_TEIF6   %1 19 lshift DMA1-HISR bis! ;  \ DMA1-HISR_TEIF6    Stream x transfer error interrupt flag
  x=7..4
: DMA1-HISR_DMEIF6   %1 18 lshift DMA1-HISR bis! ;  \ DMA1-HISR_DMEIF6    Stream x direct mode error interrupt
  flag x=7..4
: DMA1-HISR_FEIF6   %1 16 lshift DMA1-HISR bis! ;  \ DMA1-HISR_FEIF6    Stream x FIFO error interrupt flag
  x=7..4
: DMA1-HISR_TCIF5   %1 11 lshift DMA1-HISR bis! ;  \ DMA1-HISR_TCIF5    Stream x transfer complete interrupt
  flag x=7..4
: DMA1-HISR_HTIF5   %1 10 lshift DMA1-HISR bis! ;  \ DMA1-HISR_HTIF5    Stream x half transfer interrupt flag
  x=7..4
: DMA1-HISR_TEIF5   %1 9 lshift DMA1-HISR bis! ;  \ DMA1-HISR_TEIF5    Stream x transfer error interrupt flag
  x=7..4
: DMA1-HISR_DMEIF5   %1 8 lshift DMA1-HISR bis! ;  \ DMA1-HISR_DMEIF5    Stream x direct mode error interrupt
  flag x=7..4
: DMA1-HISR_FEIF5   %1 6 lshift DMA1-HISR bis! ;  \ DMA1-HISR_FEIF5    Stream x FIFO error interrupt flag
  x=7..4
: DMA1-HISR_TCIF4   %1 5 lshift DMA1-HISR bis! ;  \ DMA1-HISR_TCIF4    Stream x transfer complete interrupt
  flag x=7..4
: DMA1-HISR_HTIF4   %1 4 lshift DMA1-HISR bis! ;  \ DMA1-HISR_HTIF4    Stream x half transfer interrupt flag
  x=7..4
: DMA1-HISR_TEIF4   %1 3 lshift DMA1-HISR bis! ;  \ DMA1-HISR_TEIF4    Stream x transfer error interrupt flag
  x=7..4
: DMA1-HISR_DMEIF4   %1 2 lshift DMA1-HISR bis! ;  \ DMA1-HISR_DMEIF4    Stream x direct mode error interrupt
  flag x=7..4
: DMA1-HISR_FEIF4   %1 0 lshift DMA1-HISR bis! ;  \ DMA1-HISR_FEIF4    Stream x FIFO error interrupt flag
  x=7..4

\ DMA1-LIFCR (write-only)
: DMA1-LIFCR_CTCIF3   %1 27 lshift DMA1-LIFCR bis! ;  \ DMA1-LIFCR_CTCIF3    Stream x clear transfer complete
  interrupt flag x = 3..0
: DMA1-LIFCR_CHTIF3   %1 26 lshift DMA1-LIFCR bis! ;  \ DMA1-LIFCR_CHTIF3    Stream x clear half transfer interrupt
  flag x = 3..0
: DMA1-LIFCR_CTEIF3   %1 25 lshift DMA1-LIFCR bis! ;  \ DMA1-LIFCR_CTEIF3    Stream x clear transfer error interrupt
  flag x = 3..0
: DMA1-LIFCR_CDMEIF3   %1 24 lshift DMA1-LIFCR bis! ;  \ DMA1-LIFCR_CDMEIF3    Stream x clear direct mode error
  interrupt flag x = 3..0
: DMA1-LIFCR_CFEIF3   %1 22 lshift DMA1-LIFCR bis! ;  \ DMA1-LIFCR_CFEIF3    Stream x clear FIFO error interrupt flag
  x = 3..0
: DMA1-LIFCR_CTCIF2   %1 21 lshift DMA1-LIFCR bis! ;  \ DMA1-LIFCR_CTCIF2    Stream x clear transfer complete
  interrupt flag x = 3..0
: DMA1-LIFCR_CHTIF2   %1 20 lshift DMA1-LIFCR bis! ;  \ DMA1-LIFCR_CHTIF2    Stream x clear half transfer interrupt
  flag x = 3..0
: DMA1-LIFCR_CTEIF2   %1 19 lshift DMA1-LIFCR bis! ;  \ DMA1-LIFCR_CTEIF2    Stream x clear transfer error interrupt
  flag x = 3..0
: DMA1-LIFCR_CDMEIF2   %1 18 lshift DMA1-LIFCR bis! ;  \ DMA1-LIFCR_CDMEIF2    Stream x clear direct mode error
  interrupt flag x = 3..0
: DMA1-LIFCR_CFEIF2   %1 16 lshift DMA1-LIFCR bis! ;  \ DMA1-LIFCR_CFEIF2    Stream x clear FIFO error interrupt flag
  x = 3..0
: DMA1-LIFCR_CTCIF1   %1 11 lshift DMA1-LIFCR bis! ;  \ DMA1-LIFCR_CTCIF1    Stream x clear transfer complete
  interrupt flag x = 3..0
: DMA1-LIFCR_CHTIF1   %1 10 lshift DMA1-LIFCR bis! ;  \ DMA1-LIFCR_CHTIF1    Stream x clear half transfer interrupt
  flag x = 3..0
: DMA1-LIFCR_CTEIF1   %1 9 lshift DMA1-LIFCR bis! ;  \ DMA1-LIFCR_CTEIF1    Stream x clear transfer error interrupt
  flag x = 3..0
: DMA1-LIFCR_CDMEIF1   %1 8 lshift DMA1-LIFCR bis! ;  \ DMA1-LIFCR_CDMEIF1    Stream x clear direct mode error
  interrupt flag x = 3..0
: DMA1-LIFCR_CFEIF1   %1 6 lshift DMA1-LIFCR bis! ;  \ DMA1-LIFCR_CFEIF1    Stream x clear FIFO error interrupt flag
  x = 3..0
: DMA1-LIFCR_CTCIF0   %1 5 lshift DMA1-LIFCR bis! ;  \ DMA1-LIFCR_CTCIF0    Stream x clear transfer complete
  interrupt flag x = 3..0
: DMA1-LIFCR_CHTIF0   %1 4 lshift DMA1-LIFCR bis! ;  \ DMA1-LIFCR_CHTIF0    Stream x clear half transfer interrupt
  flag x = 3..0
: DMA1-LIFCR_CTEIF0   %1 3 lshift DMA1-LIFCR bis! ;  \ DMA1-LIFCR_CTEIF0    Stream x clear transfer error interrupt
  flag x = 3..0
: DMA1-LIFCR_CDMEIF0   %1 2 lshift DMA1-LIFCR bis! ;  \ DMA1-LIFCR_CDMEIF0    Stream x clear direct mode error
  interrupt flag x = 3..0
: DMA1-LIFCR_CFEIF0   %1 0 lshift DMA1-LIFCR bis! ;  \ DMA1-LIFCR_CFEIF0    Stream x clear FIFO error interrupt flag
  x = 3..0

\ DMA1-HIFCR (write-only)
: DMA1-HIFCR_CTCIF7   %1 27 lshift DMA1-HIFCR bis! ;  \ DMA1-HIFCR_CTCIF7    Stream x clear transfer complete
  interrupt flag x = 7..4
: DMA1-HIFCR_CHTIF7   %1 26 lshift DMA1-HIFCR bis! ;  \ DMA1-HIFCR_CHTIF7    Stream x clear half transfer interrupt
  flag x = 7..4
: DMA1-HIFCR_CTEIF7   %1 25 lshift DMA1-HIFCR bis! ;  \ DMA1-HIFCR_CTEIF7    Stream x clear transfer error interrupt
  flag x = 7..4
: DMA1-HIFCR_CDMEIF7   %1 24 lshift DMA1-HIFCR bis! ;  \ DMA1-HIFCR_CDMEIF7    Stream x clear direct mode error
  interrupt flag x = 7..4
: DMA1-HIFCR_CFEIF7   %1 22 lshift DMA1-HIFCR bis! ;  \ DMA1-HIFCR_CFEIF7    Stream x clear FIFO error interrupt flag
  x = 7..4
: DMA1-HIFCR_CTCIF6   %1 21 lshift DMA1-HIFCR bis! ;  \ DMA1-HIFCR_CTCIF6    Stream x clear transfer complete
  interrupt flag x = 7..4
: DMA1-HIFCR_CHTIF6   %1 20 lshift DMA1-HIFCR bis! ;  \ DMA1-HIFCR_CHTIF6    Stream x clear half transfer interrupt
  flag x = 7..4
: DMA1-HIFCR_CTEIF6   %1 19 lshift DMA1-HIFCR bis! ;  \ DMA1-HIFCR_CTEIF6    Stream x clear transfer error interrupt
  flag x = 7..4
: DMA1-HIFCR_CDMEIF6   %1 18 lshift DMA1-HIFCR bis! ;  \ DMA1-HIFCR_CDMEIF6    Stream x clear direct mode error
  interrupt flag x = 7..4
: DMA1-HIFCR_CFEIF6   %1 16 lshift DMA1-HIFCR bis! ;  \ DMA1-HIFCR_CFEIF6    Stream x clear FIFO error interrupt flag
  x = 7..4
: DMA1-HIFCR_CTCIF5   %1 11 lshift DMA1-HIFCR bis! ;  \ DMA1-HIFCR_CTCIF5    Stream x clear transfer complete
  interrupt flag x = 7..4
: DMA1-HIFCR_CHTIF5   %1 10 lshift DMA1-HIFCR bis! ;  \ DMA1-HIFCR_CHTIF5    Stream x clear half transfer interrupt
  flag x = 7..4
: DMA1-HIFCR_CTEIF5   %1 9 lshift DMA1-HIFCR bis! ;  \ DMA1-HIFCR_CTEIF5    Stream x clear transfer error interrupt
  flag x = 7..4
: DMA1-HIFCR_CDMEIF5   %1 8 lshift DMA1-HIFCR bis! ;  \ DMA1-HIFCR_CDMEIF5    Stream x clear direct mode error
  interrupt flag x = 7..4
: DMA1-HIFCR_CFEIF5   %1 6 lshift DMA1-HIFCR bis! ;  \ DMA1-HIFCR_CFEIF5    Stream x clear FIFO error interrupt flag
  x = 7..4
: DMA1-HIFCR_CTCIF4   %1 5 lshift DMA1-HIFCR bis! ;  \ DMA1-HIFCR_CTCIF4    Stream x clear transfer complete
  interrupt flag x = 7..4
: DMA1-HIFCR_CHTIF4   %1 4 lshift DMA1-HIFCR bis! ;  \ DMA1-HIFCR_CHTIF4    Stream x clear half transfer interrupt
  flag x = 7..4
: DMA1-HIFCR_CTEIF4   %1 3 lshift DMA1-HIFCR bis! ;  \ DMA1-HIFCR_CTEIF4    Stream x clear transfer error interrupt
  flag x = 7..4
: DMA1-HIFCR_CDMEIF4   %1 2 lshift DMA1-HIFCR bis! ;  \ DMA1-HIFCR_CDMEIF4    Stream x clear direct mode error
  interrupt flag x = 7..4
: DMA1-HIFCR_CFEIF4   %1 0 lshift DMA1-HIFCR bis! ;  \ DMA1-HIFCR_CFEIF4    Stream x clear FIFO error interrupt flag
  x = 7..4

\ DMA1-S0CR (read-write)
: DMA1-S0CR_CHSEL   ( %XXX -- ) 25 lshift DMA1-S0CR bis! ;  \ DMA1-S0CR_CHSEL    Channel selection
: DMA1-S0CR_MBURST   ( %XX -- ) 23 lshift DMA1-S0CR bis! ;  \ DMA1-S0CR_MBURST    Memory burst transfer
  configuration
: DMA1-S0CR_PBURST   ( %XX -- ) 21 lshift DMA1-S0CR bis! ;  \ DMA1-S0CR_PBURST    Peripheral burst transfer
  configuration
: DMA1-S0CR_CT   %1 19 lshift DMA1-S0CR bis! ;  \ DMA1-S0CR_CT    Current target only in double buffer
  mode
: DMA1-S0CR_DBM   %1 18 lshift DMA1-S0CR bis! ;  \ DMA1-S0CR_DBM    Double buffer mode
: DMA1-S0CR_PL   ( %XX -- ) 16 lshift DMA1-S0CR bis! ;  \ DMA1-S0CR_PL    Priority level
: DMA1-S0CR_PINCOS   %1 15 lshift DMA1-S0CR bis! ;  \ DMA1-S0CR_PINCOS    Peripheral increment offset
  size
: DMA1-S0CR_MSIZE   ( %XX -- ) 13 lshift DMA1-S0CR bis! ;  \ DMA1-S0CR_MSIZE    Memory data size
: DMA1-S0CR_PSIZE   ( %XX -- ) 11 lshift DMA1-S0CR bis! ;  \ DMA1-S0CR_PSIZE    Peripheral data size
: DMA1-S0CR_MINC   %1 10 lshift DMA1-S0CR bis! ;  \ DMA1-S0CR_MINC    Memory increment mode
: DMA1-S0CR_PINC   %1 9 lshift DMA1-S0CR bis! ;  \ DMA1-S0CR_PINC    Peripheral increment mode
: DMA1-S0CR_CIRC   %1 8 lshift DMA1-S0CR bis! ;  \ DMA1-S0CR_CIRC    Circular mode
: DMA1-S0CR_DIR   ( %XX -- ) 6 lshift DMA1-S0CR bis! ;  \ DMA1-S0CR_DIR    Data transfer direction
: DMA1-S0CR_PFCTRL   %1 5 lshift DMA1-S0CR bis! ;  \ DMA1-S0CR_PFCTRL    Peripheral flow controller
: DMA1-S0CR_TCIE   %1 4 lshift DMA1-S0CR bis! ;  \ DMA1-S0CR_TCIE    Transfer complete interrupt
  enable
: DMA1-S0CR_HTIE   %1 3 lshift DMA1-S0CR bis! ;  \ DMA1-S0CR_HTIE    Half transfer interrupt
  enable
: DMA1-S0CR_TEIE   %1 2 lshift DMA1-S0CR bis! ;  \ DMA1-S0CR_TEIE    Transfer error interrupt
  enable
: DMA1-S0CR_DMEIE   %1 1 lshift DMA1-S0CR bis! ;  \ DMA1-S0CR_DMEIE    Direct mode error interrupt
  enable
: DMA1-S0CR_EN   %1 0 lshift DMA1-S0CR bis! ;  \ DMA1-S0CR_EN    Stream enable / flag stream ready when
  read low

\ DMA1-S0NDTR (read-write)
: DMA1-S0NDTR_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-S0NDTR bis! ;  \ DMA1-S0NDTR_NDT    Number of data items to
  transfer

\ DMA1-S0PAR (read-write)
: DMA1-S0PAR_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-S0PAR bis! ;  \ DMA1-S0PAR_PA    Peripheral address

\ DMA1-S0M0AR (read-write)
: DMA1-S0M0AR_M0A   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-S0M0AR bis! ;  \ DMA1-S0M0AR_M0A    Memory 0 address

\ DMA1-S0M1AR (read-write)
: DMA1-S0M1AR_M1A   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-S0M1AR bis! ;  \ DMA1-S0M1AR_M1A    Memory 1 address used in case of Double
  buffer mode

\ DMA1-S0FCR ()
: DMA1-S0FCR_FEIE   %1 7 lshift DMA1-S0FCR bis! ;  \ DMA1-S0FCR_FEIE    FIFO error interrupt
  enable
: DMA1-S0FCR_FS   ( %XXX -- ) 3 lshift DMA1-S0FCR bis! ;  \ DMA1-S0FCR_FS    FIFO status
: DMA1-S0FCR_DMDIS   %1 2 lshift DMA1-S0FCR bis! ;  \ DMA1-S0FCR_DMDIS    Direct mode disable
: DMA1-S0FCR_FTH   ( %XX -- ) 0 lshift DMA1-S0FCR bis! ;  \ DMA1-S0FCR_FTH    FIFO threshold selection

\ DMA1-S1CR (read-write)
: DMA1-S1CR_CHSEL   ( %XXX -- ) 25 lshift DMA1-S1CR bis! ;  \ DMA1-S1CR_CHSEL    Channel selection
: DMA1-S1CR_MBURST   ( %XX -- ) 23 lshift DMA1-S1CR bis! ;  \ DMA1-S1CR_MBURST    Memory burst transfer
  configuration
: DMA1-S1CR_PBURST   ( %XX -- ) 21 lshift DMA1-S1CR bis! ;  \ DMA1-S1CR_PBURST    Peripheral burst transfer
  configuration
: DMA1-S1CR_ACK   %1 20 lshift DMA1-S1CR bis! ;  \ DMA1-S1CR_ACK    ACK
: DMA1-S1CR_CT   %1 19 lshift DMA1-S1CR bis! ;  \ DMA1-S1CR_CT    Current target only in double buffer
  mode
: DMA1-S1CR_DBM   %1 18 lshift DMA1-S1CR bis! ;  \ DMA1-S1CR_DBM    Double buffer mode
: DMA1-S1CR_PL   ( %XX -- ) 16 lshift DMA1-S1CR bis! ;  \ DMA1-S1CR_PL    Priority level
: DMA1-S1CR_PINCOS   %1 15 lshift DMA1-S1CR bis! ;  \ DMA1-S1CR_PINCOS    Peripheral increment offset
  size
: DMA1-S1CR_MSIZE   ( %XX -- ) 13 lshift DMA1-S1CR bis! ;  \ DMA1-S1CR_MSIZE    Memory data size
: DMA1-S1CR_PSIZE   ( %XX -- ) 11 lshift DMA1-S1CR bis! ;  \ DMA1-S1CR_PSIZE    Peripheral data size
: DMA1-S1CR_MINC   %1 10 lshift DMA1-S1CR bis! ;  \ DMA1-S1CR_MINC    Memory increment mode
: DMA1-S1CR_PINC   %1 9 lshift DMA1-S1CR bis! ;  \ DMA1-S1CR_PINC    Peripheral increment mode
: DMA1-S1CR_CIRC   %1 8 lshift DMA1-S1CR bis! ;  \ DMA1-S1CR_CIRC    Circular mode
: DMA1-S1CR_DIR   ( %XX -- ) 6 lshift DMA1-S1CR bis! ;  \ DMA1-S1CR_DIR    Data transfer direction
: DMA1-S1CR_PFCTRL   %1 5 lshift DMA1-S1CR bis! ;  \ DMA1-S1CR_PFCTRL    Peripheral flow controller
: DMA1-S1CR_TCIE   %1 4 lshift DMA1-S1CR bis! ;  \ DMA1-S1CR_TCIE    Transfer complete interrupt
  enable
: DMA1-S1CR_HTIE   %1 3 lshift DMA1-S1CR bis! ;  \ DMA1-S1CR_HTIE    Half transfer interrupt
  enable
: DMA1-S1CR_TEIE   %1 2 lshift DMA1-S1CR bis! ;  \ DMA1-S1CR_TEIE    Transfer error interrupt
  enable
: DMA1-S1CR_DMEIE   %1 1 lshift DMA1-S1CR bis! ;  \ DMA1-S1CR_DMEIE    Direct mode error interrupt
  enable
: DMA1-S1CR_EN   %1 0 lshift DMA1-S1CR bis! ;  \ DMA1-S1CR_EN    Stream enable / flag stream ready when
  read low

\ DMA1-S1NDTR (read-write)
: DMA1-S1NDTR_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-S1NDTR bis! ;  \ DMA1-S1NDTR_NDT    Number of data items to
  transfer

\ DMA1-S1PAR (read-write)
: DMA1-S1PAR_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-S1PAR bis! ;  \ DMA1-S1PAR_PA    Peripheral address

\ DMA1-S1M0AR (read-write)
: DMA1-S1M0AR_M0A   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-S1M0AR bis! ;  \ DMA1-S1M0AR_M0A    Memory 0 address

\ DMA1-S1M1AR (read-write)
: DMA1-S1M1AR_M1A   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-S1M1AR bis! ;  \ DMA1-S1M1AR_M1A    Memory 1 address used in case of Double
  buffer mode

\ DMA1-S1FCR ()
: DMA1-S1FCR_FEIE   %1 7 lshift DMA1-S1FCR bis! ;  \ DMA1-S1FCR_FEIE    FIFO error interrupt
  enable
: DMA1-S1FCR_FS   ( %XXX -- ) 3 lshift DMA1-S1FCR bis! ;  \ DMA1-S1FCR_FS    FIFO status
: DMA1-S1FCR_DMDIS   %1 2 lshift DMA1-S1FCR bis! ;  \ DMA1-S1FCR_DMDIS    Direct mode disable
: DMA1-S1FCR_FTH   ( %XX -- ) 0 lshift DMA1-S1FCR bis! ;  \ DMA1-S1FCR_FTH    FIFO threshold selection

\ DMA1-S2CR (read-write)
: DMA1-S2CR_CHSEL   ( %XXX -- ) 25 lshift DMA1-S2CR bis! ;  \ DMA1-S2CR_CHSEL    Channel selection
: DMA1-S2CR_MBURST   ( %XX -- ) 23 lshift DMA1-S2CR bis! ;  \ DMA1-S2CR_MBURST    Memory burst transfer
  configuration
: DMA1-S2CR_PBURST   ( %XX -- ) 21 lshift DMA1-S2CR bis! ;  \ DMA1-S2CR_PBURST    Peripheral burst transfer
  configuration
: DMA1-S2CR_ACK   %1 20 lshift DMA1-S2CR bis! ;  \ DMA1-S2CR_ACK    ACK
: DMA1-S2CR_CT   %1 19 lshift DMA1-S2CR bis! ;  \ DMA1-S2CR_CT    Current target only in double buffer
  mode
: DMA1-S2CR_DBM   %1 18 lshift DMA1-S2CR bis! ;  \ DMA1-S2CR_DBM    Double buffer mode
: DMA1-S2CR_PL   ( %XX -- ) 16 lshift DMA1-S2CR bis! ;  \ DMA1-S2CR_PL    Priority level
: DMA1-S2CR_PINCOS   %1 15 lshift DMA1-S2CR bis! ;  \ DMA1-S2CR_PINCOS    Peripheral increment offset
  size
: DMA1-S2CR_MSIZE   ( %XX -- ) 13 lshift DMA1-S2CR bis! ;  \ DMA1-S2CR_MSIZE    Memory data size
: DMA1-S2CR_PSIZE   ( %XX -- ) 11 lshift DMA1-S2CR bis! ;  \ DMA1-S2CR_PSIZE    Peripheral data size
: DMA1-S2CR_MINC   %1 10 lshift DMA1-S2CR bis! ;  \ DMA1-S2CR_MINC    Memory increment mode
: DMA1-S2CR_PINC   %1 9 lshift DMA1-S2CR bis! ;  \ DMA1-S2CR_PINC    Peripheral increment mode
: DMA1-S2CR_CIRC   %1 8 lshift DMA1-S2CR bis! ;  \ DMA1-S2CR_CIRC    Circular mode
: DMA1-S2CR_DIR   ( %XX -- ) 6 lshift DMA1-S2CR bis! ;  \ DMA1-S2CR_DIR    Data transfer direction
: DMA1-S2CR_PFCTRL   %1 5 lshift DMA1-S2CR bis! ;  \ DMA1-S2CR_PFCTRL    Peripheral flow controller
: DMA1-S2CR_TCIE   %1 4 lshift DMA1-S2CR bis! ;  \ DMA1-S2CR_TCIE    Transfer complete interrupt
  enable
: DMA1-S2CR_HTIE   %1 3 lshift DMA1-S2CR bis! ;  \ DMA1-S2CR_HTIE    Half transfer interrupt
  enable
: DMA1-S2CR_TEIE   %1 2 lshift DMA1-S2CR bis! ;  \ DMA1-S2CR_TEIE    Transfer error interrupt
  enable
: DMA1-S2CR_DMEIE   %1 1 lshift DMA1-S2CR bis! ;  \ DMA1-S2CR_DMEIE    Direct mode error interrupt
  enable
: DMA1-S2CR_EN   %1 0 lshift DMA1-S2CR bis! ;  \ DMA1-S2CR_EN    Stream enable / flag stream ready when
  read low

\ DMA1-S2NDTR (read-write)
: DMA1-S2NDTR_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-S2NDTR bis! ;  \ DMA1-S2NDTR_NDT    Number of data items to
  transfer

\ DMA1-S2PAR (read-write)
: DMA1-S2PAR_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-S2PAR bis! ;  \ DMA1-S2PAR_PA    Peripheral address

\ DMA1-S2M0AR (read-write)
: DMA1-S2M0AR_M0A   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-S2M0AR bis! ;  \ DMA1-S2M0AR_M0A    Memory 0 address

\ DMA1-S2M1AR (read-write)
: DMA1-S2M1AR_M1A   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-S2M1AR bis! ;  \ DMA1-S2M1AR_M1A    Memory 1 address used in case of Double
  buffer mode

\ DMA1-S2FCR ()
: DMA1-S2FCR_FEIE   %1 7 lshift DMA1-S2FCR bis! ;  \ DMA1-S2FCR_FEIE    FIFO error interrupt
  enable
: DMA1-S2FCR_FS   ( %XXX -- ) 3 lshift DMA1-S2FCR bis! ;  \ DMA1-S2FCR_FS    FIFO status
: DMA1-S2FCR_DMDIS   %1 2 lshift DMA1-S2FCR bis! ;  \ DMA1-S2FCR_DMDIS    Direct mode disable
: DMA1-S2FCR_FTH   ( %XX -- ) 0 lshift DMA1-S2FCR bis! ;  \ DMA1-S2FCR_FTH    FIFO threshold selection

\ DMA1-S3CR (read-write)
: DMA1-S3CR_CHSEL   ( %XXX -- ) 25 lshift DMA1-S3CR bis! ;  \ DMA1-S3CR_CHSEL    Channel selection
: DMA1-S3CR_MBURST   ( %XX -- ) 23 lshift DMA1-S3CR bis! ;  \ DMA1-S3CR_MBURST    Memory burst transfer
  configuration
: DMA1-S3CR_PBURST   ( %XX -- ) 21 lshift DMA1-S3CR bis! ;  \ DMA1-S3CR_PBURST    Peripheral burst transfer
  configuration
: DMA1-S3CR_ACK   %1 20 lshift DMA1-S3CR bis! ;  \ DMA1-S3CR_ACK    ACK
: DMA1-S3CR_CT   %1 19 lshift DMA1-S3CR bis! ;  \ DMA1-S3CR_CT    Current target only in double buffer
  mode
: DMA1-S3CR_DBM   %1 18 lshift DMA1-S3CR bis! ;  \ DMA1-S3CR_DBM    Double buffer mode
: DMA1-S3CR_PL   ( %XX -- ) 16 lshift DMA1-S3CR bis! ;  \ DMA1-S3CR_PL    Priority level
: DMA1-S3CR_PINCOS   %1 15 lshift DMA1-S3CR bis! ;  \ DMA1-S3CR_PINCOS    Peripheral increment offset
  size
: DMA1-S3CR_MSIZE   ( %XX -- ) 13 lshift DMA1-S3CR bis! ;  \ DMA1-S3CR_MSIZE    Memory data size
: DMA1-S3CR_PSIZE   ( %XX -- ) 11 lshift DMA1-S3CR bis! ;  \ DMA1-S3CR_PSIZE    Peripheral data size
: DMA1-S3CR_MINC   %1 10 lshift DMA1-S3CR bis! ;  \ DMA1-S3CR_MINC    Memory increment mode
: DMA1-S3CR_PINC   %1 9 lshift DMA1-S3CR bis! ;  \ DMA1-S3CR_PINC    Peripheral increment mode
: DMA1-S3CR_CIRC   %1 8 lshift DMA1-S3CR bis! ;  \ DMA1-S3CR_CIRC    Circular mode
: DMA1-S3CR_DIR   ( %XX -- ) 6 lshift DMA1-S3CR bis! ;  \ DMA1-S3CR_DIR    Data transfer direction
: DMA1-S3CR_PFCTRL   %1 5 lshift DMA1-S3CR bis! ;  \ DMA1-S3CR_PFCTRL    Peripheral flow controller
: DMA1-S3CR_TCIE   %1 4 lshift DMA1-S3CR bis! ;  \ DMA1-S3CR_TCIE    Transfer complete interrupt
  enable
: DMA1-S3CR_HTIE   %1 3 lshift DMA1-S3CR bis! ;  \ DMA1-S3CR_HTIE    Half transfer interrupt
  enable
: DMA1-S3CR_TEIE   %1 2 lshift DMA1-S3CR bis! ;  \ DMA1-S3CR_TEIE    Transfer error interrupt
  enable
: DMA1-S3CR_DMEIE   %1 1 lshift DMA1-S3CR bis! ;  \ DMA1-S3CR_DMEIE    Direct mode error interrupt
  enable
: DMA1-S3CR_EN   %1 0 lshift DMA1-S3CR bis! ;  \ DMA1-S3CR_EN    Stream enable / flag stream ready when
  read low

\ DMA1-S3NDTR (read-write)
: DMA1-S3NDTR_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-S3NDTR bis! ;  \ DMA1-S3NDTR_NDT    Number of data items to
  transfer

\ DMA1-S3PAR (read-write)
: DMA1-S3PAR_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-S3PAR bis! ;  \ DMA1-S3PAR_PA    Peripheral address

\ DMA1-S3M0AR (read-write)
: DMA1-S3M0AR_M0A   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-S3M0AR bis! ;  \ DMA1-S3M0AR_M0A    Memory 0 address

\ DMA1-S3M1AR (read-write)
: DMA1-S3M1AR_M1A   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-S3M1AR bis! ;  \ DMA1-S3M1AR_M1A    Memory 1 address used in case of Double
  buffer mode

\ DMA1-S3FCR ()
: DMA1-S3FCR_FEIE   %1 7 lshift DMA1-S3FCR bis! ;  \ DMA1-S3FCR_FEIE    FIFO error interrupt
  enable
: DMA1-S3FCR_FS   ( %XXX -- ) 3 lshift DMA1-S3FCR bis! ;  \ DMA1-S3FCR_FS    FIFO status
: DMA1-S3FCR_DMDIS   %1 2 lshift DMA1-S3FCR bis! ;  \ DMA1-S3FCR_DMDIS    Direct mode disable
: DMA1-S3FCR_FTH   ( %XX -- ) 0 lshift DMA1-S3FCR bis! ;  \ DMA1-S3FCR_FTH    FIFO threshold selection

\ DMA1-S4CR (read-write)
: DMA1-S4CR_CHSEL   ( %XXX -- ) 25 lshift DMA1-S4CR bis! ;  \ DMA1-S4CR_CHSEL    Channel selection
: DMA1-S4CR_MBURST   ( %XX -- ) 23 lshift DMA1-S4CR bis! ;  \ DMA1-S4CR_MBURST    Memory burst transfer
  configuration
: DMA1-S4CR_PBURST   ( %XX -- ) 21 lshift DMA1-S4CR bis! ;  \ DMA1-S4CR_PBURST    Peripheral burst transfer
  configuration
: DMA1-S4CR_ACK   %1 20 lshift DMA1-S4CR bis! ;  \ DMA1-S4CR_ACK    ACK
: DMA1-S4CR_CT   %1 19 lshift DMA1-S4CR bis! ;  \ DMA1-S4CR_CT    Current target only in double buffer
  mode
: DMA1-S4CR_DBM   %1 18 lshift DMA1-S4CR bis! ;  \ DMA1-S4CR_DBM    Double buffer mode
: DMA1-S4CR_PL   ( %XX -- ) 16 lshift DMA1-S4CR bis! ;  \ DMA1-S4CR_PL    Priority level
: DMA1-S4CR_PINCOS   %1 15 lshift DMA1-S4CR bis! ;  \ DMA1-S4CR_PINCOS    Peripheral increment offset
  size
: DMA1-S4CR_MSIZE   ( %XX -- ) 13 lshift DMA1-S4CR bis! ;  \ DMA1-S4CR_MSIZE    Memory data size
: DMA1-S4CR_PSIZE   ( %XX -- ) 11 lshift DMA1-S4CR bis! ;  \ DMA1-S4CR_PSIZE    Peripheral data size
: DMA1-S4CR_MINC   %1 10 lshift DMA1-S4CR bis! ;  \ DMA1-S4CR_MINC    Memory increment mode
: DMA1-S4CR_PINC   %1 9 lshift DMA1-S4CR bis! ;  \ DMA1-S4CR_PINC    Peripheral increment mode
: DMA1-S4CR_CIRC   %1 8 lshift DMA1-S4CR bis! ;  \ DMA1-S4CR_CIRC    Circular mode
: DMA1-S4CR_DIR   ( %XX -- ) 6 lshift DMA1-S4CR bis! ;  \ DMA1-S4CR_DIR    Data transfer direction
: DMA1-S4CR_PFCTRL   %1 5 lshift DMA1-S4CR bis! ;  \ DMA1-S4CR_PFCTRL    Peripheral flow controller
: DMA1-S4CR_TCIE   %1 4 lshift DMA1-S4CR bis! ;  \ DMA1-S4CR_TCIE    Transfer complete interrupt
  enable
: DMA1-S4CR_HTIE   %1 3 lshift DMA1-S4CR bis! ;  \ DMA1-S4CR_HTIE    Half transfer interrupt
  enable
: DMA1-S4CR_TEIE   %1 2 lshift DMA1-S4CR bis! ;  \ DMA1-S4CR_TEIE    Transfer error interrupt
  enable
: DMA1-S4CR_DMEIE   %1 1 lshift DMA1-S4CR bis! ;  \ DMA1-S4CR_DMEIE    Direct mode error interrupt
  enable
: DMA1-S4CR_EN   %1 0 lshift DMA1-S4CR bis! ;  \ DMA1-S4CR_EN    Stream enable / flag stream ready when
  read low

\ DMA1-S4NDTR (read-write)
: DMA1-S4NDTR_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-S4NDTR bis! ;  \ DMA1-S4NDTR_NDT    Number of data items to
  transfer

\ DMA1-S4PAR (read-write)
: DMA1-S4PAR_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-S4PAR bis! ;  \ DMA1-S4PAR_PA    Peripheral address

\ DMA1-S4M0AR (read-write)
: DMA1-S4M0AR_M0A   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-S4M0AR bis! ;  \ DMA1-S4M0AR_M0A    Memory 0 address

\ DMA1-S4M1AR (read-write)
: DMA1-S4M1AR_M1A   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-S4M1AR bis! ;  \ DMA1-S4M1AR_M1A    Memory 1 address used in case of Double
  buffer mode

\ DMA1-S4FCR ()
: DMA1-S4FCR_FEIE   %1 7 lshift DMA1-S4FCR bis! ;  \ DMA1-S4FCR_FEIE    FIFO error interrupt
  enable
: DMA1-S4FCR_FS   ( %XXX -- ) 3 lshift DMA1-S4FCR bis! ;  \ DMA1-S4FCR_FS    FIFO status
: DMA1-S4FCR_DMDIS   %1 2 lshift DMA1-S4FCR bis! ;  \ DMA1-S4FCR_DMDIS    Direct mode disable
: DMA1-S4FCR_FTH   ( %XX -- ) 0 lshift DMA1-S4FCR bis! ;  \ DMA1-S4FCR_FTH    FIFO threshold selection

\ DMA1-S5CR (read-write)
: DMA1-S5CR_CHSEL   ( %XXX -- ) 25 lshift DMA1-S5CR bis! ;  \ DMA1-S5CR_CHSEL    Channel selection
: DMA1-S5CR_MBURST   ( %XX -- ) 23 lshift DMA1-S5CR bis! ;  \ DMA1-S5CR_MBURST    Memory burst transfer
  configuration
: DMA1-S5CR_PBURST   ( %XX -- ) 21 lshift DMA1-S5CR bis! ;  \ DMA1-S5CR_PBURST    Peripheral burst transfer
  configuration
: DMA1-S5CR_ACK   %1 20 lshift DMA1-S5CR bis! ;  \ DMA1-S5CR_ACK    ACK
: DMA1-S5CR_CT   %1 19 lshift DMA1-S5CR bis! ;  \ DMA1-S5CR_CT    Current target only in double buffer
  mode
: DMA1-S5CR_DBM   %1 18 lshift DMA1-S5CR bis! ;  \ DMA1-S5CR_DBM    Double buffer mode
: DMA1-S5CR_PL   ( %XX -- ) 16 lshift DMA1-S5CR bis! ;  \ DMA1-S5CR_PL    Priority level
: DMA1-S5CR_PINCOS   %1 15 lshift DMA1-S5CR bis! ;  \ DMA1-S5CR_PINCOS    Peripheral increment offset
  size
: DMA1-S5CR_MSIZE   ( %XX -- ) 13 lshift DMA1-S5CR bis! ;  \ DMA1-S5CR_MSIZE    Memory data size
: DMA1-S5CR_PSIZE   ( %XX -- ) 11 lshift DMA1-S5CR bis! ;  \ DMA1-S5CR_PSIZE    Peripheral data size
: DMA1-S5CR_MINC   %1 10 lshift DMA1-S5CR bis! ;  \ DMA1-S5CR_MINC    Memory increment mode
: DMA1-S5CR_PINC   %1 9 lshift DMA1-S5CR bis! ;  \ DMA1-S5CR_PINC    Peripheral increment mode
: DMA1-S5CR_CIRC   %1 8 lshift DMA1-S5CR bis! ;  \ DMA1-S5CR_CIRC    Circular mode
: DMA1-S5CR_DIR   ( %XX -- ) 6 lshift DMA1-S5CR bis! ;  \ DMA1-S5CR_DIR    Data transfer direction
: DMA1-S5CR_PFCTRL   %1 5 lshift DMA1-S5CR bis! ;  \ DMA1-S5CR_PFCTRL    Peripheral flow controller
: DMA1-S5CR_TCIE   %1 4 lshift DMA1-S5CR bis! ;  \ DMA1-S5CR_TCIE    Transfer complete interrupt
  enable
: DMA1-S5CR_HTIE   %1 3 lshift DMA1-S5CR bis! ;  \ DMA1-S5CR_HTIE    Half transfer interrupt
  enable
: DMA1-S5CR_TEIE   %1 2 lshift DMA1-S5CR bis! ;  \ DMA1-S5CR_TEIE    Transfer error interrupt
  enable
: DMA1-S5CR_DMEIE   %1 1 lshift DMA1-S5CR bis! ;  \ DMA1-S5CR_DMEIE    Direct mode error interrupt
  enable
: DMA1-S5CR_EN   %1 0 lshift DMA1-S5CR bis! ;  \ DMA1-S5CR_EN    Stream enable / flag stream ready when
  read low

\ DMA1-S5NDTR (read-write)
: DMA1-S5NDTR_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-S5NDTR bis! ;  \ DMA1-S5NDTR_NDT    Number of data items to
  transfer

\ DMA1-S5PAR (read-write)
: DMA1-S5PAR_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-S5PAR bis! ;  \ DMA1-S5PAR_PA    Peripheral address

\ DMA1-S5M0AR (read-write)
: DMA1-S5M0AR_M0A   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-S5M0AR bis! ;  \ DMA1-S5M0AR_M0A    Memory 0 address

\ DMA1-S5M1AR (read-write)
: DMA1-S5M1AR_M1A   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-S5M1AR bis! ;  \ DMA1-S5M1AR_M1A    Memory 1 address used in case of Double
  buffer mode

\ DMA1-S5FCR ()
: DMA1-S5FCR_FEIE   %1 7 lshift DMA1-S5FCR bis! ;  \ DMA1-S5FCR_FEIE    FIFO error interrupt
  enable
: DMA1-S5FCR_FS   ( %XXX -- ) 3 lshift DMA1-S5FCR bis! ;  \ DMA1-S5FCR_FS    FIFO status
: DMA1-S5FCR_DMDIS   %1 2 lshift DMA1-S5FCR bis! ;  \ DMA1-S5FCR_DMDIS    Direct mode disable
: DMA1-S5FCR_FTH   ( %XX -- ) 0 lshift DMA1-S5FCR bis! ;  \ DMA1-S5FCR_FTH    FIFO threshold selection

\ DMA1-S6CR (read-write)
: DMA1-S6CR_CHSEL   ( %XXX -- ) 25 lshift DMA1-S6CR bis! ;  \ DMA1-S6CR_CHSEL    Channel selection
: DMA1-S6CR_MBURST   ( %XX -- ) 23 lshift DMA1-S6CR bis! ;  \ DMA1-S6CR_MBURST    Memory burst transfer
  configuration
: DMA1-S6CR_PBURST   ( %XX -- ) 21 lshift DMA1-S6CR bis! ;  \ DMA1-S6CR_PBURST    Peripheral burst transfer
  configuration
: DMA1-S6CR_ACK   %1 20 lshift DMA1-S6CR bis! ;  \ DMA1-S6CR_ACK    ACK
: DMA1-S6CR_CT   %1 19 lshift DMA1-S6CR bis! ;  \ DMA1-S6CR_CT    Current target only in double buffer
  mode
: DMA1-S6CR_DBM   %1 18 lshift DMA1-S6CR bis! ;  \ DMA1-S6CR_DBM    Double buffer mode
: DMA1-S6CR_PL   ( %XX -- ) 16 lshift DMA1-S6CR bis! ;  \ DMA1-S6CR_PL    Priority level
: DMA1-S6CR_PINCOS   %1 15 lshift DMA1-S6CR bis! ;  \ DMA1-S6CR_PINCOS    Peripheral increment offset
  size
: DMA1-S6CR_MSIZE   ( %XX -- ) 13 lshift DMA1-S6CR bis! ;  \ DMA1-S6CR_MSIZE    Memory data size
: DMA1-S6CR_PSIZE   ( %XX -- ) 11 lshift DMA1-S6CR bis! ;  \ DMA1-S6CR_PSIZE    Peripheral data size
: DMA1-S6CR_MINC   %1 10 lshift DMA1-S6CR bis! ;  \ DMA1-S6CR_MINC    Memory increment mode
: DMA1-S6CR_PINC   %1 9 lshift DMA1-S6CR bis! ;  \ DMA1-S6CR_PINC    Peripheral increment mode
: DMA1-S6CR_CIRC   %1 8 lshift DMA1-S6CR bis! ;  \ DMA1-S6CR_CIRC    Circular mode
: DMA1-S6CR_DIR   ( %XX -- ) 6 lshift DMA1-S6CR bis! ;  \ DMA1-S6CR_DIR    Data transfer direction
: DMA1-S6CR_PFCTRL   %1 5 lshift DMA1-S6CR bis! ;  \ DMA1-S6CR_PFCTRL    Peripheral flow controller
: DMA1-S6CR_TCIE   %1 4 lshift DMA1-S6CR bis! ;  \ DMA1-S6CR_TCIE    Transfer complete interrupt
  enable
: DMA1-S6CR_HTIE   %1 3 lshift DMA1-S6CR bis! ;  \ DMA1-S6CR_HTIE    Half transfer interrupt
  enable
: DMA1-S6CR_TEIE   %1 2 lshift DMA1-S6CR bis! ;  \ DMA1-S6CR_TEIE    Transfer error interrupt
  enable
: DMA1-S6CR_DMEIE   %1 1 lshift DMA1-S6CR bis! ;  \ DMA1-S6CR_DMEIE    Direct mode error interrupt
  enable
: DMA1-S6CR_EN   %1 0 lshift DMA1-S6CR bis! ;  \ DMA1-S6CR_EN    Stream enable / flag stream ready when
  read low

\ DMA1-S6NDTR (read-write)
: DMA1-S6NDTR_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-S6NDTR bis! ;  \ DMA1-S6NDTR_NDT    Number of data items to
  transfer

\ DMA1-S6PAR (read-write)
: DMA1-S6PAR_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-S6PAR bis! ;  \ DMA1-S6PAR_PA    Peripheral address

\ DMA1-S6M0AR (read-write)
: DMA1-S6M0AR_M0A   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-S6M0AR bis! ;  \ DMA1-S6M0AR_M0A    Memory 0 address

\ DMA1-S6M1AR (read-write)
: DMA1-S6M1AR_M1A   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-S6M1AR bis! ;  \ DMA1-S6M1AR_M1A    Memory 1 address used in case of Double
  buffer mode

\ DMA1-S6FCR ()
: DMA1-S6FCR_FEIE   %1 7 lshift DMA1-S6FCR bis! ;  \ DMA1-S6FCR_FEIE    FIFO error interrupt
  enable
: DMA1-S6FCR_FS   ( %XXX -- ) 3 lshift DMA1-S6FCR bis! ;  \ DMA1-S6FCR_FS    FIFO status
: DMA1-S6FCR_DMDIS   %1 2 lshift DMA1-S6FCR bis! ;  \ DMA1-S6FCR_DMDIS    Direct mode disable
: DMA1-S6FCR_FTH   ( %XX -- ) 0 lshift DMA1-S6FCR bis! ;  \ DMA1-S6FCR_FTH    FIFO threshold selection

\ DMA1-S7CR (read-write)
: DMA1-S7CR_CHSEL   ( %XXX -- ) 25 lshift DMA1-S7CR bis! ;  \ DMA1-S7CR_CHSEL    Channel selection
: DMA1-S7CR_MBURST   ( %XX -- ) 23 lshift DMA1-S7CR bis! ;  \ DMA1-S7CR_MBURST    Memory burst transfer
  configuration
: DMA1-S7CR_PBURST   ( %XX -- ) 21 lshift DMA1-S7CR bis! ;  \ DMA1-S7CR_PBURST    Peripheral burst transfer
  configuration
: DMA1-S7CR_ACK   %1 20 lshift DMA1-S7CR bis! ;  \ DMA1-S7CR_ACK    ACK
: DMA1-S7CR_CT   %1 19 lshift DMA1-S7CR bis! ;  \ DMA1-S7CR_CT    Current target only in double buffer
  mode
: DMA1-S7CR_DBM   %1 18 lshift DMA1-S7CR bis! ;  \ DMA1-S7CR_DBM    Double buffer mode
: DMA1-S7CR_PL   ( %XX -- ) 16 lshift DMA1-S7CR bis! ;  \ DMA1-S7CR_PL    Priority level
: DMA1-S7CR_PINCOS   %1 15 lshift DMA1-S7CR bis! ;  \ DMA1-S7CR_PINCOS    Peripheral increment offset
  size
: DMA1-S7CR_MSIZE   ( %XX -- ) 13 lshift DMA1-S7CR bis! ;  \ DMA1-S7CR_MSIZE    Memory data size
: DMA1-S7CR_PSIZE   ( %XX -- ) 11 lshift DMA1-S7CR bis! ;  \ DMA1-S7CR_PSIZE    Peripheral data size
: DMA1-S7CR_MINC   %1 10 lshift DMA1-S7CR bis! ;  \ DMA1-S7CR_MINC    Memory increment mode
: DMA1-S7CR_PINC   %1 9 lshift DMA1-S7CR bis! ;  \ DMA1-S7CR_PINC    Peripheral increment mode
: DMA1-S7CR_CIRC   %1 8 lshift DMA1-S7CR bis! ;  \ DMA1-S7CR_CIRC    Circular mode
: DMA1-S7CR_DIR   ( %XX -- ) 6 lshift DMA1-S7CR bis! ;  \ DMA1-S7CR_DIR    Data transfer direction
: DMA1-S7CR_PFCTRL   %1 5 lshift DMA1-S7CR bis! ;  \ DMA1-S7CR_PFCTRL    Peripheral flow controller
: DMA1-S7CR_TCIE   %1 4 lshift DMA1-S7CR bis! ;  \ DMA1-S7CR_TCIE    Transfer complete interrupt
  enable
: DMA1-S7CR_HTIE   %1 3 lshift DMA1-S7CR bis! ;  \ DMA1-S7CR_HTIE    Half transfer interrupt
  enable
: DMA1-S7CR_TEIE   %1 2 lshift DMA1-S7CR bis! ;  \ DMA1-S7CR_TEIE    Transfer error interrupt
  enable
: DMA1-S7CR_DMEIE   %1 1 lshift DMA1-S7CR bis! ;  \ DMA1-S7CR_DMEIE    Direct mode error interrupt
  enable
: DMA1-S7CR_EN   %1 0 lshift DMA1-S7CR bis! ;  \ DMA1-S7CR_EN    Stream enable / flag stream ready when
  read low

\ DMA1-S7NDTR (read-write)
: DMA1-S7NDTR_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-S7NDTR bis! ;  \ DMA1-S7NDTR_NDT    Number of data items to
  transfer

\ DMA1-S7PAR (read-write)
: DMA1-S7PAR_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-S7PAR bis! ;  \ DMA1-S7PAR_PA    Peripheral address

\ DMA1-S7M0AR (read-write)
: DMA1-S7M0AR_M0A   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-S7M0AR bis! ;  \ DMA1-S7M0AR_M0A    Memory 0 address

\ DMA1-S7M1AR (read-write)
: DMA1-S7M1AR_M1A   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-S7M1AR bis! ;  \ DMA1-S7M1AR_M1A    Memory 1 address used in case of Double
  buffer mode

\ DMA1-S7FCR ()
: DMA1-S7FCR_FEIE   %1 7 lshift DMA1-S7FCR bis! ;  \ DMA1-S7FCR_FEIE    FIFO error interrupt
  enable
: DMA1-S7FCR_FS   ( %XXX -- ) 3 lshift DMA1-S7FCR bis! ;  \ DMA1-S7FCR_FS    FIFO status
: DMA1-S7FCR_DMDIS   %1 2 lshift DMA1-S7FCR bis! ;  \ DMA1-S7FCR_DMDIS    Direct mode disable
: DMA1-S7FCR_FTH   ( %XX -- ) 0 lshift DMA1-S7FCR bis! ;  \ DMA1-S7FCR_FTH    FIFO threshold selection

\ GPIOH-MODER (read-write)
: GPIOH-MODER_MODER15   ( %XX -- ) 30 lshift GPIOH-MODER bis! ;  \ GPIOH-MODER_MODER15    Port x configuration bits y =
  0..15
: GPIOH-MODER_MODER14   ( %XX -- ) 28 lshift GPIOH-MODER bis! ;  \ GPIOH-MODER_MODER14    Port x configuration bits y =
  0..15
: GPIOH-MODER_MODER13   ( %XX -- ) 26 lshift GPIOH-MODER bis! ;  \ GPIOH-MODER_MODER13    Port x configuration bits y =
  0..15
: GPIOH-MODER_MODER12   ( %XX -- ) 24 lshift GPIOH-MODER bis! ;  \ GPIOH-MODER_MODER12    Port x configuration bits y =
  0..15
: GPIOH-MODER_MODER11   ( %XX -- ) 22 lshift GPIOH-MODER bis! ;  \ GPIOH-MODER_MODER11    Port x configuration bits y =
  0..15
: GPIOH-MODER_MODER10   ( %XX -- ) 20 lshift GPIOH-MODER bis! ;  \ GPIOH-MODER_MODER10    Port x configuration bits y =
  0..15
: GPIOH-MODER_MODER9   ( %XX -- ) 18 lshift GPIOH-MODER bis! ;  \ GPIOH-MODER_MODER9    Port x configuration bits y =
  0..15
: GPIOH-MODER_MODER8   ( %XX -- ) 16 lshift GPIOH-MODER bis! ;  \ GPIOH-MODER_MODER8    Port x configuration bits y =
  0..15
: GPIOH-MODER_MODER7   ( %XX -- ) 14 lshift GPIOH-MODER bis! ;  \ GPIOH-MODER_MODER7    Port x configuration bits y =
  0..15
: GPIOH-MODER_MODER6   ( %XX -- ) 12 lshift GPIOH-MODER bis! ;  \ GPIOH-MODER_MODER6    Port x configuration bits y =
  0..15
: GPIOH-MODER_MODER5   ( %XX -- ) 10 lshift GPIOH-MODER bis! ;  \ GPIOH-MODER_MODER5    Port x configuration bits y =
  0..15
: GPIOH-MODER_MODER4   ( %XX -- ) 8 lshift GPIOH-MODER bis! ;  \ GPIOH-MODER_MODER4    Port x configuration bits y =
  0..15
: GPIOH-MODER_MODER3   ( %XX -- ) 6 lshift GPIOH-MODER bis! ;  \ GPIOH-MODER_MODER3    Port x configuration bits y =
  0..15
: GPIOH-MODER_MODER2   ( %XX -- ) 4 lshift GPIOH-MODER bis! ;  \ GPIOH-MODER_MODER2    Port x configuration bits y =
  0..15
: GPIOH-MODER_MODER1   ( %XX -- ) 2 lshift GPIOH-MODER bis! ;  \ GPIOH-MODER_MODER1    Port x configuration bits y =
  0..15
: GPIOH-MODER_MODER0   ( %XX -- ) 0 lshift GPIOH-MODER bis! ;  \ GPIOH-MODER_MODER0    Port x configuration bits y =
  0..15

\ GPIOH-OTYPER (read-write)
: GPIOH-OTYPER_OT15   %1 15 lshift GPIOH-OTYPER bis! ;  \ GPIOH-OTYPER_OT15    Port x configuration bits y =
  0..15
: GPIOH-OTYPER_OT14   %1 14 lshift GPIOH-OTYPER bis! ;  \ GPIOH-OTYPER_OT14    Port x configuration bits y =
  0..15
: GPIOH-OTYPER_OT13   %1 13 lshift GPIOH-OTYPER bis! ;  \ GPIOH-OTYPER_OT13    Port x configuration bits y =
  0..15
: GPIOH-OTYPER_OT12   %1 12 lshift GPIOH-OTYPER bis! ;  \ GPIOH-OTYPER_OT12    Port x configuration bits y =
  0..15
: GPIOH-OTYPER_OT11   %1 11 lshift GPIOH-OTYPER bis! ;  \ GPIOH-OTYPER_OT11    Port x configuration bits y =
  0..15
: GPIOH-OTYPER_OT10   %1 10 lshift GPIOH-OTYPER bis! ;  \ GPIOH-OTYPER_OT10    Port x configuration bits y =
  0..15
: GPIOH-OTYPER_OT9   %1 9 lshift GPIOH-OTYPER bis! ;  \ GPIOH-OTYPER_OT9    Port x configuration bits y =
  0..15
: GPIOH-OTYPER_OT8   %1 8 lshift GPIOH-OTYPER bis! ;  \ GPIOH-OTYPER_OT8    Port x configuration bits y =
  0..15
: GPIOH-OTYPER_OT7   %1 7 lshift GPIOH-OTYPER bis! ;  \ GPIOH-OTYPER_OT7    Port x configuration bits y =
  0..15
: GPIOH-OTYPER_OT6   %1 6 lshift GPIOH-OTYPER bis! ;  \ GPIOH-OTYPER_OT6    Port x configuration bits y =
  0..15
: GPIOH-OTYPER_OT5   %1 5 lshift GPIOH-OTYPER bis! ;  \ GPIOH-OTYPER_OT5    Port x configuration bits y =
  0..15
: GPIOH-OTYPER_OT4   %1 4 lshift GPIOH-OTYPER bis! ;  \ GPIOH-OTYPER_OT4    Port x configuration bits y =
  0..15
: GPIOH-OTYPER_OT3   %1 3 lshift GPIOH-OTYPER bis! ;  \ GPIOH-OTYPER_OT3    Port x configuration bits y =
  0..15
: GPIOH-OTYPER_OT2   %1 2 lshift GPIOH-OTYPER bis! ;  \ GPIOH-OTYPER_OT2    Port x configuration bits y =
  0..15
: GPIOH-OTYPER_OT1   %1 1 lshift GPIOH-OTYPER bis! ;  \ GPIOH-OTYPER_OT1    Port x configuration bits y =
  0..15
: GPIOH-OTYPER_OT0   %1 0 lshift GPIOH-OTYPER bis! ;  \ GPIOH-OTYPER_OT0    Port x configuration bits y =
  0..15

\ GPIOH-OSPEEDR (read-write)
: GPIOH-OSPEEDR_OSPEEDR15   ( %XX -- ) 30 lshift GPIOH-OSPEEDR bis! ;  \ GPIOH-OSPEEDR_OSPEEDR15    Port x configuration bits y =
  0..15
: GPIOH-OSPEEDR_OSPEEDR14   ( %XX -- ) 28 lshift GPIOH-OSPEEDR bis! ;  \ GPIOH-OSPEEDR_OSPEEDR14    Port x configuration bits y =
  0..15
: GPIOH-OSPEEDR_OSPEEDR13   ( %XX -- ) 26 lshift GPIOH-OSPEEDR bis! ;  \ GPIOH-OSPEEDR_OSPEEDR13    Port x configuration bits y =
  0..15
: GPIOH-OSPEEDR_OSPEEDR12   ( %XX -- ) 24 lshift GPIOH-OSPEEDR bis! ;  \ GPIOH-OSPEEDR_OSPEEDR12    Port x configuration bits y =
  0..15
: GPIOH-OSPEEDR_OSPEEDR11   ( %XX -- ) 22 lshift GPIOH-OSPEEDR bis! ;  \ GPIOH-OSPEEDR_OSPEEDR11    Port x configuration bits y =
  0..15
: GPIOH-OSPEEDR_OSPEEDR10   ( %XX -- ) 20 lshift GPIOH-OSPEEDR bis! ;  \ GPIOH-OSPEEDR_OSPEEDR10    Port x configuration bits y =
  0..15
: GPIOH-OSPEEDR_OSPEEDR9   ( %XX -- ) 18 lshift GPIOH-OSPEEDR bis! ;  \ GPIOH-OSPEEDR_OSPEEDR9    Port x configuration bits y =
  0..15
: GPIOH-OSPEEDR_OSPEEDR8   ( %XX -- ) 16 lshift GPIOH-OSPEEDR bis! ;  \ GPIOH-OSPEEDR_OSPEEDR8    Port x configuration bits y =
  0..15
: GPIOH-OSPEEDR_OSPEEDR7   ( %XX -- ) 14 lshift GPIOH-OSPEEDR bis! ;  \ GPIOH-OSPEEDR_OSPEEDR7    Port x configuration bits y =
  0..15
: GPIOH-OSPEEDR_OSPEEDR6   ( %XX -- ) 12 lshift GPIOH-OSPEEDR bis! ;  \ GPIOH-OSPEEDR_OSPEEDR6    Port x configuration bits y =
  0..15
: GPIOH-OSPEEDR_OSPEEDR5   ( %XX -- ) 10 lshift GPIOH-OSPEEDR bis! ;  \ GPIOH-OSPEEDR_OSPEEDR5    Port x configuration bits y =
  0..15
: GPIOH-OSPEEDR_OSPEEDR4   ( %XX -- ) 8 lshift GPIOH-OSPEEDR bis! ;  \ GPIOH-OSPEEDR_OSPEEDR4    Port x configuration bits y =
  0..15
: GPIOH-OSPEEDR_OSPEEDR3   ( %XX -- ) 6 lshift GPIOH-OSPEEDR bis! ;  \ GPIOH-OSPEEDR_OSPEEDR3    Port x configuration bits y =
  0..15
: GPIOH-OSPEEDR_OSPEEDR2   ( %XX -- ) 4 lshift GPIOH-OSPEEDR bis! ;  \ GPIOH-OSPEEDR_OSPEEDR2    Port x configuration bits y =
  0..15
: GPIOH-OSPEEDR_OSPEEDR1   ( %XX -- ) 2 lshift GPIOH-OSPEEDR bis! ;  \ GPIOH-OSPEEDR_OSPEEDR1    Port x configuration bits y =
  0..15
: GPIOH-OSPEEDR_OSPEEDR0   ( %XX -- ) 0 lshift GPIOH-OSPEEDR bis! ;  \ GPIOH-OSPEEDR_OSPEEDR0    Port x configuration bits y =
  0..15

\ GPIOH-PUPDR (read-write)
: GPIOH-PUPDR_PUPDR15   ( %XX -- ) 30 lshift GPIOH-PUPDR bis! ;  \ GPIOH-PUPDR_PUPDR15    Port x configuration bits y =
  0..15
: GPIOH-PUPDR_PUPDR14   ( %XX -- ) 28 lshift GPIOH-PUPDR bis! ;  \ GPIOH-PUPDR_PUPDR14    Port x configuration bits y =
  0..15
: GPIOH-PUPDR_PUPDR13   ( %XX -- ) 26 lshift GPIOH-PUPDR bis! ;  \ GPIOH-PUPDR_PUPDR13    Port x configuration bits y =
  0..15
: GPIOH-PUPDR_PUPDR12   ( %XX -- ) 24 lshift GPIOH-PUPDR bis! ;  \ GPIOH-PUPDR_PUPDR12    Port x configuration bits y =
  0..15
: GPIOH-PUPDR_PUPDR11   ( %XX -- ) 22 lshift GPIOH-PUPDR bis! ;  \ GPIOH-PUPDR_PUPDR11    Port x configuration bits y =
  0..15
: GPIOH-PUPDR_PUPDR10   ( %XX -- ) 20 lshift GPIOH-PUPDR bis! ;  \ GPIOH-PUPDR_PUPDR10    Port x configuration bits y =
  0..15
: GPIOH-PUPDR_PUPDR9   ( %XX -- ) 18 lshift GPIOH-PUPDR bis! ;  \ GPIOH-PUPDR_PUPDR9    Port x configuration bits y =
  0..15
: GPIOH-PUPDR_PUPDR8   ( %XX -- ) 16 lshift GPIOH-PUPDR bis! ;  \ GPIOH-PUPDR_PUPDR8    Port x configuration bits y =
  0..15
: GPIOH-PUPDR_PUPDR7   ( %XX -- ) 14 lshift GPIOH-PUPDR bis! ;  \ GPIOH-PUPDR_PUPDR7    Port x configuration bits y =
  0..15
: GPIOH-PUPDR_PUPDR6   ( %XX -- ) 12 lshift GPIOH-PUPDR bis! ;  \ GPIOH-PUPDR_PUPDR6    Port x configuration bits y =
  0..15
: GPIOH-PUPDR_PUPDR5   ( %XX -- ) 10 lshift GPIOH-PUPDR bis! ;  \ GPIOH-PUPDR_PUPDR5    Port x configuration bits y =
  0..15
: GPIOH-PUPDR_PUPDR4   ( %XX -- ) 8 lshift GPIOH-PUPDR bis! ;  \ GPIOH-PUPDR_PUPDR4    Port x configuration bits y =
  0..15
: GPIOH-PUPDR_PUPDR3   ( %XX -- ) 6 lshift GPIOH-PUPDR bis! ;  \ GPIOH-PUPDR_PUPDR3    Port x configuration bits y =
  0..15
: GPIOH-PUPDR_PUPDR2   ( %XX -- ) 4 lshift GPIOH-PUPDR bis! ;  \ GPIOH-PUPDR_PUPDR2    Port x configuration bits y =
  0..15
: GPIOH-PUPDR_PUPDR1   ( %XX -- ) 2 lshift GPIOH-PUPDR bis! ;  \ GPIOH-PUPDR_PUPDR1    Port x configuration bits y =
  0..15
: GPIOH-PUPDR_PUPDR0   ( %XX -- ) 0 lshift GPIOH-PUPDR bis! ;  \ GPIOH-PUPDR_PUPDR0    Port x configuration bits y =
  0..15

\ GPIOH-IDR (read-only)
: GPIOH-IDR_IDR15   %1 15 lshift GPIOH-IDR bis! ;  \ GPIOH-IDR_IDR15    Port input data y =
  0..15
: GPIOH-IDR_IDR14   %1 14 lshift GPIOH-IDR bis! ;  \ GPIOH-IDR_IDR14    Port input data y =
  0..15
: GPIOH-IDR_IDR13   %1 13 lshift GPIOH-IDR bis! ;  \ GPIOH-IDR_IDR13    Port input data y =
  0..15
: GPIOH-IDR_IDR12   %1 12 lshift GPIOH-IDR bis! ;  \ GPIOH-IDR_IDR12    Port input data y =
  0..15
: GPIOH-IDR_IDR11   %1 11 lshift GPIOH-IDR bis! ;  \ GPIOH-IDR_IDR11    Port input data y =
  0..15
: GPIOH-IDR_IDR10   %1 10 lshift GPIOH-IDR bis! ;  \ GPIOH-IDR_IDR10    Port input data y =
  0..15
: GPIOH-IDR_IDR9   %1 9 lshift GPIOH-IDR bis! ;  \ GPIOH-IDR_IDR9    Port input data y =
  0..15
: GPIOH-IDR_IDR8   %1 8 lshift GPIOH-IDR bis! ;  \ GPIOH-IDR_IDR8    Port input data y =
  0..15
: GPIOH-IDR_IDR7   %1 7 lshift GPIOH-IDR bis! ;  \ GPIOH-IDR_IDR7    Port input data y =
  0..15
: GPIOH-IDR_IDR6   %1 6 lshift GPIOH-IDR bis! ;  \ GPIOH-IDR_IDR6    Port input data y =
  0..15
: GPIOH-IDR_IDR5   %1 5 lshift GPIOH-IDR bis! ;  \ GPIOH-IDR_IDR5    Port input data y =
  0..15
: GPIOH-IDR_IDR4   %1 4 lshift GPIOH-IDR bis! ;  \ GPIOH-IDR_IDR4    Port input data y =
  0..15
: GPIOH-IDR_IDR3   %1 3 lshift GPIOH-IDR bis! ;  \ GPIOH-IDR_IDR3    Port input data y =
  0..15
: GPIOH-IDR_IDR2   %1 2 lshift GPIOH-IDR bis! ;  \ GPIOH-IDR_IDR2    Port input data y =
  0..15
: GPIOH-IDR_IDR1   %1 1 lshift GPIOH-IDR bis! ;  \ GPIOH-IDR_IDR1    Port input data y =
  0..15
: GPIOH-IDR_IDR0   %1 0 lshift GPIOH-IDR bis! ;  \ GPIOH-IDR_IDR0    Port input data y =
  0..15

\ GPIOH-ODR (read-write)
: GPIOH-ODR_ODR15   %1 15 lshift GPIOH-ODR bis! ;  \ GPIOH-ODR_ODR15    Port output data y =
  0..15
: GPIOH-ODR_ODR14   %1 14 lshift GPIOH-ODR bis! ;  \ GPIOH-ODR_ODR14    Port output data y =
  0..15
: GPIOH-ODR_ODR13   %1 13 lshift GPIOH-ODR bis! ;  \ GPIOH-ODR_ODR13    Port output data y =
  0..15
: GPIOH-ODR_ODR12   %1 12 lshift GPIOH-ODR bis! ;  \ GPIOH-ODR_ODR12    Port output data y =
  0..15
: GPIOH-ODR_ODR11   %1 11 lshift GPIOH-ODR bis! ;  \ GPIOH-ODR_ODR11    Port output data y =
  0..15
: GPIOH-ODR_ODR10   %1 10 lshift GPIOH-ODR bis! ;  \ GPIOH-ODR_ODR10    Port output data y =
  0..15
: GPIOH-ODR_ODR9   %1 9 lshift GPIOH-ODR bis! ;  \ GPIOH-ODR_ODR9    Port output data y =
  0..15
: GPIOH-ODR_ODR8   %1 8 lshift GPIOH-ODR bis! ;  \ GPIOH-ODR_ODR8    Port output data y =
  0..15
: GPIOH-ODR_ODR7   %1 7 lshift GPIOH-ODR bis! ;  \ GPIOH-ODR_ODR7    Port output data y =
  0..15
: GPIOH-ODR_ODR6   %1 6 lshift GPIOH-ODR bis! ;  \ GPIOH-ODR_ODR6    Port output data y =
  0..15
: GPIOH-ODR_ODR5   %1 5 lshift GPIOH-ODR bis! ;  \ GPIOH-ODR_ODR5    Port output data y =
  0..15
: GPIOH-ODR_ODR4   %1 4 lshift GPIOH-ODR bis! ;  \ GPIOH-ODR_ODR4    Port output data y =
  0..15
: GPIOH-ODR_ODR3   %1 3 lshift GPIOH-ODR bis! ;  \ GPIOH-ODR_ODR3    Port output data y =
  0..15
: GPIOH-ODR_ODR2   %1 2 lshift GPIOH-ODR bis! ;  \ GPIOH-ODR_ODR2    Port output data y =
  0..15
: GPIOH-ODR_ODR1   %1 1 lshift GPIOH-ODR bis! ;  \ GPIOH-ODR_ODR1    Port output data y =
  0..15
: GPIOH-ODR_ODR0   %1 0 lshift GPIOH-ODR bis! ;  \ GPIOH-ODR_ODR0    Port output data y =
  0..15

\ GPIOH-BSRR (write-only)
: GPIOH-BSRR_BR15   %1 31 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BR15    Port x reset bit y y =
  0..15
: GPIOH-BSRR_BR14   %1 30 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BR14    Port x reset bit y y =
  0..15
: GPIOH-BSRR_BR13   %1 29 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BR13    Port x reset bit y y =
  0..15
: GPIOH-BSRR_BR12   %1 28 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BR12    Port x reset bit y y =
  0..15
: GPIOH-BSRR_BR11   %1 27 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BR11    Port x reset bit y y =
  0..15
: GPIOH-BSRR_BR10   %1 26 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BR10    Port x reset bit y y =
  0..15
: GPIOH-BSRR_BR9   %1 25 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BR9    Port x reset bit y y =
  0..15
: GPIOH-BSRR_BR8   %1 24 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BR8    Port x reset bit y y =
  0..15
: GPIOH-BSRR_BR7   %1 23 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BR7    Port x reset bit y y =
  0..15
: GPIOH-BSRR_BR6   %1 22 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BR6    Port x reset bit y y =
  0..15
: GPIOH-BSRR_BR5   %1 21 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BR5    Port x reset bit y y =
  0..15
: GPIOH-BSRR_BR4   %1 20 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BR4    Port x reset bit y y =
  0..15
: GPIOH-BSRR_BR3   %1 19 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BR3    Port x reset bit y y =
  0..15
: GPIOH-BSRR_BR2   %1 18 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BR2    Port x reset bit y y =
  0..15
: GPIOH-BSRR_BR1   %1 17 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BR1    Port x reset bit y y =
  0..15
: GPIOH-BSRR_BR0   %1 16 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BR0    Port x set bit y y=
  0..15
: GPIOH-BSRR_BS15   %1 15 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BS15    Port x set bit y y=
  0..15
: GPIOH-BSRR_BS14   %1 14 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BS14    Port x set bit y y=
  0..15
: GPIOH-BSRR_BS13   %1 13 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BS13    Port x set bit y y=
  0..15
: GPIOH-BSRR_BS12   %1 12 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BS12    Port x set bit y y=
  0..15
: GPIOH-BSRR_BS11   %1 11 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BS11    Port x set bit y y=
  0..15
: GPIOH-BSRR_BS10   %1 10 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BS10    Port x set bit y y=
  0..15
: GPIOH-BSRR_BS9   %1 9 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BS9    Port x set bit y y=
  0..15
: GPIOH-BSRR_BS8   %1 8 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BS8    Port x set bit y y=
  0..15
: GPIOH-BSRR_BS7   %1 7 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BS7    Port x set bit y y=
  0..15
: GPIOH-BSRR_BS6   %1 6 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BS6    Port x set bit y y=
  0..15
: GPIOH-BSRR_BS5   %1 5 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BS5    Port x set bit y y=
  0..15
: GPIOH-BSRR_BS4   %1 4 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BS4    Port x set bit y y=
  0..15
: GPIOH-BSRR_BS3   %1 3 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BS3    Port x set bit y y=
  0..15
: GPIOH-BSRR_BS2   %1 2 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BS2    Port x set bit y y=
  0..15
: GPIOH-BSRR_BS1   %1 1 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BS1    Port x set bit y y=
  0..15
: GPIOH-BSRR_BS0   %1 0 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BS0    Port x set bit y y=
  0..15

\ GPIOH-LCKR (read-write)
: GPIOH-LCKR_LCKK   %1 16 lshift GPIOH-LCKR bis! ;  \ GPIOH-LCKR_LCKK    Port x lock bit y y=
  0..15
: GPIOH-LCKR_LCK15   %1 15 lshift GPIOH-LCKR bis! ;  \ GPIOH-LCKR_LCK15    Port x lock bit y y=
  0..15
: GPIOH-LCKR_LCK14   %1 14 lshift GPIOH-LCKR bis! ;  \ GPIOH-LCKR_LCK14    Port x lock bit y y=
  0..15
: GPIOH-LCKR_LCK13   %1 13 lshift GPIOH-LCKR bis! ;  \ GPIOH-LCKR_LCK13    Port x lock bit y y=
  0..15
: GPIOH-LCKR_LCK12   %1 12 lshift GPIOH-LCKR bis! ;  \ GPIOH-LCKR_LCK12    Port x lock bit y y=
  0..15
: GPIOH-LCKR_LCK11   %1 11 lshift GPIOH-LCKR bis! ;  \ GPIOH-LCKR_LCK11    Port x lock bit y y=
  0..15
: GPIOH-LCKR_LCK10   %1 10 lshift GPIOH-LCKR bis! ;  \ GPIOH-LCKR_LCK10    Port x lock bit y y=
  0..15
: GPIOH-LCKR_LCK9   %1 9 lshift GPIOH-LCKR bis! ;  \ GPIOH-LCKR_LCK9    Port x lock bit y y=
  0..15
: GPIOH-LCKR_LCK8   %1 8 lshift GPIOH-LCKR bis! ;  \ GPIOH-LCKR_LCK8    Port x lock bit y y=
  0..15
: GPIOH-LCKR_LCK7   %1 7 lshift GPIOH-LCKR bis! ;  \ GPIOH-LCKR_LCK7    Port x lock bit y y=
  0..15
: GPIOH-LCKR_LCK6   %1 6 lshift GPIOH-LCKR bis! ;  \ GPIOH-LCKR_LCK6    Port x lock bit y y=
  0..15
: GPIOH-LCKR_LCK5   %1 5 lshift GPIOH-LCKR bis! ;  \ GPIOH-LCKR_LCK5    Port x lock bit y y=
  0..15
: GPIOH-LCKR_LCK4   %1 4 lshift GPIOH-LCKR bis! ;  \ GPIOH-LCKR_LCK4    Port x lock bit y y=
  0..15
: GPIOH-LCKR_LCK3   %1 3 lshift GPIOH-LCKR bis! ;  \ GPIOH-LCKR_LCK3    Port x lock bit y y=
  0..15
: GPIOH-LCKR_LCK2   %1 2 lshift GPIOH-LCKR bis! ;  \ GPIOH-LCKR_LCK2    Port x lock bit y y=
  0..15
: GPIOH-LCKR_LCK1   %1 1 lshift GPIOH-LCKR bis! ;  \ GPIOH-LCKR_LCK1    Port x lock bit y y=
  0..15
: GPIOH-LCKR_LCK0   %1 0 lshift GPIOH-LCKR bis! ;  \ GPIOH-LCKR_LCK0    Port x lock bit y y=
  0..15

\ GPIOH-AFRL (read-write)
: GPIOH-AFRL_AFRL7   ( %XXXX -- ) 28 lshift GPIOH-AFRL bis! ;  \ GPIOH-AFRL_AFRL7    Alternate function selection for port x
  bit y y = 0..7
: GPIOH-AFRL_AFRL6   ( %XXXX -- ) 24 lshift GPIOH-AFRL bis! ;  \ GPIOH-AFRL_AFRL6    Alternate function selection for port x
  bit y y = 0..7
: GPIOH-AFRL_AFRL5   ( %XXXX -- ) 20 lshift GPIOH-AFRL bis! ;  \ GPIOH-AFRL_AFRL5    Alternate function selection for port x
  bit y y = 0..7
: GPIOH-AFRL_AFRL4   ( %XXXX -- ) 16 lshift GPIOH-AFRL bis! ;  \ GPIOH-AFRL_AFRL4    Alternate function selection for port x
  bit y y = 0..7
: GPIOH-AFRL_AFRL3   ( %XXXX -- ) 12 lshift GPIOH-AFRL bis! ;  \ GPIOH-AFRL_AFRL3    Alternate function selection for port x
  bit y y = 0..7
: GPIOH-AFRL_AFRL2   ( %XXXX -- ) 8 lshift GPIOH-AFRL bis! ;  \ GPIOH-AFRL_AFRL2    Alternate function selection for port x
  bit y y = 0..7
: GPIOH-AFRL_AFRL1   ( %XXXX -- ) 4 lshift GPIOH-AFRL bis! ;  \ GPIOH-AFRL_AFRL1    Alternate function selection for port x
  bit y y = 0..7
: GPIOH-AFRL_AFRL0   ( %XXXX -- ) 0 lshift GPIOH-AFRL bis! ;  \ GPIOH-AFRL_AFRL0    Alternate function selection for port x
  bit y y = 0..7

\ GPIOH-AFRH (read-write)
: GPIOH-AFRH_AFRH15   ( %XXXX -- ) 28 lshift GPIOH-AFRH bis! ;  \ GPIOH-AFRH_AFRH15    Alternate function selection for port x
  bit y y = 8..15
: GPIOH-AFRH_AFRH14   ( %XXXX -- ) 24 lshift GPIOH-AFRH bis! ;  \ GPIOH-AFRH_AFRH14    Alternate function selection for port x
  bit y y = 8..15
: GPIOH-AFRH_AFRH13   ( %XXXX -- ) 20 lshift GPIOH-AFRH bis! ;  \ GPIOH-AFRH_AFRH13    Alternate function selection for port x
  bit y y = 8..15
: GPIOH-AFRH_AFRH12   ( %XXXX -- ) 16 lshift GPIOH-AFRH bis! ;  \ GPIOH-AFRH_AFRH12    Alternate function selection for port x
  bit y y = 8..15
: GPIOH-AFRH_AFRH11   ( %XXXX -- ) 12 lshift GPIOH-AFRH bis! ;  \ GPIOH-AFRH_AFRH11    Alternate function selection for port x
  bit y y = 8..15
: GPIOH-AFRH_AFRH10   ( %XXXX -- ) 8 lshift GPIOH-AFRH bis! ;  \ GPIOH-AFRH_AFRH10    Alternate function selection for port x
  bit y y = 8..15
: GPIOH-AFRH_AFRH9   ( %XXXX -- ) 4 lshift GPIOH-AFRH bis! ;  \ GPIOH-AFRH_AFRH9    Alternate function selection for port x
  bit y y = 8..15
: GPIOH-AFRH_AFRH8   ( %XXXX -- ) 0 lshift GPIOH-AFRH bis! ;  \ GPIOH-AFRH_AFRH8    Alternate function selection for port x
  bit y y = 8..15

\ GPIOE-MODER (read-write)
: GPIOE-MODER_MODER15   ( %XX -- ) 30 lshift GPIOE-MODER bis! ;  \ GPIOE-MODER_MODER15    Port x configuration bits y =
  0..15
: GPIOE-MODER_MODER14   ( %XX -- ) 28 lshift GPIOE-MODER bis! ;  \ GPIOE-MODER_MODER14    Port x configuration bits y =
  0..15
: GPIOE-MODER_MODER13   ( %XX -- ) 26 lshift GPIOE-MODER bis! ;  \ GPIOE-MODER_MODER13    Port x configuration bits y =
  0..15
: GPIOE-MODER_MODER12   ( %XX -- ) 24 lshift GPIOE-MODER bis! ;  \ GPIOE-MODER_MODER12    Port x configuration bits y =
  0..15
: GPIOE-MODER_MODER11   ( %XX -- ) 22 lshift GPIOE-MODER bis! ;  \ GPIOE-MODER_MODER11    Port x configuration bits y =
  0..15
: GPIOE-MODER_MODER10   ( %XX -- ) 20 lshift GPIOE-MODER bis! ;  \ GPIOE-MODER_MODER10    Port x configuration bits y =
  0..15
: GPIOE-MODER_MODER9   ( %XX -- ) 18 lshift GPIOE-MODER bis! ;  \ GPIOE-MODER_MODER9    Port x configuration bits y =
  0..15
: GPIOE-MODER_MODER8   ( %XX -- ) 16 lshift GPIOE-MODER bis! ;  \ GPIOE-MODER_MODER8    Port x configuration bits y =
  0..15
: GPIOE-MODER_MODER7   ( %XX -- ) 14 lshift GPIOE-MODER bis! ;  \ GPIOE-MODER_MODER7    Port x configuration bits y =
  0..15
: GPIOE-MODER_MODER6   ( %XX -- ) 12 lshift GPIOE-MODER bis! ;  \ GPIOE-MODER_MODER6    Port x configuration bits y =
  0..15
: GPIOE-MODER_MODER5   ( %XX -- ) 10 lshift GPIOE-MODER bis! ;  \ GPIOE-MODER_MODER5    Port x configuration bits y =
  0..15
: GPIOE-MODER_MODER4   ( %XX -- ) 8 lshift GPIOE-MODER bis! ;  \ GPIOE-MODER_MODER4    Port x configuration bits y =
  0..15
: GPIOE-MODER_MODER3   ( %XX -- ) 6 lshift GPIOE-MODER bis! ;  \ GPIOE-MODER_MODER3    Port x configuration bits y =
  0..15
: GPIOE-MODER_MODER2   ( %XX -- ) 4 lshift GPIOE-MODER bis! ;  \ GPIOE-MODER_MODER2    Port x configuration bits y =
  0..15
: GPIOE-MODER_MODER1   ( %XX -- ) 2 lshift GPIOE-MODER bis! ;  \ GPIOE-MODER_MODER1    Port x configuration bits y =
  0..15
: GPIOE-MODER_MODER0   ( %XX -- ) 0 lshift GPIOE-MODER bis! ;  \ GPIOE-MODER_MODER0    Port x configuration bits y =
  0..15

\ GPIOE-OTYPER (read-write)
: GPIOE-OTYPER_OT15   %1 15 lshift GPIOE-OTYPER bis! ;  \ GPIOE-OTYPER_OT15    Port x configuration bits y =
  0..15
: GPIOE-OTYPER_OT14   %1 14 lshift GPIOE-OTYPER bis! ;  \ GPIOE-OTYPER_OT14    Port x configuration bits y =
  0..15
: GPIOE-OTYPER_OT13   %1 13 lshift GPIOE-OTYPER bis! ;  \ GPIOE-OTYPER_OT13    Port x configuration bits y =
  0..15
: GPIOE-OTYPER_OT12   %1 12 lshift GPIOE-OTYPER bis! ;  \ GPIOE-OTYPER_OT12    Port x configuration bits y =
  0..15
: GPIOE-OTYPER_OT11   %1 11 lshift GPIOE-OTYPER bis! ;  \ GPIOE-OTYPER_OT11    Port x configuration bits y =
  0..15
: GPIOE-OTYPER_OT10   %1 10 lshift GPIOE-OTYPER bis! ;  \ GPIOE-OTYPER_OT10    Port x configuration bits y =
  0..15
: GPIOE-OTYPER_OT9   %1 9 lshift GPIOE-OTYPER bis! ;  \ GPIOE-OTYPER_OT9    Port x configuration bits y =
  0..15
: GPIOE-OTYPER_OT8   %1 8 lshift GPIOE-OTYPER bis! ;  \ GPIOE-OTYPER_OT8    Port x configuration bits y =
  0..15
: GPIOE-OTYPER_OT7   %1 7 lshift GPIOE-OTYPER bis! ;  \ GPIOE-OTYPER_OT7    Port x configuration bits y =
  0..15
: GPIOE-OTYPER_OT6   %1 6 lshift GPIOE-OTYPER bis! ;  \ GPIOE-OTYPER_OT6    Port x configuration bits y =
  0..15
: GPIOE-OTYPER_OT5   %1 5 lshift GPIOE-OTYPER bis! ;  \ GPIOE-OTYPER_OT5    Port x configuration bits y =
  0..15
: GPIOE-OTYPER_OT4   %1 4 lshift GPIOE-OTYPER bis! ;  \ GPIOE-OTYPER_OT4    Port x configuration bits y =
  0..15
: GPIOE-OTYPER_OT3   %1 3 lshift GPIOE-OTYPER bis! ;  \ GPIOE-OTYPER_OT3    Port x configuration bits y =
  0..15
: GPIOE-OTYPER_OT2   %1 2 lshift GPIOE-OTYPER bis! ;  \ GPIOE-OTYPER_OT2    Port x configuration bits y =
  0..15
: GPIOE-OTYPER_OT1   %1 1 lshift GPIOE-OTYPER bis! ;  \ GPIOE-OTYPER_OT1    Port x configuration bits y =
  0..15
: GPIOE-OTYPER_OT0   %1 0 lshift GPIOE-OTYPER bis! ;  \ GPIOE-OTYPER_OT0    Port x configuration bits y =
  0..15

\ GPIOE-OSPEEDR (read-write)
: GPIOE-OSPEEDR_OSPEEDR15   ( %XX -- ) 30 lshift GPIOE-OSPEEDR bis! ;  \ GPIOE-OSPEEDR_OSPEEDR15    Port x configuration bits y =
  0..15
: GPIOE-OSPEEDR_OSPEEDR14   ( %XX -- ) 28 lshift GPIOE-OSPEEDR bis! ;  \ GPIOE-OSPEEDR_OSPEEDR14    Port x configuration bits y =
  0..15
: GPIOE-OSPEEDR_OSPEEDR13   ( %XX -- ) 26 lshift GPIOE-OSPEEDR bis! ;  \ GPIOE-OSPEEDR_OSPEEDR13    Port x configuration bits y =
  0..15
: GPIOE-OSPEEDR_OSPEEDR12   ( %XX -- ) 24 lshift GPIOE-OSPEEDR bis! ;  \ GPIOE-OSPEEDR_OSPEEDR12    Port x configuration bits y =
  0..15
: GPIOE-OSPEEDR_OSPEEDR11   ( %XX -- ) 22 lshift GPIOE-OSPEEDR bis! ;  \ GPIOE-OSPEEDR_OSPEEDR11    Port x configuration bits y =
  0..15
: GPIOE-OSPEEDR_OSPEEDR10   ( %XX -- ) 20 lshift GPIOE-OSPEEDR bis! ;  \ GPIOE-OSPEEDR_OSPEEDR10    Port x configuration bits y =
  0..15
: GPIOE-OSPEEDR_OSPEEDR9   ( %XX -- ) 18 lshift GPIOE-OSPEEDR bis! ;  \ GPIOE-OSPEEDR_OSPEEDR9    Port x configuration bits y =
  0..15
: GPIOE-OSPEEDR_OSPEEDR8   ( %XX -- ) 16 lshift GPIOE-OSPEEDR bis! ;  \ GPIOE-OSPEEDR_OSPEEDR8    Port x configuration bits y =
  0..15
: GPIOE-OSPEEDR_OSPEEDR7   ( %XX -- ) 14 lshift GPIOE-OSPEEDR bis! ;  \ GPIOE-OSPEEDR_OSPEEDR7    Port x configuration bits y =
  0..15
: GPIOE-OSPEEDR_OSPEEDR6   ( %XX -- ) 12 lshift GPIOE-OSPEEDR bis! ;  \ GPIOE-OSPEEDR_OSPEEDR6    Port x configuration bits y =
  0..15
: GPIOE-OSPEEDR_OSPEEDR5   ( %XX -- ) 10 lshift GPIOE-OSPEEDR bis! ;  \ GPIOE-OSPEEDR_OSPEEDR5    Port x configuration bits y =
  0..15
: GPIOE-OSPEEDR_OSPEEDR4   ( %XX -- ) 8 lshift GPIOE-OSPEEDR bis! ;  \ GPIOE-OSPEEDR_OSPEEDR4    Port x configuration bits y =
  0..15
: GPIOE-OSPEEDR_OSPEEDR3   ( %XX -- ) 6 lshift GPIOE-OSPEEDR bis! ;  \ GPIOE-OSPEEDR_OSPEEDR3    Port x configuration bits y =
  0..15
: GPIOE-OSPEEDR_OSPEEDR2   ( %XX -- ) 4 lshift GPIOE-OSPEEDR bis! ;  \ GPIOE-OSPEEDR_OSPEEDR2    Port x configuration bits y =
  0..15
: GPIOE-OSPEEDR_OSPEEDR1   ( %XX -- ) 2 lshift GPIOE-OSPEEDR bis! ;  \ GPIOE-OSPEEDR_OSPEEDR1    Port x configuration bits y =
  0..15
: GPIOE-OSPEEDR_OSPEEDR0   ( %XX -- ) 0 lshift GPIOE-OSPEEDR bis! ;  \ GPIOE-OSPEEDR_OSPEEDR0    Port x configuration bits y =
  0..15

\ GPIOE-PUPDR (read-write)
: GPIOE-PUPDR_PUPDR15   ( %XX -- ) 30 lshift GPIOE-PUPDR bis! ;  \ GPIOE-PUPDR_PUPDR15    Port x configuration bits y =
  0..15
: GPIOE-PUPDR_PUPDR14   ( %XX -- ) 28 lshift GPIOE-PUPDR bis! ;  \ GPIOE-PUPDR_PUPDR14    Port x configuration bits y =
  0..15
: GPIOE-PUPDR_PUPDR13   ( %XX -- ) 26 lshift GPIOE-PUPDR bis! ;  \ GPIOE-PUPDR_PUPDR13    Port x configuration bits y =
  0..15
: GPIOE-PUPDR_PUPDR12   ( %XX -- ) 24 lshift GPIOE-PUPDR bis! ;  \ GPIOE-PUPDR_PUPDR12    Port x configuration bits y =
  0..15
: GPIOE-PUPDR_PUPDR11   ( %XX -- ) 22 lshift GPIOE-PUPDR bis! ;  \ GPIOE-PUPDR_PUPDR11    Port x configuration bits y =
  0..15
: GPIOE-PUPDR_PUPDR10   ( %XX -- ) 20 lshift GPIOE-PUPDR bis! ;  \ GPIOE-PUPDR_PUPDR10    Port x configuration bits y =
  0..15
: GPIOE-PUPDR_PUPDR9   ( %XX -- ) 18 lshift GPIOE-PUPDR bis! ;  \ GPIOE-PUPDR_PUPDR9    Port x configuration bits y =
  0..15
: GPIOE-PUPDR_PUPDR8   ( %XX -- ) 16 lshift GPIOE-PUPDR bis! ;  \ GPIOE-PUPDR_PUPDR8    Port x configuration bits y =
  0..15
: GPIOE-PUPDR_PUPDR7   ( %XX -- ) 14 lshift GPIOE-PUPDR bis! ;  \ GPIOE-PUPDR_PUPDR7    Port x configuration bits y =
  0..15
: GPIOE-PUPDR_PUPDR6   ( %XX -- ) 12 lshift GPIOE-PUPDR bis! ;  \ GPIOE-PUPDR_PUPDR6    Port x configuration bits y =
  0..15
: GPIOE-PUPDR_PUPDR5   ( %XX -- ) 10 lshift GPIOE-PUPDR bis! ;  \ GPIOE-PUPDR_PUPDR5    Port x configuration bits y =
  0..15
: GPIOE-PUPDR_PUPDR4   ( %XX -- ) 8 lshift GPIOE-PUPDR bis! ;  \ GPIOE-PUPDR_PUPDR4    Port x configuration bits y =
  0..15
: GPIOE-PUPDR_PUPDR3   ( %XX -- ) 6 lshift GPIOE-PUPDR bis! ;  \ GPIOE-PUPDR_PUPDR3    Port x configuration bits y =
  0..15
: GPIOE-PUPDR_PUPDR2   ( %XX -- ) 4 lshift GPIOE-PUPDR bis! ;  \ GPIOE-PUPDR_PUPDR2    Port x configuration bits y =
  0..15
: GPIOE-PUPDR_PUPDR1   ( %XX -- ) 2 lshift GPIOE-PUPDR bis! ;  \ GPIOE-PUPDR_PUPDR1    Port x configuration bits y =
  0..15
: GPIOE-PUPDR_PUPDR0   ( %XX -- ) 0 lshift GPIOE-PUPDR bis! ;  \ GPIOE-PUPDR_PUPDR0    Port x configuration bits y =
  0..15

\ GPIOE-IDR (read-only)
: GPIOE-IDR_IDR15   %1 15 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR15    Port input data y =
  0..15
: GPIOE-IDR_IDR14   %1 14 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR14    Port input data y =
  0..15
: GPIOE-IDR_IDR13   %1 13 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR13    Port input data y =
  0..15
: GPIOE-IDR_IDR12   %1 12 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR12    Port input data y =
  0..15
: GPIOE-IDR_IDR11   %1 11 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR11    Port input data y =
  0..15
: GPIOE-IDR_IDR10   %1 10 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR10    Port input data y =
  0..15
: GPIOE-IDR_IDR9   %1 9 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR9    Port input data y =
  0..15
: GPIOE-IDR_IDR8   %1 8 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR8    Port input data y =
  0..15
: GPIOE-IDR_IDR7   %1 7 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR7    Port input data y =
  0..15
: GPIOE-IDR_IDR6   %1 6 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR6    Port input data y =
  0..15
: GPIOE-IDR_IDR5   %1 5 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR5    Port input data y =
  0..15
: GPIOE-IDR_IDR4   %1 4 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR4    Port input data y =
  0..15
: GPIOE-IDR_IDR3   %1 3 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR3    Port input data y =
  0..15
: GPIOE-IDR_IDR2   %1 2 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR2    Port input data y =
  0..15
: GPIOE-IDR_IDR1   %1 1 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR1    Port input data y =
  0..15
: GPIOE-IDR_IDR0   %1 0 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR0    Port input data y =
  0..15

\ GPIOE-ODR (read-write)
: GPIOE-ODR_ODR15   %1 15 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR15    Port output data y =
  0..15
: GPIOE-ODR_ODR14   %1 14 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR14    Port output data y =
  0..15
: GPIOE-ODR_ODR13   %1 13 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR13    Port output data y =
  0..15
: GPIOE-ODR_ODR12   %1 12 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR12    Port output data y =
  0..15
: GPIOE-ODR_ODR11   %1 11 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR11    Port output data y =
  0..15
: GPIOE-ODR_ODR10   %1 10 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR10    Port output data y =
  0..15
: GPIOE-ODR_ODR9   %1 9 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR9    Port output data y =
  0..15
: GPIOE-ODR_ODR8   %1 8 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR8    Port output data y =
  0..15
: GPIOE-ODR_ODR7   %1 7 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR7    Port output data y =
  0..15
: GPIOE-ODR_ODR6   %1 6 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR6    Port output data y =
  0..15
: GPIOE-ODR_ODR5   %1 5 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR5    Port output data y =
  0..15
: GPIOE-ODR_ODR4   %1 4 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR4    Port output data y =
  0..15
: GPIOE-ODR_ODR3   %1 3 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR3    Port output data y =
  0..15
: GPIOE-ODR_ODR2   %1 2 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR2    Port output data y =
  0..15
: GPIOE-ODR_ODR1   %1 1 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR1    Port output data y =
  0..15
: GPIOE-ODR_ODR0   %1 0 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR0    Port output data y =
  0..15

\ GPIOE-BSRR (write-only)
: GPIOE-BSRR_BR15   %1 31 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR15    Port x reset bit y y =
  0..15
: GPIOE-BSRR_BR14   %1 30 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR14    Port x reset bit y y =
  0..15
: GPIOE-BSRR_BR13   %1 29 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR13    Port x reset bit y y =
  0..15
: GPIOE-BSRR_BR12   %1 28 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR12    Port x reset bit y y =
  0..15
: GPIOE-BSRR_BR11   %1 27 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR11    Port x reset bit y y =
  0..15
: GPIOE-BSRR_BR10   %1 26 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR10    Port x reset bit y y =
  0..15
: GPIOE-BSRR_BR9   %1 25 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR9    Port x reset bit y y =
  0..15
: GPIOE-BSRR_BR8   %1 24 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR8    Port x reset bit y y =
  0..15
: GPIOE-BSRR_BR7   %1 23 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR7    Port x reset bit y y =
  0..15
: GPIOE-BSRR_BR6   %1 22 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR6    Port x reset bit y y =
  0..15
: GPIOE-BSRR_BR5   %1 21 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR5    Port x reset bit y y =
  0..15
: GPIOE-BSRR_BR4   %1 20 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR4    Port x reset bit y y =
  0..15
: GPIOE-BSRR_BR3   %1 19 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR3    Port x reset bit y y =
  0..15
: GPIOE-BSRR_BR2   %1 18 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR2    Port x reset bit y y =
  0..15
: GPIOE-BSRR_BR1   %1 17 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR1    Port x reset bit y y =
  0..15
: GPIOE-BSRR_BR0   %1 16 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR0    Port x set bit y y=
  0..15
: GPIOE-BSRR_BS15   %1 15 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS15    Port x set bit y y=
  0..15
: GPIOE-BSRR_BS14   %1 14 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS14    Port x set bit y y=
  0..15
: GPIOE-BSRR_BS13   %1 13 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS13    Port x set bit y y=
  0..15
: GPIOE-BSRR_BS12   %1 12 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS12    Port x set bit y y=
  0..15
: GPIOE-BSRR_BS11   %1 11 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS11    Port x set bit y y=
  0..15
: GPIOE-BSRR_BS10   %1 10 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS10    Port x set bit y y=
  0..15
: GPIOE-BSRR_BS9   %1 9 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS9    Port x set bit y y=
  0..15
: GPIOE-BSRR_BS8   %1 8 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS8    Port x set bit y y=
  0..15
: GPIOE-BSRR_BS7   %1 7 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS7    Port x set bit y y=
  0..15
: GPIOE-BSRR_BS6   %1 6 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS6    Port x set bit y y=
  0..15
: GPIOE-BSRR_BS5   %1 5 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS5    Port x set bit y y=
  0..15
: GPIOE-BSRR_BS4   %1 4 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS4    Port x set bit y y=
  0..15
: GPIOE-BSRR_BS3   %1 3 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS3    Port x set bit y y=
  0..15
: GPIOE-BSRR_BS2   %1 2 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS2    Port x set bit y y=
  0..15
: GPIOE-BSRR_BS1   %1 1 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS1    Port x set bit y y=
  0..15
: GPIOE-BSRR_BS0   %1 0 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS0    Port x set bit y y=
  0..15

\ GPIOE-LCKR (read-write)
: GPIOE-LCKR_LCKK   %1 16 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCKK    Port x lock bit y y=
  0..15
: GPIOE-LCKR_LCK15   %1 15 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK15    Port x lock bit y y=
  0..15
: GPIOE-LCKR_LCK14   %1 14 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK14    Port x lock bit y y=
  0..15
: GPIOE-LCKR_LCK13   %1 13 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK13    Port x lock bit y y=
  0..15
: GPIOE-LCKR_LCK12   %1 12 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK12    Port x lock bit y y=
  0..15
: GPIOE-LCKR_LCK11   %1 11 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK11    Port x lock bit y y=
  0..15
: GPIOE-LCKR_LCK10   %1 10 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK10    Port x lock bit y y=
  0..15
: GPIOE-LCKR_LCK9   %1 9 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK9    Port x lock bit y y=
  0..15
: GPIOE-LCKR_LCK8   %1 8 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK8    Port x lock bit y y=
  0..15
: GPIOE-LCKR_LCK7   %1 7 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK7    Port x lock bit y y=
  0..15
: GPIOE-LCKR_LCK6   %1 6 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK6    Port x lock bit y y=
  0..15
: GPIOE-LCKR_LCK5   %1 5 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK5    Port x lock bit y y=
  0..15
: GPIOE-LCKR_LCK4   %1 4 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK4    Port x lock bit y y=
  0..15
: GPIOE-LCKR_LCK3   %1 3 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK3    Port x lock bit y y=
  0..15
: GPIOE-LCKR_LCK2   %1 2 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK2    Port x lock bit y y=
  0..15
: GPIOE-LCKR_LCK1   %1 1 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK1    Port x lock bit y y=
  0..15
: GPIOE-LCKR_LCK0   %1 0 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK0    Port x lock bit y y=
  0..15

\ GPIOE-AFRL (read-write)
: GPIOE-AFRL_AFRL7   ( %XXXX -- ) 28 lshift GPIOE-AFRL bis! ;  \ GPIOE-AFRL_AFRL7    Alternate function selection for port x
  bit y y = 0..7
: GPIOE-AFRL_AFRL6   ( %XXXX -- ) 24 lshift GPIOE-AFRL bis! ;  \ GPIOE-AFRL_AFRL6    Alternate function selection for port x
  bit y y = 0..7
: GPIOE-AFRL_AFRL5   ( %XXXX -- ) 20 lshift GPIOE-AFRL bis! ;  \ GPIOE-AFRL_AFRL5    Alternate function selection for port x
  bit y y = 0..7
: GPIOE-AFRL_AFRL4   ( %XXXX -- ) 16 lshift GPIOE-AFRL bis! ;  \ GPIOE-AFRL_AFRL4    Alternate function selection for port x
  bit y y = 0..7
: GPIOE-AFRL_AFRL3   ( %XXXX -- ) 12 lshift GPIOE-AFRL bis! ;  \ GPIOE-AFRL_AFRL3    Alternate function selection for port x
  bit y y = 0..7
: GPIOE-AFRL_AFRL2   ( %XXXX -- ) 8 lshift GPIOE-AFRL bis! ;  \ GPIOE-AFRL_AFRL2    Alternate function selection for port x
  bit y y = 0..7
: GPIOE-AFRL_AFRL1   ( %XXXX -- ) 4 lshift GPIOE-AFRL bis! ;  \ GPIOE-AFRL_AFRL1    Alternate function selection for port x
  bit y y = 0..7
: GPIOE-AFRL_AFRL0   ( %XXXX -- ) 0 lshift GPIOE-AFRL bis! ;  \ GPIOE-AFRL_AFRL0    Alternate function selection for port x
  bit y y = 0..7

\ GPIOE-AFRH (read-write)
: GPIOE-AFRH_AFRH15   ( %XXXX -- ) 28 lshift GPIOE-AFRH bis! ;  \ GPIOE-AFRH_AFRH15    Alternate function selection for port x
  bit y y = 8..15
: GPIOE-AFRH_AFRH14   ( %XXXX -- ) 24 lshift GPIOE-AFRH bis! ;  \ GPIOE-AFRH_AFRH14    Alternate function selection for port x
  bit y y = 8..15
: GPIOE-AFRH_AFRH13   ( %XXXX -- ) 20 lshift GPIOE-AFRH bis! ;  \ GPIOE-AFRH_AFRH13    Alternate function selection for port x
  bit y y = 8..15
: GPIOE-AFRH_AFRH12   ( %XXXX -- ) 16 lshift GPIOE-AFRH bis! ;  \ GPIOE-AFRH_AFRH12    Alternate function selection for port x
  bit y y = 8..15
: GPIOE-AFRH_AFRH11   ( %XXXX -- ) 12 lshift GPIOE-AFRH bis! ;  \ GPIOE-AFRH_AFRH11    Alternate function selection for port x
  bit y y = 8..15
: GPIOE-AFRH_AFRH10   ( %XXXX -- ) 8 lshift GPIOE-AFRH bis! ;  \ GPIOE-AFRH_AFRH10    Alternate function selection for port x
  bit y y = 8..15
: GPIOE-AFRH_AFRH9   ( %XXXX -- ) 4 lshift GPIOE-AFRH bis! ;  \ GPIOE-AFRH_AFRH9    Alternate function selection for port x
  bit y y = 8..15
: GPIOE-AFRH_AFRH8   ( %XXXX -- ) 0 lshift GPIOE-AFRH bis! ;  \ GPIOE-AFRH_AFRH8    Alternate function selection for port x
  bit y y = 8..15

\ GPIOD-MODER (read-write)
: GPIOD-MODER_MODER15   ( %XX -- ) 30 lshift GPIOD-MODER bis! ;  \ GPIOD-MODER_MODER15    Port x configuration bits y =
  0..15
: GPIOD-MODER_MODER14   ( %XX -- ) 28 lshift GPIOD-MODER bis! ;  \ GPIOD-MODER_MODER14    Port x configuration bits y =
  0..15
: GPIOD-MODER_MODER13   ( %XX -- ) 26 lshift GPIOD-MODER bis! ;  \ GPIOD-MODER_MODER13    Port x configuration bits y =
  0..15
: GPIOD-MODER_MODER12   ( %XX -- ) 24 lshift GPIOD-MODER bis! ;  \ GPIOD-MODER_MODER12    Port x configuration bits y =
  0..15
: GPIOD-MODER_MODER11   ( %XX -- ) 22 lshift GPIOD-MODER bis! ;  \ GPIOD-MODER_MODER11    Port x configuration bits y =
  0..15
: GPIOD-MODER_MODER10   ( %XX -- ) 20 lshift GPIOD-MODER bis! ;  \ GPIOD-MODER_MODER10    Port x configuration bits y =
  0..15
: GPIOD-MODER_MODER9   ( %XX -- ) 18 lshift GPIOD-MODER bis! ;  \ GPIOD-MODER_MODER9    Port x configuration bits y =
  0..15
: GPIOD-MODER_MODER8   ( %XX -- ) 16 lshift GPIOD-MODER bis! ;  \ GPIOD-MODER_MODER8    Port x configuration bits y =
  0..15
: GPIOD-MODER_MODER7   ( %XX -- ) 14 lshift GPIOD-MODER bis! ;  \ GPIOD-MODER_MODER7    Port x configuration bits y =
  0..15
: GPIOD-MODER_MODER6   ( %XX -- ) 12 lshift GPIOD-MODER bis! ;  \ GPIOD-MODER_MODER6    Port x configuration bits y =
  0..15
: GPIOD-MODER_MODER5   ( %XX -- ) 10 lshift GPIOD-MODER bis! ;  \ GPIOD-MODER_MODER5    Port x configuration bits y =
  0..15
: GPIOD-MODER_MODER4   ( %XX -- ) 8 lshift GPIOD-MODER bis! ;  \ GPIOD-MODER_MODER4    Port x configuration bits y =
  0..15
: GPIOD-MODER_MODER3   ( %XX -- ) 6 lshift GPIOD-MODER bis! ;  \ GPIOD-MODER_MODER3    Port x configuration bits y =
  0..15
: GPIOD-MODER_MODER2   ( %XX -- ) 4 lshift GPIOD-MODER bis! ;  \ GPIOD-MODER_MODER2    Port x configuration bits y =
  0..15
: GPIOD-MODER_MODER1   ( %XX -- ) 2 lshift GPIOD-MODER bis! ;  \ GPIOD-MODER_MODER1    Port x configuration bits y =
  0..15
: GPIOD-MODER_MODER0   ( %XX -- ) 0 lshift GPIOD-MODER bis! ;  \ GPIOD-MODER_MODER0    Port x configuration bits y =
  0..15

\ GPIOD-OTYPER (read-write)
: GPIOD-OTYPER_OT15   %1 15 lshift GPIOD-OTYPER bis! ;  \ GPIOD-OTYPER_OT15    Port x configuration bits y =
  0..15
: GPIOD-OTYPER_OT14   %1 14 lshift GPIOD-OTYPER bis! ;  \ GPIOD-OTYPER_OT14    Port x configuration bits y =
  0..15
: GPIOD-OTYPER_OT13   %1 13 lshift GPIOD-OTYPER bis! ;  \ GPIOD-OTYPER_OT13    Port x configuration bits y =
  0..15
: GPIOD-OTYPER_OT12   %1 12 lshift GPIOD-OTYPER bis! ;  \ GPIOD-OTYPER_OT12    Port x configuration bits y =
  0..15
: GPIOD-OTYPER_OT11   %1 11 lshift GPIOD-OTYPER bis! ;  \ GPIOD-OTYPER_OT11    Port x configuration bits y =
  0..15
: GPIOD-OTYPER_OT10   %1 10 lshift GPIOD-OTYPER bis! ;  \ GPIOD-OTYPER_OT10    Port x configuration bits y =
  0..15
: GPIOD-OTYPER_OT9   %1 9 lshift GPIOD-OTYPER bis! ;  \ GPIOD-OTYPER_OT9    Port x configuration bits y =
  0..15
: GPIOD-OTYPER_OT8   %1 8 lshift GPIOD-OTYPER bis! ;  \ GPIOD-OTYPER_OT8    Port x configuration bits y =
  0..15
: GPIOD-OTYPER_OT7   %1 7 lshift GPIOD-OTYPER bis! ;  \ GPIOD-OTYPER_OT7    Port x configuration bits y =
  0..15
: GPIOD-OTYPER_OT6   %1 6 lshift GPIOD-OTYPER bis! ;  \ GPIOD-OTYPER_OT6    Port x configuration bits y =
  0..15
: GPIOD-OTYPER_OT5   %1 5 lshift GPIOD-OTYPER bis! ;  \ GPIOD-OTYPER_OT5    Port x configuration bits y =
  0..15
: GPIOD-OTYPER_OT4   %1 4 lshift GPIOD-OTYPER bis! ;  \ GPIOD-OTYPER_OT4    Port x configuration bits y =
  0..15
: GPIOD-OTYPER_OT3   %1 3 lshift GPIOD-OTYPER bis! ;  \ GPIOD-OTYPER_OT3    Port x configuration bits y =
  0..15
: GPIOD-OTYPER_OT2   %1 2 lshift GPIOD-OTYPER bis! ;  \ GPIOD-OTYPER_OT2    Port x configuration bits y =
  0..15
: GPIOD-OTYPER_OT1   %1 1 lshift GPIOD-OTYPER bis! ;  \ GPIOD-OTYPER_OT1    Port x configuration bits y =
  0..15
: GPIOD-OTYPER_OT0   %1 0 lshift GPIOD-OTYPER bis! ;  \ GPIOD-OTYPER_OT0    Port x configuration bits y =
  0..15

\ GPIOD-OSPEEDR (read-write)
: GPIOD-OSPEEDR_OSPEEDR15   ( %XX -- ) 30 lshift GPIOD-OSPEEDR bis! ;  \ GPIOD-OSPEEDR_OSPEEDR15    Port x configuration bits y =
  0..15
: GPIOD-OSPEEDR_OSPEEDR14   ( %XX -- ) 28 lshift GPIOD-OSPEEDR bis! ;  \ GPIOD-OSPEEDR_OSPEEDR14    Port x configuration bits y =
  0..15
: GPIOD-OSPEEDR_OSPEEDR13   ( %XX -- ) 26 lshift GPIOD-OSPEEDR bis! ;  \ GPIOD-OSPEEDR_OSPEEDR13    Port x configuration bits y =
  0..15
: GPIOD-OSPEEDR_OSPEEDR12   ( %XX -- ) 24 lshift GPIOD-OSPEEDR bis! ;  \ GPIOD-OSPEEDR_OSPEEDR12    Port x configuration bits y =
  0..15
: GPIOD-OSPEEDR_OSPEEDR11   ( %XX -- ) 22 lshift GPIOD-OSPEEDR bis! ;  \ GPIOD-OSPEEDR_OSPEEDR11    Port x configuration bits y =
  0..15
: GPIOD-OSPEEDR_OSPEEDR10   ( %XX -- ) 20 lshift GPIOD-OSPEEDR bis! ;  \ GPIOD-OSPEEDR_OSPEEDR10    Port x configuration bits y =
  0..15
: GPIOD-OSPEEDR_OSPEEDR9   ( %XX -- ) 18 lshift GPIOD-OSPEEDR bis! ;  \ GPIOD-OSPEEDR_OSPEEDR9    Port x configuration bits y =
  0..15
: GPIOD-OSPEEDR_OSPEEDR8   ( %XX -- ) 16 lshift GPIOD-OSPEEDR bis! ;  \ GPIOD-OSPEEDR_OSPEEDR8    Port x configuration bits y =
  0..15
: GPIOD-OSPEEDR_OSPEEDR7   ( %XX -- ) 14 lshift GPIOD-OSPEEDR bis! ;  \ GPIOD-OSPEEDR_OSPEEDR7    Port x configuration bits y =
  0..15
: GPIOD-OSPEEDR_OSPEEDR6   ( %XX -- ) 12 lshift GPIOD-OSPEEDR bis! ;  \ GPIOD-OSPEEDR_OSPEEDR6    Port x configuration bits y =
  0..15
: GPIOD-OSPEEDR_OSPEEDR5   ( %XX -- ) 10 lshift GPIOD-OSPEEDR bis! ;  \ GPIOD-OSPEEDR_OSPEEDR5    Port x configuration bits y =
  0..15
: GPIOD-OSPEEDR_OSPEEDR4   ( %XX -- ) 8 lshift GPIOD-OSPEEDR bis! ;  \ GPIOD-OSPEEDR_OSPEEDR4    Port x configuration bits y =
  0..15
: GPIOD-OSPEEDR_OSPEEDR3   ( %XX -- ) 6 lshift GPIOD-OSPEEDR bis! ;  \ GPIOD-OSPEEDR_OSPEEDR3    Port x configuration bits y =
  0..15
: GPIOD-OSPEEDR_OSPEEDR2   ( %XX -- ) 4 lshift GPIOD-OSPEEDR bis! ;  \ GPIOD-OSPEEDR_OSPEEDR2    Port x configuration bits y =
  0..15
: GPIOD-OSPEEDR_OSPEEDR1   ( %XX -- ) 2 lshift GPIOD-OSPEEDR bis! ;  \ GPIOD-OSPEEDR_OSPEEDR1    Port x configuration bits y =
  0..15
: GPIOD-OSPEEDR_OSPEEDR0   ( %XX -- ) 0 lshift GPIOD-OSPEEDR bis! ;  \ GPIOD-OSPEEDR_OSPEEDR0    Port x configuration bits y =
  0..15

\ GPIOD-PUPDR (read-write)
: GPIOD-PUPDR_PUPDR15   ( %XX -- ) 30 lshift GPIOD-PUPDR bis! ;  \ GPIOD-PUPDR_PUPDR15    Port x configuration bits y =
  0..15
: GPIOD-PUPDR_PUPDR14   ( %XX -- ) 28 lshift GPIOD-PUPDR bis! ;  \ GPIOD-PUPDR_PUPDR14    Port x configuration bits y =
  0..15
: GPIOD-PUPDR_PUPDR13   ( %XX -- ) 26 lshift GPIOD-PUPDR bis! ;  \ GPIOD-PUPDR_PUPDR13    Port x configuration bits y =
  0..15
: GPIOD-PUPDR_PUPDR12   ( %XX -- ) 24 lshift GPIOD-PUPDR bis! ;  \ GPIOD-PUPDR_PUPDR12    Port x configuration bits y =
  0..15
: GPIOD-PUPDR_PUPDR11   ( %XX -- ) 22 lshift GPIOD-PUPDR bis! ;  \ GPIOD-PUPDR_PUPDR11    Port x configuration bits y =
  0..15
: GPIOD-PUPDR_PUPDR10   ( %XX -- ) 20 lshift GPIOD-PUPDR bis! ;  \ GPIOD-PUPDR_PUPDR10    Port x configuration bits y =
  0..15
: GPIOD-PUPDR_PUPDR9   ( %XX -- ) 18 lshift GPIOD-PUPDR bis! ;  \ GPIOD-PUPDR_PUPDR9    Port x configuration bits y =
  0..15
: GPIOD-PUPDR_PUPDR8   ( %XX -- ) 16 lshift GPIOD-PUPDR bis! ;  \ GPIOD-PUPDR_PUPDR8    Port x configuration bits y =
  0..15
: GPIOD-PUPDR_PUPDR7   ( %XX -- ) 14 lshift GPIOD-PUPDR bis! ;  \ GPIOD-PUPDR_PUPDR7    Port x configuration bits y =
  0..15
: GPIOD-PUPDR_PUPDR6   ( %XX -- ) 12 lshift GPIOD-PUPDR bis! ;  \ GPIOD-PUPDR_PUPDR6    Port x configuration bits y =
  0..15
: GPIOD-PUPDR_PUPDR5   ( %XX -- ) 10 lshift GPIOD-PUPDR bis! ;  \ GPIOD-PUPDR_PUPDR5    Port x configuration bits y =
  0..15
: GPIOD-PUPDR_PUPDR4   ( %XX -- ) 8 lshift GPIOD-PUPDR bis! ;  \ GPIOD-PUPDR_PUPDR4    Port x configuration bits y =
  0..15
: GPIOD-PUPDR_PUPDR3   ( %XX -- ) 6 lshift GPIOD-PUPDR bis! ;  \ GPIOD-PUPDR_PUPDR3    Port x configuration bits y =
  0..15
: GPIOD-PUPDR_PUPDR2   ( %XX -- ) 4 lshift GPIOD-PUPDR bis! ;  \ GPIOD-PUPDR_PUPDR2    Port x configuration bits y =
  0..15
: GPIOD-PUPDR_PUPDR1   ( %XX -- ) 2 lshift GPIOD-PUPDR bis! ;  \ GPIOD-PUPDR_PUPDR1    Port x configuration bits y =
  0..15
: GPIOD-PUPDR_PUPDR0   ( %XX -- ) 0 lshift GPIOD-PUPDR bis! ;  \ GPIOD-PUPDR_PUPDR0    Port x configuration bits y =
  0..15

\ GPIOD-IDR (read-only)
: GPIOD-IDR_IDR15   %1 15 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR15    Port input data y =
  0..15
: GPIOD-IDR_IDR14   %1 14 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR14    Port input data y =
  0..15
: GPIOD-IDR_IDR13   %1 13 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR13    Port input data y =
  0..15
: GPIOD-IDR_IDR12   %1 12 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR12    Port input data y =
  0..15
: GPIOD-IDR_IDR11   %1 11 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR11    Port input data y =
  0..15
: GPIOD-IDR_IDR10   %1 10 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR10    Port input data y =
  0..15
: GPIOD-IDR_IDR9   %1 9 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR9    Port input data y =
  0..15
: GPIOD-IDR_IDR8   %1 8 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR8    Port input data y =
  0..15
: GPIOD-IDR_IDR7   %1 7 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR7    Port input data y =
  0..15
: GPIOD-IDR_IDR6   %1 6 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR6    Port input data y =
  0..15
: GPIOD-IDR_IDR5   %1 5 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR5    Port input data y =
  0..15
: GPIOD-IDR_IDR4   %1 4 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR4    Port input data y =
  0..15
: GPIOD-IDR_IDR3   %1 3 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR3    Port input data y =
  0..15
: GPIOD-IDR_IDR2   %1 2 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR2    Port input data y =
  0..15
: GPIOD-IDR_IDR1   %1 1 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR1    Port input data y =
  0..15
: GPIOD-IDR_IDR0   %1 0 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR0    Port input data y =
  0..15

\ GPIOD-ODR (read-write)
: GPIOD-ODR_ODR15   %1 15 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR15    Port output data y =
  0..15
: GPIOD-ODR_ODR14   %1 14 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR14    Port output data y =
  0..15
: GPIOD-ODR_ODR13   %1 13 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR13    Port output data y =
  0..15
: GPIOD-ODR_ODR12   %1 12 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR12    Port output data y =
  0..15
: GPIOD-ODR_ODR11   %1 11 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR11    Port output data y =
  0..15
: GPIOD-ODR_ODR10   %1 10 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR10    Port output data y =
  0..15
: GPIOD-ODR_ODR9   %1 9 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR9    Port output data y =
  0..15
: GPIOD-ODR_ODR8   %1 8 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR8    Port output data y =
  0..15
: GPIOD-ODR_ODR7   %1 7 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR7    Port output data y =
  0..15
: GPIOD-ODR_ODR6   %1 6 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR6    Port output data y =
  0..15
: GPIOD-ODR_ODR5   %1 5 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR5    Port output data y =
  0..15
: GPIOD-ODR_ODR4   %1 4 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR4    Port output data y =
  0..15
: GPIOD-ODR_ODR3   %1 3 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR3    Port output data y =
  0..15
: GPIOD-ODR_ODR2   %1 2 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR2    Port output data y =
  0..15
: GPIOD-ODR_ODR1   %1 1 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR1    Port output data y =
  0..15
: GPIOD-ODR_ODR0   %1 0 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR0    Port output data y =
  0..15

\ GPIOD-BSRR (write-only)
: GPIOD-BSRR_BR15   %1 31 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR15    Port x reset bit y y =
  0..15
: GPIOD-BSRR_BR14   %1 30 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR14    Port x reset bit y y =
  0..15
: GPIOD-BSRR_BR13   %1 29 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR13    Port x reset bit y y =
  0..15
: GPIOD-BSRR_BR12   %1 28 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR12    Port x reset bit y y =
  0..15
: GPIOD-BSRR_BR11   %1 27 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR11    Port x reset bit y y =
  0..15
: GPIOD-BSRR_BR10   %1 26 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR10    Port x reset bit y y =
  0..15
: GPIOD-BSRR_BR9   %1 25 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR9    Port x reset bit y y =
  0..15
: GPIOD-BSRR_BR8   %1 24 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR8    Port x reset bit y y =
  0..15
: GPIOD-BSRR_BR7   %1 23 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR7    Port x reset bit y y =
  0..15
: GPIOD-BSRR_BR6   %1 22 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR6    Port x reset bit y y =
  0..15
: GPIOD-BSRR_BR5   %1 21 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR5    Port x reset bit y y =
  0..15
: GPIOD-BSRR_BR4   %1 20 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR4    Port x reset bit y y =
  0..15
: GPIOD-BSRR_BR3   %1 19 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR3    Port x reset bit y y =
  0..15
: GPIOD-BSRR_BR2   %1 18 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR2    Port x reset bit y y =
  0..15
: GPIOD-BSRR_BR1   %1 17 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR1    Port x reset bit y y =
  0..15
: GPIOD-BSRR_BR0   %1 16 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR0    Port x set bit y y=
  0..15
: GPIOD-BSRR_BS15   %1 15 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS15    Port x set bit y y=
  0..15
: GPIOD-BSRR_BS14   %1 14 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS14    Port x set bit y y=
  0..15
: GPIOD-BSRR_BS13   %1 13 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS13    Port x set bit y y=
  0..15
: GPIOD-BSRR_BS12   %1 12 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS12    Port x set bit y y=
  0..15
: GPIOD-BSRR_BS11   %1 11 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS11    Port x set bit y y=
  0..15
: GPIOD-BSRR_BS10   %1 10 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS10    Port x set bit y y=
  0..15
: GPIOD-BSRR_BS9   %1 9 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS9    Port x set bit y y=
  0..15
: GPIOD-BSRR_BS8   %1 8 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS8    Port x set bit y y=
  0..15
: GPIOD-BSRR_BS7   %1 7 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS7    Port x set bit y y=
  0..15
: GPIOD-BSRR_BS6   %1 6 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS6    Port x set bit y y=
  0..15
: GPIOD-BSRR_BS5   %1 5 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS5    Port x set bit y y=
  0..15
: GPIOD-BSRR_BS4   %1 4 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS4    Port x set bit y y=
  0..15
: GPIOD-BSRR_BS3   %1 3 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS3    Port x set bit y y=
  0..15
: GPIOD-BSRR_BS2   %1 2 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS2    Port x set bit y y=
  0..15
: GPIOD-BSRR_BS1   %1 1 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS1    Port x set bit y y=
  0..15
: GPIOD-BSRR_BS0   %1 0 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS0    Port x set bit y y=
  0..15

\ GPIOD-LCKR (read-write)
: GPIOD-LCKR_LCKK   %1 16 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCKK    Port x lock bit y y=
  0..15
: GPIOD-LCKR_LCK15   %1 15 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK15    Port x lock bit y y=
  0..15
: GPIOD-LCKR_LCK14   %1 14 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK14    Port x lock bit y y=
  0..15
: GPIOD-LCKR_LCK13   %1 13 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK13    Port x lock bit y y=
  0..15
: GPIOD-LCKR_LCK12   %1 12 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK12    Port x lock bit y y=
  0..15
: GPIOD-LCKR_LCK11   %1 11 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK11    Port x lock bit y y=
  0..15
: GPIOD-LCKR_LCK10   %1 10 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK10    Port x lock bit y y=
  0..15
: GPIOD-LCKR_LCK9   %1 9 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK9    Port x lock bit y y=
  0..15
: GPIOD-LCKR_LCK8   %1 8 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK8    Port x lock bit y y=
  0..15
: GPIOD-LCKR_LCK7   %1 7 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK7    Port x lock bit y y=
  0..15
: GPIOD-LCKR_LCK6   %1 6 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK6    Port x lock bit y y=
  0..15
: GPIOD-LCKR_LCK5   %1 5 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK5    Port x lock bit y y=
  0..15
: GPIOD-LCKR_LCK4   %1 4 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK4    Port x lock bit y y=
  0..15
: GPIOD-LCKR_LCK3   %1 3 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK3    Port x lock bit y y=
  0..15
: GPIOD-LCKR_LCK2   %1 2 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK2    Port x lock bit y y=
  0..15
: GPIOD-LCKR_LCK1   %1 1 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK1    Port x lock bit y y=
  0..15
: GPIOD-LCKR_LCK0   %1 0 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK0    Port x lock bit y y=
  0..15

\ GPIOD-AFRL (read-write)
: GPIOD-AFRL_AFRL7   ( %XXXX -- ) 28 lshift GPIOD-AFRL bis! ;  \ GPIOD-AFRL_AFRL7    Alternate function selection for port x
  bit y y = 0..7
: GPIOD-AFRL_AFRL6   ( %XXXX -- ) 24 lshift GPIOD-AFRL bis! ;  \ GPIOD-AFRL_AFRL6    Alternate function selection for port x
  bit y y = 0..7
: GPIOD-AFRL_AFRL5   ( %XXXX -- ) 20 lshift GPIOD-AFRL bis! ;  \ GPIOD-AFRL_AFRL5    Alternate function selection for port x
  bit y y = 0..7
: GPIOD-AFRL_AFRL4   ( %XXXX -- ) 16 lshift GPIOD-AFRL bis! ;  \ GPIOD-AFRL_AFRL4    Alternate function selection for port x
  bit y y = 0..7
: GPIOD-AFRL_AFRL3   ( %XXXX -- ) 12 lshift GPIOD-AFRL bis! ;  \ GPIOD-AFRL_AFRL3    Alternate function selection for port x
  bit y y = 0..7
: GPIOD-AFRL_AFRL2   ( %XXXX -- ) 8 lshift GPIOD-AFRL bis! ;  \ GPIOD-AFRL_AFRL2    Alternate function selection for port x
  bit y y = 0..7
: GPIOD-AFRL_AFRL1   ( %XXXX -- ) 4 lshift GPIOD-AFRL bis! ;  \ GPIOD-AFRL_AFRL1    Alternate function selection for port x
  bit y y = 0..7
: GPIOD-AFRL_AFRL0   ( %XXXX -- ) 0 lshift GPIOD-AFRL bis! ;  \ GPIOD-AFRL_AFRL0    Alternate function selection for port x
  bit y y = 0..7

\ GPIOD-AFRH (read-write)
: GPIOD-AFRH_AFRH15   ( %XXXX -- ) 28 lshift GPIOD-AFRH bis! ;  \ GPIOD-AFRH_AFRH15    Alternate function selection for port x
  bit y y = 8..15
: GPIOD-AFRH_AFRH14   ( %XXXX -- ) 24 lshift GPIOD-AFRH bis! ;  \ GPIOD-AFRH_AFRH14    Alternate function selection for port x
  bit y y = 8..15
: GPIOD-AFRH_AFRH13   ( %XXXX -- ) 20 lshift GPIOD-AFRH bis! ;  \ GPIOD-AFRH_AFRH13    Alternate function selection for port x
  bit y y = 8..15
: GPIOD-AFRH_AFRH12   ( %XXXX -- ) 16 lshift GPIOD-AFRH bis! ;  \ GPIOD-AFRH_AFRH12    Alternate function selection for port x
  bit y y = 8..15
: GPIOD-AFRH_AFRH11   ( %XXXX -- ) 12 lshift GPIOD-AFRH bis! ;  \ GPIOD-AFRH_AFRH11    Alternate function selection for port x
  bit y y = 8..15
: GPIOD-AFRH_AFRH10   ( %XXXX -- ) 8 lshift GPIOD-AFRH bis! ;  \ GPIOD-AFRH_AFRH10    Alternate function selection for port x
  bit y y = 8..15
: GPIOD-AFRH_AFRH9   ( %XXXX -- ) 4 lshift GPIOD-AFRH bis! ;  \ GPIOD-AFRH_AFRH9    Alternate function selection for port x
  bit y y = 8..15
: GPIOD-AFRH_AFRH8   ( %XXXX -- ) 0 lshift GPIOD-AFRH bis! ;  \ GPIOD-AFRH_AFRH8    Alternate function selection for port x
  bit y y = 8..15

\ GPIOC-MODER (read-write)
: GPIOC-MODER_MODER15   ( %XX -- ) 30 lshift GPIOC-MODER bis! ;  \ GPIOC-MODER_MODER15    Port x configuration bits y =
  0..15
: GPIOC-MODER_MODER14   ( %XX -- ) 28 lshift GPIOC-MODER bis! ;  \ GPIOC-MODER_MODER14    Port x configuration bits y =
  0..15
: GPIOC-MODER_MODER13   ( %XX -- ) 26 lshift GPIOC-MODER bis! ;  \ GPIOC-MODER_MODER13    Port x configuration bits y =
  0..15
: GPIOC-MODER_MODER12   ( %XX -- ) 24 lshift GPIOC-MODER bis! ;  \ GPIOC-MODER_MODER12    Port x configuration bits y =
  0..15
: GPIOC-MODER_MODER11   ( %XX -- ) 22 lshift GPIOC-MODER bis! ;  \ GPIOC-MODER_MODER11    Port x configuration bits y =
  0..15
: GPIOC-MODER_MODER10   ( %XX -- ) 20 lshift GPIOC-MODER bis! ;  \ GPIOC-MODER_MODER10    Port x configuration bits y =
  0..15
: GPIOC-MODER_MODER9   ( %XX -- ) 18 lshift GPIOC-MODER bis! ;  \ GPIOC-MODER_MODER9    Port x configuration bits y =
  0..15
: GPIOC-MODER_MODER8   ( %XX -- ) 16 lshift GPIOC-MODER bis! ;  \ GPIOC-MODER_MODER8    Port x configuration bits y =
  0..15
: GPIOC-MODER_MODER7   ( %XX -- ) 14 lshift GPIOC-MODER bis! ;  \ GPIOC-MODER_MODER7    Port x configuration bits y =
  0..15
: GPIOC-MODER_MODER6   ( %XX -- ) 12 lshift GPIOC-MODER bis! ;  \ GPIOC-MODER_MODER6    Port x configuration bits y =
  0..15
: GPIOC-MODER_MODER5   ( %XX -- ) 10 lshift GPIOC-MODER bis! ;  \ GPIOC-MODER_MODER5    Port x configuration bits y =
  0..15
: GPIOC-MODER_MODER4   ( %XX -- ) 8 lshift GPIOC-MODER bis! ;  \ GPIOC-MODER_MODER4    Port x configuration bits y =
  0..15
: GPIOC-MODER_MODER3   ( %XX -- ) 6 lshift GPIOC-MODER bis! ;  \ GPIOC-MODER_MODER3    Port x configuration bits y =
  0..15
: GPIOC-MODER_MODER2   ( %XX -- ) 4 lshift GPIOC-MODER bis! ;  \ GPIOC-MODER_MODER2    Port x configuration bits y =
  0..15
: GPIOC-MODER_MODER1   ( %XX -- ) 2 lshift GPIOC-MODER bis! ;  \ GPIOC-MODER_MODER1    Port x configuration bits y =
  0..15
: GPIOC-MODER_MODER0   ( %XX -- ) 0 lshift GPIOC-MODER bis! ;  \ GPIOC-MODER_MODER0    Port x configuration bits y =
  0..15

\ GPIOC-OTYPER (read-write)
: GPIOC-OTYPER_OT15   %1 15 lshift GPIOC-OTYPER bis! ;  \ GPIOC-OTYPER_OT15    Port x configuration bits y =
  0..15
: GPIOC-OTYPER_OT14   %1 14 lshift GPIOC-OTYPER bis! ;  \ GPIOC-OTYPER_OT14    Port x configuration bits y =
  0..15
: GPIOC-OTYPER_OT13   %1 13 lshift GPIOC-OTYPER bis! ;  \ GPIOC-OTYPER_OT13    Port x configuration bits y =
  0..15
: GPIOC-OTYPER_OT12   %1 12 lshift GPIOC-OTYPER bis! ;  \ GPIOC-OTYPER_OT12    Port x configuration bits y =
  0..15
: GPIOC-OTYPER_OT11   %1 11 lshift GPIOC-OTYPER bis! ;  \ GPIOC-OTYPER_OT11    Port x configuration bits y =
  0..15
: GPIOC-OTYPER_OT10   %1 10 lshift GPIOC-OTYPER bis! ;  \ GPIOC-OTYPER_OT10    Port x configuration bits y =
  0..15
: GPIOC-OTYPER_OT9   %1 9 lshift GPIOC-OTYPER bis! ;  \ GPIOC-OTYPER_OT9    Port x configuration bits y =
  0..15
: GPIOC-OTYPER_OT8   %1 8 lshift GPIOC-OTYPER bis! ;  \ GPIOC-OTYPER_OT8    Port x configuration bits y =
  0..15
: GPIOC-OTYPER_OT7   %1 7 lshift GPIOC-OTYPER bis! ;  \ GPIOC-OTYPER_OT7    Port x configuration bits y =
  0..15
: GPIOC-OTYPER_OT6   %1 6 lshift GPIOC-OTYPER bis! ;  \ GPIOC-OTYPER_OT6    Port x configuration bits y =
  0..15
: GPIOC-OTYPER_OT5   %1 5 lshift GPIOC-OTYPER bis! ;  \ GPIOC-OTYPER_OT5    Port x configuration bits y =
  0..15
: GPIOC-OTYPER_OT4   %1 4 lshift GPIOC-OTYPER bis! ;  \ GPIOC-OTYPER_OT4    Port x configuration bits y =
  0..15
: GPIOC-OTYPER_OT3   %1 3 lshift GPIOC-OTYPER bis! ;  \ GPIOC-OTYPER_OT3    Port x configuration bits y =
  0..15
: GPIOC-OTYPER_OT2   %1 2 lshift GPIOC-OTYPER bis! ;  \ GPIOC-OTYPER_OT2    Port x configuration bits y =
  0..15
: GPIOC-OTYPER_OT1   %1 1 lshift GPIOC-OTYPER bis! ;  \ GPIOC-OTYPER_OT1    Port x configuration bits y =
  0..15
: GPIOC-OTYPER_OT0   %1 0 lshift GPIOC-OTYPER bis! ;  \ GPIOC-OTYPER_OT0    Port x configuration bits y =
  0..15

\ GPIOC-OSPEEDR (read-write)
: GPIOC-OSPEEDR_OSPEEDR15   ( %XX -- ) 30 lshift GPIOC-OSPEEDR bis! ;  \ GPIOC-OSPEEDR_OSPEEDR15    Port x configuration bits y =
  0..15
: GPIOC-OSPEEDR_OSPEEDR14   ( %XX -- ) 28 lshift GPIOC-OSPEEDR bis! ;  \ GPIOC-OSPEEDR_OSPEEDR14    Port x configuration bits y =
  0..15
: GPIOC-OSPEEDR_OSPEEDR13   ( %XX -- ) 26 lshift GPIOC-OSPEEDR bis! ;  \ GPIOC-OSPEEDR_OSPEEDR13    Port x configuration bits y =
  0..15
: GPIOC-OSPEEDR_OSPEEDR12   ( %XX -- ) 24 lshift GPIOC-OSPEEDR bis! ;  \ GPIOC-OSPEEDR_OSPEEDR12    Port x configuration bits y =
  0..15
: GPIOC-OSPEEDR_OSPEEDR11   ( %XX -- ) 22 lshift GPIOC-OSPEEDR bis! ;  \ GPIOC-OSPEEDR_OSPEEDR11    Port x configuration bits y =
  0..15
: GPIOC-OSPEEDR_OSPEEDR10   ( %XX -- ) 20 lshift GPIOC-OSPEEDR bis! ;  \ GPIOC-OSPEEDR_OSPEEDR10    Port x configuration bits y =
  0..15
: GPIOC-OSPEEDR_OSPEEDR9   ( %XX -- ) 18 lshift GPIOC-OSPEEDR bis! ;  \ GPIOC-OSPEEDR_OSPEEDR9    Port x configuration bits y =
  0..15
: GPIOC-OSPEEDR_OSPEEDR8   ( %XX -- ) 16 lshift GPIOC-OSPEEDR bis! ;  \ GPIOC-OSPEEDR_OSPEEDR8    Port x configuration bits y =
  0..15
: GPIOC-OSPEEDR_OSPEEDR7   ( %XX -- ) 14 lshift GPIOC-OSPEEDR bis! ;  \ GPIOC-OSPEEDR_OSPEEDR7    Port x configuration bits y =
  0..15
: GPIOC-OSPEEDR_OSPEEDR6   ( %XX -- ) 12 lshift GPIOC-OSPEEDR bis! ;  \ GPIOC-OSPEEDR_OSPEEDR6    Port x configuration bits y =
  0..15
: GPIOC-OSPEEDR_OSPEEDR5   ( %XX -- ) 10 lshift GPIOC-OSPEEDR bis! ;  \ GPIOC-OSPEEDR_OSPEEDR5    Port x configuration bits y =
  0..15
: GPIOC-OSPEEDR_OSPEEDR4   ( %XX -- ) 8 lshift GPIOC-OSPEEDR bis! ;  \ GPIOC-OSPEEDR_OSPEEDR4    Port x configuration bits y =
  0..15
: GPIOC-OSPEEDR_OSPEEDR3   ( %XX -- ) 6 lshift GPIOC-OSPEEDR bis! ;  \ GPIOC-OSPEEDR_OSPEEDR3    Port x configuration bits y =
  0..15
: GPIOC-OSPEEDR_OSPEEDR2   ( %XX -- ) 4 lshift GPIOC-OSPEEDR bis! ;  \ GPIOC-OSPEEDR_OSPEEDR2    Port x configuration bits y =
  0..15
: GPIOC-OSPEEDR_OSPEEDR1   ( %XX -- ) 2 lshift GPIOC-OSPEEDR bis! ;  \ GPIOC-OSPEEDR_OSPEEDR1    Port x configuration bits y =
  0..15
: GPIOC-OSPEEDR_OSPEEDR0   ( %XX -- ) 0 lshift GPIOC-OSPEEDR bis! ;  \ GPIOC-OSPEEDR_OSPEEDR0    Port x configuration bits y =
  0..15

\ GPIOC-PUPDR (read-write)
: GPIOC-PUPDR_PUPDR15   ( %XX -- ) 30 lshift GPIOC-PUPDR bis! ;  \ GPIOC-PUPDR_PUPDR15    Port x configuration bits y =
  0..15
: GPIOC-PUPDR_PUPDR14   ( %XX -- ) 28 lshift GPIOC-PUPDR bis! ;  \ GPIOC-PUPDR_PUPDR14    Port x configuration bits y =
  0..15
: GPIOC-PUPDR_PUPDR13   ( %XX -- ) 26 lshift GPIOC-PUPDR bis! ;  \ GPIOC-PUPDR_PUPDR13    Port x configuration bits y =
  0..15
: GPIOC-PUPDR_PUPDR12   ( %XX -- ) 24 lshift GPIOC-PUPDR bis! ;  \ GPIOC-PUPDR_PUPDR12    Port x configuration bits y =
  0..15
: GPIOC-PUPDR_PUPDR11   ( %XX -- ) 22 lshift GPIOC-PUPDR bis! ;  \ GPIOC-PUPDR_PUPDR11    Port x configuration bits y =
  0..15
: GPIOC-PUPDR_PUPDR10   ( %XX -- ) 20 lshift GPIOC-PUPDR bis! ;  \ GPIOC-PUPDR_PUPDR10    Port x configuration bits y =
  0..15
: GPIOC-PUPDR_PUPDR9   ( %XX -- ) 18 lshift GPIOC-PUPDR bis! ;  \ GPIOC-PUPDR_PUPDR9    Port x configuration bits y =
  0..15
: GPIOC-PUPDR_PUPDR8   ( %XX -- ) 16 lshift GPIOC-PUPDR bis! ;  \ GPIOC-PUPDR_PUPDR8    Port x configuration bits y =
  0..15
: GPIOC-PUPDR_PUPDR7   ( %XX -- ) 14 lshift GPIOC-PUPDR bis! ;  \ GPIOC-PUPDR_PUPDR7    Port x configuration bits y =
  0..15
: GPIOC-PUPDR_PUPDR6   ( %XX -- ) 12 lshift GPIOC-PUPDR bis! ;  \ GPIOC-PUPDR_PUPDR6    Port x configuration bits y =
  0..15
: GPIOC-PUPDR_PUPDR5   ( %XX -- ) 10 lshift GPIOC-PUPDR bis! ;  \ GPIOC-PUPDR_PUPDR5    Port x configuration bits y =
  0..15
: GPIOC-PUPDR_PUPDR4   ( %XX -- ) 8 lshift GPIOC-PUPDR bis! ;  \ GPIOC-PUPDR_PUPDR4    Port x configuration bits y =
  0..15
: GPIOC-PUPDR_PUPDR3   ( %XX -- ) 6 lshift GPIOC-PUPDR bis! ;  \ GPIOC-PUPDR_PUPDR3    Port x configuration bits y =
  0..15
: GPIOC-PUPDR_PUPDR2   ( %XX -- ) 4 lshift GPIOC-PUPDR bis! ;  \ GPIOC-PUPDR_PUPDR2    Port x configuration bits y =
  0..15
: GPIOC-PUPDR_PUPDR1   ( %XX -- ) 2 lshift GPIOC-PUPDR bis! ;  \ GPIOC-PUPDR_PUPDR1    Port x configuration bits y =
  0..15
: GPIOC-PUPDR_PUPDR0   ( %XX -- ) 0 lshift GPIOC-PUPDR bis! ;  \ GPIOC-PUPDR_PUPDR0    Port x configuration bits y =
  0..15

\ GPIOC-IDR (read-only)
: GPIOC-IDR_IDR15   %1 15 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR15    Port input data y =
  0..15
: GPIOC-IDR_IDR14   %1 14 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR14    Port input data y =
  0..15
: GPIOC-IDR_IDR13   %1 13 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR13    Port input data y =
  0..15
: GPIOC-IDR_IDR12   %1 12 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR12    Port input data y =
  0..15
: GPIOC-IDR_IDR11   %1 11 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR11    Port input data y =
  0..15
: GPIOC-IDR_IDR10   %1 10 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR10    Port input data y =
  0..15
: GPIOC-IDR_IDR9   %1 9 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR9    Port input data y =
  0..15
: GPIOC-IDR_IDR8   %1 8 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR8    Port input data y =
  0..15
: GPIOC-IDR_IDR7   %1 7 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR7    Port input data y =
  0..15
: GPIOC-IDR_IDR6   %1 6 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR6    Port input data y =
  0..15
: GPIOC-IDR_IDR5   %1 5 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR5    Port input data y =
  0..15
: GPIOC-IDR_IDR4   %1 4 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR4    Port input data y =
  0..15
: GPIOC-IDR_IDR3   %1 3 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR3    Port input data y =
  0..15
: GPIOC-IDR_IDR2   %1 2 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR2    Port input data y =
  0..15
: GPIOC-IDR_IDR1   %1 1 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR1    Port input data y =
  0..15
: GPIOC-IDR_IDR0   %1 0 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR0    Port input data y =
  0..15

\ GPIOC-ODR (read-write)
: GPIOC-ODR_ODR15   %1 15 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR15    Port output data y =
  0..15
: GPIOC-ODR_ODR14   %1 14 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR14    Port output data y =
  0..15
: GPIOC-ODR_ODR13   %1 13 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR13    Port output data y =
  0..15
: GPIOC-ODR_ODR12   %1 12 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR12    Port output data y =
  0..15
: GPIOC-ODR_ODR11   %1 11 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR11    Port output data y =
  0..15
: GPIOC-ODR_ODR10   %1 10 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR10    Port output data y =
  0..15
: GPIOC-ODR_ODR9   %1 9 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR9    Port output data y =
  0..15
: GPIOC-ODR_ODR8   %1 8 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR8    Port output data y =
  0..15
: GPIOC-ODR_ODR7   %1 7 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR7    Port output data y =
  0..15
: GPIOC-ODR_ODR6   %1 6 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR6    Port output data y =
  0..15
: GPIOC-ODR_ODR5   %1 5 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR5    Port output data y =
  0..15
: GPIOC-ODR_ODR4   %1 4 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR4    Port output data y =
  0..15
: GPIOC-ODR_ODR3   %1 3 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR3    Port output data y =
  0..15
: GPIOC-ODR_ODR2   %1 2 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR2    Port output data y =
  0..15
: GPIOC-ODR_ODR1   %1 1 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR1    Port output data y =
  0..15
: GPIOC-ODR_ODR0   %1 0 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR0    Port output data y =
  0..15

\ GPIOC-BSRR (write-only)
: GPIOC-BSRR_BR15   %1 31 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR15    Port x reset bit y y =
  0..15
: GPIOC-BSRR_BR14   %1 30 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR14    Port x reset bit y y =
  0..15
: GPIOC-BSRR_BR13   %1 29 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR13    Port x reset bit y y =
  0..15
: GPIOC-BSRR_BR12   %1 28 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR12    Port x reset bit y y =
  0..15
: GPIOC-BSRR_BR11   %1 27 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR11    Port x reset bit y y =
  0..15
: GPIOC-BSRR_BR10   %1 26 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR10    Port x reset bit y y =
  0..15
: GPIOC-BSRR_BR9   %1 25 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR9    Port x reset bit y y =
  0..15
: GPIOC-BSRR_BR8   %1 24 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR8    Port x reset bit y y =
  0..15
: GPIOC-BSRR_BR7   %1 23 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR7    Port x reset bit y y =
  0..15
: GPIOC-BSRR_BR6   %1 22 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR6    Port x reset bit y y =
  0..15
: GPIOC-BSRR_BR5   %1 21 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR5    Port x reset bit y y =
  0..15
: GPIOC-BSRR_BR4   %1 20 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR4    Port x reset bit y y =
  0..15
: GPIOC-BSRR_BR3   %1 19 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR3    Port x reset bit y y =
  0..15
: GPIOC-BSRR_BR2   %1 18 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR2    Port x reset bit y y =
  0..15
: GPIOC-BSRR_BR1   %1 17 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR1    Port x reset bit y y =
  0..15
: GPIOC-BSRR_BR0   %1 16 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR0    Port x set bit y y=
  0..15
: GPIOC-BSRR_BS15   %1 15 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS15    Port x set bit y y=
  0..15
: GPIOC-BSRR_BS14   %1 14 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS14    Port x set bit y y=
  0..15
: GPIOC-BSRR_BS13   %1 13 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS13    Port x set bit y y=
  0..15
: GPIOC-BSRR_BS12   %1 12 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS12    Port x set bit y y=
  0..15
: GPIOC-BSRR_BS11   %1 11 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS11    Port x set bit y y=
  0..15
: GPIOC-BSRR_BS10   %1 10 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS10    Port x set bit y y=
  0..15
: GPIOC-BSRR_BS9   %1 9 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS9    Port x set bit y y=
  0..15
: GPIOC-BSRR_BS8   %1 8 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS8    Port x set bit y y=
  0..15
: GPIOC-BSRR_BS7   %1 7 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS7    Port x set bit y y=
  0..15
: GPIOC-BSRR_BS6   %1 6 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS6    Port x set bit y y=
  0..15
: GPIOC-BSRR_BS5   %1 5 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS5    Port x set bit y y=
  0..15
: GPIOC-BSRR_BS4   %1 4 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS4    Port x set bit y y=
  0..15
: GPIOC-BSRR_BS3   %1 3 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS3    Port x set bit y y=
  0..15
: GPIOC-BSRR_BS2   %1 2 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS2    Port x set bit y y=
  0..15
: GPIOC-BSRR_BS1   %1 1 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS1    Port x set bit y y=
  0..15
: GPIOC-BSRR_BS0   %1 0 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS0    Port x set bit y y=
  0..15

\ GPIOC-LCKR (read-write)
: GPIOC-LCKR_LCKK   %1 16 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCKK    Port x lock bit y y=
  0..15
: GPIOC-LCKR_LCK15   %1 15 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK15    Port x lock bit y y=
  0..15
: GPIOC-LCKR_LCK14   %1 14 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK14    Port x lock bit y y=
  0..15
: GPIOC-LCKR_LCK13   %1 13 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK13    Port x lock bit y y=
  0..15
: GPIOC-LCKR_LCK12   %1 12 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK12    Port x lock bit y y=
  0..15
: GPIOC-LCKR_LCK11   %1 11 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK11    Port x lock bit y y=
  0..15
: GPIOC-LCKR_LCK10   %1 10 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK10    Port x lock bit y y=
  0..15
: GPIOC-LCKR_LCK9   %1 9 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK9    Port x lock bit y y=
  0..15
: GPIOC-LCKR_LCK8   %1 8 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK8    Port x lock bit y y=
  0..15
: GPIOC-LCKR_LCK7   %1 7 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK7    Port x lock bit y y=
  0..15
: GPIOC-LCKR_LCK6   %1 6 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK6    Port x lock bit y y=
  0..15
: GPIOC-LCKR_LCK5   %1 5 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK5    Port x lock bit y y=
  0..15
: GPIOC-LCKR_LCK4   %1 4 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK4    Port x lock bit y y=
  0..15
: GPIOC-LCKR_LCK3   %1 3 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK3    Port x lock bit y y=
  0..15
: GPIOC-LCKR_LCK2   %1 2 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK2    Port x lock bit y y=
  0..15
: GPIOC-LCKR_LCK1   %1 1 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK1    Port x lock bit y y=
  0..15
: GPIOC-LCKR_LCK0   %1 0 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK0    Port x lock bit y y=
  0..15

\ GPIOC-AFRL (read-write)
: GPIOC-AFRL_AFRL7   ( %XXXX -- ) 28 lshift GPIOC-AFRL bis! ;  \ GPIOC-AFRL_AFRL7    Alternate function selection for port x
  bit y y = 0..7
: GPIOC-AFRL_AFRL6   ( %XXXX -- ) 24 lshift GPIOC-AFRL bis! ;  \ GPIOC-AFRL_AFRL6    Alternate function selection for port x
  bit y y = 0..7
: GPIOC-AFRL_AFRL5   ( %XXXX -- ) 20 lshift GPIOC-AFRL bis! ;  \ GPIOC-AFRL_AFRL5    Alternate function selection for port x
  bit y y = 0..7
: GPIOC-AFRL_AFRL4   ( %XXXX -- ) 16 lshift GPIOC-AFRL bis! ;  \ GPIOC-AFRL_AFRL4    Alternate function selection for port x
  bit y y = 0..7
: GPIOC-AFRL_AFRL3   ( %XXXX -- ) 12 lshift GPIOC-AFRL bis! ;  \ GPIOC-AFRL_AFRL3    Alternate function selection for port x
  bit y y = 0..7
: GPIOC-AFRL_AFRL2   ( %XXXX -- ) 8 lshift GPIOC-AFRL bis! ;  \ GPIOC-AFRL_AFRL2    Alternate function selection for port x
  bit y y = 0..7
: GPIOC-AFRL_AFRL1   ( %XXXX -- ) 4 lshift GPIOC-AFRL bis! ;  \ GPIOC-AFRL_AFRL1    Alternate function selection for port x
  bit y y = 0..7
: GPIOC-AFRL_AFRL0   ( %XXXX -- ) 0 lshift GPIOC-AFRL bis! ;  \ GPIOC-AFRL_AFRL0    Alternate function selection for port x
  bit y y = 0..7

\ GPIOC-AFRH (read-write)
: GPIOC-AFRH_AFRH15   ( %XXXX -- ) 28 lshift GPIOC-AFRH bis! ;  \ GPIOC-AFRH_AFRH15    Alternate function selection for port x
  bit y y = 8..15
: GPIOC-AFRH_AFRH14   ( %XXXX -- ) 24 lshift GPIOC-AFRH bis! ;  \ GPIOC-AFRH_AFRH14    Alternate function selection for port x
  bit y y = 8..15
: GPIOC-AFRH_AFRH13   ( %XXXX -- ) 20 lshift GPIOC-AFRH bis! ;  \ GPIOC-AFRH_AFRH13    Alternate function selection for port x
  bit y y = 8..15
: GPIOC-AFRH_AFRH12   ( %XXXX -- ) 16 lshift GPIOC-AFRH bis! ;  \ GPIOC-AFRH_AFRH12    Alternate function selection for port x
  bit y y = 8..15
: GPIOC-AFRH_AFRH11   ( %XXXX -- ) 12 lshift GPIOC-AFRH bis! ;  \ GPIOC-AFRH_AFRH11    Alternate function selection for port x
  bit y y = 8..15
: GPIOC-AFRH_AFRH10   ( %XXXX -- ) 8 lshift GPIOC-AFRH bis! ;  \ GPIOC-AFRH_AFRH10    Alternate function selection for port x
  bit y y = 8..15
: GPIOC-AFRH_AFRH9   ( %XXXX -- ) 4 lshift GPIOC-AFRH bis! ;  \ GPIOC-AFRH_AFRH9    Alternate function selection for port x
  bit y y = 8..15
: GPIOC-AFRH_AFRH8   ( %XXXX -- ) 0 lshift GPIOC-AFRH bis! ;  \ GPIOC-AFRH_AFRH8    Alternate function selection for port x
  bit y y = 8..15

\ GPIOB-MODER (read-write)
: GPIOB-MODER_MODER15   ( %XX -- ) 30 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER15    Port x configuration bits y =
  0..15
: GPIOB-MODER_MODER14   ( %XX -- ) 28 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER14    Port x configuration bits y =
  0..15
: GPIOB-MODER_MODER13   ( %XX -- ) 26 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER13    Port x configuration bits y =
  0..15
: GPIOB-MODER_MODER12   ( %XX -- ) 24 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER12    Port x configuration bits y =
  0..15
: GPIOB-MODER_MODER11   ( %XX -- ) 22 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER11    Port x configuration bits y =
  0..15
: GPIOB-MODER_MODER10   ( %XX -- ) 20 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER10    Port x configuration bits y =
  0..15
: GPIOB-MODER_MODER9   ( %XX -- ) 18 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER9    Port x configuration bits y =
  0..15
: GPIOB-MODER_MODER8   ( %XX -- ) 16 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER8    Port x configuration bits y =
  0..15
: GPIOB-MODER_MODER7   ( %XX -- ) 14 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER7    Port x configuration bits y =
  0..15
: GPIOB-MODER_MODER6   ( %XX -- ) 12 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER6    Port x configuration bits y =
  0..15
: GPIOB-MODER_MODER5   ( %XX -- ) 10 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER5    Port x configuration bits y =
  0..15
: GPIOB-MODER_MODER4   ( %XX -- ) 8 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER4    Port x configuration bits y =
  0..15
: GPIOB-MODER_MODER3   ( %XX -- ) 6 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER3    Port x configuration bits y =
  0..15
: GPIOB-MODER_MODER2   ( %XX -- ) 4 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER2    Port x configuration bits y =
  0..15
: GPIOB-MODER_MODER1   ( %XX -- ) 2 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER1    Port x configuration bits y =
  0..15
: GPIOB-MODER_MODER0   ( %XX -- ) 0 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER0    Port x configuration bits y =
  0..15

\ GPIOB-OTYPER (read-write)
: GPIOB-OTYPER_OT15   %1 15 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT15    Port x configuration bits y =
  0..15
: GPIOB-OTYPER_OT14   %1 14 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT14    Port x configuration bits y =
  0..15
: GPIOB-OTYPER_OT13   %1 13 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT13    Port x configuration bits y =
  0..15
: GPIOB-OTYPER_OT12   %1 12 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT12    Port x configuration bits y =
  0..15
: GPIOB-OTYPER_OT11   %1 11 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT11    Port x configuration bits y =
  0..15
: GPIOB-OTYPER_OT10   %1 10 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT10    Port x configuration bits y =
  0..15
: GPIOB-OTYPER_OT9   %1 9 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT9    Port x configuration bits y =
  0..15
: GPIOB-OTYPER_OT8   %1 8 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT8    Port x configuration bits y =
  0..15
: GPIOB-OTYPER_OT7   %1 7 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT7    Port x configuration bits y =
  0..15
: GPIOB-OTYPER_OT6   %1 6 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT6    Port x configuration bits y =
  0..15
: GPIOB-OTYPER_OT5   %1 5 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT5    Port x configuration bits y =
  0..15
: GPIOB-OTYPER_OT4   %1 4 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT4    Port x configuration bits y =
  0..15
: GPIOB-OTYPER_OT3   %1 3 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT3    Port x configuration bits y =
  0..15
: GPIOB-OTYPER_OT2   %1 2 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT2    Port x configuration bits y =
  0..15
: GPIOB-OTYPER_OT1   %1 1 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT1    Port x configuration bits y =
  0..15
: GPIOB-OTYPER_OT0   %1 0 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT0    Port x configuration bits y =
  0..15

\ GPIOB-OSPEEDR (read-write)
: GPIOB-OSPEEDR_OSPEEDR15   ( %XX -- ) 30 lshift GPIOB-OSPEEDR bis! ;  \ GPIOB-OSPEEDR_OSPEEDR15    Port x configuration bits y =
  0..15
: GPIOB-OSPEEDR_OSPEEDR14   ( %XX -- ) 28 lshift GPIOB-OSPEEDR bis! ;  \ GPIOB-OSPEEDR_OSPEEDR14    Port x configuration bits y =
  0..15
: GPIOB-OSPEEDR_OSPEEDR13   ( %XX -- ) 26 lshift GPIOB-OSPEEDR bis! ;  \ GPIOB-OSPEEDR_OSPEEDR13    Port x configuration bits y =
  0..15
: GPIOB-OSPEEDR_OSPEEDR12   ( %XX -- ) 24 lshift GPIOB-OSPEEDR bis! ;  \ GPIOB-OSPEEDR_OSPEEDR12    Port x configuration bits y =
  0..15
: GPIOB-OSPEEDR_OSPEEDR11   ( %XX -- ) 22 lshift GPIOB-OSPEEDR bis! ;  \ GPIOB-OSPEEDR_OSPEEDR11    Port x configuration bits y =
  0..15
: GPIOB-OSPEEDR_OSPEEDR10   ( %XX -- ) 20 lshift GPIOB-OSPEEDR bis! ;  \ GPIOB-OSPEEDR_OSPEEDR10    Port x configuration bits y =
  0..15
: GPIOB-OSPEEDR_OSPEEDR9   ( %XX -- ) 18 lshift GPIOB-OSPEEDR bis! ;  \ GPIOB-OSPEEDR_OSPEEDR9    Port x configuration bits y =
  0..15
: GPIOB-OSPEEDR_OSPEEDR8   ( %XX -- ) 16 lshift GPIOB-OSPEEDR bis! ;  \ GPIOB-OSPEEDR_OSPEEDR8    Port x configuration bits y =
  0..15
: GPIOB-OSPEEDR_OSPEEDR7   ( %XX -- ) 14 lshift GPIOB-OSPEEDR bis! ;  \ GPIOB-OSPEEDR_OSPEEDR7    Port x configuration bits y =
  0..15
: GPIOB-OSPEEDR_OSPEEDR6   ( %XX -- ) 12 lshift GPIOB-OSPEEDR bis! ;  \ GPIOB-OSPEEDR_OSPEEDR6    Port x configuration bits y =
  0..15
: GPIOB-OSPEEDR_OSPEEDR5   ( %XX -- ) 10 lshift GPIOB-OSPEEDR bis! ;  \ GPIOB-OSPEEDR_OSPEEDR5    Port x configuration bits y =
  0..15
: GPIOB-OSPEEDR_OSPEEDR4   ( %XX -- ) 8 lshift GPIOB-OSPEEDR bis! ;  \ GPIOB-OSPEEDR_OSPEEDR4    Port x configuration bits y =
  0..15
: GPIOB-OSPEEDR_OSPEEDR3   ( %XX -- ) 6 lshift GPIOB-OSPEEDR bis! ;  \ GPIOB-OSPEEDR_OSPEEDR3    Port x configuration bits y =
  0..15
: GPIOB-OSPEEDR_OSPEEDR2   ( %XX -- ) 4 lshift GPIOB-OSPEEDR bis! ;  \ GPIOB-OSPEEDR_OSPEEDR2    Port x configuration bits y =
  0..15
: GPIOB-OSPEEDR_OSPEEDR1   ( %XX -- ) 2 lshift GPIOB-OSPEEDR bis! ;  \ GPIOB-OSPEEDR_OSPEEDR1    Port x configuration bits y =
  0..15
: GPIOB-OSPEEDR_OSPEEDR0   ( %XX -- ) 0 lshift GPIOB-OSPEEDR bis! ;  \ GPIOB-OSPEEDR_OSPEEDR0    Port x configuration bits y =
  0..15

\ GPIOB-PUPDR (read-write)
: GPIOB-PUPDR_PUPDR15   ( %XX -- ) 30 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR15    Port x configuration bits y =
  0..15
: GPIOB-PUPDR_PUPDR14   ( %XX -- ) 28 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR14    Port x configuration bits y =
  0..15
: GPIOB-PUPDR_PUPDR13   ( %XX -- ) 26 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR13    Port x configuration bits y =
  0..15
: GPIOB-PUPDR_PUPDR12   ( %XX -- ) 24 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR12    Port x configuration bits y =
  0..15
: GPIOB-PUPDR_PUPDR11   ( %XX -- ) 22 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR11    Port x configuration bits y =
  0..15
: GPIOB-PUPDR_PUPDR10   ( %XX -- ) 20 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR10    Port x configuration bits y =
  0..15
: GPIOB-PUPDR_PUPDR9   ( %XX -- ) 18 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR9    Port x configuration bits y =
  0..15
: GPIOB-PUPDR_PUPDR8   ( %XX -- ) 16 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR8    Port x configuration bits y =
  0..15
: GPIOB-PUPDR_PUPDR7   ( %XX -- ) 14 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR7    Port x configuration bits y =
  0..15
: GPIOB-PUPDR_PUPDR6   ( %XX -- ) 12 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR6    Port x configuration bits y =
  0..15
: GPIOB-PUPDR_PUPDR5   ( %XX -- ) 10 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR5    Port x configuration bits y =
  0..15
: GPIOB-PUPDR_PUPDR4   ( %XX -- ) 8 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR4    Port x configuration bits y =
  0..15
: GPIOB-PUPDR_PUPDR3   ( %XX -- ) 6 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR3    Port x configuration bits y =
  0..15
: GPIOB-PUPDR_PUPDR2   ( %XX -- ) 4 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR2    Port x configuration bits y =
  0..15
: GPIOB-PUPDR_PUPDR1   ( %XX -- ) 2 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR1    Port x configuration bits y =
  0..15
: GPIOB-PUPDR_PUPDR0   ( %XX -- ) 0 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR0    Port x configuration bits y =
  0..15

\ GPIOB-IDR (read-only)
: GPIOB-IDR_IDR15   %1 15 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR15    Port input data y =
  0..15
: GPIOB-IDR_IDR14   %1 14 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR14    Port input data y =
  0..15
: GPIOB-IDR_IDR13   %1 13 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR13    Port input data y =
  0..15
: GPIOB-IDR_IDR12   %1 12 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR12    Port input data y =
  0..15
: GPIOB-IDR_IDR11   %1 11 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR11    Port input data y =
  0..15
: GPIOB-IDR_IDR10   %1 10 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR10    Port input data y =
  0..15
: GPIOB-IDR_IDR9   %1 9 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR9    Port input data y =
  0..15
: GPIOB-IDR_IDR8   %1 8 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR8    Port input data y =
  0..15
: GPIOB-IDR_IDR7   %1 7 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR7    Port input data y =
  0..15
: GPIOB-IDR_IDR6   %1 6 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR6    Port input data y =
  0..15
: GPIOB-IDR_IDR5   %1 5 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR5    Port input data y =
  0..15
: GPIOB-IDR_IDR4   %1 4 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR4    Port input data y =
  0..15
: GPIOB-IDR_IDR3   %1 3 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR3    Port input data y =
  0..15
: GPIOB-IDR_IDR2   %1 2 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR2    Port input data y =
  0..15
: GPIOB-IDR_IDR1   %1 1 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR1    Port input data y =
  0..15
: GPIOB-IDR_IDR0   %1 0 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR0    Port input data y =
  0..15

\ GPIOB-ODR (read-write)
: GPIOB-ODR_ODR15   %1 15 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR15    Port output data y =
  0..15
: GPIOB-ODR_ODR14   %1 14 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR14    Port output data y =
  0..15
: GPIOB-ODR_ODR13   %1 13 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR13    Port output data y =
  0..15
: GPIOB-ODR_ODR12   %1 12 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR12    Port output data y =
  0..15
: GPIOB-ODR_ODR11   %1 11 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR11    Port output data y =
  0..15
: GPIOB-ODR_ODR10   %1 10 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR10    Port output data y =
  0..15
: GPIOB-ODR_ODR9   %1 9 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR9    Port output data y =
  0..15
: GPIOB-ODR_ODR8   %1 8 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR8    Port output data y =
  0..15
: GPIOB-ODR_ODR7   %1 7 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR7    Port output data y =
  0..15
: GPIOB-ODR_ODR6   %1 6 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR6    Port output data y =
  0..15
: GPIOB-ODR_ODR5   %1 5 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR5    Port output data y =
  0..15
: GPIOB-ODR_ODR4   %1 4 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR4    Port output data y =
  0..15
: GPIOB-ODR_ODR3   %1 3 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR3    Port output data y =
  0..15
: GPIOB-ODR_ODR2   %1 2 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR2    Port output data y =
  0..15
: GPIOB-ODR_ODR1   %1 1 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR1    Port output data y =
  0..15
: GPIOB-ODR_ODR0   %1 0 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR0    Port output data y =
  0..15

\ GPIOB-BSRR (write-only)
: GPIOB-BSRR_BR15   %1 31 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR15    Port x reset bit y y =
  0..15
: GPIOB-BSRR_BR14   %1 30 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR14    Port x reset bit y y =
  0..15
: GPIOB-BSRR_BR13   %1 29 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR13    Port x reset bit y y =
  0..15
: GPIOB-BSRR_BR12   %1 28 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR12    Port x reset bit y y =
  0..15
: GPIOB-BSRR_BR11   %1 27 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR11    Port x reset bit y y =
  0..15
: GPIOB-BSRR_BR10   %1 26 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR10    Port x reset bit y y =
  0..15
: GPIOB-BSRR_BR9   %1 25 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR9    Port x reset bit y y =
  0..15
: GPIOB-BSRR_BR8   %1 24 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR8    Port x reset bit y y =
  0..15
: GPIOB-BSRR_BR7   %1 23 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR7    Port x reset bit y y =
  0..15
: GPIOB-BSRR_BR6   %1 22 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR6    Port x reset bit y y =
  0..15
: GPIOB-BSRR_BR5   %1 21 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR5    Port x reset bit y y =
  0..15
: GPIOB-BSRR_BR4   %1 20 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR4    Port x reset bit y y =
  0..15
: GPIOB-BSRR_BR3   %1 19 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR3    Port x reset bit y y =
  0..15
: GPIOB-BSRR_BR2   %1 18 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR2    Port x reset bit y y =
  0..15
: GPIOB-BSRR_BR1   %1 17 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR1    Port x reset bit y y =
  0..15
: GPIOB-BSRR_BR0   %1 16 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR0    Port x set bit y y=
  0..15
: GPIOB-BSRR_BS15   %1 15 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS15    Port x set bit y y=
  0..15
: GPIOB-BSRR_BS14   %1 14 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS14    Port x set bit y y=
  0..15
: GPIOB-BSRR_BS13   %1 13 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS13    Port x set bit y y=
  0..15
: GPIOB-BSRR_BS12   %1 12 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS12    Port x set bit y y=
  0..15
: GPIOB-BSRR_BS11   %1 11 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS11    Port x set bit y y=
  0..15
: GPIOB-BSRR_BS10   %1 10 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS10    Port x set bit y y=
  0..15
: GPIOB-BSRR_BS9   %1 9 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS9    Port x set bit y y=
  0..15
: GPIOB-BSRR_BS8   %1 8 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS8    Port x set bit y y=
  0..15
: GPIOB-BSRR_BS7   %1 7 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS7    Port x set bit y y=
  0..15
: GPIOB-BSRR_BS6   %1 6 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS6    Port x set bit y y=
  0..15
: GPIOB-BSRR_BS5   %1 5 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS5    Port x set bit y y=
  0..15
: GPIOB-BSRR_BS4   %1 4 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS4    Port x set bit y y=
  0..15
: GPIOB-BSRR_BS3   %1 3 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS3    Port x set bit y y=
  0..15
: GPIOB-BSRR_BS2   %1 2 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS2    Port x set bit y y=
  0..15
: GPIOB-BSRR_BS1   %1 1 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS1    Port x set bit y y=
  0..15
: GPIOB-BSRR_BS0   %1 0 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS0    Port x set bit y y=
  0..15

\ GPIOB-LCKR (read-write)
: GPIOB-LCKR_LCKK   %1 16 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCKK    Port x lock bit y y=
  0..15
: GPIOB-LCKR_LCK15   %1 15 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK15    Port x lock bit y y=
  0..15
: GPIOB-LCKR_LCK14   %1 14 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK14    Port x lock bit y y=
  0..15
: GPIOB-LCKR_LCK13   %1 13 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK13    Port x lock bit y y=
  0..15
: GPIOB-LCKR_LCK12   %1 12 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK12    Port x lock bit y y=
  0..15
: GPIOB-LCKR_LCK11   %1 11 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK11    Port x lock bit y y=
  0..15
: GPIOB-LCKR_LCK10   %1 10 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK10    Port x lock bit y y=
  0..15
: GPIOB-LCKR_LCK9   %1 9 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK9    Port x lock bit y y=
  0..15
: GPIOB-LCKR_LCK8   %1 8 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK8    Port x lock bit y y=
  0..15
: GPIOB-LCKR_LCK7   %1 7 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK7    Port x lock bit y y=
  0..15
: GPIOB-LCKR_LCK6   %1 6 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK6    Port x lock bit y y=
  0..15
: GPIOB-LCKR_LCK5   %1 5 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK5    Port x lock bit y y=
  0..15
: GPIOB-LCKR_LCK4   %1 4 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK4    Port x lock bit y y=
  0..15
: GPIOB-LCKR_LCK3   %1 3 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK3    Port x lock bit y y=
  0..15
: GPIOB-LCKR_LCK2   %1 2 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK2    Port x lock bit y y=
  0..15
: GPIOB-LCKR_LCK1   %1 1 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK1    Port x lock bit y y=
  0..15
: GPIOB-LCKR_LCK0   %1 0 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK0    Port x lock bit y y=
  0..15

\ GPIOB-AFRL (read-write)
: GPIOB-AFRL_AFRL7   ( %XXXX -- ) 28 lshift GPIOB-AFRL bis! ;  \ GPIOB-AFRL_AFRL7    Alternate function selection for port x
  bit y y = 0..7
: GPIOB-AFRL_AFRL6   ( %XXXX -- ) 24 lshift GPIOB-AFRL bis! ;  \ GPIOB-AFRL_AFRL6    Alternate function selection for port x
  bit y y = 0..7
: GPIOB-AFRL_AFRL5   ( %XXXX -- ) 20 lshift GPIOB-AFRL bis! ;  \ GPIOB-AFRL_AFRL5    Alternate function selection for port x
  bit y y = 0..7
: GPIOB-AFRL_AFRL4   ( %XXXX -- ) 16 lshift GPIOB-AFRL bis! ;  \ GPIOB-AFRL_AFRL4    Alternate function selection for port x
  bit y y = 0..7
: GPIOB-AFRL_AFRL3   ( %XXXX -- ) 12 lshift GPIOB-AFRL bis! ;  \ GPIOB-AFRL_AFRL3    Alternate function selection for port x
  bit y y = 0..7
: GPIOB-AFRL_AFRL2   ( %XXXX -- ) 8 lshift GPIOB-AFRL bis! ;  \ GPIOB-AFRL_AFRL2    Alternate function selection for port x
  bit y y = 0..7
: GPIOB-AFRL_AFRL1   ( %XXXX -- ) 4 lshift GPIOB-AFRL bis! ;  \ GPIOB-AFRL_AFRL1    Alternate function selection for port x
  bit y y = 0..7
: GPIOB-AFRL_AFRL0   ( %XXXX -- ) 0 lshift GPIOB-AFRL bis! ;  \ GPIOB-AFRL_AFRL0    Alternate function selection for port x
  bit y y = 0..7

\ GPIOB-AFRH (read-write)
: GPIOB-AFRH_AFRH15   ( %XXXX -- ) 28 lshift GPIOB-AFRH bis! ;  \ GPIOB-AFRH_AFRH15    Alternate function selection for port x
  bit y y = 8..15
: GPIOB-AFRH_AFRH14   ( %XXXX -- ) 24 lshift GPIOB-AFRH bis! ;  \ GPIOB-AFRH_AFRH14    Alternate function selection for port x
  bit y y = 8..15
: GPIOB-AFRH_AFRH13   ( %XXXX -- ) 20 lshift GPIOB-AFRH bis! ;  \ GPIOB-AFRH_AFRH13    Alternate function selection for port x
  bit y y = 8..15
: GPIOB-AFRH_AFRH12   ( %XXXX -- ) 16 lshift GPIOB-AFRH bis! ;  \ GPIOB-AFRH_AFRH12    Alternate function selection for port x
  bit y y = 8..15
: GPIOB-AFRH_AFRH11   ( %XXXX -- ) 12 lshift GPIOB-AFRH bis! ;  \ GPIOB-AFRH_AFRH11    Alternate function selection for port x
  bit y y = 8..15
: GPIOB-AFRH_AFRH10   ( %XXXX -- ) 8 lshift GPIOB-AFRH bis! ;  \ GPIOB-AFRH_AFRH10    Alternate function selection for port x
  bit y y = 8..15
: GPIOB-AFRH_AFRH9   ( %XXXX -- ) 4 lshift GPIOB-AFRH bis! ;  \ GPIOB-AFRH_AFRH9    Alternate function selection for port x
  bit y y = 8..15
: GPIOB-AFRH_AFRH8   ( %XXXX -- ) 0 lshift GPIOB-AFRH bis! ;  \ GPIOB-AFRH_AFRH8    Alternate function selection for port x
  bit y y = 8..15

\ GPIOA-MODER (read-write)
: GPIOA-MODER_MODER15   ( %XX -- ) 30 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER15    Port x configuration bits y =
  0..15
: GPIOA-MODER_MODER14   ( %XX -- ) 28 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER14    Port x configuration bits y =
  0..15
: GPIOA-MODER_MODER13   ( %XX -- ) 26 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER13    Port x configuration bits y =
  0..15
: GPIOA-MODER_MODER12   ( %XX -- ) 24 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER12    Port x configuration bits y =
  0..15
: GPIOA-MODER_MODER11   ( %XX -- ) 22 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER11    Port x configuration bits y =
  0..15
: GPIOA-MODER_MODER10   ( %XX -- ) 20 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER10    Port x configuration bits y =
  0..15
: GPIOA-MODER_MODER9   ( %XX -- ) 18 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER9    Port x configuration bits y =
  0..15
: GPIOA-MODER_MODER8   ( %XX -- ) 16 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER8    Port x configuration bits y =
  0..15
: GPIOA-MODER_MODER7   ( %XX -- ) 14 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER7    Port x configuration bits y =
  0..15
: GPIOA-MODER_MODER6   ( %XX -- ) 12 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER6    Port x configuration bits y =
  0..15
: GPIOA-MODER_MODER5   ( %XX -- ) 10 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER5    Port x configuration bits y =
  0..15
: GPIOA-MODER_MODER4   ( %XX -- ) 8 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER4    Port x configuration bits y =
  0..15
: GPIOA-MODER_MODER3   ( %XX -- ) 6 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER3    Port x configuration bits y =
  0..15
: GPIOA-MODER_MODER2   ( %XX -- ) 4 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER2    Port x configuration bits y =
  0..15
: GPIOA-MODER_MODER1   ( %XX -- ) 2 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER1    Port x configuration bits y =
  0..15
: GPIOA-MODER_MODER0   ( %XX -- ) 0 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER0    Port x configuration bits y =
  0..15

\ GPIOA-OTYPER (read-write)
: GPIOA-OTYPER_OT15   %1 15 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT15    Port x configuration bits y =
  0..15
: GPIOA-OTYPER_OT14   %1 14 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT14    Port x configuration bits y =
  0..15
: GPIOA-OTYPER_OT13   %1 13 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT13    Port x configuration bits y =
  0..15
: GPIOA-OTYPER_OT12   %1 12 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT12    Port x configuration bits y =
  0..15
: GPIOA-OTYPER_OT11   %1 11 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT11    Port x configuration bits y =
  0..15
: GPIOA-OTYPER_OT10   %1 10 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT10    Port x configuration bits y =
  0..15
: GPIOA-OTYPER_OT9   %1 9 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT9    Port x configuration bits y =
  0..15
: GPIOA-OTYPER_OT8   %1 8 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT8    Port x configuration bits y =
  0..15
: GPIOA-OTYPER_OT7   %1 7 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT7    Port x configuration bits y =
  0..15
: GPIOA-OTYPER_OT6   %1 6 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT6    Port x configuration bits y =
  0..15
: GPIOA-OTYPER_OT5   %1 5 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT5    Port x configuration bits y =
  0..15
: GPIOA-OTYPER_OT4   %1 4 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT4    Port x configuration bits y =
  0..15
: GPIOA-OTYPER_OT3   %1 3 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT3    Port x configuration bits y =
  0..15
: GPIOA-OTYPER_OT2   %1 2 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT2    Port x configuration bits y =
  0..15
: GPIOA-OTYPER_OT1   %1 1 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT1    Port x configuration bits y =
  0..15
: GPIOA-OTYPER_OT0   %1 0 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT0    Port x configuration bits y =
  0..15

\ GPIOA-OSPEEDR (read-write)
: GPIOA-OSPEEDR_OSPEEDR15   ( %XX -- ) 30 lshift GPIOA-OSPEEDR bis! ;  \ GPIOA-OSPEEDR_OSPEEDR15    Port x configuration bits y =
  0..15
: GPIOA-OSPEEDR_OSPEEDR14   ( %XX -- ) 28 lshift GPIOA-OSPEEDR bis! ;  \ GPIOA-OSPEEDR_OSPEEDR14    Port x configuration bits y =
  0..15
: GPIOA-OSPEEDR_OSPEEDR13   ( %XX -- ) 26 lshift GPIOA-OSPEEDR bis! ;  \ GPIOA-OSPEEDR_OSPEEDR13    Port x configuration bits y =
  0..15
: GPIOA-OSPEEDR_OSPEEDR12   ( %XX -- ) 24 lshift GPIOA-OSPEEDR bis! ;  \ GPIOA-OSPEEDR_OSPEEDR12    Port x configuration bits y =
  0..15
: GPIOA-OSPEEDR_OSPEEDR11   ( %XX -- ) 22 lshift GPIOA-OSPEEDR bis! ;  \ GPIOA-OSPEEDR_OSPEEDR11    Port x configuration bits y =
  0..15
: GPIOA-OSPEEDR_OSPEEDR10   ( %XX -- ) 20 lshift GPIOA-OSPEEDR bis! ;  \ GPIOA-OSPEEDR_OSPEEDR10    Port x configuration bits y =
  0..15
: GPIOA-OSPEEDR_OSPEEDR9   ( %XX -- ) 18 lshift GPIOA-OSPEEDR bis! ;  \ GPIOA-OSPEEDR_OSPEEDR9    Port x configuration bits y =
  0..15
: GPIOA-OSPEEDR_OSPEEDR8   ( %XX -- ) 16 lshift GPIOA-OSPEEDR bis! ;  \ GPIOA-OSPEEDR_OSPEEDR8    Port x configuration bits y =
  0..15
: GPIOA-OSPEEDR_OSPEEDR7   ( %XX -- ) 14 lshift GPIOA-OSPEEDR bis! ;  \ GPIOA-OSPEEDR_OSPEEDR7    Port x configuration bits y =
  0..15
: GPIOA-OSPEEDR_OSPEEDR6   ( %XX -- ) 12 lshift GPIOA-OSPEEDR bis! ;  \ GPIOA-OSPEEDR_OSPEEDR6    Port x configuration bits y =
  0..15
: GPIOA-OSPEEDR_OSPEEDR5   ( %XX -- ) 10 lshift GPIOA-OSPEEDR bis! ;  \ GPIOA-OSPEEDR_OSPEEDR5    Port x configuration bits y =
  0..15
: GPIOA-OSPEEDR_OSPEEDR4   ( %XX -- ) 8 lshift GPIOA-OSPEEDR bis! ;  \ GPIOA-OSPEEDR_OSPEEDR4    Port x configuration bits y =
  0..15
: GPIOA-OSPEEDR_OSPEEDR3   ( %XX -- ) 6 lshift GPIOA-OSPEEDR bis! ;  \ GPIOA-OSPEEDR_OSPEEDR3    Port x configuration bits y =
  0..15
: GPIOA-OSPEEDR_OSPEEDR2   ( %XX -- ) 4 lshift GPIOA-OSPEEDR bis! ;  \ GPIOA-OSPEEDR_OSPEEDR2    Port x configuration bits y =
  0..15
: GPIOA-OSPEEDR_OSPEEDR1   ( %XX -- ) 2 lshift GPIOA-OSPEEDR bis! ;  \ GPIOA-OSPEEDR_OSPEEDR1    Port x configuration bits y =
  0..15
: GPIOA-OSPEEDR_OSPEEDR0   ( %XX -- ) 0 lshift GPIOA-OSPEEDR bis! ;  \ GPIOA-OSPEEDR_OSPEEDR0    Port x configuration bits y =
  0..15

\ GPIOA-PUPDR (read-write)
: GPIOA-PUPDR_PUPDR15   ( %XX -- ) 30 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR15    Port x configuration bits y =
  0..15
: GPIOA-PUPDR_PUPDR14   ( %XX -- ) 28 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR14    Port x configuration bits y =
  0..15
: GPIOA-PUPDR_PUPDR13   ( %XX -- ) 26 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR13    Port x configuration bits y =
  0..15
: GPIOA-PUPDR_PUPDR12   ( %XX -- ) 24 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR12    Port x configuration bits y =
  0..15
: GPIOA-PUPDR_PUPDR11   ( %XX -- ) 22 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR11    Port x configuration bits y =
  0..15
: GPIOA-PUPDR_PUPDR10   ( %XX -- ) 20 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR10    Port x configuration bits y =
  0..15
: GPIOA-PUPDR_PUPDR9   ( %XX -- ) 18 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR9    Port x configuration bits y =
  0..15
: GPIOA-PUPDR_PUPDR8   ( %XX -- ) 16 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR8    Port x configuration bits y =
  0..15
: GPIOA-PUPDR_PUPDR7   ( %XX -- ) 14 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR7    Port x configuration bits y =
  0..15
: GPIOA-PUPDR_PUPDR6   ( %XX -- ) 12 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR6    Port x configuration bits y =
  0..15
: GPIOA-PUPDR_PUPDR5   ( %XX -- ) 10 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR5    Port x configuration bits y =
  0..15
: GPIOA-PUPDR_PUPDR4   ( %XX -- ) 8 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR4    Port x configuration bits y =
  0..15
: GPIOA-PUPDR_PUPDR3   ( %XX -- ) 6 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR3    Port x configuration bits y =
  0..15
: GPIOA-PUPDR_PUPDR2   ( %XX -- ) 4 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR2    Port x configuration bits y =
  0..15
: GPIOA-PUPDR_PUPDR1   ( %XX -- ) 2 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR1    Port x configuration bits y =
  0..15
: GPIOA-PUPDR_PUPDR0   ( %XX -- ) 0 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR0    Port x configuration bits y =
  0..15

\ GPIOA-IDR (read-only)
: GPIOA-IDR_IDR15   %1 15 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR15    Port input data y =
  0..15
: GPIOA-IDR_IDR14   %1 14 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR14    Port input data y =
  0..15
: GPIOA-IDR_IDR13   %1 13 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR13    Port input data y =
  0..15
: GPIOA-IDR_IDR12   %1 12 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR12    Port input data y =
  0..15
: GPIOA-IDR_IDR11   %1 11 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR11    Port input data y =
  0..15
: GPIOA-IDR_IDR10   %1 10 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR10    Port input data y =
  0..15
: GPIOA-IDR_IDR9   %1 9 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR9    Port input data y =
  0..15
: GPIOA-IDR_IDR8   %1 8 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR8    Port input data y =
  0..15
: GPIOA-IDR_IDR7   %1 7 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR7    Port input data y =
  0..15
: GPIOA-IDR_IDR6   %1 6 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR6    Port input data y =
  0..15
: GPIOA-IDR_IDR5   %1 5 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR5    Port input data y =
  0..15
: GPIOA-IDR_IDR4   %1 4 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR4    Port input data y =
  0..15
: GPIOA-IDR_IDR3   %1 3 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR3    Port input data y =
  0..15
: GPIOA-IDR_IDR2   %1 2 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR2    Port input data y =
  0..15
: GPIOA-IDR_IDR1   %1 1 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR1    Port input data y =
  0..15
: GPIOA-IDR_IDR0   %1 0 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR0    Port input data y =
  0..15

\ GPIOA-ODR (read-write)
: GPIOA-ODR_ODR15   %1 15 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR15    Port output data y =
  0..15
: GPIOA-ODR_ODR14   %1 14 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR14    Port output data y =
  0..15
: GPIOA-ODR_ODR13   %1 13 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR13    Port output data y =
  0..15
: GPIOA-ODR_ODR12   %1 12 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR12    Port output data y =
  0..15
: GPIOA-ODR_ODR11   %1 11 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR11    Port output data y =
  0..15
: GPIOA-ODR_ODR10   %1 10 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR10    Port output data y =
  0..15
: GPIOA-ODR_ODR9   %1 9 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR9    Port output data y =
  0..15
: GPIOA-ODR_ODR8   %1 8 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR8    Port output data y =
  0..15
: GPIOA-ODR_ODR7   %1 7 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR7    Port output data y =
  0..15
: GPIOA-ODR_ODR6   %1 6 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR6    Port output data y =
  0..15
: GPIOA-ODR_ODR5   %1 5 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR5    Port output data y =
  0..15
: GPIOA-ODR_ODR4   %1 4 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR4    Port output data y =
  0..15
: GPIOA-ODR_ODR3   %1 3 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR3    Port output data y =
  0..15
: GPIOA-ODR_ODR2   %1 2 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR2    Port output data y =
  0..15
: GPIOA-ODR_ODR1   %1 1 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR1    Port output data y =
  0..15
: GPIOA-ODR_ODR0   %1 0 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR0    Port output data y =
  0..15

\ GPIOA-BSRR (write-only)
: GPIOA-BSRR_BR15   %1 31 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR15    Port x reset bit y y =
  0..15
: GPIOA-BSRR_BR14   %1 30 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR14    Port x reset bit y y =
  0..15
: GPIOA-BSRR_BR13   %1 29 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR13    Port x reset bit y y =
  0..15
: GPIOA-BSRR_BR12   %1 28 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR12    Port x reset bit y y =
  0..15
: GPIOA-BSRR_BR11   %1 27 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR11    Port x reset bit y y =
  0..15
: GPIOA-BSRR_BR10   %1 26 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR10    Port x reset bit y y =
  0..15
: GPIOA-BSRR_BR9   %1 25 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR9    Port x reset bit y y =
  0..15
: GPIOA-BSRR_BR8   %1 24 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR8    Port x reset bit y y =
  0..15
: GPIOA-BSRR_BR7   %1 23 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR7    Port x reset bit y y =
  0..15
: GPIOA-BSRR_BR6   %1 22 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR6    Port x reset bit y y =
  0..15
: GPIOA-BSRR_BR5   %1 21 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR5    Port x reset bit y y =
  0..15
: GPIOA-BSRR_BR4   %1 20 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR4    Port x reset bit y y =
  0..15
: GPIOA-BSRR_BR3   %1 19 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR3    Port x reset bit y y =
  0..15
: GPIOA-BSRR_BR2   %1 18 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR2    Port x reset bit y y =
  0..15
: GPIOA-BSRR_BR1   %1 17 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR1    Port x reset bit y y =
  0..15
: GPIOA-BSRR_BR0   %1 16 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR0    Port x set bit y y=
  0..15
: GPIOA-BSRR_BS15   %1 15 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS15    Port x set bit y y=
  0..15
: GPIOA-BSRR_BS14   %1 14 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS14    Port x set bit y y=
  0..15
: GPIOA-BSRR_BS13   %1 13 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS13    Port x set bit y y=
  0..15
: GPIOA-BSRR_BS12   %1 12 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS12    Port x set bit y y=
  0..15
: GPIOA-BSRR_BS11   %1 11 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS11    Port x set bit y y=
  0..15
: GPIOA-BSRR_BS10   %1 10 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS10    Port x set bit y y=
  0..15
: GPIOA-BSRR_BS9   %1 9 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS9    Port x set bit y y=
  0..15
: GPIOA-BSRR_BS8   %1 8 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS8    Port x set bit y y=
  0..15
: GPIOA-BSRR_BS7   %1 7 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS7    Port x set bit y y=
  0..15
: GPIOA-BSRR_BS6   %1 6 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS6    Port x set bit y y=
  0..15
: GPIOA-BSRR_BS5   %1 5 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS5    Port x set bit y y=
  0..15
: GPIOA-BSRR_BS4   %1 4 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS4    Port x set bit y y=
  0..15
: GPIOA-BSRR_BS3   %1 3 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS3    Port x set bit y y=
  0..15
: GPIOA-BSRR_BS2   %1 2 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS2    Port x set bit y y=
  0..15
: GPIOA-BSRR_BS1   %1 1 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS1    Port x set bit y y=
  0..15
: GPIOA-BSRR_BS0   %1 0 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS0    Port x set bit y y=
  0..15

\ GPIOA-LCKR (read-write)
: GPIOA-LCKR_LCKK   %1 16 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCKK    Port x lock bit y y=
  0..15
: GPIOA-LCKR_LCK15   %1 15 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK15    Port x lock bit y y=
  0..15
: GPIOA-LCKR_LCK14   %1 14 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK14    Port x lock bit y y=
  0..15
: GPIOA-LCKR_LCK13   %1 13 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK13    Port x lock bit y y=
  0..15
: GPIOA-LCKR_LCK12   %1 12 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK12    Port x lock bit y y=
  0..15
: GPIOA-LCKR_LCK11   %1 11 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK11    Port x lock bit y y=
  0..15
: GPIOA-LCKR_LCK10   %1 10 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK10    Port x lock bit y y=
  0..15
: GPIOA-LCKR_LCK9   %1 9 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK9    Port x lock bit y y=
  0..15
: GPIOA-LCKR_LCK8   %1 8 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK8    Port x lock bit y y=
  0..15
: GPIOA-LCKR_LCK7   %1 7 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK7    Port x lock bit y y=
  0..15
: GPIOA-LCKR_LCK6   %1 6 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK6    Port x lock bit y y=
  0..15
: GPIOA-LCKR_LCK5   %1 5 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK5    Port x lock bit y y=
  0..15
: GPIOA-LCKR_LCK4   %1 4 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK4    Port x lock bit y y=
  0..15
: GPIOA-LCKR_LCK3   %1 3 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK3    Port x lock bit y y=
  0..15
: GPIOA-LCKR_LCK2   %1 2 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK2    Port x lock bit y y=
  0..15
: GPIOA-LCKR_LCK1   %1 1 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK1    Port x lock bit y y=
  0..15
: GPIOA-LCKR_LCK0   %1 0 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK0    Port x lock bit y y=
  0..15

\ GPIOA-AFRL (read-write)
: GPIOA-AFRL_AFRL7   ( %XXXX -- ) 28 lshift GPIOA-AFRL bis! ;  \ GPIOA-AFRL_AFRL7    Alternate function selection for port x
  bit y y = 0..7
: GPIOA-AFRL_AFRL6   ( %XXXX -- ) 24 lshift GPIOA-AFRL bis! ;  \ GPIOA-AFRL_AFRL6    Alternate function selection for port x
  bit y y = 0..7
: GPIOA-AFRL_AFRL5   ( %XXXX -- ) 20 lshift GPIOA-AFRL bis! ;  \ GPIOA-AFRL_AFRL5    Alternate function selection for port x
  bit y y = 0..7
: GPIOA-AFRL_AFRL4   ( %XXXX -- ) 16 lshift GPIOA-AFRL bis! ;  \ GPIOA-AFRL_AFRL4    Alternate function selection for port x
  bit y y = 0..7
: GPIOA-AFRL_AFRL3   ( %XXXX -- ) 12 lshift GPIOA-AFRL bis! ;  \ GPIOA-AFRL_AFRL3    Alternate function selection for port x
  bit y y = 0..7
: GPIOA-AFRL_AFRL2   ( %XXXX -- ) 8 lshift GPIOA-AFRL bis! ;  \ GPIOA-AFRL_AFRL2    Alternate function selection for port x
  bit y y = 0..7
: GPIOA-AFRL_AFRL1   ( %XXXX -- ) 4 lshift GPIOA-AFRL bis! ;  \ GPIOA-AFRL_AFRL1    Alternate function selection for port x
  bit y y = 0..7
: GPIOA-AFRL_AFRL0   ( %XXXX -- ) 0 lshift GPIOA-AFRL bis! ;  \ GPIOA-AFRL_AFRL0    Alternate function selection for port x
  bit y y = 0..7

\ GPIOA-AFRH (read-write)
: GPIOA-AFRH_AFRH15   ( %XXXX -- ) 28 lshift GPIOA-AFRH bis! ;  \ GPIOA-AFRH_AFRH15    Alternate function selection for port x
  bit y y = 8..15
: GPIOA-AFRH_AFRH14   ( %XXXX -- ) 24 lshift GPIOA-AFRH bis! ;  \ GPIOA-AFRH_AFRH14    Alternate function selection for port x
  bit y y = 8..15
: GPIOA-AFRH_AFRH13   ( %XXXX -- ) 20 lshift GPIOA-AFRH bis! ;  \ GPIOA-AFRH_AFRH13    Alternate function selection for port x
  bit y y = 8..15
: GPIOA-AFRH_AFRH12   ( %XXXX -- ) 16 lshift GPIOA-AFRH bis! ;  \ GPIOA-AFRH_AFRH12    Alternate function selection for port x
  bit y y = 8..15
: GPIOA-AFRH_AFRH11   ( %XXXX -- ) 12 lshift GPIOA-AFRH bis! ;  \ GPIOA-AFRH_AFRH11    Alternate function selection for port x
  bit y y = 8..15
: GPIOA-AFRH_AFRH10   ( %XXXX -- ) 8 lshift GPIOA-AFRH bis! ;  \ GPIOA-AFRH_AFRH10    Alternate function selection for port x
  bit y y = 8..15
: GPIOA-AFRH_AFRH9   ( %XXXX -- ) 4 lshift GPIOA-AFRH bis! ;  \ GPIOA-AFRH_AFRH9    Alternate function selection for port x
  bit y y = 8..15
: GPIOA-AFRH_AFRH8   ( %XXXX -- ) 0 lshift GPIOA-AFRH bis! ;  \ GPIOA-AFRH_AFRH8    Alternate function selection for port x
  bit y y = 8..15

\ I2C3-CR1 (read-write)
: I2C3-CR1_SWRST   %1 15 lshift I2C3-CR1 bis! ;  \ I2C3-CR1_SWRST    Software reset
: I2C3-CR1_ALERT   %1 13 lshift I2C3-CR1 bis! ;  \ I2C3-CR1_ALERT    SMBus alert
: I2C3-CR1_PEC   %1 12 lshift I2C3-CR1 bis! ;  \ I2C3-CR1_PEC    Packet error checking
: I2C3-CR1_POS   %1 11 lshift I2C3-CR1 bis! ;  \ I2C3-CR1_POS    Acknowledge/PEC Position for data
  reception
: I2C3-CR1_ACK   %1 10 lshift I2C3-CR1 bis! ;  \ I2C3-CR1_ACK    Acknowledge enable
: I2C3-CR1_STOP   %1 9 lshift I2C3-CR1 bis! ;  \ I2C3-CR1_STOP    Stop generation
: I2C3-CR1_START   %1 8 lshift I2C3-CR1 bis! ;  \ I2C3-CR1_START    Start generation
: I2C3-CR1_NOSTRETCH   %1 7 lshift I2C3-CR1 bis! ;  \ I2C3-CR1_NOSTRETCH    Clock stretching disable Slave
  mode
: I2C3-CR1_ENGC   %1 6 lshift I2C3-CR1 bis! ;  \ I2C3-CR1_ENGC    General call enable
: I2C3-CR1_ENPEC   %1 5 lshift I2C3-CR1 bis! ;  \ I2C3-CR1_ENPEC    PEC enable
: I2C3-CR1_ENARP   %1 4 lshift I2C3-CR1 bis! ;  \ I2C3-CR1_ENARP    ARP enable
: I2C3-CR1_SMBTYPE   %1 3 lshift I2C3-CR1 bis! ;  \ I2C3-CR1_SMBTYPE    SMBus type
: I2C3-CR1_SMBUS   %1 1 lshift I2C3-CR1 bis! ;  \ I2C3-CR1_SMBUS    SMBus mode
: I2C3-CR1_PE   %1 0 lshift I2C3-CR1 bis! ;  \ I2C3-CR1_PE    Peripheral enable

\ I2C3-CR2 (read-write)
: I2C3-CR2_LAST   %1 12 lshift I2C3-CR2 bis! ;  \ I2C3-CR2_LAST    DMA last transfer
: I2C3-CR2_DMAEN   %1 11 lshift I2C3-CR2 bis! ;  \ I2C3-CR2_DMAEN    DMA requests enable
: I2C3-CR2_ITBUFEN   %1 10 lshift I2C3-CR2 bis! ;  \ I2C3-CR2_ITBUFEN    Buffer interrupt enable
: I2C3-CR2_ITEVTEN   %1 9 lshift I2C3-CR2 bis! ;  \ I2C3-CR2_ITEVTEN    Event interrupt enable
: I2C3-CR2_ITERREN   %1 8 lshift I2C3-CR2 bis! ;  \ I2C3-CR2_ITERREN    Error interrupt enable
: I2C3-CR2_FREQ   ( %XXXXXX -- ) 0 lshift I2C3-CR2 bis! ;  \ I2C3-CR2_FREQ    Peripheral clock frequency

\ I2C3-OAR1 (read-write)
: I2C3-OAR1_ADDMODE   %1 15 lshift I2C3-OAR1 bis! ;  \ I2C3-OAR1_ADDMODE    Addressing mode slave
  mode
: I2C3-OAR1_ADD10   ( %XX -- ) 8 lshift I2C3-OAR1 bis! ;  \ I2C3-OAR1_ADD10    Interface address
: I2C3-OAR1_ADD7   ( %XXXXXXX -- ) 1 lshift I2C3-OAR1 bis! ;  \ I2C3-OAR1_ADD7    Interface address
: I2C3-OAR1_ADD0   %1 0 lshift I2C3-OAR1 bis! ;  \ I2C3-OAR1_ADD0    Interface address

\ I2C3-OAR2 (read-write)
: I2C3-OAR2_ADD2   ( %XXXXXXX -- ) 1 lshift I2C3-OAR2 bis! ;  \ I2C3-OAR2_ADD2    Interface address
: I2C3-OAR2_ENDUAL   %1 0 lshift I2C3-OAR2 bis! ;  \ I2C3-OAR2_ENDUAL    Dual addressing mode
  enable

\ I2C3-DR (read-write)
: I2C3-DR_DR   ( %XXXXXXXX -- ) 0 lshift I2C3-DR bis! ;  \ I2C3-DR_DR    8-bit data register

\ I2C3-SR1 ()
: I2C3-SR1_SMBALERT   %1 15 lshift I2C3-SR1 bis! ;  \ I2C3-SR1_SMBALERT    SMBus alert
: I2C3-SR1_TIMEOUT   %1 14 lshift I2C3-SR1 bis! ;  \ I2C3-SR1_TIMEOUT    Timeout or Tlow error
: I2C3-SR1_PECERR   %1 12 lshift I2C3-SR1 bis! ;  \ I2C3-SR1_PECERR    PEC Error in reception
: I2C3-SR1_OVR   %1 11 lshift I2C3-SR1 bis! ;  \ I2C3-SR1_OVR    Overrun/Underrun
: I2C3-SR1_AF   %1 10 lshift I2C3-SR1 bis! ;  \ I2C3-SR1_AF    Acknowledge failure
: I2C3-SR1_ARLO   %1 9 lshift I2C3-SR1 bis! ;  \ I2C3-SR1_ARLO    Arbitration lost master
  mode
: I2C3-SR1_BERR   %1 8 lshift I2C3-SR1 bis! ;  \ I2C3-SR1_BERR    Bus error
: I2C3-SR1_TxE   %1 7 lshift I2C3-SR1 bis! ;  \ I2C3-SR1_TxE    Data register empty
  transmitters
: I2C3-SR1_RxNE   %1 6 lshift I2C3-SR1 bis! ;  \ I2C3-SR1_RxNE    Data register not empty
  receivers
: I2C3-SR1_STOPF   %1 4 lshift I2C3-SR1 bis! ;  \ I2C3-SR1_STOPF    Stop detection slave
  mode
: I2C3-SR1_ADD10   %1 3 lshift I2C3-SR1 bis! ;  \ I2C3-SR1_ADD10    10-bit header sent Master
  mode
: I2C3-SR1_BTF   %1 2 lshift I2C3-SR1 bis! ;  \ I2C3-SR1_BTF    Byte transfer finished
: I2C3-SR1_ADDR   %1 1 lshift I2C3-SR1 bis! ;  \ I2C3-SR1_ADDR    Address sent master mode/matched
  slave mode
: I2C3-SR1_SB   %1 0 lshift I2C3-SR1 bis! ;  \ I2C3-SR1_SB    Start bit Master mode

\ I2C3-SR2 (read-only)
: I2C3-SR2_PEC   ( %XXXXXXXX -- ) 8 lshift I2C3-SR2 bis! ;  \ I2C3-SR2_PEC    acket error checking
  register
: I2C3-SR2_DUALF   %1 7 lshift I2C3-SR2 bis! ;  \ I2C3-SR2_DUALF    Dual flag Slave mode
: I2C3-SR2_SMBHOST   %1 6 lshift I2C3-SR2 bis! ;  \ I2C3-SR2_SMBHOST    SMBus host header Slave
  mode
: I2C3-SR2_SMBDEFAULT   %1 5 lshift I2C3-SR2 bis! ;  \ I2C3-SR2_SMBDEFAULT    SMBus device default address Slave
  mode
: I2C3-SR2_GENCALL   %1 4 lshift I2C3-SR2 bis! ;  \ I2C3-SR2_GENCALL    General call address Slave
  mode
: I2C3-SR2_TRA   %1 2 lshift I2C3-SR2 bis! ;  \ I2C3-SR2_TRA    Transmitter/receiver
: I2C3-SR2_BUSY   %1 1 lshift I2C3-SR2 bis! ;  \ I2C3-SR2_BUSY    Bus busy
: I2C3-SR2_MSL   %1 0 lshift I2C3-SR2 bis! ;  \ I2C3-SR2_MSL    Master/slave

\ I2C3-CCR (read-write)
: I2C3-CCR_F_S   %1 15 lshift I2C3-CCR bis! ;  \ I2C3-CCR_F_S    I2C master mode selection
: I2C3-CCR_DUTY   %1 14 lshift I2C3-CCR bis! ;  \ I2C3-CCR_DUTY    Fast mode duty cycle
: I2C3-CCR_CCR   ( %XXXXXXXXXXX -- ) 0 lshift I2C3-CCR bis! ;  \ I2C3-CCR_CCR    Clock control register in Fast/Standard
  mode Master mode

\ I2C3-TRISE (read-write)
: I2C3-TRISE_TRISE   ( %XXXXXX -- ) 0 lshift I2C3-TRISE bis! ;  \ I2C3-TRISE_TRISE    Maximum rise time in Fast/Standard mode
  Master mode

\ I2C2-CR1 (read-write)
: I2C2-CR1_SWRST   %1 15 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_SWRST    Software reset
: I2C2-CR1_ALERT   %1 13 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_ALERT    SMBus alert
: I2C2-CR1_PEC   %1 12 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_PEC    Packet error checking
: I2C2-CR1_POS   %1 11 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_POS    Acknowledge/PEC Position for data
  reception
: I2C2-CR1_ACK   %1 10 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_ACK    Acknowledge enable
: I2C2-CR1_STOP   %1 9 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_STOP    Stop generation
: I2C2-CR1_START   %1 8 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_START    Start generation
: I2C2-CR1_NOSTRETCH   %1 7 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_NOSTRETCH    Clock stretching disable Slave
  mode
: I2C2-CR1_ENGC   %1 6 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_ENGC    General call enable
: I2C2-CR1_ENPEC   %1 5 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_ENPEC    PEC enable
: I2C2-CR1_ENARP   %1 4 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_ENARP    ARP enable
: I2C2-CR1_SMBTYPE   %1 3 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_SMBTYPE    SMBus type
: I2C2-CR1_SMBUS   %1 1 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_SMBUS    SMBus mode
: I2C2-CR1_PE   %1 0 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_PE    Peripheral enable

\ I2C2-CR2 (read-write)
: I2C2-CR2_LAST   %1 12 lshift I2C2-CR2 bis! ;  \ I2C2-CR2_LAST    DMA last transfer
: I2C2-CR2_DMAEN   %1 11 lshift I2C2-CR2 bis! ;  \ I2C2-CR2_DMAEN    DMA requests enable
: I2C2-CR2_ITBUFEN   %1 10 lshift I2C2-CR2 bis! ;  \ I2C2-CR2_ITBUFEN    Buffer interrupt enable
: I2C2-CR2_ITEVTEN   %1 9 lshift I2C2-CR2 bis! ;  \ I2C2-CR2_ITEVTEN    Event interrupt enable
: I2C2-CR2_ITERREN   %1 8 lshift I2C2-CR2 bis! ;  \ I2C2-CR2_ITERREN    Error interrupt enable
: I2C2-CR2_FREQ   ( %XXXXXX -- ) 0 lshift I2C2-CR2 bis! ;  \ I2C2-CR2_FREQ    Peripheral clock frequency

\ I2C2-OAR1 (read-write)
: I2C2-OAR1_ADDMODE   %1 15 lshift I2C2-OAR1 bis! ;  \ I2C2-OAR1_ADDMODE    Addressing mode slave
  mode
: I2C2-OAR1_ADD10   ( %XX -- ) 8 lshift I2C2-OAR1 bis! ;  \ I2C2-OAR1_ADD10    Interface address
: I2C2-OAR1_ADD7   ( %XXXXXXX -- ) 1 lshift I2C2-OAR1 bis! ;  \ I2C2-OAR1_ADD7    Interface address
: I2C2-OAR1_ADD0   %1 0 lshift I2C2-OAR1 bis! ;  \ I2C2-OAR1_ADD0    Interface address

\ I2C2-OAR2 (read-write)
: I2C2-OAR2_ADD2   ( %XXXXXXX -- ) 1 lshift I2C2-OAR2 bis! ;  \ I2C2-OAR2_ADD2    Interface address
: I2C2-OAR2_ENDUAL   %1 0 lshift I2C2-OAR2 bis! ;  \ I2C2-OAR2_ENDUAL    Dual addressing mode
  enable

\ I2C2-DR (read-write)
: I2C2-DR_DR   ( %XXXXXXXX -- ) 0 lshift I2C2-DR bis! ;  \ I2C2-DR_DR    8-bit data register

\ I2C2-SR1 ()
: I2C2-SR1_SMBALERT   %1 15 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_SMBALERT    SMBus alert
: I2C2-SR1_TIMEOUT   %1 14 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_TIMEOUT    Timeout or Tlow error
: I2C2-SR1_PECERR   %1 12 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_PECERR    PEC Error in reception
: I2C2-SR1_OVR   %1 11 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_OVR    Overrun/Underrun
: I2C2-SR1_AF   %1 10 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_AF    Acknowledge failure
: I2C2-SR1_ARLO   %1 9 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_ARLO    Arbitration lost master
  mode
: I2C2-SR1_BERR   %1 8 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_BERR    Bus error
: I2C2-SR1_TxE   %1 7 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_TxE    Data register empty
  transmitters
: I2C2-SR1_RxNE   %1 6 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_RxNE    Data register not empty
  receivers
: I2C2-SR1_STOPF   %1 4 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_STOPF    Stop detection slave
  mode
: I2C2-SR1_ADD10   %1 3 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_ADD10    10-bit header sent Master
  mode
: I2C2-SR1_BTF   %1 2 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_BTF    Byte transfer finished
: I2C2-SR1_ADDR   %1 1 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_ADDR    Address sent master mode/matched
  slave mode
: I2C2-SR1_SB   %1 0 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_SB    Start bit Master mode

\ I2C2-SR2 (read-only)
: I2C2-SR2_PEC   ( %XXXXXXXX -- ) 8 lshift I2C2-SR2 bis! ;  \ I2C2-SR2_PEC    acket error checking
  register
: I2C2-SR2_DUALF   %1 7 lshift I2C2-SR2 bis! ;  \ I2C2-SR2_DUALF    Dual flag Slave mode
: I2C2-SR2_SMBHOST   %1 6 lshift I2C2-SR2 bis! ;  \ I2C2-SR2_SMBHOST    SMBus host header Slave
  mode
: I2C2-SR2_SMBDEFAULT   %1 5 lshift I2C2-SR2 bis! ;  \ I2C2-SR2_SMBDEFAULT    SMBus device default address Slave
  mode
: I2C2-SR2_GENCALL   %1 4 lshift I2C2-SR2 bis! ;  \ I2C2-SR2_GENCALL    General call address Slave
  mode
: I2C2-SR2_TRA   %1 2 lshift I2C2-SR2 bis! ;  \ I2C2-SR2_TRA    Transmitter/receiver
: I2C2-SR2_BUSY   %1 1 lshift I2C2-SR2 bis! ;  \ I2C2-SR2_BUSY    Bus busy
: I2C2-SR2_MSL   %1 0 lshift I2C2-SR2 bis! ;  \ I2C2-SR2_MSL    Master/slave

\ I2C2-CCR (read-write)
: I2C2-CCR_F_S   %1 15 lshift I2C2-CCR bis! ;  \ I2C2-CCR_F_S    I2C master mode selection
: I2C2-CCR_DUTY   %1 14 lshift I2C2-CCR bis! ;  \ I2C2-CCR_DUTY    Fast mode duty cycle
: I2C2-CCR_CCR   ( %XXXXXXXXXXX -- ) 0 lshift I2C2-CCR bis! ;  \ I2C2-CCR_CCR    Clock control register in Fast/Standard
  mode Master mode

\ I2C2-TRISE (read-write)
: I2C2-TRISE_TRISE   ( %XXXXXX -- ) 0 lshift I2C2-TRISE bis! ;  \ I2C2-TRISE_TRISE    Maximum rise time in Fast/Standard mode
  Master mode

\ I2C1-CR1 (read-write)
: I2C1-CR1_SWRST   %1 15 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_SWRST    Software reset
: I2C1-CR1_ALERT   %1 13 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_ALERT    SMBus alert
: I2C1-CR1_PEC   %1 12 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_PEC    Packet error checking
: I2C1-CR1_POS   %1 11 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_POS    Acknowledge/PEC Position for data
  reception
: I2C1-CR1_ACK   %1 10 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_ACK    Acknowledge enable
: I2C1-CR1_STOP   %1 9 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_STOP    Stop generation
: I2C1-CR1_START   %1 8 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_START    Start generation
: I2C1-CR1_NOSTRETCH   %1 7 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_NOSTRETCH    Clock stretching disable Slave
  mode
: I2C1-CR1_ENGC   %1 6 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_ENGC    General call enable
: I2C1-CR1_ENPEC   %1 5 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_ENPEC    PEC enable
: I2C1-CR1_ENARP   %1 4 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_ENARP    ARP enable
: I2C1-CR1_SMBTYPE   %1 3 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_SMBTYPE    SMBus type
: I2C1-CR1_SMBUS   %1 1 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_SMBUS    SMBus mode
: I2C1-CR1_PE   %1 0 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_PE    Peripheral enable

\ I2C1-CR2 (read-write)
: I2C1-CR2_LAST   %1 12 lshift I2C1-CR2 bis! ;  \ I2C1-CR2_LAST    DMA last transfer
: I2C1-CR2_DMAEN   %1 11 lshift I2C1-CR2 bis! ;  \ I2C1-CR2_DMAEN    DMA requests enable
: I2C1-CR2_ITBUFEN   %1 10 lshift I2C1-CR2 bis! ;  \ I2C1-CR2_ITBUFEN    Buffer interrupt enable
: I2C1-CR2_ITEVTEN   %1 9 lshift I2C1-CR2 bis! ;  \ I2C1-CR2_ITEVTEN    Event interrupt enable
: I2C1-CR2_ITERREN   %1 8 lshift I2C1-CR2 bis! ;  \ I2C1-CR2_ITERREN    Error interrupt enable
: I2C1-CR2_FREQ   ( %XXXXXX -- ) 0 lshift I2C1-CR2 bis! ;  \ I2C1-CR2_FREQ    Peripheral clock frequency

\ I2C1-OAR1 (read-write)
: I2C1-OAR1_ADDMODE   %1 15 lshift I2C1-OAR1 bis! ;  \ I2C1-OAR1_ADDMODE    Addressing mode slave
  mode
: I2C1-OAR1_ADD10   ( %XX -- ) 8 lshift I2C1-OAR1 bis! ;  \ I2C1-OAR1_ADD10    Interface address
: I2C1-OAR1_ADD7   ( %XXXXXXX -- ) 1 lshift I2C1-OAR1 bis! ;  \ I2C1-OAR1_ADD7    Interface address
: I2C1-OAR1_ADD0   %1 0 lshift I2C1-OAR1 bis! ;  \ I2C1-OAR1_ADD0    Interface address

\ I2C1-OAR2 (read-write)
: I2C1-OAR2_ADD2   ( %XXXXXXX -- ) 1 lshift I2C1-OAR2 bis! ;  \ I2C1-OAR2_ADD2    Interface address
: I2C1-OAR2_ENDUAL   %1 0 lshift I2C1-OAR2 bis! ;  \ I2C1-OAR2_ENDUAL    Dual addressing mode
  enable

\ I2C1-DR (read-write)
: I2C1-DR_DR   ( %XXXXXXXX -- ) 0 lshift I2C1-DR bis! ;  \ I2C1-DR_DR    8-bit data register

\ I2C1-SR1 ()
: I2C1-SR1_SMBALERT   %1 15 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_SMBALERT    SMBus alert
: I2C1-SR1_TIMEOUT   %1 14 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_TIMEOUT    Timeout or Tlow error
: I2C1-SR1_PECERR   %1 12 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_PECERR    PEC Error in reception
: I2C1-SR1_OVR   %1 11 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_OVR    Overrun/Underrun
: I2C1-SR1_AF   %1 10 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_AF    Acknowledge failure
: I2C1-SR1_ARLO   %1 9 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_ARLO    Arbitration lost master
  mode
: I2C1-SR1_BERR   %1 8 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_BERR    Bus error
: I2C1-SR1_TxE   %1 7 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_TxE    Data register empty
  transmitters
: I2C1-SR1_RxNE   %1 6 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_RxNE    Data register not empty
  receivers
: I2C1-SR1_STOPF   %1 4 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_STOPF    Stop detection slave
  mode
: I2C1-SR1_ADD10   %1 3 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_ADD10    10-bit header sent Master
  mode
: I2C1-SR1_BTF   %1 2 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_BTF    Byte transfer finished
: I2C1-SR1_ADDR   %1 1 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_ADDR    Address sent master mode/matched
  slave mode
: I2C1-SR1_SB   %1 0 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_SB    Start bit Master mode

\ I2C1-SR2 (read-only)
: I2C1-SR2_PEC   ( %XXXXXXXX -- ) 8 lshift I2C1-SR2 bis! ;  \ I2C1-SR2_PEC    acket error checking
  register
: I2C1-SR2_DUALF   %1 7 lshift I2C1-SR2 bis! ;  \ I2C1-SR2_DUALF    Dual flag Slave mode
: I2C1-SR2_SMBHOST   %1 6 lshift I2C1-SR2 bis! ;  \ I2C1-SR2_SMBHOST    SMBus host header Slave
  mode
: I2C1-SR2_SMBDEFAULT   %1 5 lshift I2C1-SR2 bis! ;  \ I2C1-SR2_SMBDEFAULT    SMBus device default address Slave
  mode
: I2C1-SR2_GENCALL   %1 4 lshift I2C1-SR2 bis! ;  \ I2C1-SR2_GENCALL    General call address Slave
  mode
: I2C1-SR2_TRA   %1 2 lshift I2C1-SR2 bis! ;  \ I2C1-SR2_TRA    Transmitter/receiver
: I2C1-SR2_BUSY   %1 1 lshift I2C1-SR2 bis! ;  \ I2C1-SR2_BUSY    Bus busy
: I2C1-SR2_MSL   %1 0 lshift I2C1-SR2 bis! ;  \ I2C1-SR2_MSL    Master/slave

\ I2C1-CCR (read-write)
: I2C1-CCR_F_S   %1 15 lshift I2C1-CCR bis! ;  \ I2C1-CCR_F_S    I2C master mode selection
: I2C1-CCR_DUTY   %1 14 lshift I2C1-CCR bis! ;  \ I2C1-CCR_DUTY    Fast mode duty cycle
: I2C1-CCR_CCR   ( %XXXXXXXXXXX -- ) 0 lshift I2C1-CCR bis! ;  \ I2C1-CCR_CCR    Clock control register in Fast/Standard
  mode Master mode

\ I2C1-TRISE (read-write)
: I2C1-TRISE_TRISE   ( %XXXXXX -- ) 0 lshift I2C1-TRISE bis! ;  \ I2C1-TRISE_TRISE    Maximum rise time in Fast/Standard mode
  Master mode

\ I2S2ext-CR1 (read-write)
: I2S2ext-CR1_BIDIMODE   %1 15 lshift I2S2ext-CR1 bis! ;  \ I2S2ext-CR1_BIDIMODE    Bidirectional data mode
  enable
: I2S2ext-CR1_BIDIOE   %1 14 lshift I2S2ext-CR1 bis! ;  \ I2S2ext-CR1_BIDIOE    Output enable in bidirectional
  mode
: I2S2ext-CR1_CRCEN   %1 13 lshift I2S2ext-CR1 bis! ;  \ I2S2ext-CR1_CRCEN    Hardware CRC calculation
  enable
: I2S2ext-CR1_CRCNEXT   %1 12 lshift I2S2ext-CR1 bis! ;  \ I2S2ext-CR1_CRCNEXT    CRC transfer next
: I2S2ext-CR1_DFF   %1 11 lshift I2S2ext-CR1 bis! ;  \ I2S2ext-CR1_DFF    Data frame format
: I2S2ext-CR1_RXONLY   %1 10 lshift I2S2ext-CR1 bis! ;  \ I2S2ext-CR1_RXONLY    Receive only
: I2S2ext-CR1_SSM   %1 9 lshift I2S2ext-CR1 bis! ;  \ I2S2ext-CR1_SSM    Software slave management
: I2S2ext-CR1_SSI   %1 8 lshift I2S2ext-CR1 bis! ;  \ I2S2ext-CR1_SSI    Internal slave select
: I2S2ext-CR1_LSBFIRST   %1 7 lshift I2S2ext-CR1 bis! ;  \ I2S2ext-CR1_LSBFIRST    Frame format
: I2S2ext-CR1_SPE   %1 6 lshift I2S2ext-CR1 bis! ;  \ I2S2ext-CR1_SPE    SPI enable
: I2S2ext-CR1_BR   ( %XXX -- ) 3 lshift I2S2ext-CR1 bis! ;  \ I2S2ext-CR1_BR    Baud rate control
: I2S2ext-CR1_MSTR   %1 2 lshift I2S2ext-CR1 bis! ;  \ I2S2ext-CR1_MSTR    Master selection
: I2S2ext-CR1_CPOL   %1 1 lshift I2S2ext-CR1 bis! ;  \ I2S2ext-CR1_CPOL    Clock polarity
: I2S2ext-CR1_CPHA   %1 0 lshift I2S2ext-CR1 bis! ;  \ I2S2ext-CR1_CPHA    Clock phase

\ I2S2ext-CR2 (read-write)
: I2S2ext-CR2_TXEIE   %1 7 lshift I2S2ext-CR2 bis! ;  \ I2S2ext-CR2_TXEIE    Tx buffer empty interrupt
  enable
: I2S2ext-CR2_RXNEIE   %1 6 lshift I2S2ext-CR2 bis! ;  \ I2S2ext-CR2_RXNEIE    RX buffer not empty interrupt
  enable
: I2S2ext-CR2_ERRIE   %1 5 lshift I2S2ext-CR2 bis! ;  \ I2S2ext-CR2_ERRIE    Error interrupt enable
: I2S2ext-CR2_FRF   %1 4 lshift I2S2ext-CR2 bis! ;  \ I2S2ext-CR2_FRF    Frame format
: I2S2ext-CR2_SSOE   %1 2 lshift I2S2ext-CR2 bis! ;  \ I2S2ext-CR2_SSOE    SS output enable
: I2S2ext-CR2_TXDMAEN   %1 1 lshift I2S2ext-CR2 bis! ;  \ I2S2ext-CR2_TXDMAEN    Tx buffer DMA enable
: I2S2ext-CR2_RXDMAEN   %1 0 lshift I2S2ext-CR2 bis! ;  \ I2S2ext-CR2_RXDMAEN    Rx buffer DMA enable

\ I2S2ext-SR ()
: I2S2ext-SR_TIFRFE   %1 8 lshift I2S2ext-SR bis! ;  \ I2S2ext-SR_TIFRFE    TI frame format error
: I2S2ext-SR_BSY   %1 7 lshift I2S2ext-SR bis! ;  \ I2S2ext-SR_BSY    Busy flag
: I2S2ext-SR_OVR   %1 6 lshift I2S2ext-SR bis! ;  \ I2S2ext-SR_OVR    Overrun flag
: I2S2ext-SR_MODF   %1 5 lshift I2S2ext-SR bis! ;  \ I2S2ext-SR_MODF    Mode fault
: I2S2ext-SR_CRCERR   %1 4 lshift I2S2ext-SR bis! ;  \ I2S2ext-SR_CRCERR    CRC error flag
: I2S2ext-SR_UDR   %1 3 lshift I2S2ext-SR bis! ;  \ I2S2ext-SR_UDR    Underrun flag
: I2S2ext-SR_CHSIDE   %1 2 lshift I2S2ext-SR bis! ;  \ I2S2ext-SR_CHSIDE    Channel side
: I2S2ext-SR_TXE   %1 1 lshift I2S2ext-SR bis! ;  \ I2S2ext-SR_TXE    Transmit buffer empty
: I2S2ext-SR_RXNE   %1 0 lshift I2S2ext-SR bis! ;  \ I2S2ext-SR_RXNE    Receive buffer not empty

\ I2S2ext-DR (read-write)
: I2S2ext-DR_DR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift I2S2ext-DR bis! ;  \ I2S2ext-DR_DR    Data register

\ I2S2ext-CRCPR (read-write)
: I2S2ext-CRCPR_CRCPOLY   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift I2S2ext-CRCPR bis! ;  \ I2S2ext-CRCPR_CRCPOLY    CRC polynomial register

\ I2S2ext-RXCRCR (read-only)
: I2S2ext-RXCRCR_RxCRC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift I2S2ext-RXCRCR bis! ;  \ I2S2ext-RXCRCR_RxCRC    Rx CRC register

\ I2S2ext-TXCRCR (read-only)
: I2S2ext-TXCRCR_TxCRC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift I2S2ext-TXCRCR bis! ;  \ I2S2ext-TXCRCR_TxCRC    Tx CRC register

\ I2S2ext-I2SCFGR (read-write)
: I2S2ext-I2SCFGR_I2SMOD   %1 11 lshift I2S2ext-I2SCFGR bis! ;  \ I2S2ext-I2SCFGR_I2SMOD    I2S mode selection
: I2S2ext-I2SCFGR_I2SE   %1 10 lshift I2S2ext-I2SCFGR bis! ;  \ I2S2ext-I2SCFGR_I2SE    I2S Enable
: I2S2ext-I2SCFGR_I2SCFG   ( %XX -- ) 8 lshift I2S2ext-I2SCFGR bis! ;  \ I2S2ext-I2SCFGR_I2SCFG    I2S configuration mode
: I2S2ext-I2SCFGR_PCMSYNC   %1 7 lshift I2S2ext-I2SCFGR bis! ;  \ I2S2ext-I2SCFGR_PCMSYNC    PCM frame synchronization
: I2S2ext-I2SCFGR_I2SSTD   ( %XX -- ) 4 lshift I2S2ext-I2SCFGR bis! ;  \ I2S2ext-I2SCFGR_I2SSTD    I2S standard selection
: I2S2ext-I2SCFGR_CKPOL   %1 3 lshift I2S2ext-I2SCFGR bis! ;  \ I2S2ext-I2SCFGR_CKPOL    Steady state clock
  polarity
: I2S2ext-I2SCFGR_DATLEN   ( %XX -- ) 1 lshift I2S2ext-I2SCFGR bis! ;  \ I2S2ext-I2SCFGR_DATLEN    Data length to be
  transferred
: I2S2ext-I2SCFGR_CHLEN   %1 0 lshift I2S2ext-I2SCFGR bis! ;  \ I2S2ext-I2SCFGR_CHLEN    Channel length number of bits per audio
  channel

\ I2S2ext-I2SPR (read-write)
: I2S2ext-I2SPR_MCKOE   %1 9 lshift I2S2ext-I2SPR bis! ;  \ I2S2ext-I2SPR_MCKOE    Master clock output enable
: I2S2ext-I2SPR_ODD   %1 8 lshift I2S2ext-I2SPR bis! ;  \ I2S2ext-I2SPR_ODD    Odd factor for the
  prescaler
: I2S2ext-I2SPR_I2SDIV   ( %XXXXXXXX -- ) 0 lshift I2S2ext-I2SPR bis! ;  \ I2S2ext-I2SPR_I2SDIV    I2S Linear prescaler

\ I2S3ext-CR1 (read-write)
: I2S3ext-CR1_BIDIMODE   %1 15 lshift I2S3ext-CR1 bis! ;  \ I2S3ext-CR1_BIDIMODE    Bidirectional data mode
  enable
: I2S3ext-CR1_BIDIOE   %1 14 lshift I2S3ext-CR1 bis! ;  \ I2S3ext-CR1_BIDIOE    Output enable in bidirectional
  mode
: I2S3ext-CR1_CRCEN   %1 13 lshift I2S3ext-CR1 bis! ;  \ I2S3ext-CR1_CRCEN    Hardware CRC calculation
  enable
: I2S3ext-CR1_CRCNEXT   %1 12 lshift I2S3ext-CR1 bis! ;  \ I2S3ext-CR1_CRCNEXT    CRC transfer next
: I2S3ext-CR1_DFF   %1 11 lshift I2S3ext-CR1 bis! ;  \ I2S3ext-CR1_DFF    Data frame format
: I2S3ext-CR1_RXONLY   %1 10 lshift I2S3ext-CR1 bis! ;  \ I2S3ext-CR1_RXONLY    Receive only
: I2S3ext-CR1_SSM   %1 9 lshift I2S3ext-CR1 bis! ;  \ I2S3ext-CR1_SSM    Software slave management
: I2S3ext-CR1_SSI   %1 8 lshift I2S3ext-CR1 bis! ;  \ I2S3ext-CR1_SSI    Internal slave select
: I2S3ext-CR1_LSBFIRST   %1 7 lshift I2S3ext-CR1 bis! ;  \ I2S3ext-CR1_LSBFIRST    Frame format
: I2S3ext-CR1_SPE   %1 6 lshift I2S3ext-CR1 bis! ;  \ I2S3ext-CR1_SPE    SPI enable
: I2S3ext-CR1_BR   ( %XXX -- ) 3 lshift I2S3ext-CR1 bis! ;  \ I2S3ext-CR1_BR    Baud rate control
: I2S3ext-CR1_MSTR   %1 2 lshift I2S3ext-CR1 bis! ;  \ I2S3ext-CR1_MSTR    Master selection
: I2S3ext-CR1_CPOL   %1 1 lshift I2S3ext-CR1 bis! ;  \ I2S3ext-CR1_CPOL    Clock polarity
: I2S3ext-CR1_CPHA   %1 0 lshift I2S3ext-CR1 bis! ;  \ I2S3ext-CR1_CPHA    Clock phase

\ I2S3ext-CR2 (read-write)
: I2S3ext-CR2_TXEIE   %1 7 lshift I2S3ext-CR2 bis! ;  \ I2S3ext-CR2_TXEIE    Tx buffer empty interrupt
  enable
: I2S3ext-CR2_RXNEIE   %1 6 lshift I2S3ext-CR2 bis! ;  \ I2S3ext-CR2_RXNEIE    RX buffer not empty interrupt
  enable
: I2S3ext-CR2_ERRIE   %1 5 lshift I2S3ext-CR2 bis! ;  \ I2S3ext-CR2_ERRIE    Error interrupt enable
: I2S3ext-CR2_FRF   %1 4 lshift I2S3ext-CR2 bis! ;  \ I2S3ext-CR2_FRF    Frame format
: I2S3ext-CR2_SSOE   %1 2 lshift I2S3ext-CR2 bis! ;  \ I2S3ext-CR2_SSOE    SS output enable
: I2S3ext-CR2_TXDMAEN   %1 1 lshift I2S3ext-CR2 bis! ;  \ I2S3ext-CR2_TXDMAEN    Tx buffer DMA enable
: I2S3ext-CR2_RXDMAEN   %1 0 lshift I2S3ext-CR2 bis! ;  \ I2S3ext-CR2_RXDMAEN    Rx buffer DMA enable

\ I2S3ext-SR ()
: I2S3ext-SR_TIFRFE   %1 8 lshift I2S3ext-SR bis! ;  \ I2S3ext-SR_TIFRFE    TI frame format error
: I2S3ext-SR_BSY   %1 7 lshift I2S3ext-SR bis! ;  \ I2S3ext-SR_BSY    Busy flag
: I2S3ext-SR_OVR   %1 6 lshift I2S3ext-SR bis! ;  \ I2S3ext-SR_OVR    Overrun flag
: I2S3ext-SR_MODF   %1 5 lshift I2S3ext-SR bis! ;  \ I2S3ext-SR_MODF    Mode fault
: I2S3ext-SR_CRCERR   %1 4 lshift I2S3ext-SR bis! ;  \ I2S3ext-SR_CRCERR    CRC error flag
: I2S3ext-SR_UDR   %1 3 lshift I2S3ext-SR bis! ;  \ I2S3ext-SR_UDR    Underrun flag
: I2S3ext-SR_CHSIDE   %1 2 lshift I2S3ext-SR bis! ;  \ I2S3ext-SR_CHSIDE    Channel side
: I2S3ext-SR_TXE   %1 1 lshift I2S3ext-SR bis! ;  \ I2S3ext-SR_TXE    Transmit buffer empty
: I2S3ext-SR_RXNE   %1 0 lshift I2S3ext-SR bis! ;  \ I2S3ext-SR_RXNE    Receive buffer not empty

\ I2S3ext-DR (read-write)
: I2S3ext-DR_DR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift I2S3ext-DR bis! ;  \ I2S3ext-DR_DR    Data register

\ I2S3ext-CRCPR (read-write)
: I2S3ext-CRCPR_CRCPOLY   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift I2S3ext-CRCPR bis! ;  \ I2S3ext-CRCPR_CRCPOLY    CRC polynomial register

\ I2S3ext-RXCRCR (read-only)
: I2S3ext-RXCRCR_RxCRC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift I2S3ext-RXCRCR bis! ;  \ I2S3ext-RXCRCR_RxCRC    Rx CRC register

\ I2S3ext-TXCRCR (read-only)
: I2S3ext-TXCRCR_TxCRC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift I2S3ext-TXCRCR bis! ;  \ I2S3ext-TXCRCR_TxCRC    Tx CRC register

\ I2S3ext-I2SCFGR (read-write)
: I2S3ext-I2SCFGR_I2SMOD   %1 11 lshift I2S3ext-I2SCFGR bis! ;  \ I2S3ext-I2SCFGR_I2SMOD    I2S mode selection
: I2S3ext-I2SCFGR_I2SE   %1 10 lshift I2S3ext-I2SCFGR bis! ;  \ I2S3ext-I2SCFGR_I2SE    I2S Enable
: I2S3ext-I2SCFGR_I2SCFG   ( %XX -- ) 8 lshift I2S3ext-I2SCFGR bis! ;  \ I2S3ext-I2SCFGR_I2SCFG    I2S configuration mode
: I2S3ext-I2SCFGR_PCMSYNC   %1 7 lshift I2S3ext-I2SCFGR bis! ;  \ I2S3ext-I2SCFGR_PCMSYNC    PCM frame synchronization
: I2S3ext-I2SCFGR_I2SSTD   ( %XX -- ) 4 lshift I2S3ext-I2SCFGR bis! ;  \ I2S3ext-I2SCFGR_I2SSTD    I2S standard selection
: I2S3ext-I2SCFGR_CKPOL   %1 3 lshift I2S3ext-I2SCFGR bis! ;  \ I2S3ext-I2SCFGR_CKPOL    Steady state clock
  polarity
: I2S3ext-I2SCFGR_DATLEN   ( %XX -- ) 1 lshift I2S3ext-I2SCFGR bis! ;  \ I2S3ext-I2SCFGR_DATLEN    Data length to be
  transferred
: I2S3ext-I2SCFGR_CHLEN   %1 0 lshift I2S3ext-I2SCFGR bis! ;  \ I2S3ext-I2SCFGR_CHLEN    Channel length number of bits per audio
  channel

\ I2S3ext-I2SPR (read-write)
: I2S3ext-I2SPR_MCKOE   %1 9 lshift I2S3ext-I2SPR bis! ;  \ I2S3ext-I2SPR_MCKOE    Master clock output enable
: I2S3ext-I2SPR_ODD   %1 8 lshift I2S3ext-I2SPR bis! ;  \ I2S3ext-I2SPR_ODD    Odd factor for the
  prescaler
: I2S3ext-I2SPR_I2SDIV   ( %XXXXXXXX -- ) 0 lshift I2S3ext-I2SPR bis! ;  \ I2S3ext-I2SPR_I2SDIV    I2S Linear prescaler

\ SPI1-CR1 (read-write)
: SPI1-CR1_BIDIMODE   %1 15 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_BIDIMODE    Bidirectional data mode
  enable
: SPI1-CR1_BIDIOE   %1 14 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_BIDIOE    Output enable in bidirectional
  mode
: SPI1-CR1_CRCEN   %1 13 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_CRCEN    Hardware CRC calculation
  enable
: SPI1-CR1_CRCNEXT   %1 12 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_CRCNEXT    CRC transfer next
: SPI1-CR1_DFF   %1 11 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_DFF    Data frame format
: SPI1-CR1_RXONLY   %1 10 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_RXONLY    Receive only
: SPI1-CR1_SSM   %1 9 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_SSM    Software slave management
: SPI1-CR1_SSI   %1 8 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_SSI    Internal slave select
: SPI1-CR1_LSBFIRST   %1 7 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_LSBFIRST    Frame format
: SPI1-CR1_SPE   %1 6 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_SPE    SPI enable
: SPI1-CR1_BR   ( %XXX -- ) 3 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_BR    Baud rate control
: SPI1-CR1_MSTR   %1 2 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_MSTR    Master selection
: SPI1-CR1_CPOL   %1 1 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_CPOL    Clock polarity
: SPI1-CR1_CPHA   %1 0 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_CPHA    Clock phase

\ SPI1-CR2 (read-write)
: SPI1-CR2_TXEIE   %1 7 lshift SPI1-CR2 bis! ;  \ SPI1-CR2_TXEIE    Tx buffer empty interrupt
  enable
: SPI1-CR2_RXNEIE   %1 6 lshift SPI1-CR2 bis! ;  \ SPI1-CR2_RXNEIE    RX buffer not empty interrupt
  enable
: SPI1-CR2_ERRIE   %1 5 lshift SPI1-CR2 bis! ;  \ SPI1-CR2_ERRIE    Error interrupt enable
: SPI1-CR2_FRF   %1 4 lshift SPI1-CR2 bis! ;  \ SPI1-CR2_FRF    Frame format
: SPI1-CR2_SSOE   %1 2 lshift SPI1-CR2 bis! ;  \ SPI1-CR2_SSOE    SS output enable
: SPI1-CR2_TXDMAEN   %1 1 lshift SPI1-CR2 bis! ;  \ SPI1-CR2_TXDMAEN    Tx buffer DMA enable
: SPI1-CR2_RXDMAEN   %1 0 lshift SPI1-CR2 bis! ;  \ SPI1-CR2_RXDMAEN    Rx buffer DMA enable

\ SPI1-SR ()
: SPI1-SR_TIFRFE   %1 8 lshift SPI1-SR bis! ;  \ SPI1-SR_TIFRFE    TI frame format error
: SPI1-SR_BSY   %1 7 lshift SPI1-SR bis! ;  \ SPI1-SR_BSY    Busy flag
: SPI1-SR_OVR   %1 6 lshift SPI1-SR bis! ;  \ SPI1-SR_OVR    Overrun flag
: SPI1-SR_MODF   %1 5 lshift SPI1-SR bis! ;  \ SPI1-SR_MODF    Mode fault
: SPI1-SR_CRCERR   %1 4 lshift SPI1-SR bis! ;  \ SPI1-SR_CRCERR    CRC error flag
: SPI1-SR_UDR   %1 3 lshift SPI1-SR bis! ;  \ SPI1-SR_UDR    Underrun flag
: SPI1-SR_CHSIDE   %1 2 lshift SPI1-SR bis! ;  \ SPI1-SR_CHSIDE    Channel side
: SPI1-SR_TXE   %1 1 lshift SPI1-SR bis! ;  \ SPI1-SR_TXE    Transmit buffer empty
: SPI1-SR_RXNE   %1 0 lshift SPI1-SR bis! ;  \ SPI1-SR_RXNE    Receive buffer not empty

\ SPI1-DR (read-write)
: SPI1-DR_DR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI1-DR bis! ;  \ SPI1-DR_DR    Data register

\ SPI1-CRCPR (read-write)
: SPI1-CRCPR_CRCPOLY   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI1-CRCPR bis! ;  \ SPI1-CRCPR_CRCPOLY    CRC polynomial register

\ SPI1-RXCRCR (read-only)
: SPI1-RXCRCR_RxCRC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI1-RXCRCR bis! ;  \ SPI1-RXCRCR_RxCRC    Rx CRC register

\ SPI1-TXCRCR (read-only)
: SPI1-TXCRCR_TxCRC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI1-TXCRCR bis! ;  \ SPI1-TXCRCR_TxCRC    Tx CRC register

\ SPI1-I2SCFGR (read-write)
: SPI1-I2SCFGR_I2SMOD   %1 11 lshift SPI1-I2SCFGR bis! ;  \ SPI1-I2SCFGR_I2SMOD    I2S mode selection
: SPI1-I2SCFGR_I2SE   %1 10 lshift SPI1-I2SCFGR bis! ;  \ SPI1-I2SCFGR_I2SE    I2S Enable
: SPI1-I2SCFGR_I2SCFG   ( %XX -- ) 8 lshift SPI1-I2SCFGR bis! ;  \ SPI1-I2SCFGR_I2SCFG    I2S configuration mode
: SPI1-I2SCFGR_PCMSYNC   %1 7 lshift SPI1-I2SCFGR bis! ;  \ SPI1-I2SCFGR_PCMSYNC    PCM frame synchronization
: SPI1-I2SCFGR_I2SSTD   ( %XX -- ) 4 lshift SPI1-I2SCFGR bis! ;  \ SPI1-I2SCFGR_I2SSTD    I2S standard selection
: SPI1-I2SCFGR_CKPOL   %1 3 lshift SPI1-I2SCFGR bis! ;  \ SPI1-I2SCFGR_CKPOL    Steady state clock
  polarity
: SPI1-I2SCFGR_DATLEN   ( %XX -- ) 1 lshift SPI1-I2SCFGR bis! ;  \ SPI1-I2SCFGR_DATLEN    Data length to be
  transferred
: SPI1-I2SCFGR_CHLEN   %1 0 lshift SPI1-I2SCFGR bis! ;  \ SPI1-I2SCFGR_CHLEN    Channel length number of bits per audio
  channel

\ SPI1-I2SPR (read-write)
: SPI1-I2SPR_MCKOE   %1 9 lshift SPI1-I2SPR bis! ;  \ SPI1-I2SPR_MCKOE    Master clock output enable
: SPI1-I2SPR_ODD   %1 8 lshift SPI1-I2SPR bis! ;  \ SPI1-I2SPR_ODD    Odd factor for the
  prescaler
: SPI1-I2SPR_I2SDIV   ( %XXXXXXXX -- ) 0 lshift SPI1-I2SPR bis! ;  \ SPI1-I2SPR_I2SDIV    I2S Linear prescaler

\ SPI2-CR1 (read-write)
: SPI2-CR1_BIDIMODE   %1 15 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_BIDIMODE    Bidirectional data mode
  enable
: SPI2-CR1_BIDIOE   %1 14 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_BIDIOE    Output enable in bidirectional
  mode
: SPI2-CR1_CRCEN   %1 13 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_CRCEN    Hardware CRC calculation
  enable
: SPI2-CR1_CRCNEXT   %1 12 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_CRCNEXT    CRC transfer next
: SPI2-CR1_DFF   %1 11 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_DFF    Data frame format
: SPI2-CR1_RXONLY   %1 10 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_RXONLY    Receive only
: SPI2-CR1_SSM   %1 9 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_SSM    Software slave management
: SPI2-CR1_SSI   %1 8 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_SSI    Internal slave select
: SPI2-CR1_LSBFIRST   %1 7 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_LSBFIRST    Frame format
: SPI2-CR1_SPE   %1 6 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_SPE    SPI enable
: SPI2-CR1_BR   ( %XXX -- ) 3 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_BR    Baud rate control
: SPI2-CR1_MSTR   %1 2 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_MSTR    Master selection
: SPI2-CR1_CPOL   %1 1 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_CPOL    Clock polarity
: SPI2-CR1_CPHA   %1 0 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_CPHA    Clock phase

\ SPI2-CR2 (read-write)
: SPI2-CR2_TXEIE   %1 7 lshift SPI2-CR2 bis! ;  \ SPI2-CR2_TXEIE    Tx buffer empty interrupt
  enable
: SPI2-CR2_RXNEIE   %1 6 lshift SPI2-CR2 bis! ;  \ SPI2-CR2_RXNEIE    RX buffer not empty interrupt
  enable
: SPI2-CR2_ERRIE   %1 5 lshift SPI2-CR2 bis! ;  \ SPI2-CR2_ERRIE    Error interrupt enable
: SPI2-CR2_FRF   %1 4 lshift SPI2-CR2 bis! ;  \ SPI2-CR2_FRF    Frame format
: SPI2-CR2_SSOE   %1 2 lshift SPI2-CR2 bis! ;  \ SPI2-CR2_SSOE    SS output enable
: SPI2-CR2_TXDMAEN   %1 1 lshift SPI2-CR2 bis! ;  \ SPI2-CR2_TXDMAEN    Tx buffer DMA enable
: SPI2-CR2_RXDMAEN   %1 0 lshift SPI2-CR2 bis! ;  \ SPI2-CR2_RXDMAEN    Rx buffer DMA enable

\ SPI2-SR ()
: SPI2-SR_TIFRFE   %1 8 lshift SPI2-SR bis! ;  \ SPI2-SR_TIFRFE    TI frame format error
: SPI2-SR_BSY   %1 7 lshift SPI2-SR bis! ;  \ SPI2-SR_BSY    Busy flag
: SPI2-SR_OVR   %1 6 lshift SPI2-SR bis! ;  \ SPI2-SR_OVR    Overrun flag
: SPI2-SR_MODF   %1 5 lshift SPI2-SR bis! ;  \ SPI2-SR_MODF    Mode fault
: SPI2-SR_CRCERR   %1 4 lshift SPI2-SR bis! ;  \ SPI2-SR_CRCERR    CRC error flag
: SPI2-SR_UDR   %1 3 lshift SPI2-SR bis! ;  \ SPI2-SR_UDR    Underrun flag
: SPI2-SR_CHSIDE   %1 2 lshift SPI2-SR bis! ;  \ SPI2-SR_CHSIDE    Channel side
: SPI2-SR_TXE   %1 1 lshift SPI2-SR bis! ;  \ SPI2-SR_TXE    Transmit buffer empty
: SPI2-SR_RXNE   %1 0 lshift SPI2-SR bis! ;  \ SPI2-SR_RXNE    Receive buffer not empty

\ SPI2-DR (read-write)
: SPI2-DR_DR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI2-DR bis! ;  \ SPI2-DR_DR    Data register

\ SPI2-CRCPR (read-write)
: SPI2-CRCPR_CRCPOLY   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI2-CRCPR bis! ;  \ SPI2-CRCPR_CRCPOLY    CRC polynomial register

\ SPI2-RXCRCR (read-only)
: SPI2-RXCRCR_RxCRC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI2-RXCRCR bis! ;  \ SPI2-RXCRCR_RxCRC    Rx CRC register

\ SPI2-TXCRCR (read-only)
: SPI2-TXCRCR_TxCRC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI2-TXCRCR bis! ;  \ SPI2-TXCRCR_TxCRC    Tx CRC register

\ SPI2-I2SCFGR (read-write)
: SPI2-I2SCFGR_I2SMOD   %1 11 lshift SPI2-I2SCFGR bis! ;  \ SPI2-I2SCFGR_I2SMOD    I2S mode selection
: SPI2-I2SCFGR_I2SE   %1 10 lshift SPI2-I2SCFGR bis! ;  \ SPI2-I2SCFGR_I2SE    I2S Enable
: SPI2-I2SCFGR_I2SCFG   ( %XX -- ) 8 lshift SPI2-I2SCFGR bis! ;  \ SPI2-I2SCFGR_I2SCFG    I2S configuration mode
: SPI2-I2SCFGR_PCMSYNC   %1 7 lshift SPI2-I2SCFGR bis! ;  \ SPI2-I2SCFGR_PCMSYNC    PCM frame synchronization
: SPI2-I2SCFGR_I2SSTD   ( %XX -- ) 4 lshift SPI2-I2SCFGR bis! ;  \ SPI2-I2SCFGR_I2SSTD    I2S standard selection
: SPI2-I2SCFGR_CKPOL   %1 3 lshift SPI2-I2SCFGR bis! ;  \ SPI2-I2SCFGR_CKPOL    Steady state clock
  polarity
: SPI2-I2SCFGR_DATLEN   ( %XX -- ) 1 lshift SPI2-I2SCFGR bis! ;  \ SPI2-I2SCFGR_DATLEN    Data length to be
  transferred
: SPI2-I2SCFGR_CHLEN   %1 0 lshift SPI2-I2SCFGR bis! ;  \ SPI2-I2SCFGR_CHLEN    Channel length number of bits per audio
  channel

\ SPI2-I2SPR (read-write)
: SPI2-I2SPR_MCKOE   %1 9 lshift SPI2-I2SPR bis! ;  \ SPI2-I2SPR_MCKOE    Master clock output enable
: SPI2-I2SPR_ODD   %1 8 lshift SPI2-I2SPR bis! ;  \ SPI2-I2SPR_ODD    Odd factor for the
  prescaler
: SPI2-I2SPR_I2SDIV   ( %XXXXXXXX -- ) 0 lshift SPI2-I2SPR bis! ;  \ SPI2-I2SPR_I2SDIV    I2S Linear prescaler

\ SPI3-CR1 (read-write)
: SPI3-CR1_BIDIMODE   %1 15 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_BIDIMODE    Bidirectional data mode
  enable
: SPI3-CR1_BIDIOE   %1 14 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_BIDIOE    Output enable in bidirectional
  mode
: SPI3-CR1_CRCEN   %1 13 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_CRCEN    Hardware CRC calculation
  enable
: SPI3-CR1_CRCNEXT   %1 12 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_CRCNEXT    CRC transfer next
: SPI3-CR1_DFF   %1 11 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_DFF    Data frame format
: SPI3-CR1_RXONLY   %1 10 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_RXONLY    Receive only
: SPI3-CR1_SSM   %1 9 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_SSM    Software slave management
: SPI3-CR1_SSI   %1 8 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_SSI    Internal slave select
: SPI3-CR1_LSBFIRST   %1 7 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_LSBFIRST    Frame format
: SPI3-CR1_SPE   %1 6 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_SPE    SPI enable
: SPI3-CR1_BR   ( %XXX -- ) 3 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_BR    Baud rate control
: SPI3-CR1_MSTR   %1 2 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_MSTR    Master selection
: SPI3-CR1_CPOL   %1 1 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_CPOL    Clock polarity
: SPI3-CR1_CPHA   %1 0 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_CPHA    Clock phase

\ SPI3-CR2 (read-write)
: SPI3-CR2_TXEIE   %1 7 lshift SPI3-CR2 bis! ;  \ SPI3-CR2_TXEIE    Tx buffer empty interrupt
  enable
: SPI3-CR2_RXNEIE   %1 6 lshift SPI3-CR2 bis! ;  \ SPI3-CR2_RXNEIE    RX buffer not empty interrupt
  enable
: SPI3-CR2_ERRIE   %1 5 lshift SPI3-CR2 bis! ;  \ SPI3-CR2_ERRIE    Error interrupt enable
: SPI3-CR2_FRF   %1 4 lshift SPI3-CR2 bis! ;  \ SPI3-CR2_FRF    Frame format
: SPI3-CR2_SSOE   %1 2 lshift SPI3-CR2 bis! ;  \ SPI3-CR2_SSOE    SS output enable
: SPI3-CR2_TXDMAEN   %1 1 lshift SPI3-CR2 bis! ;  \ SPI3-CR2_TXDMAEN    Tx buffer DMA enable
: SPI3-CR2_RXDMAEN   %1 0 lshift SPI3-CR2 bis! ;  \ SPI3-CR2_RXDMAEN    Rx buffer DMA enable

\ SPI3-SR ()
: SPI3-SR_TIFRFE   %1 8 lshift SPI3-SR bis! ;  \ SPI3-SR_TIFRFE    TI frame format error
: SPI3-SR_BSY   %1 7 lshift SPI3-SR bis! ;  \ SPI3-SR_BSY    Busy flag
: SPI3-SR_OVR   %1 6 lshift SPI3-SR bis! ;  \ SPI3-SR_OVR    Overrun flag
: SPI3-SR_MODF   %1 5 lshift SPI3-SR bis! ;  \ SPI3-SR_MODF    Mode fault
: SPI3-SR_CRCERR   %1 4 lshift SPI3-SR bis! ;  \ SPI3-SR_CRCERR    CRC error flag
: SPI3-SR_UDR   %1 3 lshift SPI3-SR bis! ;  \ SPI3-SR_UDR    Underrun flag
: SPI3-SR_CHSIDE   %1 2 lshift SPI3-SR bis! ;  \ SPI3-SR_CHSIDE    Channel side
: SPI3-SR_TXE   %1 1 lshift SPI3-SR bis! ;  \ SPI3-SR_TXE    Transmit buffer empty
: SPI3-SR_RXNE   %1 0 lshift SPI3-SR bis! ;  \ SPI3-SR_RXNE    Receive buffer not empty

\ SPI3-DR (read-write)
: SPI3-DR_DR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI3-DR bis! ;  \ SPI3-DR_DR    Data register

\ SPI3-CRCPR (read-write)
: SPI3-CRCPR_CRCPOLY   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI3-CRCPR bis! ;  \ SPI3-CRCPR_CRCPOLY    CRC polynomial register

\ SPI3-RXCRCR (read-only)
: SPI3-RXCRCR_RxCRC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI3-RXCRCR bis! ;  \ SPI3-RXCRCR_RxCRC    Rx CRC register

\ SPI3-TXCRCR (read-only)
: SPI3-TXCRCR_TxCRC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI3-TXCRCR bis! ;  \ SPI3-TXCRCR_TxCRC    Tx CRC register

\ SPI3-I2SCFGR (read-write)
: SPI3-I2SCFGR_I2SMOD   %1 11 lshift SPI3-I2SCFGR bis! ;  \ SPI3-I2SCFGR_I2SMOD    I2S mode selection
: SPI3-I2SCFGR_I2SE   %1 10 lshift SPI3-I2SCFGR bis! ;  \ SPI3-I2SCFGR_I2SE    I2S Enable
: SPI3-I2SCFGR_I2SCFG   ( %XX -- ) 8 lshift SPI3-I2SCFGR bis! ;  \ SPI3-I2SCFGR_I2SCFG    I2S configuration mode
: SPI3-I2SCFGR_PCMSYNC   %1 7 lshift SPI3-I2SCFGR bis! ;  \ SPI3-I2SCFGR_PCMSYNC    PCM frame synchronization
: SPI3-I2SCFGR_I2SSTD   ( %XX -- ) 4 lshift SPI3-I2SCFGR bis! ;  \ SPI3-I2SCFGR_I2SSTD    I2S standard selection
: SPI3-I2SCFGR_CKPOL   %1 3 lshift SPI3-I2SCFGR bis! ;  \ SPI3-I2SCFGR_CKPOL    Steady state clock
  polarity
: SPI3-I2SCFGR_DATLEN   ( %XX -- ) 1 lshift SPI3-I2SCFGR bis! ;  \ SPI3-I2SCFGR_DATLEN    Data length to be
  transferred
: SPI3-I2SCFGR_CHLEN   %1 0 lshift SPI3-I2SCFGR bis! ;  \ SPI3-I2SCFGR_CHLEN    Channel length number of bits per audio
  channel

\ SPI3-I2SPR (read-write)
: SPI3-I2SPR_MCKOE   %1 9 lshift SPI3-I2SPR bis! ;  \ SPI3-I2SPR_MCKOE    Master clock output enable
: SPI3-I2SPR_ODD   %1 8 lshift SPI3-I2SPR bis! ;  \ SPI3-I2SPR_ODD    Odd factor for the
  prescaler
: SPI3-I2SPR_I2SDIV   ( %XXXXXXXX -- ) 0 lshift SPI3-I2SPR bis! ;  \ SPI3-I2SPR_I2SDIV    I2S Linear prescaler

\ SPI4-CR1 (read-write)
: SPI4-CR1_BIDIMODE   %1 15 lshift SPI4-CR1 bis! ;  \ SPI4-CR1_BIDIMODE    Bidirectional data mode
  enable
: SPI4-CR1_BIDIOE   %1 14 lshift SPI4-CR1 bis! ;  \ SPI4-CR1_BIDIOE    Output enable in bidirectional
  mode
: SPI4-CR1_CRCEN   %1 13 lshift SPI4-CR1 bis! ;  \ SPI4-CR1_CRCEN    Hardware CRC calculation
  enable
: SPI4-CR1_CRCNEXT   %1 12 lshift SPI4-CR1 bis! ;  \ SPI4-CR1_CRCNEXT    CRC transfer next
: SPI4-CR1_DFF   %1 11 lshift SPI4-CR1 bis! ;  \ SPI4-CR1_DFF    Data frame format
: SPI4-CR1_RXONLY   %1 10 lshift SPI4-CR1 bis! ;  \ SPI4-CR1_RXONLY    Receive only
: SPI4-CR1_SSM   %1 9 lshift SPI4-CR1 bis! ;  \ SPI4-CR1_SSM    Software slave management
: SPI4-CR1_SSI   %1 8 lshift SPI4-CR1 bis! ;  \ SPI4-CR1_SSI    Internal slave select
: SPI4-CR1_LSBFIRST   %1 7 lshift SPI4-CR1 bis! ;  \ SPI4-CR1_LSBFIRST    Frame format
: SPI4-CR1_SPE   %1 6 lshift SPI4-CR1 bis! ;  \ SPI4-CR1_SPE    SPI enable
: SPI4-CR1_BR   ( %XXX -- ) 3 lshift SPI4-CR1 bis! ;  \ SPI4-CR1_BR    Baud rate control
: SPI4-CR1_MSTR   %1 2 lshift SPI4-CR1 bis! ;  \ SPI4-CR1_MSTR    Master selection
: SPI4-CR1_CPOL   %1 1 lshift SPI4-CR1 bis! ;  \ SPI4-CR1_CPOL    Clock polarity
: SPI4-CR1_CPHA   %1 0 lshift SPI4-CR1 bis! ;  \ SPI4-CR1_CPHA    Clock phase

\ SPI4-CR2 (read-write)
: SPI4-CR2_TXEIE   %1 7 lshift SPI4-CR2 bis! ;  \ SPI4-CR2_TXEIE    Tx buffer empty interrupt
  enable
: SPI4-CR2_RXNEIE   %1 6 lshift SPI4-CR2 bis! ;  \ SPI4-CR2_RXNEIE    RX buffer not empty interrupt
  enable
: SPI4-CR2_ERRIE   %1 5 lshift SPI4-CR2 bis! ;  \ SPI4-CR2_ERRIE    Error interrupt enable
: SPI4-CR2_FRF   %1 4 lshift SPI4-CR2 bis! ;  \ SPI4-CR2_FRF    Frame format
: SPI4-CR2_SSOE   %1 2 lshift SPI4-CR2 bis! ;  \ SPI4-CR2_SSOE    SS output enable
: SPI4-CR2_TXDMAEN   %1 1 lshift SPI4-CR2 bis! ;  \ SPI4-CR2_TXDMAEN    Tx buffer DMA enable
: SPI4-CR2_RXDMAEN   %1 0 lshift SPI4-CR2 bis! ;  \ SPI4-CR2_RXDMAEN    Rx buffer DMA enable

\ SPI4-SR ()
: SPI4-SR_TIFRFE   %1 8 lshift SPI4-SR bis! ;  \ SPI4-SR_TIFRFE    TI frame format error
: SPI4-SR_BSY   %1 7 lshift SPI4-SR bis! ;  \ SPI4-SR_BSY    Busy flag
: SPI4-SR_OVR   %1 6 lshift SPI4-SR bis! ;  \ SPI4-SR_OVR    Overrun flag
: SPI4-SR_MODF   %1 5 lshift SPI4-SR bis! ;  \ SPI4-SR_MODF    Mode fault
: SPI4-SR_CRCERR   %1 4 lshift SPI4-SR bis! ;  \ SPI4-SR_CRCERR    CRC error flag
: SPI4-SR_UDR   %1 3 lshift SPI4-SR bis! ;  \ SPI4-SR_UDR    Underrun flag
: SPI4-SR_CHSIDE   %1 2 lshift SPI4-SR bis! ;  \ SPI4-SR_CHSIDE    Channel side
: SPI4-SR_TXE   %1 1 lshift SPI4-SR bis! ;  \ SPI4-SR_TXE    Transmit buffer empty
: SPI4-SR_RXNE   %1 0 lshift SPI4-SR bis! ;  \ SPI4-SR_RXNE    Receive buffer not empty

\ SPI4-DR (read-write)
: SPI4-DR_DR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI4-DR bis! ;  \ SPI4-DR_DR    Data register

\ SPI4-CRCPR (read-write)
: SPI4-CRCPR_CRCPOLY   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI4-CRCPR bis! ;  \ SPI4-CRCPR_CRCPOLY    CRC polynomial register

\ SPI4-RXCRCR (read-only)
: SPI4-RXCRCR_RxCRC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI4-RXCRCR bis! ;  \ SPI4-RXCRCR_RxCRC    Rx CRC register

\ SPI4-TXCRCR (read-only)
: SPI4-TXCRCR_TxCRC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI4-TXCRCR bis! ;  \ SPI4-TXCRCR_TxCRC    Tx CRC register

\ SPI4-I2SCFGR (read-write)
: SPI4-I2SCFGR_I2SMOD   %1 11 lshift SPI4-I2SCFGR bis! ;  \ SPI4-I2SCFGR_I2SMOD    I2S mode selection
: SPI4-I2SCFGR_I2SE   %1 10 lshift SPI4-I2SCFGR bis! ;  \ SPI4-I2SCFGR_I2SE    I2S Enable
: SPI4-I2SCFGR_I2SCFG   ( %XX -- ) 8 lshift SPI4-I2SCFGR bis! ;  \ SPI4-I2SCFGR_I2SCFG    I2S configuration mode
: SPI4-I2SCFGR_PCMSYNC   %1 7 lshift SPI4-I2SCFGR bis! ;  \ SPI4-I2SCFGR_PCMSYNC    PCM frame synchronization
: SPI4-I2SCFGR_I2SSTD   ( %XX -- ) 4 lshift SPI4-I2SCFGR bis! ;  \ SPI4-I2SCFGR_I2SSTD    I2S standard selection
: SPI4-I2SCFGR_CKPOL   %1 3 lshift SPI4-I2SCFGR bis! ;  \ SPI4-I2SCFGR_CKPOL    Steady state clock
  polarity
: SPI4-I2SCFGR_DATLEN   ( %XX -- ) 1 lshift SPI4-I2SCFGR bis! ;  \ SPI4-I2SCFGR_DATLEN    Data length to be
  transferred
: SPI4-I2SCFGR_CHLEN   %1 0 lshift SPI4-I2SCFGR bis! ;  \ SPI4-I2SCFGR_CHLEN    Channel length number of bits per audio
  channel

\ SPI4-I2SPR (read-write)
: SPI4-I2SPR_MCKOE   %1 9 lshift SPI4-I2SPR bis! ;  \ SPI4-I2SPR_MCKOE    Master clock output enable
: SPI4-I2SPR_ODD   %1 8 lshift SPI4-I2SPR bis! ;  \ SPI4-I2SPR_ODD    Odd factor for the
  prescaler
: SPI4-I2SPR_I2SDIV   ( %XXXXXXXX -- ) 0 lshift SPI4-I2SPR bis! ;  \ SPI4-I2SPR_I2SDIV    I2S Linear prescaler

\ SPI5-CR1 (read-write)
: SPI5-CR1_BIDIMODE   %1 15 lshift SPI5-CR1 bis! ;  \ SPI5-CR1_BIDIMODE    Bidirectional data mode
  enable
: SPI5-CR1_BIDIOE   %1 14 lshift SPI5-CR1 bis! ;  \ SPI5-CR1_BIDIOE    Output enable in bidirectional
  mode
: SPI5-CR1_CRCEN   %1 13 lshift SPI5-CR1 bis! ;  \ SPI5-CR1_CRCEN    Hardware CRC calculation
  enable
: SPI5-CR1_CRCNEXT   %1 12 lshift SPI5-CR1 bis! ;  \ SPI5-CR1_CRCNEXT    CRC transfer next
: SPI5-CR1_DFF   %1 11 lshift SPI5-CR1 bis! ;  \ SPI5-CR1_DFF    Data frame format
: SPI5-CR1_RXONLY   %1 10 lshift SPI5-CR1 bis! ;  \ SPI5-CR1_RXONLY    Receive only
: SPI5-CR1_SSM   %1 9 lshift SPI5-CR1 bis! ;  \ SPI5-CR1_SSM    Software slave management
: SPI5-CR1_SSI   %1 8 lshift SPI5-CR1 bis! ;  \ SPI5-CR1_SSI    Internal slave select
: SPI5-CR1_LSBFIRST   %1 7 lshift SPI5-CR1 bis! ;  \ SPI5-CR1_LSBFIRST    Frame format
: SPI5-CR1_SPE   %1 6 lshift SPI5-CR1 bis! ;  \ SPI5-CR1_SPE    SPI enable
: SPI5-CR1_BR   ( %XXX -- ) 3 lshift SPI5-CR1 bis! ;  \ SPI5-CR1_BR    Baud rate control
: SPI5-CR1_MSTR   %1 2 lshift SPI5-CR1 bis! ;  \ SPI5-CR1_MSTR    Master selection
: SPI5-CR1_CPOL   %1 1 lshift SPI5-CR1 bis! ;  \ SPI5-CR1_CPOL    Clock polarity
: SPI5-CR1_CPHA   %1 0 lshift SPI5-CR1 bis! ;  \ SPI5-CR1_CPHA    Clock phase

\ SPI5-CR2 (read-write)
: SPI5-CR2_TXEIE   %1 7 lshift SPI5-CR2 bis! ;  \ SPI5-CR2_TXEIE    Tx buffer empty interrupt
  enable
: SPI5-CR2_RXNEIE   %1 6 lshift SPI5-CR2 bis! ;  \ SPI5-CR2_RXNEIE    RX buffer not empty interrupt
  enable
: SPI5-CR2_ERRIE   %1 5 lshift SPI5-CR2 bis! ;  \ SPI5-CR2_ERRIE    Error interrupt enable
: SPI5-CR2_FRF   %1 4 lshift SPI5-CR2 bis! ;  \ SPI5-CR2_FRF    Frame format
: SPI5-CR2_SSOE   %1 2 lshift SPI5-CR2 bis! ;  \ SPI5-CR2_SSOE    SS output enable
: SPI5-CR2_TXDMAEN   %1 1 lshift SPI5-CR2 bis! ;  \ SPI5-CR2_TXDMAEN    Tx buffer DMA enable
: SPI5-CR2_RXDMAEN   %1 0 lshift SPI5-CR2 bis! ;  \ SPI5-CR2_RXDMAEN    Rx buffer DMA enable

\ SPI5-SR ()
: SPI5-SR_TIFRFE   %1 8 lshift SPI5-SR bis! ;  \ SPI5-SR_TIFRFE    TI frame format error
: SPI5-SR_BSY   %1 7 lshift SPI5-SR bis! ;  \ SPI5-SR_BSY    Busy flag
: SPI5-SR_OVR   %1 6 lshift SPI5-SR bis! ;  \ SPI5-SR_OVR    Overrun flag
: SPI5-SR_MODF   %1 5 lshift SPI5-SR bis! ;  \ SPI5-SR_MODF    Mode fault
: SPI5-SR_CRCERR   %1 4 lshift SPI5-SR bis! ;  \ SPI5-SR_CRCERR    CRC error flag
: SPI5-SR_UDR   %1 3 lshift SPI5-SR bis! ;  \ SPI5-SR_UDR    Underrun flag
: SPI5-SR_CHSIDE   %1 2 lshift SPI5-SR bis! ;  \ SPI5-SR_CHSIDE    Channel side
: SPI5-SR_TXE   %1 1 lshift SPI5-SR bis! ;  \ SPI5-SR_TXE    Transmit buffer empty
: SPI5-SR_RXNE   %1 0 lshift SPI5-SR bis! ;  \ SPI5-SR_RXNE    Receive buffer not empty

\ SPI5-DR (read-write)
: SPI5-DR_DR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI5-DR bis! ;  \ SPI5-DR_DR    Data register

\ SPI5-CRCPR (read-write)
: SPI5-CRCPR_CRCPOLY   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI5-CRCPR bis! ;  \ SPI5-CRCPR_CRCPOLY    CRC polynomial register

\ SPI5-RXCRCR (read-only)
: SPI5-RXCRCR_RxCRC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI5-RXCRCR bis! ;  \ SPI5-RXCRCR_RxCRC    Rx CRC register

\ SPI5-TXCRCR (read-only)
: SPI5-TXCRCR_TxCRC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI5-TXCRCR bis! ;  \ SPI5-TXCRCR_TxCRC    Tx CRC register

\ SPI5-I2SCFGR (read-write)
: SPI5-I2SCFGR_I2SMOD   %1 11 lshift SPI5-I2SCFGR bis! ;  \ SPI5-I2SCFGR_I2SMOD    I2S mode selection
: SPI5-I2SCFGR_I2SE   %1 10 lshift SPI5-I2SCFGR bis! ;  \ SPI5-I2SCFGR_I2SE    I2S Enable
: SPI5-I2SCFGR_I2SCFG   ( %XX -- ) 8 lshift SPI5-I2SCFGR bis! ;  \ SPI5-I2SCFGR_I2SCFG    I2S configuration mode
: SPI5-I2SCFGR_PCMSYNC   %1 7 lshift SPI5-I2SCFGR bis! ;  \ SPI5-I2SCFGR_PCMSYNC    PCM frame synchronization
: SPI5-I2SCFGR_I2SSTD   ( %XX -- ) 4 lshift SPI5-I2SCFGR bis! ;  \ SPI5-I2SCFGR_I2SSTD    I2S standard selection
: SPI5-I2SCFGR_CKPOL   %1 3 lshift SPI5-I2SCFGR bis! ;  \ SPI5-I2SCFGR_CKPOL    Steady state clock
  polarity
: SPI5-I2SCFGR_DATLEN   ( %XX -- ) 1 lshift SPI5-I2SCFGR bis! ;  \ SPI5-I2SCFGR_DATLEN    Data length to be
  transferred
: SPI5-I2SCFGR_CHLEN   %1 0 lshift SPI5-I2SCFGR bis! ;  \ SPI5-I2SCFGR_CHLEN    Channel length number of bits per audio
  channel

\ SPI5-I2SPR (read-write)
: SPI5-I2SPR_MCKOE   %1 9 lshift SPI5-I2SPR bis! ;  \ SPI5-I2SPR_MCKOE    Master clock output enable
: SPI5-I2SPR_ODD   %1 8 lshift SPI5-I2SPR bis! ;  \ SPI5-I2SPR_ODD    Odd factor for the
  prescaler
: SPI5-I2SPR_I2SDIV   ( %XXXXXXXX -- ) 0 lshift SPI5-I2SPR bis! ;  \ SPI5-I2SPR_I2SDIV    I2S Linear prescaler

\ NVIC-ISER0 (read-write)
: NVIC-ISER0_SETENA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-ISER0 bis! ;  \ NVIC-ISER0_SETENA    SETENA

\ NVIC-ISER1 (read-write)
: NVIC-ISER1_SETENA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-ISER1 bis! ;  \ NVIC-ISER1_SETENA    SETENA

\ NVIC-ISER2 (read-write)
: NVIC-ISER2_SETENA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-ISER2 bis! ;  \ NVIC-ISER2_SETENA    SETENA

\ NVIC-ICER0 (read-write)
: NVIC-ICER0_CLRENA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-ICER0 bis! ;  \ NVIC-ICER0_CLRENA    CLRENA

\ NVIC-ICER1 (read-write)
: NVIC-ICER1_CLRENA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-ICER1 bis! ;  \ NVIC-ICER1_CLRENA    CLRENA

\ NVIC-ICER2 (read-write)
: NVIC-ICER2_CLRENA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-ICER2 bis! ;  \ NVIC-ICER2_CLRENA    CLRENA

\ NVIC-ISPR0 (read-write)
: NVIC-ISPR0_SETPEND   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-ISPR0 bis! ;  \ NVIC-ISPR0_SETPEND    SETPEND

\ NVIC-ISPR1 (read-write)
: NVIC-ISPR1_SETPEND   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-ISPR1 bis! ;  \ NVIC-ISPR1_SETPEND    SETPEND

\ NVIC-ISPR2 (read-write)
: NVIC-ISPR2_SETPEND   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-ISPR2 bis! ;  \ NVIC-ISPR2_SETPEND    SETPEND

\ NVIC-ICPR0 (read-write)
: NVIC-ICPR0_CLRPEND   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-ICPR0 bis! ;  \ NVIC-ICPR0_CLRPEND    CLRPEND

\ NVIC-ICPR1 (read-write)
: NVIC-ICPR1_CLRPEND   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-ICPR1 bis! ;  \ NVIC-ICPR1_CLRPEND    CLRPEND

\ NVIC-ICPR2 (read-write)
: NVIC-ICPR2_CLRPEND   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-ICPR2 bis! ;  \ NVIC-ICPR2_CLRPEND    CLRPEND

\ NVIC-IABR0 (read-only)
: NVIC-IABR0_ACTIVE   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-IABR0 bis! ;  \ NVIC-IABR0_ACTIVE    ACTIVE

\ NVIC-IABR1 (read-only)
: NVIC-IABR1_ACTIVE   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-IABR1 bis! ;  \ NVIC-IABR1_ACTIVE    ACTIVE

\ NVIC-IABR2 (read-only)
: NVIC-IABR2_ACTIVE   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-IABR2 bis! ;  \ NVIC-IABR2_ACTIVE    ACTIVE

\ NVIC-IPR0 (read-write)
: NVIC-IPR0_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR0 bis! ;  \ NVIC-IPR0_IPR_N0    IPR_N0
: NVIC-IPR0_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR0 bis! ;  \ NVIC-IPR0_IPR_N1    IPR_N1
: NVIC-IPR0_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR0 bis! ;  \ NVIC-IPR0_IPR_N2    IPR_N2
: NVIC-IPR0_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR0 bis! ;  \ NVIC-IPR0_IPR_N3    IPR_N3

\ NVIC-IPR1 (read-write)
: NVIC-IPR1_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR1 bis! ;  \ NVIC-IPR1_IPR_N0    IPR_N0
: NVIC-IPR1_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR1 bis! ;  \ NVIC-IPR1_IPR_N1    IPR_N1
: NVIC-IPR1_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR1 bis! ;  \ NVIC-IPR1_IPR_N2    IPR_N2
: NVIC-IPR1_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR1 bis! ;  \ NVIC-IPR1_IPR_N3    IPR_N3

\ NVIC-IPR2 (read-write)
: NVIC-IPR2_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR2 bis! ;  \ NVIC-IPR2_IPR_N0    IPR_N0
: NVIC-IPR2_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR2 bis! ;  \ NVIC-IPR2_IPR_N1    IPR_N1
: NVIC-IPR2_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR2 bis! ;  \ NVIC-IPR2_IPR_N2    IPR_N2
: NVIC-IPR2_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR2 bis! ;  \ NVIC-IPR2_IPR_N3    IPR_N3

\ NVIC-IPR3 (read-write)
: NVIC-IPR3_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR3 bis! ;  \ NVIC-IPR3_IPR_N0    IPR_N0
: NVIC-IPR3_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR3 bis! ;  \ NVIC-IPR3_IPR_N1    IPR_N1
: NVIC-IPR3_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR3 bis! ;  \ NVIC-IPR3_IPR_N2    IPR_N2
: NVIC-IPR3_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR3 bis! ;  \ NVIC-IPR3_IPR_N3    IPR_N3

\ NVIC-IPR4 (read-write)
: NVIC-IPR4_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR4 bis! ;  \ NVIC-IPR4_IPR_N0    IPR_N0
: NVIC-IPR4_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR4 bis! ;  \ NVIC-IPR4_IPR_N1    IPR_N1
: NVIC-IPR4_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR4 bis! ;  \ NVIC-IPR4_IPR_N2    IPR_N2
: NVIC-IPR4_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR4 bis! ;  \ NVIC-IPR4_IPR_N3    IPR_N3

\ NVIC-IPR5 (read-write)
: NVIC-IPR5_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR5 bis! ;  \ NVIC-IPR5_IPR_N0    IPR_N0
: NVIC-IPR5_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR5 bis! ;  \ NVIC-IPR5_IPR_N1    IPR_N1
: NVIC-IPR5_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR5 bis! ;  \ NVIC-IPR5_IPR_N2    IPR_N2
: NVIC-IPR5_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR5 bis! ;  \ NVIC-IPR5_IPR_N3    IPR_N3

\ NVIC-IPR6 (read-write)
: NVIC-IPR6_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR6 bis! ;  \ NVIC-IPR6_IPR_N0    IPR_N0
: NVIC-IPR6_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR6 bis! ;  \ NVIC-IPR6_IPR_N1    IPR_N1
: NVIC-IPR6_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR6 bis! ;  \ NVIC-IPR6_IPR_N2    IPR_N2
: NVIC-IPR6_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR6 bis! ;  \ NVIC-IPR6_IPR_N3    IPR_N3

\ NVIC-IPR7 (read-write)
: NVIC-IPR7_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR7 bis! ;  \ NVIC-IPR7_IPR_N0    IPR_N0
: NVIC-IPR7_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR7 bis! ;  \ NVIC-IPR7_IPR_N1    IPR_N1
: NVIC-IPR7_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR7 bis! ;  \ NVIC-IPR7_IPR_N2    IPR_N2
: NVIC-IPR7_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR7 bis! ;  \ NVIC-IPR7_IPR_N3    IPR_N3

\ NVIC-IPR8 (read-write)
: NVIC-IPR8_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR8 bis! ;  \ NVIC-IPR8_IPR_N0    IPR_N0
: NVIC-IPR8_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR8 bis! ;  \ NVIC-IPR8_IPR_N1    IPR_N1
: NVIC-IPR8_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR8 bis! ;  \ NVIC-IPR8_IPR_N2    IPR_N2
: NVIC-IPR8_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR8 bis! ;  \ NVIC-IPR8_IPR_N3    IPR_N3

\ NVIC-IPR9 (read-write)
: NVIC-IPR9_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR9 bis! ;  \ NVIC-IPR9_IPR_N0    IPR_N0
: NVIC-IPR9_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR9 bis! ;  \ NVIC-IPR9_IPR_N1    IPR_N1
: NVIC-IPR9_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR9 bis! ;  \ NVIC-IPR9_IPR_N2    IPR_N2
: NVIC-IPR9_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR9 bis! ;  \ NVIC-IPR9_IPR_N3    IPR_N3

\ NVIC-IPR10 (read-write)
: NVIC-IPR10_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR10 bis! ;  \ NVIC-IPR10_IPR_N0    IPR_N0
: NVIC-IPR10_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR10 bis! ;  \ NVIC-IPR10_IPR_N1    IPR_N1
: NVIC-IPR10_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR10 bis! ;  \ NVIC-IPR10_IPR_N2    IPR_N2
: NVIC-IPR10_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR10 bis! ;  \ NVIC-IPR10_IPR_N3    IPR_N3

\ NVIC-IPR11 (read-write)
: NVIC-IPR11_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR11 bis! ;  \ NVIC-IPR11_IPR_N0    IPR_N0
: NVIC-IPR11_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR11 bis! ;  \ NVIC-IPR11_IPR_N1    IPR_N1
: NVIC-IPR11_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR11 bis! ;  \ NVIC-IPR11_IPR_N2    IPR_N2
: NVIC-IPR11_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR11 bis! ;  \ NVIC-IPR11_IPR_N3    IPR_N3

\ NVIC-IPR12 (read-write)
: NVIC-IPR12_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR12 bis! ;  \ NVIC-IPR12_IPR_N0    IPR_N0
: NVIC-IPR12_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR12 bis! ;  \ NVIC-IPR12_IPR_N1    IPR_N1
: NVIC-IPR12_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR12 bis! ;  \ NVIC-IPR12_IPR_N2    IPR_N2
: NVIC-IPR12_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR12 bis! ;  \ NVIC-IPR12_IPR_N3    IPR_N3

\ NVIC-IPR13 (read-write)
: NVIC-IPR13_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR13 bis! ;  \ NVIC-IPR13_IPR_N0    IPR_N0
: NVIC-IPR13_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR13 bis! ;  \ NVIC-IPR13_IPR_N1    IPR_N1
: NVIC-IPR13_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR13 bis! ;  \ NVIC-IPR13_IPR_N2    IPR_N2
: NVIC-IPR13_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR13 bis! ;  \ NVIC-IPR13_IPR_N3    IPR_N3

\ NVIC-IPR14 (read-write)
: NVIC-IPR14_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR14 bis! ;  \ NVIC-IPR14_IPR_N0    IPR_N0
: NVIC-IPR14_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR14 bis! ;  \ NVIC-IPR14_IPR_N1    IPR_N1
: NVIC-IPR14_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR14 bis! ;  \ NVIC-IPR14_IPR_N2    IPR_N2
: NVIC-IPR14_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR14 bis! ;  \ NVIC-IPR14_IPR_N3    IPR_N3

\ NVIC-IPR15 (read-write)
: NVIC-IPR15_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR15 bis! ;  \ NVIC-IPR15_IPR_N0    IPR_N0
: NVIC-IPR15_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR15 bis! ;  \ NVIC-IPR15_IPR_N1    IPR_N1
: NVIC-IPR15_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR15 bis! ;  \ NVIC-IPR15_IPR_N2    IPR_N2
: NVIC-IPR15_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR15 bis! ;  \ NVIC-IPR15_IPR_N3    IPR_N3

\ NVIC-IPR16 (read-write)
: NVIC-IPR16_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR16 bis! ;  \ NVIC-IPR16_IPR_N0    IPR_N0
: NVIC-IPR16_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR16 bis! ;  \ NVIC-IPR16_IPR_N1    IPR_N1
: NVIC-IPR16_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR16 bis! ;  \ NVIC-IPR16_IPR_N2    IPR_N2
: NVIC-IPR16_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR16 bis! ;  \ NVIC-IPR16_IPR_N3    IPR_N3

\ NVIC-IPR17 (read-write)
: NVIC-IPR17_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR17 bis! ;  \ NVIC-IPR17_IPR_N0    IPR_N0
: NVIC-IPR17_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR17 bis! ;  \ NVIC-IPR17_IPR_N1    IPR_N1
: NVIC-IPR17_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR17 bis! ;  \ NVIC-IPR17_IPR_N2    IPR_N2
: NVIC-IPR17_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR17 bis! ;  \ NVIC-IPR17_IPR_N3    IPR_N3

\ NVIC-IPR18 (read-write)
: NVIC-IPR18_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR18 bis! ;  \ NVIC-IPR18_IPR_N0    IPR_N0
: NVIC-IPR18_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR18 bis! ;  \ NVIC-IPR18_IPR_N1    IPR_N1
: NVIC-IPR18_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR18 bis! ;  \ NVIC-IPR18_IPR_N2    IPR_N2
: NVIC-IPR18_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR18 bis! ;  \ NVIC-IPR18_IPR_N3    IPR_N3

\ NVIC-IPR19 (read-write)
: NVIC-IPR19_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR19 bis! ;  \ NVIC-IPR19_IPR_N0    IPR_N0
: NVIC-IPR19_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR19 bis! ;  \ NVIC-IPR19_IPR_N1    IPR_N1
: NVIC-IPR19_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR19 bis! ;  \ NVIC-IPR19_IPR_N2    IPR_N2
: NVIC-IPR19_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR19 bis! ;  \ NVIC-IPR19_IPR_N3    IPR_N3

\ FPU-FPCCR (read-write)
: FPU-FPCCR_LSPACT   %1 0 lshift FPU-FPCCR bis! ;  \ FPU-FPCCR_LSPACT    LSPACT
: FPU-FPCCR_USER   %1 1 lshift FPU-FPCCR bis! ;  \ FPU-FPCCR_USER    USER
: FPU-FPCCR_THREAD   %1 3 lshift FPU-FPCCR bis! ;  \ FPU-FPCCR_THREAD    THREAD
: FPU-FPCCR_HFRDY   %1 4 lshift FPU-FPCCR bis! ;  \ FPU-FPCCR_HFRDY    HFRDY
: FPU-FPCCR_MMRDY   %1 5 lshift FPU-FPCCR bis! ;  \ FPU-FPCCR_MMRDY    MMRDY
: FPU-FPCCR_BFRDY   %1 6 lshift FPU-FPCCR bis! ;  \ FPU-FPCCR_BFRDY    BFRDY
: FPU-FPCCR_MONRDY   %1 8 lshift FPU-FPCCR bis! ;  \ FPU-FPCCR_MONRDY    MONRDY
: FPU-FPCCR_LSPEN   %1 30 lshift FPU-FPCCR bis! ;  \ FPU-FPCCR_LSPEN    LSPEN
: FPU-FPCCR_ASPEN   %1 31 lshift FPU-FPCCR bis! ;  \ FPU-FPCCR_ASPEN    ASPEN

\ FPU-FPCAR (read-write)
: FPU-FPCAR_ADDRESS  3 lshift FPU-FPCAR bis! ;  \ FPU-FPCAR_ADDRESS    Location of unpopulated
  floating-point

\ FPU-FPSCR (read-write)
: FPU-FPSCR_IOC   %1 0 lshift FPU-FPSCR bis! ;  \ FPU-FPSCR_IOC    Invalid operation cumulative exception
  bit
: FPU-FPSCR_DZC   %1 1 lshift FPU-FPSCR bis! ;  \ FPU-FPSCR_DZC    Division by zero cumulative exception
  bit.
: FPU-FPSCR_OFC   %1 2 lshift FPU-FPSCR bis! ;  \ FPU-FPSCR_OFC    Overflow cumulative exception
  bit
: FPU-FPSCR_UFC   %1 3 lshift FPU-FPSCR bis! ;  \ FPU-FPSCR_UFC    Underflow cumulative exception
  bit
: FPU-FPSCR_IXC   %1 4 lshift FPU-FPSCR bis! ;  \ FPU-FPSCR_IXC    Inexact cumulative exception
  bit
: FPU-FPSCR_IDC   %1 7 lshift FPU-FPSCR bis! ;  \ FPU-FPSCR_IDC    Input denormal cumulative exception
  bit.
: FPU-FPSCR_RMode   ( %XX -- ) 22 lshift FPU-FPSCR bis! ;  \ FPU-FPSCR_RMode    Rounding Mode control
  field
: FPU-FPSCR_FZ   %1 24 lshift FPU-FPSCR bis! ;  \ FPU-FPSCR_FZ    Flush-to-zero mode control
  bit:
: FPU-FPSCR_DN   %1 25 lshift FPU-FPSCR bis! ;  \ FPU-FPSCR_DN    Default NaN mode control
  bit
: FPU-FPSCR_AHP   %1 26 lshift FPU-FPSCR bis! ;  \ FPU-FPSCR_AHP    Alternative half-precision control
  bit
: FPU-FPSCR_V   %1 28 lshift FPU-FPSCR bis! ;  \ FPU-FPSCR_V    Overflow condition code
  flag
: FPU-FPSCR_C   %1 29 lshift FPU-FPSCR bis! ;  \ FPU-FPSCR_C    Carry condition code flag
: FPU-FPSCR_Z   %1 30 lshift FPU-FPSCR bis! ;  \ FPU-FPSCR_Z    Zero condition code flag
: FPU-FPSCR_N   %1 31 lshift FPU-FPSCR bis! ;  \ FPU-FPSCR_N    Negative condition code
  flag

\ MPU-MPU_TYPER (read-only)
: MPU-MPU_TYPER_SEPARATE   %1 0 lshift MPU-MPU_TYPER bis! ;  \ MPU-MPU_TYPER_SEPARATE    Separate flag
: MPU-MPU_TYPER_DREGION   ( %XXXXXXXX -- ) 8 lshift MPU-MPU_TYPER bis! ;  \ MPU-MPU_TYPER_DREGION    Number of MPU data regions
: MPU-MPU_TYPER_IREGION   ( %XXXXXXXX -- ) 16 lshift MPU-MPU_TYPER bis! ;  \ MPU-MPU_TYPER_IREGION    Number of MPU instruction
  regions

\ MPU-MPU_CTRL (read-only)
: MPU-MPU_CTRL_ENABLE   %1 0 lshift MPU-MPU_CTRL bis! ;  \ MPU-MPU_CTRL_ENABLE    Enables the MPU
: MPU-MPU_CTRL_HFNMIENA   %1 1 lshift MPU-MPU_CTRL bis! ;  \ MPU-MPU_CTRL_HFNMIENA    Enables the operation of MPU during hard
  fault
: MPU-MPU_CTRL_PRIVDEFENA   %1 2 lshift MPU-MPU_CTRL bis! ;  \ MPU-MPU_CTRL_PRIVDEFENA    Enable priviliged software access to
  default memory map

\ MPU-MPU_RNR (read-write)
: MPU-MPU_RNR_REGION   ( %XXXXXXXX -- ) 0 lshift MPU-MPU_RNR bis! ;  \ MPU-MPU_RNR_REGION    MPU region

\ MPU-MPU_RBAR (read-write)
: MPU-MPU_RBAR_REGION   ( %XXXX -- ) 0 lshift MPU-MPU_RBAR bis! ;  \ MPU-MPU_RBAR_REGION    MPU region field
: MPU-MPU_RBAR_VALID   %1 4 lshift MPU-MPU_RBAR bis! ;  \ MPU-MPU_RBAR_VALID    MPU region number valid
: MPU-MPU_RBAR_ADDR  5 lshift MPU-MPU_RBAR bis! ;  \ MPU-MPU_RBAR_ADDR    Region base address field

\ MPU-MPU_RASR (read-write)
: MPU-MPU_RASR_ENABLE   %1 0 lshift MPU-MPU_RASR bis! ;  \ MPU-MPU_RASR_ENABLE    Region enable bit.
: MPU-MPU_RASR_SIZE   ( %XXXXX -- ) 1 lshift MPU-MPU_RASR bis! ;  \ MPU-MPU_RASR_SIZE    Size of the MPU protection
  region
: MPU-MPU_RASR_SRD   ( %XXXXXXXX -- ) 8 lshift MPU-MPU_RASR bis! ;  \ MPU-MPU_RASR_SRD    Subregion disable bits
: MPU-MPU_RASR_B   %1 16 lshift MPU-MPU_RASR bis! ;  \ MPU-MPU_RASR_B    memory attribute
: MPU-MPU_RASR_C   %1 17 lshift MPU-MPU_RASR bis! ;  \ MPU-MPU_RASR_C    memory attribute
: MPU-MPU_RASR_S   %1 18 lshift MPU-MPU_RASR bis! ;  \ MPU-MPU_RASR_S    Shareable memory attribute
: MPU-MPU_RASR_TEX   ( %XXX -- ) 19 lshift MPU-MPU_RASR bis! ;  \ MPU-MPU_RASR_TEX    memory attribute
: MPU-MPU_RASR_AP   ( %XXX -- ) 24 lshift MPU-MPU_RASR bis! ;  \ MPU-MPU_RASR_AP    Access permission
: MPU-MPU_RASR_XN   %1 28 lshift MPU-MPU_RASR bis! ;  \ MPU-MPU_RASR_XN    Instruction access disable
  bit

\ STK-CTRL (read-write)
: STK-CTRL_ENABLE   %1 0 lshift STK-CTRL bis! ;  \ STK-CTRL_ENABLE    Counter enable
: STK-CTRL_TICKINT   %1 1 lshift STK-CTRL bis! ;  \ STK-CTRL_TICKINT    SysTick exception request
  enable
: STK-CTRL_CLKSOURCE   %1 2 lshift STK-CTRL bis! ;  \ STK-CTRL_CLKSOURCE    Clock source selection
: STK-CTRL_COUNTFLAG   %1 16 lshift STK-CTRL bis! ;  \ STK-CTRL_COUNTFLAG    COUNTFLAG

\ STK-LOAD (read-write)
: STK-LOAD_RELOAD   ( %XXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift STK-LOAD bis! ;  \ STK-LOAD_RELOAD    RELOAD value

\ STK-VAL (read-write)
: STK-VAL_CURRENT   ( %XXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift STK-VAL bis! ;  \ STK-VAL_CURRENT    Current counter value

\ STK-CALIB (read-write)
: STK-CALIB_TENMS   ( %XXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift STK-CALIB bis! ;  \ STK-CALIB_TENMS    Calibration value
: STK-CALIB_SKEW   %1 30 lshift STK-CALIB bis! ;  \ STK-CALIB_SKEW    SKEW flag: Indicates whether the TENMS
  value is exact
: STK-CALIB_NOREF   %1 31 lshift STK-CALIB bis! ;  \ STK-CALIB_NOREF    NOREF flag. Reads as zero

\ SCB-CPUID (read-only)
: SCB-CPUID_Revision   ( %XXXX -- ) 0 lshift SCB-CPUID bis! ;  \ SCB-CPUID_Revision    Revision number
: SCB-CPUID_PartNo   ( %XXXXXXXXXXX -- ) 4 lshift SCB-CPUID bis! ;  \ SCB-CPUID_PartNo    Part number of the
  processor
: SCB-CPUID_Constant   ( %XXXX -- ) 16 lshift SCB-CPUID bis! ;  \ SCB-CPUID_Constant    Reads as $F
: SCB-CPUID_Variant   ( %XXXX -- ) 20 lshift SCB-CPUID bis! ;  \ SCB-CPUID_Variant    Variant number
: SCB-CPUID_Implementer   ( %XXXXXXXX -- ) 24 lshift SCB-CPUID bis! ;  \ SCB-CPUID_Implementer    Implementer code

\ SCB-ICSR (read-write)
: SCB-ICSR_VECTACTIVE   ( %XXXXXXXXX -- ) 0 lshift SCB-ICSR bis! ;  \ SCB-ICSR_VECTACTIVE    Active vector
: SCB-ICSR_RETTOBASE   %1 11 lshift SCB-ICSR bis! ;  \ SCB-ICSR_RETTOBASE    Return to base level
: SCB-ICSR_VECTPENDING   ( %XXXXXXX -- ) 12 lshift SCB-ICSR bis! ;  \ SCB-ICSR_VECTPENDING    Pending vector
: SCB-ICSR_ISRPENDING   %1 22 lshift SCB-ICSR bis! ;  \ SCB-ICSR_ISRPENDING    Interrupt pending flag
: SCB-ICSR_PENDSTCLR   %1 25 lshift SCB-ICSR bis! ;  \ SCB-ICSR_PENDSTCLR    SysTick exception clear-pending
  bit
: SCB-ICSR_PENDSTSET   %1 26 lshift SCB-ICSR bis! ;  \ SCB-ICSR_PENDSTSET    SysTick exception set-pending
  bit
: SCB-ICSR_PENDSVCLR   %1 27 lshift SCB-ICSR bis! ;  \ SCB-ICSR_PENDSVCLR    PendSV clear-pending bit
: SCB-ICSR_PENDSVSET   %1 28 lshift SCB-ICSR bis! ;  \ SCB-ICSR_PENDSVSET    PendSV set-pending bit
: SCB-ICSR_NMIPENDSET   %1 31 lshift SCB-ICSR bis! ;  \ SCB-ICSR_NMIPENDSET    NMI set-pending bit.

\ SCB-VTOR (read-write)
: SCB-VTOR_TBLOFF  9 lshift SCB-VTOR bis! ;  \ SCB-VTOR_TBLOFF    Vector table base offset
  field

\ SCB-AIRCR (read-write)
: SCB-AIRCR_VECTRESET   %1 0 lshift SCB-AIRCR bis! ;  \ SCB-AIRCR_VECTRESET    VECTRESET
: SCB-AIRCR_VECTCLRACTIVE   %1 1 lshift SCB-AIRCR bis! ;  \ SCB-AIRCR_VECTCLRACTIVE    VECTCLRACTIVE
: SCB-AIRCR_SYSRESETREQ   %1 2 lshift SCB-AIRCR bis! ;  \ SCB-AIRCR_SYSRESETREQ    SYSRESETREQ
: SCB-AIRCR_PRIGROUP   ( %XXX -- ) 8 lshift SCB-AIRCR bis! ;  \ SCB-AIRCR_PRIGROUP    PRIGROUP
: SCB-AIRCR_ENDIANESS   %1 15 lshift SCB-AIRCR bis! ;  \ SCB-AIRCR_ENDIANESS    ENDIANESS
: SCB-AIRCR_VECTKEYSTAT   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift SCB-AIRCR bis! ;  \ SCB-AIRCR_VECTKEYSTAT    Register key

\ SCB-SCR (read-write)
: SCB-SCR_SLEEPONEXIT   %1 1 lshift SCB-SCR bis! ;  \ SCB-SCR_SLEEPONEXIT    SLEEPONEXIT
: SCB-SCR_SLEEPDEEP   %1 2 lshift SCB-SCR bis! ;  \ SCB-SCR_SLEEPDEEP    SLEEPDEEP
: SCB-SCR_SEVEONPEND   %1 4 lshift SCB-SCR bis! ;  \ SCB-SCR_SEVEONPEND    Send Event on Pending bit

\ SCB-CCR (read-write)
: SCB-CCR_NONBASETHRDENA   %1 0 lshift SCB-CCR bis! ;  \ SCB-CCR_NONBASETHRDENA    Configures how the processor enters
  Thread mode
: SCB-CCR_USERSETMPEND   %1 1 lshift SCB-CCR bis! ;  \ SCB-CCR_USERSETMPEND    USERSETMPEND
: SCB-CCR_UNALIGN__TRP   %1 3 lshift SCB-CCR bis! ;  \ SCB-CCR_UNALIGN__TRP    UNALIGN_ TRP
: SCB-CCR_DIV_0_TRP   %1 4 lshift SCB-CCR bis! ;  \ SCB-CCR_DIV_0_TRP    DIV_0_TRP
: SCB-CCR_BFHFNMIGN   %1 8 lshift SCB-CCR bis! ;  \ SCB-CCR_BFHFNMIGN    BFHFNMIGN
: SCB-CCR_STKALIGN   %1 9 lshift SCB-CCR bis! ;  \ SCB-CCR_STKALIGN    STKALIGN

\ SCB-SHPR1 (read-write)
: SCB-SHPR1_PRI_4   ( %XXXXXXXX -- ) 0 lshift SCB-SHPR1 bis! ;  \ SCB-SHPR1_PRI_4    Priority of system handler
  4
: SCB-SHPR1_PRI_5   ( %XXXXXXXX -- ) 8 lshift SCB-SHPR1 bis! ;  \ SCB-SHPR1_PRI_5    Priority of system handler
  5
: SCB-SHPR1_PRI_6   ( %XXXXXXXX -- ) 16 lshift SCB-SHPR1 bis! ;  \ SCB-SHPR1_PRI_6    Priority of system handler
  6

\ SCB-SHPR2 (read-write)
: SCB-SHPR2_PRI_11   ( %XXXXXXXX -- ) 24 lshift SCB-SHPR2 bis! ;  \ SCB-SHPR2_PRI_11    Priority of system handler
  11

\ SCB-SHPR3 (read-write)
: SCB-SHPR3_PRI_14   ( %XXXXXXXX -- ) 16 lshift SCB-SHPR3 bis! ;  \ SCB-SHPR3_PRI_14    Priority of system handler
  14
: SCB-SHPR3_PRI_15   ( %XXXXXXXX -- ) 24 lshift SCB-SHPR3 bis! ;  \ SCB-SHPR3_PRI_15    Priority of system handler
  15

\ SCB-SHCRS (read-write)
: SCB-SHCRS_MEMFAULTACT   %1 0 lshift SCB-SHCRS bis! ;  \ SCB-SHCRS_MEMFAULTACT    Memory management fault exception active
  bit
: SCB-SHCRS_BUSFAULTACT   %1 1 lshift SCB-SHCRS bis! ;  \ SCB-SHCRS_BUSFAULTACT    Bus fault exception active
  bit
: SCB-SHCRS_USGFAULTACT   %1 3 lshift SCB-SHCRS bis! ;  \ SCB-SHCRS_USGFAULTACT    Usage fault exception active
  bit
: SCB-SHCRS_SVCALLACT   %1 7 lshift SCB-SHCRS bis! ;  \ SCB-SHCRS_SVCALLACT    SVC call active bit
: SCB-SHCRS_MONITORACT   %1 8 lshift SCB-SHCRS bis! ;  \ SCB-SHCRS_MONITORACT    Debug monitor active bit
: SCB-SHCRS_PENDSVACT   %1 10 lshift SCB-SHCRS bis! ;  \ SCB-SHCRS_PENDSVACT    PendSV exception active
  bit
: SCB-SHCRS_SYSTICKACT   %1 11 lshift SCB-SHCRS bis! ;  \ SCB-SHCRS_SYSTICKACT    SysTick exception active
  bit
: SCB-SHCRS_USGFAULTPENDED   %1 12 lshift SCB-SHCRS bis! ;  \ SCB-SHCRS_USGFAULTPENDED    Usage fault exception pending
  bit
: SCB-SHCRS_MEMFAULTPENDED   %1 13 lshift SCB-SHCRS bis! ;  \ SCB-SHCRS_MEMFAULTPENDED    Memory management fault exception
  pending bit
: SCB-SHCRS_BUSFAULTPENDED   %1 14 lshift SCB-SHCRS bis! ;  \ SCB-SHCRS_BUSFAULTPENDED    Bus fault exception pending
  bit
: SCB-SHCRS_SVCALLPENDED   %1 15 lshift SCB-SHCRS bis! ;  \ SCB-SHCRS_SVCALLPENDED    SVC call pending bit
: SCB-SHCRS_MEMFAULTENA   %1 16 lshift SCB-SHCRS bis! ;  \ SCB-SHCRS_MEMFAULTENA    Memory management fault enable
  bit
: SCB-SHCRS_BUSFAULTENA   %1 17 lshift SCB-SHCRS bis! ;  \ SCB-SHCRS_BUSFAULTENA    Bus fault enable bit
: SCB-SHCRS_USGFAULTENA   %1 18 lshift SCB-SHCRS bis! ;  \ SCB-SHCRS_USGFAULTENA    Usage fault enable bit

\ SCB-CFSR_UFSR_BFSR_MMFSR (read-write)
: SCB-CFSR_UFSR_BFSR_MMFSR_IACCVIOL   %1 1 lshift SCB-CFSR_UFSR_BFSR_MMFSR bis! ;  \ SCB-CFSR_UFSR_BFSR_MMFSR_IACCVIOL    Instruction access violation
  flag
: SCB-CFSR_UFSR_BFSR_MMFSR_MUNSTKERR   %1 3 lshift SCB-CFSR_UFSR_BFSR_MMFSR bis! ;  \ SCB-CFSR_UFSR_BFSR_MMFSR_MUNSTKERR    Memory manager fault on unstacking for a
  return from exception
: SCB-CFSR_UFSR_BFSR_MMFSR_MSTKERR   %1 4 lshift SCB-CFSR_UFSR_BFSR_MMFSR bis! ;  \ SCB-CFSR_UFSR_BFSR_MMFSR_MSTKERR    Memory manager fault on stacking for
  exception entry.
: SCB-CFSR_UFSR_BFSR_MMFSR_MLSPERR   %1 5 lshift SCB-CFSR_UFSR_BFSR_MMFSR bis! ;  \ SCB-CFSR_UFSR_BFSR_MMFSR_MLSPERR    MLSPERR
: SCB-CFSR_UFSR_BFSR_MMFSR_MMARVALID   %1 7 lshift SCB-CFSR_UFSR_BFSR_MMFSR bis! ;  \ SCB-CFSR_UFSR_BFSR_MMFSR_MMARVALID    Memory Management Fault Address Register
  MMAR valid flag
: SCB-CFSR_UFSR_BFSR_MMFSR_IBUSERR   %1 8 lshift SCB-CFSR_UFSR_BFSR_MMFSR bis! ;  \ SCB-CFSR_UFSR_BFSR_MMFSR_IBUSERR    Instruction bus error
: SCB-CFSR_UFSR_BFSR_MMFSR_PRECISERR   %1 9 lshift SCB-CFSR_UFSR_BFSR_MMFSR bis! ;  \ SCB-CFSR_UFSR_BFSR_MMFSR_PRECISERR    Precise data bus error
: SCB-CFSR_UFSR_BFSR_MMFSR_IMPRECISERR   %1 10 lshift SCB-CFSR_UFSR_BFSR_MMFSR bis! ;  \ SCB-CFSR_UFSR_BFSR_MMFSR_IMPRECISERR    Imprecise data bus error
: SCB-CFSR_UFSR_BFSR_MMFSR_UNSTKERR   %1 11 lshift SCB-CFSR_UFSR_BFSR_MMFSR bis! ;  \ SCB-CFSR_UFSR_BFSR_MMFSR_UNSTKERR    Bus fault on unstacking for a return
  from exception
: SCB-CFSR_UFSR_BFSR_MMFSR_STKERR   %1 12 lshift SCB-CFSR_UFSR_BFSR_MMFSR bis! ;  \ SCB-CFSR_UFSR_BFSR_MMFSR_STKERR    Bus fault on stacking for exception
  entry
: SCB-CFSR_UFSR_BFSR_MMFSR_LSPERR   %1 13 lshift SCB-CFSR_UFSR_BFSR_MMFSR bis! ;  \ SCB-CFSR_UFSR_BFSR_MMFSR_LSPERR    Bus fault on floating-point lazy state
  preservation
: SCB-CFSR_UFSR_BFSR_MMFSR_BFARVALID   %1 15 lshift SCB-CFSR_UFSR_BFSR_MMFSR bis! ;  \ SCB-CFSR_UFSR_BFSR_MMFSR_BFARVALID    Bus Fault Address Register BFAR valid
  flag
: SCB-CFSR_UFSR_BFSR_MMFSR_UNDEFINSTR   %1 16 lshift SCB-CFSR_UFSR_BFSR_MMFSR bis! ;  \ SCB-CFSR_UFSR_BFSR_MMFSR_UNDEFINSTR    Undefined instruction usage
  fault
: SCB-CFSR_UFSR_BFSR_MMFSR_INVSTATE   %1 17 lshift SCB-CFSR_UFSR_BFSR_MMFSR bis! ;  \ SCB-CFSR_UFSR_BFSR_MMFSR_INVSTATE    Invalid state usage fault
: SCB-CFSR_UFSR_BFSR_MMFSR_INVPC   %1 18 lshift SCB-CFSR_UFSR_BFSR_MMFSR bis! ;  \ SCB-CFSR_UFSR_BFSR_MMFSR_INVPC    Invalid PC load usage
  fault
: SCB-CFSR_UFSR_BFSR_MMFSR_NOCP   %1 19 lshift SCB-CFSR_UFSR_BFSR_MMFSR bis! ;  \ SCB-CFSR_UFSR_BFSR_MMFSR_NOCP    No coprocessor usage
  fault.
: SCB-CFSR_UFSR_BFSR_MMFSR_UNALIGNED   %1 24 lshift SCB-CFSR_UFSR_BFSR_MMFSR bis! ;  \ SCB-CFSR_UFSR_BFSR_MMFSR_UNALIGNED    Unaligned access usage
  fault
: SCB-CFSR_UFSR_BFSR_MMFSR_DIVBYZERO   %1 25 lshift SCB-CFSR_UFSR_BFSR_MMFSR bis! ;  \ SCB-CFSR_UFSR_BFSR_MMFSR_DIVBYZERO    Divide by zero usage fault

\ SCB-HFSR (read-write)
: SCB-HFSR_VECTTBL   %1 1 lshift SCB-HFSR bis! ;  \ SCB-HFSR_VECTTBL    Vector table hard fault
: SCB-HFSR_FORCED   %1 30 lshift SCB-HFSR bis! ;  \ SCB-HFSR_FORCED    Forced hard fault
: SCB-HFSR_DEBUG_VT   %1 31 lshift SCB-HFSR bis! ;  \ SCB-HFSR_DEBUG_VT    Reserved for Debug use

\ SCB-MMFAR (read-write)
: SCB-MMFAR_MMFAR   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift SCB-MMFAR bis! ;  \ SCB-MMFAR_MMFAR    Memory management fault
  address

\ SCB-BFAR (read-write)
: SCB-BFAR_BFAR   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift SCB-BFAR bis! ;  \ SCB-BFAR_BFAR    Bus fault address

\ SCB-AFSR (read-write)
: SCB-AFSR_IMPDEF   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift SCB-AFSR bis! ;  \ SCB-AFSR_IMPDEF    Implementation defined

\ NVIC_STIR-STIR (read-write)
: NVIC_STIR-STIR_INTID   ( %XXXXXXXXX -- ) 0 lshift NVIC_STIR-STIR bis! ;  \ NVIC_STIR-STIR_INTID    Software generated interrupt
  ID

\ FPU_CPACR-CPACR (read-write)
: FPU_CPACR-CPACR_CP   ( %XXXX -- ) 20 lshift FPU_CPACR-CPACR bis! ;  \ FPU_CPACR-CPACR_CP    CP

\ SCB_ACTRL-ACTRL (read-write)
: SCB_ACTRL-ACTRL_DISMCYCINT   %1 0 lshift SCB_ACTRL-ACTRL bis! ;  \ SCB_ACTRL-ACTRL_DISMCYCINT    DISMCYCINT
: SCB_ACTRL-ACTRL_DISDEFWBUF   %1 1 lshift SCB_ACTRL-ACTRL bis! ;  \ SCB_ACTRL-ACTRL_DISDEFWBUF    DISDEFWBUF
: SCB_ACTRL-ACTRL_DISFOLD   %1 2 lshift SCB_ACTRL-ACTRL bis! ;  \ SCB_ACTRL-ACTRL_DISFOLD    DISFOLD
: SCB_ACTRL-ACTRL_DISFPCA   %1 8 lshift SCB_ACTRL-ACTRL bis! ;  \ SCB_ACTRL-ACTRL_DISFPCA    DISFPCA
: SCB_ACTRL-ACTRL_DISOOFP   %1 9 lshift SCB_ACTRL-ACTRL bis! ;  \ SCB_ACTRL-ACTRL_DISOOFP    DISOOFP
