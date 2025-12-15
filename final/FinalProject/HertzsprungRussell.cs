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
        _strategies.Add(new GaintStarStrategy());
        _strategies.Add(new MainSequenceStrategy());

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
                _TempK = double.Parse(oneStar[0]),
                _Lum = double.Parse(oneStar[1]),
                _Radius = double.Parse(oneStar[2]),
                _AbsoluteMag = double.Parse(oneStar[3]),
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

            if(classifiedStar == null)
            {
                StarTypePrediction prediction = _predictor.Predict(_trainedMLModel, rawStar);
                int predictedType = (int)prediction.PredictedStarType;

                classifiedStar = CreateStarObjectFromPrediction(predictedType, rawStar);
            }

            _starCatalog.Add(classifiedStar);
        }
        Console.WriteLine("Classification complete. Catalog populated.")
    }

    private Star CreateStarObjectFromPrediction(int type, StarDataRaw rawData)
    {
        switch (type)
        {
            case 0:
                return new


            default:
                Console.WriteLine($"Warning: Unexpected ML prediction type: {type}. Defaulting to Main Sequence.");
                return new MainSequenceStar(rawData);
        }
    }

}