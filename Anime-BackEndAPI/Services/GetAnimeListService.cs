using Anime_BackEndAPI.DTOs;
using Anime_BackEndAPI.Interfaces;
using Anime_BackEndAPI.Responses;
using System.ComponentModel;
using System.Linq;
namespace Anime_BackEndAPI.Services
{
    public class GetAnimeListService : IGetAnimeListService
    {
        private readonly IGetAnimeListRepository _getAnimeListRepository;
        public GetAnimeListService(IGetAnimeListRepository getAnimeListRepository)
        {
            _getAnimeListRepository = getAnimeListRepository;
        }
        public async Task<IEnumerable<MinimalAnimeDTO>> GetAnimeListServiceAsync()
        {
          var AnimeList = await _getAnimeListRepository.GetAnimeListRepositoryAsync();
            return AnimeList;
        }
        
    }
}
