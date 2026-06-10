using System;

class Program
{
    static void Main(string[] args)
    {
        BaseActivity myActivity = new BaseActivity("breathing", "this will help you breath");
        myActivity.StartActivity();
        myActivity.RunCountDown("hey bob", 10);

        BreathingActivity myBreathingActivity = new BreathingActivity("This will help you breath better");
        myBreathingActivity.RunActivity();
    }
}