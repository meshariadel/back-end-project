
namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers;
public interface IProductService
{

    public IEnumerable<Product> FindAll();
    public Product? FindOne(string product);

    public IEnumerable<Product> CreateOne(Product product);
}