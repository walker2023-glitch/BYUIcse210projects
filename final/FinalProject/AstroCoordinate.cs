class AstroCoordinate
{
    private double _RA;
    private double _Dec;


    public AstroCoordinate(double RA, double DEC)
    {
        _RA = RA;
        _Dec = DEC;
    }


    public string FormatCoordinate()
    {
        
        return $"RA: {formatRA()} Dec: {formatDec()}";
    }

    public string formatRA()
    {
        //Ai suggested to use the math.floor to keep the numbers more "mathmetically pure"
        int RaHours = (int)Math.Floor(_RA); 
        int RaMinutes = (int)((_RA - RaHours ) * 60);
        double RaSeconds = (((_RA - RaHours ) * 60 - RaMinutes) * 60);
        //I wrote almost all this code, but AI suggested the formatting below (F2, D2)
        return $"{RaHours:D2}h {RaMinutes:D2}m {RaSeconds:F2}s";
    }

    public string formatDec()
    {
        //I wrote this section but it was based on code AI gave me. I gave it my code to check how I did, and it gave this suggestion
        string sign = "";
        if(_Dec > 0)
        {
            sign = "+";
        }
        else if(_Dec < 0)
        {
            sign = "-";
        }

        double absDec = Math.Abs(_Dec);

        //Ai suggested to use the math.floor to keep the numbers more "mathmetically pure"
        int Degrees = (int)Math.Floor(absDec); 
        int DecMinutes = (int)((absDec - Degrees) * 60);
        double DecSeconds = (((absDec - Degrees) * 60) - DecMinutes);
        //I wrote almost all this code, but AI suggested the formatting below (F2, D2)
        return $"{sign}{Degrees}degress {DecMinutes:D2}arcminutes {DecSeconds:F2}arcseconds";
    }

}