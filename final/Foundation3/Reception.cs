class Reception : Event
{
    private bool _register;
    private string _email;

    public Reception(string type, string title, string description, string date, string time, Address address, bool register, string email) : base(title, description, date, time, address, type)
    {
        _register = register;
        _email = email;
    }

    public string MustRegister()
    {
        if (_register)
        {
            return "Yes";
        }
        else
        {
            return "No";
        }
    }

    public string GetEmail()
    {
        return _email;
    }
}