namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public interface ICategoryService
    {
        public IEnumerable<CategoryReadDto> FindAll(int limit, int offset);
        public CategoryReadDto CreateOne(CategoryCreateDto category);
        public CategoryReadDto? FindOne(Guid categoryId);
        public bool DeleteOne(Guid categoryId);
    }
}