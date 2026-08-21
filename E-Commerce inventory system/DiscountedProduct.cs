public class DiscountedProduct<T> where T : IProduct
{
    private T _product;
    private decimal _discountPercentage;

    public DiscountedProduct(T product, decimal discountPercentage)
    {
        if(product == null)
        {
            throw new ArgumentNullException("Product is null");
        }
        if(discountPercentage < 0 || discountPercentage > 100)
        {
            throw new ArgumentException("Discount must be between 0 and 100");
        }
        _product = product;
        _discountPercentage = discountPercentage;
    }
}

///Ieumerable 
/// IQueryable  in context of Linq
/// 
/// eager loading
/// lazy loading