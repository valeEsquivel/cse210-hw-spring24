using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer()
    {
    }

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Customer: {_name}");
        _address.DisplayInfo();
    }

    public bool CheckCountry()
    {
        return _address.CheckCountry();
    }
}