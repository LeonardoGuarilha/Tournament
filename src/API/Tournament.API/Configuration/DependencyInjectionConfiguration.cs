using Microsoft.Extensions.DependencyInjection;
using Tournament.Application.Interface;
using Tournament.Application.Service;
using Tournament.Domain.Interfaces.Repositories;
using Tournament.Domain.Interfaces.Services;
using Tournament.Domain.Services;
using Tournament.Infrastructure.CrossCutting.Adapter.Interfaces;
using Tournament.Infrastructure.CrossCutting.Adapter.Map;
using Tournament.Infrastructure.Repository.Repositories;

namespace Tournament.API.Configuration
{
    public static class DependencyInjectionConfiguration
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IApplicationGameService, ApplicationGameService>();
            services.AddScoped<IApplicationPlayerService, ApplicationPlayerService>();
            services.AddScoped<IApplicationTeamService, ApplicationTeamService>();

            services.AddScoped<IGameMapper, GameMapper>();
            services.AddScoped<IPlayerMapper, PlayerMapper>();
            services.AddScoped<ITeamMapper, TeamMapper>();

            services.AddScoped<ITeamService, TeamService>();
            services.AddScoped<IPlayerService, PlayerService>();
            services.AddScoped<IGameService, GameService>();

            services.AddScoped<IGameRepository, GameRepository>();
            services.AddScoped<IPlayerRepository, PlayerRepository>();
            services.AddScoped<ITeamRepository, TeamRepository>();

        }
    }
}