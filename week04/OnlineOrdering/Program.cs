using System;
using System.Collections.Generic;

// (not necesary), but I exceed the requierements bulding the Delivery Class for set a delivery date to the order.
// the price and quantity is availbale separated to understand every multiplication and the cost of every product.
class Program
{
    static void Main(string[] args)
    {
        // Client in USA \\
        //"street name",     "city", "StateOrProvince", "Country"
        Address address1 = new Address("123 Main St", "Phoenix", "AZ", "USA");
        Customer customer1 = new Customer("Juan Alvarado", address1);

        // 2 Products added          "productName", "productId", "price", "quantity"
        Product laptop = new Product("Laptop Lenovo", "LP100", 1000.00, 1);
        Product mouse = new Product("Egonomic Mouse ", "MS200", 25.00, 2);

        // Date and products for customer #1
        Delivery delivery1 = new Delivery(3);//build delivery date for order 1
        Order order1 = new Order(customer1);//Conect the order1 to customer1
        order1.SetDelivery(delivery1);//conect the delivery time to the corresponding customer and order
        order1.AddProduct(laptop); //product 1 of order 1
        order1.AddProduct(mouse); //product 2 of order 1


        // All data to print
        Console.WriteLine(" ORDER 1 ");
        Console.Write("\nPacking Label:");
        Console.WriteLine(order1.GetPackingLabel()); //label for packing
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order1.GetShippingLabel()); // label for shipping
        Console.WriteLine($"\nTotal Price: ${order1.GetTotalPrice()}"); // total price
        Console.WriteLine($"Estimated Delivery: {delivery1.GetEstimatedDate()}"); // delivery date


        // --- Second Order: International Client --- \\

        //"street name",     "city", "StateOrProvince", "Country"
        Address address2 = new Address("False Street 123", "Madrid", "Madrid", "Spain");
        Customer customer2 = new Customer("Mary Crazy", address2);

        // 2 Products added          "productName", "productId", "price", "quantity"
        Product cables = new Product("Cable USB-C", "CB500", 5.00, 4);
        Product charger = new Product("Apple Charger", "CH900", 40.00, 4);

        // Date and products for customer #2
        Delivery delivery2 = new Delivery(7);//build delivery date for order 2
        Order order2 = new Order(customer2);//Conect the order2 to customer2
        order2.SetDelivery(delivery2); //conect the delivery time to the corresponding customer and order
        order2.AddProduct(cables);//product 1 of order 2
        order2.AddProduct(charger); //product 2 of order 2

        // All data to print
        Console.WriteLine("\n ORDER 2 ");
        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order2.GetPackingLabel()); //label for packing
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order2.GetShippingLabel()); // label for shipping
        Console.WriteLine($"\nTotal Price: ${order2.GetTotalPrice()}"); // total price
        Console.WriteLine($"Estimated Delivery: {delivery2.GetEstimatedDate()}"); // delivery date

        // --- Third Order: International Client --- \\

        //"street name",     "city", "StateOrProvince", "Country"
        Address address3 = new Address("Endless Street 321", "Escazu", "San Jose", "Costa Rica");
        Customer customer3 = new Customer("Felipe Stone", address3); //take the addres info and conect it with the name of the customer.

        // 2 Products added          "productName", "productId", "price", "quantity"
        Product TV = new Product("Samsung TV", "TV456", 549.99, 1);
        Product TVMount = new Product("TV Mount for 70' TV", "TM789", 34.99, 1);

        // Date and products for customer #3
        Delivery delivery3 = new Delivery(5); //build delivery date for order 3
        Order order3 = new Order(customer3); //Conect the order3 to customer3 
        order3.SetDelivery(delivery3); //conect the delivery time to the corresponding customer and order
        order3.AddProduct(TV); //product 1 of order 3
        order3.AddProduct(TVMount); //product 2 of order 3

        // All data to print
        Console.WriteLine("\n ORDER 3 ");
        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order3.GetPackingLabel()); //label for packing
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order3.GetShippingLabel()); // label for shipping
        Console.WriteLine($"\nTotal Price: ${order3.GetTotalPrice()}"); // total price
        Console.WriteLine($"Estimated Delivery: {delivery3.GetEstimatedDate()}"); // delivery date

    }
}