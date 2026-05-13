class JournalEntry
{
    string _date;
    string _prompt;
    string _response;

    string[] _prompts =
    {
        "How are you feeling today?",
        "Who did you talk with today?"
    };

// Finish code - need more prompts
    public void CreateJournalEntry()
    {
        _date = DateTime.Now.ToShortDateString();

        // Finish this code - need a random prompt
        _prompt = _prompts[0];
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