using Anime_BackEndAPI.DTOs;

namespace Anime_BackEndAPI.Interfaces
{
    public interface IUpdateViewRecordRepository
    {
        Task<bool> UpdateViewRecordAsync(UpdatedRecordDTO updatedRecordDTO);
    }
}