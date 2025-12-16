using System.Diagnostics;
using System.Reflection.Metadata;

class Rethink : Activity
{
    private string positiveStatement;
    private string negativeStatement;
    

    public Rethink(double t, string name, string d) :base(t, name, d)
    {
        
    }


    //These 2 functions, I needed to ask AI for help to write
    public bool CheckIfMorePositive(string statement1, string statement2)
    {
        List<string> positiveWords = new List<string> {"can", "will", "able", "growth", "better", "choose", "improve", "success", "successful"};
        List<string> negativeWords = new List<string> {"can't", "won't", "fail", "never", "shouldn't", "impossible", "worst"};
   
        int score1 = CalculateScore(statement1, positiveWords, negativeWords);
        int score2 = CalculateScore(statement2, positiveWords, negativeWords);
   
        return score2 > (score1 + 1);
    }

    public int CalculateScore(string statement, List<string> posWords, List<string> negWords)
    {
        int score = 0;
        string[] words = statement.ToLower().Split(new char[] {' ', '.', ',', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);
    
        foreach (string word in words)
        {
            if (posWords.Contains(word))
            {
                score += 2;
            }
            if (negWords.Contains(word))
            {
                score -= 3;
            }
        }
        return score;


    }


    public void rethinking()
    {
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(this._timeLimit + 6);
        while(DateTime.Now < futureTime)
        {
            bool validationPassed = false;
            Console.WriteLine("Write a fairly negative statement about life:\n");
            negativeStatement = Console.ReadLine();
            do
            {
                //validationPassed = false;
                if(validationPassed == false)
                {
                    Console.WriteLine("Now rewrite that negative statement into something positive:\n");
                }
                
                positiveStatement = Console.ReadLine();
                
                if(this.CheckIfMorePositive(negativeStatement, positiveStatement))
                {
                    Console.WriteLine("Excellent! Your second statement is much more positive than the first statement.");
                    validationPassed = true;
                }
                else
                {
                    Console.WriteLine("Your positive statement still seems to hold some negativity. Rewrite your negative statement again but try to make it more positive.");
                    Console.WriteLine($"Old negative statement: {negativeStatement}");
                    
                }  
            } while (!validationPassed && DateTime.Now < futureTime);
                
                if(DateTime.Now >= futureTime)
            {
                break;
            }
            //while(this.CheckIfMorePositive(positiveStatement, negativeStatement));
        }
        
    }

}