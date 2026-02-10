// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Lecture6Demo1;

CBox cbox1 = new CBox(7, 9);
CBox cbox2 = new CBox(10, 7);
CBox cbox3 = new CBox(11, 6);
CBox cbox4 = new CBox(12, 5);

List<CBox> boxes = new List<CBox>();

boxes.Add(cbox1);
boxes.Add(cbox2);
boxes.Add(cbox3);
boxes.Add(cbox4);

Console.WriteLine($"Initial Order of instances: {string.Join(",",boxes)}");

//Default sorting - based on the CompareTo method 
boxes.Sort();

Console.WriteLine($" Order of instances after default sorting: {string.Join(",", boxes)}");

boxes.Sort(CBox.CompareOnWidth);
//using the CompareOnWidth method for sorting 
Console.WriteLine($"Order of instances after sorting using CompareOnWidth: {string.Join(",", boxes)}");

boxes.Sort(CBox.CompareOnHeight);
//using the CompareOnHeight method for sorting 
Console.WriteLine($"Order of instances after sorting using CompareOnHeight: {string.Join(",", boxes)}");