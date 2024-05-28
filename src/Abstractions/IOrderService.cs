namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
        public interface IOrderService
        {
                public IEnumerable<OrderReadDto> FindAll();
                public void CreateOne(List<OrderCreateDto> userOrder, string userId);
                public Order? FindOneById(Guid id);
                public Order? UpdateOne(Guid id, Order.OrderStatus status);

        }
}