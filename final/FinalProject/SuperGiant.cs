class SuperGiant : GiantStar
{
    // Constructor matching your detailed signature
    // public SuperGiant(string n, double d, double l, double t, double r) 
    //     : base(n, d, l, t, r) { }

    // Constructor matching your minimal signature
    // public SuperGiant(double l, double t, double r) 
    //     : base(l, t, r) { }

    public SuperGiant(float temp, float luminosity, float radius, float absMag, string starType, string starColor, string spectralClass) :base(temp, luminosity, radius, absMag, starType, starColor, spectralClass)
    {
        
    }

    public override string GenerateAstroReport()
    {
        return $"[SUPER GIANT] {base.GenerateAstroReport()}";
    }
}