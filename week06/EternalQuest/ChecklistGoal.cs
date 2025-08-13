// A goal that must be done several times to finish.
// You get points each time, and a bonus when it's complete.
public class ChecklistGoal : Goal
{
    private int _target;
    private int _progress;
    private int _bonus;

    // "constructor"
    public ChecklistGoal(string name, string desc, int points, int target, int progress, int bonus)
        : base(name, desc, points)
    {
        _target = target;
        _progress = progress;
        _bonus = bonus;
    }

    // "add progress and return points"
    public override int RecordEvent()
    {
        if (_progress < _target)
        {
            _progress++;
            if (_progress == _target)
            {
                return _points + _bonus;
            }
            return _points;
        }
        return 0;
    }

    // "show progress count"
    public override string GetStatus()
    {
        string check = (_progress >= _target) ? "X" : " ";
        return $"[ {check} ] {_name} ({_desc}) — Completed {_progress}/{_target}";
    }

    // "convert to file format"
    public override string ToCSV()
    {
        return $"ChecklistGoal,{_name},{_desc},{_points},{_target},{_progress},{_bonus}";
    }
}


