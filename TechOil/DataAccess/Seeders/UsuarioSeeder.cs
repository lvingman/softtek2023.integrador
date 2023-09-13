using Microsoft.EntityFrameworkCore;
using TechOil.Helper;
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
                    IdRol = 1,
                    //Encripta la contraseña al generarse
                    Contrasena = PasswordEncryptHelper.EncryptPassword("1234"),
                    Email = "test@test.org",
                    Active = true,
                }
            );
        }
    }
}

