// See https://aka.ms/new-console-template for more information
/*
CMPE 2300 Object-Oriented Programming
 
Lecture2 - Demo1

Date: Jan 15th, 2026

Author: Om Patel
 */

//MyPoint P1 = new MyPoint { _X = 2, _Y = 7 };
//MyPoint P2 = new MyPoint { _X = 3, _Y = 8 };

MyPoint P1 = new MyPoint(2, 3);
MyPoint P2 = new MyPoint(4, 7);

//Console.WriteLine($"P1 is : ({P1._X}, {P1._Y})");
//Console.WriteLine($"P2 is : ({P2._X}, {P2._Y})");

Console.WriteLine($"P1 is : {P1.ToString()}");
Console.WriteLine($"P2 is : {P2.ToString()}");

//Press any key to exit
Console.WriteLine("\nPress Any Key to Exit");
Console.ReadKey();

struct MyPoint
{
    private int _X;
    private int _Y;

    //Since the members are private, we use a constructor for creating the 
    //the struct entity and a ToString for Displaying

    public MyPoint(int x, int y)
    {
        _X = x;
        _Y = y;
    }
    public string ToString()
    {
        return $"({_X}, {_Y})";
    }
}