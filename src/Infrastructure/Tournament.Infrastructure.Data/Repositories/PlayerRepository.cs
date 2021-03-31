using System;
using System.Collections.Generic;
using System.Linq;
using Tournament.Domain.Entities;
using Tournament.Domain.Interfaces.Repositories;

namespace Tournament.Infrastructure.Data.Repositories
{
    public class PlayerRepository : BaseRepository<Player>, IPlayerRepository
    {
        private readonly TournamentContext _context;
        public PlayerRepository(TournamentContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Player> GetTeamById(Guid teamId)
        {
            return _context.Players.Where(x => x.TeamId == teamId);
        }
    }
}