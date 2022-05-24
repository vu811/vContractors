using Microsoft.AspNetCore.Mvc;
using vContractors.Application.Interfaces;
using vContractors.Application.Models.Users;

namespace vContractors.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;
        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("token")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var response = await _userService.LoginAsync(request, "192.168.1.1");
            if (response == null) return BadRequest("Error");
            return Ok(response);
        }
    }
}
