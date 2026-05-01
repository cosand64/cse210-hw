using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (userNumber != 0)
        {
            Console.Write("Enter number ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int total = 0;
        int biggestNumber = 0;
        foreach (int number in numbers)
        {
            total += number;

            if (number > biggestNumber)
            {
                biggestNumber = number;
            }
        }

        float average = ((float)total) / numbers.Count;


        Console.WriteLine($"The sum is {total}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {biggestNumber}");
    }
}