using System;
using System.Collections.Generic; 
using System.Linq;
using System.Runtime.CompilerServices;

class Reflecting :Activity
{
    // This is the correct, working C# code for initializing lists.
List<string> prompt = new List<string>
{
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."
};

List<string> ponder = new List<string>
{
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"
};

Random ran = new Random();
//Random numPonder = new Random;



    public Reflecting(double t, string name, string d) :base(t, name, d)
    {
        
    }

    public bool reflect()
    {
        int numPrompt = ran.Next(0, prompt.Count);
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(this._timeLimit + 6);

        Console.WriteLine("\nConsider the following prompt\n");
        Console.WriteLine($"--- {prompt[numPrompt]} ---");
        Console.WriteLine("When you have something in mind, press enter to continue.\n");
        string enter = Console.ReadLine();
        if(string.IsNullOrEmpty(enter))
        {
            
            Console.WriteLine("Now Ponder on each of the following questions as they relate to this experience");
            Console.WriteLine($"You may begin in:"); 
            for(int i = 0; i < 5; i++){
                //Console.WriteLine($"You may begin in: {i}"); 
                Console.Write(i);
                Thread.Sleep(1050);
                Console.Write("\b \b");
            }
            while(DateTime.Now < futureTime)
            {
            
            int numPonder = ran.Next(0, ponder.Count);
            Console.WriteLine($"{ponder[numPonder]}");
            List<string> load = [$"|",  $"/", "*", $"\\",];
            for(int i = 0; i < 4; i++){
                Console.Write(load[i]);
                Thread.Sleep(2000);
                Console.Write("\b \b");
                
            }
            
            }
        return true;
           
        }
        else
        {
            Console.WriteLine("wrong input. Please only press enter");
            return false;
        }
        
    }

} 