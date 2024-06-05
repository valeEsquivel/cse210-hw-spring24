using System;

public class Running : Activity
{
    private double _distance;

    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return Math.Round(_distance / GetMinutes() * 60, 2);
    }

    public override double GetPace()
    {
        // redondear a 2 decimales
        return Math.Round(GetMinutes() / _distance, 2);
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{GetDate()} - Running ({GetMinutes()} min) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace {GetPace()} min/mile");
    }
}
