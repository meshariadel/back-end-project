

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class OrderItemRepository : IOrderItemRepository
    {
        private List<OrderItem> _orderitems;
        public OrderItemRepository()
        {
            _orderitems = new OrderItemDatabaseContext().OrderItem;
        }

        public List<OrderItem> FindAll()
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


        public List<OrderItem> DeleteAll()
        {


            _orderitems.Clear();

            return _orderitems;

        }

    }
}