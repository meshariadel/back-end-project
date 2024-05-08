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
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<ProductReadDto>> FindAll([FromQuery(Name = "limit")] int limit, [FromQuery(Name = "offset")] int offset)
        {
            return Ok(_productService.FindAll(limit, offset));

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

        public ActionResult<ProductReadDto> CreateOne([FromBody] ProductCreateDto product)
        {
            if (product is not null)
            {
                var createdProduct = _productService.CreateOne(product);
                return CreatedAtAction(nameof(CreateOne), createdProduct);
            }
            return BadRequest();
        }

        [HttpPatch]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        // [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<ProductReadDto> UpdateOne(Guid productId, [FromBody] ProductUpdateDto updatedProduct)
        {
            ProductReadDto product = _productService.UpdateOne(productId, updatedProduct);
            return Accepted(product);
        }



        [HttpDelete(":productId")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        public ActionResult DeleteOne(Guid productId)
        {

            return Accepted(_productService.DeleteOne(productId));


        }
    }
}
