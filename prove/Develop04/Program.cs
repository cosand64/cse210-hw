using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        int breathingCount = 0;
        int reflectionCount = 0;
        int listingCount = 0;

        while (choice != "5")
        {
            Console.CursorVisible = true; 
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. View activity log");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity(
                    "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."
                );
                breathing.RunActivity();
                breathingCount++; 
            }
            else if (choice == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity(
                    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
                );
                reflection.RunActivity();
                reflectionCount++; 
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity(
                    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
                );
                listing.RunActivity();
                listingCount++; 
            }
            else if (choice == "4")
            {
                Console.Clear();
                Console.WriteLine("--- Activity Log ---");
                Console.WriteLine($"The Breathing Activity performed:  {breathingCount} times");
                Console.WriteLine($"The Reflection Activity performed: {reflectionCount} times");
                Console.WriteLine($"The Listing Activity performed:    {listingCount} times");
                Console.WriteLine("--------------------");
                Console.WriteLine("\nPress Enter to return to the main menu.");
                Console.ReadLine();
            }
            else if (choice != "5")
            {
                Console.WriteLine("\nInvalid option. Please press Enter and try again.");
                Console.ReadLine();
            }
        }
    }
}