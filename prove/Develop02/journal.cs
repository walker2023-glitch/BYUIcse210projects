using System.Data.SqlTypes;

class Journal
{

    public void SendToFile(List<Entry> jes)
    {
        Console.WriteLine("What do you want to name the file? (I will add .txt automatically)");
        string input = Console.ReadLine();
        string filename = input += ".txt";
        Console.WriteLine($"Saving to the {filename} File");
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(Entry e in jes)
            {
                outputFile.WriteLine(e.SaveString());
            }
            
        }
    }
    
    public List<Entry> ReadFromFile()
    {
        Console.WriteLine("Which file do you want to read from? (.txt is automatically added)");
        string input = Console.ReadLine();
        string filename = input += ".txt";
        Console.WriteLine($"Retrieving from the {filename} File");

        //List<string> bob = new List<string>();
        string[] read = System.IO.File.ReadAllLines(filename);
        List<Entry> result = new List<Entry>();

        foreach(string line in read)
        {
            string[] parts = line.Split("+");
            Entry og6Entry = new Entry();
            og6Entry._timeNow = new DateTime(1); //Loaded entry, don't use current time. 
            og6Entry._dateTime = parts[0];
            og6Entry._spPrompt = parts[1];
            og6Entry._reponse = parts[2];
            result.Add(og6Entry);
        }

        return result;
    }

}



