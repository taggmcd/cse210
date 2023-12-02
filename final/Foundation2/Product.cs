class Product
{
    private string _name;
    private string _description;
    private decimal _price;
    private int _quantity;

    public Product(string name, string description, decimal price, int quantity)
    {
        _name = name;
        _description = description;
        _price = price;
        _quantity = quantity;
    }

    public string GetProduct()
    {
        return $"{_name} - {_description} - {_quantity} @ ${_price} each";
    }

    public decimal GetTotal()
    {
        return _price * _quantity;
    }
}