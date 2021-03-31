using System.Collections.Generic;
using Tournament.Application.Commands.Commands;
using Tournament.Domain.Entities;

namespace Tournament.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IPlayerMap
    {
        Player MapToEntity(PlayerCommand playerCommand);
        IEnumerable<PlayerCommand> MapToList(IEnumerable<Player> players);
        PlayerCommand MapToCommand(Player player);
    }
}