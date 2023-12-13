using Anime_BackEndAPI.DTOs;

namespace Anime_BackEndAPI.Interfaces
{
    public interface IGetMoreInformationAboutAnimeService
    {
        Task<IEnumerable<AnimeDTO>> GetMoreInformationAboutAnimeServiceAsync();
    }
}