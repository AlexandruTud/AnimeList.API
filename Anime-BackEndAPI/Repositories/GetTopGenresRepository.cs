using Anime_BackEndAPI.DTOs;
using Anime_BackEndAPI.Interfaces;
using Dapper;
using System.Data;

namespace Anime_BackEndAPI.Repositories
{
    public class GetTopGenresRepository : IGetTopGenresRepository
    {
        private readonly IDbConnectionFactory _dbConnectionFactory;
        public GetTopGenresRepository(IDbConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;
        }
        public async Task<IEnumerable<GenreDTO>> GetTopGenresRepositoryAsync()
        {
            using(IDbConnection connection = _dbConnectionFactory.ConnectToDataBase())
            {
                var topGenres = await connection.QueryAsync<GenreDTO>("GetTopGenres",commandType:CommandType.StoredProcedure);
                return topGenres;
            }
        }
    }
}
