using System.Diagnostics.CodeAnalysis;

public class Assignment
{

    //I used protect because it was suggested by AI
    //The idea is it is just like private but can be used
    //by child classes
    protected string _studentName;
    protected string _topic;

    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    public string GetSummary()
    {

        string sum = $"{_studentName}\n{_topic}";
        return sum;
    }
}

public class MathA : Assignment
{
    string _textbookSection;
    string _problems;

    public MathA(string name, string topic, string textbook, string problem)
    : base(name, topic)
    
    {
        // Assignment._studentName = name;
        // Assignment._topic = topic;
        _textbookSection = textbook;
        _problems = problem;

    }
    public string GetHomeWorkList()
    {
        string HomeworkList = $"{_textbookSection} {_problems}";
        return HomeworkList;
    }
}


public class WritingA : Assignment

{
     string _title;

    public WritingA(string name, string topic, string title)
    : base(name, topic)
    {
        // Assignment._studentName = name;
        // Assignment._topic = topic;
        _title = title;
        

    }
    public string GetWritingInformation()
    {
        string HomeworkList = $"{_studentName} {_topic}\n {_title}";
        return HomeworkList;
    }
}

