
using Microsoft.ML;
using Microsoft.ML.Data;

public class StarTypePrediction
{
    // ML.NET will put the predicted category index here
    [ColumnName("PredictedLabel")]
    public uint PredictedStarType { get; set; }

    // This array holds the probability for each possible star type
    public float[] Score { get; set; }
}

public class StarTypePredictor
{
    private readonly MLContext _mlContext;

    public StarTypePredictor()
    {
        _mlContext = new MLContext();
    }
    // FinalProject/StarTypePrediction.cs

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
    
    // 1. Concatenate features (Ensure these are floats in StarDataRaw)
    var dataProcessingPipeline = _mlContext.Transforms.Concatenate("Features", featureColumns)
        // 2. Map the 'Label' column (Int32) to a Key type
        .Append(_mlContext.Transforms.Conversion.MapValueToKey("Label"));

    // 3. Append the trainer
    var trainingPipeLine = dataProcessingPipeline.Append(
        _mlContext.MulticlassClassification.Trainers.SdcaMaximumEntropy(
            labelColumnName: "Label",
            featureColumnName: "Features"
        )
    );

    ITransformer trainedModel = trainingPipeLine.Fit(trainingDataView);
    
    _mlContext.Model.Save(
        trainedModel,
        trainingDataView.Schema,
        "star_classifier_model.zip"
    );
    
    return trainedModel;
}
    public StarTypePrediction Predict(ITransformer trainedModel, StarDataRaw data)
    {
        PredictionEngine<StarDataRaw, StarTypePrediction> predictionEngine = _mlContext.Model.CreatePredictionEngine<StarDataRaw, StarTypePrediction>(trainedModel);
        
        StarTypePrediction predictionResult = predictionEngine.Predict(data);

        return predictionResult;
        
        //throw new NotImplementedException();
    }
}