
using Microsoft.EntityFrameworkCore;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class CategoryRepository : ICategoryRepository
    {
        private Db_Set<Category> _category;
        private DatabaseContext _Db_Context;

        public CategoryRepository(DatabaseContext databaseContext)
        {
            _category = databaseContext.Category;
            _Db_Context = databaseContext;
        }
        public Category CreateOne(Category category)
        {
            _category.Add(category);
            _Db_Context.SaveChanges();
            return category;
        }

        public bool DeleteOne(Category category)
        {
            _Db_Context.Category.Remove(category);
            _Db_Context.SaveChanges();
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
            return _Db_Context.Category.Find(categoryId);
        }


    }
}