// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*
 * Lecture 3 demo3 - Eorking with nullable members, expression-bodies members and Computed properties 
 */


using Lecture3Demo3;

Person p1 = new Person();
p1.FirstName = "Om";
p1.LastName = "Patel";

Console.WriteLine($"Name of p1 is {p1.FullName}");
Console.WriteLine($"The Language of p1 is {Person.Language}");    //Using the class name for the static property