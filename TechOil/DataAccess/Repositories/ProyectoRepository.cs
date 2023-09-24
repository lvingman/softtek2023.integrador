using Microsoft.EntityFrameworkCore;
using TechOil.DataAccess.Repositories.Interfaces;
using TechOil.Models;

namespace TechOil.DataAccess.Repositories;

public class ProyectoRepository : Repository<Proyecto>, IProyectoRepository
{
    public ProyectoRepository(TechOilDbContext context) : base(context)
    {
        
    }

    public async Task<List<Proyecto>> FindByStatus(int status)
    {
        var activeProyectos = await _context.Proyectos.Where(x => x.IdEstado == status).ToListAsync();
        return activeProyectos;
    }
    
    public override async Task<List<Proyecto>> GetAllActive()
    {
        var activeProyectos = await _context.Proyectos.Where(x => x.Active == true).ToListAsync();
        return activeProyectos;
    }
    
    //Update no modifica el estado (el estado lo considero como baja logica)
    public override async Task<bool> Update(Proyecto dto)
    {
        var proyecto = await _context.Proyectos.FirstOrDefaultAsync(x => x.Id == dto.Id);
        if (proyecto == null) {return false;}
        
        proyecto.Nombre = dto.Nombre;
        proyecto.Direccion = dto.Direccion;
        proyecto.IdEstado = dto.IdEstado;
        
        _context.Proyectos.Update(proyecto);
        return true;
    }
    
    public override async Task<bool> HardDelete(int id)
    {
        var proyecto = await _context.Proyectos.Where(x => x.Id == id).FirstOrDefaultAsync();
        if (proyecto != null)
        {
            _context.Proyectos.Remove(proyecto);
            return true;
        }
        else
        {
            return false;
        }

    }
    
    public override async Task<bool> SoftDelete(int id)
    {
        var proyecto = await _context.Proyectos.FirstOrDefaultAsync(x => x.Id == id);
        if (proyecto == null) { return false; }

        proyecto.Active = false;

        _context.Proyectos.Update(proyecto);
        return true;
    }
}