class BrownDwarf :Star
{
    //private double _density;

     public BrownDwarf(string n, double d, double l, double t) : base(n, d, l, t)
    {
        //this._density = de;
    }

    public BrownDwarf(double temp, double luminosity, double radius, double absMag, string starType, string starColor, string spectralClass) : base(temp, luminosity, radius, absMag, starType, starColor, spectralClass)
    {
        this._tempK = temp;
        this._luminosity = luminosity;
        this._radius = radius;
        this._absMag = absMag;
        this._starType = starType;
        this._starColor = starColor;
        this._spectralClass = spectralClass;
    }

    public BrownDwarf(double l, double t) : base(l, t)
    {
        
    }

    public override string GenerateAstroReport()
    {
        string RealFinal = this._FinalResult;
        //string RealFinal = this._FinalResult + $"Density: {_density}";
        return RealFinal;
        //return base.GenerateAstroReport();
    } 
}