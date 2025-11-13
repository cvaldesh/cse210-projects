using System;
using System.Collections.Generic;
using System.Linq; // Required for the .All() and .Where() functions

public class Scripture
{
    // 1. Private attributes for the Scripture class
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    // 2. Constructor for the Scripture class
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Logic to split the text into Word objects (encapsulation principle)
        string[] wordStrings = text.Split(new char[] { ' ', ',', '.', ':', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string wordString in wordStrings)
        {
            Word word = new Word(wordString);
            _words.Add(word);
        }
    }

    // 3. Behaviors (Methods) for the Scripture class

    // Hides a specified number of random words that are NOT already hidden (Stretch Goal)
    public void HideRandomWords(int numberToHide)
    {
        List<Word> unhiddenWords = _words.Where(w => !w.IsHidden()).ToList();

        if (unhiddenWords.Count == 0) return;

        int wordsToHide = Math.Min(numberToHide, unhiddenWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = _random.Next(0, unhiddenWords.Count);
            Word wordToHide = unhiddenWords[index];
            
            wordToHide.Hide();
            unhiddenWords.RemoveAt(index);
        }
    }

    // Gets the full string for display (Reference + words)
    public string GetDisplayText()
    {
        string referenceDisplay = _reference.GetDisplayText();
        List<string> wordDisplays = new List<string>();

        foreach (Word word in _words)
        {
            wordDisplays.Add(word.GetDisplayText());
        }

        return $"{referenceDisplay} - {string.Join(" ", wordDisplays)}";
    }

    // Checks if every single word in the list is hidden
    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}