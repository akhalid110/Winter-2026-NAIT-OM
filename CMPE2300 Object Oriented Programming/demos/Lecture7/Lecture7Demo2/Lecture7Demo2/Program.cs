// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Lecture7Demo2;
using System.Runtime.CompilerServices;
CBox box1 = new CBox(4, 3);
CBox box2 = new CBox(8, 2);
CBox box3 = new CBox(6,3);
CBox box4 = new CBox(2,1);
CBox box5 = new CBox(2,3);
CBox box6 = new CBox(9,2);
CBox box7 = new CBox(9,3);
CBox box8 = new CBox(8,3);


List<CBox> list = new List<CBox> {box1, box2, box3, box4, box5, box6, box7, box8 };

Console.WriteLine($"Initial list of th boxes : {string.Join(", ", list)}");
Console.WriteLine($"list of the boxes after filtering with predicate IsBig: {string.Join(", ", list.Find(CBox.IsBig))}");
Console.WriteLine($"list of the boxes after filtering with predicate IsBig: {string.Join(", ", list.FindAll(CBox.IsBig))}");
Console.WriteLine($"list of the boxes after filtering with predicate IsBig: {string.Join(", ", list.FindAll(delegate(CBox box) { return box.Area > 20; }))}");


