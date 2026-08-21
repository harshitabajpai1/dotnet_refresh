using ProductManagementDemo.API.Entities;
using ProductManagementDemo.DTOs;

namespace ProductManagementDemo.Helpers.Extensions
{
    public static class ProductExtensions
    {
        public static ProductDetailDto ToDetailDto(this Product p) => new()
        {
            Id = p.Id,
            Name = p.Name,
            Description = p.Description,
            Price = p.Price,
            DiscountedPrice = p.DiscountedPrice,
            Category = new CategoryBasicDto { Id = p.Category?.Id ?? 0, Name = p.Category?.Name ?? "" },
            Sku = p.SKU,
            IsActive = p.IsActive,
            AverageRating = p.AverageRating,
            ReviewCount = p.ReviewCount,
            ImageUrl = p.ImageUrl,
            Tags = JsonSerializer.Deserialize<List<string>>(p.Tags) ?? new(),
            Inventory = p.Inventory?.ToStatusDto(),
            RecentReviews = p.Reviews
                .Where(r => r.IsApproved)
                .OrderByDescending(r => r.CreatedAt)
                .Take(5)
                .Select(r => r.ToDto())
                .ToList()
        };

        public static ProductSummaryDto ToSummaryDto(this Product p) => new()
        {
            Id = p.Id,
            Name = p.Name,
            // Truncate description to 100 chars for list views
            Description = p.Description?.Length > 100
                              ? p.Description[..100] + "..." : p.Description ?? "",
            Price = p.Price,
            DiscountedPrice = p.DiscountedPrice,
            ImageUrl = p.ImageUrl,
            CategoryName = p.Category?.Name ?? "",
            AverageRating = p.AverageRating,
            ReviewCount = p.ReviewCount,
            IsInStock = p.Inventory?.AvailableQuantity > 0
        };
    }

}
