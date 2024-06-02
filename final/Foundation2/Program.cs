using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Address address1 = new Address("123 Main St", "Anytown", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Product product1 = new Product("Laptop", "1234", 1000, 1);
        Product product2 = new Product("Mouse", "5678", 20, 2);

        Order order1 = new Order(new List<Product> { product1, product2 }, customer1);

        Console.WriteLine("**************************Order 1**************************");
        order1.DisplayPackingLabel();
        order1.DisplayShippingLabel();
        order1.CalculateTotalCost();

        Address address2 = new Address("456 Elm St", "Othertown", "CA", "Canada");
        Customer customer2 = new Customer("Jane Doe", address2);

        Product product3 = new Product("Laptop", "1234", 1000, 1);
        Product product4 = new Product("Mouse", "5678", 20, 2);

        Order order2 = new Order(new List<Product> { product3, product4 }, customer2);

        Console.WriteLine("\n\n");
        Console.WriteLine("**************************Order 2**************************");
        order2.DisplayPackingLabel();
        order2.DisplayShippingLabel();
        order2.CalculateTotalCost();

        Console.WriteLine("\n\n");

        Address address3 = new Address("El Carmen", "San Antonio del Monte", "Sonsonate", "El Salvador");
        Customer customer3 = new Customer("Claudia Esquivel", address3);

        Product product5 = new Product("Monitor", "9876", 200, 4);
        Product product6 = new Product("Keyboard", "5432", 50, 3);
        Product product7 = new Product("Printer", "1098", 150, 2);

        Order order3 = new Order(new List<Product> { product5, product6, product7 }, customer3);

        Console.WriteLine("**************************Order 3**************************");
        order3.DisplayPackingLabel();
        order3.DisplayShippingLabel();
        order3.CalculateTotalCost();
    }
}