// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*
 * Lecture 3 Demo2 Working with Automatic Properties
 */

using Lecture3Demo2;

Employee emp = new Employee();

emp.FullName = "Om";
Console.WriteLine($"The name of the employee 1 is {emp.FullName}.");

Employee emp2 = new Employee("Keya");
Console.WriteLine($"The name of the employee 2 is {emp2.FullName}.");

Employee emp3 = new Employee("Ban", "2005");
Console.WriteLine($"employee 3 is {emp3}.");




