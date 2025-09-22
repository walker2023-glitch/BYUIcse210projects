using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine($"Your name is {last}, {first} {last}");

        /*Part 2 */

        /* A >= 90
        B >= 80
        C >= 70
        D >= 60
        F < 60

        Ask the user for their grade percentage, 
        then write a series of if-elif-else statements to print out the appropriate letter grade. 
        (At this point, you'll have a separate print statement for each grade letter in the appropriate block.)

        Assume that you must have at least a 70 to pass the class. 
        After determining the letter grade and printing it out. 
        Add a separate if statement to determine if the user passed the course, 
        and if so display a message to congratulate them. 
        If not, display a different message to encourage them for next time.

        Change your code from the first part, 
        so that instead of printing the letter grade in the body of each if, elif, or else block,
         instead create a new variable called letter and then in each block, 
         set this variable to the appropriate value. Finally, after the whole series of if-elif-else statements, 
         have a single print statement that prints the letter grade once.
        */
        int theGradeA = 90;
        int theGradeB = 80;
        int theGradeC = 70;
        int theGradeD = 60;

        Console.Write("");
        Console.Write($"{first}, what is your grade? ");

        string theAnswer1 = Console.ReadLine();
        int theAnswer2 = int.Parse(theAnswer1);

        string letter = "";

        if (theAnswer2 < theGradeD)
        {
            letter = "F";
            //Console.WriteLine($"Sorry {first}, you got an F");
            //Console.WriteLine($"That means you failed this course, better luck next time.");
        }
        else if (theAnswer2 >= theGradeD && theAnswer2 < theGradeC)
        {
            letter = "D";
            //Console.WriteLine($"Sorry {first}, you got an D");
            //Console.WriteLine($"That means you failed this class, better luck next time.");
        }
        else if (theAnswer2 >= theGradeC && theAnswer2 < theGradeB)
        {
            letter = "C";
            //Console.WriteLine($"Good job {first}! You got an C");
            //Console.WriteLine($"C's get degrees");
        }
        else if (theAnswer2 >= theGradeB && theAnswer2 < theGradeA)
        {
            letter = "B";
            //Console.WriteLine($"Amazing {first}, you got an B");
            //Console.WriteLine($"B's are even better than C's");
        }
        else if (theAnswer2 >= theGradeA)
        {
            letter = "A";
            //Console.WriteLine($"Wow {first}, you got an A");
            //Console.WriteLine($"A's are simply awesome.");
        }

        Console.WriteLine($"Hello {first}, you got an {letter}");
        /*

        Stretch 
        Add to your code the ability to include a "+" or "-" next to the letter grade, such as B+ or A-. 
        For each grade, you'll know it is a "+" if the last digit is >= 7. 
        You'll know it is a minus if the last digit is < 3 and otherwise it has no sign.

        After your logic to determine the grade letter, 
        add another section to determine the sign. Save this sign into a variable. 
        Then, display both the grade letter and the sign in one print statement.

        Hint: To get the last digit, you could divide the number by 10, 
        and get the remainder. You might review the standard math operators and 
        find the one that does division and gives you the remainder.

        At this point, don't worry about the exceptional cases of A+, F+, or F-.

        Recognize that there is no A+ grade, only A and A-. 
        Add some additional logic to your program to detect this case and handle it correctly.

        Similarly, recognize that there is no F+ or F- grades, only F.
         Add additional logic to your program to detect these cases and handle them correctly.
        */

    }
}