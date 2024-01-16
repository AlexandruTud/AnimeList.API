using Anime_BackEndAPI.DTOs;

namespace Anime_BackEndAPI.Interfaces
{
    public interface IGetViewingRecordByAnimeNameRepository
    {
        Task<IEnumerable<ViewRecordDTO>> GetViewingRecordByAnimeNameRepositoryAsync(string animeName);
    }
}