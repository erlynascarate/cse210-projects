public class Address
{
    private string _street;
    private string _city;
    private string _province;
    private string _country;
    public bool IsUSA()
    {
        bool isIt = _country == "USA";
        return isIt;
    }
    public string FullAddress()
    {
        return $"{_street}, {_city}, {_province}, {_country}";
    }
}