namespace Mindfulness;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();
    
    public ListingActivity(string name, string description, int duration, int count) : base(name, description, duration)
    {
        _count = count;
    }

    public int GetCount()
    {
        return _count;
    }
    public void SetCount(int count)
    {
        _count = count;
    }

    public List<string> GetPrompts()
    {
        return _prompts;
    }
    public void SetPrompts(List<string> prompts)
    {
        _prompts = prompts;
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        Console.Clear();
        GetRandomPrompt();
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);
        GetListFromUser();
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        if (_prompts.Count > 0)
        {
            Random rnd = new Random();
            Console.WriteLine(_prompts[rnd.Next(_prompts.Count)]);
        }
    }

    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                responses.Add(input);
                _count++;           
            }
        }
        return responses;
    }
}