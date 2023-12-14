using Anime_BackEndAPI.DTOs;

namespace Anime_BackEndAPI.Interfaces
{
    public interface IUserRatingService
    {
        Task<bool> UserRatingServiceAsync(RatingDTO userRating);
    }
}