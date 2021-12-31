using System.Collections.Generic;
using System.Net.Http;
using System.Windows;
using Warehouse.Classes.Models;

namespace Warehouse.Classes.Controllers
{
    public class CustomerController
    {
        private HttpClient httpClient;
        private List<Customer> customers = new List<Customer>();
        public Customer Customer { get; set; }
        public List<Customer> Customers { get => this.customers; }
        public CustomerController() { }
        public CustomerController(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public void Load()
        {
            this.customers = Client.SendGetRequest<List<Customer>>(this.httpClient, "customers");
        }
        public bool Process(string name, string address, string phoneNumber)
        {
            if (name == "")
            {
                MessageBox.Show("Please insert customer's name.");
                return false;
            }
            if (address == "")
            {
                MessageBox.Show("Please insert customer's address.");
                return false;
            }
            if (phoneNumber == "")
            {
                MessageBox.Show("Please insert customer's phone number.");
                return false;
            }
            this.Customer.Name = name;
            this.Customer.Address = address;
            this.Customer.PhoneNumber = phoneNumber;
            if (!this.Customers.Contains(this.Customer))
            {
                Client.SendPostRequest<Customer>(this.httpClient, "customers", this.Customer);
            }
            else
            {
                Client.SendPutRequest<Customer>(this.httpClient, $"customers", this.Customer);
            }
            return true;
        }
        public void Remove(Customer customer)
        {
            if (customer != null)
            {
                Client.SendDeleteRequest<Customer>(this.httpClient, $"customers/{customer.Id}");
            }
        }
    }
}
