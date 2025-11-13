using System;

public class Word
{
    // Private attributes (DEFINED ONLY ONCE)
    private string _text;
    private bool _isHidden; 

    // Constructor (DEFINED ONLY ONCE)
    public Word(string text)
    {
        _text = text;
        _isHidden = false; 
    }

    // Public Behaviors (DEFINED ONLY ONCE)
    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            // Returns underscores based on the word length
            return new string('_', _text.Length);
        }
        else
        {
            // Returns the actual word
            return _text;
        }
    }
}