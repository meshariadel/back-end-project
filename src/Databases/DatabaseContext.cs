
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.Entites;
namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.Databases;



public class DatabaseContext 
{
    public List<OrderItem> order_item;

    public DatabaseContext(){

        order_item = [
            new OrderItem(1,100),

            new OrderItem(2,200),

            new OrderItem(6,7700),

            new OrderItem(3,1300),
            


        ];
    }

}