namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class UserOrderDatabaseContext
    {

        public List<UserOrder> userOrder;
        public UserOrderDatabaseContext()
        {
            userOrder = [
                    new UserOrder("1","1","1","Riyadh",DateTime.Now,new DateTime(2024,05,01),UserOrder.OrderStatus.OutForDelivery)
                ];
        }

    }
}
