using System;

class Program
{
    static void Main(string[] args)
    {

        Assignment myAssignment = new Assignment("Alonso Alvarado", "Multiplication");
        MathAssignment myAssignment1 = new MathAssignment("Alonso Alvarado", "Fractions", "7.3", "8-9");
        WritingAssignment myWritingAssignment = new WritingAssignment("Alonso", "European History", "The Causes of World War II");
        Console.WriteLine(myAssignment.GetSummary());
        Console.WriteLine($"{myAssignment1.GetHomeworkList()}\n");
        
        Console.WriteLine(myWritingAssignment.GetSummary());
        Console.WriteLine(myWritingAssignment.GetWritingAssignment());

        
        

    }
}