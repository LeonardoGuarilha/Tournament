using System;
using System.Collections.Generic;
using Tournament.Application.Commands.Commands;

namespace Tournament.Application.Interface
{
    public interface IApplicationGameService 
    {
        void Add(GameCommand obj);
        GameCommand GetById(Guid id);
        IEnumerable<GameCommand> GetAll();
        void Update(GameCommand obj);
        void Remove(GameCommand obj);
        void Dispose();
    }
}