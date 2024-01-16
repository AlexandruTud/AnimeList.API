using Anime_BackEndAPI.DTOs;
using Anime_BackEndAPI.Interfaces;
using Dapper;
using System.Data;

namespace Anime_BackEndAPI.Repositories
{
    public class GetViewingRecordByAnimeNameRepository : IGetViewingRecordByAnimeNameRepository
    {
        private readonly IDbConnectionFactory dbConnectionFactory;
        public GetViewingRecordByAnimeNameRepository(IDbConnectionFactory dbConnectionFactory)
        {
            this.dbConnectionFactory = dbConnectionFactory;
        }
        public async Task<IEnumerable<ViewRecordDTO>> GetViewingRecordByAnimeNameRepositoryAsync(string animeName)
        {
            using(IDbConnection connection = dbConnectionFactory.ConnectToDataBase())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@AnimeName", animeName);
                var viewingRecord = await connection.QueryAsync<ViewRecordDTO>("GetViewingRecordByAnimeName", parameters, commandType: CommandType.StoredProcedure);
                return viewingRecord;
            }
        }
    }
}
