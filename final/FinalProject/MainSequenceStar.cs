class MainSequenceStar :Star
{


    public MainSequenceStar(float temp, float luminosity, float radius, float absMag, string starType, string starColor, string spectralClass) 
        : base(temp, luminosity, radius, absMag, starType, starColor, spectralClass)
    {
    }
    // public MainSequenceStar(string n, double d, double l, double t) : base(n, d, l, t)
    // {
        
    // }
    // public MainSequenceStar(double l, double t) : base(l, t)
    // {
        
    // }
    public override string GenerateAstroReport()
{
    // This calls the logic in Star.cs which actually builds the string
    return base.GenerateAstroReport();
}
}