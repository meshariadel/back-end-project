using AutoMapper;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class OrderService : IOrderService
    {
        private IOrderRepository _orderRepository;
        private IOrderItemService _orderItemService;
        private IConfiguration _config;
        private IMapper _Mapper;

        public OrderService(IOrderRepository orderRepository, IMapper mapper, IConfiguration configuration, IOrderItemService orderItemService)
        {
            _orderRepository = orderRepository;
            _config = configuration;
            _Mapper = mapper;
            _orderItemService = orderItemService;
        }

        public IEnumerable<OrderReadDto> FindAll()
        {
            var orders = _orderRepository.FindAll();
            var ordersRead = orders.Select(_Mapper.Map<OrderReadDto>);
            return ordersRead;
        }
        public void CreateOne(List<OrderCreateDto> orderCheckout, string userId)
        {
            Console.WriteLine($"{userId}");
            /*
            1. create Order
            2. loop thru orderCheckout and create order item per iteration
            */
            Order order = new()
            {
                AddressId = orderCheckout[0].AddressId,
                CreatedAt = DateTime.Now,
                DeliveryAt = DateTime.Now,
                UserId = new Guid(userId),
                PaymentId = Guid.NewGuid(),
                TotalPirce = 0,
            };
            _orderRepository.CreateOne(order);
            Console.WriteLine($"{order.Id}");

            // productPrice??  find the product by id and get it's price
            // var productPrice = Prod
                  foreach (var item in orderCheckout)
            {
                var orderItem = new OrderItem
                {
                    OrderId = order.Id,
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    // TotalPirce = productPrice * item.Quantity
                };
                order.TotalPirce += orderItem.TotalPirce;
                _orderItemService.CreateOne(orderItem);
            }

            _orderRepository.UpdateOne(order);

            // map order to OrderReadDto
            /*
            1. add the missing properties in Order
            2. before creating OrderItem you should check
                - quantity in the orderCheckout is less or equal to the stock
                - calculate the total amount for all the products
            3. Build the relation between the entities
            3. create payment (do this when payment is done)
            4. get the user id from the token (do this when auth is done)
            */

        }
        public Order? FindOneById(Guid id)
        {
            return _orderRepository.FindOneById(id);
        }

        public Order? UpdateOne(Guid id, Order.OrderStatus status)
        {
            Order? userOrder = _orderRepository.FindOneById(id);
            if (userOrder is not null)
            {
                userOrder.Status = status;
                return _orderRepository.UpdateOne(userOrder);

            }
            return null;
        }
    }
}