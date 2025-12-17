using System;
using System.Collections.Generic;
using System.IO;

class GoalManager
{
    private List<CheckListGoals> wholeGoals = new List<CheckListGoals>();
    private int _totalScore;

    public GoalManager()
    {
        _totalScore = 0;
    }

    public int getTotalScore()
    {
        return _totalScore;
    }

    public void AddGoal(CheckListGoals goal)
    {
        wholeGoals.Add(goal);
    }

    public void RecordGoalEvent(int index)
    {
        CheckListGoals goal = wholeGoals[index -1];

        int pointsEarned = goal.RecordEvent();
        _totalScore += pointsEarned;

        Console.WriteLine($"Congratulations! You earned {pointsEarned} points!");
        Console.WriteLine($"You now have {_totalScore} points.");   
    }

    public void ListGoals()
    {
        Console.Clear();
        Console.WriteLine("The goals are: ");
        for(int i = 0; i < wholeGoals.Count(); i++)
        {
            Console.WriteLine($"{i + 1} {wholeGoals[i].GetDisplayString()}");
        }   
    }


    public void SaveFile()
    {
        Console.WriteLine("What do you want to name the file? (I will add .txt automatically)");
        string input = Console.ReadLine();
        string filename = input += ".txt";
        Console.WriteLine($"Saving to the {filename} File");
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_totalScore);
            foreach(CheckListGoals g in wholeGoals)
            {
                outputFile.WriteLine(g.GetSaveData());
            }
            
        }
    }

    public void LoadFile()
    {
        Console.WriteLine("Which file do you want to read from? (.txt is automatically added)");
        string input = Console.ReadLine();
        string filename = input += ".txt";
        Console.WriteLine($"Retrieving from the {filename} File");

        string[] read = System.IO.File.ReadAllLines(filename);
        
        
        List<CheckListGoals> result = new List<CheckListGoals>();
        _totalScore = int.Parse(read[0]);
        wholeGoals.Clear();
        for (int i = 1; i < read.Length; i++)
        {
            string line = read[i];
            string[] mainparts = line.Split(":");
            string type = mainparts[0];
            string data = mainparts[1];
            
            string[] parts = data.Split("+=+", StringSplitOptions.None);

            if(type == "SimpleGoal")
            {
                wholeGoals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if(type == "EternalGoal")
            {
                wholeGoals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if(type == "ChecklistGoal")
            {
                wholeGoals.Add(new CheckListGoals(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[6]), int.Parse(parts[4])));
            }            

            
            
    }


    }
}