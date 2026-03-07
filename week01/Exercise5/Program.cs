using System;

class Program
{
    static void Main(string[] args)
    {
        void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        DisplayWelcome();
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        string promptUserName(string name)
        {
            return name;
        }
        Console.Write("Please enter your favorite number: ");
        string answer = Console.ReadLine();
        int number = int.Parse(answer);
        int promptUserNumber(int number)
        {
            return number;
        }
        string userName = promptUserName(name);
        int userNumber = promptUserNumber(number);
        double squareNumber(double number)
        {
            double square = Math.Pow(number, 2);
            return square;
        }
        double square = squareNumber(userNumber);

        void DisplayResult(string name, double square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
        DisplayResult(userName, square);
        
    }
}