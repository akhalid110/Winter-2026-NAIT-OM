// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using Lecture4Demo1;
Ball b1 = new Ball();

//To access the member "color" we have to use the class name, since color is static 
Ball.color = "White";

//The static method must be invoke using the class name 
Ball.AssignColor("Red");