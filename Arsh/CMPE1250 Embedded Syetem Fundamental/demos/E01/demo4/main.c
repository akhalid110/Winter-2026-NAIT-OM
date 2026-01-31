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
  if(4>2){
  printf("4 is greater than 2\n");
  }

  int i=10;
  while(i > 0)
  {
    printf("i = %d\n",i);
    i--;
  }

  if(4){
  printf("4 is true.\n");
  }

  //logical AND
  if(4 && 0){
  printf("4 && 0 is true.\n");
  }
  else{
  printf("4 && 0 is false.\n");
  }

  //Bitwise AND
  if(4 & 0){
  printf("4 & 0 is true.\n");
  }
  else
  {
  printf("4 & 0 is false.\n");
  }

  //logical OR
  if(4 || 0){
  printf("4 || 0 is true.\n");
  }
  else {
    printf("4 || 0 is false.\n");
  }

  //Bitwise OR
  if(4 | 0){
  printf("4 | 0 is true.\n");
  }
  else {
    printf("4 | 0 is false.\n");
  }

  //Bitwise XOR
  if(4 ^ 0){
  printf("4 ^ 0 is true.\n");
  }
  else {
    printf("4 ^ 0 is false.\n");
  }

  //Bitwise XNOR
  if(!(4 ^ 0)){
  printf("4 !(^) 0 is true.\n");
  }
  else {
    printf("4 !(^) 0 is false.\n");
  }

  //bit shifting
  int num1 = 2;

  //bit shifting to the LEFT
  printf("%d bitshifted to the LEFT by 1 is %d\n",num1,num1<<1);

  //bit shifting to the RIGHT
  printf("\n\nbit shifting to the RIGHT");
  printf("%d bitshifted to the RIGHT by 1 is %d\n",num1,num1>>1);

  //bit shifting loop
  printf("\n\nbit shifting loop\n");
  unsigned int number = 65536;
  for(unsigned int i = 1; i <= 16; i++){
    printf("%u \n",number >> (17-i));
  }  
}

/*************************** End of file ****************************/
