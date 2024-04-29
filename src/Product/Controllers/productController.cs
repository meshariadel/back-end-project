using Microsoft.AspNetCore.Mvc;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.controllers;

[ApiController]
[Route("api / [controller]")]

public class productController : ControllerBase
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

}
