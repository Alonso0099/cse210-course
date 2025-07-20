using System;


class Program
{
    static void Main(string[] args)
    {
        //This are the main objects
        Journal journal = new Journal(); //manage the list of entries
        PromptGenerator generator = new PromptGenerator(); //give the random prompts   
        string choice = ""; // stores selection from user
        while (choice != "5")
        {
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal");
            Console.WriteLine("4. Load the journal");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Select an option (1-5) ");
            choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                string date = DateTime.Now.ToString(" MMM dd yyy"); // get the date from computer
                string prompt =generator.GetRandomPrompt(); // its connected with the object at the top to get the random promnpt
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();

                //enter the new text to the journal
                Entry entry = new Entry(date, prompt, response); 
                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename to save ");
                string myJournal = Console.ReadLine();
                journal.SaveToFile(myJournal);
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to load ");
                string myJournal = Console.ReadLine();
                journal.LoadFromFile(myJournal);
            }
            else if (choice != "5")
            {
                Console.WriteLine($"{choice} is invalid, try numbers 1-5");
            }

        }
        Console.WriteLine("Goodbye!");
    }
    
}