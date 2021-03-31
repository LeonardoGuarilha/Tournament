using System.Collections.Generic;
using Tournament.Application.Commands.Commands;
using Tournament.Domain.Entities;
using Tournament.Infrastructure.CrossCutting.Adapter.Interfaces;

namespace Tournament.Infrastructure.CrossCutting.Adapter.Map
{
    public class TeamMapper : ITeamMapper
    {
        public Team MapperToEntity(TeamCommand teamCommand)
        {
            return new Team()
            {
                Id = teamCommand.Id,
                Name = teamCommand.Name,
                Wins = teamCommand.Wins,
                Loses = teamCommand.Loses
            };
        }

        public IEnumerable<TeamCommand> MapperList(IEnumerable<Team> teams)
        {
            foreach (var team in teams)
            {
                yield return MapperToCommand(team);
            }
        }

        public TeamCommand MapperToCommand(Team team)
        {
            return new TeamCommand()
            {
                Id = team.Id,
                Name = team.Name,
                Wins = team.Wins,
                Loses = team.Loses
            };
        }
    }
}