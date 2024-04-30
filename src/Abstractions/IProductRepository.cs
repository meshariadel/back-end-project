namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Abstractions
{
    public interface IProductRepository
    {

        public List<Product> FindAll();
        public Product? FindOne(string product);

        public Product CreateOne(Product product);

    }
}