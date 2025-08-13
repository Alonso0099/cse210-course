public abstract class Goal
{
    protected string _name;
    protected string _desc;
    protected int _points;

    // "constructor"
    public Goal(string name, string desc, int points)
    {
        _name = name;
        _desc = desc;
        _points = points;
    }

    // "record progress and return points"
    public abstract int RecordEvent();

    // "show goal status"
    public abstract string GetStatus();

    // "convert goal to file format"
    public abstract string ToCSV();
}

