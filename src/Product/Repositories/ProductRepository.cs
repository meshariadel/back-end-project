using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Abstractions;
namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers;


public class ProductRepository : IProductRepository
{
    private List<Product> _product;

    public ProductRepository()
    {
        _product = new ProductDatabaseContext().products;
    }
    public List<Product> FindAll()
    {
        return _product;
    }
    public Product? FindOne(string productId)
    {
        Product? product = _product.FirstOrDefault(product => product._ProductId == productId);
        return product;
    }

    public Product CreateOne(Product product)
    {
        _product.Add(product);
        return product;
    }
}