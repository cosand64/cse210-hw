using System.Reflection;

class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.CursorVisible = false;
        int sleepTime = 25;

        // for (int i = 0; i < 20; i++)
        // {
        //     Console.Write("+");
        //     Thread.Sleep(sleepTime);
        //     Console.Write("\b");
        //     Console.Write("-");
        //     Thread.Sleep(sleepTime);
        //     Console.Write("\b");
        // }

        string animationString = "\\-/|";
        for (int i = 0; i < 200; i++)
        {
            Console.Write(animationString[i % animationString.Length]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");
            // Console.Write("-");
            // Thread.Sleep(sleepTime);
            // Console.Write("\b");
        }

        Console.CursorVisible = true;
    }
}
