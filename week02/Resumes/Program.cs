using System;



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
