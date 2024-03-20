using System.Collections.Generic;

public class Scripture
{
    Reference _reference;
    private List<Word> _words = new List<Word>();

    // Constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        // Assuming text contains space-separated words
        string[] wordArray = text.Split(' ');
        foreach (string wordText in wordArray)
        {
            _words.Add(new Word(wordText));
        }
    }
     public int WordCount
    {
        get { return _words.Count; }
    }


    // Method to hide a specified number of random words
    public void HideRandomWords(int numberToHide)
    {
        Random random = new();
        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(0, _words.Count);
            _words[index].Hide();
        }
    }



    // Method to get the display text of the scripture
    public string GetDisplayText()
    {
        List<string> displayedWords = new List<string>();
        foreach (Word word in _words)
        {
            displayedWords.Add(word.IsHidden() ? "____" : word.GetText());
        }
        return string.Join(" ", displayedWords);
    }

    // Method to check if all words are completely hidden
    public bool isCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}