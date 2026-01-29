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
int main(void) {
RCC-> IOPENR |= RCC_IOPENR_GPIOAEN_Msk; //same as RCC_IOPENR_GPIOAEN // Enable GPIOA
RCC-> IOPENR |= RCC_IOPENR_GPIOBEN_Msk; //same as RCC_IOPENR_GPIOBEN // Enable GPIOB
RCC-> IOPENR |= RCC_IOPENR_GPIOCEN_Msk; //same as RCC_IOPENR_GPIOCEN // Enable GPIOC


//Configure PA5 as an output 

GPIOA->MODER &= ~(0b11 << 5*2); //CLEAR moder
//GPIOA->MODER &= GPIO_MODER_MODE5_Msk; // same as the above
GPIOA->MODER |= 0b01 << 5*2;  //SET moder to GPIO output
//GPIOA->MODER |= GPIO_MODER_MODE5_0 // same as the above
GPIOC->MODER &= ~(0b11 << 13*2); 

while (1) {
if((GPIOC->IDR & (1<<13) )== 0){
//GPIOA->ODR ^= GPIO_ODR_OD5; //TOGGLE //same as the below
    uint32_t delay = 156100;
    while(--delay);
    GPIOA->ODR ^= 0b1 << 5; //TOGGLE 
}
else 
{
GPIOA->ODR |= (1<<5);
}
}

}

/*************************** End of file ****************************/
