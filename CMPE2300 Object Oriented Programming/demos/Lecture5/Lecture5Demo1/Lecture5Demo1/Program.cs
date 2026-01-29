// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
int A = 15;
int B = 15;
Console.WriteLine($"A.Equals(B)     : {A.Equals(B)}"); 
Console.WriteLine($"A == B          : {A == B}"); 
Console.WriteLine($"object.Equals(A,B): {object.Equals(A,B)}"); 

Console.WriteLine();
Console.WriteLine();


Thing C = new Thing(10);
Thing D = new Thing(10);
Console.WriteLine("Working with objects");
Console.WriteLine($"C.Equals(D)                : {C.Equals(D)}");
Console.WriteLine($"C == D                     : {C == D}");
Console.WriteLine($"object.Equals(C,D)           : {object.Equals(C, D)}");
Console.WriteLine($"C == D                     : {C == D}");
Console.WriteLine($"object.ReferenceEquals(C,D): {object.ReferenceEquals(C, D)}");


Console.WriteLine();
Console.WriteLine();


Thing E = C;
Console.WriteLine($"C.Equals(E)                : {C.Equals(E)}");
Console.WriteLine($"C == E                     : {C == E}");
Console.WriteLine($"object.Equals(C,E)           : {object.Equals(C, E)}");
Console.WriteLine($"object.ReferenceEquals(C,E): {object.ReferenceEquals(C, E)}");


Console.WriteLine();
Console.WriteLine();

//Testing Equals on value types (structs)
Box a = new Box(2, 1);
Box b = new Box(2, 1);
Box c = new Box(2, 2);
Console.WriteLine("Verifiying the different equality checcks with structs");
Console.WriteLine($"a.Equals(b)                : {a.Equals(b)}");
//Console.WriteLine($"a == b                     : {a == b}");
Console.WriteLine($"object.Equals(a,b)           : {object.Equals(a, b)}");
Console.WriteLine($"object.ReferenceEquals(a,b): {object.ReferenceEquals(a, b)}");
Console.WriteLine();
Console.WriteLine($"a.Equals(c)                : {a.Equals(c)}");
//Console.WriteLine($"a == c                     : {a == c}");
Console.WriteLine($"object.Equals(a,c)           : {object.Equals(a, c)}");
Console.WriteLine($"object.ReferenceEquals(a,c): {object.ReferenceEquals(a, c)}");




internal class Thing
{
    private int _num;
    public Thing(int num)
    {
        _num = num;
    }
}

struct Box
{
    public int _length;
    public int _width;

    public Box(int l, int w)
    {
        _length = l;
        _width = w;
    }
}