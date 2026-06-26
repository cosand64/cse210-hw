class SimpleGoal : BaseGoal
{
    public SimpleGoal() : base()
    {
        
    }

    public SimpleGoal(string name, string description, int points, bool status) : base(name, description, points, status, "SimpleGoal")
    {
        
    }

    public override void CreateGoal()
    {
        SetName();
        SetDescription();
        SetNumberOfPoints();
    }

    public override int RecordEvent()
    {
        return MarkComplete();
    }
}