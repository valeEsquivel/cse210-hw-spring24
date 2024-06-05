using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Activity Tracker!");
        Console.WriteLine("=================================");
        Console.WriteLine();

        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("04 Jun 2024", 30, 3.1));
        activities.Add(new Cycling("04 Jun 2024", 45, 15));
        activities.Add(new Swimming("04 Jun 2024", 60, 40));

        //Note: I worked with miles

        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }
    }
}