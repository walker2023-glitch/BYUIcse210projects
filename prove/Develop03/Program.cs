using System;
using System.Data;
using System.Net.WebSockets;
using System.Runtime.InteropServices;

using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;




class Program
{
    static async Task Main(string[] args)
    {

        string apiKey = "lE22fD7pxAr1S_fUVols8";

        string Bible = "de4e12af7f28f599-02";

        string passage = "JHN.3.16";

        string url = $"https://api.scripture.api.bible/v1/bibles/{Bible}/verses/{passage}";



        using (HttpClient client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("api-key", apiKey);

             try
                {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string reponseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(reponseBody);
        }
catch (HttpRequestException e)
            {
                Console.WriteLine($"Request error: {e.Message}");
            }
        }


       


    //Console.WriteLine("Hello Develop03 World!");

        //lE22fD7pxAr1S_fUVols8

        //

            Word word1 = new Word("Jesus");

        Word word2 = new Word("Wept.");

        // word1.Display();
        // word2.Display();

        // word1.Hide();

        // word1.Display();
        // word2.Display();

        //List<Word> sWords = new List<Word>(word1, word2);

        const string quit = "quit";

        Scripture Verse1 = new Scripture("1 Nephi", 3, 7, 0, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        Menu m1 = new Menu();

        //Verse1.TotalHidden() == false && 
        Verse1.Display();
        
        while (m1.GetInput() != quit && !(Verse1.TotalHidden()))
        
            {
            Verse1.HideWords();
        }

        

        
        //Verse1.Display();
        //Verse1.GetVerse();
        }
}