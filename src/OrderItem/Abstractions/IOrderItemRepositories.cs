using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.Entites;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Abstractions
{
    public interface IOrderItemRepository
    {


        public List<OrderItem> FindAll();

        public OrderItem? UpdateOne(string orderItemId, int newQuantity, decimal newTotalPrice);



        public List<OrderItem> DeleteAll();


    }
}