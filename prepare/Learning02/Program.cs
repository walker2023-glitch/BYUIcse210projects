using System;
using System.Runtime.InteropServices; // Note: This using directive is not strictly needed for this code.


class Program
{

    // The main entry point for the Resume Builder application.
    // This method initializes sample job data and then handles user input to build a resume.
    
    static void Main(string[] args)
    {
        /*
         * Section 1: Initialization of Sample Job Objects (for testing purposes)
         * These objects are created and populated directly in code.
         */
        Jobs job1 = new Jobs();
        job1._company = "Microsoft";
        job1._jobTitle = "Manager";
        job1._startYear = 2018;
        job1._endYear = 2027; // Future end date
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

        // The following lines are commented out, but show examples of calling Job methods.
        //job1.Display();
        //job1.DisplayAll();
        //Console.WriteLine($"{job1.CurrentWorkThere(2025)}");
        //Console.WriteLine($"{job1.MoneyMade(2025)}");

        /*
         * Section 2: User Input and Resume Construction
         * Prompts the user for personal and job details to dynamically build the resume.
         */
        Resume Resume1 = new Resume();

        // Starts the user input process by greeting the user and requesting the name.
        Console.WriteLine("Welcome to Resume builder.");
        Console.WriteLine("First, we need your name. What is your name?");
        Resume1._name = Console.ReadLine();

        // Prompts the user for the total number of jobs to enter.
        Console.WriteLine($"Awesome, {Resume1._name}, how many jobs have you had?");
        string repeats = Console.ReadLine();

        int repeatNum = 0;
        // Attempts to parse the input into an integer to control the loop.
        if (int.TryParse(repeats, out repeatNum))
        {
            /*
             * Loop to collect details for each job.
             * Iterates from 0 up to (number of jobs - 1).
             */
            for (int i = 0; i <= repeatNum - 1; i++)
            {
                Jobs newJob = new Jobs();
                int num = i + 1;
                Console.WriteLine($"Entering Job #: {num}");

                // Collects Company Name
                Console.WriteLine($"Enter Job Company: ");
                newJob._company = Console.ReadLine();

                // Collects Job Title
                Console.WriteLine($"Enter Job Title: ");
                newJob._jobTitle = Console.ReadLine();

                // Collects and parses Start Year
                Console.WriteLine("Enter Start Year: ");
                if (int.TryParse(Console.ReadLine(), out int startYear))
                {
                    newJob._startYear = startYear;
                }

                // Collects and parses End Year
                Console.WriteLine("Enter End Year: ");
                if (int.TryParse(Console.ReadLine(), out int endYear))
                {
                    newJob._endYear = endYear;
                }

                // Collects Internship status (Y/N)
                Console.WriteLine("Was it an internship?: Y/N");
                // NOTE: This logic reads from Console.ReadLine() multiple times, which may skip prompts.
                string internshipInput = Console.ReadLine();
                if (internshipInput == "Y" || internshipInput == "Yes")
                {
                    newJob._internship = true;
                }
                else // Assuming 'N' or any other input is No/False.
                {
                    newJob._internship = false;
                }

                // Collects and parses Wage (currently parsing as int, consider using double/decimal for wages)
                Console.WriteLine("Enter wage for the year: ");
                if (int.TryParse(Console.ReadLine(), out int wage))
                {
                    newJob._wage = wage;
                }

                // Collects Schedule Type (Full-time/Part-time)
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
                    // No default handling if input is not 1 or 2.
                }

                // Adds the fully populated new Job object to the Resume's list.
                Resume1._jobs.Add(newJob);
            }
        }
        else
        {
            // Error handling for invalid number of jobs input.
            Console.WriteLine("Incorrect Input. Please try again.");
        }

        // Adds the two manually created jobs (job1 and job2) to the resume.
        // NOTE: These lines were previously commented out, but are added here for completeness.
        // Resume1._jobs.Add(job1);
        // Resume1._jobs.Add(job2);

        // Displays the entire resume, which calls the Display method for each job.
        Resume1.Display();
    }
}