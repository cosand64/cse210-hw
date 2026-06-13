class BreathingActivity : BaseActivity
{
    public BreathingActivity(string description) : base("Breathing Activity", description)
    {
        
    }
    
    public void RunActivity()
    {
        StartActivity();
        StartTime();

        while (!HasTimerExpired())
        {
            Console.WriteLine();
            RunCountDown("Breathe in...", 4);
            RunCountDown("Breathe out...", 6);
        }

        DisplayEnding();
    }
}