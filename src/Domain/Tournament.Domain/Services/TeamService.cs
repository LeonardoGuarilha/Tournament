using Tournament.Domain.Entities;
using Tournament.Domain.Interfaces.Repositories;
using Tournament.Domain.Interfaces.Services;

namespace Tournament.Domain.Services
{
    public class TeamService : ServiceBase<Team>, ITeamService
    {
        private readonly ITeamRepository _teamRepository;

        public TeamService(ITeamRepository repository)
            : base(repository)
        {
            _teamRepository = repository;
        }
    }
}