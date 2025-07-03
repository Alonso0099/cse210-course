using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");


        
        Random randomGenerator = new Random();
        string response;
        do
        {
            int magicNumber = randomGenerator.Next(1, 101);
            int guess = -1;
            int guessCount = 0;



            while (guess != magicNumber)

            {

                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;
                if (magicNumber > guess)
                {
                    Console.WriteLine("Higer");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }

            }

            Console.WriteLine($"The number of guesses you made was {guessCount}");
            Console.Write("Do you want to play again? ");
            response = Console.ReadLine();
        } while (response == "yes");
    }
}