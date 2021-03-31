using System.Collections.Generic;
using Tournament.Application.Commands.Commands;
using Tournament.Domain.Entities;

namespace Tournament.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IGameMap
    {
        Game MapToEntity(GameCommand gameCommand);
        IEnumerable<GameCommand> MapToList(IEnumerable<Game> games);
        GameCommand MapToCommand(Game game);
    }
}