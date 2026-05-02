using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite whole number? ");
        int favoriteNumber = int.Parse(Console.ReadLine());
        return favoriteNumber;
    }

    static void PromptBirthYear(out int birthyear)
    {
        Console.Write("What is your birth year? ");
        birthyear = int.Parse(Console.ReadLine());
    }

    static int SquareUserNumber(int userNumber)
    {
        int numberSquared = userNumber * userNumber;
        return numberSquared;
    }

    static void DisplayResult(string userName, int squaredNumber, int birthyear)
    {
        Console.WriteLine($"{userName} your number squared is {squaredNumber}.");
        Console.WriteLine($"You will turn {2026 - birthyear} years old this year. ");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();

        int favoriteNumber = PromptUserNumber();
        int squaredUserNumber = SquareUserNumber(favoriteNumber);

        int birthyear;
        PromptBirthYear(out birthyear);

        DisplayResult(userName, squaredUserNumber, birthyear);
    }
}