using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        bool running = true;

        Console.WriteLine("Welcome to the Journal Program!");

        while (running)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    JournalEntry newEntry = new JournalEntry();
                    newEntry.CreateJournalEntry();
                    myJournal.AddJournalEntry(newEntry);
                    break;

                case "2":
                    myJournal.DisplayJournal();
                    break;

                case "3":
                    Console.Write("What is the filename? ");
                    string loadFilename = Console.ReadLine();
                    myJournal.LoadFromFile(loadFilename);
                    break;

                case "4":
                    Console.Write("What is the filename? ");
                    string saveFilename = Console.ReadLine();
                    myJournal.SaveToFile(saveFilename);
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please enter a number from 1 to 5.");
                    break;
            }

            Console.WriteLine();
        }
    }
}