class JournalEntry
{
    string _date;
    string _prompt;
    string _response;

    string[] _prompts =
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "How are you feeling today?",
        "Who did you talk with today?"
    };

    public JournalEntry() 
    {
    }

    public JournalEntry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public void CreateJournalEntry()
    {
        _date = DateTime.Now.ToShortDateString();

        Random random = new Random();
        int index = random.Next(_prompts.Length);
        _prompt = _prompts[index];
        
        Console.WriteLine(_prompt);
        _response = Console.ReadLine();
    }


    public void DisplayJournalEntry()
        {
            Console.WriteLine($"{_date}, {_prompt}, {_response}");
        }

    public string CreateFileSystemString()
    {
        return $"{_date}#{_prompt}#{_response}";
    }
}