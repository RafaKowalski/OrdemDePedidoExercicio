using System;
using OrdemDePedido.Entities.Enums;
using OrdemDePedido.Entities;

namespace Course
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("ENTER CLIENT DATA: ");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("ENTER ORDER DATA: ");

            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int itens = int.Parse(Console.ReadLine());

            for (int i = 1; i <= itens; i++ )
            {
                Console.WriteLine($" Enter #{itens} item data: ");
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                Console.WriteLine("Product Price: ");
                double price = double.Parse(Console.ReadLine());

                Product product = new Product(productName,price );

                Console.WriteLine("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order);
            
        }
    }
}