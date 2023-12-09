class Biking : Activity
{
    private double _speed;

    public Biking(DateOnly date, int duration, string type, double speed) : base(date, duration, type)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return Math.Round(_speed * (_duration / 60), 2);
    }

    public override double GetSpeed()
    {
        return Math.Round(_speed, 2);
    }

    public override double GetPace()
    {
        return Math.Round(60 / _speed, 2);
    }
}