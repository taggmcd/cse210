using System.Threading.Tasks.Dataflow;

public class Entry
{
    public string _date;
    public string _entry;
    public string _prompt;

    public string _mood;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} Mood: {_mood}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Entry: \n{_entry}\n");
    }
}