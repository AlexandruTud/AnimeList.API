using Anime_BackEndAPI.DTOs;
using Anime_BackEndAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Anime_BackEndAPI.Controllers
{
    [ApiController]
    [Route("user/register")]
    public class RegisterController : ControllerBase
    { 
        private readonly IRegisterUserService _registerUserService;
        public RegisterController(IRegisterUserService registerUserService)
        {
            _registerUserService = registerUserService ?? throw new ArgumentNullException(nameof(registerUserService));
        }
        [HttpPost]
        public async Task<IActionResult> Register([FromBody] UserDTO user)
        {
            var userID = await _registerUserService.RegisterUserAsync(user);
            if(userID == -1)
            {
                return BadRequest("User already Exists");
            }
            return Ok(userID);
        }
    }
}
