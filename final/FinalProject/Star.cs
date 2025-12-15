using System.Runtime.ConstrainedExecution;

public class Star :CelestialObject
{
    protected double _luminosity;
    protected double _tempK;

    protected string _FinalResult;

    private readonly SpectralType st = new SpectralType();

    public Star(double l, double t)
    {
        this._luminosity = l;
        this._tempK = t;
    }

    public Star(string n, double d, double l, double t) : base(n, d)
    {
        this._luminosity = l;
        this._tempK = t;
    }

    

    public string GetSpectralClass()
    {
        return st.GetSpectralClass(this._tempK);
    }

    public virtual string GenerateAstroReport()
    {
        string _FinalResult = $"Star Name: {this._name} Star temperature: {this._tempK}K Star Distance: {this._distanceLY}";
        return _FinalResult;
    }
}

