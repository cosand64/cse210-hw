class SimpleGoal : BaseGoal
{
    public SimpleGoal() : base()
    {
        
    }

    public override void CreateGoal()
    {
        SetName();
        SetDescription();
        SetNumberOfPoints();
    }

    public override void RecordEvent()
    {
        MarkComplete();
    }
}