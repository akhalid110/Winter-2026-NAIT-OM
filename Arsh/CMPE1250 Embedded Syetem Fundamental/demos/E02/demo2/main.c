/*********************************************************************
*                    SEGGER Microcontroller GmbH                     *
*                        The Embedded Experts                        *
**********************************************************************

-------------------------- END-OF-HEADER -----------------------------

File    : main.c
Purpose : Demo to test IO on the debugging console

*/

#include <stdio.h>

#define NUMBER 5
#define SQUARE(X) X*X
#define PART1
#define PART2

int main(void)
{

  #ifdef  PART1
  short int const number = 6;
  printf("Hello world from PART1\n");
  int size = sizeof(number);
  int test = SQUARE(2);
  size = sizeof(NUMBER);
  #endif

  #ifdef  PART2
  printf("Hello world from PART2\n");
    #endif

}
