using System;
using System.Collections.Generic;
using Tournament.Application.Commands.Commands;

namespace Tournament.Application.Interface
{
    public interface IApplicationTeamService
    {
        void Add(TeamCommand obj);
        TeamCommand GetById(Guid id);
        IEnumerable<TeamCommand> GetAll();
        void Update(TeamCommand obj);
        void Remove(TeamCommand obj);
        void Dispose();
    }
}