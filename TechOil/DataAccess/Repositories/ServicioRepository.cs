using Microsoft.EntityFrameworkCore;
using TechOil.DataAccess.Repositories.Interfaces;
using TechOil.Models;

namespace TechOil.DataAccess.Repositories;

public class ServicioRepository  : Repository<Servicio>, IServicioRepository
{
    public ServicioRepository(TechOilDbContext context) : base(context)
    {
        
    }

    public override async Task<List<Servicio>> GetAllActive()
    {
        var activeServices = await _context.Servicios.Where(x => x.Estado == true).ToListAsync();
        return activeServices;
    }
    
    //Update no modifica el estado (el estado lo considero como baja logica)
    public override async Task<bool> Update(Servicio dto)
    {
        var servicio = await _context.Servicios.FirstOrDefaultAsync(x => x.Id == dto.Id);
        if (servicio == null) {return false;}
        
        servicio.Descripcion = dto.Descripcion;
        servicio.ValorHora = dto.ValorHora;


        _context.Servicios.Update(servicio);
        return true;
    }
    
    public override async Task<bool> HardDelete(int id)
    {
        var servicio = await _context.Servicios.Where(x => x.Id == id).FirstOrDefaultAsync();
        if (servicio != null)
        {
            _context.Servicios.Remove(servicio);
            return true;
        }
        else
        {
            return false;
        }

    }
    
    public override async Task<bool> SoftDelete(int id)
    {
        var servicio = await _context.Servicios.FirstOrDefaultAsync(x => x.Id == id);
        if (servicio == null) { return false; }

        servicio.Estado = false;

        _context.Servicios.Update(servicio);
        return true;
    }
    
    
}