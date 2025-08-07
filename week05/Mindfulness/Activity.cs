using System;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}\n");
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        int seconds;
        while (!int.TryParse(Console.ReadLine(), out seconds))
        {
            Console.Write("Please enter a valid number: ");
        }
        _duration = seconds;

        Console.WriteLine("\nGet ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(3);

        Console.WriteLine($"\nYou have completed the {_name} for {_duration} seconds.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
    string[] spinner = { "|","/","-","\\","|","/","-","\\"};
    DateTime endTime = DateTime.Now.AddSeconds(seconds);
    int i = 0;

    while (DateTime.Now < endTime)
    {
        Console.Write(spinner[i]);
        Thread.Sleep(500); 
        Console.Write("\b \b");
        i = (i + 1) % spinner.Length;
    }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public int GetDuration()
    {
        return _duration;
    }
}

