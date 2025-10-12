using System.Data.SqlTypes;

class Journal
{





    public void SendToFile(string JE)
    {
        Console.WriteLine("What do you want to name the file?");
        string input = Console.ReadLine();
        string filename = input += ".txt";
        Console.WriteLine($"Saving to the {filename} File");
        using (StreamWriter outputFile = new StreamWriter(filename))
        {

            outputFile.WriteLine($"{JE}");
        }
    }
    
    public void ReadFromFile()
    {
        Console.WriteLine("Which file do you want to read from?");
        string input = Console.ReadLine();
        string filename = input += ".txt";
        Console.WriteLine($"Retrieving from the {filename} File");

        //List<string> bob = new List<string>();
        string read = System.IO.File.ReadAllText(filename);
        Console.WriteLine(read);
    }

}



