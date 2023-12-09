class Running : Activity
{
    private double _distance;

    public Running(DateOnly date, int duration, string type, double distance) : base(date, duration, type)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return Math.Round(_distance, 2);
    }

    public override double GetSpeed()
    {
        return Math.Round((_distance / _duration) * 60, 2);
    }

    public override double GetPace()
    {
        return Math.Round(60 / this.GetSpeed(), 2);
    }
}