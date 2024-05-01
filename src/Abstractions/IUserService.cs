namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public interface IUserService
    {
        public IEnumerable<UserReadDto> GetAll();

        public UserReadDto? GetOne(string userId);

        public UserReadDto UpdateOne(string userId, UserUpdateDto updatedUser);
        public User CreateOne(User newUser);
    }
}