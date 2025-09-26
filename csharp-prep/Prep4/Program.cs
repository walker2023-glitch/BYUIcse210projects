using System;

class Program
{
    static void Main(string[] args)
    {
        /*
    Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0.

Once you have a list, have your program do the following:

Core Requirements
Work through these core requirements step-by-step to complete the program. Please don't skip ahead and do the whole thing at once, because others on your team may benefit from building the program up slowly.

Compute the sum, or total, of the numbers in the list.

Compute the average of the numbers in the list.

Find the maximum, or largest, number in the list.
        */

        List<int> numbers = new List<int>();
        const int STOPPER = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int inputReal = 2;
        do
        {
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out inputReal))
            {
                numbers.Add(inputReal);

            }
            else
            {
                Console.WriteLine("Your input is not a number, please try again");
            }
        } while (inputReal != STOPPER);

        //a for loop going through each value, then different equations for each thing
        //sum (use this for the average)
        //average = all the numbers added together / length function + 1
        //compare list[i] and list[i + 1]

        //get ride of the zero at the end
        numbers.RemoveAll(n => n == 0);
        foreach (int nums in numbers)
        {

            Console.WriteLine(nums);
        }

        //finds the sum of the data
        int sum = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
        }

        //finds the average
        double mean = ((float)sum) / numbers.Count;
        //finds the Max
        int max = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }


        //end of program reports the data
        Console.WriteLine($"The Sum is: {sum}");
        Console.WriteLine($"The average (mean) is: {mean}");
        Console.WriteLine($"The Max is: {max}");
    }
}