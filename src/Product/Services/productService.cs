using AutoMapper;
namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class productService : IProductService
    {
        private IProductRepository _productRepository;
        private IConfiguration _config;

        private IMapper _Mapper;
        public productService(IProductRepository productRepository, IConfiguration config, IMapper mapper)
        {
            _productRepository = productRepository;
            _config = config;
            _Mapper = mapper;
        }
        public IEnumerable<ProductReadDto> FindAll()
        {
            var products = _productRepository.FindAll();
            var usersRead = products.Select(_Mapper.Map<ProductReadDto>);
            return usersRead;
        }

        public ProductReadDto? FindOne(string product)
        {
            var productId = _productRepository.FindOne(product);

            if (productId is not null)
            {
                var productRead = _Mapper.Map<ProductReadDto>(productId);
                return productRead;
            }
            throw new Exception("Product Id " + productId + " is not found ");
        }



        public Product CreateOne(Product product)
        {
            Product? foundProduct = _productRepository.FindOne(product.Name);

            if (foundProduct is not null)
            {
                throw new Exception("Product " + product.Name + " already exists");
            }
            return _productRepository.CreateOne(product);
        }

        public Product UpdateOne(string productName, Product updatedProduct)
        {
            Product? product = _productRepository.FindOne(productName);
            if (product is not null)
            {
                product.Color = updatedProduct.Color;
                return _productRepository.UpdateOne(product);

            }
            throw new Exception("Product " + productName + " do not exists");
        }
    }
}
