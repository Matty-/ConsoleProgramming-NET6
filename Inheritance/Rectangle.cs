// See https://aka.ms/new-console-template for more information

using Inheritance;

class Rectangle : Shape, IShape
{
    public double Width { get; set; }

    public double GetArea()
    {
        return Length * Width;
    }
}