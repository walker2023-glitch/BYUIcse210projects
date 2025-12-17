using System;


class Program
{
    static void Main(string[] args)
    {
        //Console.OutputEncoding = System.Text.Encoding.UTF8;
        Menu menu = new Menu();
        //menu.Display();

        do
        {
            menu.Display();
            //Console.Clear();
            menu.CallActivity(menu.GetInput());
        }
        while (menu.ReturnInputNum() != 6);
    }
}