using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProjectBaseX.Domain.Entities;
using ProjectBaseX.Infra.Data.Mapping;
using System.IO;

namespace ProjectBaseX.Infra.Data.Context
{
    public class MySqlContext : DbContext
    {
 

        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
            // get the configuration from the app settings
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseMySql(config.GetConnectionString("MYSQLCONNSTR_defaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<User>(new UserMap().Configure);
            modelBuilder.ApplyConfiguration(new UserMap());


            base.OnModelCreating(modelBuilder);
        }
    }
}
