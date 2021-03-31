using Tournament.Domain.Entities;
using Tournament.Domain.Interfaces.Repositories;
using Tournament.Domain.Interfaces.Services;

namespace Tournament.Domain.Services
{
    public class GameService : ServiceBase<Game>, IGameService
    {
        private readonly IGameRepository _gameRepository;

        public GameService(IGameRepository repository) 
            : base(repository)
        {
            _gameRepository = repository;
        }
    }
}