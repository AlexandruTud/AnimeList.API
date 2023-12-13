using Anime_BackEndAPI.DTOs;

namespace Anime_BackEndAPI.Interfaces
{
    public interface IInsertViewingRecordDetailsService
    {
        Task<bool> InsertViewRecordServiceAsync(ViewRecordDTO viewRecord);
    }
}