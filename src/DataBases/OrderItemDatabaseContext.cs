namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{

    public class OrderItemDatabaseContext
    {
        public List<OrderItem> OrderItem;

        public OrderItemDatabaseContext()
        {
            OrderItem = [
           new OrderItem(1,100),

            new OrderItem(2,200),

            new OrderItem(6,7700),

            new OrderItem(3,1300)
            ];
        }
    }
}