using System;
using System.Collections.Generic;
using Tournament.Application.Commands.Commands;
using Tournament.Application.Interface;
using Tournament.Domain.Interfaces.Services;
using Tournament.Infrastructure.CrossCutting.Interfaces;

namespace Tournament.Application.Service
{
    public class ApplicationTeamService : IApplicationTeamService
    {
        private readonly ITeamService _teamService;

        private readonly ITeamMap _teamMap;

        public ApplicationTeamService(ITeamService teamService, ITeamMap teamMap)
        {
            _teamService = teamService;
            _teamMap = teamMap;
        }

        public void Remove(TeamCommand obj)
        {
            _teamService.Remove(_teamMap.MapToEntity(obj));
        }

        public IEnumerable<TeamCommand> GetAll()
        {
            return _teamMap.MapToList(_teamService.GetAll());
        }

        public TeamCommand GetById(Guid id)
        {
            return _teamMap.MapToCommand(_teamService.GetById(id));
        }

        public void Add(TeamCommand obj)
        {
            _teamService.Add(_teamMap.MapToEntity(obj));
        }

        public void Update(TeamCommand obj)
        {
            _teamService.Update(_teamMap.MapToEntity(obj));
        }

        public void Dispose()
        {
            _teamService.Dispose();
        }
    }
}