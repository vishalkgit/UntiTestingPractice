using Controller_Testing_Proj.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Controller_Testing_Proj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserReposittory _user;

        public UserController(IUserReposittory user)
        {
            _user = user;
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var user = _user.GetUser(id);

            if (user == null)
                return NotFound();
            return Ok(user);
        }

    }
}
