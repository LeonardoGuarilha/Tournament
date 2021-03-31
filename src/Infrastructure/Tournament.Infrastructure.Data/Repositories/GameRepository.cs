using Tournament.Domain.Entities;
using Tournament.Domain.Interfaces.Repositories;

namespace Tournament.Infrastructure.Data.Repositories
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