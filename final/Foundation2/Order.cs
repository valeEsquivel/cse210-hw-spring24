using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private double _totalCost;

    private double _shippingCost;

    public Order()
    {
    }

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public void DisplayPackingLabel()
    {
        foreach (Product product in _products)
        {
            product.DisplayProductDetails();
        }
    }

    public void DisplayShippingLabel()
    {
        _customer.DisplayInfo();
    }

    public void CalculateTotalCost()
    {
        foreach (Product product in _products)
        {
            _totalCost += product.CalculateCost();
        }

        if (_customer.CheckCountry())
        {
            _shippingCost = 5;
        }
        else
        {
            _shippingCost = 35;
        }

        _totalCost += _shippingCost;

        Console.WriteLine($"Total Cost: ${_totalCost}");
    }
}