class CheckListGoal : BaseGoal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal() : base()
    {
        _amountCompleted = 0;
    }

    public CheckListGoal(string name, string description, int points, bool status, int bonus, int target, int amountCompleted) : base(name, description, points, status, "CheckListGoal")
    {
        _bonus = bonus;
        _target = target;
        _amountCompleted = amountCompleted;
    }

    public override void CreateGoal()
    {
        SetName();
        SetDescription();
        SetNumberOfPoints();
        
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _target = int.Parse(Console.ReadLine());
        
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonus = int.Parse(Console.ReadLine());
        
        _amountCompleted = 0;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        
        if (_amountCompleted >= _target)
        {
            return GetPoints() + _bonus;
        }
        else
        {
            return GetPoints();
        }
    }

    public override string GetDisplayString()
    {
        char statusMarker = ' ';
        if (_amountCompleted >= _target) statusMarker = 'X';
        
        return $"[{statusMarker}] Name: {GetName()}, Description: {GetDescription()} -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetFileSystemString()
    {
        return $"{GetType().Name}:{GetName()},{GetDescription()},{GetPoints()},{GetStatus()},{_bonus},{_target},{_amountCompleted}";
    }
}