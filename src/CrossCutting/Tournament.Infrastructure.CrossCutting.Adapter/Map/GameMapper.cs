using System.Collections.Generic;
using Tournament.Application.Commands.Commands;
using Tournament.Domain.Entities;
using Tournament.Infrastructure.CrossCutting.Adapter.Interfaces;

namespace Tournament.Infrastructure.CrossCutting.Adapter.Map
{
    public class GameMapper : IGameMapper
    {
        public Game MapperToEntity(GameCommand gameCommand)
        {
            return new Game()
            {
                Id = gameCommand.Id,
                GameStart = gameCommand.GameStart,
                GameEnd = gameCommand.GameEnd,
                HomeScore = gameCommand.HomeScore,
                GuestScore = gameCommand.GuestScore,
                GuestTeamId = gameCommand.GuestTeamId,
                HomeTeamId = gameCommand.HomeTeamId
            };
        }

        public IEnumerable<GameCommand> MapperList(IEnumerable<Game> games)
        {
            foreach (var game in games)
            {
                yield return MapperToCommand(game);
            }
        }

        public GameCommand MapperToCommand(Game game)
        {
            return new GameCommand()
            {
                Id = game.Id,
                GameStart = game.GameStart,
                GameEnd = game.GameEnd,
                HomeScore = game.HomeScore,
                GuestScore = game.GuestScore,
                GuestTeamId = game.GuestTeamId,
                HomeTeamId = game.HomeTeamId
            };
        }
    }
}