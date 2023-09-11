using Microsoft.EntityFrameworkCore;
using TechOil.Models;
using TechOil.DataAccess.Repositories;
using TechOil.DataAccess.Repositories.Interfaces;
using TechOil.DTO;

namespace TechOil.DataAccess.Repositories;

public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
{
    public UsuarioRepository(TechOilDbContext context) : base(context)
    {
        
    }

    public override async Task<bool> Update(Usuario dto)
    {
        var usuario = await _context.Usuarios.FirstOrDefaultAsync(x => x.Id == dto.Id);
        if (usuario == null) {return false;}

        usuario.Nombre = dto.Nombre;
        usuario.Contrasena = dto.Contrasena;
        usuario.Email = dto.Email;
        usuario.Dni = dto.Dni;
        usuario.Tipo = dto.Tipo;

        _context.Usuarios.Update(usuario);
        return true;
    }
    
    public async Task<Usuario?> AuthenticateCredentials(AutenticacionDTO dto)
    {
        return await _context.Usuarios.SingleOrDefaultAsync
            (x => x.Email == dto.Email && x.Contrasena == dto.Contrasena);
    }
    
}