

using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src;


public class DatabaseContext
{
    public List<UserOrder> userOrder;
    public List<Product> products;
    public DatabaseContext()
    {
        products = [
            new Product( ProductSize.L, "Red",  155.99 ,12 ,"picture","T-shirt","red t-shirt"),
            new Product( ProductSize.S, "Red",  155.99 ,12 ,"picture","T-shirt","red t-shirt"),
            new Product( ProductSize.M, "Red",  155.99 ,12 ,"picture","T-shirt","red t-shirt")
            ];
            userOrder = [
                new UserOrder("1","1","1","Riyadh",DateTime.Now,new DateTime(2024,05,01),UserOrder.OrderStatus.OutForDelivery)
            ];


        
    }
}
