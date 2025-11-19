using System.Drawing;

class Rectangle : Shape
{

    private double _length;
    private double _width;

    private const string _name = "Rectangle";

    public Rectangle(double W, double L, string C) : base(C)
    {
        this._length = L;
        this._width = W;

    }

    public override double GetArea()
    {
        return _length * _width;
    }

    public override string WriteName()
    {
        return _name;
    }
}