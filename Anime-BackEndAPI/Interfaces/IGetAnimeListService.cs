using Anime_BackEndAPI.DTOs;
using Anime_BackEndAPI.Responses;

namespace Anime_BackEndAPI.Interfaces
{
    public interface IGetAnimeListService
    {
        Task<IEnumerable<MinimalAnimeDTO>> GetAnimeListServiceAsync();
    }
}