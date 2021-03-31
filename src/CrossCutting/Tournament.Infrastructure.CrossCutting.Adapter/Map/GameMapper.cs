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
                StartGameHour = gameCommand.StartGameHour,
                EndGameHour = gameCommand.EndGameHour,
                HomeScore = gameCommand.HomeScore,
                VisitoursScore = gameCommand.VisitoursScore,
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
                StartGameHour = game.StartGameHour,
                EndGameHour = game.EndGameHour,
                HomeScore = game.HomeScore,
                VisitoursScore = game.VisitoursScore,
                GuestTeamId = game.GuestTeamId,
                HomeTeamId = game.HomeTeamId
            };
        }
    }
}