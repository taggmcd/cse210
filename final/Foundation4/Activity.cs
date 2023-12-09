class Activity
{
    private DateOnly _date;
    protected int _duration;
    private string _type;

    public Activity(DateOnly date, int duration, string type)
    {
        _date = date;
        _duration = duration;
        _type = type;
    }

    public string GetSummary()
    {
        return $"{_date:dd} {_date:MMM} {_date.Year} {_type} ({_duration} min): Distance {this.GetDistance()} km, Speed: {this.GetSpeed()} kph, Pace: {this.GetPace()} min per km";
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }
}