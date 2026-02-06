/*********************************************************************
*                    SEGGER Microcontroller GmbH                     *
*                        The Embedded Experts                        *
**********************************************************************

-------------------------- END-OF-HEADER -----------------------------

File    : main.c
Purpose : Generic application start

*/
#include <stdint.h>
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

GPIO_InitOutput(GPIOA, 5);

while (1) {
    delayMs(40);
    GPIO_Toggle(GPIOA, 5);
} 
}

//function for 1 ms 
void delay_1Ms(){
    volatile uint32_t delay = 1776;
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
