using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 101);
        
        int usersGuess = 0;

        while (usersGuess != randomNumber)
        {
            Console.Write("What is your guess at the magic number? ");
            usersGuess = int.Parse(Console.ReadLine());

            if (usersGuess > randomNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (usersGuess < randomNumber)
            {
                Console.WriteLine("Higher");
            }
        }

        Console.WriteLine("You Guessed it!");

    }
}