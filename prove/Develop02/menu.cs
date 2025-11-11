using System.Formats.Asn1;
using System.Threading;

class Menu
{

    /*const string _startWord = "
           __..._   _...__
  _..-"      `Y`      "-._
  \ Once upon |           /
  \\  a time..|          //
  \\\         |         ///
   \\\ _..---.|.---.._ ///
jgs \\`_..---.Y.---.._`//
     '`               `' "
     ;*/

    const string _asciiArt = @"
         __..._   _...__
  _..-""         `Y`         ""-._
  \ Once upon |             /
  \\  a time..|           //
  \\\         |         ///
    \\\ _..---.|.---.._ ///
jgs \\`_..---.Y.---.._`//
      '`               `'
";

    const string _aaw = @"  __
 (`/\
 `=\/\ __...--~~~~~-._   _.-~~~~~--...__
  `=\/\               \ /               \\
   `=\/                V                 \\
   //_\___--~~~~~~-._  |  _.-~~~~~~--...__\\
  //  ) (..----~~~~._\ | /_.~~~~----.....__\\
 ===( INK )==========\\|//====================
__ejm\___/________dwb`---`_____________________";

    const string _aad =
    @"    __________________   __________________
.-/|                  \ /                  |\-.
||||                   |                   ||||
||||                   |       ~~*~~       ||||
||||    --==*==--      |                   ||||
||||                   |                   ||||
||||                   |                   ||||
||||                   |     --==*==--     ||||
||||                   |                   ||||
||||                   |                   ||||
||||                   |                   ||||
||||                   |                   ||||
||||__________________ | __________________||||
||/===================\|/===================\||
`--------------------~___~-------------------''";

    const string _aaq1 =
    @",         ,
|\\\\ ////|
| \\\V/// |
|  |~~~|  |
|  |===|  |
|  |j  |  |
|  | g |  |
 \ |  s| /
  \|===|/
   '---'";

    const string _aaq2 =
 @"   
  /////|
 ///// |
|~~~|  |
|===|  |
|j  |  |
| g |  |
|  s| /
|===|/
'---'";



    const string _startMenu = "Please Select one of the following choices? \n 1: Write \n 2: Display \n 3: Load \n 4: Save\n 5: Quit\n Would what you like to do?";
    const string _errorMessage = "Oops! I didn't recognize that input. Please make sure you are selecting one of the available options.";

    int _userInput = -5;



    List<Entry> _storage = new List<Entry>();



    public void StartDisplay()
    {
        Console.WriteLine($"{_asciiArt}");
        Console.WriteLine($"{_startMenu}");
    }
    public void Display()
    {
        Console.WriteLine($"{_startMenu}");
    }
    public int GetInput()
    {
        if (int.TryParse(Console.ReadLine(), out _userInput))
        {
            Console.Clear();
            return _userInput;
        }
        else
        {
            Console.Clear();
            Console.WriteLine(_errorMessage);
            return _userInput = -5;

            //Console.WriteLine($"{_errorMessage}");
        }

    }

    public int ReturnInputNum()
    {
        return _userInput;
    }

    public void CallJournal(int _userInput)
    {
        Journal ogJournal = new Journal();
        if (_userInput == 1)
        {
            Console.WriteLine($"{_aaw}");
            Console.WriteLine($"\nWrite");
            Console.WriteLine($"Do you want a prompt?\n1:Yes\n2:No");
            _userInput = this.GetInput();
            if (_userInput == 1)
            {
                Console.WriteLine($"Do you want a longer prompt or a shorter one?\n1:Longer\n2:Shorter");
                _userInput = this.GetInput();
                if (_userInput == 1)
                {
                    Entry og2Entry = new Entry();
                    og2Entry.DisplayLP();
                    og2Entry.WriteEntry();
                    //string answer = og2Entry._fullAnswer + og2Entry._reponse;
                    _storage.Add(og2Entry);
                }
                else if (_userInput == 2)
                {
                    Entry og3Entry = new Entry();
                    og3Entry.DisplaySP();
                    og3Entry.WriteEntry();
                    //string answer = og3Entry._fullAnswer + og3Entry._reponse;
                    _storage.Add(og3Entry);
                }
                else
                {
                    Console.WriteLine(_errorMessage);
                }


            }
            else if (_userInput == 2)
            {
                Entry og4Entry = new Entry();
                og4Entry.Display();
                og4Entry.WriteEntry();
                //string answer = og4Entry._fullAnswer + og4Entry._reponse;
                _storage.Add(og4Entry);
            }
            else
            {
                Console.WriteLine(_errorMessage);
            }

            // ogEntry.Display();
            // ogEntry.WriteEntry();
            // string answer = ogEntry._fullAnswer + ogEntry._reponse;
            // storage = storage.Append($"{answer}").ToList();
            //Console.WriteLine($"{_startMenu}");
            // Entry og2Entry = new Entry();
            // og2Entry.DisplaySP();
            // og2Entry.WriteEntry();
            // string answer = og2Entry._fullAnswer + og2Entry._reponse;
            // storage = storage.Append($"{answer}").ToList();
        }
        else if (_userInput == 2)
        {
            Console.WriteLine($"{_aad}");
            Console.WriteLine($"Display");
            foreach (Entry e in _storage)
            {
                //Console.WriteLine($"{storage}");
                //ogJournal.SendToFile(e);
                Console.WriteLine(e.FullEntry());
                //Console.WriteLine($"{_startMenu}");
            }
        }
        else if (_userInput == 3)
        {
            Console.WriteLine($"Load");
            _storage = ogJournal.ReadFromFile();

        }
        else if (_userInput == 4)
        {
            Console.WriteLine($"Save");
            ogJournal.SendToFile(_storage);


            //Console.WriteLine($"{_startMenu}");
        }
        else if (_userInput == 5)
        {
            Console.WriteLine($"{_aaq1}");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine($"{_aaq2}");
            Console.WriteLine($"Quit");

        }
        else if (_userInput < 0)
        {
            Console.WriteLine($"_errorMessage");
            //Console.WriteLine($"{_startMenu}");

        }
    }
}