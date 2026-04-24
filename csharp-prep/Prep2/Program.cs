using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the percent that you recieved? ");
        string userInput = Console.ReadLine();
        int gradePercent = int.Parse(userInput);
        
        Console.Write($"Your grade is {gradePercent}");
        
    }
    
}