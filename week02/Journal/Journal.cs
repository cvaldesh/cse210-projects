// Journal.cs

using System.Collections.Generic;
using System.IO;

public class Journal
{
    // A list to hold all the Entry objects
    public List<Entry> _entries = new List<Entry>();

    // A list of prompts
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is one thing I accomplished today?"
    };

    // Method to create and add a new entry
    public void AddEntry()
    {
        // 1. Get a random prompt
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        string selectedPrompt = _prompts[index];

        // 2. Display the prompt and get the response
        Console.WriteLine($"\n{selectedPrompt}");
        Console.Write("> ");
        string response = Console.ReadLine();

        // 3. Get the current date as a simple string
        string date = DateTime.Now.ToShortDateString();

        // 4. Create the new Entry object
        Entry newEntry = new Entry();
        newEntry._date = date;
        newEntry._promptText = selectedPrompt;
        newEntry._responseText = response;

        // 5. Add it to the list
        _entries.Add(newEntry);
        Console.WriteLine("\nEntry saved successfully!");
    }

    // Method to display all entries
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("\nThe journal is currently empty.");
            return;
        }

        Console.WriteLine("\n--- Journal Entries ---");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
        Console.WriteLine("-----------------------");
    }

    // Method to save the journal to a file
    public void SaveToFile(string filename)
    {
        try
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                // Iterate through the entries and write the formatted string to the file
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine(entry.ToStringForFile());
                }
            }
            Console.WriteLine($"\nJournal saved to '{filename}' successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving: {ex.Message}");
        }
    }

    // Method to load the journal from a file
    public void LoadFromFile(string filename)
    {
        try
        {
            // Clear existing entries before loading new ones
            _entries.Clear();

            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                // Split the line using the pipe '|' separator
                string[] parts = line.Split('|');

                // Check if we have the 3 expected parts
                if (parts.Length == 3)
                {
                    // Create a new entry and assign the parts
                    Entry newEntry = new Entry();
                    newEntry._date = parts[0];
                    newEntry._promptText = parts[1];
                    newEntry._responseText = parts[2];

                    _entries.Add(newEntry);
                }
            }
            Console.WriteLine($"\nJournal loaded from '{filename}' successfully. Total entries: {_entries.Count}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"\nError: The file '{filename}' was not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred while loading: {ex.Message}");
        }
    }
}