using Microsoft.EntityFrameworkCore;
using TechOil.Models;

namespace TechOil.DataAccess.Seeders
{
    public class RolSeeder : IEntitySeeder
    {
        public void SeedDatabase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rol>().HasData(
                new Rol
                {
                    Id = 1,
                    Nombre = "Admin",
                    Descripcion = "Admin",
                    Active = true,

                },
                 new Rol
                 {
                     Id = 2,
                     Nombre = "Consulta",
                     Descripcion = "Consulta",
                     Active = true,
                 });
        }
    }
}