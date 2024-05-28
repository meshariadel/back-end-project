using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class UserRepository : IUserRepository
    {
        private DbSet<User> _users;
        private DatabaseContext _databasecontext;

        public UserRepository(DatabaseContext databaseContext)
        {

            _users = databaseContext.User;
            _databasecontext = databaseContext;
        }

        public IEnumerable<User> GetAll()
        {
            return _users;
        }

        public User? GetOne(Guid userId)
        {

            User? user = _users.FirstOrDefault(aUser => aUser.UserId == userId);
            return user;
        }
        public User? GetOneByEmail(string email)
        {
            User? user = _users.FirstOrDefault(aUser => aUser.Email == email);
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

            _users.Add(newUser);
            _databasecontext.SaveChanges();
            return newUser;
        }

        public void Delete(User targetUser)
        {
            _users.Remove(targetUser);
            _databasecontext.SaveChanges();
        }
    }
}