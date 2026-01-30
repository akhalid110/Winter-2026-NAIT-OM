// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
List<string> myData = new List<string>();
myData.Add("Cat");
myData.Add("Dog");
myData.Add("Lion");
myData.Insert(1, "Goat");
Console.WriteLine(myData[0]);
Console.WriteLine(myData[1]);
Console.WriteLine(myData[2]);
Console.WriteLine(myData[3]);
//Console.WriteLine(myData[30]); // Index out of range 

Console.WriteLine();

Console.WriteLine($"There are {myData.Count} elements in the List ");


Console.WriteLine();


Console.WriteLine("Using foreach loop");
foreach(string s in myData)
{
    Console.WriteLine(s);
}


Console.WriteLine();


Console.WriteLine("Using for loop");
for (int i = 0; i<myData.Count; i++)
{
    Console.WriteLine($"Animal {i} = {myData[i]}");
}
