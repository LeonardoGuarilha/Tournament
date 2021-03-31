using System.Collections.Generic;
using Tournament.Application.Commands.Commands;
using Tournament.Domain.Entities;

namespace Tournament.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IPlayerMapper
    {
        Player MapperToEntity(PlayerCommand playerCommand);
        IEnumerable<PlayerCommand> MapperList(IEnumerable<Player> players);
        PlayerCommand MapperToCommand(Player player);
    }
}