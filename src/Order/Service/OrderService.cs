namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class OrderService : IOrderService
    {
        private IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public IEnumerable<Order> FindAll()
        {
            return _orderRepository.FindAll();
        }
        public IEnumerable<Order> CreateOne(Order order)
        {
            Order? FoundOrder = _orderRepository.FindOne(order);
            if (FoundOrder is not null)
            {
                return null;
            }
            return _orderRepository.CreateOne(order);
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