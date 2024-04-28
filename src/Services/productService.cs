namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.controllers
{


    public class productService : IProductService
    {

        public List<Product> FindAll()
        {
            var serviceFindAll = new ProductRepository();
            return serviceFindAll.FindAll();
        }

    }
}