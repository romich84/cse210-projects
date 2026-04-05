namespace Mindfulness;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
    }
    public List<string> GetPrompts()
    {
        return _prompts;
    }

    public void SetPrompts(List<string> prompts)
    {
        _prompts = prompts;
    }

    public List<string> GetQuestions()
    {
        return _questions;
    }

    public void SetQuestions(List<string> questions)
    {
        _questions = questions;
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        Console.Clear();
    
        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt();
        
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        { 
            Console.Write("> ");
            DisplayQuestions();
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        return _prompts[new Random().Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        return _questions[new Random().Next(_questions.Count)];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }
    public void DisplayQuestions()
    { 
        Console.WriteLine(GetRandomQuestion());
    }
}