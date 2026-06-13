class ListingActivity : BaseActivity
{
    private List<string> _prompts;

    public ListingActivity(string description) : base("Listing Activity", description)
    {
        SetPrompts();
    }

    private void SetPrompts()
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void RunActivity()
    {
        StartActivity();

        Console.WriteLine("\nList as many responses you can to the following prompt:");
        string prompt = GetRandomPrompt(_prompts);
        Console.WriteLine($"--- {prompt} ---");
        
        RunCountDown("You may begin in", 5);
        StartTime(); 
        int itemCount = 0;

        Console.CursorVisible = true;
        
        while (!HasTimerExpired())
        {
            Console.Write("> ");
            
            string input = Console.ReadLine();
            
            if (!string.IsNullOrWhiteSpace(input))
            {
                itemCount++;
            }
        }

        Console.CursorVisible = false;

        Console.WriteLine($"\nYou listed {itemCount} items!");
        DisplayEnding();
    }
}