using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

class Breathing :Activity {
    
private const string BSM = "";
private const string BEM = "";
//private const string _name = "Breathing";

//private const string _description = "";
    public Breathing(double t, string name, string d) :base(t, name, d)
    {
        
    }

    public void breathe()
    {
        
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(this._timeLimit);
        //DateTime currentTime = DateTime.Now;
        
        
        int breathCount = 1;
        while(DateTime.Now < futureTime)
        {
            
            
            
            
            Console.WriteLine($"Cycle number: {breathCount}");
            

            //Orginal I wrote everything out, but then askd AI for improvement and it suggested this for loop. 
            Console.WriteLine("Breathe In...");
            for(int bi = 0; bi < 5; bi++){
                Console.Write(bi);
                Thread.Sleep(1500);
                Console.Write("\b \b");
            }



            Console.WriteLine("Breathe Out...");
            for(int bo = 0; bo < 5; bo++){
                Console.Write(bo);
                Thread.Sleep(1500);
                Console.Write("\b \b");
            }
          
            breathCount++;  
        }
        
    }




}