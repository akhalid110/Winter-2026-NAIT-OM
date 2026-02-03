






using System.Threading;

List<box> boxes = new List<box>();
//Note that here the Equals test for b1 and b3 will return 
box b1 = new box(2, 1, 8);
box b2 = new box(2, 3, 5);
box b3 = new box(2, 1, 5);

boxes.Add(b1);
boxes.Add(b2);

Console.WriteLine($"boxes.Contains(b3) : {boxes.Contains(b3)}");
Console.WriteLine($"boxes.IndexOf(b3) : {boxes.IndexOf(b3)}");



Console.WriteLine($"b1.Equals(b2): {b1.Equals(b2)}");
Console.WriteLine($"b1.Equals(b3): {b1.Equals(b3)}");
Console.WriteLine($"b1 == b2:  {b1 == b2}");
Console.WriteLine($"b1 == b3: {b1 == b3}");

class box
{
    private int _length;
    private int _width;
    private int _height;


    public box(int l, int w, int h = 5)
    {
        _length = l;
        _width = w;
        _height = h;
    }
    public override bool Equals(object? obj)
    {
        //This statement will both test for the correct type 
        // and also for null
        if (!(obj is box other)) return false;

        //test for equality of the member values 
        return (this._length == other._length && this._width == other._width);
    }

    //overloading Equals for Box class
    public bool Equals(box box)
    {
        //Test for null first 
        if (box is null) return false;

        //test for equality of the member values 
        return (this._length == box._length && this._width == box._width);
    }

    public override string ToString()
    {
        return $" Value of Length = {_length}, Value of Width = {_width} and  Value of height = {_height}";
    }


}