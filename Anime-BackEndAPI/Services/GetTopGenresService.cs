using Anime_BackEndAPI.DTOs;
using Anime_BackEndAPI.Interfaces;

namespace Anime_BackEndAPI.Services
{
    public class GetTopGenresService : IGetTopGenresService
    {
        private readonly IGetTopGenresRepository _getTopGenresRepository;
        public GetTopGenresService(IGetTopGenresRepository getTopGenresRepository)
        {
            _getTopGenresRepository = getTopGenresRepository ?? throw new ArgumentNullException(nameof(getTopGenresRepository));
        }
        public async Task<IEnumerable<GenreDTO>> GetTopGenresServiceAsync()
        {
            var topGenres = await _getTopGenresRepository.GetTopGenresRepositoryAsync();
            return topGenres;
        }
    }
}
