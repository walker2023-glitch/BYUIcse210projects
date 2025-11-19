using System.Drawing;

class Circle : Shape
{

    private double _radius;

    private const string _name = "Circle";

    public Circle(double R, string C) : base(C)
    {
        this._radius = R;


    }

    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }

    public override string WriteName()
    {
        return _name;
    }
}