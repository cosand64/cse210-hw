using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string fristName;
        fristName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {fristName} {lastName}.");

        int x = 10;

        if(x == 10)
        {
            Console.WriteLine("10");
        }
        else if (x != 10)
        {
            Console.WriteLine("no");
        }
        else
        {
            Console.WriteLine("how");
        }
    }
}