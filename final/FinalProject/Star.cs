using System.Runtime.ConstrainedExecution;

public class Star :CelestialObject
{
    protected float _luminosity;
    protected float _tempK;
    protected float _radius;
    protected float _absMag;
    protected string _starType;
    protected string _starColor;
    protected string _spectralClass;

    protected string _FinalResult;

    private readonly SpectralType st = new SpectralType();

    //Temperature (K),Luminosity(L/Lo),Radius(R/Ro),Absolute magnitude(Mv),Star type,Star color,Spectral Class

    public Star(float temp, float luminosity, float radius, float absMag, string starType, string starColor, string spectralClass)
    {
        this._tempK = temp;
        this._luminosity = luminosity;
        this._radius = radius;
        this._absMag = absMag;
        this._starType = starType;
        this._starColor = starColor;
        this._spectralClass = spectralClass;
    }

    // public Star(double l, double t)
    // {
    //     _luminosity = l;
    //     this._tempK = t;
    // }

    // public Star(string n, double d, float l, float t) : base(n, d)
    // {
    //     this._luminosity = l;
    //     this._tempK = t;
    // }

    
    

    public string GetSpectralClass()
    {
        return st.GetSpectralClass(this._tempK);
    }

    public virtual string GenerateAstroReport()
    {
        return $"Star Type: {this._starType} Spectral Class: {GetSpectralClass()} Star Color: {this._starColor} Star temperature: {this._tempK}K Star Luminosity: {this._luminosity}L/Lo Star Radius: {this._radius}R/Ro Absolute Magnitude: {this._absMag}";
    }
}

