using Anime_BackEndAPI.DTOs;
using Anime_BackEndAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Anime_BackEndAPI.Controllers
{

    [ApiController]
    [Route("user/login")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;
        public LoginController(ILoginService loginService)
        {
            _loginService = loginService ?? throw new ArgumentNullException(nameof(loginService));
        }
        [HttpPost]
        public  async Task<IActionResult> Login([FromBody] UserDTO user)
        {
            var userID = await _loginService.LoginAsync(user);
            if(userID == -1)
            {
                return Unauthorized();
            }
            return Ok(userID);
        }
    }
}
