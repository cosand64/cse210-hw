using System.Security.Cryptography.X509Certificates;

class GoalManager
{
    private List<BaseGoal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<BaseGoal>();
        _score = 0;
    }

// 
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
                Console.WriteLine("fill in later");
            }
            else if (userChoice == "3")
            {
                Console.WriteLine("fill in later");
            }
            else if (userChoice == "4")
            {
                Console.WriteLine("fill in later");
            }
            else if (userChoice == "5")
            {
                Console.WriteLine("fill in later");
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
        // fill in later
    }

}