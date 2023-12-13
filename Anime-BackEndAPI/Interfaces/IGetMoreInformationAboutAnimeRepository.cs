using Anime_BackEndAPI.DTOs;

namespace Anime_BackEndAPI.Interfaces
{
    public interface IGetMoreInformationAboutAnimeRepository
    {
        Task<IEnumerable<AnimeDTO>> GetMoreInformationAboutAnimeRepositoryAsync();
    }
}