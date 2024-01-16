using Anime_BackEndAPI.Requests;

namespace Anime_BackEndAPI.Interfaces
{
    public interface IDeleteViewRecRepository
    {
        Task<bool> DeleteViewRecordAsync(int userID, string animeName);
    }
}