// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Linq;

List<int> aList = new List<int>();
List<int> bList = new List<int>();

Random rand = new Random();
for(int count = 0; count < 10; count ++)
{
    aList.Add(rand.Next(1, 16));
    bList.Add(rand.Next(1, 16));
}
Console.WriteLine("Initial Listes: ");
Console.WriteLine($"aList: {string.Join(",",aList)}");
Console.WriteLine($"bList: {string.Join(",", bList)}");
Console.WriteLine();
Console.WriteLine("Lists with Distinct() method applied: ");
Console.WriteLine($"aList.Distinct: {string.Join(",", aList.Distinct())}");
Console.WriteLine($"bList.Distinct: {string.Join(",", bList.Distinct())}");


//Note that th extension methods do not modify the original variables 
Console.WriteLine($"aList.Concat(bList): {string.Join(",", aList.Concat(bList))}");
Console.WriteLine($"aList.Union(bList): {string.Join(",", aList.Union(bList))}");
Console.WriteLine($"aList.Intersect(bList): {string.Join(",", aList.Intersect(bList))}");
Console.WriteLine($"aList.Except(bList): {string.Join(",", aList.Except(bList))}");

//Using a forwach loop to iterate over the obtained collection 
Console.WriteLine("Iterating over aList.Except(bList) using a foreach loop: ");
foreach(int val in aList.Except(bList))
{
    Console.Write(val);
}

Console.WriteLine();
int threshold = 10;
Console.WriteLine($"Elements less than {threshold} from aList: {string.Join(",",aList.Where(x=>x<threshold))}");
Console.WriteLine($"Elements less than {threshold} from aList: {string.Join(",", aList.SkipWhile(x => x < threshold))}");





