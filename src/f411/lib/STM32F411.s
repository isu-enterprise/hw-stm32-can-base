@ arm-none-eabi-as equates file for STM32F411
@ SVD2GAS Equates Generator, Copyright Terry Porter 2017 "terry@tjporter.com.au" for arm-none-eabi-as 
@ Matthias Koch Complimentary Edition 2017
@ Takes a CMSIS-SVD file plus a hand edited config.xml file as input 
@ Licensed under the GPL, see http://www.gnu.org/licenses/


@=========================== ADC_Common ===========================@
.equ ADC_Common_BASE, 0x40012300 @ (ADC common registers) 
    .equ ADC_Common_CSR, ADC_Common_BASE + 0x0 @ (ADC Common status register) 
        .equ ADC_Common_OVR3_Shift, 21   @ bitWidth 1 (Overrun flag of ADC3)  
        .equ ADC_Common_STRT3_Shift, 20   @ bitWidth 1 (Regular channel Start flag of ADC
  3)  
        .equ ADC_Common_JSTRT3_Shift, 19   @ bitWidth 1 (Injected channel Start flag of ADC
  3)  
        .equ ADC_Common_JEOC3_Shift, 18   @ bitWidth 1 (Injected channel end of conversion of
  ADC 3)  
        .equ ADC_Common_EOC3_Shift, 17   @ bitWidth 1 (End of conversion of ADC 3)  
        .equ ADC_Common_AWD3_Shift, 16   @ bitWidth 1 (Analog watchdog flag of ADC
  3)  
        .equ ADC_Common_OVR2_Shift, 13   @ bitWidth 1 (Overrun flag of ADC 2)  
        .equ ADC_Common_STRT2_Shift, 12   @ bitWidth 1 (Regular channel Start flag of ADC
  2)  
        .equ ADC_Common_JSTRT2_Shift, 11   @ bitWidth 1 (Injected channel Start flag of ADC
  2)  
        .equ ADC_Common_JEOC2_Shift, 10   @ bitWidth 1 (Injected channel end of conversion of
  ADC 2)  
        .equ ADC_Common_EOC2_Shift, 9   @ bitWidth 1 (End of conversion of ADC 2)  
        .equ ADC_Common_AWD2_Shift, 8   @ bitWidth 1 (Analog watchdog flag of ADC
  2)  
        .equ ADC_Common_OVR1_Shift, 5   @ bitWidth 1 (Overrun flag of ADC 1)  
        .equ ADC_Common_STRT1_Shift, 4   @ bitWidth 1 (Regular channel Start flag of ADC
  1)  
        .equ ADC_Common_JSTRT1_Shift, 3   @ bitWidth 1 (Injected channel Start flag of ADC
  1)  
        .equ ADC_Common_JEOC1_Shift, 2   @ bitWidth 1 (Injected channel end of conversion of
  ADC 1)  
        .equ ADC_Common_EOC1_Shift, 1   @ bitWidth 1 (End of conversion of ADC 1)  
        .equ ADC_Common_AWD1_Shift, 0   @ bitWidth 1 (Analog watchdog flag of ADC
  1)  
 
    .equ ADC_Common_CCR, ADC_Common_BASE + 0x4 @ (ADC common control register) 
        .equ ADC_Common_TSVREFE_Shift, 23   @ bitWidth 1 (Temperature sensor and VREFINT
  enable)  
        .equ ADC_Common_VBATE_Shift, 22   @ bitWidth 1 (VBAT enable)  
        .equ ADC_Common_ADCPRE_Shift, 16   @ bitWidth 2 (ADC prescaler)  
        .equ ADC_Common_DMA_Shift, 14   @ bitWidth 2 (Direct memory access mode for multi ADC
  mode)  
        .equ ADC_Common_DDS_Shift, 13   @ bitWidth 1 (DMA disable selection for multi-ADC
  mode)  
        .equ ADC_Common_DELAY_Shift, 8   @ bitWidth 4 (Delay between 2 sampling
  phases)  
 

@=========================== ADC1 ===========================@
.equ ADC1_BASE, 0x40012000 @ (Analog-to-digital converter) 
    .equ ADC1_SR, ADC1_BASE + 0x0 @ (status register) 
        .equ ADC1_OVR_Shift, 5   @ bitWidth 1 (Overrun)  
        .equ ADC1_STRT_Shift, 4   @ bitWidth 1 (Regular channel start flag)  
        .equ ADC1_JSTRT_Shift, 3   @ bitWidth 1 (Injected channel start
  flag)  
        .equ ADC1_JEOC_Shift, 2   @ bitWidth 1 (Injected channel end of
  conversion)  
        .equ ADC1_EOC_Shift, 1   @ bitWidth 1 (Regular channel end of
  conversion)  
        .equ ADC1_AWD_Shift, 0   @ bitWidth 1 (Analog watchdog flag)  
 
    .equ ADC1_CR1, ADC1_BASE + 0x4 @ (control register 1) 
        .equ ADC1_OVRIE_Shift, 26   @ bitWidth 1 (Overrun interrupt enable)  
        .equ ADC1_RES_Shift, 24   @ bitWidth 2 (Resolution)  
        .equ ADC1_AWDEN_Shift, 23   @ bitWidth 1 (Analog watchdog enable on regular
  channels)  
        .equ ADC1_JAWDEN_Shift, 22   @ bitWidth 1 (Analog watchdog enable on injected
  channels)  
        .equ ADC1_DISCNUM_Shift, 13   @ bitWidth 3 (Discontinuous mode channel
  count)  
        .equ ADC1_JDISCEN_Shift, 12   @ bitWidth 1 (Discontinuous mode on injected
  channels)  
        .equ ADC1_DISCEN_Shift, 11   @ bitWidth 1 (Discontinuous mode on regular
  channels)  
        .equ ADC1_JAUTO_Shift, 10   @ bitWidth 1 (Automatic injected group
  conversion)  
        .equ ADC1_AWDSGL_Shift, 9   @ bitWidth 1 (Enable the watchdog on a single channel
  in scan mode)  
        .equ ADC1_SCAN_Shift, 8   @ bitWidth 1 (Scan mode)  
        .equ ADC1_JEOCIE_Shift, 7   @ bitWidth 1 (Interrupt enable for injected
  channels)  
        .equ ADC1_AWDIE_Shift, 6   @ bitWidth 1 (Analog watchdog interrupt
  enable)  
        .equ ADC1_EOCIE_Shift, 5   @ bitWidth 1 (Interrupt enable for EOC)  
        .equ ADC1_AWDCH_Shift, 0   @ bitWidth 5 (Analog watchdog channel select
  bits)  
 
    .equ ADC1_CR2, ADC1_BASE + 0x8 @ (control register 2) 
        .equ ADC1_SWSTART_Shift, 30   @ bitWidth 1 (Start conversion of regular
  channels)  
        .equ ADC1_EXTEN_Shift, 28   @ bitWidth 2 (External trigger enable for regular
  channels)  
        .equ ADC1_EXTSEL_Shift, 24   @ bitWidth 4 (External event select for regular
  group)  
        .equ ADC1_JSWSTART_Shift, 22   @ bitWidth 1 (Start conversion of injected
  channels)  
        .equ ADC1_JEXTEN_Shift, 20   @ bitWidth 2 (External trigger enable for injected
  channels)  
        .equ ADC1_JEXTSEL_Shift, 16   @ bitWidth 4 (External event select for injected
  group)  
        .equ ADC1_ALIGN_Shift, 11   @ bitWidth 1 (Data alignment)  
        .equ ADC1_EOCS_Shift, 10   @ bitWidth 1 (End of conversion
  selection)  
        .equ ADC1_DDS_Shift, 9   @ bitWidth 1 (DMA disable selection for single ADC
  mode)  
        .equ ADC1_DMA_Shift, 8   @ bitWidth 1 (Direct memory access mode for single
  ADC mode)  
        .equ ADC1_CONT_Shift, 1   @ bitWidth 1 (Continuous conversion)  
        .equ ADC1_ADON_Shift, 0   @ bitWidth 1 (A/D Converter ON / OFF)  
 
    .equ ADC1_SMPR1, ADC1_BASE + 0xC @ (sample time register 1) 
        .equ ADC1_SMPx_x_Shift, 0   @ bitWidth 32 (Sample time bits)  
 
    .equ ADC1_SMPR2, ADC1_BASE + 0x10 @ (sample time register 2) 
        .equ ADC1_SMPx_x_Shift, 0   @ bitWidth 32 (Sample time bits)  
 
    .equ ADC1_JOFR1, ADC1_BASE + 0x14 @ (injected channel data offset register
  x) 
        .equ ADC1_JOFFSET1_Shift, 0   @ bitWidth 12 (Data offset for injected channel
  x)  
 
    .equ ADC1_JOFR2, ADC1_BASE + 0x18 @ (injected channel data offset register
  x) 
        .equ ADC1_JOFFSET2_Shift, 0   @ bitWidth 12 (Data offset for injected channel
  x)  
 
    .equ ADC1_JOFR3, ADC1_BASE + 0x1C @ (injected channel data offset register
  x) 
        .equ ADC1_JOFFSET3_Shift, 0   @ bitWidth 12 (Data offset for injected channel
  x)  
 
    .equ ADC1_JOFR4, ADC1_BASE + 0x20 @ (injected channel data offset register
  x) 
        .equ ADC1_JOFFSET4_Shift, 0   @ bitWidth 12 (Data offset for injected channel
  x)  
 
    .equ ADC1_HTR, ADC1_BASE + 0x24 @ (watchdog higher threshold
  register) 
        .equ ADC1_HT_Shift, 0   @ bitWidth 12 (Analog watchdog higher
  threshold)  
 
    .equ ADC1_LTR, ADC1_BASE + 0x28 @ (watchdog lower threshold
  register) 
        .equ ADC1_LT_Shift, 0   @ bitWidth 12 (Analog watchdog lower
  threshold)  
 
    .equ ADC1_SQR1, ADC1_BASE + 0x2C @ (regular sequence register 1) 
        .equ ADC1_L_Shift, 20   @ bitWidth 4 (Regular channel sequence
  length)  
        .equ ADC1_SQ16_Shift, 15   @ bitWidth 5 (16th conversion in regular
  sequence)  
        .equ ADC1_SQ15_Shift, 10   @ bitWidth 5 (15th conversion in regular
  sequence)  
        .equ ADC1_SQ14_Shift, 5   @ bitWidth 5 (14th conversion in regular
  sequence)  
        .equ ADC1_SQ13_Shift, 0   @ bitWidth 5 (13th conversion in regular
  sequence)  
 
    .equ ADC1_SQR2, ADC1_BASE + 0x30 @ (regular sequence register 2) 
        .equ ADC1_SQ12_Shift, 25   @ bitWidth 5 (12th conversion in regular
  sequence)  
        .equ ADC1_SQ11_Shift, 20   @ bitWidth 5 (11th conversion in regular
  sequence)  
        .equ ADC1_SQ10_Shift, 15   @ bitWidth 5 (10th conversion in regular
  sequence)  
        .equ ADC1_SQ9_Shift, 10   @ bitWidth 5 (9th conversion in regular
  sequence)  
        .equ ADC1_SQ8_Shift, 5   @ bitWidth 5 (8th conversion in regular
  sequence)  
        .equ ADC1_SQ7_Shift, 0   @ bitWidth 5 (7th conversion in regular
  sequence)  
 
    .equ ADC1_SQR3, ADC1_BASE + 0x34 @ (regular sequence register 3) 
        .equ ADC1_SQ6_Shift, 25   @ bitWidth 5 (6th conversion in regular
  sequence)  
        .equ ADC1_SQ5_Shift, 20   @ bitWidth 5 (5th conversion in regular
  sequence)  
        .equ ADC1_SQ4_Shift, 15   @ bitWidth 5 (4th conversion in regular
  sequence)  
        .equ ADC1_SQ3_Shift, 10   @ bitWidth 5 (3rd conversion in regular
  sequence)  
        .equ ADC1_SQ2_Shift, 5   @ bitWidth 5 (2nd conversion in regular
  sequence)  
        .equ ADC1_SQ1_Shift, 0   @ bitWidth 5 (1st conversion in regular
  sequence)  
 
    .equ ADC1_JSQR, ADC1_BASE + 0x38 @ (injected sequence register) 
        .equ ADC1_JL_Shift, 20   @ bitWidth 2 (Injected sequence length)  
        .equ ADC1_JSQ4_Shift, 15   @ bitWidth 5 (4th conversion in injected
  sequence)  
        .equ ADC1_JSQ3_Shift, 10   @ bitWidth 5 (3rd conversion in injected
  sequence)  
        .equ ADC1_JSQ2_Shift, 5   @ bitWidth 5 (2nd conversion in injected
  sequence)  
        .equ ADC1_JSQ1_Shift, 0   @ bitWidth 5 (1st conversion in injected
  sequence)  
 
    .equ ADC1_JDR1, ADC1_BASE + 0x3C @ (injected data register x) 
        .equ ADC1_JDATA_Shift, 0   @ bitWidth 16 (Injected data)  
 
    .equ ADC1_JDR2, ADC1_BASE + 0x40 @ (injected data register x) 
        .equ ADC1_JDATA_Shift, 0   @ bitWidth 16 (Injected data)  
 
    .equ ADC1_JDR3, ADC1_BASE + 0x44 @ (injected data register x) 
        .equ ADC1_JDATA_Shift, 0   @ bitWidth 16 (Injected data)  
 
    .equ ADC1_JDR4, ADC1_BASE + 0x48 @ (injected data register x) 
        .equ ADC1_JDATA_Shift, 0   @ bitWidth 16 (Injected data)  
 
    .equ ADC1_DR, ADC1_BASE + 0x4C @ (regular data register) 
        .equ ADC1_DATA_Shift, 0   @ bitWidth 16 (Regular data)  
 

@=========================== CRC ===========================@
.equ CRC_BASE, 0x40023000 @ (Cryptographic processor) 
    .equ CRC_DR, CRC_BASE + 0x0 @ (Data register) 
        .equ CRC_DR_Shift, 0   @ bitWidth 32 (Data Register)  
 
    .equ CRC_IDR, CRC_BASE + 0x4 @ (Independent Data register) 
        .equ CRC_IDR_Shift, 0   @ bitWidth 8 (Independent Data register)  
 
    .equ CRC_CR, CRC_BASE + 0x8 @ (Control register) 
        .equ CRC_CR_Shift, 0   @ bitWidth 1 (Control regidter)  
 

@=========================== DBG ===========================@
.equ DBG_BASE, 0xE0042000 @ (Debug support) 
    .equ DBG_DBGMCU_IDCODE, DBG_BASE + 0x0 @ (IDCODE) 
        .equ DBG_DEV_ID_Shift, 0   @ bitWidth 12 (DEV_ID)  
        .equ DBG_REV_ID_Shift, 16   @ bitWidth 16 (REV_ID)  
 
    .equ DBG_DBGMCU_CR, DBG_BASE + 0x4 @ (Control Register) 
        .equ DBG_DBG_SLEEP_Shift, 0   @ bitWidth 1 (DBG_SLEEP)  
        .equ DBG_DBG_STOP_Shift, 1   @ bitWidth 1 (DBG_STOP)  
        .equ DBG_DBG_STANDBY_Shift, 2   @ bitWidth 1 (DBG_STANDBY)  
        .equ DBG_TRACE_IOEN_Shift, 5   @ bitWidth 1 (TRACE_IOEN)  
        .equ DBG_TRACE_MODE_Shift, 6   @ bitWidth 2 (TRACE_MODE)  
 
    .equ DBG_DBGMCU_APB1_FZ, DBG_BASE + 0x8 @ (Debug MCU APB1 Freeze registe) 
        .equ DBG_DBG_TIM2_STOP_Shift, 0   @ bitWidth 1 (DBG_TIM2_STOP)  
        .equ DBG_DBG_TIM3_STOP_Shift, 1   @ bitWidth 1 (DBG_TIM3 _STOP)  
        .equ DBG_DBG_TIM4_STOP_Shift, 2   @ bitWidth 1 (DBG_TIM4_STOP)  
        .equ DBG_DBG_TIM5_STOP_Shift, 3   @ bitWidth 1 (DBG_TIM5_STOP)  
        .equ DBG_DBG_RTC_Stop_Shift, 10   @ bitWidth 1 (RTC stopped when Core is
  halted)  
        .equ DBG_DBG_WWDG_STOP_Shift, 11   @ bitWidth 1 (DBG_WWDG_STOP)  
        .equ DBG_DBG_IWDEG_STOP_Shift, 12   @ bitWidth 1 (DBG_IWDEG_STOP)  
        .equ DBG_DBG_I2C1_SMBUS_TIMEOUT_Shift, 21   @ bitWidth 1 (DBG_J2C1_SMBUS_TIMEOUT)  
        .equ DBG_DBG_I2C2_SMBUS_TIMEOUT_Shift, 22   @ bitWidth 1 (DBG_J2C2_SMBUS_TIMEOUT)  
        .equ DBG_DBG_I2C3SMBUS_TIMEOUT_Shift, 23   @ bitWidth 1 (DBG_J2C3SMBUS_TIMEOUT)  
 
    .equ DBG_DBGMCU_APB2_FZ, DBG_BASE + 0xC @ (Debug MCU APB2 Freeze registe) 
        .equ DBG_DBG_TIM1_STOP_Shift, 0   @ bitWidth 1 (TIM1 counter stopped when core is
  halted)  
        .equ DBG_DBG_TIM9_STOP_Shift, 16   @ bitWidth 1 (TIM9 counter stopped when core is
  halted)  
        .equ DBG_DBG_TIM10_STOP_Shift, 17   @ bitWidth 1 (TIM10 counter stopped when core is
  halted)  
        .equ DBG_DBG_TIM11_STOP_Shift, 18   @ bitWidth 1 (TIM11 counter stopped when core is
  halted)  
 

@=========================== EXTI ===========================@
.equ EXTI_BASE, 0x40013C00 @ (External interrupt/event
  controller) 
    .equ EXTI_IMR, EXTI_BASE + 0x0 @ (Interrupt mask register
  EXTI_IMR) 
        .equ EXTI_MR0_Shift, 0   @ bitWidth 1 (Interrupt Mask on line 0)  
        .equ EXTI_MR1_Shift, 1   @ bitWidth 1 (Interrupt Mask on line 1)  
        .equ EXTI_MR2_Shift, 2   @ bitWidth 1 (Interrupt Mask on line 2)  
        .equ EXTI_MR3_Shift, 3   @ bitWidth 1 (Interrupt Mask on line 3)  
        .equ EXTI_MR4_Shift, 4   @ bitWidth 1 (Interrupt Mask on line 4)  
        .equ EXTI_MR5_Shift, 5   @ bitWidth 1 (Interrupt Mask on line 5)  
        .equ EXTI_MR6_Shift, 6   @ bitWidth 1 (Interrupt Mask on line 6)  
        .equ EXTI_MR7_Shift, 7   @ bitWidth 1 (Interrupt Mask on line 7)  
        .equ EXTI_MR8_Shift, 8   @ bitWidth 1 (Interrupt Mask on line 8)  
        .equ EXTI_MR9_Shift, 9   @ bitWidth 1 (Interrupt Mask on line 9)  
        .equ EXTI_MR10_Shift, 10   @ bitWidth 1 (Interrupt Mask on line 10)  
        .equ EXTI_MR11_Shift, 11   @ bitWidth 1 (Interrupt Mask on line 11)  
        .equ EXTI_MR12_Shift, 12   @ bitWidth 1 (Interrupt Mask on line 12)  
        .equ EXTI_MR13_Shift, 13   @ bitWidth 1 (Interrupt Mask on line 13)  
        .equ EXTI_MR14_Shift, 14   @ bitWidth 1 (Interrupt Mask on line 14)  
        .equ EXTI_MR15_Shift, 15   @ bitWidth 1 (Interrupt Mask on line 15)  
        .equ EXTI_MR16_Shift, 16   @ bitWidth 1 (Interrupt Mask on line 16)  
        .equ EXTI_MR17_Shift, 17   @ bitWidth 1 (Interrupt Mask on line 17)  
        .equ EXTI_MR18_Shift, 18   @ bitWidth 1 (Interrupt Mask on line 18)  
        .equ EXTI_MR19_Shift, 19   @ bitWidth 1 (Interrupt Mask on line 19)  
        .equ EXTI_MR20_Shift, 20   @ bitWidth 1 (Interrupt Mask on line 20)  
        .equ EXTI_MR21_Shift, 21   @ bitWidth 1 (Interrupt Mask on line 21)  
        .equ EXTI_MR22_Shift, 22   @ bitWidth 1 (Interrupt Mask on line 22)  
 
    .equ EXTI_EMR, EXTI_BASE + 0x4 @ (Event mask register EXTI_EMR) 
        .equ EXTI_MR0_Shift, 0   @ bitWidth 1 (Event Mask on line 0)  
        .equ EXTI_MR1_Shift, 1   @ bitWidth 1 (Event Mask on line 1)  
        .equ EXTI_MR2_Shift, 2   @ bitWidth 1 (Event Mask on line 2)  
        .equ EXTI_MR3_Shift, 3   @ bitWidth 1 (Event Mask on line 3)  
        .equ EXTI_MR4_Shift, 4   @ bitWidth 1 (Event Mask on line 4)  
        .equ EXTI_MR5_Shift, 5   @ bitWidth 1 (Event Mask on line 5)  
        .equ EXTI_MR6_Shift, 6   @ bitWidth 1 (Event Mask on line 6)  
        .equ EXTI_MR7_Shift, 7   @ bitWidth 1 (Event Mask on line 7)  
        .equ EXTI_MR8_Shift, 8   @ bitWidth 1 (Event Mask on line 8)  
        .equ EXTI_MR9_Shift, 9   @ bitWidth 1 (Event Mask on line 9)  
        .equ EXTI_MR10_Shift, 10   @ bitWidth 1 (Event Mask on line 10)  
        .equ EXTI_MR11_Shift, 11   @ bitWidth 1 (Event Mask on line 11)  
        .equ EXTI_MR12_Shift, 12   @ bitWidth 1 (Event Mask on line 12)  
        .equ EXTI_MR13_Shift, 13   @ bitWidth 1 (Event Mask on line 13)  
        .equ EXTI_MR14_Shift, 14   @ bitWidth 1 (Event Mask on line 14)  
        .equ EXTI_MR15_Shift, 15   @ bitWidth 1 (Event Mask on line 15)  
        .equ EXTI_MR16_Shift, 16   @ bitWidth 1 (Event Mask on line 16)  
        .equ EXTI_MR17_Shift, 17   @ bitWidth 1 (Event Mask on line 17)  
        .equ EXTI_MR18_Shift, 18   @ bitWidth 1 (Event Mask on line 18)  
        .equ EXTI_MR19_Shift, 19   @ bitWidth 1 (Event Mask on line 19)  
        .equ EXTI_MR20_Shift, 20   @ bitWidth 1 (Event Mask on line 20)  
        .equ EXTI_MR21_Shift, 21   @ bitWidth 1 (Event Mask on line 21)  
        .equ EXTI_MR22_Shift, 22   @ bitWidth 1 (Event Mask on line 22)  
 
    .equ EXTI_RTSR, EXTI_BASE + 0x8 @ (Rising Trigger selection register
  EXTI_RTSR) 
        .equ EXTI_TR0_Shift, 0   @ bitWidth 1 (Rising trigger event configuration of
  line 0)  
        .equ EXTI_TR1_Shift, 1   @ bitWidth 1 (Rising trigger event configuration of
  line 1)  
        .equ EXTI_TR2_Shift, 2   @ bitWidth 1 (Rising trigger event configuration of
  line 2)  
        .equ EXTI_TR3_Shift, 3   @ bitWidth 1 (Rising trigger event configuration of
  line 3)  
        .equ EXTI_TR4_Shift, 4   @ bitWidth 1 (Rising trigger event configuration of
  line 4)  
        .equ EXTI_TR5_Shift, 5   @ bitWidth 1 (Rising trigger event configuration of
  line 5)  
        .equ EXTI_TR6_Shift, 6   @ bitWidth 1 (Rising trigger event configuration of
  line 6)  
        .equ EXTI_TR7_Shift, 7   @ bitWidth 1 (Rising trigger event configuration of
  line 7)  
        .equ EXTI_TR8_Shift, 8   @ bitWidth 1 (Rising trigger event configuration of
  line 8)  
        .equ EXTI_TR9_Shift, 9   @ bitWidth 1 (Rising trigger event configuration of
  line 9)  
        .equ EXTI_TR10_Shift, 10   @ bitWidth 1 (Rising trigger event configuration of
  line 10)  
        .equ EXTI_TR11_Shift, 11   @ bitWidth 1 (Rising trigger event configuration of
  line 11)  
        .equ EXTI_TR12_Shift, 12   @ bitWidth 1 (Rising trigger event configuration of
  line 12)  
        .equ EXTI_TR13_Shift, 13   @ bitWidth 1 (Rising trigger event configuration of
  line 13)  
        .equ EXTI_TR14_Shift, 14   @ bitWidth 1 (Rising trigger event configuration of
  line 14)  
        .equ EXTI_TR15_Shift, 15   @ bitWidth 1 (Rising trigger event configuration of
  line 15)  
        .equ EXTI_TR16_Shift, 16   @ bitWidth 1 (Rising trigger event configuration of
  line 16)  
        .equ EXTI_TR17_Shift, 17   @ bitWidth 1 (Rising trigger event configuration of
  line 17)  
        .equ EXTI_TR18_Shift, 18   @ bitWidth 1 (Rising trigger event configuration of
  line 18)  
        .equ EXTI_TR19_Shift, 19   @ bitWidth 1 (Rising trigger event configuration of
  line 19)  
        .equ EXTI_TR20_Shift, 20   @ bitWidth 1 (Rising trigger event configuration of
  line 20)  
        .equ EXTI_TR21_Shift, 21   @ bitWidth 1 (Rising trigger event configuration of
  line 21)  
        .equ EXTI_TR22_Shift, 22   @ bitWidth 1 (Rising trigger event configuration of
  line 22)  
 
    .equ EXTI_FTSR, EXTI_BASE + 0xC @ (Falling Trigger selection register
  EXTI_FTSR) 
        .equ EXTI_TR0_Shift, 0   @ bitWidth 1 (Falling trigger event configuration of
  line 0)  
        .equ EXTI_TR1_Shift, 1   @ bitWidth 1 (Falling trigger event configuration of
  line 1)  
        .equ EXTI_TR2_Shift, 2   @ bitWidth 1 (Falling trigger event configuration of
  line 2)  
        .equ EXTI_TR3_Shift, 3   @ bitWidth 1 (Falling trigger event configuration of
  line 3)  
        .equ EXTI_TR4_Shift, 4   @ bitWidth 1 (Falling trigger event configuration of
  line 4)  
        .equ EXTI_TR5_Shift, 5   @ bitWidth 1 (Falling trigger event configuration of
  line 5)  
        .equ EXTI_TR6_Shift, 6   @ bitWidth 1 (Falling trigger event configuration of
  line 6)  
        .equ EXTI_TR7_Shift, 7   @ bitWidth 1 (Falling trigger event configuration of
  line 7)  
        .equ EXTI_TR8_Shift, 8   @ bitWidth 1 (Falling trigger event configuration of
  line 8)  
        .equ EXTI_TR9_Shift, 9   @ bitWidth 1 (Falling trigger event configuration of
  line 9)  
        .equ EXTI_TR10_Shift, 10   @ bitWidth 1 (Falling trigger event configuration of
  line 10)  
        .equ EXTI_TR11_Shift, 11   @ bitWidth 1 (Falling trigger event configuration of
  line 11)  
        .equ EXTI_TR12_Shift, 12   @ bitWidth 1 (Falling trigger event configuration of
  line 12)  
        .equ EXTI_TR13_Shift, 13   @ bitWidth 1 (Falling trigger event configuration of
  line 13)  
        .equ EXTI_TR14_Shift, 14   @ bitWidth 1 (Falling trigger event configuration of
  line 14)  
        .equ EXTI_TR15_Shift, 15   @ bitWidth 1 (Falling trigger event configuration of
  line 15)  
        .equ EXTI_TR16_Shift, 16   @ bitWidth 1 (Falling trigger event configuration of
  line 16)  
        .equ EXTI_TR17_Shift, 17   @ bitWidth 1 (Falling trigger event configuration of
  line 17)  
        .equ EXTI_TR18_Shift, 18   @ bitWidth 1 (Falling trigger event configuration of
  line 18)  
        .equ EXTI_TR19_Shift, 19   @ bitWidth 1 (Falling trigger event configuration of
  line 19)  
        .equ EXTI_TR20_Shift, 20   @ bitWidth 1 (Falling trigger event configuration of
  line 20)  
        .equ EXTI_TR21_Shift, 21   @ bitWidth 1 (Falling trigger event configuration of
  line 21)  
        .equ EXTI_TR22_Shift, 22   @ bitWidth 1 (Falling trigger event configuration of
  line 22)  
 
    .equ EXTI_SWIER, EXTI_BASE + 0x10 @ (Software interrupt event register
  EXTI_SWIER) 
        .equ EXTI_SWIER0_Shift, 0   @ bitWidth 1 (Software Interrupt on line
  0)  
        .equ EXTI_SWIER1_Shift, 1   @ bitWidth 1 (Software Interrupt on line
  1)  
        .equ EXTI_SWIER2_Shift, 2   @ bitWidth 1 (Software Interrupt on line
  2)  
        .equ EXTI_SWIER3_Shift, 3   @ bitWidth 1 (Software Interrupt on line
  3)  
        .equ EXTI_SWIER4_Shift, 4   @ bitWidth 1 (Software Interrupt on line
  4)  
        .equ EXTI_SWIER5_Shift, 5   @ bitWidth 1 (Software Interrupt on line
  5)  
        .equ EXTI_SWIER6_Shift, 6   @ bitWidth 1 (Software Interrupt on line
  6)  
        .equ EXTI_SWIER7_Shift, 7   @ bitWidth 1 (Software Interrupt on line
  7)  
        .equ EXTI_SWIER8_Shift, 8   @ bitWidth 1 (Software Interrupt on line
  8)  
        .equ EXTI_SWIER9_Shift, 9   @ bitWidth 1 (Software Interrupt on line
  9)  
        .equ EXTI_SWIER10_Shift, 10   @ bitWidth 1 (Software Interrupt on line
  10)  
        .equ EXTI_SWIER11_Shift, 11   @ bitWidth 1 (Software Interrupt on line
  11)  
        .equ EXTI_SWIER12_Shift, 12   @ bitWidth 1 (Software Interrupt on line
  12)  
        .equ EXTI_SWIER13_Shift, 13   @ bitWidth 1 (Software Interrupt on line
  13)  
        .equ EXTI_SWIER14_Shift, 14   @ bitWidth 1 (Software Interrupt on line
  14)  
        .equ EXTI_SWIER15_Shift, 15   @ bitWidth 1 (Software Interrupt on line
  15)  
        .equ EXTI_SWIER16_Shift, 16   @ bitWidth 1 (Software Interrupt on line
  16)  
        .equ EXTI_SWIER17_Shift, 17   @ bitWidth 1 (Software Interrupt on line
  17)  
        .equ EXTI_SWIER18_Shift, 18   @ bitWidth 1 (Software Interrupt on line
  18)  
        .equ EXTI_SWIER19_Shift, 19   @ bitWidth 1 (Software Interrupt on line
  19)  
        .equ EXTI_SWIER20_Shift, 20   @ bitWidth 1 (Software Interrupt on line
  20)  
        .equ EXTI_SWIER21_Shift, 21   @ bitWidth 1 (Software Interrupt on line
  21)  
        .equ EXTI_SWIER22_Shift, 22   @ bitWidth 1 (Software Interrupt on line
  22)  
 
    .equ EXTI_PR, EXTI_BASE + 0x14 @ (Pending register EXTI_PR) 
        .equ EXTI_PR0_Shift, 0   @ bitWidth 1 (Pending bit 0)  
        .equ EXTI_PR1_Shift, 1   @ bitWidth 1 (Pending bit 1)  
        .equ EXTI_PR2_Shift, 2   @ bitWidth 1 (Pending bit 2)  
        .equ EXTI_PR3_Shift, 3   @ bitWidth 1 (Pending bit 3)  
        .equ EXTI_PR4_Shift, 4   @ bitWidth 1 (Pending bit 4)  
        .equ EXTI_PR5_Shift, 5   @ bitWidth 1 (Pending bit 5)  
        .equ EXTI_PR6_Shift, 6   @ bitWidth 1 (Pending bit 6)  
        .equ EXTI_PR7_Shift, 7   @ bitWidth 1 (Pending bit 7)  
        .equ EXTI_PR8_Shift, 8   @ bitWidth 1 (Pending bit 8)  
        .equ EXTI_PR9_Shift, 9   @ bitWidth 1 (Pending bit 9)  
        .equ EXTI_PR10_Shift, 10   @ bitWidth 1 (Pending bit 10)  
        .equ EXTI_PR11_Shift, 11   @ bitWidth 1 (Pending bit 11)  
        .equ EXTI_PR12_Shift, 12   @ bitWidth 1 (Pending bit 12)  
        .equ EXTI_PR13_Shift, 13   @ bitWidth 1 (Pending bit 13)  
        .equ EXTI_PR14_Shift, 14   @ bitWidth 1 (Pending bit 14)  
        .equ EXTI_PR15_Shift, 15   @ bitWidth 1 (Pending bit 15)  
        .equ EXTI_PR16_Shift, 16   @ bitWidth 1 (Pending bit 16)  
        .equ EXTI_PR17_Shift, 17   @ bitWidth 1 (Pending bit 17)  
        .equ EXTI_PR18_Shift, 18   @ bitWidth 1 (Pending bit 18)  
        .equ EXTI_PR19_Shift, 19   @ bitWidth 1 (Pending bit 19)  
        .equ EXTI_PR20_Shift, 20   @ bitWidth 1 (Pending bit 20)  
        .equ EXTI_PR21_Shift, 21   @ bitWidth 1 (Pending bit 21)  
        .equ EXTI_PR22_Shift, 22   @ bitWidth 1 (Pending bit 22)  
 

@=========================== FLASH ===========================@
.equ FLASH_BASE, 0x40023C00 @ (FLASH) 
    .equ FLASH_ACR, FLASH_BASE + 0x0 @ (Flash access control register) 
        .equ FLASH_LATENCY_Shift, 0   @ bitWidth 3 (Latency)  
        .equ FLASH_PRFTEN_Shift, 8   @ bitWidth 1 (Prefetch enable)  
        .equ FLASH_ICEN_Shift, 9   @ bitWidth 1 (Instruction cache enable)  
        .equ FLASH_DCEN_Shift, 10   @ bitWidth 1 (Data cache enable)  
        .equ FLASH_ICRST_Shift, 11   @ bitWidth 1 (Instruction cache reset)  
        .equ FLASH_DCRST_Shift, 12   @ bitWidth 1 (Data cache reset)  
 
    .equ FLASH_KEYR, FLASH_BASE + 0x4 @ (Flash key register) 
        .equ FLASH_KEY_Shift, 0   @ bitWidth 32 (FPEC key)  
 
    .equ FLASH_OPTKEYR, FLASH_BASE + 0x8 @ (Flash option key register) 
        .equ FLASH_OPTKEY_Shift, 0   @ bitWidth 32 (Option byte key)  
 
    .equ FLASH_SR, FLASH_BASE + 0xC @ (Status register) 
        .equ FLASH_EOP_Shift, 0   @ bitWidth 1 (End of operation)  
        .equ FLASH_OPERR_Shift, 1   @ bitWidth 1 (Operation error)  
        .equ FLASH_WRPERR_Shift, 4   @ bitWidth 1 (Write protection error)  
        .equ FLASH_PGAERR_Shift, 5   @ bitWidth 1 (Programming alignment
  error)  
        .equ FLASH_PGPERR_Shift, 6   @ bitWidth 1 (Programming parallelism
  error)  
        .equ FLASH_PGSERR_Shift, 7   @ bitWidth 1 (Programming sequence error)  
        .equ FLASH_BSY_Shift, 16   @ bitWidth 1 (Busy)  
 
    .equ FLASH_CR, FLASH_BASE + 0x10 @ (Control register) 
        .equ FLASH_PG_Shift, 0   @ bitWidth 1 (Programming)  
        .equ FLASH_SER_Shift, 1   @ bitWidth 1 (Sector Erase)  
        .equ FLASH_MER_Shift, 2   @ bitWidth 1 (Mass Erase)  
        .equ FLASH_SNB_Shift, 3   @ bitWidth 4 (Sector number)  
        .equ FLASH_PSIZE_Shift, 8   @ bitWidth 2 (Program size)  
        .equ FLASH_STRT_Shift, 16   @ bitWidth 1 (Start)  
        .equ FLASH_EOPIE_Shift, 24   @ bitWidth 1 (End of operation interrupt
  enable)  
        .equ FLASH_ERRIE_Shift, 25   @ bitWidth 1 (Error interrupt enable)  
        .equ FLASH_LOCK_Shift, 31   @ bitWidth 1 (Lock)  
 
    .equ FLASH_OPTCR, FLASH_BASE + 0x14 @ (Flash option control register) 
        .equ FLASH_OPTLOCK_Shift, 0   @ bitWidth 1 (Option lock)  
        .equ FLASH_OPTSTRT_Shift, 1   @ bitWidth 1 (Option start)  
        .equ FLASH_BOR_LEV_Shift, 2   @ bitWidth 2 (BOR reset Level)  
        .equ FLASH_WDG_SW_Shift, 5   @ bitWidth 1 (WDG_SW User option bytes)  
        .equ FLASH_nRST_STOP_Shift, 6   @ bitWidth 1 (nRST_STOP User option
  bytes)  
        .equ FLASH_nRST_STDBY_Shift, 7   @ bitWidth 1 (nRST_STDBY User option
  bytes)  
        .equ FLASH_RDP_Shift, 8   @ bitWidth 8 (Read protect)  
        .equ FLASH_nWRP_Shift, 16   @ bitWidth 12 (Not write protect)  
 

@=========================== IWDG ===========================@
.equ IWDG_BASE, 0x40003000 @ (Independent watchdog) 
    .equ IWDG_KR, IWDG_BASE + 0x0 @ (Key register) 
        .equ IWDG_KEY_Shift, 0   @ bitWidth 16 (Key value)  
 
    .equ IWDG_PR, IWDG_BASE + 0x4 @ (Prescaler register) 
        .equ IWDG_PR_Shift, 0   @ bitWidth 3 (Prescaler divider)  
 
    .equ IWDG_RLR, IWDG_BASE + 0x8 @ (Reload register) 
        .equ IWDG_RL_Shift, 0   @ bitWidth 12 (Watchdog counter reload
  value)  
 
    .equ IWDG_SR, IWDG_BASE + 0xC @ (Status register) 
        .equ IWDG_RVU_Shift, 1   @ bitWidth 1 (Watchdog counter reload value
  update)  
        .equ IWDG_PVU_Shift, 0   @ bitWidth 1 (Watchdog prescaler value
  update)  
 

@=========================== OTG_FS_DEVICE ===========================@
.equ OTG_FS_DEVICE_BASE, 0x50000800 @ (USB on the go full speed) 
    .equ OTG_FS_DEVICE_FS_DCFG, OTG_FS_DEVICE_BASE + 0x0 @ (OTG_FS device configuration register
  OTG_FS_DCFG) 
        .equ OTG_FS_DEVICE_DSPD_Shift, 0   @ bitWidth 2 (Device speed)  
        .equ OTG_FS_DEVICE_NZLSOHSK_Shift, 2   @ bitWidth 1 (Non-zero-length status OUT
  handshake)  
        .equ OTG_FS_DEVICE_DAD_Shift, 4   @ bitWidth 7 (Device address)  
        .equ OTG_FS_DEVICE_PFIVL_Shift, 11   @ bitWidth 2 (Periodic frame interval)  
 
    .equ OTG_FS_DEVICE_FS_DCTL, OTG_FS_DEVICE_BASE + 0x4 @ (OTG_FS device control register
  OTG_FS_DCTL) 
        .equ OTG_FS_DEVICE_RWUSIG_Shift, 0   @ bitWidth 1 (Remote wakeup signaling)  
        .equ OTG_FS_DEVICE_SDIS_Shift, 1   @ bitWidth 1 (Soft disconnect)  
        .equ OTG_FS_DEVICE_GINSTS_Shift, 2   @ bitWidth 1 (Global IN NAK status)  
        .equ OTG_FS_DEVICE_GONSTS_Shift, 3   @ bitWidth 1 (Global OUT NAK status)  
        .equ OTG_FS_DEVICE_TCTL_Shift, 4   @ bitWidth 3 (Test control)  
        .equ OTG_FS_DEVICE_SGINAK_Shift, 7   @ bitWidth 1 (Set global IN NAK)  
        .equ OTG_FS_DEVICE_CGINAK_Shift, 8   @ bitWidth 1 (Clear global IN NAK)  
        .equ OTG_FS_DEVICE_SGONAK_Shift, 9   @ bitWidth 1 (Set global OUT NAK)  
        .equ OTG_FS_DEVICE_CGONAK_Shift, 10   @ bitWidth 1 (Clear global OUT NAK)  
        .equ OTG_FS_DEVICE_POPRGDNE_Shift, 11   @ bitWidth 1 (Power-on programming done)  
 
    .equ OTG_FS_DEVICE_FS_DSTS, OTG_FS_DEVICE_BASE + 0x8 @ (OTG_FS device status register
  OTG_FS_DSTS) 
        .equ OTG_FS_DEVICE_SUSPSTS_Shift, 0   @ bitWidth 1 (Suspend status)  
        .equ OTG_FS_DEVICE_ENUMSPD_Shift, 1   @ bitWidth 2 (Enumerated speed)  
        .equ OTG_FS_DEVICE_EERR_Shift, 3   @ bitWidth 1 (Erratic error)  
        .equ OTG_FS_DEVICE_FNSOF_Shift, 8   @ bitWidth 14 (Frame number of the received
  SOF)  
 
    .equ OTG_FS_DEVICE_FS_DIEPMSK, OTG_FS_DEVICE_BASE + 0x10 @ (OTG_FS device IN endpoint common interrupt
  mask register OTG_FS_DIEPMSK) 
        .equ OTG_FS_DEVICE_XFRCM_Shift, 0   @ bitWidth 1 (Transfer completed interrupt
  mask)  
        .equ OTG_FS_DEVICE_EPDM_Shift, 1   @ bitWidth 1 (Endpoint disabled interrupt
  mask)  
        .equ OTG_FS_DEVICE_TOM_Shift, 3   @ bitWidth 1 (Timeout condition mask Non-isochronous
  endpoints)  
        .equ OTG_FS_DEVICE_ITTXFEMSK_Shift, 4   @ bitWidth 1 (IN token received when TxFIFO empty
  mask)  
        .equ OTG_FS_DEVICE_INEPNMM_Shift, 5   @ bitWidth 1 (IN token received with EP mismatch
  mask)  
        .equ OTG_FS_DEVICE_INEPNEM_Shift, 6   @ bitWidth 1 (IN endpoint NAK effective
  mask)  
 
    .equ OTG_FS_DEVICE_FS_DOEPMSK, OTG_FS_DEVICE_BASE + 0x14 @ (OTG_FS device OUT endpoint common interrupt
  mask register OTG_FS_DOEPMSK) 
        .equ OTG_FS_DEVICE_XFRCM_Shift, 0   @ bitWidth 1 (Transfer completed interrupt
  mask)  
        .equ OTG_FS_DEVICE_EPDM_Shift, 1   @ bitWidth 1 (Endpoint disabled interrupt
  mask)  
        .equ OTG_FS_DEVICE_STUPM_Shift, 3   @ bitWidth 1 (SETUP phase done mask)  
        .equ OTG_FS_DEVICE_OTEPDM_Shift, 4   @ bitWidth 1 (OUT token received when endpoint
  disabled mask)  
 
    .equ OTG_FS_DEVICE_FS_DAINT, OTG_FS_DEVICE_BASE + 0x18 @ (OTG_FS device all endpoints interrupt
  register OTG_FS_DAINT) 
        .equ OTG_FS_DEVICE_IEPINT_Shift, 0   @ bitWidth 16 (IN endpoint interrupt bits)  
        .equ OTG_FS_DEVICE_OEPINT_Shift, 16   @ bitWidth 16 (OUT endpoint interrupt
  bits)  
 
    .equ OTG_FS_DEVICE_FS_DAINTMSK, OTG_FS_DEVICE_BASE + 0x1C @ (OTG_FS all endpoints interrupt mask register
  OTG_FS_DAINTMSK) 
        .equ OTG_FS_DEVICE_IEPM_Shift, 0   @ bitWidth 16 (IN EP interrupt mask bits)  
        .equ OTG_FS_DEVICE_OEPINT_Shift, 16   @ bitWidth 16 (OUT endpoint interrupt
  bits)  
 
    .equ OTG_FS_DEVICE_DVBUSDIS, OTG_FS_DEVICE_BASE + 0x28 @ (OTG_FS device VBUS discharge time
  register) 
        .equ OTG_FS_DEVICE_VBUSDT_Shift, 0   @ bitWidth 16 (Device VBUS discharge time)  
 
    .equ OTG_FS_DEVICE_DVBUSPULSE, OTG_FS_DEVICE_BASE + 0x2C @ (OTG_FS device VBUS pulsing time
  register) 
        .equ OTG_FS_DEVICE_DVBUSP_Shift, 0   @ bitWidth 12 (Device VBUS pulsing time)  
 
    .equ OTG_FS_DEVICE_DIEPEMPMSK, OTG_FS_DEVICE_BASE + 0x34 @ (OTG_FS device IN endpoint FIFO empty
  interrupt mask register) 
        .equ OTG_FS_DEVICE_INEPTXFEM_Shift, 0   @ bitWidth 16 (IN EP Tx FIFO empty interrupt mask
  bits)  
 
    .equ OTG_FS_DEVICE_FS_DIEPCTL0, OTG_FS_DEVICE_BASE + 0x100 @ (OTG_FS device control IN endpoint 0 control
  register OTG_FS_DIEPCTL0) 
        .equ OTG_FS_DEVICE_MPSIZ_Shift, 0   @ bitWidth 2 (Maximum packet size)  
        .equ OTG_FS_DEVICE_USBAEP_Shift, 15   @ bitWidth 1 (USB active endpoint)  
        .equ OTG_FS_DEVICE_NAKSTS_Shift, 17   @ bitWidth 1 (NAK status)  
        .equ OTG_FS_DEVICE_EPTYP_Shift, 18   @ bitWidth 2 (Endpoint type)  
        .equ OTG_FS_DEVICE_STALL_Shift, 21   @ bitWidth 1 (STALL handshake)  
        .equ OTG_FS_DEVICE_TXFNUM_Shift, 22   @ bitWidth 4 (TxFIFO number)  
        .equ OTG_FS_DEVICE_CNAK_Shift, 26   @ bitWidth 1 (Clear NAK)  
        .equ OTG_FS_DEVICE_SNAK_Shift, 27   @ bitWidth 1 (Set NAK)  
        .equ OTG_FS_DEVICE_EPDIS_Shift, 30   @ bitWidth 1 (Endpoint disable)  
        .equ OTG_FS_DEVICE_EPENA_Shift, 31   @ bitWidth 1 (Endpoint enable)  
 
    .equ OTG_FS_DEVICE_DIEPCTL1, OTG_FS_DEVICE_BASE + 0x120 @ (OTG device endpoint-1 control
  register) 
        .equ OTG_FS_DEVICE_EPENA_Shift, 31   @ bitWidth 1 (EPENA)  
        .equ OTG_FS_DEVICE_EPDIS_Shift, 30   @ bitWidth 1 (EPDIS)  
        .equ OTG_FS_DEVICE_SODDFRM_SD1PID_Shift, 29   @ bitWidth 1 (SODDFRM/SD1PID)  
        .equ OTG_FS_DEVICE_SD0PID_SEVNFRM_Shift, 28   @ bitWidth 1 (SD0PID/SEVNFRM)  
        .equ OTG_FS_DEVICE_SNAK_Shift, 27   @ bitWidth 1 (SNAK)  
        .equ OTG_FS_DEVICE_CNAK_Shift, 26   @ bitWidth 1 (CNAK)  
        .equ OTG_FS_DEVICE_TXFNUM_Shift, 22   @ bitWidth 4 (TXFNUM)  
        .equ OTG_FS_DEVICE_Stall_Shift, 21   @ bitWidth 1 (Stall)  
        .equ OTG_FS_DEVICE_EPTYP_Shift, 18   @ bitWidth 2 (EPTYP)  
        .equ OTG_FS_DEVICE_NAKSTS_Shift, 17   @ bitWidth 1 (NAKSTS)  
        .equ OTG_FS_DEVICE_EONUM_DPID_Shift, 16   @ bitWidth 1 (EONUM/DPID)  
        .equ OTG_FS_DEVICE_USBAEP_Shift, 15   @ bitWidth 1 (USBAEP)  
        .equ OTG_FS_DEVICE_MPSIZ_Shift, 0   @ bitWidth 11 (MPSIZ)  
 
    .equ OTG_FS_DEVICE_DIEPCTL2, OTG_FS_DEVICE_BASE + 0x140 @ (OTG device endpoint-2 control
  register) 
        .equ OTG_FS_DEVICE_EPENA_Shift, 31   @ bitWidth 1 (EPENA)  
        .equ OTG_FS_DEVICE_EPDIS_Shift, 30   @ bitWidth 1 (EPDIS)  
        .equ OTG_FS_DEVICE_SODDFRM_Shift, 29   @ bitWidth 1 (SODDFRM)  
        .equ OTG_FS_DEVICE_SD0PID_SEVNFRM_Shift, 28   @ bitWidth 1 (SD0PID/SEVNFRM)  
        .equ OTG_FS_DEVICE_SNAK_Shift, 27   @ bitWidth 1 (SNAK)  
        .equ OTG_FS_DEVICE_CNAK_Shift, 26   @ bitWidth 1 (CNAK)  
        .equ OTG_FS_DEVICE_TXFNUM_Shift, 22   @ bitWidth 4 (TXFNUM)  
        .equ OTG_FS_DEVICE_Stall_Shift, 21   @ bitWidth 1 (Stall)  
        .equ OTG_FS_DEVICE_EPTYP_Shift, 18   @ bitWidth 2 (EPTYP)  
        .equ OTG_FS_DEVICE_NAKSTS_Shift, 17   @ bitWidth 1 (NAKSTS)  
        .equ OTG_FS_DEVICE_EONUM_DPID_Shift, 16   @ bitWidth 1 (EONUM/DPID)  
        .equ OTG_FS_DEVICE_USBAEP_Shift, 15   @ bitWidth 1 (USBAEP)  
        .equ OTG_FS_DEVICE_MPSIZ_Shift, 0   @ bitWidth 11 (MPSIZ)  
 
    .equ OTG_FS_DEVICE_DIEPCTL3, OTG_FS_DEVICE_BASE + 0x160 @ (OTG device endpoint-3 control
  register) 
        .equ OTG_FS_DEVICE_EPENA_Shift, 31   @ bitWidth 1 (EPENA)  
        .equ OTG_FS_DEVICE_EPDIS_Shift, 30   @ bitWidth 1 (EPDIS)  
        .equ OTG_FS_DEVICE_SODDFRM_Shift, 29   @ bitWidth 1 (SODDFRM)  
        .equ OTG_FS_DEVICE_SD0PID_SEVNFRM_Shift, 28   @ bitWidth 1 (SD0PID/SEVNFRM)  
        .equ OTG_FS_DEVICE_SNAK_Shift, 27   @ bitWidth 1 (SNAK)  
        .equ OTG_FS_DEVICE_CNAK_Shift, 26   @ bitWidth 1 (CNAK)  
        .equ OTG_FS_DEVICE_TXFNUM_Shift, 22   @ bitWidth 4 (TXFNUM)  
        .equ OTG_FS_DEVICE_Stall_Shift, 21   @ bitWidth 1 (Stall)  
        .equ OTG_FS_DEVICE_EPTYP_Shift, 18   @ bitWidth 2 (EPTYP)  
        .equ OTG_FS_DEVICE_NAKSTS_Shift, 17   @ bitWidth 1 (NAKSTS)  
        .equ OTG_FS_DEVICE_EONUM_DPID_Shift, 16   @ bitWidth 1 (EONUM/DPID)  
        .equ OTG_FS_DEVICE_USBAEP_Shift, 15   @ bitWidth 1 (USBAEP)  
        .equ OTG_FS_DEVICE_MPSIZ_Shift, 0   @ bitWidth 11 (MPSIZ)  
 
    .equ OTG_FS_DEVICE_DOEPCTL0, OTG_FS_DEVICE_BASE + 0x300 @ (device endpoint-0 control
  register) 
        .equ OTG_FS_DEVICE_EPENA_Shift, 31   @ bitWidth 1 (EPENA)  
        .equ OTG_FS_DEVICE_EPDIS_Shift, 30   @ bitWidth 1 (EPDIS)  
        .equ OTG_FS_DEVICE_SNAK_Shift, 27   @ bitWidth 1 (SNAK)  
        .equ OTG_FS_DEVICE_CNAK_Shift, 26   @ bitWidth 1 (CNAK)  
        .equ OTG_FS_DEVICE_Stall_Shift, 21   @ bitWidth 1 (Stall)  
        .equ OTG_FS_DEVICE_SNPM_Shift, 20   @ bitWidth 1 (SNPM)  
        .equ OTG_FS_DEVICE_EPTYP_Shift, 18   @ bitWidth 2 (EPTYP)  
        .equ OTG_FS_DEVICE_NAKSTS_Shift, 17   @ bitWidth 1 (NAKSTS)  
        .equ OTG_FS_DEVICE_USBAEP_Shift, 15   @ bitWidth 1 (USBAEP)  
        .equ OTG_FS_DEVICE_MPSIZ_Shift, 0   @ bitWidth 2 (MPSIZ)  
 
    .equ OTG_FS_DEVICE_DOEPCTL1, OTG_FS_DEVICE_BASE + 0x320 @ (device endpoint-1 control
  register) 
        .equ OTG_FS_DEVICE_EPENA_Shift, 31   @ bitWidth 1 (EPENA)  
        .equ OTG_FS_DEVICE_EPDIS_Shift, 30   @ bitWidth 1 (EPDIS)  
        .equ OTG_FS_DEVICE_SODDFRM_Shift, 29   @ bitWidth 1 (SODDFRM)  
        .equ OTG_FS_DEVICE_SD0PID_SEVNFRM_Shift, 28   @ bitWidth 1 (SD0PID/SEVNFRM)  
        .equ OTG_FS_DEVICE_SNAK_Shift, 27   @ bitWidth 1 (SNAK)  
        .equ OTG_FS_DEVICE_CNAK_Shift, 26   @ bitWidth 1 (CNAK)  
        .equ OTG_FS_DEVICE_Stall_Shift, 21   @ bitWidth 1 (Stall)  
        .equ OTG_FS_DEVICE_SNPM_Shift, 20   @ bitWidth 1 (SNPM)  
        .equ OTG_FS_DEVICE_EPTYP_Shift, 18   @ bitWidth 2 (EPTYP)  
        .equ OTG_FS_DEVICE_NAKSTS_Shift, 17   @ bitWidth 1 (NAKSTS)  
        .equ OTG_FS_DEVICE_EONUM_DPID_Shift, 16   @ bitWidth 1 (EONUM/DPID)  
        .equ OTG_FS_DEVICE_USBAEP_Shift, 15   @ bitWidth 1 (USBAEP)  
        .equ OTG_FS_DEVICE_MPSIZ_Shift, 0   @ bitWidth 11 (MPSIZ)  
 
    .equ OTG_FS_DEVICE_DOEPCTL2, OTG_FS_DEVICE_BASE + 0x340 @ (device endpoint-2 control
  register) 
        .equ OTG_FS_DEVICE_EPENA_Shift, 31   @ bitWidth 1 (EPENA)  
        .equ OTG_FS_DEVICE_EPDIS_Shift, 30   @ bitWidth 1 (EPDIS)  
        .equ OTG_FS_DEVICE_SODDFRM_Shift, 29   @ bitWidth 1 (SODDFRM)  
        .equ OTG_FS_DEVICE_SD0PID_SEVNFRM_Shift, 28   @ bitWidth 1 (SD0PID/SEVNFRM)  
        .equ OTG_FS_DEVICE_SNAK_Shift, 27   @ bitWidth 1 (SNAK)  
        .equ OTG_FS_DEVICE_CNAK_Shift, 26   @ bitWidth 1 (CNAK)  
        .equ OTG_FS_DEVICE_Stall_Shift, 21   @ bitWidth 1 (Stall)  
        .equ OTG_FS_DEVICE_SNPM_Shift, 20   @ bitWidth 1 (SNPM)  
        .equ OTG_FS_DEVICE_EPTYP_Shift, 18   @ bitWidth 2 (EPTYP)  
        .equ OTG_FS_DEVICE_NAKSTS_Shift, 17   @ bitWidth 1 (NAKSTS)  
        .equ OTG_FS_DEVICE_EONUM_DPID_Shift, 16   @ bitWidth 1 (EONUM/DPID)  
        .equ OTG_FS_DEVICE_USBAEP_Shift, 15   @ bitWidth 1 (USBAEP)  
        .equ OTG_FS_DEVICE_MPSIZ_Shift, 0   @ bitWidth 11 (MPSIZ)  
 
    .equ OTG_FS_DEVICE_DOEPCTL3, OTG_FS_DEVICE_BASE + 0x360 @ (device endpoint-3 control
  register) 
        .equ OTG_FS_DEVICE_EPENA_Shift, 31   @ bitWidth 1 (EPENA)  
        .equ OTG_FS_DEVICE_EPDIS_Shift, 30   @ bitWidth 1 (EPDIS)  
        .equ OTG_FS_DEVICE_SODDFRM_Shift, 29   @ bitWidth 1 (SODDFRM)  
        .equ OTG_FS_DEVICE_SD0PID_SEVNFRM_Shift, 28   @ bitWidth 1 (SD0PID/SEVNFRM)  
        .equ OTG_FS_DEVICE_SNAK_Shift, 27   @ bitWidth 1 (SNAK)  
        .equ OTG_FS_DEVICE_CNAK_Shift, 26   @ bitWidth 1 (CNAK)  
        .equ OTG_FS_DEVICE_Stall_Shift, 21   @ bitWidth 1 (Stall)  
        .equ OTG_FS_DEVICE_SNPM_Shift, 20   @ bitWidth 1 (SNPM)  
        .equ OTG_FS_DEVICE_EPTYP_Shift, 18   @ bitWidth 2 (EPTYP)  
        .equ OTG_FS_DEVICE_NAKSTS_Shift, 17   @ bitWidth 1 (NAKSTS)  
        .equ OTG_FS_DEVICE_EONUM_DPID_Shift, 16   @ bitWidth 1 (EONUM/DPID)  
        .equ OTG_FS_DEVICE_USBAEP_Shift, 15   @ bitWidth 1 (USBAEP)  
        .equ OTG_FS_DEVICE_MPSIZ_Shift, 0   @ bitWidth 11 (MPSIZ)  
 
    .equ OTG_FS_DEVICE_DIEPINT0, OTG_FS_DEVICE_BASE + 0x108 @ (device endpoint-x interrupt
  register) 
        .equ OTG_FS_DEVICE_TXFE_Shift, 7   @ bitWidth 1 (TXFE)  
        .equ OTG_FS_DEVICE_INEPNE_Shift, 6   @ bitWidth 1 (INEPNE)  
        .equ OTG_FS_DEVICE_ITTXFE_Shift, 4   @ bitWidth 1 (ITTXFE)  
        .equ OTG_FS_DEVICE_TOC_Shift, 3   @ bitWidth 1 (TOC)  
        .equ OTG_FS_DEVICE_EPDISD_Shift, 1   @ bitWidth 1 (EPDISD)  
        .equ OTG_FS_DEVICE_XFRC_Shift, 0   @ bitWidth 1 (XFRC)  
 
    .equ OTG_FS_DEVICE_DIEPINT1, OTG_FS_DEVICE_BASE + 0x128 @ (device endpoint-1 interrupt
  register) 
        .equ OTG_FS_DEVICE_TXFE_Shift, 7   @ bitWidth 1 (TXFE)  
        .equ OTG_FS_DEVICE_INEPNE_Shift, 6   @ bitWidth 1 (INEPNE)  
        .equ OTG_FS_DEVICE_ITTXFE_Shift, 4   @ bitWidth 1 (ITTXFE)  
        .equ OTG_FS_DEVICE_TOC_Shift, 3   @ bitWidth 1 (TOC)  
        .equ OTG_FS_DEVICE_EPDISD_Shift, 1   @ bitWidth 1 (EPDISD)  
        .equ OTG_FS_DEVICE_XFRC_Shift, 0   @ bitWidth 1 (XFRC)  
 
    .equ OTG_FS_DEVICE_DIEPINT2, OTG_FS_DEVICE_BASE + 0x148 @ (device endpoint-2 interrupt
  register) 
        .equ OTG_FS_DEVICE_TXFE_Shift, 7   @ bitWidth 1 (TXFE)  
        .equ OTG_FS_DEVICE_INEPNE_Shift, 6   @ bitWidth 1 (INEPNE)  
        .equ OTG_FS_DEVICE_ITTXFE_Shift, 4   @ bitWidth 1 (ITTXFE)  
        .equ OTG_FS_DEVICE_TOC_Shift, 3   @ bitWidth 1 (TOC)  
        .equ OTG_FS_DEVICE_EPDISD_Shift, 1   @ bitWidth 1 (EPDISD)  
        .equ OTG_FS_DEVICE_XFRC_Shift, 0   @ bitWidth 1 (XFRC)  
 
    .equ OTG_FS_DEVICE_DIEPINT3, OTG_FS_DEVICE_BASE + 0x168 @ (device endpoint-3 interrupt
  register) 
        .equ OTG_FS_DEVICE_TXFE_Shift, 7   @ bitWidth 1 (TXFE)  
        .equ OTG_FS_DEVICE_INEPNE_Shift, 6   @ bitWidth 1 (INEPNE)  
        .equ OTG_FS_DEVICE_ITTXFE_Shift, 4   @ bitWidth 1 (ITTXFE)  
        .equ OTG_FS_DEVICE_TOC_Shift, 3   @ bitWidth 1 (TOC)  
        .equ OTG_FS_DEVICE_EPDISD_Shift, 1   @ bitWidth 1 (EPDISD)  
        .equ OTG_FS_DEVICE_XFRC_Shift, 0   @ bitWidth 1 (XFRC)  
 
    .equ OTG_FS_DEVICE_DOEPINT0, OTG_FS_DEVICE_BASE + 0x308 @ (device endpoint-0 interrupt
  register) 
        .equ OTG_FS_DEVICE_B2BSTUP_Shift, 6   @ bitWidth 1 (B2BSTUP)  
        .equ OTG_FS_DEVICE_OTEPDIS_Shift, 4   @ bitWidth 1 (OTEPDIS)  
        .equ OTG_FS_DEVICE_STUP_Shift, 3   @ bitWidth 1 (STUP)  
        .equ OTG_FS_DEVICE_EPDISD_Shift, 1   @ bitWidth 1 (EPDISD)  
        .equ OTG_FS_DEVICE_XFRC_Shift, 0   @ bitWidth 1 (XFRC)  
 
    .equ OTG_FS_DEVICE_DOEPINT1, OTG_FS_DEVICE_BASE + 0x328 @ (device endpoint-1 interrupt
  register) 
        .equ OTG_FS_DEVICE_B2BSTUP_Shift, 6   @ bitWidth 1 (B2BSTUP)  
        .equ OTG_FS_DEVICE_OTEPDIS_Shift, 4   @ bitWidth 1 (OTEPDIS)  
        .equ OTG_FS_DEVICE_STUP_Shift, 3   @ bitWidth 1 (STUP)  
        .equ OTG_FS_DEVICE_EPDISD_Shift, 1   @ bitWidth 1 (EPDISD)  
        .equ OTG_FS_DEVICE_XFRC_Shift, 0   @ bitWidth 1 (XFRC)  
 
    .equ OTG_FS_DEVICE_DOEPINT2, OTG_FS_DEVICE_BASE + 0x348 @ (device endpoint-2 interrupt
  register) 
        .equ OTG_FS_DEVICE_B2BSTUP_Shift, 6   @ bitWidth 1 (B2BSTUP)  
        .equ OTG_FS_DEVICE_OTEPDIS_Shift, 4   @ bitWidth 1 (OTEPDIS)  
        .equ OTG_FS_DEVICE_STUP_Shift, 3   @ bitWidth 1 (STUP)  
        .equ OTG_FS_DEVICE_EPDISD_Shift, 1   @ bitWidth 1 (EPDISD)  
        .equ OTG_FS_DEVICE_XFRC_Shift, 0   @ bitWidth 1 (XFRC)  
 
    .equ OTG_FS_DEVICE_DOEPINT3, OTG_FS_DEVICE_BASE + 0x368 @ (device endpoint-3 interrupt
  register) 
        .equ OTG_FS_DEVICE_B2BSTUP_Shift, 6   @ bitWidth 1 (B2BSTUP)  
        .equ OTG_FS_DEVICE_OTEPDIS_Shift, 4   @ bitWidth 1 (OTEPDIS)  
        .equ OTG_FS_DEVICE_STUP_Shift, 3   @ bitWidth 1 (STUP)  
        .equ OTG_FS_DEVICE_EPDISD_Shift, 1   @ bitWidth 1 (EPDISD)  
        .equ OTG_FS_DEVICE_XFRC_Shift, 0   @ bitWidth 1 (XFRC)  
 
    .equ OTG_FS_DEVICE_DIEPTSIZ0, OTG_FS_DEVICE_BASE + 0x110 @ (device endpoint-0 transfer size
  register) 
        .equ OTG_FS_DEVICE_PKTCNT_Shift, 19   @ bitWidth 2 (Packet count)  
        .equ OTG_FS_DEVICE_XFRSIZ_Shift, 0   @ bitWidth 7 (Transfer size)  
 
    .equ OTG_FS_DEVICE_DOEPTSIZ0, OTG_FS_DEVICE_BASE + 0x310 @ (device OUT endpoint-0 transfer size
  register) 
        .equ OTG_FS_DEVICE_STUPCNT_Shift, 29   @ bitWidth 2 (SETUP packet count)  
        .equ OTG_FS_DEVICE_PKTCNT_Shift, 19   @ bitWidth 1 (Packet count)  
        .equ OTG_FS_DEVICE_XFRSIZ_Shift, 0   @ bitWidth 7 (Transfer size)  
 
    .equ OTG_FS_DEVICE_DIEPTSIZ1, OTG_FS_DEVICE_BASE + 0x130 @ (device endpoint-1 transfer size
  register) 
        .equ OTG_FS_DEVICE_MCNT_Shift, 29   @ bitWidth 2 (Multi count)  
        .equ OTG_FS_DEVICE_PKTCNT_Shift, 19   @ bitWidth 10 (Packet count)  
        .equ OTG_FS_DEVICE_XFRSIZ_Shift, 0   @ bitWidth 19 (Transfer size)  
 
    .equ OTG_FS_DEVICE_DIEPTSIZ2, OTG_FS_DEVICE_BASE + 0x150 @ (device endpoint-2 transfer size
  register) 
        .equ OTG_FS_DEVICE_MCNT_Shift, 29   @ bitWidth 2 (Multi count)  
        .equ OTG_FS_DEVICE_PKTCNT_Shift, 19   @ bitWidth 10 (Packet count)  
        .equ OTG_FS_DEVICE_XFRSIZ_Shift, 0   @ bitWidth 19 (Transfer size)  
 
    .equ OTG_FS_DEVICE_DIEPTSIZ3, OTG_FS_DEVICE_BASE + 0x170 @ (device endpoint-3 transfer size
  register) 
        .equ OTG_FS_DEVICE_MCNT_Shift, 29   @ bitWidth 2 (Multi count)  
        .equ OTG_FS_DEVICE_PKTCNT_Shift, 19   @ bitWidth 10 (Packet count)  
        .equ OTG_FS_DEVICE_XFRSIZ_Shift, 0   @ bitWidth 19 (Transfer size)  
 
    .equ OTG_FS_DEVICE_DTXFSTS0, OTG_FS_DEVICE_BASE + 0x118 @ (OTG_FS device IN endpoint transmit FIFO
  status register) 
        .equ OTG_FS_DEVICE_INEPTFSAV_Shift, 0   @ bitWidth 16 (IN endpoint TxFIFO space
  available)  
 
    .equ OTG_FS_DEVICE_DTXFSTS1, OTG_FS_DEVICE_BASE + 0x138 @ (OTG_FS device IN endpoint transmit FIFO
  status register) 
        .equ OTG_FS_DEVICE_INEPTFSAV_Shift, 0   @ bitWidth 16 (IN endpoint TxFIFO space
  available)  
 
    .equ OTG_FS_DEVICE_DTXFSTS2, OTG_FS_DEVICE_BASE + 0x158 @ (OTG_FS device IN endpoint transmit FIFO
  status register) 
        .equ OTG_FS_DEVICE_INEPTFSAV_Shift, 0   @ bitWidth 16 (IN endpoint TxFIFO space
  available)  
 
    .equ OTG_FS_DEVICE_DTXFSTS3, OTG_FS_DEVICE_BASE + 0x178 @ (OTG_FS device IN endpoint transmit FIFO
  status register) 
        .equ OTG_FS_DEVICE_INEPTFSAV_Shift, 0   @ bitWidth 16 (IN endpoint TxFIFO space
  available)  
 
    .equ OTG_FS_DEVICE_DOEPTSIZ1, OTG_FS_DEVICE_BASE + 0x330 @ (device OUT endpoint-1 transfer size
  register) 
        .equ OTG_FS_DEVICE_RXDPID_STUPCNT_Shift, 29   @ bitWidth 2 (Received data PID/SETUP packet
  count)  
        .equ OTG_FS_DEVICE_PKTCNT_Shift, 19   @ bitWidth 10 (Packet count)  
        .equ OTG_FS_DEVICE_XFRSIZ_Shift, 0   @ bitWidth 19 (Transfer size)  
 
    .equ OTG_FS_DEVICE_DOEPTSIZ2, OTG_FS_DEVICE_BASE + 0x350 @ (device OUT endpoint-2 transfer size
  register) 
        .equ OTG_FS_DEVICE_RXDPID_STUPCNT_Shift, 29   @ bitWidth 2 (Received data PID/SETUP packet
  count)  
        .equ OTG_FS_DEVICE_PKTCNT_Shift, 19   @ bitWidth 10 (Packet count)  
        .equ OTG_FS_DEVICE_XFRSIZ_Shift, 0   @ bitWidth 19 (Transfer size)  
 
    .equ OTG_FS_DEVICE_DOEPTSIZ3, OTG_FS_DEVICE_BASE + 0x370 @ (device OUT endpoint-3 transfer size
  register) 
        .equ OTG_FS_DEVICE_RXDPID_STUPCNT_Shift, 29   @ bitWidth 2 (Received data PID/SETUP packet
  count)  
        .equ OTG_FS_DEVICE_PKTCNT_Shift, 19   @ bitWidth 10 (Packet count)  
        .equ OTG_FS_DEVICE_XFRSIZ_Shift, 0   @ bitWidth 19 (Transfer size)  
 

@=========================== OTG_FS_GLOBAL ===========================@
.equ OTG_FS_GLOBAL_BASE, 0x50000000 @ (USB on the go full speed) 
    .equ OTG_FS_GLOBAL_FS_GOTGCTL, OTG_FS_GLOBAL_BASE + 0x0 @ (OTG_FS control and status register
  OTG_FS_GOTGCTL) 
        .equ OTG_FS_GLOBAL_SRQSCS_Shift, 0   @ bitWidth 1 (Session request success)  
        .equ OTG_FS_GLOBAL_SRQ_Shift, 1   @ bitWidth 1 (Session request)  
        .equ OTG_FS_GLOBAL_HNGSCS_Shift, 8   @ bitWidth 1 (Host negotiation success)  
        .equ OTG_FS_GLOBAL_HNPRQ_Shift, 9   @ bitWidth 1 (HNP request)  
        .equ OTG_FS_GLOBAL_HSHNPEN_Shift, 10   @ bitWidth 1 (Host set HNP enable)  
        .equ OTG_FS_GLOBAL_DHNPEN_Shift, 11   @ bitWidth 1 (Device HNP enabled)  
        .equ OTG_FS_GLOBAL_CIDSTS_Shift, 16   @ bitWidth 1 (Connector ID status)  
        .equ OTG_FS_GLOBAL_DBCT_Shift, 17   @ bitWidth 1 (Long/short debounce time)  
        .equ OTG_FS_GLOBAL_ASVLD_Shift, 18   @ bitWidth 1 (A-session valid)  
        .equ OTG_FS_GLOBAL_BSVLD_Shift, 19   @ bitWidth 1 (B-session valid)  
 
    .equ OTG_FS_GLOBAL_FS_GOTGINT, OTG_FS_GLOBAL_BASE + 0x4 @ (OTG_FS interrupt register
  OTG_FS_GOTGINT) 
        .equ OTG_FS_GLOBAL_SEDET_Shift, 2   @ bitWidth 1 (Session end detected)  
        .equ OTG_FS_GLOBAL_SRSSCHG_Shift, 8   @ bitWidth 1 (Session request success status
  change)  
        .equ OTG_FS_GLOBAL_HNSSCHG_Shift, 9   @ bitWidth 1 (Host negotiation success status
  change)  
        .equ OTG_FS_GLOBAL_HNGDET_Shift, 17   @ bitWidth 1 (Host negotiation detected)  
        .equ OTG_FS_GLOBAL_ADTOCHG_Shift, 18   @ bitWidth 1 (A-device timeout change)  
        .equ OTG_FS_GLOBAL_DBCDNE_Shift, 19   @ bitWidth 1 (Debounce done)  
 
    .equ OTG_FS_GLOBAL_FS_GAHBCFG, OTG_FS_GLOBAL_BASE + 0x8 @ (OTG_FS AHB configuration register
  OTG_FS_GAHBCFG) 
        .equ OTG_FS_GLOBAL_GINT_Shift, 0   @ bitWidth 1 (Global interrupt mask)  
        .equ OTG_FS_GLOBAL_TXFELVL_Shift, 7   @ bitWidth 1 (TxFIFO empty level)  
        .equ OTG_FS_GLOBAL_PTXFELVL_Shift, 8   @ bitWidth 1 (Periodic TxFIFO empty
  level)  
 
    .equ OTG_FS_GLOBAL_FS_GUSBCFG, OTG_FS_GLOBAL_BASE + 0xC @ (OTG_FS USB configuration register
  OTG_FS_GUSBCFG) 
        .equ OTG_FS_GLOBAL_TOCAL_Shift, 0   @ bitWidth 3 (FS timeout calibration)  
        .equ OTG_FS_GLOBAL_PHYSEL_Shift, 6   @ bitWidth 1 (Full Speed serial transceiver
  select)  
        .equ OTG_FS_GLOBAL_SRPCAP_Shift, 8   @ bitWidth 1 (SRP-capable)  
        .equ OTG_FS_GLOBAL_HNPCAP_Shift, 9   @ bitWidth 1 (HNP-capable)  
        .equ OTG_FS_GLOBAL_TRDT_Shift, 10   @ bitWidth 4 (USB turnaround time)  
        .equ OTG_FS_GLOBAL_FHMOD_Shift, 29   @ bitWidth 1 (Force host mode)  
        .equ OTG_FS_GLOBAL_FDMOD_Shift, 30   @ bitWidth 1 (Force device mode)  
        .equ OTG_FS_GLOBAL_CTXPKT_Shift, 31   @ bitWidth 1 (Corrupt Tx packet)  
 
    .equ OTG_FS_GLOBAL_FS_GRSTCTL, OTG_FS_GLOBAL_BASE + 0x10 @ (OTG_FS reset register
  OTG_FS_GRSTCTL) 
        .equ OTG_FS_GLOBAL_CSRST_Shift, 0   @ bitWidth 1 (Core soft reset)  
        .equ OTG_FS_GLOBAL_HSRST_Shift, 1   @ bitWidth 1 (HCLK soft reset)  
        .equ OTG_FS_GLOBAL_FCRST_Shift, 2   @ bitWidth 1 (Host frame counter reset)  
        .equ OTG_FS_GLOBAL_RXFFLSH_Shift, 4   @ bitWidth 1 (RxFIFO flush)  
        .equ OTG_FS_GLOBAL_TXFFLSH_Shift, 5   @ bitWidth 1 (TxFIFO flush)  
        .equ OTG_FS_GLOBAL_TXFNUM_Shift, 6   @ bitWidth 5 (TxFIFO number)  
        .equ OTG_FS_GLOBAL_AHBIDL_Shift, 31   @ bitWidth 1 (AHB master idle)  
 
    .equ OTG_FS_GLOBAL_FS_GINTSTS, OTG_FS_GLOBAL_BASE + 0x14 @ (OTG_FS core interrupt register
  OTG_FS_GINTSTS) 
        .equ OTG_FS_GLOBAL_CMOD_Shift, 0   @ bitWidth 1 (Current mode of operation)  
        .equ OTG_FS_GLOBAL_MMIS_Shift, 1   @ bitWidth 1 (Mode mismatch interrupt)  
        .equ OTG_FS_GLOBAL_OTGINT_Shift, 2   @ bitWidth 1 (OTG interrupt)  
        .equ OTG_FS_GLOBAL_SOF_Shift, 3   @ bitWidth 1 (Start of frame)  
        .equ OTG_FS_GLOBAL_RXFLVL_Shift, 4   @ bitWidth 1 (RxFIFO non-empty)  
        .equ OTG_FS_GLOBAL_NPTXFE_Shift, 5   @ bitWidth 1 (Non-periodic TxFIFO empty)  
        .equ OTG_FS_GLOBAL_GINAKEFF_Shift, 6   @ bitWidth 1 (Global IN non-periodic NAK
  effective)  
        .equ OTG_FS_GLOBAL_GOUTNAKEFF_Shift, 7   @ bitWidth 1 (Global OUT NAK effective)  
        .equ OTG_FS_GLOBAL_ESUSP_Shift, 10   @ bitWidth 1 (Early suspend)  
        .equ OTG_FS_GLOBAL_USBSUSP_Shift, 11   @ bitWidth 1 (USB suspend)  
        .equ OTG_FS_GLOBAL_USBRST_Shift, 12   @ bitWidth 1 (USB reset)  
        .equ OTG_FS_GLOBAL_ENUMDNE_Shift, 13   @ bitWidth 1 (Enumeration done)  
        .equ OTG_FS_GLOBAL_ISOODRP_Shift, 14   @ bitWidth 1 (Isochronous OUT packet dropped
  interrupt)  
        .equ OTG_FS_GLOBAL_EOPF_Shift, 15   @ bitWidth 1 (End of periodic frame
  interrupt)  
        .equ OTG_FS_GLOBAL_IEPINT_Shift, 18   @ bitWidth 1 (IN endpoint interrupt)  
        .equ OTG_FS_GLOBAL_OEPINT_Shift, 19   @ bitWidth 1 (OUT endpoint interrupt)  
        .equ OTG_FS_GLOBAL_IISOIXFR_Shift, 20   @ bitWidth 1 (Incomplete isochronous IN
  transfer)  
        .equ OTG_FS_GLOBAL_IPXFR_INCOMPISOOUT_Shift, 21   @ bitWidth 1 (Incomplete periodic transferHost
  mode/Incomplete isochronous OUT transferDevice
  mode)  
        .equ OTG_FS_GLOBAL_HPRTINT_Shift, 24   @ bitWidth 1 (Host port interrupt)  
        .equ OTG_FS_GLOBAL_HCINT_Shift, 25   @ bitWidth 1 (Host channels interrupt)  
        .equ OTG_FS_GLOBAL_PTXFE_Shift, 26   @ bitWidth 1 (Periodic TxFIFO empty)  
        .equ OTG_FS_GLOBAL_CIDSCHG_Shift, 28   @ bitWidth 1 (Connector ID status change)  
        .equ OTG_FS_GLOBAL_DISCINT_Shift, 29   @ bitWidth 1 (Disconnect detected
  interrupt)  
        .equ OTG_FS_GLOBAL_SRQINT_Shift, 30   @ bitWidth 1 (Session request/new session detected
  interrupt)  
        .equ OTG_FS_GLOBAL_WKUPINT_Shift, 31   @ bitWidth 1 (Resume/remote wakeup detected
  interrupt)  
 
    .equ OTG_FS_GLOBAL_FS_GINTMSK, OTG_FS_GLOBAL_BASE + 0x18 @ (OTG_FS interrupt mask register
  OTG_FS_GINTMSK) 
        .equ OTG_FS_GLOBAL_MMISM_Shift, 1   @ bitWidth 1 (Mode mismatch interrupt
  mask)  
        .equ OTG_FS_GLOBAL_OTGINT_Shift, 2   @ bitWidth 1 (OTG interrupt mask)  
        .equ OTG_FS_GLOBAL_SOFM_Shift, 3   @ bitWidth 1 (Start of frame mask)  
        .equ OTG_FS_GLOBAL_RXFLVLM_Shift, 4   @ bitWidth 1 (Receive FIFO non-empty
  mask)  
        .equ OTG_FS_GLOBAL_NPTXFEM_Shift, 5   @ bitWidth 1 (Non-periodic TxFIFO empty
  mask)  
        .equ OTG_FS_GLOBAL_GINAKEFFM_Shift, 6   @ bitWidth 1 (Global non-periodic IN NAK effective
  mask)  
        .equ OTG_FS_GLOBAL_GONAKEFFM_Shift, 7   @ bitWidth 1 (Global OUT NAK effective
  mask)  
        .equ OTG_FS_GLOBAL_ESUSPM_Shift, 10   @ bitWidth 1 (Early suspend mask)  
        .equ OTG_FS_GLOBAL_USBSUSPM_Shift, 11   @ bitWidth 1 (USB suspend mask)  
        .equ OTG_FS_GLOBAL_USBRST_Shift, 12   @ bitWidth 1 (USB reset mask)  
        .equ OTG_FS_GLOBAL_ENUMDNEM_Shift, 13   @ bitWidth 1 (Enumeration done mask)  
        .equ OTG_FS_GLOBAL_ISOODRPM_Shift, 14   @ bitWidth 1 (Isochronous OUT packet dropped interrupt
  mask)  
        .equ OTG_FS_GLOBAL_EOPFM_Shift, 15   @ bitWidth 1 (End of periodic frame interrupt
  mask)  
        .equ OTG_FS_GLOBAL_EPMISM_Shift, 17   @ bitWidth 1 (Endpoint mismatch interrupt
  mask)  
        .equ OTG_FS_GLOBAL_IEPINT_Shift, 18   @ bitWidth 1 (IN endpoints interrupt
  mask)  
        .equ OTG_FS_GLOBAL_OEPINT_Shift, 19   @ bitWidth 1 (OUT endpoints interrupt
  mask)  
        .equ OTG_FS_GLOBAL_IISOIXFRM_Shift, 20   @ bitWidth 1 (Incomplete isochronous IN transfer
  mask)  
        .equ OTG_FS_GLOBAL_IPXFRM_IISOOXFRM_Shift, 21   @ bitWidth 1 (Incomplete periodic transfer maskHost
  mode/Incomplete isochronous OUT transfer maskDevice
  mode)  
        .equ OTG_FS_GLOBAL_PRTIM_Shift, 24   @ bitWidth 1 (Host port interrupt mask)  
        .equ OTG_FS_GLOBAL_HCIM_Shift, 25   @ bitWidth 1 (Host channels interrupt
  mask)  
        .equ OTG_FS_GLOBAL_PTXFEM_Shift, 26   @ bitWidth 1 (Periodic TxFIFO empty mask)  
        .equ OTG_FS_GLOBAL_CIDSCHGM_Shift, 28   @ bitWidth 1 (Connector ID status change
  mask)  
        .equ OTG_FS_GLOBAL_DISCINT_Shift, 29   @ bitWidth 1 (Disconnect detected interrupt
  mask)  
        .equ OTG_FS_GLOBAL_SRQIM_Shift, 30   @ bitWidth 1 (Session request/new session detected
  interrupt mask)  
        .equ OTG_FS_GLOBAL_WUIM_Shift, 31   @ bitWidth 1 (Resume/remote wakeup detected interrupt
  mask)  
 
    .equ OTG_FS_GLOBAL_FS_GRXSTSR_Device, OTG_FS_GLOBAL_BASE + 0x1C @ (OTG_FS Receive status debug readDevice
  mode) 
        .equ OTG_FS_GLOBAL_EPNUM_Shift, 0   @ bitWidth 4 (Endpoint number)  
        .equ OTG_FS_GLOBAL_BCNT_Shift, 4   @ bitWidth 11 (Byte count)  
        .equ OTG_FS_GLOBAL_DPID_Shift, 15   @ bitWidth 2 (Data PID)  
        .equ OTG_FS_GLOBAL_PKTSTS_Shift, 17   @ bitWidth 4 (Packet status)  
        .equ OTG_FS_GLOBAL_FRMNUM_Shift, 21   @ bitWidth 4 (Frame number)  
 
    .equ OTG_FS_GLOBAL_FS_GRXSTSR_Host, OTG_FS_GLOBAL_BASE + 0x1C @ (OTG_FS Receive status debug readHost
  mode) 
        .equ OTG_FS_GLOBAL_EPNUM_Shift, 0   @ bitWidth 4 (Endpoint number)  
        .equ OTG_FS_GLOBAL_BCNT_Shift, 4   @ bitWidth 11 (Byte count)  
        .equ OTG_FS_GLOBAL_DPID_Shift, 15   @ bitWidth 2 (Data PID)  
        .equ OTG_FS_GLOBAL_PKTSTS_Shift, 17   @ bitWidth 4 (Packet status)  
        .equ OTG_FS_GLOBAL_FRMNUM_Shift, 21   @ bitWidth 4 (Frame number)  
 
    .equ OTG_FS_GLOBAL_FS_GRXFSIZ, OTG_FS_GLOBAL_BASE + 0x24 @ (OTG_FS Receive FIFO size register
  OTG_FS_GRXFSIZ) 
        .equ OTG_FS_GLOBAL_RXFD_Shift, 0   @ bitWidth 16 (RxFIFO depth)  
 
    .equ OTG_FS_GLOBAL_FS_GNPTXFSIZ_Device, OTG_FS_GLOBAL_BASE + 0x28 @ (OTG_FS non-periodic transmit FIFO size
  register Device mode) 
        .equ OTG_FS_GLOBAL_TX0FSA_Shift, 0   @ bitWidth 16 (Endpoint 0 transmit RAM start
  address)  
        .equ OTG_FS_GLOBAL_TX0FD_Shift, 16   @ bitWidth 16 (Endpoint 0 TxFIFO depth)  
 
    .equ OTG_FS_GLOBAL_FS_GNPTXFSIZ_Host, OTG_FS_GLOBAL_BASE + 0x28 @ (OTG_FS non-periodic transmit FIFO size
  register Host mode) 
        .equ OTG_FS_GLOBAL_NPTXFSA_Shift, 0   @ bitWidth 16 (Non-periodic transmit RAM start
  address)  
        .equ OTG_FS_GLOBAL_NPTXFD_Shift, 16   @ bitWidth 16 (Non-periodic TxFIFO depth)  
 
    .equ OTG_FS_GLOBAL_FS_GNPTXSTS, OTG_FS_GLOBAL_BASE + 0x2C @ (OTG_FS non-periodic transmit FIFO/queue
  status register OTG_FS_GNPTXSTS) 
        .equ OTG_FS_GLOBAL_NPTXFSAV_Shift, 0   @ bitWidth 16 (Non-periodic TxFIFO space
  available)  
        .equ OTG_FS_GLOBAL_NPTQXSAV_Shift, 16   @ bitWidth 8 (Non-periodic transmit request queue
  space available)  
        .equ OTG_FS_GLOBAL_NPTXQTOP_Shift, 24   @ bitWidth 7 (Top of the non-periodic transmit request
  queue)  
 
    .equ OTG_FS_GLOBAL_FS_GCCFG, OTG_FS_GLOBAL_BASE + 0x38 @ (OTG_FS general core configuration register
  OTG_FS_GCCFG) 
        .equ OTG_FS_GLOBAL_PWRDWN_Shift, 16   @ bitWidth 1 (Power down)  
        .equ OTG_FS_GLOBAL_VBUSASEN_Shift, 18   @ bitWidth 1 (Enable the VBUS sensing
  device)  
        .equ OTG_FS_GLOBAL_VBUSBSEN_Shift, 19   @ bitWidth 1 (Enable the VBUS sensing
  device)  
        .equ OTG_FS_GLOBAL_SOFOUTEN_Shift, 20   @ bitWidth 1 (SOF output enable)  
 
    .equ OTG_FS_GLOBAL_FS_CID, OTG_FS_GLOBAL_BASE + 0x3C @ (core ID register) 
        .equ OTG_FS_GLOBAL_PRODUCT_ID_Shift, 0   @ bitWidth 32 (Product ID field)  
 
    .equ OTG_FS_GLOBAL_FS_HPTXFSIZ, OTG_FS_GLOBAL_BASE + 0x100 @ (OTG_FS Host periodic transmit FIFO size
  register OTG_FS_HPTXFSIZ) 
        .equ OTG_FS_GLOBAL_PTXSA_Shift, 0   @ bitWidth 16 (Host periodic TxFIFO start
  address)  
        .equ OTG_FS_GLOBAL_PTXFSIZ_Shift, 16   @ bitWidth 16 (Host periodic TxFIFO depth)  
 
    .equ OTG_FS_GLOBAL_FS_DIEPTXF1, OTG_FS_GLOBAL_BASE + 0x104 @ (OTG_FS device IN endpoint transmit FIFO size
  register OTG_FS_DIEPTXF2) 
        .equ OTG_FS_GLOBAL_INEPTXSA_Shift, 0   @ bitWidth 16 (IN endpoint FIFO2 transmit RAM start
  address)  
        .equ OTG_FS_GLOBAL_INEPTXFD_Shift, 16   @ bitWidth 16 (IN endpoint TxFIFO depth)  
 
    .equ OTG_FS_GLOBAL_FS_DIEPTXF2, OTG_FS_GLOBAL_BASE + 0x108 @ (OTG_FS device IN endpoint transmit FIFO size
  register OTG_FS_DIEPTXF3) 
        .equ OTG_FS_GLOBAL_INEPTXSA_Shift, 0   @ bitWidth 16 (IN endpoint FIFO3 transmit RAM start
  address)  
        .equ OTG_FS_GLOBAL_INEPTXFD_Shift, 16   @ bitWidth 16 (IN endpoint TxFIFO depth)  
 
    .equ OTG_FS_GLOBAL_FS_DIEPTXF3, OTG_FS_GLOBAL_BASE + 0x10C @ (OTG_FS device IN endpoint transmit FIFO size
  register OTG_FS_DIEPTXF4) 
        .equ OTG_FS_GLOBAL_INEPTXSA_Shift, 0   @ bitWidth 16 (IN endpoint FIFO4 transmit RAM start
  address)  
        .equ OTG_FS_GLOBAL_INEPTXFD_Shift, 16   @ bitWidth 16 (IN endpoint TxFIFO depth)  
 

@=========================== OTG_FS_HOST ===========================@
.equ OTG_FS_HOST_BASE, 0x50000400 @ (USB on the go full speed) 
    .equ OTG_FS_HOST_FS_HCFG, OTG_FS_HOST_BASE + 0x0 @ (OTG_FS host configuration register
  OTG_FS_HCFG) 
        .equ OTG_FS_HOST_FSLSPCS_Shift, 0   @ bitWidth 2 (FS/LS PHY clock select)  
        .equ OTG_FS_HOST_FSLSS_Shift, 2   @ bitWidth 1 (FS- and LS-only support)  
 
    .equ OTG_FS_HOST_HFIR, OTG_FS_HOST_BASE + 0x4 @ (OTG_FS Host frame interval
  register) 
        .equ OTG_FS_HOST_FRIVL_Shift, 0   @ bitWidth 16 (Frame interval)  
 
    .equ OTG_FS_HOST_FS_HFNUM, OTG_FS_HOST_BASE + 0x8 @ (OTG_FS host frame number/frame time
  remaining register OTG_FS_HFNUM) 
        .equ OTG_FS_HOST_FRNUM_Shift, 0   @ bitWidth 16 (Frame number)  
        .equ OTG_FS_HOST_FTREM_Shift, 16   @ bitWidth 16 (Frame time remaining)  
 
    .equ OTG_FS_HOST_FS_HPTXSTS, OTG_FS_HOST_BASE + 0x10 @ (OTG_FS_Host periodic transmit FIFO/queue
  status register OTG_FS_HPTXSTS) 
        .equ OTG_FS_HOST_PTXFSAVL_Shift, 0   @ bitWidth 16 (Periodic transmit data FIFO space
  available)  
        .equ OTG_FS_HOST_PTXQSAV_Shift, 16   @ bitWidth 8 (Periodic transmit request queue space
  available)  
        .equ OTG_FS_HOST_PTXQTOP_Shift, 24   @ bitWidth 8 (Top of the periodic transmit request
  queue)  
 
    .equ OTG_FS_HOST_HAINT, OTG_FS_HOST_BASE + 0x14 @ (OTG_FS Host all channels interrupt
  register) 
        .equ OTG_FS_HOST_HAINT_Shift, 0   @ bitWidth 16 (Channel interrupts)  
 
    .equ OTG_FS_HOST_HAINTMSK, OTG_FS_HOST_BASE + 0x18 @ (OTG_FS host all channels interrupt mask
  register) 
        .equ OTG_FS_HOST_HAINTM_Shift, 0   @ bitWidth 16 (Channel interrupt mask)  
 
    .equ OTG_FS_HOST_FS_HPRT, OTG_FS_HOST_BASE + 0x40 @ (OTG_FS host port control and status register
  OTG_FS_HPRT) 
        .equ OTG_FS_HOST_PCSTS_Shift, 0   @ bitWidth 1 (Port connect status)  
        .equ OTG_FS_HOST_PCDET_Shift, 1   @ bitWidth 1 (Port connect detected)  
        .equ OTG_FS_HOST_PENA_Shift, 2   @ bitWidth 1 (Port enable)  
        .equ OTG_FS_HOST_PENCHNG_Shift, 3   @ bitWidth 1 (Port enable/disable change)  
        .equ OTG_FS_HOST_POCA_Shift, 4   @ bitWidth 1 (Port overcurrent active)  
        .equ OTG_FS_HOST_POCCHNG_Shift, 5   @ bitWidth 1 (Port overcurrent change)  
        .equ OTG_FS_HOST_PRES_Shift, 6   @ bitWidth 1 (Port resume)  
        .equ OTG_FS_HOST_PSUSP_Shift, 7   @ bitWidth 1 (Port suspend)  
        .equ OTG_FS_HOST_PRST_Shift, 8   @ bitWidth 1 (Port reset)  
        .equ OTG_FS_HOST_PLSTS_Shift, 10   @ bitWidth 2 (Port line status)  
        .equ OTG_FS_HOST_PPWR_Shift, 12   @ bitWidth 1 (Port power)  
        .equ OTG_FS_HOST_PTCTL_Shift, 13   @ bitWidth 4 (Port test control)  
        .equ OTG_FS_HOST_PSPD_Shift, 17   @ bitWidth 2 (Port speed)  
 
    .equ OTG_FS_HOST_FS_HCCHAR0, OTG_FS_HOST_BASE + 0x100 @ (OTG_FS host channel-0 characteristics
  register OTG_FS_HCCHAR0) 
        .equ OTG_FS_HOST_MPSIZ_Shift, 0   @ bitWidth 11 (Maximum packet size)  
        .equ OTG_FS_HOST_EPNUM_Shift, 11   @ bitWidth 4 (Endpoint number)  
        .equ OTG_FS_HOST_EPDIR_Shift, 15   @ bitWidth 1 (Endpoint direction)  
        .equ OTG_FS_HOST_LSDEV_Shift, 17   @ bitWidth 1 (Low-speed device)  
        .equ OTG_FS_HOST_EPTYP_Shift, 18   @ bitWidth 2 (Endpoint type)  
        .equ OTG_FS_HOST_MCNT_Shift, 20   @ bitWidth 2 (Multicount)  
        .equ OTG_FS_HOST_DAD_Shift, 22   @ bitWidth 7 (Device address)  
        .equ OTG_FS_HOST_ODDFRM_Shift, 29   @ bitWidth 1 (Odd frame)  
        .equ OTG_FS_HOST_CHDIS_Shift, 30   @ bitWidth 1 (Channel disable)  
        .equ OTG_FS_HOST_CHENA_Shift, 31   @ bitWidth 1 (Channel enable)  
 
    .equ OTG_FS_HOST_FS_HCCHAR1, OTG_FS_HOST_BASE + 0x120 @ (OTG_FS host channel-1 characteristics
  register OTG_FS_HCCHAR1) 
        .equ OTG_FS_HOST_MPSIZ_Shift, 0   @ bitWidth 11 (Maximum packet size)  
        .equ OTG_FS_HOST_EPNUM_Shift, 11   @ bitWidth 4 (Endpoint number)  
        .equ OTG_FS_HOST_EPDIR_Shift, 15   @ bitWidth 1 (Endpoint direction)  
        .equ OTG_FS_HOST_LSDEV_Shift, 17   @ bitWidth 1 (Low-speed device)  
        .equ OTG_FS_HOST_EPTYP_Shift, 18   @ bitWidth 2 (Endpoint type)  
        .equ OTG_FS_HOST_MCNT_Shift, 20   @ bitWidth 2 (Multicount)  
        .equ OTG_FS_HOST_DAD_Shift, 22   @ bitWidth 7 (Device address)  
        .equ OTG_FS_HOST_ODDFRM_Shift, 29   @ bitWidth 1 (Odd frame)  
        .equ OTG_FS_HOST_CHDIS_Shift, 30   @ bitWidth 1 (Channel disable)  
        .equ OTG_FS_HOST_CHENA_Shift, 31   @ bitWidth 1 (Channel enable)  
 
    .equ OTG_FS_HOST_FS_HCCHAR2, OTG_FS_HOST_BASE + 0x140 @ (OTG_FS host channel-2 characteristics
  register OTG_FS_HCCHAR2) 
        .equ OTG_FS_HOST_MPSIZ_Shift, 0   @ bitWidth 11 (Maximum packet size)  
        .equ OTG_FS_HOST_EPNUM_Shift, 11   @ bitWidth 4 (Endpoint number)  
        .equ OTG_FS_HOST_EPDIR_Shift, 15   @ bitWidth 1 (Endpoint direction)  
        .equ OTG_FS_HOST_LSDEV_Shift, 17   @ bitWidth 1 (Low-speed device)  
        .equ OTG_FS_HOST_EPTYP_Shift, 18   @ bitWidth 2 (Endpoint type)  
        .equ OTG_FS_HOST_MCNT_Shift, 20   @ bitWidth 2 (Multicount)  
        .equ OTG_FS_HOST_DAD_Shift, 22   @ bitWidth 7 (Device address)  
        .equ OTG_FS_HOST_ODDFRM_Shift, 29   @ bitWidth 1 (Odd frame)  
        .equ OTG_FS_HOST_CHDIS_Shift, 30   @ bitWidth 1 (Channel disable)  
        .equ OTG_FS_HOST_CHENA_Shift, 31   @ bitWidth 1 (Channel enable)  
 
    .equ OTG_FS_HOST_FS_HCCHAR3, OTG_FS_HOST_BASE + 0x160 @ (OTG_FS host channel-3 characteristics
  register OTG_FS_HCCHAR3) 
        .equ OTG_FS_HOST_MPSIZ_Shift, 0   @ bitWidth 11 (Maximum packet size)  
        .equ OTG_FS_HOST_EPNUM_Shift, 11   @ bitWidth 4 (Endpoint number)  
        .equ OTG_FS_HOST_EPDIR_Shift, 15   @ bitWidth 1 (Endpoint direction)  
        .equ OTG_FS_HOST_LSDEV_Shift, 17   @ bitWidth 1 (Low-speed device)  
        .equ OTG_FS_HOST_EPTYP_Shift, 18   @ bitWidth 2 (Endpoint type)  
        .equ OTG_FS_HOST_MCNT_Shift, 20   @ bitWidth 2 (Multicount)  
        .equ OTG_FS_HOST_DAD_Shift, 22   @ bitWidth 7 (Device address)  
        .equ OTG_FS_HOST_ODDFRM_Shift, 29   @ bitWidth 1 (Odd frame)  
        .equ OTG_FS_HOST_CHDIS_Shift, 30   @ bitWidth 1 (Channel disable)  
        .equ OTG_FS_HOST_CHENA_Shift, 31   @ bitWidth 1 (Channel enable)  
 
    .equ OTG_FS_HOST_FS_HCCHAR4, OTG_FS_HOST_BASE + 0x180 @ (OTG_FS host channel-4 characteristics
  register OTG_FS_HCCHAR4) 
        .equ OTG_FS_HOST_MPSIZ_Shift, 0   @ bitWidth 11 (Maximum packet size)  
        .equ OTG_FS_HOST_EPNUM_Shift, 11   @ bitWidth 4 (Endpoint number)  
        .equ OTG_FS_HOST_EPDIR_Shift, 15   @ bitWidth 1 (Endpoint direction)  
        .equ OTG_FS_HOST_LSDEV_Shift, 17   @ bitWidth 1 (Low-speed device)  
        .equ OTG_FS_HOST_EPTYP_Shift, 18   @ bitWidth 2 (Endpoint type)  
        .equ OTG_FS_HOST_MCNT_Shift, 20   @ bitWidth 2 (Multicount)  
        .equ OTG_FS_HOST_DAD_Shift, 22   @ bitWidth 7 (Device address)  
        .equ OTG_FS_HOST_ODDFRM_Shift, 29   @ bitWidth 1 (Odd frame)  
        .equ OTG_FS_HOST_CHDIS_Shift, 30   @ bitWidth 1 (Channel disable)  
        .equ OTG_FS_HOST_CHENA_Shift, 31   @ bitWidth 1 (Channel enable)  
 
    .equ OTG_FS_HOST_FS_HCCHAR5, OTG_FS_HOST_BASE + 0x1A0 @ (OTG_FS host channel-5 characteristics
  register OTG_FS_HCCHAR5) 
        .equ OTG_FS_HOST_MPSIZ_Shift, 0   @ bitWidth 11 (Maximum packet size)  
        .equ OTG_FS_HOST_EPNUM_Shift, 11   @ bitWidth 4 (Endpoint number)  
        .equ OTG_FS_HOST_EPDIR_Shift, 15   @ bitWidth 1 (Endpoint direction)  
        .equ OTG_FS_HOST_LSDEV_Shift, 17   @ bitWidth 1 (Low-speed device)  
        .equ OTG_FS_HOST_EPTYP_Shift, 18   @ bitWidth 2 (Endpoint type)  
        .equ OTG_FS_HOST_MCNT_Shift, 20   @ bitWidth 2 (Multicount)  
        .equ OTG_FS_HOST_DAD_Shift, 22   @ bitWidth 7 (Device address)  
        .equ OTG_FS_HOST_ODDFRM_Shift, 29   @ bitWidth 1 (Odd frame)  
        .equ OTG_FS_HOST_CHDIS_Shift, 30   @ bitWidth 1 (Channel disable)  
        .equ OTG_FS_HOST_CHENA_Shift, 31   @ bitWidth 1 (Channel enable)  
 
    .equ OTG_FS_HOST_FS_HCCHAR6, OTG_FS_HOST_BASE + 0x1C0 @ (OTG_FS host channel-6 characteristics
  register OTG_FS_HCCHAR6) 
        .equ OTG_FS_HOST_MPSIZ_Shift, 0   @ bitWidth 11 (Maximum packet size)  
        .equ OTG_FS_HOST_EPNUM_Shift, 11   @ bitWidth 4 (Endpoint number)  
        .equ OTG_FS_HOST_EPDIR_Shift, 15   @ bitWidth 1 (Endpoint direction)  
        .equ OTG_FS_HOST_LSDEV_Shift, 17   @ bitWidth 1 (Low-speed device)  
        .equ OTG_FS_HOST_EPTYP_Shift, 18   @ bitWidth 2 (Endpoint type)  
        .equ OTG_FS_HOST_MCNT_Shift, 20   @ bitWidth 2 (Multicount)  
        .equ OTG_FS_HOST_DAD_Shift, 22   @ bitWidth 7 (Device address)  
        .equ OTG_FS_HOST_ODDFRM_Shift, 29   @ bitWidth 1 (Odd frame)  
        .equ OTG_FS_HOST_CHDIS_Shift, 30   @ bitWidth 1 (Channel disable)  
        .equ OTG_FS_HOST_CHENA_Shift, 31   @ bitWidth 1 (Channel enable)  
 
    .equ OTG_FS_HOST_FS_HCCHAR7, OTG_FS_HOST_BASE + 0x1E0 @ (OTG_FS host channel-7 characteristics
  register OTG_FS_HCCHAR7) 
        .equ OTG_FS_HOST_MPSIZ_Shift, 0   @ bitWidth 11 (Maximum packet size)  
        .equ OTG_FS_HOST_EPNUM_Shift, 11   @ bitWidth 4 (Endpoint number)  
        .equ OTG_FS_HOST_EPDIR_Shift, 15   @ bitWidth 1 (Endpoint direction)  
        .equ OTG_FS_HOST_LSDEV_Shift, 17   @ bitWidth 1 (Low-speed device)  
        .equ OTG_FS_HOST_EPTYP_Shift, 18   @ bitWidth 2 (Endpoint type)  
        .equ OTG_FS_HOST_MCNT_Shift, 20   @ bitWidth 2 (Multicount)  
        .equ OTG_FS_HOST_DAD_Shift, 22   @ bitWidth 7 (Device address)  
        .equ OTG_FS_HOST_ODDFRM_Shift, 29   @ bitWidth 1 (Odd frame)  
        .equ OTG_FS_HOST_CHDIS_Shift, 30   @ bitWidth 1 (Channel disable)  
        .equ OTG_FS_HOST_CHENA_Shift, 31   @ bitWidth 1 (Channel enable)  
 
    .equ OTG_FS_HOST_FS_HCINT0, OTG_FS_HOST_BASE + 0x108 @ (OTG_FS host channel-0 interrupt register
  OTG_FS_HCINT0) 
        .equ OTG_FS_HOST_XFRC_Shift, 0   @ bitWidth 1 (Transfer completed)  
        .equ OTG_FS_HOST_CHH_Shift, 1   @ bitWidth 1 (Channel halted)  
        .equ OTG_FS_HOST_STALL_Shift, 3   @ bitWidth 1 (STALL response received
  interrupt)  
        .equ OTG_FS_HOST_NAK_Shift, 4   @ bitWidth 1 (NAK response received
  interrupt)  
        .equ OTG_FS_HOST_ACK_Shift, 5   @ bitWidth 1 (ACK response received/transmitted
  interrupt)  
        .equ OTG_FS_HOST_TXERR_Shift, 7   @ bitWidth 1 (Transaction error)  
        .equ OTG_FS_HOST_BBERR_Shift, 8   @ bitWidth 1 (Babble error)  
        .equ OTG_FS_HOST_FRMOR_Shift, 9   @ bitWidth 1 (Frame overrun)  
        .equ OTG_FS_HOST_DTERR_Shift, 10   @ bitWidth 1 (Data toggle error)  
 
    .equ OTG_FS_HOST_FS_HCINT1, OTG_FS_HOST_BASE + 0x128 @ (OTG_FS host channel-1 interrupt register
  OTG_FS_HCINT1) 
        .equ OTG_FS_HOST_XFRC_Shift, 0   @ bitWidth 1 (Transfer completed)  
        .equ OTG_FS_HOST_CHH_Shift, 1   @ bitWidth 1 (Channel halted)  
        .equ OTG_FS_HOST_STALL_Shift, 3   @ bitWidth 1 (STALL response received
  interrupt)  
        .equ OTG_FS_HOST_NAK_Shift, 4   @ bitWidth 1 (NAK response received
  interrupt)  
        .equ OTG_FS_HOST_ACK_Shift, 5   @ bitWidth 1 (ACK response received/transmitted
  interrupt)  
        .equ OTG_FS_HOST_TXERR_Shift, 7   @ bitWidth 1 (Transaction error)  
        .equ OTG_FS_HOST_BBERR_Shift, 8   @ bitWidth 1 (Babble error)  
        .equ OTG_FS_HOST_FRMOR_Shift, 9   @ bitWidth 1 (Frame overrun)  
        .equ OTG_FS_HOST_DTERR_Shift, 10   @ bitWidth 1 (Data toggle error)  
 
    .equ OTG_FS_HOST_FS_HCINT2, OTG_FS_HOST_BASE + 0x148 @ (OTG_FS host channel-2 interrupt register
  OTG_FS_HCINT2) 
        .equ OTG_FS_HOST_XFRC_Shift, 0   @ bitWidth 1 (Transfer completed)  
        .equ OTG_FS_HOST_CHH_Shift, 1   @ bitWidth 1 (Channel halted)  
        .equ OTG_FS_HOST_STALL_Shift, 3   @ bitWidth 1 (STALL response received
  interrupt)  
        .equ OTG_FS_HOST_NAK_Shift, 4   @ bitWidth 1 (NAK response received
  interrupt)  
        .equ OTG_FS_HOST_ACK_Shift, 5   @ bitWidth 1 (ACK response received/transmitted
  interrupt)  
        .equ OTG_FS_HOST_TXERR_Shift, 7   @ bitWidth 1 (Transaction error)  
        .equ OTG_FS_HOST_BBERR_Shift, 8   @ bitWidth 1 (Babble error)  
        .equ OTG_FS_HOST_FRMOR_Shift, 9   @ bitWidth 1 (Frame overrun)  
        .equ OTG_FS_HOST_DTERR_Shift, 10   @ bitWidth 1 (Data toggle error)  
 
    .equ OTG_FS_HOST_FS_HCINT3, OTG_FS_HOST_BASE + 0x168 @ (OTG_FS host channel-3 interrupt register
  OTG_FS_HCINT3) 
        .equ OTG_FS_HOST_XFRC_Shift, 0   @ bitWidth 1 (Transfer completed)  
        .equ OTG_FS_HOST_CHH_Shift, 1   @ bitWidth 1 (Channel halted)  
        .equ OTG_FS_HOST_STALL_Shift, 3   @ bitWidth 1 (STALL response received
  interrupt)  
        .equ OTG_FS_HOST_NAK_Shift, 4   @ bitWidth 1 (NAK response received
  interrupt)  
        .equ OTG_FS_HOST_ACK_Shift, 5   @ bitWidth 1 (ACK response received/transmitted
  interrupt)  
        .equ OTG_FS_HOST_TXERR_Shift, 7   @ bitWidth 1 (Transaction error)  
        .equ OTG_FS_HOST_BBERR_Shift, 8   @ bitWidth 1 (Babble error)  
        .equ OTG_FS_HOST_FRMOR_Shift, 9   @ bitWidth 1 (Frame overrun)  
        .equ OTG_FS_HOST_DTERR_Shift, 10   @ bitWidth 1 (Data toggle error)  
 
    .equ OTG_FS_HOST_FS_HCINT4, OTG_FS_HOST_BASE + 0x188 @ (OTG_FS host channel-4 interrupt register
  OTG_FS_HCINT4) 
        .equ OTG_FS_HOST_XFRC_Shift, 0   @ bitWidth 1 (Transfer completed)  
        .equ OTG_FS_HOST_CHH_Shift, 1   @ bitWidth 1 (Channel halted)  
        .equ OTG_FS_HOST_STALL_Shift, 3   @ bitWidth 1 (STALL response received
  interrupt)  
        .equ OTG_FS_HOST_NAK_Shift, 4   @ bitWidth 1 (NAK response received
  interrupt)  
        .equ OTG_FS_HOST_ACK_Shift, 5   @ bitWidth 1 (ACK response received/transmitted
  interrupt)  
        .equ OTG_FS_HOST_TXERR_Shift, 7   @ bitWidth 1 (Transaction error)  
        .equ OTG_FS_HOST_BBERR_Shift, 8   @ bitWidth 1 (Babble error)  
        .equ OTG_FS_HOST_FRMOR_Shift, 9   @ bitWidth 1 (Frame overrun)  
        .equ OTG_FS_HOST_DTERR_Shift, 10   @ bitWidth 1 (Data toggle error)  
 
    .equ OTG_FS_HOST_FS_HCINT5, OTG_FS_HOST_BASE + 0x1A8 @ (OTG_FS host channel-5 interrupt register
  OTG_FS_HCINT5) 
        .equ OTG_FS_HOST_XFRC_Shift, 0   @ bitWidth 1 (Transfer completed)  
        .equ OTG_FS_HOST_CHH_Shift, 1   @ bitWidth 1 (Channel halted)  
        .equ OTG_FS_HOST_STALL_Shift, 3   @ bitWidth 1 (STALL response received
  interrupt)  
        .equ OTG_FS_HOST_NAK_Shift, 4   @ bitWidth 1 (NAK response received
  interrupt)  
        .equ OTG_FS_HOST_ACK_Shift, 5   @ bitWidth 1 (ACK response received/transmitted
  interrupt)  
        .equ OTG_FS_HOST_TXERR_Shift, 7   @ bitWidth 1 (Transaction error)  
        .equ OTG_FS_HOST_BBERR_Shift, 8   @ bitWidth 1 (Babble error)  
        .equ OTG_FS_HOST_FRMOR_Shift, 9   @ bitWidth 1 (Frame overrun)  
        .equ OTG_FS_HOST_DTERR_Shift, 10   @ bitWidth 1 (Data toggle error)  
 
    .equ OTG_FS_HOST_FS_HCINT6, OTG_FS_HOST_BASE + 0x1C8 @ (OTG_FS host channel-6 interrupt register
  OTG_FS_HCINT6) 
        .equ OTG_FS_HOST_XFRC_Shift, 0   @ bitWidth 1 (Transfer completed)  
        .equ OTG_FS_HOST_CHH_Shift, 1   @ bitWidth 1 (Channel halted)  
        .equ OTG_FS_HOST_STALL_Shift, 3   @ bitWidth 1 (STALL response received
  interrupt)  
        .equ OTG_FS_HOST_NAK_Shift, 4   @ bitWidth 1 (NAK response received
  interrupt)  
        .equ OTG_FS_HOST_ACK_Shift, 5   @ bitWidth 1 (ACK response received/transmitted
  interrupt)  
        .equ OTG_FS_HOST_TXERR_Shift, 7   @ bitWidth 1 (Transaction error)  
        .equ OTG_FS_HOST_BBERR_Shift, 8   @ bitWidth 1 (Babble error)  
        .equ OTG_FS_HOST_FRMOR_Shift, 9   @ bitWidth 1 (Frame overrun)  
        .equ OTG_FS_HOST_DTERR_Shift, 10   @ bitWidth 1 (Data toggle error)  
 
    .equ OTG_FS_HOST_FS_HCINT7, OTG_FS_HOST_BASE + 0x1E8 @ (OTG_FS host channel-7 interrupt register
  OTG_FS_HCINT7) 
        .equ OTG_FS_HOST_XFRC_Shift, 0   @ bitWidth 1 (Transfer completed)  
        .equ OTG_FS_HOST_CHH_Shift, 1   @ bitWidth 1 (Channel halted)  
        .equ OTG_FS_HOST_STALL_Shift, 3   @ bitWidth 1 (STALL response received
  interrupt)  
        .equ OTG_FS_HOST_NAK_Shift, 4   @ bitWidth 1 (NAK response received
  interrupt)  
        .equ OTG_FS_HOST_ACK_Shift, 5   @ bitWidth 1 (ACK response received/transmitted
  interrupt)  
        .equ OTG_FS_HOST_TXERR_Shift, 7   @ bitWidth 1 (Transaction error)  
        .equ OTG_FS_HOST_BBERR_Shift, 8   @ bitWidth 1 (Babble error)  
        .equ OTG_FS_HOST_FRMOR_Shift, 9   @ bitWidth 1 (Frame overrun)  
        .equ OTG_FS_HOST_DTERR_Shift, 10   @ bitWidth 1 (Data toggle error)  
 
    .equ OTG_FS_HOST_FS_HCINTMSK0, OTG_FS_HOST_BASE + 0x10C @ (OTG_FS host channel-0 mask register
  OTG_FS_HCINTMSK0) 
        .equ OTG_FS_HOST_XFRCM_Shift, 0   @ bitWidth 1 (Transfer completed mask)  
        .equ OTG_FS_HOST_CHHM_Shift, 1   @ bitWidth 1 (Channel halted mask)  
        .equ OTG_FS_HOST_STALLM_Shift, 3   @ bitWidth 1 (STALL response received interrupt
  mask)  
        .equ OTG_FS_HOST_NAKM_Shift, 4   @ bitWidth 1 (NAK response received interrupt
  mask)  
        .equ OTG_FS_HOST_ACKM_Shift, 5   @ bitWidth 1 (ACK response received/transmitted
  interrupt mask)  
        .equ OTG_FS_HOST_NYET_Shift, 6   @ bitWidth 1 (response received interrupt
  mask)  
        .equ OTG_FS_HOST_TXERRM_Shift, 7   @ bitWidth 1 (Transaction error mask)  
        .equ OTG_FS_HOST_BBERRM_Shift, 8   @ bitWidth 1 (Babble error mask)  
        .equ OTG_FS_HOST_FRMORM_Shift, 9   @ bitWidth 1 (Frame overrun mask)  
        .equ OTG_FS_HOST_DTERRM_Shift, 10   @ bitWidth 1 (Data toggle error mask)  
 
    .equ OTG_FS_HOST_FS_HCINTMSK1, OTG_FS_HOST_BASE + 0x12C @ (OTG_FS host channel-1 mask register
  OTG_FS_HCINTMSK1) 
        .equ OTG_FS_HOST_XFRCM_Shift, 0   @ bitWidth 1 (Transfer completed mask)  
        .equ OTG_FS_HOST_CHHM_Shift, 1   @ bitWidth 1 (Channel halted mask)  
        .equ OTG_FS_HOST_STALLM_Shift, 3   @ bitWidth 1 (STALL response received interrupt
  mask)  
        .equ OTG_FS_HOST_NAKM_Shift, 4   @ bitWidth 1 (NAK response received interrupt
  mask)  
        .equ OTG_FS_HOST_ACKM_Shift, 5   @ bitWidth 1 (ACK response received/transmitted
  interrupt mask)  
        .equ OTG_FS_HOST_NYET_Shift, 6   @ bitWidth 1 (response received interrupt
  mask)  
        .equ OTG_FS_HOST_TXERRM_Shift, 7   @ bitWidth 1 (Transaction error mask)  
        .equ OTG_FS_HOST_BBERRM_Shift, 8   @ bitWidth 1 (Babble error mask)  
        .equ OTG_FS_HOST_FRMORM_Shift, 9   @ bitWidth 1 (Frame overrun mask)  
        .equ OTG_FS_HOST_DTERRM_Shift, 10   @ bitWidth 1 (Data toggle error mask)  
 
    .equ OTG_FS_HOST_FS_HCINTMSK2, OTG_FS_HOST_BASE + 0x14C @ (OTG_FS host channel-2 mask register
  OTG_FS_HCINTMSK2) 
        .equ OTG_FS_HOST_XFRCM_Shift, 0   @ bitWidth 1 (Transfer completed mask)  
        .equ OTG_FS_HOST_CHHM_Shift, 1   @ bitWidth 1 (Channel halted mask)  
        .equ OTG_FS_HOST_STALLM_Shift, 3   @ bitWidth 1 (STALL response received interrupt
  mask)  
        .equ OTG_FS_HOST_NAKM_Shift, 4   @ bitWidth 1 (NAK response received interrupt
  mask)  
        .equ OTG_FS_HOST_ACKM_Shift, 5   @ bitWidth 1 (ACK response received/transmitted
  interrupt mask)  
        .equ OTG_FS_HOST_NYET_Shift, 6   @ bitWidth 1 (response received interrupt
  mask)  
        .equ OTG_FS_HOST_TXERRM_Shift, 7   @ bitWidth 1 (Transaction error mask)  
        .equ OTG_FS_HOST_BBERRM_Shift, 8   @ bitWidth 1 (Babble error mask)  
        .equ OTG_FS_HOST_FRMORM_Shift, 9   @ bitWidth 1 (Frame overrun mask)  
        .equ OTG_FS_HOST_DTERRM_Shift, 10   @ bitWidth 1 (Data toggle error mask)  
 
    .equ OTG_FS_HOST_FS_HCINTMSK3, OTG_FS_HOST_BASE + 0x16C @ (OTG_FS host channel-3 mask register
  OTG_FS_HCINTMSK3) 
        .equ OTG_FS_HOST_XFRCM_Shift, 0   @ bitWidth 1 (Transfer completed mask)  
        .equ OTG_FS_HOST_CHHM_Shift, 1   @ bitWidth 1 (Channel halted mask)  
        .equ OTG_FS_HOST_STALLM_Shift, 3   @ bitWidth 1 (STALL response received interrupt
  mask)  
        .equ OTG_FS_HOST_NAKM_Shift, 4   @ bitWidth 1 (NAK response received interrupt
  mask)  
        .equ OTG_FS_HOST_ACKM_Shift, 5   @ bitWidth 1 (ACK response received/transmitted
  interrupt mask)  
        .equ OTG_FS_HOST_NYET_Shift, 6   @ bitWidth 1 (response received interrupt
  mask)  
        .equ OTG_FS_HOST_TXERRM_Shift, 7   @ bitWidth 1 (Transaction error mask)  
        .equ OTG_FS_HOST_BBERRM_Shift, 8   @ bitWidth 1 (Babble error mask)  
        .equ OTG_FS_HOST_FRMORM_Shift, 9   @ bitWidth 1 (Frame overrun mask)  
        .equ OTG_FS_HOST_DTERRM_Shift, 10   @ bitWidth 1 (Data toggle error mask)  
 
    .equ OTG_FS_HOST_FS_HCINTMSK4, OTG_FS_HOST_BASE + 0x18C @ (OTG_FS host channel-4 mask register
  OTG_FS_HCINTMSK4) 
        .equ OTG_FS_HOST_XFRCM_Shift, 0   @ bitWidth 1 (Transfer completed mask)  
        .equ OTG_FS_HOST_CHHM_Shift, 1   @ bitWidth 1 (Channel halted mask)  
        .equ OTG_FS_HOST_STALLM_Shift, 3   @ bitWidth 1 (STALL response received interrupt
  mask)  
        .equ OTG_FS_HOST_NAKM_Shift, 4   @ bitWidth 1 (NAK response received interrupt
  mask)  
        .equ OTG_FS_HOST_ACKM_Shift, 5   @ bitWidth 1 (ACK response received/transmitted
  interrupt mask)  
        .equ OTG_FS_HOST_NYET_Shift, 6   @ bitWidth 1 (response received interrupt
  mask)  
        .equ OTG_FS_HOST_TXERRM_Shift, 7   @ bitWidth 1 (Transaction error mask)  
        .equ OTG_FS_HOST_BBERRM_Shift, 8   @ bitWidth 1 (Babble error mask)  
        .equ OTG_FS_HOST_FRMORM_Shift, 9   @ bitWidth 1 (Frame overrun mask)  
        .equ OTG_FS_HOST_DTERRM_Shift, 10   @ bitWidth 1 (Data toggle error mask)  
 
    .equ OTG_FS_HOST_FS_HCINTMSK5, OTG_FS_HOST_BASE + 0x1AC @ (OTG_FS host channel-5 mask register
  OTG_FS_HCINTMSK5) 
        .equ OTG_FS_HOST_XFRCM_Shift, 0   @ bitWidth 1 (Transfer completed mask)  
        .equ OTG_FS_HOST_CHHM_Shift, 1   @ bitWidth 1 (Channel halted mask)  
        .equ OTG_FS_HOST_STALLM_Shift, 3   @ bitWidth 1 (STALL response received interrupt
  mask)  
        .equ OTG_FS_HOST_NAKM_Shift, 4   @ bitWidth 1 (NAK response received interrupt
  mask)  
        .equ OTG_FS_HOST_ACKM_Shift, 5   @ bitWidth 1 (ACK response received/transmitted
  interrupt mask)  
        .equ OTG_FS_HOST_NYET_Shift, 6   @ bitWidth 1 (response received interrupt
  mask)  
        .equ OTG_FS_HOST_TXERRM_Shift, 7   @ bitWidth 1 (Transaction error mask)  
        .equ OTG_FS_HOST_BBERRM_Shift, 8   @ bitWidth 1 (Babble error mask)  
        .equ OTG_FS_HOST_FRMORM_Shift, 9   @ bitWidth 1 (Frame overrun mask)  
        .equ OTG_FS_HOST_DTERRM_Shift, 10   @ bitWidth 1 (Data toggle error mask)  
 
    .equ OTG_FS_HOST_FS_HCINTMSK6, OTG_FS_HOST_BASE + 0x1CC @ (OTG_FS host channel-6 mask register
  OTG_FS_HCINTMSK6) 
        .equ OTG_FS_HOST_XFRCM_Shift, 0   @ bitWidth 1 (Transfer completed mask)  
        .equ OTG_FS_HOST_CHHM_Shift, 1   @ bitWidth 1 (Channel halted mask)  
        .equ OTG_FS_HOST_STALLM_Shift, 3   @ bitWidth 1 (STALL response received interrupt
  mask)  
        .equ OTG_FS_HOST_NAKM_Shift, 4   @ bitWidth 1 (NAK response received interrupt
  mask)  
        .equ OTG_FS_HOST_ACKM_Shift, 5   @ bitWidth 1 (ACK response received/transmitted
  interrupt mask)  
        .equ OTG_FS_HOST_NYET_Shift, 6   @ bitWidth 1 (response received interrupt
  mask)  
        .equ OTG_FS_HOST_TXERRM_Shift, 7   @ bitWidth 1 (Transaction error mask)  
        .equ OTG_FS_HOST_BBERRM_Shift, 8   @ bitWidth 1 (Babble error mask)  
        .equ OTG_FS_HOST_FRMORM_Shift, 9   @ bitWidth 1 (Frame overrun mask)  
        .equ OTG_FS_HOST_DTERRM_Shift, 10   @ bitWidth 1 (Data toggle error mask)  
 
    .equ OTG_FS_HOST_FS_HCINTMSK7, OTG_FS_HOST_BASE + 0x1EC @ (OTG_FS host channel-7 mask register
  OTG_FS_HCINTMSK7) 
        .equ OTG_FS_HOST_XFRCM_Shift, 0   @ bitWidth 1 (Transfer completed mask)  
        .equ OTG_FS_HOST_CHHM_Shift, 1   @ bitWidth 1 (Channel halted mask)  
        .equ OTG_FS_HOST_STALLM_Shift, 3   @ bitWidth 1 (STALL response received interrupt
  mask)  
        .equ OTG_FS_HOST_NAKM_Shift, 4   @ bitWidth 1 (NAK response received interrupt
  mask)  
        .equ OTG_FS_HOST_ACKM_Shift, 5   @ bitWidth 1 (ACK response received/transmitted
  interrupt mask)  
        .equ OTG_FS_HOST_NYET_Shift, 6   @ bitWidth 1 (response received interrupt
  mask)  
        .equ OTG_FS_HOST_TXERRM_Shift, 7   @ bitWidth 1 (Transaction error mask)  
        .equ OTG_FS_HOST_BBERRM_Shift, 8   @ bitWidth 1 (Babble error mask)  
        .equ OTG_FS_HOST_FRMORM_Shift, 9   @ bitWidth 1 (Frame overrun mask)  
        .equ OTG_FS_HOST_DTERRM_Shift, 10   @ bitWidth 1 (Data toggle error mask)  
 
    .equ OTG_FS_HOST_FS_HCTSIZ0, OTG_FS_HOST_BASE + 0x110 @ (OTG_FS host channel-0 transfer size
  register) 
        .equ OTG_FS_HOST_XFRSIZ_Shift, 0   @ bitWidth 19 (Transfer size)  
        .equ OTG_FS_HOST_PKTCNT_Shift, 19   @ bitWidth 10 (Packet count)  
        .equ OTG_FS_HOST_DPID_Shift, 29   @ bitWidth 2 (Data PID)  
 
    .equ OTG_FS_HOST_FS_HCTSIZ1, OTG_FS_HOST_BASE + 0x130 @ (OTG_FS host channel-1 transfer size
  register) 
        .equ OTG_FS_HOST_XFRSIZ_Shift, 0   @ bitWidth 19 (Transfer size)  
        .equ OTG_FS_HOST_PKTCNT_Shift, 19   @ bitWidth 10 (Packet count)  
        .equ OTG_FS_HOST_DPID_Shift, 29   @ bitWidth 2 (Data PID)  
 
    .equ OTG_FS_HOST_FS_HCTSIZ2, OTG_FS_HOST_BASE + 0x150 @ (OTG_FS host channel-2 transfer size
  register) 
        .equ OTG_FS_HOST_XFRSIZ_Shift, 0   @ bitWidth 19 (Transfer size)  
        .equ OTG_FS_HOST_PKTCNT_Shift, 19   @ bitWidth 10 (Packet count)  
        .equ OTG_FS_HOST_DPID_Shift, 29   @ bitWidth 2 (Data PID)  
 
    .equ OTG_FS_HOST_FS_HCTSIZ3, OTG_FS_HOST_BASE + 0x170 @ (OTG_FS host channel-3 transfer size
  register) 
        .equ OTG_FS_HOST_XFRSIZ_Shift, 0   @ bitWidth 19 (Transfer size)  
        .equ OTG_FS_HOST_PKTCNT_Shift, 19   @ bitWidth 10 (Packet count)  
        .equ OTG_FS_HOST_DPID_Shift, 29   @ bitWidth 2 (Data PID)  
 
    .equ OTG_FS_HOST_FS_HCTSIZ4, OTG_FS_HOST_BASE + 0x190 @ (OTG_FS host channel-x transfer size
  register) 
        .equ OTG_FS_HOST_XFRSIZ_Shift, 0   @ bitWidth 19 (Transfer size)  
        .equ OTG_FS_HOST_PKTCNT_Shift, 19   @ bitWidth 10 (Packet count)  
        .equ OTG_FS_HOST_DPID_Shift, 29   @ bitWidth 2 (Data PID)  
 
    .equ OTG_FS_HOST_FS_HCTSIZ5, OTG_FS_HOST_BASE + 0x1B0 @ (OTG_FS host channel-5 transfer size
  register) 
        .equ OTG_FS_HOST_XFRSIZ_Shift, 0   @ bitWidth 19 (Transfer size)  
        .equ OTG_FS_HOST_PKTCNT_Shift, 19   @ bitWidth 10 (Packet count)  
        .equ OTG_FS_HOST_DPID_Shift, 29   @ bitWidth 2 (Data PID)  
 
    .equ OTG_FS_HOST_FS_HCTSIZ6, OTG_FS_HOST_BASE + 0x1D0 @ (OTG_FS host channel-6 transfer size
  register) 
        .equ OTG_FS_HOST_XFRSIZ_Shift, 0   @ bitWidth 19 (Transfer size)  
        .equ OTG_FS_HOST_PKTCNT_Shift, 19   @ bitWidth 10 (Packet count)  
        .equ OTG_FS_HOST_DPID_Shift, 29   @ bitWidth 2 (Data PID)  
 
    .equ OTG_FS_HOST_FS_HCTSIZ7, OTG_FS_HOST_BASE + 0x1F0 @ (OTG_FS host channel-7 transfer size
  register) 
        .equ OTG_FS_HOST_XFRSIZ_Shift, 0   @ bitWidth 19 (Transfer size)  
        .equ OTG_FS_HOST_PKTCNT_Shift, 19   @ bitWidth 10 (Packet count)  
        .equ OTG_FS_HOST_DPID_Shift, 29   @ bitWidth 2 (Data PID)  
 

@=========================== OTG_FS_PWRCLK ===========================@
.equ OTG_FS_PWRCLK_BASE, 0x50000E00 @ (USB on the go full speed) 
    .equ OTG_FS_PWRCLK_FS_PCGCCTL, OTG_FS_PWRCLK_BASE + 0x0 @ (OTG_FS power and clock gating control
  register) 
        .equ OTG_FS_PWRCLK_STPPCLK_Shift, 0   @ bitWidth 1 (Stop PHY clock)  
        .equ OTG_FS_PWRCLK_GATEHCLK_Shift, 1   @ bitWidth 1 (Gate HCLK)  
        .equ OTG_FS_PWRCLK_PHYSUSP_Shift, 4   @ bitWidth 1 (PHY Suspended)  
 

@=========================== PWR ===========================@
.equ PWR_BASE, 0x40007000 @ (Power control) 
    .equ PWR_CR, PWR_BASE + 0x0 @ (power control register) 
        .equ PWR_VOS_Shift, 14   @ bitWidth 2 (Regulator voltage scaling output
  selection)  
        .equ PWR_ADCDC1_Shift, 13   @ bitWidth 1 (ADCDC1)  
        .equ PWR_FPDS_Shift, 9   @ bitWidth 1 (Flash power down in Stop
  mode)  
        .equ PWR_DBP_Shift, 8   @ bitWidth 1 (Disable backup domain write
  protection)  
        .equ PWR_PLS_Shift, 5   @ bitWidth 3 (PVD level selection)  
        .equ PWR_PVDE_Shift, 4   @ bitWidth 1 (Power voltage detector
  enable)  
        .equ PWR_CSBF_Shift, 3   @ bitWidth 1 (Clear standby flag)  
        .equ PWR_CWUF_Shift, 2   @ bitWidth 1 (Clear wakeup flag)  
        .equ PWR_PDDS_Shift, 1   @ bitWidth 1 (Power down deepsleep)  
        .equ PWR_LPDS_Shift, 0   @ bitWidth 1 (Low-power deep sleep)  
 
    .equ PWR_CSR, PWR_BASE + 0x4 @ (power control/status register) 
        .equ PWR_WUF_Shift, 0   @ bitWidth 1 (Wakeup flag)  
        .equ PWR_SBF_Shift, 1   @ bitWidth 1 (Standby flag)  
        .equ PWR_PVDO_Shift, 2   @ bitWidth 1 (PVD output)  
        .equ PWR_BRR_Shift, 3   @ bitWidth 1 (Backup regulator ready)  
        .equ PWR_EWUP_Shift, 8   @ bitWidth 1 (Enable WKUP pin)  
        .equ PWR_BRE_Shift, 9   @ bitWidth 1 (Backup regulator enable)  
        .equ PWR_VOSRDY_Shift, 14   @ bitWidth 1 (Regulator voltage scaling output
  selection ready bit)  
 

@=========================== RCC ===========================@
.equ RCC_BASE, 0x40023800 @ (Reset and clock control) 
    .equ RCC_CR, RCC_BASE + 0x0 @ (clock control register) 
        .equ RCC_PLLI2SRDY_Shift, 27   @ bitWidth 1 (PLLI2S clock ready flag)  
        .equ RCC_PLLI2SON_Shift, 26   @ bitWidth 1 (PLLI2S enable)  
        .equ RCC_PLLRDY_Shift, 25   @ bitWidth 1 (Main PLL PLL clock ready
  flag)  
        .equ RCC_PLLON_Shift, 24   @ bitWidth 1 (Main PLL PLL enable)  
        .equ RCC_CSSON_Shift, 19   @ bitWidth 1 (Clock security system
  enable)  
        .equ RCC_HSEBYP_Shift, 18   @ bitWidth 1 (HSE clock bypass)  
        .equ RCC_HSERDY_Shift, 17   @ bitWidth 1 (HSE clock ready flag)  
        .equ RCC_HSEON_Shift, 16   @ bitWidth 1 (HSE clock enable)  
        .equ RCC_HSICAL_Shift, 8   @ bitWidth 8 (Internal high-speed clock
  calibration)  
        .equ RCC_HSITRIM_Shift, 3   @ bitWidth 5 (Internal high-speed clock
  trimming)  
        .equ RCC_HSIRDY_Shift, 1   @ bitWidth 1 (Internal high-speed clock ready
  flag)  
        .equ RCC_HSION_Shift, 0   @ bitWidth 1 (Internal high-speed clock
  enable)  
 
    .equ RCC_PLLCFGR, RCC_BASE + 0x4 @ (PLL configuration register) 
        .equ RCC_PLLQ3_Shift, 27   @ bitWidth 1 (Main PLL PLL division factor for USB
  OTG FS, SDIO and random number generator
  clocks)  
        .equ RCC_PLLQ2_Shift, 26   @ bitWidth 1 (Main PLL PLL division factor for USB
  OTG FS, SDIO and random number generator
  clocks)  
        .equ RCC_PLLQ1_Shift, 25   @ bitWidth 1 (Main PLL PLL division factor for USB
  OTG FS, SDIO and random number generator
  clocks)  
        .equ RCC_PLLQ0_Shift, 24   @ bitWidth 1 (Main PLL PLL division factor for USB
  OTG FS, SDIO and random number generator
  clocks)  
        .equ RCC_PLLSRC_Shift, 22   @ bitWidth 1 (Main PLLPLL and audio PLL PLLI2S
  entry clock source)  
        .equ RCC_PLLP1_Shift, 17   @ bitWidth 1 (Main PLL PLL division factor for main
  system clock)  
        .equ RCC_PLLP0_Shift, 16   @ bitWidth 1 (Main PLL PLL division factor for main
  system clock)  
        .equ RCC_PLLN8_Shift, 14   @ bitWidth 1 (Main PLL PLL multiplication factor for
  VCO)  
        .equ RCC_PLLN7_Shift, 13   @ bitWidth 1 (Main PLL PLL multiplication factor for
  VCO)  
        .equ RCC_PLLN6_Shift, 12   @ bitWidth 1 (Main PLL PLL multiplication factor for
  VCO)  
        .equ RCC_PLLN5_Shift, 11   @ bitWidth 1 (Main PLL PLL multiplication factor for
  VCO)  
        .equ RCC_PLLN4_Shift, 10   @ bitWidth 1 (Main PLL PLL multiplication factor for
  VCO)  
        .equ RCC_PLLN3_Shift, 9   @ bitWidth 1 (Main PLL PLL multiplication factor for
  VCO)  
        .equ RCC_PLLN2_Shift, 8   @ bitWidth 1 (Main PLL PLL multiplication factor for
  VCO)  
        .equ RCC_PLLN1_Shift, 7   @ bitWidth 1 (Main PLL PLL multiplication factor for
  VCO)  
        .equ RCC_PLLN0_Shift, 6   @ bitWidth 1 (Main PLL PLL multiplication factor for
  VCO)  
        .equ RCC_PLLM5_Shift, 5   @ bitWidth 1 (Division factor for the main PLL PLL
  and audio PLL PLLI2S input clock)  
        .equ RCC_PLLM4_Shift, 4   @ bitWidth 1 (Division factor for the main PLL PLL
  and audio PLL PLLI2S input clock)  
        .equ RCC_PLLM3_Shift, 3   @ bitWidth 1 (Division factor for the main PLL PLL
  and audio PLL PLLI2S input clock)  
        .equ RCC_PLLM2_Shift, 2   @ bitWidth 1 (Division factor for the main PLL PLL
  and audio PLL PLLI2S input clock)  
        .equ RCC_PLLM1_Shift, 1   @ bitWidth 1 (Division factor for the main PLL PLL
  and audio PLL PLLI2S input clock)  
        .equ RCC_PLLM0_Shift, 0   @ bitWidth 1 (Division factor for the main PLL PLL
  and audio PLL PLLI2S input clock)  
 
    .equ RCC_CFGR, RCC_BASE + 0x8 @ (clock configuration register) 
        .equ RCC_MCO2_Shift, 30   @ bitWidth 2 (Microcontroller clock output
  2)  
        .equ RCC_MCO2PRE_Shift, 27   @ bitWidth 3 (MCO2 prescaler)  
        .equ RCC_MCO1PRE_Shift, 24   @ bitWidth 3 (MCO1 prescaler)  
        .equ RCC_I2SSRC_Shift, 23   @ bitWidth 1 (I2S clock selection)  
        .equ RCC_MCO1_Shift, 21   @ bitWidth 2 (Microcontroller clock output
  1)  
        .equ RCC_RTCPRE_Shift, 16   @ bitWidth 5 (HSE division factor for RTC
  clock)  
        .equ RCC_PPRE2_Shift, 13   @ bitWidth 3 (APB high-speed prescaler
  APB2)  
        .equ RCC_PPRE1_Shift, 10   @ bitWidth 3 (APB Low speed prescaler
  APB1)  
        .equ RCC_HPRE_Shift, 4   @ bitWidth 4 (AHB prescaler)  
        .equ RCC_SWS1_Shift, 3   @ bitWidth 1 (System clock switch status)  
        .equ RCC_SWS0_Shift, 2   @ bitWidth 1 (System clock switch status)  
        .equ RCC_SW1_Shift, 1   @ bitWidth 1 (System clock switch)  
        .equ RCC_SW0_Shift, 0   @ bitWidth 1 (System clock switch)  
 
    .equ RCC_CIR, RCC_BASE + 0xC @ (clock interrupt register) 
        .equ RCC_CSSC_Shift, 23   @ bitWidth 1 (Clock security system interrupt
  clear)  
        .equ RCC_PLLI2SRDYC_Shift, 21   @ bitWidth 1 (PLLI2S ready interrupt
  clear)  
        .equ RCC_PLLRDYC_Shift, 20   @ bitWidth 1 (Main PLLPLL ready interrupt
  clear)  
        .equ RCC_HSERDYC_Shift, 19   @ bitWidth 1 (HSE ready interrupt clear)  
        .equ RCC_HSIRDYC_Shift, 18   @ bitWidth 1 (HSI ready interrupt clear)  
        .equ RCC_LSERDYC_Shift, 17   @ bitWidth 1 (LSE ready interrupt clear)  
        .equ RCC_LSIRDYC_Shift, 16   @ bitWidth 1 (LSI ready interrupt clear)  
        .equ RCC_PLLI2SRDYIE_Shift, 13   @ bitWidth 1 (PLLI2S ready interrupt
  enable)  
        .equ RCC_PLLRDYIE_Shift, 12   @ bitWidth 1 (Main PLL PLL ready interrupt
  enable)  
        .equ RCC_HSERDYIE_Shift, 11   @ bitWidth 1 (HSE ready interrupt enable)  
        .equ RCC_HSIRDYIE_Shift, 10   @ bitWidth 1 (HSI ready interrupt enable)  
        .equ RCC_LSERDYIE_Shift, 9   @ bitWidth 1 (LSE ready interrupt enable)  
        .equ RCC_LSIRDYIE_Shift, 8   @ bitWidth 1 (LSI ready interrupt enable)  
        .equ RCC_CSSF_Shift, 7   @ bitWidth 1 (Clock security system interrupt
  flag)  
        .equ RCC_PLLI2SRDYF_Shift, 5   @ bitWidth 1 (PLLI2S ready interrupt
  flag)  
        .equ RCC_PLLRDYF_Shift, 4   @ bitWidth 1 (Main PLL PLL ready interrupt
  flag)  
        .equ RCC_HSERDYF_Shift, 3   @ bitWidth 1 (HSE ready interrupt flag)  
        .equ RCC_HSIRDYF_Shift, 2   @ bitWidth 1 (HSI ready interrupt flag)  
        .equ RCC_LSERDYF_Shift, 1   @ bitWidth 1 (LSE ready interrupt flag)  
        .equ RCC_LSIRDYF_Shift, 0   @ bitWidth 1 (LSI ready interrupt flag)  
 
    .equ RCC_AHB1RSTR, RCC_BASE + 0x10 @ (AHB1 peripheral reset register) 
        .equ RCC_DMA2RST_Shift, 22   @ bitWidth 1 (DMA2 reset)  
        .equ RCC_DMA1RST_Shift, 21   @ bitWidth 1 (DMA2 reset)  
        .equ RCC_CRCRST_Shift, 12   @ bitWidth 1 (CRC reset)  
        .equ RCC_GPIOHRST_Shift, 7   @ bitWidth 1 (IO port H reset)  
        .equ RCC_GPIOERST_Shift, 4   @ bitWidth 1 (IO port E reset)  
        .equ RCC_GPIODRST_Shift, 3   @ bitWidth 1 (IO port D reset)  
        .equ RCC_GPIOCRST_Shift, 2   @ bitWidth 1 (IO port C reset)  
        .equ RCC_GPIOBRST_Shift, 1   @ bitWidth 1 (IO port B reset)  
        .equ RCC_GPIOARST_Shift, 0   @ bitWidth 1 (IO port A reset)  
 
    .equ RCC_AHB2RSTR, RCC_BASE + 0x14 @ (AHB2 peripheral reset register) 
        .equ RCC_OTGFSRST_Shift, 7   @ bitWidth 1 (USB OTG FS module reset)  
 
    .equ RCC_APB1RSTR, RCC_BASE + 0x20 @ (APB1 peripheral reset register) 
        .equ RCC_PWRRST_Shift, 28   @ bitWidth 1 (Power interface reset)  
        .equ RCC_I2C3RST_Shift, 23   @ bitWidth 1 (I2C3 reset)  
        .equ RCC_I2C2RST_Shift, 22   @ bitWidth 1 (I2C 2 reset)  
        .equ RCC_I2C1RST_Shift, 21   @ bitWidth 1 (I2C 1 reset)  
        .equ RCC_UART2RST_Shift, 17   @ bitWidth 1 (USART 2 reset)  
        .equ RCC_SPI3RST_Shift, 15   @ bitWidth 1 (SPI 3 reset)  
        .equ RCC_SPI2RST_Shift, 14   @ bitWidth 1 (SPI 2 reset)  
        .equ RCC_WWDGRST_Shift, 11   @ bitWidth 1 (Window watchdog reset)  
        .equ RCC_TIM5RST_Shift, 3   @ bitWidth 1 (TIM5 reset)  
        .equ RCC_TIM4RST_Shift, 2   @ bitWidth 1 (TIM4 reset)  
        .equ RCC_TIM3RST_Shift, 1   @ bitWidth 1 (TIM3 reset)  
        .equ RCC_TIM2RST_Shift, 0   @ bitWidth 1 (TIM2 reset)  
 
    .equ RCC_APB2RSTR, RCC_BASE + 0x24 @ (APB2 peripheral reset register) 
        .equ RCC_TIM11RST_Shift, 18   @ bitWidth 1 (TIM11 reset)  
        .equ RCC_TIM10RST_Shift, 17   @ bitWidth 1 (TIM10 reset)  
        .equ RCC_TIM9RST_Shift, 16   @ bitWidth 1 (TIM9 reset)  
        .equ RCC_SYSCFGRST_Shift, 14   @ bitWidth 1 (System configuration controller
  reset)  
        .equ RCC_SPI1RST_Shift, 12   @ bitWidth 1 (SPI 1 reset)  
        .equ RCC_SDIORST_Shift, 11   @ bitWidth 1 (SDIO reset)  
        .equ RCC_ADCRST_Shift, 8   @ bitWidth 1 (ADC interface reset common to all
  ADCs)  
        .equ RCC_USART6RST_Shift, 5   @ bitWidth 1 (USART6 reset)  
        .equ RCC_USART1RST_Shift, 4   @ bitWidth 1 (USART1 reset)  
        .equ RCC_TIM1RST_Shift, 0   @ bitWidth 1 (TIM1 reset)  
 
    .equ RCC_AHB1ENR, RCC_BASE + 0x30 @ (AHB1 peripheral clock register) 
        .equ RCC_DMA2EN_Shift, 22   @ bitWidth 1 (DMA2 clock enable)  
        .equ RCC_DMA1EN_Shift, 21   @ bitWidth 1 (DMA1 clock enable)  
        .equ RCC_CRCEN_Shift, 12   @ bitWidth 1 (CRC clock enable)  
        .equ RCC_GPIOHEN_Shift, 7   @ bitWidth 1 (IO port H clock enable)  
        .equ RCC_GPIOEEN_Shift, 4   @ bitWidth 1 (IO port E clock enable)  
        .equ RCC_GPIODEN_Shift, 3   @ bitWidth 1 (IO port D clock enable)  
        .equ RCC_GPIOCEN_Shift, 2   @ bitWidth 1 (IO port C clock enable)  
        .equ RCC_GPIOBEN_Shift, 1   @ bitWidth 1 (IO port B clock enable)  
        .equ RCC_GPIOAEN_Shift, 0   @ bitWidth 1 (IO port A clock enable)  
 
    .equ RCC_AHB2ENR, RCC_BASE + 0x34 @ (AHB2 peripheral clock enable
  register) 
        .equ RCC_OTGFSEN_Shift, 7   @ bitWidth 1 (USB OTG FS clock enable)  
 
    .equ RCC_APB1ENR, RCC_BASE + 0x40 @ (APB1 peripheral clock enable
  register) 
        .equ RCC_PWREN_Shift, 28   @ bitWidth 1 (Power interface clock
  enable)  
        .equ RCC_I2C3EN_Shift, 23   @ bitWidth 1 (I2C3 clock enable)  
        .equ RCC_I2C2EN_Shift, 22   @ bitWidth 1 (I2C2 clock enable)  
        .equ RCC_I2C1EN_Shift, 21   @ bitWidth 1 (I2C1 clock enable)  
        .equ RCC_USART2EN_Shift, 17   @ bitWidth 1 (USART 2 clock enable)  
        .equ RCC_SPI3EN_Shift, 15   @ bitWidth 1 (SPI3 clock enable)  
        .equ RCC_SPI2EN_Shift, 14   @ bitWidth 1 (SPI2 clock enable)  
        .equ RCC_WWDGEN_Shift, 11   @ bitWidth 1 (Window watchdog clock
  enable)  
        .equ RCC_TIM5EN_Shift, 3   @ bitWidth 1 (TIM5 clock enable)  
        .equ RCC_TIM4EN_Shift, 2   @ bitWidth 1 (TIM4 clock enable)  
        .equ RCC_TIM3EN_Shift, 1   @ bitWidth 1 (TIM3 clock enable)  
        .equ RCC_TIM2EN_Shift, 0   @ bitWidth 1 (TIM2 clock enable)  
 
    .equ RCC_APB2ENR, RCC_BASE + 0x44 @ (APB2 peripheral clock enable
  register) 
        .equ RCC_TIM1EN_Shift, 0   @ bitWidth 1 (TIM1 clock enable)  
        .equ RCC_USART1EN_Shift, 4   @ bitWidth 1 (USART1 clock enable)  
        .equ RCC_USART6EN_Shift, 5   @ bitWidth 1 (USART6 clock enable)  
        .equ RCC_ADC1EN_Shift, 8   @ bitWidth 1 (ADC1 clock enable)  
        .equ RCC_SDIOEN_Shift, 11   @ bitWidth 1 (SDIO clock enable)  
        .equ RCC_SPI1EN_Shift, 12   @ bitWidth 1 (SPI1 clock enable)  
        .equ RCC_SPI4EN_Shift, 13   @ bitWidth 1 (SPI4 clock enable)  
        .equ RCC_SYSCFGEN_Shift, 14   @ bitWidth 1 (System configuration controller clock
  enable)  
        .equ RCC_TIM9EN_Shift, 16   @ bitWidth 1 (TIM9 clock enable)  
        .equ RCC_TIM10EN_Shift, 17   @ bitWidth 1 (TIM10 clock enable)  
        .equ RCC_TIM11EN_Shift, 18   @ bitWidth 1 (TIM11 clock enable)  
 
    .equ RCC_AHB1LPENR, RCC_BASE + 0x50 @ (AHB1 peripheral clock enable in low power
  mode register) 
        .equ RCC_DMA2LPEN_Shift, 22   @ bitWidth 1 (DMA2 clock enable during Sleep
  mode)  
        .equ RCC_DMA1LPEN_Shift, 21   @ bitWidth 1 (DMA1 clock enable during Sleep
  mode)  
        .equ RCC_SRAM1LPEN_Shift, 16   @ bitWidth 1 (SRAM 1interface clock enable during
  Sleep mode)  
        .equ RCC_FLITFLPEN_Shift, 15   @ bitWidth 1 (Flash interface clock enable during
  Sleep mode)  
        .equ RCC_CRCLPEN_Shift, 12   @ bitWidth 1 (CRC clock enable during Sleep
  mode)  
        .equ RCC_GPIOHLPEN_Shift, 7   @ bitWidth 1 (IO port H clock enable during Sleep
  mode)  
        .equ RCC_GPIOELPEN_Shift, 4   @ bitWidth 1 (IO port E clock enable during Sleep
  mode)  
        .equ RCC_GPIODLPEN_Shift, 3   @ bitWidth 1 (IO port D clock enable during Sleep
  mode)  
        .equ RCC_GPIOCLPEN_Shift, 2   @ bitWidth 1 (IO port C clock enable during Sleep
  mode)  
        .equ RCC_GPIOBLPEN_Shift, 1   @ bitWidth 1 (IO port B clock enable during Sleep
  mode)  
        .equ RCC_GPIOALPEN_Shift, 0   @ bitWidth 1 (IO port A clock enable during sleep
  mode)  
 
    .equ RCC_AHB2LPENR, RCC_BASE + 0x54 @ (AHB2 peripheral clock enable in low power
  mode register) 
        .equ RCC_OTGFSLPEN_Shift, 7   @ bitWidth 1 (USB OTG FS clock enable during Sleep
  mode)  
 
    .equ RCC_APB1LPENR, RCC_BASE + 0x60 @ (APB1 peripheral clock enable in low power
  mode register) 
        .equ RCC_PWRLPEN_Shift, 28   @ bitWidth 1 (Power interface clock enable during
  Sleep mode)  
        .equ RCC_I2C3LPEN_Shift, 23   @ bitWidth 1 (I2C3 clock enable during Sleep
  mode)  
        .equ RCC_I2C2LPEN_Shift, 22   @ bitWidth 1 (I2C2 clock enable during Sleep
  mode)  
        .equ RCC_I2C1LPEN_Shift, 21   @ bitWidth 1 (I2C1 clock enable during Sleep
  mode)  
        .equ RCC_USART2LPEN_Shift, 17   @ bitWidth 1 (USART2 clock enable during Sleep
  mode)  
        .equ RCC_SPI3LPEN_Shift, 15   @ bitWidth 1 (SPI3 clock enable during Sleep
  mode)  
        .equ RCC_SPI2LPEN_Shift, 14   @ bitWidth 1 (SPI2 clock enable during Sleep
  mode)  
        .equ RCC_WWDGLPEN_Shift, 11   @ bitWidth 1 (Window watchdog clock enable during
  Sleep mode)  
        .equ RCC_TIM5LPEN_Shift, 3   @ bitWidth 1 (TIM5 clock enable during Sleep
  mode)  
        .equ RCC_TIM4LPEN_Shift, 2   @ bitWidth 1 (TIM4 clock enable during Sleep
  mode)  
        .equ RCC_TIM3LPEN_Shift, 1   @ bitWidth 1 (TIM3 clock enable during Sleep
  mode)  
        .equ RCC_TIM2LPEN_Shift, 0   @ bitWidth 1 (TIM2 clock enable during Sleep
  mode)  
 
    .equ RCC_APB2LPENR, RCC_BASE + 0x64 @ (APB2 peripheral clock enabled in low power
  mode register) 
        .equ RCC_TIM1LPEN_Shift, 0   @ bitWidth 1 (TIM1 clock enable during Sleep
  mode)  
        .equ RCC_USART1LPEN_Shift, 4   @ bitWidth 1 (USART1 clock enable during Sleep
  mode)  
        .equ RCC_USART6LPEN_Shift, 5   @ bitWidth 1 (USART6 clock enable during Sleep
  mode)  
        .equ RCC_ADC1LPEN_Shift, 8   @ bitWidth 1 (ADC1 clock enable during Sleep
  mode)  
        .equ RCC_SDIOLPEN_Shift, 11   @ bitWidth 1 (SDIO clock enable during Sleep
  mode)  
        .equ RCC_SPI1LPEN_Shift, 12   @ bitWidth 1 (SPI 1 clock enable during Sleep
  mode)  
        .equ RCC_SPI4LPEN_Shift, 13   @ bitWidth 1 (SPI4 clock enable during Sleep
  mode)  
        .equ RCC_SYSCFGLPEN_Shift, 14   @ bitWidth 1 (System configuration controller clock
  enable during Sleep mode)  
        .equ RCC_TIM9LPEN_Shift, 16   @ bitWidth 1 (TIM9 clock enable during sleep
  mode)  
        .equ RCC_TIM10LPEN_Shift, 17   @ bitWidth 1 (TIM10 clock enable during Sleep
  mode)  
        .equ RCC_TIM11LPEN_Shift, 18   @ bitWidth 1 (TIM11 clock enable during Sleep
  mode)  
 
    .equ RCC_BDCR, RCC_BASE + 0x70 @ (Backup domain control register) 
        .equ RCC_BDRST_Shift, 16   @ bitWidth 1 (Backup domain software
  reset)  
        .equ RCC_RTCEN_Shift, 15   @ bitWidth 1 (RTC clock enable)  
        .equ RCC_RTCSEL1_Shift, 9   @ bitWidth 1 (RTC clock source selection)  
        .equ RCC_RTCSEL0_Shift, 8   @ bitWidth 1 (RTC clock source selection)  
        .equ RCC_LSEBYP_Shift, 2   @ bitWidth 1 (External low-speed oscillator
  bypass)  
        .equ RCC_LSERDY_Shift, 1   @ bitWidth 1 (External low-speed oscillator
  ready)  
        .equ RCC_LSEON_Shift, 0   @ bitWidth 1 (External low-speed oscillator
  enable)  
 
    .equ RCC_CSR, RCC_BASE + 0x74 @ (clock control & status
  register) 
        .equ RCC_LPWRRSTF_Shift, 31   @ bitWidth 1 (Low-power reset flag)  
        .equ RCC_WWDGRSTF_Shift, 30   @ bitWidth 1 (Window watchdog reset flag)  
        .equ RCC_WDGRSTF_Shift, 29   @ bitWidth 1 (Independent watchdog reset
  flag)  
        .equ RCC_SFTRSTF_Shift, 28   @ bitWidth 1 (Software reset flag)  
        .equ RCC_PORRSTF_Shift, 27   @ bitWidth 1 (POR/PDR reset flag)  
        .equ RCC_PADRSTF_Shift, 26   @ bitWidth 1 (PIN reset flag)  
        .equ RCC_BORRSTF_Shift, 25   @ bitWidth 1 (BOR reset flag)  
        .equ RCC_RMVF_Shift, 24   @ bitWidth 1 (Remove reset flag)  
        .equ RCC_LSIRDY_Shift, 1   @ bitWidth 1 (Internal low-speed oscillator
  ready)  
        .equ RCC_LSION_Shift, 0   @ bitWidth 1 (Internal low-speed oscillator
  enable)  
 
    .equ RCC_SSCGR, RCC_BASE + 0x80 @ (spread spectrum clock generation
  register) 
        .equ RCC_SSCGEN_Shift, 31   @ bitWidth 1 (Spread spectrum modulation
  enable)  
        .equ RCC_SPREADSEL_Shift, 30   @ bitWidth 1 (Spread Select)  
        .equ RCC_INCSTEP_Shift, 13   @ bitWidth 15 (Incrementation step)  
        .equ RCC_MODPER_Shift, 0   @ bitWidth 13 (Modulation period)  
 
    .equ RCC_PLLI2SCFGR, RCC_BASE + 0x84 @ (PLLI2S configuration register) 
        .equ RCC_PLLI2SRx_Shift, 28   @ bitWidth 3 (PLLI2S division factor for I2S
  clocks)  
        .equ RCC_PLLI2SNx_Shift, 6   @ bitWidth 9 (PLLI2S multiplication factor for
  VCO)  
 

@=========================== RTC ===========================@
.equ RTC_BASE, 0x40002800 @ (Real-time clock) 
    .equ RTC_TR, RTC_BASE + 0x0 @ (time register) 
        .equ RTC_PM_Shift, 22   @ bitWidth 1 (AM/PM notation)  
        .equ RTC_HT_Shift, 20   @ bitWidth 2 (Hour tens in BCD format)  
        .equ RTC_HU_Shift, 16   @ bitWidth 4 (Hour units in BCD format)  
        .equ RTC_MNT_Shift, 12   @ bitWidth 3 (Minute tens in BCD format)  
        .equ RTC_MNU_Shift, 8   @ bitWidth 4 (Minute units in BCD format)  
        .equ RTC_ST_Shift, 4   @ bitWidth 3 (Second tens in BCD format)  
        .equ RTC_SU_Shift, 0   @ bitWidth 4 (Second units in BCD format)  
 
    .equ RTC_DR, RTC_BASE + 0x4 @ (date register) 
        .equ RTC_YT_Shift, 20   @ bitWidth 4 (Year tens in BCD format)  
        .equ RTC_YU_Shift, 16   @ bitWidth 4 (Year units in BCD format)  
        .equ RTC_WDU_Shift, 13   @ bitWidth 3 (Week day units)  
        .equ RTC_MT_Shift, 12   @ bitWidth 1 (Month tens in BCD format)  
        .equ RTC_MU_Shift, 8   @ bitWidth 4 (Month units in BCD format)  
        .equ RTC_DT_Shift, 4   @ bitWidth 2 (Date tens in BCD format)  
        .equ RTC_DU_Shift, 0   @ bitWidth 4 (Date units in BCD format)  
 
    .equ RTC_CR, RTC_BASE + 0x8 @ (control register) 
        .equ RTC_COE_Shift, 23   @ bitWidth 1 (Calibration output enable)  
        .equ RTC_OSEL_Shift, 21   @ bitWidth 2 (Output selection)  
        .equ RTC_POL_Shift, 20   @ bitWidth 1 (Output polarity)  
        .equ RTC_COSEL_Shift, 19   @ bitWidth 1 (Calibration Output
  selection)  
        .equ RTC_BKP_Shift, 18   @ bitWidth 1 (Backup)  
        .equ RTC_SUB1H_Shift, 17   @ bitWidth 1 (Subtract 1 hour winter time
  change)  
        .equ RTC_ADD1H_Shift, 16   @ bitWidth 1 (Add 1 hour summer time
  change)  
        .equ RTC_TSIE_Shift, 15   @ bitWidth 1 (Time-stamp interrupt
  enable)  
        .equ RTC_WUTIE_Shift, 14   @ bitWidth 1 (Wakeup timer interrupt
  enable)  
        .equ RTC_ALRBIE_Shift, 13   @ bitWidth 1 (Alarm B interrupt enable)  
        .equ RTC_ALRAIE_Shift, 12   @ bitWidth 1 (Alarm A interrupt enable)  
        .equ RTC_TSE_Shift, 11   @ bitWidth 1 (Time stamp enable)  
        .equ RTC_WUTE_Shift, 10   @ bitWidth 1 (Wakeup timer enable)  
        .equ RTC_ALRBE_Shift, 9   @ bitWidth 1 (Alarm B enable)  
        .equ RTC_ALRAE_Shift, 8   @ bitWidth 1 (Alarm A enable)  
        .equ RTC_DCE_Shift, 7   @ bitWidth 1 (Coarse digital calibration
  enable)  
        .equ RTC_FMT_Shift, 6   @ bitWidth 1 (Hour format)  
        .equ RTC_BYPSHAD_Shift, 5   @ bitWidth 1 (Bypass the shadow
  registers)  
        .equ RTC_REFCKON_Shift, 4   @ bitWidth 1 (Reference clock detection enable 50 or
  60 Hz)  
        .equ RTC_TSEDGE_Shift, 3   @ bitWidth 1 (Time-stamp event active
  edge)  
        .equ RTC_WCKSEL_Shift, 0   @ bitWidth 3 (Wakeup clock selection)  
 
    .equ RTC_ISR, RTC_BASE + 0xC @ (initialization and status
  register) 
        .equ RTC_ALRAWF_Shift, 0   @ bitWidth 1 (Alarm A write flag)  
        .equ RTC_ALRBWF_Shift, 1   @ bitWidth 1 (Alarm B write flag)  
        .equ RTC_WUTWF_Shift, 2   @ bitWidth 1 (Wakeup timer write flag)  
        .equ RTC_SHPF_Shift, 3   @ bitWidth 1 (Shift operation pending)  
        .equ RTC_INITS_Shift, 4   @ bitWidth 1 (Initialization status flag)  
        .equ RTC_RSF_Shift, 5   @ bitWidth 1 (Registers synchronization
  flag)  
        .equ RTC_INITF_Shift, 6   @ bitWidth 1 (Initialization flag)  
        .equ RTC_INIT_Shift, 7   @ bitWidth 1 (Initialization mode)  
        .equ RTC_ALRAF_Shift, 8   @ bitWidth 1 (Alarm A flag)  
        .equ RTC_ALRBF_Shift, 9   @ bitWidth 1 (Alarm B flag)  
        .equ RTC_WUTF_Shift, 10   @ bitWidth 1 (Wakeup timer flag)  
        .equ RTC_TSF_Shift, 11   @ bitWidth 1 (Time-stamp flag)  
        .equ RTC_TSOVF_Shift, 12   @ bitWidth 1 (Time-stamp overflow flag)  
        .equ RTC_TAMP1F_Shift, 13   @ bitWidth 1 (Tamper detection flag)  
        .equ RTC_TAMP2F_Shift, 14   @ bitWidth 1 (TAMPER2 detection flag)  
        .equ RTC_RECALPF_Shift, 16   @ bitWidth 1 (Recalibration pending Flag)  
 
    .equ RTC_PRER, RTC_BASE + 0x10 @ (prescaler register) 
        .equ RTC_PREDIV_A_Shift, 16   @ bitWidth 7 (Asynchronous prescaler
  factor)  
        .equ RTC_PREDIV_S_Shift, 0   @ bitWidth 15 (Synchronous prescaler
  factor)  
 
    .equ RTC_WUTR, RTC_BASE + 0x14 @ (wakeup timer register) 
        .equ RTC_WUT_Shift, 0   @ bitWidth 16 (Wakeup auto-reload value
  bits)  
 
    .equ RTC_CALIBR, RTC_BASE + 0x18 @ (calibration register) 
        .equ RTC_DCS_Shift, 7   @ bitWidth 1 (Digital calibration sign)  
        .equ RTC_DC_Shift, 0   @ bitWidth 5 (Digital calibration)  
 
    .equ RTC_ALRMAR, RTC_BASE + 0x1C @ (alarm A register) 
        .equ RTC_MSK4_Shift, 31   @ bitWidth 1 (Alarm A date mask)  
        .equ RTC_WDSEL_Shift, 30   @ bitWidth 1 (Week day selection)  
        .equ RTC_DT_Shift, 28   @ bitWidth 2 (Date tens in BCD format)  
        .equ RTC_DU_Shift, 24   @ bitWidth 4 (Date units or day in BCD
  format)  
        .equ RTC_MSK3_Shift, 23   @ bitWidth 1 (Alarm A hours mask)  
        .equ RTC_PM_Shift, 22   @ bitWidth 1 (AM/PM notation)  
        .equ RTC_HT_Shift, 20   @ bitWidth 2 (Hour tens in BCD format)  
        .equ RTC_HU_Shift, 16   @ bitWidth 4 (Hour units in BCD format)  
        .equ RTC_MSK2_Shift, 15   @ bitWidth 1 (Alarm A minutes mask)  
        .equ RTC_MNT_Shift, 12   @ bitWidth 3 (Minute tens in BCD format)  
        .equ RTC_MNU_Shift, 8   @ bitWidth 4 (Minute units in BCD format)  
        .equ RTC_MSK1_Shift, 7   @ bitWidth 1 (Alarm A seconds mask)  
        .equ RTC_ST_Shift, 4   @ bitWidth 3 (Second tens in BCD format)  
        .equ RTC_SU_Shift, 0   @ bitWidth 4 (Second units in BCD format)  
 
    .equ RTC_ALRMBR, RTC_BASE + 0x20 @ (alarm B register) 
        .equ RTC_MSK4_Shift, 31   @ bitWidth 1 (Alarm B date mask)  
        .equ RTC_WDSEL_Shift, 30   @ bitWidth 1 (Week day selection)  
        .equ RTC_DT_Shift, 28   @ bitWidth 2 (Date tens in BCD format)  
        .equ RTC_DU_Shift, 24   @ bitWidth 4 (Date units or day in BCD
  format)  
        .equ RTC_MSK3_Shift, 23   @ bitWidth 1 (Alarm B hours mask)  
        .equ RTC_PM_Shift, 22   @ bitWidth 1 (AM/PM notation)  
        .equ RTC_HT_Shift, 20   @ bitWidth 2 (Hour tens in BCD format)  
        .equ RTC_HU_Shift, 16   @ bitWidth 4 (Hour units in BCD format)  
        .equ RTC_MSK2_Shift, 15   @ bitWidth 1 (Alarm B minutes mask)  
        .equ RTC_MNT_Shift, 12   @ bitWidth 3 (Minute tens in BCD format)  
        .equ RTC_MNU_Shift, 8   @ bitWidth 4 (Minute units in BCD format)  
        .equ RTC_MSK1_Shift, 7   @ bitWidth 1 (Alarm B seconds mask)  
        .equ RTC_ST_Shift, 4   @ bitWidth 3 (Second tens in BCD format)  
        .equ RTC_SU_Shift, 0   @ bitWidth 4 (Second units in BCD format)  
 
    .equ RTC_WPR, RTC_BASE + 0x24 @ (write protection register) 
        .equ RTC_KEY_Shift, 0   @ bitWidth 8 (Write protection key)  
 
    .equ RTC_SSR, RTC_BASE + 0x28 @ (sub second register) 
        .equ RTC_SS_Shift, 0   @ bitWidth 16 (Sub second value)  
 
    .equ RTC_SHIFTR, RTC_BASE + 0x2C @ (shift control register) 
        .equ RTC_ADD1S_Shift, 31   @ bitWidth 1 (Add one second)  
        .equ RTC_SUBFS_Shift, 0   @ bitWidth 15 (Subtract a fraction of a
  second)  
 
    .equ RTC_TSTR, RTC_BASE + 0x30 @ (time stamp time register) 
        .equ RTC_PM_Shift, 22   @ bitWidth 1 (AM/PM notation)  
        .equ RTC_HT_Shift, 20   @ bitWidth 2 (Hour tens in BCD format)  
        .equ RTC_HU_Shift, 16   @ bitWidth 4 (Hour units in BCD format)  
        .equ RTC_MNT_Shift, 12   @ bitWidth 3 (Minute tens in BCD format)  
        .equ RTC_MNU_Shift, 8   @ bitWidth 4 (Minute units in BCD format)  
        .equ RTC_ST_Shift, 4   @ bitWidth 3 (Second tens in BCD format)  
        .equ RTC_SU_Shift, 0   @ bitWidth 4 (Second units in BCD format)  
 
    .equ RTC_TSDR, RTC_BASE + 0x34 @ (time stamp date register) 
        .equ RTC_WDU_Shift, 13   @ bitWidth 3 (Week day units)  
        .equ RTC_MT_Shift, 12   @ bitWidth 1 (Month tens in BCD format)  
        .equ RTC_MU_Shift, 8   @ bitWidth 4 (Month units in BCD format)  
        .equ RTC_DT_Shift, 4   @ bitWidth 2 (Date tens in BCD format)  
        .equ RTC_DU_Shift, 0   @ bitWidth 4 (Date units in BCD format)  
 
    .equ RTC_TSSSR, RTC_BASE + 0x38 @ (timestamp sub second register) 
        .equ RTC_SS_Shift, 0   @ bitWidth 16 (Sub second value)  
 
    .equ RTC_CALR, RTC_BASE + 0x3C @ (calibration register) 
        .equ RTC_CALP_Shift, 15   @ bitWidth 1 (Increase frequency of RTC by 488.5
  ppm)  
        .equ RTC_CALW8_Shift, 14   @ bitWidth 1 (Use an 8-second calibration cycle
  period)  
        .equ RTC_CALW16_Shift, 13   @ bitWidth 1 (Use a 16-second calibration cycle
  period)  
        .equ RTC_CALM_Shift, 0   @ bitWidth 9 (Calibration minus)  
 
    .equ RTC_TAFCR, RTC_BASE + 0x40 @ (tamper and alternate function configuration
  register) 
        .equ RTC_ALARMOUTTYPE_Shift, 18   @ bitWidth 1 (AFO_ALARM output type)  
        .equ RTC_TSINSEL_Shift, 17   @ bitWidth 1 (TIMESTAMP mapping)  
        .equ RTC_TAMP1INSEL_Shift, 16   @ bitWidth 1 (TAMPER1 mapping)  
        .equ RTC_TAMPPUDIS_Shift, 15   @ bitWidth 1 (TAMPER pull-up disable)  
        .equ RTC_TAMPPRCH_Shift, 13   @ bitWidth 2 (Tamper precharge duration)  
        .equ RTC_TAMPFLT_Shift, 11   @ bitWidth 2 (Tamper filter count)  
        .equ RTC_TAMPFREQ_Shift, 8   @ bitWidth 3 (Tamper sampling frequency)  
        .equ RTC_TAMPTS_Shift, 7   @ bitWidth 1 (Activate timestamp on tamper detection
  event)  
        .equ RTC_TAMP2TRG_Shift, 4   @ bitWidth 1 (Active level for tamper 2)  
        .equ RTC_TAMP2E_Shift, 3   @ bitWidth 1 (Tamper 2 detection enable)  
        .equ RTC_TAMPIE_Shift, 2   @ bitWidth 1 (Tamper interrupt enable)  
        .equ RTC_TAMP1TRG_Shift, 1   @ bitWidth 1 (Active level for tamper 1)  
        .equ RTC_TAMP1E_Shift, 0   @ bitWidth 1 (Tamper 1 detection enable)  
 
    .equ RTC_ALRMASSR, RTC_BASE + 0x44 @ (alarm A sub second register) 
        .equ RTC_MASKSS_Shift, 24   @ bitWidth 4 (Mask the most-significant bits starting
  at this bit)  
        .equ RTC_SS_Shift, 0   @ bitWidth 15 (Sub seconds value)  
 
    .equ RTC_ALRMBSSR, RTC_BASE + 0x48 @ (alarm B sub second register) 
        .equ RTC_MASKSS_Shift, 24   @ bitWidth 4 (Mask the most-significant bits starting
  at this bit)  
        .equ RTC_SS_Shift, 0   @ bitWidth 15 (Sub seconds value)  
 
    .equ RTC_BKP0R, RTC_BASE + 0x50 @ (backup register) 
        .equ RTC_BKP_Shift, 0   @ bitWidth 32 (BKP)  
 
    .equ RTC_BKP1R, RTC_BASE + 0x54 @ (backup register) 
        .equ RTC_BKP_Shift, 0   @ bitWidth 32 (BKP)  
 
    .equ RTC_BKP2R, RTC_BASE + 0x58 @ (backup register) 
        .equ RTC_BKP_Shift, 0   @ bitWidth 32 (BKP)  
 
    .equ RTC_BKP3R, RTC_BASE + 0x5C @ (backup register) 
        .equ RTC_BKP_Shift, 0   @ bitWidth 32 (BKP)  
 
    .equ RTC_BKP4R, RTC_BASE + 0x60 @ (backup register) 
        .equ RTC_BKP_Shift, 0   @ bitWidth 32 (BKP)  
 
    .equ RTC_BKP5R, RTC_BASE + 0x64 @ (backup register) 
        .equ RTC_BKP_Shift, 0   @ bitWidth 32 (BKP)  
 
    .equ RTC_BKP6R, RTC_BASE + 0x68 @ (backup register) 
        .equ RTC_BKP_Shift, 0   @ bitWidth 32 (BKP)  
 
    .equ RTC_BKP7R, RTC_BASE + 0x6C @ (backup register) 
        .equ RTC_BKP_Shift, 0   @ bitWidth 32 (BKP)  
 
    .equ RTC_BKP8R, RTC_BASE + 0x70 @ (backup register) 
        .equ RTC_BKP_Shift, 0   @ bitWidth 32 (BKP)  
 
    .equ RTC_BKP9R, RTC_BASE + 0x74 @ (backup register) 
        .equ RTC_BKP_Shift, 0   @ bitWidth 32 (BKP)  
 
    .equ RTC_BKP10R, RTC_BASE + 0x78 @ (backup register) 
        .equ RTC_BKP_Shift, 0   @ bitWidth 32 (BKP)  
 
    .equ RTC_BKP11R, RTC_BASE + 0x7C @ (backup register) 
        .equ RTC_BKP_Shift, 0   @ bitWidth 32 (BKP)  
 
    .equ RTC_BKP12R, RTC_BASE + 0x80 @ (backup register) 
        .equ RTC_BKP_Shift, 0   @ bitWidth 32 (BKP)  
 
    .equ RTC_BKP13R, RTC_BASE + 0x84 @ (backup register) 
        .equ RTC_BKP_Shift, 0   @ bitWidth 32 (BKP)  
 
    .equ RTC_BKP14R, RTC_BASE + 0x88 @ (backup register) 
        .equ RTC_BKP_Shift, 0   @ bitWidth 32 (BKP)  
 
    .equ RTC_BKP15R, RTC_BASE + 0x8C @ (backup register) 
        .equ RTC_BKP_Shift, 0   @ bitWidth 32 (BKP)  
 
    .equ RTC_BKP16R, RTC_BASE + 0x90 @ (backup register) 
        .equ RTC_BKP_Shift, 0   @ bitWidth 32 (BKP)  
 
    .equ RTC_BKP17R, RTC_BASE + 0x94 @ (backup register) 
        .equ RTC_BKP_Shift, 0   @ bitWidth 32 (BKP)  
 
    .equ RTC_BKP18R, RTC_BASE + 0x98 @ (backup register) 
        .equ RTC_BKP_Shift, 0   @ bitWidth 32 (BKP)  
 
    .equ RTC_BKP19R, RTC_BASE + 0x9C @ (backup register) 
        .equ RTC_BKP_Shift, 0   @ bitWidth 32 (BKP)  
 

@=========================== SDIO ===========================@
.equ SDIO_BASE, 0x40012C00 @ (Secure digital input/output
  interface) 
    .equ SDIO_POWER, SDIO_BASE + 0x0 @ (power control register) 
        .equ SDIO_PWRCTRL_Shift, 0   @ bitWidth 2 (PWRCTRL)  
 
    .equ SDIO_CLKCR, SDIO_BASE + 0x4 @ (SDI clock control register) 
        .equ SDIO_HWFC_EN_Shift, 14   @ bitWidth 1 (HW Flow Control enable)  
        .equ SDIO_NEGEDGE_Shift, 13   @ bitWidth 1 (SDIO_CK dephasing selection
  bit)  
        .equ SDIO_WIDBUS_Shift, 11   @ bitWidth 2 (Wide bus mode enable bit)  
        .equ SDIO_BYPASS_Shift, 10   @ bitWidth 1 (Clock divider bypass enable
  bit)  
        .equ SDIO_PWRSAV_Shift, 9   @ bitWidth 1 (Power saving configuration
  bit)  
        .equ SDIO_CLKEN_Shift, 8   @ bitWidth 1 (Clock enable bit)  
        .equ SDIO_CLKDIV_Shift, 0   @ bitWidth 8 (Clock divide factor)  
 
    .equ SDIO_ARG, SDIO_BASE + 0x8 @ (argument register) 
        .equ SDIO_CMDARG_Shift, 0   @ bitWidth 32 (Command argument)  
 
    .equ SDIO_CMD, SDIO_BASE + 0xC @ (command register) 
        .equ SDIO_CE_ATACMD_Shift, 14   @ bitWidth 1 (CE-ATA command)  
        .equ SDIO_nIEN_Shift, 13   @ bitWidth 1 (not Interrupt Enable)  
        .equ SDIO_ENCMDcompl_Shift, 12   @ bitWidth 1 (Enable CMD completion)  
        .equ SDIO_SDIOSuspend_Shift, 11   @ bitWidth 1 (SD I/O suspend command)  
        .equ SDIO_CPSMEN_Shift, 10   @ bitWidth 1 (Command path state machine CPSM Enable
  bit)  
        .equ SDIO_WAITPEND_Shift, 9   @ bitWidth 1 (CPSM Waits for ends of data transfer
  CmdPend internal signal.)  
        .equ SDIO_WAITINT_Shift, 8   @ bitWidth 1 (CPSM waits for interrupt
  request)  
        .equ SDIO_WAITRESP_Shift, 6   @ bitWidth 2 (Wait for response bits)  
        .equ SDIO_CMDINDEX_Shift, 0   @ bitWidth 6 (Command index)  
 
    .equ SDIO_RESPCMD, SDIO_BASE + 0x10 @ (command response register) 
        .equ SDIO_RESPCMD_Shift, 0   @ bitWidth 6 (Response command index)  
 
    .equ SDIO_RESP1, SDIO_BASE + 0x14 @ (response 1..4 register) 
        .equ SDIO_CARDSTATUS1_Shift, 0   @ bitWidth 32 (Card Status)  
 
    .equ SDIO_RESP2, SDIO_BASE + 0x18 @ (response 1..4 register) 
        .equ SDIO_CARDSTATUS2_Shift, 0   @ bitWidth 32 (Card Status)  
 
    .equ SDIO_RESP3, SDIO_BASE + 0x1C @ (response 1..4 register) 
        .equ SDIO_CARDSTATUS3_Shift, 0   @ bitWidth 32 (Card Status)  
 
    .equ SDIO_RESP4, SDIO_BASE + 0x20 @ (response 1..4 register) 
        .equ SDIO_CARDSTATUS4_Shift, 0   @ bitWidth 32 (Card Status)  
 
    .equ SDIO_DTIMER, SDIO_BASE + 0x24 @ (data timer register) 
        .equ SDIO_DATATIME_Shift, 0   @ bitWidth 32 (Data timeout period)  
 
    .equ SDIO_DLEN, SDIO_BASE + 0x28 @ (data length register) 
        .equ SDIO_DATALENGTH_Shift, 0   @ bitWidth 25 (Data length value)  
 
    .equ SDIO_DCTRL, SDIO_BASE + 0x2C @ (data control register) 
        .equ SDIO_SDIOEN_Shift, 11   @ bitWidth 1 (SD I/O enable functions)  
        .equ SDIO_RWMOD_Shift, 10   @ bitWidth 1 (Read wait mode)  
        .equ SDIO_RWSTOP_Shift, 9   @ bitWidth 1 (Read wait stop)  
        .equ SDIO_RWSTART_Shift, 8   @ bitWidth 1 (Read wait start)  
        .equ SDIO_DBLOCKSIZE_Shift, 4   @ bitWidth 4 (Data block size)  
        .equ SDIO_DMAEN_Shift, 3   @ bitWidth 1 (DMA enable bit)  
        .equ SDIO_DTMODE_Shift, 2   @ bitWidth 1 (Data transfer mode selection 1: Stream
  or SDIO multibyte data transfer.)  
        .equ SDIO_DTDIR_Shift, 1   @ bitWidth 1 (Data transfer direction
  selection)  
        .equ SDIO_DTEN_Shift, 0   @ bitWidth 1 (DTEN)  
 
    .equ SDIO_DCOUNT, SDIO_BASE + 0x30 @ (data counter register) 
        .equ SDIO_DATACOUNT_Shift, 0   @ bitWidth 25 (Data count value)  
 
    .equ SDIO_STA, SDIO_BASE + 0x34 @ (status register) 
        .equ SDIO_CEATAEND_Shift, 23   @ bitWidth 1 (CE-ATA command completion signal
  received for CMD61)  
        .equ SDIO_SDIOIT_Shift, 22   @ bitWidth 1 (SDIO interrupt received)  
        .equ SDIO_RXDAVL_Shift, 21   @ bitWidth 1 (Data available in receive
  FIFO)  
        .equ SDIO_TXDAVL_Shift, 20   @ bitWidth 1 (Data available in transmit
  FIFO)  
        .equ SDIO_RXFIFOE_Shift, 19   @ bitWidth 1 (Receive FIFO empty)  
        .equ SDIO_TXFIFOE_Shift, 18   @ bitWidth 1 (Transmit FIFO empty)  
        .equ SDIO_RXFIFOF_Shift, 17   @ bitWidth 1 (Receive FIFO full)  
        .equ SDIO_TXFIFOF_Shift, 16   @ bitWidth 1 (Transmit FIFO full)  
        .equ SDIO_RXFIFOHF_Shift, 15   @ bitWidth 1 (Receive FIFO half full: there are at
  least 8 words in the FIFO)  
        .equ SDIO_TXFIFOHE_Shift, 14   @ bitWidth 1 (Transmit FIFO half empty: at least 8
  words can be written into the FIFO)  
        .equ SDIO_RXACT_Shift, 13   @ bitWidth 1 (Data receive in progress)  
        .equ SDIO_TXACT_Shift, 12   @ bitWidth 1 (Data transmit in progress)  
        .equ SDIO_CMDACT_Shift, 11   @ bitWidth 1 (Command transfer in
  progress)  
        .equ SDIO_DBCKEND_Shift, 10   @ bitWidth 1 (Data block sent/received CRC check
  passed)  
        .equ SDIO_STBITERR_Shift, 9   @ bitWidth 1 (Start bit not detected on all data
  signals in wide bus mode)  
        .equ SDIO_DATAEND_Shift, 8   @ bitWidth 1 (Data end data counter, SDIDCOUNT, is
  zero)  
        .equ SDIO_CMDSENT_Shift, 7   @ bitWidth 1 (Command sent no response
  required)  
        .equ SDIO_CMDREND_Shift, 6   @ bitWidth 1 (Command response received CRC check
  passed)  
        .equ SDIO_RXOVERR_Shift, 5   @ bitWidth 1 (Received FIFO overrun
  error)  
        .equ SDIO_TXUNDERR_Shift, 4   @ bitWidth 1 (Transmit FIFO underrun
  error)  
        .equ SDIO_DTIMEOUT_Shift, 3   @ bitWidth 1 (Data timeout)  
        .equ SDIO_CTIMEOUT_Shift, 2   @ bitWidth 1 (Command response timeout)  
        .equ SDIO_DCRCFAIL_Shift, 1   @ bitWidth 1 (Data block sent/received CRC check
  failed)  
        .equ SDIO_CCRCFAIL_Shift, 0   @ bitWidth 1 (Command response received CRC check
  failed)  
 
    .equ SDIO_ICR, SDIO_BASE + 0x38 @ (interrupt clear register) 
        .equ SDIO_CEATAENDC_Shift, 23   @ bitWidth 1 (CEATAEND flag clear bit)  
        .equ SDIO_SDIOITC_Shift, 22   @ bitWidth 1 (SDIOIT flag clear bit)  
        .equ SDIO_DBCKENDC_Shift, 10   @ bitWidth 1 (DBCKEND flag clear bit)  
        .equ SDIO_STBITERRC_Shift, 9   @ bitWidth 1 (STBITERR flag clear bit)  
        .equ SDIO_DATAENDC_Shift, 8   @ bitWidth 1 (DATAEND flag clear bit)  
        .equ SDIO_CMDSENTC_Shift, 7   @ bitWidth 1 (CMDSENT flag clear bit)  
        .equ SDIO_CMDRENDC_Shift, 6   @ bitWidth 1 (CMDREND flag clear bit)  
        .equ SDIO_RXOVERRC_Shift, 5   @ bitWidth 1 (RXOVERR flag clear bit)  
        .equ SDIO_TXUNDERRC_Shift, 4   @ bitWidth 1 (TXUNDERR flag clear bit)  
        .equ SDIO_DTIMEOUTC_Shift, 3   @ bitWidth 1 (DTIMEOUT flag clear bit)  
        .equ SDIO_CTIMEOUTC_Shift, 2   @ bitWidth 1 (CTIMEOUT flag clear bit)  
        .equ SDIO_DCRCFAILC_Shift, 1   @ bitWidth 1 (DCRCFAIL flag clear bit)  
        .equ SDIO_CCRCFAILC_Shift, 0   @ bitWidth 1 (CCRCFAIL flag clear bit)  
 
    .equ SDIO_MASK, SDIO_BASE + 0x3C @ (mask register) 
        .equ SDIO_CEATAENDIE_Shift, 23   @ bitWidth 1 (CE-ATA command completion signal
  received interrupt enable)  
        .equ SDIO_SDIOITIE_Shift, 22   @ bitWidth 1 (SDIO mode interrupt received interrupt
  enable)  
        .equ SDIO_RXDAVLIE_Shift, 21   @ bitWidth 1 (Data available in Rx FIFO interrupt
  enable)  
        .equ SDIO_TXDAVLIE_Shift, 20   @ bitWidth 1 (Data available in Tx FIFO interrupt
  enable)  
        .equ SDIO_RXFIFOEIE_Shift, 19   @ bitWidth 1 (Rx FIFO empty interrupt
  enable)  
        .equ SDIO_TXFIFOEIE_Shift, 18   @ bitWidth 1 (Tx FIFO empty interrupt
  enable)  
        .equ SDIO_RXFIFOFIE_Shift, 17   @ bitWidth 1 (Rx FIFO full interrupt
  enable)  
        .equ SDIO_TXFIFOFIE_Shift, 16   @ bitWidth 1 (Tx FIFO full interrupt
  enable)  
        .equ SDIO_RXFIFOHFIE_Shift, 15   @ bitWidth 1 (Rx FIFO half full interrupt
  enable)  
        .equ SDIO_TXFIFOHEIE_Shift, 14   @ bitWidth 1 (Tx FIFO half empty interrupt
  enable)  
        .equ SDIO_RXACTIE_Shift, 13   @ bitWidth 1 (Data receive acting interrupt
  enable)  
        .equ SDIO_TXACTIE_Shift, 12   @ bitWidth 1 (Data transmit acting interrupt
  enable)  
        .equ SDIO_CMDACTIE_Shift, 11   @ bitWidth 1 (Command acting interrupt
  enable)  
        .equ SDIO_DBCKENDIE_Shift, 10   @ bitWidth 1 (Data block end interrupt
  enable)  
        .equ SDIO_STBITERRIE_Shift, 9   @ bitWidth 1 (Start bit error interrupt
  enable)  
        .equ SDIO_DATAENDIE_Shift, 8   @ bitWidth 1 (Data end interrupt enable)  
        .equ SDIO_CMDSENTIE_Shift, 7   @ bitWidth 1 (Command sent interrupt
  enable)  
        .equ SDIO_CMDRENDIE_Shift, 6   @ bitWidth 1 (Command response received interrupt
  enable)  
        .equ SDIO_RXOVERRIE_Shift, 5   @ bitWidth 1 (Rx FIFO overrun error interrupt
  enable)  
        .equ SDIO_TXUNDERRIE_Shift, 4   @ bitWidth 1 (Tx FIFO underrun error interrupt
  enable)  
        .equ SDIO_DTIMEOUTIE_Shift, 3   @ bitWidth 1 (Data timeout interrupt
  enable)  
        .equ SDIO_CTIMEOUTIE_Shift, 2   @ bitWidth 1 (Command timeout interrupt
  enable)  
        .equ SDIO_DCRCFAILIE_Shift, 1   @ bitWidth 1 (Data CRC fail interrupt
  enable)  
        .equ SDIO_CCRCFAILIE_Shift, 0   @ bitWidth 1 (Command CRC fail interrupt
  enable)  
 
    .equ SDIO_FIFOCNT, SDIO_BASE + 0x48 @ (FIFO counter register) 
        .equ SDIO_FIFOCOUNT_Shift, 0   @ bitWidth 24 (Remaining number of words to be written
  to or read from the FIFO.)  
 
    .equ SDIO_FIFO, SDIO_BASE + 0x80 @ (data FIFO register) 
        .equ SDIO_FIFOData_Shift, 0   @ bitWidth 32 (Receive and transmit FIFO
  data)  
 

@=========================== SYSCFG ===========================@
.equ SYSCFG_BASE, 0x40013800 @ (System configuration controller) 
    .equ SYSCFG_MEMRM, SYSCFG_BASE + 0x0 @ (memory remap register) 
        .equ SYSCFG_MEM_MODE_Shift, 0   @ bitWidth 2 (MEM_MODE)  
 
    .equ SYSCFG_PMC, SYSCFG_BASE + 0x4 @ (peripheral mode configuration
  register) 
        .equ SYSCFG_ADC1DC2_Shift, 16   @ bitWidth 1 (ADC1DC2)  
 
    .equ SYSCFG_EXTICR1, SYSCFG_BASE + 0x8 @ (external interrupt configuration register
  1) 
        .equ SYSCFG_EXTI3_Shift, 12   @ bitWidth 4 (EXTI x configuration x = 0 to
  3)  
        .equ SYSCFG_EXTI2_Shift, 8   @ bitWidth 4 (EXTI x configuration x = 0 to
  3)  
        .equ SYSCFG_EXTI1_Shift, 4   @ bitWidth 4 (EXTI x configuration x = 0 to
  3)  
        .equ SYSCFG_EXTI0_Shift, 0   @ bitWidth 4 (EXTI x configuration x = 0 to
  3)  
 
    .equ SYSCFG_EXTICR2, SYSCFG_BASE + 0xC @ (external interrupt configuration register
  2) 
        .equ SYSCFG_EXTI7_Shift, 12   @ bitWidth 4 (EXTI x configuration x = 4 to
  7)  
        .equ SYSCFG_EXTI6_Shift, 8   @ bitWidth 4 (EXTI x configuration x = 4 to
  7)  
        .equ SYSCFG_EXTI5_Shift, 4   @ bitWidth 4 (EXTI x configuration x = 4 to
  7)  
        .equ SYSCFG_EXTI4_Shift, 0   @ bitWidth 4 (EXTI x configuration x = 4 to
  7)  
 
    .equ SYSCFG_EXTICR3, SYSCFG_BASE + 0x10 @ (external interrupt configuration register
  3) 
        .equ SYSCFG_EXTI11_Shift, 12   @ bitWidth 4 (EXTI x configuration x = 8 to
  11)  
        .equ SYSCFG_EXTI10_Shift, 8   @ bitWidth 4 (EXTI10)  
        .equ SYSCFG_EXTI9_Shift, 4   @ bitWidth 4 (EXTI x configuration x = 8 to
  11)  
        .equ SYSCFG_EXTI8_Shift, 0   @ bitWidth 4 (EXTI x configuration x = 8 to
  11)  
 
    .equ SYSCFG_EXTICR4, SYSCFG_BASE + 0x14 @ (external interrupt configuration register
  4) 
        .equ SYSCFG_EXTI15_Shift, 12   @ bitWidth 4 (EXTI x configuration x = 12 to
  15)  
        .equ SYSCFG_EXTI14_Shift, 8   @ bitWidth 4 (EXTI x configuration x = 12 to
  15)  
        .equ SYSCFG_EXTI13_Shift, 4   @ bitWidth 4 (EXTI x configuration x = 12 to
  15)  
        .equ SYSCFG_EXTI12_Shift, 0   @ bitWidth 4 (EXTI x configuration x = 12 to
  15)  
 
    .equ SYSCFG_CMPCR, SYSCFG_BASE + 0x20 @ (Compensation cell control
  register) 
        .equ SYSCFG_READY_Shift, 8   @ bitWidth 1 (READY)  
        .equ SYSCFG_CMP_PD_Shift, 0   @ bitWidth 1 (Compensation cell
  power-down)  
 

@=========================== TIM1 ===========================@
.equ TIM1_BASE, 0x40010000 @ (Advanced-timers) 
    .equ TIM1_CR1, TIM1_BASE + 0x0 @ (control register 1) 
        .equ TIM1_CKD_Shift, 8   @ bitWidth 2 (Clock division)  
        .equ TIM1_ARPE_Shift, 7   @ bitWidth 1 (Auto-reload preload enable)  
        .equ TIM1_CMS_Shift, 5   @ bitWidth 2 (Center-aligned mode
  selection)  
        .equ TIM1_DIR_Shift, 4   @ bitWidth 1 (Direction)  
        .equ TIM1_OPM_Shift, 3   @ bitWidth 1 (One-pulse mode)  
        .equ TIM1_URS_Shift, 2   @ bitWidth 1 (Update request source)  
        .equ TIM1_UDIS_Shift, 1   @ bitWidth 1 (Update disable)  
        .equ TIM1_CEN_Shift, 0   @ bitWidth 1 (Counter enable)  
 
    .equ TIM1_CR2, TIM1_BASE + 0x4 @ (control register 2) 
        .equ TIM1_OIS4_Shift, 14   @ bitWidth 1 (Output Idle state 4)  
        .equ TIM1_OIS3N_Shift, 13   @ bitWidth 1 (Output Idle state 3)  
        .equ TIM1_OIS3_Shift, 12   @ bitWidth 1 (Output Idle state 3)  
        .equ TIM1_OIS2N_Shift, 11   @ bitWidth 1 (Output Idle state 2)  
        .equ TIM1_OIS2_Shift, 10   @ bitWidth 1 (Output Idle state 2)  
        .equ TIM1_OIS1N_Shift, 9   @ bitWidth 1 (Output Idle state 1)  
        .equ TIM1_OIS1_Shift, 8   @ bitWidth 1 (Output Idle state 1)  
        .equ TIM1_TI1S_Shift, 7   @ bitWidth 1 (TI1 selection)  
        .equ TIM1_MMS_Shift, 4   @ bitWidth 3 (Master mode selection)  
        .equ TIM1_CCDS_Shift, 3   @ bitWidth 1 (Capture/compare DMA
  selection)  
        .equ TIM1_CCUS_Shift, 2   @ bitWidth 1 (Capture/compare control update
  selection)  
        .equ TIM1_CCPC_Shift, 0   @ bitWidth 1 (Capture/compare preloaded
  control)  
 
    .equ TIM1_SMCR, TIM1_BASE + 0x8 @ (slave mode control register) 
        .equ TIM1_ETP_Shift, 15   @ bitWidth 1 (External trigger polarity)  
        .equ TIM1_ECE_Shift, 14   @ bitWidth 1 (External clock enable)  
        .equ TIM1_ETPS_Shift, 12   @ bitWidth 2 (External trigger prescaler)  
        .equ TIM1_ETF_Shift, 8   @ bitWidth 4 (External trigger filter)  
        .equ TIM1_MSM_Shift, 7   @ bitWidth 1 (Master/Slave mode)  
        .equ TIM1_TS_Shift, 4   @ bitWidth 3 (Trigger selection)  
        .equ TIM1_SMS_Shift, 0   @ bitWidth 3 (Slave mode selection)  
 
    .equ TIM1_DIER, TIM1_BASE + 0xC @ (DMA/Interrupt enable register) 
        .equ TIM1_TDE_Shift, 14   @ bitWidth 1 (Trigger DMA request enable)  
        .equ TIM1_COMDE_Shift, 13   @ bitWidth 1 (COM DMA request enable)  
        .equ TIM1_CC4DE_Shift, 12   @ bitWidth 1 (Capture/Compare 4 DMA request
  enable)  
        .equ TIM1_CC3DE_Shift, 11   @ bitWidth 1 (Capture/Compare 3 DMA request
  enable)  
        .equ TIM1_CC2DE_Shift, 10   @ bitWidth 1 (Capture/Compare 2 DMA request
  enable)  
        .equ TIM1_CC1DE_Shift, 9   @ bitWidth 1 (Capture/Compare 1 DMA request
  enable)  
        .equ TIM1_UDE_Shift, 8   @ bitWidth 1 (Update DMA request enable)  
        .equ TIM1_BIE_Shift, 7   @ bitWidth 1 (Break interrupt enable)  
        .equ TIM1_TIE_Shift, 6   @ bitWidth 1 (Trigger interrupt enable)  
        .equ TIM1_COMIE_Shift, 5   @ bitWidth 1 (COM interrupt enable)  
        .equ TIM1_CC4IE_Shift, 4   @ bitWidth 1 (Capture/Compare 4 interrupt
  enable)  
        .equ TIM1_CC3IE_Shift, 3   @ bitWidth 1 (Capture/Compare 3 interrupt
  enable)  
        .equ TIM1_CC2IE_Shift, 2   @ bitWidth 1 (Capture/Compare 2 interrupt
  enable)  
        .equ TIM1_CC1IE_Shift, 1   @ bitWidth 1 (Capture/Compare 1 interrupt
  enable)  
        .equ TIM1_UIE_Shift, 0   @ bitWidth 1 (Update interrupt enable)  
 
    .equ TIM1_SR, TIM1_BASE + 0x10 @ (status register) 
        .equ TIM1_CC4OF_Shift, 12   @ bitWidth 1 (Capture/Compare 4 overcapture
  flag)  
        .equ TIM1_CC3OF_Shift, 11   @ bitWidth 1 (Capture/Compare 3 overcapture
  flag)  
        .equ TIM1_CC2OF_Shift, 10   @ bitWidth 1 (Capture/compare 2 overcapture
  flag)  
        .equ TIM1_CC1OF_Shift, 9   @ bitWidth 1 (Capture/Compare 1 overcapture
  flag)  
        .equ TIM1_BIF_Shift, 7   @ bitWidth 1 (Break interrupt flag)  
        .equ TIM1_TIF_Shift, 6   @ bitWidth 1 (Trigger interrupt flag)  
        .equ TIM1_COMIF_Shift, 5   @ bitWidth 1 (COM interrupt flag)  
        .equ TIM1_CC4IF_Shift, 4   @ bitWidth 1 (Capture/Compare 4 interrupt
  flag)  
        .equ TIM1_CC3IF_Shift, 3   @ bitWidth 1 (Capture/Compare 3 interrupt
  flag)  
        .equ TIM1_CC2IF_Shift, 2   @ bitWidth 1 (Capture/Compare 2 interrupt
  flag)  
        .equ TIM1_CC1IF_Shift, 1   @ bitWidth 1 (Capture/compare 1 interrupt
  flag)  
        .equ TIM1_UIF_Shift, 0   @ bitWidth 1 (Update interrupt flag)  
 
    .equ TIM1_EGR, TIM1_BASE + 0x14 @ (event generation register) 
        .equ TIM1_BG_Shift, 7   @ bitWidth 1 (Break generation)  
        .equ TIM1_TG_Shift, 6   @ bitWidth 1 (Trigger generation)  
        .equ TIM1_COMG_Shift, 5   @ bitWidth 1 (Capture/Compare control update
  generation)  
        .equ TIM1_CC4G_Shift, 4   @ bitWidth 1 (Capture/compare 4
  generation)  
        .equ TIM1_CC3G_Shift, 3   @ bitWidth 1 (Capture/compare 3
  generation)  
        .equ TIM1_CC2G_Shift, 2   @ bitWidth 1 (Capture/compare 2
  generation)  
        .equ TIM1_CC1G_Shift, 1   @ bitWidth 1 (Capture/compare 1
  generation)  
        .equ TIM1_UG_Shift, 0   @ bitWidth 1 (Update generation)  
 
    .equ TIM1_CCMR1_Output, TIM1_BASE + 0x18 @ (capture/compare mode register 1 output
  mode) 
        .equ TIM1_OC2CE_Shift, 15   @ bitWidth 1 (Output Compare 2 clear
  enable)  
        .equ TIM1_OC2M_Shift, 12   @ bitWidth 3 (Output Compare 2 mode)  
        .equ TIM1_OC2PE_Shift, 11   @ bitWidth 1 (Output Compare 2 preload
  enable)  
        .equ TIM1_OC2FE_Shift, 10   @ bitWidth 1 (Output Compare 2 fast
  enable)  
        .equ TIM1_CC2S_Shift, 8   @ bitWidth 2 (Capture/Compare 2
  selection)  
        .equ TIM1_OC1CE_Shift, 7   @ bitWidth 1 (Output Compare 1 clear
  enable)  
        .equ TIM1_OC1M_Shift, 4   @ bitWidth 3 (Output Compare 1 mode)  
        .equ TIM1_OC1PE_Shift, 3   @ bitWidth 1 (Output Compare 1 preload
  enable)  
        .equ TIM1_OC1FE_Shift, 2   @ bitWidth 1 (Output Compare 1 fast
  enable)  
        .equ TIM1_CC1S_Shift, 0   @ bitWidth 2 (Capture/Compare 1
  selection)  
 
    .equ TIM1_CCMR1_Input, TIM1_BASE + 0x18 @ (capture/compare mode register 1 input
  mode) 
        .equ TIM1_IC2F_Shift, 12   @ bitWidth 4 (Input capture 2 filter)  
        .equ TIM1_IC2PCS_Shift, 10   @ bitWidth 2 (Input capture 2 prescaler)  
        .equ TIM1_CC2S_Shift, 8   @ bitWidth 2 (Capture/Compare 2
  selection)  
        .equ TIM1_IC1F_Shift, 4   @ bitWidth 4 (Input capture 1 filter)  
        .equ TIM1_ICPCS_Shift, 2   @ bitWidth 2 (Input capture 1 prescaler)  
        .equ TIM1_CC1S_Shift, 0   @ bitWidth 2 (Capture/Compare 1
  selection)  
 
    .equ TIM1_CCMR2_Output, TIM1_BASE + 0x1C @ (capture/compare mode register 2 output
  mode) 
        .equ TIM1_OC4CE_Shift, 15   @ bitWidth 1 (Output compare 4 clear
  enable)  
        .equ TIM1_OC4M_Shift, 12   @ bitWidth 3 (Output compare 4 mode)  
        .equ TIM1_OC4PE_Shift, 11   @ bitWidth 1 (Output compare 4 preload
  enable)  
        .equ TIM1_OC4FE_Shift, 10   @ bitWidth 1 (Output compare 4 fast
  enable)  
        .equ TIM1_CC4S_Shift, 8   @ bitWidth 2 (Capture/Compare 4
  selection)  
        .equ TIM1_OC3CE_Shift, 7   @ bitWidth 1 (Output compare 3 clear
  enable)  
        .equ TIM1_OC3M_Shift, 4   @ bitWidth 3 (Output compare 3 mode)  
        .equ TIM1_OC3PE_Shift, 3   @ bitWidth 1 (Output compare 3 preload
  enable)  
        .equ TIM1_OC3FE_Shift, 2   @ bitWidth 1 (Output compare 3 fast
  enable)  
        .equ TIM1_CC3S_Shift, 0   @ bitWidth 2 (Capture/Compare 3
  selection)  
 
    .equ TIM1_CCMR2_Input, TIM1_BASE + 0x1C @ (capture/compare mode register 2 input
  mode) 
        .equ TIM1_IC4F_Shift, 12   @ bitWidth 4 (Input capture 4 filter)  
        .equ TIM1_IC4PSC_Shift, 10   @ bitWidth 2 (Input capture 4 prescaler)  
        .equ TIM1_CC4S_Shift, 8   @ bitWidth 2 (Capture/Compare 4
  selection)  
        .equ TIM1_IC3F_Shift, 4   @ bitWidth 4 (Input capture 3 filter)  
        .equ TIM1_IC3PSC_Shift, 2   @ bitWidth 2 (Input capture 3 prescaler)  
        .equ TIM1_CC3S_Shift, 0   @ bitWidth 2 (Capture/compare 3
  selection)  
 
    .equ TIM1_CCER, TIM1_BASE + 0x20 @ (capture/compare enable
  register) 
        .equ TIM1_CC4P_Shift, 13   @ bitWidth 1 (Capture/Compare 3 output
  Polarity)  
        .equ TIM1_CC4E_Shift, 12   @ bitWidth 1 (Capture/Compare 4 output
  enable)  
        .equ TIM1_CC3NP_Shift, 11   @ bitWidth 1 (Capture/Compare 3 output
  Polarity)  
        .equ TIM1_CC3NE_Shift, 10   @ bitWidth 1 (Capture/Compare 3 complementary output
  enable)  
        .equ TIM1_CC3P_Shift, 9   @ bitWidth 1 (Capture/Compare 3 output
  Polarity)  
        .equ TIM1_CC3E_Shift, 8   @ bitWidth 1 (Capture/Compare 3 output
  enable)  
        .equ TIM1_CC2NP_Shift, 7   @ bitWidth 1 (Capture/Compare 2 output
  Polarity)  
        .equ TIM1_CC2NE_Shift, 6   @ bitWidth 1 (Capture/Compare 2 complementary output
  enable)  
        .equ TIM1_CC2P_Shift, 5   @ bitWidth 1 (Capture/Compare 2 output
  Polarity)  
        .equ TIM1_CC2E_Shift, 4   @ bitWidth 1 (Capture/Compare 2 output
  enable)  
        .equ TIM1_CC1NP_Shift, 3   @ bitWidth 1 (Capture/Compare 1 output
  Polarity)  
        .equ TIM1_CC1NE_Shift, 2   @ bitWidth 1 (Capture/Compare 1 complementary output
  enable)  
        .equ TIM1_CC1P_Shift, 1   @ bitWidth 1 (Capture/Compare 1 output
  Polarity)  
        .equ TIM1_CC1E_Shift, 0   @ bitWidth 1 (Capture/Compare 1 output
  enable)  
 
    .equ TIM1_CNT, TIM1_BASE + 0x24 @ (counter) 
        .equ TIM1_CNT_Shift, 0   @ bitWidth 16 (counter value)  
 
    .equ TIM1_PSC, TIM1_BASE + 0x28 @ (prescaler) 
        .equ TIM1_PSC_Shift, 0   @ bitWidth 16 (Prescaler value)  
 
    .equ TIM1_ARR, TIM1_BASE + 0x2C @ (auto-reload register) 
        .equ TIM1_ARR_Shift, 0   @ bitWidth 16 (Auto-reload value)  
 
    .equ TIM1_CCR1, TIM1_BASE + 0x34 @ (capture/compare register 1) 
        .equ TIM1_CCR1_Shift, 0   @ bitWidth 16 (Capture/Compare 1 value)  
 
    .equ TIM1_CCR2, TIM1_BASE + 0x38 @ (capture/compare register 2) 
        .equ TIM1_CCR2_Shift, 0   @ bitWidth 16 (Capture/Compare 2 value)  
 
    .equ TIM1_CCR3, TIM1_BASE + 0x3C @ (capture/compare register 3) 
        .equ TIM1_CCR3_Shift, 0   @ bitWidth 16 (Capture/Compare value)  
 
    .equ TIM1_CCR4, TIM1_BASE + 0x40 @ (capture/compare register 4) 
        .equ TIM1_CCR4_Shift, 0   @ bitWidth 16 (Capture/Compare value)  
 
    .equ TIM1_DCR, TIM1_BASE + 0x48 @ (DMA control register) 
        .equ TIM1_DBL_Shift, 8   @ bitWidth 5 (DMA burst length)  
        .equ TIM1_DBA_Shift, 0   @ bitWidth 5 (DMA base address)  
 
    .equ TIM1_DMAR, TIM1_BASE + 0x4C @ (DMA address for full transfer) 
        .equ TIM1_DMAB_Shift, 0   @ bitWidth 16 (DMA register for burst
  accesses)  
 
    .equ TIM1_RCR, TIM1_BASE + 0x30 @ (repetition counter register) 
        .equ TIM1_REP_Shift, 0   @ bitWidth 8 (Repetition counter value)  
 
    .equ TIM1_BDTR, TIM1_BASE + 0x44 @ (break and dead-time register) 
        .equ TIM1_MOE_Shift, 15   @ bitWidth 1 (Main output enable)  
        .equ TIM1_AOE_Shift, 14   @ bitWidth 1 (Automatic output enable)  
        .equ TIM1_BKP_Shift, 13   @ bitWidth 1 (Break polarity)  
        .equ TIM1_BKE_Shift, 12   @ bitWidth 1 (Break enable)  
        .equ TIM1_OSSR_Shift, 11   @ bitWidth 1 (Off-state selection for Run
  mode)  
        .equ TIM1_OSSI_Shift, 10   @ bitWidth 1 (Off-state selection for Idle
  mode)  
        .equ TIM1_LOCK_Shift, 8   @ bitWidth 2 (Lock configuration)  
        .equ TIM1_DTG_Shift, 0   @ bitWidth 8 (Dead-time generator setup)  
 

@=========================== TIM8 ===========================@
.equ TIM8_BASE, 0x40010400 @ (Advanced-timers) 
    .equ TIM8_CR1, TIM8_BASE + 0x0 @ (control register 1) 
        .equ TIM8_CKD_Shift, 8   @ bitWidth 2 (Clock division)  
        .equ TIM8_ARPE_Shift, 7   @ bitWidth 1 (Auto-reload preload enable)  
        .equ TIM8_CMS_Shift, 5   @ bitWidth 2 (Center-aligned mode
  selection)  
        .equ TIM8_DIR_Shift, 4   @ bitWidth 1 (Direction)  
        .equ TIM8_OPM_Shift, 3   @ bitWidth 1 (One-pulse mode)  
        .equ TIM8_URS_Shift, 2   @ bitWidth 1 (Update request source)  
        .equ TIM8_UDIS_Shift, 1   @ bitWidth 1 (Update disable)  
        .equ TIM8_CEN_Shift, 0   @ bitWidth 1 (Counter enable)  
 
    .equ TIM8_CR2, TIM8_BASE + 0x4 @ (control register 2) 
        .equ TIM8_OIS4_Shift, 14   @ bitWidth 1 (Output Idle state 4)  
        .equ TIM8_OIS3N_Shift, 13   @ bitWidth 1 (Output Idle state 3)  
        .equ TIM8_OIS3_Shift, 12   @ bitWidth 1 (Output Idle state 3)  
        .equ TIM8_OIS2N_Shift, 11   @ bitWidth 1 (Output Idle state 2)  
        .equ TIM8_OIS2_Shift, 10   @ bitWidth 1 (Output Idle state 2)  
        .equ TIM8_OIS1N_Shift, 9   @ bitWidth 1 (Output Idle state 1)  
        .equ TIM8_OIS1_Shift, 8   @ bitWidth 1 (Output Idle state 1)  
        .equ TIM8_TI1S_Shift, 7   @ bitWidth 1 (TI1 selection)  
        .equ TIM8_MMS_Shift, 4   @ bitWidth 3 (Master mode selection)  
        .equ TIM8_CCDS_Shift, 3   @ bitWidth 1 (Capture/compare DMA
  selection)  
        .equ TIM8_CCUS_Shift, 2   @ bitWidth 1 (Capture/compare control update
  selection)  
        .equ TIM8_CCPC_Shift, 0   @ bitWidth 1 (Capture/compare preloaded
  control)  
 
    .equ TIM8_SMCR, TIM8_BASE + 0x8 @ (slave mode control register) 
        .equ TIM8_ETP_Shift, 15   @ bitWidth 1 (External trigger polarity)  
        .equ TIM8_ECE_Shift, 14   @ bitWidth 1 (External clock enable)  
        .equ TIM8_ETPS_Shift, 12   @ bitWidth 2 (External trigger prescaler)  
        .equ TIM8_ETF_Shift, 8   @ bitWidth 4 (External trigger filter)  
        .equ TIM8_MSM_Shift, 7   @ bitWidth 1 (Master/Slave mode)  
        .equ TIM8_TS_Shift, 4   @ bitWidth 3 (Trigger selection)  
        .equ TIM8_SMS_Shift, 0   @ bitWidth 3 (Slave mode selection)  
 
    .equ TIM8_DIER, TIM8_BASE + 0xC @ (DMA/Interrupt enable register) 
        .equ TIM8_TDE_Shift, 14   @ bitWidth 1 (Trigger DMA request enable)  
        .equ TIM8_COMDE_Shift, 13   @ bitWidth 1 (COM DMA request enable)  
        .equ TIM8_CC4DE_Shift, 12   @ bitWidth 1 (Capture/Compare 4 DMA request
  enable)  
        .equ TIM8_CC3DE_Shift, 11   @ bitWidth 1 (Capture/Compare 3 DMA request
  enable)  
        .equ TIM8_CC2DE_Shift, 10   @ bitWidth 1 (Capture/Compare 2 DMA request
  enable)  
        .equ TIM8_CC1DE_Shift, 9   @ bitWidth 1 (Capture/Compare 1 DMA request
  enable)  
        .equ TIM8_UDE_Shift, 8   @ bitWidth 1 (Update DMA request enable)  
        .equ TIM8_BIE_Shift, 7   @ bitWidth 1 (Break interrupt enable)  
        .equ TIM8_TIE_Shift, 6   @ bitWidth 1 (Trigger interrupt enable)  
        .equ TIM8_COMIE_Shift, 5   @ bitWidth 1 (COM interrupt enable)  
        .equ TIM8_CC4IE_Shift, 4   @ bitWidth 1 (Capture/Compare 4 interrupt
  enable)  
        .equ TIM8_CC3IE_Shift, 3   @ bitWidth 1 (Capture/Compare 3 interrupt
  enable)  
        .equ TIM8_CC2IE_Shift, 2   @ bitWidth 1 (Capture/Compare 2 interrupt
  enable)  
        .equ TIM8_CC1IE_Shift, 1   @ bitWidth 1 (Capture/Compare 1 interrupt
  enable)  
        .equ TIM8_UIE_Shift, 0   @ bitWidth 1 (Update interrupt enable)  
 
    .equ TIM8_SR, TIM8_BASE + 0x10 @ (status register) 
        .equ TIM8_CC4OF_Shift, 12   @ bitWidth 1 (Capture/Compare 4 overcapture
  flag)  
        .equ TIM8_CC3OF_Shift, 11   @ bitWidth 1 (Capture/Compare 3 overcapture
  flag)  
        .equ TIM8_CC2OF_Shift, 10   @ bitWidth 1 (Capture/compare 2 overcapture
  flag)  
        .equ TIM8_CC1OF_Shift, 9   @ bitWidth 1 (Capture/Compare 1 overcapture
  flag)  
        .equ TIM8_BIF_Shift, 7   @ bitWidth 1 (Break interrupt flag)  
        .equ TIM8_TIF_Shift, 6   @ bitWidth 1 (Trigger interrupt flag)  
        .equ TIM8_COMIF_Shift, 5   @ bitWidth 1 (COM interrupt flag)  
        .equ TIM8_CC4IF_Shift, 4   @ bitWidth 1 (Capture/Compare 4 interrupt
  flag)  
        .equ TIM8_CC3IF_Shift, 3   @ bitWidth 1 (Capture/Compare 3 interrupt
  flag)  
        .equ TIM8_CC2IF_Shift, 2   @ bitWidth 1 (Capture/Compare 2 interrupt
  flag)  
        .equ TIM8_CC1IF_Shift, 1   @ bitWidth 1 (Capture/compare 1 interrupt
  flag)  
        .equ TIM8_UIF_Shift, 0   @ bitWidth 1 (Update interrupt flag)  
 
    .equ TIM8_EGR, TIM8_BASE + 0x14 @ (event generation register) 
        .equ TIM8_BG_Shift, 7   @ bitWidth 1 (Break generation)  
        .equ TIM8_TG_Shift, 6   @ bitWidth 1 (Trigger generation)  
        .equ TIM8_COMG_Shift, 5   @ bitWidth 1 (Capture/Compare control update
  generation)  
        .equ TIM8_CC4G_Shift, 4   @ bitWidth 1 (Capture/compare 4
  generation)  
        .equ TIM8_CC3G_Shift, 3   @ bitWidth 1 (Capture/compare 3
  generation)  
        .equ TIM8_CC2G_Shift, 2   @ bitWidth 1 (Capture/compare 2
  generation)  
        .equ TIM8_CC1G_Shift, 1   @ bitWidth 1 (Capture/compare 1
  generation)  
        .equ TIM8_UG_Shift, 0   @ bitWidth 1 (Update generation)  
 
    .equ TIM8_CCMR1_Output, TIM8_BASE + 0x18 @ (capture/compare mode register 1 output
  mode) 
        .equ TIM8_OC2CE_Shift, 15   @ bitWidth 1 (Output Compare 2 clear
  enable)  
        .equ TIM8_OC2M_Shift, 12   @ bitWidth 3 (Output Compare 2 mode)  
        .equ TIM8_OC2PE_Shift, 11   @ bitWidth 1 (Output Compare 2 preload
  enable)  
        .equ TIM8_OC2FE_Shift, 10   @ bitWidth 1 (Output Compare 2 fast
  enable)  
        .equ TIM8_CC2S_Shift, 8   @ bitWidth 2 (Capture/Compare 2
  selection)  
        .equ TIM8_OC1CE_Shift, 7   @ bitWidth 1 (Output Compare 1 clear
  enable)  
        .equ TIM8_OC1M_Shift, 4   @ bitWidth 3 (Output Compare 1 mode)  
        .equ TIM8_OC1PE_Shift, 3   @ bitWidth 1 (Output Compare 1 preload
  enable)  
        .equ TIM8_OC1FE_Shift, 2   @ bitWidth 1 (Output Compare 1 fast
  enable)  
        .equ TIM8_CC1S_Shift, 0   @ bitWidth 2 (Capture/Compare 1
  selection)  
 
    .equ TIM8_CCMR1_Input, TIM8_BASE + 0x18 @ (capture/compare mode register 1 input
  mode) 
        .equ TIM8_IC2F_Shift, 12   @ bitWidth 4 (Input capture 2 filter)  
        .equ TIM8_IC2PCS_Shift, 10   @ bitWidth 2 (Input capture 2 prescaler)  
        .equ TIM8_CC2S_Shift, 8   @ bitWidth 2 (Capture/Compare 2
  selection)  
        .equ TIM8_IC1F_Shift, 4   @ bitWidth 4 (Input capture 1 filter)  
        .equ TIM8_ICPCS_Shift, 2   @ bitWidth 2 (Input capture 1 prescaler)  
        .equ TIM8_CC1S_Shift, 0   @ bitWidth 2 (Capture/Compare 1
  selection)  
 
    .equ TIM8_CCMR2_Output, TIM8_BASE + 0x1C @ (capture/compare mode register 2 output
  mode) 
        .equ TIM8_OC4CE_Shift, 15   @ bitWidth 1 (Output compare 4 clear
  enable)  
        .equ TIM8_OC4M_Shift, 12   @ bitWidth 3 (Output compare 4 mode)  
        .equ TIM8_OC4PE_Shift, 11   @ bitWidth 1 (Output compare 4 preload
  enable)  
        .equ TIM8_OC4FE_Shift, 10   @ bitWidth 1 (Output compare 4 fast
  enable)  
        .equ TIM8_CC4S_Shift, 8   @ bitWidth 2 (Capture/Compare 4
  selection)  
        .equ TIM8_OC3CE_Shift, 7   @ bitWidth 1 (Output compare 3 clear
  enable)  
        .equ TIM8_OC3M_Shift, 4   @ bitWidth 3 (Output compare 3 mode)  
        .equ TIM8_OC3PE_Shift, 3   @ bitWidth 1 (Output compare 3 preload
  enable)  
        .equ TIM8_OC3FE_Shift, 2   @ bitWidth 1 (Output compare 3 fast
  enable)  
        .equ TIM8_CC3S_Shift, 0   @ bitWidth 2 (Capture/Compare 3
  selection)  
 
    .equ TIM8_CCMR2_Input, TIM8_BASE + 0x1C @ (capture/compare mode register 2 input
  mode) 
        .equ TIM8_IC4F_Shift, 12   @ bitWidth 4 (Input capture 4 filter)  
        .equ TIM8_IC4PSC_Shift, 10   @ bitWidth 2 (Input capture 4 prescaler)  
        .equ TIM8_CC4S_Shift, 8   @ bitWidth 2 (Capture/Compare 4
  selection)  
        .equ TIM8_IC3F_Shift, 4   @ bitWidth 4 (Input capture 3 filter)  
        .equ TIM8_IC3PSC_Shift, 2   @ bitWidth 2 (Input capture 3 prescaler)  
        .equ TIM8_CC3S_Shift, 0   @ bitWidth 2 (Capture/compare 3
  selection)  
 
    .equ TIM8_CCER, TIM8_BASE + 0x20 @ (capture/compare enable
  register) 
        .equ TIM8_CC4P_Shift, 13   @ bitWidth 1 (Capture/Compare 3 output
  Polarity)  
        .equ TIM8_CC4E_Shift, 12   @ bitWidth 1 (Capture/Compare 4 output
  enable)  
        .equ TIM8_CC3NP_Shift, 11   @ bitWidth 1 (Capture/Compare 3 output
  Polarity)  
        .equ TIM8_CC3NE_Shift, 10   @ bitWidth 1 (Capture/Compare 3 complementary output
  enable)  
        .equ TIM8_CC3P_Shift, 9   @ bitWidth 1 (Capture/Compare 3 output
  Polarity)  
        .equ TIM8_CC3E_Shift, 8   @ bitWidth 1 (Capture/Compare 3 output
  enable)  
        .equ TIM8_CC2NP_Shift, 7   @ bitWidth 1 (Capture/Compare 2 output
  Polarity)  
        .equ TIM8_CC2NE_Shift, 6   @ bitWidth 1 (Capture/Compare 2 complementary output
  enable)  
        .equ TIM8_CC2P_Shift, 5   @ bitWidth 1 (Capture/Compare 2 output
  Polarity)  
        .equ TIM8_CC2E_Shift, 4   @ bitWidth 1 (Capture/Compare 2 output
  enable)  
        .equ TIM8_CC1NP_Shift, 3   @ bitWidth 1 (Capture/Compare 1 output
  Polarity)  
        .equ TIM8_CC1NE_Shift, 2   @ bitWidth 1 (Capture/Compare 1 complementary output
  enable)  
        .equ TIM8_CC1P_Shift, 1   @ bitWidth 1 (Capture/Compare 1 output
  Polarity)  
        .equ TIM8_CC1E_Shift, 0   @ bitWidth 1 (Capture/Compare 1 output
  enable)  
 
    .equ TIM8_CNT, TIM8_BASE + 0x24 @ (counter) 
        .equ TIM8_CNT_Shift, 0   @ bitWidth 16 (counter value)  
 
    .equ TIM8_PSC, TIM8_BASE + 0x28 @ (prescaler) 
        .equ TIM8_PSC_Shift, 0   @ bitWidth 16 (Prescaler value)  
 
    .equ TIM8_ARR, TIM8_BASE + 0x2C @ (auto-reload register) 
        .equ TIM8_ARR_Shift, 0   @ bitWidth 16 (Auto-reload value)  
 
    .equ TIM8_CCR1, TIM8_BASE + 0x34 @ (capture/compare register 1) 
        .equ TIM8_CCR1_Shift, 0   @ bitWidth 16 (Capture/Compare 1 value)  
 
    .equ TIM8_CCR2, TIM8_BASE + 0x38 @ (capture/compare register 2) 
        .equ TIM8_CCR2_Shift, 0   @ bitWidth 16 (Capture/Compare 2 value)  
 
    .equ TIM8_CCR3, TIM8_BASE + 0x3C @ (capture/compare register 3) 
        .equ TIM8_CCR3_Shift, 0   @ bitWidth 16 (Capture/Compare value)  
 
    .equ TIM8_CCR4, TIM8_BASE + 0x40 @ (capture/compare register 4) 
        .equ TIM8_CCR4_Shift, 0   @ bitWidth 16 (Capture/Compare value)  
 
    .equ TIM8_DCR, TIM8_BASE + 0x48 @ (DMA control register) 
        .equ TIM8_DBL_Shift, 8   @ bitWidth 5 (DMA burst length)  
        .equ TIM8_DBA_Shift, 0   @ bitWidth 5 (DMA base address)  
 
    .equ TIM8_DMAR, TIM8_BASE + 0x4C @ (DMA address for full transfer) 
        .equ TIM8_DMAB_Shift, 0   @ bitWidth 16 (DMA register for burst
  accesses)  
 
    .equ TIM8_RCR, TIM8_BASE + 0x30 @ (repetition counter register) 
        .equ TIM8_REP_Shift, 0   @ bitWidth 8 (Repetition counter value)  
 
    .equ TIM8_BDTR, TIM8_BASE + 0x44 @ (break and dead-time register) 
        .equ TIM8_MOE_Shift, 15   @ bitWidth 1 (Main output enable)  
        .equ TIM8_AOE_Shift, 14   @ bitWidth 1 (Automatic output enable)  
        .equ TIM8_BKP_Shift, 13   @ bitWidth 1 (Break polarity)  
        .equ TIM8_BKE_Shift, 12   @ bitWidth 1 (Break enable)  
        .equ TIM8_OSSR_Shift, 11   @ bitWidth 1 (Off-state selection for Run
  mode)  
        .equ TIM8_OSSI_Shift, 10   @ bitWidth 1 (Off-state selection for Idle
  mode)  
        .equ TIM8_LOCK_Shift, 8   @ bitWidth 2 (Lock configuration)  
        .equ TIM8_DTG_Shift, 0   @ bitWidth 8 (Dead-time generator setup)  
 

@=========================== TIM10 ===========================@
.equ TIM10_BASE, 0x40014400 @ (General-purpose-timers) 
    .equ TIM10_CR1, TIM10_BASE + 0x0 @ (control register 1) 
        .equ TIM10_CKD_Shift, 8   @ bitWidth 2 (Clock division)  
        .equ TIM10_ARPE_Shift, 7   @ bitWidth 1 (Auto-reload preload enable)  
        .equ TIM10_URS_Shift, 2   @ bitWidth 1 (Update request source)  
        .equ TIM10_UDIS_Shift, 1   @ bitWidth 1 (Update disable)  
        .equ TIM10_CEN_Shift, 0   @ bitWidth 1 (Counter enable)  
 
    .equ TIM10_DIER, TIM10_BASE + 0xC @ (DMA/Interrupt enable register) 
        .equ TIM10_CC1IE_Shift, 1   @ bitWidth 1 (Capture/Compare 1 interrupt
  enable)  
        .equ TIM10_UIE_Shift, 0   @ bitWidth 1 (Update interrupt enable)  
 
    .equ TIM10_SR, TIM10_BASE + 0x10 @ (status register) 
        .equ TIM10_CC1OF_Shift, 9   @ bitWidth 1 (Capture/Compare 1 overcapture
  flag)  
        .equ TIM10_CC1IF_Shift, 1   @ bitWidth 1 (Capture/compare 1 interrupt
  flag)  
        .equ TIM10_UIF_Shift, 0   @ bitWidth 1 (Update interrupt flag)  
 
    .equ TIM10_EGR, TIM10_BASE + 0x14 @ (event generation register) 
        .equ TIM10_CC1G_Shift, 1   @ bitWidth 1 (Capture/compare 1
  generation)  
        .equ TIM10_UG_Shift, 0   @ bitWidth 1 (Update generation)  
 
    .equ TIM10_CCMR1_Output, TIM10_BASE + 0x18 @ (capture/compare mode register 1 output
  mode) 
        .equ TIM10_OC1M_Shift, 4   @ bitWidth 3 (Output Compare 1 mode)  
        .equ TIM10_OC1PE_Shift, 3   @ bitWidth 1 (Output Compare 1 preload
  enable)  
        .equ TIM10_OC1FE_Shift, 2   @ bitWidth 1 (Output Compare 1 fast
  enable)  
        .equ TIM10_CC1S_Shift, 0   @ bitWidth 2 (Capture/Compare 1
  selection)  
 
    .equ TIM10_CCMR1_Input, TIM10_BASE + 0x18 @ (capture/compare mode register 1 input
  mode) 
        .equ TIM10_IC1F_Shift, 4   @ bitWidth 4 (Input capture 1 filter)  
        .equ TIM10_ICPCS_Shift, 2   @ bitWidth 2 (Input capture 1 prescaler)  
        .equ TIM10_CC1S_Shift, 0   @ bitWidth 2 (Capture/Compare 1
  selection)  
 
    .equ TIM10_CCER, TIM10_BASE + 0x20 @ (capture/compare enable
  register) 
        .equ TIM10_CC1NP_Shift, 3   @ bitWidth 1 (Capture/Compare 1 output
  Polarity)  
        .equ TIM10_CC1P_Shift, 1   @ bitWidth 1 (Capture/Compare 1 output
  Polarity)  
        .equ TIM10_CC1E_Shift, 0   @ bitWidth 1 (Capture/Compare 1 output
  enable)  
 
    .equ TIM10_CNT, TIM10_BASE + 0x24 @ (counter) 
        .equ TIM10_CNT_Shift, 0   @ bitWidth 16 (counter value)  
 
    .equ TIM10_PSC, TIM10_BASE + 0x28 @ (prescaler) 
        .equ TIM10_PSC_Shift, 0   @ bitWidth 16 (Prescaler value)  
 
    .equ TIM10_ARR, TIM10_BASE + 0x2C @ (auto-reload register) 
        .equ TIM10_ARR_Shift, 0   @ bitWidth 16 (Auto-reload value)  
 
    .equ TIM10_CCR1, TIM10_BASE + 0x34 @ (capture/compare register 1) 
        .equ TIM10_CCR1_Shift, 0   @ bitWidth 16 (Capture/Compare 1 value)  
 

@=========================== TIM11 ===========================@
.equ TIM11_BASE, 0x40014800 @ (General-purpose-timers) 
    .equ TIM11_CR1, TIM11_BASE + 0x0 @ (control register 1) 
        .equ TIM11_CKD_Shift, 8   @ bitWidth 2 (Clock division)  
        .equ TIM11_ARPE_Shift, 7   @ bitWidth 1 (Auto-reload preload enable)  
        .equ TIM11_URS_Shift, 2   @ bitWidth 1 (Update request source)  
        .equ TIM11_UDIS_Shift, 1   @ bitWidth 1 (Update disable)  
        .equ TIM11_CEN_Shift, 0   @ bitWidth 1 (Counter enable)  
 
    .equ TIM11_DIER, TIM11_BASE + 0xC @ (DMA/Interrupt enable register) 
        .equ TIM11_CC1IE_Shift, 1   @ bitWidth 1 (Capture/Compare 1 interrupt
  enable)  
        .equ TIM11_UIE_Shift, 0   @ bitWidth 1 (Update interrupt enable)  
 
    .equ TIM11_SR, TIM11_BASE + 0x10 @ (status register) 
        .equ TIM11_CC1OF_Shift, 9   @ bitWidth 1 (Capture/Compare 1 overcapture
  flag)  
        .equ TIM11_CC1IF_Shift, 1   @ bitWidth 1 (Capture/compare 1 interrupt
  flag)  
        .equ TIM11_UIF_Shift, 0   @ bitWidth 1 (Update interrupt flag)  
 
    .equ TIM11_EGR, TIM11_BASE + 0x14 @ (event generation register) 
        .equ TIM11_CC1G_Shift, 1   @ bitWidth 1 (Capture/compare 1
  generation)  
        .equ TIM11_UG_Shift, 0   @ bitWidth 1 (Update generation)  
 
    .equ TIM11_CCMR1_Output, TIM11_BASE + 0x18 @ (capture/compare mode register 1 output
  mode) 
        .equ TIM11_OC1M_Shift, 4   @ bitWidth 3 (Output Compare 1 mode)  
        .equ TIM11_OC1PE_Shift, 3   @ bitWidth 1 (Output Compare 1 preload
  enable)  
        .equ TIM11_OC1FE_Shift, 2   @ bitWidth 1 (Output Compare 1 fast
  enable)  
        .equ TIM11_CC1S_Shift, 0   @ bitWidth 2 (Capture/Compare 1
  selection)  
 
    .equ TIM11_CCMR1_Input, TIM11_BASE + 0x18 @ (capture/compare mode register 1 input
  mode) 
        .equ TIM11_IC1F_Shift, 4   @ bitWidth 4 (Input capture 1 filter)  
        .equ TIM11_ICPCS_Shift, 2   @ bitWidth 2 (Input capture 1 prescaler)  
        .equ TIM11_CC1S_Shift, 0   @ bitWidth 2 (Capture/Compare 1
  selection)  
 
    .equ TIM11_CCER, TIM11_BASE + 0x20 @ (capture/compare enable
  register) 
        .equ TIM11_CC1NP_Shift, 3   @ bitWidth 1 (Capture/Compare 1 output
  Polarity)  
        .equ TIM11_CC1P_Shift, 1   @ bitWidth 1 (Capture/Compare 1 output
  Polarity)  
        .equ TIM11_CC1E_Shift, 0   @ bitWidth 1 (Capture/Compare 1 output
  enable)  
 
    .equ TIM11_CNT, TIM11_BASE + 0x24 @ (counter) 
        .equ TIM11_CNT_Shift, 0   @ bitWidth 16 (counter value)  
 
    .equ TIM11_PSC, TIM11_BASE + 0x28 @ (prescaler) 
        .equ TIM11_PSC_Shift, 0   @ bitWidth 16 (Prescaler value)  
 
    .equ TIM11_ARR, TIM11_BASE + 0x2C @ (auto-reload register) 
        .equ TIM11_ARR_Shift, 0   @ bitWidth 16 (Auto-reload value)  
 
    .equ TIM11_CCR1, TIM11_BASE + 0x34 @ (capture/compare register 1) 
        .equ TIM11_CCR1_Shift, 0   @ bitWidth 16 (Capture/Compare 1 value)  
 
    .equ TIM11_OR, TIM11_BASE + 0x50 @ (option register) 
        .equ TIM11_RMP_Shift, 0   @ bitWidth 2 (Input 1 remapping
  capability)  
 

@=========================== TIM2 ===========================@
.equ TIM2_BASE, 0x40000000 @ (General purpose timers) 
    .equ TIM2_CR1, TIM2_BASE + 0x0 @ (control register 1) 
        .equ TIM2_CKD_Shift, 8   @ bitWidth 2 (Clock division)  
        .equ TIM2_ARPE_Shift, 7   @ bitWidth 1 (Auto-reload preload enable)  
        .equ TIM2_CMS_Shift, 5   @ bitWidth 2 (Center-aligned mode
  selection)  
        .equ TIM2_DIR_Shift, 4   @ bitWidth 1 (Direction)  
        .equ TIM2_OPM_Shift, 3   @ bitWidth 1 (One-pulse mode)  
        .equ TIM2_URS_Shift, 2   @ bitWidth 1 (Update request source)  
        .equ TIM2_UDIS_Shift, 1   @ bitWidth 1 (Update disable)  
        .equ TIM2_CEN_Shift, 0   @ bitWidth 1 (Counter enable)  
 
    .equ TIM2_CR2, TIM2_BASE + 0x4 @ (control register 2) 
        .equ TIM2_TI1S_Shift, 7   @ bitWidth 1 (TI1 selection)  
        .equ TIM2_MMS_Shift, 4   @ bitWidth 3 (Master mode selection)  
        .equ TIM2_CCDS_Shift, 3   @ bitWidth 1 (Capture/compare DMA
  selection)  
 
    .equ TIM2_SMCR, TIM2_BASE + 0x8 @ (slave mode control register) 
        .equ TIM2_ETP_Shift, 15   @ bitWidth 1 (External trigger polarity)  
        .equ TIM2_ECE_Shift, 14   @ bitWidth 1 (External clock enable)  
        .equ TIM2_ETPS_Shift, 12   @ bitWidth 2 (External trigger prescaler)  
        .equ TIM2_ETF_Shift, 8   @ bitWidth 4 (External trigger filter)  
        .equ TIM2_MSM_Shift, 7   @ bitWidth 1 (Master/Slave mode)  
        .equ TIM2_TS_Shift, 4   @ bitWidth 3 (Trigger selection)  
        .equ TIM2_SMS_Shift, 0   @ bitWidth 3 (Slave mode selection)  
 
    .equ TIM2_DIER, TIM2_BASE + 0xC @ (DMA/Interrupt enable register) 
        .equ TIM2_TDE_Shift, 14   @ bitWidth 1 (Trigger DMA request enable)  
        .equ TIM2_CC4DE_Shift, 12   @ bitWidth 1 (Capture/Compare 4 DMA request
  enable)  
        .equ TIM2_CC3DE_Shift, 11   @ bitWidth 1 (Capture/Compare 3 DMA request
  enable)  
        .equ TIM2_CC2DE_Shift, 10   @ bitWidth 1 (Capture/Compare 2 DMA request
  enable)  
        .equ TIM2_CC1DE_Shift, 9   @ bitWidth 1 (Capture/Compare 1 DMA request
  enable)  
        .equ TIM2_UDE_Shift, 8   @ bitWidth 1 (Update DMA request enable)  
        .equ TIM2_TIE_Shift, 6   @ bitWidth 1 (Trigger interrupt enable)  
        .equ TIM2_CC4IE_Shift, 4   @ bitWidth 1 (Capture/Compare 4 interrupt
  enable)  
        .equ TIM2_CC3IE_Shift, 3   @ bitWidth 1 (Capture/Compare 3 interrupt
  enable)  
        .equ TIM2_CC2IE_Shift, 2   @ bitWidth 1 (Capture/Compare 2 interrupt
  enable)  
        .equ TIM2_CC1IE_Shift, 1   @ bitWidth 1 (Capture/Compare 1 interrupt
  enable)  
        .equ TIM2_UIE_Shift, 0   @ bitWidth 1 (Update interrupt enable)  
 
    .equ TIM2_SR, TIM2_BASE + 0x10 @ (status register) 
        .equ TIM2_CC4OF_Shift, 12   @ bitWidth 1 (Capture/Compare 4 overcapture
  flag)  
        .equ TIM2_CC3OF_Shift, 11   @ bitWidth 1 (Capture/Compare 3 overcapture
  flag)  
        .equ TIM2_CC2OF_Shift, 10   @ bitWidth 1 (Capture/compare 2 overcapture
  flag)  
        .equ TIM2_CC1OF_Shift, 9   @ bitWidth 1 (Capture/Compare 1 overcapture
  flag)  
        .equ TIM2_TIF_Shift, 6   @ bitWidth 1 (Trigger interrupt flag)  
        .equ TIM2_CC4IF_Shift, 4   @ bitWidth 1 (Capture/Compare 4 interrupt
  flag)  
        .equ TIM2_CC3IF_Shift, 3   @ bitWidth 1 (Capture/Compare 3 interrupt
  flag)  
        .equ TIM2_CC2IF_Shift, 2   @ bitWidth 1 (Capture/Compare 2 interrupt
  flag)  
        .equ TIM2_CC1IF_Shift, 1   @ bitWidth 1 (Capture/compare 1 interrupt
  flag)  
        .equ TIM2_UIF_Shift, 0   @ bitWidth 1 (Update interrupt flag)  
 
    .equ TIM2_EGR, TIM2_BASE + 0x14 @ (event generation register) 
        .equ TIM2_TG_Shift, 6   @ bitWidth 1 (Trigger generation)  
        .equ TIM2_CC4G_Shift, 4   @ bitWidth 1 (Capture/compare 4
  generation)  
        .equ TIM2_CC3G_Shift, 3   @ bitWidth 1 (Capture/compare 3
  generation)  
        .equ TIM2_CC2G_Shift, 2   @ bitWidth 1 (Capture/compare 2
  generation)  
        .equ TIM2_CC1G_Shift, 1   @ bitWidth 1 (Capture/compare 1
  generation)  
        .equ TIM2_UG_Shift, 0   @ bitWidth 1 (Update generation)  
 
    .equ TIM2_CCMR1_Output, TIM2_BASE + 0x18 @ (capture/compare mode register 1 output
  mode) 
        .equ TIM2_OC2CE_Shift, 15   @ bitWidth 1 (OC2CE)  
        .equ TIM2_OC2M_Shift, 12   @ bitWidth 3 (OC2M)  
        .equ TIM2_OC2PE_Shift, 11   @ bitWidth 1 (OC2PE)  
        .equ TIM2_OC2FE_Shift, 10   @ bitWidth 1 (OC2FE)  
        .equ TIM2_CC2S_Shift, 8   @ bitWidth 2 (CC2S)  
        .equ TIM2_OC1CE_Shift, 7   @ bitWidth 1 (OC1CE)  
        .equ TIM2_OC1M_Shift, 4   @ bitWidth 3 (OC1M)  
        .equ TIM2_OC1PE_Shift, 3   @ bitWidth 1 (OC1PE)  
        .equ TIM2_OC1FE_Shift, 2   @ bitWidth 1 (OC1FE)  
        .equ TIM2_CC1S_Shift, 0   @ bitWidth 2 (CC1S)  
 
    .equ TIM2_CCMR1_Input, TIM2_BASE + 0x18 @ (capture/compare mode register 1 input
  mode) 
        .equ TIM2_IC2F_Shift, 12   @ bitWidth 4 (Input capture 2 filter)  
        .equ TIM2_IC2PCS_Shift, 10   @ bitWidth 2 (Input capture 2 prescaler)  
        .equ TIM2_CC2S_Shift, 8   @ bitWidth 2 (Capture/Compare 2
  selection)  
        .equ TIM2_IC1F_Shift, 4   @ bitWidth 4 (Input capture 1 filter)  
        .equ TIM2_ICPCS_Shift, 2   @ bitWidth 2 (Input capture 1 prescaler)  
        .equ TIM2_CC1S_Shift, 0   @ bitWidth 2 (Capture/Compare 1
  selection)  
 
    .equ TIM2_CCMR2_Output, TIM2_BASE + 0x1C @ (capture/compare mode register 2 output
  mode) 
        .equ TIM2_O24CE_Shift, 15   @ bitWidth 1 (O24CE)  
        .equ TIM2_OC4M_Shift, 12   @ bitWidth 3 (OC4M)  
        .equ TIM2_OC4PE_Shift, 11   @ bitWidth 1 (OC4PE)  
        .equ TIM2_OC4FE_Shift, 10   @ bitWidth 1 (OC4FE)  
        .equ TIM2_CC4S_Shift, 8   @ bitWidth 2 (CC4S)  
        .equ TIM2_OC3CE_Shift, 7   @ bitWidth 1 (OC3CE)  
        .equ TIM2_OC3M_Shift, 4   @ bitWidth 3 (OC3M)  
        .equ TIM2_OC3PE_Shift, 3   @ bitWidth 1 (OC3PE)  
        .equ TIM2_OC3FE_Shift, 2   @ bitWidth 1 (OC3FE)  
        .equ TIM2_CC3S_Shift, 0   @ bitWidth 2 (CC3S)  
 
    .equ TIM2_CCMR2_Input, TIM2_BASE + 0x1C @ (capture/compare mode register 2 input
  mode) 
        .equ TIM2_IC4F_Shift, 12   @ bitWidth 4 (Input capture 4 filter)  
        .equ TIM2_IC4PSC_Shift, 10   @ bitWidth 2 (Input capture 4 prescaler)  
        .equ TIM2_CC4S_Shift, 8   @ bitWidth 2 (Capture/Compare 4
  selection)  
        .equ TIM2_IC3F_Shift, 4   @ bitWidth 4 (Input capture 3 filter)  
        .equ TIM2_IC3PSC_Shift, 2   @ bitWidth 2 (Input capture 3 prescaler)  
        .equ TIM2_CC3S_Shift, 0   @ bitWidth 2 (Capture/compare 3
  selection)  
 
    .equ TIM2_CCER, TIM2_BASE + 0x20 @ (capture/compare enable
  register) 
        .equ TIM2_CC4NP_Shift, 15   @ bitWidth 1 (Capture/Compare 4 output
  Polarity)  
        .equ TIM2_CC4P_Shift, 13   @ bitWidth 1 (Capture/Compare 3 output
  Polarity)  
        .equ TIM2_CC4E_Shift, 12   @ bitWidth 1 (Capture/Compare 4 output
  enable)  
        .equ TIM2_CC3NP_Shift, 11   @ bitWidth 1 (Capture/Compare 3 output
  Polarity)  
        .equ TIM2_CC3P_Shift, 9   @ bitWidth 1 (Capture/Compare 3 output
  Polarity)  
        .equ TIM2_CC3E_Shift, 8   @ bitWidth 1 (Capture/Compare 3 output
  enable)  
        .equ TIM2_CC2NP_Shift, 7   @ bitWidth 1 (Capture/Compare 2 output
  Polarity)  
        .equ TIM2_CC2P_Shift, 5   @ bitWidth 1 (Capture/Compare 2 output
  Polarity)  
        .equ TIM2_CC2E_Shift, 4   @ bitWidth 1 (Capture/Compare 2 output
  enable)  
        .equ TIM2_CC1NP_Shift, 3   @ bitWidth 1 (Capture/Compare 1 output
  Polarity)  
        .equ TIM2_CC1P_Shift, 1   @ bitWidth 1 (Capture/Compare 1 output
  Polarity)  
        .equ TIM2_CC1E_Shift, 0   @ bitWidth 1 (Capture/Compare 1 output
  enable)  
 
    .equ TIM2_CNT, TIM2_BASE + 0x24 @ (counter) 
        .equ TIM2_CNT_H_Shift, 16   @ bitWidth 16 (High counter value)  
        .equ TIM2_CNT_L_Shift, 0   @ bitWidth 16 (Low counter value)  
 
    .equ TIM2_PSC, TIM2_BASE + 0x28 @ (prescaler) 
        .equ TIM2_PSC_Shift, 0   @ bitWidth 16 (Prescaler value)  
 
    .equ TIM2_ARR, TIM2_BASE + 0x2C @ (auto-reload register) 
        .equ TIM2_ARR_H_Shift, 16   @ bitWidth 16 (High Auto-reload value)  
        .equ TIM2_ARR_L_Shift, 0   @ bitWidth 16 (Low Auto-reload value)  
 
    .equ TIM2_CCR1, TIM2_BASE + 0x34 @ (capture/compare register 1) 
        .equ TIM2_CCR1_H_Shift, 16   @ bitWidth 16 (High Capture/Compare 1
  value)  
        .equ TIM2_CCR1_L_Shift, 0   @ bitWidth 16 (Low Capture/Compare 1
  value)  
 
    .equ TIM2_CCR2, TIM2_BASE + 0x38 @ (capture/compare register 2) 
        .equ TIM2_CCR2_H_Shift, 16   @ bitWidth 16 (High Capture/Compare 2
  value)  
        .equ TIM2_CCR2_L_Shift, 0   @ bitWidth 16 (Low Capture/Compare 2
  value)  
 
    .equ TIM2_CCR3, TIM2_BASE + 0x3C @ (capture/compare register 3) 
        .equ TIM2_CCR3_H_Shift, 16   @ bitWidth 16 (High Capture/Compare value)  
        .equ TIM2_CCR3_L_Shift, 0   @ bitWidth 16 (Low Capture/Compare value)  
 
    .equ TIM2_CCR4, TIM2_BASE + 0x40 @ (capture/compare register 4) 
        .equ TIM2_CCR4_H_Shift, 16   @ bitWidth 16 (High Capture/Compare value)  
        .equ TIM2_CCR4_L_Shift, 0   @ bitWidth 16 (Low Capture/Compare value)  
 
    .equ TIM2_DCR, TIM2_BASE + 0x48 @ (DMA control register) 
        .equ TIM2_DBL_Shift, 8   @ bitWidth 5 (DMA burst length)  
        .equ TIM2_DBA_Shift, 0   @ bitWidth 5 (DMA base address)  
 
    .equ TIM2_DMAR, TIM2_BASE + 0x4C @ (DMA address for full transfer) 
        .equ TIM2_DMAB_Shift, 0   @ bitWidth 16 (DMA register for burst
  accesses)  
 
    .equ TIM2_OR, TIM2_BASE + 0x50 @ (TIM5 option register) 
        .equ TIM2_ITR1_RMP_Shift, 10   @ bitWidth 2 (Timer Input 4 remap)  
 

@=========================== TIM3 ===========================@
.equ TIM3_BASE, 0x40000400 @ (General purpose timers) 
    .equ TIM3_CR1, TIM3_BASE + 0x0 @ (control register 1) 
        .equ TIM3_CKD_Shift, 8   @ bitWidth 2 (Clock division)  
        .equ TIM3_ARPE_Shift, 7   @ bitWidth 1 (Auto-reload preload enable)  
        .equ TIM3_CMS_Shift, 5   @ bitWidth 2 (Center-aligned mode
  selection)  
        .equ TIM3_DIR_Shift, 4   @ bitWidth 1 (Direction)  
        .equ TIM3_OPM_Shift, 3   @ bitWidth 1 (One-pulse mode)  
        .equ TIM3_URS_Shift, 2   @ bitWidth 1 (Update request source)  
        .equ TIM3_UDIS_Shift, 1   @ bitWidth 1 (Update disable)  
        .equ TIM3_CEN_Shift, 0   @ bitWidth 1 (Counter enable)  
 
    .equ TIM3_CR2, TIM3_BASE + 0x4 @ (control register 2) 
        .equ TIM3_TI1S_Shift, 7   @ bitWidth 1 (TI1 selection)  
        .equ TIM3_MMS_Shift, 4   @ bitWidth 3 (Master mode selection)  
        .equ TIM3_CCDS_Shift, 3   @ bitWidth 1 (Capture/compare DMA
  selection)  
 
    .equ TIM3_SMCR, TIM3_BASE + 0x8 @ (slave mode control register) 
        .equ TIM3_ETP_Shift, 15   @ bitWidth 1 (External trigger polarity)  
        .equ TIM3_ECE_Shift, 14   @ bitWidth 1 (External clock enable)  
        .equ TIM3_ETPS_Shift, 12   @ bitWidth 2 (External trigger prescaler)  
        .equ TIM3_ETF_Shift, 8   @ bitWidth 4 (External trigger filter)  
        .equ TIM3_MSM_Shift, 7   @ bitWidth 1 (Master/Slave mode)  
        .equ TIM3_TS_Shift, 4   @ bitWidth 3 (Trigger selection)  
        .equ TIM3_SMS_Shift, 0   @ bitWidth 3 (Slave mode selection)  
 
    .equ TIM3_DIER, TIM3_BASE + 0xC @ (DMA/Interrupt enable register) 
        .equ TIM3_TDE_Shift, 14   @ bitWidth 1 (Trigger DMA request enable)  
        .equ TIM3_CC4DE_Shift, 12   @ bitWidth 1 (Capture/Compare 4 DMA request
  enable)  
        .equ TIM3_CC3DE_Shift, 11   @ bitWidth 1 (Capture/Compare 3 DMA request
  enable)  
        .equ TIM3_CC2DE_Shift, 10   @ bitWidth 1 (Capture/Compare 2 DMA request
  enable)  
        .equ TIM3_CC1DE_Shift, 9   @ bitWidth 1 (Capture/Compare 1 DMA request
  enable)  
        .equ TIM3_UDE_Shift, 8   @ bitWidth 1 (Update DMA request enable)  
        .equ TIM3_TIE_Shift, 6   @ bitWidth 1 (Trigger interrupt enable)  
        .equ TIM3_CC4IE_Shift, 4   @ bitWidth 1 (Capture/Compare 4 interrupt
  enable)  
        .equ TIM3_CC3IE_Shift, 3   @ bitWidth 1 (Capture/Compare 3 interrupt
  enable)  
        .equ TIM3_CC2IE_Shift, 2   @ bitWidth 1 (Capture/Compare 2 interrupt
  enable)  
        .equ TIM3_CC1IE_Shift, 1   @ bitWidth 1 (Capture/Compare 1 interrupt
  enable)  
        .equ TIM3_UIE_Shift, 0   @ bitWidth 1 (Update interrupt enable)  
 
    .equ TIM3_SR, TIM3_BASE + 0x10 @ (status register) 
        .equ TIM3_CC4OF_Shift, 12   @ bitWidth 1 (Capture/Compare 4 overcapture
  flag)  
        .equ TIM3_CC3OF_Shift, 11   @ bitWidth 1 (Capture/Compare 3 overcapture
  flag)  
        .equ TIM3_CC2OF_Shift, 10   @ bitWidth 1 (Capture/compare 2 overcapture
  flag)  
        .equ TIM3_CC1OF_Shift, 9   @ bitWidth 1 (Capture/Compare 1 overcapture
  flag)  
        .equ TIM3_TIF_Shift, 6   @ bitWidth 1 (Trigger interrupt flag)  
        .equ TIM3_CC4IF_Shift, 4   @ bitWidth 1 (Capture/Compare 4 interrupt
  flag)  
        .equ TIM3_CC3IF_Shift, 3   @ bitWidth 1 (Capture/Compare 3 interrupt
  flag)  
        .equ TIM3_CC2IF_Shift, 2   @ bitWidth 1 (Capture/Compare 2 interrupt
  flag)  
        .equ TIM3_CC1IF_Shift, 1   @ bitWidth 1 (Capture/compare 1 interrupt
  flag)  
        .equ TIM3_UIF_Shift, 0   @ bitWidth 1 (Update interrupt flag)  
 
    .equ TIM3_EGR, TIM3_BASE + 0x14 @ (event generation register) 
        .equ TIM3_TG_Shift, 6   @ bitWidth 1 (Trigger generation)  
        .equ TIM3_CC4G_Shift, 4   @ bitWidth 1 (Capture/compare 4
  generation)  
        .equ TIM3_CC3G_Shift, 3   @ bitWidth 1 (Capture/compare 3
  generation)  
        .equ TIM3_CC2G_Shift, 2   @ bitWidth 1 (Capture/compare 2
  generation)  
        .equ TIM3_CC1G_Shift, 1   @ bitWidth 1 (Capture/compare 1
  generation)  
        .equ TIM3_UG_Shift, 0   @ bitWidth 1 (Update generation)  
 
    .equ TIM3_CCMR1_Output, TIM3_BASE + 0x18 @ (capture/compare mode register 1 output
  mode) 
        .equ TIM3_OC2CE_Shift, 15   @ bitWidth 1 (OC2CE)  
        .equ TIM3_OC2M_Shift, 12   @ bitWidth 3 (OC2M)  
        .equ TIM3_OC2PE_Shift, 11   @ bitWidth 1 (OC2PE)  
        .equ TIM3_OC2FE_Shift, 10   @ bitWidth 1 (OC2FE)  
        .equ TIM3_CC2S_Shift, 8   @ bitWidth 2 (CC2S)  
        .equ TIM3_OC1CE_Shift, 7   @ bitWidth 1 (OC1CE)  
        .equ TIM3_OC1M_Shift, 4   @ bitWidth 3 (OC1M)  
        .equ TIM3_OC1PE_Shift, 3   @ bitWidth 1 (OC1PE)  
        .equ TIM3_OC1FE_Shift, 2   @ bitWidth 1 (OC1FE)  
        .equ TIM3_CC1S_Shift, 0   @ bitWidth 2 (CC1S)  
 
    .equ TIM3_CCMR1_Input, TIM3_BASE + 0x18 @ (capture/compare mode register 1 input
  mode) 
        .equ TIM3_IC2F_Shift, 12   @ bitWidth 4 (Input capture 2 filter)  
        .equ TIM3_IC2PCS_Shift, 10   @ bitWidth 2 (Input capture 2 prescaler)  
        .equ TIM3_CC2S_Shift, 8   @ bitWidth 2 (Capture/Compare 2
  selection)  
        .equ TIM3_IC1F_Shift, 4   @ bitWidth 4 (Input capture 1 filter)  
        .equ TIM3_ICPCS_Shift, 2   @ bitWidth 2 (Input capture 1 prescaler)  
        .equ TIM3_CC1S_Shift, 0   @ bitWidth 2 (Capture/Compare 1
  selection)  
 
    .equ TIM3_CCMR2_Output, TIM3_BASE + 0x1C @ (capture/compare mode register 2 output
  mode) 
        .equ TIM3_O24CE_Shift, 15   @ bitWidth 1 (O24CE)  
        .equ TIM3_OC4M_Shift, 12   @ bitWidth 3 (OC4M)  
        .equ TIM3_OC4PE_Shift, 11   @ bitWidth 1 (OC4PE)  
        .equ TIM3_OC4FE_Shift, 10   @ bitWidth 1 (OC4FE)  
        .equ TIM3_CC4S_Shift, 8   @ bitWidth 2 (CC4S)  
        .equ TIM3_OC3CE_Shift, 7   @ bitWidth 1 (OC3CE)  
        .equ TIM3_OC3M_Shift, 4   @ bitWidth 3 (OC3M)  
        .equ TIM3_OC3PE_Shift, 3   @ bitWidth 1 (OC3PE)  
        .equ TIM3_OC3FE_Shift, 2   @ bitWidth 1 (OC3FE)  
        .equ TIM3_CC3S_Shift, 0   @ bitWidth 2 (CC3S)  
 
    .equ TIM3_CCMR2_Input, TIM3_BASE + 0x1C @ (capture/compare mode register 2 input
  mode) 
        .equ TIM3_IC4F_Shift, 12   @ bitWidth 4 (Input capture 4 filter)  
        .equ TIM3_IC4PSC_Shift, 10   @ bitWidth 2 (Input capture 4 prescaler)  
        .equ TIM3_CC4S_Shift, 8   @ bitWidth 2 (Capture/Compare 4
  selection)  
        .equ TIM3_IC3F_Shift, 4   @ bitWidth 4 (Input capture 3 filter)  
        .equ TIM3_IC3PSC_Shift, 2   @ bitWidth 2 (Input capture 3 prescaler)  
        .equ TIM3_CC3S_Shift, 0   @ bitWidth 2 (Capture/compare 3
  selection)  
 
    .equ TIM3_CCER, TIM3_BASE + 0x20 @ (capture/compare enable
  register) 
        .equ TIM3_CC4NP_Shift, 15   @ bitWidth 1 (Capture/Compare 4 output
  Polarity)  
        .equ TIM3_CC4P_Shift, 13   @ bitWidth 1 (Capture/Compare 3 output
  Polarity)  
        .equ TIM3_CC4E_Shift, 12   @ bitWidth 1 (Capture/Compare 4 output
  enable)  
        .equ TIM3_CC3NP_Shift, 11   @ bitWidth 1 (Capture/Compare 3 output
  Polarity)  
        .equ TIM3_CC3P_Shift, 9   @ bitWidth 1 (Capture/Compare 3 output
  Polarity)  
        .equ TIM3_CC3E_Shift, 8   @ bitWidth 1 (Capture/Compare 3 output
  enable)  
        .equ TIM3_CC2NP_Shift, 7   @ bitWidth 1 (Capture/Compare 2 output
  Polarity)  
        .equ TIM3_CC2P_Shift, 5   @ bitWidth 1 (Capture/Compare 2 output
  Polarity)  
        .equ TIM3_CC2E_Shift, 4   @ bitWidth 1 (Capture/Compare 2 output
  enable)  
        .equ TIM3_CC1NP_Shift, 3   @ bitWidth 1 (Capture/Compare 1 output
  Polarity)  
        .equ TIM3_CC1P_Shift, 1   @ bitWidth 1 (Capture/Compare 1 output
  Polarity)  
        .equ TIM3_CC1E_Shift, 0   @ bitWidth 1 (Capture/Compare 1 output
  enable)  
 
    .equ TIM3_CNT, TIM3_BASE + 0x24 @ (counter) 
        .equ TIM3_CNT_H_Shift, 16   @ bitWidth 16 (High counter value)  
        .equ TIM3_CNT_L_Shift, 0   @ bitWidth 16 (Low counter value)  
 
    .equ TIM3_PSC, TIM3_BASE + 0x28 @ (prescaler) 
        .equ TIM3_PSC_Shift, 0   @ bitWidth 16 (Prescaler value)  
 
    .equ TIM3_ARR, TIM3_BASE + 0x2C @ (auto-reload register) 
        .equ TIM3_ARR_H_Shift, 16   @ bitWidth 16 (High Auto-reload value)  
        .equ TIM3_ARR_L_Shift, 0   @ bitWidth 16 (Low Auto-reload value)  
 
    .equ TIM3_CCR1, TIM3_BASE + 0x34 @ (capture/compare register 1) 
        .equ TIM3_CCR1_H_Shift, 16   @ bitWidth 16 (High Capture/Compare 1
  value)  
        .equ TIM3_CCR1_L_Shift, 0   @ bitWidth 16 (Low Capture/Compare 1
  value)  
 
    .equ TIM3_CCR2, TIM3_BASE + 0x38 @ (capture/compare register 2) 
        .equ TIM3_CCR2_H_Shift, 16   @ bitWidth 16 (High Capture/Compare 2
  value)  
        .equ TIM3_CCR2_L_Shift, 0   @ bitWidth 16 (Low Capture/Compare 2
  value)  
 
    .equ TIM3_CCR3, TIM3_BASE + 0x3C @ (capture/compare register 3) 
        .equ TIM3_CCR3_H_Shift, 16   @ bitWidth 16 (High Capture/Compare value)  
        .equ TIM3_CCR3_L_Shift, 0   @ bitWidth 16 (Low Capture/Compare value)  
 
    .equ TIM3_CCR4, TIM3_BASE + 0x40 @ (capture/compare register 4) 
        .equ TIM3_CCR4_H_Shift, 16   @ bitWidth 16 (High Capture/Compare value)  
        .equ TIM3_CCR4_L_Shift, 0   @ bitWidth 16 (Low Capture/Compare value)  
 
    .equ TIM3_DCR, TIM3_BASE + 0x48 @ (DMA control register) 
        .equ TIM3_DBL_Shift, 8   @ bitWidth 5 (DMA burst length)  
        .equ TIM3_DBA_Shift, 0   @ bitWidth 5 (DMA base address)  
 
    .equ TIM3_DMAR, TIM3_BASE + 0x4C @ (DMA address for full transfer) 
        .equ TIM3_DMAB_Shift, 0   @ bitWidth 16 (DMA register for burst
  accesses)  
 

@=========================== TIM4 ===========================@
.equ TIM4_BASE, 0x40000800 @ (General purpose timers) 
    .equ TIM4_CR1, TIM4_BASE + 0x0 @ (control register 1) 
        .equ TIM4_CKD_Shift, 8   @ bitWidth 2 (Clock division)  
        .equ TIM4_ARPE_Shift, 7   @ bitWidth 1 (Auto-reload preload enable)  
        .equ TIM4_CMS_Shift, 5   @ bitWidth 2 (Center-aligned mode
  selection)  
        .equ TIM4_DIR_Shift, 4   @ bitWidth 1 (Direction)  
        .equ TIM4_OPM_Shift, 3   @ bitWidth 1 (One-pulse mode)  
        .equ TIM4_URS_Shift, 2   @ bitWidth 1 (Update request source)  
        .equ TIM4_UDIS_Shift, 1   @ bitWidth 1 (Update disable)  
        .equ TIM4_CEN_Shift, 0   @ bitWidth 1 (Counter enable)  
 
    .equ TIM4_CR2, TIM4_BASE + 0x4 @ (control register 2) 
        .equ TIM4_TI1S_Shift, 7   @ bitWidth 1 (TI1 selection)  
        .equ TIM4_MMS_Shift, 4   @ bitWidth 3 (Master mode selection)  
        .equ TIM4_CCDS_Shift, 3   @ bitWidth 1 (Capture/compare DMA
  selection)  
 
    .equ TIM4_SMCR, TIM4_BASE + 0x8 @ (slave mode control register) 
        .equ TIM4_ETP_Shift, 15   @ bitWidth 1 (External trigger polarity)  
        .equ TIM4_ECE_Shift, 14   @ bitWidth 1 (External clock enable)  
        .equ TIM4_ETPS_Shift, 12   @ bitWidth 2 (External trigger prescaler)  
        .equ TIM4_ETF_Shift, 8   @ bitWidth 4 (External trigger filter)  
        .equ TIM4_MSM_Shift, 7   @ bitWidth 1 (Master/Slave mode)  
        .equ TIM4_TS_Shift, 4   @ bitWidth 3 (Trigger selection)  
        .equ TIM4_SMS_Shift, 0   @ bitWidth 3 (Slave mode selection)  
 
    .equ TIM4_DIER, TIM4_BASE + 0xC @ (DMA/Interrupt enable register) 
        .equ TIM4_TDE_Shift, 14   @ bitWidth 1 (Trigger DMA request enable)  
        .equ TIM4_CC4DE_Shift, 12   @ bitWidth 1 (Capture/Compare 4 DMA request
  enable)  
        .equ TIM4_CC3DE_Shift, 11   @ bitWidth 1 (Capture/Compare 3 DMA request
  enable)  
        .equ TIM4_CC2DE_Shift, 10   @ bitWidth 1 (Capture/Compare 2 DMA request
  enable)  
        .equ TIM4_CC1DE_Shift, 9   @ bitWidth 1 (Capture/Compare 1 DMA request
  enable)  
        .equ TIM4_UDE_Shift, 8   @ bitWidth 1 (Update DMA request enable)  
        .equ TIM4_TIE_Shift, 6   @ bitWidth 1 (Trigger interrupt enable)  
        .equ TIM4_CC4IE_Shift, 4   @ bitWidth 1 (Capture/Compare 4 interrupt
  enable)  
        .equ TIM4_CC3IE_Shift, 3   @ bitWidth 1 (Capture/Compare 3 interrupt
  enable)  
        .equ TIM4_CC2IE_Shift, 2   @ bitWidth 1 (Capture/Compare 2 interrupt
  enable)  
        .equ TIM4_CC1IE_Shift, 1   @ bitWidth 1 (Capture/Compare 1 interrupt
  enable)  
        .equ TIM4_UIE_Shift, 0   @ bitWidth 1 (Update interrupt enable)  
 
    .equ TIM4_SR, TIM4_BASE + 0x10 @ (status register) 
        .equ TIM4_CC4OF_Shift, 12   @ bitWidth 1 (Capture/Compare 4 overcapture
  flag)  
        .equ TIM4_CC3OF_Shift, 11   @ bitWidth 1 (Capture/Compare 3 overcapture
  flag)  
        .equ TIM4_CC2OF_Shift, 10   @ bitWidth 1 (Capture/compare 2 overcapture
  flag)  
        .equ TIM4_CC1OF_Shift, 9   @ bitWidth 1 (Capture/Compare 1 overcapture
  flag)  
        .equ TIM4_TIF_Shift, 6   @ bitWidth 1 (Trigger interrupt flag)  
        .equ TIM4_CC4IF_Shift, 4   @ bitWidth 1 (Capture/Compare 4 interrupt
  flag)  
        .equ TIM4_CC3IF_Shift, 3   @ bitWidth 1 (Capture/Compare 3 interrupt
  flag)  
        .equ TIM4_CC2IF_Shift, 2   @ bitWidth 1 (Capture/Compare 2 interrupt
  flag)  
        .equ TIM4_CC1IF_Shift, 1   @ bitWidth 1 (Capture/compare 1 interrupt
  flag)  
        .equ TIM4_UIF_Shift, 0   @ bitWidth 1 (Update interrupt flag)  
 
    .equ TIM4_EGR, TIM4_BASE + 0x14 @ (event generation register) 
        .equ TIM4_TG_Shift, 6   @ bitWidth 1 (Trigger generation)  
        .equ TIM4_CC4G_Shift, 4   @ bitWidth 1 (Capture/compare 4
  generation)  
        .equ TIM4_CC3G_Shift, 3   @ bitWidth 1 (Capture/compare 3
  generation)  
        .equ TIM4_CC2G_Shift, 2   @ bitWidth 1 (Capture/compare 2
  generation)  
        .equ TIM4_CC1G_Shift, 1   @ bitWidth 1 (Capture/compare 1
  generation)  
        .equ TIM4_UG_Shift, 0   @ bitWidth 1 (Update generation)  
 
    .equ TIM4_CCMR1_Output, TIM4_BASE + 0x18 @ (capture/compare mode register 1 output
  mode) 
        .equ TIM4_OC2CE_Shift, 15   @ bitWidth 1 (OC2CE)  
        .equ TIM4_OC2M_Shift, 12   @ bitWidth 3 (OC2M)  
        .equ TIM4_OC2PE_Shift, 11   @ bitWidth 1 (OC2PE)  
        .equ TIM4_OC2FE_Shift, 10   @ bitWidth 1 (OC2FE)  
        .equ TIM4_CC2S_Shift, 8   @ bitWidth 2 (CC2S)  
        .equ TIM4_OC1CE_Shift, 7   @ bitWidth 1 (OC1CE)  
        .equ TIM4_OC1M_Shift, 4   @ bitWidth 3 (OC1M)  
        .equ TIM4_OC1PE_Shift, 3   @ bitWidth 1 (OC1PE)  
        .equ TIM4_OC1FE_Shift, 2   @ bitWidth 1 (OC1FE)  
        .equ TIM4_CC1S_Shift, 0   @ bitWidth 2 (CC1S)  
 
    .equ TIM4_CCMR1_Input, TIM4_BASE + 0x18 @ (capture/compare mode register 1 input
  mode) 
        .equ TIM4_IC2F_Shift, 12   @ bitWidth 4 (Input capture 2 filter)  
        .equ TIM4_IC2PCS_Shift, 10   @ bitWidth 2 (Input capture 2 prescaler)  
        .equ TIM4_CC2S_Shift, 8   @ bitWidth 2 (Capture/Compare 2
  selection)  
        .equ TIM4_IC1F_Shift, 4   @ bitWidth 4 (Input capture 1 filter)  
        .equ TIM4_ICPCS_Shift, 2   @ bitWidth 2 (Input capture 1 prescaler)  
        .equ TIM4_CC1S_Shift, 0   @ bitWidth 2 (Capture/Compare 1
  selection)  
 
    .equ TIM4_CCMR2_Output, TIM4_BASE + 0x1C @ (capture/compare mode register 2 output
  mode) 
        .equ TIM4_O24CE_Shift, 15   @ bitWidth 1 (O24CE)  
        .equ TIM4_OC4M_Shift, 12   @ bitWidth 3 (OC4M)  
        .equ TIM4_OC4PE_Shift, 11   @ bitWidth 1 (OC4PE)  
        .equ TIM4_OC4FE_Shift, 10   @ bitWidth 1 (OC4FE)  
        .equ TIM4_CC4S_Shift, 8   @ bitWidth 2 (CC4S)  
        .equ TIM4_OC3CE_Shift, 7   @ bitWidth 1 (OC3CE)  
        .equ TIM4_OC3M_Shift, 4   @ bitWidth 3 (OC3M)  
        .equ TIM4_OC3PE_Shift, 3   @ bitWidth 1 (OC3PE)  
        .equ TIM4_OC3FE_Shift, 2   @ bitWidth 1 (OC3FE)  
        .equ TIM4_CC3S_Shift, 0   @ bitWidth 2 (CC3S)  
 
    .equ TIM4_CCMR2_Input, TIM4_BASE + 0x1C @ (capture/compare mode register 2 input
  mode) 
        .equ TIM4_IC4F_Shift, 12   @ bitWidth 4 (Input capture 4 filter)  
        .equ TIM4_IC4PSC_Shift, 10   @ bitWidth 2 (Input capture 4 prescaler)  
        .equ TIM4_CC4S_Shift, 8   @ bitWidth 2 (Capture/Compare 4
  selection)  
        .equ TIM4_IC3F_Shift, 4   @ bitWidth 4 (Input capture 3 filter)  
        .equ TIM4_IC3PSC_Shift, 2   @ bitWidth 2 (Input capture 3 prescaler)  
        .equ TIM4_CC3S_Shift, 0   @ bitWidth 2 (Capture/compare 3
  selection)  
 
    .equ TIM4_CCER, TIM4_BASE + 0x20 @ (capture/compare enable
  register) 
        .equ TIM4_CC4NP_Shift, 15   @ bitWidth 1 (Capture/Compare 4 output
  Polarity)  
        .equ TIM4_CC4P_Shift, 13   @ bitWidth 1 (Capture/Compare 3 output
  Polarity)  
        .equ TIM4_CC4E_Shift, 12   @ bitWidth 1 (Capture/Compare 4 output
  enable)  
        .equ TIM4_CC3NP_Shift, 11   @ bitWidth 1 (Capture/Compare 3 output
  Polarity)  
        .equ TIM4_CC3P_Shift, 9   @ bitWidth 1 (Capture/Compare 3 output
  Polarity)  
        .equ TIM4_CC3E_Shift, 8   @ bitWidth 1 (Capture/Compare 3 output
  enable)  
        .equ TIM4_CC2NP_Shift, 7   @ bitWidth 1 (Capture/Compare 2 output
  Polarity)  
        .equ TIM4_CC2P_Shift, 5   @ bitWidth 1 (Capture/Compare 2 output
  Polarity)  
        .equ TIM4_CC2E_Shift, 4   @ bitWidth 1 (Capture/Compare 2 output
  enable)  
        .equ TIM4_CC1NP_Shift, 3   @ bitWidth 1 (Capture/Compare 1 output
  Polarity)  
        .equ TIM4_CC1P_Shift, 1   @ bitWidth 1 (Capture/Compare 1 output
  Polarity)  
        .equ TIM4_CC1E_Shift, 0   @ bitWidth 1 (Capture/Compare 1 output
  enable)  
 
    .equ TIM4_CNT, TIM4_BASE + 0x24 @ (counter) 
        .equ TIM4_CNT_H_Shift, 16   @ bitWidth 16 (High counter value)  
        .equ TIM4_CNT_L_Shift, 0   @ bitWidth 16 (Low counter value)  
 
    .equ TIM4_PSC, TIM4_BASE + 0x28 @ (prescaler) 
        .equ TIM4_PSC_Shift, 0   @ bitWidth 16 (Prescaler value)  
 
    .equ TIM4_ARR, TIM4_BASE + 0x2C @ (auto-reload register) 
        .equ TIM4_ARR_H_Shift, 16   @ bitWidth 16 (High Auto-reload value)  
        .equ TIM4_ARR_L_Shift, 0   @ bitWidth 16 (Low Auto-reload value)  
 
    .equ TIM4_CCR1, TIM4_BASE + 0x34 @ (capture/compare register 1) 
        .equ TIM4_CCR1_H_Shift, 16   @ bitWidth 16 (High Capture/Compare 1
  value)  
        .equ TIM4_CCR1_L_Shift, 0   @ bitWidth 16 (Low Capture/Compare 1
  value)  
 
    .equ TIM4_CCR2, TIM4_BASE + 0x38 @ (capture/compare register 2) 
        .equ TIM4_CCR2_H_Shift, 16   @ bitWidth 16 (High Capture/Compare 2
  value)  
        .equ TIM4_CCR2_L_Shift, 0   @ bitWidth 16 (Low Capture/Compare 2
  value)  
 
    .equ TIM4_CCR3, TIM4_BASE + 0x3C @ (capture/compare register 3) 
        .equ TIM4_CCR3_H_Shift, 16   @ bitWidth 16 (High Capture/Compare value)  
        .equ TIM4_CCR3_L_Shift, 0   @ bitWidth 16 (Low Capture/Compare value)  
 
    .equ TIM4_CCR4, TIM4_BASE + 0x40 @ (capture/compare register 4) 
        .equ TIM4_CCR4_H_Shift, 16   @ bitWidth 16 (High Capture/Compare value)  
        .equ TIM4_CCR4_L_Shift, 0   @ bitWidth 16 (Low Capture/Compare value)  
 
    .equ TIM4_DCR, TIM4_BASE + 0x48 @ (DMA control register) 
        .equ TIM4_DBL_Shift, 8   @ bitWidth 5 (DMA burst length)  
        .equ TIM4_DBA_Shift, 0   @ bitWidth 5 (DMA base address)  
 
    .equ TIM4_DMAR, TIM4_BASE + 0x4C @ (DMA address for full transfer) 
        .equ TIM4_DMAB_Shift, 0   @ bitWidth 16 (DMA register for burst
  accesses)  
 

@=========================== TIM5 ===========================@
.equ TIM5_BASE, 0x40000C00 @ (General-purpose-timers) 
    .equ TIM5_CR1, TIM5_BASE + 0x0 @ (control register 1) 
        .equ TIM5_CKD_Shift, 8   @ bitWidth 2 (Clock division)  
        .equ TIM5_ARPE_Shift, 7   @ bitWidth 1 (Auto-reload preload enable)  
        .equ TIM5_CMS_Shift, 5   @ bitWidth 2 (Center-aligned mode
  selection)  
        .equ TIM5_DIR_Shift, 4   @ bitWidth 1 (Direction)  
        .equ TIM5_OPM_Shift, 3   @ bitWidth 1 (One-pulse mode)  
        .equ TIM5_URS_Shift, 2   @ bitWidth 1 (Update request source)  
        .equ TIM5_UDIS_Shift, 1   @ bitWidth 1 (Update disable)  
        .equ TIM5_CEN_Shift, 0   @ bitWidth 1 (Counter enable)  
 
    .equ TIM5_CR2, TIM5_BASE + 0x4 @ (control register 2) 
        .equ TIM5_TI1S_Shift, 7   @ bitWidth 1 (TI1 selection)  
        .equ TIM5_MMS_Shift, 4   @ bitWidth 3 (Master mode selection)  
        .equ TIM5_CCDS_Shift, 3   @ bitWidth 1 (Capture/compare DMA
  selection)  
 
    .equ TIM5_SMCR, TIM5_BASE + 0x8 @ (slave mode control register) 
        .equ TIM5_ETP_Shift, 15   @ bitWidth 1 (External trigger polarity)  
        .equ TIM5_ECE_Shift, 14   @ bitWidth 1 (External clock enable)  
        .equ TIM5_ETPS_Shift, 12   @ bitWidth 2 (External trigger prescaler)  
        .equ TIM5_ETF_Shift, 8   @ bitWidth 4 (External trigger filter)  
        .equ TIM5_MSM_Shift, 7   @ bitWidth 1 (Master/Slave mode)  
        .equ TIM5_TS_Shift, 4   @ bitWidth 3 (Trigger selection)  
        .equ TIM5_SMS_Shift, 0   @ bitWidth 3 (Slave mode selection)  
 
    .equ TIM5_DIER, TIM5_BASE + 0xC @ (DMA/Interrupt enable register) 
        .equ TIM5_TDE_Shift, 14   @ bitWidth 1 (Trigger DMA request enable)  
        .equ TIM5_CC4DE_Shift, 12   @ bitWidth 1 (Capture/Compare 4 DMA request
  enable)  
        .equ TIM5_CC3DE_Shift, 11   @ bitWidth 1 (Capture/Compare 3 DMA request
  enable)  
        .equ TIM5_CC2DE_Shift, 10   @ bitWidth 1 (Capture/Compare 2 DMA request
  enable)  
        .equ TIM5_CC1DE_Shift, 9   @ bitWidth 1 (Capture/Compare 1 DMA request
  enable)  
        .equ TIM5_UDE_Shift, 8   @ bitWidth 1 (Update DMA request enable)  
        .equ TIM5_TIE_Shift, 6   @ bitWidth 1 (Trigger interrupt enable)  
        .equ TIM5_CC4IE_Shift, 4   @ bitWidth 1 (Capture/Compare 4 interrupt
  enable)  
        .equ TIM5_CC3IE_Shift, 3   @ bitWidth 1 (Capture/Compare 3 interrupt
  enable)  
        .equ TIM5_CC2IE_Shift, 2   @ bitWidth 1 (Capture/Compare 2 interrupt
  enable)  
        .equ TIM5_CC1IE_Shift, 1   @ bitWidth 1 (Capture/Compare 1 interrupt
  enable)  
        .equ TIM5_UIE_Shift, 0   @ bitWidth 1 (Update interrupt enable)  
 
    .equ TIM5_SR, TIM5_BASE + 0x10 @ (status register) 
        .equ TIM5_CC4OF_Shift, 12   @ bitWidth 1 (Capture/Compare 4 overcapture
  flag)  
        .equ TIM5_CC3OF_Shift, 11   @ bitWidth 1 (Capture/Compare 3 overcapture
  flag)  
        .equ TIM5_CC2OF_Shift, 10   @ bitWidth 1 (Capture/compare 2 overcapture
  flag)  
        .equ TIM5_CC1OF_Shift, 9   @ bitWidth 1 (Capture/Compare 1 overcapture
  flag)  
        .equ TIM5_TIF_Shift, 6   @ bitWidth 1 (Trigger interrupt flag)  
        .equ TIM5_CC4IF_Shift, 4   @ bitWidth 1 (Capture/Compare 4 interrupt
  flag)  
        .equ TIM5_CC3IF_Shift, 3   @ bitWidth 1 (Capture/Compare 3 interrupt
  flag)  
        .equ TIM5_CC2IF_Shift, 2   @ bitWidth 1 (Capture/Compare 2 interrupt
  flag)  
        .equ TIM5_CC1IF_Shift, 1   @ bitWidth 1 (Capture/compare 1 interrupt
  flag)  
        .equ TIM5_UIF_Shift, 0   @ bitWidth 1 (Update interrupt flag)  
 
    .equ TIM5_EGR, TIM5_BASE + 0x14 @ (event generation register) 
        .equ TIM5_TG_Shift, 6   @ bitWidth 1 (Trigger generation)  
        .equ TIM5_CC4G_Shift, 4   @ bitWidth 1 (Capture/compare 4
  generation)  
        .equ TIM5_CC3G_Shift, 3   @ bitWidth 1 (Capture/compare 3
  generation)  
        .equ TIM5_CC2G_Shift, 2   @ bitWidth 1 (Capture/compare 2
  generation)  
        .equ TIM5_CC1G_Shift, 1   @ bitWidth 1 (Capture/compare 1
  generation)  
        .equ TIM5_UG_Shift, 0   @ bitWidth 1 (Update generation)  
 
    .equ TIM5_CCMR1_Output, TIM5_BASE + 0x18 @ (capture/compare mode register 1 output
  mode) 
        .equ TIM5_OC2CE_Shift, 15   @ bitWidth 1 (OC2CE)  
        .equ TIM5_OC2M_Shift, 12   @ bitWidth 3 (OC2M)  
        .equ TIM5_OC2PE_Shift, 11   @ bitWidth 1 (OC2PE)  
        .equ TIM5_OC2FE_Shift, 10   @ bitWidth 1 (OC2FE)  
        .equ TIM5_CC2S_Shift, 8   @ bitWidth 2 (CC2S)  
        .equ TIM5_OC1CE_Shift, 7   @ bitWidth 1 (OC1CE)  
        .equ TIM5_OC1M_Shift, 4   @ bitWidth 3 (OC1M)  
        .equ TIM5_OC1PE_Shift, 3   @ bitWidth 1 (OC1PE)  
        .equ TIM5_OC1FE_Shift, 2   @ bitWidth 1 (OC1FE)  
        .equ TIM5_CC1S_Shift, 0   @ bitWidth 2 (CC1S)  
 
    .equ TIM5_CCMR1_Input, TIM5_BASE + 0x18 @ (capture/compare mode register 1 input
  mode) 
        .equ TIM5_IC2F_Shift, 12   @ bitWidth 4 (Input capture 2 filter)  
        .equ TIM5_IC2PCS_Shift, 10   @ bitWidth 2 (Input capture 2 prescaler)  
        .equ TIM5_CC2S_Shift, 8   @ bitWidth 2 (Capture/Compare 2
  selection)  
        .equ TIM5_IC1F_Shift, 4   @ bitWidth 4 (Input capture 1 filter)  
        .equ TIM5_ICPCS_Shift, 2   @ bitWidth 2 (Input capture 1 prescaler)  
        .equ TIM5_CC1S_Shift, 0   @ bitWidth 2 (Capture/Compare 1
  selection)  
 
    .equ TIM5_CCMR2_Output, TIM5_BASE + 0x1C @ (capture/compare mode register 2 output
  mode) 
        .equ TIM5_O24CE_Shift, 15   @ bitWidth 1 (O24CE)  
        .equ TIM5_OC4M_Shift, 12   @ bitWidth 3 (OC4M)  
        .equ TIM5_OC4PE_Shift, 11   @ bitWidth 1 (OC4PE)  
        .equ TIM5_OC4FE_Shift, 10   @ bitWidth 1 (OC4FE)  
        .equ TIM5_CC4S_Shift, 8   @ bitWidth 2 (CC4S)  
        .equ TIM5_OC3CE_Shift, 7   @ bitWidth 1 (OC3CE)  
        .equ TIM5_OC3M_Shift, 4   @ bitWidth 3 (OC3M)  
        .equ TIM5_OC3PE_Shift, 3   @ bitWidth 1 (OC3PE)  
        .equ TIM5_OC3FE_Shift, 2   @ bitWidth 1 (OC3FE)  
        .equ TIM5_CC3S_Shift, 0   @ bitWidth 2 (CC3S)  
 
    .equ TIM5_CCMR2_Input, TIM5_BASE + 0x1C @ (capture/compare mode register 2 input
  mode) 
        .equ TIM5_IC4F_Shift, 12   @ bitWidth 4 (Input capture 4 filter)  
        .equ TIM5_IC4PSC_Shift, 10   @ bitWidth 2 (Input capture 4 prescaler)  
        .equ TIM5_CC4S_Shift, 8   @ bitWidth 2 (Capture/Compare 4
  selection)  
        .equ TIM5_IC3F_Shift, 4   @ bitWidth 4 (Input capture 3 filter)  
        .equ TIM5_IC3PSC_Shift, 2   @ bitWidth 2 (Input capture 3 prescaler)  
        .equ TIM5_CC3S_Shift, 0   @ bitWidth 2 (Capture/compare 3
  selection)  
 
    .equ TIM5_CCER, TIM5_BASE + 0x20 @ (capture/compare enable
  register) 
        .equ TIM5_CC4NP_Shift, 15   @ bitWidth 1 (Capture/Compare 4 output
  Polarity)  
        .equ TIM5_CC4P_Shift, 13   @ bitWidth 1 (Capture/Compare 3 output
  Polarity)  
        .equ TIM5_CC4E_Shift, 12   @ bitWidth 1 (Capture/Compare 4 output
  enable)  
        .equ TIM5_CC3NP_Shift, 11   @ bitWidth 1 (Capture/Compare 3 output
  Polarity)  
        .equ TIM5_CC3P_Shift, 9   @ bitWidth 1 (Capture/Compare 3 output
  Polarity)  
        .equ TIM5_CC3E_Shift, 8   @ bitWidth 1 (Capture/Compare 3 output
  enable)  
        .equ TIM5_CC2NP_Shift, 7   @ bitWidth 1 (Capture/Compare 2 output
  Polarity)  
        .equ TIM5_CC2P_Shift, 5   @ bitWidth 1 (Capture/Compare 2 output
  Polarity)  
        .equ TIM5_CC2E_Shift, 4   @ bitWidth 1 (Capture/Compare 2 output
  enable)  
        .equ TIM5_CC1NP_Shift, 3   @ bitWidth 1 (Capture/Compare 1 output
  Polarity)  
        .equ TIM5_CC1P_Shift, 1   @ bitWidth 1 (Capture/Compare 1 output
  Polarity)  
        .equ TIM5_CC1E_Shift, 0   @ bitWidth 1 (Capture/Compare 1 output
  enable)  
 
    .equ TIM5_CNT, TIM5_BASE + 0x24 @ (counter) 
        .equ TIM5_CNT_H_Shift, 16   @ bitWidth 16 (High counter value)  
        .equ TIM5_CNT_L_Shift, 0   @ bitWidth 16 (Low counter value)  
 
    .equ TIM5_PSC, TIM5_BASE + 0x28 @ (prescaler) 
        .equ TIM5_PSC_Shift, 0   @ bitWidth 16 (Prescaler value)  
 
    .equ TIM5_ARR, TIM5_BASE + 0x2C @ (auto-reload register) 
        .equ TIM5_ARR_H_Shift, 16   @ bitWidth 16 (High Auto-reload value)  
        .equ TIM5_ARR_L_Shift, 0   @ bitWidth 16 (Low Auto-reload value)  
 
    .equ TIM5_CCR1, TIM5_BASE + 0x34 @ (capture/compare register 1) 
        .equ TIM5_CCR1_H_Shift, 16   @ bitWidth 16 (High Capture/Compare 1
  value)  
        .equ TIM5_CCR1_L_Shift, 0   @ bitWidth 16 (Low Capture/Compare 1
  value)  
 
    .equ TIM5_CCR2, TIM5_BASE + 0x38 @ (capture/compare register 2) 
        .equ TIM5_CCR2_H_Shift, 16   @ bitWidth 16 (High Capture/Compare 2
  value)  
        .equ TIM5_CCR2_L_Shift, 0   @ bitWidth 16 (Low Capture/Compare 2
  value)  
 
    .equ TIM5_CCR3, TIM5_BASE + 0x3C @ (capture/compare register 3) 
        .equ TIM5_CCR3_H_Shift, 16   @ bitWidth 16 (High Capture/Compare value)  
        .equ TIM5_CCR3_L_Shift, 0   @ bitWidth 16 (Low Capture/Compare value)  
 
    .equ TIM5_CCR4, TIM5_BASE + 0x40 @ (capture/compare register 4) 
        .equ TIM5_CCR4_H_Shift, 16   @ bitWidth 16 (High Capture/Compare value)  
        .equ TIM5_CCR4_L_Shift, 0   @ bitWidth 16 (Low Capture/Compare value)  
 
    .equ TIM5_DCR, TIM5_BASE + 0x48 @ (DMA control register) 
        .equ TIM5_DBL_Shift, 8   @ bitWidth 5 (DMA burst length)  
        .equ TIM5_DBA_Shift, 0   @ bitWidth 5 (DMA base address)  
 
    .equ TIM5_DMAR, TIM5_BASE + 0x4C @ (DMA address for full transfer) 
        .equ TIM5_DMAB_Shift, 0   @ bitWidth 16 (DMA register for burst
  accesses)  
 
    .equ TIM5_OR, TIM5_BASE + 0x50 @ (TIM5 option register) 
        .equ TIM5_IT4_RMP_Shift, 6   @ bitWidth 2 (Timer Input 4 remap)  
 

@=========================== TIM9 ===========================@
.equ TIM9_BASE, 0x40014000 @ (General purpose timers) 
    .equ TIM9_CR1, TIM9_BASE + 0x0 @ (control register 1) 
        .equ TIM9_CKD_Shift, 8   @ bitWidth 2 (Clock division)  
        .equ TIM9_ARPE_Shift, 7   @ bitWidth 1 (Auto-reload preload enable)  
        .equ TIM9_OPM_Shift, 3   @ bitWidth 1 (One-pulse mode)  
        .equ TIM9_URS_Shift, 2   @ bitWidth 1 (Update request source)  
        .equ TIM9_UDIS_Shift, 1   @ bitWidth 1 (Update disable)  
        .equ TIM9_CEN_Shift, 0   @ bitWidth 1 (Counter enable)  
 
    .equ TIM9_CR2, TIM9_BASE + 0x4 @ (control register 2) 
        .equ TIM9_MMS_Shift, 4   @ bitWidth 3 (Master mode selection)  
 
    .equ TIM9_SMCR, TIM9_BASE + 0x8 @ (slave mode control register) 
        .equ TIM9_MSM_Shift, 7   @ bitWidth 1 (Master/Slave mode)  
        .equ TIM9_TS_Shift, 4   @ bitWidth 3 (Trigger selection)  
        .equ TIM9_SMS_Shift, 0   @ bitWidth 3 (Slave mode selection)  
 
    .equ TIM9_DIER, TIM9_BASE + 0xC @ (DMA/Interrupt enable register) 
        .equ TIM9_TIE_Shift, 6   @ bitWidth 1 (Trigger interrupt enable)  
        .equ TIM9_CC2IE_Shift, 2   @ bitWidth 1 (Capture/Compare 2 interrupt
  enable)  
        .equ TIM9_CC1IE_Shift, 1   @ bitWidth 1 (Capture/Compare 1 interrupt
  enable)  
        .equ TIM9_UIE_Shift, 0   @ bitWidth 1 (Update interrupt enable)  
 
    .equ TIM9_SR, TIM9_BASE + 0x10 @ (status register) 
        .equ TIM9_CC2OF_Shift, 10   @ bitWidth 1 (Capture/compare 2 overcapture
  flag)  
        .equ TIM9_CC1OF_Shift, 9   @ bitWidth 1 (Capture/Compare 1 overcapture
  flag)  
        .equ TIM9_TIF_Shift, 6   @ bitWidth 1 (Trigger interrupt flag)  
        .equ TIM9_CC2IF_Shift, 2   @ bitWidth 1 (Capture/Compare 2 interrupt
  flag)  
        .equ TIM9_CC1IF_Shift, 1   @ bitWidth 1 (Capture/compare 1 interrupt
  flag)  
        .equ TIM9_UIF_Shift, 0   @ bitWidth 1 (Update interrupt flag)  
 
    .equ TIM9_EGR, TIM9_BASE + 0x14 @ (event generation register) 
        .equ TIM9_TG_Shift, 6   @ bitWidth 1 (Trigger generation)  
        .equ TIM9_CC2G_Shift, 2   @ bitWidth 1 (Capture/compare 2
  generation)  
        .equ TIM9_CC1G_Shift, 1   @ bitWidth 1 (Capture/compare 1
  generation)  
        .equ TIM9_UG_Shift, 0   @ bitWidth 1 (Update generation)  
 
    .equ TIM9_CCMR1_Output, TIM9_BASE + 0x18 @ (capture/compare mode register 1 output
  mode) 
        .equ TIM9_OC2M_Shift, 12   @ bitWidth 3 (Output Compare 2 mode)  
        .equ TIM9_OC2PE_Shift, 11   @ bitWidth 1 (Output Compare 2 preload
  enable)  
        .equ TIM9_OC2FE_Shift, 10   @ bitWidth 1 (Output Compare 2 fast
  enable)  
        .equ TIM9_CC2S_Shift, 8   @ bitWidth 2 (Capture/Compare 2
  selection)  
        .equ TIM9_OC1M_Shift, 4   @ bitWidth 3 (Output Compare 1 mode)  
        .equ TIM9_OC1PE_Shift, 3   @ bitWidth 1 (Output Compare 1 preload
  enable)  
        .equ TIM9_OC1FE_Shift, 2   @ bitWidth 1 (Output Compare 1 fast
  enable)  
        .equ TIM9_CC1S_Shift, 0   @ bitWidth 2 (Capture/Compare 1
  selection)  
 
    .equ TIM9_CCMR1_Input, TIM9_BASE + 0x18 @ (capture/compare mode register 1 input
  mode) 
        .equ TIM9_IC2F_Shift, 12   @ bitWidth 3 (Input capture 2 filter)  
        .equ TIM9_IC2PCS_Shift, 10   @ bitWidth 2 (Input capture 2 prescaler)  
        .equ TIM9_CC2S_Shift, 8   @ bitWidth 2 (Capture/Compare 2
  selection)  
        .equ TIM9_IC1F_Shift, 4   @ bitWidth 3 (Input capture 1 filter)  
        .equ TIM9_ICPCS_Shift, 2   @ bitWidth 2 (Input capture 1 prescaler)  
        .equ TIM9_CC1S_Shift, 0   @ bitWidth 2 (Capture/Compare 1
  selection)  
 
    .equ TIM9_CCER, TIM9_BASE + 0x20 @ (capture/compare enable
  register) 
        .equ TIM9_CC2NP_Shift, 7   @ bitWidth 1 (Capture/Compare 2 output
  Polarity)  
        .equ TIM9_CC2P_Shift, 5   @ bitWidth 1 (Capture/Compare 2 output
  Polarity)  
        .equ TIM9_CC2E_Shift, 4   @ bitWidth 1 (Capture/Compare 2 output
  enable)  
        .equ TIM9_CC1NP_Shift, 3   @ bitWidth 1 (Capture/Compare 1 output
  Polarity)  
        .equ TIM9_CC1P_Shift, 1   @ bitWidth 1 (Capture/Compare 1 output
  Polarity)  
        .equ TIM9_CC1E_Shift, 0   @ bitWidth 1 (Capture/Compare 1 output
  enable)  
 
    .equ TIM9_CNT, TIM9_BASE + 0x24 @ (counter) 
        .equ TIM9_CNT_Shift, 0   @ bitWidth 16 (counter value)  
 
    .equ TIM9_PSC, TIM9_BASE + 0x28 @ (prescaler) 
        .equ TIM9_PSC_Shift, 0   @ bitWidth 16 (Prescaler value)  
 
    .equ TIM9_ARR, TIM9_BASE + 0x2C @ (auto-reload register) 
        .equ TIM9_ARR_Shift, 0   @ bitWidth 16 (Auto-reload value)  
 
    .equ TIM9_CCR1, TIM9_BASE + 0x34 @ (capture/compare register 1) 
        .equ TIM9_CCR1_Shift, 0   @ bitWidth 16 (Capture/Compare 1 value)  
 
    .equ TIM9_CCR2, TIM9_BASE + 0x38 @ (capture/compare register 2) 
        .equ TIM9_CCR2_Shift, 0   @ bitWidth 16 (Capture/Compare 2 value)  
 

@=========================== USART1 ===========================@
.equ USART1_BASE, 0x40011000 @ (Universal synchronous asynchronous receiver
  transmitter) 
    .equ USART1_SR, USART1_BASE + 0x0 @ (Status register) 
        .equ USART1_CTS_Shift, 9   @ bitWidth 1 (CTS flag)  
        .equ USART1_LBD_Shift, 8   @ bitWidth 1 (LIN break detection flag)  
        .equ USART1_TXE_Shift, 7   @ bitWidth 1 (Transmit data register
  empty)  
        .equ USART1_TC_Shift, 6   @ bitWidth 1 (Transmission complete)  
        .equ USART1_RXNE_Shift, 5   @ bitWidth 1 (Read data register not
  empty)  
        .equ USART1_IDLE_Shift, 4   @ bitWidth 1 (IDLE line detected)  
        .equ USART1_ORE_Shift, 3   @ bitWidth 1 (Overrun error)  
        .equ USART1_NF_Shift, 2   @ bitWidth 1 (Noise detected flag)  
        .equ USART1_FE_Shift, 1   @ bitWidth 1 (Framing error)  
        .equ USART1_PE_Shift, 0   @ bitWidth 1 (Parity error)  
 
    .equ USART1_DR, USART1_BASE + 0x4 @ (Data register) 
        .equ USART1_DR_Shift, 0   @ bitWidth 9 (Data value)  
 
    .equ USART1_BRR, USART1_BASE + 0x8 @ (Baud rate register) 
        .equ USART1_DIV_Mantissa_Shift, 4   @ bitWidth 12 (mantissa of USARTDIV)  
        .equ USART1_DIV_Fraction_Shift, 0   @ bitWidth 4 (fraction of USARTDIV)  
 
    .equ USART1_CR1, USART1_BASE + 0xC @ (Control register 1) 
        .equ USART1_OVER8_Shift, 15   @ bitWidth 1 (Oversampling mode)  
        .equ USART1_UE_Shift, 13   @ bitWidth 1 (USART enable)  
        .equ USART1_M_Shift, 12   @ bitWidth 1 (Word length)  
        .equ USART1_WAKE_Shift, 11   @ bitWidth 1 (Wakeup method)  
        .equ USART1_PCE_Shift, 10   @ bitWidth 1 (Parity control enable)  
        .equ USART1_PS_Shift, 9   @ bitWidth 1 (Parity selection)  
        .equ USART1_PEIE_Shift, 8   @ bitWidth 1 (PE interrupt enable)  
        .equ USART1_TXEIE_Shift, 7   @ bitWidth 1 (TXE interrupt enable)  
        .equ USART1_TCIE_Shift, 6   @ bitWidth 1 (Transmission complete interrupt
  enable)  
        .equ USART1_RXNEIE_Shift, 5   @ bitWidth 1 (RXNE interrupt enable)  
        .equ USART1_IDLEIE_Shift, 4   @ bitWidth 1 (IDLE interrupt enable)  
        .equ USART1_TE_Shift, 3   @ bitWidth 1 (Transmitter enable)  
        .equ USART1_RE_Shift, 2   @ bitWidth 1 (Receiver enable)  
        .equ USART1_RWU_Shift, 1   @ bitWidth 1 (Receiver wakeup)  
        .equ USART1_SBK_Shift, 0   @ bitWidth 1 (Send break)  
 
    .equ USART1_CR2, USART1_BASE + 0x10 @ (Control register 2) 
        .equ USART1_LINEN_Shift, 14   @ bitWidth 1 (LIN mode enable)  
        .equ USART1_STOP_Shift, 12   @ bitWidth 2 (STOP bits)  
        .equ USART1_CLKEN_Shift, 11   @ bitWidth 1 (Clock enable)  
        .equ USART1_CPOL_Shift, 10   @ bitWidth 1 (Clock polarity)  
        .equ USART1_CPHA_Shift, 9   @ bitWidth 1 (Clock phase)  
        .equ USART1_LBCL_Shift, 8   @ bitWidth 1 (Last bit clock pulse)  
        .equ USART1_LBDIE_Shift, 6   @ bitWidth 1 (LIN break detection interrupt
  enable)  
        .equ USART1_LBDL_Shift, 5   @ bitWidth 1 (lin break detection length)  
        .equ USART1_ADD_Shift, 0   @ bitWidth 4 (Address of the USART node)  
 
    .equ USART1_CR3, USART1_BASE + 0x14 @ (Control register 3) 
        .equ USART1_ONEBIT_Shift, 11   @ bitWidth 1 (One sample bit method
  enable)  
        .equ USART1_CTSIE_Shift, 10   @ bitWidth 1 (CTS interrupt enable)  
        .equ USART1_CTSE_Shift, 9   @ bitWidth 1 (CTS enable)  
        .equ USART1_RTSE_Shift, 8   @ bitWidth 1 (RTS enable)  
        .equ USART1_DMAT_Shift, 7   @ bitWidth 1 (DMA enable transmitter)  
        .equ USART1_DMAR_Shift, 6   @ bitWidth 1 (DMA enable receiver)  
        .equ USART1_SCEN_Shift, 5   @ bitWidth 1 (Smartcard mode enable)  
        .equ USART1_NACK_Shift, 4   @ bitWidth 1 (Smartcard NACK enable)  
        .equ USART1_HDSEL_Shift, 3   @ bitWidth 1 (Half-duplex selection)  
        .equ USART1_IRLP_Shift, 2   @ bitWidth 1 (IrDA low-power)  
        .equ USART1_IREN_Shift, 1   @ bitWidth 1 (IrDA mode enable)  
        .equ USART1_EIE_Shift, 0   @ bitWidth 1 (Error interrupt enable)  
 
    .equ USART1_GTPR, USART1_BASE + 0x18 @ (Guard time and prescaler
  register) 
        .equ USART1_GT_Shift, 8   @ bitWidth 8 (Guard time value)  
        .equ USART1_PSC_Shift, 0   @ bitWidth 8 (Prescaler value)  
 

@=========================== USART2 ===========================@
.equ USART2_BASE, 0x40004400 @ (Universal synchronous asynchronous receiver
  transmitter) 
    .equ USART2_SR, USART2_BASE + 0x0 @ (Status register) 
        .equ USART2_CTS_Shift, 9   @ bitWidth 1 (CTS flag)  
        .equ USART2_LBD_Shift, 8   @ bitWidth 1 (LIN break detection flag)  
        .equ USART2_TXE_Shift, 7   @ bitWidth 1 (Transmit data register
  empty)  
        .equ USART2_TC_Shift, 6   @ bitWidth 1 (Transmission complete)  
        .equ USART2_RXNE_Shift, 5   @ bitWidth 1 (Read data register not
  empty)  
        .equ USART2_IDLE_Shift, 4   @ bitWidth 1 (IDLE line detected)  
        .equ USART2_ORE_Shift, 3   @ bitWidth 1 (Overrun error)  
        .equ USART2_NF_Shift, 2   @ bitWidth 1 (Noise detected flag)  
        .equ USART2_FE_Shift, 1   @ bitWidth 1 (Framing error)  
        .equ USART2_PE_Shift, 0   @ bitWidth 1 (Parity error)  
 
    .equ USART2_DR, USART2_BASE + 0x4 @ (Data register) 
        .equ USART2_DR_Shift, 0   @ bitWidth 9 (Data value)  
 
    .equ USART2_BRR, USART2_BASE + 0x8 @ (Baud rate register) 
        .equ USART2_DIV_Mantissa_Shift, 4   @ bitWidth 12 (mantissa of USARTDIV)  
        .equ USART2_DIV_Fraction_Shift, 0   @ bitWidth 4 (fraction of USARTDIV)  
 
    .equ USART2_CR1, USART2_BASE + 0xC @ (Control register 1) 
        .equ USART2_OVER8_Shift, 15   @ bitWidth 1 (Oversampling mode)  
        .equ USART2_UE_Shift, 13   @ bitWidth 1 (USART enable)  
        .equ USART2_M_Shift, 12   @ bitWidth 1 (Word length)  
        .equ USART2_WAKE_Shift, 11   @ bitWidth 1 (Wakeup method)  
        .equ USART2_PCE_Shift, 10   @ bitWidth 1 (Parity control enable)  
        .equ USART2_PS_Shift, 9   @ bitWidth 1 (Parity selection)  
        .equ USART2_PEIE_Shift, 8   @ bitWidth 1 (PE interrupt enable)  
        .equ USART2_TXEIE_Shift, 7   @ bitWidth 1 (TXE interrupt enable)  
        .equ USART2_TCIE_Shift, 6   @ bitWidth 1 (Transmission complete interrupt
  enable)  
        .equ USART2_RXNEIE_Shift, 5   @ bitWidth 1 (RXNE interrupt enable)  
        .equ USART2_IDLEIE_Shift, 4   @ bitWidth 1 (IDLE interrupt enable)  
        .equ USART2_TE_Shift, 3   @ bitWidth 1 (Transmitter enable)  
        .equ USART2_RE_Shift, 2   @ bitWidth 1 (Receiver enable)  
        .equ USART2_RWU_Shift, 1   @ bitWidth 1 (Receiver wakeup)  
        .equ USART2_SBK_Shift, 0   @ bitWidth 1 (Send break)  
 
    .equ USART2_CR2, USART2_BASE + 0x10 @ (Control register 2) 
        .equ USART2_LINEN_Shift, 14   @ bitWidth 1 (LIN mode enable)  
        .equ USART2_STOP_Shift, 12   @ bitWidth 2 (STOP bits)  
        .equ USART2_CLKEN_Shift, 11   @ bitWidth 1 (Clock enable)  
        .equ USART2_CPOL_Shift, 10   @ bitWidth 1 (Clock polarity)  
        .equ USART2_CPHA_Shift, 9   @ bitWidth 1 (Clock phase)  
        .equ USART2_LBCL_Shift, 8   @ bitWidth 1 (Last bit clock pulse)  
        .equ USART2_LBDIE_Shift, 6   @ bitWidth 1 (LIN break detection interrupt
  enable)  
        .equ USART2_LBDL_Shift, 5   @ bitWidth 1 (lin break detection length)  
        .equ USART2_ADD_Shift, 0   @ bitWidth 4 (Address of the USART node)  
 
    .equ USART2_CR3, USART2_BASE + 0x14 @ (Control register 3) 
        .equ USART2_ONEBIT_Shift, 11   @ bitWidth 1 (One sample bit method
  enable)  
        .equ USART2_CTSIE_Shift, 10   @ bitWidth 1 (CTS interrupt enable)  
        .equ USART2_CTSE_Shift, 9   @ bitWidth 1 (CTS enable)  
        .equ USART2_RTSE_Shift, 8   @ bitWidth 1 (RTS enable)  
        .equ USART2_DMAT_Shift, 7   @ bitWidth 1 (DMA enable transmitter)  
        .equ USART2_DMAR_Shift, 6   @ bitWidth 1 (DMA enable receiver)  
        .equ USART2_SCEN_Shift, 5   @ bitWidth 1 (Smartcard mode enable)  
        .equ USART2_NACK_Shift, 4   @ bitWidth 1 (Smartcard NACK enable)  
        .equ USART2_HDSEL_Shift, 3   @ bitWidth 1 (Half-duplex selection)  
        .equ USART2_IRLP_Shift, 2   @ bitWidth 1 (IrDA low-power)  
        .equ USART2_IREN_Shift, 1   @ bitWidth 1 (IrDA mode enable)  
        .equ USART2_EIE_Shift, 0   @ bitWidth 1 (Error interrupt enable)  
 
    .equ USART2_GTPR, USART2_BASE + 0x18 @ (Guard time and prescaler
  register) 
        .equ USART2_GT_Shift, 8   @ bitWidth 8 (Guard time value)  
        .equ USART2_PSC_Shift, 0   @ bitWidth 8 (Prescaler value)  
 

@=========================== USART6 ===========================@
.equ USART6_BASE, 0x40011400 @ (Universal synchronous asynchronous receiver
  transmitter) 
    .equ USART6_SR, USART6_BASE + 0x0 @ (Status register) 
        .equ USART6_CTS_Shift, 9   @ bitWidth 1 (CTS flag)  
        .equ USART6_LBD_Shift, 8   @ bitWidth 1 (LIN break detection flag)  
        .equ USART6_TXE_Shift, 7   @ bitWidth 1 (Transmit data register
  empty)  
        .equ USART6_TC_Shift, 6   @ bitWidth 1 (Transmission complete)  
        .equ USART6_RXNE_Shift, 5   @ bitWidth 1 (Read data register not
  empty)  
        .equ USART6_IDLE_Shift, 4   @ bitWidth 1 (IDLE line detected)  
        .equ USART6_ORE_Shift, 3   @ bitWidth 1 (Overrun error)  
        .equ USART6_NF_Shift, 2   @ bitWidth 1 (Noise detected flag)  
        .equ USART6_FE_Shift, 1   @ bitWidth 1 (Framing error)  
        .equ USART6_PE_Shift, 0   @ bitWidth 1 (Parity error)  
 
    .equ USART6_DR, USART6_BASE + 0x4 @ (Data register) 
        .equ USART6_DR_Shift, 0   @ bitWidth 9 (Data value)  
 
    .equ USART6_BRR, USART6_BASE + 0x8 @ (Baud rate register) 
        .equ USART6_DIV_Mantissa_Shift, 4   @ bitWidth 12 (mantissa of USARTDIV)  
        .equ USART6_DIV_Fraction_Shift, 0   @ bitWidth 4 (fraction of USARTDIV)  
 
    .equ USART6_CR1, USART6_BASE + 0xC @ (Control register 1) 
        .equ USART6_OVER8_Shift, 15   @ bitWidth 1 (Oversampling mode)  
        .equ USART6_UE_Shift, 13   @ bitWidth 1 (USART enable)  
        .equ USART6_M_Shift, 12   @ bitWidth 1 (Word length)  
        .equ USART6_WAKE_Shift, 11   @ bitWidth 1 (Wakeup method)  
        .equ USART6_PCE_Shift, 10   @ bitWidth 1 (Parity control enable)  
        .equ USART6_PS_Shift, 9   @ bitWidth 1 (Parity selection)  
        .equ USART6_PEIE_Shift, 8   @ bitWidth 1 (PE interrupt enable)  
        .equ USART6_TXEIE_Shift, 7   @ bitWidth 1 (TXE interrupt enable)  
        .equ USART6_TCIE_Shift, 6   @ bitWidth 1 (Transmission complete interrupt
  enable)  
        .equ USART6_RXNEIE_Shift, 5   @ bitWidth 1 (RXNE interrupt enable)  
        .equ USART6_IDLEIE_Shift, 4   @ bitWidth 1 (IDLE interrupt enable)  
        .equ USART6_TE_Shift, 3   @ bitWidth 1 (Transmitter enable)  
        .equ USART6_RE_Shift, 2   @ bitWidth 1 (Receiver enable)  
        .equ USART6_RWU_Shift, 1   @ bitWidth 1 (Receiver wakeup)  
        .equ USART6_SBK_Shift, 0   @ bitWidth 1 (Send break)  
 
    .equ USART6_CR2, USART6_BASE + 0x10 @ (Control register 2) 
        .equ USART6_LINEN_Shift, 14   @ bitWidth 1 (LIN mode enable)  
        .equ USART6_STOP_Shift, 12   @ bitWidth 2 (STOP bits)  
        .equ USART6_CLKEN_Shift, 11   @ bitWidth 1 (Clock enable)  
        .equ USART6_CPOL_Shift, 10   @ bitWidth 1 (Clock polarity)  
        .equ USART6_CPHA_Shift, 9   @ bitWidth 1 (Clock phase)  
        .equ USART6_LBCL_Shift, 8   @ bitWidth 1 (Last bit clock pulse)  
        .equ USART6_LBDIE_Shift, 6   @ bitWidth 1 (LIN break detection interrupt
  enable)  
        .equ USART6_LBDL_Shift, 5   @ bitWidth 1 (lin break detection length)  
        .equ USART6_ADD_Shift, 0   @ bitWidth 4 (Address of the USART node)  
 
    .equ USART6_CR3, USART6_BASE + 0x14 @ (Control register 3) 
        .equ USART6_ONEBIT_Shift, 11   @ bitWidth 1 (One sample bit method
  enable)  
        .equ USART6_CTSIE_Shift, 10   @ bitWidth 1 (CTS interrupt enable)  
        .equ USART6_CTSE_Shift, 9   @ bitWidth 1 (CTS enable)  
        .equ USART6_RTSE_Shift, 8   @ bitWidth 1 (RTS enable)  
        .equ USART6_DMAT_Shift, 7   @ bitWidth 1 (DMA enable transmitter)  
        .equ USART6_DMAR_Shift, 6   @ bitWidth 1 (DMA enable receiver)  
        .equ USART6_SCEN_Shift, 5   @ bitWidth 1 (Smartcard mode enable)  
        .equ USART6_NACK_Shift, 4   @ bitWidth 1 (Smartcard NACK enable)  
        .equ USART6_HDSEL_Shift, 3   @ bitWidth 1 (Half-duplex selection)  
        .equ USART6_IRLP_Shift, 2   @ bitWidth 1 (IrDA low-power)  
        .equ USART6_IREN_Shift, 1   @ bitWidth 1 (IrDA mode enable)  
        .equ USART6_EIE_Shift, 0   @ bitWidth 1 (Error interrupt enable)  
 
    .equ USART6_GTPR, USART6_BASE + 0x18 @ (Guard time and prescaler
  register) 
        .equ USART6_GT_Shift, 8   @ bitWidth 8 (Guard time value)  
        .equ USART6_PSC_Shift, 0   @ bitWidth 8 (Prescaler value)  
 

@=========================== WWDG ===========================@
.equ WWDG_BASE, 0x40002C00 @ (Window watchdog) 
    .equ WWDG_CR, WWDG_BASE + 0x0 @ (Control register) 
        .equ WWDG_WDGA_Shift, 7   @ bitWidth 1 (Activation bit)  
        .equ WWDG_T_Shift, 0   @ bitWidth 7 (7-bit counter MSB to LSB)  
 
    .equ WWDG_CFR, WWDG_BASE + 0x4 @ (Configuration register) 
        .equ WWDG_EWI_Shift, 9   @ bitWidth 1 (Early wakeup interrupt)  
        .equ WWDG_WDGTB1_Shift, 8   @ bitWidth 1 (Timer base)  
        .equ WWDG_WDGTB0_Shift, 7   @ bitWidth 1 (Timer base)  
        .equ WWDG_W_Shift, 0   @ bitWidth 7 (7-bit window value)  
 
    .equ WWDG_SR, WWDG_BASE + 0x8 @ (Status register) 
        .equ WWDG_EWIF_Shift, 0   @ bitWidth 1 (Early wakeup interrupt
  flag)  
 

@=========================== DMA2 ===========================@
.equ DMA2_BASE, 0x40026400 @ (DMA controller) 
    .equ DMA2_LISR, DMA2_BASE + 0x0 @ (low interrupt status register) 
        .equ DMA2_TCIF3_Shift, 27   @ bitWidth 1 (Stream x transfer complete interrupt
  flag x = 3..0)  
        .equ DMA2_HTIF3_Shift, 26   @ bitWidth 1 (Stream x half transfer interrupt flag
  x=3..0)  
        .equ DMA2_TEIF3_Shift, 25   @ bitWidth 1 (Stream x transfer error interrupt flag
  x=3..0)  
        .equ DMA2_DMEIF3_Shift, 24   @ bitWidth 1 (Stream x direct mode error interrupt
  flag x=3..0)  
        .equ DMA2_FEIF3_Shift, 22   @ bitWidth 1 (Stream x FIFO error interrupt flag
  x=3..0)  
        .equ DMA2_TCIF2_Shift, 21   @ bitWidth 1 (Stream x transfer complete interrupt
  flag x = 3..0)  
        .equ DMA2_HTIF2_Shift, 20   @ bitWidth 1 (Stream x half transfer interrupt flag
  x=3..0)  
        .equ DMA2_TEIF2_Shift, 19   @ bitWidth 1 (Stream x transfer error interrupt flag
  x=3..0)  
        .equ DMA2_DMEIF2_Shift, 18   @ bitWidth 1 (Stream x direct mode error interrupt
  flag x=3..0)  
        .equ DMA2_FEIF2_Shift, 16   @ bitWidth 1 (Stream x FIFO error interrupt flag
  x=3..0)  
        .equ DMA2_TCIF1_Shift, 11   @ bitWidth 1 (Stream x transfer complete interrupt
  flag x = 3..0)  
        .equ DMA2_HTIF1_Shift, 10   @ bitWidth 1 (Stream x half transfer interrupt flag
  x=3..0)  
        .equ DMA2_TEIF1_Shift, 9   @ bitWidth 1 (Stream x transfer error interrupt flag
  x=3..0)  
        .equ DMA2_DMEIF1_Shift, 8   @ bitWidth 1 (Stream x direct mode error interrupt
  flag x=3..0)  
        .equ DMA2_FEIF1_Shift, 6   @ bitWidth 1 (Stream x FIFO error interrupt flag
  x=3..0)  
        .equ DMA2_TCIF0_Shift, 5   @ bitWidth 1 (Stream x transfer complete interrupt
  flag x = 3..0)  
        .equ DMA2_HTIF0_Shift, 4   @ bitWidth 1 (Stream x half transfer interrupt flag
  x=3..0)  
        .equ DMA2_TEIF0_Shift, 3   @ bitWidth 1 (Stream x transfer error interrupt flag
  x=3..0)  
        .equ DMA2_DMEIF0_Shift, 2   @ bitWidth 1 (Stream x direct mode error interrupt
  flag x=3..0)  
        .equ DMA2_FEIF0_Shift, 0   @ bitWidth 1 (Stream x FIFO error interrupt flag
  x=3..0)  
 
    .equ DMA2_HISR, DMA2_BASE + 0x4 @ (high interrupt status register) 
        .equ DMA2_TCIF7_Shift, 27   @ bitWidth 1 (Stream x transfer complete interrupt
  flag x=7..4)  
        .equ DMA2_HTIF7_Shift, 26   @ bitWidth 1 (Stream x half transfer interrupt flag
  x=7..4)  
        .equ DMA2_TEIF7_Shift, 25   @ bitWidth 1 (Stream x transfer error interrupt flag
  x=7..4)  
        .equ DMA2_DMEIF7_Shift, 24   @ bitWidth 1 (Stream x direct mode error interrupt
  flag x=7..4)  
        .equ DMA2_FEIF7_Shift, 22   @ bitWidth 1 (Stream x FIFO error interrupt flag
  x=7..4)  
        .equ DMA2_TCIF6_Shift, 21   @ bitWidth 1 (Stream x transfer complete interrupt
  flag x=7..4)  
        .equ DMA2_HTIF6_Shift, 20   @ bitWidth 1 (Stream x half transfer interrupt flag
  x=7..4)  
        .equ DMA2_TEIF6_Shift, 19   @ bitWidth 1 (Stream x transfer error interrupt flag
  x=7..4)  
        .equ DMA2_DMEIF6_Shift, 18   @ bitWidth 1 (Stream x direct mode error interrupt
  flag x=7..4)  
        .equ DMA2_FEIF6_Shift, 16   @ bitWidth 1 (Stream x FIFO error interrupt flag
  x=7..4)  
        .equ DMA2_TCIF5_Shift, 11   @ bitWidth 1 (Stream x transfer complete interrupt
  flag x=7..4)  
        .equ DMA2_HTIF5_Shift, 10   @ bitWidth 1 (Stream x half transfer interrupt flag
  x=7..4)  
        .equ DMA2_TEIF5_Shift, 9   @ bitWidth 1 (Stream x transfer error interrupt flag
  x=7..4)  
        .equ DMA2_DMEIF5_Shift, 8   @ bitWidth 1 (Stream x direct mode error interrupt
  flag x=7..4)  
        .equ DMA2_FEIF5_Shift, 6   @ bitWidth 1 (Stream x FIFO error interrupt flag
  x=7..4)  
        .equ DMA2_TCIF4_Shift, 5   @ bitWidth 1 (Stream x transfer complete interrupt
  flag x=7..4)  
        .equ DMA2_HTIF4_Shift, 4   @ bitWidth 1 (Stream x half transfer interrupt flag
  x=7..4)  
        .equ DMA2_TEIF4_Shift, 3   @ bitWidth 1 (Stream x transfer error interrupt flag
  x=7..4)  
        .equ DMA2_DMEIF4_Shift, 2   @ bitWidth 1 (Stream x direct mode error interrupt
  flag x=7..4)  
        .equ DMA2_FEIF4_Shift, 0   @ bitWidth 1 (Stream x FIFO error interrupt flag
  x=7..4)  
 
    .equ DMA2_LIFCR, DMA2_BASE + 0x8 @ (low interrupt flag clear
  register) 
        .equ DMA2_CTCIF3_Shift, 27   @ bitWidth 1 (Stream x clear transfer complete
  interrupt flag x = 3..0)  
        .equ DMA2_CHTIF3_Shift, 26   @ bitWidth 1 (Stream x clear half transfer interrupt
  flag x = 3..0)  
        .equ DMA2_CTEIF3_Shift, 25   @ bitWidth 1 (Stream x clear transfer error interrupt
  flag x = 3..0)  
        .equ DMA2_CDMEIF3_Shift, 24   @ bitWidth 1 (Stream x clear direct mode error
  interrupt flag x = 3..0)  
        .equ DMA2_CFEIF3_Shift, 22   @ bitWidth 1 (Stream x clear FIFO error interrupt flag
  x = 3..0)  
        .equ DMA2_CTCIF2_Shift, 21   @ bitWidth 1 (Stream x clear transfer complete
  interrupt flag x = 3..0)  
        .equ DMA2_CHTIF2_Shift, 20   @ bitWidth 1 (Stream x clear half transfer interrupt
  flag x = 3..0)  
        .equ DMA2_CTEIF2_Shift, 19   @ bitWidth 1 (Stream x clear transfer error interrupt
  flag x = 3..0)  
        .equ DMA2_CDMEIF2_Shift, 18   @ bitWidth 1 (Stream x clear direct mode error
  interrupt flag x = 3..0)  
        .equ DMA2_CFEIF2_Shift, 16   @ bitWidth 1 (Stream x clear FIFO error interrupt flag
  x = 3..0)  
        .equ DMA2_CTCIF1_Shift, 11   @ bitWidth 1 (Stream x clear transfer complete
  interrupt flag x = 3..0)  
        .equ DMA2_CHTIF1_Shift, 10   @ bitWidth 1 (Stream x clear half transfer interrupt
  flag x = 3..0)  
        .equ DMA2_CTEIF1_Shift, 9   @ bitWidth 1 (Stream x clear transfer error interrupt
  flag x = 3..0)  
        .equ DMA2_CDMEIF1_Shift, 8   @ bitWidth 1 (Stream x clear direct mode error
  interrupt flag x = 3..0)  
        .equ DMA2_CFEIF1_Shift, 6   @ bitWidth 1 (Stream x clear FIFO error interrupt flag
  x = 3..0)  
        .equ DMA2_CTCIF0_Shift, 5   @ bitWidth 1 (Stream x clear transfer complete
  interrupt flag x = 3..0)  
        .equ DMA2_CHTIF0_Shift, 4   @ bitWidth 1 (Stream x clear half transfer interrupt
  flag x = 3..0)  
        .equ DMA2_CTEIF0_Shift, 3   @ bitWidth 1 (Stream x clear transfer error interrupt
  flag x = 3..0)  
        .equ DMA2_CDMEIF0_Shift, 2   @ bitWidth 1 (Stream x clear direct mode error
  interrupt flag x = 3..0)  
        .equ DMA2_CFEIF0_Shift, 0   @ bitWidth 1 (Stream x clear FIFO error interrupt flag
  x = 3..0)  
 
    .equ DMA2_HIFCR, DMA2_BASE + 0xC @ (high interrupt flag clear
  register) 
        .equ DMA2_CTCIF7_Shift, 27   @ bitWidth 1 (Stream x clear transfer complete
  interrupt flag x = 7..4)  
        .equ DMA2_CHTIF7_Shift, 26   @ bitWidth 1 (Stream x clear half transfer interrupt
  flag x = 7..4)  
        .equ DMA2_CTEIF7_Shift, 25   @ bitWidth 1 (Stream x clear transfer error interrupt
  flag x = 7..4)  
        .equ DMA2_CDMEIF7_Shift, 24   @ bitWidth 1 (Stream x clear direct mode error
  interrupt flag x = 7..4)  
        .equ DMA2_CFEIF7_Shift, 22   @ bitWidth 1 (Stream x clear FIFO error interrupt flag
  x = 7..4)  
        .equ DMA2_CTCIF6_Shift, 21   @ bitWidth 1 (Stream x clear transfer complete
  interrupt flag x = 7..4)  
        .equ DMA2_CHTIF6_Shift, 20   @ bitWidth 1 (Stream x clear half transfer interrupt
  flag x = 7..4)  
        .equ DMA2_CTEIF6_Shift, 19   @ bitWidth 1 (Stream x clear transfer error interrupt
  flag x = 7..4)  
        .equ DMA2_CDMEIF6_Shift, 18   @ bitWidth 1 (Stream x clear direct mode error
  interrupt flag x = 7..4)  
        .equ DMA2_CFEIF6_Shift, 16   @ bitWidth 1 (Stream x clear FIFO error interrupt flag
  x = 7..4)  
        .equ DMA2_CTCIF5_Shift, 11   @ bitWidth 1 (Stream x clear transfer complete
  interrupt flag x = 7..4)  
        .equ DMA2_CHTIF5_Shift, 10   @ bitWidth 1 (Stream x clear half transfer interrupt
  flag x = 7..4)  
        .equ DMA2_CTEIF5_Shift, 9   @ bitWidth 1 (Stream x clear transfer error interrupt
  flag x = 7..4)  
        .equ DMA2_CDMEIF5_Shift, 8   @ bitWidth 1 (Stream x clear direct mode error
  interrupt flag x = 7..4)  
        .equ DMA2_CFEIF5_Shift, 6   @ bitWidth 1 (Stream x clear FIFO error interrupt flag
  x = 7..4)  
        .equ DMA2_CTCIF4_Shift, 5   @ bitWidth 1 (Stream x clear transfer complete
  interrupt flag x = 7..4)  
        .equ DMA2_CHTIF4_Shift, 4   @ bitWidth 1 (Stream x clear half transfer interrupt
  flag x = 7..4)  
        .equ DMA2_CTEIF4_Shift, 3   @ bitWidth 1 (Stream x clear transfer error interrupt
  flag x = 7..4)  
        .equ DMA2_CDMEIF4_Shift, 2   @ bitWidth 1 (Stream x clear direct mode error
  interrupt flag x = 7..4)  
        .equ DMA2_CFEIF4_Shift, 0   @ bitWidth 1 (Stream x clear FIFO error interrupt flag
  x = 7..4)  
 
    .equ DMA2_S0CR, DMA2_BASE + 0x10 @ (stream x configuration
  register) 
        .equ DMA2_CHSEL_Shift, 25   @ bitWidth 3 (Channel selection)  
        .equ DMA2_MBURST_Shift, 23   @ bitWidth 2 (Memory burst transfer
  configuration)  
        .equ DMA2_PBURST_Shift, 21   @ bitWidth 2 (Peripheral burst transfer
  configuration)  
        .equ DMA2_CT_Shift, 19   @ bitWidth 1 (Current target only in double buffer
  mode)  
        .equ DMA2_DBM_Shift, 18   @ bitWidth 1 (Double buffer mode)  
        .equ DMA2_PL_Shift, 16   @ bitWidth 2 (Priority level)  
        .equ DMA2_PINCOS_Shift, 15   @ bitWidth 1 (Peripheral increment offset
  size)  
        .equ DMA2_MSIZE_Shift, 13   @ bitWidth 2 (Memory data size)  
        .equ DMA2_PSIZE_Shift, 11   @ bitWidth 2 (Peripheral data size)  
        .equ DMA2_MINC_Shift, 10   @ bitWidth 1 (Memory increment mode)  
        .equ DMA2_PINC_Shift, 9   @ bitWidth 1 (Peripheral increment mode)  
        .equ DMA2_CIRC_Shift, 8   @ bitWidth 1 (Circular mode)  
        .equ DMA2_DIR_Shift, 6   @ bitWidth 2 (Data transfer direction)  
        .equ DMA2_PFCTRL_Shift, 5   @ bitWidth 1 (Peripheral flow controller)  
        .equ DMA2_TCIE_Shift, 4   @ bitWidth 1 (Transfer complete interrupt
  enable)  
        .equ DMA2_HTIE_Shift, 3   @ bitWidth 1 (Half transfer interrupt
  enable)  
        .equ DMA2_TEIE_Shift, 2   @ bitWidth 1 (Transfer error interrupt
  enable)  
        .equ DMA2_DMEIE_Shift, 1   @ bitWidth 1 (Direct mode error interrupt
  enable)  
        .equ DMA2_EN_Shift, 0   @ bitWidth 1 (Stream enable / flag stream ready when
  read low)  
 
    .equ DMA2_S0NDTR, DMA2_BASE + 0x14 @ (stream x number of data
  register) 
        .equ DMA2_NDT_Shift, 0   @ bitWidth 16 (Number of data items to
  transfer)  
 
    .equ DMA2_S0PAR, DMA2_BASE + 0x18 @ (stream x peripheral address
  register) 
        .equ DMA2_PA_Shift, 0   @ bitWidth 32 (Peripheral address)  
 
    .equ DMA2_S0M0AR, DMA2_BASE + 0x1C @ (stream x memory 0 address
  register) 
        .equ DMA2_M0A_Shift, 0   @ bitWidth 32 (Memory 0 address)  
 
    .equ DMA2_S0M1AR, DMA2_BASE + 0x20 @ (stream x memory 1 address
  register) 
        .equ DMA2_M1A_Shift, 0   @ bitWidth 32 (Memory 1 address used in case of Double
  buffer mode)  
 
    .equ DMA2_S0FCR, DMA2_BASE + 0x24 @ (stream x FIFO control register) 
        .equ DMA2_FEIE_Shift, 7   @ bitWidth 1 (FIFO error interrupt
  enable)  
        .equ DMA2_FS_Shift, 3   @ bitWidth 3 (FIFO status)  
        .equ DMA2_DMDIS_Shift, 2   @ bitWidth 1 (Direct mode disable)  
        .equ DMA2_FTH_Shift, 0   @ bitWidth 2 (FIFO threshold selection)  
 
    .equ DMA2_S1CR, DMA2_BASE + 0x28 @ (stream x configuration
  register) 
        .equ DMA2_CHSEL_Shift, 25   @ bitWidth 3 (Channel selection)  
        .equ DMA2_MBURST_Shift, 23   @ bitWidth 2 (Memory burst transfer
  configuration)  
        .equ DMA2_PBURST_Shift, 21   @ bitWidth 2 (Peripheral burst transfer
  configuration)  
        .equ DMA2_ACK_Shift, 20   @ bitWidth 1 (ACK)  
        .equ DMA2_CT_Shift, 19   @ bitWidth 1 (Current target only in double buffer
  mode)  
        .equ DMA2_DBM_Shift, 18   @ bitWidth 1 (Double buffer mode)  
        .equ DMA2_PL_Shift, 16   @ bitWidth 2 (Priority level)  
        .equ DMA2_PINCOS_Shift, 15   @ bitWidth 1 (Peripheral increment offset
  size)  
        .equ DMA2_MSIZE_Shift, 13   @ bitWidth 2 (Memory data size)  
        .equ DMA2_PSIZE_Shift, 11   @ bitWidth 2 (Peripheral data size)  
        .equ DMA2_MINC_Shift, 10   @ bitWidth 1 (Memory increment mode)  
        .equ DMA2_PINC_Shift, 9   @ bitWidth 1 (Peripheral increment mode)  
        .equ DMA2_CIRC_Shift, 8   @ bitWidth 1 (Circular mode)  
        .equ DMA2_DIR_Shift, 6   @ bitWidth 2 (Data transfer direction)  
        .equ DMA2_PFCTRL_Shift, 5   @ bitWidth 1 (Peripheral flow controller)  
        .equ DMA2_TCIE_Shift, 4   @ bitWidth 1 (Transfer complete interrupt
  enable)  
        .equ DMA2_HTIE_Shift, 3   @ bitWidth 1 (Half transfer interrupt
  enable)  
        .equ DMA2_TEIE_Shift, 2   @ bitWidth 1 (Transfer error interrupt
  enable)  
        .equ DMA2_DMEIE_Shift, 1   @ bitWidth 1 (Direct mode error interrupt
  enable)  
        .equ DMA2_EN_Shift, 0   @ bitWidth 1 (Stream enable / flag stream ready when
  read low)  
 
    .equ DMA2_S1NDTR, DMA2_BASE + 0x2C @ (stream x number of data
  register) 
        .equ DMA2_NDT_Shift, 0   @ bitWidth 16 (Number of data items to
  transfer)  
 
    .equ DMA2_S1PAR, DMA2_BASE + 0x30 @ (stream x peripheral address
  register) 
        .equ DMA2_PA_Shift, 0   @ bitWidth 32 (Peripheral address)  
 
    .equ DMA2_S1M0AR, DMA2_BASE + 0x34 @ (stream x memory 0 address
  register) 
        .equ DMA2_M0A_Shift, 0   @ bitWidth 32 (Memory 0 address)  
 
    .equ DMA2_S1M1AR, DMA2_BASE + 0x38 @ (stream x memory 1 address
  register) 
        .equ DMA2_M1A_Shift, 0   @ bitWidth 32 (Memory 1 address used in case of Double
  buffer mode)  
 
    .equ DMA2_S1FCR, DMA2_BASE + 0x3C @ (stream x FIFO control register) 
        .equ DMA2_FEIE_Shift, 7   @ bitWidth 1 (FIFO error interrupt
  enable)  
        .equ DMA2_FS_Shift, 3   @ bitWidth 3 (FIFO status)  
        .equ DMA2_DMDIS_Shift, 2   @ bitWidth 1 (Direct mode disable)  
        .equ DMA2_FTH_Shift, 0   @ bitWidth 2 (FIFO threshold selection)  
 
    .equ DMA2_S2CR, DMA2_BASE + 0x40 @ (stream x configuration
  register) 
        .equ DMA2_CHSEL_Shift, 25   @ bitWidth 3 (Channel selection)  
        .equ DMA2_MBURST_Shift, 23   @ bitWidth 2 (Memory burst transfer
  configuration)  
        .equ DMA2_PBURST_Shift, 21   @ bitWidth 2 (Peripheral burst transfer
  configuration)  
        .equ DMA2_ACK_Shift, 20   @ bitWidth 1 (ACK)  
        .equ DMA2_CT_Shift, 19   @ bitWidth 1 (Current target only in double buffer
  mode)  
        .equ DMA2_DBM_Shift, 18   @ bitWidth 1 (Double buffer mode)  
        .equ DMA2_PL_Shift, 16   @ bitWidth 2 (Priority level)  
        .equ DMA2_PINCOS_Shift, 15   @ bitWidth 1 (Peripheral increment offset
  size)  
        .equ DMA2_MSIZE_Shift, 13   @ bitWidth 2 (Memory data size)  
        .equ DMA2_PSIZE_Shift, 11   @ bitWidth 2 (Peripheral data size)  
        .equ DMA2_MINC_Shift, 10   @ bitWidth 1 (Memory increment mode)  
        .equ DMA2_PINC_Shift, 9   @ bitWidth 1 (Peripheral increment mode)  
        .equ DMA2_CIRC_Shift, 8   @ bitWidth 1 (Circular mode)  
        .equ DMA2_DIR_Shift, 6   @ bitWidth 2 (Data transfer direction)  
        .equ DMA2_PFCTRL_Shift, 5   @ bitWidth 1 (Peripheral flow controller)  
        .equ DMA2_TCIE_Shift, 4   @ bitWidth 1 (Transfer complete interrupt
  enable)  
        .equ DMA2_HTIE_Shift, 3   @ bitWidth 1 (Half transfer interrupt
  enable)  
        .equ DMA2_TEIE_Shift, 2   @ bitWidth 1 (Transfer error interrupt
  enable)  
        .equ DMA2_DMEIE_Shift, 1   @ bitWidth 1 (Direct mode error interrupt
  enable)  
        .equ DMA2_EN_Shift, 0   @ bitWidth 1 (Stream enable / flag stream ready when
  read low)  
 
    .equ DMA2_S2NDTR, DMA2_BASE + 0x44 @ (stream x number of data
  register) 
        .equ DMA2_NDT_Shift, 0   @ bitWidth 16 (Number of data items to
  transfer)  
 
    .equ DMA2_S2PAR, DMA2_BASE + 0x48 @ (stream x peripheral address
  register) 
        .equ DMA2_PA_Shift, 0   @ bitWidth 32 (Peripheral address)  
 
    .equ DMA2_S2M0AR, DMA2_BASE + 0x4C @ (stream x memory 0 address
  register) 
        .equ DMA2_M0A_Shift, 0   @ bitWidth 32 (Memory 0 address)  
 
    .equ DMA2_S2M1AR, DMA2_BASE + 0x50 @ (stream x memory 1 address
  register) 
        .equ DMA2_M1A_Shift, 0   @ bitWidth 32 (Memory 1 address used in case of Double
  buffer mode)  
 
    .equ DMA2_S2FCR, DMA2_BASE + 0x54 @ (stream x FIFO control register) 
        .equ DMA2_FEIE_Shift, 7   @ bitWidth 1 (FIFO error interrupt
  enable)  
        .equ DMA2_FS_Shift, 3   @ bitWidth 3 (FIFO status)  
        .equ DMA2_DMDIS_Shift, 2   @ bitWidth 1 (Direct mode disable)  
        .equ DMA2_FTH_Shift, 0   @ bitWidth 2 (FIFO threshold selection)  
 
    .equ DMA2_S3CR, DMA2_BASE + 0x58 @ (stream x configuration
  register) 
        .equ DMA2_CHSEL_Shift, 25   @ bitWidth 3 (Channel selection)  
        .equ DMA2_MBURST_Shift, 23   @ bitWidth 2 (Memory burst transfer
  configuration)  
        .equ DMA2_PBURST_Shift, 21   @ bitWidth 2 (Peripheral burst transfer
  configuration)  
        .equ DMA2_ACK_Shift, 20   @ bitWidth 1 (ACK)  
        .equ DMA2_CT_Shift, 19   @ bitWidth 1 (Current target only in double buffer
  mode)  
        .equ DMA2_DBM_Shift, 18   @ bitWidth 1 (Double buffer mode)  
        .equ DMA2_PL_Shift, 16   @ bitWidth 2 (Priority level)  
        .equ DMA2_PINCOS_Shift, 15   @ bitWidth 1 (Peripheral increment offset
  size)  
        .equ DMA2_MSIZE_Shift, 13   @ bitWidth 2 (Memory data size)  
        .equ DMA2_PSIZE_Shift, 11   @ bitWidth 2 (Peripheral data size)  
        .equ DMA2_MINC_Shift, 10   @ bitWidth 1 (Memory increment mode)  
        .equ DMA2_PINC_Shift, 9   @ bitWidth 1 (Peripheral increment mode)  
        .equ DMA2_CIRC_Shift, 8   @ bitWidth 1 (Circular mode)  
        .equ DMA2_DIR_Shift, 6   @ bitWidth 2 (Data transfer direction)  
        .equ DMA2_PFCTRL_Shift, 5   @ bitWidth 1 (Peripheral flow controller)  
        .equ DMA2_TCIE_Shift, 4   @ bitWidth 1 (Transfer complete interrupt
  enable)  
        .equ DMA2_HTIE_Shift, 3   @ bitWidth 1 (Half transfer interrupt
  enable)  
        .equ DMA2_TEIE_Shift, 2   @ bitWidth 1 (Transfer error interrupt
  enable)  
        .equ DMA2_DMEIE_Shift, 1   @ bitWidth 1 (Direct mode error interrupt
  enable)  
        .equ DMA2_EN_Shift, 0   @ bitWidth 1 (Stream enable / flag stream ready when
  read low)  
 
    .equ DMA2_S3NDTR, DMA2_BASE + 0x5C @ (stream x number of data
  register) 
        .equ DMA2_NDT_Shift, 0   @ bitWidth 16 (Number of data items to
  transfer)  
 
    .equ DMA2_S3PAR, DMA2_BASE + 0x60 @ (stream x peripheral address
  register) 
        .equ DMA2_PA_Shift, 0   @ bitWidth 32 (Peripheral address)  
 
    .equ DMA2_S3M0AR, DMA2_BASE + 0x64 @ (stream x memory 0 address
  register) 
        .equ DMA2_M0A_Shift, 0   @ bitWidth 32 (Memory 0 address)  
 
    .equ DMA2_S3M1AR, DMA2_BASE + 0x68 @ (stream x memory 1 address
  register) 
        .equ DMA2_M1A_Shift, 0   @ bitWidth 32 (Memory 1 address used in case of Double
  buffer mode)  
 
    .equ DMA2_S3FCR, DMA2_BASE + 0x6C @ (stream x FIFO control register) 
        .equ DMA2_FEIE_Shift, 7   @ bitWidth 1 (FIFO error interrupt
  enable)  
        .equ DMA2_FS_Shift, 3   @ bitWidth 3 (FIFO status)  
        .equ DMA2_DMDIS_Shift, 2   @ bitWidth 1 (Direct mode disable)  
        .equ DMA2_FTH_Shift, 0   @ bitWidth 2 (FIFO threshold selection)  
 
    .equ DMA2_S4CR, DMA2_BASE + 0x70 @ (stream x configuration
  register) 
        .equ DMA2_CHSEL_Shift, 25   @ bitWidth 3 (Channel selection)  
        .equ DMA2_MBURST_Shift, 23   @ bitWidth 2 (Memory burst transfer
  configuration)  
        .equ DMA2_PBURST_Shift, 21   @ bitWidth 2 (Peripheral burst transfer
  configuration)  
        .equ DMA2_ACK_Shift, 20   @ bitWidth 1 (ACK)  
        .equ DMA2_CT_Shift, 19   @ bitWidth 1 (Current target only in double buffer
  mode)  
        .equ DMA2_DBM_Shift, 18   @ bitWidth 1 (Double buffer mode)  
        .equ DMA2_PL_Shift, 16   @ bitWidth 2 (Priority level)  
        .equ DMA2_PINCOS_Shift, 15   @ bitWidth 1 (Peripheral increment offset
  size)  
        .equ DMA2_MSIZE_Shift, 13   @ bitWidth 2 (Memory data size)  
        .equ DMA2_PSIZE_Shift, 11   @ bitWidth 2 (Peripheral data size)  
        .equ DMA2_MINC_Shift, 10   @ bitWidth 1 (Memory increment mode)  
        .equ DMA2_PINC_Shift, 9   @ bitWidth 1 (Peripheral increment mode)  
        .equ DMA2_CIRC_Shift, 8   @ bitWidth 1 (Circular mode)  
        .equ DMA2_DIR_Shift, 6   @ bitWidth 2 (Data transfer direction)  
        .equ DMA2_PFCTRL_Shift, 5   @ bitWidth 1 (Peripheral flow controller)  
        .equ DMA2_TCIE_Shift, 4   @ bitWidth 1 (Transfer complete interrupt
  enable)  
        .equ DMA2_HTIE_Shift, 3   @ bitWidth 1 (Half transfer interrupt
  enable)  
        .equ DMA2_TEIE_Shift, 2   @ bitWidth 1 (Transfer error interrupt
  enable)  
        .equ DMA2_DMEIE_Shift, 1   @ bitWidth 1 (Direct mode error interrupt
  enable)  
        .equ DMA2_EN_Shift, 0   @ bitWidth 1 (Stream enable / flag stream ready when
  read low)  
 
    .equ DMA2_S4NDTR, DMA2_BASE + 0x74 @ (stream x number of data
  register) 
        .equ DMA2_NDT_Shift, 0   @ bitWidth 16 (Number of data items to
  transfer)  
 
    .equ DMA2_S4PAR, DMA2_BASE + 0x78 @ (stream x peripheral address
  register) 
        .equ DMA2_PA_Shift, 0   @ bitWidth 32 (Peripheral address)  
 
    .equ DMA2_S4M0AR, DMA2_BASE + 0x7C @ (stream x memory 0 address
  register) 
        .equ DMA2_M0A_Shift, 0   @ bitWidth 32 (Memory 0 address)  
 
    .equ DMA2_S4M1AR, DMA2_BASE + 0x80 @ (stream x memory 1 address
  register) 
        .equ DMA2_M1A_Shift, 0   @ bitWidth 32 (Memory 1 address used in case of Double
  buffer mode)  
 
    .equ DMA2_S4FCR, DMA2_BASE + 0x84 @ (stream x FIFO control register) 
        .equ DMA2_FEIE_Shift, 7   @ bitWidth 1 (FIFO error interrupt
  enable)  
        .equ DMA2_FS_Shift, 3   @ bitWidth 3 (FIFO status)  
        .equ DMA2_DMDIS_Shift, 2   @ bitWidth 1 (Direct mode disable)  
        .equ DMA2_FTH_Shift, 0   @ bitWidth 2 (FIFO threshold selection)  
 
    .equ DMA2_S5CR, DMA2_BASE + 0x88 @ (stream x configuration
  register) 
        .equ DMA2_CHSEL_Shift, 25   @ bitWidth 3 (Channel selection)  
        .equ DMA2_MBURST_Shift, 23   @ bitWidth 2 (Memory burst transfer
  configuration)  
        .equ DMA2_PBURST_Shift, 21   @ bitWidth 2 (Peripheral burst transfer
  configuration)  
        .equ DMA2_ACK_Shift, 20   @ bitWidth 1 (ACK)  
        .equ DMA2_CT_Shift, 19   @ bitWidth 1 (Current target only in double buffer
  mode)  
        .equ DMA2_DBM_Shift, 18   @ bitWidth 1 (Double buffer mode)  
        .equ DMA2_PL_Shift, 16   @ bitWidth 2 (Priority level)  
        .equ DMA2_PINCOS_Shift, 15   @ bitWidth 1 (Peripheral increment offset
  size)  
        .equ DMA2_MSIZE_Shift, 13   @ bitWidth 2 (Memory data size)  
        .equ DMA2_PSIZE_Shift, 11   @ bitWidth 2 (Peripheral data size)  
        .equ DMA2_MINC_Shift, 10   @ bitWidth 1 (Memory increment mode)  
        .equ DMA2_PINC_Shift, 9   @ bitWidth 1 (Peripheral increment mode)  
        .equ DMA2_CIRC_Shift, 8   @ bitWidth 1 (Circular mode)  
        .equ DMA2_DIR_Shift, 6   @ bitWidth 2 (Data transfer direction)  
        .equ DMA2_PFCTRL_Shift, 5   @ bitWidth 1 (Peripheral flow controller)  
        .equ DMA2_TCIE_Shift, 4   @ bitWidth 1 (Transfer complete interrupt
  enable)  
        .equ DMA2_HTIE_Shift, 3   @ bitWidth 1 (Half transfer interrupt
  enable)  
        .equ DMA2_TEIE_Shift, 2   @ bitWidth 1 (Transfer error interrupt
  enable)  
        .equ DMA2_DMEIE_Shift, 1   @ bitWidth 1 (Direct mode error interrupt
  enable)  
        .equ DMA2_EN_Shift, 0   @ bitWidth 1 (Stream enable / flag stream ready when
  read low)  
 
    .equ DMA2_S5NDTR, DMA2_BASE + 0x8C @ (stream x number of data
  register) 
        .equ DMA2_NDT_Shift, 0   @ bitWidth 16 (Number of data items to
  transfer)  
 
    .equ DMA2_S5PAR, DMA2_BASE + 0x90 @ (stream x peripheral address
  register) 
        .equ DMA2_PA_Shift, 0   @ bitWidth 32 (Peripheral address)  
 
    .equ DMA2_S5M0AR, DMA2_BASE + 0x94 @ (stream x memory 0 address
  register) 
        .equ DMA2_M0A_Shift, 0   @ bitWidth 32 (Memory 0 address)  
 
    .equ DMA2_S5M1AR, DMA2_BASE + 0x98 @ (stream x memory 1 address
  register) 
        .equ DMA2_M1A_Shift, 0   @ bitWidth 32 (Memory 1 address used in case of Double
  buffer mode)  
 
    .equ DMA2_S5FCR, DMA2_BASE + 0x9C @ (stream x FIFO control register) 
        .equ DMA2_FEIE_Shift, 7   @ bitWidth 1 (FIFO error interrupt
  enable)  
        .equ DMA2_FS_Shift, 3   @ bitWidth 3 (FIFO status)  
        .equ DMA2_DMDIS_Shift, 2   @ bitWidth 1 (Direct mode disable)  
        .equ DMA2_FTH_Shift, 0   @ bitWidth 2 (FIFO threshold selection)  
 
    .equ DMA2_S6CR, DMA2_BASE + 0xA0 @ (stream x configuration
  register) 
        .equ DMA2_CHSEL_Shift, 25   @ bitWidth 3 (Channel selection)  
        .equ DMA2_MBURST_Shift, 23   @ bitWidth 2 (Memory burst transfer
  configuration)  
        .equ DMA2_PBURST_Shift, 21   @ bitWidth 2 (Peripheral burst transfer
  configuration)  
        .equ DMA2_ACK_Shift, 20   @ bitWidth 1 (ACK)  
        .equ DMA2_CT_Shift, 19   @ bitWidth 1 (Current target only in double buffer
  mode)  
        .equ DMA2_DBM_Shift, 18   @ bitWidth 1 (Double buffer mode)  
        .equ DMA2_PL_Shift, 16   @ bitWidth 2 (Priority level)  
        .equ DMA2_PINCOS_Shift, 15   @ bitWidth 1 (Peripheral increment offset
  size)  
        .equ DMA2_MSIZE_Shift, 13   @ bitWidth 2 (Memory data size)  
        .equ DMA2_PSIZE_Shift, 11   @ bitWidth 2 (Peripheral data size)  
        .equ DMA2_MINC_Shift, 10   @ bitWidth 1 (Memory increment mode)  
        .equ DMA2_PINC_Shift, 9   @ bitWidth 1 (Peripheral increment mode)  
        .equ DMA2_CIRC_Shift, 8   @ bitWidth 1 (Circular mode)  
        .equ DMA2_DIR_Shift, 6   @ bitWidth 2 (Data transfer direction)  
        .equ DMA2_PFCTRL_Shift, 5   @ bitWidth 1 (Peripheral flow controller)  
        .equ DMA2_TCIE_Shift, 4   @ bitWidth 1 (Transfer complete interrupt
  enable)  
        .equ DMA2_HTIE_Shift, 3   @ bitWidth 1 (Half transfer interrupt
  enable)  
        .equ DMA2_TEIE_Shift, 2   @ bitWidth 1 (Transfer error interrupt
  enable)  
        .equ DMA2_DMEIE_Shift, 1   @ bitWidth 1 (Direct mode error interrupt
  enable)  
        .equ DMA2_EN_Shift, 0   @ bitWidth 1 (Stream enable / flag stream ready when
  read low)  
 
    .equ DMA2_S6NDTR, DMA2_BASE + 0xA4 @ (stream x number of data
  register) 
        .equ DMA2_NDT_Shift, 0   @ bitWidth 16 (Number of data items to
  transfer)  
 
    .equ DMA2_S6PAR, DMA2_BASE + 0xA8 @ (stream x peripheral address
  register) 
        .equ DMA2_PA_Shift, 0   @ bitWidth 32 (Peripheral address)  
 
    .equ DMA2_S6M0AR, DMA2_BASE + 0xAC @ (stream x memory 0 address
  register) 
        .equ DMA2_M0A_Shift, 0   @ bitWidth 32 (Memory 0 address)  
 
    .equ DMA2_S6M1AR, DMA2_BASE + 0xB0 @ (stream x memory 1 address
  register) 
        .equ DMA2_M1A_Shift, 0   @ bitWidth 32 (Memory 1 address used in case of Double
  buffer mode)  
 
    .equ DMA2_S6FCR, DMA2_BASE + 0xB4 @ (stream x FIFO control register) 
        .equ DMA2_FEIE_Shift, 7   @ bitWidth 1 (FIFO error interrupt
  enable)  
        .equ DMA2_FS_Shift, 3   @ bitWidth 3 (FIFO status)  
        .equ DMA2_DMDIS_Shift, 2   @ bitWidth 1 (Direct mode disable)  
        .equ DMA2_FTH_Shift, 0   @ bitWidth 2 (FIFO threshold selection)  
 
    .equ DMA2_S7CR, DMA2_BASE + 0xB8 @ (stream x configuration
  register) 
        .equ DMA2_CHSEL_Shift, 25   @ bitWidth 3 (Channel selection)  
        .equ DMA2_MBURST_Shift, 23   @ bitWidth 2 (Memory burst transfer
  configuration)  
        .equ DMA2_PBURST_Shift, 21   @ bitWidth 2 (Peripheral burst transfer
  configuration)  
        .equ DMA2_ACK_Shift, 20   @ bitWidth 1 (ACK)  
        .equ DMA2_CT_Shift, 19   @ bitWidth 1 (Current target only in double buffer
  mode)  
        .equ DMA2_DBM_Shift, 18   @ bitWidth 1 (Double buffer mode)  
        .equ DMA2_PL_Shift, 16   @ bitWidth 2 (Priority level)  
        .equ DMA2_PINCOS_Shift, 15   @ bitWidth 1 (Peripheral increment offset
  size)  
        .equ DMA2_MSIZE_Shift, 13   @ bitWidth 2 (Memory data size)  
        .equ DMA2_PSIZE_Shift, 11   @ bitWidth 2 (Peripheral data size)  
        .equ DMA2_MINC_Shift, 10   @ bitWidth 1 (Memory increment mode)  
        .equ DMA2_PINC_Shift, 9   @ bitWidth 1 (Peripheral increment mode)  
        .equ DMA2_CIRC_Shift, 8   @ bitWidth 1 (Circular mode)  
        .equ DMA2_DIR_Shift, 6   @ bitWidth 2 (Data transfer direction)  
        .equ DMA2_PFCTRL_Shift, 5   @ bitWidth 1 (Peripheral flow controller)  
        .equ DMA2_TCIE_Shift, 4   @ bitWidth 1 (Transfer complete interrupt
  enable)  
        .equ DMA2_HTIE_Shift, 3   @ bitWidth 1 (Half transfer interrupt
  enable)  
        .equ DMA2_TEIE_Shift, 2   @ bitWidth 1 (Transfer error interrupt
  enable)  
        .equ DMA2_DMEIE_Shift, 1   @ bitWidth 1 (Direct mode error interrupt
  enable)  
        .equ DMA2_EN_Shift, 0   @ bitWidth 1 (Stream enable / flag stream ready when
  read low)  
 
    .equ DMA2_S7NDTR, DMA2_BASE + 0xBC @ (stream x number of data
  register) 
        .equ DMA2_NDT_Shift, 0   @ bitWidth 16 (Number of data items to
  transfer)  
 
    .equ DMA2_S7PAR, DMA2_BASE + 0xC0 @ (stream x peripheral address
  register) 
        .equ DMA2_PA_Shift, 0   @ bitWidth 32 (Peripheral address)  
 
    .equ DMA2_S7M0AR, DMA2_BASE + 0xC4 @ (stream x memory 0 address
  register) 
        .equ DMA2_M0A_Shift, 0   @ bitWidth 32 (Memory 0 address)  
 
    .equ DMA2_S7M1AR, DMA2_BASE + 0xC8 @ (stream x memory 1 address
  register) 
        .equ DMA2_M1A_Shift, 0   @ bitWidth 32 (Memory 1 address used in case of Double
  buffer mode)  
 
    .equ DMA2_S7FCR, DMA2_BASE + 0xCC @ (stream x FIFO control register) 
        .equ DMA2_FEIE_Shift, 7   @ bitWidth 1 (FIFO error interrupt
  enable)  
        .equ DMA2_FS_Shift, 3   @ bitWidth 3 (FIFO status)  
        .equ DMA2_DMDIS_Shift, 2   @ bitWidth 1 (Direct mode disable)  
        .equ DMA2_FTH_Shift, 0   @ bitWidth 2 (FIFO threshold selection)  
 

@=========================== DMA1 ===========================@
.equ DMA1_BASE, 0x40026000 @ (DMA controller) 
    .equ DMA1_LISR, DMA1_BASE + 0x0 @ (low interrupt status register) 
        .equ DMA1_TCIF3_Shift, 27   @ bitWidth 1 (Stream x transfer complete interrupt
  flag x = 3..0)  
        .equ DMA1_HTIF3_Shift, 26   @ bitWidth 1 (Stream x half transfer interrupt flag
  x=3..0)  
        .equ DMA1_TEIF3_Shift, 25   @ bitWidth 1 (Stream x transfer error interrupt flag
  x=3..0)  
        .equ DMA1_DMEIF3_Shift, 24   @ bitWidth 1 (Stream x direct mode error interrupt
  flag x=3..0)  
        .equ DMA1_FEIF3_Shift, 22   @ bitWidth 1 (Stream x FIFO error interrupt flag
  x=3..0)  
        .equ DMA1_TCIF2_Shift, 21   @ bitWidth 1 (Stream x transfer complete interrupt
  flag x = 3..0)  
        .equ DMA1_HTIF2_Shift, 20   @ bitWidth 1 (Stream x half transfer interrupt flag
  x=3..0)  
        .equ DMA1_TEIF2_Shift, 19   @ bitWidth 1 (Stream x transfer error interrupt flag
  x=3..0)  
        .equ DMA1_DMEIF2_Shift, 18   @ bitWidth 1 (Stream x direct mode error interrupt
  flag x=3..0)  
        .equ DMA1_FEIF2_Shift, 16   @ bitWidth 1 (Stream x FIFO error interrupt flag
  x=3..0)  
        .equ DMA1_TCIF1_Shift, 11   @ bitWidth 1 (Stream x transfer complete interrupt
  flag x = 3..0)  
        .equ DMA1_HTIF1_Shift, 10   @ bitWidth 1 (Stream x half transfer interrupt flag
  x=3..0)  
        .equ DMA1_TEIF1_Shift, 9   @ bitWidth 1 (Stream x transfer error interrupt flag
  x=3..0)  
        .equ DMA1_DMEIF1_Shift, 8   @ bitWidth 1 (Stream x direct mode error interrupt
  flag x=3..0)  
        .equ DMA1_FEIF1_Shift, 6   @ bitWidth 1 (Stream x FIFO error interrupt flag
  x=3..0)  
        .equ DMA1_TCIF0_Shift, 5   @ bitWidth 1 (Stream x transfer complete interrupt
  flag x = 3..0)  
        .equ DMA1_HTIF0_Shift, 4   @ bitWidth 1 (Stream x half transfer interrupt flag
  x=3..0)  
        .equ DMA1_TEIF0_Shift, 3   @ bitWidth 1 (Stream x transfer error interrupt flag
  x=3..0)  
        .equ DMA1_DMEIF0_Shift, 2   @ bitWidth 1 (Stream x direct mode error interrupt
  flag x=3..0)  
        .equ DMA1_FEIF0_Shift, 0   @ bitWidth 1 (Stream x FIFO error interrupt flag
  x=3..0)  
 
    .equ DMA1_HISR, DMA1_BASE + 0x4 @ (high interrupt status register) 
        .equ DMA1_TCIF7_Shift, 27   @ bitWidth 1 (Stream x transfer complete interrupt
  flag x=7..4)  
        .equ DMA1_HTIF7_Shift, 26   @ bitWidth 1 (Stream x half transfer interrupt flag
  x=7..4)  
        .equ DMA1_TEIF7_Shift, 25   @ bitWidth 1 (Stream x transfer error interrupt flag
  x=7..4)  
        .equ DMA1_DMEIF7_Shift, 24   @ bitWidth 1 (Stream x direct mode error interrupt
  flag x=7..4)  
        .equ DMA1_FEIF7_Shift, 22   @ bitWidth 1 (Stream x FIFO error interrupt flag
  x=7..4)  
        .equ DMA1_TCIF6_Shift, 21   @ bitWidth 1 (Stream x transfer complete interrupt
  flag x=7..4)  
        .equ DMA1_HTIF6_Shift, 20   @ bitWidth 1 (Stream x half transfer interrupt flag
  x=7..4)  
        .equ DMA1_TEIF6_Shift, 19   @ bitWidth 1 (Stream x transfer error interrupt flag
  x=7..4)  
        .equ DMA1_DMEIF6_Shift, 18   @ bitWidth 1 (Stream x direct mode error interrupt
  flag x=7..4)  
        .equ DMA1_FEIF6_Shift, 16   @ bitWidth 1 (Stream x FIFO error interrupt flag
  x=7..4)  
        .equ DMA1_TCIF5_Shift, 11   @ bitWidth 1 (Stream x transfer complete interrupt
  flag x=7..4)  
        .equ DMA1_HTIF5_Shift, 10   @ bitWidth 1 (Stream x half transfer interrupt flag
  x=7..4)  
        .equ DMA1_TEIF5_Shift, 9   @ bitWidth 1 (Stream x transfer error interrupt flag
  x=7..4)  
        .equ DMA1_DMEIF5_Shift, 8   @ bitWidth 1 (Stream x direct mode error interrupt
  flag x=7..4)  
        .equ DMA1_FEIF5_Shift, 6   @ bitWidth 1 (Stream x FIFO error interrupt flag
  x=7..4)  
        .equ DMA1_TCIF4_Shift, 5   @ bitWidth 1 (Stream x transfer complete interrupt
  flag x=7..4)  
        .equ DMA1_HTIF4_Shift, 4   @ bitWidth 1 (Stream x half transfer interrupt flag
  x=7..4)  
        .equ DMA1_TEIF4_Shift, 3   @ bitWidth 1 (Stream x transfer error interrupt flag
  x=7..4)  
        .equ DMA1_DMEIF4_Shift, 2   @ bitWidth 1 (Stream x direct mode error interrupt
  flag x=7..4)  
        .equ DMA1_FEIF4_Shift, 0   @ bitWidth 1 (Stream x FIFO error interrupt flag
  x=7..4)  
 
    .equ DMA1_LIFCR, DMA1_BASE + 0x8 @ (low interrupt flag clear
  register) 
        .equ DMA1_CTCIF3_Shift, 27   @ bitWidth 1 (Stream x clear transfer complete
  interrupt flag x = 3..0)  
        .equ DMA1_CHTIF3_Shift, 26   @ bitWidth 1 (Stream x clear half transfer interrupt
  flag x = 3..0)  
        .equ DMA1_CTEIF3_Shift, 25   @ bitWidth 1 (Stream x clear transfer error interrupt
  flag x = 3..0)  
        .equ DMA1_CDMEIF3_Shift, 24   @ bitWidth 1 (Stream x clear direct mode error
  interrupt flag x = 3..0)  
        .equ DMA1_CFEIF3_Shift, 22   @ bitWidth 1 (Stream x clear FIFO error interrupt flag
  x = 3..0)  
        .equ DMA1_CTCIF2_Shift, 21   @ bitWidth 1 (Stream x clear transfer complete
  interrupt flag x = 3..0)  
        .equ DMA1_CHTIF2_Shift, 20   @ bitWidth 1 (Stream x clear half transfer interrupt
  flag x = 3..0)  
        .equ DMA1_CTEIF2_Shift, 19   @ bitWidth 1 (Stream x clear transfer error interrupt
  flag x = 3..0)  
        .equ DMA1_CDMEIF2_Shift, 18   @ bitWidth 1 (Stream x clear direct mode error
  interrupt flag x = 3..0)  
        .equ DMA1_CFEIF2_Shift, 16   @ bitWidth 1 (Stream x clear FIFO error interrupt flag
  x = 3..0)  
        .equ DMA1_CTCIF1_Shift, 11   @ bitWidth 1 (Stream x clear transfer complete
  interrupt flag x = 3..0)  
        .equ DMA1_CHTIF1_Shift, 10   @ bitWidth 1 (Stream x clear half transfer interrupt
  flag x = 3..0)  
        .equ DMA1_CTEIF1_Shift, 9   @ bitWidth 1 (Stream x clear transfer error interrupt
  flag x = 3..0)  
        .equ DMA1_CDMEIF1_Shift, 8   @ bitWidth 1 (Stream x clear direct mode error
  interrupt flag x = 3..0)  
        .equ DMA1_CFEIF1_Shift, 6   @ bitWidth 1 (Stream x clear FIFO error interrupt flag
  x = 3..0)  
        .equ DMA1_CTCIF0_Shift, 5   @ bitWidth 1 (Stream x clear transfer complete
  interrupt flag x = 3..0)  
        .equ DMA1_CHTIF0_Shift, 4   @ bitWidth 1 (Stream x clear half transfer interrupt
  flag x = 3..0)  
        .equ DMA1_CTEIF0_Shift, 3   @ bitWidth 1 (Stream x clear transfer error interrupt
  flag x = 3..0)  
        .equ DMA1_CDMEIF0_Shift, 2   @ bitWidth 1 (Stream x clear direct mode error
  interrupt flag x = 3..0)  
        .equ DMA1_CFEIF0_Shift, 0   @ bitWidth 1 (Stream x clear FIFO error interrupt flag
  x = 3..0)  
 
    .equ DMA1_HIFCR, DMA1_BASE + 0xC @ (high interrupt flag clear
  register) 
        .equ DMA1_CTCIF7_Shift, 27   @ bitWidth 1 (Stream x clear transfer complete
  interrupt flag x = 7..4)  
        .equ DMA1_CHTIF7_Shift, 26   @ bitWidth 1 (Stream x clear half transfer interrupt
  flag x = 7..4)  
        .equ DMA1_CTEIF7_Shift, 25   @ bitWidth 1 (Stream x clear transfer error interrupt
  flag x = 7..4)  
        .equ DMA1_CDMEIF7_Shift, 24   @ bitWidth 1 (Stream x clear direct mode error
  interrupt flag x = 7..4)  
        .equ DMA1_CFEIF7_Shift, 22   @ bitWidth 1 (Stream x clear FIFO error interrupt flag
  x = 7..4)  
        .equ DMA1_CTCIF6_Shift, 21   @ bitWidth 1 (Stream x clear transfer complete
  interrupt flag x = 7..4)  
        .equ DMA1_CHTIF6_Shift, 20   @ bitWidth 1 (Stream x clear half transfer interrupt
  flag x = 7..4)  
        .equ DMA1_CTEIF6_Shift, 19   @ bitWidth 1 (Stream x clear transfer error interrupt
  flag x = 7..4)  
        .equ DMA1_CDMEIF6_Shift, 18   @ bitWidth 1 (Stream x clear direct mode error
  interrupt flag x = 7..4)  
        .equ DMA1_CFEIF6_Shift, 16   @ bitWidth 1 (Stream x clear FIFO error interrupt flag
  x = 7..4)  
        .equ DMA1_CTCIF5_Shift, 11   @ bitWidth 1 (Stream x clear transfer complete
  interrupt flag x = 7..4)  
        .equ DMA1_CHTIF5_Shift, 10   @ bitWidth 1 (Stream x clear half transfer interrupt
  flag x = 7..4)  
        .equ DMA1_CTEIF5_Shift, 9   @ bitWidth 1 (Stream x clear transfer error interrupt
  flag x = 7..4)  
        .equ DMA1_CDMEIF5_Shift, 8   @ bitWidth 1 (Stream x clear direct mode error
  interrupt flag x = 7..4)  
        .equ DMA1_CFEIF5_Shift, 6   @ bitWidth 1 (Stream x clear FIFO error interrupt flag
  x = 7..4)  
        .equ DMA1_CTCIF4_Shift, 5   @ bitWidth 1 (Stream x clear transfer complete
  interrupt flag x = 7..4)  
        .equ DMA1_CHTIF4_Shift, 4   @ bitWidth 1 (Stream x clear half transfer interrupt
  flag x = 7..4)  
        .equ DMA1_CTEIF4_Shift, 3   @ bitWidth 1 (Stream x clear transfer error interrupt
  flag x = 7..4)  
        .equ DMA1_CDMEIF4_Shift, 2   @ bitWidth 1 (Stream x clear direct mode error
  interrupt flag x = 7..4)  
        .equ DMA1_CFEIF4_Shift, 0   @ bitWidth 1 (Stream x clear FIFO error interrupt flag
  x = 7..4)  
 
    .equ DMA1_S0CR, DMA1_BASE + 0x10 @ (stream x configuration
  register) 
        .equ DMA1_CHSEL_Shift, 25   @ bitWidth 3 (Channel selection)  
        .equ DMA1_MBURST_Shift, 23   @ bitWidth 2 (Memory burst transfer
  configuration)  
        .equ DMA1_PBURST_Shift, 21   @ bitWidth 2 (Peripheral burst transfer
  configuration)  
        .equ DMA1_CT_Shift, 19   @ bitWidth 1 (Current target only in double buffer
  mode)  
        .equ DMA1_DBM_Shift, 18   @ bitWidth 1 (Double buffer mode)  
        .equ DMA1_PL_Shift, 16   @ bitWidth 2 (Priority level)  
        .equ DMA1_PINCOS_Shift, 15   @ bitWidth 1 (Peripheral increment offset
  size)  
        .equ DMA1_MSIZE_Shift, 13   @ bitWidth 2 (Memory data size)  
        .equ DMA1_PSIZE_Shift, 11   @ bitWidth 2 (Peripheral data size)  
        .equ DMA1_MINC_Shift, 10   @ bitWidth 1 (Memory increment mode)  
        .equ DMA1_PINC_Shift, 9   @ bitWidth 1 (Peripheral increment mode)  
        .equ DMA1_CIRC_Shift, 8   @ bitWidth 1 (Circular mode)  
        .equ DMA1_DIR_Shift, 6   @ bitWidth 2 (Data transfer direction)  
        .equ DMA1_PFCTRL_Shift, 5   @ bitWidth 1 (Peripheral flow controller)  
        .equ DMA1_TCIE_Shift, 4   @ bitWidth 1 (Transfer complete interrupt
  enable)  
        .equ DMA1_HTIE_Shift, 3   @ bitWidth 1 (Half transfer interrupt
  enable)  
        .equ DMA1_TEIE_Shift, 2   @ bitWidth 1 (Transfer error interrupt
  enable)  
        .equ DMA1_DMEIE_Shift, 1   @ bitWidth 1 (Direct mode error interrupt
  enable)  
        .equ DMA1_EN_Shift, 0   @ bitWidth 1 (Stream enable / flag stream ready when
  read low)  
 
    .equ DMA1_S0NDTR, DMA1_BASE + 0x14 @ (stream x number of data
  register) 
        .equ DMA1_NDT_Shift, 0   @ bitWidth 16 (Number of data items to
  transfer)  
 
    .equ DMA1_S0PAR, DMA1_BASE + 0x18 @ (stream x peripheral address
  register) 
        .equ DMA1_PA_Shift, 0   @ bitWidth 32 (Peripheral address)  
 
    .equ DMA1_S0M0AR, DMA1_BASE + 0x1C @ (stream x memory 0 address
  register) 
        .equ DMA1_M0A_Shift, 0   @ bitWidth 32 (Memory 0 address)  
 
    .equ DMA1_S0M1AR, DMA1_BASE + 0x20 @ (stream x memory 1 address
  register) 
        .equ DMA1_M1A_Shift, 0   @ bitWidth 32 (Memory 1 address used in case of Double
  buffer mode)  
 
    .equ DMA1_S0FCR, DMA1_BASE + 0x24 @ (stream x FIFO control register) 
        .equ DMA1_FEIE_Shift, 7   @ bitWidth 1 (FIFO error interrupt
  enable)  
        .equ DMA1_FS_Shift, 3   @ bitWidth 3 (FIFO status)  
        .equ DMA1_DMDIS_Shift, 2   @ bitWidth 1 (Direct mode disable)  
        .equ DMA1_FTH_Shift, 0   @ bitWidth 2 (FIFO threshold selection)  
 
    .equ DMA1_S1CR, DMA1_BASE + 0x28 @ (stream x configuration
  register) 
        .equ DMA1_CHSEL_Shift, 25   @ bitWidth 3 (Channel selection)  
        .equ DMA1_MBURST_Shift, 23   @ bitWidth 2 (Memory burst transfer
  configuration)  
        .equ DMA1_PBURST_Shift, 21   @ bitWidth 2 (Peripheral burst transfer
  configuration)  
        .equ DMA1_ACK_Shift, 20   @ bitWidth 1 (ACK)  
        .equ DMA1_CT_Shift, 19   @ bitWidth 1 (Current target only in double buffer
  mode)  
        .equ DMA1_DBM_Shift, 18   @ bitWidth 1 (Double buffer mode)  
        .equ DMA1_PL_Shift, 16   @ bitWidth 2 (Priority level)  
        .equ DMA1_PINCOS_Shift, 15   @ bitWidth 1 (Peripheral increment offset
  size)  
        .equ DMA1_MSIZE_Shift, 13   @ bitWidth 2 (Memory data size)  
        .equ DMA1_PSIZE_Shift, 11   @ bitWidth 2 (Peripheral data size)  
        .equ DMA1_MINC_Shift, 10   @ bitWidth 1 (Memory increment mode)  
        .equ DMA1_PINC_Shift, 9   @ bitWidth 1 (Peripheral increment mode)  
        .equ DMA1_CIRC_Shift, 8   @ bitWidth 1 (Circular mode)  
        .equ DMA1_DIR_Shift, 6   @ bitWidth 2 (Data transfer direction)  
        .equ DMA1_PFCTRL_Shift, 5   @ bitWidth 1 (Peripheral flow controller)  
        .equ DMA1_TCIE_Shift, 4   @ bitWidth 1 (Transfer complete interrupt
  enable)  
        .equ DMA1_HTIE_Shift, 3   @ bitWidth 1 (Half transfer interrupt
  enable)  
        .equ DMA1_TEIE_Shift, 2   @ bitWidth 1 (Transfer error interrupt
  enable)  
        .equ DMA1_DMEIE_Shift, 1   @ bitWidth 1 (Direct mode error interrupt
  enable)  
        .equ DMA1_EN_Shift, 0   @ bitWidth 1 (Stream enable / flag stream ready when
  read low)  
 
    .equ DMA1_S1NDTR, DMA1_BASE + 0x2C @ (stream x number of data
  register) 
        .equ DMA1_NDT_Shift, 0   @ bitWidth 16 (Number of data items to
  transfer)  
 
    .equ DMA1_S1PAR, DMA1_BASE + 0x30 @ (stream x peripheral address
  register) 
        .equ DMA1_PA_Shift, 0   @ bitWidth 32 (Peripheral address)  
 
    .equ DMA1_S1M0AR, DMA1_BASE + 0x34 @ (stream x memory 0 address
  register) 
        .equ DMA1_M0A_Shift, 0   @ bitWidth 32 (Memory 0 address)  
 
    .equ DMA1_S1M1AR, DMA1_BASE + 0x38 @ (stream x memory 1 address
  register) 
        .equ DMA1_M1A_Shift, 0   @ bitWidth 32 (Memory 1 address used in case of Double
  buffer mode)  
 
    .equ DMA1_S1FCR, DMA1_BASE + 0x3C @ (stream x FIFO control register) 
        .equ DMA1_FEIE_Shift, 7   @ bitWidth 1 (FIFO error interrupt
  enable)  
        .equ DMA1_FS_Shift, 3   @ bitWidth 3 (FIFO status)  
        .equ DMA1_DMDIS_Shift, 2   @ bitWidth 1 (Direct mode disable)  
        .equ DMA1_FTH_Shift, 0   @ bitWidth 2 (FIFO threshold selection)  
 
    .equ DMA1_S2CR, DMA1_BASE + 0x40 @ (stream x configuration
  register) 
        .equ DMA1_CHSEL_Shift, 25   @ bitWidth 3 (Channel selection)  
        .equ DMA1_MBURST_Shift, 23   @ bitWidth 2 (Memory burst transfer
  configuration)  
        .equ DMA1_PBURST_Shift, 21   @ bitWidth 2 (Peripheral burst transfer
  configuration)  
        .equ DMA1_ACK_Shift, 20   @ bitWidth 1 (ACK)  
        .equ DMA1_CT_Shift, 19   @ bitWidth 1 (Current target only in double buffer
  mode)  
        .equ DMA1_DBM_Shift, 18   @ bitWidth 1 (Double buffer mode)  
        .equ DMA1_PL_Shift, 16   @ bitWidth 2 (Priority level)  
        .equ DMA1_PINCOS_Shift, 15   @ bitWidth 1 (Peripheral increment offset
  size)  
        .equ DMA1_MSIZE_Shift, 13   @ bitWidth 2 (Memory data size)  
        .equ DMA1_PSIZE_Shift, 11   @ bitWidth 2 (Peripheral data size)  
        .equ DMA1_MINC_Shift, 10   @ bitWidth 1 (Memory increment mode)  
        .equ DMA1_PINC_Shift, 9   @ bitWidth 1 (Peripheral increment mode)  
        .equ DMA1_CIRC_Shift, 8   @ bitWidth 1 (Circular mode)  
        .equ DMA1_DIR_Shift, 6   @ bitWidth 2 (Data transfer direction)  
        .equ DMA1_PFCTRL_Shift, 5   @ bitWidth 1 (Peripheral flow controller)  
        .equ DMA1_TCIE_Shift, 4   @ bitWidth 1 (Transfer complete interrupt
  enable)  
        .equ DMA1_HTIE_Shift, 3   @ bitWidth 1 (Half transfer interrupt
  enable)  
        .equ DMA1_TEIE_Shift, 2   @ bitWidth 1 (Transfer error interrupt
  enable)  
        .equ DMA1_DMEIE_Shift, 1   @ bitWidth 1 (Direct mode error interrupt
  enable)  
        .equ DMA1_EN_Shift, 0   @ bitWidth 1 (Stream enable / flag stream ready when
  read low)  
 
    .equ DMA1_S2NDTR, DMA1_BASE + 0x44 @ (stream x number of data
  register) 
        .equ DMA1_NDT_Shift, 0   @ bitWidth 16 (Number of data items to
  transfer)  
 
    .equ DMA1_S2PAR, DMA1_BASE + 0x48 @ (stream x peripheral address
  register) 
        .equ DMA1_PA_Shift, 0   @ bitWidth 32 (Peripheral address)  
 
    .equ DMA1_S2M0AR, DMA1_BASE + 0x4C @ (stream x memory 0 address
  register) 
        .equ DMA1_M0A_Shift, 0   @ bitWidth 32 (Memory 0 address)  
 
    .equ DMA1_S2M1AR, DMA1_BASE + 0x50 @ (stream x memory 1 address
  register) 
        .equ DMA1_M1A_Shift, 0   @ bitWidth 32 (Memory 1 address used in case of Double
  buffer mode)  
 
    .equ DMA1_S2FCR, DMA1_BASE + 0x54 @ (stream x FIFO control register) 
        .equ DMA1_FEIE_Shift, 7   @ bitWidth 1 (FIFO error interrupt
  enable)  
        .equ DMA1_FS_Shift, 3   @ bitWidth 3 (FIFO status)  
        .equ DMA1_DMDIS_Shift, 2   @ bitWidth 1 (Direct mode disable)  
        .equ DMA1_FTH_Shift, 0   @ bitWidth 2 (FIFO threshold selection)  
 
    .equ DMA1_S3CR, DMA1_BASE + 0x58 @ (stream x configuration
  register) 
        .equ DMA1_CHSEL_Shift, 25   @ bitWidth 3 (Channel selection)  
        .equ DMA1_MBURST_Shift, 23   @ bitWidth 2 (Memory burst transfer
  configuration)  
        .equ DMA1_PBURST_Shift, 21   @ bitWidth 2 (Peripheral burst transfer
  configuration)  
        .equ DMA1_ACK_Shift, 20   @ bitWidth 1 (ACK)  
        .equ DMA1_CT_Shift, 19   @ bitWidth 1 (Current target only in double buffer
  mode)  
        .equ DMA1_DBM_Shift, 18   @ bitWidth 1 (Double buffer mode)  
        .equ DMA1_PL_Shift, 16   @ bitWidth 2 (Priority level)  
        .equ DMA1_PINCOS_Shift, 15   @ bitWidth 1 (Peripheral increment offset
  size)  
        .equ DMA1_MSIZE_Shift, 13   @ bitWidth 2 (Memory data size)  
        .equ DMA1_PSIZE_Shift, 11   @ bitWidth 2 (Peripheral data size)  
        .equ DMA1_MINC_Shift, 10   @ bitWidth 1 (Memory increment mode)  
        .equ DMA1_PINC_Shift, 9   @ bitWidth 1 (Peripheral increment mode)  
        .equ DMA1_CIRC_Shift, 8   @ bitWidth 1 (Circular mode)  
        .equ DMA1_DIR_Shift, 6   @ bitWidth 2 (Data transfer direction)  
        .equ DMA1_PFCTRL_Shift, 5   @ bitWidth 1 (Peripheral flow controller)  
        .equ DMA1_TCIE_Shift, 4   @ bitWidth 1 (Transfer complete interrupt
  enable)  
        .equ DMA1_HTIE_Shift, 3   @ bitWidth 1 (Half transfer interrupt
  enable)  
        .equ DMA1_TEIE_Shift, 2   @ bitWidth 1 (Transfer error interrupt
  enable)  
        .equ DMA1_DMEIE_Shift, 1   @ bitWidth 1 (Direct mode error interrupt
  enable)  
        .equ DMA1_EN_Shift, 0   @ bitWidth 1 (Stream enable / flag stream ready when
  read low)  
 
    .equ DMA1_S3NDTR, DMA1_BASE + 0x5C @ (stream x number of data
  register) 
        .equ DMA1_NDT_Shift, 0   @ bitWidth 16 (Number of data items to
  transfer)  
 
    .equ DMA1_S3PAR, DMA1_BASE + 0x60 @ (stream x peripheral address
  register) 
        .equ DMA1_PA_Shift, 0   @ bitWidth 32 (Peripheral address)  
 
    .equ DMA1_S3M0AR, DMA1_BASE + 0x64 @ (stream x memory 0 address
  register) 
        .equ DMA1_M0A_Shift, 0   @ bitWidth 32 (Memory 0 address)  
 
    .equ DMA1_S3M1AR, DMA1_BASE + 0x68 @ (stream x memory 1 address
  register) 
        .equ DMA1_M1A_Shift, 0   @ bitWidth 32 (Memory 1 address used in case of Double
  buffer mode)  
 
    .equ DMA1_S3FCR, DMA1_BASE + 0x6C @ (stream x FIFO control register) 
        .equ DMA1_FEIE_Shift, 7   @ bitWidth 1 (FIFO error interrupt
  enable)  
        .equ DMA1_FS_Shift, 3   @ bitWidth 3 (FIFO status)  
        .equ DMA1_DMDIS_Shift, 2   @ bitWidth 1 (Direct mode disable)  
        .equ DMA1_FTH_Shift, 0   @ bitWidth 2 (FIFO threshold selection)  
 
    .equ DMA1_S4CR, DMA1_BASE + 0x70 @ (stream x configuration
  register) 
        .equ DMA1_CHSEL_Shift, 25   @ bitWidth 3 (Channel selection)  
        .equ DMA1_MBURST_Shift, 23   @ bitWidth 2 (Memory burst transfer
  configuration)  
        .equ DMA1_PBURST_Shift, 21   @ bitWidth 2 (Peripheral burst transfer
  configuration)  
        .equ DMA1_ACK_Shift, 20   @ bitWidth 1 (ACK)  
        .equ DMA1_CT_Shift, 19   @ bitWidth 1 (Current target only in double buffer
  mode)  
        .equ DMA1_DBM_Shift, 18   @ bitWidth 1 (Double buffer mode)  
        .equ DMA1_PL_Shift, 16   @ bitWidth 2 (Priority level)  
        .equ DMA1_PINCOS_Shift, 15   @ bitWidth 1 (Peripheral increment offset
  size)  
        .equ DMA1_MSIZE_Shift, 13   @ bitWidth 2 (Memory data size)  
        .equ DMA1_PSIZE_Shift, 11   @ bitWidth 2 (Peripheral data size)  
        .equ DMA1_MINC_Shift, 10   @ bitWidth 1 (Memory increment mode)  
        .equ DMA1_PINC_Shift, 9   @ bitWidth 1 (Peripheral increment mode)  
        .equ DMA1_CIRC_Shift, 8   @ bitWidth 1 (Circular mode)  
        .equ DMA1_DIR_Shift, 6   @ bitWidth 2 (Data transfer direction)  
        .equ DMA1_PFCTRL_Shift, 5   @ bitWidth 1 (Peripheral flow controller)  
        .equ DMA1_TCIE_Shift, 4   @ bitWidth 1 (Transfer complete interrupt
  enable)  
        .equ DMA1_HTIE_Shift, 3   @ bitWidth 1 (Half transfer interrupt
  enable)  
        .equ DMA1_TEIE_Shift, 2   @ bitWidth 1 (Transfer error interrupt
  enable)  
        .equ DMA1_DMEIE_Shift, 1   @ bitWidth 1 (Direct mode error interrupt
  enable)  
        .equ DMA1_EN_Shift, 0   @ bitWidth 1 (Stream enable / flag stream ready when
  read low)  
 
    .equ DMA1_S4NDTR, DMA1_BASE + 0x74 @ (stream x number of data
  register) 
        .equ DMA1_NDT_Shift, 0   @ bitWidth 16 (Number of data items to
  transfer)  
 
    .equ DMA1_S4PAR, DMA1_BASE + 0x78 @ (stream x peripheral address
  register) 
        .equ DMA1_PA_Shift, 0   @ bitWidth 32 (Peripheral address)  
 
    .equ DMA1_S4M0AR, DMA1_BASE + 0x7C @ (stream x memory 0 address
  register) 
        .equ DMA1_M0A_Shift, 0   @ bitWidth 32 (Memory 0 address)  
 
    .equ DMA1_S4M1AR, DMA1_BASE + 0x80 @ (stream x memory 1 address
  register) 
        .equ DMA1_M1A_Shift, 0   @ bitWidth 32 (Memory 1 address used in case of Double
  buffer mode)  
 
    .equ DMA1_S4FCR, DMA1_BASE + 0x84 @ (stream x FIFO control register) 
        .equ DMA1_FEIE_Shift, 7   @ bitWidth 1 (FIFO error interrupt
  enable)  
        .equ DMA1_FS_Shift, 3   @ bitWidth 3 (FIFO status)  
        .equ DMA1_DMDIS_Shift, 2   @ bitWidth 1 (Direct mode disable)  
        .equ DMA1_FTH_Shift, 0   @ bitWidth 2 (FIFO threshold selection)  
 
    .equ DMA1_S5CR, DMA1_BASE + 0x88 @ (stream x configuration
  register) 
        .equ DMA1_CHSEL_Shift, 25   @ bitWidth 3 (Channel selection)  
        .equ DMA1_MBURST_Shift, 23   @ bitWidth 2 (Memory burst transfer
  configuration)  
        .equ DMA1_PBURST_Shift, 21   @ bitWidth 2 (Peripheral burst transfer
  configuration)  
        .equ DMA1_ACK_Shift, 20   @ bitWidth 1 (ACK)  
        .equ DMA1_CT_Shift, 19   @ bitWidth 1 (Current target only in double buffer
  mode)  
        .equ DMA1_DBM_Shift, 18   @ bitWidth 1 (Double buffer mode)  
        .equ DMA1_PL_Shift, 16   @ bitWidth 2 (Priority level)  
        .equ DMA1_PINCOS_Shift, 15   @ bitWidth 1 (Peripheral increment offset
  size)  
        .equ DMA1_MSIZE_Shift, 13   @ bitWidth 2 (Memory data size)  
        .equ DMA1_PSIZE_Shift, 11   @ bitWidth 2 (Peripheral data size)  
        .equ DMA1_MINC_Shift, 10   @ bitWidth 1 (Memory increment mode)  
        .equ DMA1_PINC_Shift, 9   @ bitWidth 1 (Peripheral increment mode)  
        .equ DMA1_CIRC_Shift, 8   @ bitWidth 1 (Circular mode)  
        .equ DMA1_DIR_Shift, 6   @ bitWidth 2 (Data transfer direction)  
        .equ DMA1_PFCTRL_Shift, 5   @ bitWidth 1 (Peripheral flow controller)  
        .equ DMA1_TCIE_Shift, 4   @ bitWidth 1 (Transfer complete interrupt
  enable)  
        .equ DMA1_HTIE_Shift, 3   @ bitWidth 1 (Half transfer interrupt
  enable)  
        .equ DMA1_TEIE_Shift, 2   @ bitWidth 1 (Transfer error interrupt
  enable)  
        .equ DMA1_DMEIE_Shift, 1   @ bitWidth 1 (Direct mode error interrupt
  enable)  
        .equ DMA1_EN_Shift, 0   @ bitWidth 1 (Stream enable / flag stream ready when
  read low)  
 
    .equ DMA1_S5NDTR, DMA1_BASE + 0x8C @ (stream x number of data
  register) 
        .equ DMA1_NDT_Shift, 0   @ bitWidth 16 (Number of data items to
  transfer)  
 
    .equ DMA1_S5PAR, DMA1_BASE + 0x90 @ (stream x peripheral address
  register) 
        .equ DMA1_PA_Shift, 0   @ bitWidth 32 (Peripheral address)  
 
    .equ DMA1_S5M0AR, DMA1_BASE + 0x94 @ (stream x memory 0 address
  register) 
        .equ DMA1_M0A_Shift, 0   @ bitWidth 32 (Memory 0 address)  
 
    .equ DMA1_S5M1AR, DMA1_BASE + 0x98 @ (stream x memory 1 address
  register) 
        .equ DMA1_M1A_Shift, 0   @ bitWidth 32 (Memory 1 address used in case of Double
  buffer mode)  
 
    .equ DMA1_S5FCR, DMA1_BASE + 0x9C @ (stream x FIFO control register) 
        .equ DMA1_FEIE_Shift, 7   @ bitWidth 1 (FIFO error interrupt
  enable)  
        .equ DMA1_FS_Shift, 3   @ bitWidth 3 (FIFO status)  
        .equ DMA1_DMDIS_Shift, 2   @ bitWidth 1 (Direct mode disable)  
        .equ DMA1_FTH_Shift, 0   @ bitWidth 2 (FIFO threshold selection)  
 
    .equ DMA1_S6CR, DMA1_BASE + 0xA0 @ (stream x configuration
  register) 
        .equ DMA1_CHSEL_Shift, 25   @ bitWidth 3 (Channel selection)  
        .equ DMA1_MBURST_Shift, 23   @ bitWidth 2 (Memory burst transfer
  configuration)  
        .equ DMA1_PBURST_Shift, 21   @ bitWidth 2 (Peripheral burst transfer
  configuration)  
        .equ DMA1_ACK_Shift, 20   @ bitWidth 1 (ACK)  
        .equ DMA1_CT_Shift, 19   @ bitWidth 1 (Current target only in double buffer
  mode)  
        .equ DMA1_DBM_Shift, 18   @ bitWidth 1 (Double buffer mode)  
        .equ DMA1_PL_Shift, 16   @ bitWidth 2 (Priority level)  
        .equ DMA1_PINCOS_Shift, 15   @ bitWidth 1 (Peripheral increment offset
  size)  
        .equ DMA1_MSIZE_Shift, 13   @ bitWidth 2 (Memory data size)  
        .equ DMA1_PSIZE_Shift, 11   @ bitWidth 2 (Peripheral data size)  
        .equ DMA1_MINC_Shift, 10   @ bitWidth 1 (Memory increment mode)  
        .equ DMA1_PINC_Shift, 9   @ bitWidth 1 (Peripheral increment mode)  
        .equ DMA1_CIRC_Shift, 8   @ bitWidth 1 (Circular mode)  
        .equ DMA1_DIR_Shift, 6   @ bitWidth 2 (Data transfer direction)  
        .equ DMA1_PFCTRL_Shift, 5   @ bitWidth 1 (Peripheral flow controller)  
        .equ DMA1_TCIE_Shift, 4   @ bitWidth 1 (Transfer complete interrupt
  enable)  
        .equ DMA1_HTIE_Shift, 3   @ bitWidth 1 (Half transfer interrupt
  enable)  
        .equ DMA1_TEIE_Shift, 2   @ bitWidth 1 (Transfer error interrupt
  enable)  
        .equ DMA1_DMEIE_Shift, 1   @ bitWidth 1 (Direct mode error interrupt
  enable)  
        .equ DMA1_EN_Shift, 0   @ bitWidth 1 (Stream enable / flag stream ready when
  read low)  
 
    .equ DMA1_S6NDTR, DMA1_BASE + 0xA4 @ (stream x number of data
  register) 
        .equ DMA1_NDT_Shift, 0   @ bitWidth 16 (Number of data items to
  transfer)  
 
    .equ DMA1_S6PAR, DMA1_BASE + 0xA8 @ (stream x peripheral address
  register) 
        .equ DMA1_PA_Shift, 0   @ bitWidth 32 (Peripheral address)  
 
    .equ DMA1_S6M0AR, DMA1_BASE + 0xAC @ (stream x memory 0 address
  register) 
        .equ DMA1_M0A_Shift, 0   @ bitWidth 32 (Memory 0 address)  
 
    .equ DMA1_S6M1AR, DMA1_BASE + 0xB0 @ (stream x memory 1 address
  register) 
        .equ DMA1_M1A_Shift, 0   @ bitWidth 32 (Memory 1 address used in case of Double
  buffer mode)  
 
    .equ DMA1_S6FCR, DMA1_BASE + 0xB4 @ (stream x FIFO control register) 
        .equ DMA1_FEIE_Shift, 7   @ bitWidth 1 (FIFO error interrupt
  enable)  
        .equ DMA1_FS_Shift, 3   @ bitWidth 3 (FIFO status)  
        .equ DMA1_DMDIS_Shift, 2   @ bitWidth 1 (Direct mode disable)  
        .equ DMA1_FTH_Shift, 0   @ bitWidth 2 (FIFO threshold selection)  
 
    .equ DMA1_S7CR, DMA1_BASE + 0xB8 @ (stream x configuration
  register) 
        .equ DMA1_CHSEL_Shift, 25   @ bitWidth 3 (Channel selection)  
        .equ DMA1_MBURST_Shift, 23   @ bitWidth 2 (Memory burst transfer
  configuration)  
        .equ DMA1_PBURST_Shift, 21   @ bitWidth 2 (Peripheral burst transfer
  configuration)  
        .equ DMA1_ACK_Shift, 20   @ bitWidth 1 (ACK)  
        .equ DMA1_CT_Shift, 19   @ bitWidth 1 (Current target only in double buffer
  mode)  
        .equ DMA1_DBM_Shift, 18   @ bitWidth 1 (Double buffer mode)  
        .equ DMA1_PL_Shift, 16   @ bitWidth 2 (Priority level)  
        .equ DMA1_PINCOS_Shift, 15   @ bitWidth 1 (Peripheral increment offset
  size)  
        .equ DMA1_MSIZE_Shift, 13   @ bitWidth 2 (Memory data size)  
        .equ DMA1_PSIZE_Shift, 11   @ bitWidth 2 (Peripheral data size)  
        .equ DMA1_MINC_Shift, 10   @ bitWidth 1 (Memory increment mode)  
        .equ DMA1_PINC_Shift, 9   @ bitWidth 1 (Peripheral increment mode)  
        .equ DMA1_CIRC_Shift, 8   @ bitWidth 1 (Circular mode)  
        .equ DMA1_DIR_Shift, 6   @ bitWidth 2 (Data transfer direction)  
        .equ DMA1_PFCTRL_Shift, 5   @ bitWidth 1 (Peripheral flow controller)  
        .equ DMA1_TCIE_Shift, 4   @ bitWidth 1 (Transfer complete interrupt
  enable)  
        .equ DMA1_HTIE_Shift, 3   @ bitWidth 1 (Half transfer interrupt
  enable)  
        .equ DMA1_TEIE_Shift, 2   @ bitWidth 1 (Transfer error interrupt
  enable)  
        .equ DMA1_DMEIE_Shift, 1   @ bitWidth 1 (Direct mode error interrupt
  enable)  
        .equ DMA1_EN_Shift, 0   @ bitWidth 1 (Stream enable / flag stream ready when
  read low)  
 
    .equ DMA1_S7NDTR, DMA1_BASE + 0xBC @ (stream x number of data
  register) 
        .equ DMA1_NDT_Shift, 0   @ bitWidth 16 (Number of data items to
  transfer)  
 
    .equ DMA1_S7PAR, DMA1_BASE + 0xC0 @ (stream x peripheral address
  register) 
        .equ DMA1_PA_Shift, 0   @ bitWidth 32 (Peripheral address)  
 
    .equ DMA1_S7M0AR, DMA1_BASE + 0xC4 @ (stream x memory 0 address
  register) 
        .equ DMA1_M0A_Shift, 0   @ bitWidth 32 (Memory 0 address)  
 
    .equ DMA1_S7M1AR, DMA1_BASE + 0xC8 @ (stream x memory 1 address
  register) 
        .equ DMA1_M1A_Shift, 0   @ bitWidth 32 (Memory 1 address used in case of Double
  buffer mode)  
 
    .equ DMA1_S7FCR, DMA1_BASE + 0xCC @ (stream x FIFO control register) 
        .equ DMA1_FEIE_Shift, 7   @ bitWidth 1 (FIFO error interrupt
  enable)  
        .equ DMA1_FS_Shift, 3   @ bitWidth 3 (FIFO status)  
        .equ DMA1_DMDIS_Shift, 2   @ bitWidth 1 (Direct mode disable)  
        .equ DMA1_FTH_Shift, 0   @ bitWidth 2 (FIFO threshold selection)  
 

@=========================== GPIOH ===========================@
.equ GPIOH_BASE, 0x40021C00 @ (General-purpose I/Os) 
    .equ GPIOH_MODER, GPIOH_BASE + 0x0 @ (GPIO port mode register) 
        .equ GPIOH_MODER15_Shift, 30   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_MODER14_Shift, 28   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_MODER13_Shift, 26   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_MODER12_Shift, 24   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_MODER11_Shift, 22   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_MODER10_Shift, 20   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_MODER9_Shift, 18   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_MODER8_Shift, 16   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_MODER7_Shift, 14   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_MODER6_Shift, 12   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_MODER5_Shift, 10   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_MODER4_Shift, 8   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_MODER3_Shift, 6   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_MODER2_Shift, 4   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_MODER1_Shift, 2   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_MODER0_Shift, 0   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
 
    .equ GPIOH_OTYPER, GPIOH_BASE + 0x4 @ (GPIO port output type register) 
        .equ GPIOH_OT15_Shift, 15   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_OT14_Shift, 14   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_OT13_Shift, 13   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_OT12_Shift, 12   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_OT11_Shift, 11   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_OT10_Shift, 10   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_OT9_Shift, 9   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_OT8_Shift, 8   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_OT7_Shift, 7   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_OT6_Shift, 6   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_OT5_Shift, 5   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_OT4_Shift, 4   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_OT3_Shift, 3   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_OT2_Shift, 2   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_OT1_Shift, 1   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_OT0_Shift, 0   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
 
    .equ GPIOH_OSPEEDR, GPIOH_BASE + 0x8 @ (GPIO port output speed
  register) 
        .equ GPIOH_OSPEEDR15_Shift, 30   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_OSPEEDR14_Shift, 28   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_OSPEEDR13_Shift, 26   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_OSPEEDR12_Shift, 24   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_OSPEEDR11_Shift, 22   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_OSPEEDR10_Shift, 20   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_OSPEEDR9_Shift, 18   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_OSPEEDR8_Shift, 16   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_OSPEEDR7_Shift, 14   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_OSPEEDR6_Shift, 12   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_OSPEEDR5_Shift, 10   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_OSPEEDR4_Shift, 8   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_OSPEEDR3_Shift, 6   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_OSPEEDR2_Shift, 4   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_OSPEEDR1_Shift, 2   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_OSPEEDR0_Shift, 0   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
 
    .equ GPIOH_PUPDR, GPIOH_BASE + 0xC @ (GPIO port pull-up/pull-down
  register) 
        .equ GPIOH_PUPDR15_Shift, 30   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_PUPDR14_Shift, 28   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_PUPDR13_Shift, 26   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_PUPDR12_Shift, 24   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_PUPDR11_Shift, 22   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_PUPDR10_Shift, 20   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_PUPDR9_Shift, 18   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_PUPDR8_Shift, 16   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_PUPDR7_Shift, 14   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_PUPDR6_Shift, 12   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_PUPDR5_Shift, 10   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_PUPDR4_Shift, 8   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_PUPDR3_Shift, 6   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_PUPDR2_Shift, 4   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_PUPDR1_Shift, 2   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOH_PUPDR0_Shift, 0   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
 
    .equ GPIOH_IDR, GPIOH_BASE + 0x10 @ (GPIO port input data register) 
        .equ GPIOH_IDR15_Shift, 15   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOH_IDR14_Shift, 14   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOH_IDR13_Shift, 13   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOH_IDR12_Shift, 12   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOH_IDR11_Shift, 11   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOH_IDR10_Shift, 10   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOH_IDR9_Shift, 9   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOH_IDR8_Shift, 8   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOH_IDR7_Shift, 7   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOH_IDR6_Shift, 6   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOH_IDR5_Shift, 5   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOH_IDR4_Shift, 4   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOH_IDR3_Shift, 3   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOH_IDR2_Shift, 2   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOH_IDR1_Shift, 1   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOH_IDR0_Shift, 0   @ bitWidth 1 (Port input data y =
  0..15)  
 
    .equ GPIOH_ODR, GPIOH_BASE + 0x14 @ (GPIO port output data register) 
        .equ GPIOH_ODR15_Shift, 15   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOH_ODR14_Shift, 14   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOH_ODR13_Shift, 13   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOH_ODR12_Shift, 12   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOH_ODR11_Shift, 11   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOH_ODR10_Shift, 10   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOH_ODR9_Shift, 9   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOH_ODR8_Shift, 8   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOH_ODR7_Shift, 7   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOH_ODR6_Shift, 6   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOH_ODR5_Shift, 5   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOH_ODR4_Shift, 4   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOH_ODR3_Shift, 3   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOH_ODR2_Shift, 2   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOH_ODR1_Shift, 1   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOH_ODR0_Shift, 0   @ bitWidth 1 (Port output data y =
  0..15)  
 
    .equ GPIOH_BSRR, GPIOH_BASE + 0x18 @ (GPIO port bit set/reset
  register) 
        .equ GPIOH_BR15_Shift, 31   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOH_BR14_Shift, 30   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOH_BR13_Shift, 29   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOH_BR12_Shift, 28   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOH_BR11_Shift, 27   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOH_BR10_Shift, 26   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOH_BR9_Shift, 25   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOH_BR8_Shift, 24   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOH_BR7_Shift, 23   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOH_BR6_Shift, 22   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOH_BR5_Shift, 21   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOH_BR4_Shift, 20   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOH_BR3_Shift, 19   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOH_BR2_Shift, 18   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOH_BR1_Shift, 17   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOH_BR0_Shift, 16   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOH_BS15_Shift, 15   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOH_BS14_Shift, 14   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOH_BS13_Shift, 13   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOH_BS12_Shift, 12   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOH_BS11_Shift, 11   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOH_BS10_Shift, 10   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOH_BS9_Shift, 9   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOH_BS8_Shift, 8   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOH_BS7_Shift, 7   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOH_BS6_Shift, 6   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOH_BS5_Shift, 5   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOH_BS4_Shift, 4   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOH_BS3_Shift, 3   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOH_BS2_Shift, 2   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOH_BS1_Shift, 1   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOH_BS0_Shift, 0   @ bitWidth 1 (Port x set bit y y=
  0..15)  
 
    .equ GPIOH_LCKR, GPIOH_BASE + 0x1C @ (GPIO port configuration lock
  register) 
        .equ GPIOH_LCKK_Shift, 16   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOH_LCK15_Shift, 15   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOH_LCK14_Shift, 14   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOH_LCK13_Shift, 13   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOH_LCK12_Shift, 12   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOH_LCK11_Shift, 11   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOH_LCK10_Shift, 10   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOH_LCK9_Shift, 9   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOH_LCK8_Shift, 8   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOH_LCK7_Shift, 7   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOH_LCK6_Shift, 6   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOH_LCK5_Shift, 5   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOH_LCK4_Shift, 4   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOH_LCK3_Shift, 3   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOH_LCK2_Shift, 2   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOH_LCK1_Shift, 1   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOH_LCK0_Shift, 0   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
 
    .equ GPIOH_AFRL, GPIOH_BASE + 0x20 @ (GPIO alternate function low
  register) 
        .equ GPIOH_AFRL7_Shift, 28   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOH_AFRL6_Shift, 24   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOH_AFRL5_Shift, 20   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOH_AFRL4_Shift, 16   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOH_AFRL3_Shift, 12   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOH_AFRL2_Shift, 8   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOH_AFRL1_Shift, 4   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOH_AFRL0_Shift, 0   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
 
    .equ GPIOH_AFRH, GPIOH_BASE + 0x24 @ (GPIO alternate function high
  register) 
        .equ GPIOH_AFRH15_Shift, 28   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOH_AFRH14_Shift, 24   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOH_AFRH13_Shift, 20   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOH_AFRH12_Shift, 16   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOH_AFRH11_Shift, 12   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOH_AFRH10_Shift, 8   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOH_AFRH9_Shift, 4   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOH_AFRH8_Shift, 0   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
 

@=========================== GPIOE ===========================@
.equ GPIOE_BASE, 0x40021000 @ (General-purpose I/Os) 
    .equ GPIOE_MODER, GPIOE_BASE + 0x0 @ (GPIO port mode register) 
        .equ GPIOE_MODER15_Shift, 30   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_MODER14_Shift, 28   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_MODER13_Shift, 26   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_MODER12_Shift, 24   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_MODER11_Shift, 22   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_MODER10_Shift, 20   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_MODER9_Shift, 18   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_MODER8_Shift, 16   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_MODER7_Shift, 14   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_MODER6_Shift, 12   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_MODER5_Shift, 10   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_MODER4_Shift, 8   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_MODER3_Shift, 6   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_MODER2_Shift, 4   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_MODER1_Shift, 2   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_MODER0_Shift, 0   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
 
    .equ GPIOE_OTYPER, GPIOE_BASE + 0x4 @ (GPIO port output type register) 
        .equ GPIOE_OT15_Shift, 15   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_OT14_Shift, 14   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_OT13_Shift, 13   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_OT12_Shift, 12   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_OT11_Shift, 11   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_OT10_Shift, 10   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_OT9_Shift, 9   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_OT8_Shift, 8   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_OT7_Shift, 7   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_OT6_Shift, 6   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_OT5_Shift, 5   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_OT4_Shift, 4   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_OT3_Shift, 3   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_OT2_Shift, 2   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_OT1_Shift, 1   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_OT0_Shift, 0   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
 
    .equ GPIOE_OSPEEDR, GPIOE_BASE + 0x8 @ (GPIO port output speed
  register) 
        .equ GPIOE_OSPEEDR15_Shift, 30   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_OSPEEDR14_Shift, 28   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_OSPEEDR13_Shift, 26   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_OSPEEDR12_Shift, 24   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_OSPEEDR11_Shift, 22   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_OSPEEDR10_Shift, 20   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_OSPEEDR9_Shift, 18   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_OSPEEDR8_Shift, 16   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_OSPEEDR7_Shift, 14   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_OSPEEDR6_Shift, 12   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_OSPEEDR5_Shift, 10   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_OSPEEDR4_Shift, 8   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_OSPEEDR3_Shift, 6   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_OSPEEDR2_Shift, 4   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_OSPEEDR1_Shift, 2   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_OSPEEDR0_Shift, 0   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
 
    .equ GPIOE_PUPDR, GPIOE_BASE + 0xC @ (GPIO port pull-up/pull-down
  register) 
        .equ GPIOE_PUPDR15_Shift, 30   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_PUPDR14_Shift, 28   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_PUPDR13_Shift, 26   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_PUPDR12_Shift, 24   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_PUPDR11_Shift, 22   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_PUPDR10_Shift, 20   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_PUPDR9_Shift, 18   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_PUPDR8_Shift, 16   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_PUPDR7_Shift, 14   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_PUPDR6_Shift, 12   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_PUPDR5_Shift, 10   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_PUPDR4_Shift, 8   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_PUPDR3_Shift, 6   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_PUPDR2_Shift, 4   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_PUPDR1_Shift, 2   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOE_PUPDR0_Shift, 0   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
 
    .equ GPIOE_IDR, GPIOE_BASE + 0x10 @ (GPIO port input data register) 
        .equ GPIOE_IDR15_Shift, 15   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOE_IDR14_Shift, 14   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOE_IDR13_Shift, 13   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOE_IDR12_Shift, 12   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOE_IDR11_Shift, 11   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOE_IDR10_Shift, 10   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOE_IDR9_Shift, 9   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOE_IDR8_Shift, 8   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOE_IDR7_Shift, 7   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOE_IDR6_Shift, 6   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOE_IDR5_Shift, 5   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOE_IDR4_Shift, 4   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOE_IDR3_Shift, 3   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOE_IDR2_Shift, 2   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOE_IDR1_Shift, 1   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOE_IDR0_Shift, 0   @ bitWidth 1 (Port input data y =
  0..15)  
 
    .equ GPIOE_ODR, GPIOE_BASE + 0x14 @ (GPIO port output data register) 
        .equ GPIOE_ODR15_Shift, 15   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOE_ODR14_Shift, 14   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOE_ODR13_Shift, 13   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOE_ODR12_Shift, 12   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOE_ODR11_Shift, 11   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOE_ODR10_Shift, 10   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOE_ODR9_Shift, 9   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOE_ODR8_Shift, 8   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOE_ODR7_Shift, 7   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOE_ODR6_Shift, 6   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOE_ODR5_Shift, 5   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOE_ODR4_Shift, 4   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOE_ODR3_Shift, 3   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOE_ODR2_Shift, 2   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOE_ODR1_Shift, 1   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOE_ODR0_Shift, 0   @ bitWidth 1 (Port output data y =
  0..15)  
 
    .equ GPIOE_BSRR, GPIOE_BASE + 0x18 @ (GPIO port bit set/reset
  register) 
        .equ GPIOE_BR15_Shift, 31   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOE_BR14_Shift, 30   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOE_BR13_Shift, 29   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOE_BR12_Shift, 28   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOE_BR11_Shift, 27   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOE_BR10_Shift, 26   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOE_BR9_Shift, 25   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOE_BR8_Shift, 24   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOE_BR7_Shift, 23   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOE_BR6_Shift, 22   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOE_BR5_Shift, 21   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOE_BR4_Shift, 20   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOE_BR3_Shift, 19   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOE_BR2_Shift, 18   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOE_BR1_Shift, 17   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOE_BR0_Shift, 16   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOE_BS15_Shift, 15   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOE_BS14_Shift, 14   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOE_BS13_Shift, 13   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOE_BS12_Shift, 12   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOE_BS11_Shift, 11   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOE_BS10_Shift, 10   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOE_BS9_Shift, 9   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOE_BS8_Shift, 8   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOE_BS7_Shift, 7   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOE_BS6_Shift, 6   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOE_BS5_Shift, 5   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOE_BS4_Shift, 4   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOE_BS3_Shift, 3   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOE_BS2_Shift, 2   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOE_BS1_Shift, 1   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOE_BS0_Shift, 0   @ bitWidth 1 (Port x set bit y y=
  0..15)  
 
    .equ GPIOE_LCKR, GPIOE_BASE + 0x1C @ (GPIO port configuration lock
  register) 
        .equ GPIOE_LCKK_Shift, 16   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOE_LCK15_Shift, 15   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOE_LCK14_Shift, 14   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOE_LCK13_Shift, 13   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOE_LCK12_Shift, 12   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOE_LCK11_Shift, 11   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOE_LCK10_Shift, 10   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOE_LCK9_Shift, 9   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOE_LCK8_Shift, 8   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOE_LCK7_Shift, 7   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOE_LCK6_Shift, 6   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOE_LCK5_Shift, 5   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOE_LCK4_Shift, 4   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOE_LCK3_Shift, 3   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOE_LCK2_Shift, 2   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOE_LCK1_Shift, 1   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOE_LCK0_Shift, 0   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
 
    .equ GPIOE_AFRL, GPIOE_BASE + 0x20 @ (GPIO alternate function low
  register) 
        .equ GPIOE_AFRL7_Shift, 28   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOE_AFRL6_Shift, 24   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOE_AFRL5_Shift, 20   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOE_AFRL4_Shift, 16   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOE_AFRL3_Shift, 12   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOE_AFRL2_Shift, 8   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOE_AFRL1_Shift, 4   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOE_AFRL0_Shift, 0   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
 
    .equ GPIOE_AFRH, GPIOE_BASE + 0x24 @ (GPIO alternate function high
  register) 
        .equ GPIOE_AFRH15_Shift, 28   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOE_AFRH14_Shift, 24   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOE_AFRH13_Shift, 20   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOE_AFRH12_Shift, 16   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOE_AFRH11_Shift, 12   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOE_AFRH10_Shift, 8   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOE_AFRH9_Shift, 4   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOE_AFRH8_Shift, 0   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
 

@=========================== GPIOD ===========================@
.equ GPIOD_BASE, 0X40020C00 @ (General-purpose I/Os) 
    .equ GPIOD_MODER, GPIOD_BASE + 0x0 @ (GPIO port mode register) 
        .equ GPIOD_MODER15_Shift, 30   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_MODER14_Shift, 28   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_MODER13_Shift, 26   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_MODER12_Shift, 24   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_MODER11_Shift, 22   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_MODER10_Shift, 20   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_MODER9_Shift, 18   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_MODER8_Shift, 16   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_MODER7_Shift, 14   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_MODER6_Shift, 12   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_MODER5_Shift, 10   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_MODER4_Shift, 8   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_MODER3_Shift, 6   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_MODER2_Shift, 4   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_MODER1_Shift, 2   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_MODER0_Shift, 0   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
 
    .equ GPIOD_OTYPER, GPIOD_BASE + 0x4 @ (GPIO port output type register) 
        .equ GPIOD_OT15_Shift, 15   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_OT14_Shift, 14   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_OT13_Shift, 13   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_OT12_Shift, 12   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_OT11_Shift, 11   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_OT10_Shift, 10   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_OT9_Shift, 9   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_OT8_Shift, 8   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_OT7_Shift, 7   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_OT6_Shift, 6   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_OT5_Shift, 5   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_OT4_Shift, 4   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_OT3_Shift, 3   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_OT2_Shift, 2   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_OT1_Shift, 1   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_OT0_Shift, 0   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
 
    .equ GPIOD_OSPEEDR, GPIOD_BASE + 0x8 @ (GPIO port output speed
  register) 
        .equ GPIOD_OSPEEDR15_Shift, 30   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_OSPEEDR14_Shift, 28   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_OSPEEDR13_Shift, 26   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_OSPEEDR12_Shift, 24   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_OSPEEDR11_Shift, 22   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_OSPEEDR10_Shift, 20   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_OSPEEDR9_Shift, 18   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_OSPEEDR8_Shift, 16   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_OSPEEDR7_Shift, 14   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_OSPEEDR6_Shift, 12   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_OSPEEDR5_Shift, 10   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_OSPEEDR4_Shift, 8   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_OSPEEDR3_Shift, 6   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_OSPEEDR2_Shift, 4   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_OSPEEDR1_Shift, 2   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_OSPEEDR0_Shift, 0   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
 
    .equ GPIOD_PUPDR, GPIOD_BASE + 0xC @ (GPIO port pull-up/pull-down
  register) 
        .equ GPIOD_PUPDR15_Shift, 30   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_PUPDR14_Shift, 28   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_PUPDR13_Shift, 26   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_PUPDR12_Shift, 24   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_PUPDR11_Shift, 22   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_PUPDR10_Shift, 20   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_PUPDR9_Shift, 18   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_PUPDR8_Shift, 16   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_PUPDR7_Shift, 14   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_PUPDR6_Shift, 12   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_PUPDR5_Shift, 10   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_PUPDR4_Shift, 8   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_PUPDR3_Shift, 6   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_PUPDR2_Shift, 4   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_PUPDR1_Shift, 2   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOD_PUPDR0_Shift, 0   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
 
    .equ GPIOD_IDR, GPIOD_BASE + 0x10 @ (GPIO port input data register) 
        .equ GPIOD_IDR15_Shift, 15   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOD_IDR14_Shift, 14   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOD_IDR13_Shift, 13   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOD_IDR12_Shift, 12   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOD_IDR11_Shift, 11   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOD_IDR10_Shift, 10   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOD_IDR9_Shift, 9   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOD_IDR8_Shift, 8   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOD_IDR7_Shift, 7   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOD_IDR6_Shift, 6   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOD_IDR5_Shift, 5   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOD_IDR4_Shift, 4   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOD_IDR3_Shift, 3   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOD_IDR2_Shift, 2   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOD_IDR1_Shift, 1   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOD_IDR0_Shift, 0   @ bitWidth 1 (Port input data y =
  0..15)  
 
    .equ GPIOD_ODR, GPIOD_BASE + 0x14 @ (GPIO port output data register) 
        .equ GPIOD_ODR15_Shift, 15   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOD_ODR14_Shift, 14   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOD_ODR13_Shift, 13   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOD_ODR12_Shift, 12   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOD_ODR11_Shift, 11   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOD_ODR10_Shift, 10   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOD_ODR9_Shift, 9   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOD_ODR8_Shift, 8   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOD_ODR7_Shift, 7   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOD_ODR6_Shift, 6   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOD_ODR5_Shift, 5   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOD_ODR4_Shift, 4   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOD_ODR3_Shift, 3   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOD_ODR2_Shift, 2   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOD_ODR1_Shift, 1   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOD_ODR0_Shift, 0   @ bitWidth 1 (Port output data y =
  0..15)  
 
    .equ GPIOD_BSRR, GPIOD_BASE + 0x18 @ (GPIO port bit set/reset
  register) 
        .equ GPIOD_BR15_Shift, 31   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOD_BR14_Shift, 30   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOD_BR13_Shift, 29   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOD_BR12_Shift, 28   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOD_BR11_Shift, 27   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOD_BR10_Shift, 26   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOD_BR9_Shift, 25   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOD_BR8_Shift, 24   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOD_BR7_Shift, 23   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOD_BR6_Shift, 22   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOD_BR5_Shift, 21   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOD_BR4_Shift, 20   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOD_BR3_Shift, 19   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOD_BR2_Shift, 18   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOD_BR1_Shift, 17   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOD_BR0_Shift, 16   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOD_BS15_Shift, 15   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOD_BS14_Shift, 14   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOD_BS13_Shift, 13   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOD_BS12_Shift, 12   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOD_BS11_Shift, 11   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOD_BS10_Shift, 10   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOD_BS9_Shift, 9   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOD_BS8_Shift, 8   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOD_BS7_Shift, 7   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOD_BS6_Shift, 6   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOD_BS5_Shift, 5   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOD_BS4_Shift, 4   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOD_BS3_Shift, 3   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOD_BS2_Shift, 2   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOD_BS1_Shift, 1   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOD_BS0_Shift, 0   @ bitWidth 1 (Port x set bit y y=
  0..15)  
 
    .equ GPIOD_LCKR, GPIOD_BASE + 0x1C @ (GPIO port configuration lock
  register) 
        .equ GPIOD_LCKK_Shift, 16   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOD_LCK15_Shift, 15   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOD_LCK14_Shift, 14   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOD_LCK13_Shift, 13   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOD_LCK12_Shift, 12   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOD_LCK11_Shift, 11   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOD_LCK10_Shift, 10   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOD_LCK9_Shift, 9   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOD_LCK8_Shift, 8   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOD_LCK7_Shift, 7   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOD_LCK6_Shift, 6   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOD_LCK5_Shift, 5   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOD_LCK4_Shift, 4   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOD_LCK3_Shift, 3   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOD_LCK2_Shift, 2   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOD_LCK1_Shift, 1   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOD_LCK0_Shift, 0   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
 
    .equ GPIOD_AFRL, GPIOD_BASE + 0x20 @ (GPIO alternate function low
  register) 
        .equ GPIOD_AFRL7_Shift, 28   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOD_AFRL6_Shift, 24   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOD_AFRL5_Shift, 20   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOD_AFRL4_Shift, 16   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOD_AFRL3_Shift, 12   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOD_AFRL2_Shift, 8   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOD_AFRL1_Shift, 4   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOD_AFRL0_Shift, 0   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
 
    .equ GPIOD_AFRH, GPIOD_BASE + 0x24 @ (GPIO alternate function high
  register) 
        .equ GPIOD_AFRH15_Shift, 28   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOD_AFRH14_Shift, 24   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOD_AFRH13_Shift, 20   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOD_AFRH12_Shift, 16   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOD_AFRH11_Shift, 12   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOD_AFRH10_Shift, 8   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOD_AFRH9_Shift, 4   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOD_AFRH8_Shift, 0   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
 

@=========================== GPIOC ===========================@
.equ GPIOC_BASE, 0x40020800 @ (General-purpose I/Os) 
    .equ GPIOC_MODER, GPIOC_BASE + 0x0 @ (GPIO port mode register) 
        .equ GPIOC_MODER15_Shift, 30   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_MODER14_Shift, 28   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_MODER13_Shift, 26   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_MODER12_Shift, 24   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_MODER11_Shift, 22   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_MODER10_Shift, 20   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_MODER9_Shift, 18   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_MODER8_Shift, 16   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_MODER7_Shift, 14   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_MODER6_Shift, 12   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_MODER5_Shift, 10   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_MODER4_Shift, 8   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_MODER3_Shift, 6   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_MODER2_Shift, 4   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_MODER1_Shift, 2   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_MODER0_Shift, 0   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
 
    .equ GPIOC_OTYPER, GPIOC_BASE + 0x4 @ (GPIO port output type register) 
        .equ GPIOC_OT15_Shift, 15   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_OT14_Shift, 14   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_OT13_Shift, 13   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_OT12_Shift, 12   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_OT11_Shift, 11   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_OT10_Shift, 10   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_OT9_Shift, 9   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_OT8_Shift, 8   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_OT7_Shift, 7   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_OT6_Shift, 6   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_OT5_Shift, 5   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_OT4_Shift, 4   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_OT3_Shift, 3   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_OT2_Shift, 2   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_OT1_Shift, 1   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_OT0_Shift, 0   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
 
    .equ GPIOC_OSPEEDR, GPIOC_BASE + 0x8 @ (GPIO port output speed
  register) 
        .equ GPIOC_OSPEEDR15_Shift, 30   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_OSPEEDR14_Shift, 28   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_OSPEEDR13_Shift, 26   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_OSPEEDR12_Shift, 24   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_OSPEEDR11_Shift, 22   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_OSPEEDR10_Shift, 20   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_OSPEEDR9_Shift, 18   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_OSPEEDR8_Shift, 16   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_OSPEEDR7_Shift, 14   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_OSPEEDR6_Shift, 12   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_OSPEEDR5_Shift, 10   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_OSPEEDR4_Shift, 8   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_OSPEEDR3_Shift, 6   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_OSPEEDR2_Shift, 4   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_OSPEEDR1_Shift, 2   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_OSPEEDR0_Shift, 0   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
 
    .equ GPIOC_PUPDR, GPIOC_BASE + 0xC @ (GPIO port pull-up/pull-down
  register) 
        .equ GPIOC_PUPDR15_Shift, 30   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_PUPDR14_Shift, 28   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_PUPDR13_Shift, 26   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_PUPDR12_Shift, 24   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_PUPDR11_Shift, 22   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_PUPDR10_Shift, 20   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_PUPDR9_Shift, 18   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_PUPDR8_Shift, 16   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_PUPDR7_Shift, 14   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_PUPDR6_Shift, 12   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_PUPDR5_Shift, 10   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_PUPDR4_Shift, 8   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_PUPDR3_Shift, 6   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_PUPDR2_Shift, 4   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_PUPDR1_Shift, 2   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOC_PUPDR0_Shift, 0   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
 
    .equ GPIOC_IDR, GPIOC_BASE + 0x10 @ (GPIO port input data register) 
        .equ GPIOC_IDR15_Shift, 15   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOC_IDR14_Shift, 14   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOC_IDR13_Shift, 13   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOC_IDR12_Shift, 12   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOC_IDR11_Shift, 11   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOC_IDR10_Shift, 10   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOC_IDR9_Shift, 9   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOC_IDR8_Shift, 8   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOC_IDR7_Shift, 7   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOC_IDR6_Shift, 6   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOC_IDR5_Shift, 5   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOC_IDR4_Shift, 4   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOC_IDR3_Shift, 3   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOC_IDR2_Shift, 2   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOC_IDR1_Shift, 1   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOC_IDR0_Shift, 0   @ bitWidth 1 (Port input data y =
  0..15)  
 
    .equ GPIOC_ODR, GPIOC_BASE + 0x14 @ (GPIO port output data register) 
        .equ GPIOC_ODR15_Shift, 15   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOC_ODR14_Shift, 14   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOC_ODR13_Shift, 13   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOC_ODR12_Shift, 12   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOC_ODR11_Shift, 11   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOC_ODR10_Shift, 10   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOC_ODR9_Shift, 9   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOC_ODR8_Shift, 8   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOC_ODR7_Shift, 7   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOC_ODR6_Shift, 6   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOC_ODR5_Shift, 5   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOC_ODR4_Shift, 4   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOC_ODR3_Shift, 3   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOC_ODR2_Shift, 2   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOC_ODR1_Shift, 1   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOC_ODR0_Shift, 0   @ bitWidth 1 (Port output data y =
  0..15)  
 
    .equ GPIOC_BSRR, GPIOC_BASE + 0x18 @ (GPIO port bit set/reset
  register) 
        .equ GPIOC_BR15_Shift, 31   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOC_BR14_Shift, 30   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOC_BR13_Shift, 29   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOC_BR12_Shift, 28   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOC_BR11_Shift, 27   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOC_BR10_Shift, 26   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOC_BR9_Shift, 25   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOC_BR8_Shift, 24   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOC_BR7_Shift, 23   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOC_BR6_Shift, 22   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOC_BR5_Shift, 21   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOC_BR4_Shift, 20   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOC_BR3_Shift, 19   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOC_BR2_Shift, 18   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOC_BR1_Shift, 17   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOC_BR0_Shift, 16   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOC_BS15_Shift, 15   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOC_BS14_Shift, 14   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOC_BS13_Shift, 13   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOC_BS12_Shift, 12   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOC_BS11_Shift, 11   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOC_BS10_Shift, 10   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOC_BS9_Shift, 9   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOC_BS8_Shift, 8   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOC_BS7_Shift, 7   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOC_BS6_Shift, 6   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOC_BS5_Shift, 5   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOC_BS4_Shift, 4   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOC_BS3_Shift, 3   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOC_BS2_Shift, 2   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOC_BS1_Shift, 1   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOC_BS0_Shift, 0   @ bitWidth 1 (Port x set bit y y=
  0..15)  
 
    .equ GPIOC_LCKR, GPIOC_BASE + 0x1C @ (GPIO port configuration lock
  register) 
        .equ GPIOC_LCKK_Shift, 16   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOC_LCK15_Shift, 15   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOC_LCK14_Shift, 14   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOC_LCK13_Shift, 13   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOC_LCK12_Shift, 12   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOC_LCK11_Shift, 11   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOC_LCK10_Shift, 10   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOC_LCK9_Shift, 9   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOC_LCK8_Shift, 8   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOC_LCK7_Shift, 7   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOC_LCK6_Shift, 6   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOC_LCK5_Shift, 5   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOC_LCK4_Shift, 4   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOC_LCK3_Shift, 3   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOC_LCK2_Shift, 2   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOC_LCK1_Shift, 1   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOC_LCK0_Shift, 0   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
 
    .equ GPIOC_AFRL, GPIOC_BASE + 0x20 @ (GPIO alternate function low
  register) 
        .equ GPIOC_AFRL7_Shift, 28   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOC_AFRL6_Shift, 24   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOC_AFRL5_Shift, 20   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOC_AFRL4_Shift, 16   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOC_AFRL3_Shift, 12   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOC_AFRL2_Shift, 8   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOC_AFRL1_Shift, 4   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOC_AFRL0_Shift, 0   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
 
    .equ GPIOC_AFRH, GPIOC_BASE + 0x24 @ (GPIO alternate function high
  register) 
        .equ GPIOC_AFRH15_Shift, 28   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOC_AFRH14_Shift, 24   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOC_AFRH13_Shift, 20   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOC_AFRH12_Shift, 16   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOC_AFRH11_Shift, 12   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOC_AFRH10_Shift, 8   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOC_AFRH9_Shift, 4   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOC_AFRH8_Shift, 0   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
 

@=========================== GPIOB ===========================@
.equ GPIOB_BASE, 0x40020400 @ (General-purpose I/Os) 
    .equ GPIOB_MODER, GPIOB_BASE + 0x0 @ (GPIO port mode register) 
        .equ GPIOB_MODER15_Shift, 30   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_MODER14_Shift, 28   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_MODER13_Shift, 26   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_MODER12_Shift, 24   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_MODER11_Shift, 22   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_MODER10_Shift, 20   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_MODER9_Shift, 18   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_MODER8_Shift, 16   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_MODER7_Shift, 14   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_MODER6_Shift, 12   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_MODER5_Shift, 10   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_MODER4_Shift, 8   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_MODER3_Shift, 6   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_MODER2_Shift, 4   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_MODER1_Shift, 2   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_MODER0_Shift, 0   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
 
    .equ GPIOB_OTYPER, GPIOB_BASE + 0x4 @ (GPIO port output type register) 
        .equ GPIOB_OT15_Shift, 15   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_OT14_Shift, 14   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_OT13_Shift, 13   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_OT12_Shift, 12   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_OT11_Shift, 11   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_OT10_Shift, 10   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_OT9_Shift, 9   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_OT8_Shift, 8   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_OT7_Shift, 7   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_OT6_Shift, 6   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_OT5_Shift, 5   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_OT4_Shift, 4   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_OT3_Shift, 3   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_OT2_Shift, 2   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_OT1_Shift, 1   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_OT0_Shift, 0   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
 
    .equ GPIOB_OSPEEDR, GPIOB_BASE + 0x8 @ (GPIO port output speed
  register) 
        .equ GPIOB_OSPEEDR15_Shift, 30   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_OSPEEDR14_Shift, 28   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_OSPEEDR13_Shift, 26   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_OSPEEDR12_Shift, 24   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_OSPEEDR11_Shift, 22   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_OSPEEDR10_Shift, 20   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_OSPEEDR9_Shift, 18   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_OSPEEDR8_Shift, 16   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_OSPEEDR7_Shift, 14   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_OSPEEDR6_Shift, 12   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_OSPEEDR5_Shift, 10   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_OSPEEDR4_Shift, 8   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_OSPEEDR3_Shift, 6   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_OSPEEDR2_Shift, 4   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_OSPEEDR1_Shift, 2   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_OSPEEDR0_Shift, 0   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
 
    .equ GPIOB_PUPDR, GPIOB_BASE + 0xC @ (GPIO port pull-up/pull-down
  register) 
        .equ GPIOB_PUPDR15_Shift, 30   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_PUPDR14_Shift, 28   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_PUPDR13_Shift, 26   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_PUPDR12_Shift, 24   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_PUPDR11_Shift, 22   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_PUPDR10_Shift, 20   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_PUPDR9_Shift, 18   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_PUPDR8_Shift, 16   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_PUPDR7_Shift, 14   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_PUPDR6_Shift, 12   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_PUPDR5_Shift, 10   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_PUPDR4_Shift, 8   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_PUPDR3_Shift, 6   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_PUPDR2_Shift, 4   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_PUPDR1_Shift, 2   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOB_PUPDR0_Shift, 0   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
 
    .equ GPIOB_IDR, GPIOB_BASE + 0x10 @ (GPIO port input data register) 
        .equ GPIOB_IDR15_Shift, 15   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOB_IDR14_Shift, 14   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOB_IDR13_Shift, 13   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOB_IDR12_Shift, 12   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOB_IDR11_Shift, 11   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOB_IDR10_Shift, 10   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOB_IDR9_Shift, 9   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOB_IDR8_Shift, 8   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOB_IDR7_Shift, 7   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOB_IDR6_Shift, 6   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOB_IDR5_Shift, 5   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOB_IDR4_Shift, 4   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOB_IDR3_Shift, 3   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOB_IDR2_Shift, 2   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOB_IDR1_Shift, 1   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOB_IDR0_Shift, 0   @ bitWidth 1 (Port input data y =
  0..15)  
 
    .equ GPIOB_ODR, GPIOB_BASE + 0x14 @ (GPIO port output data register) 
        .equ GPIOB_ODR15_Shift, 15   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOB_ODR14_Shift, 14   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOB_ODR13_Shift, 13   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOB_ODR12_Shift, 12   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOB_ODR11_Shift, 11   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOB_ODR10_Shift, 10   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOB_ODR9_Shift, 9   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOB_ODR8_Shift, 8   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOB_ODR7_Shift, 7   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOB_ODR6_Shift, 6   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOB_ODR5_Shift, 5   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOB_ODR4_Shift, 4   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOB_ODR3_Shift, 3   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOB_ODR2_Shift, 2   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOB_ODR1_Shift, 1   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOB_ODR0_Shift, 0   @ bitWidth 1 (Port output data y =
  0..15)  
 
    .equ GPIOB_BSRR, GPIOB_BASE + 0x18 @ (GPIO port bit set/reset
  register) 
        .equ GPIOB_BR15_Shift, 31   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOB_BR14_Shift, 30   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOB_BR13_Shift, 29   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOB_BR12_Shift, 28   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOB_BR11_Shift, 27   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOB_BR10_Shift, 26   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOB_BR9_Shift, 25   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOB_BR8_Shift, 24   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOB_BR7_Shift, 23   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOB_BR6_Shift, 22   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOB_BR5_Shift, 21   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOB_BR4_Shift, 20   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOB_BR3_Shift, 19   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOB_BR2_Shift, 18   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOB_BR1_Shift, 17   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOB_BR0_Shift, 16   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOB_BS15_Shift, 15   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOB_BS14_Shift, 14   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOB_BS13_Shift, 13   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOB_BS12_Shift, 12   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOB_BS11_Shift, 11   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOB_BS10_Shift, 10   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOB_BS9_Shift, 9   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOB_BS8_Shift, 8   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOB_BS7_Shift, 7   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOB_BS6_Shift, 6   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOB_BS5_Shift, 5   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOB_BS4_Shift, 4   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOB_BS3_Shift, 3   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOB_BS2_Shift, 2   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOB_BS1_Shift, 1   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOB_BS0_Shift, 0   @ bitWidth 1 (Port x set bit y y=
  0..15)  
 
    .equ GPIOB_LCKR, GPIOB_BASE + 0x1C @ (GPIO port configuration lock
  register) 
        .equ GPIOB_LCKK_Shift, 16   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOB_LCK15_Shift, 15   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOB_LCK14_Shift, 14   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOB_LCK13_Shift, 13   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOB_LCK12_Shift, 12   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOB_LCK11_Shift, 11   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOB_LCK10_Shift, 10   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOB_LCK9_Shift, 9   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOB_LCK8_Shift, 8   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOB_LCK7_Shift, 7   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOB_LCK6_Shift, 6   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOB_LCK5_Shift, 5   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOB_LCK4_Shift, 4   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOB_LCK3_Shift, 3   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOB_LCK2_Shift, 2   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOB_LCK1_Shift, 1   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOB_LCK0_Shift, 0   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
 
    .equ GPIOB_AFRL, GPIOB_BASE + 0x20 @ (GPIO alternate function low
  register) 
        .equ GPIOB_AFRL7_Shift, 28   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOB_AFRL6_Shift, 24   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOB_AFRL5_Shift, 20   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOB_AFRL4_Shift, 16   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOB_AFRL3_Shift, 12   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOB_AFRL2_Shift, 8   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOB_AFRL1_Shift, 4   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOB_AFRL0_Shift, 0   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
 
    .equ GPIOB_AFRH, GPIOB_BASE + 0x24 @ (GPIO alternate function high
  register) 
        .equ GPIOB_AFRH15_Shift, 28   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOB_AFRH14_Shift, 24   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOB_AFRH13_Shift, 20   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOB_AFRH12_Shift, 16   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOB_AFRH11_Shift, 12   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOB_AFRH10_Shift, 8   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOB_AFRH9_Shift, 4   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOB_AFRH8_Shift, 0   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
 

@=========================== GPIOA ===========================@
.equ GPIOA_BASE, 0x40020000 @ (General-purpose I/Os) 
    .equ GPIOA_MODER, GPIOA_BASE + 0x0 @ (GPIO port mode register) 
        .equ GPIOA_MODER15_Shift, 30   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_MODER14_Shift, 28   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_MODER13_Shift, 26   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_MODER12_Shift, 24   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_MODER11_Shift, 22   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_MODER10_Shift, 20   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_MODER9_Shift, 18   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_MODER8_Shift, 16   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_MODER7_Shift, 14   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_MODER6_Shift, 12   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_MODER5_Shift, 10   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_MODER4_Shift, 8   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_MODER3_Shift, 6   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_MODER2_Shift, 4   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_MODER1_Shift, 2   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_MODER0_Shift, 0   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
 
    .equ GPIOA_OTYPER, GPIOA_BASE + 0x4 @ (GPIO port output type register) 
        .equ GPIOA_OT15_Shift, 15   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_OT14_Shift, 14   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_OT13_Shift, 13   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_OT12_Shift, 12   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_OT11_Shift, 11   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_OT10_Shift, 10   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_OT9_Shift, 9   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_OT8_Shift, 8   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_OT7_Shift, 7   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_OT6_Shift, 6   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_OT5_Shift, 5   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_OT4_Shift, 4   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_OT3_Shift, 3   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_OT2_Shift, 2   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_OT1_Shift, 1   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_OT0_Shift, 0   @ bitWidth 1 (Port x configuration bits y =
  0..15)  
 
    .equ GPIOA_OSPEEDR, GPIOA_BASE + 0x8 @ (GPIO port output speed
  register) 
        .equ GPIOA_OSPEEDR15_Shift, 30   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_OSPEEDR14_Shift, 28   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_OSPEEDR13_Shift, 26   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_OSPEEDR12_Shift, 24   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_OSPEEDR11_Shift, 22   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_OSPEEDR10_Shift, 20   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_OSPEEDR9_Shift, 18   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_OSPEEDR8_Shift, 16   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_OSPEEDR7_Shift, 14   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_OSPEEDR6_Shift, 12   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_OSPEEDR5_Shift, 10   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_OSPEEDR4_Shift, 8   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_OSPEEDR3_Shift, 6   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_OSPEEDR2_Shift, 4   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_OSPEEDR1_Shift, 2   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_OSPEEDR0_Shift, 0   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
 
    .equ GPIOA_PUPDR, GPIOA_BASE + 0xC @ (GPIO port pull-up/pull-down
  register) 
        .equ GPIOA_PUPDR15_Shift, 30   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_PUPDR14_Shift, 28   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_PUPDR13_Shift, 26   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_PUPDR12_Shift, 24   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_PUPDR11_Shift, 22   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_PUPDR10_Shift, 20   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_PUPDR9_Shift, 18   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_PUPDR8_Shift, 16   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_PUPDR7_Shift, 14   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_PUPDR6_Shift, 12   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_PUPDR5_Shift, 10   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_PUPDR4_Shift, 8   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_PUPDR3_Shift, 6   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_PUPDR2_Shift, 4   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_PUPDR1_Shift, 2   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
        .equ GPIOA_PUPDR0_Shift, 0   @ bitWidth 2 (Port x configuration bits y =
  0..15)  
 
    .equ GPIOA_IDR, GPIOA_BASE + 0x10 @ (GPIO port input data register) 
        .equ GPIOA_IDR15_Shift, 15   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOA_IDR14_Shift, 14   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOA_IDR13_Shift, 13   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOA_IDR12_Shift, 12   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOA_IDR11_Shift, 11   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOA_IDR10_Shift, 10   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOA_IDR9_Shift, 9   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOA_IDR8_Shift, 8   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOA_IDR7_Shift, 7   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOA_IDR6_Shift, 6   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOA_IDR5_Shift, 5   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOA_IDR4_Shift, 4   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOA_IDR3_Shift, 3   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOA_IDR2_Shift, 2   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOA_IDR1_Shift, 1   @ bitWidth 1 (Port input data y =
  0..15)  
        .equ GPIOA_IDR0_Shift, 0   @ bitWidth 1 (Port input data y =
  0..15)  
 
    .equ GPIOA_ODR, GPIOA_BASE + 0x14 @ (GPIO port output data register) 
        .equ GPIOA_ODR15_Shift, 15   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOA_ODR14_Shift, 14   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOA_ODR13_Shift, 13   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOA_ODR12_Shift, 12   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOA_ODR11_Shift, 11   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOA_ODR10_Shift, 10   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOA_ODR9_Shift, 9   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOA_ODR8_Shift, 8   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOA_ODR7_Shift, 7   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOA_ODR6_Shift, 6   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOA_ODR5_Shift, 5   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOA_ODR4_Shift, 4   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOA_ODR3_Shift, 3   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOA_ODR2_Shift, 2   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOA_ODR1_Shift, 1   @ bitWidth 1 (Port output data y =
  0..15)  
        .equ GPIOA_ODR0_Shift, 0   @ bitWidth 1 (Port output data y =
  0..15)  
 
    .equ GPIOA_BSRR, GPIOA_BASE + 0x18 @ (GPIO port bit set/reset
  register) 
        .equ GPIOA_BR15_Shift, 31   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOA_BR14_Shift, 30   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOA_BR13_Shift, 29   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOA_BR12_Shift, 28   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOA_BR11_Shift, 27   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOA_BR10_Shift, 26   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOA_BR9_Shift, 25   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOA_BR8_Shift, 24   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOA_BR7_Shift, 23   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOA_BR6_Shift, 22   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOA_BR5_Shift, 21   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOA_BR4_Shift, 20   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOA_BR3_Shift, 19   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOA_BR2_Shift, 18   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOA_BR1_Shift, 17   @ bitWidth 1 (Port x reset bit y y =
  0..15)  
        .equ GPIOA_BR0_Shift, 16   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOA_BS15_Shift, 15   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOA_BS14_Shift, 14   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOA_BS13_Shift, 13   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOA_BS12_Shift, 12   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOA_BS11_Shift, 11   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOA_BS10_Shift, 10   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOA_BS9_Shift, 9   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOA_BS8_Shift, 8   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOA_BS7_Shift, 7   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOA_BS6_Shift, 6   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOA_BS5_Shift, 5   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOA_BS4_Shift, 4   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOA_BS3_Shift, 3   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOA_BS2_Shift, 2   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOA_BS1_Shift, 1   @ bitWidth 1 (Port x set bit y y=
  0..15)  
        .equ GPIOA_BS0_Shift, 0   @ bitWidth 1 (Port x set bit y y=
  0..15)  
 
    .equ GPIOA_LCKR, GPIOA_BASE + 0x1C @ (GPIO port configuration lock
  register) 
        .equ GPIOA_LCKK_Shift, 16   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOA_LCK15_Shift, 15   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOA_LCK14_Shift, 14   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOA_LCK13_Shift, 13   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOA_LCK12_Shift, 12   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOA_LCK11_Shift, 11   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOA_LCK10_Shift, 10   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOA_LCK9_Shift, 9   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOA_LCK8_Shift, 8   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOA_LCK7_Shift, 7   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOA_LCK6_Shift, 6   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOA_LCK5_Shift, 5   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOA_LCK4_Shift, 4   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOA_LCK3_Shift, 3   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOA_LCK2_Shift, 2   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOA_LCK1_Shift, 1   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
        .equ GPIOA_LCK0_Shift, 0   @ bitWidth 1 (Port x lock bit y y=
  0..15)  
 
    .equ GPIOA_AFRL, GPIOA_BASE + 0x20 @ (GPIO alternate function low
  register) 
        .equ GPIOA_AFRL7_Shift, 28   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOA_AFRL6_Shift, 24   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOA_AFRL5_Shift, 20   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOA_AFRL4_Shift, 16   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOA_AFRL3_Shift, 12   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOA_AFRL2_Shift, 8   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOA_AFRL1_Shift, 4   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
        .equ GPIOA_AFRL0_Shift, 0   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 0..7)  
 
    .equ GPIOA_AFRH, GPIOA_BASE + 0x24 @ (GPIO alternate function high
  register) 
        .equ GPIOA_AFRH15_Shift, 28   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOA_AFRH14_Shift, 24   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOA_AFRH13_Shift, 20   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOA_AFRH12_Shift, 16   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOA_AFRH11_Shift, 12   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOA_AFRH10_Shift, 8   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOA_AFRH9_Shift, 4   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
        .equ GPIOA_AFRH8_Shift, 0   @ bitWidth 4 (Alternate function selection for port x
  bit y y = 8..15)  
 

@=========================== I2C3 ===========================@
.equ I2C3_BASE, 0x40005C00 @ (Inter-integrated circuit) 
    .equ I2C3_CR1, I2C3_BASE + 0x0 @ (Control register 1) 
        .equ I2C3_SWRST_Shift, 15   @ bitWidth 1 (Software reset)  
        .equ I2C3_ALERT_Shift, 13   @ bitWidth 1 (SMBus alert)  
        .equ I2C3_PEC_Shift, 12   @ bitWidth 1 (Packet error checking)  
        .equ I2C3_POS_Shift, 11   @ bitWidth 1 (Acknowledge/PEC Position for data
  reception)  
        .equ I2C3_ACK_Shift, 10   @ bitWidth 1 (Acknowledge enable)  
        .equ I2C3_STOP_Shift, 9   @ bitWidth 1 (Stop generation)  
        .equ I2C3_START_Shift, 8   @ bitWidth 1 (Start generation)  
        .equ I2C3_NOSTRETCH_Shift, 7   @ bitWidth 1 (Clock stretching disable Slave
  mode)  
        .equ I2C3_ENGC_Shift, 6   @ bitWidth 1 (General call enable)  
        .equ I2C3_ENPEC_Shift, 5   @ bitWidth 1 (PEC enable)  
        .equ I2C3_ENARP_Shift, 4   @ bitWidth 1 (ARP enable)  
        .equ I2C3_SMBTYPE_Shift, 3   @ bitWidth 1 (SMBus type)  
        .equ I2C3_SMBUS_Shift, 1   @ bitWidth 1 (SMBus mode)  
        .equ I2C3_PE_Shift, 0   @ bitWidth 1 (Peripheral enable)  
 
    .equ I2C3_CR2, I2C3_BASE + 0x4 @ (Control register 2) 
        .equ I2C3_LAST_Shift, 12   @ bitWidth 1 (DMA last transfer)  
        .equ I2C3_DMAEN_Shift, 11   @ bitWidth 1 (DMA requests enable)  
        .equ I2C3_ITBUFEN_Shift, 10   @ bitWidth 1 (Buffer interrupt enable)  
        .equ I2C3_ITEVTEN_Shift, 9   @ bitWidth 1 (Event interrupt enable)  
        .equ I2C3_ITERREN_Shift, 8   @ bitWidth 1 (Error interrupt enable)  
        .equ I2C3_FREQ_Shift, 0   @ bitWidth 6 (Peripheral clock frequency)  
 
    .equ I2C3_OAR1, I2C3_BASE + 0x8 @ (Own address register 1) 
        .equ I2C3_ADDMODE_Shift, 15   @ bitWidth 1 (Addressing mode slave
  mode)  
        .equ I2C3_ADD10_Shift, 8   @ bitWidth 2 (Interface address)  
        .equ I2C3_ADD7_Shift, 1   @ bitWidth 7 (Interface address)  
        .equ I2C3_ADD0_Shift, 0   @ bitWidth 1 (Interface address)  
 
    .equ I2C3_OAR2, I2C3_BASE + 0xC @ (Own address register 2) 
        .equ I2C3_ADD2_Shift, 1   @ bitWidth 7 (Interface address)  
        .equ I2C3_ENDUAL_Shift, 0   @ bitWidth 1 (Dual addressing mode
  enable)  
 
    .equ I2C3_DR, I2C3_BASE + 0x10 @ (Data register) 
        .equ I2C3_DR_Shift, 0   @ bitWidth 8 (8-bit data register)  
 
    .equ I2C3_SR1, I2C3_BASE + 0x14 @ (Status register 1) 
        .equ I2C3_SMBALERT_Shift, 15   @ bitWidth 1 (SMBus alert)  
        .equ I2C3_TIMEOUT_Shift, 14   @ bitWidth 1 (Timeout or Tlow error)  
        .equ I2C3_PECERR_Shift, 12   @ bitWidth 1 (PEC Error in reception)  
        .equ I2C3_OVR_Shift, 11   @ bitWidth 1 (Overrun/Underrun)  
        .equ I2C3_AF_Shift, 10   @ bitWidth 1 (Acknowledge failure)  
        .equ I2C3_ARLO_Shift, 9   @ bitWidth 1 (Arbitration lost master
  mode)  
        .equ I2C3_BERR_Shift, 8   @ bitWidth 1 (Bus error)  
        .equ I2C3_TxE_Shift, 7   @ bitWidth 1 (Data register empty
  transmitters)  
        .equ I2C3_RxNE_Shift, 6   @ bitWidth 1 (Data register not empty
  receivers)  
        .equ I2C3_STOPF_Shift, 4   @ bitWidth 1 (Stop detection slave
  mode)  
        .equ I2C3_ADD10_Shift, 3   @ bitWidth 1 (10-bit header sent Master
  mode)  
        .equ I2C3_BTF_Shift, 2   @ bitWidth 1 (Byte transfer finished)  
        .equ I2C3_ADDR_Shift, 1   @ bitWidth 1 (Address sent master mode/matched
  slave mode)  
        .equ I2C3_SB_Shift, 0   @ bitWidth 1 (Start bit Master mode)  
 
    .equ I2C3_SR2, I2C3_BASE + 0x18 @ (Status register 2) 
        .equ I2C3_PEC_Shift, 8   @ bitWidth 8 (acket error checking
  register)  
        .equ I2C3_DUALF_Shift, 7   @ bitWidth 1 (Dual flag Slave mode)  
        .equ I2C3_SMBHOST_Shift, 6   @ bitWidth 1 (SMBus host header Slave
  mode)  
        .equ I2C3_SMBDEFAULT_Shift, 5   @ bitWidth 1 (SMBus device default address Slave
  mode)  
        .equ I2C3_GENCALL_Shift, 4   @ bitWidth 1 (General call address Slave
  mode)  
        .equ I2C3_TRA_Shift, 2   @ bitWidth 1 (Transmitter/receiver)  
        .equ I2C3_BUSY_Shift, 1   @ bitWidth 1 (Bus busy)  
        .equ I2C3_MSL_Shift, 0   @ bitWidth 1 (Master/slave)  
 
    .equ I2C3_CCR, I2C3_BASE + 0x1C @ (Clock control register) 
        .equ I2C3_F_S_Shift, 15   @ bitWidth 1 (I2C master mode selection)  
        .equ I2C3_DUTY_Shift, 14   @ bitWidth 1 (Fast mode duty cycle)  
        .equ I2C3_CCR_Shift, 0   @ bitWidth 12 (Clock control register in Fast/Standard
  mode Master mode)  
 
    .equ I2C3_TRISE, I2C3_BASE + 0x20 @ (TRISE register) 
        .equ I2C3_TRISE_Shift, 0   @ bitWidth 6 (Maximum rise time in Fast/Standard mode
  Master mode)  
 

@=========================== I2C2 ===========================@
.equ I2C2_BASE, 0x40005800 @ (Inter-integrated circuit) 
    .equ I2C2_CR1, I2C2_BASE + 0x0 @ (Control register 1) 
        .equ I2C2_SWRST_Shift, 15   @ bitWidth 1 (Software reset)  
        .equ I2C2_ALERT_Shift, 13   @ bitWidth 1 (SMBus alert)  
        .equ I2C2_PEC_Shift, 12   @ bitWidth 1 (Packet error checking)  
        .equ I2C2_POS_Shift, 11   @ bitWidth 1 (Acknowledge/PEC Position for data
  reception)  
        .equ I2C2_ACK_Shift, 10   @ bitWidth 1 (Acknowledge enable)  
        .equ I2C2_STOP_Shift, 9   @ bitWidth 1 (Stop generation)  
        .equ I2C2_START_Shift, 8   @ bitWidth 1 (Start generation)  
        .equ I2C2_NOSTRETCH_Shift, 7   @ bitWidth 1 (Clock stretching disable Slave
  mode)  
        .equ I2C2_ENGC_Shift, 6   @ bitWidth 1 (General call enable)  
        .equ I2C2_ENPEC_Shift, 5   @ bitWidth 1 (PEC enable)  
        .equ I2C2_ENARP_Shift, 4   @ bitWidth 1 (ARP enable)  
        .equ I2C2_SMBTYPE_Shift, 3   @ bitWidth 1 (SMBus type)  
        .equ I2C2_SMBUS_Shift, 1   @ bitWidth 1 (SMBus mode)  
        .equ I2C2_PE_Shift, 0   @ bitWidth 1 (Peripheral enable)  
 
    .equ I2C2_CR2, I2C2_BASE + 0x4 @ (Control register 2) 
        .equ I2C2_LAST_Shift, 12   @ bitWidth 1 (DMA last transfer)  
        .equ I2C2_DMAEN_Shift, 11   @ bitWidth 1 (DMA requests enable)  
        .equ I2C2_ITBUFEN_Shift, 10   @ bitWidth 1 (Buffer interrupt enable)  
        .equ I2C2_ITEVTEN_Shift, 9   @ bitWidth 1 (Event interrupt enable)  
        .equ I2C2_ITERREN_Shift, 8   @ bitWidth 1 (Error interrupt enable)  
        .equ I2C2_FREQ_Shift, 0   @ bitWidth 6 (Peripheral clock frequency)  
 
    .equ I2C2_OAR1, I2C2_BASE + 0x8 @ (Own address register 1) 
        .equ I2C2_ADDMODE_Shift, 15   @ bitWidth 1 (Addressing mode slave
  mode)  
        .equ I2C2_ADD10_Shift, 8   @ bitWidth 2 (Interface address)  
        .equ I2C2_ADD7_Shift, 1   @ bitWidth 7 (Interface address)  
        .equ I2C2_ADD0_Shift, 0   @ bitWidth 1 (Interface address)  
 
    .equ I2C2_OAR2, I2C2_BASE + 0xC @ (Own address register 2) 
        .equ I2C2_ADD2_Shift, 1   @ bitWidth 7 (Interface address)  
        .equ I2C2_ENDUAL_Shift, 0   @ bitWidth 1 (Dual addressing mode
  enable)  
 
    .equ I2C2_DR, I2C2_BASE + 0x10 @ (Data register) 
        .equ I2C2_DR_Shift, 0   @ bitWidth 8 (8-bit data register)  
 
    .equ I2C2_SR1, I2C2_BASE + 0x14 @ (Status register 1) 
        .equ I2C2_SMBALERT_Shift, 15   @ bitWidth 1 (SMBus alert)  
        .equ I2C2_TIMEOUT_Shift, 14   @ bitWidth 1 (Timeout or Tlow error)  
        .equ I2C2_PECERR_Shift, 12   @ bitWidth 1 (PEC Error in reception)  
        .equ I2C2_OVR_Shift, 11   @ bitWidth 1 (Overrun/Underrun)  
        .equ I2C2_AF_Shift, 10   @ bitWidth 1 (Acknowledge failure)  
        .equ I2C2_ARLO_Shift, 9   @ bitWidth 1 (Arbitration lost master
  mode)  
        .equ I2C2_BERR_Shift, 8   @ bitWidth 1 (Bus error)  
        .equ I2C2_TxE_Shift, 7   @ bitWidth 1 (Data register empty
  transmitters)  
        .equ I2C2_RxNE_Shift, 6   @ bitWidth 1 (Data register not empty
  receivers)  
        .equ I2C2_STOPF_Shift, 4   @ bitWidth 1 (Stop detection slave
  mode)  
        .equ I2C2_ADD10_Shift, 3   @ bitWidth 1 (10-bit header sent Master
  mode)  
        .equ I2C2_BTF_Shift, 2   @ bitWidth 1 (Byte transfer finished)  
        .equ I2C2_ADDR_Shift, 1   @ bitWidth 1 (Address sent master mode/matched
  slave mode)  
        .equ I2C2_SB_Shift, 0   @ bitWidth 1 (Start bit Master mode)  
 
    .equ I2C2_SR2, I2C2_BASE + 0x18 @ (Status register 2) 
        .equ I2C2_PEC_Shift, 8   @ bitWidth 8 (acket error checking
  register)  
        .equ I2C2_DUALF_Shift, 7   @ bitWidth 1 (Dual flag Slave mode)  
        .equ I2C2_SMBHOST_Shift, 6   @ bitWidth 1 (SMBus host header Slave
  mode)  
        .equ I2C2_SMBDEFAULT_Shift, 5   @ bitWidth 1 (SMBus device default address Slave
  mode)  
        .equ I2C2_GENCALL_Shift, 4   @ bitWidth 1 (General call address Slave
  mode)  
        .equ I2C2_TRA_Shift, 2   @ bitWidth 1 (Transmitter/receiver)  
        .equ I2C2_BUSY_Shift, 1   @ bitWidth 1 (Bus busy)  
        .equ I2C2_MSL_Shift, 0   @ bitWidth 1 (Master/slave)  
 
    .equ I2C2_CCR, I2C2_BASE + 0x1C @ (Clock control register) 
        .equ I2C2_F_S_Shift, 15   @ bitWidth 1 (I2C master mode selection)  
        .equ I2C2_DUTY_Shift, 14   @ bitWidth 1 (Fast mode duty cycle)  
        .equ I2C2_CCR_Shift, 0   @ bitWidth 12 (Clock control register in Fast/Standard
  mode Master mode)  
 
    .equ I2C2_TRISE, I2C2_BASE + 0x20 @ (TRISE register) 
        .equ I2C2_TRISE_Shift, 0   @ bitWidth 6 (Maximum rise time in Fast/Standard mode
  Master mode)  
 

@=========================== I2C1 ===========================@
.equ I2C1_BASE, 0x40005400 @ (Inter-integrated circuit) 
    .equ I2C1_CR1, I2C1_BASE + 0x0 @ (Control register 1) 
        .equ I2C1_SWRST_Shift, 15   @ bitWidth 1 (Software reset)  
        .equ I2C1_ALERT_Shift, 13   @ bitWidth 1 (SMBus alert)  
        .equ I2C1_PEC_Shift, 12   @ bitWidth 1 (Packet error checking)  
        .equ I2C1_POS_Shift, 11   @ bitWidth 1 (Acknowledge/PEC Position for data
  reception)  
        .equ I2C1_ACK_Shift, 10   @ bitWidth 1 (Acknowledge enable)  
        .equ I2C1_STOP_Shift, 9   @ bitWidth 1 (Stop generation)  
        .equ I2C1_START_Shift, 8   @ bitWidth 1 (Start generation)  
        .equ I2C1_NOSTRETCH_Shift, 7   @ bitWidth 1 (Clock stretching disable Slave
  mode)  
        .equ I2C1_ENGC_Shift, 6   @ bitWidth 1 (General call enable)  
        .equ I2C1_ENPEC_Shift, 5   @ bitWidth 1 (PEC enable)  
        .equ I2C1_ENARP_Shift, 4   @ bitWidth 1 (ARP enable)  
        .equ I2C1_SMBTYPE_Shift, 3   @ bitWidth 1 (SMBus type)  
        .equ I2C1_SMBUS_Shift, 1   @ bitWidth 1 (SMBus mode)  
        .equ I2C1_PE_Shift, 0   @ bitWidth 1 (Peripheral enable)  
 
    .equ I2C1_CR2, I2C1_BASE + 0x4 @ (Control register 2) 
        .equ I2C1_LAST_Shift, 12   @ bitWidth 1 (DMA last transfer)  
        .equ I2C1_DMAEN_Shift, 11   @ bitWidth 1 (DMA requests enable)  
        .equ I2C1_ITBUFEN_Shift, 10   @ bitWidth 1 (Buffer interrupt enable)  
        .equ I2C1_ITEVTEN_Shift, 9   @ bitWidth 1 (Event interrupt enable)  
        .equ I2C1_ITERREN_Shift, 8   @ bitWidth 1 (Error interrupt enable)  
        .equ I2C1_FREQ_Shift, 0   @ bitWidth 6 (Peripheral clock frequency)  
 
    .equ I2C1_OAR1, I2C1_BASE + 0x8 @ (Own address register 1) 
        .equ I2C1_ADDMODE_Shift, 15   @ bitWidth 1 (Addressing mode slave
  mode)  
        .equ I2C1_ADD10_Shift, 8   @ bitWidth 2 (Interface address)  
        .equ I2C1_ADD7_Shift, 1   @ bitWidth 7 (Interface address)  
        .equ I2C1_ADD0_Shift, 0   @ bitWidth 1 (Interface address)  
 
    .equ I2C1_OAR2, I2C1_BASE + 0xC @ (Own address register 2) 
        .equ I2C1_ADD2_Shift, 1   @ bitWidth 7 (Interface address)  
        .equ I2C1_ENDUAL_Shift, 0   @ bitWidth 1 (Dual addressing mode
  enable)  
 
    .equ I2C1_DR, I2C1_BASE + 0x10 @ (Data register) 
        .equ I2C1_DR_Shift, 0   @ bitWidth 8 (8-bit data register)  
 
    .equ I2C1_SR1, I2C1_BASE + 0x14 @ (Status register 1) 
        .equ I2C1_SMBALERT_Shift, 15   @ bitWidth 1 (SMBus alert)  
        .equ I2C1_TIMEOUT_Shift, 14   @ bitWidth 1 (Timeout or Tlow error)  
        .equ I2C1_PECERR_Shift, 12   @ bitWidth 1 (PEC Error in reception)  
        .equ I2C1_OVR_Shift, 11   @ bitWidth 1 (Overrun/Underrun)  
        .equ I2C1_AF_Shift, 10   @ bitWidth 1 (Acknowledge failure)  
        .equ I2C1_ARLO_Shift, 9   @ bitWidth 1 (Arbitration lost master
  mode)  
        .equ I2C1_BERR_Shift, 8   @ bitWidth 1 (Bus error)  
        .equ I2C1_TxE_Shift, 7   @ bitWidth 1 (Data register empty
  transmitters)  
        .equ I2C1_RxNE_Shift, 6   @ bitWidth 1 (Data register not empty
  receivers)  
        .equ I2C1_STOPF_Shift, 4   @ bitWidth 1 (Stop detection slave
  mode)  
        .equ I2C1_ADD10_Shift, 3   @ bitWidth 1 (10-bit header sent Master
  mode)  
        .equ I2C1_BTF_Shift, 2   @ bitWidth 1 (Byte transfer finished)  
        .equ I2C1_ADDR_Shift, 1   @ bitWidth 1 (Address sent master mode/matched
  slave mode)  
        .equ I2C1_SB_Shift, 0   @ bitWidth 1 (Start bit Master mode)  
 
    .equ I2C1_SR2, I2C1_BASE + 0x18 @ (Status register 2) 
        .equ I2C1_PEC_Shift, 8   @ bitWidth 8 (acket error checking
  register)  
        .equ I2C1_DUALF_Shift, 7   @ bitWidth 1 (Dual flag Slave mode)  
        .equ I2C1_SMBHOST_Shift, 6   @ bitWidth 1 (SMBus host header Slave
  mode)  
        .equ I2C1_SMBDEFAULT_Shift, 5   @ bitWidth 1 (SMBus device default address Slave
  mode)  
        .equ I2C1_GENCALL_Shift, 4   @ bitWidth 1 (General call address Slave
  mode)  
        .equ I2C1_TRA_Shift, 2   @ bitWidth 1 (Transmitter/receiver)  
        .equ I2C1_BUSY_Shift, 1   @ bitWidth 1 (Bus busy)  
        .equ I2C1_MSL_Shift, 0   @ bitWidth 1 (Master/slave)  
 
    .equ I2C1_CCR, I2C1_BASE + 0x1C @ (Clock control register) 
        .equ I2C1_F_S_Shift, 15   @ bitWidth 1 (I2C master mode selection)  
        .equ I2C1_DUTY_Shift, 14   @ bitWidth 1 (Fast mode duty cycle)  
        .equ I2C1_CCR_Shift, 0   @ bitWidth 12 (Clock control register in Fast/Standard
  mode Master mode)  
 
    .equ I2C1_TRISE, I2C1_BASE + 0x20 @ (TRISE register) 
        .equ I2C1_TRISE_Shift, 0   @ bitWidth 6 (Maximum rise time in Fast/Standard mode
  Master mode)  
 

@=========================== I2S2ext ===========================@
.equ I2S2ext_BASE, 0x40003400 @ (Serial peripheral interface) 
    .equ I2S2ext_CR1, I2S2ext_BASE + 0x0 @ (control register 1) 
        .equ I2S2ext_BIDIMODE_Shift, 15   @ bitWidth 1 (Bidirectional data mode
  enable)  
        .equ I2S2ext_BIDIOE_Shift, 14   @ bitWidth 1 (Output enable in bidirectional
  mode)  
        .equ I2S2ext_CRCEN_Shift, 13   @ bitWidth 1 (Hardware CRC calculation
  enable)  
        .equ I2S2ext_CRCNEXT_Shift, 12   @ bitWidth 1 (CRC transfer next)  
        .equ I2S2ext_DFF_Shift, 11   @ bitWidth 1 (Data frame format)  
        .equ I2S2ext_RXONLY_Shift, 10   @ bitWidth 1 (Receive only)  
        .equ I2S2ext_SSM_Shift, 9   @ bitWidth 1 (Software slave management)  
        .equ I2S2ext_SSI_Shift, 8   @ bitWidth 1 (Internal slave select)  
        .equ I2S2ext_LSBFIRST_Shift, 7   @ bitWidth 1 (Frame format)  
        .equ I2S2ext_SPE_Shift, 6   @ bitWidth 1 (SPI enable)  
        .equ I2S2ext_BR_Shift, 3   @ bitWidth 3 (Baud rate control)  
        .equ I2S2ext_MSTR_Shift, 2   @ bitWidth 1 (Master selection)  
        .equ I2S2ext_CPOL_Shift, 1   @ bitWidth 1 (Clock polarity)  
        .equ I2S2ext_CPHA_Shift, 0   @ bitWidth 1 (Clock phase)  
 
    .equ I2S2ext_CR2, I2S2ext_BASE + 0x4 @ (control register 2) 
        .equ I2S2ext_TXEIE_Shift, 7   @ bitWidth 1 (Tx buffer empty interrupt
  enable)  
        .equ I2S2ext_RXNEIE_Shift, 6   @ bitWidth 1 (RX buffer not empty interrupt
  enable)  
        .equ I2S2ext_ERRIE_Shift, 5   @ bitWidth 1 (Error interrupt enable)  
        .equ I2S2ext_FRF_Shift, 4   @ bitWidth 1 (Frame format)  
        .equ I2S2ext_SSOE_Shift, 2   @ bitWidth 1 (SS output enable)  
        .equ I2S2ext_TXDMAEN_Shift, 1   @ bitWidth 1 (Tx buffer DMA enable)  
        .equ I2S2ext_RXDMAEN_Shift, 0   @ bitWidth 1 (Rx buffer DMA enable)  
 
    .equ I2S2ext_SR, I2S2ext_BASE + 0x8 @ (status register) 
        .equ I2S2ext_TIFRFE_Shift, 8   @ bitWidth 1 (TI frame format error)  
        .equ I2S2ext_BSY_Shift, 7   @ bitWidth 1 (Busy flag)  
        .equ I2S2ext_OVR_Shift, 6   @ bitWidth 1 (Overrun flag)  
        .equ I2S2ext_MODF_Shift, 5   @ bitWidth 1 (Mode fault)  
        .equ I2S2ext_CRCERR_Shift, 4   @ bitWidth 1 (CRC error flag)  
        .equ I2S2ext_UDR_Shift, 3   @ bitWidth 1 (Underrun flag)  
        .equ I2S2ext_CHSIDE_Shift, 2   @ bitWidth 1 (Channel side)  
        .equ I2S2ext_TXE_Shift, 1   @ bitWidth 1 (Transmit buffer empty)  
        .equ I2S2ext_RXNE_Shift, 0   @ bitWidth 1 (Receive buffer not empty)  
 
    .equ I2S2ext_DR, I2S2ext_BASE + 0xC @ (data register) 
        .equ I2S2ext_DR_Shift, 0   @ bitWidth 16 (Data register)  
 
    .equ I2S2ext_CRCPR, I2S2ext_BASE + 0x10 @ (CRC polynomial register) 
        .equ I2S2ext_CRCPOLY_Shift, 0   @ bitWidth 16 (CRC polynomial register)  
 
    .equ I2S2ext_RXCRCR, I2S2ext_BASE + 0x14 @ (RX CRC register) 
        .equ I2S2ext_RxCRC_Shift, 0   @ bitWidth 16 (Rx CRC register)  
 
    .equ I2S2ext_TXCRCR, I2S2ext_BASE + 0x18 @ (TX CRC register) 
        .equ I2S2ext_TxCRC_Shift, 0   @ bitWidth 16 (Tx CRC register)  
 
    .equ I2S2ext_I2SCFGR, I2S2ext_BASE + 0x1C @ (I2S configuration register) 
        .equ I2S2ext_I2SMOD_Shift, 11   @ bitWidth 1 (I2S mode selection)  
        .equ I2S2ext_I2SE_Shift, 10   @ bitWidth 1 (I2S Enable)  
        .equ I2S2ext_I2SCFG_Shift, 8   @ bitWidth 2 (I2S configuration mode)  
        .equ I2S2ext_PCMSYNC_Shift, 7   @ bitWidth 1 (PCM frame synchronization)  
        .equ I2S2ext_I2SSTD_Shift, 4   @ bitWidth 2 (I2S standard selection)  
        .equ I2S2ext_CKPOL_Shift, 3   @ bitWidth 1 (Steady state clock
  polarity)  
        .equ I2S2ext_DATLEN_Shift, 1   @ bitWidth 2 (Data length to be
  transferred)  
        .equ I2S2ext_CHLEN_Shift, 0   @ bitWidth 1 (Channel length number of bits per audio
  channel)  
 
    .equ I2S2ext_I2SPR, I2S2ext_BASE + 0x20 @ (I2S prescaler register) 
        .equ I2S2ext_MCKOE_Shift, 9   @ bitWidth 1 (Master clock output enable)  
        .equ I2S2ext_ODD_Shift, 8   @ bitWidth 1 (Odd factor for the
  prescaler)  
        .equ I2S2ext_I2SDIV_Shift, 0   @ bitWidth 8 (I2S Linear prescaler)  
 

@=========================== I2S3ext ===========================@
.equ I2S3ext_BASE, 0x40004000 @ (Serial peripheral interface) 
    .equ I2S3ext_CR1, I2S3ext_BASE + 0x0 @ (control register 1) 
        .equ I2S3ext_BIDIMODE_Shift, 15   @ bitWidth 1 (Bidirectional data mode
  enable)  
        .equ I2S3ext_BIDIOE_Shift, 14   @ bitWidth 1 (Output enable in bidirectional
  mode)  
        .equ I2S3ext_CRCEN_Shift, 13   @ bitWidth 1 (Hardware CRC calculation
  enable)  
        .equ I2S3ext_CRCNEXT_Shift, 12   @ bitWidth 1 (CRC transfer next)  
        .equ I2S3ext_DFF_Shift, 11   @ bitWidth 1 (Data frame format)  
        .equ I2S3ext_RXONLY_Shift, 10   @ bitWidth 1 (Receive only)  
        .equ I2S3ext_SSM_Shift, 9   @ bitWidth 1 (Software slave management)  
        .equ I2S3ext_SSI_Shift, 8   @ bitWidth 1 (Internal slave select)  
        .equ I2S3ext_LSBFIRST_Shift, 7   @ bitWidth 1 (Frame format)  
        .equ I2S3ext_SPE_Shift, 6   @ bitWidth 1 (SPI enable)  
        .equ I2S3ext_BR_Shift, 3   @ bitWidth 3 (Baud rate control)  
        .equ I2S3ext_MSTR_Shift, 2   @ bitWidth 1 (Master selection)  
        .equ I2S3ext_CPOL_Shift, 1   @ bitWidth 1 (Clock polarity)  
        .equ I2S3ext_CPHA_Shift, 0   @ bitWidth 1 (Clock phase)  
 
    .equ I2S3ext_CR2, I2S3ext_BASE + 0x4 @ (control register 2) 
        .equ I2S3ext_TXEIE_Shift, 7   @ bitWidth 1 (Tx buffer empty interrupt
  enable)  
        .equ I2S3ext_RXNEIE_Shift, 6   @ bitWidth 1 (RX buffer not empty interrupt
  enable)  
        .equ I2S3ext_ERRIE_Shift, 5   @ bitWidth 1 (Error interrupt enable)  
        .equ I2S3ext_FRF_Shift, 4   @ bitWidth 1 (Frame format)  
        .equ I2S3ext_SSOE_Shift, 2   @ bitWidth 1 (SS output enable)  
        .equ I2S3ext_TXDMAEN_Shift, 1   @ bitWidth 1 (Tx buffer DMA enable)  
        .equ I2S3ext_RXDMAEN_Shift, 0   @ bitWidth 1 (Rx buffer DMA enable)  
 
    .equ I2S3ext_SR, I2S3ext_BASE + 0x8 @ (status register) 
        .equ I2S3ext_TIFRFE_Shift, 8   @ bitWidth 1 (TI frame format error)  
        .equ I2S3ext_BSY_Shift, 7   @ bitWidth 1 (Busy flag)  
        .equ I2S3ext_OVR_Shift, 6   @ bitWidth 1 (Overrun flag)  
        .equ I2S3ext_MODF_Shift, 5   @ bitWidth 1 (Mode fault)  
        .equ I2S3ext_CRCERR_Shift, 4   @ bitWidth 1 (CRC error flag)  
        .equ I2S3ext_UDR_Shift, 3   @ bitWidth 1 (Underrun flag)  
        .equ I2S3ext_CHSIDE_Shift, 2   @ bitWidth 1 (Channel side)  
        .equ I2S3ext_TXE_Shift, 1   @ bitWidth 1 (Transmit buffer empty)  
        .equ I2S3ext_RXNE_Shift, 0   @ bitWidth 1 (Receive buffer not empty)  
 
    .equ I2S3ext_DR, I2S3ext_BASE + 0xC @ (data register) 
        .equ I2S3ext_DR_Shift, 0   @ bitWidth 16 (Data register)  
 
    .equ I2S3ext_CRCPR, I2S3ext_BASE + 0x10 @ (CRC polynomial register) 
        .equ I2S3ext_CRCPOLY_Shift, 0   @ bitWidth 16 (CRC polynomial register)  
 
    .equ I2S3ext_RXCRCR, I2S3ext_BASE + 0x14 @ (RX CRC register) 
        .equ I2S3ext_RxCRC_Shift, 0   @ bitWidth 16 (Rx CRC register)  
 
    .equ I2S3ext_TXCRCR, I2S3ext_BASE + 0x18 @ (TX CRC register) 
        .equ I2S3ext_TxCRC_Shift, 0   @ bitWidth 16 (Tx CRC register)  
 
    .equ I2S3ext_I2SCFGR, I2S3ext_BASE + 0x1C @ (I2S configuration register) 
        .equ I2S3ext_I2SMOD_Shift, 11   @ bitWidth 1 (I2S mode selection)  
        .equ I2S3ext_I2SE_Shift, 10   @ bitWidth 1 (I2S Enable)  
        .equ I2S3ext_I2SCFG_Shift, 8   @ bitWidth 2 (I2S configuration mode)  
        .equ I2S3ext_PCMSYNC_Shift, 7   @ bitWidth 1 (PCM frame synchronization)  
        .equ I2S3ext_I2SSTD_Shift, 4   @ bitWidth 2 (I2S standard selection)  
        .equ I2S3ext_CKPOL_Shift, 3   @ bitWidth 1 (Steady state clock
  polarity)  
        .equ I2S3ext_DATLEN_Shift, 1   @ bitWidth 2 (Data length to be
  transferred)  
        .equ I2S3ext_CHLEN_Shift, 0   @ bitWidth 1 (Channel length number of bits per audio
  channel)  
 
    .equ I2S3ext_I2SPR, I2S3ext_BASE + 0x20 @ (I2S prescaler register) 
        .equ I2S3ext_MCKOE_Shift, 9   @ bitWidth 1 (Master clock output enable)  
        .equ I2S3ext_ODD_Shift, 8   @ bitWidth 1 (Odd factor for the
  prescaler)  
        .equ I2S3ext_I2SDIV_Shift, 0   @ bitWidth 8 (I2S Linear prescaler)  
 

@=========================== SPI1 ===========================@
.equ SPI1_BASE, 0x40013000 @ (Serial peripheral interface) 
    .equ SPI1_CR1, SPI1_BASE + 0x0 @ (control register 1) 
        .equ SPI1_BIDIMODE_Shift, 15   @ bitWidth 1 (Bidirectional data mode
  enable)  
        .equ SPI1_BIDIOE_Shift, 14   @ bitWidth 1 (Output enable in bidirectional
  mode)  
        .equ SPI1_CRCEN_Shift, 13   @ bitWidth 1 (Hardware CRC calculation
  enable)  
        .equ SPI1_CRCNEXT_Shift, 12   @ bitWidth 1 (CRC transfer next)  
        .equ SPI1_DFF_Shift, 11   @ bitWidth 1 (Data frame format)  
        .equ SPI1_RXONLY_Shift, 10   @ bitWidth 1 (Receive only)  
        .equ SPI1_SSM_Shift, 9   @ bitWidth 1 (Software slave management)  
        .equ SPI1_SSI_Shift, 8   @ bitWidth 1 (Internal slave select)  
        .equ SPI1_LSBFIRST_Shift, 7   @ bitWidth 1 (Frame format)  
        .equ SPI1_SPE_Shift, 6   @ bitWidth 1 (SPI enable)  
        .equ SPI1_BR_Shift, 3   @ bitWidth 3 (Baud rate control)  
        .equ SPI1_MSTR_Shift, 2   @ bitWidth 1 (Master selection)  
        .equ SPI1_CPOL_Shift, 1   @ bitWidth 1 (Clock polarity)  
        .equ SPI1_CPHA_Shift, 0   @ bitWidth 1 (Clock phase)  
 
    .equ SPI1_CR2, SPI1_BASE + 0x4 @ (control register 2) 
        .equ SPI1_TXEIE_Shift, 7   @ bitWidth 1 (Tx buffer empty interrupt
  enable)  
        .equ SPI1_RXNEIE_Shift, 6   @ bitWidth 1 (RX buffer not empty interrupt
  enable)  
        .equ SPI1_ERRIE_Shift, 5   @ bitWidth 1 (Error interrupt enable)  
        .equ SPI1_FRF_Shift, 4   @ bitWidth 1 (Frame format)  
        .equ SPI1_SSOE_Shift, 2   @ bitWidth 1 (SS output enable)  
        .equ SPI1_TXDMAEN_Shift, 1   @ bitWidth 1 (Tx buffer DMA enable)  
        .equ SPI1_RXDMAEN_Shift, 0   @ bitWidth 1 (Rx buffer DMA enable)  
 
    .equ SPI1_SR, SPI1_BASE + 0x8 @ (status register) 
        .equ SPI1_TIFRFE_Shift, 8   @ bitWidth 1 (TI frame format error)  
        .equ SPI1_BSY_Shift, 7   @ bitWidth 1 (Busy flag)  
        .equ SPI1_OVR_Shift, 6   @ bitWidth 1 (Overrun flag)  
        .equ SPI1_MODF_Shift, 5   @ bitWidth 1 (Mode fault)  
        .equ SPI1_CRCERR_Shift, 4   @ bitWidth 1 (CRC error flag)  
        .equ SPI1_UDR_Shift, 3   @ bitWidth 1 (Underrun flag)  
        .equ SPI1_CHSIDE_Shift, 2   @ bitWidth 1 (Channel side)  
        .equ SPI1_TXE_Shift, 1   @ bitWidth 1 (Transmit buffer empty)  
        .equ SPI1_RXNE_Shift, 0   @ bitWidth 1 (Receive buffer not empty)  
 
    .equ SPI1_DR, SPI1_BASE + 0xC @ (data register) 
        .equ SPI1_DR_Shift, 0   @ bitWidth 16 (Data register)  
 
    .equ SPI1_CRCPR, SPI1_BASE + 0x10 @ (CRC polynomial register) 
        .equ SPI1_CRCPOLY_Shift, 0   @ bitWidth 16 (CRC polynomial register)  
 
    .equ SPI1_RXCRCR, SPI1_BASE + 0x14 @ (RX CRC register) 
        .equ SPI1_RxCRC_Shift, 0   @ bitWidth 16 (Rx CRC register)  
 
    .equ SPI1_TXCRCR, SPI1_BASE + 0x18 @ (TX CRC register) 
        .equ SPI1_TxCRC_Shift, 0   @ bitWidth 16 (Tx CRC register)  
 
    .equ SPI1_I2SCFGR, SPI1_BASE + 0x1C @ (I2S configuration register) 
        .equ SPI1_I2SMOD_Shift, 11   @ bitWidth 1 (I2S mode selection)  
        .equ SPI1_I2SE_Shift, 10   @ bitWidth 1 (I2S Enable)  
        .equ SPI1_I2SCFG_Shift, 8   @ bitWidth 2 (I2S configuration mode)  
        .equ SPI1_PCMSYNC_Shift, 7   @ bitWidth 1 (PCM frame synchronization)  
        .equ SPI1_I2SSTD_Shift, 4   @ bitWidth 2 (I2S standard selection)  
        .equ SPI1_CKPOL_Shift, 3   @ bitWidth 1 (Steady state clock
  polarity)  
        .equ SPI1_DATLEN_Shift, 1   @ bitWidth 2 (Data length to be
  transferred)  
        .equ SPI1_CHLEN_Shift, 0   @ bitWidth 1 (Channel length number of bits per audio
  channel)  
 
    .equ SPI1_I2SPR, SPI1_BASE + 0x20 @ (I2S prescaler register) 
        .equ SPI1_MCKOE_Shift, 9   @ bitWidth 1 (Master clock output enable)  
        .equ SPI1_ODD_Shift, 8   @ bitWidth 1 (Odd factor for the
  prescaler)  
        .equ SPI1_I2SDIV_Shift, 0   @ bitWidth 8 (I2S Linear prescaler)  
 

@=========================== SPI2 ===========================@
.equ SPI2_BASE, 0x40003800 @ (Serial peripheral interface) 
    .equ SPI2_CR1, SPI2_BASE + 0x0 @ (control register 1) 
        .equ SPI2_BIDIMODE_Shift, 15   @ bitWidth 1 (Bidirectional data mode
  enable)  
        .equ SPI2_BIDIOE_Shift, 14   @ bitWidth 1 (Output enable in bidirectional
  mode)  
        .equ SPI2_CRCEN_Shift, 13   @ bitWidth 1 (Hardware CRC calculation
  enable)  
        .equ SPI2_CRCNEXT_Shift, 12   @ bitWidth 1 (CRC transfer next)  
        .equ SPI2_DFF_Shift, 11   @ bitWidth 1 (Data frame format)  
        .equ SPI2_RXONLY_Shift, 10   @ bitWidth 1 (Receive only)  
        .equ SPI2_SSM_Shift, 9   @ bitWidth 1 (Software slave management)  
        .equ SPI2_SSI_Shift, 8   @ bitWidth 1 (Internal slave select)  
        .equ SPI2_LSBFIRST_Shift, 7   @ bitWidth 1 (Frame format)  
        .equ SPI2_SPE_Shift, 6   @ bitWidth 1 (SPI enable)  
        .equ SPI2_BR_Shift, 3   @ bitWidth 3 (Baud rate control)  
        .equ SPI2_MSTR_Shift, 2   @ bitWidth 1 (Master selection)  
        .equ SPI2_CPOL_Shift, 1   @ bitWidth 1 (Clock polarity)  
        .equ SPI2_CPHA_Shift, 0   @ bitWidth 1 (Clock phase)  
 
    .equ SPI2_CR2, SPI2_BASE + 0x4 @ (control register 2) 
        .equ SPI2_TXEIE_Shift, 7   @ bitWidth 1 (Tx buffer empty interrupt
  enable)  
        .equ SPI2_RXNEIE_Shift, 6   @ bitWidth 1 (RX buffer not empty interrupt
  enable)  
        .equ SPI2_ERRIE_Shift, 5   @ bitWidth 1 (Error interrupt enable)  
        .equ SPI2_FRF_Shift, 4   @ bitWidth 1 (Frame format)  
        .equ SPI2_SSOE_Shift, 2   @ bitWidth 1 (SS output enable)  
        .equ SPI2_TXDMAEN_Shift, 1   @ bitWidth 1 (Tx buffer DMA enable)  
        .equ SPI2_RXDMAEN_Shift, 0   @ bitWidth 1 (Rx buffer DMA enable)  
 
    .equ SPI2_SR, SPI2_BASE + 0x8 @ (status register) 
        .equ SPI2_TIFRFE_Shift, 8   @ bitWidth 1 (TI frame format error)  
        .equ SPI2_BSY_Shift, 7   @ bitWidth 1 (Busy flag)  
        .equ SPI2_OVR_Shift, 6   @ bitWidth 1 (Overrun flag)  
        .equ SPI2_MODF_Shift, 5   @ bitWidth 1 (Mode fault)  
        .equ SPI2_CRCERR_Shift, 4   @ bitWidth 1 (CRC error flag)  
        .equ SPI2_UDR_Shift, 3   @ bitWidth 1 (Underrun flag)  
        .equ SPI2_CHSIDE_Shift, 2   @ bitWidth 1 (Channel side)  
        .equ SPI2_TXE_Shift, 1   @ bitWidth 1 (Transmit buffer empty)  
        .equ SPI2_RXNE_Shift, 0   @ bitWidth 1 (Receive buffer not empty)  
 
    .equ SPI2_DR, SPI2_BASE + 0xC @ (data register) 
        .equ SPI2_DR_Shift, 0   @ bitWidth 16 (Data register)  
 
    .equ SPI2_CRCPR, SPI2_BASE + 0x10 @ (CRC polynomial register) 
        .equ SPI2_CRCPOLY_Shift, 0   @ bitWidth 16 (CRC polynomial register)  
 
    .equ SPI2_RXCRCR, SPI2_BASE + 0x14 @ (RX CRC register) 
        .equ SPI2_RxCRC_Shift, 0   @ bitWidth 16 (Rx CRC register)  
 
    .equ SPI2_TXCRCR, SPI2_BASE + 0x18 @ (TX CRC register) 
        .equ SPI2_TxCRC_Shift, 0   @ bitWidth 16 (Tx CRC register)  
 
    .equ SPI2_I2SCFGR, SPI2_BASE + 0x1C @ (I2S configuration register) 
        .equ SPI2_I2SMOD_Shift, 11   @ bitWidth 1 (I2S mode selection)  
        .equ SPI2_I2SE_Shift, 10   @ bitWidth 1 (I2S Enable)  
        .equ SPI2_I2SCFG_Shift, 8   @ bitWidth 2 (I2S configuration mode)  
        .equ SPI2_PCMSYNC_Shift, 7   @ bitWidth 1 (PCM frame synchronization)  
        .equ SPI2_I2SSTD_Shift, 4   @ bitWidth 2 (I2S standard selection)  
        .equ SPI2_CKPOL_Shift, 3   @ bitWidth 1 (Steady state clock
  polarity)  
        .equ SPI2_DATLEN_Shift, 1   @ bitWidth 2 (Data length to be
  transferred)  
        .equ SPI2_CHLEN_Shift, 0   @ bitWidth 1 (Channel length number of bits per audio
  channel)  
 
    .equ SPI2_I2SPR, SPI2_BASE + 0x20 @ (I2S prescaler register) 
        .equ SPI2_MCKOE_Shift, 9   @ bitWidth 1 (Master clock output enable)  
        .equ SPI2_ODD_Shift, 8   @ bitWidth 1 (Odd factor for the
  prescaler)  
        .equ SPI2_I2SDIV_Shift, 0   @ bitWidth 8 (I2S Linear prescaler)  
 

@=========================== SPI3 ===========================@
.equ SPI3_BASE, 0x40003C00 @ (Serial peripheral interface) 
    .equ SPI3_CR1, SPI3_BASE + 0x0 @ (control register 1) 
        .equ SPI3_BIDIMODE_Shift, 15   @ bitWidth 1 (Bidirectional data mode
  enable)  
        .equ SPI3_BIDIOE_Shift, 14   @ bitWidth 1 (Output enable in bidirectional
  mode)  
        .equ SPI3_CRCEN_Shift, 13   @ bitWidth 1 (Hardware CRC calculation
  enable)  
        .equ SPI3_CRCNEXT_Shift, 12   @ bitWidth 1 (CRC transfer next)  
        .equ SPI3_DFF_Shift, 11   @ bitWidth 1 (Data frame format)  
        .equ SPI3_RXONLY_Shift, 10   @ bitWidth 1 (Receive only)  
        .equ SPI3_SSM_Shift, 9   @ bitWidth 1 (Software slave management)  
        .equ SPI3_SSI_Shift, 8   @ bitWidth 1 (Internal slave select)  
        .equ SPI3_LSBFIRST_Shift, 7   @ bitWidth 1 (Frame format)  
        .equ SPI3_SPE_Shift, 6   @ bitWidth 1 (SPI enable)  
        .equ SPI3_BR_Shift, 3   @ bitWidth 3 (Baud rate control)  
        .equ SPI3_MSTR_Shift, 2   @ bitWidth 1 (Master selection)  
        .equ SPI3_CPOL_Shift, 1   @ bitWidth 1 (Clock polarity)  
        .equ SPI3_CPHA_Shift, 0   @ bitWidth 1 (Clock phase)  
 
    .equ SPI3_CR2, SPI3_BASE + 0x4 @ (control register 2) 
        .equ SPI3_TXEIE_Shift, 7   @ bitWidth 1 (Tx buffer empty interrupt
  enable)  
        .equ SPI3_RXNEIE_Shift, 6   @ bitWidth 1 (RX buffer not empty interrupt
  enable)  
        .equ SPI3_ERRIE_Shift, 5   @ bitWidth 1 (Error interrupt enable)  
        .equ SPI3_FRF_Shift, 4   @ bitWidth 1 (Frame format)  
        .equ SPI3_SSOE_Shift, 2   @ bitWidth 1 (SS output enable)  
        .equ SPI3_TXDMAEN_Shift, 1   @ bitWidth 1 (Tx buffer DMA enable)  
        .equ SPI3_RXDMAEN_Shift, 0   @ bitWidth 1 (Rx buffer DMA enable)  
 
    .equ SPI3_SR, SPI3_BASE + 0x8 @ (status register) 
        .equ SPI3_TIFRFE_Shift, 8   @ bitWidth 1 (TI frame format error)  
        .equ SPI3_BSY_Shift, 7   @ bitWidth 1 (Busy flag)  
        .equ SPI3_OVR_Shift, 6   @ bitWidth 1 (Overrun flag)  
        .equ SPI3_MODF_Shift, 5   @ bitWidth 1 (Mode fault)  
        .equ SPI3_CRCERR_Shift, 4   @ bitWidth 1 (CRC error flag)  
        .equ SPI3_UDR_Shift, 3   @ bitWidth 1 (Underrun flag)  
        .equ SPI3_CHSIDE_Shift, 2   @ bitWidth 1 (Channel side)  
        .equ SPI3_TXE_Shift, 1   @ bitWidth 1 (Transmit buffer empty)  
        .equ SPI3_RXNE_Shift, 0   @ bitWidth 1 (Receive buffer not empty)  
 
    .equ SPI3_DR, SPI3_BASE + 0xC @ (data register) 
        .equ SPI3_DR_Shift, 0   @ bitWidth 16 (Data register)  
 
    .equ SPI3_CRCPR, SPI3_BASE + 0x10 @ (CRC polynomial register) 
        .equ SPI3_CRCPOLY_Shift, 0   @ bitWidth 16 (CRC polynomial register)  
 
    .equ SPI3_RXCRCR, SPI3_BASE + 0x14 @ (RX CRC register) 
        .equ SPI3_RxCRC_Shift, 0   @ bitWidth 16 (Rx CRC register)  
 
    .equ SPI3_TXCRCR, SPI3_BASE + 0x18 @ (TX CRC register) 
        .equ SPI3_TxCRC_Shift, 0   @ bitWidth 16 (Tx CRC register)  
 
    .equ SPI3_I2SCFGR, SPI3_BASE + 0x1C @ (I2S configuration register) 
        .equ SPI3_I2SMOD_Shift, 11   @ bitWidth 1 (I2S mode selection)  
        .equ SPI3_I2SE_Shift, 10   @ bitWidth 1 (I2S Enable)  
        .equ SPI3_I2SCFG_Shift, 8   @ bitWidth 2 (I2S configuration mode)  
        .equ SPI3_PCMSYNC_Shift, 7   @ bitWidth 1 (PCM frame synchronization)  
        .equ SPI3_I2SSTD_Shift, 4   @ bitWidth 2 (I2S standard selection)  
        .equ SPI3_CKPOL_Shift, 3   @ bitWidth 1 (Steady state clock
  polarity)  
        .equ SPI3_DATLEN_Shift, 1   @ bitWidth 2 (Data length to be
  transferred)  
        .equ SPI3_CHLEN_Shift, 0   @ bitWidth 1 (Channel length number of bits per audio
  channel)  
 
    .equ SPI3_I2SPR, SPI3_BASE + 0x20 @ (I2S prescaler register) 
        .equ SPI3_MCKOE_Shift, 9   @ bitWidth 1 (Master clock output enable)  
        .equ SPI3_ODD_Shift, 8   @ bitWidth 1 (Odd factor for the
  prescaler)  
        .equ SPI3_I2SDIV_Shift, 0   @ bitWidth 8 (I2S Linear prescaler)  
 

@=========================== SPI4 ===========================@
.equ SPI4_BASE, 0x40013400 @ (Serial peripheral interface) 
    .equ SPI4_CR1, SPI4_BASE + 0x0 @ (control register 1) 
        .equ SPI4_BIDIMODE_Shift, 15   @ bitWidth 1 (Bidirectional data mode
  enable)  
        .equ SPI4_BIDIOE_Shift, 14   @ bitWidth 1 (Output enable in bidirectional
  mode)  
        .equ SPI4_CRCEN_Shift, 13   @ bitWidth 1 (Hardware CRC calculation
  enable)  
        .equ SPI4_CRCNEXT_Shift, 12   @ bitWidth 1 (CRC transfer next)  
        .equ SPI4_DFF_Shift, 11   @ bitWidth 1 (Data frame format)  
        .equ SPI4_RXONLY_Shift, 10   @ bitWidth 1 (Receive only)  
        .equ SPI4_SSM_Shift, 9   @ bitWidth 1 (Software slave management)  
        .equ SPI4_SSI_Shift, 8   @ bitWidth 1 (Internal slave select)  
        .equ SPI4_LSBFIRST_Shift, 7   @ bitWidth 1 (Frame format)  
        .equ SPI4_SPE_Shift, 6   @ bitWidth 1 (SPI enable)  
        .equ SPI4_BR_Shift, 3   @ bitWidth 3 (Baud rate control)  
        .equ SPI4_MSTR_Shift, 2   @ bitWidth 1 (Master selection)  
        .equ SPI4_CPOL_Shift, 1   @ bitWidth 1 (Clock polarity)  
        .equ SPI4_CPHA_Shift, 0   @ bitWidth 1 (Clock phase)  
 
    .equ SPI4_CR2, SPI4_BASE + 0x4 @ (control register 2) 
        .equ SPI4_TXEIE_Shift, 7   @ bitWidth 1 (Tx buffer empty interrupt
  enable)  
        .equ SPI4_RXNEIE_Shift, 6   @ bitWidth 1 (RX buffer not empty interrupt
  enable)  
        .equ SPI4_ERRIE_Shift, 5   @ bitWidth 1 (Error interrupt enable)  
        .equ SPI4_FRF_Shift, 4   @ bitWidth 1 (Frame format)  
        .equ SPI4_SSOE_Shift, 2   @ bitWidth 1 (SS output enable)  
        .equ SPI4_TXDMAEN_Shift, 1   @ bitWidth 1 (Tx buffer DMA enable)  
        .equ SPI4_RXDMAEN_Shift, 0   @ bitWidth 1 (Rx buffer DMA enable)  
 
    .equ SPI4_SR, SPI4_BASE + 0x8 @ (status register) 
        .equ SPI4_TIFRFE_Shift, 8   @ bitWidth 1 (TI frame format error)  
        .equ SPI4_BSY_Shift, 7   @ bitWidth 1 (Busy flag)  
        .equ SPI4_OVR_Shift, 6   @ bitWidth 1 (Overrun flag)  
        .equ SPI4_MODF_Shift, 5   @ bitWidth 1 (Mode fault)  
        .equ SPI4_CRCERR_Shift, 4   @ bitWidth 1 (CRC error flag)  
        .equ SPI4_UDR_Shift, 3   @ bitWidth 1 (Underrun flag)  
        .equ SPI4_CHSIDE_Shift, 2   @ bitWidth 1 (Channel side)  
        .equ SPI4_TXE_Shift, 1   @ bitWidth 1 (Transmit buffer empty)  
        .equ SPI4_RXNE_Shift, 0   @ bitWidth 1 (Receive buffer not empty)  
 
    .equ SPI4_DR, SPI4_BASE + 0xC @ (data register) 
        .equ SPI4_DR_Shift, 0   @ bitWidth 16 (Data register)  
 
    .equ SPI4_CRCPR, SPI4_BASE + 0x10 @ (CRC polynomial register) 
        .equ SPI4_CRCPOLY_Shift, 0   @ bitWidth 16 (CRC polynomial register)  
 
    .equ SPI4_RXCRCR, SPI4_BASE + 0x14 @ (RX CRC register) 
        .equ SPI4_RxCRC_Shift, 0   @ bitWidth 16 (Rx CRC register)  
 
    .equ SPI4_TXCRCR, SPI4_BASE + 0x18 @ (TX CRC register) 
        .equ SPI4_TxCRC_Shift, 0   @ bitWidth 16 (Tx CRC register)  
 
    .equ SPI4_I2SCFGR, SPI4_BASE + 0x1C @ (I2S configuration register) 
        .equ SPI4_I2SMOD_Shift, 11   @ bitWidth 1 (I2S mode selection)  
        .equ SPI4_I2SE_Shift, 10   @ bitWidth 1 (I2S Enable)  
        .equ SPI4_I2SCFG_Shift, 8   @ bitWidth 2 (I2S configuration mode)  
        .equ SPI4_PCMSYNC_Shift, 7   @ bitWidth 1 (PCM frame synchronization)  
        .equ SPI4_I2SSTD_Shift, 4   @ bitWidth 2 (I2S standard selection)  
        .equ SPI4_CKPOL_Shift, 3   @ bitWidth 1 (Steady state clock
  polarity)  
        .equ SPI4_DATLEN_Shift, 1   @ bitWidth 2 (Data length to be
  transferred)  
        .equ SPI4_CHLEN_Shift, 0   @ bitWidth 1 (Channel length number of bits per audio
  channel)  
 
    .equ SPI4_I2SPR, SPI4_BASE + 0x20 @ (I2S prescaler register) 
        .equ SPI4_MCKOE_Shift, 9   @ bitWidth 1 (Master clock output enable)  
        .equ SPI4_ODD_Shift, 8   @ bitWidth 1 (Odd factor for the
  prescaler)  
        .equ SPI4_I2SDIV_Shift, 0   @ bitWidth 8 (I2S Linear prescaler)  
 

@=========================== SPI5 ===========================@
.equ SPI5_BASE, 0x40015000 @ (Serial peripheral interface) 
    .equ SPI5_CR1, SPI5_BASE + 0x0 @ (control register 1) 
        .equ SPI5_BIDIMODE_Shift, 15   @ bitWidth 1 (Bidirectional data mode
  enable)  
        .equ SPI5_BIDIOE_Shift, 14   @ bitWidth 1 (Output enable in bidirectional
  mode)  
        .equ SPI5_CRCEN_Shift, 13   @ bitWidth 1 (Hardware CRC calculation
  enable)  
        .equ SPI5_CRCNEXT_Shift, 12   @ bitWidth 1 (CRC transfer next)  
        .equ SPI5_DFF_Shift, 11   @ bitWidth 1 (Data frame format)  
        .equ SPI5_RXONLY_Shift, 10   @ bitWidth 1 (Receive only)  
        .equ SPI5_SSM_Shift, 9   @ bitWidth 1 (Software slave management)  
        .equ SPI5_SSI_Shift, 8   @ bitWidth 1 (Internal slave select)  
        .equ SPI5_LSBFIRST_Shift, 7   @ bitWidth 1 (Frame format)  
        .equ SPI5_SPE_Shift, 6   @ bitWidth 1 (SPI enable)  
        .equ SPI5_BR_Shift, 3   @ bitWidth 3 (Baud rate control)  
        .equ SPI5_MSTR_Shift, 2   @ bitWidth 1 (Master selection)  
        .equ SPI5_CPOL_Shift, 1   @ bitWidth 1 (Clock polarity)  
        .equ SPI5_CPHA_Shift, 0   @ bitWidth 1 (Clock phase)  
 
    .equ SPI5_CR2, SPI5_BASE + 0x4 @ (control register 2) 
        .equ SPI5_TXEIE_Shift, 7   @ bitWidth 1 (Tx buffer empty interrupt
  enable)  
        .equ SPI5_RXNEIE_Shift, 6   @ bitWidth 1 (RX buffer not empty interrupt
  enable)  
        .equ SPI5_ERRIE_Shift, 5   @ bitWidth 1 (Error interrupt enable)  
        .equ SPI5_FRF_Shift, 4   @ bitWidth 1 (Frame format)  
        .equ SPI5_SSOE_Shift, 2   @ bitWidth 1 (SS output enable)  
        .equ SPI5_TXDMAEN_Shift, 1   @ bitWidth 1 (Tx buffer DMA enable)  
        .equ SPI5_RXDMAEN_Shift, 0   @ bitWidth 1 (Rx buffer DMA enable)  
 
    .equ SPI5_SR, SPI5_BASE + 0x8 @ (status register) 
        .equ SPI5_TIFRFE_Shift, 8   @ bitWidth 1 (TI frame format error)  
        .equ SPI5_BSY_Shift, 7   @ bitWidth 1 (Busy flag)  
        .equ SPI5_OVR_Shift, 6   @ bitWidth 1 (Overrun flag)  
        .equ SPI5_MODF_Shift, 5   @ bitWidth 1 (Mode fault)  
        .equ SPI5_CRCERR_Shift, 4   @ bitWidth 1 (CRC error flag)  
        .equ SPI5_UDR_Shift, 3   @ bitWidth 1 (Underrun flag)  
        .equ SPI5_CHSIDE_Shift, 2   @ bitWidth 1 (Channel side)  
        .equ SPI5_TXE_Shift, 1   @ bitWidth 1 (Transmit buffer empty)  
        .equ SPI5_RXNE_Shift, 0   @ bitWidth 1 (Receive buffer not empty)  
 
    .equ SPI5_DR, SPI5_BASE + 0xC @ (data register) 
        .equ SPI5_DR_Shift, 0   @ bitWidth 16 (Data register)  
 
    .equ SPI5_CRCPR, SPI5_BASE + 0x10 @ (CRC polynomial register) 
        .equ SPI5_CRCPOLY_Shift, 0   @ bitWidth 16 (CRC polynomial register)  
 
    .equ SPI5_RXCRCR, SPI5_BASE + 0x14 @ (RX CRC register) 
        .equ SPI5_RxCRC_Shift, 0   @ bitWidth 16 (Rx CRC register)  
 
    .equ SPI5_TXCRCR, SPI5_BASE + 0x18 @ (TX CRC register) 
        .equ SPI5_TxCRC_Shift, 0   @ bitWidth 16 (Tx CRC register)  
 
    .equ SPI5_I2SCFGR, SPI5_BASE + 0x1C @ (I2S configuration register) 
        .equ SPI5_I2SMOD_Shift, 11   @ bitWidth 1 (I2S mode selection)  
        .equ SPI5_I2SE_Shift, 10   @ bitWidth 1 (I2S Enable)  
        .equ SPI5_I2SCFG_Shift, 8   @ bitWidth 2 (I2S configuration mode)  
        .equ SPI5_PCMSYNC_Shift, 7   @ bitWidth 1 (PCM frame synchronization)  
        .equ SPI5_I2SSTD_Shift, 4   @ bitWidth 2 (I2S standard selection)  
        .equ SPI5_CKPOL_Shift, 3   @ bitWidth 1 (Steady state clock
  polarity)  
        .equ SPI5_DATLEN_Shift, 1   @ bitWidth 2 (Data length to be
  transferred)  
        .equ SPI5_CHLEN_Shift, 0   @ bitWidth 1 (Channel length number of bits per audio
  channel)  
 
    .equ SPI5_I2SPR, SPI5_BASE + 0x20 @ (I2S prescaler register) 
        .equ SPI5_MCKOE_Shift, 9   @ bitWidth 1 (Master clock output enable)  
        .equ SPI5_ODD_Shift, 8   @ bitWidth 1 (Odd factor for the
  prescaler)  
        .equ SPI5_I2SDIV_Shift, 0   @ bitWidth 8 (I2S Linear prescaler)  
 

@=========================== NVIC ===========================@
.equ NVIC_BASE, 0xE000E100 @ (Nested Vectored Interrupt
  Controller) 
    .equ NVIC_ISER0, NVIC_BASE + 0x0 @ (Interrupt Set-Enable Register) 
        .equ NVIC_SETENA_Shift, 0   @ bitWidth 32 (SETENA)  
 
    .equ NVIC_ISER1, NVIC_BASE + 0x4 @ (Interrupt Set-Enable Register) 
        .equ NVIC_SETENA_Shift, 0   @ bitWidth 32 (SETENA)  
 
    .equ NVIC_ISER2, NVIC_BASE + 0x8 @ (Interrupt Set-Enable Register) 
        .equ NVIC_SETENA_Shift, 0   @ bitWidth 32 (SETENA)  
 
    .equ NVIC_ICER0, NVIC_BASE + 0x80 @ (Interrupt Clear-Enable
  Register) 
        .equ NVIC_CLRENA_Shift, 0   @ bitWidth 32 (CLRENA)  
 
    .equ NVIC_ICER1, NVIC_BASE + 0x84 @ (Interrupt Clear-Enable
  Register) 
        .equ NVIC_CLRENA_Shift, 0   @ bitWidth 32 (CLRENA)  
 
    .equ NVIC_ICER2, NVIC_BASE + 0x88 @ (Interrupt Clear-Enable
  Register) 
        .equ NVIC_CLRENA_Shift, 0   @ bitWidth 32 (CLRENA)  
 
    .equ NVIC_ISPR0, NVIC_BASE + 0x100 @ (Interrupt Set-Pending Register) 
        .equ NVIC_SETPEND_Shift, 0   @ bitWidth 32 (SETPEND)  
 
    .equ NVIC_ISPR1, NVIC_BASE + 0x104 @ (Interrupt Set-Pending Register) 
        .equ NVIC_SETPEND_Shift, 0   @ bitWidth 32 (SETPEND)  
 
    .equ NVIC_ISPR2, NVIC_BASE + 0x108 @ (Interrupt Set-Pending Register) 
        .equ NVIC_SETPEND_Shift, 0   @ bitWidth 32 (SETPEND)  
 
    .equ NVIC_ICPR0, NVIC_BASE + 0x180 @ (Interrupt Clear-Pending
  Register) 
        .equ NVIC_CLRPEND_Shift, 0   @ bitWidth 32 (CLRPEND)  
 
    .equ NVIC_ICPR1, NVIC_BASE + 0x184 @ (Interrupt Clear-Pending
  Register) 
        .equ NVIC_CLRPEND_Shift, 0   @ bitWidth 32 (CLRPEND)  
 
    .equ NVIC_ICPR2, NVIC_BASE + 0x188 @ (Interrupt Clear-Pending
  Register) 
        .equ NVIC_CLRPEND_Shift, 0   @ bitWidth 32 (CLRPEND)  
 
    .equ NVIC_IABR0, NVIC_BASE + 0x200 @ (Interrupt Active Bit Register) 
        .equ NVIC_ACTIVE_Shift, 0   @ bitWidth 32 (ACTIVE)  
 
    .equ NVIC_IABR1, NVIC_BASE + 0x204 @ (Interrupt Active Bit Register) 
        .equ NVIC_ACTIVE_Shift, 0   @ bitWidth 32 (ACTIVE)  
 
    .equ NVIC_IABR2, NVIC_BASE + 0x208 @ (Interrupt Active Bit Register) 
        .equ NVIC_ACTIVE_Shift, 0   @ bitWidth 32 (ACTIVE)  
 
    .equ NVIC_IPR0, NVIC_BASE + 0x300 @ (Interrupt Priority Register) 
        .equ NVIC_IPR_N0_Shift, 0   @ bitWidth 8 (IPR_N0)  
        .equ NVIC_IPR_N1_Shift, 8   @ bitWidth 8 (IPR_N1)  
        .equ NVIC_IPR_N2_Shift, 16   @ bitWidth 8 (IPR_N2)  
        .equ NVIC_IPR_N3_Shift, 24   @ bitWidth 8 (IPR_N3)  
 
    .equ NVIC_IPR1, NVIC_BASE + 0x304 @ (Interrupt Priority Register) 
        .equ NVIC_IPR_N0_Shift, 0   @ bitWidth 8 (IPR_N0)  
        .equ NVIC_IPR_N1_Shift, 8   @ bitWidth 8 (IPR_N1)  
        .equ NVIC_IPR_N2_Shift, 16   @ bitWidth 8 (IPR_N2)  
        .equ NVIC_IPR_N3_Shift, 24   @ bitWidth 8 (IPR_N3)  
 
    .equ NVIC_IPR2, NVIC_BASE + 0x308 @ (Interrupt Priority Register) 
        .equ NVIC_IPR_N0_Shift, 0   @ bitWidth 8 (IPR_N0)  
        .equ NVIC_IPR_N1_Shift, 8   @ bitWidth 8 (IPR_N1)  
        .equ NVIC_IPR_N2_Shift, 16   @ bitWidth 8 (IPR_N2)  
        .equ NVIC_IPR_N3_Shift, 24   @ bitWidth 8 (IPR_N3)  
 
    .equ NVIC_IPR3, NVIC_BASE + 0x30C @ (Interrupt Priority Register) 
        .equ NVIC_IPR_N0_Shift, 0   @ bitWidth 8 (IPR_N0)  
        .equ NVIC_IPR_N1_Shift, 8   @ bitWidth 8 (IPR_N1)  
        .equ NVIC_IPR_N2_Shift, 16   @ bitWidth 8 (IPR_N2)  
        .equ NVIC_IPR_N3_Shift, 24   @ bitWidth 8 (IPR_N3)  
 
    .equ NVIC_IPR4, NVIC_BASE + 0x310 @ (Interrupt Priority Register) 
        .equ NVIC_IPR_N0_Shift, 0   @ bitWidth 8 (IPR_N0)  
        .equ NVIC_IPR_N1_Shift, 8   @ bitWidth 8 (IPR_N1)  
        .equ NVIC_IPR_N2_Shift, 16   @ bitWidth 8 (IPR_N2)  
        .equ NVIC_IPR_N3_Shift, 24   @ bitWidth 8 (IPR_N3)  
 
    .equ NVIC_IPR5, NVIC_BASE + 0x314 @ (Interrupt Priority Register) 
        .equ NVIC_IPR_N0_Shift, 0   @ bitWidth 8 (IPR_N0)  
        .equ NVIC_IPR_N1_Shift, 8   @ bitWidth 8 (IPR_N1)  
        .equ NVIC_IPR_N2_Shift, 16   @ bitWidth 8 (IPR_N2)  
        .equ NVIC_IPR_N3_Shift, 24   @ bitWidth 8 (IPR_N3)  
 
    .equ NVIC_IPR6, NVIC_BASE + 0x318 @ (Interrupt Priority Register) 
        .equ NVIC_IPR_N0_Shift, 0   @ bitWidth 8 (IPR_N0)  
        .equ NVIC_IPR_N1_Shift, 8   @ bitWidth 8 (IPR_N1)  
        .equ NVIC_IPR_N2_Shift, 16   @ bitWidth 8 (IPR_N2)  
        .equ NVIC_IPR_N3_Shift, 24   @ bitWidth 8 (IPR_N3)  
 
    .equ NVIC_IPR7, NVIC_BASE + 0x31C @ (Interrupt Priority Register) 
        .equ NVIC_IPR_N0_Shift, 0   @ bitWidth 8 (IPR_N0)  
        .equ NVIC_IPR_N1_Shift, 8   @ bitWidth 8 (IPR_N1)  
        .equ NVIC_IPR_N2_Shift, 16   @ bitWidth 8 (IPR_N2)  
        .equ NVIC_IPR_N3_Shift, 24   @ bitWidth 8 (IPR_N3)  
 
    .equ NVIC_IPR8, NVIC_BASE + 0x320 @ (Interrupt Priority Register) 
        .equ NVIC_IPR_N0_Shift, 0   @ bitWidth 8 (IPR_N0)  
        .equ NVIC_IPR_N1_Shift, 8   @ bitWidth 8 (IPR_N1)  
        .equ NVIC_IPR_N2_Shift, 16   @ bitWidth 8 (IPR_N2)  
        .equ NVIC_IPR_N3_Shift, 24   @ bitWidth 8 (IPR_N3)  
 
    .equ NVIC_IPR9, NVIC_BASE + 0x324 @ (Interrupt Priority Register) 
        .equ NVIC_IPR_N0_Shift, 0   @ bitWidth 8 (IPR_N0)  
        .equ NVIC_IPR_N1_Shift, 8   @ bitWidth 8 (IPR_N1)  
        .equ NVIC_IPR_N2_Shift, 16   @ bitWidth 8 (IPR_N2)  
        .equ NVIC_IPR_N3_Shift, 24   @ bitWidth 8 (IPR_N3)  
 
    .equ NVIC_IPR10, NVIC_BASE + 0x328 @ (Interrupt Priority Register) 
        .equ NVIC_IPR_N0_Shift, 0   @ bitWidth 8 (IPR_N0)  
        .equ NVIC_IPR_N1_Shift, 8   @ bitWidth 8 (IPR_N1)  
        .equ NVIC_IPR_N2_Shift, 16   @ bitWidth 8 (IPR_N2)  
        .equ NVIC_IPR_N3_Shift, 24   @ bitWidth 8 (IPR_N3)  
 
    .equ NVIC_IPR11, NVIC_BASE + 0x32C @ (Interrupt Priority Register) 
        .equ NVIC_IPR_N0_Shift, 0   @ bitWidth 8 (IPR_N0)  
        .equ NVIC_IPR_N1_Shift, 8   @ bitWidth 8 (IPR_N1)  
        .equ NVIC_IPR_N2_Shift, 16   @ bitWidth 8 (IPR_N2)  
        .equ NVIC_IPR_N3_Shift, 24   @ bitWidth 8 (IPR_N3)  
 
    .equ NVIC_IPR12, NVIC_BASE + 0x330 @ (Interrupt Priority Register) 
        .equ NVIC_IPR_N0_Shift, 0   @ bitWidth 8 (IPR_N0)  
        .equ NVIC_IPR_N1_Shift, 8   @ bitWidth 8 (IPR_N1)  
        .equ NVIC_IPR_N2_Shift, 16   @ bitWidth 8 (IPR_N2)  
        .equ NVIC_IPR_N3_Shift, 24   @ bitWidth 8 (IPR_N3)  
 
    .equ NVIC_IPR13, NVIC_BASE + 0x334 @ (Interrupt Priority Register) 
        .equ NVIC_IPR_N0_Shift, 0   @ bitWidth 8 (IPR_N0)  
        .equ NVIC_IPR_N1_Shift, 8   @ bitWidth 8 (IPR_N1)  
        .equ NVIC_IPR_N2_Shift, 16   @ bitWidth 8 (IPR_N2)  
        .equ NVIC_IPR_N3_Shift, 24   @ bitWidth 8 (IPR_N3)  
 
    .equ NVIC_IPR14, NVIC_BASE + 0x338 @ (Interrupt Priority Register) 
        .equ NVIC_IPR_N0_Shift, 0   @ bitWidth 8 (IPR_N0)  
        .equ NVIC_IPR_N1_Shift, 8   @ bitWidth 8 (IPR_N1)  
        .equ NVIC_IPR_N2_Shift, 16   @ bitWidth 8 (IPR_N2)  
        .equ NVIC_IPR_N3_Shift, 24   @ bitWidth 8 (IPR_N3)  
 
    .equ NVIC_IPR15, NVIC_BASE + 0x33C @ (Interrupt Priority Register) 
        .equ NVIC_IPR_N0_Shift, 0   @ bitWidth 8 (IPR_N0)  
        .equ NVIC_IPR_N1_Shift, 8   @ bitWidth 8 (IPR_N1)  
        .equ NVIC_IPR_N2_Shift, 16   @ bitWidth 8 (IPR_N2)  
        .equ NVIC_IPR_N3_Shift, 24   @ bitWidth 8 (IPR_N3)  
 
    .equ NVIC_IPR16, NVIC_BASE + 0x340 @ (Interrupt Priority Register) 
        .equ NVIC_IPR_N0_Shift, 0   @ bitWidth 8 (IPR_N0)  
        .equ NVIC_IPR_N1_Shift, 8   @ bitWidth 8 (IPR_N1)  
        .equ NVIC_IPR_N2_Shift, 16   @ bitWidth 8 (IPR_N2)  
        .equ NVIC_IPR_N3_Shift, 24   @ bitWidth 8 (IPR_N3)  
 
    .equ NVIC_IPR17, NVIC_BASE + 0x344 @ (Interrupt Priority Register) 
        .equ NVIC_IPR_N0_Shift, 0   @ bitWidth 8 (IPR_N0)  
        .equ NVIC_IPR_N1_Shift, 8   @ bitWidth 8 (IPR_N1)  
        .equ NVIC_IPR_N2_Shift, 16   @ bitWidth 8 (IPR_N2)  
        .equ NVIC_IPR_N3_Shift, 24   @ bitWidth 8 (IPR_N3)  
 
    .equ NVIC_IPR18, NVIC_BASE + 0x348 @ (Interrupt Priority Register) 
        .equ NVIC_IPR_N0_Shift, 0   @ bitWidth 8 (IPR_N0)  
        .equ NVIC_IPR_N1_Shift, 8   @ bitWidth 8 (IPR_N1)  
        .equ NVIC_IPR_N2_Shift, 16   @ bitWidth 8 (IPR_N2)  
        .equ NVIC_IPR_N3_Shift, 24   @ bitWidth 8 (IPR_N3)  
 
    .equ NVIC_IPR19, NVIC_BASE + 0x34C @ (Interrupt Priority Register) 
        .equ NVIC_IPR_N0_Shift, 0   @ bitWidth 8 (IPR_N0)  
        .equ NVIC_IPR_N1_Shift, 8   @ bitWidth 8 (IPR_N1)  
        .equ NVIC_IPR_N2_Shift, 16   @ bitWidth 8 (IPR_N2)  
        .equ NVIC_IPR_N3_Shift, 24   @ bitWidth 8 (IPR_N3)  
 

@=========================== FPU ===========================@
.equ FPU_BASE, 0xE000EF34 @ (Floting point unit) 
    .equ FPU_FPCCR, FPU_BASE + 0x0 @ (Floating-point context control
  register) 
        .equ FPU_LSPACT_Shift, 0   @ bitWidth 1 (LSPACT)  
        .equ FPU_USER_Shift, 1   @ bitWidth 1 (USER)  
        .equ FPU_THREAD_Shift, 3   @ bitWidth 1 (THREAD)  
        .equ FPU_HFRDY_Shift, 4   @ bitWidth 1 (HFRDY)  
        .equ FPU_MMRDY_Shift, 5   @ bitWidth 1 (MMRDY)  
        .equ FPU_BFRDY_Shift, 6   @ bitWidth 1 (BFRDY)  
        .equ FPU_MONRDY_Shift, 8   @ bitWidth 1 (MONRDY)  
        .equ FPU_LSPEN_Shift, 30   @ bitWidth 1 (LSPEN)  
        .equ FPU_ASPEN_Shift, 31   @ bitWidth 1 (ASPEN)  
 
    .equ FPU_FPCAR, FPU_BASE + 0x4 @ (Floating-point context address
  register) 
        .equ FPU_ADDRESS_Shift, 3   @ bitWidth 29 (Location of unpopulated
  floating-point)  
 
    .equ FPU_FPSCR, FPU_BASE + 0x8 @ (Floating-point status control
  register) 
        .equ FPU_IOC_Shift, 0   @ bitWidth 1 (Invalid operation cumulative exception
  bit)  
        .equ FPU_DZC_Shift, 1   @ bitWidth 1 (Division by zero cumulative exception
  bit.)  
        .equ FPU_OFC_Shift, 2   @ bitWidth 1 (Overflow cumulative exception
  bit)  
        .equ FPU_UFC_Shift, 3   @ bitWidth 1 (Underflow cumulative exception
  bit)  
        .equ FPU_IXC_Shift, 4   @ bitWidth 1 (Inexact cumulative exception
  bit)  
        .equ FPU_IDC_Shift, 7   @ bitWidth 1 (Input denormal cumulative exception
  bit.)  
        .equ FPU_RMode_Shift, 22   @ bitWidth 2 (Rounding Mode control
  field)  
        .equ FPU_FZ_Shift, 24   @ bitWidth 1 (Flush-to-zero mode control
  bit:)  
        .equ FPU_DN_Shift, 25   @ bitWidth 1 (Default NaN mode control
  bit)  
        .equ FPU_AHP_Shift, 26   @ bitWidth 1 (Alternative half-precision control
  bit)  
        .equ FPU_V_Shift, 28   @ bitWidth 1 (Overflow condition code
  flag)  
        .equ FPU_C_Shift, 29   @ bitWidth 1 (Carry condition code flag)  
        .equ FPU_Z_Shift, 30   @ bitWidth 1 (Zero condition code flag)  
        .equ FPU_N_Shift, 31   @ bitWidth 1 (Negative condition code
  flag)  
 

@=========================== MPU ===========================@
.equ MPU_BASE, 0xE000ED90 @ (Memory protection unit) 
    .equ MPU_MPU_TYPER, MPU_BASE + 0x0 @ (MPU type register) 
        .equ MPU_SEPARATE_Shift, 0   @ bitWidth 1 (Separate flag)  
        .equ MPU_DREGION_Shift, 8   @ bitWidth 8 (Number of MPU data regions)  
        .equ MPU_IREGION_Shift, 16   @ bitWidth 8 (Number of MPU instruction
  regions)  
 
    .equ MPU_MPU_CTRL, MPU_BASE + 0x4 @ (MPU control register) 
        .equ MPU_ENABLE_Shift, 0   @ bitWidth 1 (Enables the MPU)  
        .equ MPU_HFNMIENA_Shift, 1   @ bitWidth 1 (Enables the operation of MPU during hard
  fault)  
        .equ MPU_PRIVDEFENA_Shift, 2   @ bitWidth 1 (Enable priviliged software access to
  default memory map)  
 
    .equ MPU_MPU_RNR, MPU_BASE + 0x8 @ (MPU region number register) 
        .equ MPU_REGION_Shift, 0   @ bitWidth 8 (MPU region)  
 
    .equ MPU_MPU_RBAR, MPU_BASE + 0xC @ (MPU region base address
  register) 
        .equ MPU_REGION_Shift, 0   @ bitWidth 4 (MPU region field)  
        .equ MPU_VALID_Shift, 4   @ bitWidth 1 (MPU region number valid)  
        .equ MPU_ADDR_Shift, 5   @ bitWidth 27 (Region base address field)  
 
    .equ MPU_MPU_RASR, MPU_BASE + 0x10 @ (MPU region attribute and size
  register) 
        .equ MPU_ENABLE_Shift, 0   @ bitWidth 1 (Region enable bit.)  
        .equ MPU_SIZE_Shift, 1   @ bitWidth 5 (Size of the MPU protection
  region)  
        .equ MPU_SRD_Shift, 8   @ bitWidth 8 (Subregion disable bits)  
        .equ MPU_B_Shift, 16   @ bitWidth 1 (memory attribute)  
        .equ MPU_C_Shift, 17   @ bitWidth 1 (memory attribute)  
        .equ MPU_S_Shift, 18   @ bitWidth 1 (Shareable memory attribute)  
        .equ MPU_TEX_Shift, 19   @ bitWidth 3 (memory attribute)  
        .equ MPU_AP_Shift, 24   @ bitWidth 3 (Access permission)  
        .equ MPU_XN_Shift, 28   @ bitWidth 1 (Instruction access disable
  bit)  
 

@=========================== STK ===========================@
.equ STK_BASE, 0xE000E010 @ (SysTick timer) 
    .equ STK_CTRL, STK_BASE + 0x0 @ (SysTick control and status
  register) 
        .equ STK_ENABLE_Shift, 0   @ bitWidth 1 (Counter enable)  
        .equ STK_TICKINT_Shift, 1   @ bitWidth 1 (SysTick exception request
  enable)  
        .equ STK_CLKSOURCE_Shift, 2   @ bitWidth 1 (Clock source selection)  
        .equ STK_COUNTFLAG_Shift, 16   @ bitWidth 1 (COUNTFLAG)  
 
    .equ STK_LOAD, STK_BASE + 0x4 @ (SysTick reload value register) 
        .equ STK_RELOAD_Shift, 0   @ bitWidth 24 (RELOAD value)  
 
    .equ STK_VAL, STK_BASE + 0x8 @ (SysTick current value register) 
        .equ STK_CURRENT_Shift, 0   @ bitWidth 24 (Current counter value)  
 
    .equ STK_CALIB, STK_BASE + 0xC @ (SysTick calibration value
  register) 
        .equ STK_TENMS_Shift, 0   @ bitWidth 24 (Calibration value)  
        .equ STK_SKEW_Shift, 30   @ bitWidth 1 (SKEW flag: Indicates whether the TENMS
  value is exact)  
        .equ STK_NOREF_Shift, 31   @ bitWidth 1 (NOREF flag. Reads as zero)  
 

@=========================== SCB ===========================@
.equ SCB_BASE, 0xE000ED00 @ (System control block) 
    .equ SCB_CPUID, SCB_BASE + 0x0 @ (CPUID base register) 
        .equ SCB_Revision_Shift, 0   @ bitWidth 4 (Revision number)  
        .equ SCB_PartNo_Shift, 4   @ bitWidth 12 (Part number of the
  processor)  
        .equ SCB_Constant_Shift, 16   @ bitWidth 4 (Reads as 0xF)  
        .equ SCB_Variant_Shift, 20   @ bitWidth 4 (Variant number)  
        .equ SCB_Implementer_Shift, 24   @ bitWidth 8 (Implementer code)  
 
    .equ SCB_ICSR, SCB_BASE + 0x4 @ (Interrupt control and state
  register) 
        .equ SCB_VECTACTIVE_Shift, 0   @ bitWidth 9 (Active vector)  
        .equ SCB_RETTOBASE_Shift, 11   @ bitWidth 1 (Return to base level)  
        .equ SCB_VECTPENDING_Shift, 12   @ bitWidth 7 (Pending vector)  
        .equ SCB_ISRPENDING_Shift, 22   @ bitWidth 1 (Interrupt pending flag)  
        .equ SCB_PENDSTCLR_Shift, 25   @ bitWidth 1 (SysTick exception clear-pending
  bit)  
        .equ SCB_PENDSTSET_Shift, 26   @ bitWidth 1 (SysTick exception set-pending
  bit)  
        .equ SCB_PENDSVCLR_Shift, 27   @ bitWidth 1 (PendSV clear-pending bit)  
        .equ SCB_PENDSVSET_Shift, 28   @ bitWidth 1 (PendSV set-pending bit)  
        .equ SCB_NMIPENDSET_Shift, 31   @ bitWidth 1 (NMI set-pending bit.)  
 
    .equ SCB_VTOR, SCB_BASE + 0x8 @ (Vector table offset register) 
        .equ SCB_TBLOFF_Shift, 9   @ bitWidth 21 (Vector table base offset
  field)  
 
    .equ SCB_AIRCR, SCB_BASE + 0xC @ (Application interrupt and reset control
  register) 
        .equ SCB_VECTRESET_Shift, 0   @ bitWidth 1 (VECTRESET)  
        .equ SCB_VECTCLRACTIVE_Shift, 1   @ bitWidth 1 (VECTCLRACTIVE)  
        .equ SCB_SYSRESETREQ_Shift, 2   @ bitWidth 1 (SYSRESETREQ)  
        .equ SCB_PRIGROUP_Shift, 8   @ bitWidth 3 (PRIGROUP)  
        .equ SCB_ENDIANESS_Shift, 15   @ bitWidth 1 (ENDIANESS)  
        .equ SCB_VECTKEYSTAT_Shift, 16   @ bitWidth 16 (Register key)  
 
    .equ SCB_SCR, SCB_BASE + 0x10 @ (System control register) 
        .equ SCB_SLEEPONEXIT_Shift, 1   @ bitWidth 1 (SLEEPONEXIT)  
        .equ SCB_SLEEPDEEP_Shift, 2   @ bitWidth 1 (SLEEPDEEP)  
        .equ SCB_SEVEONPEND_Shift, 4   @ bitWidth 1 (Send Event on Pending bit)  
 
    .equ SCB_CCR, SCB_BASE + 0x14 @ (Configuration and control
  register) 
        .equ SCB_NONBASETHRDENA_Shift, 0   @ bitWidth 1 (Configures how the processor enters
  Thread mode)  
        .equ SCB_USERSETMPEND_Shift, 1   @ bitWidth 1 (USERSETMPEND)  
        .equ SCB_UNALIGN__TRP_Shift, 3   @ bitWidth 1 (UNALIGN_ TRP)  
        .equ SCB_DIV_0_TRP_Shift, 4   @ bitWidth 1 (DIV_0_TRP)  
        .equ SCB_BFHFNMIGN_Shift, 8   @ bitWidth 1 (BFHFNMIGN)  
        .equ SCB_STKALIGN_Shift, 9   @ bitWidth 1 (STKALIGN)  
 
    .equ SCB_SHPR1, SCB_BASE + 0x18 @ (System handler priority
  registers) 
        .equ SCB_PRI_4_Shift, 0   @ bitWidth 8 (Priority of system handler
  4)  
        .equ SCB_PRI_5_Shift, 8   @ bitWidth 8 (Priority of system handler
  5)  
        .equ SCB_PRI_6_Shift, 16   @ bitWidth 8 (Priority of system handler
  6)  
 
    .equ SCB_SHPR2, SCB_BASE + 0x1C @ (System handler priority
  registers) 
        .equ SCB_PRI_11_Shift, 24   @ bitWidth 8 (Priority of system handler
  11)  
 
    .equ SCB_SHPR3, SCB_BASE + 0x20 @ (System handler priority
  registers) 
        .equ SCB_PRI_14_Shift, 16   @ bitWidth 8 (Priority of system handler
  14)  
        .equ SCB_PRI_15_Shift, 24   @ bitWidth 8 (Priority of system handler
  15)  
 
    .equ SCB_SHCRS, SCB_BASE + 0x24 @ (System handler control and state
  register) 
        .equ SCB_MEMFAULTACT_Shift, 0   @ bitWidth 1 (Memory management fault exception active
  bit)  
        .equ SCB_BUSFAULTACT_Shift, 1   @ bitWidth 1 (Bus fault exception active
  bit)  
        .equ SCB_USGFAULTACT_Shift, 3   @ bitWidth 1 (Usage fault exception active
  bit)  
        .equ SCB_SVCALLACT_Shift, 7   @ bitWidth 1 (SVC call active bit)  
        .equ SCB_MONITORACT_Shift, 8   @ bitWidth 1 (Debug monitor active bit)  
        .equ SCB_PENDSVACT_Shift, 10   @ bitWidth 1 (PendSV exception active
  bit)  
        .equ SCB_SYSTICKACT_Shift, 11   @ bitWidth 1 (SysTick exception active
  bit)  
        .equ SCB_USGFAULTPENDED_Shift, 12   @ bitWidth 1 (Usage fault exception pending
  bit)  
        .equ SCB_MEMFAULTPENDED_Shift, 13   @ bitWidth 1 (Memory management fault exception
  pending bit)  
        .equ SCB_BUSFAULTPENDED_Shift, 14   @ bitWidth 1 (Bus fault exception pending
  bit)  
        .equ SCB_SVCALLPENDED_Shift, 15   @ bitWidth 1 (SVC call pending bit)  
        .equ SCB_MEMFAULTENA_Shift, 16   @ bitWidth 1 (Memory management fault enable
  bit)  
        .equ SCB_BUSFAULTENA_Shift, 17   @ bitWidth 1 (Bus fault enable bit)  
        .equ SCB_USGFAULTENA_Shift, 18   @ bitWidth 1 (Usage fault enable bit)  
 
    .equ SCB_CFSR_UFSR_BFSR_MMFSR, SCB_BASE + 0x28 @ (Configurable fault status
  register) 
        .equ SCB_IACCVIOL_Shift, 1   @ bitWidth 1 (Instruction access violation
  flag)  
        .equ SCB_MUNSTKERR_Shift, 3   @ bitWidth 1 (Memory manager fault on unstacking for a
  return from exception)  
        .equ SCB_MSTKERR_Shift, 4   @ bitWidth 1 (Memory manager fault on stacking for
  exception entry.)  
        .equ SCB_MLSPERR_Shift, 5   @ bitWidth 1 (MLSPERR)  
        .equ SCB_MMARVALID_Shift, 7   @ bitWidth 1 (Memory Management Fault Address Register
  MMAR valid flag)  
        .equ SCB_IBUSERR_Shift, 8   @ bitWidth 1 (Instruction bus error)  
        .equ SCB_PRECISERR_Shift, 9   @ bitWidth 1 (Precise data bus error)  
        .equ SCB_IMPRECISERR_Shift, 10   @ bitWidth 1 (Imprecise data bus error)  
        .equ SCB_UNSTKERR_Shift, 11   @ bitWidth 1 (Bus fault on unstacking for a return
  from exception)  
        .equ SCB_STKERR_Shift, 12   @ bitWidth 1 (Bus fault on stacking for exception
  entry)  
        .equ SCB_LSPERR_Shift, 13   @ bitWidth 1 (Bus fault on floating-point lazy state
  preservation)  
        .equ SCB_BFARVALID_Shift, 15   @ bitWidth 1 (Bus Fault Address Register BFAR valid
  flag)  
        .equ SCB_UNDEFINSTR_Shift, 16   @ bitWidth 1 (Undefined instruction usage
  fault)  
        .equ SCB_INVSTATE_Shift, 17   @ bitWidth 1 (Invalid state usage fault)  
        .equ SCB_INVPC_Shift, 18   @ bitWidth 1 (Invalid PC load usage
  fault)  
        .equ SCB_NOCP_Shift, 19   @ bitWidth 1 (No coprocessor usage
  fault.)  
        .equ SCB_UNALIGNED_Shift, 24   @ bitWidth 1 (Unaligned access usage
  fault)  
        .equ SCB_DIVBYZERO_Shift, 25   @ bitWidth 1 (Divide by zero usage fault)  
 
    .equ SCB_HFSR, SCB_BASE + 0x2C @ (Hard fault status register) 
        .equ SCB_VECTTBL_Shift, 1   @ bitWidth 1 (Vector table hard fault)  
        .equ SCB_FORCED_Shift, 30   @ bitWidth 1 (Forced hard fault)  
        .equ SCB_DEBUG_VT_Shift, 31   @ bitWidth 1 (Reserved for Debug use)  
 
    .equ SCB_MMFAR, SCB_BASE + 0x34 @ (Memory management fault address
  register) 
        .equ SCB_MMFAR_Shift, 0   @ bitWidth 32 (Memory management fault
  address)  
 
    .equ SCB_BFAR, SCB_BASE + 0x38 @ (Bus fault address register) 
        .equ SCB_BFAR_Shift, 0   @ bitWidth 32 (Bus fault address)  
 
    .equ SCB_AFSR, SCB_BASE + 0x3C @ (Auxiliary fault status
  register) 
        .equ SCB_IMPDEF_Shift, 0   @ bitWidth 32 (Implementation defined)  
 

@=========================== NVIC_STIR ===========================@
.equ NVIC_STIR_BASE, 0xE000EF00 @ (Nested vectored interrupt
  controller) 
    .equ NVIC_STIR_STIR, NVIC_STIR_BASE + 0x0 @ (Software trigger interrupt
  register) 
        .equ NVIC_STIR_INTID_Shift, 0   @ bitWidth 9 (Software generated interrupt
  ID)  
 

@=========================== FPU_CPACR ===========================@
.equ FPU_CPACR_BASE, 0xE000ED88 @ (Floating point unit CPACR) 
    .equ FPU_CPACR_CPACR, FPU_CPACR_BASE + 0x0 @ (Coprocessor access control
  register) 
        .equ FPU_CPACR_CP_Shift, 20   @ bitWidth 4 (CP)  
 

@=========================== SCB_ACTRL ===========================@
.equ SCB_ACTRL_BASE, 0xE000E008 @ (System control block ACTLR) 
    .equ SCB_ACTRL_ACTRL, SCB_ACTRL_BASE + 0x0 @ (Auxiliary control register) 
        .equ SCB_ACTRL_DISMCYCINT_Shift, 0   @ bitWidth 1 (DISMCYCINT)  
        .equ SCB_ACTRL_DISDEFWBUF_Shift, 1   @ bitWidth 1 (DISDEFWBUF)  
        .equ SCB_ACTRL_DISFOLD_Shift, 2   @ bitWidth 1 (DISFOLD)  
        .equ SCB_ACTRL_DISFPCA_Shift, 8   @ bitWidth 1 (DISFPCA)  
        .equ SCB_ACTRL_DISOOFP_Shift, 9   @ bitWidth 1 (DISOOFP)  
 
