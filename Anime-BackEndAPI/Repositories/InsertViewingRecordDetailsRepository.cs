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
        public async Task<int> InsertViewRecordRepositoryAsync(ViewRecordDTO viewRecord)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@UserID", viewRecord.UserID);
            parameters.Add("@AnimeName", viewRecord.AnimeName);
            parameters.Add("@NumberOfEpisodes", viewRecord.viewedEpisodes);
            parameters.Add("@StartDate", viewRecord.StartDate);
            parameters.Add("@EndDate", viewRecord.EndDate);
            parameters.Add("@Rating", viewRecord.Rating);
            parameters.Add("@ViewRecordID", dbType: DbType.Int32, direction: ParameterDirection.Output);
            using (var conn = _dbConnectionFactory.ConnectToDataBase())
            {
                var result = await conn.QueryAsync<int>("InsertIntoViewingRecord", parameters, commandType: CommandType.StoredProcedure);
                var viewRecordID = parameters.Get<int>("ViewRecordID");
                return viewRecordID;
            }
            
        }
    }
}
