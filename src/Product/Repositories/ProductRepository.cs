using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class ProductRepository : IProductRepository
    {
        private Db_Set<Product> _products;

        private DatabaseContext _Db_Context;

        public ProductRepository(DatabaseContext databaseContext)
        {
            _products = databaseContext.Product;
            _Db_Context = databaseContext;
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
            return _Db_Context.Product.Find(productId);
        }


        public Product CreateOne(Product product)
        {
            _products.Add(product);
            _Db_Context.SaveChanges();
            return product;
        }

        public Product UpdateOne(Product updatedProduct)
        {
            _Db_Context.Product.Update(updatedProduct);
            _Db_Context.SaveChanges();
            return updatedProduct;
        }
        public bool DeleteOne(Product product)
        {
            _Db_Context.Product.Remove(product);
            _Db_Context.SaveChanges();
            return true;
        }
        public IEnumerable<Product> Search(string keyword)
        {
            return _Db_Context.Product
                    .Where(p => p.Name.Contains(keyword))
                    .ToList();
        }

    }


}
