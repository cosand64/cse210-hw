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

    public void SetName()
    {
        Console.Write("What is the name of your goal: ");
        _name = Console.ReadLine();
    }

    public void SetDescription()
    {
        Console.Write($"enter the description for your goal {_name}: ");
        _description = Console.ReadLine();
    }

    public void SetNumberOfPoints()
    {
        Console.Write($"enter the points earned for your goal {_name}: ");
        _numberOfPoints = int.Parse(Console.ReadLine());
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
    public abstract void RecordEvent();

}