public class SuperGiantStrategy : IClassificationStrategy
{
    public Star TryClassify(StarDataRaw data)
    {
        // Super Giants: Magnitude between -5.0 and -8.0
        if (data._AbsoluteMag < -5.0 && data._AbsoluteMag >= -8.0)
        {
            return new SuperGiant(data._TempK, data._Lum, data._Radius, data._AbsoluteMag, "Super Giant", data._Color, data._SpectralClass);
        }
        return null;
    }
}