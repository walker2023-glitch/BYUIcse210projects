using System.Dynamic;

class Menu
{
    private const string _menu = "Press Enter to Continue or type quit to stop: ";
    private const string _quit = "quit";

    private string _input;


    //eventually add other input options, allow them to pick what scripture they want,
    //  (or if they want a poem)
    //pick the difficulty (how many words disappear)
    //eventually the option to go back and forth between making more words disappear or less
    public string GetInput()
    {
        Console.WriteLine("\n");
        this.DisplaySMenu();
        _input = Console.ReadLine();
        Console.Clear();
        return _input;
    }

    public void DisplaySMenu()
    {
        Console.WriteLine($"{_menu}");
    }





}