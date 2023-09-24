using Microsoft.EntityFrameworkCore;
using TechOil.Models;

namespace TechOil.DataAccess.Seeders
{
    public class ProyectoSeeder : IEntitySeeder
    {
        public void SeedDatabase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Proyecto>().HasData
            (
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
                },
                new Proyecto
                {
                    Id = 3,
                    Nombre = "Proyecto 3",
                    Direccion = "Mariano Moreno 3311",
                    IdEstado = 3,
                    Active = true
                },
                new Proyecto
                {
                    Id = 4,
                    Nombre = "Proyecto 4",
                    Direccion = "Guemes 1645",
                    IdEstado = 1,
                    Active = true
                },
                new Proyecto
                {
                    Id = 5,
                    Nombre = "Proyecto 5",
                    Direccion = "Gaspar Campos 3200",
                    IdEstado = 2,
                    Active = true
                },
                new Proyecto
                {
                    Id = 6,
                    Nombre = "Proyecto 6",
                    Direccion = "Avenida Corrientes y Libertador",
                    IdEstado = 3,
                    Active = true
                },
                new Proyecto
                {
                    Id = 7,
                    Nombre = "Proyecto 7",
                    Direccion = "Ruta 197 y Yrigoin",
                    IdEstado = 1,
                    Active = true
                },
                new Proyecto
                {
                    Id = 8,
                    Nombre = "Proyecto 8",
                    Direccion = "Avenida Balbin 433",
                    IdEstado = 2,
                    Active = true
                },
                new Proyecto
                {
                    Id = 9,
                    Nombre = "Proyecto 9",
                    Direccion = "Parana 350",
                    IdEstado = 3,
                    Active = true
                },
                new Proyecto
                {
                    Id = 10,
                    Nombre = "Proyecto 10",
                    Direccion = "Sarmiento 1888",
                    IdEstado = 1,
                    Active = true
                },
                new Proyecto
                {
                    Id = 11,
                    Nombre = "Proyecto 11",
                    Direccion = "Gutierrez 4011",
                    IdEstado = 2,
                    Active = true
                },
                new Proyecto
                {
                    Id = 12,
                    Nombre = "Proyecto 12",
                    Direccion = "Avenida Corrientes 6200",
                    IdEstado = 3,
                    Active = true
                }
                
            );
        }
    }
}