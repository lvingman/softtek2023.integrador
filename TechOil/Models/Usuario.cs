using TechOil.DataAccess;

namespace TechOil.Models;
using TechOil.DTO;
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
        Tipo = dto.Tipo;
        Email = dto.Email;
        Contrasena = dto.Contrasena;
    }

    /// <summary>
    /// Constructor de Usuario con DTO para registro
    /// </summary>
    /// <param name="dto">Datos de registro</param>
    public Usuario(UsuarioDTO dto)
    {
        Nombre = dto.Nombre;
        Dni = dto.Dni;
        Tipo = dto.Tipo;
        Email = dto.Email;
        Contrasena = dto.Contrasena;
    }
    
/// <summary>
/// Constructor vacio (SIEMPRE SE COLOCA CUANDO SE INGRESA
/// UN NUEVO CONSTRUCTOR, SI NO SE ROMPEN LOS PROGRAMAS)
/// </summary>
    public Usuario()
    {
        
    }
    
    public int Id { get; set; }
    public string Nombre { get; set; }
    public int Dni { get; set; }
    public int Tipo { get; set; }
    public string Contrasena { get; set; }
    public string Email { get; set; }
    

}