// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class CBox : IComparable  // Now with comparison via CompareTo()
{
    private int Width;
    private int Height;
    public CBox(int _widht, int _height)
    {
        this.Width = _widht;
        this.Height = _height;
    }
}
