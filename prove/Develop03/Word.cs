using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (IsHidden())
        {
            for (int i = 0; i < _text.Length; i++)
            {
                if (_text[i] != ' ')
                {
                    _text = _text.Remove(i, 1);
                    _text = _text.Insert(i, "_");
                }
            }
            return _text;
        }
        else
        {
            return _text;
        }
    }
}