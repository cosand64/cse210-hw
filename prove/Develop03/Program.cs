using System;

class Program
{
    static void Main(string[] args)
    {
        Word myWord = new Word("hello");
        Console.WriteLine(myWord.GetWordString());

        myWord.HideWord();
        Console.WriteLine(myWord.GetWordString());

        myWord.DisplayWord();
        if (myWord.IsHidden())
        {
            Console.WriteLine(myWord.GetWordString());
        }

    }
}