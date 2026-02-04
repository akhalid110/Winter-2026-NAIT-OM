






using System.Threading;

List<Box> boxes = new List<Box>();
//Note that here the Equals test for b1 and b3 will return 
Box b1 = new Box(2, 2,5);
Box b2 = new Box(2, 1, 8);
Box b3 = new Box(2, 1, 5);

boxes.Add(b1);
boxes.Add(b2);

Console.WriteLine($"boxes.Contains(b3) : {boxes.Contains(b3)}");
Console.WriteLine($"boxes.IndexOf(b3) : {boxes.IndexOf(b3)}");

Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"b1.Equals(b2): {b1.Equals(b2)}");
Console.WriteLine($"b1.Equals(b3): {b1.Equals(b3)}");
Console.WriteLine($"b1 == b2:  {b1 == b2}");
Console.WriteLine($"b1 == b3: {b1 == b3}");
Console.WriteLine($"b1 != b2: {b1 != b2}");
Console.WriteLine($"b1 != b3: {b1 != b3}");


class Box
{
    private int _length;
    private int _width;
    private int _height;


    public Box(int l, int w, int h = 5)
    {
        _length = l;
        _width = w;
        _height = h;
    }
    public override bool Equals(object? obj)
    {
        //This statement will both test for the correct type 
        // and also for null
        if (!(obj is Box other)) return false;

        //test for equality of the member values 
        return (this._length == other._length && this._width == other._width);
    }

    //overloading Equals for Box class
    public bool Equals(Box box)
    {
        //Test for null first 
        if (box is null) return false;

        //test for equality of the member values 
        return (this._length == box._length && this._width == box._width);
    }

    //Overloading the == operator to make it behave like the Equals method
    public static bool operator ==(Box argLeft , Box argRight)
    {
        //if both refer to the same object, we return true
        if (ReferenceEquals(argLeft, argRight))
            return true;
        //if either is null,but not both,  we return false
        if (ReferenceEquals(argLeft, null) ^ ReferenceEquals(argRight, null))
            return false;

        //leverage Equal() here instead of rewriting 
        return argLeft.Equals(argRight);
    }

    //Oveerloading !=
    public static bool operator !=(Box argLeft, Box argRight)
    {
        //leverage operator==() here instead of rewriting 
        return !(argLeft.Equals(argRight));
    }

    public override string ToString()
    {
        return $" Value of Length = {_length}, Value of Width = {_width} and  Value of height = {_height}";
    }


}