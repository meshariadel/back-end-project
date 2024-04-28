using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.User.Controllers
{
    public class User
    {


        public string UserId {get; set;}
        public string FullName {get; set;}
        public string Role {get; set;}
        public string Email { get; set;}
        public User(string userId, string fullName, string role, string email){
        
        UserId = userId;
        FullName = fullName;
        Role = role;
        Email = email;

        }
        
        
    }
}