public enum Category {Electronic, Clothing, Books, Groceries}

public class ProductRepository<T> where T : class, IProduct
{
    private List<T> _products = new List<T>();

    public void AddProduct(T product)
    {
        if()
    }
}