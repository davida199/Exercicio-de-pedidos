using System;
using exercicio.Entities;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //dados do cliente
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status =Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, date);
            Order order = new Order(DateTime.Now, status,client);
            

            //inserindo itens
            Console.WriteLine("how many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string pn = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());

                Product product = new Product(pn, price);

                Console.Write("Quantity: ");
                int quant = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(product,quant,price);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}
/* Depois, mostrar um
sumário do pedido conforme exemplo (próxima página). Nota: o instante do pedido deve ser
o instante do sistema: DateTime.Now*/

/*
Status: Processing
*/