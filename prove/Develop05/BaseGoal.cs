using System.Runtime.Intrinsics.X86;

abstract class BaseGoal
{
    private string _name;
    private string _description;
    private int _numberOfPoints;
    private bool _status;
    private string _goalType;

    public BaseGoal()
    {
        _name = "";
        _description = "";
        _numberOfPoints = 0;
        _status = false;
        _goalType = "";
    }

    public BaseGoal(string name, string description, int points, bool status, string goalType)
    {
        _name = name;
        _description = description;
        _numberOfPoints = points;
        _status = status;
        _goalType = goalType;
    }

    protected void SetName()
    {
        Console.Write("What is the name of your goal: ");
        _name = Console.ReadLine();
    }

    protected void SetDescription()
    {
        Console.Write($"enter the description for your goal {_name}: ");
        _description = Console.ReadLine();
    }

    protected void SetNumberOfPoints()
    {
        Console.Write($"enter the points earned for your goal {_name}: ");
        _numberOfPoints = int.Parse(Console.ReadLine());
    }

    protected string GetName()
    {
        return _name;
    }

    protected string GetDescription()
    {
        return _description;
    }

    protected int GetPoints()
    {
        return _numberOfPoints;
    }

    protected bool GetStatus()
    {
        return _status;
    }

// get and formatt the string of user input
    public virtual string GetDisplayString()
    {
        char statusMarker = ' ';
        if (_status)
        {
            statusMarker = 'X';
        }
        return $"[{statusMarker}] Name: {_name}, Description: {_description}, points Earned: {_numberOfPoints}";
    }

    // Formats user's string so that it can be saved in a txt file
    public virtual string GetFileSystemString()
    {
        return $"{GetType().Name}:{_name},{_description},{_numberOfPoints},{_status}";
    }

    /* 
    Markcomplete will set the status to true, which means complete and
    return the number of points for completeing the goal
    */
    public int MarkComplete()
    {
        _status = true;
        return _numberOfPoints;
    }

    public abstract void CreateGoal();
    public abstract int RecordEvent();

}