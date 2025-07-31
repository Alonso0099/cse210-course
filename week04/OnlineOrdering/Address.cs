
using System.Collections.Concurrent;
using System.Threading.Tasks.Dataflow;

class Address
{
    //Atributes
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

//constructor to assign names
    public Address(string street, string city, string stateOrProvince, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    //boolean to know if the customer is from USA or not
    public bool IsInUsa()
    {
        return _country.ToUpper() == "USA";

    }
    
    // getter to obtain the full address.
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_stateOrProvince}\n{_country}";
    }

}