namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public interface IProductService
    {
        public IEnumerable<ProductReadDto> FindAll();
        public ProductReadDto? FindOne(Guid product);
        public Product CreateOne(Product product);
        public Product UpdateOne(Guid productId, Product product);
        public bool DeleteOne(Guid product);
    }
}