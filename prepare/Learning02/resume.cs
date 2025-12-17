using System;
using System.Collections.Generic; // IMPORTANT: Needed for the List<T> data type

/// <summary>
/// Represents a person's complete resume, containing their name and a list of their past and current jobs.
/// </summary>
public class Resume
{
    // -----------------------------------------------------------------
    // Member Variables (Fields) - Represents the state/data of the resume
    // -----------------------------------------------------------------

    /// <summary>The name of the person who owns this resume.</summary>
    public string _name;

    /// <summary>
    /// A list of Job objects associated with this resume. 
    /// The list is initialized upon creation to prevent NullReferenceExceptions.
    /// </summary>
    public List<Jobs> _jobs = new List<Jobs>();


    // -----------------------------------------------------------------
    // Behaviors (Methods) - Defines the actions/functionality of the resume
    // -----------------------------------------------------------------

    /// <summary>
    /// Displays the full contents of the resume to the console.
    /// This includes the person's name and details for every job in the list.
    /// </summary>
    public void Display()
    {
        // NOTE: The current implementation prints the name and "Jobs:" for *each* job.
        // It is typically better practice to print the name once outside the loop.

        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Iterates through every Job object stored in the _jobs list.
        foreach (Jobs job in _jobs)
        {
            // Delegates the display responsibility to the individual Job object.
            job.Display();
        }
        
        /*
        // --- Original Code Block (with a note on potential formatting issue) ---
        foreach (Jobs job in _jobs)
        {
            // These two lines are often better placed *outside* the loop 
            // to avoid repeating the name and header for every single job.
            Console.WriteLine($"name: {_name}"); 
            Console.WriteLine("Jobs: ");
            
            job.Display();
        }
        */
    }
}