// Program.cs

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Create one instance of the Journal class
        Journal myJournal = new Journal();
        string userChoice = "";

        Console.WriteLine("Welcome to the Simple Prompt Journal Program!");

        while (userChoice != "5")
        {
            // Display the menu
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            userChoice = Console.ReadLine();

            // Handle the user's choice
            switch (userChoice)
            {
                case "1":
                    // Write a new entry
                    myJournal.AddEntry();
                    break;

                case "2":
                    // Display the journal
                    myJournal.DisplayAll();
                    break;

                case "3":
                    // Save the journal
                    Console.Write("Enter the filename to save (e.g., myjournal.txt): ");
                    string saveFile = Console.ReadLine();
                    myJournal.SaveToFile(saveFile);
                    break;

                case "4":
                    // Load the journal
                    Console.Write("Enter the filename to load: ");
                    string loadFile = Console.ReadLine();
                    myJournal.LoadFromFile(loadFile);
                    break;

                case "5":
                    // Quit
                    Console.WriteLine("\nThank you for journaling! Goodbye.");
                    break;

                default:
                    // Invalid choice
                    Console.WriteLine("\nInvalid choice. Please enter a number from 1 to 5.");
                    break;
            }
        }
    }
}