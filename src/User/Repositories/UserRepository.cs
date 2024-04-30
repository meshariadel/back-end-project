using Microsoft.AspNetCore.Identity;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.User.Controllers
{
    public class UserRepository : IUserRepository
    {
        private IEnumerable<User> _users;

        public UserRepository()
        {
            _users = new UserDataBaseContext().users;
        }

        public IEnumerable<User> GetAll()
        {
            return _users;
        }

        public User? GetOne(string userId)
        {

            User? user = _users.FirstOrDefault(aUser => aUser.UserId == userId);
            return user;
        }

        public User UpdateOne(User targetUser, string newName)
        {

            foreach (var aUser in _users)
            {
                if (aUser.UserId == targetUser.UserId)
                {
                    aUser.FullName = newName;
                    return aUser;
                }


            }
            return targetUser;
        }
    }
}