using System;
using System.Globalization;
using ExerciseTracking;

class Program
{
    static void Main(string[] args)
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
        List<Activity> activities = new List<Activity>();
        activities.Add(new Running(DateTime.Now, 30, 5.0));
        activities.Add(new Cycling(DateTime.Now, 45, 20.0));
        activities.Add(new Swimming(DateTime.Now, 40, 30));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}