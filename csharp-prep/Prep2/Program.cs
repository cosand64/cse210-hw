using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the percent that you recieved? ");
        string userInput = Console.ReadLine();
        int gradePercent = int.Parse(userInput);
        string letterGrade = "";
        
        if (gradePercent >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercent >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercent >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercent >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        Console.WriteLine($"Your letter grade is: {letterGrade}");
        if (gradePercent >= 70)
        {
            Console.WriteLine("You have passed the class!");
        }
        else
        {
            Console.WriteLine("You have failed! You will have to try again!");
        }
    }
    
}