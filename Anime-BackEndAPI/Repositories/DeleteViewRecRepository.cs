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
        public async Task<bool> DeleteViewRecordAsync(ViewRecordRequest viewRecord)
        {
            using (IDbConnection conn = _dbConnectionFactory.ConnectToDataBase())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@UserID", viewRecord.UserId);
                parameters.Add("@AnimeID", viewRecord.AnimeId);
                parameters.Add("@Success", dbType: DbType.Boolean, direction: ParameterDirection.Output);   
                await conn.ExecuteAsync("DeleteViewingRecord", parameters, commandType: CommandType.StoredProcedure);
                bool success = parameters.Get<bool>("Success");
                return success;
            }
        }
    }
}
