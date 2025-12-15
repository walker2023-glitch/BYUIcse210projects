class RedDwarf :Star
{
    //private double _density;

     public RedDwarf(string n, double d, double l, double t) : base(n, d, l, t)
    {
        //this._density = de;
    }

    public RedDwarf(double l, double t) : base(l, t)
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