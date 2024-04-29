using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Entities;



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
