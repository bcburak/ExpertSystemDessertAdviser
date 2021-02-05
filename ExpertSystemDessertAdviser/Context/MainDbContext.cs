using ExpertSystemDessertAdviser.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemDessertAdviser.Context
{
    public class MainDbContext : DbContext, IDisposable
    {
        #region DbEntityClasses
        public DbSet<Meal> Meal { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Restaurant> Restaurant { get; set; }
        public DbSet<User> User { get; set; }

        #endregion

    }
}
