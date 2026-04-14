namespace EternalQuest;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool running = true;
        while (running)
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice: ");
            string userInput = Console.ReadLine();
            int choice = int.Parse(userInput);
            if (choice == 1)
            { 
                CreateGoal();
            }
            else if (choice == 2)
            { 
                Console.WriteLine("The goals are: ");
                ListGoalNames();
            }
            else if (choice == 3)
            { 
                Console.Write("What is the filename for the goal file? ");  
                SaveGoals();
            }
            else if (choice == 4)
            { 
                Console.Write("What is the filename for the goal file? "); 
                LoadGoals();
            }
            else if (choice == 5)
            {
                RecordEvent();
            }
            else if (choice == 6)
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }    
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }
    public void ListGoalNames()
    {
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console. WriteLine($"{i}. {goal.GetStringRepresentation()}");
            i++;
        }
    }
    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console. WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("4. Which type of goal would you like to create? ");
        string userInput = Console.ReadLine();
        int choice = int.Parse(userInput);
        if (choice == 1)
        {
              Console.Write("What is the name of the goal? ");
              string goalName = Console.ReadLine();
              Console.Write("What is a short description of it? ");
              string description = Console.ReadLine();
              Console.Write("What is the amount of points associated with this goal? ");
              string points = Console.ReadLine();
              int pointsGoal = int.Parse(points);
              SimpleGoal simpleGoal = new SimpleGoal(goalName, description, pointsGoal, false);
              _goals.Add(simpleGoal);
        }
        else if (choice == 2)
        {
            Console.Write("What is the name of the goal? ");
            string goalName = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();
            int pointsGoal = int.Parse(points);
            EternalGoal eternalGoal = new EternalGoal(goalName, description, pointsGoal);
            _goals.Add(eternalGoal);
        }
        else if (choice == 3)
        {
            Console.Write("What is the name of the goal? ");
            string goalName = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();
            int pointsGoal = int.Parse(points);
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            string target = Console.ReadLine();
            int targetGoal = int.Parse(target);
            Console.Write("What is the bonus for accomplishing it that many times? ");
            string bonus = Console.ReadLine();
            int bonusGoal = int.Parse(bonus);
            ChecklistGoal checklistGoal = new ChecklistGoal(goalName, description, pointsGoal,bonusGoal, targetGoal, 0);
            _goals.Add(checklistGoal);   
        }
        else
        {
            Console.WriteLine("Invalid choice");
        }
    }

    public void RecordEvent()
    {
       Console.WriteLine("The goals are:");
       int i = 1;
       foreach (Goal goal in _goals)
       {
           Console.WriteLine($"{i}. {goal.GetShortName()}");
           i++;
       }
       Console.Write("Which goal did you accomplish? ");
       string choice = Console.ReadLine();
       int choiceInt = int.Parse(choice);
       int index = choiceInt - 1;
       if (index < 0 || index >= _goals.Count)
       {
           Console.WriteLine("Invalid choice.");
           return;
       }
       Goal selectedGoal = _goals[index];
       selectedGoal.RecordEvent();
       _score += selectedGoal.GetPoints();
       Console.WriteLine($"Congratulations! You have earned {selectedGoal.GetPoints()} points!");
       Console.WriteLine($"You now have {_score} points.");
       Console.WriteLine(" ");
    }
    public void SaveGoals()
    {
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"{_score}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetSaveString());
            }
        }
    }

    public void LoadGoals()
    {
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(',');

            string type = parts[0];
            if (type == "SimpleGoal")
            {
                string shortName = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);
                SimpleGoal simpleGoal = new SimpleGoal(shortName, description, points, isComplete);
                _goals.Add(simpleGoal);
            }

            if (type == "EternalGoal")
            {
                string shortName = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                EternalGoal eternalGoal = new EternalGoal(shortName, description, points);
                _goals.Add(eternalGoal);
            }

            if (type == "ChecklistGoal")
            {
                string shortName = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int bonus = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int amountCompleted = int.Parse(parts[6]);
                ChecklistGoal checklistGoal = new ChecklistGoal(shortName, description, points, bonus, target, amountCompleted);
                _goals.Add(checklistGoal);
            }
        }
    }
        
}