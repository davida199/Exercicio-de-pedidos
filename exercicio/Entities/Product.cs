using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            this.price = price;
        }
    }
}
