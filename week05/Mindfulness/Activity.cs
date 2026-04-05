namespace Mindfulness;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
            Console.WriteLine($"Welcome to the {GetName()}");
            Console.WriteLine(GetDescription());
            Console.Write($"How long, in seconds would you like for your session? ");
            string input = Console.ReadLine();
            
            if (int.TryParse(input, out int userDuration))
            {
                SetDuration(userDuration);
            }
            else
            {
                Console.WriteLine("Invalid input, using default duration.");
                SetDuration(GetDuration());
            }
    }

    public void ShowSpinner(int duration)
    {
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string a = animation[i];
            Console.Write(a);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;
            if (i >= animation.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(5);
        Console.WriteLine($"You have completed another {GetDuration()} seconds of the {GetName()}.");
        ShowSpinner(5);
    }
}