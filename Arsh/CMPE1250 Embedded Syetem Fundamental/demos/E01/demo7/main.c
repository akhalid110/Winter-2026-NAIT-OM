/*********************************************************************
*                    SEGGER Microcontroller GmbH                     *
*                        The Embedded Experts                        *
**********************************************************************

-------------------------- END-OF-HEADER -----------------------------

File    : main.c
Purpose : Generic application start

*/

#include <stdio.h>

/*********************************************************************
*
*       main()
*
*  Function description
*   Application entry point.
*/
#define BIT7 0b10000000;
#define BIT6 0b01000000;
#define BIT5 0b00100000;
#define BIT4 0b00010000;
#define BIT3 0b10001000;
#define BIT2 0b10000100;
#define BIT1 0b10000010;
#define BIT0 0b10000001;

int main(void) {
  unsigned short int number = 0xFFFF; // 65535
  /*
  clear all bits 1-by-1 starting from B0 upto b15
  */
  for (int i = 0;i<16;i++){
  number &= ~(1 << i) ;  // clear all the bits 
  }
}

/*************************** End of file ****************************/
