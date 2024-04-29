using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.Entites;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.Services;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.Controllers;



[ApiController]

[Route("[controller]")]

public class OrderItemController : ControllerTemplate
{
    [HttpGet]

    public List<OrderItem> FindAll()
    {
        var controllFindAll = new OrderItemService();

        return controllFindAll.FindAll();
    }

    [HttpPost("updateone")]

    public OrderItem? UpdateOne(string orderItemId, int newQuantity, decimal newTotalPrice)

    {

        var controllUpdateOne = new OrderItemService();

        return controllUpdateOne.UpdateOne(orderItemId, newQuantity, newTotalPrice);
    }


    [HttpGet("delete")]

    public List<OrderItem> DeleteAll()
    {
        var contoller = new OrderItemService();

        return contoller.DeleteAll();


    }


}

public class ControllerTemplate
{
}