using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(Product name, int quantity, double price)
        {
            product = name;
            Quantity = quantity;
            Price = price;
        }

        public double subTotal()
        {
            return Quantity * Price;
        }
    }
}
