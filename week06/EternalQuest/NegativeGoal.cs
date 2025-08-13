// A goal that gives a penalty. You lose points when you trigger it.
public class NegativeGoal : Goal
{
    // "constructor"
    public NegativeGoal(string name, string desc, int penalty)
        : base(name, desc, penalty)
    {
    }

    // "subtract points"
    public override int RecordEvent()
    {
        return -_points;
    }

    // "show penalty"
    public override string GetStatus()
    {
        return $"[!] {_name} ({_desc}) — Penalty: {_points}";
    }

    // "convert to file format"
    public override string ToCSV()
    {
        return $"NegativeGoal,{_name},{_desc},{_points}";
    }
}

