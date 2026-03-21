using System;
using ScriptureMemorizer;


class Program
{
    static void Main(string[] args)
    {
        Reference r = new Reference("Genesis",46,3);
        Scripture s = new Scripture(r, "And he said, I am God, the God of thy father: fear not to go down into Egypt; for I will there make of thee a great nation:");
        Reference r2 = new Reference("Alma", 32, 41, 42);
        Scripture s2 = new Scripture(r2, "But if ye will nourish the word, yea, nourish the tree as it beginneth to grow, by your faith with great diligence, and with patience, looking forward to the fruit thereof, it shall take root; and behold it shall be a tree springing up unto everlasting life. And because of your diligence and your faith and your patience with the word in nourishing it, that it may take root in you, behold, by and by ye shall pluck the fruit thereof, which is most precious, which is sweet above all that is sweet, and which is white above all that is white, yea, and pure above all that is pure; and ye shall feast upon this fruit even until ye are filled, that ye hunger not, neither shall ye thirst.");
        Menu(s);
    }

    static void Menu(Scripture s)
    {
        string answer = "";
        
        while (answer != "quit" && !s.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(s.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            answer = Console.ReadLine();
            s.HideRandomWords(3);
            Console.Clear();
            Console.WriteLine(s.GetDisplayText());
        }
    }
}