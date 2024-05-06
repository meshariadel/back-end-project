namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class ProductRepository : IProductRepository
    {
        private IEnumerable<Product> _product;

        public ProductRepository(DatabaseContext databaseContext)
        {
            _product = databaseContext.Product;
        }
        public IEnumerable<Product> FindAll()
        {
            return _product;
        }
        public Product? FindOne(string foundProduct)
        {
            Product? product = _product.FirstOrDefault(product => product.ProductId == foundProduct);
            return product;
        }

        public Product CreateOne(Product product)
        {
            _product = _product.Append(product);
            return product;
        }

        public Product UpdateOne(Product updatedProduct)
        {
            var products = _product.Select(product =>
        {
            if (product.Name == updatedProduct.Name)
            {

                return updatedProduct;
            }
            return updatedProduct;
        });
            _product = products.ToList();

            return updatedProduct;
        }
    }
}