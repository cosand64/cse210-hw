class Scripture
{
    private List<Word> _words;
    private ScriptureReference _reference;

    public Scripture(string name, int chapter, int verse, string text)
    {
        _reference = new ScriptureReference(name, chapter, verse);
        _words = ConvertToWords(text);
    }
    public Scripture(string name, int chapter, int startVerse, int endVerse, string text)
    {
        _reference = new ScriptureReference(name, chapter, startVerse, endVerse);
        _words = ConvertToWords(text);
    }
    public Scripture(ScriptureReference refs, string text)
    {
        _reference = refs;
        _words = ConvertToWords(text);
    }

    // Splits the raw text into individual Word objects and returns them as a list
    private List<Word> ConvertToWords(string text)
    {
        List<Word> wordList = new List<Word>();
        string[] splitText = text.Split(' ');

        foreach (string rawWord in splitText)
        {
            wordList.Add(new Word(rawWord));
        }

        return wordList;
    }

    // Returns the formatted reference string
    public string GetScriptureReference()
    {
        return _reference.GetScriptureReferenceString();
    }

    // Counts and returns how many words are currently hidden
    private int NumberOfHiddenWords()
    {
        int hiddenCount = 0;
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                hiddenCount++;
            }
        }
        return hiddenCount;
    }

    // Hides a few random words and returns true if all words are hidden
    public bool HideSomeWords()
    {
        // Checks for hidden words
        List<int> availableIndices = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                availableIndices.Add(i);
            }
        }

        // Return true when there is nothing left to hide
        if (availableIndices.Count == 0)
        {
            return true;
        }

        Random random = new Random();
        // Set words to hide
        int wordsToHideThisTurn = Math.Min(3, availableIndices.Count);

        for (int i = 0; i < wordsToHideThisTurn; i++)
        {
            int randomListIndex = random.Next(availableIndices.Count);
            int actualWordIndex = availableIndices[randomListIndex];

            _words[actualWordIndex].HideWord();
            
            availableIndices.RemoveAt(randomListIndex); 
        }

        return NumberOfHiddenWords() == _words.Count;
    }

    // Displays the reference and the current state of the text
    public void ShowScripture()
    {
        Console.Write($"{GetScriptureReference()} ");
        
        foreach (Word word in _words)
        {
            Console.Write(word.GetWordString() + " ");
        }
        
        Console.WriteLine();
    }
}