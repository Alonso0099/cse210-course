using System;
// Requirements exceeded:
// ListingActivity avoids repeating prompts until all have been used.
// ReflectingActivity avoids repeating prompts and questions until all have been used.
// These improve user experience and go beyond the core requirements.




class Program
{
    static void Main(string[] args)
    {


        BreathingActivity breathing = new BreathingActivity();
        ReflectingActivity reflecting = new ReflectingActivity();
        ListingActivity listing = new ListingActivity();

        string choice = "";
        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    breathing.Run();
                    break;
                case "2":
                    reflecting.Run();
                    break;
                case "3":
                    listing.Run();
                    break;
                case "4":
                    Console.WriteLine("\nThanks for using the Mindfulness Program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose 1-4.");
                    Thread.Sleep(2000);
                    break;
            }
        }
    }
}