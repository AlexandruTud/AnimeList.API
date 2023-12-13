using Anime_BackEndAPI.DTOs;
using Anime_BackEndAPI.Interfaces;

namespace Anime_BackEndAPI.Services
{
    public class RegisterUserService : IRegisterUserService
    {
        private readonly IRegisterUserRepository _registerUserRepository;
        public RegisterUserService(IRegisterUserRepository registerUserRepository)
        {
            _registerUserRepository = registerUserRepository;
        }
        public async Task<int> RegisterUserAsync(UserDTO user)
        {
            if(user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            if(user.Email == "" || user.Email == null)
            {
                throw new ArgumentNullException(nameof(user.Email));
            }
            if(user.Password == "" || user.Password == null)
            {
                throw new ArgumentNullException(nameof(user.Password));
            }
            return await _registerUserRepository.RegisterUser(user);
        }
    }
}
