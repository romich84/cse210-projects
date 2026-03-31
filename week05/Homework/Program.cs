using System;
using Homework;

class Program
{
    static void Main(string[] args)
    {
        Assignment assigment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assigment.GetSummary());
        Console.WriteLine("------------------------------");
        MathAssignment assignment2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine($"{assignment2.GetSummary()}\n{assignment2.GetHomeworkList()}");
        Console.WriteLine("------------------------------");
        WritingAssignment assignment3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine($"{assignment3.GetSummary()}\n{assignment3.GetWritingInformation()}");
    }
}