class ScriptureReference
{
    private string _bookName;
    private int _chapter;
    private int _verse;
    private int _startVerse;
    private int _endVerse;

    public ScriptureReference(string bookName, int chapter, int verse)
    {
        _bookName = bookName;
        _chapter = chapter;
        _verse = verse;
    }
    public ScriptureReference(string bookName, int chapter, int startVerse, int endVerse)
    {
        _bookName = bookName;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    // return a formatted string of the scripture reference.
    public string GetScriptureReferenceString()
    {
        if (_endVerse > 0)
        {
            return $"{_bookName}, {_chapter}: {_startVerse}-{_endVerse}";
        }
        else
        {
            return $"{_bookName}, {_chapter}: {_verse}";
        }
    }

    // send the reference to the console
    public void ShowScriptureReference()
    {
        Console.Write(GetScriptureReferenceString() + " ");
    }

}