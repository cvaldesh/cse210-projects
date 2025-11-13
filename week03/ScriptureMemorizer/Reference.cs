public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse; 

    // Constructor 1: For a single verse (e.g., John 3:16)
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = 0; // Use 0 to indicate no end verse
    }

    // Constructor 2: For a verse range (e.g., Proverbs 3:5-6)
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    // Behavior: Returns the properly formatted reference string
    public string GetDisplayText()
    {
        if (_endVerse == 0)
        {
            // Format: Book Chapter:Verse (e.g., John 3:16)
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            // Format: Book Chapter:StartVerse-EndVerse (e.g., Proverbs 3:5-6)
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }
}