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

uint16_t count5 = 0;
uint16_t count6 = 0;

int main(void) {
RCC-> IOPENR |= RCC_IOPENR_GPIOAEN_Msk; 
RCC-> IOPENR |= RCC_IOPENR_GPIOCEN_Msk; 


GPIO_InitOutput(GPIOA, 5);  //PA5
GPIO_InitOutput(GPIOA, 6);  //PA6
GPIO_InitInput(GPIOC, 13);  // PC13 input mode

while (1) {
delay_1Ms();
if((GPIOC->IDR & (1<<13))==0)  // button-> enable
{
  count5++;
  if(count5 >= 15){  
count5 = 0;
  GPIO_Toggle(GPIOA, 5);
  }

  count6++;
if(count6 >= 7){  
count6 = 0;
  GPIO_Toggle(GPIOA, 6);
}
}
else
{
  count5++;
  if(count5 >= 10){  
count5 = 0;
  GPIO_Toggle(GPIOA, 5);
  }

  count6++;
if(count6 >= 1){  
count6 = 0;
  GPIO_Toggle(GPIOA, 6);
}
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
