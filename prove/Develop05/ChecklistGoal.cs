using System.Drawing;

class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _eventCount;
    private int _bonusValue;

    public ChecklistGoal(string name, string description, int pointValue, int targetCount, int bonusValue) : base(name, description, pointValue)
    {
        _targetCount = targetCount;
        _bonusValue = bonusValue;
    }

    override public void SetCompleted()
    {
        _completed = true;
    }
    override public void SetEventCount(int count)
    {
        _eventCount = count;
    }

    override public bool IsCompleted()
    {
        return _completed;
    }
    override public string Serialize()
    {
        return "ChecklistGoal," + _name + "," + _description + "," + _pointValue + "," + IsCompleted() + "," + _eventCount + "," + _targetCount + "," + _bonusValue;
    }

    override public void SetPoints()
    {
        _points = _eventCount * _pointValue;

        if (_completed)
        {
            _points += _bonusValue;
        }
    }

    override public void Record()
    {
        if (_eventCount < _targetCount)
        {
            _eventCount++;
            if (_eventCount == _targetCount)
            {
                _completed = true;
            }
        }
        SetPoints();
    }

    override public string PrintGoal()
    {
        return _name + " (" + _description + ") " + " -- Completed " + _eventCount + "/" + _targetCount;
    }

}