using System;
using System.Collections.Generic;
using Tournament.Application.Commands.Commands;

namespace Tournament.Application.Interface
{
    public interface IApplicationPlayerService
    {
        void Add(PlayerCommand obj);
        PlayerCommand GetById(Guid id);
        IEnumerable<PlayerCommand> GetAll();
        void Update(PlayerCommand obj);
        void Remove(PlayerCommand obj);
        void Dispose();
    }
}