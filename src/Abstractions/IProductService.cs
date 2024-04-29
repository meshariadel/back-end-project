
namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers;
public interface IProductService
{

    public List<Product> FindAll();
    public Product? FindOne(string product);

}