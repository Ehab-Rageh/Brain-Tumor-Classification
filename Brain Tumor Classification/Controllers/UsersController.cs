namespace Brain_Tumor_Classification.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UsersController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = await _userService.GetAllAsync();

            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] string id)
        {
            var user = await _userService.GetByIdAsync(id);

            if (user is null)
                return NotFound($"There is no user with Id: {id}");

            return Ok(_mapper.Map<UserDetailsDto>(user));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] string id, [FromBody] UpdateUserDto dto)
        {
            var user = await _userService.GetByIdAsync(id);
            if (user is null)
                return NotFound($"There is no user with Id: {id}");

            user.Name = dto.Name;
            user.BirthDate = dto.BirthDate;
            user.UserName = dto.UserName;
            user.Gender = dto.Gender;

            await _userService.UpdateAsync(user);

            return Ok(_mapper.Map<UpdateUserDto>(user));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] string id)
        {
            var user = await _userService.GetByIdAsync(id);
            if (user is null)
                return NotFound($"There is no user with Id: {id}");

            await _userService.Delete(user);

            return Ok(_mapper.Map<RegisterDto>(user));
        }
    }
}
