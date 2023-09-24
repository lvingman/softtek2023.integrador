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
                    Nombre = "admin",
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
                    Nombre = "consultor1",
                    Dni = 2123422,
                    IdRol = 2,
                    //Encripta la contrase�a al generarse
                    Contrasena = PasswordEncryptHelper.EncryptPassword("2222", "test2@test.org"),
                    Email = "test2@test.org",
                    Active = true,
                },
                new Usuario
                {
                    Id = 3,
                    Nombre = "consultor2",
                    Dni = 40412401,
                    IdRol = 2,
                    //Encripta la contrase�a al generarse
                    Contrasena = PasswordEncryptHelper.EncryptPassword("1111", "test3@test.org"),
                    Email = "test3@test.org",
                    Active = true,
                },
                new Usuario
                {
                    Id = 4,
                    Nombre = "consultor3",
                    Dni = 33101222,
                    IdRol = 2,
                    //Encripta la contrase�a al generarse
                    Contrasena = PasswordEncryptHelper.EncryptPassword("3333", "test4@test.org"),
                    Email = "test4@test.org",
                    Active = true,
                },
                new Usuario
                {
                    Id = 5,
                    Nombre = "consultor4",
                    Dni = 11111111,
                    IdRol = 2,
                    //Encripta la contrase�a al generarse
                    Contrasena = PasswordEncryptHelper.EncryptPassword("4444", "test5@test.org"),
                    Email = "test5@test.org",
                    Active = true,
                }, 
                new Usuario
                {
                    Id = 6,
                    Nombre = "consultor5",
                    Dni = 22111222,
                    IdRol = 2,
                    //Encripta la contrase�a al generarse
                    Contrasena = PasswordEncryptHelper.EncryptPassword("5555", "test6@test.org"),
                    Email = "test6@test.org",
                    Active = true,
                },    
                new Usuario
                {
                    Id = 7,
                    Nombre = "consultor6",
                    Dni = 33333111,
                    IdRol = 2,
                    //Encripta la contrase�a al generarse
                    Contrasena = PasswordEncryptHelper.EncryptPassword("6363", "test7@test.org"),
                    Email = "test7@test.org",
                    Active = true,
                },                new Usuario
                {
                    Id = 8,
                    Nombre = "consultor7",
                    Dni = 12123123,
                    IdRol = 2,
                    //Encripta la contrase�a al generarse
                    Contrasena = PasswordEncryptHelper.EncryptPassword("7777", "test8@test.org"),
                    Email = "test8@test.org",
                    Active = true,
                },          
                new Usuario
                {
                    Id = 9,
                    Nombre = "consultor8",
                    Dni = 22333222,
                    IdRol = 2,
                    //Encripta la contrase�a al generarse
                    Contrasena = PasswordEncryptHelper.EncryptPassword("8888", "test9@test.org"),
                    Email = "test9@test.org",
                    Active = true,
                },        
                new Usuario
                {
                    Id = 10,
                    Nombre = "consultor9",
                    Dni = 22111333,
                    IdRol = 2,
                    //Encripta la contrase�a al generarse
                    Contrasena = PasswordEncryptHelper.EncryptPassword("9999", "test10@test.org"),
                    Email = "test10@test.org",
                    Active = true,
                },           
                new Usuario
                {
                    Id = 11,
                    Nombre = "consultor10",
                    Dni = 22222111,
                    IdRol = 2,
                    //Encripta la contrase�a al generarse
                    Contrasena = PasswordEncryptHelper.EncryptPassword("1000", "test11@test.org"),
                    Email = "test11@test.org",
                    Active = true,
                },            
                new Usuario
                {
                    Id = 12,
                    Nombre = "consultor11",
                    Dni = 11333555,
                    IdRol = 2,
                    //Encripta la contrase�a al generarse
                    Contrasena = PasswordEncryptHelper.EncryptPassword("2000", "test12@test.org"),
                    Email = "test12@test.org",
                    Active = true,
                },             
                new Usuario
                {
                    Id = 13,
                    Nombre = "consultor12",
                    Dni = 40412412,
                    IdRol = 2,
                    //Encripta la contrase�a al generarse
                    Contrasena = PasswordEncryptHelper.EncryptPassword("3000", "test13@test.org"),
                    Email = "test13@test.org",
                    Active = true,
                }
            );
        }
    }
}

