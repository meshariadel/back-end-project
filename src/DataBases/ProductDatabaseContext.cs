

using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src;


public class ProductDatabaseContext
{
    public List<Product> products;
    public ProductDatabaseContext()
    {
        products = [
            new Product( ProductSize.L, "Red",  155.99 ,12 ,"picture","T-shirt","red t-shirt"),
            new Product( ProductSize.S, "Red",  155.99 ,12 ,"picture","T-shirt","red t-shirt"),
            new Product( ProductSize.M, "Red",  155.99 ,12 ,"picture","T-shirt","red t-shirt")
            ];

    }
}
