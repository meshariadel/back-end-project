using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class ProductRepository : IProductRepository
    {
        private DbSet<Product> _products;

        private DatabaseContext _DbContext;

        public ProductRepository(DatabaseContext databaseContext)
        {
            _products = databaseContext.Product;
            _DbContext = databaseContext;
        }
        /*  public IEnumerable<Product> FindAll(int limit, int offset)
          {
              if (limit == 0 & offset == 0)
              {
                  return _products;
              }
              return _products.Skip(offset).Take(limit);
          }*/


        public IEnumerable<Product> FindAll()
        {

            return _products;

        }



        public Product? FindOne(Guid productId)
        {
            return _DbContext.Product.Find(productId);
        }


        public Product CreateOne(Product product)
        {
            _products.Add(product);
            _DbContext.SaveChanges();
            return product;
        }

        public Product UpdateOne(Product updatedProduct)
        {
            _DbContext.Product.Update(updatedProduct);
            _DbContext.SaveChanges();
            return updatedProduct;
        }
        public bool DeleteOne(Product product)
        {
            _DbContext.Product.Remove(product);
            _DbContext.SaveChanges();
            return true;
        }
        public IEnumerable<Product> Search(string keyword)
        {
            return _DbContext.Product
                    .Where(p => p.Name.Contains(keyword))
                    .ToList();
        }

    }


}
