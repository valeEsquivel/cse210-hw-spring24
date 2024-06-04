using System;

public class Address
{
    private string _city;
    private string _state;
    private string _country;
    private string _place;

    public Address()
    {
    }

    public Address(string city, string state, string country, string place)
    {
        _city = city;
        _state = state;
        _country = country;
        _place = place;
    }

    public void DisplayAddress()
    {
        Console.WriteLine($"Address: {_place}, {_city}, {_state}, {_country}");
    }
}