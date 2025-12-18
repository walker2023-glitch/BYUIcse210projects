using Microsoft.ML;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;


class HertzsprungRussell
{
    private List<Star> _starCatalog;
    
    
    private List<IClassificationStrategy> _strategies;
    private readonly StarTypePredictor _predictor = new StarTypePredictor();
    private ITransformer _trainedMLModel;
    const string DataPath = "StarData.txt";


    public HertzsprungRussell()
    {
        _starCatalog = new List<Star>();

        _strategies = new List<IClassificationStrategy>();

        _strategies.Add(new RedDwarfStrategy());
        _strategies.Add(new GiantStarStrategy());
        _strategies.Add(new MainSequenceStrategy());

    }

    public void PrintCatalogReport()
{
    foreach (var star in _starCatalog)
    {
        Console.WriteLine(star.GenerateAstroReport());
    }
}
    public void InitializeMLModel()
    {
        _trainedMLModel = _predictor.LoadAndTrainModel(DataPath);
    }

    public List<StarDataRaw> LoadRawData()
    {
        string[] allLines = File.ReadAllLines(DataPath);
        List<StarDataRaw> rawStars = new List<StarDataRaw>();
        foreach (string line in allLines.Skip(1))
        {
            string[] oneStar = line.Split(',');
            
            rawStars.Add(new StarDataRaw
            {
                _TempK = float.Parse(oneStar[0]),
                _Lum = float.Parse(oneStar[1]),
                _Radius = float.Parse(oneStar[2]),
                _AbsoluteMag = float.Parse(oneStar[3]),
                //Label = int.Parse(oneStar[4]),
                 Label = int.Parse(oneStar[4]),
                _Color = (oneStar[5]),
                
                _SpectralClass = (oneStar[6]),
            
               
            
            });
        }

        return rawStars;
    }

    public void RunClassification()
    {
        List<StarDataRaw> rawStars = LoadRawData();
        _starCatalog.Clear();

        Console.WriteLine($"Starting classifcation of {rawStars.Count} stars...");

        foreach (var rawStar in rawStars)
        {
            Star classifiedStar = null;
            foreach(var strategy in _strategies)
            {
                classifiedStar = strategy.TryClassify(rawStar);

                if(classifiedStar != null)
                {
                    break;
                }
            }

            // FinalProject/HertzsprungRussell.cs

            if(classifiedStar == null)
            {
                StarTypePrediction prediction = _predictor.Predict(_trainedMLModel, rawStar);
                // Cast the uint key back to int
                int predictedType = (int)prediction.PredictedStarType - 1; 

                classifiedStar = CreateStarObjectFromPrediction(predictedType, rawStar);
            }

            _starCatalog.Add(classifiedStar);
        }
        Console.WriteLine("Classification complete. Catalog populated.");
    }


        // Updated HertzsprungRussell.cs
private Star CreateStarObjectFromPrediction(int type, StarDataRaw rawData)
{
    return type switch
    {
        0 => new BrownDwarf(rawData._TempK, rawData._Lum, rawData._Radius, rawData._AbsoluteMag, "Brown Dwarf", rawData._Color, rawData._SpectralClass),
        1 => new RedDwarf(rawData._TempK, rawData._Lum, rawData._Radius, rawData._AbsoluteMag, "Red Dwarf", rawData._Color, rawData._SpectralClass),
        2 => new WhiteDwarf(rawData._TempK, rawData._Lum, rawData._Radius, rawData._AbsoluteMag, "White Dwarf", rawData._Color, rawData._SpectralClass),
        3 => new MainSequenceStar(rawData._TempK, rawData._Lum, rawData._Radius, rawData._AbsoluteMag, "Main Sequence", rawData._Color, rawData._SpectralClass),
        4 => new GiantStar(rawData._TempK, rawData._Lum, rawData._Radius, rawData._AbsoluteMag, "Giant", rawData._Color, rawData._SpectralClass),
        5 => new HyperGiant(rawData._TempK, rawData._Lum, rawData._Radius, rawData._AbsoluteMag, "Hypergiant", rawData._Color, rawData._SpectralClass),
        // Fallback case
        _ => new MainSequenceStar(rawData._TempK, rawData._Lum, rawData._Radius, rawData._AbsoluteMag, "Main Sequence", rawData._Color, rawData._SpectralClass)
    };
}

}