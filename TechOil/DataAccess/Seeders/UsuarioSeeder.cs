using Microsoft.EntityFrameworkCore;
using TechOil.Models;


namespace TechOil.DataAccess.Seeders
{
    public class UsuarioSeeder : IEntitySeeder
    {
        public void SeedDatabase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario
                {
                    Id = 1,
                    Nombre = "rmartin",
                    Dni = 41024562,
                    Tipo = 1,
                    Contrasena = "1234"
                }
            );
        }
    }
}

