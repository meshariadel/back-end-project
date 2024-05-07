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





        public Product CreateOne(Product product)
        {

            return _productRepository.CreateOne(product);
        }

        public Product UpdateOne(Guid productId, Product updatedProduct)
        {
            Product? product = _productRepository.FindOne(productId);
            if (product is not null)
            {
                return _productRepository.UpdateOne(product);

            }
            return null;
        }

        public bool DeleteOne(Guid productId)
        {

            Product? deleteProduct = _productRepository.FindOne(productId);
            if (deleteProduct is null) return false;
            _productRepository.DeleteOne(deleteProduct);
            return true;
        }

        public ProductReadDto? FindOne(Guid product)
        {
            var productId = _productRepository.FindOne(product);

            if (productId is not null)
            {
                var productRead = _Mapper.Map<ProductReadDto>(productId);
                return productRead;
            }
            return null;
        }
    }
}
