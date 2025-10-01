using System;
using System.Runtime.InteropServices;


class Program
{
    static void Main(string[] args)
    {
        Jobs job1 = new Jobs();
        job1._company = "Microsoft";
        job1._jobTitle = "Manager";
        job1._startYear = 2018;
        job1._endYear = 2027;
        job1._internship = false;
        job1._wage = 20.5;
        job1._scheduleType = "Fulltime";


        Jobs job2 = new Jobs();
        job2._company = "Amazon";
        job2._jobTitle = "begginning web design";
        job2._startYear = 2015;
        job2._endYear = 2018;
        job2._internship = true;
        job2._wage = 14.5;
        job2._scheduleType = "Fulltime";

        //job1.Display();
        //job1.DisplayAll();
        //Console.WriteLine($"{job1.CurrentWorkThere(2025)}");
        //Console.WriteLine($"{job1.MoneyMade(2025)}");

        //Created a new Resume object
        Resume Resume1 = new Resume();
        //Starts the user input section
        Console.WriteLine("Welcome to Resume builder.");
        Console.WriteLine("First, we need your name. What is your name?");
        Resume1._name = Console.ReadLine();
        Console.WriteLine($"Awesome, {Resume1._name}, how many jobs have you had?");
        string repeats = Console.ReadLine();
        int repeatNum = 0;
        if (int.TryParse(repeats, out repeatNum))
        {
            for (int i = 0; i <= repeatNum - 1; i++)
            {
                Jobs newJob = new Jobs();
                int num = i + 1;
                Console.WriteLine($"Entering Job #: {num}");
                Console.WriteLine($"Enter Job Company: ");
                newJob._company = Console.ReadLine();
                Console.WriteLine($"Enter Job Title: ");
                newJob._jobTitle = Console.ReadLine();
                //suggested by AI
                Console.WriteLine("Enter Start Year: ");
                if (int.TryParse(Console.ReadLine(), out int startYear))
                {
                    newJob._startYear = startYear;
                }
                Console.WriteLine("Enter End Year: ");
                if (int.TryParse(Console.ReadLine(), out int endYear))
                {
                    newJob._endYear = endYear;
                }
                Console.WriteLine("Was it an internship?: Y/N");
                if (Console.ReadLine() == "Y" || Console.ReadLine() == "Yes")
                {
                    newJob._internship = true;
                }
                else if (Console.ReadLine() == "N" || Console.ReadLine() == "No")
                {
                    newJob._internship = false;
                }
                Console.WriteLine("Enter wage for the year: ");
                if (int.TryParse(Console.ReadLine(), out int wage))
                {
                    newJob._wage = wage;
                }
                Console.WriteLine("Did you work full time or part time?");
                Console.WriteLine("1: Full-time");
                Console.WriteLine("2: part-time");
                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    if (input == 1)
                    {
                        newJob._scheduleType = "Full-time";
                    }
                    else if (input == 2)
                    {
                        newJob._scheduleType = "part-time";
                    }
                }
                Resume1._jobs.Add(newJob);
                /*
                
                job2._wage = 14.5;
                job2._scheduleType = "Fulltime";*/
            }
        }
        else
        {
            Console.WriteLine("Incorrect Input. Please try again.");
         }
        //Resume1._jobs.Add(job1);
        //Resume1._jobs.Add(job2);
        //Console.WriteLine($"{Resume1._jobs[0]._jobTitle}");
        Resume1.Display();
    }
}