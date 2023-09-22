using System.Globalization;
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
                Fecha = DateTime.ParseExact("12/03/1998", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                IdProyecto = 1,
                IdServicio = 1,
                CantidadHoras = 8,
                ValorHora = 12.5,
                Active = true,
              },
            new Trabajo
            {
                Id = 2,
                Fecha = DateTime.ParseExact("22/01/2020","dd/MM/yyyy", CultureInfo.InvariantCulture),
                IdProyecto = 2,
                IdServicio = 2,
                CantidadHoras = 4,
                ValorHora = 32.55,
                Active = true
            }
        );
    }
}