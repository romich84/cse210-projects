using System;
using Journal;
using JournalApp;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        PromptGenerator newPrompt = new PromptGenerator();
        newPrompt._prompts.Add("Who was the most interesting person I interacted with today?");
        newPrompt._prompts.Add("What was the best part of the day?");
        newPrompt._prompts.Add("How did I see the hand of the Lord in my life today?");
        newPrompt._prompts.Add("What was the strongest emotion I felt today?");
        newPrompt._prompts.Add("If I had one thing I could do over today, what would it be?");
        newPrompt._prompts.Add("Did you read any Scriptures today? What did you learn from it?");
        newPrompt._prompts.Add("Do you have any plans for today?");
        newPrompt._prompts.Add("Did you visit any friends?");
        newPrompt._prompts.Add("Did you watch any tv shows? Which ones?");
        newPrompt._prompts.Add("Would you like to go somewhere this week? Where?");
        newPrompt._prompts.Add("What made you smile today?");
        newPrompt._prompts.Add("What did you learn today?");

        JournalApp.Journal journal = new JournalApp.Journal();
        Menu(journal, newPrompt);
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Journal Program!");
    }

    static void Menu(JournalApp.Journal journal, PromptGenerator newPrompt)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string userInput = Console.ReadLine();
            int choice = int.Parse(userInput);
            if (choice == 1)
            {
                string prompt = newPrompt.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string userEntry = Console.ReadLine();
                Entry entry = new Entry();
                entry._date = "03-14-2026";
                entry._promptText = prompt;
                entry._entryText = userEntry;
                journal.AddEntry(entry);
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.WriteLine("What is the file:");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
            }
            else if (choice == 4)
            {
                Console.WriteLine("What is the file:");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }
            else if (choice == 5)
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }
    }
        
}