namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public interface IUserService
    {
        public IEnumerable<UserReadDto> GetAll();

        public UserReadDto? GetOne(Guid userId);

        public UserReadDto UpdateOne(Guid userId, UserUpdateDto updatedUser);
        public UserReadDto CreateOne(UserCreateDto newUser);
    }
}