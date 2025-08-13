using System;
// I exceed the requierements by create NegativeGoal that subtracts points if the user fails to do something or does something bad."
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        string choice = "";

        while (choice != "6")

        {

            Console.WriteLine("\n--- Eternal Quest Menu ---");
            Console.WriteLine("1. Display Goals and Score");
            Console.WriteLine("2. Create New Goal");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            switch (choice)

            {
                case "1":
                    manager.DisplayGoals();
                    break;

                case "2":

                    Console.WriteLine("\nChoose goal type:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.WriteLine("4. Negative Goal");
                    Console.Write("Type: ");
                    string type = Console.ReadLine();

                    Console.Write("Goal Titule: ");
                    string name = Console.ReadLine();
                    Console.Write("Description: ");
                    string desc = Console.ReadLine();

                    try

                    {
                        if (type == "1")
                        {
                            Console.Write("Points to earn: ");
                            int points = int.Parse(Console.ReadLine());
                            manager.AddGoal(new SimpleGoal(name, desc, points));
                        }

                        else if (type == "2")
                        {
                            Console.Write("Points per time: ");
                            int points = int.Parse(Console.ReadLine());
                            manager.AddGoal(new EternalGoal(name, desc, points));
                        }

                        else if (type == "3")
                        {
                            Console.Write("Points per time: ");
                            int points = int.Parse(Console.ReadLine());
                            Console.Write("Times needed: ");
                            int target = int.Parse(Console.ReadLine());
                            Console.Write("Bonus points: ");
                            int bonus = int.Parse(Console.ReadLine());
                            manager.AddGoal(new ChecklistGoal(name, desc, points, target, 0, bonus));
                        }

                        else if (type == "4")
                        {
                            Console.Write("Penalty points: ");
                            int penalty = int.Parse(Console.ReadLine());
                            manager.AddGoal(new NegativeGoal(name, desc, penalty));
                        }

                        else
                        {
                            Console.WriteLine("Invalid type.");
                        }

                    }
                    catch
                    {
                        Console.WriteLine("Please enter valid numbers.");
                    }
                    break;

                case "3":
                    manager.DisplayGoals();
                    Console.Write("Which goal did you complete? (number): ");
                    if (int.TryParse(Console.ReadLine(), out int index))
                    {
                        manager.RecordEvent(index - 1);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                    break;

                case "4":
                    manager.Save("goals.txt");
                    break;

                case "5":
                    manager.Load("goals.txt");
                    break;

                case "6":
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}



                    
      
                    

