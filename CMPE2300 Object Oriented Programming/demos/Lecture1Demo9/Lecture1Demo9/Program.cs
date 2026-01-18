// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*
 * Lecture1 - Demo9 - Testing struct with reference type
 */

Thing T1, T2;

T1 = new Thing { num1 = 3, num2 = 5, intArray = new int[] { 1, 2, 3, 4, 5 } };
T2 = T1;

Console.WriteLine("Initial values in T1 and T2:");
Console.WriteLine($"T1: num1 = {T1.num1}, num2 = {T1.num2}, intArray: {string.Join(",",T1.intArray)}");
Console.WriteLine($"T1: num1 = {T2.num1}, num2 = {T2.num2}, intArray: {string.Join(",", T2.intArray)}");
Console.WriteLine($"T1 == T2: {T1.Equals(T2)}");
Console.WriteLine();

//we modify the first two members of T2
T2.num1 = 5;
T2.num2 = 7;
Console.WriteLine("After modifying the first two members of T2:");
Console.WriteLine($"T1: num1 = {T1.num1}, num2 = {T1.num2}, intArray: {string.Join(",", T1.intArray)}");
Console.WriteLine($"T1: num1 = {T2.num1}, num2 = {T2.num2}, intArray: {string.Join(",", T2.intArray)}");
Console.WriteLine($"T1 == T2: {T1.Equals(T2)}");
Console.WriteLine();
        
//We modify values in the intArray for T2
T2.intArray[3] = 50;
T2.intArray[4] = 100;
Console.WriteLine("After modifying the intArray of T2:");
Console.WriteLine($"T1: num1 = {T1.num1}, num2 = {T1.num2}, intArray: {string.Join(",", T1.intArray)}");
Console.WriteLine($"T1: num1 = {T2.num1}, num2 = {T2.num2}, intArray: {string.Join(",", T2.intArray)}");
Console.WriteLine($"T1 == T2: {T1.Equals(T2)}");
Console.WriteLine();


//The struct below has 2 members of value type and a member of a reference type
struct Thing
{
    public int num1;
    public int num2;
    public int[] intArray;
}
