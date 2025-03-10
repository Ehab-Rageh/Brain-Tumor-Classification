namespace Brain_Tumor_Classification.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _context.Users.Select(s => new
            {
                Id = s.Id,
                Name = s.Name,
                Username = s.UserName,
                Email = s.Email,
                Gender = s.Gender,
                Birthdate = s.BirthDate,
            }).ToList();

            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] string id)
        {
            var user = _context.Users.Find(id);

            if (user is null)
                return NotFound($"There is no user with Id: {id}");

            return Ok(new
            {
                Id = user.Id,
                Name = user.Name,
                Username = user.UserName,
                Email = user.Email,
                Gender = user.Gender,
                Birthdate = user.BirthDate,
            });
        }
    }
}
