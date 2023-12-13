using Anime_BackEndAPI.DTOs;

namespace Anime_BackEndAPI.Interfaces
{
    public interface IGetAnimeListRepository
    {
        Task<IEnumerable<MinimalAnimeDTO>> GetAnimeListRepositoryAsync();
    }
}