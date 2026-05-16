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
        // using (StreamWriter)
    }
}