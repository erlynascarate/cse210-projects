using System;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>
        {
            new Product("Classic Black T-Shirt", 1100, 35, 3),
            new Product("Futuristic Silver and Gold High-Top Sneaker", 1200, 68, 1),
        };
        Address address1 = new Address("123 Main St", "Toronto", "Ontario", "Canada");
        Customer customer1 = new Customer("Sebastian", address1);
        Order order1 = new Order(customer1, products);

        Address address2 = new Address("1600 Pennsylvania Avenue NW", "Washington", "DC", "USA");
        Customer customer2 = new Customer("Sayori", address2);
        Order order2 = new Order(customer2, products);

        List<Order> orders = new List<Order>
        {
            order1,
            order2
        };

        foreach (Order order in orders)
        {
            Console.WriteLine("\n** Packing Label **");
            Console.WriteLine(order.GetPackingLabel());

            Console.WriteLine("** Shipping Label **");
            Console.WriteLine(order.GetShippingLabel());

            Console.WriteLine($"\nTotal price of the order: ${order.GetTotalCost()}");
        }
    }
}