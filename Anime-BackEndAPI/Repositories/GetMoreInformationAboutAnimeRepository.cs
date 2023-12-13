using Anime_BackEndAPI.DTOs;
using Anime_BackEndAPI.Interfaces;
using Dapper;
using System.Data;

namespace Anime_BackEndAPI.Repositories
{
    public class GetMoreInformationAboutAnimeRepository : IGetMoreInformationAboutAnimeRepository
    {
        private readonly IDbConnectionFactory dbConnectionFactory;

        public GetMoreInformationAboutAnimeRepository(IDbConnectionFactory dbConnectionFactory)
        {
            this.dbConnectionFactory = dbConnectionFactory;
        }

        public async Task<IEnumerable<AnimeDTO>> GetMoreInformationAboutAnimeRepositoryAsync()
        {
            using(IDbConnection dbConnection = dbConnectionFactory.ConnectToDataBase())
            {
                var AnimeList = await dbConnection.QueryAsync<AnimeDTO>("GetMoreInformationAboutAnime",commandType:CommandType.StoredProcedure);
                return AnimeList;
            }
        }
    }
}
