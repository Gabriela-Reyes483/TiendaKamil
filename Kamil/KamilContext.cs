using Microsoft.EntityFrameworkCore;

namespace Kamil
{
    public class ApplicationDbContext : DbContext
    {
        // DbSets para las entidades
        public DbSet<CatalogoPuestos> CatalogoPuestos { get; set; }
        public DbSet<CatalogoCentros> CatalogoCentros { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Directivo> Directivos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=KAMIL;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración del índice único para RFC
            modelBuilder.Entity<Empleado>()
                .HasIndex(e => e.RFC)
                .IsUnique();

            // Relaciones y DeleteBehavior para evitar múltiples rutas en cascada
            modelBuilder.Entity<Empleado>()
                .HasOne(e => e.Puesto)
                .WithMany(p => p.Empleados)
                .HasForeignKey(e => e.ID_Puesto)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Empleado>()
                .HasOne(e => e.Centro)
                .WithMany(c => c.Empleados)
                .HasForeignKey(e => e.Numero_Centro)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Directivo>()
                .HasOne(d => d.Empleado)
                .WithOne(e => e.DirectivoInfo)
                .HasForeignKey<Directivo>(d => d.Numero_Empleado)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Directivo>()
                .HasOne(d => d.CentroSupervisado)
                .WithMany(c => c.DirectivosSupervisados)
                .HasForeignKey(d => d.Centro_Supervisado)
                .OnDelete(DeleteBehavior.Restrict);

            // Seed data para CatalogoPuestos
            modelBuilder.Entity<CatalogoPuestos>().HasData(
                new CatalogoPuestos { ID_Puesto = 1, Descripcion_Puesto = "Gerente" },
                new CatalogoPuestos { ID_Puesto = 2, Descripcion_Puesto = "Supervisor" },
                new CatalogoPuestos { ID_Puesto = 3, Descripcion_Puesto = "Operador" },
                new CatalogoPuestos { ID_Puesto = 4, Descripcion_Puesto = "Analista" },
                new CatalogoPuestos { ID_Puesto = 5, Descripcion_Puesto = "Administrativo" }
            );

            // Seed data para CatalogoCentros
            modelBuilder.Entity<CatalogoCentros>().HasData(
                new CatalogoCentros { Numero_Centro = 1, Nombre_Centro = "Centro Norte", Ciudad = "Monterrey" },
                new CatalogoCentros { Numero_Centro = 2, Nombre_Centro = "Centro Sur", Ciudad = "Ciudad de México" },
                new CatalogoCentros { Numero_Centro = 3, Nombre_Centro = "Centro Occidente", Ciudad = "Guadalajara" },
                new CatalogoCentros { Numero_Centro = 4, Nombre_Centro = "Centro Bajío", Ciudad = "León" },
                new CatalogoCentros { Numero_Centro = 5, Nombre_Centro = "Centro Sureste", Ciudad = "Mérida" }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}