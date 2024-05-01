
using static sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.DTOs.ProductDto;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers;
public interface IProductService
{

    public IEnumerable<Product> FindAll();
    public ProductReadDto? FindOne(string product);
    public Product CreateOne(Product product);
    public Product UpdateOne(string productName, Product product);
}