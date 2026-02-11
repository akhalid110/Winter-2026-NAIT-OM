// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");



List<int> list = new List<int> { 15,24,12,21,8,14,34,22,17,4};
Console.WriteLine($"The List of all event members is : {string.Join(", " , list.FindAll(IsEven))}");
Console.WriteLine($"The List of all event members is : {string.Join(", ", list.Find(IsEven))}");

bool IsEven (int a)
{
    return a % 2 == 0;
} 


