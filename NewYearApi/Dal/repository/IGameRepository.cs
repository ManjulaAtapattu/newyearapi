using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Dal.entity;

namespace Dal.repository
{
    public interface IGameRepository
    {
        List<Game> Get();
        void Add(Game game);

        void Update(Game game);

        void Delete(int id);
    }
}
