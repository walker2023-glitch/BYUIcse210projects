using System;

class Program
{
    static void Main(string[] args)
    {
        Menu newMenu = new Menu();
        
        newMenu.Display();
        //newMenu.GetInput();
        newMenu.CallJournal(newMenu.GetInput());
        while(newMenu.GetInput() != 5)
        {
            newMenu.Display();
            newMenu.CallJournal(newMenu.GetInput());
            newMenu.Display();
        }
        
    }
}