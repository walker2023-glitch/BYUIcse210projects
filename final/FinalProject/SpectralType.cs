using System.Collections.Generic;

//public struct SpectralClassDetails
class SpectralClassDetails
{
    // The public properties for our two values
    public string _CharacteristicColor;
    public string _TemperatureRangeK;

    public double _LowerTempK;

    public string getColor()
    {
        return _CharacteristicColor;
    }

    public string getTempRange()
    {
        return _TemperatureRangeK;
    }

    public double getLowerTemp()
    {
        return _LowerTempK;
    }

    // A constructor to easily create a new struct with values
    public SpectralClassDetails(string color, string tempRange, double LowerTemp)
    {
        _CharacteristicColor = color;
        _TemperatureRangeK = tempRange;
       _LowerTempK = LowerTemp;
    }
    
}


class SpectralType
{
    //AI taught me how to define dictionaries in c# then suggested I turn it to private and readonly
    private readonly Dictionary<string, SpectralClassDetails> TempRanges = new Dictionary<string, SpectralClassDetails>()
{
    {"O", new SpectralClassDetails("Blue", "> 30,000", 30000)},
    //I wrote the first one, then used AI to write these next ones to speed it up.
    { "B", new SpectralClassDetails("Blue-White", "10,000 - 30,000", 10000) },
    { "A", new SpectralClassDetails("White", "7,500 - 10,000", 7500) },
    { "F", new SpectralClassDetails("Yellow-White", "6,000 - 7,500", 6000) },
    { "G", new SpectralClassDetails("Yellow", "5,200 - 6,000", 5200) },
    { "K", new SpectralClassDetails("Orange", "3,700 - 5,200", 3700) },
    { "M", new SpectralClassDetails("Red", "< 3,700", 0) }
    
};

public string GetSpectralClass(double temp)
    {
        //I used AI to help me figure out how to do this part
        //but I made sure to type it all my own
        //and asked it questions so I could understand what it is doing
        var sortedBounds = TempRanges.Values.OrderByDescending(d => d._LowerTempK);
        foreach(var details in sortedBounds)
        {
            //this checks if the current version of the loop is greater than the least value of the star
           if(temp >= details.getLowerTemp())
            {
                //This take that temp, and assigns it the correct letter according to it's temperature.
                string SpectralLetter = TempRanges.First(key => key.Value == details).Key;
                return SpectralLetter;
                
            } 
        }
        //If it's not very hot, it is assigned M by default. 
        return "M";
        
    }
}