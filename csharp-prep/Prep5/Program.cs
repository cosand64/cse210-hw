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

    static int PromptFavoriteNumber()
    {
        Console.Write("What is your favorite whole number? ");
        int favoriteNumber = int.Parse(Console.ReadLine());
        return favoriteNumber;
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favoriteNumber = PromptFavoriteNumber();
    }
}