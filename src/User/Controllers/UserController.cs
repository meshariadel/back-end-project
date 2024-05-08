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

        [HttpGet("{userId}")]
        public UserReadDto? GetOne(Guid userId)
        {
            return _userService.GetOne(userId);
        }

        [HttpPatch("{userId}")]

        public UserReadDto UpdateOne(Guid userId, [FromBody] UserUpdateDto updatedUser)
        {
            return _userService.UpdateOne(userId, updatedUser);
        }

        [HttpPost("SignIn")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<UserReadDto> SignUp([FromBody] UserCreateDto newUser)
        {
            if (newUser is not null)
            {
                var createdUser = _userService.SignUp(newUser);
                return CreatedAtAction(nameof(SignUp), createdUser);
            }
            return BadRequest();
        }

        [HttpPost("Login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public ActionResult<UserReadDto> Login([FromBody] UserLogin User)
        {
            if (User is not null)
            {

                UserReadDto loginUser = _userService.Login(User);
                if (loginUser is null) return BadRequest();

                return Ok(loginUser);
            }
            return BadRequest();
        }

        [HttpDelete("{userId}")]
        public void Delete(Guid userId)
        {
            _userService.Delete(userId);
        }



    }
}