// Entry.cs

public class Entry
{
    // Member variables (using public for simplicity in a beginner project)
    public string _date;
    public string _promptText;
    public string _responseText;

    // Method to display the entry nicely
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_responseText}");
        Console.WriteLine("--------------------------");
    }

    // Method to format the entry for saving to a file. 
    // We'll use the pipe '|' as the separator.
    public string ToStringForFile()
    {
        return $"{_date}|{_promptText}|{_responseText}";
    }
}