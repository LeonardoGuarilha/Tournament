using System;
using System.Collections.Generic;
using Tournament.Domain.Entities;
using Tournament.Domain.Interfaces.Repositories;
using Tournament.Domain.Interfaces.Services;

namespace Tournament.Domain.Services
{
    public class PlayerService : ServiceBase<Player>, IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;

        public PlayerService(IPlayerRepository repository)
            : base(repository)
        {
            _playerRepository = repository;
        }

        public IEnumerable<Player> GetTeamById(Guid teamId)
        {
            return _playerRepository.GetTeamById(teamId);
        }
    }
}