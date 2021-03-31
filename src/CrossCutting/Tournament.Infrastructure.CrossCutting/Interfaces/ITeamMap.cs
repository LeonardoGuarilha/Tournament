using System.Collections.Generic;
using Tournament.Application.Commands.Commands;
using Tournament.Domain.Entities;

namespace Tournament.Infrastructure.CrossCutting.Interfaces
{
    public interface ITeamMap
    {
        Team MapToEntity(TeamCommand teamCommand);
        IEnumerable<TeamCommand> MapToList(IEnumerable<Team> teams);
        TeamCommand MapToCommand(Team team);
    }
}