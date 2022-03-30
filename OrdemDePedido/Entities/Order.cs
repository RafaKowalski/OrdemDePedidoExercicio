﻿using OrdemDePedido.Entities.Enums;
using System.Text;
using System.Collections.Generic;

namespace OrdemDePedido.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }

        public OrderStatus Status { get; set; }

        public List<OrderItem> Items { get; set;} = new List<OrderItem>();

        public Client Client { get; set; }

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem (OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double soma = 0.0;
            foreach(OrderItem item in Items)
            {
                soma += item.SubTotal();
            }
            return soma;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total());
            return sb.ToString();

        }


    }
}