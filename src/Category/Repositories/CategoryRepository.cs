
using Microsoft.EntityFrameworkCore;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class CategoryRepository : ICategoryRepository
    {
        private DbSet<Category> _category;
        private DatabaseContext _DbContext;

        public CategoryRepository(DatabaseContext databaseContext)
        {
            _category = databaseContext.Category;
            _DbContext = databaseContext;
        }
        public Category CreateOne(Category category)
        {
            _category.Add(category);
            _DbContext.SaveChanges();
            return category;
        }

        public bool DeleteOne(Category category)
        {
            _DbContext.Category.Remove(category);
            _DbContext.SaveChanges();
            return true;
        }

        public IEnumerable<Category> FindAll(int limit, int offset)
        {
            if (limit == 0 & offset == 0)
            {
                return _category;
            }
            return _category.Skip(offset).Take(limit);
        }

        public Category? FindOne(Guid categoryId)
        {
            return _DbContext.Category.Find(categoryId);
        }


    }
}