using System.ComponentModel;
using System.IO.Compression;

class Menu
{
    const string _menu = "Menu options:\n1: Start breathing activity\n2: Start reflecting activity\n3: Start listing activity\n4: Start rethinking activity\n5: Quit\nSelect a choice from the menu: ";


    const string _errorMessage = "Oops! I didn't recognize that input. Please make sure you are selecting one of the available options.";

    int _userInput = -5;
    Breathing breathA = new Breathing(45, "Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

    Reflecting reflectA = new Reflecting(60, "Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

    Listing ListA = new Listing(30, "Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    
    Rethink RethinkA = new Rethink(50, "Rethink Activity", "This activity will help you transform negative thoughts into positive action statements, recognizing your agency and power.");
    public void Display()
    {
        Console.WriteLine($"{_menu}");
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


        public void CallActivity(int _userInput)
    {
        
        if (_userInput == 1)
        {
            Console.WriteLine("Breathing");
            breathA.StartActivity();
            breathA.SetTime(this.GetInput());
            breathA.Prepare();
            breathA.breathe();
            breathA.End();
            breathA.EndActivity();
        }
        else if (_userInput == 2)
        {
            Console.WriteLine("reflecting");
            reflectA.StartActivity();
            reflectA.SetTime(this.GetInput());
            reflectA.Prepare();
            do{reflectA.reflect();}
            while(reflectA.reflect());
            reflectA.End();
            reflectA.EndActivity();
            
        }
        else if (_userInput == 3)
        {
            Console.WriteLine("Listing");
            ListA.StartActivity();
            ListA.SetTime(this.GetInput());
            ListA.Prepare();
            ListA.listTheGood();
            ListA.End();
            ListA.EndActivity();

        }
        else if (_userInput == 4)
        {
            Console.WriteLine("Rethinking");
            RethinkA.StartActivity();
            RethinkA.SetTime(this.GetInput());
            RethinkA.Prepare();
            RethinkA.rethinking();
            RethinkA.End();
            RethinkA.EndActivity();
        }
        else if (_userInput == 5)
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