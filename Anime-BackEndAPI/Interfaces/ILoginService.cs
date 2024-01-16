using Anime_BackEndAPI.DTOs;

namespace Anime_BackEndAPI.Interfaces
{
    public interface ILoginService
    {
        Task<int> LoginAsync(UserLoginDTO user);
    }
}