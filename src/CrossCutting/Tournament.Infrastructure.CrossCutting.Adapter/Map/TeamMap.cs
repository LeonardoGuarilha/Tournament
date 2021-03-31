using System.Collections.Generic;
using Tournament.Application.Commands.Commands;
using Tournament.Domain.Entities;
using Tournament.Infrastructure.CrossCutting.Adapter.Interfaces;

namespace Tournament.Infrastructure.CrossCutting.Adapter.Map
{
    public class TeamMap : ITeamMap
    {
        public Team MapToEntity(TeamCommand teamCommand)
        {
            return new Team()
            {
                Id = teamCommand.Id,
                Name = teamCommand.Name,
                Wins = teamCommand.Wins,
                Loses = teamCommand.Loses
            };
        }

        public IEnumerable<TeamCommand> MapToList(IEnumerable<Team> teams)
        {
            foreach (var team in teams)
            {
                yield return MapToCommand(team);
            }
        }

        public TeamCommand MapToCommand(Team team)
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