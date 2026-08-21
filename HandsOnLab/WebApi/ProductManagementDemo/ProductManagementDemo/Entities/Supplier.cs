namespace ProductManagementDemo.API.Entities
{
    public class Supplier
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string ContactPerson { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public double Rating { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; }

        // Navigation
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}