using System.ComponentModel;
using System.IO.Compression;

class Menu
{
    const string _menu = "Menu options:\n1: Create New Goal\n2: List Goals\n3: Save Goals\n4: Load Goals\n5: Record Event\n6: Quit\nSelect a choice from the menu: ";

    const string _menu2 = "These types of Goals are:\n1: Simple Goal\n2:Eternal Goal\n3:Checklist Goal\nWhich type of goal would you like to create?";

    readonly List<string> _goalQuestions = new List<string>()
    {
        "What is the name of your goal?",
        "What is a short description of your goal?",
        "What is the amount of points associated with this goal?",
        "How many times does this goal need ot be accomplished for a bonus?",
        "What is the bonus for accomplishing this goal that many times?"
    };
    const string _errorMessage = "Oops! I didn't recognize that input. Please make sure you are selecting one of the available options.";

    

    int _userInput = -5;

    GoalManager goalM = new GoalManager();

    public void Display()
    {
        Console.WriteLine($"Total score: {goalM.getTotalScore()}\n");
        
        Console.WriteLine($"{_menu}");
    }

    public void DisplayRubric()
    {
        //For speed, I had AI generate the Task difficulty rubric and copied and pasted it.
                        Console.WriteLine("---  TASK DIFFICULTY RUBRIC ---");
                        Console.WriteLine("{0,-5} {1,-20} {2}", "Level", "Complexity", "Description of Effort & Requirements");
                        Console.WriteLine(new string('-', 90));
                        Console.WriteLine("1     Trivial             No mental effort. Routine 'autopilot' tasks.");
                        Console.WriteLine("2     Very Simple         Requires 1-2 steps. No specialized knowledge needed.");
                        Console.WriteLine("3     Simple              Straightforward but requires active participation.");
                        Console.WriteLine("4     Below Average       Minor problem solving required; multi-step process.");
                        Console.WriteLine("5     Average             Standard task; requires focus and basic competence.");
                        Console.WriteLine("6     Moderate            Requires moderate skill and troubleshooting.");
                        Console.WriteLine("7     Challenging         Complex tasks; requires planning and research.");
                        Console.WriteLine("8     Technical           High complexity; requires specialized skills/deep thought.");
                        Console.WriteLine("9     Very Difficult      Major project milestones; high stakes or high effort.");
                        Console.WriteLine("10    Mastery Level       Peak performance required; significant cognitive demand.");
    }


    public int GetInput()
    {
        if (int.TryParse(Console.ReadLine(), out _userInput))
        {
            Console.Clear();
            return _userInput;
        }
        else
        {
            Console.Clear();
            Console.WriteLine(_errorMessage);
            return _userInput = -5;

            //Console.WriteLine($"{_errorMessage}");
        }

    }


    public int ReturnInputNum()
        {
            return _userInput;
        }

//"Menu options:\n1: Create New Goal\n2: List Goals\n3: Save Goals\n4: Load Goals\n5: Record Event\n6: Quit\nSelect a choice from the menu: ";


