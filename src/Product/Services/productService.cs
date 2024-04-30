using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Abstractions;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.controllers;



public class productService : IProductService
{
    private IProductRepository _productRepository;
    public productService(IProductRepository productRepository)
    {
        _productRepository = productRepository;

    }
    public IEnumerable<Product> FindAll()
    {

        return _productRepository.FindAll();
    }

    public Product? FindOne(string product)
    {
        return _productRepository.FindOne(product);
    }
    public IEnumerable<Product> CreateOne(Product product)
    {
        Product? foundProduct = _productRepository.FindOne(product.Name);

        if (foundProduct is not null)
        {
            throw new Exception("Product " + product.Name + " already exists");
        }
        return _productRepository.CreateOne(product);
    }

}
