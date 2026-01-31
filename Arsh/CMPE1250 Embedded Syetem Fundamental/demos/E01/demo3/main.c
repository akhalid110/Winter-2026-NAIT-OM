/*********************************************************************
*                    SEGGER Microcontroller GmbH                     *
*                        The Embedded Experts                        *
**********************************************************************

-------------------------- END-OF-HEADER -----------------------------

File    : main.c
Purpose : Demo to test IO on the debugging console

*/

#include <stdio.h>
int main(void){
 int num1 = 0,num2 = 0,num3 =0,num4 =0;
  int const const1=0,const2 = 0;
 
  printf("The address of const1 %p\n",&const1);
  printf("The address of const2 %p\n",&const2);

  printf("The address of num1 %p\n",&num1);
  printf("The address of num2 %p\n",&num2);
  printf("The address of num3 %p\n",&num3);
  printf("The address of num4 %p\n",&num4);

}