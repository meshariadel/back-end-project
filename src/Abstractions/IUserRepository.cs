namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetAll();

        public User? GetOne(Guid userID);
        public User? GetOneByEmail(string eamil);

        public User UpdateOne(User targetUser, User updatedUser);

        public User CreateOne(User newUser);

        public void Delete(User targetUser);

    }

}