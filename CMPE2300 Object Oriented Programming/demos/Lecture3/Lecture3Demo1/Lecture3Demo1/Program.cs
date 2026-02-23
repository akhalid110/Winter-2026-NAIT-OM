// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using Lecture3Demo1;

Box b = new Box(12);


//Get Value
int widthValue = b.Width;
Console.Write("get called = ");
Console.WriteLine($"{widthValue}");

Console.WriteLine();

//Set Value
b.Width = -25;
Console.WriteLine($"set called using (b.Width) = {b.Width}");

Console.WriteLine();

//Display method calsed
Console.WriteLine("Using b.Display to display the initial values of both _iWidth and Width");
b.Display();

Console.WriteLine();

//Both will be called
b.Width++;

Console.WriteLine();

Console.Write($"Area of b1 = {b.Area}");

Console.WriteLine();

Box c1 = new Box(8, 6);
Console.WriteLine($"Area of c1 = {c1.Area}");


