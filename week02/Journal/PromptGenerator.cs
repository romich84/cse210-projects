namespace Journal;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    

    public string GetRandomPrompt()
    {
        return _prompts[new Random().Next(_prompts.Count)];
    }
}