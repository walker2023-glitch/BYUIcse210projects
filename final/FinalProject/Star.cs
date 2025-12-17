using System.Runtime.ConstrainedExecution;

public class Star :CelestialObject
{
    protected double _luminosity;
    protected double _tempK;
    protected double _radius;
    protected double _absMag;
    protected string _starType;
    protected string _starColor;
    protected string _spectralClass;

    protected string _FinalResult;

    private readonly SpectralType st = new SpectralType();

    //Temperature (K),Luminosity(L/Lo),Radius(R/Ro),Absolute magnitude(Mv),Star type,Star color,Spectral Class

    public Star(double temp, double luminosity, double radius, double absMag, string starType, string starColor, string spectralClass)
    {
        this._tempK = temp;
        this._luminosity = luminosity;
        this._radius = radius;
        this._absMag = absMag;
        this._starType = starType;
        this._starColor = starColor;
        this._spectralClass = spectralClass;
    }

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
        //string _FinalResult = $"Star Name: {this._name} Star temperature: {this._tempK}K Star Distance: {this._distanceLY}";
        string _FinalResult = $"Star Name: {this._name} Star temperature: {this._tempK}K Star Luminosity: {this._luminosity}L/Lo Star Type: {this._starType} Star Color: {this._starColor} Spectral Class: {GetSpectralClass()}";
        
        return _FinalResult;
    }
}

