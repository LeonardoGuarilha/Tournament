using Microsoft.Extensions.DependencyInjection;
using Tournament.Application.Interface;
using Tournament.Application.Service;
using Tournament.Domain.Interfaces.Repositories;
using Tournament.Domain.Interfaces.Services;
using Tournament.Domain.Services;
using Tournament.Infrastructure.CrossCutting.Interfaces;
using Tournament.Infrastructure.CrossCutting.Map;
using Tournament.Infrastructure.Data.Repositories;

namespace Tournament.API.Configuration
{
    public static class DependencyInjectionConfiguration
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IApplicationGameService, ApplicationGameService>();
            services.AddScoped<IApplicationPlayerService, ApplicationPlayerService>();
            services.AddScoped<IApplicationTeamService, ApplicationTeamService>();

            services.AddScoped<IGameMap, GameMap>();
            services.AddScoped<IPlayerMap, PlayerMap>();
            services.AddScoped<ITeamMap, TeamMap>();

            services.AddScoped<ITeamService, TeamService>();
            services.AddScoped<IPlayerService, PlayerService>();
            services.AddScoped<IGameService, GameService>();

            services.AddScoped<IGameRepository, GameRepository>();
            services.AddScoped<IPlayerRepository, PlayerRepository>();
            services.AddScoped<ITeamRepository, TeamRepository>();

        }
    }
}