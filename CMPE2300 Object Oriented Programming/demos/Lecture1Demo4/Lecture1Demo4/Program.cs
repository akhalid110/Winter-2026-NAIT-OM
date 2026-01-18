// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*
 * cmpe2300 - object oriented programming 
 * Lecture1 - Demo4 - Working with strings
 */

string name1 = "Hello";
string name2 = name1;

Console.WriteLine($"Object.ReferenceEquaals(name1,name2): {object.ReferenceEquals(name1,name2)}");
name2 += "World"; //modification of name1

Console.WriteLine($"After modification of name1 - Object.ReferenceEquaals(name1,name2): {object.ReferenceEquals(name1, name2)}");

Console.WriteLine();
Console.WriteLine();


//Using verbatim string- Adding an @ before our string makes it verbatim, i.e it cancels the escapse sequence effect 
string sNonVerbatim = "C:\\Utils\\SimeDir\\myFile.txt";
string sVerbatim = @"C:\Utils\SimeDir\myFile.txt";  //Also works with $@"C:\Utils\SimeDir\myFile.txt";

Console.WriteLine($"sNonVerbatim is: {sNonVerbatim}");
Console.WriteLine($"sVerbatim is: {sVerbatim}");