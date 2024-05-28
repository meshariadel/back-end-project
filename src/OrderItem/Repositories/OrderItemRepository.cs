using Microsoft.EntityFrameworkCore;


namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class OrderItemRepository : IOrderItemRepository
    {
        private DatabaseContext _Db_Context;

        private Db_Set<OrderItem> _orderitems;


        public OrderItemRepository(DatabaseContext databaseContext)
        {
            _orderitems = databaseContext.OrderItem;
            _Db_Context = databaseContext;

        }

        public IEnumerable<OrderItem> FindAll()
        {
            return _orderitems;
        }


        public OrderItem? UpdateOne(Guid orderItemId, int newQuantity, decimal newTotalPrice)
        {

            OrderItem? itemToUpdate = _orderitems.FirstOrDefault(item => item.Id == orderItemId);
            if (itemToUpdate != null)
            {
                // Update properties of the found item
                itemToUpdate.Quantity = newQuantity;
                itemToUpdate.TotalPirce = newTotalPrice;
                return itemToUpdate;
            }
            else
            {
                throw new ArgumentException("Order item not found");
            }


        }


        public void DeleteAll()
        {
            _Db_Context.OrderItem.RemoveRange(_orderitems);
            _Db_Context.SaveChanges();
        }







        public OrderItem? FindOne(Guid foundOrderItem)
        {
            OrderItem? order = _orderitems.FirstOrDefault(o => o.Id == foundOrderItem);
            return order;
        }

        public OrderItem CreateOne(OrderItem orderitem)
        {
            _orderitems.Add(orderitem);
            _Db_Context.SaveChanges();
            return orderitem;
        }

    }
}