using System.Drawing;

class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int pointValue) : base(name, description, pointValue)
    {

    }

    override public bool IsCompleted()
    {
        return _completed;
    }
    override public string Serialize()
    {
        return "SimpleGoal," + _name + "," + _description + "," + _pointValue + "," + IsCompleted();
    }

    override public void SetPoints()
    {
        if (_completed)
        {
            _points = _pointValue;
        }
    }

    override public void Record()
    {
        _completed = true;
        SetPoints();
    }

    override public string PrintGoal()
    {
        return _name + " (" + _description + ")";
    }
}