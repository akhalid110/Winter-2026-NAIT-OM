/*********************************************************************
*                    SEGGER Microcontroller GmbH                     *
*                        The Embedded Experts                        *
**********************************************************************

-------------------------- END-OF-HEADER -----------------------------

File    : main.c
Purpose : Generic application start

*/

#include <stdio.h>
//               Decimal                  Hexa-Decimal
// BIT0          1                           0x1
// BIT1          2                           0x2
// BIT2          4                           0x4
// BIT3          8                           0x8
// BIT4          16                          0x10
// BIT5          32                          0x20
// BIT6          64                          0x40
// BIT7          128                         0x80
// BIT8          256                         0x100
// BIT9          512                         0x200
//   

/*********************************************************************
*
*       main()
*
*  Function description
*   Application entry point.
*/
#define BIT7 0b10000000
#define BIT6 0b01000000
#define BIT5 0b00100000
#define BIT4 0b00010000
#define BIT3 0b10001000
#define BIT2 0b10000100
#define BIT1 0b10000010
#define BIT0 0b10000001

int main(void) {
unsigned char PORTA = 0b11000010; //0x
PORTA |= BIT5; //SET b5
PORTA &= ~BIT3; //CLEAR B3
PORTA &= ~(BIT4 | BIT2); // CLEAR BIT4 and BIT2 
while (1) {
PORTA ^= BIT7 | BIT0; // Toggle BIT7 and Toggle BIT0
}
}

/*************************** End of file ****************************/
