using System;
using System.Collections.Generic;
using Tournament.Application.Commands.Commands;
using Tournament.Domain.Entities;
using Tournament.Infrastructure.CrossCutting.Adapter.Interfaces;

namespace Tournament.Infrastructure.CrossCutting.Adapter.Map
{
    public class PlayerMapper : IPlayerMapper
    {
        public Player MapperToEntity(PlayerCommand playerCommand)
        {
            return new Player()
            {
                Id = playerCommand.Id,
                Name = playerCommand.Name,
                TeamId = playerCommand.TeamId == Guid.Empty? null: playerCommand.TeamId
            };
        }

        public IEnumerable<PlayerCommand> MapperList(IEnumerable<Player> players)
        {
            foreach (var player in players)
            {
                yield return MapperToCommand(player);
            }
        }

        public PlayerCommand MapperToCommand(Player player)
        {
            return new PlayerCommand()
            {
                Id = player.Id,
                Name = player.Name,
                TeamId = player.TeamId
            };
        }
    }
}