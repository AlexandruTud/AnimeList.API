using Anime_BackEndAPI.DTOs;

namespace Anime_BackEndAPI.Interfaces
{
    public interface IInsertViewingRecordDetailsRepository
    {
        Task<bool> InsertViewRecordRepositoryAsync(ViewRecordDTO viewRecord); 
    }
}