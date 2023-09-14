using TechOil.DataAccess;
using TechOil.DataAccess.Repositories;

namespace TechOil.Services;

public class UnitOfWorkService : IUnitOfWork
{
    private readonly TechOilDbContext _context;
    
    public UsuarioRepository UsuarioRepository { get; private set; }

    public UnitOfWorkService(TechOilDbContext context)
    {
        _context = context;
        UsuarioRepository = new UsuarioRepository(_context);
    }
    
    public Task<int> Complete()
    {
        return _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}