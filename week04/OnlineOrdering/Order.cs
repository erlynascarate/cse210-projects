public class Order
{
    private string _customer;
    private List<Product> _products = []Product;
    public void GetTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.CalculateCost();
        }
    }
}