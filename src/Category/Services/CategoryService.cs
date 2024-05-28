
using AutoMapper;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _categoryRepository;
        private IConfiguration _config;

        private IMapper _Mapper;
        public CategoryService(ICategoryRepository categoryRepository, IConfiguration config, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _config = config;
            _Mapper = mapper;
        }
        public CategoryReadDto CreateOne(CategoryCreateDto newCategory)
        {

            var category = _Mapper.Map<Category>(newCategory);
            _categoryRepository.CreateOne(category);
            return _Mapper.Map<CategoryReadDto>(category);
        }

        public bool DeleteOne(Guid categoryId)
        {
            Category? deleteCategory = _categoryRepository.FindOne(categoryId);
            if (deleteCategory is null) return false;
            _categoryRepository.DeleteOne(deleteCategory);
            return true;
        }

        public IEnumerable<CategoryReadDto> FindAll(int limit, int offset)
        {
            IEnumerable<Category> categories = _categoryRepository.FindAll(limit, offset);
            return categories.Select(_Mapper.Map<CategoryReadDto>);
        }

        public CategoryReadDto? FindOne(Guid category)
        {
            var categoryId = _categoryRepository.FindOne(category);
            if (categoryId is not null)
            {
                var categoryRead = _Mapper.Map<CategoryReadDto>(categoryId);
                return categoryRead;

            }
            return null;
        }

    }
}