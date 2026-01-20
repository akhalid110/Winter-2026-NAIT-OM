// See https://aka.ms/new-console-template for more information
/*
CMPE 2300 Object-Oriented Programming

Lecture2 - Demo2 - Working with Classes

Date: Jan 15th, 2026

Author: Luke Picherack
 */

using Lecture2_Demo2;

//Creatine an instance (an object) of the CStudent class
CStudent s1 = new CStudent("Jackson", 97);
CStudent s2 = new CStudent("Micael");
CStudent s3 = new CStudent("Harry, 95, 525");
Console.WriteLine($"The student s1 has the following attributes: {s1.ToString()}");
Console.WriteLine($"The student s2 has the following attributes: {s2.ToString()}");
Console.WriteLine($"The student s3 has the following attributes: {s3.ToString()}");


//Press any key to exit
Console.WriteLine("Press Any Key to Exit");
Console.ReadKey();