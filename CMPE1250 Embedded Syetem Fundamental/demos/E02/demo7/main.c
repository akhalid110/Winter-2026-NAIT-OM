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
typedef struct Person__{
char name[30];
int age; 
}Person;

Person person1;
Person person2;

person1.name[0] = 'O';
person1.name[1] = 'm';
person1.age = 21;
person1.age = 20;

Person *pPerson1 = &person1;
pPerson1->age = 12; // accessing using the pointer 
}


/*************************** End of file ****************************/
