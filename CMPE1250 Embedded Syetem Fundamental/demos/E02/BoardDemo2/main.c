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

/*********************************************************************
*
*       main()
*
*  Function description
*   Application entry point.
*/
void delayMs(uint32_t ms)
{
  while(ms--)
  {
    volatile uint32_t delay = 1779;
    while(--delay);
  }
}
int main(void) {
RCC-> IOPENR |= RCC_IOPENR_GPIOAEN_Msk; //same as RCC_IOPENR_GPIOAEN // Enable GPIOA

GPIOA->MODER &= ~(0b11 << 5*2); //CLEAR moder
//GPIOA->MODER &= GPIO_MODER_MODE5_Msk; // same as the above
GPIOA->MODER |= 0b01 << 5*2;  //SET moder to GPIO output
//GPIOA->MODER |= GPIO_MODER_MODE5_0 // same as the above

while (1) {
    GPIOA->ODR ^= 0b1 << 5; //TOGGLE 
    delayMs(1000);
}
}

/*************************** End of file ****************************/
