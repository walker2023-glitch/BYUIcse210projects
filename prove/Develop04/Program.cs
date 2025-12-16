using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        //const string Menu = "Menu options:\n1: Start breathing activity\n2: Start reflecting activity\n3: Start listing activity\n4:Start rethinking activity\n5: Quit\nSelect a choice from the menu: ";
        
        //Console.WriteLine($"{Menu}");

        // Activity Breathing = new Activity(1.5, "Breathing", "Helps breath", "you did it", "An activity that helps you learn how to breathe");
        // Breathing.Display();
        Menu menu1 = new Menu();
        
        //menu1.Display();

        // Breathing test = new Breathing(20, "Bob", "Bob");

        // test.breathe();

        do
        {
            menu1.Display();
            //Console.Clear();
            menu1.CallActivity(menu1.GetInput());
        }
        while (menu1.ReturnInputNum() != 5);
    }
}