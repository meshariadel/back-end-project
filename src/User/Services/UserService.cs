using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.User.Controllers
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User? GetOne(string email)
        {

            return _userRepository.GetOne(email);
        }

        public User UpdateOne(string userId, string newName)
        {
            User targetUser = _userRepository.GetOne(userId);
            return _userRepository.UpdateOne(targetUser, newName);
        }

        public User CreateOne(User newUser){
            
            return _userRepository.CreateOne(newUser);
        }
    }
}