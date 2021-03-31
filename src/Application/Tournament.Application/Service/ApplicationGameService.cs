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

        private readonly IGameMapper _gameMapper;

        public ApplicationGameService(IGameService gameService, IGameMapper gameMapper)
                                              
        {
            _gameService = gameService;
            _gameMapper = gameMapper;
        }
        public void Remove(GameCommand obj)
        {
            _gameService.Remove(_gameMapper.MapperToEntity(obj));
        }

        public IEnumerable<GameCommand> GetAll()
        {
            return _gameMapper.MapperList(_gameService.GetAll());
        }

        public GameCommand GetById(Guid id)
        {
            return _gameMapper.MapperToCommand(_gameService.GetById(id));
        }

        public void Add(GameCommand obj)
        {
            _gameService.Add(_gameMapper.MapperToEntity(obj));
        }

        public void Update(GameCommand obj)
        {
            _gameService.Update(_gameMapper.MapperToEntity(obj));
        }
        
        public void Dispose()
        {
            _gameService.Dispose();
        }
    }
}