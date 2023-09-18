using Microsoft.EntityFrameworkCore;

using TechOil.Models;

namespace TechOil.DataAccess.Seeders;

public class ServicioSeeder : IEntitySeeder
{
    public void SeedDatabase(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Servicio>().HasData(
            new Servicio
            {
                Id = 1,
                Descripcion = "Un servicio",
                Estado = true,
                ValorHora = 37.50
            },
            new Servicio
            {
                Id = 2,
                Descripcion = "Servicio Nº2",
                Estado = true,
                ValorHora = 80.75
            }
        );
    }
}