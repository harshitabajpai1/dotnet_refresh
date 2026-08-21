using ProductManagementDemo.API.Entities;

namespace ProductManagementDemo.Data
{
    public static async Task InitializeAsync(AppDbContext context)
    {
        if (context.Categories.Any()) return;  // Already seeded

        var electronics = new Category { Name = "Electronics", DisplayOrder = 1 };
        var clothing = new Category { Name = "Clothing", DisplayOrder = 2 };
        // ... add subcategories, suppliers, products, inventory ...

        await context.SaveChangesAsync();
    }

}
