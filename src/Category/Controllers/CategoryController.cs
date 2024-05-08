using Microsoft.AspNetCore.Mvc;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class CategoryController : ControllerTemplate
    {
        private ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<CategoryReadDto>> FindAll([FromQuery(Name = "limit")] int limit, [FromQuery(Name = "offset")] int offset)
        {
            return Ok(_categoryService.FindAll(limit, offset));
        }

        [HttpGet("{categoryId}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<CategoryReadDto> FindOne(Guid categoryId)
        {

            var foundCategory = _categoryService.FindOne(categoryId);
            if (foundCategory is not null)
            {
                return CreatedAtAction(nameof(FindOne), foundCategory);

            }
            return BadRequest();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<CategoryReadDto> CreateOne([FromBody] CategoryCreateDto category)
        {
            if (category is not null)
            {
                var createdCategory = _categoryService.CreateOne(category);
                return CreatedAtAction(nameof(CreateOne), createdCategory);
            }
            return BadRequest();
        }


        [HttpDelete("{categoryId}")]

        [ProducesResponseType(StatusCodes.Status202Accepted)]
        public ActionResult DeleteOne(Guid categoryId)
        {

            return Accepted(_categoryService.DeleteOne(categoryId));


        }


    }
}
