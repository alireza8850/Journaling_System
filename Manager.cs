namespace App;

public class Manager
{
    private const string JournalFile = "Journals.txt";
    private List<Journal> Journals = new List<Journal>();

    public void NewJournal()
    {
        Console.Clear();
        Console.WriteLine("1. Titel: ");
        string? title = Console.ReadLine();
        Console.WriteLine("2. Innehål.");
        string? content = Console.ReadLine();
        Console.WriteLine("3. Resultat");
        string? result = Console.ReadLine();
        Console.WriteLine("4. Taggar");
        string? tags = Console.ReadLine();
        
        
        
    }




}