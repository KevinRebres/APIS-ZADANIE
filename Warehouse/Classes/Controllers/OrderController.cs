using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows;
using Warehouse.Classes.Models;

namespace Warehouse.Classes.Controllers
{
    public class OrderController
    {
        private HttpClient httpClient;
        private List<Order> orders = new List<Order>();
        public Order Order { get; set; }
        public List<Order> Orders { get => this.orders; }
        public OrderController() { }
        public OrderController(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public void Load()
        {
            this.orders = Client.SendGetRequest<List<Order>>(this.httpClient, "orders");
        }
        public bool Process(string quantity, Customer customer, Product product)
        {
            if (customer == null)
            {
                MessageBox.Show("Please select customer.");
                return false;
            }
            if (product == null)
            {
                MessageBox.Show("Please select order.");
                return false;
            }
            try
            {
                if (Convert.ToInt32(quantity) < 1)
                {
                    MessageBox.Show("Quantity must be positive number.");
                    return false;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Quantity must be positive number.");
                return false;
            }
            this.Order.Quantity = Convert.ToInt32(quantity);
            this.Order.CustomerId = customer.Id;
            this.Order.ProductId = product.Id;
            if (!this.Orders.Contains(this.Order))
            {
                Client.SendPostRequest<Order>(this.httpClient, "orders", this.Order);
            }
            else
            {
                Client.SendPutRequest<Order>(this.httpClient, $"orders", this.Order);
            }
            return true;
        }
        public void Remove(Order order)
        {
            if (order != null)
            {
                Client.SendDeleteRequest<Order>(this.httpClient, $"orders/{order.Id}");
            }
        }
    }
}
