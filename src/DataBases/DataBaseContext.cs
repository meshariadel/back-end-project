

using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.DataBases
{
    public class DataBaseContext
    {
        public List<UserOrder> userOrder;

        public DataBaseContext()
        {
            userOrder = [
                new UserOrder("1","1","1","Riyadh",DateTime.Now,new DateTime(2024,05,01),UserOrder.OrderStatus.OutForDelivery)
            ];
        }
    }
}