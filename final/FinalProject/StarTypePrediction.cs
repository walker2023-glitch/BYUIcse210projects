
using Microsoft.ML;
using Microsoft.ML.Data;

public class StarTypePrediction
{
    public float Score {get; set;}
    [ColumnName("PredictedLabel")]
    public int PredictedStarType {get; set;}

    

}

public class StarTypePredictor
{
    private readonly MLContext _mlContext;

    public StarTypePredictor()
    {
        _mlContext = new MLContext();
    }
    public ITransformer LoadAndTrainModel(string trainingDataPath)
    {
        IDataView trainingDataView = _mlContext.Data.LoadFromTextFile<StarDataRaw>(
            path: trainingDataPath,
            separatorChar: ',',
            hasHeader: true
        );
        
        string[] featureColumns = new[]
        {
            nameof(StarDataRaw._TempK),
            nameof(StarDataRaw._Lum),
            nameof(StarDataRaw._AbsoluteMag),
            nameof(StarDataRaw._Radius)
        };
        
        IEstimator<ITransformer> dataProcessingPipeline = _mlContext.Transforms.Concatenate("Features", featureColumns);

        var trainingPipeLinen= dataProcessingPipeline.Append(
            _mlContext.MulticlassClassification.Trainers.SdcaMaximumEntropy(
                labelColumnName: "Label",
                featureColumnName: "Features"
            )
        );
        ITransformer trainedModel = trainingPipeLinen.Fit(trainingDataView);
        _mlContext.Model.Save(
            trainedModel,
            trainingDataView.Schema,
            "star_classifier_model.zip"
        );
        
        
        return trainedModel;



        //throw new NotImplementedException();
    }
    public StarTypePrediction Predict(ITransformer trainedModel, StarDataRaw data)
    {
        PredictionEngine<StarDataRaw, StarTypePrediction> predictionEngine = _mlContext.Model.CreatePredictionEngine<StarDataRaw, StarTypePrediction>(trainedModel);
        
        StarTypePrediction predictionResult = predictionEngine.Predict(data);

        return predictionResult;
        
        //throw new NotImplementedException();
    }
}