
using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using Humanizer;

public class Program
{
    public static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");
        /*
    Start by asking the user for the magic number. 
    (In future steps, we will change this to have the computer generate a random number, 
    but to get started, we'll just let the user decide what it is.)

    Ask the user for a guess.

    Using an if statement, 
    determine if the user needs to guess higher or lower next time,
     or tell them if they guessed it.

    At this point, you won't have any loops.

    The following shows the expected output at this point:

        */

        /*
        Add a loop that keeps looping as long as the guess does not match the magic number.

    At this point, the user should be able to keep playing until they get the correct answer.
        */

        /*
            Instead of having the user supply the magic number, generate a random number from 1 to 100.

    Play the game and make sure it works!
        */

        /*
        Keep track of how many guesses the user has made and inform them of it at the end of the game.

        After the game is over, ask the user if they want to play again. Then, loop back and play the whole game again and continue this loop as long as they keep saying "yes".
        */
        Console.WriteLine("What is the lowest number in the range you want the random number to be generated in?");
        string Num1S = Console.ReadLine();
        Console.WriteLine("What is the highest number in the range you want the random number to be generated in?");
        string Num2S = Console.ReadLine();
        
        //TryParse
        //At first, I was just going to use the Parse command, but after using AI to learn more about the Parse command
        //it showed me this TryParse command which inspired me to try to use it.
        //Basically, it will try to try the Num variable into a integer.
        //If it can't, it will return a false statement. 
        
        
        string numGS = "";


        int numG = -1;
        int Num1 = 0;
        int Num2 = 100;
        int guessNum = 0;

        if (int.TryParse(Num1S, out Num1) && int.TryParse(Num2S, out Num2))
        {
            Random randomGenerator = new Random();
            int numA = randomGenerator.Next(Num1, Num2);
            do
            {
                guessNum++;
                //asks user to guess what the number is
                Console.WriteLine("What do you think the magic number is?");
                numGS = Console.ReadLine();
                //another TryParse. If it can't turn the number into a string, it asks to the user to try to input it again. 
                //AI helped me see not to do out int numG but just out numG
                if (int.TryParse(numGS, out numG))
                {
                    if (numG > numA)
                    {
                        //tells user their guess is higher than the real number
                        Console.WriteLine("Your guess is higher than the real number");
                    }
                    else if (numG < numA)
                    {
                        //tells user their guess is lower than the real number
                        Console.WriteLine("Your guess is lower than the real number");
                    }
                }
                else
                {
                    /*if (numG.TryParseNumber<int>(out int result))
                    {
                        Console.WriteLine("Success");
                    }
                    else
                    {
                        //tells the user to enter a number
                        Console.WriteLine("Error, not a valid input, please input a number.");
                    }*/
                }
            } while (numG != numA);
            Console.WriteLine($"Congrates! It took you {guessNum} time(s) to guess the number.");
        }
        else
        {
            /*if (numGS.TryParseNumber<int>(out int result))
            {
                Console.WriteLine("Success");
            }*/
            //tells the user to enter a number
            Console.WriteLine("Error, not a valid input, please input a number.");
        }
        
    }
}