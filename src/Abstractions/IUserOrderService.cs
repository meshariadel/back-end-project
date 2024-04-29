using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Abstractions
{
    public interface IUserOrderService
    {
        public IEnumerable<UserOrder> FindAll();
        public IEnumerable<UserOrder> CreateOne(UserOrder userOrder);


    }
}