namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class ProductRepository : IProductRepository
    {
        private IEnumerable<Product> _products;

        private DatabaseContext _dbContext;
        public ProductRepository(DatabaseContext databaseContext)
        {
            _products = databaseContext.Product;
            _dbContext = databaseContext;
        }
        public IEnumerable<Product> FindAll()
        {
            return _products;
        }
        public Product? FindOne(Guid foundProduct)
        {
            return _dbContext.Product.Find(foundProduct);
        }
        public Product? FindOneByName(string name)
        {
            return _dbContext.Product.Find(name);
        }

        public Product CreateOne(Product product)
        {
            _products = _products.Append(product);
            return product;
        }

        public Product UpdateOne(Product updatedProduct)
        {
            var products = _products.Select(product =>
        {
            if (product.Name == updatedProduct.Name)
            {

                return updatedProduct;
            }
            return updatedProduct;
        });
            _products = products.ToList();

            return updatedProduct;
        }
        public bool DeleteOne(Product product)
        {
            _dbContext.Product.Remove(product);
            _dbContext.SaveChanges();
            return true;
        }

    }


}
