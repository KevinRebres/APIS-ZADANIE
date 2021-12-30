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
            this.httpClient = new HttpClient();
        }
        public List<Order> Get()
        {
            this.orders = new List<Order>();

            this.orders.Add(new Order
            {
                Id = 1,
                Quantity = 5,
                CustomerId = 1,
                ProductId = 1,
            });
            this.orders.Add(new Order
            {
                Id = 2,
                Quantity = 9,
                CustomerId = 3,
                ProductId = 2,
            });
            this.orders.Add(new Order
            {
                Id = 3,
                Quantity = 13,
                CustomerId = 3,
                ProductId = 3,
            });
            /*
            this.orders = Client.SendGetRequest<List<Order>>(this.httpClient, "orders");
            */
            return this.orders;
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
                //Client.SendPostRequest<Order>(this.httpClient, "orders", this.Order);
                this.Orders.Add(this.Order);
            }
            else
            {
                //Client.SendPutRequest<Order>(this.httpClient, $"orders/{this.Order.Id}", this.Order);
            }
            return true;
        }
        public void Remove(Order order)
        {
            if (order != null)
            {
                this.Orders.Remove(order);
                //Client.SendDeleteRequest<Order>(this.httpClient, $"orders/{this.Order.Id}");
            }
        }
    }
}
