using System;
using System.Formats.Asn1;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Assignment A1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine($"{A1.GetSummary()}");


        MathA math1 = new MathA("Bob", "Number Line", "Algera", "page 221 odd");
        Console.WriteLine($"{math1.GetSummary()}");
        Console.WriteLine($"{math1.GetHomeWorkList()}");
        WritingA write1 = new WritingA("Billy", "Effects of staying up late", "Staying up vs going to bed");
        Console.WriteLine($"{write1.GetSummary()}");
        Console.WriteLine($"{write1.GetWritingInformation()}");
   
   
   
    }
}