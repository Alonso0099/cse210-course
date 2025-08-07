using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt peace this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> _unusedPrompts;

    public ListingActivity() : base(
        "Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    { }

    public void Run()
    {
        DisplayStartingMessage();

        if (_unusedPrompts == null || _unusedPrompts.Count == 0)
        {
            _unusedPrompts = new List<string>(_prompts); // Reinicia cuando se acaban
        }

        Random rand = new Random();
        int index = rand.Next(_unusedPrompts.Count);
        string prompt = _unusedPrompts[index];
        _unusedPrompts.RemoveAt(index);

        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"-- {prompt} --");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                responses.Add(response);
            }
        }

        Console.WriteLine($"\nYou listed {responses.Count} items!");
        DisplayEndingMessage();
    }
}


