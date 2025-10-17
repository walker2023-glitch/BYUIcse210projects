using System.Diagnostics;
using System.Dynamic;

class Fraction
{
    private int _top = 0;
    private int _bottom = 0;


    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public void SetTop(int theTop)
    {
        _top = theTop;
    }

    public void SetBottom(int theBottom)
    {
        _bottom = theBottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public string GetFractionString()
    {
        string both = $"{this.GetTop()}/{this.GetBottom()}";
        return both;
    }
    
    public double GetDecimalValue  (){
        double dec = (double)this.GetTop() / (double)this.GetBottom();
        return dec;
    }

    //getfractionstring

    //getfractiondecimal

}