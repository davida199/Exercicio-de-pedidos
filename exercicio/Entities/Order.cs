using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client client { get; set; }

        public Order(DateTime moment, OrderStatus status,Client client)
        {
            Moment = moment;
            Status = status;
            this.client = client;
        }

        public void addItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void removeItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double sum = 0.0;
            foreach(OrderItem item in Items)
            {
                sum += item.subTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sm=new StringBuilder();
            sm.AppendLine("Order moment: "+Moment.ToString("dd/MM/yyyy"));
            sm.AppendLine("Order status: " + Status);
            sm.Append("Client: " +client );
            sm.AppendLine("Order items: ");
            foreach(OrderItem item in Items)
            {
                sm.AppendLine(item.ToString());
            }
             sm.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sm.ToString();

        }
    }
}
