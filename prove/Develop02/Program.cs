using System;

class Program
{
    static void Main(string[] args)
    {
        JournalEntry myJournalEntry = new JournalEntry();
        myJournalEntry.CreateJournalEntry();
        myJournalEntry.DisplayJournalEntry();
    }
}