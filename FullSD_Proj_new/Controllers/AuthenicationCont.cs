using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FullSD_Proj_new.Data;
using FullSD_Proj_new.Domain;

namespace FullSD_Proj_new.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly FullSD_Proj_newContext _context;

        public AuthController(FullSD_Proj_newContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginDto userLogin)
        {
            var user = await _context.User.SingleOrDefaultAsync(u => u.Email == userLogin.Email);
            if (user == null || !VerifyPassword(userLogin.Password, user.Password))
            {
                return Unauthorized();
            }

            return Ok(new { user.Id });
        }

        private bool VerifyPassword(string password, string hashedPassword)
        {
            // Implement password verification logic here
            return password == hashedPassword; // Simplified for demonstration
        }
    }

    public class UserLoginDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
