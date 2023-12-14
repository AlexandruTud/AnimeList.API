using Anime_BackEndAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace Anime_BackEndAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenresController : ControllerBase
    {
         private readonly IGetTopGenresService _getTopGenresService;
        public GenresController(IGetTopGenresService getTopGenresService)
        {
                _getTopGenresService = getTopGenresService ?? throw new ArgumentNullException(nameof(getTopGenresService));
        }
        [HttpGet]
        [Route("getTopGenres")]
        public async Task<IActionResult> GetTopGenres()
        {
            var topGenres = await _getTopGenresService.GetTopGenresServiceAsync();
            if(topGenres == null)
            {
                return NotFound();
            }
            return Ok(topGenres);
        }
    }
}
