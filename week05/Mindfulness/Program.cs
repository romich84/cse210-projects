using System;
using System.Collections.Generic;
using Mindfulness;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity a1 = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 30);
        ReflectingActivity a2 = new ReflectingActivity("Reflecting Activity",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
            30);
        a2.GetPrompts().Add("Think of a time when you stood up for someone else.");
        a2.GetPrompts().Add("Think of a time when you did something really difficult.");
        a2.GetPrompts().Add("Think of a time when you helped someone in need.");
        a2.GetPrompts().Add("Think of a time when you did something truly selfless.");
        a2.GetQuestions().Add("Why was this experience meaningful to you?");
        a2.GetQuestions().Add("Have you ever done anything like this before?");
        a2.GetQuestions().Add("How did you get started?");
        a2.GetQuestions().Add("How did you feel when it was complete?");
        ListingActivity a3 = new ListingActivity("Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",30,
            0);
        a3.GetPrompts().Add("Who are people that you appreciate?");
        a3.GetPrompts().Add("What are personal strengths of yours?");
        a3.GetPrompts().Add("Who are people that you have helped this week?");
        a3.GetPrompts().Add("When have you felt the Holy Ghost this month?");
        a3.GetPrompts().Add("Who are some of your personal heroes?");
        
        Menu(a1, a2, a3);

    }
    static void Menu(BreathingActivity a1,  ReflectingActivity a2, ListingActivity a3)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Menu options");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select an option: ");
            string userInput = Console.ReadLine();
            int choice = int.Parse(userInput);
            if (choice == 1)
            {
                a1.Run();
            }
            else if (choice == 2)
            {
                a2.Run();
            }
            else if (choice == 3)
            {
               a3.Run(); 
            }
            else if (choice == 4)
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