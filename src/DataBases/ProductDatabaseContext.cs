using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Entities;
namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class ProductDatabaseContext
    {
        public IEnumerable<Product> products;
        public ProductDatabaseContext()
        {
            products = [
                new Product("0", ProductSize.S, "Red", 159.99 ,14 ,"picture","T-shirt","red t-shirt"),
            new Product("1", ProductSize.L, "Red",  155.99 ,12 ,"picture","Coat","red t-shirt"),
            new Product( "2",ProductSize.S, "Red",  155.99 ,12 ,"picture","Shirt","red t-shirt"),
            new Product( "3",ProductSize.M, "blue",  159.99 ,12 ,"picture","Jeans","blue t-shirt")
                ];

        }
    }
}
