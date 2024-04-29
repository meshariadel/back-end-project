using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Abstractions;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.controllers;



public class productService : IProductService
{
    private IProductRepository _productRepository;
    public productService(IProductRepository productRepository)
    {
        _productRepository = productRepository;

    }
    public List<Product> FindAll()
    {

        return _productRepository.FindAll();
    }

    public Product? FindOne(string product)
    {
        throw new NotImplementedException();
    }
}
