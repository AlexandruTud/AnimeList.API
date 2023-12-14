using Anime_BackEndAPI.Infrastructure;
using Anime_BackEndAPI.Interfaces;
using Anime_BackEndAPI.Repositories;
using Anime_BackEndAPI.Services;

namespace Anime_BackEndAPI
{
    public static class MyConfigServiceCollectionExtensions
    {
        public static IServiceCollection AddMyDependencyGroup(
             this IServiceCollection services)
        {
            services.AddScoped<IDbConnectionFactory,DbConnectionFactory>();
            services.AddScoped<ILoginRepository,LoginRepository>();
            services.AddScoped<ILoginService,LoginService>();
            services.AddScoped<IRegisterUserRepository,RegisterUserRepository>();
            services.AddScoped<IRegisterUserService,RegisterUserService>();
            services.AddScoped<IGetAnimeListRepository,GetAnimeListRepository>();
            services.AddScoped<IGetAnimeListService,GetAnimeListService>();
            services.AddScoped<IGetMoreInformationAboutAnimeRepository,GetMoreInformationAboutAnimeRepository>();
            services.AddScoped<IGetMoreInformationAboutAnimeService,GetMoreInformationAboutAnimeService>();
            services.AddScoped<IInsertViewingRecordDetailsRepository,InsertViewingRecordDetailsRepository>();
            services.AddScoped<IInsertViewingRecordDetailsService,InsertViewingRecordDetailsService>();
            services.AddScoped<IGetTopGenresRepository,GetTopGenresRepository>();
            services.AddScoped<IGetTopGenresService,GetTopGenresService>();
            services.AddScoped<IUserRatingRepository, UserRatingRepository>();
            services.AddScoped<IUserRatingService, UserRatingService>();
            services.AddScoped<IDeleteViewRecRepository,DeleteViewRecRepository>();


            return services;
        }
    }
}