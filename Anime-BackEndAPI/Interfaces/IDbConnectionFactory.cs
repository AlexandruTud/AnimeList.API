using System.Data;

namespace Anime_BackEndAPI.Interfaces
{
    public interface IDbConnectionFactory
    {
        IDbConnection ConnectToDataBase();
    }
}