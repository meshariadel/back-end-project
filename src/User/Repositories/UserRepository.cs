using Microsoft.AspNetCore.Identity;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class UserRepository : IUserRepository
    {
        private IEnumerable<User> _users;

        public UserRepository(DatabaseContext databaseContext)
        {
            _users = databaseContext.Users;

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

        public User UpdateOne(User targetUser, User updatedUser)
        {

            foreach (var aUser in _users)
            {
                if (aUser.UserId == targetUser.UserId)
                {
                    aUser.FullName = updatedUser.FullName;
                    aUser.Email = updatedUser.Email;
                    aUser.Password = updatedUser.Password;
                    return aUser;
                }


            }
            return targetUser;
        }

        public User CreateOne(User newUser)
        {

            _users.Append(newUser);
            return newUser;
        }
    }
}