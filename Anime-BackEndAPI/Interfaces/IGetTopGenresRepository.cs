using Anime_BackEndAPI.DTOs;

namespace Anime_BackEndAPI.Interfaces
{
    public interface IGetTopGenresRepository
    {
        Task<IEnumerable<GenreDTO>> GetTopGenresRepositoryAsync();
    }
}