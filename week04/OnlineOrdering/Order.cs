public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();
    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }
    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.CalculateCost();
        }

        double shippingCost;
        if (_customer.LivesInUSA())
        {
            shippingCost = 5;
        } else
        {
            shippingCost = 35;
        }

        totalCost += shippingCost;
        return totalCost;
    }
    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()} (Id: {product.GetId()})\n";
        }
        
        return label;
    }
    public string GetShippingLabel()
    {
        Address address = _customer.GetAddress();
        string label = $"{_customer.GetName()}\n{address.FullAddress()}";

        return label;
    }
}