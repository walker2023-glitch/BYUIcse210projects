public class RedDwarfStrategy : IClassificationStrategy
{
    public Star TryClassify(StarDataRaw data)
    {
        if(data._AbsoluteMag > 10 && data._TempK < 5000)
        {
            return new RedDwarf(data._TempK, data._Lum);
        }
        return null;
    }
}