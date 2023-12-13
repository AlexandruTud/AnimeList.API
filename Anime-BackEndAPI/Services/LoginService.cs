using Anime_BackEndAPI.DTOs;
using Anime_BackEndAPI.Interfaces;
using Anime_BackEndAPI.Repositories;

namespace Anime_BackEndAPI.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _loginRepository;
        public LoginService(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }
        public async Task<int> LoginAsync(UserDTO user)
        {
            if(user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            return await _loginRepository.Login(user);
        }   
    }
}
