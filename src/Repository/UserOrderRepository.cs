using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.DataBases;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Repository
{
    public class UserOrderRepository : IUserOrderRepository
    {
        private List<UserOrder> _userOrder;

        public UserOrderRepository()
        {
            _userOrder = new DataBaseContext().userOrder;
        }
        public List<UserOrder> FindAll()
        {
            return _userOrder;
        }
    }
}