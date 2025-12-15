class MainSequenceStar :Star
{

    public MainSequenceStar(string n, double d, double l, double t) : base(n, d, l, t)
    {
        
    }
    public MainSequenceStar(double l, double t) : base(l, t)
    {
        
    }
    public override string GenerateAstroReport()
    {
        return base.GenerateAstroReport();
    }
}