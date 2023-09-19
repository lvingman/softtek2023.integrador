using Microsoft.EntityFrameworkCore;
using TechOil.Models;

namespace TechOil.DataAccess.Seeders
{
    public class ProyectoSeeder : IEntitySeeder
    {
        public void SeedDatabase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Proyecto>().HasData(
                new Proyecto
                {
                    Id = 1,
                    Nombre = "Proyecto 1",
                    Direccion = "P. Sherman, Calle Wallaby 42",
                    IdEstado = 1,
                    Active = true
                },
                new Proyecto
                {
                    Id = 2,
                    Nombre = "Proyecto 2",
                    Direccion = "Avenida Siempre Viva 742",
                    IdEstado = 2,
                    Active = true
                });
        }
    }
}