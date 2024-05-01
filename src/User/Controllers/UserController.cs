using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.User.Controllers
{
    public class userController : ControllerTemplate
    {
        private IUserService _userService;

        public userController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IEnumerable<User> GetAll()
        {
            return _userService.GetAll();
        }

        [HttpGet("{email}")]
        public User? GetOne(string email)
        {
            return _userService.GetOne(email);
        }

        [HttpPatch("userId")]
        public User UpdateOne(string userId, [FromBody] string newName)
        {
            return _userService.UpdateOne(userId, newName);
        }

        [HttpPost]
        public User CreateOne([FromBody]User newUser){
            return _userService.CreateOne(newUser);
        }



    }
}