class EternalGoal : Goal
{
    private int _eventCount;

    public EternalGoal(string name, string description, int pointValue) : base(name, description, pointValue)
    {

    }

    override public void SetEventCount(int count)
    {
        _eventCount = count;
    }
    override public bool IsCompleted()
    {
        return false;
    }
    override public string Serialize()
    {
        return "EternalGoal," + _name + "," + _description + "," + _pointValue + "," + IsCompleted() + "," + _eventCount;
    }

    override public void SetPoints()
    {
        _points = _eventCount * _pointValue;
    }

    override public void Record()
    {
        _eventCount++;
        SetPoints();
    }

    override public string PrintGoal()
    {
        return _name + " (" + _description + ")";
    }

}