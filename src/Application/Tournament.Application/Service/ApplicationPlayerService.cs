using System;
using System.Collections.Generic;
using System.Linq;
using Tournament.Application.Commands.Commands;
using Tournament.Application.Interface;
using Tournament.Domain.Interfaces.Services;
using Tournament.Infrastructure.CrossCutting.Adapter.Interfaces;

namespace Tournament.Application.Service
{
    public class ApplicationPlayerService : IApplicationPlayerService
    {
        private readonly IPlayerService _playerService;

        private readonly IPlayerMapper _playerMapper;

        public ApplicationPlayerService(IPlayerService playerService, IPlayerMapper playerMapper)
        {
            _playerService = playerService;
            _playerMapper = playerMapper;
        }

        public void Remove(PlayerCommand obj)
        {
            _playerService.Remove(_playerMapper.MapperToEntity(obj));
        }

        public IEnumerable<PlayerCommand> GetAll()
        {
            return _playerMapper.MapperList(_playerService.GetAll());
        }

        public PlayerCommand GetById(Guid id)
        {
            return _playerMapper.MapperToCommand(_playerService.GetById(id));
        }

        public void Add(PlayerCommand obj)
        {
            try
            {
                TeamCompletedException(obj);

                _playerService.Add(_playerMapper.MapperToEntity(obj));
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public void Update(PlayerCommand obj)
        {
            TeamCompletedException(obj);

            _playerService.Update(_playerMapper.MapperToEntity(obj));
        }

        public void Dispose()
        {
            _playerService.Dispose();
        }

        private void TeamCompletedException(PlayerCommand obj)
        {
            if ((obj.TeamId.HasValue))
            {
                var playersOnTeam = _playerService.GetTeamById(obj.TeamId.Value);

                if ((playersOnTeam.Count() > 4) && !(playersOnTeam.Where(x=> x.Id == obj.Id) == null))
                    throw new Exception("Team completed");
            }
        }
    }
}