using System;
using ExerciseTracking;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running("03 Nov 2022", 30, 4.8);
        Cycling cycling = new Cycling("03 Nov 2022", 30, 4.8);
        Swimming swimming = new Swimming("03 Nov 2022", 30, 40);

        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}