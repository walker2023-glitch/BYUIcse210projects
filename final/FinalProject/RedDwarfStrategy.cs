public class RedDwarfStrategy : IClassificationStrategy
{
    public Star TryClassify(StarDataRaw data)
    {
        // Red Dwarfs: Dim (> 10 Mag) and relatively cool (< 5000K)
        if(data._AbsoluteMag > 10 && data._TempK < 5000)
        {
            return new RedDwarf(data._TempK, data._Lum, data._Radius, data._AbsoluteMag, "Red Dwarf", data._Color, data._SpectralClass);
        }
        return null;
    }
}