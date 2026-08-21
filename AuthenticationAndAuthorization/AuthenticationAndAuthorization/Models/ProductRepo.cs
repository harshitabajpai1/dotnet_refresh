namespace AuthenticationAndAuthorization.Models
{
    public class ProductRepo
    {
        public static List<Product> cosmeticProducts = null;
        public static List<Product> electronicProducts = null;
        public static List<Product> Cloths = null;
        public ProductRepo()
        {
            cosmeticProducts = new List<Product>
            {
                new Product{ProductId=1, Name="Lipstick", Cost=19.99M, Description="A long-lasting lipstick that provides vibrant color and a smooth finish.", Category="Makeup", Brand="Luxe Beauty", StockQuantity=100,ImageUrl="/images/Lipstick.png"},
                new Product{ProductId=2, Name="Foundation", Cost=29.99M, Description="A lightweight foundation that offers buildable coverage and a natural finish.", Category="Makeup", Brand="Glow Cosmetics", StockQuantity=150,ImageUrl="/images/Foundation.png"},
                new Product{ProductId=3, Name="Mascara", Cost=14.99M, Description="A volumizing mascara that lengthens and defines lashes for a dramatic look.", Category="Makeup", Brand="Luxe Beauty", StockQuantity=200, ImageUrl="/images/maskara.png"},
                new Product{ProductId=4, Name="Blush", Cost=24.99M, Description="A silky blush that adds a natural flush of color to the cheeks.", Category="Makeup", Brand="Glow Cosmetics", StockQuantity=120, ImageUrl = "/images/blush.png"},
                new Product{ProductId=5, Name="Eyeshadow Palette", Cost=39.99M, Description="A versatile eyeshadow palette with a range of shades for creating endless eye looks.", Category="Makeup", Brand="Luxe Beauty", StockQuantity=80, ImageUrl = "/images/eyeshadow.png"},
                new Product{ProductId=6, Name="Face Cream", Cost=49.99M, Description="A nourishing face cream that hydrates and revitalizes the skin.", Category="Skincare", Brand="Glow Cosmetics", StockQuantity=90, ImageUrl="/images/FaceCream.png"},
            };
            electronicProducts = new List<Product>
            {
                new Product{ProductId=7, Name="Smartphone", Cost=699.99M, Description="A high-performance smartphone with a stunning display and powerful camera.", Category="Electronics", Brand="TechPro", StockQuantity=50, ImageUrl="/images/smartphone.png"},
                new Product{ProductId=8, Name="Laptop", Cost=999.99M, Description="A sleek laptop with fast processing and ample storage for work and play.", Category="Electronics", Brand="TechPro", StockQuantity=30, ImageUrl="/images/laptop.png"},
                new Product{ProductId=9, Name="Headphones", Cost=199.99M, Description="Noise-canceling headphones that deliver immersive sound quality.", Category="Electronics", Brand="SoundWave", StockQuantity=100, ImageUrl="/images/headphones.png"},
            };
             Cloths = new List<Product>
            {
                new Product{ProductId=10, Name="T-Shirt", Cost=19.99M, Description="A comfortable and stylish t-shirt made from soft cotton fabric.", Category="Clothing", Brand="FashionHub", StockQuantity=200, ImageUrl="/images/tshirt.png"},
                new Product{ProductId=11, Name="Jeans", Cost=49.99M, Description="Classic denim jeans with a modern fit and durable construction.", Category="Clothing", Brand="FashionHub", StockQuantity=150, ImageUrl="/images/jeans.png"},
                new Product{ProductId=12, Name="Jacket", Cost=89.99M, Description="A versatile jacket that provides warmth and style for any occasion.", Category="Clothing", Brand="StyleCo", StockQuantity=80, ImageUrl="/images/jacket.png"},
            };
        }
        public List<Product> GetAllCosmeticProducts()
        {
            return cosmeticProducts; 
        }
        public List<Product> GetAllElectronicProducts()
        {
            return electronicProducts;
        }
        public List<Product> GetAllClothProduct()
        {
            return Cloths;
        }
        public List<Product> GetAllProducts()
        {
            return cosmeticProducts
                    .Concat(electronicProducts)
                    .Concat(Cloths)
                    .ToList();
        }
    }
}
