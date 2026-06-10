class BreathingActivity : BaseActivity
{
    public BreathingActivity(string description) : base("Breathing Activity", description)
    {
        
    }
    
    public void RunActivity()
    {
        StartActivity();
        RunCountDown("Breath in", 4);
        RunCountDown("Breath out", 6);
    }
}