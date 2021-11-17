# hw-cardio-nec
My project of two subprojects implemented in Mecrisp FORTH.

## phictrl
Old Philips projector control module

## Распределение периферии по портам/пинам. CARDIO

### Светодиод на отладочной плате (LED) - отладка алгоритмов.

  - USER_LED : PC13

### Кнопка пользователя

  - USER_PB : PA0

### UART2 - Терминальный доступ к микроконтроллеру,

  - A2 (PA2,12) - TX2
  - A3 (PA3,13) - RX2
  - 115200 Baud,8,1,n

### Обмен с AD73360 SPI1

 - SPI1 CS/SCK/MISO/MOSI : PA4/PA5/PA6/PA7
 - Альтернатива - SPI1 CS/SCK/MISO/MOSI : PA15/PB3/PB4/PB5
 - Управление обменом c AD73360 GPIOC, PC14,PC15 (~RESET, +SE (!))

### Обмен с ILI, SPI2

 - SPI2 CS/SCK/MISO/MOSI : PB12/PB13/PB14/PB15

### Обмен с Orange PI, SPI2 или UART1

 - SPI2 CS/SCK/MISO/MOSI : PAPB12/PB13/PB14/PB15
 - UART2 TX/RX : PA9/PA10 или PB6/PB7
 - Baud >> 115200

### Управление Экраном ILI9488

 - SPI3 PB5,4,3,PA15 + PA0 for ~OE
 - I2C1 PB7,PB6

 - CS=PB10, RS=PB2, WR=PB1, RD=PB0, RST->RESET


### Useful docs

https://tuxotronic.org/post/mecrisp-forth/  (Loading programs via ```folie```)