using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class userController : ControllerTemplate
    {
        private IUserService _userService;
        private IMapper _mapper;

        public userController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<UserReadDto> GetAll()
        {
            return _userService.GetAll();
        }

        [HttpGet("{email}")]
        public UserReadDto? GetOne(string email)
        {
            return _userService.GetOne(email);
        }

        [HttpPatch("userId")]
        public UserReadDto UpdateOne(string userId, [FromBody] UserUpdateDto updatedUser)
        {
            return _userService.UpdateOne(userId, updatedUser);
        }

        [HttpPost]
        public User CreateOne([FromBody]User newUser){
            return _userService.CreateOne(newUser);
        }



    }
}