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

        [HttpGet("{orderItemId}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<OrderItem> FindOne(Guid orderItemId)
        {

            var foundOrderItem = _orderItemService.FindOne(orderItemId);
            if (foundOrderItem is not null)
            {

                return CreatedAtAction(nameof(FindOne), foundOrderItem);
            }
            else
                return NotFound();
        }



    }

}

