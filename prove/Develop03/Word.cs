
using System.Text;

public class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }
    public void SetWord(string word)
    {
        _word = word;
    }

    public string GetWord()
    {
        if (_hidden)
        {
            var hiddenWord = new StringBuilder();
            foreach (char letter in _word)
            {
                hiddenWord.Append('_');
            }
            _word = hiddenWord.ToString();
        }

        return _word;
    }

    public void SetHidden()
    {
        _hidden = true;
    }

    public bool IsHidden()
    {
        return _hidden;
    }
}