// See https://aka.ms/new-console-template for more information
///Console.WriteLine("Hello, World!");
///

using Lecture6Demo2;
CBox c1 = new CBox(3, 3);
CBox c2 = new CBox(2, 3);
CBox c3 = new CBox(1, 3);
CBox c4 = new CBox(3, 2);
CBox c5 = new CBox(3, 4);
CBox c6 = new CBox(5, 4);
CBox c7 = new CBox(1, 5);
CBox c8 = new CBox(2, 4);


List<CBox> list = new List<CBox>() { c1, c2, c3, c4, c5, c6, c7, c8 };
Console.WriteLine("Displaying CBox objects before sorting: ");
foreach(CBox c in list)
{
    Console.WriteLine(c);
}


Console.WriteLine();
Console.WriteLine();


list.Sort();
Console.WriteLine("Displaying CBox objects after sorting: ");
foreach (CBox c in list)
{
    Console.WriteLine(c);
}








