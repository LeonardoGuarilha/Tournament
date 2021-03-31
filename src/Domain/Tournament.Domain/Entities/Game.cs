using System;

namespace Tournament.Domain.Entities
{
    public class Game : BaseEntity
    {
        public DateTime GameStart { get; set; }
        public DateTime? GameEnd { get; set; }
        public Guid HomeTeamId { get; set; }
        public Guid GuestTeamId { get; set; }
        public int HomeScore { get; set; }
        public int GuestScore { get; set; }

    }
}