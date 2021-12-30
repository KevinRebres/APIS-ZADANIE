using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Warehouse.Classes.Controllers;

namespace Warehouse.Classes
{
    public class Backend
    {
        private HttpClient httpClient;
        private CustomerController customerController;
        private ProductController productController;
        private OrderController orderController;
        public EventHandler UpdateUIEventHandler { get; set; }
        public CustomerController CustomerController { get => this.customerController; }
        public ProductController ProductController { get => this.productController; }
        public OrderController OrderController { get => this.orderController; }
        public Backend()
        {
            this.httpClient = new HttpClient();
            this.httpClient.BaseAddress = new Uri("https://cvicenie.herokuapp.com/");
            this.httpClient.DefaultRequestHeaders.Accept.Clear();
            this.httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            this.customerController = new CustomerController(this.httpClient);
            this.productController = new ProductController(this.httpClient);
            this.orderController = new OrderController(this.httpClient);
        }
    }
}
