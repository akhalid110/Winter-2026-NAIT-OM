// See https://aka.ms/new-console-template for more information
/*
CMPE 2300 Object-Oriented Programming

Lecture2 - Demo2 - Working with Classes

Date: Jan 15th, 2026

Author: Om Patel
 */

using Lecture2Demo2;

//Creatine an instance (an object) of the CStudent class
CStudent s1 = new CStudent("Jackson", 97);
CStudent s2 = new CStudent("Micael");
CStudent s3 = new CStudent("Harry", 85, 525);
CStudent s4 = new CStudent();

Console.WriteLine("Values asssigned at objects creation");
Console.WriteLine($"The student s1 has the following attributes: {s1.ToString()}");
Console.WriteLine($"The student s2 has the following attributes: {s2.ToString()}");
Console.WriteLine($"The student s3 has the following attributes: {s3.ToString()}");
Console.WriteLine($"The student s3 has the following attributes: {s4.ToString()}");
Console.WriteLine();

//We'll invoke upgrade for some instances of CStudent
Console.WriteLine("After calling upgrade");
s1.Upgrade(12);
s2.Upgrade(15);
s3.Upgrade();
Console.WriteLine($"The student s1 has the following attributes: {s1.ToString()}");
Console.WriteLine($"The student s2 has the following attributes: {s2.ToString()}");
Console.WriteLine($"The student s3 has the following attributes: {s3.ToString()}");
Console.WriteLine();

Console.WriteLine("Working with a List of CStudent instances");
//Creating a List of CStudent instances
List<CStudent> students = new List<CStudent>();
//We can create the CStudent instance then add it to the List
CStudent s = new CStudent();
students.Add(s);

//Or we can create and add in one statement as below
//We create 2 instances with the 2 parameters constructor
students.Add(new CStudent("Om Patel", 75));
students.Add(new CStudent("Keya", 78));


//We create 2 instances with the 3 parameters constructor
students.Add(new CStudent("Dhingu", 82, 625));
students.Add(new CStudent("Ban", 92, 725));

//Display
Console.WriteLine("Displaying instances of CStudent from the students List - with initial values");
foreach (CStudent cs in students)
{
    Console.WriteLine(cs);
}
Console.WriteLine();

//For first student, since all the values were default, we'll assign all members usign the available methods
students[0].AssignName("Ninja");
students[0].AssignGrade(92);
students[0].AssignFees(579);

//For student[1] and student[2], we'll assign the fees
students[1].AssignFees(675);
students[2].AssignFees(745);


Console.WriteLine("Redisplaying the students List -after modifications");
foreach (CStudent cs in students)
{
    Console.WriteLine(cs);
}




Console.WriteLine();
//Press any key to exit
Console.WriteLine("Press Any Key to Exit");
Console.ReadKey();