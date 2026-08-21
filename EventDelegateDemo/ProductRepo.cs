namespace EventDelegateDemo
{
    class ProductRepo : IRepo<Product>
    {
        public bool Add(Product item)
        {
            throw new NotImplementedException();
        }

        public Product SearchById(int id)
        {
            throw new NotImplementedException();
        }
    }
}