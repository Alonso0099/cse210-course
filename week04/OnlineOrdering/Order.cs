using System.Diagnostics.CodeAnalysis;

class Order
{
    //attributes on list and one a class
    List<Product> _products = new List<Product>();
    Customer _customer;

    //constructor to use the order class.
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    //Add products to the list products with all data(name,Id,price,quantity) 
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    //Go trohough the products list and show the corresponding data.
    public string GetPackingLabel()
    {
        string packingLabel = "";

        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetName()} - {product.GetProductId()} | Price: ${product.GetPrice()} | Quantity: {product.GetQuantity()}\n";
        }

        return packingLabel;
    }


    //get name and address from customer and return the label with data in the correct order.
    public string GetShippingLabel()
    {
        string name = _customer.GetCustomerName();
        string address = _customer.GetFullAddress();

        return $"{name}\n{address}";
    }

    //makes the calculation adding the total cost of products plus the corresponding shipping fee 
    public double GetTotalPrice()
    {

        double totalCost = 0;

        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        double shippingCost = _customer.LivesInUsa() ? 5 : 35;

        return totalCost + shippingCost;
    }


    //this works with the Delivery class setting and getting as needed the estimated delivery date
    private Delivery _delivery;
    public void SetDelivery(Delivery delivery)
    {
        _delivery = delivery;
    }
    public Delivery GetDelivery()
    {
        return _delivery;
    }
    
}