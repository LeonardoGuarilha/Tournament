namespace Tournament.Application.Commands.Commands
{
    public class TeamCommand : BaseCommand
    {
        public string Name { get; set; }

        public int Wins { get; set; }

        public int Loses { get; set; }
    }
}