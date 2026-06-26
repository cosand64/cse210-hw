using System.Security.Cryptography.X509Certificates;

class Goals
{
    private List<BaseGoal> _goals;
    private int _score;

    public Goals()
    {
        _goals = new List<BaseGoal>();
        _score = 0;
    }

    public void Start()
    {
        bool quit = false;
        while (!quit)
        {
            Console.WriteLine($"\nYou have {_score} points.\n");
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
            // We will hook this up when we build EternalGoal (Step 13)
            Console.WriteLine("Eternal Goal feature coming soon...");
        }
        else if (typeChoice == "3")
        {
             // We will hook this up when we build CheckListGoal (Step 14)
            Console.WriteLine("Checklist Goal feature coming soon...");
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
        // fill in later
        Console.WriteLine("\n[Save feature coming soon...]");
    }

    public void LoadGoals()
    {
        // fill in later
        Console.WriteLine("\n[Load feature coming soon...]");
    }

    public void RecordEvent()
    {
        // fill in later
        Console.WriteLine("\n[Record Event feature coming soon...]");
    }

}