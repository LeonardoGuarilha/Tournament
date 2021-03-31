using System;
using System.Collections.Generic;
using Tournament.Application.Commands.Commands;
using Tournament.Application.Interface;
using Tournament.Domain.Interfaces.Services;
using Tournament.Infrastructure.CrossCutting.Adapter.Interfaces;

namespace Tournament.Application.Service
{
    public class ApplicationGameService : IApplicationGameService
    {
        private readonly IGameService _gameService;

        private readonly IGameMap _gameMap;

        public ApplicationGameService(IGameService gameService, IGameMap gameMap)
                                              
        {
            _gameService = gameService;
            _gameMap = gameMap;
        }
        public void Remove(GameCommand obj)
        {
            _gameService.Remove(_gameMap.MapToEntity(obj));
        }

        public IEnumerable<GameCommand> GetAll()
        {
            return _gameMap.MapToList(_gameService.GetAll());
        }

        public GameCommand GetById(Guid id)
        {
            return _gameMap.MapToCommand(_gameService.GetById(id));
        }

        public void Add(GameCommand obj)
        {
            _gameService.Add(_gameMap.MapToEntity(obj));
        }

        public void Update(GameCommand obj)
        {
            _gameService.Update(_gameMap.MapToEntity(obj));
        }
        
        public void Dispose()
        {
            _gameService.Dispose();
        }
    }
}