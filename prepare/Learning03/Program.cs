using System;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        //Fraction newFraction = new Fraction(); 

        Fraction Bob = new Fraction();
        Fraction Bob2 = new Fraction(5);
        Fraction Bob3 = new Fraction(1, 10);

        Console.WriteLine($"{Bob.GetTop()} {Bob.GetBottom()}");
        Console.WriteLine($"{Bob2.GetTop()} {Bob2.GetBottom()}");
        Console.WriteLine($"{Bob3.GetTop()} {Bob3.GetBottom()}");

        Console.WriteLine($"{Bob.GetFractionString()}");
        Console.WriteLine($"{Bob2.GetFractionString()}");
        Console.WriteLine($"{Bob3.GetFractionString()}");

        Console.WriteLine($"{Bob.GetDecimalValue()}");
        Console.WriteLine($"{Bob2.GetDecimalValue()}");
        Console.WriteLine($"{Bob3.GetDecimalValue()}");

        Bob.SetTop(52);
        Bob2.SetTop(102);
        Bob3.SetTop(74);

        Bob.SetBottom(20);
        Bob2.SetBottom(30);
        Bob3.SetBottom(50);

        Console.WriteLine($"{Bob.GetTop()} {Bob.GetBottom()}");
        Console.WriteLine($"{Bob2.GetTop()} {Bob2.GetBottom()}");
        Console.WriteLine($"{Bob3.GetTop()} {Bob3.GetBottom()}");
    
        Console.WriteLine($"{Bob.GetFractionString()}");
        Console.WriteLine($"{Bob2.GetFractionString()}");
        Console.WriteLine($"{Bob3.GetFractionString()}");


        Console.WriteLine($"{Bob.GetDecimalValue()}");
        Console.WriteLine($"{Bob2.GetDecimalValue()}");
        Console.WriteLine($"{Bob3.GetDecimalValue()}");
    
    }
}