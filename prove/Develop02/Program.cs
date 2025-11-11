using System;



class Program
{
    static void Main(string[] args)
    {
        
        
        Menu newMenu = new Menu();

        // newMenu.StartDisplay();
        // //newMenu.GetInput();
        // newMenu.CallJournal(newMenu.GetInput());
        do
        {
            newMenu.Display();
            // Console.Clear();
            newMenu.CallJournal(newMenu.GetInput());

            // newMenu.Display();
        }
        while (newMenu.ReturnInputNum() != 5);
        

    }
}