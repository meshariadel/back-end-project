using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.User.Controllers
{
    public class User
    {

        private string _userId;
        private string _fullName;
        private string _role;
        private string _email;
        public User(string userId, string fullName, string role, string email){
        
        _userId = userId;
        _fullName = fullName;
        _role = role;
        _email = email;
        }
    }
}