using System;

class Program
{
    static void Main(string[] args)
    {
        // int magicNumber = 6;
        // int magicNumber = 18;
        // int magicNumber = randomGenerator.Next(1, 101);
        // Console.WriteLine($"What is the magic number? {magicNumber}");
        // Console.WriteLine("What is your guess?");
        // string userInput = Console.ReadLine();
        //guess = int.Parse(userInput);
        // if (guess == magicNumber)
        // {
        //    Console.WriteLine("You guessed it!");
        // }
        // else if (guess < magicNumber)
        // {
        //    Console.WriteLine("Higher");
        // }
        // else
        // {
        //    Console.WriteLine("Lower");
        // }
        
        // int guess = -1;
        // int counter = 0;
        Random randomGenerator = new Random();
        string response = "yes";
        while (response == "yes")
        {
            int magicNumber = randomGenerator.Next(1, 101);
            int guess = -1;
            int counter = 0;
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string userInput = Console.ReadLine();
                guess = int.Parse(userInput);
                counter++;
                if (guess == magicNumber)
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You guessed it in {counter} attempts.");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Lower");
                }
            }
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        }
    }
}