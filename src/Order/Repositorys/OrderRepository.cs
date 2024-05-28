using Microsoft.EntityFrameworkCore;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class OrderRepository : IOrderRepository
    {
        private Db_Set<Order> _order;
        private DatabaseContext _Db_Context;
        public OrderRepository(DatabaseContext Db_Context)
        {
            _order = Db_Context.Order;
            _Db_Context = Db_Context;
        }
        public IEnumerable<Order> FindAll()
        {
            return _order;
        }
        public Order CreateOne(Order order)
        {
            _order.Add(order);
            _Db_Context.SaveChanges();
            return order;
        }
        public Order? FindOne(Order NewOrder)
        {
            Order? order = _order.FirstOrDefault(order => order.Id == NewOrder.Id);

            return order;
        }
        public Order? FindOneById(Guid id)
        {
            Order? order = _order.FirstOrDefault(order => order.Id == id);

            return order;
        }
        public Order? UpdateOne(Order updateOrder)
        {
            _order.Update(updateOrder);
            _Db_Context.SaveChanges();
            return updateOrder;
        }
    }
}
