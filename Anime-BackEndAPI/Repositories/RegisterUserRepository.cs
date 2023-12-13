using Anime_BackEndAPI.DTOs;
using Anime_BackEndAPI.Interfaces;
using Dapper;
using System.Data;

namespace Anime_BackEndAPI.Repositories
{
    public class RegisterUserRepository : IRegisterUserRepository
    {
        private readonly IDbConnectionFactory _dbConnectionFactory;
        public RegisterUserRepository(IDbConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;
        }   
        public async Task<int> RegisterUser(UserDTO user)
        {
            using(IDbConnection connection = _dbConnectionFactory.ConnectToDataBase())
            {              
                var parameters =new DynamicParameters();
                parameters.Add("@Name",user.Name);
                parameters.Add("@Email",user.Email);
                parameters.Add("@Password",user.Password);
                parameters.Add("@UserID", dbType:DbType.Int32,direction:ParameterDirection.Output);  
                await connection.ExecuteAsync("RegisterUser", parameters,commandType:CommandType.StoredProcedure);
                int userID = parameters.Get<int>("UserID");
                return userID;
            }
        }
    }
}
