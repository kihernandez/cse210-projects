using System;


namespace OnlineOrdering
{


    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address("1840 Circle St", "Chicago", "IL", "USA");
            Customer customer1 = new Customer("Mark", address1);

            Address address2 = new Address("2340 Esteban St", "Philadelplhphia", "PA", "USA");
            Customer customer2 = new Customer("John", address2);

            Product product1 = new Product("Book", "253", 6.50, 3);
            Product product2 = new Product("Hammer", "470", 3.50, 2);
            Product product3 = new Product("Pillow", "650", 25.00, 1);

            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Order order2 = new Order(customer2);
            order2.AddProduct(product2);
            order2.AddProduct(product3);

            Console.WriteLine("Order 1");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order1.CalculateTotalCost()}");
            Console.WriteLine();

            Console.WriteLine("Order 2");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order2.CalculateTotalCost()}");


        }
    }
}