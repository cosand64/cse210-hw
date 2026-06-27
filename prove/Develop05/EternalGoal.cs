class EternalGoal : BaseGoal
{
    private int _numberOfCompletions;

    public EternalGoal() : base()
    {
        _numberOfCompletions = 0;
    }

    public EternalGoal(string name, string description, int points, bool status, int completions) : base(name, description, points, status, "EternalGoal")
    {
        _numberOfCompletions = completions;
    }

    public override void CreateGoal()
    {
        SetName();
        SetDescription();
        SetNumberOfPoints();
        _numberOfCompletions = 0;
    }

    public override int RecordEvent()
    {
        _numberOfCompletions++;
        return GetPoints(); 
    }

    public override string GetDisplayString()
    {
        return $"[ ] Name: {GetName()}, Description: {GetDescription()}, Points: {GetPoints()} (Completed: {_numberOfCompletions} times)";
    }

    public override string GetFileSystemString()
    {
        return $"{GetType().Name}:{GetName()},{GetDescription()},{GetPoints()},{GetStatus()},{_numberOfCompletions}";
    }
}