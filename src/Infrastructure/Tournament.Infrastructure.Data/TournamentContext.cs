using Microsoft.EntityFrameworkCore;
using Tournament.Domain.Entities;

namespace Tournament.Infrastructure.Data
{
    public class TournamentContext : DbContext
    {
        public TournamentContext(DbContextOptions<TournamentContext> options) : base(options) { }

        public DbSet<Player> Players { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Game> Games { get; set; }
    }
}