using Microsoft.EntityFrameworkCore;
using TechOil.DataAccess.Repositories.Interfaces;
using TechOil.Models;

namespace TechOil.DataAccess.Repositories
{
    public class TrabajoRepository : Repository<Trabajo>, ITrabajoRepository
    {
        public TrabajoRepository(TechOilDbContext context) : base(context)
        {

        }

        public override async Task<List<Trabajo>> GetAllActive()
        {
            var activeJobs = await _context.Trabajos.Where(x => x.Active == true).ToListAsync();
            return activeJobs;
        }

        //Update no modifica el estado (el estado lo considero como baja logica)
        public override async Task<bool> Update(Trabajo dto)
        {
            var trabajo = await _context.Trabajos.FirstOrDefaultAsync(x => x.Id == dto.Id);
            if (trabajo == null) { return false; }
            
            trabajo.Fecha = dto.Fecha;
            trabajo.IdProyecto = dto.IdProyecto;
            trabajo.IdServicio = dto.IdServicio;
            trabajo.CantidadHoras = dto.CantidadHoras;
            trabajo.ValorHora = dto.ValorHora;
            trabajo.Costo = dto.Costo;


            _context.Trabajos.Update(trabajo);
            return true;
        }

        public override async Task<bool> HardDelete(int id)
        {
            var trabajo = await _context.Trabajos.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (trabajo != null)
            {
                _context.Trabajos.Remove(trabajo);
            }

            return true;
        }

        public override async Task<bool> SoftDelete(int id)
        {
            var trabajo = await _context.Trabajos.FirstOrDefaultAsync(x => x.Id == id);
            if (trabajo == null) { return false; }

            trabajo.Active = false;

            _context.Trabajos.Update(trabajo);
            return true;
        }


    }
}
