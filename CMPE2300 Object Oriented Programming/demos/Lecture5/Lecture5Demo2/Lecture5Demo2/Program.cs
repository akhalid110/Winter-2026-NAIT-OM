// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Box a = new Box(2, 1);
Box b = new Box(2, 1);
Console.WriteLine($"a.Equals(b): {a.Equals(b)}");
Console.WriteLine($"a==b: {a==b}");
Console.WriteLine($"object.Equals(a,b): {object.Equals(a,b)}");
Console.WriteLine($"object.ReferenceEquals(a,b): {object.ReferenceEquals(a, b)}");





class Box
{
    public int _length;
    public int _width;

    public Box(int l,int w)
    {
        _length = l;
        _width = w;
    }
}