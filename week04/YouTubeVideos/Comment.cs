using System;

public class Comment
{
    private string _name;
    private string _text;

    // Constructor
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    // Display method
    public void DisplayComment()
    {
        Console.WriteLine($" - {_name}: {_text}");
    }
}
