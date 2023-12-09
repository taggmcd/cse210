class Swimming : Activity
{
    private double _laps;

    public Swimming(DateOnly date, int duration, string type, double laps) : base(date, duration, type)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return Math.Round(_laps * 50 / 1000, 2);
    }

    public override double GetSpeed()
    {
        return Math.Round((this.GetDistance() / _duration) * 60, 2);
    }

    public override double GetPace()
    {
        return Math.Round(_duration / this.GetDistance(), 2);
    }
}