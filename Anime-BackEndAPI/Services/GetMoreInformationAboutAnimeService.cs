using Anime_BackEndAPI.DTOs;
using Anime_BackEndAPI.Interfaces;

namespace Anime_BackEndAPI.Services
{
    public class GetMoreInformationAboutAnimeService : IGetMoreInformationAboutAnimeService
    {
        private readonly IGetMoreInformationAboutAnimeRepository _getMoreInformationAboutAnimeRepository;
        public GetMoreInformationAboutAnimeService(IGetMoreInformationAboutAnimeRepository getMoreInformationAboutAnimeRepository)
        {
            _getMoreInformationAboutAnimeRepository = getMoreInformationAboutAnimeRepository;
        }
        public async Task<IEnumerable<AnimeDTO>> GetMoreInformationAboutAnimeServiceAsync()
        {
            var AnimeList = await _getMoreInformationAboutAnimeRepository.GetMoreInformationAboutAnimeRepositoryAsync();
            return AnimeList;
        }
    }
}
