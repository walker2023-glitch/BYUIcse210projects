using System.Drawing;
using System.Runtime.CompilerServices;

class Square : Shape
{

    private double _side;
    private const string _name = "Square";

    public Square(double S, string C) : base(C)
    {
        this._side = S;

    }

    public override double GetArea()
    {
        return _side * _side;
    }

    public override string WriteName()
    {
        return _name;
    }
}