// A goal that never ends. You get points every time you do it.
public class EternalGoal : Goal
{
    // "constructor"
    public EternalGoal(string name, string desc, int points)
        : base(name, desc, points)
    {
    }

    // "always gives points"
    public override int RecordEvent()
    {
        return _points;
    }

    // "show infinite symbol"
    public override string GetStatus()
    {
        return $"[∞] {_name} ({_desc})";
    }

    // "convert to file format"
    public override string ToCSV()
    {
        return $"EternalGoal,{_name},{_desc},{_points}";
    }
}

