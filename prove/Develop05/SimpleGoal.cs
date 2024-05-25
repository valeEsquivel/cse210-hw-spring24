using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string shortName, string description, string points) : base(shortName, description, points)
    {
    }

    // Constructor to load the goal from the file
    public SimpleGoal(string shortName, string description, string points, bool isComplete) : base(shortName, description, points)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points.");
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        string textToSave;

        textToSave = "SimpleGoal:" + _shortName + "," + _description + "," + _points + "," + _isComplete;

        return textToSave;
    }
}