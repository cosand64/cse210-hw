class BaseActivity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected DateTime _endTime;

    public BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
        _endTime = DateTime.Now;
    }

    // Combined DisplayGreeting, DisplayDescription and ObtainDuration
    public void StartActivity()
    {
        Console.Clear();
        Console.CursorVisible = true;
        
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine(_description);
        Console.WriteLine("\nHow many seconds would you like for your session?");
        
        if(int.TryParse(Console.ReadLine(), out int duration))
        {
            _duration = duration;
        }
        else
        {
            _duration = 30;
        }

        Console.CursorVisible = false;

        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplaySpinner("", 3);
    }

    public void DisplayEnding()
    {
        Console.WriteLine();
        Console.WriteLine("Good Job!");
        DisplaySpinner("", 3);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} Activity.");
        DisplaySpinner("", 5);
    }

    public void RunCountDown(string message, int duration)
    {
        Console.Write($"{message} ");

        while(duration > 0)
        {
            Console.Write($"{duration, 2}");
            Thread.Sleep(1000);
            Console.Write("\b\b  \b\b"); 
            duration--;
        }
        Console.WriteLine();
    }

    public void DisplaySpinner(string message, int seconds)
    {
        if (!string.IsNullOrEmpty(message))
        {
            Console.Write(message + " ");
        }

        List<string> animationString = new List<string> { "|", "/", "-", "\\" };
        int i = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;
            if (i >= animationString.Count)
            {
                i = 0;
            }
        }
        Console.WriteLine();
    }

    public void StartTime()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
    }

    public bool HasTimerExpired()
    {
        return DateTime.Now >= _endTime;
    }

    public string GetRandomPrompt(List<string> prompts)
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}