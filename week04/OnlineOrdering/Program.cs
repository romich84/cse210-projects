using System;
using OnlineOrdering;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to The Real Stay Store");
        Address address = new Address("Buenos Aires 100", "Villa María", "Córdoba", "Argentina");
        Customer customer = new Customer("Romina Chazarreta", address);
        Product p1 = new Product("Skzoo T-Shirt", "SKZ001", 20,5);
        Product p2 = new Product("Skzoo 25cm dominate series", "SKZ002", 10,8);
        Product p3 = new Product("Skzoo pilot", "SKZ003", 7,8);
        Order order = new Order(customer);
        order.AddProduct(p1);
        order.AddProduct(p2);
        order.AddProduct(p3);
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total: U$S {order.GetTotalPrice():F2}");
        Console.WriteLine("----------------------------");

        Address address2 = new Address("350 Fifth Avenue", "New York", "NY", "USA");
        Customer customer2 = new Customer("Ashley Miller", address2);
        Product p4 = new Product("Stray Kids Photocard Set", "SKZ004", 15, 3);
        Product p5 = new Product("SKZOO Plush (Han Quokka)", "SKZ005", 25, 2);
        Product p6 = new Product("Stray Kids Lightstick", "SKZ006", 60, 1);
        Order order2 = new Order(customer2);
        order2.AddProduct(p4);
        order2.AddProduct(p5);
        order2.AddProduct(p6);
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total: U$S {order2.GetTotalPrice():F2}");
        Console.WriteLine("----------------------------");

        Address address3 = new Address("1600 Amphitheatre Parkway", "Mountain View", "CA", "USA");
        Customer customer3 = new Customer("Jessica Brown", address3);
        Product p7 = new Product("SKZOO Plush (Changbin - Dwaekki)", "SKZ007", 28, 1);
        Product p8 = new Product("SKZOO Plush (Hyunjin - Jiniret)", "SKZ008", 28, 1);
        Product p9 = new Product("SKZOO Plush (Felix - BbokAri)", "SKZ009", 28, 1);
        Order order3 = new Order(customer3);
        order3.AddProduct(p7);
        order3.AddProduct(p8);
        order3.AddProduct(p9);
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total: U$S {order3.GetTotalPrice():F2}");



    }
}