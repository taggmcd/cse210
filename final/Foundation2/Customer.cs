class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name)
    {
        _name = name;
    }

    public void SetAddress(Address address)
    {
        _address = address;
    }

    public string GetAddress()
    {
        return _address.GetAddress();
    }

    public bool IsUsa()
    {
        return _address.IsUsa();
    }
    public string GetCustomer()
    {
        return $"{_name}";
    }

}