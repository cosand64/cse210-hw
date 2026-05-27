// Word class will contain the word. if the word is hidden, GetWordString
// Will return _characters - one for each character in the word

class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

// Return either the word, if not hidden, or the _string
    public string GetWordString()
    {
        string tempWord = "";
        if (_hidden)
        {
            foreach(char c in _word)
            {
                tempWord += '_';
            }
        }
        else
        {
            tempWord = _word;
        }
        return tempWord;
    }

// Hide the word
    public void HideWord()
    {
        _hidden = true;
    }

// Find out if the word is hidden
    public bool IsHidden()
    {
        return _hidden;
    }

    public void DisplayWord()
    {
        Console.WriteLine(GetWordString());
    }
}