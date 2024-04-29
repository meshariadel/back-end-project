using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Abstractions;
namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers;


public class ProductRepository : IProductRepository
{
    private List<Product> _product;


    public List<Product> FindAll()
    {
        return _product;
    }
}