class Customer
{
    //attributes
    private string _customerName;
    private Address _address;

//constructor to assign names
    public Customer(string name, Address address)
    {
        _customerName = name;
        _address = address;
    }
    
    // getters to  get full address and customer name plus the boolean to know get the customer when is from USA
    public string GetCustomerName()
    {
        return _customerName;
    }
    public string GetFullAddress()
    {
        return _address.GetFullAddress();
    }
    
    public bool LivesInUsa()
    {
        return _address.IsInUsa();
    }
 
}