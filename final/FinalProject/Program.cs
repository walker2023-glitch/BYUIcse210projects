using System;

class Program
{
    static void Main(string[] args)
    {
        HertzsprungRussell engine = new HertzsprungRussell();
        
        // Step 1: Initialize and Train ML Model
        engine.InitializeMLModel();
        
        // Step 2: Run the Classification logic (Manual Strategy + ML Fallback)
        engine.RunClassification();
        
        // Step 3: Access and display the results
        // You'll need to add a public getter or method in HertzsprungRussell 
        // to retrieve the _starCatalog.
    }
}