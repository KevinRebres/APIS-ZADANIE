using System;

namespace Warehouse.Classes.Models
{
    public class Customer
    {
        private int id = 0;
        private string name = "";
        private string address = "";
        private string phoneNumber = "";
        public int Id { get => this.id; set => this.id = value; }
        public string Name { get => this.name; set => this.name = value; }
        public string Address { get => this.address; set => this.address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public override string ToString()
        {
            return String.Format("{0} {1}", this.Id, this.Name);
        }
    }
}
