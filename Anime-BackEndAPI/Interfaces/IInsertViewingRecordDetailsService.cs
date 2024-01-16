using Anime_BackEndAPI.DTOs;

namespace Anime_BackEndAPI.Interfaces
{
    public interface IInsertViewingRecordDetailsService
    {
        Task<int> InsertViewRecordServiceAsync(ViewRecordDTO viewRecord);
    }
}