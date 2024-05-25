using System;

public abstract class Goal {
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string shortName, string description, string points) {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string complete = IsComplete() ? "X" : " ";
        string text =  "[" + complete + "] " + _shortName + " (" + _description + ")";
        return text;
    }

    public abstract string GetStringRepresentation();

    // This method is used to get the short name of the goal for the Goal Manager Class, due to the fact that the short name is a protected field
    public string GetShortName() {
        return _shortName;
    }

    // This method is used to get the points of the goal for the Goal Manager Class, due to the fact that the points is a protected field
    public virtual int GetPoints() {
        return int.Parse(_points);
    }
}