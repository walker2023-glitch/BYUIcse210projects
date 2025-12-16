class Listing :Activity
{
    private readonly List<string> positiveQ = new List<string>
{
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
};
    Random ran = new Random();
    public Listing(double t, string name, string d) : base(t, name, d)
    {
        
    }

    public void listTheGood()
    {
        int numPrompt = ran.Next(0, positiveQ.Count);
        Console.WriteLine($"--- {positiveQ[numPrompt]} ---");
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(this._timeLimit + 6);
        int count = 1;
        do
        {
            
            Console.WriteLine($"{count}: ");
            List<string> entry = new List<string>()
            {
                
            };
            string Textentry = Console.ReadLine();
            entry.Add(Textentry);
            count++;
        }
        while(DateTime.Now < futureTime);
        Console.Clear();
        Console.WriteLine($"You wrote {count} entires");
    }
}