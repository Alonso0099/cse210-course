using System;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("whats is your grade? 0-100: ");
        string userinput = Console.ReadLine();
        int grade = int.Parse(userinput);

        string letter = "";

        if (grade >= 93 && grade <= 100)
        {
            letter = "A";
        }
        else if (grade <= 92 && grade >= 90)
        {
            letter = "A-";
        }
        else if (grade >= 87 && grade <= 89)
        {
            letter = "B+";
        }
        else if (grade <= 82 && grade >= 80)
        {
            letter = "B-";
        }
        else if (grade >= 83 && grade <= 87)
        {
            letter = "B";
        }
        else if (grade >= 77 && grade <= 79)
        {
            letter = "C+";
        }
        else if (grade <= 72 && grade >= 70)
        {
            letter = "C-";
        }
        else if (grade >= 73 && grade <= 77)
        {
            letter = "C";
        }
        else if (grade >= 67 && grade <= 69)
        {
            letter = "D+";
        }
        else if (grade <= 62 && grade >= 60)
        {
            letter = "D-";
        }
        else if (grade >= 63 && grade <= 67)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations you pass the course!");
        }
        else
        {
            Console.WriteLine("You didn't pass the course, next time you can do it better.");
        }

        

    }
}