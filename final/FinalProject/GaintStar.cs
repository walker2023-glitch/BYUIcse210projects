class GiantStar :Star
{
    //private double _RadiusSolar;


    public GiantStar(float temp, float luminosity, float radius, float absMag, string starType, string starColor, string spectralClass) :base(temp, luminosity, radius, absMag, starType, starColor, spectralClass)
    {
        
    }
    // public GiantStar(string n, double d, double l, double t, double r) : base(n, d, l, t)
    // {
    //     this._RadiusSolar = r;
    // }
    // public GiantStar(double l, double t, double r) : base(l, t)
    // {
    //     this._RadiusSolar = r;]
    // }

    public override string GenerateAstroReport()
    {
        string RealFinal = this._FinalResult;
        return RealFinal;
        //return base.GenerateAstroReport();
    }
}