using Anime_BackEndAPI.DTOs;
using Anime_BackEndAPI.Interfaces;
using Dapper;
using System.Data;

namespace Anime_BackEndAPI.Repositories
{
    public class UserRatingRepository : IUserRatingRepository
    {
        private readonly IDbConnectionFactory _dbConnectionFactory;
        public UserRatingRepository(IDbConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;
        }
        public async Task<bool> InsertUserRatingAsync(RatingDTO ratingDTO)
        {
            using (IDbConnection connection = _dbConnectionFactory.ConnectToDataBase())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@UserID", ratingDTO.UserID);
                parameters.Add("@AnimeName", ratingDTO.AnimeName);
                parameters.Add("@Score", ratingDTO.Rating);
                parameters.Add("Success", dbType: DbType.Boolean, direction: ParameterDirection.Output);
                var result = await connection.ExecuteAsync("InsertUserRating", parameters, commandType: CommandType.StoredProcedure);
                var success = parameters.Get<bool>("Success");
                return success;
            }
        }
    }
}
