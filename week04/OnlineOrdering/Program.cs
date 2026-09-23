using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        Address address1 = new Address(
            "123 Main Street",
            "Salt Lake City",
            "Utah",
            "USA");

        Customer customer1 = new Customer(
            "John Smith",
            address1);

        Product product1 = new Product(
            "Laptop",
            "P001",
            850.00,
            1);

        Product product2 = new Product(
            "Wireless Mouse",
            "P002",
            25.00,
            2);

        Order order1 = new Order(customer1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);


        // Order 2
        Address address2 = new Address(
            "15 Aba Road",
            "Aba",
            "Abia",
            "Nigeria");

        Customer customer2 = new Customer(
            "Chukwuemeka Okpara",
            address2);

        Product product3 = new Product(
            "Solar Panel",
            "P003",
            300.00,
            2);

        Product product4 = new Product(
            "Inverter",
            "P004",
            750.00,
            1);

        Order order2 = new Order(customer2);

        order2.AddProduct(product3);
        order2.AddProduct(product4);


        // Store orders in a list
        List<Order> orders = new List<Order>
        {
            order1,
            order2
        };


        // Display each order
        foreach (Order order in orders)
        {
            Console.WriteLine("========================================");
            Console.WriteLine($"TOTAL COST: ${order.GetTotalCost():0.00}");
            Console.WriteLine();

            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine();

            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine("========================================");
            Console.WriteLine();
        }
    }
}