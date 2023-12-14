using Anime_BackEndAPI.DTOs;
using Anime_BackEndAPI.Interfaces;

namespace Anime_BackEndAPI.Services
{
    public class UserRatingService : IUserRatingService
    {
        private readonly IUserRatingRepository _userRatingRepository;
        public UserRatingService(IUserRatingRepository userRatingRepository)
        {
            _userRatingRepository = userRatingRepository;
        }
        public async Task<bool> UserRatingServiceAsync(RatingDTO userRating)
        {
            return await _userRatingRepository.InsertUserRatingAsync(userRating);
        }
    }
}
