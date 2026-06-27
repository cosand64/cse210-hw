using System.Security.Cryptography.X509Certificates;

class Goals
{
    private const int XP_PER_LEVEL = 500;
    private List<BaseGoal> _goals;
    private int _score;

    public Goals()
    {
        _goals = new List<BaseGoal>();
        _score = 0;
    }

    private int GetLevel()
    {
        return (_score / XP_PER_LEVEL) + 1;
    }

    private string GetTitle()
    {
        int level = GetLevel();
        if (level < 2) return "Novice";
        if (level < 4) return "Apprentice";
        if (level < 7) return "Quest Seeker";
        if (level < 10) return "Master of Habits";
        return "Eternal Sage";
    }

    public void Start()
    {
        bool quit = false;
        while (!quit)
        {
            Console.WriteLine($"\nLevel: {GetLevel()}");
            Console.WriteLine($"Title: {GetTitle()}");
            Console.WriteLine($"You have {_score} points.\n");
            
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            string userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                CreateGoal();
            }
            else if (userChoice == "2")
            {
               ListGoalDetails();
            }
            else if (userChoice == "3")
            {
                SaveGoals();
            }
            else if (userChoice == "4")
            {
                LoadGoals();
            }
            else if (userChoice == "5")
            {
                RecordEvent();
            }
            else if (userChoice == "6")
            {
                quit = true;
            }
            else
            {
                Console.WriteLine("Invalid input, please try again");
            }
        }
    }

    public void CreateGoal()
    {
        
        Console.WriteLine("Which type of goal would you like to create? ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("--> ");
        
        string typeChoice = Console.ReadLine();

        if (typeChoice == "1")
        {
            SimpleGoal newGoal = new SimpleGoal();
            
            newGoal.CreateGoal(); 
            _goals.Add(newGoal); 
        }
        else if (typeChoice == "2")
        {
            EternalGoal newGoal = new EternalGoal();
            newGoal.CreateGoal();
            _goals.Add(newGoal);
        }
        else if (typeChoice == "3")
        {
            CheckListGoal newGoal = new CheckListGoal();
            newGoal.CreateGoal();
            _goals.Add(newGoal);
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetFileSystemString().Split(':')[1].Split(',')[0]}"); 
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDisplayString()}");
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);

            foreach (BaseGoal goal in _goals)
            {
                outputFile.WriteLine(goal.GetFileSystemString());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
       Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);

            _score = int.Parse(lines[0]);
            _goals.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                
                string[] parts = line.Split(':');
                string goalType = parts[0];
                string[] details = parts[1].Split(',');

                string name = details[0];
                string description = details[1];
                int points = int.Parse(details[2]);
                bool status = bool.Parse(details[3]);

                if (goalType == "SimpleGoal")
                {
                    SimpleGoal loadedGoal = new SimpleGoal(name, description, points, status);
                    _goals.Add(loadedGoal);
                }
                else if (goalType == "EternalGoal")
                {
                    int completions = int.Parse(details[4]);
                    EternalGoal loadedGoal = new EternalGoal(name, description, points, status, completions);
                    _goals.Add(loadedGoal);
                }
                else if (goalType == "CheckListGoal")
                {
                    int bonus = int.Parse(details[4]);
                    int target = int.Parse(details[5]);
                    int completions = int.Parse(details[6]);
                    CheckListGoal loadedGoal = new CheckListGoal(name, description, points, status, bonus, target, completions);
                    _goals.Add(loadedGoal);
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    public void RecordEvent()
    {

        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals. Please create a goal first.");
            return;
        }

        ListGoalNames();

        Console.Write("Which goal did you accomplish? ");
        string input = Console.ReadLine();
        
        if (int.TryParse(input, out int goalIndex))
        {
            goalIndex = goalIndex - 1; 

            if (goalIndex >= 0 && goalIndex < _goals.Count)
            {
                int pointsEarned = _goals[goalIndex].RecordEvent();
 
                _score += pointsEarned;
                
                Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
                Console.WriteLine($"You now have {_score} points.");
            }
            else
            {
                Console.WriteLine("Invalid goal selection.");
            }
        }
        else
        {
             Console.WriteLine("Invalid input. Please enter a number.");
        }
    }

}