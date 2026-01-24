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
unsigned short int variable;
printf("Enter a positive number = ");
scanf("%u",&variable);
printf("Binary number : ");
for (int i = 15;i>=0;i--){
unsigned int mask = 1 << i;
if(variable & mask){
printf("1"); 
}
else {
printf("0");
}
}
}

/*
int main(void) {
unsigned short int variable;
printf("Enter a positive number = ");
scanf("%u",&variable);
for (int i = 15;i>=0;i--){
printf("%d",(variable << i) & 1);
}
}
*/

/*************************** End of file ****************************/
