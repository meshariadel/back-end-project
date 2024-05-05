namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class OrderItemService : IOrderItemService
    {
        private IOrderItemRepository _orderItemRepository;
        public OrderItemService(IOrderItemRepository orderItemRepository)
        {
            _orderItemRepository = orderItemRepository;
        }

        public List<OrderItem> FindAll()
        {

            return _orderItemRepository.FindAll();
        }

        public OrderItem? UpdateOne(string orderItemId, int newQuantity, decimal newTotalPrice)

        {

            return _orderItemRepository.UpdateOne(orderItemId, newQuantity, newTotalPrice);
        }

        public List<OrderItem> DeleteAll()
        {
            return _orderItemRepository.DeleteAll();
        }
    }
}