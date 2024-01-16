using Anime_BackEndAPI.Interfaces;
using Anime_BackEndAPI.Requests;
using Dapper;
using System.Data;

namespace Anime_BackEndAPI.Repositories
{
    public class DeleteViewRecRepository : IDeleteViewRecRepository 
    {
        private readonly IDbConnectionFactory _dbConnectionFactory;
        
        public DeleteViewRecRepository(IDbConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;
        }
        public async Task<bool> DeleteViewRecordAsync(int userID, string animeName)
        {
            using (IDbConnection conn = _dbConnectionFactory.ConnectToDataBase())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@AnimeName", animeName);
                parameters.Add("@UserID", userID);
                parameters.Add("@Success", dbType: DbType.Boolean, direction: ParameterDirection.Output);   
                await conn.ExecuteAsync("DeleteViewingRecord", parameters, commandType: CommandType.StoredProcedure);
                bool success = parameters.Get<bool>("Success");
                return success;
            }
        }
    }
}
