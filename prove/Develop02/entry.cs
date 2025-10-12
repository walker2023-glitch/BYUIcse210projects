
using System.Runtime.CompilerServices;

class Entry
{
    DateTime _timeNow = DateTime.Now;
    Random _generator = new Random();



    readonly List<string> _lPrompt = ["Who was the most interesting person I interacted with today?",
"What was the best part of my day?",
"How did I see the hand of the Lord in my life today?",
"What was the strongest emotion I felt today?",
"If I had one thing I could do over today, what would it be?",
"Describe a specific conversation you had today that changed your perspective.",
"If you could magically solve one problem facing the world, which one would it be and why?",
"What steps did I take today toward achieving a long-term goal, and how did they feel?",
"Detail a difficult decision I had to make today and what led me to my choice.",
"What is a new thought or idea that I spent a significant amount of time considering today?"];
    
  


    readonly List<string> _sPrompt = [  "What is one thing I learned today?",
    "What challenge did I overcome today, big or small?",
"Did I accomplish the most important thing I set out to do? Why or why not?",
"What small act of kindness did I either give or receive today?",
"How did my actions today align with my goals?",
"List three things I am genuinely grateful for right now.",
"What movie, book, or piece of music did I enjoy today?",
"What skill or habit did I practice for at least 10 minutes today?",
"What is one thing I need to remember for tomorrow?",
"Where did I spend the most unnecessary time today? (Be specific.)"];
    public string _reponse = "";

    public string _fullAnswer = "";
    //

    public void Display()
    {
        

        string NowDate = _timeNow.ToLongDateString();
        string NowTime = _timeNow.ToString("h:mm:ss tt");
        Console.WriteLine($"Date: {NowDate}, {NowTime}\n ");
        _fullAnswer += ($"Date: {NowDate}, {NowTime}\n ");
    }

    public void DisplayLP()
    {
        int Random = _generator.Next(0, _lPrompt.Count);

        string NowDate = _timeNow.ToLongDateString();
        string NowTime = _timeNow.ToString("h:mm:ss tt");
        Console.WriteLine($"Date: {NowDate}, {NowTime} - Prompt: {_lPrompt[Random]}\n ");
        _fullAnswer += ($"Date: {NowDate}, {NowTime} - Prompt: {_lPrompt[Random]}\n ");
    }
    
    public void DisplaySP()
    {
        int Random = _generator.Next(0, _sPrompt.Count);

        string NowDate = _timeNow.ToLongDateString();
        string NowTime = _timeNow.ToString("h:mm:ss tt");
        Console.WriteLine($"Date: {NowDate}, {NowTime} - Prompt: {_sPrompt[Random]}\n ");
        _fullAnswer += ($"Date: {NowDate}, {NowTime} - Prompt: {_sPrompt[Random]}\n ");
    }

    public string WriteEntry()
    {
        _reponse = Console.ReadLine();
        //_fullAnswer += _response;
        return _reponse;
        
    }

    public string SendAll()
    {
        //_fullAnswer += ($"{_response}");
        return _fullAnswer;
    }



}


