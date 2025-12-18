class BrownDwarf :Star
{
    //private double _density;

    //  public BrownDwarf(string n, double d, double l, double t) : base(n, d, l, t)
    // {
    //     //this._density = de;
    // }

    public BrownDwarf(float temp, float luminosity, float radius, float absMag, string starType, string starColor, string spectralClass) : base(temp, luminosity, radius, absMag, starType, starColor, spectralClass)
    {
        
    }

    // public BrownDwarf(double l, double t) : base(l, t)
    // {
        
    // }

    

    public override string GenerateAstroReport()
{
    // This calls the logic in Star.cs which actually builds the string
    return base.GenerateAstroReport();
} 
}