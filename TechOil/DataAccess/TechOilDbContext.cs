
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using TechOil.DataAccess.Seeders;
using TechOil.Models;

namespace TechOil.DataAccess
{
    public class TechOilDbContext : DbContext
    {
        //ctor construye constructor automatico
        //El constructor aplica las opciones de DbContext en la clase
        public TechOilDbContext(DbContextOptions<TechOilDbContext> options) : base(options)
        {
            
        }

        public DbSet<Proyecto> Proyectos { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Trabajo> Trabajos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Se especifica la SeedData aca adentro
            var seeders = new List<IEntitySeeder>
            {
                new RolSeeder(),
                new UsuarioSeeder(),
                new ServicioSeeder(),
                new ProyectoSeeder()
            };

            foreach (var entitySeeder in seeders)
            {
                entitySeeder.SeedDatabase(modelBuilder);
            }
        }
        
    }
    
}
