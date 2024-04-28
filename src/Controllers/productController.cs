using Microsoft.AspNetCore.Mvc;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.controllers;

[ApiController]
[Route("api / [controller]")]

public class productController : ControllerBase
{
    private List<Product> _products;
    public productController()
    {
        _products = new DatabaseContext().products;
    }
    [HttpGet]
    public List<Product> FindAll()
    {
        return _products;

    }

}
