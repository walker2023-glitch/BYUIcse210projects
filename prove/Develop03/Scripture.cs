using System.Collections;
using System.Data;
using System.Linq;

class Scripture
{
    private List<Word> _verse;
    private int _repeat = 7;
    private Reference _reference;
    Random randomGenerator = new Random();

    //I don't feel reference is enough to be it's own class
    //And I researched and found I can nest classes within each other, so that's what I'm doing.

    public class Reference
    {
        string _book;
        int _chapter;
        int _sverse;
        int _everse;

        public Reference()
        {
            _book = "John";
            _chapter = 11;
            _sverse = 35;
        }


        public Reference(string BookName, int chap, int StartVerse)
        {
            _book = BookName;
            _chapter = chap;
            _sverse = StartVerse;
        }

        public Reference(string BookName, int chap, int StartVerse, int EndVerse)
        {
            _book = BookName;
            _chapter = chap;
            _sverse = StartVerse;
            _everse = EndVerse;
        } 
        public string GetReference()
        {
            string StV = _sverse.ToString();

            if (_everse != 0)
            {
                string EV = _sverse.ToString();
                return $"{_book} {_chapter} :{_sverse}-{_everse}";
            }
            else
            {
                return $"{_book} {_chapter} :{_sverse}";
            }


            
        }
    }


    public Scripture()
    {
        //_verse = ["Jesus", "wept"];
        this._reference = new Reference("John", 11, 35);
        
        _verse = new();
        Word word1 = new Word("Jesus");
        Word space = new Word(" ");
        Word word2 = new Word("Wept.");
        Word word3 = new Word("And ");
        Word word4 = new Word("It ");
        Word word5 = new Word("was ");
        Word word6 = new Word("sad.");
        _verse.Add(word1);
        _verse.Add(space);
        _verse.Add(word2);
        _verse.Add(word3);
        _verse.Add(word4);
        _verse.Add(word5);
        _verse.Add(word6);

    }
    
      public Scripture(string BookName, int chapter, int StartVerse, int EndVerse, string _start)
    {
        this._reference = new Reference(BookName, chapter, StartVerse, EndVerse);
        string scriptureInput = _start;
        List<string> aList = _start.Split(' ').ToList();
        _verse = new();
        foreach (string word in aList)
        {
            Word verse = new Word(word);
            _verse.Add(verse);
        }
        
    }


    public Scripture(List<Word> _w)
    {
    
        _verse = _w;
        
    }

    public void Display()
    {
        /*
        Edit eventually to add that you put in a string, then get a list.
        */
        string fullReferenceText = _reference.GetReference();
        Console.Write($"{fullReferenceText}" + " ");
        for(int w = 0; w < _verse.Count(); w++)
        {
            
            Console.Write($"{_verse[w].GetText()}" + " ");
        }
        
    }

    public void GetVerse(List<Word> v)
    {
        _verse = v;
    }


    public void HideWords()
    {
        // this.Display();
        for (int i = 0; i < _repeat; i++)
        {

            int RandomNum = randomGenerator.Next(0, (_verse.Count()));
            this._verse[RandomNum].Hide();
            //return this._verse;
            // Console.Clear();
            // this._verse[i].Display();

        }
        string fullReferenceText = _reference.GetReference();
        Console.Write($"{fullReferenceText}" + " ");
        for (int b = 0; b < _verse.Count(); b++)
        {
                
                this._verse[b].Display();
                
            }
        // this.Display();
        //return this._verse;
    }

    public string GetText()
    {
        
        // for(int w = 0; w < _verse.Count(); w++)
        // {
        //     return _verse[w].GetText();
        // };

        return "";
    }

    public bool TotalHidden()
    {

        // bool AllWords = false;
        // for (int w = 0; w < _verse.Count(); w++)
        // {

        //     List<bool> Stat = new List<bool> { };
        //     Stat.Add(_verse[w].IsHidden());
        //     AllWords = Stat.All(status => status == true);

        // }

        // return AllWords;


        //I was confused on this part, so I had AI help me. I found this ALL method and learned about it. 
        bool allAreVisible = _verse.All(word => word.IsHidden() == false);
        return allAreVisible;
       
    }
}