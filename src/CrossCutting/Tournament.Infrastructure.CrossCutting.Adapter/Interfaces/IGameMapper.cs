using System.Collections.Generic;
using Tournament.Application.Commands.Commands;
using Tournament.Domain.Entities;

namespace Tournament.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IGameMapper
    {
        Game MapperToEntity(GameCommand gameCommand);
        IEnumerable<GameCommand> MapperList(IEnumerable<Game> games);
        GameCommand MapperToCommand(Game game);
    }
}