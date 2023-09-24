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
            },
            new Trabajo
            {
                Id = 3,
                Fecha = DateTime.ParseExact("20/05/2015","dd/MM/yyyy", CultureInfo.InvariantCulture),
                IdProyecto = 5,
                IdServicio = 3,
                CantidadHoras = 8,
                ValorHora = 4300,
                Active = true
            },
            new Trabajo
            {
                Id = 4,
                Fecha = DateTime.ParseExact("15/03/2007","dd/MM/yyyy", CultureInfo.InvariantCulture),
                IdProyecto = 7,
                IdServicio = 5,
                CantidadHoras = 6,
                ValorHora = 885,
                Active = true
            },
            new Trabajo
            {
                Id = 5,
                Fecha = DateTime.ParseExact("01/05/1993","dd/MM/yyyy", CultureInfo.InvariantCulture),
                IdProyecto = 8,
                IdServicio = 8,
                CantidadHoras = 2,
                ValorHora = 62.50,
                Active = true
            },
            new Trabajo
            {
                Id = 6,
                Fecha = DateTime.ParseExact("06/03/1990","dd/MM/yyyy", CultureInfo.InvariantCulture),
                IdProyecto = 1,
                IdServicio = 5,
                CantidadHoras = 8,
                ValorHora = 9500,
                Active = true
            },
            new Trabajo
            {
                Id = 7,
                Fecha = DateTime.ParseExact("07/09/2011","dd/MM/yyyy", CultureInfo.InvariantCulture),
                IdProyecto = 10,
                IdServicio = 10,
                CantidadHoras = 7,
                ValorHora = 85.620,
                Active = true
            },
            new Trabajo
            {
                Id = 8,
                Fecha = DateTime.ParseExact("08/11/2001","dd/MM/yyyy", CultureInfo.InvariantCulture),
                IdProyecto = 5,
                IdServicio = 4,
                CantidadHoras = 6,
                ValorHora = 172.50,
                Active = true
            },
            new Trabajo
            {
                Id = 9,
                Fecha = DateTime.ParseExact("20/11/2022","dd/MM/yyyy", CultureInfo.InvariantCulture),
                IdProyecto = 9,
                IdServicio = 8,
                CantidadHoras = 8,
                ValorHora = 90.50,
                Active = true
            },
            new Trabajo
            {
                Id = 10,
                Fecha = DateTime.ParseExact("11/03/2005","dd/MM/yyyy", CultureInfo.InvariantCulture),
                IdProyecto = 5,
                IdServicio = 5,
                CantidadHoras = 6,
                ValorHora = 99.705,
                Active = true
            },
            new Trabajo
            {
                Id = 11,
                Fecha = DateTime.ParseExact("10/03/2002","dd/MM/yyyy", CultureInfo.InvariantCulture),
                IdProyecto = 6,
                IdServicio = 9,
                CantidadHoras = 12,
                ValorHora = 10,
                Active = true
            }
        );
    }
}