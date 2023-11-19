class Goal
{
    protected int _pointValue;
    protected int _points;
    protected string _name;
    protected string _description;

    protected bool _completed;

    public Goal(string name, string description, int pointValue)
    {
        _name = name;
        _description = description;
        _pointValue = pointValue;
    }

    public int GetPoints()
    {
        return _points;
    }
    virtual public void SetCompleted()
    {
        _completed = true;
    }
    virtual public void SetEventCount(int count)
    {

    }
    virtual public bool IsCompleted()
    {
        return _completed;
    }
    virtual public string Serialize()
    {
        return "";
    }

    virtual public void SetPoints()
    {

    }

    virtual public void Record()
    {

    }

    virtual public string PrintGoal()
    {
        return "";
    }
}