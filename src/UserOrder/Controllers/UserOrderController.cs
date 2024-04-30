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
        public IEnumerable<UserOrder> FindAll()
        {
            return _userOrderService.FindAll();
        }
        [HttpGet("{Id}")]
        public UserOrder? FindOneById(string id)
        {
            return _userOrderService.FindOneById(id);
        }
        
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ActionResult<UserOrder> CreateOne([FromBody] UserOrder userOrder)
        {
            if (userOrder is not null)
            {
                var createdUserOrder = _userOrderService.CreateOne(userOrder);
                return CreatedAtAction(nameof(CreateOne), createdUserOrder);
            }
            return BadRequest();

        }

    }
}