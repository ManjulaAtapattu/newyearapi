using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dal.entity;
using Dal.handler;
using Dal.repository;

namespace NewYearApi.Controllers
{

    public class GameController : ApiController
    {
        private GameHandler gameHandler;

        public GameController()
        {
            gameHandler = new GameHandler(new GameRepository());
        }


        // GET: api/Game
        public IEnumerable<Game> Get()
        {
            // return new string[] { "value1", "value2" };
           return gameHandler.GetGames();
        }

        // GET: api/Game/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Game
        public void Post([FromBody]Game game)
        {
            gameHandler.Add(game);
        }

        // PUT: api/Game/5
        public void Put(int id, [FromBody]Game game)
        {
            gameHandler.Update(game);
        }

        // DELETE: api/Game/5
        public void Delete(int id)
        {
            gameHandler.Delete(id);
        }
    }
}
