using Anime_BackEndAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Anime_BackEndAPI.Controllers
{
    [ApiController]
    [Route("anime/getAnimeList")]
    public class GetAnimeListController : ControllerBase
    {
        private readonly IGetAnimeListService _getAnimeListService;
        public GetAnimeListController(IGetAnimeListService getAnimeListService)
        {
            _getAnimeListService = getAnimeListService ?? throw new ArgumentNullException(nameof(getAnimeListService));
        }
        [HttpGet]
        public async Task<IActionResult> GetAnimeList()
        {
            var animeList = await _getAnimeListService.GetAnimeListServiceAsync();
            if(animeList == null)
            {
                return NotFound();
            }
            return Ok(animeList);
        }
    }
}
