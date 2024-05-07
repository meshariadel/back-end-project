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
        public OrderReadDto CreateOne(List<OrderCreateDto> orderCheckout)
        {
            /*
            1. create Order
            2. loop thru orderCheckout and create order item per iteration
            */
            Order order = new Order
            {
                AddressId = orderCheckout[0].AddressId,
                CreatedAt = DateTime.Now,
                UserId = new Guid("ab19e11f-9481-4595-8c93-772fc282f651"),
                PaymentId = Guid.NewGuid()
            };
            order = _orderRepository.CreateOne(order);
            foreach (var item in orderCheckout)
            {
                var orderItem = new OrderItem
                {
                    OrderId = order.Id,
                    ProductId = item.ProductId,
                    Quantity = item.Quantity
                };

                _orderItemService.CreateOne(orderItem);
            }

            // map order to OrderReadDto
            return;
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