using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.Entites;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.OrderItemRepositories;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Abstractions;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.Services;



public class OrderItemService : IOrderItemService
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