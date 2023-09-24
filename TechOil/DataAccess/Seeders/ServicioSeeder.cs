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
                Descripcion = "Servicio Nº1",
                Estado = true,
                ValorHora = 37.50
            },
            new Servicio
            {
                Id = 2,
                Descripcion = "Servicio Nº2",
                Estado = true,
                ValorHora = 80.75
            },
            new Servicio
            {
                Id = 3,
                Descripcion = "Servicio Nº3",
                Estado = true,
                ValorHora = 4000
            },
            new Servicio
            {
                Id = 4,
                Descripcion = "Servicio Nº4",
                Estado = true,
                ValorHora = 999.99
            },
            new Servicio
            {
                Id = 5,
                Descripcion = "Servicio Nº5",
                Estado = true,
                ValorHora = 1000.1
            },
            new Servicio
            {
                Id = 6,
                Descripcion = "Servicio Nº6",
                Estado = true,
                ValorHora = 1337.30
            },
            new Servicio
            {
                Id = 7,
                Descripcion = "Servicio Nº7",
                Estado = true,
                ValorHora = 50.50
            },
            new Servicio
            {
                Id = 8,
                Descripcion = "Servicio Nº8",
                Estado = true,
                ValorHora = 200.20
            },
            new Servicio
            {
                Id = 9,
                Descripcion = "Servicio Nº9",
                Estado = true,
                ValorHora = 1
            },
            new Servicio
            {
                Id = 10,
                Descripcion = "Servicio Nº10",
                Estado = true,
                ValorHora = 22
            },
            new Servicio
            {
                Id = 11,
                Descripcion = "Servicio Nº11",
                Estado = true,
                ValorHora = 777
            },
            new Servicio
            {
                Id = 12,
                Descripcion = "Servicio Nº12",
                Estado = true,
                ValorHora = 199.98
            }
        );
    }
}