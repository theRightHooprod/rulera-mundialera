using Microsoft.EntityFrameworkCore;
using rulera_mundialera.Server.Database.Entities;

namespace rulera_mundialera.Server.Database
{
    public class Database : DbContext
    {
        public DbSet<Test> tests { get; set; }

        public Database()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       => optionsBuilder.UseNpgsql("Host=localhost;Database=rulera-mundialeradb;Username=psql;Password=D1rrhb6BdE24");


    }
}
