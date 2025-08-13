public class SimpleGoal : Goal
{
    private bool _isComplete;

    // "constructor"
    public SimpleGoal(string name, string desc, int points, bool isComplete = false)
        : base(name, desc, points)
    {
        _isComplete = isComplete;
    }

    // "mark complete and return points"
    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    // "show status with checkmark"
    public override string GetStatus()
    {
        return $"[ {( _isComplete ? "X" : " " )} ] {_name} ({_desc})";
    }

    // "convert to file format"
    public override string ToCSV()
    {
        return $"SimpleGoal,{_name},{_desc},{_points},{_isComplete}";
    }
}


