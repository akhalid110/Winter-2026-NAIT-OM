/*********************************************************************
*                    SEGGER Microcontroller GmbH                     *
*                        The Embedded Experts                        *
**********************************************************************

-------------------------- END-OF-HEADER -----------------------------

File    : main.c
Purpose : Generic application start

*/

#include <stdio.h>

//AND -> '0'   1,1 -> 1            with 0 all are zero     {CLEAR}     X+1 = 1    X+ 0= X
//OR -> '1'    0,0 ->0             with 1 alla are one     {SET}       X.0 = 0    X.1 =X
//XOR -> toggle   0,1  1,0 -> 1    same are zeros          {TOGGLE}    X +o 1 = Xbar   X +o 0 = X

//Example 1 :                                       b7 b6 b5 b4 b3 b2 b1 b0
//                                    PORTA :-  
//     SET b2     everything else remains same      0  0  0  0  0  1  0  0
//     CLEAR b5   everything else remains same      1  1  0  1  1  1  1  1
//     TOGGLE b3    everything else remains same    0  0  0  0  1  0  0  0


//Example 2 :                                       b7 b6 b5 b4 b3 b2 b1 b0
//                                    PORTA :-  
//     SET b5     everything else remains same      0  0  1  0  0  0  0  0
//     CLEAR b3   everything else remains same      1  1  0  1  1  1  1  1
//     TOGGLE b7  everything else remains same      1  0  0  0  0  0  0  0

//Example 3 :                                       b7 b6 b5 b4 b3 b2 b1 b0
//                                    PORTA :-      1  1  0  0  0  0  1  0
//     SET b0     everything else remains same      0  0  0  0  0  0  0  1
//     CLEAR b6   everything else remains same      1  0  1  1  1  1  1  1
//     TOGGLE b4  everything else remains same      0  0  0  1  0  0  0  0


/*********************************************************************

*
*       main()
*
*  Function description
*   Application entry point.
*/
int main(void) {
  unsigned char PORTA = 0b11000010; //0x

  PORTA |= 0b00100000; // SET bit5

  PORTA &= 0b11011111; // CLEAR bit3

  while (1) {
    PORTA ^= 0b10000001; // TOGGLE bit7 as well as bit0
  }
}

/*************************** End of file ****************************/
