using Microsoft.EntityFrameworkCore;
using TechOil.Models;

namespace TechOil.DataAccess.Seeders;

public class TrabajoSeeder : IEntitySeeder
{
    public void SeedDatabase(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Trabajo>().HasData(
            new Trabajo
            {
                Id = 1,
                Fecha = "12/03/1998",
                IdProyecto = 1,
                IdServicio = 1,
                CantidadHoras = 8,
                ValorHora = 12.5,
                Costo = 3000,
                Active = true,
              },
            new Trabajo
            {
                Id = 2,
                Fecha = "22/01/2020",
                IdProyecto = 2,
                IdServicio = 2,
                CantidadHoras = 4,
                ValorHora = 32.55,
                Costo = 200000,
                Active = true
            }
        );
    }
}