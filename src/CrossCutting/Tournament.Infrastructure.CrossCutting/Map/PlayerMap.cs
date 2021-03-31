using System;
using System.Collections.Generic;
using Tournament.Application.Commands.Commands;
using Tournament.Domain.Entities;
using Tournament.Infrastructure.CrossCutting.Interfaces;

namespace Tournament.Infrastructure.CrossCutting.Map
{
    public class PlayerMap : IPlayerMap
    {
        public Player MapToEntity(PlayerCommand playerCommand)
        {
            return new Player()
            {
                Id = playerCommand.Id,
                Name = playerCommand.Name,
                TeamId = playerCommand.TeamId == Guid.Empty? null: playerCommand.TeamId
            };
        }

        public IEnumerable<PlayerCommand> MapToList(IEnumerable<Player> players)
        {
            foreach (var player in players)
            {
                yield return MapToCommand(player);
            }
        }

        public PlayerCommand MapToCommand(Player player)
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