namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public interface IOrderRepository
    {
        public IEnumerable<Order> FindAll();
        public Order CreateOne(Order order);
        public Order? FindOne(Order newOrder);
        public Order? FindOneById(Guid id);
        public Order? UpdateOne(Order updateUserOrder);
    }
}