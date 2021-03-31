using System;
using System.Collections.Generic;
using Tournament.Domain.Entities;

namespace Tournament.Domain.Interfaces.Repositories
{
    public interface IPlayerRepository: IBaseRepository<Player>
    {
        IEnumerable<Player> GetTeamById(Guid teamId);
    }
}