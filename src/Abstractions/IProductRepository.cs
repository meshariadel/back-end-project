namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public interface IProductRepository
    {

        public IEnumerable<Product> FindAll();
        public Product? FindOne(string product);

        public Product CreateOne(Product product);

        public Product UpdateOne(Product updatedProduct);
    }
}