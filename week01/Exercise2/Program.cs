using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the grade percentage: ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);
        string letter = " ";
        string sign = " ";
        int lastDigit = gradePercentage % 10;
        
        if (gradePercentage >= 90) 
        {
            letter = "A";
        }
        else if (gradePercentage >= 80) 
        { 
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (lastDigit < 3)
        {
            sign = "-";
        }
        Console.WriteLine($"{letter}{sign}");
        
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("You did not achieve a sufficient grade to pass the course, so you will have to retake it, but keep your spirits up—you will pass it next semester!");
        }
            
    }
}