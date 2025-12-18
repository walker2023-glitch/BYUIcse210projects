class WhiteDwarf :Star
{
    //private double _density;

    //  public WhiteDwarf(string n, double d, double l, double t) : base(n, d, l, t)
    // {
    //     //this._density = de;
    // }

    public WhiteDwarf(float temp, float luminosity, float radius, float absMag, string starType, string starColor, string spectralClass) : base(temp, luminosity, radius, absMag, starType, starColor, spectralClass)
    {
        
    }

    // public WhiteDwarf(double l, double t) : base(l, t)
    // {
        
    // }

    public override string GenerateAstroReport()
    {
        string RealFinal = this._FinalResult;
        //string RealFinal = this._FinalResult + $"Density: {_density}";
        return RealFinal;
        //return base.GenerateAstroReport();
    } 
}