using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Entities;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.User.Controllers;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Controllers
{
    public class userOrderController : ControllerTemplate
    {
        private IUserOrderService _userOrderService;

        public userOrderController(IUserOrderService userOrderService)
        {
            _userOrderService = userOrderService;
        }

        [HttpGet]
        public IEnumerable<UserOrder>FindAll()
        {
            return _userOrderService.FindAll();
        }
        [HttpPost]
        public IEnumerable<UserOrder> CreateOne([FromBody] UserOrder userOrder){
            return _userOrderService.CreateOne(userOrder);

        }

    }
}