// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/* 
 * Lecture1Demo5 - Using is and as for type conversion
 */


//type conversion using "is" method
//string
object myThing = "Hi";
if (myThing is String)
{
    Console.WriteLine("myThing is a string");
}
else
{
    Console.WriteLine("myThing is not a string");
}


Console.WriteLine();


//int
myThing = 25;
//type conversion using "is" method
if (myThing is String)
{
    Console.WriteLine("myThing is a string");
}
else
{
    Console.WriteLine("myThing is not a string");
}


Console.WriteLine();


//Using the extension to the is
object r = new Random();
if(r is Random rand)
{
    Console.WriteLine($"Random num is: {rand.Next(100)}");
}
else
{
    Console.WriteLine($"The object was not of class Random");
}


Console.WriteLine();


r = "Hello";
if (r is Random ran)
{
    Console.WriteLine($"Random num is: {ran.Next(100)}");
}
else
{
    Console.WriteLine($"The object was not of class Random");
}


Console.WriteLine();


//type conversion using "as" method
//testMe being declared of general type object
//but assignned a value of type string 
object testMe = "Hello There";

//The opbject testMe cast to a string using "as" and stored in refMe
string refMe = testMe as string;
if(refMe != null)
{
    Console.WriteLine("testMe was a string.");
}
else
{
    Console.WriteLine("testMe was not a string.");
}
