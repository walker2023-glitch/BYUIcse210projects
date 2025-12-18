public class HyperGiantStrategy : IClassificationStrategy
{
    public Star TryClassify(StarDataRaw data)
    {
        // Hyper Giants: Extremely bright (Magnitude < -8.0)
        if (data._AbsoluteMag < -8.0) 
        {
            return new HyperGiant(data._TempK, data._Lum, data._Radius, data._AbsoluteMag, "Hypergiant", data._Color, data._SpectralClass);
        }
        return null;
    }
}