using System;

public class OutdoorGatherings : Event
{
    private string _weather;

    public OutdoorGatherings()
    {
    }

    public OutdoorGatherings(string title, string date, Address address, string description, string hour, string weather) : base(title, date, address, description, hour)
    {
        _weather = weather;
    }

    public void OutdoorDescription()
    {
        Console.WriteLine(" * Outdoor Gathering Event * ");
        ShortDescription();
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine(" *- Outdoor Gathering Event -* ");
        DisplayStandardDetails();
        Console.WriteLine($"Weather: {_weather}");
    }
}