// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



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
