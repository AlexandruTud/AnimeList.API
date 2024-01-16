using Anime_BackEndAPI.DTOs;
using System.Data;

namespace Anime_BackEndAPI.Interfaces
{
    public interface ILoginRepository
    {
        Task<int> Login(UserLoginDTO user);
    }
}
