using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.entity;
using Dal.repository;

namespace Dal.handler
{
    public class GameHandler
    {
        private readonly IGameRepository _gameRepository;

        public GameHandler(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public List<Game> GetGames()
        {
            var games = _gameRepository.Get();
            return games;
        }

        public void Add(Game game)
        {
             _gameRepository.Add(game);
           
        }

        public void Update(Game game)
        {
            _gameRepository.Update(game);

        }

        public void Delete(int id)
        {
            _gameRepository.Delete(id);

        }
    }
}
