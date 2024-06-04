using System;

public class Lectures : Event
{
    private string _speaker;
    private string _capacity;

    public Lectures()
    {
    }

    public Lectures(string title, string date, Address address, string description, string hour, string speaker, string capacity) : base(title, date, address, description, hour)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public void LectureDescription()
    {
        Console.WriteLine(" * Lecture Event * ");
        ShortDescription();
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine(" *- Lecture Event -* ");
        DisplayStandardDetails();
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
    }
}