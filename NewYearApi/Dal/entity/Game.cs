using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.entity
{
    public class Game
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string GameName { get; set; }
        public string Description { get; set; }
        public int NumberOfGifts { get; set; }
        public string Sponser { get; set; }
        public string Coordinator { get; set; }

    }
}
