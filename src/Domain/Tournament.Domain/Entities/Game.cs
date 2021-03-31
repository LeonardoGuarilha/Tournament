using System;

namespace Tournament.Domain.Entities
{
    public class Game : BaseEntity
    {
        public DateTime StartGameHour { get; set; }
        public DateTime? EndGameHour { get; set; }
        public Guid HomeTeamId { get; set; }
        public Guid GuestTeamId { get; set; }
        public int HomeScore { get; set; }
        public int VisitoursScore { get; set; }
    }
}