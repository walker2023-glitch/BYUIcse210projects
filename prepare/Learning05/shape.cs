class Shape
{
    protected string _color;
    private double _area;

    private string _name;


    public Shape(string c)
    {
        this._color = c;
    }


    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        color = _color;
    }

    public virtual double GetArea()
    {
        return _area;
    }
    
    public virtual string WriteName()
    {
        return _name;
    }
}