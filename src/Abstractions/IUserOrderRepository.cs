using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Abstractions
{
    public interface IUserOrderRepository
    {
          public List<UserOrder> FindAll();   
   
    }
}