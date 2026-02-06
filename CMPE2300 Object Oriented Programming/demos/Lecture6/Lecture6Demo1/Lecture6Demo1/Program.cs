// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Lecture6Demo1;

CBox a = new CBox(2, 2);
CBox b = new CBox(2, 1);

Console.WriteLine($"a: {a}");
Console.WriteLine($"b: {b}");

Console.WriteLine($"a.Equals(b): {a.Equals(b)}");
Console.WriteLine($"a.CompareTo(b): {a.CompareTo(b)}");
Console.WriteLine($"b.CompareTo(a): {b.CompareTo(a)}");


List<CBox> list = new List<CBox>();
list.Add(new CBox(3, 3));
list.Add(new CBox(2, 2));
list.Add(new CBox(1, 1));
list.Sort(); // Needs a way to order the set, Sort will find and use your IComparable support
Console.WriteLine($"{list[0]} - {list[1]} - {list[2]}");
