using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("03 Ago 2025",30,4.8),
            new Cycling("03 Ago 2025",45,15.0),
            new Swimming("03 Ago 2025",25,30)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }

 
}
