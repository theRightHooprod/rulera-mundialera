using Microsoft.EntityFrameworkCore;
using rulera_mundialera.Server.Database.Entities;

namespace rulera_mundialera.Server.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Test> Tests { get; set; }

        // 1. ¡Este es el constructor clave que falta! 
        // Acepta las opciones de configuración y se las hereda a la clase base (DbContext)
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        // 2. Mantenemos el constructor vacío por si las herramientas de migración en consola lo necesitan
        public DatabaseContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // 3. Una buena práctica: solo aplica la cadena de conexión local 
            // si no se ha configurado previamente en el Program.cs
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Database=rulera-mundialeradb;Username=psql;Password=D1rrhb6BdE24");
            }
        }
    }
}