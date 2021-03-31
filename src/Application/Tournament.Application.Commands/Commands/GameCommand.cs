using System;

namespace Tournament.Application.Commands.Commands
{
    public class GameCommand : BaseCommand
    {
        public DateTime GameStart { get; set; }

        public DateTime? GameEnd { get; set; }

        public Guid HomeTeamId { get; set; }

        public Guid GuestTeamId { get; set; }

        public int HomeScore { get; set; }

        public int GuestScore { get; set; }
    }
}