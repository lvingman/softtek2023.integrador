using Microsoft.EntityFrameworkCore;
using TechOil.DataAccess.Repositories.Interfaces;

namespace TechOil.DataAccess.Repositories
{

    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly TechOilDbContext _context;

        public Repository(TechOilDbContext context)
        {
            _context = context;
        }

        public virtual async Task<List<T>> GetAll()
        {   
            return await _context.Set<T>().ToListAsync();
        }
        
    }
        
}
