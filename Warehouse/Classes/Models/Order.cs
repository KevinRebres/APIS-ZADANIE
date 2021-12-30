namespace Warehouse.Classes.Models
{
    public class Order
    {
        private int id = 0;
        private int quantity = 1;
        private int customerId = 0;
        private int productId = 0;
        public int Id { get => this.id; set => this.id = value; }
        public int Quantity { get => this.quantity; set => this.quantity = value; }
        public int CustomerId { get => this.customerId; set => this.customerId = value; }
        public int ProductId { get => this.productId; set => this.productId = value; }
    }
}
