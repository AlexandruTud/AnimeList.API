using Anime_BackEndAPI.DTOs;

namespace Anime_BackEndAPI.Interfaces
{
    public interface IRegisterUserService
    {
        Task<int> RegisterUserAsync(UserDTO user);
    }
}