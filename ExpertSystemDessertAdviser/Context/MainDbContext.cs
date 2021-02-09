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
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Desert> Deserts { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        #endregion

    }
}
