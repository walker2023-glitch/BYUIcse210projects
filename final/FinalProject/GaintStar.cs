class GaintStar :Star
{
    private double _RadiusSolar;

    public GaintStar(string n, double d, double l, double t, double r) : base(n, d, l, t)
    {
        this._RadiusSolar = r;
    }
    public GaintStar(double l, double t, double r) : base(l, t)
    {
        this._RadiusSolar = r;
    }

    public override string GenerateAstroReport()
    {
        string RealFinal = this._FinalResult + $"Radius Solar: {_RadiusSolar}";
        return RealFinal;
        //return base.GenerateAstroReport();
    }
}