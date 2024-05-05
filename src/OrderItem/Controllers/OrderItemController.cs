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

        [HttpGet("findall")]
        public IEnumerable<OrderItem> FindAll()
        {

            return _orderItemService.FindAll();
        }

        /* [HttpPost("updateone")]

         public OrderItem? UpdateOne(string orderItemId, int newQuantity, decimal newTotalPrice)

         {
             return _orderItemService.UpdateOne(orderItemId, newQuantity, newTotalPrice);
         }


         [HttpGet("delete")]

         public List<OrderItem> DeleteAll()
         {
             return _orderItemService.DeleteAll();
         }
 */
        [HttpGet("findone")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<OrderItem> FindOne(string OrderId)
        {
            if (OrderId is not null)
            {
                var foundOrderItem = _orderItemService.FindOne(OrderId);
                if (foundOrderItem is not null)
                {

                    return CreatedAtAction(nameof(FindOne), foundOrderItem);
                }
                else
                    return BadRequest();

            }
            return BadRequest();
        }



    }

}

