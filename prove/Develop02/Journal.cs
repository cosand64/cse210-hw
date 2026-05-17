class Journal
{
    List<JournalEntry> _journalEntries = new List<JournalEntry>();

    public void AddJournalEntry(JournalEntry journalEntry)
    {
        _journalEntries.Add(journalEntry);
    }

    public void DisplayJournal()
    {
        if (_journalEntries.Count == 0)
        {
            Console.WriteLine("There are currently no entries in the Journal. ");
            return;
        }

        foreach (JournalEntry journalEntry in _journalEntries)
        {
            journalEntry.DisplayJournalEntry();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in _journalEntries)
            {
                outputFile.WriteLine(entry.CreateFileSystemString());
            }
        }

        Console.WriteLine("Journal saved successfully");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File does not exist.");
        }

        _journalEntries.Clear();

        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {

            string[] parts = line.Split('#');
            if (parts.Length == 3)
            {
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];

                JournalEntry loadedEntry = new JournalEntry(date, prompt, response);
                _journalEntries.Add(loadedEntry);
            }
        }

        Console.WriteLine("Journal loaded successfully!");

    }
}