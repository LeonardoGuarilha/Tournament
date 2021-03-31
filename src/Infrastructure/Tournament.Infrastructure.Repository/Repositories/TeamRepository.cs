using Tournament.Domain.Entities;
using Tournament.Domain.Interfaces.Repositories;
using Tournament.Infrasctructure.Data;

namespace Tournament.Infrastructure.Repository.Repositories
{
    public class TeamRepository: BaseRepository<Team>, ITeamRepository
    {
        private readonly TournamentContext _context;

        public TeamRepository(TournamentContext context)
            : base(context)
        {
            _context = context;
        }
    }
}