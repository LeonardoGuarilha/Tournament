using Tournament.Domain.Entities;
using Tournament.Domain.Interfaces.Repositories;
using Tournament.Infrasctructure.Data;

namespace Tournament.Infrastructure.Repository.Repositories
{
    public class GameRepository: BaseRepository<Game>, IGameRepository
    {
        private readonly TournamentContext _context;

        public GameRepository(TournamentContext context)
            : base(context)
        {
            _context = context;
        }
    }
}