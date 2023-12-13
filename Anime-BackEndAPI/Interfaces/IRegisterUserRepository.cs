using Anime_BackEndAPI.DTOs;

namespace Anime_BackEndAPI.Interfaces
{
    public interface IRegisterUserRepository
    {
        Task<int> RegisterUser(UserDTO user);
    }
}