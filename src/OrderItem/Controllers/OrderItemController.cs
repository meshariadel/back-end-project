using Microsoft.AspNetCore.Mvc;
namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{

    public class OrderItemController : ControllerTemplate
    {
        private IOrderItemService _orderItemService;
        public OrderItemController(IOrderItemService orderItemService)
        {
            _orderItemService = orderItemService;
        }

        [HttpGet]
        public List<OrderItem> FindAll()
        {

            return _orderItemService.FindAll();
        }

        [HttpPost("updateone")]

        public OrderItem? UpdateOne(string orderItemId, int newQuantity, decimal newTotalPrice)

        {
            return _orderItemService.UpdateOne(orderItemId, newQuantity, newTotalPrice);
        }


        [HttpGet("delete")]

        public List<OrderItem> DeleteAll()
        {
            return _orderItemService.DeleteAll();
        }


    }

}