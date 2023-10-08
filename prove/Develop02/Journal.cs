public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        Entry entry = new Entry();
        DateTime theCurrentTime = DateTime.Now;
        entry._date = theCurrentTime.ToShortDateString();
        entry._prompt = new PromptGenerator()._prompt.ToString();

        Console.WriteLine($"Date: {entry._date}");
        Console.Write("What is your current mood? ");
        entry._mood = Console.ReadLine();
        Console.WriteLine($"Your prompt is: {entry._prompt}");
        Console.Write("> ");
        entry._entry = Console.ReadLine();
        _entries.Add(entry);
    }

    public void LoadEntries()
    {
        string filename = "journal.csv";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            if (line != "sep=|")
            {
                Entry journalEntry = new Entry();
                string[] parts = line.Split("|");
                if (parts[0] != "Date")
                {
                    journalEntry._date = parts[0];
                    journalEntry._prompt = parts[1];
                    journalEntry._mood = parts[2];
                    journalEntry._entry = parts[3];

                    _entries.Add(journalEntry);
                }
            }
        }
    }

    public void SaveEntries()
    {
        string fileName = "journal.csv";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine("sep=|");
            outputFile.WriteLine($"Date| Writing Prompt| Mood| Entry");
            foreach (Entry journalEntry in _entries)
            {
                outputFile.WriteLine($"{journalEntry._date}|{journalEntry._prompt}|{journalEntry._mood}|{journalEntry._entry}");
            }
        }
    }

    public void DisplayEntries()
    {
        foreach (Entry journalEntry in _entries)
        {
            journalEntry.Display();
        }
    }
}