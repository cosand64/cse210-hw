using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());

        Random random= new Random();
        Fraction randomFraction = new Fraction();
        for (int i = 0; i < 20; i++)
        {
            int topValue = random.Next(1, 11);
            int bottomValue = random.Next(1, 11);
            randomFraction.SetTop(topValue);
            randomFraction.SetBottom(bottomValue);
            Console.Write($"Fraction {i + 1}: ");
            Console.Write($"string: {randomFraction.GetFractionString()}");
            Console.WriteLine($" Number: {randomFraction.GetDecimalValue()}");
        }
    }
}