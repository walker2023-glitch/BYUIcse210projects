
class Activity
{
    protected double _timeLimit;
    protected string _name;

    protected string _description;

    public Activity(double t, string n, string d)
    {
        _timeLimit = t;
        _name = n;
        _description = d;
    }
    
    public void Display()
    {
        Console.WriteLine($"{_timeLimit} {_name}");
    }

    public void Prepare()
    {
        List<string> load = [$"|",  $"/", "*", $"\\",];
            Console.WriteLine("Prepare...");
            for(int i = 0; i < 4; i++){
                Console.Write(load[i]);
                Thread.Sleep(1500);
                Console.Write("\b \b");
                
            }
            Console.Clear();
    }

     public void End()
    {
        List<string> load = [$"|",  $"/", "*", $"\\",];
            Console.WriteLine("Good job!");
            for(int i = 0; i < 4; i++){
                Console.Write(load[i]);
                Thread.Sleep(1500);
                Console.Write("\b \b");
                
            }
            Console.Clear();
    }

    //can add vitrual if needed for polymorphism
    public void StartActivity()
    {
        Console.WriteLine($"Welcome to the {_name} Activity"  + "\n" + $"{_description}" + "\n" + "How long, in seconds, would you like this acivity to do this activity?");

    }
    
    public void EndActivity()
    {
        Console.WriteLine($"You have now completed {_timeLimit} seconds in the {_name} Activty");
        Thread.Sleep(1500);
        Console.Clear();
    }    

    public void SetTime(double t)
    {
        _timeLimit = t;
    }

    public double GetTime()
    {
        return _timeLimit;
    }



}










