namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> FindAll(int limit, int offset);
        public Category CreateOne(Category category);
        public Category? FindOne(Guid categoryId);
        public bool DeleteOne(Category category);

        public Category? UpdateOne(Category updateCategory);
    }
}