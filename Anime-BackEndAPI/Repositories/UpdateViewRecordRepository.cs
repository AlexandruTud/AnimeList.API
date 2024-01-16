using Anime_BackEndAPI.DTOs;
using Anime_BackEndAPI.Interfaces;
using Dapper;
using System.Data;

namespace Anime_BackEndAPI.Repositories
{
    public class UpdateViewRecordRepository : IUpdateViewRecordRepository
    {
        private readonly IDbConnectionFactory _dbConnectionFactory;
        public UpdateViewRecordRepository(IDbConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;
        }
        public async Task<bool> UpdateViewRecordAsync(UpdatedRecordDTO updatedRecordDTO)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@UserID", updatedRecordDTO.userID);  
            parameters.Add("@AnimeName", updatedRecordDTO.animeName);
            parameters.Add("@NewNumberOfEpisodes", updatedRecordDTO.noOfEpisodes);
            parameters.Add("@NewEndDate", updatedRecordDTO.endDate);
            parameters.Add("@Success", dbType: DbType.Boolean, direction: ParameterDirection.Output);
            using (var conn = _dbConnectionFactory.ConnectToDataBase())
            {
                var result = await conn.ExecuteAsync("UpdateViewingRecord", parameters, commandType: CommandType.StoredProcedure);
                var success = parameters.Get<bool>("Success");
                if (success)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
