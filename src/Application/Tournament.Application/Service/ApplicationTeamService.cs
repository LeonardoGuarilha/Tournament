using System;
using System.Collections.Generic;
using Tournament.Application.Commands.Commands;
using Tournament.Application.Interface;
using Tournament.Domain.Interfaces.Services;
using Tournament.Infrastructure.CrossCutting.Adapter.Interfaces;

namespace Tournament.Application.Service
{
    public class ApplicationTeamService : IApplicationTeamService
    {
        private readonly ITeamService _teamService;

        private readonly ITeamMapper _teamMapper;

        public ApplicationTeamService(ITeamService teamService, ITeamMapper teamMapper)
        {
            _teamService = teamService;
            _teamMapper = teamMapper;
        }

        public void Remove(TeamCommand obj)
        {
            _teamService.Remove(_teamMapper.MapperToEntity(obj));
        }

        public IEnumerable<TeamCommand> GetAll()
        {
            return _teamMapper.MapperList(_teamService.GetAll());
        }

        public TeamCommand GetById(Guid id)
        {
            return _teamMapper.MapperToCommand(_teamService.GetById(id));
        }

        public void Add(TeamCommand obj)
        {
            _teamService.Add(_teamMapper.MapperToEntity(obj));
        }

        public void Update(TeamCommand obj)
        {
            _teamService.Update(_teamMapper.MapperToEntity(obj));
        }

        public void Dispose()
        {
            _teamService.Dispose();
        }
    }
}