
using System.Threading.Tasks.Dataflow;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _firstVerse;
    private string _lastVerse;
    private List<string> _text = new List<string>();

    public Reference(string reference)
    {
        _book = reference.Split(" ")[0];
        _chapter = reference.Split(" ")[1].Split(":")[0];
        if (reference.Split(" ")[1].Split(":")[1].Contains("-"))
        {
            _firstVerse = reference.Split(" ")[1].Split(":")[1].Split("-")[0];
            _lastVerse = reference.Split(" ")[1].Split(":")[1].Split("-")[1];
        }
        else
        {
            _firstVerse = reference.Split(" ")[1].Split(":")[1];
        }
    }

    public string Text()
    {
        if (_lastVerse != null)
        {
            return $"{_book} {_chapter}:{_firstVerse}-{_lastVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_firstVerse}";
        }
    }
}