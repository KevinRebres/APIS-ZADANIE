using System;

namespace Warehouse.Classes.Models
{
    public class Product
    {
        private int id = 0;
        private string name = "";
        private int quantity = 0;
        private double price = 0.0;
        public int Id { get => this.id; set => this.id = value; }
        public string Name { get => this.name; set => this.name = value; }
        public int Quantity { get => this.quantity; set => this.quantity = value; }
        public double Price { get => this.price; set =>this.price = value; }
        public override string ToString()
        {
            return $"{this.Id} {this.Name}";
        }
    }
}