        public void CallActivity(int _userInput)
    {
        
        if (_userInput == 1)
        {
            Console.WriteLine("Create New Goal");
            Console.WriteLine(_menu2);
            int goalType = this.GetInput();
            if(goalType == 1)
            {
                int difficulty = 5;
                List<string> input = new List<string>();
                for(int l = 0; l < (_goalQuestions.Count() - 2); l++)
                {
                    if(l != 2)
                    {
                        Console.WriteLine(_goalQuestions[l]);
                        input.Add(Console.ReadLine());
                    }
                    else
                    {
                        
                        this.DisplayRubric();
                        Console.WriteLine("What level of difficulty is your task (1-10)?");
                        difficulty = int.Parse(Console.ReadLine());
                    }
                }
                int predicted = CalculateSuggestedPoints.GetSuggestion("SimpleGoal", difficulty);
                Console.WriteLine($"This is the suggested point value: {predicted}\nDo you want to use it? (Y/N)");
                string useSuggestion = Console.ReadLine().ToLower();
                if(useSuggestion == "y")
                {
                    input.Add(predicted.ToString());
                }
                else
                {
                    Console.WriteLine(_goalQuestions[2]);
                    input.Add(Console.ReadLine());
                }


                
                SimpleGoal newGoal = new SimpleGoal(input[0], input[1], int.Parse(input[2]));
                goalM.AddGoal(newGoal);
            }
            else if(goalType == 2)
            {
                int difficulty = 5;
                List<string> input = new List<string>();
                for(int l = 0; l < (_goalQuestions.Count() - 2); l++)
                {
                    if(l != 2)
                    {
                        Console.WriteLine(_goalQuestions[l]);
                        input.Add(Console.ReadLine());
                    }
                    else
                    {
                        
                        this.DisplayRubric();
                        Console.WriteLine("What level of difficulty is your task (1-10)?");
                        difficulty = int.Parse(Console.ReadLine());
                    }
                }
                int predicted = CalculateSuggestedPoints.GetSuggestion("EternalGoal", difficulty);
                Console.WriteLine($"This is the suggested point value: {predicted}\nDo you want to use it? (Y/N)");
                string useSuggestion = Console.ReadLine().ToLower();
                if(useSuggestion == "y")
                {
                    input.Add(predicted.ToString());
                }
                else
                {
                    Console.WriteLine(_goalQuestions[2]);
                    input.Add(Console.ReadLine());
                }
                EternalGoal newGoal = new EternalGoal(input[0], input[1], int.Parse(input[2]));
                goalM.AddGoal(newGoal);
            }
            else if(goalType == 3)
            {
                int difficulty = 5;
                List<string> input = new List<string>();
                for(int l = 0; l < (_goalQuestions.Count()); l++)
                {
                    if(l != 2)
                    {
                        Console.WriteLine(_goalQuestions[l]);
                        input.Add(Console.ReadLine());
                    }
                    else
                    {
                        
                        this.DisplayRubric();
                        Console.WriteLine("What level of difficulty is your task (1-10)?");
                        difficulty = int.Parse(Console.ReadLine());
                    }
                }
                int predicted = CalculateSuggestedPoints.GetSuggestion("CheckListGoal", difficulty);
                Console.WriteLine($"This is the suggested point value: {predicted}\nDo you want to use it? (Y/N)");
                string useSuggestion = Console.ReadLine().ToLower();
                int FinalPoints;
                if(useSuggestion == "y")
                {
                    FinalPoints = predicted;
                    //input.Add(predicted.ToString());
                }
                else
                {
                    Console.WriteLine(_goalQuestions[2]);
                    FinalPoints = int.Parse(Console.ReadLine());
                    //input.Add(Console.ReadLine());
                }
                input.Insert(2, FinalPoints.ToString());
                CheckListGoals newGoal = new CheckListGoals(input[0], input[1], int.Parse(input[2]), int.Parse(input[3]), int.Parse(input[4]));
                goalM.AddGoal(newGoal);
            }
            else
            {
                Console.WriteLine(_errorMessage);
            }
            
        }
        else if (_userInput == 2)
        {
            Console.WriteLine("List Goals");
            goalM.ListGoals();
            
        }
        else if (_userInput == 3)
        {
            Console.WriteLine("Save Goals");
            goalM.SaveFile();
            

        }
        else if (_userInput == 4)
        {
            Console.WriteLine("Load Goals");
            goalM.LoadFile();
            
        }
        else if (_userInput == 5)
        {
            Console.WriteLine($"Record Event");
            goalM.RecordGoalEvent(this.GetInput());

        }
        else if (_userInput == 6)
        {
            Console.WriteLine($"Quit");

        }
        else if (_userInput < 0)
        {
            Console.WriteLine($"_errorMessage");
            //Console.WriteLine($"{_startMenu}");

        }
    }

}