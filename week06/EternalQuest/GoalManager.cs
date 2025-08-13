public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    // "add goal to list"
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    // "show all goals and score"
    public void DisplayGoals()
    {
        Console.WriteLine($"\nTotal Score: {_score}");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
    }

    // "record progress and update score"
    public void RecordEvent(int index)
    {
        if (index >= 0 && index < _goals.Count)
        {
            int points = _goals[index].RecordEvent();
            _score += points;
            Console.WriteLine($"You earned {points} points!");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    // "save score and goals to file"
    public void Save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.ToCSV());
            }
        }
        Console.WriteLine("Goals saved to file.");
    }

    // "load score and goals from file"
    public void Load(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _goals.Clear();

        try
        {
            _score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(",");
                string type = parts[0];
                string name = parts[1];
                string desc = parts[2];

                if (type == "SimpleGoal")
                {
                    int points = int.Parse(parts[3]);
                    bool complete = bool.Parse(parts[4]);
                    _goals.Add(new SimpleGoal(name, desc, points, complete));
                }
                else if (type == "EternalGoal")
                {
                    int points = int.Parse(parts[3]);
                    _goals.Add(new EternalGoal(name, desc, points));
                }
                else if (type == "ChecklistGoal")
                {
                    int points = int.Parse(parts[3]);
                    int target = int.Parse(parts[4]);
                    int progress = int.Parse(parts[5]);
                    int bonus = int.Parse(parts[6]);
                    _goals.Add(new ChecklistGoal(name, desc, points, target, progress, bonus));
                }
                else if (type == "NegativeGoal")
                {
                    int penalty = int.Parse(parts[3]);
                    _goals.Add(new NegativeGoal(name, desc, penalty));
                }
            }

            Console.WriteLine("Goals loaded from file.");
            DisplayGoals(); 
        }
        catch
        {
            Console.WriteLine("Error loading file. Please check formatting.");
        }
    }
}





