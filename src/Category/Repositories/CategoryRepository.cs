
using Microsoft.EntityFrameworkCore;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class CategoryRepository : ICategoryRepository
    {
        private DbSet<Category> _category;
        private DatabaseContext _databaseContext;

        public CategoryRepository(DatabaseContext databaseContext)
        {
            _category = databaseContext.Category;
            _databaseContext = databaseContext;
        }
        public Category CreateOne(Category category)
        {
            _category.Add(category);
            _databaseContext.SaveChanges();
            return category;
        }

        public Category? DeleteOne(Guid categoryId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> FindAll()
        {
            throw new NotImplementedException();
        }

        public Category? FindOne(Guid categoryId)
        {
            throw new NotImplementedException();
        }

        public Category? UpdateOne(Category updateCategory)
        {
            throw new NotImplementedException();
        }

    }
}