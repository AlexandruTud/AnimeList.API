using Anime_BackEndAPI.DTOs;

namespace Anime_BackEndAPI.Interfaces
{
    public interface IInsertViewingRecordDetailsRepository
    {
        Task<int> InsertViewRecordRepositoryAsync(ViewRecordDTO viewRecord); 
    }
}