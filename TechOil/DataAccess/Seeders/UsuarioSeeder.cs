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
                    //Encripta la contrase�a al generarse
                    Contrasena = PasswordEncryptHelper.EncryptPassword("1234", "test@test.org"),
                    Email = "test@test.org",
                    Active = true,
                },
                new Usuario
                {
                    Id = 2,
                    Nombre = "testuser",
                    Dni = 41024562,
                    IdRol = 2,
                    //Encripta la contrase�a al generarse
                    Contrasena = PasswordEncryptHelper.EncryptPassword("2222", "test2@test.org"),
                    Email = "test2@test.org",
                    Active = true,
                }
            );
        }
    }
}

