using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        string answer = "";
        int sum;
        double average;
        int largestNumber;
        int smallestNumber;
        while (answer != "0")
        {
            Console.Write("Enter number: ");
            answer = Console.ReadLine();
            int num = int.Parse(answer);
            if (num != 0)
            {
                numbers.Add(num);
            }
        }
        sum = numbers.Sum();
        average = numbers.Average();
        largestNumber = numbers.Max();
        smallestNumber = numbers.Where(n => n > 0).Min();
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestNumber}");
        numbers.Sort();
        Console.WriteLine($"The sorted list is:");
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }
        
    }
}