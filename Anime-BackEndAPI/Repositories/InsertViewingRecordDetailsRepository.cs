using Anime_BackEndAPI.DTOs;
using Anime_BackEndAPI.Interfaces;
using Dapper;
using System.Data;

namespace Anime_BackEndAPI.Repositories
{
    public class InsertViewingRecordDetailsRepository : IInsertViewingRecordDetailsRepository
    {
        private readonly IDbConnectionFactory _dbConnectionFactory;
        public InsertViewingRecordDetailsRepository(IDbConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;
        }   
        public async Task<bool> InsertViewRecordRepositoryAsync(ViewRecordDTO viewRecord)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@AnimeName", viewRecord.AnimeName);
            parameters.Add("@viewedEpisodes", viewRecord.viewedEpisodes);
            parameters.Add("@StartDate", viewRecord.StartDate);
            parameters.Add("@EndDate", viewRecord.EndDate);
            parameters.Add("@Raiting", viewRecord.Raiting);
            using (var conn = _dbConnectionFactory.ConnectToDataBase())
            {
                var result = await conn.QueryAsync<int>("InsertViewRecord", parameters, commandType: CommandType.StoredProcedure);
                if(result.Equals(1))
                {
                    return true;
                }
                
            }
            return false;
        }
    }
}
