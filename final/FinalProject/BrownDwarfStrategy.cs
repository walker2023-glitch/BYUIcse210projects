public class BrownDwarfStrategy : IClassificationStrategy
{
    public Star TryClassify(StarDataRaw data)
    {
        // Brown Dwarfs: Cooler than 3500K and dim (Magnitude > 16.0)
        if (data._TempK < 3500 && data._AbsoluteMag > 16.0)
        {
            return new BrownDwarf(data._TempK, data._Lum, data._Radius, data._AbsoluteMag, "Brown Dwarf", data._Color, data._SpectralClass);
        }
        return null;
    }
}