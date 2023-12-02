using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

class Order
{
    private Customer _customer;
    private List<Product> _products;
    private decimal _shipping;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public void SetShipping()
    {
        if (_customer.IsUsa())
        {
            _shipping = 5;
        }
        else
        {
            _shipping = 35;
        }
    }

    public decimal GetTotalPrice()
    {
        decimal total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotal();
        }
        return total + _shipping;
    }
    public decimal GetSubTotal()
    {
        decimal total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotal();
        }
        return total;
    }
    public decimal GetShippingCost()
    {
        return _shipping;
    }
    public List<string> GetPacking()
    {
        List<string> packing = new List<string>();

        foreach (var product in _products)
        {
            packing.Add(product.GetProduct());
        }

        return packing;
    }

    public string GetShipping()
    {
        return $"   {_customer.GetCustomer()}\n{_customer.GetAddress()}";
    }

    public string GetCustomer()
    {
        return _customer.GetCustomer();
    }
}