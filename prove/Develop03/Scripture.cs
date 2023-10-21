using System.Text;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(string reference, string scripture)
    {
        _reference = new Reference(reference);

        string[] words = scripture.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public string Text()
    {
        var text = new StringBuilder();
        foreach (var word in _words)
        {
            text.Append(word.GetWord() + " ");
        }

        return $"{_reference.Text()}\n{text.ToString()}";
    }

    public void HideRandom()
    {
        List<Word> unhiddenWords = _words.Where(word => !word.IsHidden()).ToList();
        if (unhiddenWords.Count() >= 0)
        {
            unhiddenWords[new Random().Next(unhiddenWords.Count())].SetHidden();
        }
    }
    public bool AllHidden()
    {
        return _words.All(word => word.IsHidden());
    }

}