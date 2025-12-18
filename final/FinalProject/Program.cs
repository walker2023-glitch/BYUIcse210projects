using System;

class Program
{
    // FinalProject/Program.cs
static void Main(string[] args)
{
    HertzsprungRussell engine = new HertzsprungRussell();
    engine.InitializeMLModel();
    engine.RunClassification();

    // ADD THIS LINE to see the results
    engine.PrintCatalogReport(); 
}
}