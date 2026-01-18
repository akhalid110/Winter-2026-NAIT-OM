// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*
 * Lecture1 - Demo7 
 */

using System.Drawing;

Tester(); 

/*
 * Our Test method contains a number o default parameter valu. Note that when we invoke the 
 * method, the values for thhese are optional. Also note that we can't use default enum types.
 * For enum type varibales, we have to assign them as null by default, then in the method, test for null,
 * then assign a default value
 */
void Test(int iX,int iY,double dZ=0.1, int iWidth = 5, string sWord = "OOP", Color? color = null)
{
    //color being of an enum type, it has been assigned as null by default in hte method header,
    //then inside the method, we test for null then assign a value
    if(color == null)
    {
        Console.WriteLine("color was null - it's assigned as black");
        color = Color.Black;
    }
    Console.WriteLine($"Value of iX is: {iX} ");
    Console.WriteLine($"Value of iY is: {iY} ");
    Console.WriteLine($"Value of dZ is: {dZ} ");
    Console.WriteLine($"Value of iWidth is: {iWidth} ");
    Console.WriteLine($"Value of sWordd is: {sWord} ");
    Console.WriteLine();
}

//This method calls Test() with varying number of arguements 
void Tester()
{
    Console.WriteLine("Calling Test(1,2):");
    Test(1, 2);

    Console.WriteLine("Calling Test(1,2,0.4):");
    Test(1, 2, 0.4);

    Console.WriteLine("Calling Test(1,2,0.4,10):");
    Test(1, 2, 0.4, 10);

    Console.WriteLine("Calling Test(1,2,0.4,10,\"timepass\"):");
    Test(1, 2, 0.4, 10, "timepass");

    //if we use parameters, we can  use non-default values for any parameter, irreespective of wwhere it's positioned
    Console.WriteLine("Calling Test(1,2,\"nothing\"):");
    Test(1, 2, sWord: "nothing");
}