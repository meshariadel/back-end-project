using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Service
{
    public class UserOrderService : IUserOrderService
    {
        private IUserOrderRepository _userOrderRepository;

        public UserOrderService(IUserOrderRepository userOrderRepository)
        {
            _userOrderRepository = userOrderRepository;
        }

        public List<UserOrder> FindAll()
        {
            return _userOrderRepository.FindAll();
        }
    }
}