using System;

public class Resume
{
    public string _name;
    public List<Jobs> _jobs = new List<Jobs>();


    public void Display()
    {
        foreach (Jobs job in _jobs)
        {
            Console.WriteLine($"name: {_name}");
            Console.WriteLine("Jobs: ");
            job.Display();
        }
    }

}