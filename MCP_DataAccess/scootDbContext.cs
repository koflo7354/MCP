using MCP_Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MCP_DataAccess
{
    public class ScootDbContext : DbContext
    {
        public DbSet<App_User> App_user => Set<App_User>();
        public DbSet<Scooter> Scooter => Set<Scooter>();
        public DbSet<Trip> Trip => Set<Trip>();
        public DbSet<UserOnScooter> userOnScooter => Set<UserOnScooter>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                "Host = localhost:5434; " +
                "Username = postgres; " +
                "Password = 123; " +
                "Database = RentAScooter"
                )
            .UseLowerCaseNamingConvention();
        }


    }
}
