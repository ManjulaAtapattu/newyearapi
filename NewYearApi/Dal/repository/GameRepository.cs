using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.entity;

namespace Dal.repository
{
    public class GameRepository : IGameRepository
    {
        public List<Game> Get()
        {
            using (NewYearDbContext dbContext = new NewYearDbContext())
            {
                return dbContext.Games.ToList();
            }
        }

        public void Add(Game game)
        {
            using (NewYearDbContext dbContext = new NewYearDbContext())
            {
                dbContext.Games.Add(game);
                if (dbContext.SaveChanges() != 1)
                {
                    throw new Exception("Error Occurred..");
                }
            }
        }


        public void Update(Game game)
        {
            using (NewYearDbContext dbContext = new NewYearDbContext())
            {
                dbContext.Games.Attach(game);
                var entry = dbContext.Entry(game);

                entry.State = EntityState.Modified;
                dbContext.SaveChanges();

            }
        }



        public void Delete(int id)
        {
            using (NewYearDbContext dbContext = new NewYearDbContext())
            {
                var game = dbContext.Games.FirstOrDefault(g => g.Id == id);
                if (game != null)
                {
                    dbContext.Games.Remove(game);
                    dbContext.SaveChanges();
                }
                else
                {
                    throw new DataException($"No Game found witht the id  {id}");
                }
            }
        }
    }
}
