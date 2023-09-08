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

    public async Task<Usuario?> AuthenticateCredentials(AutenticacionDTO dto)
    {
        return await _context.Usuarios.SingleOrDefaultAsync(x => x.Email == dto.Email && x.Contrasena == dto.Contrasena);
    }
    
}