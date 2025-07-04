using System;
using System.Globalization;
using System.Collections.Generic;
using System.Net;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello World! This is the Exercise4 Project.");


        List<int> numbers = new List<int>();
        int number = -1;


        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)

        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = 0;
        int max = int.MinValue;
        int minPositive = int.MaxValue;


        foreach (int num in numbers)
        {
            sum += num;
        
            if (num > max)
                max = num;
        }
        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The largest number is: {max}");
        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is {average}");

        foreach (int num in numbers)
            if (num > 0 && num < minPositive)
            {
                minPositive = num;
            }
        if (minPositive == int.MaxValue)
            Console.WriteLine("No positive numbers added");
        else if (minPositive != int.MaxValue)
            Console.WriteLine($"The smallest positive number is: {minPositive}");

        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
        
        
        
        
        
        



    }

    
}
