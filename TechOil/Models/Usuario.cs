using TechOil.DataAccess;

namespace TechOil.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

using System.ComponentModel.DataAnnotations;
using TechOil.DTO;
using System.ComponentModel;
using TechOil.Helper;
using Microsoft.AspNetCore.Identity;

public class Usuario
{
    /// <summary>
    /// Constructor de Usuario con DTO para modificacion
    /// </summary>
    /// <param name="dto">Datos nuevos</param>
    /// <param name="id">ID usuario a modificar</param>
    public Usuario(UsuarioDTO dto, int id)
    {
        Id = id;
        Nombre = dto.Nombre;
        Dni = dto.Dni;
        IdRol = dto.IdRol;
        Email = dto.Email;
        Contrasena = PasswordEncryptHelper.EncryptPassword(dto.Contrasena, dto.Email);
    }

    /// <summary>
    /// Constructor de Usuario con DTO para registro
    /// </summary>
    /// <param name="dto">Datos de registro</param>
    public Usuario(UsuarioDTO dto)
    {
        Nombre = dto.Nombre;
        Dni = dto.Dni;
        IdRol = dto.IdRol;
        Email = dto.Email;
        Contrasena = PasswordEncryptHelper.EncryptPassword(dto.Contrasena, dto.Email);
        Active = true;
    }   

    /// <summary>
    /// Constructor vacio (SIEMPRE SE COLOCA CUANDO SE INGRESA
    /// UN NUEVO CONSTRUCTOR, SI NO SE ROMPEN LOS PROGRAMAS)
    /// </summary>
    public Usuario()
    {
        
    }

    [Required]
    public int Id { get; set; }
    [Required]
    [Column("Nombre", TypeName = "VARCHAR(50)")]
    public string Nombre { get; set; }
    [Required]
    [Column("Dni", TypeName = "VARCHAR(10)")]
    public int Dni { get; set; }
    [Required]
    [ForeignKey("Rol")]
    public int IdRol { get; set; }
    public Rol? Rol { get; set; }
    [Required]
    [Column("Contrasena", TypeName = "VARCHAR(64)")]
    public string Contrasena { get; set; }
    [Required]
    [Column("Email", TypeName = "VARCHAR(50)")]
    public string Email { get; set; }
    [Column("Active", TypeName = "bit")]
    [DefaultValue(true)]
    public bool Active { get; set; }
    

}