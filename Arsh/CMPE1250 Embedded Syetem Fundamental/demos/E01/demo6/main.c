/*********************************************************************
*                    SEGGER Microcontroller GmbH                     *
*                        The Embedded Experts                        *
**********************************************************************

-------------------------- END-OF-HEADER -----------------------------

File    : main.c
Purpose : Generic application start

*/

#include <stdio.h>
#define BIT7 0b10000000
#define BIT6 0b01000000
#define BIT5 0b00100000
#define BIT4 0b00010000
#define BIT3 0b10001000
#define BIT2 0b10000100
#define BIT1 0b10000010
#define BIT0 0b10000001


/*********************************************************************
*
*       main()
*
*  Function description
*   Application entry point.
*/
int main(void) {
unsigned char PORTA = 0b11000010; //0x
PORTA |= BIT5; //SET b5
PORTA &= ~BIT3; //CLEAR B3
PORTA &= ~(BIT4 | BIT2); // CLEAR BIT4 and BIT2 
}

/*************************** End of file ****************************/
