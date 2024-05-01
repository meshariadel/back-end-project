using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.User.Controllers;
using static sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.DTOs.ProductDto;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.controllers;
public class productController : ControllerTemplate
{

    private IProductService _productService;
    public productController(IProductService productService)
    {
        _productService = productService;
    }
    [HttpGet]
    public IEnumerable<ProductReadDto> FindAll()
    {
        return _productService.FindAll();

    }
    [HttpGet("{productId}")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<ProductReadDto?> FindOne(string productId)
    {
        if (productId is not null)
        {
            var foundProduct = _productService.FindOne(productId);
            if (foundProduct is not null)
            {

                return CreatedAtAction(nameof(FindOne), foundProduct);
            }
            else
                return BadRequest();

        }
        return BadRequest();
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public ActionResult<Product> CreateOne([FromBody] Product product)
    {
        if (product is not null)
        {
            var createdProduct = _productService.CreateOne(product);
            return CreatedAtAction(nameof(CreateOne), createdProduct);
        }
        return BadRequest();
    }

    [HttpPatch("{productName}")]
    // [ProducesResponseType(StatusCodes.Status204NoContent)]
    // [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public Product? UpdateOne(string productName, [FromBody] Product product)
    {

        if (product is not null)
        {
            return _productService.UpdateOne(productName, product);

        }
        return null;
    }
}
