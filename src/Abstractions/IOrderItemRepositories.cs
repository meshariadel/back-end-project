namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public interface IOrderItemRepository
    {


        public IEnumerable<OrderItem> FindAll();

        public OrderItem? UpdateOne(string orderItemId, int newQuantity, decimal newTotalPrice);



        public IEnumerable<OrderItem> DeleteAll();

        public OrderItem? FindOne(string foundOrderItem);

        public OrderItem CreateOne(OrderItem orderitem);


    }
}