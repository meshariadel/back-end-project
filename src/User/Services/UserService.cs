using System.Text;
using AutoMapper;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        private IMapper _mapper;
        private IConfiguration _config;

        public UserService(IUserRepository userRepository, IMapper mapper, IConfiguration config)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _config = config;
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


        public UserReadDto SignUp(UserCreateDto newUser)
        {
            User? foundUser = _userRepository.GetOneByEmail(newUser.Email);
            if (foundUser is not null)
            {
                return null;
            }
            byte[] pepper = Encoding.UTF8.GetBytes(_config["Jwt:Pepper"]);
            PasswordUtils.HashPassword(newUser.Password, out string hashedPassword, pepper);
            newUser.Password = hashedPassword;

            User userCreateDto = _mapper.Map<User>(newUser);
            userCreateDto = _userRepository.CreateOne(userCreateDto);
            UserReadDto userReadDto = _mapper.Map<UserReadDto>(userCreateDto);
            return userReadDto;

        }

        public UserReadDto? Login(UserLogin user)
        {
            User? foundUser = _userRepository.GetOneByEmail(user.Email);
            if (foundUser is null) return null;

            byte[] pepper = Encoding.UTF8.GetBytes(_config["Jwt:Pepper"]);
            bool matchedPassword = PasswordUtils.VerifyPassword(user.Password, foundUser.Password, pepper);

            if (!matchedPassword) return null;

            UserReadDto userReturnDto = _mapper.Map<UserReadDto>(foundUser);
            return userReturnDto;

        }

        public void Delete(Guid targetUserId)
        {
            User targetUser = _userRepository.GetOne(targetUserId);
            _userRepository.Delete(targetUser);
            return;
        }
    }
}