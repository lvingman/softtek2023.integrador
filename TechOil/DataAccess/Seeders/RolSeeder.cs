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
                    Nombre = "Administrador",
                    Descripcion = "Administrador del proyecto",
                    Active = true,

                },
                 new Rol
                 {
                     Id = 2,
                     Nombre = "Consultor",
                     Descripcion = "Consultor del proyecto",
                     Active = true,
                 });
        }
    }
}