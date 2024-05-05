namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public interface IOrderItemService
    {


        public List<OrderItem> FindAll();
        public OrderItem? UpdateOne(string orderItemId, int newQuantity, decimal newTotalPrice);
        public List<OrderItem> DeleteAll();
    }
}