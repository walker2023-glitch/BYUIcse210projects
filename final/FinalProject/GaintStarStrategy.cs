public class GaintStarStrategy : IClassificationStrategy
{
    public Star TryClassify(StarDataRaw data)
    {
        if(data._AbsoluteMag > 3.0)
        {
            return new GaintStar(data._TempK, data._Lum, data._AbsoluteMag);
        }
        return null;
    }
}