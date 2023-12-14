using Anime_BackEndAPI.DTOs;

namespace Anime_BackEndAPI.Interfaces
{
    public interface IGetTopGenresService
    {
        Task<IEnumerable<GenreDTO>> GetTopGenresServiceAsync();
    }
}