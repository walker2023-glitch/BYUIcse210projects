using System;



class Program
{
    static void Main(string[] args)
    {
        
        
        Menu newMenu = new Menu();

        newMenu.StartDisplay();
        //newMenu.GetInput();
        newMenu.CallJournal(newMenu.GetInput());
        while (newMenu.GetInput() != 5)
        {
            newMenu.Display();
            // Console.Clear();
            newMenu.CallJournal(newMenu.GetInput());

            // newMenu.Display();
        }

    }
}