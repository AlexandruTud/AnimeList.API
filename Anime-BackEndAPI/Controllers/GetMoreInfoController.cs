using Anime_BackEndAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Anime_BackEndAPI.Controllers
{
    [ApiController]
    [Route("anime/GetMoreInfo")]
    public class GetMoreInfoController : ControllerBase
    {
        private readonly IGetMoreInformationAboutAnimeService _getMoreInformationAboutAnimeService;
        public GetMoreInfoController(IGetMoreInformationAboutAnimeService getMoreInformationAboutAnimeService)
        {
            _getMoreInformationAboutAnimeService = getMoreInformationAboutAnimeService;
        }
        [HttpGet]
        public async Task<IActionResult> GetMoreInfo()
        {
            var MoreInfoAnime = await _getMoreInformationAboutAnimeService.GetMoreInformationAboutAnimeServiceAsync();
            if(MoreInfoAnime == null)
            {
                return NotFound();
            }   
            return Ok(MoreInfoAnime);
        }
    }
}
