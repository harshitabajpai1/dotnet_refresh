namespace ProductManagementDemo.API.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public string OrderNumber { get; set; } = string.Empty;

        public string CustomerName { get; set; } = string.Empty;

        public string CustomerEmail { get; set; } = string.Empty;

        public string ShippingAddress { get; set; } = string.Empty;

        public decimal TotalAmount { get; set; }

        public string Status { get; set; } = string.Empty;

        public DateTime OrderDate { get; set; }

        // Navigation
        public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}