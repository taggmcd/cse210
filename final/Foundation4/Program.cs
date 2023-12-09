using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateOnly(2022, 12, 03),60, "Running", 4),
            new Running(new DateOnly(2022, 12, 04),30, "Running", 2),
            new Running(new DateOnly(2022, 12, 05),60, "Running", 5),
            new Biking(new DateOnly(2022, 12, 06),120, "Biking", 20),
            new Biking(new DateOnly(2022, 12, 07),60, "Biking", 18),
            new Biking(new DateOnly(2022, 12, 08),120, "Biking", 15),
            new Swimming(new DateOnly(2022, 12, 09),30, "Swimming", 10),
            new Swimming(new DateOnly(2022, 12, 10),45, "Swimming", 15),
            new Swimming(new DateOnly(2022, 12, 11),60, "Swimming", 20)
        };

        Console.Clear();

        foreach (Activity activity in activities)
        {
            Console.WriteLine($"{activity.GetSummary()}");
        }
    }
}