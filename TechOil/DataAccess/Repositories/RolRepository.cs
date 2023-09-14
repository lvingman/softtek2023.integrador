using Microsoft.EntityFrameworkCore;
using TechOil.DataAccess.Repositories.Interfaces;
using TechOil.DataAccess.Repositories;
using TechOil.Models;
using Microsoft.AspNetCore.Mvc;

namespace TechOil.DataAccess.Repositories
{
    public class RolRepository : Repository<Rol>, IRolRepository
    {

        public RolRepository(TechOilDbContext context) : base(context)
        {
        }
        
        public override async Task<List<Rol>> GetAllActive()
        {
            var rolesActivos = await _context.Roles.Where(x => x.Active == true).ToListAsync();
            return rolesActivos;
        }
        
        
        public override async Task<bool> SoftDelete(int id)
        {
            var rol = await _context.Roles.FirstOrDefaultAsync(x => x.Id == id);
            if (rol == null) { return false; }

            rol.Active = false;

            _context.Roles.Update(rol);
            return true;
        }
        

        public override async Task<bool> Update(Rol updateRole)
        {
            var Role = await _context.Roles.FirstOrDefaultAsync(x => x.Id == updateRole.Id);
            if (Role == null) { return false; }

            Role.Nombre = updateRole.Nombre;
            Role.Descripcion = updateRole.Descripcion;
            Role.Active = updateRole.Active;

            _context.Roles.Update(Role);
            return true;
        }

        public override async Task<bool> HardDelete(int id)
        {
            var Role = await _context.Roles.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (Role != null)
            {
                _context.Roles.Remove(Role);
            }

            return true;
        }


    }
}