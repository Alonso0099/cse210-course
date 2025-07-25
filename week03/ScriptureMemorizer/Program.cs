using System;
using System.IO;
// I esceed the requierements making the program loads scriptures from an external file and picks one randomly,
// which goes beyond the assignment requirements. It showing extra effort.

class Program
{
    static void Main(string[] args)
    {
        string[] lines = File.ReadAllLines("ScripturesLoad");
        var rng = new Random();
        string randomLine = lines[rng.Next(lines.Length)];

        string[] parts = randomLine.Split('|');
        var reference = new Reference(parts[0]);
        var scripture = new Scripture(reference, parts[1]);

        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to hide more words, or type 'quit' to exit.");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                Console.WriteLine("See you soon.");
                return;
            }

            scripture.HideRandomWords(3);
        }

        // Final message once all words are hidden
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("All words are hidden. Hope you memorized the scripture.");
    }
}


