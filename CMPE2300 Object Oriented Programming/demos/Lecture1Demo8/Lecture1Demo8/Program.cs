// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*
 * lEcture1 - Demo8 - Struct 
 */


sTest s;
// Declaring a struct as above does not initialize the members so the statement below givens as error
//Console.WriteLine($"s.iX = {s.iX}, s.iY = {s.iY}"); 
s.iX = 1;
s.iY = 2;
Console.WriteLine($"Members of s were assigned directly: s.iX = {s.iX}, s.iY = {s.iY}"); 

sTest s1 = new sTest(2);
Console.WriteLine($"s1 was created using the user-defined constructor: s1.iX = {s1.iX}, s1.iY = {s1.iY}");

//Creating the struct entity using the default constructor
sTest s2 = new sTest();
Console.WriteLine($"s2 was created using the default constructor: s2.iX = {s2.iX}, s2.iY = {s2.iY}");
struct sTest
{
    public int iX;
    public int iY;

    //user-defined constructor
    public sTest(int iVal)
    {
        iX = iVal;
        this.iY = iVal;  // The "this" is optional
    }
}
