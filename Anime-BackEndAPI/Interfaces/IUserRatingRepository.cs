using Anime_BackEndAPI.DTOs;

namespace Anime_BackEndAPI.Interfaces
{
    public interface IUserRatingRepository
    {
        Task<bool> InsertUserRatingAsync(RatingDTO ratingDTO);
    }
}