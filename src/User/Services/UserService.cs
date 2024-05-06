using AutoMapper;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        private IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public IEnumerable<UserReadDto> GetAll()
        {

            IEnumerable<UserReadDto> usersReadDto = _mapper.Map<IEnumerable<UserReadDto>>(_userRepository.GetAll());
            return usersReadDto;
        }


        public UserReadDto? GetOne(Guid userId)
        {
            User user = _userRepository.GetOne(userId);
            UserReadDto userReadDto = _mapper.Map<UserReadDto>(user);
            return userReadDto;
        }


        public UserReadDto UpdateOne(Guid userId, UserUpdateDto updatedUser)

        {
            User? targetUser = _userRepository.GetOne(userId);
            User updatedUserDto = _mapper.Map<User>(updatedUser);

            updatedUserDto = _userRepository.UpdateOne(targetUser, updatedUserDto);
            UserReadDto updatedUserReadDto = _mapper.Map<UserReadDto>(updatedUserDto);
            return updatedUserReadDto;
        }


        public UserReadDto CreateOne(UserCreateDto newUser)
        {

            User userCreateDto = _mapper.Map<User>(newUser);
            userCreateDto = _userRepository.CreateOne(userCreateDto);
            UserReadDto userReadDto = _mapper.Map<UserReadDto>(userCreateDto);
            return userReadDto;

        }
    }
}