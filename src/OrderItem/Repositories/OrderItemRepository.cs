using Microsoft.EntityFrameworkCore;


namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class OrderItemRepository : IOrderItemRepository
    {


        private DbSet<OrderItem> _orderitems;
        public OrderItemRepository(DatabaseContext databaseContext)
        {
            _orderitems = databaseContext.OrderItem;
        }

        public IEnumerable<OrderItem> FindAll()
        {
            return _orderitems;
        }


        public OrderItem? UpdateOne(string orderItemId, int newQuantity, decimal newTotalPrice)
        {

            OrderItem? itemToUpdate = _orderitems.FirstOrDefault(item => item.OrderItemId == orderItemId);
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


        public IEnumerable<OrderItem> DeleteAll()
        {
            foreach (var item in _orderitems.ToList())
            {
                _orderitems.Remove(item);
            }

            return _orderitems;

        }



        public OrderItem? FindOne(string foundOrderItem)
        {
            OrderItem? order = _orderitems.FirstOrDefault(o => o.OrderId == foundOrderItem);
            return order;
        }

        public OrderItem CreateOne(OrderItem orderitem)
        {
            _orderitems = (DbSet<OrderItem>)_orderitems.Append(orderitem);
            return orderitem;
        }

    }
}