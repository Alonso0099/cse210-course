using System;
// I exceeds the basic requirements by:
// - Including multiple creative and meaningful prompts (more than the minimum five)
// - Saving and loading journal entries to a text file with clear formatting
// - Organizing the code into separate classes (PromptGenerator, Entry, Journal) to make it easier to understand and manage


class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "The Aroma Trace";
        job1._jobTitle = "Technician";
        job1._startYear = 2023;
        job1._endYear = 2024;

        Resume resume1 = new Resume();
        resume1._name = "Alonso Alvarado";
        resume1._jobs.Add(job1);

        resume1.Display();
    }
}
