using Microsoft.AspNetCore.Mvc;
namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
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
        public ActionResult<ProductReadDto?> FindOne(Guid productId)
        {

            var foundProduct = _productService.FindOne(productId);
            if (foundProduct is not null)
            {
                return CreatedAtAction(nameof(FindOne), foundProduct);
            }
            else
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
        public Product? UpdateOne(Guid productId, [FromBody] Product product)
        {

            if (product is not null)
            {
                return _productService.UpdateOne(productId, product);

            }
            return null;
        }
        [HttpDelete(":productId")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        public ActionResult DeleteOne(Guid productId)
        {

            return Accepted(_productService.DeleteOne(productId));


        }
    }
}
