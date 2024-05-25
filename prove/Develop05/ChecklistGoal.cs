using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted; // to know how many times the goal has been completed
    private int _target; // to know how many times the goal should be completed
    private int _bonus; // to know how many points the user will get when the goal is completed

    public ChecklistGoal(string shortName, string description, string points, int target, int bonus) : base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    // Constructor to load the goal from the file
    public ChecklistGoal(string shortName, string description, string points, int target, int bonus, int amountCompleted) : base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;

        int totalPoints = int.Parse(_points);

        if (_amountCompleted == _target)
        {
            totalPoints = _bonus + int.Parse(_points);
        }

        Console.WriteLine($"Congratulations! You have earned {totalPoints} points.");
    }

    public override bool IsComplete()
    {
        return _amountCompleted == _target;
    }

    public override string GetDetailsString()
    {
        string complete = IsComplete() ? "X" : " ";
        string text = "[" + complete + "] " + _shortName + " (" + _description + ") " + " -- Current completed: " + _amountCompleted + "/" + _target;
        return text;
    }

    public override string GetStringRepresentation()
    {
        string textToSave;

        textToSave = "ChecklistGoal:" + _shortName + "," + _description + "," + _points + "," + _bonus + "," + _target + "," + _amountCompleted;

        return textToSave;
    }

    public override int GetPoints()
    {
        int totalPoints = int.Parse(_points);

        if (_amountCompleted == _target)
        {
            totalPoints = _bonus + int.Parse(_points);
        }

        return totalPoints;
    }

}