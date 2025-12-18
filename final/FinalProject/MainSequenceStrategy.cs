public class MainSequenceStrategy : IClassificationStrategy
{
    public Star TryClassify(StarDataRaw data)
    {
        // Main Sequence: Magnitude between 3 and 10, Temperature between 3500 and 25000
        if(data._AbsoluteMag >= 3.0 && data._AbsoluteMag <= 10.0 && data._TempK >= 3500 && data._TempK <= 25000)
        {
            return new MainSequenceStar(data._TempK, data._Lum, data._Radius, data._AbsoluteMag, "Main Sequence", data._Color, data._SpectralClass);
        }
        return null;
    }
}