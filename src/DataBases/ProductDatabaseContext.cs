

using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src;


public class ProductDatabaseContext
{
    public List<Product> products;
    public ProductDatabaseContext()
    {
        products = [
            new Product("1", ProductSize.L, "Red",  155.99 ,12 ,"picture","T-shirt","red t-shirt"),
            new Product( "2",ProductSize.S, "Red",  155.99 ,12 ,"picture","T-shirt","red t-shirt"),
            new Product( "3",ProductSize.M, "Red",  155.99 ,12 ,"picture","T-shirt","red t-shirt")
            ];

    }
}
