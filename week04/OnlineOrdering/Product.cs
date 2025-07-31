class Product
{
    private string _nameProduct;
    private string _productId;
    private double _price;
    private int _quantity;

    //Constructor to create a product with all data.
    public Product(string name, string id, double price, int quantity)
    {
        _nameProduct = name;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }

    // public getters for name and Id product.
    public string GetName()
    {
        return _nameProduct;
    }
    public string GetProductId()
    {
        return _productId;
    }

    // Calculate the total price multiplying price per quantity.
    public double GetTotalCost()
    {
        return _price * _quantity;
    }
    public double GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }



}