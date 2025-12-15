public class MainSequenceStrategy : IClassificationStrategy
{
    public Star TryClassify(StarDataRaw data)
    {
        


        if(data._AbsoluteMag >= 3.0 && data._AbsoluteMag <= 10.0 && data._TempK >=3500 && data._TempK <= 25000)
        {
            return new MainSequenceStar(data._TempK, data._Lum);
        }
        return null;
    }
}