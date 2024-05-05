using AutoMapper;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class OrderItemService : IOrderItemService
    {
        private IOrderItemRepository _orderItemRepository;

        private IConfiguration _config;

        private IMapper _Mapper;
        public OrderItemService(IOrderItemRepository orderItemRepository, IConfiguration config, IMapper mapper)
        {
            _orderItemRepository = orderItemRepository;
            _config = config;
            _Mapper = mapper;
        }

        public IEnumerable<OrderItem> FindAll()
        {

            return _orderItemRepository.FindAll();
        }

        public OrderItem? UpdateOne(string orderItemId, int newQuantity, decimal newTotalPrice)

        {

            return _orderItemRepository.UpdateOne(orderItemId, newQuantity, newTotalPrice);
        }

        public IEnumerable<OrderItem> DeleteAll()
        {
            return _orderItemRepository.DeleteAll();
        }


        public OrderItem? FindOne(string order)
        {
            var orderId = _orderItemRepository.FindOne(order);

            if (orderId is not null)
            {
                var orderRead = _Mapper.Map<OrderItem>(orderId);
                return orderRead;
            }
            throw new Exception("Order Id " + orderId + " is not found ");
        }



        public OrderItem CreateOne(OrderItem orderItem)
        {
            OrderItem? foundOrderItem = _orderItemRepository.FindOne(orderItem.OrderItemId);

            if (foundOrderItem is not null)
            {
                throw new Exception("OrderItem " + orderItem.OrderItemId + " already exists");
            }
            return _orderItemRepository.CreateOne(orderItem);
        }

    }
}

