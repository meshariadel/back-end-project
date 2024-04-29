using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.Entites;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.OrderItemRepositories;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.Services;



public class UserService
{

    public List<OrderItem> FindAll()
    {
        var servicesFindAll = new OrderItemRepository();

        return servicesFindAll.FindAll();
    }

    public OrderItem? UpdateOne(string orderItemId, int newQuantity, decimal newTotalPrice)

    {
        var services = new OrderItemRepository();

        return services.UpdateOne(orderItemId, newQuantity, newTotalPrice);
    }

    public List<OrderItem> DeleteAll()
    {

        var services = new OrderItemRepository();

        return services.DeleteAll();
    }
}