using Microsoft.EntityFrameworkCore;
using RebelTours.Domain;
using RebelTours.Persistence.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelTours.Persistence
{
    public class RebelToursDbContext : DbContext
    {
        private string connectionString = "Server=DESKTOP-MTU4EKB\\SQLEXPRESS; Database=RebelToursDb; Integrated Security=true;" ;
        public DbSet<City> Cities { get; set; }
        public DbSet<Station> Stations { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CityConfiguration());
            modelBuilder.ApplyConfiguration(new StationConfiguration());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }

    }

}
