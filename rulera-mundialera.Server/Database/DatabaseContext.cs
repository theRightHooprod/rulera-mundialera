using Microsoft.EntityFrameworkCore;
using rulera_mundialera.Server.Database.Entities;

namespace rulera_mundialera.Server.Database
{
    public class DatabaseContext(DbContextOptions<DatabaseContext> options) : DbContext(options)
    {
        public DbSet<Test> Tests { get; set; }

    }
}
