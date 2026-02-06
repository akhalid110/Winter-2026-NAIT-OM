/*********************************************************************
*                    SEGGER Microcontroller GmbH                     *
*                        The Embedded Experts                        *
**********************************************************************

-------------------------- END-OF-HEADER -----------------------------

File    : main.c
Purpose : Generic application start

*/
#include <stdint.h>
#include <stdio.h>
#include "stm32g0b1xx.h"
#include "gpio.h"

/*********************************************************************
*
*       main()
*
*  Function description
*   Application entry point.
*/

//function prototype
void delay_1Ms(void);
void delayMs(uint32_t ms);


int main(void) {
RCC-> IOPENR |= RCC_IOPENR_GPIOAEN_Msk; 
RCC-> IOPENR |= RCC_IOPENR_GPIOCEN_Msk; 
RCC->APBENR1 |= RCC_APBENR1_USART2EN; //Enable USART // 5.4.15 //Reference Manual = RM

printf("Clock speed: %u[Hz]",SystemCoreClock);

//BAUD RATE ROUNDING EXAMPLE
uint32_t BRR = (uint32_t)(SystemCoreClock*1.0f / 9600 +0.5);

//PA2 and PA3 config // Configure GPIO for USART2 // TX-> PA2 // RX->PA3
GPIOA->MODER &= ~(0b11 <<2*2);//Clear PA2
GPIOA->MODER |= 0b10 <<2*2;//Set PA2 to AF mode

GPIOA->MODER &= ~(0b11 <<3*2);//Clear PA3
GPIOA->MODER |= 0b10 <<3*2;//Set PA3 to AF mode

//CLEAR the AF PA2
//SET PA2 to ALternate Function 1 (AF1)
GPIOA->AFR[0] &= ~(0b1111<< 2*4);
GPIOA->AFR[0] |= 1<< 2*4;
//SET PA3 to ALternate Function 1 (AF1)
GPIOA->AFR[0] &= ~(0b1111<< 3*4);
GPIOA->AFR[0] |= 1<< 3*4;

char arr[] = " Hello World ";

//USART Config
USART2->BRR =  (uint32_t)(SystemCoreClock*1.0f / 9600 +0.5);// Set Baud Rate

USART2->CR1 |= USART_CR1_UE| USART_CR1_RE| USART_CR1_TE ; //Enable USART, RE, TE in CR1
USART2->RQR |= USART_RQR_RXFRQ;  //Discard any remaining data for safety // flush out any remaining data

//Transmit 1 byte
for (int i = 0; i < sizeof(arr) - 1; i++)
{
    while (!(USART2->ISR & USART_ISR_TXE_TXFNF));
    USART2->TDR = arr[i];
}



while (1) {
delayMs(250);
for (int i = 0; i < sizeof(arr) - 1; i++)
{
    while (!(USART2->ISR & USART_ISR_TXE_TXFNF));
    USART2->TDR = arr[i];
}  
}

}

//function for 1 ms 
void delay_1Ms(){
    volatile uint32_t delay = 1775;
        while(--delay);
}


//function for x ms 
void delayMs(uint32_t ms)
{
  for(int i=0;i<ms;i++)     //while(--ms)
  {
    delay_1Ms();
  }
}

/*************************** End of file ****************************/
