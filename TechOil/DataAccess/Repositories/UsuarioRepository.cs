using TechOil.Models;
using TechOil.DataAccess.Repositories;
using TechOil.DataAccess.Repositories.Interfaces;

namespace TechOil.DataAccess.Repositories;

public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
{
    public UsuarioRepository(TechOilDbContext context) : base(context)
    {
        
    }
}