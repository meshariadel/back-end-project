using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Abstractions;
namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers;


public class ProductRepository : IProductRepository
{
    private IEnumerable<Product> _product;

    public ProductRepository()
    {
        _product = new ProductDatabaseContext().products;
    }
    public IEnumerable<Product> FindAll()
    {
        return _product;
    }
    public Product? FindOne(string foundProduct)
    {
        Product? product = _product.FirstOrDefault(product => product.Name == foundProduct);
        return product;
    }

    public IEnumerable<Product> CreateOne(Product product)
    {
        _product = _product.Append(product);
        return _product;
    }
}