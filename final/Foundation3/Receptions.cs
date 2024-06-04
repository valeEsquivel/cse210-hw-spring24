using System;

public class Receptions : Event
{
    private string _email;

    public Receptions()
    {
    }

    public Receptions(string title, string date, Address address, string description, string hour, string email) : base(title, date, address, description, hour)
    {
        _email = email;
    }

    public void ReceptionDescription()
    {
        Console.WriteLine(" * Reception Event * ");
        ShortDescription();
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine(" *- Reception Event -*");
        DisplayStandardDetails();
        Console.WriteLine($"Email: {_email}");
    }
}