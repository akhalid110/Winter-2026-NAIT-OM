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
int main(void) {
  if(4>2)
  {
    printf("4 is greater than 2");
  }

  int i=10;
  while(i>0)
  {
  printf("i = %d\n",i);
  --i;
  }

  if(6)
  {
  printf("6 is true.\n");
  }
  else
  {
  printf("6 is false\n");
  }

  //logical OR
  if(6 || 0){
  printf("6 || 0 is true\n");
  }
  else
  {
  printf("6 || 0 is false\n");
  }

  //bitwise OR
  if(6 | 0)
  {
  printf("6 | 0 is true\n");
  }
  else
  {
  printf("6 | 0 is false\n");
  }

  //bitwise AND
  if(5 & 4)
  {
  printf("5 & 4 is true\n");
  }
  else
  {
  printf("5 & 4 is false\n");
  }

  //bitwise XOR
  if(5^4)
  {
  printf("5 ^ 4 is true\n");
  }
  else
  {
  printf("5 ^ 4 is false\n");
  }

  //bit shifting 
  int number1 = 8;

  //bit shifting to the LEFT
  printf("%d bitshifted to the LEFT by 1 is %d\n",number1,number1<<1);
  

  //bit shifting to the RIGHT
  printf("%d bitshifted to the LEFT by 1 is %d\n",number1,number1>>1);

  //bit shifting loop decrement loop  
  unsigned int number= 65536;
  printf("bit shifting loop decrement loop\n");
  for(unsigned int i = 16;i > 0; i--){
      printf("%u\n",number>>i);
  }
  printf("\n");

  //bit shifting loop increment loop 
  printf("bit shifting loop increment loop\n"); 
  for(unsigned int i = 1;i <= 16; i++){
      printf("%u\n",number>>(17-i));
  }
}

/*************************** End of file ****************************/
