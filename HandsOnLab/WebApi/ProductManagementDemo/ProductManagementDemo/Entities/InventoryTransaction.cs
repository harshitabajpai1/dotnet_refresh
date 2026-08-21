namespace ProductManagementDemo.API.Entities
{
    public class InventoryTransaction
    {
        public int Id { get; set; }

        public int InventoryId { get; set; }

        public string TransactionType { get; set; } = string.Empty;

        public int Quantity { get; set; }

        public string ReferenceNumber { get; set; } = string.Empty;

        public DateTime TransactionDate { get; set; }

        public string Notes { get; set; } = string.Empty;

        // Navigation
        public virtual Inventory? Inventory { get; set; }
    }
}