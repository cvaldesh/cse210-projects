using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Setup the initial scripture
        // We are using a single-verse reference for simplicity in the setup.
        Reference reference = new Reference("John", 3, 16);
        string text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        
        // The Scripture object handles the words and the hiding logic.
        Scripture scripture = new Scripture(reference, text);

        string userInput = "";

        // Main Loop: Continues until user types 'quit' OR all words are hidden
        while (userInput.ToLower() != "quit" && !scripture.IsCompletelyHidden()) 
        {
            // 3. Clear the screen and display the current scripture text
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            // 4. Prompt the user
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to end.");
            userInput = Console.ReadLine();

            if (userInput.ToLower() != "quit")
            {
                // 6. Hide 3 random words if the user presses Enter
                scripture.HideRandomWords(3); 
            }
        }
        
        // Final display when the loop ends
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nProgram finished."); 
    }
}