using System;
using System.Collections.Generic;
using Tournament.Domain.Entities;

namespace Tournament.Domain.Interfaces.Services
{
    public interface IPlayerService: IBaseService<Player>
    {
        IEnumerable<Player> GetTeamById(Guid teamId);
    }
}