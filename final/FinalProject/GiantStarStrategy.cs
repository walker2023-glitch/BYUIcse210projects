public class GiantStarStrategy : IClassificationStrategy
{
    public Star TryClassify(StarDataRaw data)
    {
        // Giant Stars: Magnitude less than 3.0
        if(data._AbsoluteMag < 3.0)
        {
            return new GiantStar(data._TempK, data._Lum, data._Radius, data._AbsoluteMag, "Giant", data._Color, data._SpectralClass);
        }
        return null;
    }
}