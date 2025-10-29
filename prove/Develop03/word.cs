class Word
{
    private string _word;
    private bool _revealed;


    public Word(string w)
    {
        _word = w;
        _revealed = true;
    }

    public void Display()
    {

        if (_revealed)
        {
            Console.Write($" " + _word);
        }
        else if(_revealed != true)
        {

            Console.Write(" ");
            int size = _word.Length;
            for (int i = 0; i < size; i++)
            {
                Console.Write("_");
            }
        }
    }

    public string GetText()
    {
        return _word;
    }

    public void Hide()
    {
        _revealed = false;
    }

    public bool IsHidden()
    {
        return _revealed;
    }
}