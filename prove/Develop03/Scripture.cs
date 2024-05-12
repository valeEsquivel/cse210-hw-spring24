using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;

        _words = new List<Word>();
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        int totalWords = _words.Count;

        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(0, totalWords);

            if (_words[index].IsHidden())
            {
                i--;
                continue;
            }
            _words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText;
    }

    public bool IsComplete()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                return false;
            } else {
                return true;
            }
        }
        return true;
    }
}