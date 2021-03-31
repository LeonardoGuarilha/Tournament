using System.Collections.Generic;
using Tournament.Application.Commands.Commands;
using Tournament.Domain.Entities;

namespace Tournament.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface ITeamMapper
    {
        Team MapperToEntity(TeamCommand teamCommand);
        IEnumerable<TeamCommand> MapperList(IEnumerable<Team> teams);
        TeamCommand MapperToCommand(Team team);
    }
}