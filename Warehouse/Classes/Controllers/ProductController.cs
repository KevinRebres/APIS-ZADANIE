using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows;
using Warehouse.Classes.Models;

namespace Warehouse.Classes.Controllers
{
    public class ProductController
    {
        private HttpClient httpClient;
        private List<Product> products = new List<Product>();
        public Product Product { get; set; }
        public List<Product> Products { get => this.products; }
        public ProductController() { }
        public ProductController(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public List<Product> Get()
        {
            this.products = new List<Product>();

            this.products.Add(new Product
            {
                Id = 1,
                Name = "Exhaust",
                Quantity = 25,
                Price = 159.99
            });
            this.products.Add(new Product
            {
                Id = 2,
                Name = "Gearbox",
                Quantity = 10,
                Price = 379.99
            });
            this.products.Add(new Product
            {
                Id = 3,
                Name = "Diesel Engine",
                Quantity = 3,
                Price = 809.99
            });
            /*
            this.products = Client.SendGetRequest<List<Product>>(this.httpClient, "products");
            */
            return this.products;
        }
        public bool Process(string name, string quantity, string price)
        {
            if (name == "")
            {
                MessageBox.Show("Please insert product's name.");
                return false;
            }
            try
            {
                Convert.ToInt32(quantity);
            }
            catch (FormatException)
            {
                MessageBox.Show("Quantity must be positive number.");
                return false;
            }
            try
            {
                Convert.ToDouble(price);
            }
            catch (FormatException)
            {
                MessageBox.Show("Price must be positive number.");
                return false;
            }
            this.Product.Name = name;
            this.Product.Quantity = Convert.ToInt32(quantity);
            this.Product.Price = Convert.ToDouble(price);
            if (!this.Products.Contains(this.Product))
            {
                //Client.SendPostRequest<Product>(this.httpClient, "products", this.Product);
                this.Products.Add(this.Product);
            }
            else
            {
                //Client.SendPutRequest<Product>(this.httpClient, $"products/{this.Product.Id}", this.Product);
            }
            return true;
        }
        public void Remove(Product product)
        {
            if (product != null)
            {
                this.Products.Remove(product);
                //Client.SendDeleteRequest<Product>(this.httpClient, $"products/{this.Product.Id}");
            }
        }
    }
}
