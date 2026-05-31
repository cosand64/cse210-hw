using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a library of scriptures
        List<Scripture> scriptureLibrary = new List<Scripture>();

        scriptureLibrary.Add(new Scripture("Proverbs", 3, 5, 6, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."));
        scriptureLibrary.Add(new Scripture("John", 3, 16, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."));
        scriptureLibrary.Add(new Scripture("Philippians", 4, 13, "I can do all things through Christ which strengtheneth me."));
        scriptureLibrary.Add(new Scripture("2 Timothy", 1, 7, "For God hath not given us the spirit of fear; but of power, and of love, and of a sound mind."));

        // Select a random scripture
        Random random = new Random();
        int randomIndex = random.Next(scriptureLibrary.Count);
        Scripture selectedScripture = scriptureLibrary[randomIndex];

        string userInput = "";

        // Main program loop
        while (userInput.ToLower() != "quit")
        {
            Console.Clear();
            selectedScripture.ShowScripture();
            Console.WriteLine();
            
            // Prompt the user for input
            Console.WriteLine("Press Enter to hide words, or type 'quit' to exit:");
            userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }

            // Hide words and check if everything is hidden
            bool allWordsHidden = selectedScripture.HideSomeWords();

            // If everything is hidden end the program
            if (allWordsHidden)
            {
                Console.Clear();
                selectedScripture.ShowScripture();
                Console.WriteLine();
                Console.WriteLine("You are done! I hope you succeeded");
                break;
            }
        }
    }
}