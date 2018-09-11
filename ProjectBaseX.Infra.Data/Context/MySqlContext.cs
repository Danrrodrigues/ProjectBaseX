using Microsoft.EntityFrameworkCore;
using ProjectBaseX.Domain.Entities;
using ProjectBaseX.Infra.Data.Mapping;

namespace ProjectBaseX.Infra.Data.Context
{
    public class MySqlContext : DbContext
    {
 

        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseMySql("Server=servermysqlbasex.mysql.database.azure.com;Port=3306;Database=projectbasex;Uid=mysqldbuser@servermysqlbasex;Pwd=mysqldbSenha10;SslMode=Preferred");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<User>(new UserMap().Configure);
            modelBuilder.ApplyConfiguration(new UserMap());


            base.OnModelCreating(modelBuilder);
        }
    }
}
