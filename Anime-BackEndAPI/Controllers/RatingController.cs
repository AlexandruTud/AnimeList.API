using Anime_BackEndAPI.DTOs;
using Anime_BackEndAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Anime_BackEndAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RatingController : ControllerBase
    {
        private readonly IUserRatingService _userRatingService;
        public RatingController(IUserRatingService userRatingService)
        {
            _userRatingService = userRatingService;
        }
        [HttpPost]
        [Route("InsertUserRating")]
        public async Task<IActionResult> InsertUserRating(RatingDTO ratingDTO)
        {
            if (ratingDTO == null)
            {
                return BadRequest();
            }
            if (await _userRatingService.UserRatingServiceAsync(ratingDTO))
            {
                return Ok("Rating Ok");
            }
            return BadRequest();
        }
    }
}
