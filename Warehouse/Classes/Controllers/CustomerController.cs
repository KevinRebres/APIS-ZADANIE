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
        public List<Customer> Get()
        {
            this.customers = new List<Customer>();

            this.customers.Add(new Customer
            {
                Id = 1,
                Name = "LandRover",
                Address = "Nitra 94911",
                PhoneNumber = "+421 901 222 485"
            });
            this.customers.Add(new Customer
            {
                Id = 2,
                Name = "Volkswagen",
                Address = "Bratislava 81104",
                PhoneNumber = "+421 912 456 054"
            });
            this.customers.Add(new Customer
            {
                Id = 3,
                Name = "Kia",
                Address = "Zilina 01008",
                PhoneNumber = "+421 900 542 564"
            });
            /*
            this.customers = Client.SendGetRequest<List<Customer>>(this.httpClient, "customers");
            */
            return this.customers;
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
                //Client.SendPostRequest<Customer>(this.httpClient, "customers", this.Customer);
                this.Customers.Add(this.Customer);
            }
            else
            {
                //Client.SendPutRequest<Customer>(this.httpClient, $"customers/{this.Customer.Id}", this.Customer);
            }
            return true;
        }
        public void Remove(Customer customer)
        {
            if (customer != null)
            {
                this.Customers.Remove(customer);
                //Client.SendDeleteRequest<Customer>(this.httpClient, $"customers/{this.Customer.Id}");
            }
        }
    }
}
