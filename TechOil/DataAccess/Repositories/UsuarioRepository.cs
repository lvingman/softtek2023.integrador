using Microsoft.EntityFrameworkCore;
using TechOil.Models;
using TechOil.DataAccess.Repositories;
using TechOil.DataAccess.Repositories.Interfaces;
using TechOil.DTO;
using TechOil.Helper;

namespace TechOil.DataAccess.Repositories;

public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
{
    public UsuarioRepository(TechOilDbContext context) : base(context)
    {
        
    }


    public override async Task<List<Usuario>> GetAllActive()
    {
        var activeUsers = await _context.Usuarios.Where(x => x.Active == true).ToListAsync();
        return activeUsers;
    }

    public override async Task<bool> Update(Usuario dto)
    {
        var usuario = await _context.Usuarios.FirstOrDefaultAsync(x => x.Id == dto.Id);
        if (usuario == null) {return false;}

        usuario.Nombre = dto.Nombre;
        usuario.Contrasena = dto.Contrasena;
        usuario.Email = dto.Email;
        usuario.Dni = dto.Dni;
        usuario.IdRol = dto.IdRol;

        _context.Usuarios.Update(usuario);
        return true;
    }

    public override async Task<bool> HardDelete(int id)
    {
        var user = await _context.Usuarios.Where(x => x.Id == id).FirstOrDefaultAsync();
        if (user != null)
        {
            _context.Usuarios.Remove(user);
        }

        return true;
    }
    
    public override async Task<bool> SoftDelete(int id)
    {
        var usuario = await _context.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        if (usuario == null) { return false; }

        usuario.Active = false;

        _context.Usuarios.Update(usuario);
        return true;
    }

    public async Task<Usuario?> AuthenticateCredentials(AutenticacionDTO dto)
    {
        return await _context.Usuarios.Include(x => x.Rol).SingleOrDefaultAsync
            (x => x.Email == dto.Email && x.Contrasena == PasswordEncryptHelper.EncryptPassword(dto.Contrasena, dto.Email));
    }
    
}