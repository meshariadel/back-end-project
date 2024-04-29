using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.User.Controllers;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.controllers;
public class productController : ControllerTemplate
{

    private IProductService _productService;
    public productController(IProductService productService)
    {
        _productService = productService;
    }
    [HttpGet]
    public List<Product> FindAll()
    {
        return _productService.FindAll();

    }
    [HttpGet("{productId}")]
    public Product? FindOne(string productId)
    {
        return _productService.FindOne(productId);
    }

}
