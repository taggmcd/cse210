class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string type, string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address, type)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetSpeaker()
    {
        return _speaker;
    }

    public int GetCapacity()
    {
        return _capacity;
    }
}