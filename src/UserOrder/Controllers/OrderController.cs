using Microsoft.AspNetCore.Mvc;
namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{

    public class OrderController : ControllerTemplate
    {
        private IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public IEnumerable<Order> FindAll()
        {
            return _orderService.FindAll();
        }
        [HttpGet("{Id}")]
        public Order? FindOneById(Guid id)
        {
            return _orderService.FindOneById(id);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ActionResult<Order> CreateOne([FromBody] Order order)
        {
            //creating order
            if (order is not null)
            {
                var createdUserOrder = _orderService.CreateOne(order);
                return CreatedAtAction(nameof(CreateOne), createdUserOrder);
            }
            return BadRequest();

        }

        [HttpPatch("{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<Order> UpdateOne(Guid id, [FromBody] Order.OrderStatus status)
        {
            var updateStatusOrder = _orderService.UpdateOne(id, status);
            return CreatedAtAction(nameof(UpdateOne), updateStatusOrder);

        }

    }
}
