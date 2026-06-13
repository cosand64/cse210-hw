using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "4")
        {
            Console.CursorVisible = true;
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity(
                    "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."
                );
                breathing.RunActivity();
            }
            else if (choice == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity(
                    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
                );
                reflection.RunActivity();
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity(
                    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
                );
                listing.RunActivity();
            }
            else if (choice != "4")
            {
                Console.WriteLine("\nInvalid option. Please press Enter and try again.");
                Console.ReadLine();
            }
        }
    }
}