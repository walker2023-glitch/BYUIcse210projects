using System;
using System.Xml;

class Program
{
    // FinalProject/Program.cs
static void Main(string[] args)
{
    HertzsprungRussell engine = new HertzsprungRussell();
    engine.InitializeMLModel();
    engine.RunClassification("testData.txt");
    engine.PrintCatalogReportToFile("OutputMethod.txt");
    // ADD THIS LINE to see the results
    //engine.PrintCatalogReport(); 
}
}