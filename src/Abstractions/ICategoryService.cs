namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public interface ICategoryService
    {
        public IEnumerable<CategoryReadDto> FindAll();
        public CategoryReadDto CreateOne(CategoryCreateDto category);
        public CategoryReadDto? FindOne(Guid categoryId);
        public CategoryReadDto? DeleteOne(Guid categoryId);

        public CategoryReadDto? UpdateOne(Guid categoryId, CategoryUpdateDto categoryUpdate);
    }
}