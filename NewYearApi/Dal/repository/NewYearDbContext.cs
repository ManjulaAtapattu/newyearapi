using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.entity;

namespace Dal.repository
{
    class NewYearDbContext:DbContext
    {
        public NewYearDbContext() : base("name=NewYearDBConnection")
        {
            Database.SetInitializer<NewYearDbContext>(null);
        }

        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<Game> Games { get; set; }
    }
}
