using OrderGenerator.Entities;
using OrderGenerator.Enums;
using System;
using System.Globalization;

namespace OrderGenerator
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("E-mail: ");
            string clientEmail = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime clientBithDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(clientName, clientEmail, clientBithDate);
            Console.WriteLine();
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many to this order? ");
            int howMany = int.Parse(Console.ReadLine());
            Order order = new Order(status,client);
            Console.WriteLine();
            for(int i = 1; i <= howMany ; i++)
            {
                Console.WriteLine($"({i}) Enter item data:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quant = int.Parse(Console.ReadLine());
                Product product = new Product(name,price);
                OrderItem item = new OrderItem(quant,price,product);
                order.AddItem(item);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine(order);

        }
    }
}