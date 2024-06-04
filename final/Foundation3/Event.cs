using System;

public class Event
{
    private string _title;
    private string _date;
    private Address _address;
    private string _description;
    private string _hour;

    public Event()
    {
    }

    public Event(string title, string date, Address address, string description, string hour)
    {
        _title = title;
        _date = date;
        _address = address;
        _description = description;
        _hour = hour;
    }

    public void DisplayStandardDetails()
    {
        Console.WriteLine($"** {_title}");
        Console.WriteLine($"** {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Hour: {_hour}");
        _address.DisplayAddress();
    }

    public void ShortDescription()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_date}");
    }
}