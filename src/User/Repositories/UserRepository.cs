using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.User.Controllers
{
    public class UserRepository : IUserRepository
    {
        private IEnumerable<User> _users;

        public UserRepository(){
            _users = new DataBaseContext().users;
        }

        public IEnumerable<User> GetAll(){      
            return _users;
        }
        
        public User GetByEmail(string email){
            return new User("","","","");
        }
    }
}