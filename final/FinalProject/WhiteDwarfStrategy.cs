public class WhiteDwarfStrategy : IClassificationStrategy
{
    public Star TryClassify(StarDataRaw data)
    {
        // White Dwarfs: Hot (> 8000K) but very dim (Magnitude > 10.0)
        if (data._TempK >= 8000 && data._AbsoluteMag > 10.0)
        {
            return new WhiteDwarf(data._TempK, data._Lum, data._Radius, data._AbsoluteMag, "White Dwarf", data._Color, data._SpectralClass);
        }
        return null;
    }
}