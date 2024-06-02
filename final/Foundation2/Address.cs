using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address()
    {
    }

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // To check if the country is USA to make the difference when calculating the shipping cost
    public bool CheckCountry()
    {
        if (_country == "USA")
        {
            return true;
        }

        return false;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Address: {_street}, {_city}, {_state}, {_country}");
    }
}