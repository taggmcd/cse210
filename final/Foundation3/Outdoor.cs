class Outdoor : Event
{
    private string _weather;

    public Outdoor(string type, string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address, type)
    {
        _weather = weather;
    }

    public string GetWeather()
    {
        return _weather;
    }
}