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

    Entry OGEntry = new Entry();
    Journal OGJournal = new Journal();

    List<string> storage = new List<string>();
    //List<string> storage = [];


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
        if (int.TryParse(Console.ReadLine(),  out _userInput))
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

    public void CallJournal(int _userInput)
    {
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
                        Entry OG2Entry = new Entry();
                        OG2Entry.DisplayLP();
                        OG2Entry.WriteEntry();
                        string answer = OG2Entry._fullAnswer + OG2Entry._reponse;
                        storage = storage.Append($"{answer}").ToList();
                    }
                    else if (_userInput == 2)
                    {
                        Entry OG3Entry = new Entry();
                        OG3Entry.DisplaySP();
                        OG3Entry.WriteEntry();
                        string answer = OG3Entry._fullAnswer + OG3Entry._reponse;
                        storage = storage.Append($"{answer}").ToList();
                    }
                    else
                    {
                        Console.WriteLine(_errorMessage);
                    }

                    
                }
                else if (_userInput == 2)
                {
                    Entry OG4Entry = new Entry();
                    OG4Entry.Display();
                    OG4Entry.WriteEntry();
                    string answer = OG4Entry._fullAnswer + OG4Entry._reponse;
                    storage = storage.Append($"{answer}").ToList();
                }
                else
                {
                    Console.WriteLine(_errorMessage);
                }
            
            // OGEntry.Display();
            // OGEntry.WriteEntry();
            // string answer = OGEntry._fullAnswer + OGEntry._reponse;
            // storage = storage.Append($"{answer}").ToList();
            //Console.WriteLine($"{_startMenu}");
            // Entry OG2Entry = new Entry();
            // OG2Entry.DisplaySP();
            // OG2Entry.WriteEntry();
            // string answer = OG2Entry._fullAnswer + OG2Entry._reponse;
            // storage = storage.Append($"{answer}").ToList();
        }
        else if (_userInput == 2)
        {
            Console.WriteLine($"{_aad}");
            Console.WriteLine($"Display");
            foreach (string e in storage)
            {
                //Console.WriteLine($"{storage}");
                //OGJournal.SendToFile(e);
                Console.WriteLine(e);
                //Console.WriteLine($"{_startMenu}");
            }
        }
        else if (_userInput == 3)
        {
            Console.WriteLine($"Load");
            OGJournal.ReadFromFile();
            //Console.WriteLine($"{storage[0]}");
            //Console.WriteLine($"{_startMenu}");
                
        }
        else if (_userInput == 4)
        {
            Console.WriteLine($"Save");
            foreach (string e in storage)
            {
                //Console.WriteLine($"{storage}");
                OGJournal.SendToFile(e);
            }
            //Console.WriteLine($"{_startMenu}");
        }
        else if (_userInput == 5)
        {
            Console.WriteLine($"{_aaq1}");
            Thread.Sleep(2000);
            Console.Clear();
            Console.Clear();
            Console.WriteLine($"{_aaq2}");
            Console.WriteLine($"Quit");
            Console.WriteLine($"Confirm quit? (Click 5 to confirm, click anything else to continue)");
            _userInput = 5;
        }
        else if (_userInput < 0)
        {
            Console.WriteLine($"_errorMessage");
            //Console.WriteLine($"{_startMenu}");
            
        }
    }
}